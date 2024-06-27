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
    public partial class Readers_bookfind : Form
    {
        public Readers_bookfind()
        {
            InitializeComponent();
        }

        private void btn_book_find_Click(object sender, EventArgs e)
        {
            string bno = this.txt_bno.Text;
            string bname = this.txt_bname.Text;
            string bauthor = this.txt_bauthor.Text;
            string bpublish = this.txt_bpublish.Text;
            //string bsum=this.txt_bsum.Text;
            this.bookList.DataSource = book.Query("select * from Book where Bno like'%" + bno + "%' and Bname like'%" + bname + "%'and Bauthor like'%" + bauthor + "%'and Bpublish like'%" + bpublish + "%'").Tables["Book"];
        }
    }
}
