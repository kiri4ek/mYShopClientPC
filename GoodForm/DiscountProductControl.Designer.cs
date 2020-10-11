namespace mYShop
{
    partial class DiscountProductControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.productBuy = new System.Windows.Forms.Button();
            this.productPicture = new System.Windows.Forms.PictureBox();
            this.productPrice = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.productName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // productBuy
            // 
            this.productBuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(33)))), ((int)(((byte)(100)))));
            this.productBuy.FlatAppearance.BorderSize = 0;
            this.productBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productBuy.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productBuy.ForeColor = System.Drawing.Color.LightGray;
            this.productBuy.Location = new System.Drawing.Point(120, 164);
            this.productBuy.Name = "productBuy";
            this.productBuy.Size = new System.Drawing.Size(222, 35);
            this.productBuy.TabIndex = 10;
            this.productBuy.Text = "Добавить";
            this.productBuy.UseVisualStyleBackColor = false;
            // 
            // productPicture
            // 
            this.productPicture.Location = new System.Drawing.Point(476, 11);
            this.productPicture.Name = "productPicture";
            this.productPicture.Size = new System.Drawing.Size(194, 155);
            this.productPicture.TabIndex = 9;
            this.productPicture.TabStop = false;
            // 
            // productPrice
            // 
            this.productPrice.AutoSize = true;
            this.productPrice.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productPrice.ForeColor = System.Drawing.Color.LightGray;
            this.productPrice.Location = new System.Drawing.Point(7, 157);
            this.productPrice.Name = "productPrice";
            this.productPrice.Size = new System.Drawing.Size(66, 42);
            this.productPrice.TabIndex = 8;
            this.productPrice.Text = "0 ₽";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionLabel.ForeColor = System.Drawing.Color.LightGray;
            this.descriptionLabel.Location = new System.Drawing.Point(4, 38);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(93, 19);
            this.descriptionLabel.TabIndex = 7;
            this.descriptionLabel.Text = "Описание";
            // 
            // productName
            // 
            this.productName.AutoSize = true;
            this.productName.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productName.ForeColor = System.Drawing.Color.LightGray;
            this.productName.Location = new System.Drawing.Point(-2, -1);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(132, 41);
            this.productName.TabIndex = 6;
            this.productName.Text = "Блюдо";
            // 
            // DiscountProductControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(74)))), ((int)(((byte)(0)))));
            this.Controls.Add(this.productBuy);
            this.Controls.Add(this.productPicture);
            this.Controls.Add(this.productPrice);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.productName);
            this.Name = "DiscountProductControl";
            this.Size = new System.Drawing.Size(680, 203);
            ((System.ComponentModel.ISupportInitialize)(this.productPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button productBuy;
        private System.Windows.Forms.PictureBox productPicture;
        public System.Windows.Forms.Label productPrice;
        public System.Windows.Forms.Label descriptionLabel;
        public System.Windows.Forms.Label productName;
    }
}
