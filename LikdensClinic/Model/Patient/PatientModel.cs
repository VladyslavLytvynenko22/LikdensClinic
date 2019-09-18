using LikdensClinic.Database;
using System.Data;

namespace LikdensClinic.Model
{
    class PatientModel : IPatientModel
    {
        public DataSet _dataSet { get; private set; }
        public string _idPatient { get; set; }

        public void RefreshData()
        {
            this._dataSet = DBUtils.GetPatientDataFromTableByID("patient", this._idPatient);
        }
    }
}
