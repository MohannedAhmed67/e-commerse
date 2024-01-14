using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net;

namespace EmployeeManagementSystem
{
    public partial class Product_details : Form
    {
        int prod_id;
        SqlConnection connect
            = new SqlConnection(@"Server=mssql-160155-0.cloudclusters.net,18755; Database= 3m-Rashed-Market; User Id=1517002; Password=123Rashed123; Trusted_Connection=False;TrustServerCertificate=True; MultipleActiveResultSets=true");
        static string BeautifyString(string input, int wordsPerLine)
        {
            string[] words = input.Split(' ');

            StringBuilder beautifiedText = new StringBuilder();
            int wordCount = 0;

            foreach (string word in words)
            {
                beautifiedText.Append(word).Append(" ");
                wordCount++;

                if (wordCount % wordsPerLine == 0)
                {
                    beautifiedText.AppendLine();
                }
            }

            return beautifiedText.ToString().Trim();
        }
        public Product_details(int id)
        {
            InitializeComponent();
            prod_id = id;
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
                            op.total_sold,
	                        opp.sold_last_day,
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
                                p.productID = @id;";

            using (SqlCommand cmd = new SqlCommand(query, connect))
            {
                cmd.Parameters.AddWithValue("@id", prod_id);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                WebClient webClient = new WebClient();
                byte[] imageData = webClient.DownloadData((string)dt.Rows[0][4].ToString());
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    pictureBox1.Image = Image.FromStream(ms);
                }

                name.Text = (string)dt.Rows[0][0].ToString();
                price.Text = (string)dt.Rows[0][2].ToString();
                nat.Text = (string)dt.Rows[0][8].ToString();
                sold.Text = (string)dt.Rows[0][9].ToString();
                av.Text = (string)dt.Rows[0][1].ToString();
                ex.Text = (string)dt.Rows[0][6].ToString();
                des.Text = BeautifyString((string)dt.Rows[0][3].ToString(), 5);
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void product_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void des_Click(object sender, EventArgs e)
        {

        }

        private void Product_details_Load(object sender, EventArgs e)
        {

        }
    }
}
