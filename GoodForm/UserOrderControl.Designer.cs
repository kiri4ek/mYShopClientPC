namespace mYShop
{
    partial class UserOrderControl
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
            this.UserName = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.NumberOrder = new System.Windows.Forms.Label();
            this.Count = new System.Windows.Forms.Label();
            this.TypeOfPayment = new System.Windows.Forms.Label();
            this.DateOrder = new System.Windows.Forms.Label();
            this.DeleteOrder = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserName.ForeColor = System.Drawing.Color.LightGray;
            this.UserName.Location = new System.Drawing.Point(28, 0);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(42, 18);
            this.UserName.TabIndex = 1;
            this.UserName.Text = "ФИО";
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.id.ForeColor = System.Drawing.Color.LightGray;
            this.id.Location = new System.Drawing.Point(-1, 0);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(25, 18);
            this.id.TabIndex = 2;
            this.id.Text = "№";
            // 
            // NumberOrder
            // 
            this.NumberOrder.AutoSize = true;
            this.NumberOrder.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberOrder.ForeColor = System.Drawing.Color.LightGray;
            this.NumberOrder.Location = new System.Drawing.Point(273, 0);
            this.NumberOrder.Name = "NumberOrder";
            this.NumberOrder.Size = new System.Drawing.Size(54, 18);
            this.NumberOrder.TabIndex = 4;
            this.NumberOrder.Text = "№ зак";
            // 
            // Count
            // 
            this.Count.AutoSize = true;
            this.Count.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Count.ForeColor = System.Drawing.Color.LightGray;
            this.Count.Location = new System.Drawing.Point(349, 0);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(35, 18);
            this.Count.TabIndex = 5;
            this.Count.Text = "Кол";
            // 
            // TypeOfPayment
            // 
            this.TypeOfPayment.AutoSize = true;
            this.TypeOfPayment.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TypeOfPayment.ForeColor = System.Drawing.Color.LightGray;
            this.TypeOfPayment.Location = new System.Drawing.Point(548, 0);
            this.TypeOfPayment.Name = "TypeOfPayment";
            this.TypeOfPayment.Size = new System.Drawing.Size(93, 18);
            this.TypeOfPayment.TabIndex = 6;
            this.TypeOfPayment.Text = "Тип оплаты";
            // 
            // DateOrder
            // 
            this.DateOrder.AutoSize = true;
            this.DateOrder.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateOrder.ForeColor = System.Drawing.Color.LightGray;
            this.DateOrder.Location = new System.Drawing.Point(390, 0);
            this.DateOrder.Name = "DateOrder";
            this.DateOrder.Size = new System.Drawing.Size(48, 18);
            this.DateOrder.TabIndex = 7;
            this.DateOrder.Text = "Дата";
            // 
            // DeleteOrder
            // 
            this.DeleteOrder.AutoSize = true;
            this.DeleteOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteOrder.ForeColor = System.Drawing.Color.White;
            this.DeleteOrder.Location = new System.Drawing.Point(662, 3);
            this.DeleteOrder.Name = "DeleteOrder";
            this.DeleteOrder.Size = new System.Drawing.Size(15, 15);
            this.DeleteOrder.TabIndex = 8;
            this.DeleteOrder.Text = "X";
            this.DeleteOrder.Click += new System.EventHandler(this.DeleteOrder_Click);
            // 
            // UserOrderControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(33)))), ((int)(((byte)(100)))));
            this.Controls.Add(this.DeleteOrder);
            this.Controls.Add(this.DateOrder);
            this.Controls.Add(this.TypeOfPayment);
            this.Controls.Add(this.Count);
            this.Controls.Add(this.NumberOrder);
            this.Controls.Add(this.id);
            this.Controls.Add(this.UserName);
            this.Name = "UserOrderControl";
            this.Size = new System.Drawing.Size(680, 26);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label UserName;
        public System.Windows.Forms.Label id;
        public System.Windows.Forms.Label NumberOrder;
        public System.Windows.Forms.Label Count;
        public System.Windows.Forms.Label TypeOfPayment;
        public System.Windows.Forms.Label DateOrder;
        private System.Windows.Forms.Label DeleteOrder;
    }
}
