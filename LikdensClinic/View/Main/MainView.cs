using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace LikdensClinic.View
{
    public partial class MainView : Form, IMainView
    {
        #region Members
        public DataSet _dataSet { get; set; }
        public List<string> _idSelectedPatients { get; set; }
        public Size sizePanel = new Size(350, 200);
        public Font fontPanel = new Font("Arial", 14, FontStyle.Bold);
        public Padding padingPanel = new Padding(50,0,0,50);
        #endregion

        #region Event
        public event Action FormLoad = delegate { };
        public event Action SaveData = delegate { };
        public event Action RefreshData = delegate { };
        public event Action CloseForm = delegate { };
        public event Action<List<string>> DeletePatient = delegate { };
        public event Action<string> OpenPatient = delegate { };
        #endregion

        #region Constructors
        public MainView()
        {
            InitializeComponent();
        }
        #endregion

        #region Methods
        
        #region Methods of interface
        public void ShowForm()
        {
            this.WindowState = FormWindowState.Maximized;
            this.FormClosing += MainView_FormClosing;

            Application.Run(this);
        }

        public void ShowError(string errorMessage)
        {
            MessageBox.Show(errorMessage, "Непередбачена помилка!");
        }

        public void InitialiseForPatientsPanels()
        {
            int count = Convert.ToInt32(_dataSet?.Tables["patient"].Rows.Count);
            this.flwLytPnlMain.Controls.Clear();
            for (int j = 0; j < 10; j++)
            {
                this.flwLytPnlMain.Controls.Add(GetCastomPanel(_dataSet?.Tables["patient"]?.Rows[j]));
            }
        }

        public TableLayoutPanel GetCastomPanel(DataRow row = null)
        {
            if (row != null)
            {
                TableLayoutPanel panel = new TableLayoutPanel()
                {
                    ColumnCount = 1,
                    RowCount = 6,
                    MaximumSize = this.sizePanel,
                    MinimumSize = this.sizePanel,
                    Font = this.fontPanel,
                    BackColor = Color.Aqua,
                    BorderStyle = BorderStyle.FixedSingle
                };

                FlowLayoutPanel flwLayPanLName = new FlowLayoutPanel();
                flwLayPanLName.AutoSize = true;
                flwLayPanLName.Controls.Add(new Label() { AutoSize = true, Text = "Прізвище:" });
                flwLayPanLName.Controls.Add(new Label() { AutoSize = true, Text = row?["last_name"]?.ToString() });

                FlowLayoutPanel flwLayPanFName = new FlowLayoutPanel();
                flwLayPanFName.AutoSize = true;
                flwLayPanFName.Controls.Add(new Label() { AutoSize = true, Text = "Ім'я:" });
                flwLayPanFName.Controls.Add(new Label() { AutoSize = true, Text = row?["first_name"]?.ToString() });

                FlowLayoutPanel flwLayPanMName = new FlowLayoutPanel();
                flwLayPanMName.AutoSize = true;
                flwLayPanMName.Controls.Add(new Label() { AutoSize = true, Text = "По батькові:" });
                flwLayPanMName.Controls.Add(new Label() { AutoSize = true, Text = row?["middle_name"]?.ToString() });

                FlowLayoutPanel flwLayPanPhone = new FlowLayoutPanel();
                flwLayPanPhone.AutoSize = true;
                flwLayPanPhone.Controls.Add(new Label() { AutoSize = true, Text = "Телефон:" });
                flwLayPanPhone.Controls.Add(new Label() { Name = "phone_number", AutoSize = true, Text = row?["phone_number"]?.ToString() });

                FlowLayoutPanel flwLayPanDateOfBirth = new FlowLayoutPanel();
                flwLayPanDateOfBirth.AutoSize = true;
                flwLayPanDateOfBirth.Controls.Add(new Label() { AutoSize = true, Text = "Дата народження:" });
                flwLayPanDateOfBirth.Controls.Add(new Label() { AutoSize = true, Text = DateTime.Parse(row?["date_of_birth"]?.ToString()).ToShortDateString() });

                FlowLayoutPanel flwLayPanAdres = new FlowLayoutPanel();
                flwLayPanAdres.AutoSize = true;
                flwLayPanAdres.Controls.Add(new Label() { AutoSize = true, Text = "Домашня адреса:" });
                flwLayPanAdres.Controls.Add(new Label() { AutoSize = true, Text = row?["home_address"]?.ToString() });

                panel.Controls.AddRange(new Control[] { flwLayPanLName,
                                                        flwLayPanFName,
                                                        flwLayPanMName,
                                                        flwLayPanPhone,
                                                        flwLayPanDateOfBirth,
                                                        flwLayPanAdres
                });
                panel.Margin = padingPanel;

                return panel;
            }
            return null;
        }

        public void WaitCursor(bool yesOrNo)
        {

            this.Cursor = yesOrNo ? Cursors.WaitCursor : Cursors.Default;
        }
        #endregion

        #region Methods of events
        private void MainView_Load(object sender, EventArgs e)
        {
            this.FormLoad();
            InitialiseForPatientsPanels();
        }

        private void MainView_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseForm();
        }
        #endregion

        #region Methods of buttons
        private void відкритиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_idSelectedPatients?.Count == 1)
                OpenPatient(_idSelectedPatients[0]);
        }

        private void видалитиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.DeletePatient(_idSelectedPatients);
        }
        private void зареєструватиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void оновитиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        #endregion

        #endregion
    }
}
