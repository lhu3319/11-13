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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ListView listView1 = new ListView();
          
            ColumnHeader columnHeader1 = new ColumnHeader();
            
            ColumnHeader columnHeader2 = new ColumnHeader();
            ColumnHeader columnHeader3 = new ColumnHeader();
            //listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listView1.Columns.Add(columnHeader1);
            listView1.Columns.Add(columnHeader2);
            listView1.Columns.Add(columnHeader3);
            columnHeader1.Text = "1열";
            columnHeader1.Width = 100;
            columnHeader1.TextAlign = HorizontalAlignment.Center;
            
            columnHeader2.Text = "2열";
            columnHeader2.Width = 100;
            columnHeader2.TextAlign = HorizontalAlignment.Center;

            columnHeader3.Text = "3열";
            columnHeader3.Width = 100;
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            

            /*
            listView1.Columns.Add("Item Column", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Column 2", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Column 3", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Column 4", -2, HorizontalAlignment.Center);
            */
            listView1.GridLines = true;
            listView1.Location = new System.Drawing.Point(1, -2);
            listView1.Name = "listView1";
            listView1.Size = new System.Drawing.Size(802, 456);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = System.Windows.Forms.View.Details;

            /*
            ListViewItem item1 = new ListViewItem("item1", 0);
            // Place a check mark next to the item.
           
            item1.SubItems.Add("1");
            item1.SubItems.Add("2");
            item1.SubItems.Add("3");
            ListViewItem item2 = new ListViewItem("item2", 1);
            item2.SubItems.Add("4");
            item2.SubItems.Add("5");
            item2.SubItems.Add("6");
            ListViewItem item3 = new ListViewItem("item3", 0);
            // Place a check mark next to the item.
           
            item3.SubItems.Add("7");
            item3.SubItems.Add("8");
            item3.SubItems.Add("9");


           // listView1.Items.AddRange(new ListViewItem[] { item1, item2, item3 });
            listView1.Items.Add(item1);
            listView1.Items.Add(item2);
            listView1.Items.Add(item3);
            */
            ArrayList arry = new ArrayList();
            arry.Add(new Items(new string[] { "item1", "1", "2" }));
            arry.Add(new Items(new string[] { "item2", "4", "5" }));
            arry.Add(new Items(new string[] { "item3", "7", "8" }));
            ListViewItem item;
            for (int i = 0; i < 3; i++)
            {
                Items row = (Items)arry[i];
                item = new ListViewItem(row.Col1);
                item.SubItems.Add(row.Col2);
                item.SubItems.Add(row.Col3);
                listView1.Items.Add(item);
            }

            Controls.Add(listView1);
        }

    }
    public class Items
    {
        string col1;
        string col2;
        string col3;
        public Items(string[] a)
        {
            col1 = a[0];
            col2 = a[1];
            col3 = a[2];
        }
        public string Col1
        {
            get { return col1; }
        }
        public string Col2
        {
            get { return col2; }
        }
        public string Col3
        {
            get { return col3; }
        }

        /*
        public Items(string[] a)
        {
            col1 = a[0];
            col2 = a[1];
            col3 = a[2];
        }
        public string getCol1()
        {
            return col1;
        }
        public string getCol2()
        {
            return col2;
        }
        public string getCol3()
        {
            return col3;
        }
        */
    }

}
