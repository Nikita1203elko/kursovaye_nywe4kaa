namespace Kursovaya
{
    partial class ProfileForm
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
            this.lb_profile = new System.Windows.Forms.Label();
            this.firstname_lb = new System.Windows.Forms.Label();
            this.lastName_lb = new System.Windows.Forms.Label();
            this.email_lb = new System.Windows.Forms.Label();
            this.numberPhone_label = new System.Windows.Forms.Label();
            this.firstName_tb = new System.Windows.Forms.TextBox();
            this.lastName_tb = new System.Windows.Forms.TextBox();
            this.email_tb = new System.Windows.Forms.TextBox();
            this.numberPhone_tb = new System.Windows.Forms.TextBox();
            this.saveProfile_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_profile
            // 
            this.lb_profile.AutoSize = true;
            this.lb_profile.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_profile.Location = new System.Drawing.Point(146, 13);
            this.lb_profile.Name = "lb_profile";
            this.lb_profile.Size = new System.Drawing.Size(81, 28);
            this.lb_profile.TabIndex = 0;
            this.lb_profile.Text = "Профиль";
            // 
            // firstname_lb
            // 
            this.firstname_lb.AutoSize = true;
            this.firstname_lb.Font = new System.Drawing.Font("Sitka Banner", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstname_lb.Location = new System.Drawing.Point(72, 83);
            this.firstname_lb.Name = "firstname_lb";
            this.firstname_lb.Size = new System.Drawing.Size(32, 19);
            this.firstname_lb.TabIndex = 1;
            this.firstname_lb.Text = "Имя";
            // 
            // lastName_lb
            // 
            this.lastName_lb.AutoSize = true;
            this.lastName_lb.Font = new System.Drawing.Font("Sitka Banner", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastName_lb.Location = new System.Drawing.Point(72, 128);
            this.lastName_lb.Name = "lastName_lb";
            this.lastName_lb.Size = new System.Drawing.Size(58, 19);
            this.lastName_lb.TabIndex = 1;
            this.lastName_lb.Text = "Фамилия";
            // 
            // email_lb
            // 
            this.email_lb.AutoSize = true;
            this.email_lb.Font = new System.Drawing.Font("Sitka Banner", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.email_lb.Location = new System.Drawing.Point(197, 83);
            this.email_lb.Name = "email_lb";
            this.email_lb.Size = new System.Drawing.Size(42, 19);
            this.email_lb.TabIndex = 1;
            this.email_lb.Text = "Почта";
            // 
            // numberPhone_label
            // 
            this.numberPhone_label.AutoSize = true;
            this.numberPhone_label.Font = new System.Drawing.Font("Sitka Banner", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberPhone_label.Location = new System.Drawing.Point(197, 128);
            this.numberPhone_label.Name = "numberPhone_label";
            this.numberPhone_label.Size = new System.Drawing.Size(96, 19);
            this.numberPhone_label.TabIndex = 1;
            this.numberPhone_label.Text = "Номер телефона";
            // 
            // firstName_tb
            // 
            this.firstName_tb.Location = new System.Drawing.Point(76, 105);
            this.firstName_tb.Name = "firstName_tb";
            this.firstName_tb.Size = new System.Drawing.Size(100, 20);
            this.firstName_tb.TabIndex = 2;
            // 
            // lastName_tb
            // 
            this.lastName_tb.Location = new System.Drawing.Point(76, 150);
            this.lastName_tb.Name = "lastName_tb";
            this.lastName_tb.Size = new System.Drawing.Size(100, 20);
            this.lastName_tb.TabIndex = 2;
            // 
            // email_tb
            // 
            this.email_tb.Location = new System.Drawing.Point(201, 105);
            this.email_tb.Name = "email_tb";
            this.email_tb.Size = new System.Drawing.Size(100, 20);
            this.email_tb.TabIndex = 2;
            // 
            // numberPhone_tb
            // 
            this.numberPhone_tb.Location = new System.Drawing.Point(201, 150);
            this.numberPhone_tb.Name = "numberPhone_tb";
            this.numberPhone_tb.Size = new System.Drawing.Size(100, 20);
            this.numberPhone_tb.TabIndex = 2;
            // 
            // saveProfile_btn
            // 
            this.saveProfile_btn.Location = new System.Drawing.Point(76, 176);
            this.saveProfile_btn.Name = "saveProfile_btn";
            this.saveProfile_btn.Size = new System.Drawing.Size(225, 33);
            this.saveProfile_btn.TabIndex = 3;
            this.saveProfile_btn.Text = "Сохранить";
            this.saveProfile_btn.UseVisualStyleBackColor = true;
            this.saveProfile_btn.Click += new System.EventHandler(this.saveProfile_btn_Click);
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 293);
            this.Controls.Add(this.saveProfile_btn);
            this.Controls.Add(this.numberPhone_tb);
            this.Controls.Add(this.email_tb);
            this.Controls.Add(this.lastName_tb);
            this.Controls.Add(this.firstName_tb);
            this.Controls.Add(this.numberPhone_label);
            this.Controls.Add(this.email_lb);
            this.Controls.Add(this.lastName_lb);
            this.Controls.Add(this.firstname_lb);
            this.Controls.Add(this.lb_profile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "ProfileForm";
            this.Text = "ProfileForm";
            this.Load += new System.EventHandler(this.ProfileForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lb_profile;
        private System.Windows.Forms.Label firstname_lb;
        private System.Windows.Forms.Label lastName_lb;
        private System.Windows.Forms.Label email_lb;
        private System.Windows.Forms.Label numberPhone_label;
        private System.Windows.Forms.TextBox firstName_tb;
        private System.Windows.Forms.TextBox lastName_tb;
        private System.Windows.Forms.TextBox email_tb;
        private System.Windows.Forms.TextBox numberPhone_tb;
        private System.Windows.Forms.Button saveProfile_btn;
    }
}