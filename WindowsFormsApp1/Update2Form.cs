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
    public partial class Update2Form : Form
    {
        DataSet data;
        SqlDataAdapter sda;
        SqlDataAdapter sda_Name;
        SqlDataAdapter sda_Genres;
        SqlDataAdapter sda_Tags;
        SqlDataAdapter sda_Rating;
        SqlDataAdapter sda_Prise;
        SqlDataAdapter sda_Despription;
        SqlCommand cmd;
        static string cs = "Data Source = EMPTY\\SQLEXPRESS; Initial Catalog = GameList1; Integrated Security = SSPI";
        SqlConnection con = new SqlConnection(cs);

        public Update2Form()
        {
            InitializeComponent();
            //Update1Form update1Form = new Update1Form();
            //sda_Name = new SqlDataAdapter($"SELECT [Name] FROM [Games] where id = {update1Form.IdCount()}", con);
            //sda_Genres = new SqlDataAdapter($"SELECT  [Genres] FROM [Games] where id = {update1Form.IdCount()}", con);
            //sda_Tags = new SqlDataAdapter($"SELECT [Tags] FROM [Games] where id = {update1Form.IdCount()}", con);
            //sda_Rating = new SqlDataAdapter($"SELECT [Rating] FROM [Games] where id = {update1Form.IdCount()}", con);
            //sda_Prise = new SqlDataAdapter($"SELECT [Prise] FROM [Games] where id = {update1Form.IdCount()}", con);
            //sda_Despription = new SqlDataAdapter($"SELECT [Despription] FROM [Games] where id = {update1Form.IdCount()}", con);
            //textBox1.Text = sda_Name.ToString();
            //textBox2.Text = sda_Genres.ToString();
            //textBox3.Text = sda_Tags.ToString();
            //textBox4.Text = sda_Rating.ToString();
            //textBox5.Text = sda_Prise.ToString();
            //textBox6.Text = sda_Despription.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Update1Form update1Form = new Update1Form();
            con.Open();
            if (textBox1.Text != null)
            {
                cmd = new SqlCommand($"Update Games set [Name] = '{textBox1.Text}' where Id = '{update1Form.IdCount()}'", con);
                cmd.ExecuteNonQuery();
            }
            if (textBox2.Text != null)
            {
                cmd = new SqlCommand($"Update Games set [Genres] = '{textBox2.Text}' where Id = '{update1Form.IdCount()}'", con);
                cmd.ExecuteNonQuery();
            }
            if (textBox3.Text != null)
            {
                cmd = new SqlCommand($"Update Games set [Tags] = '{textBox3.Text}' where Id = '{update1Form.IdCount()}'", con);
                cmd.ExecuteNonQuery();
            }
            if (textBox4.Text != null)
            {
                cmd = new SqlCommand($"Update Games set [Rating] = '{textBox4.Text}' where Id = '{update1Form.IdCount()}'", con);
                cmd.ExecuteNonQuery();
            }
            if (textBox5.Text != null)
            {
                cmd = new SqlCommand($"Update Games set [Prise] = '{textBox5.Text}' where Id = '{update1Form.IdCount()}'", con);
                cmd.ExecuteNonQuery();
            }
            if (textBox6.Text != null)
            {
                cmd = new SqlCommand($"Update Games set [Despription] = '{textBox6.Text}' where Id = '{update1Form.IdCount()}'", con);
                cmd.ExecuteNonQuery();
            }
            cmd.ExecuteNonQuery();
            con.Close();
            this.Close();
        }
    }
}
