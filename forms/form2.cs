//Форма Клиента
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktika
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "praktikaDataSet22.Izdelie". При необходимости она может быть перемещена или удалена.
            this.izdelieTableAdapter3.Fill(this.praktikaDataSet22.Izdelie);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "praktikaDataSet21.Zakaznue_izdelia". При необходимости она может быть перемещена или удалена.
            this.zakaznue_izdeliaTableAdapter2.Fill(this.praktikaDataSet21.Zakaznue_izdelia);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "praktikaDataSet21.Zakaznue_izdelia". При необходимости она может быть перемещена или удалена.
            this.zakaznue_izdeliaTableAdapter2.Fill(this.praktikaDataSet21.Zakaznue_izdelia);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Hide();
        }
    }
}