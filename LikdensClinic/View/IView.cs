using System;
using System.Collections.Generic;
using System.Data;

namespace LikdensClinic.View
{
    interface IView
    {
        DataSet _dataSet { get; set; }
        void ShowForm();
        void ShowError(string errorMessage);
        void WaitCursor(bool yesOrNo);

        event Action FormLoad;
        event Action SaveData;
        event Action RefreshData;
        event Action CloseForm;
        event Action<List<string>> DeletePatient;
    }
}
