
namespace _3m_Rashed_Market
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            signup_btn = new Button();
            signup_showPass = new CheckBox();
            signup_password = new TextBox();
            label4 = new Label();
            signup_username = new TextBox();
            label3 = new Label();
            label2 = new Label();
            exit = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            signup_loginBtn = new Button();
            label5 = new Label();
            label1 = new Label();
            customer_name = new TextBox();
            label7 = new Label();
            phone_number = new TextBox();
            label8 = new Label();
            address = new TextBox();
            label9 = new Label();
            male = new RadioButton();
            female = new RadioButton();
            email = new TextBox();
            label10 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // signup_btn
            // 
            signup_btn.BackColor = Color.Black;
            signup_btn.Cursor = Cursors.Hand;
            signup_btn.FlatAppearance.BorderSize = 0;
            signup_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
            signup_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
            signup_btn.FlatStyle = FlatStyle.Flat;
            signup_btn.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signup_btn.ForeColor = Color.Transparent;
            signup_btn.Location = new Point(381, 688);
            signup_btn.Margin = new Padding(4, 5, 4, 5);
            signup_btn.Name = "signup_btn";
            signup_btn.Size = new Size(124, 52);
            signup_btn.TabIndex = 17;
            signup_btn.Text = "SIGNUP";
            signup_btn.UseVisualStyleBackColor = false;
            signup_btn.Click += signup_btn_Click;
            // 
            // signup_showPass
            // 
            signup_showPass.AutoSize = true;
            signup_showPass.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signup_showPass.Location = new Point(577, 655);
            signup_showPass.Margin = new Padding(4, 5, 4, 5);
            signup_showPass.Name = "signup_showPass";
            signup_showPass.Size = new Size(130, 22);
            signup_showPass.TabIndex = 16;
            signup_showPass.Text = "Show Password";
            signup_showPass.UseVisualStyleBackColor = true;
            signup_showPass.CheckedChanged += signup_showPass_CheckedChanged;
            // 
            // signup_password
            // 
            signup_password.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signup_password.Location = new Point(373, 535);
            signup_password.Margin = new Padding(4, 5, 4, 5);
            signup_password.Multiline = true;
            signup_password.Name = "signup_password";
            signup_password.PasswordChar = '*';
            signup_password.Size = new Size(347, 44);
            signup_password.TabIndex = 15;
            signup_password.TextChanged += signup_password_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(377, 509);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(87, 21);
            label4.TabIndex = 14;
            label4.Text = "Password:";
            // 
            // signup_username
            // 
            signup_username.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signup_username.Location = new Point(377, 452);
            signup_username.Margin = new Padding(4, 5, 4, 5);
            signup_username.Multiline = true;
            signup_username.Name = "signup_username";
            signup_username.Size = new Size(347, 44);
            signup_username.TabIndex = 13;
            signup_username.TextChanged += signup_username_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(377, 426);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(91, 21);
            label3.TabIndex = 12;
            label3.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(387, 11);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(212, 28);
            label2.TabIndex = 11;
            label2.Text = "Register Account";
            // 
            // exit
            // 
            exit.AutoSize = true;
            exit.Cursor = Cursors.Hand;
            exit.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exit.Location = new Point(735, 11);
            exit.Margin = new Padding(4, 0, 4, 0);
            exit.Name = "exit";
            exit.Size = new Size(21, 23);
            exit.TabIndex = 10;
            exit.Text = "X";
            exit.Click += exit_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(signup_loginBtn);
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(355, 750);
            panel1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(105, 91);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(133, 154);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(92, 339);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(128, 24);
            label6.TabIndex = 2;
            label6.Text = "Grocery Shop";
            label6.Click += label6_Click;
            // 
            // signup_loginBtn
            // 
            signup_loginBtn.BackColor = Color.White;
            signup_loginBtn.Cursor = Cursors.Hand;
            signup_loginBtn.FlatAppearance.BorderSize = 0;
            signup_loginBtn.FlatAppearance.MouseDownBackColor = Color.Purple;
            signup_loginBtn.FlatAppearance.MouseOverBackColor = Color.Purple;
            signup_loginBtn.FlatStyle = FlatStyle.Flat;
            signup_loginBtn.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signup_loginBtn.ForeColor = Color.Black;
            signup_loginBtn.Location = new Point(29, 548);
            signup_loginBtn.Margin = new Padding(4, 5, 4, 5);
            signup_loginBtn.Name = "signup_loginBtn";
            signup_loginBtn.Size = new Size(301, 48);
            signup_loginBtn.TabIndex = 1;
            signup_loginBtn.Text = "SIGN IN";
            signup_loginBtn.UseVisualStyleBackColor = false;
            signup_loginBtn.Click += signup_loginBtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(108, 511);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(132, 18);
            label5.TabIndex = 0;
            label5.Text = "Login your Account";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(377, 51);
            label1.Name = "label1";
            label1.Size = new Size(133, 21);
            label1.TabIndex = 18;
            label1.Text = "Customer name:";
            // 
            // customer_name
            // 
            customer_name.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customer_name.Location = new Point(377, 95);
            customer_name.Margin = new Padding(4, 5, 4, 5);
            customer_name.Multiline = true;
            customer_name.Name = "customer_name";
            customer_name.Size = new Size(347, 44);
            customer_name.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(373, 154);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(122, 21);
            label7.TabIndex = 21;
            label7.Text = "Phone number:";
            // 
            // phone_number
            // 
            phone_number.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phone_number.Location = new Point(377, 196);
            phone_number.Margin = new Padding(4, 5, 4, 5);
            phone_number.Multiline = true;
            phone_number.Name = "phone_number";
            phone_number.Size = new Size(347, 44);
            phone_number.TabIndex = 22;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(377, 262);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(63, 21);
            label8.TabIndex = 23;
            label8.Text = "Gender";
            label8.Click += label8_Click;
            // 
            // address
            // 
            address.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            address.Location = new Point(377, 377);
            address.Margin = new Padding(4, 5, 4, 5);
            address.Multiline = true;
            address.Name = "address";
            address.Size = new Size(347, 44);
            address.TabIndex = 26;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(377, 351);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(70, 21);
            label9.TabIndex = 25;
            label9.Text = "Address";
            // 
            // male
            // 
            male.AutoSize = true;
            male.Location = new Point(377, 312);
            male.Margin = new Padding(3, 4, 3, 4);
            male.Name = "male";
            male.Size = new Size(63, 24);
            male.TabIndex = 29;
            male.TabStop = true;
            male.Text = "Male";
            male.UseVisualStyleBackColor = true;
            male.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // female
            // 
            female.AutoSize = true;
            female.Location = new Point(464, 312);
            female.Margin = new Padding(3, 4, 3, 4);
            female.Name = "female";
            female.Size = new Size(78, 24);
            female.TabIndex = 30;
            female.TabStop = true;
            female.Text = "Female";
            female.UseVisualStyleBackColor = true;
            female.CheckedChanged += female_CheckedChanged;
            // 
            // email
            // 
            email.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            email.Location = new Point(373, 611);
            email.Margin = new Padding(4, 5, 4, 5);
            email.Multiline = true;
            email.Name = "email";
            email.Size = new Size(347, 44);
            email.TabIndex = 31;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(373, 585);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(56, 21);
            label10.TabIndex = 32;
            label10.Text = "email:";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(820, 750);
            Controls.Add(label10);
            Controls.Add(email);
            Controls.Add(female);
            Controls.Add(male);
            Controls.Add(address);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(phone_number);
            Controls.Add(label7);
            Controls.Add(customer_name);
            Controls.Add(label1);
            Controls.Add(signup_btn);
            Controls.Add(signup_showPass);
            Controls.Add(signup_password);
            Controls.Add(label4);
            Controls.Add(signup_username);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(exit);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "RegisterForm";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            Load += RegisterForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button signup_btn;
        private System.Windows.Forms.CheckBox signup_showPass;
        private System.Windows.Forms.TextBox signup_password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox signup_username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button signup_loginBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox customer_name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox phone_number;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton male;
        private System.Windows.Forms.RadioButton female;
        private TextBox email;
        private Label label10;
    }
}