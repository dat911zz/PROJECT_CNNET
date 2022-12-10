using Core.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Core
{
    public class Service
    {
        private readonly string rootPath = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + @"\BookStore.Sys";
        private static Service instance;
        private DBHelper db;
        private Service()
        {
            db = new DBHelper();
        }

        public string RootPath => rootPath;

        public static Service Instance
        {
            get => instance ?? new Service();
            private set => instance = value;
        }
        public bool CheckAccount(string username, string password)
        {
            try
            {
                string cmd = "select * from AccountEmployee";
                List<Account> accounts = db.ExecuteReader<Account>(cmd);
                var account = accounts.FirstOrDefault(x => x.Username.Equals(username));
                if (account != null)
                {
                    if (account.Password.Equals(password))
                    {
                        return true;
                    }
                    return false;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool CheckFormExist(string name)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Name.Equals(name))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
