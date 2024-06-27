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
    public partial class manage : Form
    {
        public manage(string name)
        {
            InitializeComponent();
            label2.Text = name;
        }

        //图书档案管理
        private void btn_book_Click(object sender, EventArgs e)
        {
            book childrenForm = new book();
            childrenForm.Owner = this;
            childrenForm.Show();
        }

        //查找图书
        private void btn_borrow_find_Click(object sender, EventArgs e)
        {
            borrowfind childrenForm = new borrowfind();
            childrenForm.Owner = this;
            childrenForm.Show();
        }

        //读者档案管理
        private void btn_readers_Click(object sender, EventArgs e)
        {
            Rinfo childrenFrom= new Rinfo();
            childrenFrom.Owner = this;
            childrenFrom.Show();
        }

        //图书借阅管理
        private void btn_borrow_Click(object sender, EventArgs e)
        {
            borrow childrenFrom = new borrow();
            childrenFrom.Owner = this;
            childrenFrom.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
