namespace bai2
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
            this.btnArea = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblCd = new System.Windows.Forms.Label();
            this.txtCD = new System.Windows.Forms.TextBox();
            this.txtCR = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnArea
            // 
            this.btnArea.Enabled = false;
            this.btnArea.Location = new System.Drawing.Point(12, 90);
            this.btnArea.Name = "btnArea";
            this.btnArea.Size = new System.Drawing.Size(94, 25);
            this.btnArea.TabIndex = 0;
            this.btnArea.Text = "Tính Diễn tích";
            this.btnArea.UseVisualStyleBackColor = true;
            this.btnArea.Click += new System.EventHandler(this.btnArea_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(156, 90);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 25);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "kết thúc";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(112, 90);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(38, 25);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "tiếp";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblCd
            // 
            this.lblCd.AutoSize = true;
            this.lblCd.Location = new System.Drawing.Point(38, 14);
            this.lblCd.Name = "lblCd";
            this.lblCd.Size = new System.Drawing.Size(53, 13);
            this.lblCd.TabIndex = 4;
            this.lblCd.Text = "Chiều Dài";
            // 
            // txtCD
            // 
            this.txtCD.Location = new System.Drawing.Point(112, 11);
            this.txtCD.Name = "txtCD";
            this.txtCD.Size = new System.Drawing.Size(100, 20);
            this.txtCD.TabIndex = 5;
            this.txtCD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCD.TextChanged += new System.EventHandler(this.txtChange);
            // 
            // txtCR
            // 
            this.txtCR.Location = new System.Drawing.Point(112, 34);
            this.txtCR.Name = "txtCR";
            this.txtCR.Size = new System.Drawing.Size(100, 20);
            this.txtCR.TabIndex = 7;
            this.txtCR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCR.TextChanged += new System.EventHandler(this.txtChange);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Chiều Rộng";
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(112, 60);
            this.txtArea.Name = "txtArea";
            this.txtArea.ReadOnly = true;
            this.txtArea.Size = new System.Drawing.Size(100, 20);
            this.txtArea.TabIndex = 9;
            this.txtArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Diễn Tích";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnArea;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(246, 121);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCD);
            this.Controls.Add(this.lblCd);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnArea);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnArea;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblCd;
        private System.Windows.Forms.TextBox txtCD;
        private System.Windows.Forms.TextBox txtCR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label label2;
    }
}

