using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Warehouse
{
    public partial class Form1 : Form
    {
        public static int WareNumber { get; set; }

        public Form1()
        {
            InitializeComponent();
            WareNumber = 0;
            LoadData();
        }

        private void LoadData()
        {
            string query = "SELECT * FROM Товары ORDER BY ID";
            QueryManipulation qm = new QueryManipulation();
            qm.GridShow(query, tableGrid);
            WareNumber = tableGrid.RowCount - 1;
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            using (FormNew fn = new FormNew())
            {
                fn.ShowDialog();
            }
            LoadData();
        }

        private void buttonWared_Click(object sender, EventArgs e)
        {
            using (FormWared fw = new FormWared())
            {
                fw.ShowDialog();
            }
            LoadData();
        }

        private void buttonSold_Click(object sender, EventArgs e)
        {
            using (FormSold fs = new FormSold())
            {
                fs.ShowDialog();
            }
            LoadData();
        }

        private void buttonReport_Click(object sender, EventArgs e)
        {
            using (FormReport fr = new FormReport())
            {
                fr.ShowDialog();
            }
            LoadData();
        }
    }

}
