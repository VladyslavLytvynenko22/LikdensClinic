using LikdensClinic.Model;
using LikdensClinic.View;
using System;
using System.Windows.Forms;

namespace LikdensClinic.Presenter
{
    class PatientPresenter : IPatientPresenter
    {
        private readonly IPatientModel _model;
        private readonly IPatientView _view;

        public PatientPresenter(IPatientModel model, IPatientView view)
        {
            try
            {
                this._model = model;
                this._view = view;

                this._view.FormLoad += () => this.FormLoad();
            }
            catch (Exception ex)
            {
                this._view.ShowError(ex.ToString());
            }
        }
        public void Run(string idPatient)
        {
            try
            {
                this._model._idPatient = idPatient;
                this._model.RefreshData();
                this._view.ShowForm();
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

        public void Refresh()
        {
            //code
        }
    }
}
