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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Load += Form2_Load;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ListView lv=lv_create();
            Controls.Add(lv);

        }
        private ListView lv_create()
        {
            ListView lv = new ListView();
            

            lv.GridLines = true;
            lv.Location = new System.Drawing.Point(1, -2);
            lv.Name = "listView1";
            lv.Size = new System.Drawing.Size(802, 456);
            lv.TabIndex = 0;
            lv.UseCompatibleStateImageBehavior = false;
            lv.View = System.Windows.Forms.View.Details;
            return lv;
        }
    }
}
