using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAp
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            Load += Form4_Load;
        }
        Panel panel;
        private void Form4_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            Size = new Size(1000, 800);
            Class1 c1 = new Class1();
            c1.btn(new Btnclass(this, "btn_1", "버튼1", 100, 50, 30, 30, btn_Click));

            panel = new Panel();
            panel.Location = new Point(0, 80);
            panel.Size = new Size(1000, 400);
        }
        private void btn_Click(object o, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.MdiParent = this;
            f5.Show();
        }
    }
}
