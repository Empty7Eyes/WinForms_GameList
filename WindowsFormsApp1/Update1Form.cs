using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Update1Form : Form
    {
        public Update1Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Update2Form update2Form = new Update2Form();
            update2Form.ShowDialog();

        }

        public string IdCount()
        {
            return textBox1.Text;
        }
    }
}
