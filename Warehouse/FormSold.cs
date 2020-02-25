using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warehouse
{
    public partial class FormSold : Form
    {
        public FormSold()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            string query = "SELECT * FROM Товары WHERE Статус = N'Продан' ORDER BY ID";
            QueryManipulation qm = new QueryManipulation();
            qm.GridShow(query, tableGridSold);
        }
    }
}
