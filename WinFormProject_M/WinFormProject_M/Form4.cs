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
    public partial class Form4 : Form
    {
        MySqlConnection conn;
        MySqlDataAdapter dataAdapter;
        DataSet dataSet;

        private string number;
        private string name;
        private string pro;
        private string inven;
        private string dri;
        private string date;
        private int selectedRowIndex;

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            String connectionString = "server=localhost;port=3306;database=h_market;username=root;password=Alsdk815";
            conn = new MySqlConnection(connectionString);
            dataAdapter = new MySqlDataAdapter("SELECT * FROM 주문", conn);
            dataSet = new DataSet();

            dataAdapter.Fill(dataSet, "주문");
            dataGridView1.DataSource = dataSet.Tables["주문"];

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

        private void btnSelect_Click(object sender, EventArgs e)
        {
            string queryStr;

            #region Select QueryString 만들기
            string[] conditions = new string[7];
            conditions[0] = (textBoxOnumber.Text != "") ? "주문번호=@주문번호" : null;
            conditions[1] = (textBoxOname.Text != "") ? "주문고객=@주문고객" : null;
            conditions[2] = (textBoxOpro.Text != "") ? "주문제품=@주문제품" : null;
            conditions[3] = (textBoxOinven.Text != "") ? "수량=@수량" : null;
            conditions[4] = (textBoxOdri.Text != "") ? "배송지=@배송지" : null;
            conditions[5] = (textBoxOdate.Text != "") ? "주문일자=@주문일자" : null;

            if (conditions[0] != null || conditions[1] != null || conditions[2] != null || conditions[3] != null || conditions[4] != null||conditions[5]!=null)
            {
                queryStr = $"SELECT * FROM 주문 WHERE ";
                bool firstCondition = true;
                for (int i = 0; i < conditions.Length; i++)
                {
                    if (conditions[i] != null)
                        if (firstCondition)
                        {
                            queryStr += conditions[i];
                            firstCondition = false;
                        }
                        else
                        {
                            queryStr += " and " + conditions[i];
                        }
                }
            }
            else
            {
                queryStr = "SELECT * FROM 주문";
            }
            #endregion

            #region SelectCommand 객체 생성 및 Parameters 설정
            dataAdapter.SelectCommand = new MySqlCommand(queryStr, conn);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@주문번호", textBoxOnumber.Text);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@주문고객", textBoxOname.Text);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@주문제품", textBoxOpro.Text);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@수량", textBoxOinven.Text);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@배송지", textBoxOdri.Text);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@주문일자", textBoxOdate.Text);
            #endregion

            try
            {
                conn.Open();
                dataSet.Clear();
                if (dataAdapter.Fill(dataSet, "주문") > 0)
                    dataGridView1.DataSource = dataSet.Tables["주문"];
                else
                    MessageBox.Show("찾는 데이터가 없습니다.");
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string[] rowDatas = {
                textBoxOnumber.Text,
                textBoxOname.Text,
                textBoxOpro.Text,
                textBoxOinven.Text,
                textBoxOdri.Text,
                textBoxOdate.Text};

            string queryStr = "INSERT INTO 주문 (주문번호,주문고객,주문제품,수량,배송지,주문일자) " +
                "VALUES(@주문번호,@주문고객,@주문제품,@수량,@배송지,@주문일자)";
            dataAdapter.InsertCommand = new MySqlCommand(queryStr, conn);
            dataAdapter.InsertCommand.Parameters.Add("@주문번호", MySqlDbType.VarChar);
            dataAdapter.InsertCommand.Parameters.Add("@주문고객", MySqlDbType.VarChar);
            dataAdapter.InsertCommand.Parameters.Add("@주문제품", MySqlDbType.VarChar);
            dataAdapter.InsertCommand.Parameters.Add("@수량", MySqlDbType.Int32);
            dataAdapter.InsertCommand.Parameters.Add("@배송지", MySqlDbType.VarChar);
            dataAdapter.InsertCommand.Parameters.Add("@주문일자", MySqlDbType.Date);

            #region Parameter를 이용한 처리
            dataAdapter.InsertCommand.Parameters["@주문번호"].Value = rowDatas[0];
            dataAdapter.InsertCommand.Parameters["@주문고객"].Value = rowDatas[1];
            dataAdapter.InsertCommand.Parameters["@주문제품"].Value = rowDatas[2];
            dataAdapter.InsertCommand.Parameters["@수량"].Value = rowDatas[3];
            dataAdapter.InsertCommand.Parameters["@배송지"].Value = rowDatas[4];
            dataAdapter.InsertCommand.Parameters["@주문일자"].Value = rowDatas[5];

            try
            {
                conn.Open();
                dataAdapter.InsertCommand.ExecuteNonQuery();

                dataSet.Clear();                                        
                dataAdapter.Fill(dataSet, "주문");                     
                dataGridView1.DataSource = dataSet.Tables["주문"];    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            #endregion
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBoxOnumber.Clear();
            textBoxOname.Clear();
            textBoxOpro.Clear();
            textBoxOinven.Clear();
            textBoxOdri.Clear();
            textBoxOdate.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string[] rowDatas = {
                textBoxOnumber.Text,
                textBoxOname.Text,
                textBoxOpro.Text,
                textBoxOinven.Text,
                textBoxOdri.Text,
                textBoxOdate.Text };

            string sql = "UPDATE 주문 SET 주문고객=@주문고객,주문제품=@주문제품,수량=@수량,배송지=@배송지,주문일자=@주문일자 WHERE 주문번호=@주문번호";
            dataAdapter.UpdateCommand = new MySqlCommand(sql, conn);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@주문번호", rowDatas[0]);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@주문고객", rowDatas[1]);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@주문제품", rowDatas[2]);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@수량", rowDatas[3]);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@배송지", rowDatas[4]);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@주문일자", rowDatas[5]);

            try
            {
                conn.Open();
                dataAdapter.UpdateCommand.ExecuteNonQuery();
                if (textBoxOnumber == null)
                {

                }

                dataSet.Clear();
                dataAdapter.Fill(dataSet, "주문");
                dataGridView1.DataSource = dataSet.Tables["주문"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
