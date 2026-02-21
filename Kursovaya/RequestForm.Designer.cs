namespace Kursovaya
{
    partial class RequestForm
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.requestId_lb = new System.Windows.Forms.Label();
            this.DateRequest_lb = new System.Windows.Forms.Label();
            this.DescriptionRequest_lb = new System.Windows.Forms.Label();
            this.StatusRequest_lb = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.отменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // requestId_lb
            // 
            this.requestId_lb.AutoSize = true;
            this.requestId_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.requestId_lb.Location = new System.Drawing.Point(13, 10);
            this.requestId_lb.Name = "requestId_lb";
            this.requestId_lb.Size = new System.Drawing.Size(77, 18);
            this.requestId_lb.TabIndex = 0;
            this.requestId_lb.Text = "Заявка №";
            // 
            // DateRequest_lb
            // 
            this.DateRequest_lb.AutoSize = true;
            this.DateRequest_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateRequest_lb.Location = new System.Drawing.Point(13, 35);
            this.DateRequest_lb.Name = "DateRequest_lb";
            this.DateRequest_lb.Size = new System.Drawing.Size(43, 18);
            this.DateRequest_lb.TabIndex = 0;
            this.DateRequest_lb.Text = "Дата";
            // 
            // DescriptionRequest_lb
            // 
            this.DescriptionRequest_lb.AutoSize = true;
            this.DescriptionRequest_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DescriptionRequest_lb.Location = new System.Drawing.Point(13, 63);
            this.DescriptionRequest_lb.Name = "DescriptionRequest_lb";
            this.DescriptionRequest_lb.Size = new System.Drawing.Size(76, 18);
            this.DescriptionRequest_lb.TabIndex = 0;
            this.DescriptionRequest_lb.Text = "Описание";
            // 
            // StatusRequest_lb
            // 
            this.StatusRequest_lb.AutoSize = true;
            this.StatusRequest_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StatusRequest_lb.Location = new System.Drawing.Point(13, 103);
            this.StatusRequest_lb.Name = "StatusRequest_lb";
            this.StatusRequest_lb.Size = new System.Drawing.Size(56, 18);
            this.StatusRequest_lb.TabIndex = 0;
            this.StatusRequest_lb.Text = "Статус";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.requestId_lb);
            this.panel1.Controls.Add(this.StatusRequest_lb);
            this.panel1.Controls.Add(this.DateRequest_lb);
            this.panel1.Controls.Add(this.DescriptionRequest_lb);
            this.panel1.Location = new System.Drawing.Point(7, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 133);
            this.panel1.TabIndex = 1;
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.отменитьToolStripMenuItem, this.редактироватьToolStripMenuItem });
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(155, 48);
            // 
            // отменитьToolStripMenuItem
            // 
            this.отменитьToolStripMenuItem.Name = "отменитьToolStripMenuItem";
            this.отменитьToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.отменитьToolStripMenuItem.Text = "Редактировать";
            this.отменитьToolStripMenuItem.Click += new System.EventHandler(this.редактироватьToolStripMenuItem_Click);
            // 
            // редактироватьToolStripMenuItem
            // 
            this.редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            this.редактироватьToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.редактироватьToolStripMenuItem.Text = "Отменить";
            this.редактироватьToolStripMenuItem.Click += new System.EventHandler(this.отменитьToolStripMenuItem_Click);
            // 
            // RequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "RequestForm";
            this.Size = new System.Drawing.Size(762, 150);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label requestId_lb;
        private System.Windows.Forms.Label DateRequest_lb;
        private System.Windows.Forms.Label DescriptionRequest_lb;
        private System.Windows.Forms.Label StatusRequest_lb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem отменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem;
    }
}
