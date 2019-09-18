using MySql.Data.MySqlClient;
using System.Data;

namespace LikdensClinic.Model
{
    interface IModel
    {
        DataSet _dataSet { get; }
        void RefreshData();
    }
}
