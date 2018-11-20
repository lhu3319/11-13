using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace WindowsFormsAp
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            Load += Form3_Load;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Class1 c1 = new Class1();
            ArrayList arr = new ArrayList();
            arr.Add(new Btnclass(this, "btn_1", "버튼1", 100, 50, 30, 30,btn1_Click));
            arr.Add(new Btnclass(this, "btn_2", "버튼2", 100, 50, 30, (30 + 30 + 50),btn2_Click));
            arr.Add(new Lbclass(this, "lb_2", "라벨1", 100, 50, (30+30+100), 30));
            for (int i = 0; i < arr.Count; i++)
            {
                if ( typeof(Btnclass) == arr[i].GetType())
                {
                    c1.btn((Btnclass)arr[i]);
                }
                else if ((typeof(Lbclass) == arr[i].GetType()))
                {
                    c1.lb((Lbclass)arr[i]);
                }
            }
        }
        private void btn1_Click(Object o,EventArgs e)
        {
            MessageBox.Show("btn1");
            
        }
        private void btn2_Click(Object o, EventArgs e)
        {
            MessageBox.Show("btn2");
        }

    }
}
