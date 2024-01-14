
namespace _3m_Rashed_Market
{
    partial class Login
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
            panel1 = new Panel();
            label6 = new Label();
            login_signupBtn = new Button();
            exit = new Label();
            label2 = new Label();
            label3 = new Label();
            login_username = new TextBox();
            login_password = new TextBox();
            label4 = new Label();
            login_showPass = new CheckBox();
            login_btn = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(login_signupBtn);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(355, 750);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(104, 269);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(128, 24);
            label6.TabIndex = 2;
            label6.Text = "Grocery Shop";
            label6.Click += label6_Click;
            // 
            // login_signupBtn
            // 
            login_signupBtn.BackColor = Color.White;
            login_signupBtn.Cursor = Cursors.Hand;
            login_signupBtn.FlatAppearance.BorderSize = 0;
            login_signupBtn.FlatAppearance.MouseDownBackColor = Color.Purple;
            login_signupBtn.FlatAppearance.MouseOverBackColor = Color.Purple;
            login_signupBtn.FlatStyle = FlatStyle.Flat;
            login_signupBtn.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_signupBtn.ForeColor = Color.Black;
            login_signupBtn.Location = new Point(29, 548);
            login_signupBtn.Margin = new Padding(4, 5, 4, 5);
            login_signupBtn.Name = "login_signupBtn";
            login_signupBtn.Size = new Size(301, 48);
            login_signupBtn.TabIndex = 1;
            login_signupBtn.Text = "SIGNUP";
            login_signupBtn.UseVisualStyleBackColor = false;
            login_signupBtn.Click += login_signupBtn_Click;
            // 
            // exit
            // 
            exit.AutoSize = true;
            exit.Cursor = Cursors.Hand;
            exit.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exit.Location = new Point(733, 11);
            exit.Margin = new Padding(4, 0, 4, 0);
            exit.Name = "exit";
            exit.Size = new Size(21, 23);
            exit.TabIndex = 1;
            exit.Text = "X";
            exit.Click += exit_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(380, 145);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(177, 28);
            label2.TabIndex = 2;
            label2.Text = "Login Account";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(381, 266);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(91, 21);
            label3.TabIndex = 3;
            label3.Text = "Username:";
            // 
            // login_username
            // 
            login_username.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_username.Location = new Point(385, 296);
            login_username.Margin = new Padding(4, 5, 4, 5);
            login_username.Multiline = true;
            login_username.Name = "login_username";
            login_username.Size = new Size(347, 44);
            login_username.TabIndex = 4;
            // 
            // login_password
            // 
            login_password.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_password.Location = new Point(385, 395);
            login_password.Margin = new Padding(4, 5, 4, 5);
            login_password.Multiline = true;
            login_password.Name = "login_password";
            login_password.PasswordChar = '*';
            login_password.Size = new Size(347, 44);
            login_password.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(381, 364);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(87, 21);
            label4.TabIndex = 5;
            label4.Text = "Password:";
            // 
            // login_showPass
            // 
            login_showPass.AutoSize = true;
            login_showPass.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_showPass.Location = new Point(583, 450);
            login_showPass.Margin = new Padding(4, 5, 4, 5);
            login_showPass.Name = "login_showPass";
            login_showPass.Size = new Size(130, 22);
            login_showPass.TabIndex = 7;
            login_showPass.Text = "Show Password";
            login_showPass.UseVisualStyleBackColor = true;
            login_showPass.CheckedChanged += login_showPass_CheckedChanged;
            // 
            // login_btn
            // 
            login_btn.BackColor = Color.Black;
            login_btn.Cursor = Cursors.Hand;
            login_btn.FlatAppearance.BorderSize = 0;
            login_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
            login_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
            login_btn.FlatStyle = FlatStyle.Flat;
            login_btn.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_btn.ForeColor = Color.White;
            login_btn.Location = new Point(497, 549);
            login_btn.Margin = new Padding(4, 5, 4, 5);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(124, 52);
            login_btn.TabIndex = 8;
            login_btn.Text = "LOGIN";
            login_btn.UseVisualStyleBackColor = false;
            login_btn.Click += login_btn_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(820, 750);
            Controls.Add(login_btn);
            Controls.Add(login_showPass);
            Controls.Add(login_password);
            Controls.Add(label4);
            Controls.Add(login_username);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(exit);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox login_username;
        private System.Windows.Forms.TextBox login_password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox login_showPass;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Button login_signupBtn;
        private System.Windows.Forms.Label label6;
    }
}

