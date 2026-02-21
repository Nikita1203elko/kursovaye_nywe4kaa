namespace Kursovaya
{
    partial class NewRequests
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
            this.newRequests_lb = new System.Windows.Forms.Label();
            this.description_lb = new System.Windows.Forms.Label();
            this.description_tb = new System.Windows.Forms.TextBox();
            this.equipmentsId_lb = new System.Windows.Forms.Label();
            this.sendRequests_btn = new System.Windows.Forms.Button();
            this.equipmentList = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // newRequests_lb
            // 
            this.newRequests_lb.AutoSize = true;
            this.newRequests_lb.Font = new System.Drawing.Font("Sitka Banner", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newRequests_lb.Location = new System.Drawing.Point(74, 23);
            this.newRequests_lb.Name = "newRequests_lb";
            this.newRequests_lb.Size = new System.Drawing.Size(214, 30);
            this.newRequests_lb.TabIndex = 0;
            this.newRequests_lb.Text = "Создание новой заявки";
            // 
            // description_lb
            // 
            this.description_lb.AutoSize = true;
            this.description_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.description_lb.Location = new System.Drawing.Point(8, 70);
            this.description_lb.Name = "description_lb";
            this.description_lb.Size = new System.Drawing.Size(193, 20);
            this.description_lb.TabIndex = 1;
            this.description_lb.Text = "Опишите что случилось";
            // 
            // description_tb
            // 
            this.description_tb.Location = new System.Drawing.Point(12, 100);
            this.description_tb.Multiline = true;
            this.description_tb.Name = "description_tb";
            this.description_tb.Size = new System.Drawing.Size(385, 64);
            this.description_tb.TabIndex = 2;
            // 
            // equipmentsId_lb
            // 
            this.equipmentsId_lb.AutoSize = true;
            this.equipmentsId_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.equipmentsId_lb.Location = new System.Drawing.Point(8, 186);
            this.equipmentsId_lb.Name = "equipmentsId_lb";
            this.equipmentsId_lb.Size = new System.Drawing.Size(203, 20);
            this.equipmentsId_lb.TabIndex = 1;
            this.equipmentsId_lb.Text = "Выберите что сломалось";
            // 
            // sendRequests_btn
            // 
            this.sendRequests_btn.Location = new System.Drawing.Point(7, 393);
            this.sendRequests_btn.Name = "sendRequests_btn";
            this.sendRequests_btn.Size = new System.Drawing.Size(394, 36);
            this.sendRequests_btn.TabIndex = 4;
            this.sendRequests_btn.Text = "Отправить";
            this.sendRequests_btn.UseVisualStyleBackColor = true;
            this.sendRequests_btn.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // equipmentList
            // 
            this.equipmentList.FormattingEnabled = true;
            this.equipmentList.Location = new System.Drawing.Point(12, 219);
            this.equipmentList.Name = "equipmentList";
            this.equipmentList.Size = new System.Drawing.Size(120, 94);
            this.equipmentList.TabIndex = 7;
            // 
            // NewRequests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 441);
            this.Controls.Add(this.equipmentList);
            this.Controls.Add(this.sendRequests_btn);
            this.Controls.Add(this.description_tb);
            this.Controls.Add(this.equipmentsId_lb);
            this.Controls.Add(this.description_lb);
            this.Controls.Add(this.newRequests_lb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "NewRequests";
            this.Text = "NewRequests";
            this.Load += new System.EventHandler(this.NewRequests_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label newRequests_lb;
        private System.Windows.Forms.Label description_lb;
        private System.Windows.Forms.TextBox description_tb;
        private System.Windows.Forms.Label equipmentsId_lb;
        private System.Windows.Forms.Button sendRequests_btn;
        private System.Windows.Forms.CheckedListBox equipmentList;
    }
}