using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Collections;
namespace WindowsFormsAp
{
    public partial class mysqltest : Form
    {
        public mysqltest()
        {
            InitializeComponent();
            Load += Mysqltest_Load;
        }
        MySqlConnection conn;
        private void Mysqltest_Load(object sender, EventArgs e)
        {
            string host = "myDB";
            string user = "root";
            string password = "1234";
            string db = "gdc";

            string connStr = string.Format(@"server={0};user={1};password={2};database={3}",host, user, password, db); // 접속할 때 사용할 전체 정보
            conn = new MySqlConnection(connStr); // 데이터베이스 접속 정보 생성
            
           
        }
        
        private void btn_Event(object s, EventArgs e)
        {
            try
            {
                conn.Open(); //데이터베이스 연결
                MessageBox.Show("연결되었습니다.");
                string sql = textBox1.Text;
                MySqlCommand comm = new MySqlCommand(sql, conn);
                MySqlDataReader reader = comm.ExecuteReader(); // insert 부분
                ArrayList arr = new ArrayList();
                while (reader.Read()) // 위에서부터 하나씩 읽는다는 의미
                {
                    Hashtable ht = new Hashtable();
                    ht.Add("no", reader[0]);
                    ht.Add("name", reader[1]);
                    arr.Add(ht);
                    /*
                    ListViewItem item = new ListViewItem((reader.GetInt32(0).ToString()));
                    item.SubItems.Add(reader.GetString(1));
                    listView1.Items.Add(item);
                    */
                }
                foreach(Hashtable row in arr)
                {
                    //Hashtable ht = (Hashtable)row;
                    ListViewItem item = new ListViewItem(row["no"].ToString());
                    item.SubItems.Add(row["name"].ToString());
                    listView1.Items.Add(item);
                }
            }
            catch
            {
                conn.Close(); // 데이터베이스 
                MessageBox.Show("연결을 실패하였습니다.");
            }
        }
    }
}
