namespace book
{
    partial class book
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(book));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_book_find = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_bno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_bname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_bauthor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_bpublish = new System.Windows.Forms.TextBox();
            this.btn_book_update = new System.Windows.Forms.Button();
            this.btn_book_delete = new System.Windows.Forms.Button();
            this.btn_book_add = new System.Windows.Forms.Button();
            this.bookList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookList)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, -5);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1055, 326);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, -5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1054, 840);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_book_find);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_bno);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_bname);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_bauthor);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_bpublish);
            this.groupBox1.Location = new System.Drawing.Point(36, 329);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(979, 159);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "图书信息";
            // 
            // btn_book_find
            // 
            this.btn_book_find.Location = new System.Drawing.Point(735, 88);
            this.btn_book_find.Name = "btn_book_find";
            this.btn_book_find.Size = new System.Drawing.Size(179, 59);
            this.btn_book_find.TabIndex = 38;
            this.btn_book_find.Text = "查询";
            this.btn_book_find.UseVisualStyleBackColor = true;
            this.btn_book_find.Click += new System.EventHandler(this.btn_book_find_Click);
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
            this.txt_bno.Margin = new System.Windows.Forms.Padding(4);
            this.txt_bno.Name = "txt_bno";
            this.txt_bno.Size = new System.Drawing.Size(177, 35);
            this.txt_bno.TabIndex = 16;
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
            this.txt_bname.Margin = new System.Windows.Forms.Padding(4);
            this.txt_bname.Name = "txt_bname";
            this.txt_bname.Size = new System.Drawing.Size(177, 35);
            this.txt_bname.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(668, 40);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "作者";
            // 
            // txt_bauthor
            // 
            this.txt_bauthor.Location = new System.Drawing.Point(735, 36);
            this.txt_bauthor.Margin = new System.Windows.Forms.Padding(4);
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
            this.txt_bpublish.Margin = new System.Windows.Forms.Padding(4);
            this.txt_bpublish.Name = "txt_bpublish";
            this.txt_bpublish.Size = new System.Drawing.Size(177, 35);
            this.txt_bpublish.TabIndex = 19;
            // 
            // btn_book_update
            // 
            this.btn_book_update.Location = new System.Drawing.Point(819, 750);
            this.btn_book_update.Name = "btn_book_update";
            this.btn_book_update.Size = new System.Drawing.Size(117, 61);
            this.btn_book_update.TabIndex = 44;
            this.btn_book_update.Text = "编辑";
            this.btn_book_update.UseVisualStyleBackColor = true;
            this.btn_book_update.Click += new System.EventHandler(this.btn_book_update_Click);
            // 
            // btn_book_delete
            // 
            this.btn_book_delete.Location = new System.Drawing.Point(483, 750);
            this.btn_book_delete.Name = "btn_book_delete";
            this.btn_book_delete.Size = new System.Drawing.Size(113, 61);
            this.btn_book_delete.TabIndex = 43;
            this.btn_book_delete.Text = "删除";
            this.btn_book_delete.UseVisualStyleBackColor = true;
            this.btn_book_delete.Click += new System.EventHandler(this.btn_book_delete_Click);
            // 
            // btn_book_add
            // 
            this.btn_book_add.Location = new System.Drawing.Point(152, 750);
            this.btn_book_add.Name = "btn_book_add";
            this.btn_book_add.Size = new System.Drawing.Size(120, 61);
            this.btn_book_add.TabIndex = 42;
            this.btn_book_add.Text = "新增";
            this.btn_book_add.UseVisualStyleBackColor = true;
            this.btn_book_add.Click += new System.EventHandler(this.btn_book_add_Click);
            // 
            // bookList
            // 
            this.bookList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookList.Location = new System.Drawing.Point(36, 485);
            this.bookList.Name = "bookList";
            this.bookList.RowHeadersWidth = 62;
            this.bookList.RowTemplate.Height = 30;
            this.bookList.Size = new System.Drawing.Size(979, 260);
            this.bookList.TabIndex = 41;
            // 
            // book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 833);
            this.Controls.Add(this.btn_book_update);
            this.Controls.Add(this.btn_book_delete);
            this.Controls.Add(this.btn_book_add);
            this.Controls.Add(this.bookList);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "book";
            this.Text = "图书档案管理";
            this.Load += new System.EventHandler(this.book_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_bno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_bname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_bauthor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_bpublish;
        private System.Windows.Forms.Button btn_book_find;
        private System.Windows.Forms.Button btn_book_update;
        private System.Windows.Forms.Button btn_book_delete;
        private System.Windows.Forms.Button btn_book_add;
        private System.Windows.Forms.DataGridView bookList;
    }
}