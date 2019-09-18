using LikdensClinic.Model;
using LikdensClinic.View;
using System;
using System.Windows.Forms;

namespace LikdensClinic.Presenter
{
    class MainPresenter : IMainPresenter
    {
        private readonly IMainModel _model;
        private readonly IMainView _view;

        public MainPresenter(IMainModel model, IMainView view)
        {
            try
            {
                this._model = model;
                this._view = view;

                this._view.OpenPatient += (string idPatient) => this.OpenPatient(idPatient);
                this._view.FormLoad += () => this.FormLoad();
                this._view.RefreshData += () => this.Refresh();
            }
            catch (Exception ex)
            {
                _view.ShowError(ex.ToString());
            }
        }

        public void Refresh()
        {
            this._view.WaitCursor(true);
            this._model.RefreshData();
            this._view.InitialiseForPatientsPanels();
            this._view.WaitCursor(false);
        }

        public void Run()
        {
            do
            {
                try
                {
                    this._view.WaitCursor(true);
                    this._model.RefreshData();
                    this._view.WaitCursor(false);
                    this._view.ShowForm();
                    return;
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    if (MessageBox.Show($"ERROR: {ex.Message}", "Помилка підключення до бази данних!", MessageBoxButtons.RetryCancel) == DialogResult.Cancel)
                    {
                        return;
                    }
                }
                catch (Exception ex)
                {
                    this._view.ShowError(ex.ToString());
                    return;
                }
                finally
                {
                    
                }
            } while (true);
        }
        public void OpenPatient(string idPatient)
        {
            try
            {
                IPatientPresenter presenter = new PatientPresenter(new PatientModel(), new PatientView());
                if (presenter != null)
                    presenter.Run(idPatient);
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show($"ERROR: {ex.Message}", "Помилка підключення до бази данних!", MessageBoxButtons.OK);
                return;
            }
            catch (Exception ex)
            {
                this._view.ShowError(ex.ToString());
            }
        }

        public void FormLoad()
        {
            try
            {
                this._view._dataSet = this._model._dataSet;
            }
            catch (Exception ex)
            {
                this._view.ShowError(ex.ToString());
            }
        }
    }
}
