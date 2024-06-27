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
    public partial class book_add : Form
    {
        public book_add()
        {
            InitializeComponent();
        }

        private void btn_book_add_check_Click(object sender, EventArgs e)
        {
            string bno = this.txt_bno.Text;
            string bname = this.txt_bname.Text;
            string bauthor = this.txt_bauthor.Text;
            string bpublish = this.txt_bpublish.Text;
            string bsum=this.txt_bsum.Text;
            string sql = "insert into Book values('" + bno + "','" + bname + "','" +
            bpublish + "','" + bauthor + "',"+bsum+","+bsum+ ")";
            book.ExecuteSql(sql);
            this.Close();
        }
    }
}
