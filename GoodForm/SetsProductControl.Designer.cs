namespace mYShop
{
    partial class SetsProductControl
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
            this.productName = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.productPrice = new System.Windows.Forms.Label();
            this.productPicture = new System.Windows.Forms.PictureBox();
            this.productBuy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // productName
            // 
            this.productName.AutoSize = true;
            this.productName.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productName.ForeColor = System.Drawing.Color.LightGray;
            this.productName.Location = new System.Drawing.Point(-2, -1);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(132, 41);
            this.productName.TabIndex = 1;
            this.productName.Text = "Блюдо";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionLabel.ForeColor = System.Drawing.Color.LightGray;
            this.descriptionLabel.Location = new System.Drawing.Point(4, 38);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(93, 19);
            this.descriptionLabel.TabIndex = 2;
            this.descriptionLabel.Text = "Описание";
            // 
            // productPrice
            // 
            this.productPrice.AutoSize = true;
            this.productPrice.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productPrice.ForeColor = System.Drawing.Color.LightGray;
            this.productPrice.Location = new System.Drawing.Point(7, 157);
            this.productPrice.Name = "productPrice";
            this.productPrice.Size = new System.Drawing.Size(66, 42);
            this.productPrice.TabIndex = 3;
            this.productPrice.Text = "0 ₽";
            // 
            // productPicture
            // 
            this.productPicture.Location = new System.Drawing.Point(471, 11);
            this.productPicture.Name = "productPicture";
            this.productPicture.Size = new System.Drawing.Size(204, 183);
            this.productPicture.TabIndex = 4;
            this.productPicture.TabStop = false;
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
            this.productBuy.TabIndex = 5;
            this.productBuy.Text = "Добавить";
            this.productBuy.UseVisualStyleBackColor = false;
            // 
            // SetsProductControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(33)))), ((int)(((byte)(100)))));
            this.Controls.Add(this.productBuy);
            this.Controls.Add(this.productPicture);
            this.Controls.Add(this.productPrice);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.productName);
            this.Name = "SetsProductControl";
            this.Size = new System.Drawing.Size(680, 203);
            ((System.ComponentModel.ISupportInitialize)(this.productPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label productName;
        public System.Windows.Forms.Label descriptionLabel;
        public System.Windows.Forms.Label productPrice;
        private System.Windows.Forms.PictureBox productPicture;
        public System.Windows.Forms.Button productBuy;
    }
}
