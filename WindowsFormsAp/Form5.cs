using System;
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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            Load += Form5_Load;
  
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            Location = new Point(0, 80);
            Size = new Size(100, 100);
        }
    }
}
