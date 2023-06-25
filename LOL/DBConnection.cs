using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Windows;
using System.Data;

namespace Uneversity_Manager
{ 
    internal class DbConnection
    {
        public SqlConnection cnn { get; set; }
        public DbConnection()
        {
            try
            {
                cnn = new SqlConnection("Data Source = ALI; Initial Catalog = Uneversity_DB; Integrated Security = True");
                cnn.Open();
            }
            catch
            {
                MessageBox.Show("Error in Database Connection...");
            }
        }
        public void Disconnect()
        {
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
        }
    }
}

