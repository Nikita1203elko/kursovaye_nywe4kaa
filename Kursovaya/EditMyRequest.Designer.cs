using System.ComponentModel;

namespace Kursovaya
{
    partial class EditMyRequest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.editMyRequest_lb = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.saveDescriptionRequest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // editMyRequest_lb
            // 
            this.editMyRequest_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editMyRequest_lb.Location = new System.Drawing.Point(4, 9);
            this.editMyRequest_lb.Name = "editMyRequest_lb";
            this.editMyRequest_lb.Size = new System.Drawing.Size(209, 30);
            this.editMyRequest_lb.TabIndex = 0;
            this.editMyRequest_lb.Text = "Изменение заявки";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(8, 61);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(204, 242);
            this.textBox1.TabIndex = 1;
            // 
            // saveDescriptionRequest
            // 
            this.saveDescriptionRequest.Location = new System.Drawing.Point(4, 416);
            this.saveDescriptionRequest.Name = "saveDescriptionRequest";
            this.saveDescriptionRequest.Size = new System.Drawing.Size(207, 27);
            this.saveDescriptionRequest.TabIndex = 2;
            this.saveDescriptionRequest.Text = "Сохранить";
            this.saveDescriptionRequest.UseVisualStyleBackColor = true;
            this.saveDescriptionRequest.Click += new System.EventHandler(this.saveDescriptionRequest_Click);
            // 
            // EditMyRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(218, 450);
            this.Controls.Add(this.saveDescriptionRequest);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.editMyRequest_lb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "EditMyRequest";
            this.Load += new System.EventHandler(this.EditMyRequest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button saveDescriptionRequest;

        private System.Windows.Forms.TextBox textBox1;

        private System.Windows.Forms.Label editMyRequest_lb;

        #endregion
    }
}