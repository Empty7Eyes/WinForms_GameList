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
    public partial class DeleteForm : Form
    {
        DataSet data;
        SqlDataAdapter sda;
        SqlCommandBuilder cmd;
        SqlCommand cmD;
        static string cs = "Data Source = EMPTY\\SQLEXPRESS; Initial Catalog = GameList1; Integrated Security = SSPI";
        SqlConnection con = new SqlConnection(cs);
        public DeleteForm()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            cmD = new SqlCommand($"delete FROM Games WHERE id = {textBox1.Text}", con);
            cmD.ExecuteNonQuery();
            con.Close();
            this.Close();
        }

        private void DeleteForm_Load(object sender, EventArgs e)
        {

        }
    }
}
