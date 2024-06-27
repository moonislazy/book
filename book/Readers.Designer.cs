namespace book
{
    partial class Readers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Readers));
            this.button1 = new System.Windows.Forms.Button();
            this.btn_readers = new System.Windows.Forms.Button();
            this.btn_borrow_find = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_my_unreturn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(206, 628);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(272, 174);
            this.button1.TabIndex = 20;
            this.button1.Text = "逾期借阅";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_readers
            // 
            this.btn_readers.Location = new System.Drawing.Point(617, 628);
            this.btn_readers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_readers.Name = "btn_readers";
            this.btn_readers.Size = new System.Drawing.Size(272, 174);
            this.btn_readers.TabIndex = 19;
            this.btn_readers.Text = "我的";
            this.btn_readers.UseVisualStyleBackColor = true;
            this.btn_readers.Click += new System.EventHandler(this.btn_readers_Click);
            // 
            // btn_borrow_find
            // 
            this.btn_borrow_find.Location = new System.Drawing.Point(617, 422);
            this.btn_borrow_find.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_borrow_find.Name = "btn_borrow_find";
            this.btn_borrow_find.Size = new System.Drawing.Size(272, 174);
            this.btn_borrow_find.TabIndex = 18;
            this.btn_borrow_find.Text = "查找图书";
            this.btn_borrow_find.UseVisualStyleBackColor = true;
            this.btn_borrow_find.Click += new System.EventHandler(this.btn_borrow_find_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Azure;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(13, 335);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 17;
            this.label2.Text = "label2";
            // 
            // btn_my_unreturn
            // 
            this.btn_my_unreturn.Location = new System.Drawing.Point(206, 422);
            this.btn_my_unreturn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_my_unreturn.Name = "btn_my_unreturn";
            this.btn_my_unreturn.Size = new System.Drawing.Size(272, 174);
            this.btn_my_unreturn.TabIndex = 15;
            this.btn_my_unreturn.Text = "当前借阅";
            this.btn_my_unreturn.UseVisualStyleBackColor = true;
            this.btn_my_unreturn.Click += new System.EventHandler(this.btn_my_unreturn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-5, 363);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1062, 471);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Azure;
            this.pictureBox2.Location = new System.Drawing.Point(-5, 328);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1062, 41);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(-5, 0);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1062, 331);
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // Readers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 833);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_readers);
            this.Controls.Add(this.btn_borrow_find);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_my_unreturn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Readers";
            this.Text = "读者";
            this.Load += new System.EventHandler(this.Readers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_readers;
        private System.Windows.Forms.Button btn_borrow_find;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_my_unreturn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}