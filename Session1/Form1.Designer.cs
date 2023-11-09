namespace Session1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            panel1 = new Panel();
            check_password = new CheckBox();
            check_keepmesigned = new CheckBox();
            text_password = new TextBox();
            label4 = new Label();
            text_user = new TextBox();
            text_username = new Label();
            text_employee = new TextBox();
            label3 = new Label();
            label2 = new Label();
            btn_login = new Button();
            btn_exit = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Location = new Point(293, 9);
            label1.Name = "label1";
            label1.Padding = new Padding(10);
            label1.Size = new Size(56, 37);
            label1.TabIndex = 0;
            label1.Text = "Logo";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(check_password);
            panel1.Controls.Add(check_keepmesigned);
            panel1.Controls.Add(text_password);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(text_user);
            panel1.Controls.Add(text_username);
            panel1.Controls.Add(text_employee);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(39, 68);
            panel1.Name = "panel1";
            panel1.Size = new Size(590, 296);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // check_password
            // 
            check_password.AutoSize = true;
            check_password.Location = new Point(437, 175);
            check_password.Name = "check_password";
            check_password.Size = new Size(108, 19);
            check_password.TabIndex = 7;
            check_password.Text = "Show Password";
            check_password.UseVisualStyleBackColor = true;
            check_password.CheckedChanged += check_password_CheckedChanged;
            // 
            // check_keepmesigned
            // 
            check_keepmesigned.AutoSize = true;
            check_keepmesigned.Location = new Point(437, 100);
            check_keepmesigned.Name = "check_keepmesigned";
            check_keepmesigned.Size = new Size(124, 19);
            check_keepmesigned.TabIndex = 6;
            check_keepmesigned.Text = "Keep Me Signed In";
            check_keepmesigned.UseVisualStyleBackColor = true;
            // 
            // text_password
            // 
            text_password.Location = new Point(103, 216);
            text_password.Name = "text_password";
            text_password.Size = new Size(268, 23);
            text_password.TabIndex = 5;
            text_password.TextChanged += text_password_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 219);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 4;
            label4.Text = "Password:";
            // 
            // text_user
            // 
            text_user.Location = new Point(103, 136);
            text_user.Name = "text_user";
            text_user.Size = new Size(268, 23);
            text_user.TabIndex = 3;
            // 
            // text_username
            // 
            text_username.AutoSize = true;
            text_username.Location = new Point(64, 139);
            text_username.Name = "text_username";
            text_username.Size = new Size(33, 15);
            text_username.TabIndex = 2;
            text_username.Text = "User:";
            // 
            // text_employee
            // 
            text_employee.Location = new Point(103, 52);
            text_employee.Name = "text_employee";
            text_employee.Size = new Size(268, 23);
            text_employee.TabIndex = 1;
            text_employee.TextChanged += text_employee_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 55);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 0;
            label3.Text = "Employee:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(70, 57);
            label2.Name = "label2";
            label2.Size = new Size(49, 21);
            label2.TabIndex = 2;
            label2.Text = "Login";
            // 
            // btn_login
            // 
            btn_login.Location = new Point(212, 370);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(101, 23);
            btn_login.TabIndex = 3;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // btn_exit
            // 
            btn_exit.Location = new Point(350, 370);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(101, 23);
            btn_exit.TabIndex = 4;
            btn_exit.Text = "Exit";
            btn_exit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(672, 413);
            Controls.Add(btn_exit);
            Controls.Add(btn_login);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Seoul Stay - Welcome";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private TextBox text_password;
        private Label label4;
        private TextBox text_user;
        private Label text_username;
        private TextBox text_employee;
        private Label label3;
        private Label label2;
        private CheckBox check_password;
        private CheckBox check_keepmesigned;
        private Button btn_login;
        private Button btn_exit;
    }
}