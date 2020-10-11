namespace mYShop
{
    partial class BasketProductControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.productName = new System.Windows.Forms.Label();
            this.productCount = new System.Windows.Forms.NumericUpDown();
            this.productPrice = new System.Windows.Forms.Label();
            this.productBuy = new System.Windows.Forms.Button();
            this.DeleteProduct = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productCount)).BeginInit();
            this.SuspendLayout();
            // 
            // productName
            // 
            this.productName.AutoSize = true;
            this.productName.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productName.ForeColor = System.Drawing.Color.LightGray;
            this.productName.Location = new System.Drawing.Point(23, 3);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(132, 41);
            this.productName.TabIndex = 0;
            this.productName.Text = "Блюдо";
            // 
            // productCount
            // 
            this.productCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(33)))), ((int)(((byte)(100)))));
            this.productCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productCount.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productCount.ForeColor = System.Drawing.Color.LightGray;
            this.productCount.Location = new System.Drawing.Point(345, 13);
            this.productCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.productCount.Name = "productCount";
            this.productCount.Size = new System.Drawing.Size(50, 25);
            this.productCount.TabIndex = 1;
            this.productCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.productCount.ValueChanged += new System.EventHandler(this.UpdateTotalPrice);
            // 
            // productPrice
            // 
            this.productPrice.AutoSize = true;
            this.productPrice.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productPrice.ForeColor = System.Drawing.Color.LightGray;
            this.productPrice.Location = new System.Drawing.Point(416, 5);
            this.productPrice.Name = "productPrice";
            this.productPrice.Size = new System.Drawing.Size(66, 42);
            this.productPrice.TabIndex = 2;
            this.productPrice.Text = "0 ₽";
            // 
            // productBuy
            // 
            this.productBuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(33)))), ((int)(((byte)(100)))));
            this.productBuy.FlatAppearance.BorderSize = 0;
            this.productBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productBuy.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productBuy.ForeColor = System.Drawing.Color.LightGray;
            this.productBuy.Location = new System.Drawing.Point(550, 13);
            this.productBuy.Name = "productBuy";
            this.productBuy.Size = new System.Drawing.Size(99, 26);
            this.productBuy.TabIndex = 3;
            this.productBuy.Text = "Заказать";
            this.productBuy.UseVisualStyleBackColor = false;
            // 
            // DeleteProduct
            // 
            this.DeleteProduct.AutoSize = true;
            this.DeleteProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteProduct.ForeColor = System.Drawing.Color.White;
            this.DeleteProduct.Location = new System.Drawing.Point(665, 0);
            this.DeleteProduct.Name = "DeleteProduct";
            this.DeleteProduct.Size = new System.Drawing.Size(15, 15);
            this.DeleteProduct.TabIndex = 4;
            this.DeleteProduct.Text = "X";
            this.DeleteProduct.Click += new System.EventHandler(this.DeleteProduct_Click);
            this.DeleteProduct.MouseEnter += new System.EventHandler(this.DeleteProduct_MouseEnter);
            this.DeleteProduct.MouseLeave += new System.EventHandler(this.DeleteProduct_MouseLeave);
            // 
            // BasketProductControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(33)))), ((int)(((byte)(100)))));
            this.Controls.Add(this.DeleteProduct);
            this.Controls.Add(this.productBuy);
            this.Controls.Add(this.productPrice);
            this.Controls.Add(this.productCount);
            this.Controls.Add(this.productName);
            this.Name = "BasketProductControl";
            this.Size = new System.Drawing.Size(680, 50);
            ((System.ComponentModel.ISupportInitialize)(this.productCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label productName;
        public System.Windows.Forms.NumericUpDown productCount;
        public System.Windows.Forms.Label productPrice;
        public System.Windows.Forms.Button productBuy;
        private System.Windows.Forms.Label DeleteProduct;
    }
}
