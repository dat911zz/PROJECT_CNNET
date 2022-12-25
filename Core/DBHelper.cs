using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
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
            connStr = @"Data Source=(localdb)\Local;Initial Catalog=BookStore;Integrated Security=True";
            //connStr = "Data Source=sql5080.site4now.net;Initial Catalog=db_a9156e_n8bookstore;Persist Security Info=True;User ID=db_a9156e_n8bookstore_admin;Password=ez4XqR6@QrhhzCu";
            //ez4XqR6@QrhhzCu
        }
        #region Utilities
        /// <summary>
        /// Add params with prefix: @p_{0} ({0} is integer start from 0)
        /// </summary>
        /// <param name="cmd"></param>
        /// <param name="obj"></param>
        public void AddParameters(ref SqlCommand cmd, object[] obj)
        {
            int paramsLenth = obj.Length;
            for (int i = 0; i < paramsLenth; i++)
            {
                cmd.Parameters.AddWithValue("@p_" + i.ToString(), obj[i]);
            }
        }
        public void AddParameters(ref SqlCommand cmd, Dictionary<string, object> mapParams)
        {
            foreach (var param in mapParams)
            {
                cmd.Parameters.AddWithValue(param.Key, param.Value);
            }
        }
        private void BeginTransact(Action<SqlCommand> action)
        {
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            action(cmd);
            conn.Close();
        }
        public int ExceuteNonQuery(string query, params object[] obj)
        {
            int result = 0;
            BeginTransact(cmd =>
            {
                cmd.CommandText = query;
                if (obj != null)
                {
                    AddParameters(ref cmd, obj);
                }
                result = cmd.ExecuteNonQuery();
            });
            return result;
        }
        public int ExceuteNonQuery(string query, Dictionary<string, object> mapParams)
        {
            int result = 0;
            BeginTransact(cmd =>
            {
                cmd.CommandText = query;
                if (mapParams != null)
                {
                    AddParameters(ref cmd, mapParams);
                }
                result = cmd.ExecuteNonQuery();
            });
            return result;
        }
        public int ExceuteScalar(string query, params object[] obj)
        {
            int result = 0;
            BeginTransact(cmd =>
            {
                cmd.CommandText = query;
                if (obj != null)
                {
                    AddParameters(ref cmd, obj);
                }
                result = (int)cmd.ExecuteScalar();
            });
            return result;
        }
        public int ExceuteScalar(string query, Dictionary<string, object> mapParams)
        {
            int result = 0;
            BeginTransact(cmd =>
            {
                cmd.CommandText = query;
                if (mapParams != null)
                {
                    AddParameters(ref cmd, mapParams);
                }
                result = (int)cmd.ExecuteScalar();
            });
            return result;
        }
        public List<T> ExecuteReader<T>(string query, params object[] obj) where T : class, new()//Attribute for avoid normal data type
        {
            List<T> list = new List<T>();
            BeginTransact(cmd =>
            {
                cmd.CommandText = query;
                if (obj != null)
                {
                    AddParameters(ref cmd, obj);
                }
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    T item = new T();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        PropertyInfo propertyInfo = typeof(T).GetProperty(reader.GetName(i));
                        if (propertyInfo != null)
                        {
                            propertyInfo.SetValue(item, reader.GetValue(i));
                        }
                    }
                    list.Add(item);
                }
            });
            return list;
        }
        public List<T> ExecuteReader<T>(string query, Dictionary<string, object> mapParams) where T : class, new()
        {
            List<T> list = new List<T>();
            BeginTransact(cmd =>
            {
                cmd.CommandText = query;
                if (mapParams != null)
                {
                    AddParameters(ref cmd, mapParams);
                }
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    T item = new T();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        PropertyInfo propertyInfo = typeof(T).GetProperty(reader.GetName(i));
                        if (propertyInfo != null)
                        {
                            propertyInfo.SetValue(item, reader.GetValue(i));
                        }
                    }
                    list.Add(item);
                }
            });
            return list;
        }
        public void FillData(DataSet dataSet, string selectCmd, string tableName)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(selectCmd, connStr);
            adapter.Fill(dataSet, tableName);
        }
        public void LoadDataIntoCbo(ComboBox cbo, DataSet dataSet, string tableName, string display, string value)
        {
            string selectCmd = "Select * from " + tableName;
            FillData(dataSet, selectCmd, tableName);
            cbo.DataSource = dataSet.Tables[tableName];
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
        }
        public void LoadDataIntoDgv(DataGridView dgv, DataSet dataSet, string tableName)
        {
            string selectCmd = "Select * from " + tableName;
            FillData(dataSet, selectCmd, tableName);
            dgv.DataSource = dataSet.Tables[tableName];
        }
        public int Update(DataSet ds, string tableName)
        {
            string selectCmd = "Select * from " + tableName;
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
        public void SetPrimaryKey(ref DataTable dt, params object[] mapKeys)
        {
            DataColumn[] keys = new DataColumn[mapKeys.Length];
            for (int i = 0; i < mapKeys.Length; i++)
            {
                keys[i] = dt.Columns[mapKeys[i].ToString()];
            }
            dt.PrimaryKey = keys;
        }
        #endregion
    }
}
