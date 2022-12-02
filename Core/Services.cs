using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Services
    {
        private readonly string rootPath = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + @"\BookStore.Sys";
        private static Services instance;
        private Services()
        {

        }

        public string RootPath => rootPath;

        public static Services Instance 
        { 
            get => instance ?? new Services(); 
            private set => instance = value; 
        }
    }
}
