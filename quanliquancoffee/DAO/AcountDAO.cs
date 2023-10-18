using quanliquancoffee.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanliquancoffee.DAO
{
    internal class AcountDAO
    {
        private static AcountDAO instance;

        public static AcountDAO Instance
        {
            get { if (instance == null) instance = new AcountDAO(); return instance; }
            private set { instance = value; }
        }
        private AcountDAO() { }

        public bool Login(string userName, string passWord)
        {
            string query = "USP_Login @userName , @passWord";
            DataTable result=DataProvider.Instance.ExecuteQuery(query,new object[] {userName ,passWord});
            return result.Rows.Count > 0; 
        }
    }
}