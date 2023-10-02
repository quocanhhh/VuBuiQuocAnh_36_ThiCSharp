namespace VuBuiQuocAnh_36_ThiCSharp
{
    partial class dinhdang
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
            this.txtnhapten = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtlaptrinh = new System.Windows.Forms.TextBox();
            this.radred = new System.Windows.Forms.RadioButton();
            this.radgreen = new System.Windows.Forms.RadioButton();
            this.radblue = new System.Windows.Forms.RadioButton();
            this.radblack = new System.Windows.Forms.RadioButton();
            this.ckbdam = new System.Windows.Forms.CheckBox();
            this.ckbnghieng = new System.Windows.Forms.CheckBox();
            this.ckbgachchan = new System.Windows.Forms.CheckBox();
            this.btnthoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập Tên:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtnhapten
            // 
            this.txtnhapten.Location = new System.Drawing.Point(93, 18);
            this.txtnhapten.Name = "txtnhapten";
            this.txtnhapten.Size = new System.Drawing.Size(353, 20);
            this.txtnhapten.TabIndex = 1;
            this.txtnhapten.TextChanged += new System.EventHandler(this.txtnhapten_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.radblack);
            this.groupBox1.Controls.Add(this.radblue);
            this.groupBox1.Controls.Add(this.radgreen);
            this.groupBox1.Controls.Add(this.radred);
            this.groupBox1.Location = new System.Drawing.Point(34, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 127);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Color";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.ckbgachchan);
            this.groupBox2.Controls.Add(this.ckbnghieng);
            this.groupBox2.Controls.Add(this.ckbdam);
            this.groupBox2.Location = new System.Drawing.Point(256, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(180, 127);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Font";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lập trình bởi:";
            // 
            // txtlaptrinh
            // 
            this.txtlaptrinh.Location = new System.Drawing.Point(108, 237);
            this.txtlaptrinh.Name = "txtlaptrinh";
            this.txtlaptrinh.Size = new System.Drawing.Size(338, 20);
            this.txtlaptrinh.TabIndex = 5;
            // 
            // radred
            // 
            this.radred.AutoSize = true;
            this.radred.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radred.ForeColor = System.Drawing.Color.Red;
            this.radred.Location = new System.Drawing.Point(20, 28);
            this.radred.Name = "radred";
            this.radred.Size = new System.Drawing.Size(48, 17);
            this.radred.TabIndex = 0;
            this.radred.TabStop = true;
            this.radred.Text = "Red";
            this.radred.UseVisualStyleBackColor = true;
            this.radred.CheckedChanged += new System.EventHandler(this.radred_CheckedChanged);
            // 
            // radgreen
            // 
            this.radgreen.AutoSize = true;
            this.radgreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radgreen.ForeColor = System.Drawing.Color.Green;
            this.radgreen.Location = new System.Drawing.Point(20, 51);
            this.radgreen.Name = "radgreen";
            this.radgreen.Size = new System.Drawing.Size(59, 17);
            this.radgreen.TabIndex = 1;
            this.radgreen.TabStop = true;
            this.radgreen.Text = "Green";
            this.radgreen.UseVisualStyleBackColor = true;
            this.radgreen.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radblue
            // 
            this.radblue.AutoSize = true;
            this.radblue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radblue.ForeColor = System.Drawing.Color.Blue;
            this.radblue.Location = new System.Drawing.Point(20, 74);
            this.radblue.Name = "radblue";
            this.radblue.Size = new System.Drawing.Size(50, 17);
            this.radblue.TabIndex = 2;
            this.radblue.TabStop = true;
            this.radblue.Text = "Blue";
            this.radblue.UseVisualStyleBackColor = true;
            this.radblue.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radblack
            // 
            this.radblack.AutoSize = true;
            this.radblack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radblack.ForeColor = System.Drawing.Color.Black;
            this.radblack.Location = new System.Drawing.Point(20, 97);
            this.radblack.Name = "radblack";
            this.radblack.Size = new System.Drawing.Size(57, 17);
            this.radblack.TabIndex = 3;
            this.radblack.TabStop = true;
            this.radblack.Text = "Black";
            this.radblack.UseVisualStyleBackColor = true;
            this.radblack.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // ckbdam
            // 
            this.ckbdam.AutoSize = true;
            this.ckbdam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbdam.ForeColor = System.Drawing.Color.Blue;
            this.ckbdam.Location = new System.Drawing.Point(25, 31);
            this.ckbdam.Name = "ckbdam";
            this.ckbdam.Size = new System.Drawing.Size(80, 17);
            this.ckbdam.TabIndex = 0;
            this.ckbdam.Text = "Đậm Bold";
            this.ckbdam.UseVisualStyleBackColor = true;
            this.ckbdam.CheckedChanged += new System.EventHandler(this.ckbdam_CheckedChanged);
            // 
            // ckbnghieng
            // 
            this.ckbnghieng.AutoSize = true;
            this.ckbnghieng.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbnghieng.ForeColor = System.Drawing.Color.Blue;
            this.ckbnghieng.Location = new System.Drawing.Point(25, 63);
            this.ckbnghieng.Name = "ckbnghieng";
            this.ckbnghieng.Size = new System.Drawing.Size(105, 17);
            this.ckbnghieng.TabIndex = 1;
            this.ckbnghieng.Text = "Nghiêng Italic";
            this.ckbnghieng.UseVisualStyleBackColor = true;
            this.ckbnghieng.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // ckbgachchan
            // 
            this.ckbgachchan.AutoSize = true;
            this.ckbgachchan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbgachchan.ForeColor = System.Drawing.Color.Blue;
            this.ckbgachchan.Location = new System.Drawing.Point(25, 98);
            this.ckbgachchan.Name = "ckbgachchan";
            this.ckbgachchan.Size = new System.Drawing.Size(88, 17);
            this.ckbgachchan.TabIndex = 2;
            this.ckbgachchan.Text = "Gạch chân";
            this.ckbgachchan.UseVisualStyleBackColor = true;
            this.ckbgachchan.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(23, 276);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(423, 56);
            this.btnthoat.TabIndex = 6;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.button1_Click);
            // 
            // dinhdang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 344);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.txtlaptrinh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtnhapten);
            this.Controls.Add(this.label1);
            this.Name = "dinhdang";
            this.Text = "dinhdang";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnhapten;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtlaptrinh;
        private System.Windows.Forms.RadioButton radblack;
        private System.Windows.Forms.RadioButton radblue;
        private System.Windows.Forms.RadioButton radgreen;
        private System.Windows.Forms.RadioButton radred;
        private System.Windows.Forms.CheckBox ckbnghieng;
        private System.Windows.Forms.CheckBox ckbdam;
        private System.Windows.Forms.CheckBox ckbgachchan;
        private System.Windows.Forms.Button btnthoat;
    }
}