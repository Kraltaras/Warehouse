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
    public partial class FormWared : Form
    {
        public FormWared()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            string query = "SELECT * FROM Товары WHERE Статус = N'На складе' ORDER BY ID";
            QueryManipulation qm = new QueryManipulation();
            qm.GridShow(query, tableGridWared);
        }

        private void buttonSell_Click(object sender, EventArgs e)
        {
            string newStatus = "Продан";

            int selectedRowIndex = tableGridWared.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = tableGridWared.Rows[selectedRowIndex];
            int idNumber = Convert.ToInt32(selectedRow.Cells["ID"].Value);

            QueryManipulation qm = new QueryManipulation();
            qm.ChangeStatus(newStatus, idNumber);

            LoadData();
        }
    }
}
