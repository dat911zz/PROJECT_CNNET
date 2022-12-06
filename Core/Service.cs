using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Service
    {
        private readonly string rootPath = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + @"\BookStore.Sys";
        private static Service instance;
        private Service()
        {

        }

        public string RootPath => rootPath;

        public static Service Instance 
        { 
            get => instance ?? new Service(); 
            private set => instance = value; 
        }
    }
}
