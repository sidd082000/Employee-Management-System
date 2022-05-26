
namespace LoginForm
{
    partial class Form2
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
            this.save = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.changepass = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.Label();
            this.loginname = new System.Windows.Forms.Label();
            this.employment = new System.Windows.Forms.Label();
            this.dept = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.role = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.checkbox1 = new System.Windows.Forms.CheckBox();
            this.details = new System.Windows.Forms.DataGridView();
            this.searchbtn = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.details)).BeginInit();
            this.SuspendLayout();
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.save.Location = new System.Drawing.Point(89, 283);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(133, 40);
            this.save.TabIndex = 0;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.button1_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.delete.Location = new System.Drawing.Point(270, 283);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(128, 40);
            this.delete.TabIndex = 1;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.button2_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.update.Location = new System.Drawing.Point(448, 283);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(124, 40);
            this.update.TabIndex = 2;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // changepass
            // 
            this.changepass.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.changepass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changepass.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.changepass.Location = new System.Drawing.Point(618, 285);
            this.changepass.Name = "changepass";
            this.changepass.Size = new System.Drawing.Size(280, 40);
            this.changepass.TabIndex = 3;
            this.changepass.Text = "Change Password";
            this.changepass.UseVisualStyleBackColor = false;
            this.changepass.Click += new System.EventHandler(this.changepass_Click);
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(106, 63);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(110, 25);
            this.username.TabIndex = 4;
            this.username.Text = "Username";
            this.username.Click += new System.EventHandler(this.label1_Click);
            // 
            // loginname
            // 
            this.loginname.AutoSize = true;
            this.loginname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginname.Location = new System.Drawing.Point(107, 106);
            this.loginname.Name = "loginname";
            this.loginname.Size = new System.Drawing.Size(127, 25);
            this.loginname.TabIndex = 5;
            this.loginname.Text = "Login Name";
            // 
            // employment
            // 
            this.employment.AutoSize = true;
            this.employment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employment.Location = new System.Drawing.Point(704, 63);
            this.employment.Name = "employment";
            this.employment.Size = new System.Drawing.Size(185, 25);
            this.employment.TabIndex = 6;
            this.employment.Text = "Employment Type";
            // 
            // dept
            // 
            this.dept.AutoSize = true;
            this.dept.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dept.Location = new System.Drawing.Point(704, 109);
            this.dept.Name = "dept";
            this.dept.Size = new System.Drawing.Size(123, 25);
            this.dept.TabIndex = 7;
            this.dept.Text = "Department";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(106, 153);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(106, 25);
            this.password.TabIndex = 8;
            this.password.Text = "Password";
            this.password.Click += new System.EventHandler(this.password_Click);
            // 
            // role
            // 
            this.role.AutoSize = true;
            this.role.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.role.Location = new System.Drawing.Point(107, 197);
            this.role.Name = "role";
            this.role.Size = new System.Drawing.Size(55, 25);
            this.role.TabIndex = 9;
            this.role.Text = "Role";
            this.role.Click += new System.EventHandler(this.label6_Click);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.close.Location = new System.Drawing.Point(1118, 283);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(130, 40);
            this.close.TabIndex = 10;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(303, 150);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(149, 28);
            this.textBox1.TabIndex = 11;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(304, 105);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(149, 28);
            this.textBox3.TabIndex = 13;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(938, 108);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(149, 28);
            this.textBox4.TabIndex = 14;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.comboBox1.Location = new System.Drawing.Point(304, 196);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(149, 30);
            this.comboBox1.TabIndex = 15;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "External",
            "Internal"});
            this.comboBox2.Location = new System.Drawing.Point(938, 60);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(149, 30);
            this.comboBox2.TabIndex = 16;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // checkbox1
            // 
            this.checkbox1.AutoSize = true;
            this.checkbox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbox1.Location = new System.Drawing.Point(709, 152);
            this.checkbox1.Name = "checkbox1";
            this.checkbox1.Size = new System.Drawing.Size(149, 29);
            this.checkbox1.TabIndex = 17;
            this.checkbox1.Text = "User Active";
            this.checkbox1.UseVisualStyleBackColor = true;
            this.checkbox1.CheckedChanged += new System.EventHandler(this.useractive_CheckedChanged);
            // 
            // details
            // 
            this.details.AllowUserToAddRows = false;
            this.details.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.details.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.details.Location = new System.Drawing.Point(89, 420);
            this.details.Name = "details";
            this.details.RowHeadersWidth = 62;
            this.details.RowTemplate.Height = 28;
            this.details.Size = new System.Drawing.Size(1159, 280);
            this.details.TabIndex = 18;
            this.details.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // searchbtn
            // 
            this.searchbtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.searchbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.searchbtn.Location = new System.Drawing.Point(353, 353);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(128, 38);
            this.searchbtn.TabIndex = 19;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = false;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(34, 359);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(298, 28);
            this.textBox5.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(507, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 38);
            this.button1.TabIndex = 21;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(494, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 22;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(304, 60);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(149, 28);
            this.textBox2.TabIndex = 23;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button2.Location = new System.Drawing.Point(938, 283);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 40);
            this.button2.TabIndex = 24;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1339, 712);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.role);
            this.Controls.Add(this.password);
            this.Controls.Add(this.loginname);
            this.Controls.Add(this.username);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.details);
            this.Controls.Add(this.checkbox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.close);
            this.Controls.Add(this.dept);
            this.Controls.Add(this.employment);
            this.Controls.Add(this.changepass);
            this.Controls.Add(this.update);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.save);
            this.Name = "Form2";
            this.Text = "Login Details";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.details)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button changepass;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label loginname;
        private System.Windows.Forms.Label employment;
        private System.Windows.Forms.Label dept;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label role;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.CheckBox checkbox1;
        private System.Windows.Forms.DataGridView details;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
    }
}