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
    public partial class FormNew : Form
    {
        public FormNew()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            string query = "SELECT * FROM Товары WHERE Статус = N'Принят' ORDER BY ID";
            QueryManipulation qm = new QueryManipulation();
            qm.GridShow(query, tableGridNew);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            using (FormNewAdd fna = new FormNewAdd())
            {
                fna.ShowDialog();
            }
            LoadData();
        }

        private void buttonToWare_Click(object sender, EventArgs e)
        {
            string newStatus = "На складе";

            int selectedRowIndex = tableGridNew.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = tableGridNew.Rows[selectedRowIndex];
            int idNumber = Convert.ToInt32(selectedRow.Cells["ID"].Value);

            QueryManipulation qm = new QueryManipulation();
            qm.ChangeStatus(newStatus, idNumber);

            LoadData();
        }
    }
}
