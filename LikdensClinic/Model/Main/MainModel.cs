using LikdensClinic.Database;
using System.Data;

namespace LikdensClinic.Model
{
    class MainModel: IMainModel
    {
        public DataSet _dataSet { get; set; }
        public MainModel()
        {
        }

        public void RefreshData()
        {
            this._dataSet = DBUtils.GetAllDataFromTable("patient");
        }
    }
}
