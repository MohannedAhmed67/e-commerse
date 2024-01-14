namespace _3m_Rashed_Market
{
    partial class Cart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cart));
            proceed = new Button();
            search = new Button();
            label22 = new Label();
            brand_input = new TextBox();
            panel1 = new Panel();
            quan1_box = new TextBox();
            quan1 = new Label();
            remove1 = new Button();
            brand1 = new Label();
            av1 = new Label();
            price1 = new Label();
            ex_date1 = new Label();
            nat1 = new Label();
            name1 = new Label();
            pic1 = new PictureBox();
            panel2 = new Panel();
            quan2_box = new TextBox();
            quan2 = new Label();
            remove2 = new Button();
            brand2 = new Label();
            av2 = new Label();
            price2 = new Label();
            ex_date2 = new Label();
            nat2 = new Label();
            name2 = new Label();
            pic2 = new PictureBox();
            panel3 = new Panel();
            quan3_box = new TextBox();
            quan3 = new Label();
            remove3 = new Button();
            brand3 = new Label();
            av3 = new Label();
            price3 = new Label();
            ex_date3 = new Label();
            nat3 = new Label();
            name3 = new Label();
            pic3 = new PictureBox();
            Current_User = new Label();
            pictureBox4 = new PictureBox();
            Load_More = new Button();
            Refresh = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // proceed
            // 
            proceed.Location = new Point(296, 572);
            proceed.Margin = new Padding(3, 4, 3, 4);
            proceed.Name = "proceed";
            proceed.Size = new Size(207, 62);
            proceed.TabIndex = 59;
            proceed.Text = "Proceed to checkout";
            proceed.UseVisualStyleBackColor = true;
            proceed.Click += button4_Click;
            // 
            // search
            // 
            search.Location = new Point(231, 44);
            search.Margin = new Padding(3, 4, 3, 4);
            search.Name = "search";
            search.Size = new Size(82, 41);
            search.TabIndex = 62;
            search.Text = "Search";
            search.UseVisualStyleBackColor = true;
            search.Click += button6_Click;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(368, 11);
            label22.Name = "label22";
            label22.Size = new Size(89, 20);
            label22.TabIndex = 61;
            label22.Text = "Brand name";
            label22.Click += label22_Click;
            // 
            // brand_input
            // 
            brand_input.Location = new Point(331, 50);
            brand_input.Margin = new Padding(3, 4, 3, 4);
            brand_input.Name = "brand_input";
            brand_input.Size = new Size(172, 27);
            brand_input.TabIndex = 60;
            brand_input.TextChanged += textBox4_TextChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(quan1_box);
            panel1.Controls.Add(quan1);
            panel1.Controls.Add(remove1);
            panel1.Controls.Add(brand1);
            panel1.Controls.Add(av1);
            panel1.Controls.Add(price1);
            panel1.Controls.Add(ex_date1);
            panel1.Controls.Add(nat1);
            panel1.Controls.Add(name1);
            panel1.Controls.Add(pic1);
            panel1.Location = new Point(12, 170);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(207, 312);
            panel1.TabIndex = 63;
            // 
            // quan1_box
            // 
            quan1_box.Location = new Point(110, 238);
            quan1_box.Margin = new Padding(3, 4, 3, 4);
            quan1_box.Name = "quan1_box";
            quan1_box.Size = new Size(49, 27);
            quan1_box.TabIndex = 48;
            // 
            // quan1
            // 
            quan1.AutoSize = true;
            quan1.Location = new Point(32, 241);
            quan1.Name = "quan1";
            quan1.Size = new Size(66, 20);
            quan1.TabIndex = 47;
            quan1.Text = "quantity:";
            // 
            // remove1
            // 
            remove1.Location = new Point(35, 284);
            remove1.Margin = new Padding(3, 4, 3, 4);
            remove1.Name = "remove1";
            remove1.Size = new Size(124, 29);
            remove1.TabIndex = 46;
            remove1.Text = "remove from cart";
            remove1.UseVisualStyleBackColor = true;
            remove1.Click += remove1_Click;
            // 
            // brand1
            // 
            brand1.AutoSize = true;
            brand1.Location = new Point(117, 170);
            brand1.Name = "brand1";
            brand1.Size = new Size(48, 20);
            brand1.TabIndex = 45;
            brand1.Text = "brand";
            // 
            // av1
            // 
            av1.AutoSize = true;
            av1.Location = new Point(117, 206);
            av1.Name = "av1";
            av1.Size = new Size(100, 20);
            av1.TabIndex = 44;
            av1.Text = "# of available";
            // 
            // price1
            // 
            price1.AutoSize = true;
            price1.Location = new Point(115, 131);
            price1.Name = "price1";
            price1.Size = new Size(42, 20);
            price1.TabIndex = 43;
            price1.Text = "price";
            // 
            // ex_date1
            // 
            ex_date1.AutoSize = true;
            ex_date1.Location = new Point(22, 206);
            ex_date1.Name = "ex_date1";
            ex_date1.Size = new Size(58, 20);
            ex_date1.TabIndex = 42;
            ex_date1.Text = "ex date";
            // 
            // nat1
            // 
            nat1.AutoSize = true;
            nat1.Location = new Point(22, 170);
            nat1.Name = "nat1";
            nat1.Size = new Size(79, 20);
            nat1.TabIndex = 41;
            nat1.Text = "nationality";
            // 
            // name1
            // 
            name1.AutoSize = true;
            name1.Location = new Point(22, 131);
            name1.Name = "name1";
            name1.Size = new Size(46, 20);
            name1.TabIndex = 40;
            name1.Text = "name";
            // 
            // pic1
            // 
            pic1.InitialImage = (Image)resources.GetObject("pic1.InitialImage");
            pic1.Location = new Point(0, 0);
            pic1.Margin = new Padding(3, 4, 3, 4);
            pic1.Name = "pic1";
            pic1.Size = new Size(207, 120);
            pic1.SizeMode = PictureBoxSizeMode.Zoom;
            pic1.TabIndex = 39;
            pic1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(quan2_box);
            panel2.Controls.Add(quan2);
            panel2.Controls.Add(remove2);
            panel2.Controls.Add(brand2);
            panel2.Controls.Add(av2);
            panel2.Controls.Add(price2);
            panel2.Controls.Add(ex_date2);
            panel2.Controls.Add(nat2);
            panel2.Controls.Add(name2);
            panel2.Controls.Add(pic2);
            panel2.Location = new Point(296, 170);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(207, 312);
            panel2.TabIndex = 64;
            // 
            // quan2_box
            // 
            quan2_box.Location = new Point(117, 238);
            quan2_box.Margin = new Padding(3, 4, 3, 4);
            quan2_box.Name = "quan2_box";
            quan2_box.Size = new Size(49, 27);
            quan2_box.TabIndex = 48;
            // 
            // quan2
            // 
            quan2.AutoSize = true;
            quan2.Location = new Point(32, 241);
            quan2.Name = "quan2";
            quan2.Size = new Size(66, 20);
            quan2.TabIndex = 47;
            quan2.Text = "quantity:";
            // 
            // remove2
            // 
            remove2.Location = new Point(35, 284);
            remove2.Margin = new Padding(3, 4, 3, 4);
            remove2.Name = "remove2";
            remove2.Size = new Size(124, 29);
            remove2.TabIndex = 46;
            remove2.Text = "remove from cart";
            remove2.UseVisualStyleBackColor = true;
            remove2.Click += remove2_Click;
            // 
            // brand2
            // 
            brand2.AutoSize = true;
            brand2.Location = new Point(117, 170);
            brand2.Name = "brand2";
            brand2.Size = new Size(48, 20);
            brand2.TabIndex = 45;
            brand2.Text = "brand";
            // 
            // av2
            // 
            av2.AutoSize = true;
            av2.Location = new Point(117, 206);
            av2.Name = "av2";
            av2.Size = new Size(100, 20);
            av2.TabIndex = 44;
            av2.Text = "# of available";
            // 
            // price2
            // 
            price2.AutoSize = true;
            price2.Location = new Point(115, 131);
            price2.Name = "price2";
            price2.Size = new Size(42, 20);
            price2.TabIndex = 43;
            price2.Text = "price";
            // 
            // ex_date2
            // 
            ex_date2.AutoSize = true;
            ex_date2.Location = new Point(22, 206);
            ex_date2.Name = "ex_date2";
            ex_date2.Size = new Size(58, 20);
            ex_date2.TabIndex = 42;
            ex_date2.Text = "ex date";
            // 
            // nat2
            // 
            nat2.AutoSize = true;
            nat2.Location = new Point(22, 170);
            nat2.Name = "nat2";
            nat2.Size = new Size(79, 20);
            nat2.TabIndex = 41;
            nat2.Text = "nationality";
            // 
            // name2
            // 
            name2.AutoSize = true;
            name2.Location = new Point(22, 131);
            name2.Name = "name2";
            name2.Size = new Size(46, 20);
            name2.TabIndex = 40;
            name2.Text = "name";
            // 
            // pic2
            // 
            pic2.InitialImage = (Image)resources.GetObject("pic2.InitialImage");
            pic2.Location = new Point(0, 0);
            pic2.Margin = new Padding(3, 4, 3, 4);
            pic2.Name = "pic2";
            pic2.Size = new Size(207, 120);
            pic2.SizeMode = PictureBoxSizeMode.Zoom;
            pic2.TabIndex = 39;
            pic2.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(quan3_box);
            panel3.Controls.Add(quan3);
            panel3.Controls.Add(remove3);
            panel3.Controls.Add(brand3);
            panel3.Controls.Add(av3);
            panel3.Controls.Add(price3);
            panel3.Controls.Add(ex_date3);
            panel3.Controls.Add(nat3);
            panel3.Controls.Add(name3);
            panel3.Controls.Add(pic3);
            panel3.Location = new Point(583, 170);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(207, 312);
            panel3.TabIndex = 64;
            panel3.Paint += panel3_Paint;
            // 
            // quan3_box
            // 
            quan3_box.Location = new Point(117, 241);
            quan3_box.Margin = new Padding(3, 4, 3, 4);
            quan3_box.Name = "quan3_box";
            quan3_box.Size = new Size(49, 27);
            quan3_box.TabIndex = 48;
            // 
            // quan3
            // 
            quan3.AutoSize = true;
            quan3.Location = new Point(32, 241);
            quan3.Name = "quan3";
            quan3.Size = new Size(66, 20);
            quan3.TabIndex = 47;
            quan3.Text = "quantity:";
            // 
            // remove3
            // 
            remove3.Location = new Point(35, 284);
            remove3.Margin = new Padding(3, 4, 3, 4);
            remove3.Name = "remove3";
            remove3.Size = new Size(124, 29);
            remove3.TabIndex = 46;
            remove3.Text = "remove from cart";
            remove3.UseVisualStyleBackColor = true;
            remove3.Click += remove3_Click;
            // 
            // brand3
            // 
            brand3.AutoSize = true;
            brand3.Location = new Point(117, 170);
            brand3.Name = "brand3";
            brand3.Size = new Size(48, 20);
            brand3.TabIndex = 45;
            brand3.Text = "brand";
            // 
            // av3
            // 
            av3.AutoSize = true;
            av3.Location = new Point(117, 206);
            av3.Name = "av3";
            av3.Size = new Size(100, 20);
            av3.TabIndex = 44;
            av3.Text = "# of available";
            // 
            // price3
            // 
            price3.AutoSize = true;
            price3.Location = new Point(115, 131);
            price3.Name = "price3";
            price3.Size = new Size(42, 20);
            price3.TabIndex = 43;
            price3.Text = "price";
            // 
            // ex_date3
            // 
            ex_date3.AutoSize = true;
            ex_date3.Location = new Point(22, 206);
            ex_date3.Name = "ex_date3";
            ex_date3.Size = new Size(58, 20);
            ex_date3.TabIndex = 42;
            ex_date3.Text = "ex date";
            // 
            // nat3
            // 
            nat3.AutoSize = true;
            nat3.Location = new Point(22, 170);
            nat3.Name = "nat3";
            nat3.Size = new Size(79, 20);
            nat3.TabIndex = 41;
            nat3.Text = "nationality";
            // 
            // name3
            // 
            name3.AutoSize = true;
            name3.Location = new Point(22, 131);
            name3.Name = "name3";
            name3.Size = new Size(46, 20);
            name3.TabIndex = 40;
            name3.Text = "name";
            // 
            // pic3
            // 
            pic3.InitialImage = (Image)resources.GetObject("pic3.InitialImage");
            pic3.Location = new Point(0, 0);
            pic3.Margin = new Padding(3, 4, 3, 4);
            pic3.Name = "pic3";
            pic3.Size = new Size(207, 120);
            pic3.SizeMode = PictureBoxSizeMode.Zoom;
            pic3.TabIndex = 39;
            pic3.TabStop = false;
            // 
            // Current_User
            // 
            Current_User.AutoSize = true;
            Current_User.Location = new Point(99, 49);
            Current_User.Name = "Current_User";
            Current_User.Size = new Size(77, 20);
            Current_User.TabIndex = 89;
            Current_User.Text = "user name";
            Current_User.Click += label31_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(683, 22);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(59, 62);
            pictureBox4.TabIndex = 90;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // Load_More
            // 
            Load_More.Location = new Point(12, 100);
            Load_More.Margin = new Padding(3, 4, 3, 4);
            Load_More.Name = "Load_More";
            Load_More.Size = new Size(101, 41);
            Load_More.TabIndex = 91;
            Load_More.Text = "Load More";
            Load_More.UseVisualStyleBackColor = true;
            Load_More.Click += Load_More_Click;
            // 
            // Refresh
            // 
            Refresh.Location = new Point(129, 100);
            Refresh.Margin = new Padding(3, 4, 3, 4);
            Refresh.Name = "Refresh";
            Refresh.Size = new Size(82, 41);
            Refresh.TabIndex = 92;
            Refresh.Text = "Refresh";
            Refresh.UseVisualStyleBackColor = true;
            Refresh.Click += Refresh_Click;
            // 
            // Cart
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(802, 691);
            Controls.Add(Refresh);
            Controls.Add(Load_More);
            Controls.Add(pictureBox4);
            Controls.Add(Current_User);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(search);
            Controls.Add(label22);
            Controls.Add(brand_input);
            Controls.Add(proceed);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Cart";
            Text = "Cart";
            Load += Cart_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button proceed;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox brand_input;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button remove1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox quan2_box;
        private System.Windows.Forms.Label quan2;
        private System.Windows.Forms.Button remove2;
        private System.Windows.Forms.Label brand2;
        private System.Windows.Forms.Label av2;
        private System.Windows.Forms.Label price2;
        private System.Windows.Forms.Label ex_date2;
        private System.Windows.Forms.Label nat2;
        private System.Windows.Forms.Label name2;
        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox quan3_box;
        private System.Windows.Forms.Label quan3;
        private System.Windows.Forms.Button remove3;
        private System.Windows.Forms.Label brand3;
        private System.Windows.Forms.Label av3;
        private System.Windows.Forms.Label price3;
        private System.Windows.Forms.Label ex_date3;
        private System.Windows.Forms.Label nat3;
        private System.Windows.Forms.Label name3;
        private System.Windows.Forms.PictureBox pic3;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.PictureBox pictureBox4;
        private Label Current_User;
        private TextBox quan1_box;
        private Label quan1;
        private Label brand1;
        private Label av1;
        private Label price1;
        private Label ex_date1;
        private Label nat1;
        private Label name1;
        private Button Load_More;
        private Button Refresh;
    }
}