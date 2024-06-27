using System;
using System.Collections;
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
    public partial class borrowfind : Form
    {
        public borrowfind()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            
            if (comboBox1.Text == "按图书查询未还读者")
            {
                string bno=txt_borrow_find.Text;
                string sql ="Rnotreturn @Bno ='" + bno + "'";
                this.unreturnList.DataSource = book.Query(sql).Tables[0]; ;
            }
            else if(comboBox1.Text == "按读者查询未还图书")
            {
                string rno = txt_borrow_find.Text;
                string sql = "Bnotreturn @Rno=" + rno ;
                this.unreturnList.DataSource = book.Query(sql).Tables[0]; 
            }
            else if (comboBox1.Text == "到期图书查询")
            {
                string sql = "EXEC GetOverdueBooks";
                this.unreturnList.DataSource = book.Query(sql).Tables[0];
            }

        }
    }
}
