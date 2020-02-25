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
    public partial class FormNewAdd : Form
    {
        public FormNewAdd()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                QueryManipulation qm = new QueryManipulation();
                qm.InsertData(textBox1.Text);
            }
            this.Close();
        }
    }
}
