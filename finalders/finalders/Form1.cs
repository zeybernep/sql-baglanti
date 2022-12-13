using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace finalders
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Server=LAPTOP-HM45C1D4\\SQLEXPRESS;Database=GorselProgramlama;User Id=Tasarim;Password=123; connection timeout=30;";
            SqlConnection conn = new SqlConnection(); 
           conn.ConnectionString = ConnectionString;
            conn.Open();
            MessageBox.Show("Bağlantı Sağlandı");

            SqlCommand command = new SqlCommand("select * From isimler",conn);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                richTextBox1.Text += reader.GetValue(reader.GetOrdinal("isim")).ToString()+"\n";
            }





            conn.Close();
        }
    }
}
