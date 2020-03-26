namespace bai7
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNamDuong = new System.Windows.Forms.TextBox();
            this.btnChance = new System.Windows.Forms.Button();
            this.txtNamAmLich = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập vào năm dương :";
            // 
            // txtNamDuong
            // 
            this.txtNamDuong.Location = new System.Drawing.Point(163, 20);
            this.txtNamDuong.Name = "txtNamDuong";
            this.txtNamDuong.Size = new System.Drawing.Size(150, 20);
            this.txtNamDuong.TabIndex = 1;
            this.txtNamDuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnChance
            // 
            this.btnChance.Location = new System.Drawing.Point(107, 52);
            this.btnChance.Name = "btnChance";
            this.btnChance.Size = new System.Drawing.Size(136, 23);
            this.btnChance.TabIndex = 2;
            this.btnChance.Text = "Thực hiện thay đổi";
            this.btnChance.UseVisualStyleBackColor = true;
            this.btnChance.Click += new System.EventHandler(this.btnChance_Click);
            // 
            // txtNamAmLich
            // 
            this.txtNamAmLich.Location = new System.Drawing.Point(163, 88);
            this.txtNamAmLich.Name = "txtNamAmLich";
            this.txtNamAmLich.ReadOnly = true;
            this.txtNamAmLich.Size = new System.Drawing.Size(150, 20);
            this.txtNamAmLich.TabIndex = 4;
            this.txtNamAmLich.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Năm âm lịch :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 126);
            this.Controls.Add(this.txtNamAmLich);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnChance);
            this.Controls.Add(this.txtNamDuong);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNamDuong;
        private System.Windows.Forms.Button btnChance;
        private System.Windows.Forms.TextBox txtNamAmLich;
        private System.Windows.Forms.Label label2;
    }
}

