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
    public partial class Rinfo : Form
    {
        static string connectionString = System.Configuration.ConfigurationManager.AppSettings["connectionString"];

        public Rinfo()
        {
            InitializeComponent();
        }

        //查询读者档案
        private void btn_rinfo_find_Click(object sender, EventArgs e)
        {
            string rno = string.IsNullOrEmpty(this.txt_rno.Text) ? "NULL" : this.txt_rno.Text;
            string rname = string.IsNullOrEmpty(this.txt_rname.Text) ? "NULL" : "'" + this.txt_rname.Text + "'";
            string rsex = string.IsNullOrEmpty(this.txt_rsex.Text) ? "NULL" : "'" + this.txt_rsex.Text + "'";
            string rtitle = string.IsNullOrEmpty(this.txt_rtitle.Text) ? "NULL" : "'" + this.txt_rtitle.Text + "'";
            string rdepartment = string.IsNullOrEmpty(this.txt_rdepartment.Text) ? "NULL" : "'" + this.txt_rdepartment.Text + "'";
            string rtel = string.IsNullOrEmpty(this.txt_rtel.Text) ? "NULL" : "'" + this.txt_rtel.Text + "'";

            string sql = $"EXEC Rinfo @Rno={rno}, @Rname={rname}, @Rsex={rsex}, @Rtitle={rtitle}, @Rdepartment={rdepartment}, @Rtel={rtel}";
            this.RinfoList.DataSource = book.Query(sql).Tables[0];
        }

        //删除读者信息
        private void btn_rinfo_delete_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedIndex = RinfoList.CurrentRow.Index;
                string rno = RinfoList.Rows[selectedIndex].Cells[0].Value.ToString().Trim();

                string sql = "delete from Readers where Rno=@rno";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@rno", rno);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("删除成功");
                    }
                    else
                    {
                        MessageBox.Show("删除失败，未找到符合条件的记录。");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"删除操作出现错误：{ex.Message}");
            }
        }


        //查询读者未还书籍
        private void btn_Rnotreturn_Click(object sender, EventArgs e)
        {
            int a = RinfoList.CurrentRow.Index;//获取选中的行号
            string rno = RinfoList.Rows[a].Cells[0].Value.ToString().Trim();
            book_not_return childrenForm = new book_not_return(rno);
            childrenForm.Owner = this;
            childrenForm.Show();
        }

        //添加读者信息
        private void btn_rinfo__add_Click(object sender, EventArgs e)
        {
            Rinfo_add childrenForm = new Rinfo_add();
            childrenForm.Owner = this;
            childrenForm.Show();
        }

        private void btn_rinfo_update_Click(object sender, EventArgs e)
        {
            if (RinfoList.CurrentRow != null)
            {
                int selectedIndex = RinfoList.CurrentRow.Index;
                string rno = RinfoList.Rows[selectedIndex].Cells[0].Value.ToString().Trim();

                Rinfo_update updateForm = new Rinfo_update(rno);
                updateForm.ShowDialog();

                // 更新列表
                btn_rinfo_find_Click(sender, e);
            }
            else
            {
                MessageBox.Show("请根据读者编号（Rno）选择要修改的读者信息");
            }
        }

    }
}
