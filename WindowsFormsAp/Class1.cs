﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsAp
{
    class Class1
    {
        public void btn(Btnclass bc)
        {
           Button btn = new Button();
            btn.DialogResult = DialogResult.OK;
            btn.Name = bc.Name;
            btn.Text = bc.Text;
            btn.Size = new Size(bc.SX, bc.SY);
            btn.Location = new Point(bc.PX, bc.PY);
            btn.Cursor = Cursors.Hand;
            btn.Click += bc.eh;
            bc.Form.Controls.Add(btn);
        }
        public void lb(Lbclass lb)
        {
            Label label  = new Label(); 
            label.Name = lb.Name;
            label.Text = lb.Text;
            label.Size = new Size(lb.SX, lb.SY);
            label.Location = new Point(lb.PX, lb.PY);
            lb.Form.Controls.Add(label);
        }
    }
}
