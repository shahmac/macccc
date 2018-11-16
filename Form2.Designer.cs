namespace WindowsFormsApp4
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.price = new System.Windows.Forms.TextBox();
            this.items = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.TextBox();
            this.cgst = new System.Windows.Forms.TextBox();
            this.sgst = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.final = new System.Windows.Forms.TextBox();
            this.total1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.log = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Name";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "noodles",
            "biscuit",
            "maida",
            "shampoo",
            "soap",
            "deterjent",
            "harpic",
            "odonil",
            "perfume",
            "hair wax"});
            this.comboBox1.Location = new System.Drawing.Point(169, 111);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(169, 160);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(121, 20);
            this.price.TabIndex = 3;
            this.price.TextChanged += new System.EventHandler(this.price_TextChanged);
            // 
            // items
            // 
            this.items.Location = new System.Drawing.Point(169, 220);
            this.items.Name = "items";
            this.items.Size = new System.Drawing.Size(121, 20);
            this.items.TabIndex = 4;
            this.items.TextChanged += new System.EventHandler(this.items_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "number of itmes";
            // 
            // total
            // 
            this.total.Location = new System.Drawing.Point(169, 275);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(121, 20);
            this.total.TabIndex = 7;
            this.total.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // cgst
            // 
            this.cgst.Location = new System.Drawing.Point(169, 318);
            this.cgst.Name = "cgst";
            this.cgst.Size = new System.Drawing.Size(121, 20);
            this.cgst.TabIndex = 9;
            this.cgst.TextChanged += new System.EventHandler(this.cgst_TextChanged);
            // 
            // sgst
            // 
            this.sgst.Location = new System.Drawing.Point(169, 371);
            this.sgst.Name = "sgst";
            this.sgst.Size = new System.Drawing.Size(121, 20);
            this.sgst.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(509, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "FINAL BILL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // final
            // 
            this.final.Location = new System.Drawing.Point(494, 321);
            this.final.Name = "final";
            this.final.Size = new System.Drawing.Size(100, 20);
            this.final.TabIndex = 13;
            // 
            // total1
            // 
            this.total1.Location = new System.Drawing.Point(53, 273);
            this.total1.Name = "total1";
            this.total1.Size = new System.Drawing.Size(75, 23);
            this.total1.TabIndex = 14;
            this.total1.Text = "Total";
            this.total1.UseVisualStyleBackColor = true;
            this.total1.Click += new System.EventHandler(this.total1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(56, 160);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "GET PRICE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // log
            // 
            this.log.Location = new System.Drawing.Point(642, 361);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(75, 23);
            this.log.TabIndex = 18;
            this.log.Text = "LOG OUT";
            this.log.UseVisualStyleBackColor = true;
            this.log.Click += new System.EventHandler(this.log_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Matura MT Script Capitals", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(535, 401);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 28);
            this.label2.TabIndex = 19;
            this.label2.Text = "Thank You Visit Again";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "CGST";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 371);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "SGST";
            this.label5.Click += new System.EventHandler(this.label5_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(642, 315);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 23);
            this.button3.TabIndex = 22;
            this.button3.Text = "Shop More with Us";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(509, 361);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 23;
            this.button4.Text = "PAY";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.grocery_channel_private_brand_problem;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.log);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.total1);
            this.Controls.Add(this.final);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sgst);
            this.Controls.Add(this.cgst);
            this.Controls.Add(this.total);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.items);
            this.Controls.Add(this.price);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.TextBox items;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox total;
        private System.Windows.Forms.TextBox cgst;
        private System.Windows.Forms.TextBox sgst;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox final;
        private System.Windows.Forms.Button total1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button log;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}