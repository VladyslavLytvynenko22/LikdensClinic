using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace LikdensClinic.View
{
    interface IMainView : IView
    {
        List<string> _idSelectedPatients { get; set; }

        event Action<string> OpenPatient;

        TableLayoutPanel GetCastomPanel(DataRow row);
        void InitialiseForPatientsPanels();
    }
}
