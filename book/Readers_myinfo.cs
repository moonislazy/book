using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace book
{
    public partial class Readers_myinfo : Form
    {
        static string Rno="";
        public Readers_myinfo(string rno)
        {
            InitializeComponent();
            Rno=rno;
            label_rno.Text = Rno;
            DataSet temp;
            string sql = "select * from Readers where Rno=" + Rno ;
            temp = book.Query(sql);
            label_rname.Text = temp.Tables[0].Rows[0][1].ToString();
            label_rsex.Text = temp.Tables[0].Rows[0][2].ToString();
            label_rtitle.Text = temp.Tables[0].Rows[0][3].ToString();
            label_rcan.Text = temp.Tables[0].Rows[0][4].ToString();
            label_rborrow.Text = temp.Tables[0].Rows[0][5].ToString();
            label_rdepart.Text = temp.Tables[0].Rows[0][6].ToString();
            txt_rtel.Text = temp.Tables[0].Rows[0][7].ToString();


            string sql2 = "count_fine @Rno=" + Rno;
            label_fine.Text = book.Query(sql2).Tables[0].Rows[0][0].ToString();
            
            
            string sql3 = "select count(*) from Borrow where Rno='" + Rno + "'";
            label_overtime.Text = book.Query(sql3).Tables[0].Rows[0][0].ToString();
        }


        private void btn_myinfo_check_Click(object sender, EventArgs e)
        {
            string rtel = txt_rtel.Text;
            string sql = "update Readers set Rtel='"+rtel+"' where Rno='" + Rno + "'";
            book.ExecuteSql(sql);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
