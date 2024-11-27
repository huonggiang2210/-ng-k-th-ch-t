namespace Đăng_ký_thể_chất
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_ten = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btt_phai = new System.Windows.Forms.Button();
            this.btt_phaihet = new System.Windows.Forms.Button();
            this.btt_trai = new System.Windows.Forms.Button();
            this.btt_traihet = new System.Windows.Forms.Button();
            this.btt_add = new System.Windows.Forms.Button();
            this.btt_reset = new System.Windows.Forms.Button();
            this.btt_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Danh sách môn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(533, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Danh sách chọn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(90, 372);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Kết quả";
            // 
            // txt_ten
            // 
            this.txt_ten.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ten.Location = new System.Drawing.Point(184, 49);
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.Size = new System.Drawing.Size(305, 28);
            this.txt_ten.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(79, 391);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(333, 148);
            this.textBox2.TabIndex = 6;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "Bóng đá",
            "Bóng bàn",
            "Nhảy dù",
            "Bóng chuyền",
            "Cầu lông",
            "Đá cầu"});
            this.listBox1.Location = new System.Drawing.Point(96, 205);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(187, 148);
            this.listBox1.TabIndex = 7;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(536, 205);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(178, 148);
            this.listBox2.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(184, 91);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(305, 22);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // btt_phai
            // 
            this.btt_phai.Location = new System.Drawing.Point(363, 205);
            this.btt_phai.Name = "btt_phai";
            this.btt_phai.Size = new System.Drawing.Size(75, 23);
            this.btt_phai.TabIndex = 10;
            this.btt_phai.Text = ">";
            this.btt_phai.UseVisualStyleBackColor = true;
            this.btt_phai.Click += new System.EventHandler(this.btt_phai_Click);
            // 
            // btt_phaihet
            // 
            this.btt_phaihet.Location = new System.Drawing.Point(363, 243);
            this.btt_phaihet.Name = "btt_phaihet";
            this.btt_phaihet.Size = new System.Drawing.Size(75, 23);
            this.btt_phaihet.TabIndex = 11;
            this.btt_phaihet.Text = ">>";
            this.btt_phaihet.UseVisualStyleBackColor = true;
            this.btt_phaihet.Click += new System.EventHandler(this.btt_phaihet_Click);
            // 
            // btt_trai
            // 
            this.btt_trai.Location = new System.Drawing.Point(363, 282);
            this.btt_trai.Name = "btt_trai";
            this.btt_trai.Size = new System.Drawing.Size(75, 23);
            this.btt_trai.TabIndex = 12;
            this.btt_trai.Text = "<";
            this.btt_trai.UseVisualStyleBackColor = true;
            this.btt_trai.Click += new System.EventHandler(this.btt_trai_Click);
            // 
            // btt_traihet
            // 
            this.btt_traihet.Location = new System.Drawing.Point(363, 311);
            this.btt_traihet.Name = "btt_traihet";
            this.btt_traihet.Size = new System.Drawing.Size(75, 23);
            this.btt_traihet.TabIndex = 13;
            this.btt_traihet.Text = "<<";
            this.btt_traihet.UseVisualStyleBackColor = true;
            this.btt_traihet.Click += new System.EventHandler(this.btt_traihet_Click);
            // 
            // btt_add
            // 
            this.btt_add.Location = new System.Drawing.Point(587, 396);
            this.btt_add.Name = "btt_add";
            this.btt_add.Size = new System.Drawing.Size(75, 23);
            this.btt_add.TabIndex = 14;
            this.btt_add.Text = "Nhập";
            this.btt_add.UseVisualStyleBackColor = true;
            this.btt_add.Click += new System.EventHandler(this.btt_add_Click);
            // 
            // btt_reset
            // 
            this.btt_reset.Location = new System.Drawing.Point(587, 438);
            this.btt_reset.Name = "btt_reset";
            this.btt_reset.Size = new System.Drawing.Size(75, 23);
            this.btt_reset.TabIndex = 15;
            this.btt_reset.Text = "Reset";
            this.btt_reset.UseVisualStyleBackColor = true;
            this.btt_reset.Click += new System.EventHandler(this.btt_reset_Click);
            // 
            // btt_exit
            // 
            this.btt_exit.Location = new System.Drawing.Point(587, 485);
            this.btt_exit.Name = "btt_exit";
            this.btt_exit.Size = new System.Drawing.Size(75, 23);
            this.btt_exit.TabIndex = 16;
            this.btt_exit.Text = "Thoát";
            this.btt_exit.UseVisualStyleBackColor = true;
            this.btt_exit.Click += new System.EventHandler(this.btt_exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 551);
            this.Controls.Add(this.btt_exit);
            this.Controls.Add(this.btt_reset);
            this.Controls.Add(this.btt_add);
            this.Controls.Add(this.btt_traihet);
            this.Controls.Add(this.btt_trai);
            this.Controls.Add(this.btt_phaihet);
            this.Controls.Add(this.btt_phai);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txt_ten);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_ten;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btt_phai;
        private System.Windows.Forms.Button btt_phaihet;
        private System.Windows.Forms.Button btt_trai;
        private System.Windows.Forms.Button btt_traihet;
        private System.Windows.Forms.Button btt_add;
        private System.Windows.Forms.Button btt_reset;
        private System.Windows.Forms.Button btt_exit;
    }
}

