using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace LikdensClinic.View
{
    public partial class PatientView : Form, IPatientView
    {
        #region Members
        public DataSet _dataSet { get; set; }
        #endregion

        #region Event
        public event Action FormLoad = delegate { };
        public event Action SaveData = delegate { };
        public event Action RefreshData = delegate { };
        public event Action CloseForm = delegate { };
        public event Action<List<string>> DeletePatient = delegate { };
        #endregion

        #region Constructors
        public PatientView()
        {
            InitializeComponent();
        }
        #endregion

        #region Methods

        #region Methods of DataGrid
        #endregion

        #region Methods of interface
        public void ShowForm()
        {
            this.FormClosing += PatientView_FormClosing;
            
            this.Show();
        }

        public void ShowError(string errorMessage)
        {
            MessageBox.Show(errorMessage);
        }

        public void WaitCursor(bool yesOrNo)
        {

            this.Cursor = yesOrNo ? Cursors.WaitCursor : Cursors.Default;
        }
        #endregion

        #region Methods of events
        private void PatientView_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
        #endregion

        #region Methods of buttons
        #endregion

        #endregion

        private void PatientView_Load(object sender, EventArgs e)
        {
            FormLoad();
            this.txtBoxFirstName.DataBindings.Add(new Binding("Text", this._dataSet.Tables["patient"], "first_name"));
            this.txtBoxLastName.DataBindings.Add(new Binding("Text", this._dataSet.Tables["patient"], "last_name"));
        }
    }
}
