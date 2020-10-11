namespace mYShop
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.OutLogin = new System.Windows.Forms.Label();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.HeadPanel = new System.Windows.Forms.Panel();
            this.DrawPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.discountControl1 = new mYShop.DiscountControl();
            this.setsControl1 = new mYShop.SetsControl();
            this.settingsControl1 = new mYShop.SettingsControl();
            this.basketControl1 = new mYShop.BasketControl();
            this.firstCustomControl1 = new mYShop.FirstCustomControl();
            this.menuControl1 = new mYShop.MenuControl();
            this.ordersControl1 = new mYShop.OrdersControl();
            this.RollButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.VKButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.InstagramButton = new System.Windows.Forms.Button();
            this.OrdersButton = new System.Windows.Forms.Button();
            this.FoodbasketButton = new System.Windows.Forms.Button();
            this.DiscountButton = new System.Windows.Forms.Button();
            this.SetsButton = new System.Windows.Forms.Button();
            this.MenuButton = new System.Windows.Forms.Button();
            this.GlobalButton = new System.Windows.Forms.Button();
            this.MenuPanel.SuspendLayout();
            this.DrawPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(42)))));
            this.MenuPanel.Controls.Add(this.OrdersButton);
            this.MenuPanel.Controls.Add(this.OutLogin);
            this.MenuPanel.Controls.Add(this.SidePanel);
            this.MenuPanel.Controls.Add(this.FoodbasketButton);
            this.MenuPanel.Controls.Add(this.DiscountButton);
            this.MenuPanel.Controls.Add(this.SetsButton);
            this.MenuPanel.Controls.Add(this.MenuButton);
            this.MenuPanel.Controls.Add(this.GlobalButton);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(161, 496);
            this.MenuPanel.TabIndex = 0;
            this.MenuPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MenuPanel_MouseDown);
            this.MenuPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MenuPanel_MouseMove);
            // 
            // OutLogin
            // 
            this.OutLogin.AutoSize = true;
            this.OutLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OutLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutLogin.ForeColor = System.Drawing.Color.White;
            this.OutLogin.Location = new System.Drawing.Point(51, 467);
            this.OutLogin.Name = "OutLogin";
            this.OutLogin.Size = new System.Drawing.Size(58, 20);
            this.OutLogin.TabIndex = 8;
            this.OutLogin.Text = "Выход";
            this.OutLogin.Click += new System.EventHandler(this.OutLogin_Click);
            this.OutLogin.MouseEnter += new System.EventHandler(this.OutLogin_MouseEnter);
            this.OutLogin.MouseLeave += new System.EventHandler(this.OutLogin_MouseLeave);
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(34)))), ((int)(((byte)(25)))));
            this.SidePanel.Location = new System.Drawing.Point(3, 38);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(10, 42);
            this.SidePanel.TabIndex = 3;
            // 
            // HeadPanel
            // 
            this.HeadPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(34)))), ((int)(((byte)(25)))));
            this.HeadPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeadPanel.Location = new System.Drawing.Point(161, 0);
            this.HeadPanel.Name = "HeadPanel";
            this.HeadPanel.Size = new System.Drawing.Size(730, 10);
            this.HeadPanel.TabIndex = 1;
            this.HeadPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HeadPanel_MouseDown);
            this.HeadPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HeadPanel_MouseMove);
            // 
            // DrawPanel
            // 
            this.DrawPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(34)))), ((int)(((byte)(25)))));
            this.DrawPanel.Controls.Add(this.label2);
            this.DrawPanel.Controls.Add(this.label1);
            this.DrawPanel.Controls.Add(this.pictureBox1);
            this.DrawPanel.Location = new System.Drawing.Point(226, 1);
            this.DrawPanel.Name = "DrawPanel";
            this.DrawPanel.Size = new System.Drawing.Size(97, 136);
            this.DrawPanel.TabIndex = 2;
            this.DrawPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DrawPanel_MouseDown);
            this.DrawPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DrawPanel_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(7, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Restaurants";
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label2_MouseDown);
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label2_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(5, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fast Foods";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // discountControl1
            // 
            this.discountControl1.AutoScroll = true;
            this.discountControl1.Location = new System.Drawing.Point(161, 143);
            this.discountControl1.Name = "discountControl1";
            this.discountControl1.Size = new System.Drawing.Size(728, 345);
            this.discountControl1.TabIndex = 18;
            // 
            // setsControl1
            // 
            this.setsControl1.AutoScroll = true;
            this.setsControl1.Location = new System.Drawing.Point(161, 143);
            this.setsControl1.Name = "setsControl1";
            this.setsControl1.Size = new System.Drawing.Size(728, 345);
            this.setsControl1.TabIndex = 17;
            // 
            // settingsControl1
            // 
            this.settingsControl1.AutoScroll = true;
            this.settingsControl1.Location = new System.Drawing.Point(161, 143);
            this.settingsControl1.Name = "settingsControl1";
            this.settingsControl1.Size = new System.Drawing.Size(728, 345);
            this.settingsControl1.TabIndex = 16;
            // 
            // basketControl1
            // 
            this.basketControl1.AutoScroll = true;
            this.basketControl1.Location = new System.Drawing.Point(162, 143);
            this.basketControl1.Name = "basketControl1";
            this.basketControl1.Size = new System.Drawing.Size(728, 345);
            this.basketControl1.TabIndex = 15;
            // 
            // firstCustomControl1
            // 
            this.firstCustomControl1.AutoScroll = true;
            this.firstCustomControl1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstCustomControl1.Location = new System.Drawing.Point(162, 143);
            this.firstCustomControl1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.firstCustomControl1.Name = "firstCustomControl1";
            this.firstCustomControl1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.firstCustomControl1.Size = new System.Drawing.Size(728, 345);
            this.firstCustomControl1.TabIndex = 14;
            // 
            // menuControl1
            // 
            this.menuControl1.AutoScroll = true;
            this.menuControl1.Location = new System.Drawing.Point(162, 143);
            this.menuControl1.Name = "menuControl1";
            this.menuControl1.Size = new System.Drawing.Size(728, 345);
            this.menuControl1.TabIndex = 13;
            // 
            // ordersControl1
            // 
            this.ordersControl1.AutoScroll = true;
            this.ordersControl1.Location = new System.Drawing.Point(161, 143);
            this.ordersControl1.Name = "ordersControl1";
            this.ordersControl1.Size = new System.Drawing.Size(728, 345);
            this.ordersControl1.TabIndex = 19;
            // 
            // RollButton
            // 
            this.RollButton.FlatAppearance.BorderSize = 0;
            this.RollButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RollButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RollButton.ForeColor = System.Drawing.Color.Black;
            this.RollButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RollButton.Location = new System.Drawing.Point(764, 14);
            this.RollButton.Name = "RollButton";
            this.RollButton.Size = new System.Drawing.Size(43, 31);
            this.RollButton.TabIndex = 20;
            this.RollButton.Text = "___";
            this.RollButton.UseVisualStyleBackColor = true;
            this.RollButton.Click += new System.EventHandler(this.RollButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Image = global::mYShop.Properties.Resources.Off;
            this.ExitButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExitButton.Location = new System.Drawing.Point(855, 14);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(33, 29);
            this.ExitButton.TabIndex = 12;
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.FlatAppearance.BorderSize = 0;
            this.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SettingsButton.ForeColor = System.Drawing.Color.White;
            this.SettingsButton.Image = global::mYShop.Properties.Resources.settings;
            this.SettingsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SettingsButton.Location = new System.Drawing.Point(816, 14);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(33, 29);
            this.SettingsButton.TabIndex = 11;
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // VKButton
            // 
            this.VKButton.FlatAppearance.BorderSize = 0;
            this.VKButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VKButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VKButton.ForeColor = System.Drawing.Color.White;
            this.VKButton.Image = global::mYShop.Properties.Resources.VK;
            this.VKButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.VKButton.Location = new System.Drawing.Point(715, 14);
            this.VKButton.Name = "VKButton";
            this.VKButton.Size = new System.Drawing.Size(33, 29);
            this.VKButton.TabIndex = 10;
            this.VKButton.UseVisualStyleBackColor = true;
            this.VKButton.Click += new System.EventHandler(this.VKButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(34)))), ((int)(((byte)(25)))));
            this.pictureBox1.Image = global::mYShop.Properties.Resources.chicken;
            this.pictureBox1.Location = new System.Drawing.Point(19, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // InstagramButton
            // 
            this.InstagramButton.FlatAppearance.BorderSize = 0;
            this.InstagramButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InstagramButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InstagramButton.ForeColor = System.Drawing.Color.White;
            this.InstagramButton.Image = global::mYShop.Properties.Resources.Instagram;
            this.InstagramButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.InstagramButton.Location = new System.Drawing.Point(676, 14);
            this.InstagramButton.Name = "InstagramButton";
            this.InstagramButton.Size = new System.Drawing.Size(33, 29);
            this.InstagramButton.TabIndex = 9;
            this.InstagramButton.UseVisualStyleBackColor = true;
            this.InstagramButton.Click += new System.EventHandler(this.InstagramButton_Click);
            // 
            // OrdersButton
            // 
            this.OrdersButton.FlatAppearance.BorderSize = 0;
            this.OrdersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrdersButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrdersButton.ForeColor = System.Drawing.Color.White;
            this.OrdersButton.Image = global::mYShop.Properties.Resources.order;
            this.OrdersButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OrdersButton.Location = new System.Drawing.Point(17, 361);
            this.OrdersButton.Name = "OrdersButton";
            this.OrdersButton.Size = new System.Drawing.Size(138, 42);
            this.OrdersButton.TabIndex = 9;
            this.OrdersButton.Text = "Заказы";
            this.OrdersButton.UseVisualStyleBackColor = true;
            this.OrdersButton.Visible = false;
            this.OrdersButton.Click += new System.EventHandler(this.OrdersButton_Click);
            // 
            // FoodbasketButton
            // 
            this.FoodbasketButton.FlatAppearance.BorderSize = 0;
            this.FoodbasketButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FoodbasketButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FoodbasketButton.ForeColor = System.Drawing.Color.White;
            this.FoodbasketButton.Image = global::mYShop.Properties.Resources.retail;
            this.FoodbasketButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FoodbasketButton.Location = new System.Drawing.Point(19, 294);
            this.FoodbasketButton.Name = "FoodbasketButton";
            this.FoodbasketButton.Size = new System.Drawing.Size(138, 42);
            this.FoodbasketButton.TabIndex = 7;
            this.FoodbasketButton.Text = "Корзина";
            this.FoodbasketButton.UseVisualStyleBackColor = true;
            this.FoodbasketButton.Click += new System.EventHandler(this.FoodbasketButton_Click);
            // 
            // DiscountButton
            // 
            this.DiscountButton.FlatAppearance.BorderSize = 0;
            this.DiscountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DiscountButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DiscountButton.ForeColor = System.Drawing.Color.White;
            this.DiscountButton.Image = global::mYShop.Properties.Resources.sale;
            this.DiscountButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DiscountButton.Location = new System.Drawing.Point(19, 230);
            this.DiscountButton.Name = "DiscountButton";
            this.DiscountButton.Size = new System.Drawing.Size(138, 42);
            this.DiscountButton.TabIndex = 6;
            this.DiscountButton.Text = "Акции";
            this.DiscountButton.UseVisualStyleBackColor = true;
            this.DiscountButton.Click += new System.EventHandler(this.DiscountButton_Click);
            // 
            // SetsButton
            // 
            this.SetsButton.FlatAppearance.BorderSize = 0;
            this.SetsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SetsButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SetsButton.ForeColor = System.Drawing.Color.White;
            this.SetsButton.Image = global::mYShop.Properties.Resources.market;
            this.SetsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SetsButton.Location = new System.Drawing.Point(19, 166);
            this.SetsButton.Name = "SetsButton";
            this.SetsButton.Size = new System.Drawing.Size(138, 42);
            this.SetsButton.TabIndex = 5;
            this.SetsButton.Text = "Наборы";
            this.SetsButton.UseVisualStyleBackColor = true;
            this.SetsButton.Click += new System.EventHandler(this.SetsButton_Click);
            // 
            // MenuButton
            // 
            this.MenuButton.FlatAppearance.BorderSize = 0;
            this.MenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MenuButton.ForeColor = System.Drawing.Color.White;
            this.MenuButton.Image = global::mYShop.Properties.Resources.fast_food;
            this.MenuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MenuButton.Location = new System.Drawing.Point(19, 102);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(138, 42);
            this.MenuButton.TabIndex = 4;
            this.MenuButton.Text = "Меню";
            this.MenuButton.UseVisualStyleBackColor = true;
            this.MenuButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // GlobalButton
            // 
            this.GlobalButton.FlatAppearance.BorderSize = 0;
            this.GlobalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GlobalButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GlobalButton.ForeColor = System.Drawing.Color.White;
            this.GlobalButton.Image = global::mYShop.Properties.Resources.burger;
            this.GlobalButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GlobalButton.Location = new System.Drawing.Point(19, 38);
            this.GlobalButton.Name = "GlobalButton";
            this.GlobalButton.Size = new System.Drawing.Size(138, 42);
            this.GlobalButton.TabIndex = 3;
            this.GlobalButton.Text = "Главная";
            this.GlobalButton.UseVisualStyleBackColor = true;
            this.GlobalButton.Click += new System.EventHandler(this.GlobalButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 496);
            this.Controls.Add(this.RollButton);
            this.Controls.Add(this.ordersControl1);
            this.Controls.Add(this.discountControl1);
            this.Controls.Add(this.setsControl1);
            this.Controls.Add(this.settingsControl1);
            this.Controls.Add(this.basketControl1);
            this.Controls.Add(this.firstCustomControl1);
            this.Controls.Add(this.menuControl1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.VKButton);
            this.Controls.Add(this.DrawPanel);
            this.Controls.Add(this.HeadPanel);
            this.Controls.Add(this.InstagramButton);
            this.Controls.Add(this.MenuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            this.DrawPanel.ResumeLayout(false);
            this.DrawPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Panel HeadPanel;
        private System.Windows.Forms.Panel DrawPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button GlobalButton;
        private System.Windows.Forms.Button FoodbasketButton;
        private System.Windows.Forms.Button DiscountButton;
        private System.Windows.Forms.Button SetsButton;
        private System.Windows.Forms.Button MenuButton;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button InstagramButton;
        private System.Windows.Forms.Button VKButton;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Button ExitButton;
        private MenuControl menuControl1;
        private FirstCustomControl firstCustomControl1;
        private System.Windows.Forms.Label OutLogin;
        public BasketControl basketControl1;
        public SettingsControl settingsControl1;
        private SetsControl setsControl1;
        private DiscountControl discountControl1;
        private System.Windows.Forms.Button OrdersButton;
        public OrdersControl ordersControl1;
        private System.Windows.Forms.Button RollButton;
    }
}