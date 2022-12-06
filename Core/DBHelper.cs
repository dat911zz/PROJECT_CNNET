using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Core
{
    public class DBHelper
    {
        private string connStr;

        public string ConnStr { get => connStr; set => connStr = value; }
        public DBHelper()
        {
            connStr = "Data Source=DESKTOP-GUE0JS7;Initial Catalog=BookStore;Integrated Security=True";
        }
        public void FillData(DataSet dataSet, string selectCmd, string tableName)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(selectCmd, connStr);
            adapter.Fill(dataSet, tableName);
        }
        public void LoadDataIntoCbo(ComboBox cbo, DataSet dataSet, string selectCmd, string tableName, string display, string value)
        {
            FillData(dataSet, selectCmd, tableName);
            cbo.DataSource = dataSet.Tables[tableName];
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
        }
        public void LoadDataIntoDgv(DataGridView dgv, DataSet dataSet, string selectCmd, string tableName)
        {
            FillData(dataSet, selectCmd, tableName);
            dgv.DataSource = dataSet.Tables[tableName];
        }
        public int Update(DataSet ds, string selectCmd, string tableName)
        {
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(selectCmd, connStr);
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adapter);
                return adapter.Update(ds, tableName);
            }
            catch (Exception)
            {
                return 0;
            }

        }
    }
}
