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
    public partial class FormReport : Form
    {
        public int Mode { get; set; }

        public FormReport()
        {
            InitializeComponent();
            monthCalendarStart.SetDate(new DateTime(2019, 10, 1, 0, 0, 0));
            Mode = 0;
            LoadData(Mode);
        }

        private void radioButtonAll_CheckedChanged(object sender, EventArgs e)
        {
            Mode = 0;
            LoadData(Mode);
        }

        private void radioButtonNew_CheckedChanged(object sender, EventArgs e)
        {
            Mode = 1;
            LoadData(Mode);
        }

        private void radioButtonWared_CheckedChanged(object sender, EventArgs e)
        {
            Mode = 2;
            LoadData(Mode);
        }

        private void radioButtonSold_CheckedChanged(object sender, EventArgs e)
        {
            Mode = 3;
            LoadData(Mode);
        }

        public void LoadData(int mode)
        {
            string query;
            string query_date;

            DateTime dateStart = monthCalendarStart.SelectionStart;
            DateTime dateEnd = monthCalendarEnd.SelectionStart;
            DateTime dateEndEnd = dateEnd.Add(new TimeSpan(23, 59, 59));       

            query_date = "[Дата изменения статуса] >= @DateStart AND [Дата изменения статуса] < @DateEnd";

            switch (mode)
            {
                case 1:
                    query = "SELECT * FROM Товары WHERE Статус = N'Принят' AND "+ query_date +" ORDER BY ID";
                    break;
                case 2:
                    query = "SELECT * FROM Товары WHERE Статус = N'На складе' AND " + query_date + " ORDER BY ID";
                    break;
                case 3:
                    query = "SELECT * FROM Товары WHERE Статус = N'Продан' AND " + query_date + " ORDER BY ID";
                    break;
                default:
                    query = "SELECT * FROM Товары WHERE " + query_date + " ORDER BY ID";
                    break;
            }
            QueryManipulation qm = new QueryManipulation();
            qm.GridShow(query, tableGridReport, dateStart, dateEndEnd);
        }

        private void monthCalendarStart_DateChanged(object sender, DateRangeEventArgs e)
        {
            LoadData(Mode);
        }

        private void monthCalendarEnd_DateChanged(object sender, DateRangeEventArgs e)
        {
            LoadData(Mode);
        }
    }
}
