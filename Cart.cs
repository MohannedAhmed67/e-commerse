using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using EmployeeManagementSystem;

namespace _3m_Rashed_Market
{
    public partial class Cart : Form
    {
        SqlConnection connect
            = new SqlConnection(@"Server=mssql-160155-0.cloudclusters.net,18755; Database= 3m-Rashed-Market; User Id=1517002; Password=123Rashed123; Trusted_Connection=False;TrustServerCertificate=True; MultipleActiveResultSets=true");
        int cur_id;
        int[] prod_id = new int[3];
        int shift;
        int total;
        public Cart(int id)
        {
            InitializeComponent();
            cur_id = id;
            string query1 = "SELECT UserName FROM Customer WHERE custID = @id";


            using (SqlCommand cmd = new SqlCommand(query1, connect))
            {
                cmd.Parameters.AddWithValue("@id", cur_id);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                Current_User.Text = (string)dt.Rows[0][0];
            }

            for (int i = 0; i < 3; i++)
            {
                prod_id[i] = -1;
            }

            pic1.Image = pic2.Image = pic3.Image = null;
            name1.Text = name2.Text = name3.Text = null;
            price1.Text = price2.Text = price3.Text = null;
            nat1.Text = nat2.Text = nat3.Text = null;
            brand1.Text = brand2.Text = brand3.Text = null;
            ex_date1.Text = ex_date2.Text = ex_date3.Text = null;
            av1.Text = av2.Text = av3.Text = null;
            quan1.Text = quan2.Text = quan3.Text = null;
            quan1_box.Text = quan2_box.Text = quan3_box.Text = null;

            string query = @"
                SELECT *
                FROM 
                Order_Product
                JOIN
	                Product
                ON 
	                Product.productID = Order_Product.productID
                JOIN 
	                Brand
                ON
	                Product.brandID = Brand.brandID
                JOIN 
	                Country
                ON
	                Brand.countryID = Country.countryID
                JOIN 
                    Order_
                ON
                    Order_Product.orderID = Order_.orderID
                WHERE 
	                Order_.transState = 'pending' AND Order_.custID = @id
                ;
                
            ";

            using (SqlCommand cmd = new SqlCommand(query, connect))
            {
                cmd.Parameters.AddWithValue("@id", cur_id);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                HashSet<int> s = new HashSet<int>();

                int sz = 0;
                List<int> IDs = new List<int>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (s.Contains((int)dt.Rows[i][0]))
                    {
                        s.Add((int)dt.Rows[i][0]);
                    }
                    else
                    {
                        IDs.Add(i);
                        sz++;
                        s.Add((int)dt.Rows[i][0]);
                    }
                }


                if (sz > 0)
                {
                    total = sz - shift;
                    if (total <= 0)
                    {
                        return;
                    }
                    WebClient webClient = new WebClient();
                    byte[] imageData = webClient.DownloadData((string)dt.Rows[IDs[0 + shift]][4].ToString());
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        pic1.Image = Image.FromStream(ms);
                    }

                    name1.Text = dt.Rows[IDs[0 + shift]][3].ToString();
                    price1.Text = dt.Rows[IDs[0 + shift]][6].ToString();
                    nat1.Text = dt.Rows[IDs[0 + shift]][15].ToString();
                    brand1.Text = dt.Rows[IDs[0 + shift]][12].ToString();
                    ex_date1.Text = dt.Rows[IDs[0 + shift]][9].ToString();
                    av1.Text = dt.Rows[IDs[0 + shift]][7].ToString();
                    quan1.Text = "quantity:";

                    prod_id[0] = (int)dt.Rows[IDs[0 + shift]][0];

                    string new_query = "SELECT COUNT(*) FROM Order_Product WHERE Order_Product.productID = @prod_id GROUP BY productID";
                    using (SqlCommand cmd2 = new SqlCommand(new_query, connect))
                    {
                        cmd2.Parameters.AddWithValue("@prod_id", prod_id[0]);

                        SqlDataAdapter adapter1 = new SqlDataAdapter(cmd2);
                        DataTable dt2 = new DataTable();
                        adapter1.Fill(dt2);

                        quan1_box.Text = dt2.Rows[0][0].ToString();
                    }

                    total--;

                    if (total <= 0)
                    {
                        return;
                    }

                    webClient = new WebClient();
                    imageData = webClient.DownloadData((string)dt.Rows[IDs[1 + shift]][4].ToString());
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        pic2.Image = Image.FromStream(ms);
                    }

                    name2.Text = dt.Rows[IDs[1 + shift]][3].ToString();
                    price2.Text = dt.Rows[IDs[1 + shift]][6].ToString();
                    nat2.Text = dt.Rows[IDs[1 + shift]][15].ToString();
                    brand2.Text = dt.Rows[IDs[1 + shift]][12].ToString();
                    ex_date2.Text = dt.Rows[IDs[1 + shift]][9].ToString();
                    av2.Text = dt.Rows[IDs[1 + shift]][7].ToString();
                    quan2.Text = "quantity:";

                    prod_id[1] = (int)dt.Rows[IDs[1 + shift]][0];

                    new_query = "SELECT COUNT(*) FROM Order_Product WHERE Order_Product.productID = @prod_id GROUP BY productID";
                    using (SqlCommand cmd2 = new SqlCommand(new_query, connect))
                    {
                        cmd2.Parameters.AddWithValue("@prod_id", prod_id[1]);

                        SqlDataAdapter adapter1 = new SqlDataAdapter(cmd2);
                        DataTable dt2 = new DataTable();
                        adapter1.Fill(dt2);

                        quan2_box.Text = dt2.Rows[0][0].ToString();
                    }

                    total--;

                    if (total <= 0)
                    {
                        return;
                    }

                    webClient = new WebClient();
                    imageData = webClient.DownloadData((string)dt.Rows[IDs[2 + shift]][4].ToString());
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        pic3.Image = Image.FromStream(ms);
                    }

                    name3.Text = dt.Rows[IDs[2 + shift]][3].ToString();
                    price3.Text = dt.Rows[IDs[2 + shift]][6].ToString();
                    nat3.Text = dt.Rows[IDs[2 + shift]][15].ToString();
                    brand3.Text = dt.Rows[IDs[2 + shift]][12].ToString();
                    ex_date3.Text = dt.Rows[IDs[2 + shift]][9].ToString();
                    av3.Text = dt.Rows[IDs[2 + shift]][7].ToString();
                    quan3.Text = "quantity:";

                    prod_id[2] = (int)dt.Rows[IDs[2 + shift]][0];

                    new_query = "SELECT COUNT(*) FROM Order_Product WHERE Order_Product.productID = @prod_id GROUP BY productID";
                    using (SqlCommand cmd2 = new SqlCommand(new_query, connect))
                    {
                        cmd2.Parameters.AddWithValue("@prod_id", prod_id[2]);

                        SqlDataAdapter adapter1 = new SqlDataAdapter(cmd2);
                        DataTable dt2 = new DataTable();
                        adapter1.Fill(dt2);

                        quan3_box.Text = dt2.Rows[0][0].ToString();
                    }

                    total--;

                    if (total <= 0)
                    {
                        return;
                    }


                }
                else
                {
                    MessageBox.Show("There is nothing in your cart yet!"
                        , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void Cart_Load(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                prod_id[i] = -1;
            }

            pic1.Image = pic2.Image = pic3.Image = null;
            name1.Text = name2.Text = name3.Text = null;
            price1.Text = price2.Text = price3.Text = null;
            nat1.Text = nat2.Text = nat3.Text = null;
            brand1.Text = brand2.Text = brand3.Text = null;
            ex_date1.Text = ex_date2.Text = ex_date3.Text = null;
            av1.Text = av2.Text = av3.Text = null;
            quan1.Text = quan2.Text = quan3.Text = null;
            quan1_box.Text = quan2_box.Text = quan3_box.Text = null;

            string query = @"
                SELECT *
                FROM 
                Order_Product
                JOIN
	                Product
                ON 
	                Product.productID = Order_Product.productID
                JOIN 
	                Brand
                ON
	                Product.brandID = Brand.brandID
                JOIN 
	                Country
                ON
	                Brand.countryID = Country.countryID
                JOIN 
                    Order_
                ON
                    Order_Product.orderID = Order_.orderID  
                WHERE 
	                Product.productName LIKE '%cake%' AND Order_.transState = 'pending' AND AND Order_.custID = @id;
                
            ";

            using (SqlCommand cmd = new SqlCommand(query, connect))
            {
                cmd.Parameters.AddWithValue("@prod_name", brand_input.Text);
                cmd.Parameters.AddWithValue("@id", cur_id);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                HashSet<int> s = new HashSet<int>();

                int sz = 0;
                List<int> IDs = new List<int>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (s.Contains((int)dt.Rows[i][0]))
                    {
                        s.Add((int)dt.Rows[i][0]);
                    }
                    else
                    {
                        IDs.Add(i);
                        sz++;
                        s.Add((int)dt.Rows[i][0]);
                    }
                }


                if (sz > 0)
                {
                    total = sz - shift;
                    if (total <= 0)
                    {
                        return;
                    }
                    WebClient webClient = new WebClient();
                    byte[] imageData = webClient.DownloadData((string)dt.Rows[IDs[0 + shift]][4].ToString());
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        pic1.Image = Image.FromStream(ms);
                    }

                    name1.Text = dt.Rows[IDs[0 + shift]][3].ToString();
                    price1.Text = dt.Rows[IDs[0 + shift]][6].ToString();
                    nat1.Text = dt.Rows[IDs[0 + shift]][15].ToString();
                    brand1.Text = dt.Rows[IDs[0 + shift]][12].ToString();
                    ex_date1.Text = dt.Rows[IDs[0 + shift]][9].ToString();
                    av1.Text = dt.Rows[IDs[0 + shift]][7].ToString();
                    quan1.Text = "quantity:";

                    prod_id[0] = (int)dt.Rows[IDs[0 + shift]][0];

                    string new_query = "SELECT COUNT(*) FROM Order_Product WHERE Order_Product.productID = @prod_id GROUP BY productID";
                    using (SqlCommand cmd2 = new SqlCommand(new_query, connect))
                    {
                        cmd2.Parameters.AddWithValue("@prod_id", prod_id[0]);

                        SqlDataAdapter adapter1 = new SqlDataAdapter(cmd2);
                        DataTable dt2 = new DataTable();
                        adapter1.Fill(dt2);

                        quan1_box.Text = dt2.Rows[0][0].ToString();
                    }

                    total--;

                    if (total <= 0)
                    {
                        return;
                    }

                    webClient = new WebClient();
                    imageData = webClient.DownloadData((string)dt.Rows[IDs[1 + shift]][4].ToString());
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        pic2.Image = Image.FromStream(ms);
                    }

                    name2.Text = dt.Rows[IDs[1 + shift]][3].ToString();
                    price2.Text = dt.Rows[IDs[1 + shift]][6].ToString();
                    nat2.Text = dt.Rows[IDs[1 + shift]][15].ToString();
                    brand2.Text = dt.Rows[IDs[1 + shift]][12].ToString();
                    ex_date2.Text = dt.Rows[IDs[1 + shift]][9].ToString();
                    av2.Text = dt.Rows[IDs[1 + shift]][7].ToString();
                    quan2.Text = "quantity:";

                    prod_id[1] = (int)dt.Rows[IDs[1 + shift]][0];

                    new_query = "SELECT COUNT(*) FROM Order_Product WHERE Order_Product.productID = @prod_id GROUP BY productID";
                    using (SqlCommand cmd2 = new SqlCommand(new_query, connect))
                    {
                        cmd2.Parameters.AddWithValue("@prod_id", prod_id[1]);

                        SqlDataAdapter adapter1 = new SqlDataAdapter(cmd2);
                        DataTable dt2 = new DataTable();
                        adapter1.Fill(dt2);

                        quan2_box.Text = dt2.Rows[0][0].ToString();
                    }

                    total--;

                    if (total <= 0)
                    {
                        return;
                    }

                    webClient = new WebClient();
                    imageData = webClient.DownloadData((string)dt.Rows[IDs[2 + shift]][4].ToString());
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        pic3.Image = Image.FromStream(ms);
                    }

                    name3.Text = dt.Rows[IDs[2 + shift]][3].ToString();
                    price3.Text = dt.Rows[IDs[2 + shift]][6].ToString();
                    nat3.Text = dt.Rows[IDs[2 + shift]][15].ToString();
                    brand3.Text = dt.Rows[IDs[2 + shift]][12].ToString();
                    ex_date3.Text = dt.Rows[IDs[2 + shift]][9].ToString();
                    av3.Text = dt.Rows[IDs[2 + shift]][7].ToString();
                    quan3.Text = "quantity:";

                    prod_id[2] = (int)dt.Rows[IDs[2 + shift]][0];

                    new_query = "SELECT COUNT(*) FROM Order_Product WHERE Order_Product.productID = @prod_id GROUP BY productID";
                    using (SqlCommand cmd2 = new SqlCommand(new_query, connect))
                    {
                        cmd2.Parameters.AddWithValue("@prod_id", prod_id[2]);

                        SqlDataAdapter adapter1 = new SqlDataAdapter(cmd2);
                        DataTable dt2 = new DataTable();
                        adapter1.Fill(dt2);

                        quan3_box.Text = dt2.Rows[0][0].ToString();
                    }

                    total--;

                    if (total <= 0)
                    {
                        return;
                    }


                }
                else
                {
                    MessageBox.Show("The requested item hasn't been added to your cart!"
                        , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            payment Mform = new payment(cur_id);
            Mform.Show();
            this.Hide();    
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Load_More_Click(object sender, EventArgs e)
        {
            shift += 3;
            search.PerformClick();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            shift = 0;
            search.PerformClick();
        }

        private void remove1_Click(object sender, EventArgs e)
        {
            connect.Open();
            string query = "DELETE FROM Order_Product WHERE productID = @prod_id;";

            using (SqlCommand cmd = new SqlCommand(query, connect))
            {
                cmd.Parameters.AddWithValue("@prod_id", prod_id[0]);
                cmd.ExecuteNonQuery();
            }

            connect.Close();

            Refresh.PerformClick();
        }

        private void remove2_Click(object sender, EventArgs e)
        {
            connect.Open();
            string query = "DELETE FROM Order_Product WHERE productID = @prod_id;";

            using (SqlCommand cmd = new SqlCommand(query, connect))
            {
                cmd.Parameters.AddWithValue("@prod_id", prod_id[1]);
                cmd.ExecuteNonQuery();
            }

            connect.Close();

            Refresh.PerformClick();
        }

        private void remove3_Click(object sender, EventArgs e)
        {
            connect.Open();
            string query = "DELETE FROM Order_Product WHERE productID = @prod_id;";

            using (SqlCommand cmd = new SqlCommand(query, connect))
            {
                cmd.Parameters.AddWithValue("@prod_id", prod_id[2]);
                cmd.ExecuteNonQuery();
            }

            connect.Close();

            Refresh.PerformClick();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Products Mform = new Products(cur_id);
            Mform.Show();
            this.Hide();
        }
    }
}
