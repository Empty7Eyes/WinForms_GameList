using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        DataSet data;
        SqlDataAdapter sda;
        SqlCommandBuilder cmd;
        SqlCommand cmD;
        static string cs = "Data Source = EMPTY\\SQLEXPRESS; Initial Catalog = GameList1; Integrated Security = SSPI";
        SqlConnection con = new SqlConnection(cs);
        public Form1()
        {
            InitializeComponent();
            data = new DataSet();
            sda = new SqlDataAdapter("SELECT * FROM  Games", con);
            cmd = new SqlCommandBuilder(sda);
            sda.Fill(data, "games");
            dataGridView1.DataSource = data.Tables["games"];
            sda.Update(data, "games");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            addForm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            data = new DataSet();
            sda = new SqlDataAdapter("SELECT * FROM  Games", con);
            cmd = new SqlCommandBuilder(sda);
            sda.Fill(data, "games");
            dataGridView1.DataSource = data.Tables["games"];
            sda.Update(data, "games");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DeleteForm deleteForm = new DeleteForm();
            deleteForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Update1Form update1Form = new Update1Form();
            update1Form.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
