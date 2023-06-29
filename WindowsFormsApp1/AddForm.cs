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

namespace WindowsFormsApp1
{
    public partial class AddForm : Form
    {
        
        DataSet data;
        SqlDataAdapter sda;
        SqlCommand cmd;
        static string cs = "Data Source = EMPTY\\SQLEXPRESS; Initial Catalog = GameList1; Integrated Security = SSPI";
        SqlConnection con = new SqlConnection(cs);
        public AddForm()
        {
            InitializeComponent();
            data = new DataSet();
            sda = new SqlDataAdapter("SELECT * FROM [Games]", con);
            sda.Fill(data, "games");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand($"Insert Into [Games] Values ('{textBox1.Text}','{textBox2.Text}','{textBox3.Text}','{textBox4.Text}','{textBox5.Text}','{textBox6.Text}')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            this.Close();
        }

        private void AddForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
