using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _3m_Rashed_Market;
using Microsoft.Data.SqlClient;

namespace EmployeeManagementSystem
{
    public partial class payment : Form
    {
        SqlConnection connect
            = new SqlConnection(@"Server=mssql-160155-0.cloudclusters.net,18755; Database= 3m-Rashed-Market; User Id=1517002; Password=123Rashed123; Trusted_Connection=False;TrustServerCertificate=True; MultipleActiveResultSets=true");
        int cur_id;
        int[] prod_id = new int[6];
        int shift;
        int total;
        public payment(int id)
        {
            InitializeComponent();
            cur_id = id;

            for (int i = 0; i < 6; i++)
            {
                prod_id[i] = -1;
            }

            pic1.Image = pic2.Image = pic3.Image = pic4.Image = pic5.Image = pic6.Image = null;
            name1.Text = name2.Text = name3.Text = name4.Text = name5.Text = name6.Text = null;
            price1.Text = price2.Text = price3.Text = price4.Text = price5.Text = price6.Text = null;
            quan1.Text = quan2.Text = quan3.Text = quan4.Text = quan5.Text = quan6.Text = null;

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
	                Order_.transState = 'pending' AND Order_.custID = @id ;
               
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

                    prod_id[0] = (int)dt.Rows[IDs[0 + shift]][0];

                    string new_query = "SELECT COUNT(*) FROM Order_Product WHERE Order_Product.productID = @prod_id GROUP BY productID";
                    using (SqlCommand cmd2 = new SqlCommand(new_query, connect))
                    {
                        cmd2.Parameters.AddWithValue("@prod_id", prod_id[0]);

                        SqlDataAdapter adapter1 = new SqlDataAdapter(cmd2);
                        DataTable dt2 = new DataTable();
                        adapter1.Fill(dt2);

                        quan1.Text = dt2.Rows[0][0].ToString();
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

                    prod_id[1] = (int)dt.Rows[IDs[1 + shift]][0];

                    new_query = "SELECT COUNT(*) FROM Order_Product WHERE Order_Product.productID = @prod_id GROUP BY productID";
                    using (SqlCommand cmd2 = new SqlCommand(new_query, connect))
                    {
                        cmd2.Parameters.AddWithValue("@prod_id", prod_id[1]);

                        SqlDataAdapter adapter1 = new SqlDataAdapter(cmd2);
                        DataTable dt2 = new DataTable();
                        adapter1.Fill(dt2);

                        quan2.Text = dt2.Rows[0][0].ToString();
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

                    prod_id[2] = (int)dt.Rows[IDs[2 + shift]][0];

                    new_query = "SELECT COUNT(*) FROM Order_Product WHERE Order_Product.productID = @prod_id GROUP BY productID";
                    using (SqlCommand cmd2 = new SqlCommand(new_query, connect))
                    {
                        cmd2.Parameters.AddWithValue("@prod_id", prod_id[2]);

                        SqlDataAdapter adapter1 = new SqlDataAdapter(cmd2);
                        DataTable dt2 = new DataTable();
                        adapter1.Fill(dt2);

                        quan3.Text = dt2.Rows[0][0].ToString();
                    }

                    total--;

                    if (total <= 0)
                    {
                        return;
                    }

                    webClient = new WebClient();
                    imageData = webClient.DownloadData((string)dt.Rows[IDs[3 + shift]][4].ToString());
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        pic3.Image = Image.FromStream(ms);
                    }

                    name3.Text = dt.Rows[IDs[3 + shift]][3].ToString();
                    price3.Text = dt.Rows[IDs[3 + shift]][6].ToString();

                    prod_id[3] = (int)dt.Rows[IDs[3 + shift]][0];

                    new_query = "SELECT COUNT(*) FROM Order_Product WHERE Order_Product.productID = @prod_id GROUP BY productID";
                    using (SqlCommand cmd2 = new SqlCommand(new_query, connect))
                    {
                        cmd2.Parameters.AddWithValue("@prod_id", prod_id[3]);

                        SqlDataAdapter adapter1 = new SqlDataAdapter(cmd2);
                        DataTable dt2 = new DataTable();
                        adapter1.Fill(dt2);

                        quan3.Text = dt2.Rows[0][0].ToString();
                    }

                    total--;

                    if (total <= 0)
                    {
                        return;
                    }

                    webClient = new WebClient();
                    imageData = webClient.DownloadData((string)dt.Rows[IDs[4 + shift]][4].ToString());
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        pic3.Image = Image.FromStream(ms);
                    }

                    name3.Text = dt.Rows[IDs[4 + shift]][3].ToString();
                    price3.Text = dt.Rows[IDs[4 + shift]][6].ToString();

                    prod_id[4] = (int)dt.Rows[IDs[4 + shift]][0];

                    new_query = "SELECT COUNT(*) FROM Order_Product WHERE Order_Product.productID = @prod_id GROUP BY productID";
                    using (SqlCommand cmd2 = new SqlCommand(new_query, connect))
                    {
                        cmd2.Parameters.AddWithValue("@prod_id", prod_id[4]);

                        SqlDataAdapter adapter1 = new SqlDataAdapter(cmd2);
                        DataTable dt2 = new DataTable();
                        adapter1.Fill(dt2);

                        quan3.Text = dt2.Rows[0][0].ToString();
                    }

                    total--;

                    if (total <= 0)
                    {
                        return;
                    }

                    webClient = new WebClient();
                    imageData = webClient.DownloadData((string)dt.Rows[IDs[5 + shift]][4].ToString());
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        pic3.Image = Image.FromStream(ms);
                    }

                    name3.Text = dt.Rows[IDs[5 + shift]][3].ToString();
                    price3.Text = dt.Rows[IDs[5 + shift]][6].ToString();

                    prod_id[5] = (int)dt.Rows[IDs[5 + shift]][0];

                    new_query = "SELECT COUNT(*) FROM Order_Product WHERE Order_Product.productID = @prod_id GROUP BY productID";
                    using (SqlCommand cmd2 = new SqlCommand(new_query, connect))
                    {
                        cmd2.Parameters.AddWithValue("@prod_id", prod_id[5]);

                        SqlDataAdapter adapter1 = new SqlDataAdapter(cmd2);
                        DataTable dt2 = new DataTable();
                        adapter1.Fill(dt2);

                        quan3.Text = dt2.Rows[0][0].ToString();
                    }

                    total--;

                    if (total <= 0)
                    {
                        return;
                    }

                }
                else
                {
                    MessageBox.Show("You haven't ordered anything yet!"
                        , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        void load()
        {
            for (int i = 0; i < 6; i++)
            {
                prod_id[i] = -1;
            }

            pic1.Image = pic2.Image = pic3.Image = pic4.Image = pic5.Image = pic6.Image = null;
            name1.Text = name2.Text = name3.Text = name4.Text = name5.Text = name6.Text = null;
            price1.Text = price2.Text = price3.Text = price4.Text = price5.Text = price6.Text = null;
            quan1.Text = quan2.Text = quan3.Text = quan4.Text = quan5.Text = quan6.Text = null;

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
	                Order_.transState = 'pending' AND Order_.custID = @id ;;
               
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

                    prod_id[0] = (int)dt.Rows[IDs[0 + shift]][0];

                    string new_query = "SELECT COUNT(*) FROM Order_Product WHERE Order_Product.productID = @prod_id GROUP BY productID";
                    using (SqlCommand cmd2 = new SqlCommand(new_query, connect))
                    {
                        cmd2.Parameters.AddWithValue("@prod_id", prod_id[0]);

                        SqlDataAdapter adapter1 = new SqlDataAdapter(cmd2);
                        DataTable dt2 = new DataTable();
                        adapter1.Fill(dt2);

                        quan1.Text = dt2.Rows[0][0].ToString();
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

                    prod_id[1] = (int)dt.Rows[IDs[1 + shift]][0];

                    new_query = "SELECT COUNT(*) FROM Order_Product WHERE Order_Product.productID = @prod_id GROUP BY productID";
                    using (SqlCommand cmd2 = new SqlCommand(new_query, connect))
                    {
                        cmd2.Parameters.AddWithValue("@prod_id", prod_id[1]);

                        SqlDataAdapter adapter1 = new SqlDataAdapter(cmd2);
                        DataTable dt2 = new DataTable();
                        adapter1.Fill(dt2);

                        quan2.Text = dt2.Rows[0][0].ToString();
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

                    prod_id[2] = (int)dt.Rows[IDs[2 + shift]][0];

                    new_query = "SELECT COUNT(*) FROM Order_Product WHERE Order_Product.productID = @prod_id GROUP BY productID";
                    using (SqlCommand cmd2 = new SqlCommand(new_query, connect))
                    {
                        cmd2.Parameters.AddWithValue("@prod_id", prod_id[2]);

                        SqlDataAdapter adapter1 = new SqlDataAdapter(cmd2);
                        DataTable dt2 = new DataTable();
                        adapter1.Fill(dt2);

                        quan3.Text = dt2.Rows[0][0].ToString();
                    }

                    total--;

                    if (total <= 0)
                    {
                        return;
                    }

                    webClient = new WebClient();
                    imageData = webClient.DownloadData((string)dt.Rows[IDs[3 + shift]][4].ToString());
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        pic3.Image = Image.FromStream(ms);
                    }

                    name3.Text = dt.Rows[IDs[3 + shift]][3].ToString();
                    price3.Text = dt.Rows[IDs[3 + shift]][6].ToString();

                    prod_id[3] = (int)dt.Rows[IDs[3 + shift]][0];

                    new_query = "SELECT COUNT(*) FROM Order_Product WHERE Order_Product.productID = @prod_id GROUP BY productID";
                    using (SqlCommand cmd2 = new SqlCommand(new_query, connect))
                    {
                        cmd2.Parameters.AddWithValue("@prod_id", prod_id[3]);

                        SqlDataAdapter adapter1 = new SqlDataAdapter(cmd2);
                        DataTable dt2 = new DataTable();
                        adapter1.Fill(dt2);

                        quan3.Text = dt2.Rows[0][0].ToString();
                    }

                    total--;

                    if (total <= 0)
                    {
                        return;
                    }

                    webClient = new WebClient();
                    imageData = webClient.DownloadData((string)dt.Rows[IDs[4 + shift]][4].ToString());
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        pic3.Image = Image.FromStream(ms);
                    }

                    name3.Text = dt.Rows[IDs[4 + shift]][3].ToString();
                    price3.Text = dt.Rows[IDs[4 + shift]][6].ToString();

                    prod_id[4] = (int)dt.Rows[IDs[4 + shift]][0];

                    new_query = "SELECT COUNT(*) FROM Order_Product WHERE Order_Product.productID = @prod_id GROUP BY productID";
                    using (SqlCommand cmd2 = new SqlCommand(new_query, connect))
                    {
                        cmd2.Parameters.AddWithValue("@prod_id", prod_id[4]);

                        SqlDataAdapter adapter1 = new SqlDataAdapter(cmd2);
                        DataTable dt2 = new DataTable();
                        adapter1.Fill(dt2);

                        quan3.Text = dt2.Rows[0][0].ToString();
                    }

                    total--;

                    if (total <= 0)
                    {
                        return;
                    }

                    webClient = new WebClient();
                    imageData = webClient.DownloadData((string)dt.Rows[IDs[5 + shift]][4].ToString());
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        pic3.Image = Image.FromStream(ms);
                    }

                    name3.Text = dt.Rows[IDs[5 + shift]][3].ToString();
                    price3.Text = dt.Rows[IDs[5 + shift]][6].ToString();

                    prod_id[5] = (int)dt.Rows[IDs[5 + shift]][0];

                    new_query = "SELECT COUNT(*) FROM Order_Product WHERE Order_Product.productID = @prod_id GROUP BY productID";
                    using (SqlCommand cmd2 = new SqlCommand(new_query, connect))
                    {
                        cmd2.Parameters.AddWithValue("@prod_id", prod_id[5]);

                        SqlDataAdapter adapter1 = new SqlDataAdapter(cmd2);
                        DataTable dt2 = new DataTable();
                        adapter1.Fill(dt2);

                        quan3.Text = dt2.Rows[0][0].ToString();
                    }

                    total--;

                    if (total <= 0)
                    {
                        return;
                    }

                }
                else
                {
                    MessageBox.Show("You haven't ordered anything yet!"
                        , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Holder.Text == "" || Card.Text == "" || exp_date.Text == "" || CVV.Text == "" || postal_code.Text == "")
            {
                MessageBox.Show("Fill all the required fields!"
                        , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Payment succeeded!"
                                    , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                connect.Open();
                string query = "UPDATE Order_ SET transState = 'paid' WHERE custID = @cur_id AND transState = 'pending';";
                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@cur_id", cur_id);
                    cmd.ExecuteNonQuery();
                }

                connect.Close();

                Products Mform = new Products(cur_id);
                Mform.Show();
                this.Hide();
            }
        }

        private void Load_More_Click(object sender, EventArgs e)
        {
            shift += 6;
            load();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            shift = 0;
            load();
        }
    }
}
