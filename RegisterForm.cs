using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace _3m_Rashed_Market
{
    public partial class RegisterForm : Form
    {
        SqlConnection connect
            = new SqlConnection(@"Server=mssql-160155-0.cloudclusters.net,18755; Database= 3m-Rashed-Market; User Id=1517002; Password=123Rashed123; Trusted_Connection=False;TrustServerCertificate=True; MultipleActiveResultSets=true");
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signup_loginBtn_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void signup_btn_Click(object sender, EventArgs e)
        {
            if (signup_username.Text == ""
                || signup_password.Text == "")
            {
                MessageBox.Show("Please fill all blank fields"
                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();
                        string selectUsername = "SELECT COUNT(username) FROM Customer WHERE UserName = @user";

                        using (SqlCommand checkUser = new SqlCommand(selectUsername, connect))
                        {
                            checkUser.Parameters.AddWithValue("@user", signup_username.Text.Trim());
                            int count = (int)checkUser.ExecuteScalar();

                            if (count >= 1)
                            {
                                MessageBox.Show(signup_username.Text.Trim() + " is already taken"
                                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {

                                string insertData = "INSERT INTO Customer " +
                                    "(UserName, Password, CustName, PhoneNum, Gender, Address, email) " +
                                    "VALUES(@username, @password, @cust_name, @phone_num, @gender, @address, @email)";

                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@username", signup_username.Text.Trim());
                                    cmd.Parameters.AddWithValue("@password", signup_password.Text.Trim());
                                    cmd.Parameters.AddWithValue("@cust_name", customer_name.Text.Trim());
                                    cmd.Parameters.AddWithValue("@phone_num", phone_number.Text.Trim());
                                    cmd.Parameters.AddWithValue("@address", address.Text.Trim());
                                    cmd.Parameters.AddWithValue("@email", email.Text.Trim());
                                    if (male.Checked)
                                    {
                                        cmd.Parameters.AddWithValue("@gender", "1");
                                    }

                                    if(female.Checked)
                                    {
                                        cmd.Parameters.AddWithValue("@gender", "0");
                                    }

                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show("Registered successfully!"
                                        , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    Login loginForm = new Login();
                                    loginForm.Show();
                                    this.Hide();
                                }
                            }
                        }



                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex
                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        private void signup_showPass_CheckedChanged(object sender, EventArgs e)
        {
            signup_password.PasswordChar = signup_showPass.Checked ? '\0' : '*';
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void signup_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void signup_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void femaleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void female_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
