namespace EmployeeManagementSystem
{
    partial class Product_details
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
            pictureBox1 = new PictureBox();
            name = new Label();
            price = new Label();
            nat = new Label();
            sold = new Label();
            av = new Label();
            brand = new Label();
            ex = new Label();
            panel1 = new Panel();
            des = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, 79);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(360, 334);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // name
            // 
            name.AutoSize = true;
            name.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            name.Location = new Point(131, 18);
            name.Name = "name";
            name.Size = new Size(89, 32);
            name.TabIndex = 76;
            name.Text = "name";
            name.Click += label4_Click;
            // 
            // price
            // 
            price.AutoSize = true;
            price.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            price.Location = new Point(57, 476);
            price.Name = "price";
            price.Size = new Size(54, 25);
            price.TabIndex = 77;
            price.Text = "price";
            // 
            // nat
            // 
            nat.AutoSize = true;
            nat.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nat.Location = new Point(57, 520);
            nat.Name = "nat";
            nat.Size = new Size(99, 25);
            nat.TabIndex = 78;
            nat.Text = "nationality";
            // 
            // sold
            // 
            sold.AutoSize = true;
            sold.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sold.Location = new Point(203, 432);
            sold.Name = "sold";
            sold.Size = new Size(85, 25);
            sold.TabIndex = 80;
            sold.Text = "# of sold";
            // 
            // av
            // 
            av.AutoSize = true;
            av.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            av.Location = new Point(203, 476);
            av.Name = "av";
            av.Size = new Size(126, 25);
            av.TabIndex = 81;
            av.Text = "# of available";
            // 
            // brand
            // 
            brand.AutoSize = true;
            brand.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            brand.Location = new Point(57, 432);
            brand.Name = "brand";
            brand.Size = new Size(62, 25);
            brand.TabIndex = 85;
            brand.Text = "brand";
            // 
            // ex
            // 
            ex.AutoSize = true;
            ex.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ex.Location = new Point(205, 520);
            ex.Name = "ex";
            ex.Size = new Size(76, 25);
            ex.TabIndex = 83;
            ex.Text = "ex date";
            // 
            // panel1
            // 
            panel1.Controls.Add(brand);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(ex);
            panel1.Controls.Add(av);
            panel1.Controls.Add(name);
            panel1.Controls.Add(sold);
            panel1.Controls.Add(price);
            panel1.Controls.Add(nat);
            panel1.Location = new Point(395, 15);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(362, 663);
            panel1.TabIndex = 86;
            panel1.Paint += panel1_Paint;
            // 
            // des
            // 
            des.AutoSize = true;
            des.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            des.Location = new Point(12, 40);
            des.Name = "des";
            des.Size = new Size(44, 25);
            des.TabIndex = 86;
            des.Text = "des";
            des.Click += des_Click;
            // 
            // Product_details
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(802, 691);
            Controls.Add(des);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Product_details";
            Text = "Product_details";
            Load += Product_details_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label nat;
        private System.Windows.Forms.Label sold;
        private System.Windows.Forms.Label av;
        private System.Windows.Forms.Label brand;
        private System.Windows.Forms.Label ex;
        private System.Windows.Forms.Panel panel1;
        private Label des;
    }
}