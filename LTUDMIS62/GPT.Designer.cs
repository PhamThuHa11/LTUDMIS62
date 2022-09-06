
using System;

namespace LTUDMIS62
{
    partial class GPT
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEXIT = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblKQ = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(20, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(462, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bài tập 1: Giải phương trình bậc 2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOK);
            this.groupBox1.Controls.Add(this.txtC);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtB);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtA);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(31, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(737, 124);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập tham số a,b,c";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(553, 38);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(160, 46);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "Giải phương trình";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtC
            // 
            this.txtC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtC.Location = new System.Drawing.Point(395, 41);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(40, 34);
            this.txtC.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(358, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "c =";
            // 
            // txtB
            // 
            this.txtB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtB.Location = new System.Drawing.Point(228, 41);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(40, 34);
            this.txtB.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(191, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "b =";
            // 
            // txtA
            // 
            this.txtA.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtA.Location = new System.Drawing.Point(67, 42);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(40, 34);
            this.txtA.TabIndex = 1;
            this.txtA.TextChanged += new System.EventHandler(this.txtA_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(30, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "a =";
            // 
            // btnEXIT
            // 
            this.btnEXIT.Location = new System.Drawing.Point(611, 385);
            this.btnEXIT.Name = "btnEXIT";
            this.btnEXIT.Size = new System.Drawing.Size(133, 37);
            this.btnEXIT.TabIndex = 2;
            this.btnEXIT.Text = "Đóng";
            this.btnEXIT.UseVisualStyleBackColor = true;
            this.btnEXIT.Click += new System.EventHandler(this.btnEXIT_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(259, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 41);
            this.label5.TabIndex = 3;
            this.label5.Text = "Kết quả";
            // 
            // lblKQ
            // 
            this.lblKQ.AutoSize = true;
            this.lblKQ.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblKQ.ForeColor = System.Drawing.Color.Red;
            this.lblKQ.Location = new System.Drawing.Point(194, 312);
            this.lblKQ.Name = "lblKQ";
            this.lblKQ.Size = new System.Drawing.Size(65, 31);
            this.lblKQ.TabIndex = 4;
            this.lblKQ.Text = "x1 = ";
            this.lblKQ.Click += new System.EventHandler(this.lblKQ_Click);
            // 
            // GPT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblKQ);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnEXIT);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "GPT";
            this.Text = "Giải phương trình bậc 2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void lblKQ_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEXIT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblKQ;
    }
}

