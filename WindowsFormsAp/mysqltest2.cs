using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAp
{
    public partial class mysqltest2 : Form
    {
        public mysqltest2()
        {
            InitializeComponent();
            Load += Mysqltest2_Load;
        }

        private void Mysqltest2_Load(object sender, EventArgs e)
        {
            string host = "(localdb)\\ProjectsV13";
            string user = "root";
            string password = "1234";
            string db = "gdc";

            string connStr = string.Format("Data Source = {0}; Initial Catalog = {3}; Persist Security Info = False; User ID = {1};Password = {2}; Pooling = False; MultipleActiveResultSets = False; Encrypt = False; TrustServerCertificate = True", host, user, password, db);
           
            SqlConnection conn = new SqlConnection(connStr);

            try
            {
                conn.Open(); //데이터베이스 연결
                MessageBox.Show("연결되었습니다.");
            }
            catch
            {
                conn.Close(); // 데이터베이스 
                MessageBox.Show("연결을 실패하였습니다.");
            }
        }
    }
}
