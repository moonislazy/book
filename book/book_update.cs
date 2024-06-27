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
    public partial class book_update : Form
    {
        public book_update(string bno, string bname, string bauthor, string bpublish, string bsum)
        {
            InitializeComponent();
            this.txt_bno.Text = bno;
            this.txt_bname.Text = bname;
            this.txt_bauthor.Text = bauthor;
            this.txt_bpublish.Text = bpublish;
            this.label_bsum.Text = bsum;
        }

        private void btn_book_add_check_Click(object sender, EventArgs e)
        {
            string bno = this.txt_bno.Text;
            string bname = this.txt_bname.Text;
            string bauthor = this.txt_bauthor.Text;
            string bpublish = this.txt_bpublish.Text;
            //string bsum = this.txt_bsum.Text;
            string sql = "update Book set Bno='"+bno+"',Bname='"+bname+"',Bauthor='"+bauthor+"',Bpublish='"+bpublish+"'";
            if(!comboBox_change.Text.Equals("")) sql=sql+",Bsum=Bsum"+ comboBox_change.Text+txt_bsum_change.Text+ ",Bleft=Bleft" + comboBox_change.Text + txt_bsum_change.Text;
            sql=sql+"where Bno='"+bno+"'";
            book.ExecuteSql(sql);
            this.Close();
        }
    }
}
