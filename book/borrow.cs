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
    public partial class borrow : Form
    {
        public borrow()
        {
            InitializeComponent();
        }

        static string connectionString = System.Configuration.ConfigurationManager.AppSettings["connectionString"];

        private void btn_borrow_Click(object sender, EventArgs e)
        {
            string bno = txt_borrow_bno.Text;
            string rno = txt_borrow_rno.Text;
            string sql0 = "select Rno from Readers where Rno=" + rno;
            string sql1 = "count_fine @Rno=" + rno;
            string sql2 = "select Rno from Readers where Rcan>Rborrow and Rno=" + rno;
            string sql3 = "select Rno from unreturnbook where Rno=" + rno;
            string sql4 = "select Bno from Book where Bleft>0 and Bno='" + bno+"'";
            string sql4_1 = "select * from Borrow where Bno='" + bno + "' and Rno="+rno+" and returntime is null";
            int wrong = 0;
            if (book.Query(sql0).Tables[0].Rows.Count == 0) { 
                MessageBox.Show("读者不存在！");
                wrong++;
            }
            else
            {
                if (!book.Query(sql1).Tables[0].Rows[0][0].ToString().Equals(""))
                {
                    //MessageBox.Show(book.Query(sql1).Tables[0].Rows[0][0].ToString());
                    if (Convert.ToDouble(book.Query(sql1).Tables[0].Rows[0][0].ToString()) > 0)
                    {
                        MessageBox.Show("罚款未缴纳！");
                        wrong++;
                    }
                }
                if (book.Query(sql2).Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("可借书籍已达上限！");
                    wrong++;
                }
                if (int.Parse(book.Query(sql3).Tables[0].Rows.Count.ToString()) > 0)
                {
                    MessageBox.Show("存在逾期未还图书！");
                    wrong++;
                }
                if (book.Query(sql4).Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("图书不可借阅！");
                    wrong++;
                }
                if (book.Query(sql4_1).Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show("该书借阅未还！");
                    wrong++;
                }
            }
            if(wrong==0)
            {
                string sql = "insert into Borrow values(" + rno + ",'" + bno + "',GETDATE(),30,null,0,0)";
                book.ExecuteSql(sql);
                string sql5 = "select Bleft from Book where Bleft>0 and Bno='" + bno + "'";
                label_bleft.Text = book.Query(sql5).Tables[0].Rows[0][0].ToString();
                string sql6 = "select Borrowperiod,Borrowtime,dateadd(dd,Borrowperiod,Borrowtime) from Borrow where Bno='" + bno + "' and Rno="+rno+ " and datediff(dd,Borrowtime,GETDATE())=0";
                //DataSet temp = book.Query(sql6);
                label_period.Text = book.Query(sql6).Tables[0].Rows[0][0].ToString()+"天";
                label_rentday.Text = book.Query(sql6).Tables[0].Rows[0][1].ToString();
                label_returnday.Text = book.Query(sql6).Tables[0].Rows[0][2].ToString();
                MessageBox.Show("借阅成功！");
            }
            
           // MessageBox.Show(book.Query(sql4).Tables[0].Rows.Count.ToString());
        }

        private void btn_ruturn_Click(object sender, EventArgs e)
        {
            string bno = txt_borrow_bno.Text;
            string rno = txt_borrow_rno.Text;
            string sql = "update Borrow set Returntime=GETDATE() where Rno=" + rno + " and Bno='" + bno + "' and Returntime is null";
            book.ExecuteSql(sql);
            MessageBox.Show("还书成功！");
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
