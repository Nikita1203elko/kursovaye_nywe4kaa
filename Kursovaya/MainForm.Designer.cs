namespace Kursovaya
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
            this.lblUserInfo = new System.Windows.Forms.Label();
            this.profile_btn = new System.Windows.Forms.Button();
            this.myRequests_btn = new System.Windows.Forms.Button();
            this.newRequesRepair_btn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.vendors_btn = new System.Windows.Forms.Button();
            this.allRequestsRepair_btn = new System.Windows.Forms.Button();
            this.invoices_btn = new System.Windows.Forms.Button();
            this.users_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUserInfo
            // 
            this.lblUserInfo.AutoSize = true;
            this.lblUserInfo.Font = new System.Drawing.Font("Sitka Banner", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUserInfo.Location = new System.Drawing.Point(12, 12);
            this.lblUserInfo.Name = "lblUserInfo";
            this.lblUserInfo.Size = new System.Drawing.Size(0, 21);
            this.lblUserInfo.TabIndex = 0;
            // 
            // profile_btn
            // 
            this.profile_btn.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.profile_btn.Location = new System.Drawing.Point(315, 12);
            this.profile_btn.Name = "profile_btn";
            this.profile_btn.Size = new System.Drawing.Size(89, 38);
            this.profile_btn.TabIndex = 1;
            this.profile_btn.Text = "Профиль";
            this.profile_btn.UseVisualStyleBackColor = true;
            this.profile_btn.Click += new System.EventHandler(this.profile_btn_Click);
            // 
            // myRequests_btn
            // 
            this.myRequests_btn.Location = new System.Drawing.Point(209, 81);
            this.myRequests_btn.Name = "myRequests_btn";
            this.myRequests_btn.Size = new System.Drawing.Size(142, 36);
            this.myRequests_btn.TabIndex = 2;
            this.myRequests_btn.Text = "📋 Мои заявки";
            this.myRequests_btn.UseVisualStyleBackColor = true;
            this.myRequests_btn.Click += new System.EventHandler(this.myRequests_btn_Click);
            // 
            // newRequesRepair_btn
            // 
            this.newRequesRepair_btn.Location = new System.Drawing.Point(65, 83);
            this.newRequesRepair_btn.Name = "newRequesRepair_btn";
            this.newRequesRepair_btn.Size = new System.Drawing.Size(134, 34);
            this.newRequesRepair_btn.TabIndex = 2;
            this.newRequesRepair_btn.Text = "📝 Новая заявка";
            this.newRequesRepair_btn.UseVisualStyleBackColor = true;
            this.newRequesRepair_btn.Click += new System.EventHandler(this.newRequesRepair_btn_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(209, 163);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(142, 36);
            this.button3.TabIndex = 2;
            this.button3.Text = "🖥️ Каталог";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // vendors_btn
            // 
            this.vendors_btn.Location = new System.Drawing.Point(209, 123);
            this.vendors_btn.Name = "vendors_btn";
            this.vendors_btn.Size = new System.Drawing.Size(142, 34);
            this.vendors_btn.TabIndex = 2;
            this.vendors_btn.Text = "🏢 Поставщики";
            this.vendors_btn.UseVisualStyleBackColor = true;
            this.vendors_btn.Visible = false;
            // 
            // allRequestsRepair_btn
            // 
            this.allRequestsRepair_btn.Location = new System.Drawing.Point(65, 163);
            this.allRequestsRepair_btn.Name = "allRequestsRepair_btn";
            this.allRequestsRepair_btn.Size = new System.Drawing.Size(134, 36);
            this.allRequestsRepair_btn.TabIndex = 2;
            this.allRequestsRepair_btn.Text = "🔧 Все заявки";
            this.allRequestsRepair_btn.UseVisualStyleBackColor = true;
            this.allRequestsRepair_btn.Visible = false;
            // 
            // invoices_btn
            // 
            this.invoices_btn.Location = new System.Drawing.Point(65, 123);
            this.invoices_btn.Name = "invoices_btn";
            this.invoices_btn.Size = new System.Drawing.Size(134, 34);
            this.invoices_btn.TabIndex = 2;
            this.invoices_btn.Text = "🧾 Счета";
            this.invoices_btn.UseVisualStyleBackColor = true;
            this.invoices_btn.Visible = false;
            // 
            // users_btn
            // 
            this.users_btn.Location = new System.Drawing.Point(65, 205);
            this.users_btn.Name = "users_btn";
            this.users_btn.Size = new System.Drawing.Size(286, 36);
            this.users_btn.TabIndex = 2;
            this.users_btn.Text = "👥 Пользователи";
            this.users_btn.UseVisualStyleBackColor = true;
            this.users_btn.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(416, 253);
            this.Controls.Add(this.users_btn);
            this.Controls.Add(this.invoices_btn);
            this.Controls.Add(this.allRequestsRepair_btn);
            this.Controls.Add(this.vendors_btn);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.newRequesRepair_btn);
            this.Controls.Add(this.myRequests_btn);
            this.Controls.Add(this.profile_btn);
            this.Controls.Add(this.lblUserInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MainForm";
            this.Text = "Главная страница";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblUserInfo;
        private System.Windows.Forms.Button profile_btn;
        private System.Windows.Forms.Button myRequests_btn;
        private System.Windows.Forms.Button newRequesRepair_btn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button vendors_btn;
        private System.Windows.Forms.Button allRequestsRepair_btn;
        private System.Windows.Forms.Button invoices_btn;
        private System.Windows.Forms.Button users_btn;
    }
}