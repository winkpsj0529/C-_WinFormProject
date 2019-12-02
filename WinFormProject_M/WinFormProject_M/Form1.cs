using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormProject_M
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        MySqlConnection conn;

        private void Form1_Load(object sender, EventArgs e)
        {
            String connectionString = "server=localhost;port=3306;database=h_market;username=root;password=Alsdk815";
            conn = new MySqlConnection(connectionString);

            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    label8.Text = "연결 성공";
                    label8.ForeColor = Color.Green;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 Dig = new Form2();
            if (Dig.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("정상 종료");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 Dig = new Form3();
            if (Dig.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("정상 종료");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 Dig = new Form4();
            if (Dig.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("정상 종료");
            }
        }
    }
}
