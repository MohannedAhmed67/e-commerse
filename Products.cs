using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using EmployeeManagementSystem;

namespace _3m_Rashed_Market
{
    public partial class Products : Form
    {
        int cur_id;
        int[] prod_id = new int[5];
        int[] dis = new int[5];
        int total;
        int prods;
        int shift;
        SqlConnection connect
            = new SqlConnection(@"Server=mssql-160155-0.cloudclusters.net,18755; Database= 3m-Rashed-Market; User Id=1517002; Password=123Rashed123; Trusted_Connection=False;TrustServerCertificate=True; MultipleActiveResultSets=true");
        public Products(int user_id)
        {
            InitializeComponent();
            prods = 0;
            dis1.Visible = dis2.Visible = dis3.Visible = dis4.Visible = dis5.Visible = false;
            for(int i = 0; i < 5; i++)
            {
                dis[i] = 0;
            }

            cur_id = user_id;
            string query1 = "SELECT UserName FROM Customer WHERE custID = @id";


            using (SqlCommand cmd = new SqlCommand(query1, connect))
            {
                cmd.Parameters.AddWithValue("@id", cur_id);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                current_user.Text = (string)dt.Rows[0][0];
            }


            for (int i = 0; i < 5; i++)
            {
                prod_id[i] = -1;
            }
            name1.Text = name2.Text = name3.Text = name4.Text = name5.Text = null;
            price1.Text = price2.Text = price3.Text = price4.Text = price5.Text = null;
            nat1.Text = nat2.Text = nat3.Text = nat4.Text = nat5.Text = null;
            sold1.Text = sold2.Text = sold3.Text = sold4.Text = sold5.Text = null;
            quan1.Text = quan2.Text = quan3.Text = quan4.Text = quan5.Text = null;
            pictureBox2.Image = pictureBox3.Image = pictureBox4.Image = pictureBox5.Image = pictureBox6.Image = null;

            string query = @"SELECT 
                            p.productName, 
                            p.quantity, 
                            p.price, 
                            p.description_, 
                            p.imgLink, 
                            p.prodDate, 
                            p.expDate, 
                            br.brand, 
	                        c.country AS BrandOriigon,
                            opp.sold_last_day,
                            op.total_sold, 
                            p.productID
                            FROM 
                                Product p
                            INNER JOIN 
                                Brand br ON p.brandID = br.brandID
                            INNER JOIN
	                            Country c ON br.countryID = c.countryID
                            LEFT JOIN 
                                (SELECT productID, COUNT(*) as total_sold FROM Order_Product GROUP BY productID) op ON p.productID = op.productID
                            LEFT JOIN 
                                CountLastDay opp ON p.productID = opp.productID;";



            using (SqlCommand cmd = new SqlCommand(query, connect))
            {
                cmd.Parameters.AddWithValue("@product_name", product_name.Text);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    int total = dt.Rows.Count - shift;
                    prods = total;


                    if (total <= 0)
                    {
                        return;
                    }

                    WebClient webClient = new WebClient();
                    byte[] imageData = webClient.DownloadData((string)dt.Rows[0 + shift][4].ToString());
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        pictureBox2.Image = Image.FromStream(ms);
                    }

                    name1.Text = (string)dt.Rows[0 + shift][0].ToString();
                    price1.Text = (string)dt.Rows[0 + shift][2].ToString();
                    nat1.Text = (string)dt.Rows[0 + shift][8].ToString();
                    sold1.Text = (string)dt.Rows[0 + shift][9].ToString();
                    quan1.Text = (string)dt.Rows[0 + shift][1].ToString();
                    prod_id[0] = (int)dt.Rows[0 + shift][11];

                    total--;

                    if (total <= 0)
                    {
                        return;
                    }

                    webClient = new WebClient();
                    imageData = webClient.DownloadData((string)dt.Rows[1 + shift][4].ToString());
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        pictureBox3.Image = Image.FromStream(ms);
                    }

                    name2.Text = (string)dt.Rows[1 + shift][0].ToString();
                    price2.Text = (string)dt.Rows[1 + shift][2].ToString();
                    nat2.Text = (string)dt.Rows[1 + shift][8].ToString();
                    sold2.Text = (string)dt.Rows[1 + shift][9].ToString();
                    quan2.Text = (string)dt.Rows[1 + shift][1].ToString();
                    prod_id[1] = (int)dt.Rows[1 + shift][11];

                    total--;

                    if (total <= 0)
                    {
                        return;
                    }

                    webClient = new WebClient();
                    imageData = webClient.DownloadData((string)dt.Rows[2 + shift][4].ToString());
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        pictureBox4.Image = Image.FromStream(ms);
                    }

                    name3.Text = (string)dt.Rows[2 + shift][0].ToString();
                    price3.Text = (string)dt.Rows[2 + shift][2].ToString();
                    nat3.Text = (string)dt.Rows[2 + shift][8].ToString();
                    sold3.Text = (string)dt.Rows[2 + shift][9].ToString();
                    quan3.Text = (string)dt.Rows[2 + shift][1].ToString();
                    prod_id[2] = (int)dt.Rows[2 + shift][11];

                    total--;

                    if (total <= 0)
                    {
                        return;
                    }

                    webClient = new WebClient();
                    imageData = webClient.DownloadData((string)dt.Rows[3 + shift][4].ToString());
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        pictureBox5.Image = Image.FromStream(ms);
                    }

                    name4.Text = (string)dt.Rows[3 + shift][0].ToString();
                    price4.Text = (string)dt.Rows[3 + shift][2].ToString();
                    nat4.Text = (string)dt.Rows[3 + shift][8].ToString();
                    sold4.Text = (string)dt.Rows[3 + shift][9].ToString();
                    quan4.Text = (string)dt.Rows[3 + shift][1].ToString();
                    prod_id[3] = (int)dt.Rows[3 + shift][11];

                    total--;

                    if (total <= 0)
                    {
                        return;
                    }

                    webClient = new WebClient();
                    imageData = webClient.DownloadData((string)dt.Rows[4 + shift][4].ToString());
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        pictureBox6.Image = Image.FromStream(ms);
                    }

                    name5.Text = (string)dt.Rows[4 + shift][0].ToString();
                    price5.Text = (string)dt.Rows[4 + shift][2].ToString();
                    nat5.Text = (string)dt.Rows[4 + shift][8].ToString();
                    sold5.Text = (string)dt.Rows[4 + shift][9].ToString();
                    quan5.Text = (string)dt.Rows[4 + shift][1].ToString();
                    prod_id[4] = (int)dt.Rows[4 + shift][11];
                }
                else
                {
                    MessageBox.Show("The requested item isn't available at the moment. come back soon!"
                        , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                discount();
                if (dis[0] == 1)
                {
                    dis1.Visible = true;
                }
                if (dis[1] == 1)
                {
                    dis2.Visible = true;
                }
                if (dis[2] == 1)
                {
                    dis3.Visible = true;
                }
                if (dis[3] == 1)
                {
                    dis4.Visible = true;
                }
                if (dis[4] == 1)
                {
                    dis5.Visible = true;
                }


                for (int i = 0; i < 5; i++)
                {
                    if (dis[i] == 1)
                    {
                        Console.WriteLine(1);
                    }
                    else
                    {
                        Console.WriteLine(0);
                    }
                }
            }
        }

        void discount()
        {

            List<(string, int)> list = new List<(string, int)>();
            for(int i = 0; i < Math.Min(prods, 5); i++)
            {
                string query = "SELECT expDate FROM Product WHERE productID = @prod_id;";
                using(SqlCommand cmd = new SqlCommand(query, connect)) {
                    cmd.Parameters.AddWithValue("@prod_id", prod_id[i]);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    list.Add((dt.Rows[0][0].ToString(), i));

                }
            }
            
            list.Sort((x, y) => x.Item1.CompareTo(y.Item1));
            for(int i = 0; i < Math.Min(prods, 2); i++)
            {
                dis[list[i].Item2] = 1;
            }
        }

        static string GetCurrentDateTimeString()
        {
            // Get the current date and time
            DateTime currentDateTime = DateTime.Now;

            // Format it as a string (adjust the format as needed)
            string formattedDateTime = currentDateTime.ToString("yyyy-MM-dd HH:mm:ss");

            return formattedDateTime;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Product_details Mform = new Product_details(prod_id[0]);
            Mform.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connect.Open();
            int sold;
            try
            {
                sold = int.Parse(sold1.Text);
            }
            catch
            {
                sold = 0;
            }
            int quan = int.Parse(quan1.Text);

            if (sold >= quan)
            {
                MessageBox.Show("The requested item is out of stock. come back soon!"
                        , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int to_buy = int.Parse(quantity.Text);
                if (to_buy > (quan - sold))
                {
                    MessageBox.Show("The quantity available isn't enough!"
                        , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string query = @"
                    INSERT INTO Order_(custID, transState, orderDate)
                    VALUES(@user_id,@paid,@date);
                ";

                string cur_date = GetCurrentDateTimeString();
                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@user_id", cur_id);
                    cmd.Parameters.AddWithValue("@paid", "pending");
                    cmd.Parameters.AddWithValue("@date", cur_date);
                    cmd.ExecuteNonQuery();
                }

                int num_of_orders = 0;
                string count = @"
                    SELECT orderID FROM Order_ WHERE custID = @cur_id AND orderDate = @cur_date;
                ";

                DataTable dt = new DataTable();
                using (SqlCommand cmd = new SqlCommand(count, connect))
                {
                    cmd.Parameters.AddWithValue("@cur_id", cur_id);
                    cmd.Parameters.AddWithValue("@cur_date", cur_date);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                    num_of_orders = dt.Rows.Count;
                }

                string query1 = @"
                    INSERT INTO Order_Product(orderID, productID, quantity)
                    VALUES(@order_id, @prod_id, @quantity);
                ";

                for (int i = 0; i < num_of_orders; i++)
                {
                    using (SqlCommand cmd = new SqlCommand(query1, connect))
                    {

                        cmd.Parameters.AddWithValue("@order_id", (int)dt.Rows[i][0]);
                        cmd.Parameters.AddWithValue("@prod_id", prod_id[0]);
                        cmd.Parameters.AddWithValue("@quantity", int.Parse(quantity.Text));

                        cmd.ExecuteNonQuery();
                    }
                }
            }

            connect.Close();
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void Products_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            prods = 0;
            for (int i = 0; i < 5; i++)
            {
                prod_id[i] = -1;
            }

            for (int i = 0; i < 5; i++)
            {
                dis[i] = 0;
            }
            name1.Text = name2.Text = name3.Text = name4.Text = name5.Text = null;
            price1.Text = price2.Text = price3.Text = price4.Text = price5.Text = null;
            nat1.Text = nat2.Text = nat3.Text = nat4.Text = nat5.Text = null;
            sold1.Text = sold2.Text = sold3.Text = sold4.Text = sold5.Text = null;
            quan1.Text = quan2.Text = quan3.Text = quan4.Text = quan5.Text = null;
            pictureBox2.Image = pictureBox3.Image = pictureBox4.Image = pictureBox5.Image = pictureBox6.Image = null;
            dis1.Visible = dis2.Visible = dis3.Visible = dis4.Visible = dis5.Visible = false;


            string query = @"SELECT 
                            p.productName, 
                            p.quantity, 
                            p.price, 
                            p.description_, 
                            p.imgLink, 
                            p.prodDate, 
                            p.expDate, 
                            br.brand, 
	                        c.country AS BrandOriigon,
                            opp.sold_last_day,
                            op.total_sold,
                            p.productID
                            FROM 
                                Product p
                            INNER JOIN 
                                Brand br ON p.brandID = br.brandID
                            INNER JOIN
	                            Country c ON br.countryID = c.countryID
                            LEFT JOIN 
                                (SELECT productID, COUNT(*) as total_sold FROM Order_Product GROUP BY productID) op ON p.productID = op.productID
                            LEFT JOIN 
                                CountLastDay opp ON p.productID = opp.productID
                            WHERE 
                                p.productName LIKE '%' + @product_name + '%';";



            using (SqlCommand cmd = new SqlCommand(query, connect))
            {
                cmd.Parameters.AddWithValue("@product_name", product_name.Text);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    int total = dt.Rows.Count - shift;
                    prods = total;
                    
                    if (total <= 0)
                    {
                        return;
                    }

                    WebClient webClient = new WebClient();
                    byte[] imageData = webClient.DownloadData((string)dt.Rows[0 + shift][4].ToString());
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        pictureBox2.Image = Image.FromStream(ms);
                    }

                    name1.Text = (string)dt.Rows[0 + shift][0].ToString();
                    price1.Text = (string)dt.Rows[0 + shift][2].ToString();
                    nat1.Text = (string)dt.Rows[0 + shift][8].ToString();
                    sold1.Text = (string)dt.Rows[0 + shift][9].ToString();
                    quan1.Text = (string)dt.Rows[0 + shift][1].ToString();
                    prod_id[0] = (int)dt.Rows[0 + shift][11];

                    total--;

                    if (total <= 0)
                    {
                        return;
                    }

                    webClient = new WebClient();
                    imageData = webClient.DownloadData((string)dt.Rows[1 + shift][4].ToString());
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        pictureBox3.Image = Image.FromStream(ms);
                    }

                    name2.Text = (string)dt.Rows[1 + shift][0].ToString();
                    price2.Text = (string)dt.Rows[1 + shift][2].ToString();
                    nat2.Text = (string)dt.Rows[1 + shift][8].ToString();
                    sold2.Text = (string)dt.Rows[1 + shift][9].ToString();
                    quan2.Text = (string)dt.Rows[1 + shift][1].ToString();
                    prod_id[1] = (int)dt.Rows[1 + shift][11];

                    total--;

                    if (total <= 0)
                    {
                        return;
                    }

                    webClient = new WebClient();
                    imageData = webClient.DownloadData((string)dt.Rows[2 + shift][4].ToString());
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        pictureBox4.Image = Image.FromStream(ms);
                    }

                    name3.Text = (string)dt.Rows[2 + shift][0].ToString();
                    price3.Text = (string)dt.Rows[2 + shift][2].ToString();
                    nat3.Text = (string)dt.Rows[2 + shift][8].ToString();
                    sold3.Text = (string)dt.Rows[2 + shift][9].ToString();
                    quan3.Text = (string)dt.Rows[2 + shift][1].ToString();
                    prod_id[2] = (int)dt.Rows[2 + shift][11];

                    total--;

                    if (total <= 0)
                    {
                        return;
                    }

                    webClient = new WebClient();
                    imageData = webClient.DownloadData((string)dt.Rows[3 + shift][4].ToString());
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        pictureBox5.Image = Image.FromStream(ms);
                    }

                    name4.Text = (string)dt.Rows[3 + shift][0].ToString();
                    price4.Text = (string)dt.Rows[3 + shift][2].ToString();
                    nat4.Text = (string)dt.Rows[3 + shift][8].ToString();
                    sold4.Text = (string)dt.Rows[3 + shift][9].ToString();
                    quan4.Text = (string)dt.Rows[3 + shift][1].ToString();
                    prod_id[3] = (int)dt.Rows[3 + shift][11];

                    total--;

                    if (total <= 0)
                    {
                        return;
                    }

                    webClient = new WebClient();
                    imageData = webClient.DownloadData((string)dt.Rows[4 + shift][4].ToString());
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        pictureBox6.Image = Image.FromStream(ms);
                    }

                    name5.Text = (string)dt.Rows[4 + shift][0].ToString();
                    price5.Text = (string)dt.Rows[4 + shift][2].ToString();
                    nat5.Text = (string)dt.Rows[4 + shift][8].ToString();
                    sold5.Text = (string)dt.Rows[4 + shift][9].ToString();
                    quan5.Text = (string)dt.Rows[4 + shift][1].ToString();
                    prod_id[4] = (int)dt.Rows[4 + shift][11];
                }
                else
                {
                    MessageBox.Show("The requested item isn't available at the moment. come back soon!"
                        , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                discount();
                if (dis[0] == 1)
                {
                    dis1.Visible = true;
                }
                if (dis[1] == 1)
                {
                    dis2.Visible = true;
                }
                if (dis[2] == 1)
                {
                    dis3.Visible = true;
                }
                if (dis[3] == 1)
                {
                    dis4.Visible = true;
                }
                if (dis[4] == 1)
                {
                    dis5.Visible = true;
                }


                for (int i = 0; i < 5; i++)
                {
                    if (dis[i] == 1)
                    {
                        Console.WriteLine(1);
                    }
                    else
                    {
                        Console.WriteLine(0);
                    }
                }
            }
        }

        private void filter2_Click(object sender, EventArgs e)
        {
            prods = 0;
            for (int i = 0; i < 5; i++)
            {
                prod_id[i] = -1;
            }

            for (int i = 0; i < 5; i++)
            {
                dis[i] = 0;
            }
            name1.Text = name2.Text = name3.Text = name4.Text = name5.Text = null;
            price1.Text = price2.Text = price3.Text = price4.Text = price5.Text = null;
            nat1.Text = nat2.Text = nat3.Text = nat4.Text = nat5.Text = null;
            sold1.Text = sold2.Text = sold3.Text = sold4.Text = sold5.Text = null;
            quan1.Text = quan2.Text = quan3.Text = quan4.Text = quan5.Text = null;
            pictureBox2.Image = pictureBox3.Image = pictureBox4.Image = pictureBox5.Image = pictureBox6.Image = null;
            dis1.Visible = dis2.Visible = dis3.Visible = dis4.Visible = dis5.Visible = false;


            string query = @"SELECT 
                p.productName, 
                p.quantity, 
                p.price, 
                p.description_, 
                p.imgLink, 
                p.prodDate, 
                p.expDate, 
                br.brand, 
                c.country AS BrandOriigon,
                opp.sold_last_day,
                op.total_sold,
                p.productID
                FROM 
                    Product p
                INNER JOIN 
                    Brand br ON p.brandID = br.brandID
                INNER JOIN
                    Country c ON br.countryID = c.countryID
                LEFT JOIN 
                    (SELECT productID, COUNT(*) as total_sold FROM Order_Product GROUP BY productID) op ON p.productID = op.productID
                LEFT JOIN 
                    CountLastDay opp ON p.productID = opp.productID
                WHERE 
                    p.productName LIKE '%' + @product_name + '%'
                AND
                    p.price BETWEEN @min AND @max;";



            using (SqlCommand cmd = new SqlCommand(query, connect))
            {
                cmd.Parameters.AddWithValue("@product_name", product_name.Text);
                cmd.Parameters.AddWithValue("@min", int.Parse(textBox3.Text));
                cmd.Parameters.AddWithValue("@max", int.Parse(textBox4.Text));

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    int total = dt.Rows.Count - shift;
                    prods = total;
                    
                    if (total <= 0)
                    {
                        return;
                    }

                    WebClient webClient = new WebClient();
                    byte[] imageData = webClient.DownloadData((string)dt.Rows[0 + shift][4].ToString());
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        pictureBox2.Image = Image.FromStream(ms);
                    }

                    name1.Text = (string)dt.Rows[0 + shift][0].ToString();
                    price1.Text = (string)dt.Rows[0 + shift][2].ToString();
                    nat1.Text = (string)dt.Rows[0 + shift][8].ToString();
                    sold1.Text = (string)dt.Rows[0 + shift][9].ToString();
                    quan1.Text = (string)dt.Rows[0 + shift][1].ToString();
                    prod_id[0] = (int)dt.Rows[0 + shift][11];

                    total--;
                    if (total <= 0)
                    {
                        return;
                    }

                    webClient = new WebClient();
                    imageData = webClient.DownloadData((string)dt.Rows[1 + shift][4].ToString());
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        pictureBox3.Image = Image.FromStream(ms);
                    }

                    name2.Text = (string)dt.Rows[1 + shift][0].ToString();
                    price2.Text = (string)dt.Rows[1 + shift][2].ToString();
                    nat2.Text = (string)dt.Rows[1 + shift][8].ToString();
                    sold2.Text = (string)dt.Rows[1 + shift][9].ToString();
                    quan2.Text = (string)dt.Rows[1 + shift][1].ToString();
                    prod_id[1] = (int)dt.Rows[1 + shift][11];

                    total--;
                    if (total <= 0)
                    {
                        return;
                    }

                    webClient = new WebClient();
                    imageData = webClient.DownloadData((string)dt.Rows[2 + shift][4].ToString());
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        pictureBox4.Image = Image.FromStream(ms);
                    }

                    name3.Text = (string)dt.Rows[2 + shift][0].ToString();
                    price3.Text = (string)dt.Rows[2 + shift][2].ToString();
                    nat3.Text = (string)dt.Rows[2 + shift][8].ToString();
                    sold3.Text = (string)dt.Rows[2 + shift][9].ToString();
                    quan3.Text = (string)dt.Rows[2 + shift][1].ToString();
                    prod_id[2] = (int)dt.Rows[2 + shift][11];

                    total--;
                    if (total <= 0)
                    {
                        return;
                    }

                    webClient = new WebClient();
                    imageData = webClient.DownloadData((string)dt.Rows[3 + shift][4].ToString());
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        pictureBox5.Image = Image.FromStream(ms);
                    }

                    name4.Text = (string)dt.Rows[3 + shift][0].ToString();
                    price4.Text = (string)dt.Rows[3 + shift][2].ToString();
                    nat4.Text = (string)dt.Rows[3 + shift][8].ToString();
                    sold4.Text = (string)dt.Rows[3 + shift][9].ToString();
                    quan4.Text = (string)dt.Rows[3 + shift][1].ToString();
                    prod_id[3] = (int)dt.Rows[3 + shift][11];

                    total--;
                    if (total <= 0)
                    {
                        return;
                    }

                    webClient = new WebClient();
                    imageData = webClient.DownloadData((string)dt.Rows[4 + shift][4].ToString());
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        pictureBox6.Image = Image.FromStream(ms);
                    }

                    name5.Text = (string)dt.Rows[4 + shift][0].ToString();
                    price5.Text = (string)dt.Rows[4 + shift][2].ToString();
                    nat5.Text = (string)dt.Rows[4 + shift][8].ToString();
                    sold5.Text = (string)dt.Rows[4 + shift][9].ToString();
                    quan5.Text = (string)dt.Rows[4 + shift][1].ToString();
                    prod_id[4] = (int)dt.Rows[4 + shift][11];
                    
                }
                else
                {
                    MessageBox.Show("The requested item isn't available at the moment. come back soon!"
                        , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                discount();
                if (dis[0] == 1)
                {
                    dis1.Visible = true;
                }
                if (dis[1] == 1)
                {
                    dis2.Visible = true;
                }
                if (dis[2] == 1)
                {
                    dis3.Visible = true;
                }
                if (dis[3] == 1)
                {
                    dis4.Visible = true;
                }
                if (dis[4] == 1)
                {
                    dis5.Visible = true;
                }


                for (int i = 0; i < 5; i++)
                {
                    if (dis[i] == 1)
                    {
                        Console.WriteLine(1);
                    }
                    else
                    {
                        Console.WriteLine(0);
                    }
                }
            }
        }

        private void filter_Click(object sender, EventArgs e)
        {
            prods = 0;
            for (int i = 0; i < 5; i++)
            {
                prod_id[i] = -1;
            }

            for (int i = 0; i < 5; i++)
            {
                dis[i] = 0;
            }
            name1.Text = name2.Text = name3.Text = name4.Text = name5.Text = null;
            price1.Text = price2.Text = price3.Text = price4.Text = price5.Text = null;
            nat1.Text = nat2.Text = nat3.Text = nat4.Text = nat5.Text = null;
            sold1.Text = sold2.Text = sold3.Text = sold4.Text = sold5.Text = null;
            quan1.Text = quan2.Text = quan3.Text = quan4.Text = quan5.Text = null;
            pictureBox2.Image = pictureBox3.Image = pictureBox4.Image = pictureBox5.Image = pictureBox6.Image = null;
            dis1.Visible = dis2.Visible = dis3.Visible = dis4.Visible = dis5.Visible = false;


            string query = @"SELECT 
                            p.productName, 
                            p.quantity, 
                            p.price, 
                            p.description_, 
                            p.imgLink, 
                            p.prodDate, 
                            p.expDate, 
                            br.brand, 
	                        c.country AS BrandOriigon,
                            opp.sold_last_day,
                            op.total_sold,
                            p.productID
                            FROM 
                                Product p
                            INNER JOIN 
                                Brand br ON p.brandID = br.brandID
                            INNER JOIN
	                            Country c ON br.countryID = c.countryID
                            LEFT JOIN 
                                (SELECT productID, COUNT(*) as total_sold FROM Order_Product GROUP BY productID) op ON p.productID = op.productID
                            LEFT JOIN 
                                CountLastDay opp ON p.productID = opp.productID
                            WHERE 
                                p.productName LIKE '%' + @product_name + '%'
                            AND
                                c.country = @nat;";



            using (SqlCommand cmd = new SqlCommand(query, connect))
            {
                cmd.Parameters.AddWithValue("@product_name", product_name.Text);
                cmd.Parameters.AddWithValue("@nat", textBox2.Text);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    int total = dt.Rows.Count - shift;
                    prods = total;
                    
                    if (total <= 0)
                    {
                        return;
                    }

                    WebClient webClient = new WebClient();
                    byte[] imageData = webClient.DownloadData((string)dt.Rows[0 + shift][4].ToString());
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        pictureBox2.Image = Image.FromStream(ms);
                    }

                    name1.Text = (string)dt.Rows[0 + shift][0].ToString();
                    price1.Text = (string)dt.Rows[0 + shift][2].ToString();
                    nat1.Text = (string)dt.Rows[0 + shift][8].ToString();
                    sold1.Text = (string)dt.Rows[0 + shift][9].ToString();
                    quan1.Text = (string)dt.Rows[0 + shift][1].ToString();
                    prod_id[0] = (int)dt.Rows[0 + shift][11];

                    total--;
                    if (total <= 0)
                    {
                        return;
                    }

                    webClient = new WebClient();
                    imageData = webClient.DownloadData((string)dt.Rows[1 + shift][4].ToString());
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        pictureBox3.Image = Image.FromStream(ms);
                    }

                    name2.Text = (string)dt.Rows[1 + shift][0].ToString();
                    price2.Text = (string)dt.Rows[1 + shift][2].ToString();
                    nat2.Text = (string)dt.Rows[1 + shift][8].ToString();
                    sold2.Text = (string)dt.Rows[1 + shift][9].ToString();
                    quan2.Text = (string)dt.Rows[1 + shift][1].ToString();
                    prod_id[1] = (int)dt.Rows[1 + shift][11];

                    total--;
                    if (total <= 0)
                    {
                        return;
                    }

                    webClient = new WebClient();
                    imageData = webClient.DownloadData((string)dt.Rows[2 + shift][4].ToString());
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        pictureBox4.Image = Image.FromStream(ms);
                    }

                    name3.Text = (string)dt.Rows[2 + shift][0].ToString();
                    price3.Text = (string)dt.Rows[2 + shift][2].ToString();
                    nat3.Text = (string)dt.Rows[2 + shift][8].ToString();
                    sold3.Text = (string)dt.Rows[2 + shift][9].ToString();
                    quan3.Text = (string)dt.Rows[2 + shift][1].ToString();
                    prod_id[2] = (int)dt.Rows[2 + shift][11];

                    total--;
                    if (total <= 0)
                    {
                        return;
                    }

                    webClient = new WebClient();
                    imageData = webClient.DownloadData((string)dt.Rows[3 + shift][4].ToString());
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        pictureBox5.Image = Image.FromStream(ms);
                    }

                    name4.Text = (string)dt.Rows[3 + shift][0].ToString();
                    price4.Text = (string)dt.Rows[3 + shift][2].ToString();
                    nat4.Text = (string)dt.Rows[3 + shift][8].ToString();
                    sold4.Text = (string)dt.Rows[3 + shift][9].ToString();
                    quan4.Text = (string)dt.Rows[3 + shift][1].ToString();
                    prod_id[3] = (int)dt.Rows[3 + shift][11];

                    total--;
                    if (total <= 0)
                    {
                        return;
                    }

                    webClient = new WebClient();
                    imageData = webClient.DownloadData((string)dt.Rows[4 + shift][4].ToString());
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        pictureBox6.Image = Image.FromStream(ms);
                    }

                    name5.Text = (string)dt.Rows[4 + shift][0].ToString();
                    price5.Text = (string)dt.Rows[4 + shift][2].ToString();
                    nat5.Text = (string)dt.Rows[4 + shift][8].ToString();
                    sold5.Text = (string)dt.Rows[4 + shift][9].ToString();
                    quan5.Text = (string)dt.Rows[4 + shift][1].ToString();
                    prod_id[4] = (int)dt.Rows[4 + shift][11];
                    
                }
                else
                {
                    MessageBox.Show("The requested item isn't available at the moment. come back soon!"
                        , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                discount();
                if (dis[0] == 1)
                {
                    dis1.Visible = true;
                }
                if (dis[1] == 1)
                {
                    dis2.Visible = true;
                }
                if (dis[2] == 1)
                {
                    dis3.Visible = true;
                }
                if (dis[3] == 1)
                {
                    dis4.Visible = true;
                }
                if (dis[4] == 1)
                {
                    dis5.Visible = true;
                }
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            connect.Open();
            int sold;
            try
            {
                sold = int.Parse(sold2.Text);
            }
            catch
            {
                sold = 0;
            }
            int quan = int.Parse(quan2.Text);

            if (sold >= quan)
            {
                MessageBox.Show("The requested item is out of stock. come back soon!"
                        , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int to_buy = int.Parse(quantity.Text);
                if (to_buy > (quan - sold))
                {
                    MessageBox.Show("The quantity available isn't enough!"
                        , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string query = @"
                    INSERT INTO Order_(custID, transState, orderDate)
                    VALUES(@user_id,@paid,@date);
                ";
                string cur_date = GetCurrentDateTimeString();
                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@user_id", cur_id);
                    cmd.Parameters.AddWithValue("@paid", "pending");
                    cmd.Parameters.AddWithValue("@date", cur_date);
                    cmd.ExecuteNonQuery();
                }

                int num_of_orders = 0;
                string count = @"
                    SELECT orderID FROM Order_ WHERE custID = @cur_id AND orderDate = @cur_date;
                    ";


                DataTable dt = new DataTable();
                using (SqlCommand cmd = new SqlCommand(count, connect))
                {
                    cmd.Parameters.AddWithValue("@cur_id", cur_id);
                    cmd.Parameters.AddWithValue("@cur_date", cur_date);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                    num_of_orders = dt.Rows.Count;

                }

                string query1 = @"
                    INSERT INTO Order_Product(orderID, productID, quantity)
                    VALUES(@order_id, @prod_id, @quantity);
                ";

                for (int i = 0; i < num_of_orders; i++)
                {
                    using (SqlCommand cmd = new SqlCommand(query1, connect))
                    {
                        cmd.Parameters.AddWithValue("@order_id", (int)dt.Rows[i][0]);
                        cmd.Parameters.AddWithValue("@prod_id", prod_id[1]);
                        cmd.Parameters.AddWithValue("@quantity", int.Parse(quantity.Text));

                        cmd.ExecuteNonQuery();
                    }
                }
            }

            connect.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            connect.Open();
            int sold;
            try
            {
                sold = int.Parse(sold3.Text);
            }
            catch
            {
                sold = 0;
            }
            int quan = int.Parse(quan3.Text);

            if (sold >= quan)
            {
                MessageBox.Show("The requested item is out of stock. come back soon!"
                        , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int to_buy = int.Parse(quantity.Text);
                if (to_buy > (quan - sold))
                {
                    MessageBox.Show("The quantity available isn't enough!"
                        , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string query = @"
                    INSERT INTO Order_(custID, transState, orderDate)
                    VALUES(@user_id,@paid,@date);
                ";
                string cur_date = GetCurrentDateTimeString();
                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@user_id", cur_id);
                    cmd.Parameters.AddWithValue("@paid", "pending");
                    cmd.Parameters.AddWithValue("@date", cur_date);
                    cmd.ExecuteNonQuery();
                }

                int num_of_orders = 0;
                string count = @"
                    SELECT orderID FROM Order_ WHERE custID = @cur_id AND orderDate = @cur_date;
                ";

                DataTable dt = new DataTable();
                using (SqlCommand cmd = new SqlCommand(count, connect))
                {
                    cmd.Parameters.AddWithValue("@cur_id", cur_id);
                    cmd.Parameters.AddWithValue("@cur_date", cur_date);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                    num_of_orders = dt.Rows.Count;

                }

                string query1 = @"
                    INSERT INTO Order_Product(orderID, productID, quantity)
                    VALUES(@order_id, @prod_id, @quantity);
                ";

                for (int i = 0; i < num_of_orders; i++)
                {
                    using (SqlCommand cmd = new SqlCommand(query1, connect))
                    {
                        cmd.Parameters.AddWithValue("@order_id", (int)dt.Rows[i][0]);
                        cmd.Parameters.AddWithValue("@prod_id", prod_id[2]);
                        cmd.Parameters.AddWithValue("@quantity", int.Parse(quantity.Text));

                        cmd.ExecuteNonQuery();
                    }
                }
            }

            connect.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            connect.Open();
            int sold;
            try
            {
                sold = int.Parse(sold4.Text);
            }
            catch
            {
                sold = 0;
            }
            int quan = int.Parse(quan4.Text);

            if (sold >= quan)
            {
                MessageBox.Show("The requested item is out of stock. come back soon!"
                        , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int to_buy = int.Parse(quantity.Text);
                if (to_buy > (quan - sold))
                {
                    MessageBox.Show("The quantity available isn't enough!"
                        , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string query = @"
                    INSERT INTO Order_(custID, transState, orderDate)
                    VALUES(@user_id,@paid,@date);
                ";
                string cur_date = GetCurrentDateTimeString();
                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@user_id", cur_id);
                    cmd.Parameters.AddWithValue("@paid", "pending");
                    cmd.Parameters.AddWithValue("@date", cur_date);
                    cmd.ExecuteNonQuery();
                }

                int num_of_orders = 0;
                string count = @"
                    SELECT orderID FROM Order_ WHERE custID = @cur_id AND orderDate = @cur_date;
                ";

                DataTable dt = new DataTable();
                using (SqlCommand cmd = new SqlCommand(count, connect))
                {
                    cmd.Parameters.AddWithValue("@cur_id", cur_id);
                    cmd.Parameters.AddWithValue("@cur_date", cur_date);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                    num_of_orders = dt.Rows.Count;

                }

                string query1 = @"
                    INSERT INTO Order_Product(orderID, productID, quantity)
                    VALUES(@order_id, @prod_id, @quantity);
                ";

                for (int i = 0; i < num_of_orders; i++)
                {
                    using (SqlCommand cmd = new SqlCommand(query1, connect))
                    {
                        cmd.Parameters.AddWithValue("@order_id", (int)dt.Rows[i][0]);
                        cmd.Parameters.AddWithValue("@prod_id", prod_id[3]);
                        cmd.Parameters.AddWithValue("@quantity", int.Parse(quantity.Text));

                        cmd.ExecuteNonQuery();
                    }
                }
            }

            connect.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            connect.Open();
            int sold;
            try
            {
                sold = int.Parse(sold5.Text);
            }
            catch
            {
                sold = 0;
            }
            int quan = int.Parse(quan5.Text);

            if (sold >= quan)
            {
                MessageBox.Show("The requested item is out of stock. come back soon!"
                        , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int to_buy = int.Parse(quantity.Text);
                if (to_buy > (quan - sold))
                {
                    MessageBox.Show("The quantity available isn't enough!"
                        , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string query = @"
                    INSERT INTO Order_(custID, transState, orderDate)
                    VALUES(@user_id,@paid,@date);
                ";
                string cur_date = GetCurrentDateTimeString();
                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@user_id", cur_id);
                    cmd.Parameters.AddWithValue("@paid", "pending");
                    cmd.Parameters.AddWithValue("@date", cur_date);
                    cmd.ExecuteNonQuery();
                }

                int num_of_orders = 0;
                string count = @"
                    SELECT orderID FROM Order_ WHERE custID = @cur_id AND orderDate = @cur_date;
                ";

                DataTable dt = new DataTable();
                using (SqlCommand cmd = new SqlCommand(count, connect))
                {
                    cmd.Parameters.AddWithValue("@cur_id", cur_id);
                    cmd.Parameters.AddWithValue("@cur_date", cur_date);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                    num_of_orders = dt.Rows.Count;

                }

                string query1 = @"
                    INSERT INTO Order_Product(orderID, productID, quantity)
                    VALUES(@order_id, @prod_id, @quantity);
                ";

                for (int i = 0; i < num_of_orders; i++)
                {
                    using (SqlCommand cmd = new SqlCommand(query1, connect))
                    {
                        cmd.Parameters.AddWithValue("@order_id", (int)dt.Rows[i][0]);
                        cmd.Parameters.AddWithValue("@prod_id", prod_id[4]);
                        cmd.Parameters.AddWithValue("@quantity", int.Parse(quantity.Text));

                        cmd.ExecuteNonQuery();
                    }
                }
            }

            connect.Close();
        }

        private void quantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Cart mForm = new Cart(cur_id);
            mForm.Show();
            this.Hide();
        }

        private void load_more_Click(object sender, EventArgs e)
        {
            shift += 5;
            search.PerformClick();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            shift = 0;
            search.PerformClick();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Product_details Mform = new Product_details(prod_id[1]);
            Mform.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Product_details Mform = new Product_details(prod_id[2]);
            Mform.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Product_details Mform = new Product_details(prod_id[3]);
            Mform.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Product_details Mform = new Product_details(prod_id[4]);
            Mform.Show();
        }
    }
}
