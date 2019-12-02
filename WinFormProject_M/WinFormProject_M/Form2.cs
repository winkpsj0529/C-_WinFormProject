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

    public partial class Form2 : Form
    {
        MySqlConnection conn;
        MySqlDataAdapter dataAdapter;
        DataSet dataSet;

        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            String connectionString = "server=localhost;port=3306;database=h_market;username=root;password=Alsdk815";
            conn = new MySqlConnection(connectionString);
            dataAdapter = new MySqlDataAdapter("SELECT * FROM 고객", conn);
            dataSet = new DataSet();

            dataAdapter.Fill(dataSet, "고객");
            dataGridView1.DataSource = dataSet.Tables["고객"];
            

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
            string[] conditions = new string[6];
            conditions[0] = (textBoxID.Text != "") ? "고객아이디=@고객아이디" : null;
            conditions[1] = (textBoxName.Text != "") ? "고객이름=@고객이름" : null;
            conditions[2] = (textBoxAge.Text != "") ? "나이=@나이" : null;
            conditions[3] = (textBoxJob.Text != "") ? "직업=@직업" : null;
            conditions[4] = (textBoxPoint.Text != "") ? "적립금=@적립금" : null;
            
            if (conditions[0] != null || conditions[1] != null || conditions[2] != null || conditions[3] != null || conditions[4] != null )
            {
                queryStr = $"SELECT * FROM 고객 WHERE ";
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
                queryStr = "SELECT * FROM 고객";
            }
            #endregion

            #region SelectCommand 객체 생성 및 Parameters 설정
            dataAdapter.SelectCommand = new MySqlCommand(queryStr, conn);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@고객아이디", textBoxID.Text);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@고객이름", textBoxName.Text);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@나이", textBoxAge.Text);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@직업", textBoxJob.Text);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@적립금", textBoxPoint.Text);
            #endregion

            try
            {
                conn.Open();
                dataSet.Clear();
                if (dataAdapter.Fill(dataSet, "고객") > 0)
                    dataGridView1.DataSource = dataSet.Tables["고객"];
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
                textBoxID.Text,
                textBoxName.Text,
                textBoxAge.Text,
                textBoxJob.Text,
                textBoxPoint.Text};

            string queryStr = "INSERT INTO 고객 (고객아이디,고객이름, 나이, 직업, 적립금) " +
                "VALUES(@고객아이디, @고객이름, @나이, @직업, @적립금)";
            dataAdapter.InsertCommand = new MySqlCommand(queryStr, conn);
            dataAdapter.InsertCommand.Parameters.Add("@고객아이디", MySqlDbType.VarChar);
            dataAdapter.InsertCommand.Parameters.Add("@고객이름", MySqlDbType.VarChar);
            dataAdapter.InsertCommand.Parameters.Add("@나이", MySqlDbType.Int32);
            dataAdapter.InsertCommand.Parameters.Add("@직업", MySqlDbType.VarChar);
            dataAdapter.InsertCommand.Parameters.Add("@적립금", MySqlDbType.Int32);

            #region Parameter를 이용한 처리
            dataAdapter.InsertCommand.Parameters["@고객아이디"].Value = rowDatas[0];
            dataAdapter.InsertCommand.Parameters["@고객이름"].Value = rowDatas[1];
            dataAdapter.InsertCommand.Parameters["@나이"].Value = rowDatas[2];
            dataAdapter.InsertCommand.Parameters["@직업"].Value = rowDatas[3];
            dataAdapter.InsertCommand.Parameters["@적립금"].Value = rowDatas[4];

            try
            {
                conn.Open();
                dataAdapter.InsertCommand.ExecuteNonQuery();

                dataSet.Clear();                                      
                dataAdapter.Fill(dataSet, "고객");                 
                dataGridView1.DataSource = dataSet.Tables["고객"];   
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            string[] rowDatas = {
                textBoxID.Text,
                textBoxName.Text,
                textBoxAge.Text,
                textBoxJob.Text,
                textBoxPoint.Text };

            string sql = "UPDATE 고객 SET 고객이름=@고객이름, 나이=@나이, 직업=@직업, 적립금=@적립금 WHERE 고객아이디=@고객아이디";
            dataAdapter.UpdateCommand = new MySqlCommand(sql, conn);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@고객아이디", rowDatas[0]);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@고객이름", rowDatas[1]);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@나이", rowDatas[2]);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@직업", rowDatas[3]);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@적립금", rowDatas[4]);

            try
            {
                conn.Open();
                dataAdapter.UpdateCommand.ExecuteNonQuery();
                if (textBoxID == null)
                {

                }

                dataSet.Clear();
                dataAdapter.Fill(dataSet, "고객");
                dataGridView1.DataSource = dataSet.Tables["고객"];
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string target = textBoxID.Text;

            string query = "delete from고객 where 고객아이디=@고객아이디";
            dataAdapter.DeleteCommand = new MySqlCommand(query, conn);
            dataAdapter.DeleteCommand.Parameters.Add("@고객아이디", MySqlDbType.VarChar);
            dataAdapter.DeleteCommand.Parameters["@고객아이디"].Value = target;
            try
            {
                DataRow[] findRows = dataSet.Tables["고객"].Select($"고객아이디={target}");
                findRows[0].Delete();
                dataAdapter.Update(dataSet, "고객");
                MessageBox.Show("성공적으로 삭제되었습니다.", "삭제 완료");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBoxID.Clear();
            textBoxName.Clear();
            textBoxAge.Clear();
            textBoxJob.Clear();
            textBoxPoint.Clear();

        }
    }
}
