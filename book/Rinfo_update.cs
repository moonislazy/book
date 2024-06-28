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

namespace book
{
    public partial class Rinfo_update : Form
    {
        static string connectionString = System.Configuration.ConfigurationManager.AppSettings["connectionString"];
        private string rno;

        public Rinfo_update(string rno)
        {
            InitializeComponent();
            this.rno = rno;
        }

        private void Rinfo_update_Load(object sender, EventArgs e)
        {
            label2.Text = rno; // 显示读者编号
            LoadReaderInfo(rno);
            PopulateComboBoxes();
        }

        private void LoadReaderInfo(string rno)
        {
            // 根据 rno 查询数据库，获取读者信息并加载到界面上
            string sql = "SELECT Rname, Rsex, Rtitle, Rcan, Rdepartment, Rtel FROM Readers WHERE Rno = @rno";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@rno", rno);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    textBox2.Text = reader["Rname"].ToString();
                    string rsex = reader["Rsex"].ToString();
                    comboBox1.SelectedItem = (rsex == "m") ? "男" : "女"; // 根据数据库值设置 ComboBox
                    comboBox2.SelectedItem = reader["Rtitle"].ToString();
                    textBox1.Text = reader["Rcan"].ToString();
                    textBox3.Text = reader["Rdepartment"].ToString();
                    textBox4.Text = reader["Rtel"].ToString();
                }
                reader.Close();
            }
        }


        private void PopulateComboBoxes()
        {
            comboBox1.Items.Add("男");
            comboBox1.Items.Add("女");
            comboBox1.SelectedIndex = 0;

            comboBox2.Items.Add("主任");
            comboBox2.Items.Add("副主任");
            comboBox2.Items.Add("职工");
            comboBox2.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string rname = textBox2.Text;
            string rsex = comboBox1.SelectedItem.ToString() == "男" ? "m" : "f";
            string rtitle = comboBox2.SelectedItem.ToString();
            int rcan = int.Parse(textBox1.Text);
            string rdepartment = textBox3.Text;
            string rtel = textBox4.Text;

            string sql = "UPDATE Readers SET Rname = @rname, Rsex = @rsex, Rtitle = @rtitle, Rcan = @rcan, Rdepartment = @rdepartment, Rtel = @rtel WHERE Rno = @rno";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@rno", rno);
                command.Parameters.AddWithValue("@rname", rname);
                command.Parameters.AddWithValue("@rsex", rsex);
                command.Parameters.AddWithValue("@rtitle", rtitle);
                command.Parameters.AddWithValue("@rcan", rcan);
                command.Parameters.AddWithValue("@rdepartment", rdepartment);
                command.Parameters.AddWithValue("@rtel", rtel);

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("修改成功");
                }
                else
                {
                    MessageBox.Show("修改失败");
                }
            }
        }
    }
}
