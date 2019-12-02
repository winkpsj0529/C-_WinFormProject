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
    public partial class Form3 : Form
    {
        MySqlConnection conn;
        MySqlDataAdapter dataAdapter;
        DataSet dataSet;

        private string number;
        private string name;
        private string inven;
        private string mo;
        private string made;
        private int selectedRowIndex;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            String connectionString = "server=localhost;port=3306;database=h_market;username=root;password=Alsdk815";
            conn = new MySqlConnection(connectionString);
            dataAdapter = new MySqlDataAdapter("SELECT * FROM 제품", conn);
            dataSet = new DataSet();

            dataAdapter.Fill(dataSet, "제품");
            dataGridView1.DataSource = dataSet.Tables["제품"];

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
        private void btnClear_Click(object sender, EventArgs e)
        {
            textBoxPnumber.Clear();
            textBoxPname.Clear();
            textBoxPinven.Clear();
            textBoxPmo.Clear();
            textBoxPmade.Clear();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string[] rowDatas = {
                textBoxPnumber.Text,
                textBoxPname.Text,
                textBoxPinven.Text,
                textBoxPmo.Text,
                textBoxPmade.Text};

            string queryStr = "INSERT INTO 제품 (제품번호, 제품명, 재고량, 단가, 제조업체) " +
                "VALUES(@제품번호, @제품명, @재고량, @단가, @제조업체)";
            dataAdapter.InsertCommand = new MySqlCommand(queryStr, conn);
            dataAdapter.InsertCommand.Parameters.Add("@제품번호", MySqlDbType.VarChar);
            dataAdapter.InsertCommand.Parameters.Add("@제품명", MySqlDbType.VarChar);
            dataAdapter.InsertCommand.Parameters.Add("@재고량", MySqlDbType.Int32);
            dataAdapter.InsertCommand.Parameters.Add("@단가", MySqlDbType.Int32);
            dataAdapter.InsertCommand.Parameters.Add("@제조업체", MySqlDbType.VarChar);

            #region Parameter를 이용한 처리
            dataAdapter.InsertCommand.Parameters["@제품번호"].Value = rowDatas[0];
            dataAdapter.InsertCommand.Parameters["@제품명"].Value = rowDatas[1];
            dataAdapter.InsertCommand.Parameters["@재고량"].Value = rowDatas[2];
            dataAdapter.InsertCommand.Parameters["@단가"].Value = rowDatas[3];
            dataAdapter.InsertCommand.Parameters["@제조업체"].Value = rowDatas[4];

            try
            {
                conn.Open();
                dataAdapter.InsertCommand.ExecuteNonQuery();

                dataSet.Clear();                                        
                dataAdapter.Fill(dataSet, "제품");                    
                dataGridView1.DataSource = dataSet.Tables["제품"];    
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

        private void btnSelect_Click(object sender, EventArgs e)
        {
            string queryStr;

            #region Select QueryString 만들기
            string[] conditions = new string[6];
            conditions[0] = (textBoxPnumber.Text != "") ? "제품번호=@제품번호" : null;
            conditions[1] = (textBoxPname.Text != "") ? "제품명=@제품명" : null;
            conditions[2] = (textBoxPinven.Text != "") ? "재고량=@재고량" : null;
            conditions[3] = (textBoxPmo.Text != "") ? "단가=@단가" : null;
            conditions[4] = (textBoxPmade.Text != "") ? "제조업체=@제조업체" : null;

            if (conditions[0] != null || conditions[1] != null || conditions[2] != null || conditions[3] != null || conditions[4] != null)
            {
                queryStr = $"SELECT * FROM 제품 WHERE ";
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
                queryStr = "SELECT * FROM 제품";
            }
            #endregion

            #region SelectCommand 객체 생성 및 Parameters 설정
            dataAdapter.SelectCommand = new MySqlCommand(queryStr, conn);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@제품번호", textBoxPnumber.Text);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@제품명", textBoxPname.Text);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@재고량", textBoxPinven.Text);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@단가", textBoxPmo.Text);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@제조업체", textBoxPmade.Text);
            #endregion

            try
            {
                conn.Open();
                dataSet.Clear();
                if (dataAdapter.Fill(dataSet, "제품") > 0)
                    dataGridView1.DataSource = dataSet.Tables["제품"];
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string[] rowDatas = {
                textBoxPnumber.Text,
                textBoxPname.Text,
                textBoxPinven.Text,
                textBoxPmo.Text,
                textBoxPmade.Text };

            string sql = "UPDATE 제품 SET 제품명=@제품명,재고량=@재고량, 단가=@단가,제조업체=@제조업체 WHERE 제품번호=@제품번호";
            dataAdapter.UpdateCommand = new MySqlCommand(sql, conn);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@제품번호", rowDatas[0]);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@제품명", rowDatas[1]);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@재고량", rowDatas[2]);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@단가", rowDatas[3]);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@제조업체", rowDatas[4]);

            try
            {
                conn.Open();
                dataAdapter.UpdateCommand.ExecuteNonQuery();
                if (textBoxPnumber == null)
                {

                }

                dataSet.Clear();
                dataAdapter.Fill(dataSet, "제품");
                dataGridView1.DataSource = dataSet.Tables["제품"];
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
