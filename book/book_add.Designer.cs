namespace book
{
    partial class book_add
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(book_add));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_book_add_check = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_bno = new System.Windows.Forms.TextBox();
            this.txt_bsum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_bname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_bauthor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_bpublish = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-3, -3);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1062, 331);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-3, 327);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1056, 587);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_book_add_check);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_bno);
            this.groupBox1.Controls.Add(this.txt_bsum);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_bname);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_bauthor);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_bpublish);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Location = new System.Drawing.Point(182, 446);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(668, 359);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "图书信息";
            // 
            // btn_book_add_check
            // 
            this.btn_book_add_check.Location = new System.Drawing.Point(257, 224);
            this.btn_book_add_check.Name = "btn_book_add_check";
            this.btn_book_add_check.Size = new System.Drawing.Size(179, 59);
            this.btn_book_add_check.TabIndex = 38;
            this.btn_book_add_check.Text = "确认";
            this.btn_book_add_check.UseVisualStyleBackColor = true;
            this.btn_book_add_check.Click += new System.EventHandler(this.btn_book_add_check_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "ISBN";
            // 
            // txt_bno
            // 
            this.txt_bno.Location = new System.Drawing.Point(116, 36);
            this.txt_bno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_bno.Name = "txt_bno";
            this.txt_bno.Size = new System.Drawing.Size(177, 35);
            this.txt_bno.TabIndex = 16;
            // 
            // txt_bsum
            // 
            this.txt_bsum.Location = new System.Drawing.Point(116, 168);
            this.txt_bsum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_bsum.Name = "txt_bsum";
            this.txt_bsum.Size = new System.Drawing.Size(177, 35);
            this.txt_bsum.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(359, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "书名";
            // 
            // txt_bname
            // 
            this.txt_bname.Location = new System.Drawing.Point(425, 36);
            this.txt_bname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_bname.Name = "txt_bname";
            this.txt_bname.Size = new System.Drawing.Size(177, 35);
            this.txt_bname.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(359, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "作者";
            // 
            // txt_bauthor
            // 
            this.txt_bauthor.Location = new System.Drawing.Point(425, 101);
            this.txt_bauthor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_bauthor.Name = "txt_bauthor";
            this.txt_bauthor.Size = new System.Drawing.Size(177, 35);
            this.txt_bauthor.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 104);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "出版社";
            // 
            // txt_bpublish
            // 
            this.txt_bpublish.Location = new System.Drawing.Point(116, 101);
            this.txt_bpublish.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_bpublish.Name = "txt_bpublish";
            this.txt_bpublish.Size = new System.Drawing.Size(177, 35);
            this.txt_bpublish.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 172);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 24);
            this.label12.TabIndex = 13;
            this.label12.Text = "馆藏数量";
            // 
            // book_add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 903);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "book_add";
            this.Text = "图书信息添加";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_book_add_check;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_bno;
        private System.Windows.Forms.TextBox txt_bsum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_bname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_bauthor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_bpublish;
        private System.Windows.Forms.Label label12;
    }
}