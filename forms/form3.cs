//Форма бронирования
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Praktika
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "praktikaDataSet23.Zakaznue_izdelia". При необходимости она может быть перемещена или удалена.
            this.zakaznue_izdeliaTableAdapter.Fill(this.praktikaDataSet23.Zakaznue_izdelia);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "praktikaDataSet15.Izdelie". При необходимости она может быть перемещена или удалена.
            this.izdelieTableAdapter3.Fill(this.praktikaDataSet15.Izdelie);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "praktikaDataSet14.Izdelie". При необходимости она может быть перемещена или удалена.
            this.izdelieTableAdapter2.Fill(this.praktikaDataSet14.Izdelie);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "praktikaDataSet13.Izdelie". При необходимости она может быть перемещена или удалена.
            this.izdelieTableAdapter1.Fill(this.praktikaDataSet13.Izdelie);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "praktikaDataSet12.Izdelie". При необходимости она может быть перемещена или удалена.
            this.izdelieTableAdapter.Fill(this.praktikaDataSet12.Izdelie);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // SQL
            string UserArticul = comboBox2.Text.Trim();
            string UserKolichestvo = textBox1.Text.Trim();
            string UserZakazchik = textBox2.Text.Trim();
            string UserNomer_zakaza = textBox3.Text.Trim();
            



            SqlConnection con = new SqlConnection(@"Data Source=USER-PC;Initial Catalog=Praktika;Integrated Security=True");
            string query = "Select * From Zakaznue_izdelia where Articul_izdelia ='" + comboBox2.Text.Trim() + "' and Kolichestvo = '" + textBox1.Text.Trim() + "' and Zakazchik = '" + textBox2.Text.Trim() + "' and Nomer_zakaza = '" + textBox3.Text.Trim() + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            {
                reader.Close();
                string insertquery = "INSERT INTO Zakaznue_izdelia (Articul_izdelia, Kolichestvo, Zakazchik, Nomer_zakaza) VALUES ( '" + comboBox2.Text + "' , '" + textBox1.Text + "' , '" + textBox2.Text + "' , '" + textBox3.Text.Trim() + "')";
                SqlCommand cmd2 = new SqlCommand(insertquery, con);
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Заказ принят");


            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
