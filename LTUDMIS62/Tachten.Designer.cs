
namespace LTUDMIS62
{
    partial class Tachten
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
            this.txtHT = new System.Windows.Forms.TextBox();
            this.btnHODEM = new System.Windows.Forms.Button();
            this.btnDEM = new System.Windows.Forms.Button();
            this.btnDEMTEN = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblKQ = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(41, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ và tên:";
            // 
            // txtHT
            // 
            this.txtHT.Location = new System.Drawing.Point(170, 29);
            this.txtHT.Name = "txtHT";
            this.txtHT.Size = new System.Drawing.Size(176, 27);
            this.txtHT.TabIndex = 1;
            // 
            // btnHODEM
            // 
            this.btnHODEM.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHODEM.Location = new System.Drawing.Point(61, 100);
            this.btnHODEM.Name = "btnHODEM";
            this.btnHODEM.Size = new System.Drawing.Size(145, 34);
            this.btnHODEM.TabIndex = 2;
            this.btnHODEM.Text = "Tách họ đệm";
            this.btnHODEM.UseVisualStyleBackColor = true;
            this.btnHODEM.Click += new System.EventHandler(this.btnHODEM_Click);
            // 
            // btnDEM
            // 
            this.btnDEM.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDEM.Location = new System.Drawing.Point(315, 100);
            this.btnDEM.Name = "btnDEM";
            this.btnDEM.Size = new System.Drawing.Size(145, 34);
            this.btnDEM.TabIndex = 3;
            this.btnDEM.Text = "Tách đệm";
            this.btnDEM.UseVisualStyleBackColor = true;
            this.btnDEM.Click += new System.EventHandler(this.btnDEM_Click);
            // 
            // btnDEMTEN
            // 
            this.btnDEMTEN.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDEMTEN.Location = new System.Drawing.Point(569, 100);
            this.btnDEMTEN.Name = "btnDEMTEN";
            this.btnDEMTEN.Size = new System.Drawing.Size(145, 34);
            this.btnDEMTEN.TabIndex = 4;
            this.btnDEMTEN.Text = "Tách đệm và tên";
            this.btnDEMTEN.UseVisualStyleBackColor = true;
            this.btnDEMTEN.Click += new System.EventHandler(this.btnDEMTEN_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(656, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 32);
            this.button1.TabIndex = 5;
            this.button1.Text = "Đóng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(315, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 38);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kết quả:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 8;
            // 
            // lblKQ
            // 
            this.lblKQ.AutoSize = true;
            this.lblKQ.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblKQ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblKQ.Location = new System.Drawing.Point(315, 276);
            this.lblKQ.Name = "lblKQ";
            this.lblKQ.Size = new System.Drawing.Size(44, 31);
            this.lblKQ.TabIndex = 9;
            this.lblKQ.Text = "KQ";
            this.lblKQ.Click += new System.EventHandler(this.label3_Click);
            // 
            // Tachten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblKQ);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDEMTEN);
            this.Controls.Add(this.btnDEM);
            this.Controls.Add(this.btnHODEM);
            this.Controls.Add(this.txtHT);
            this.Controls.Add(this.label1);
            this.Name = "Tachten";
            this.Text = "Tachten";
            this.Load += new System.EventHandler(this.Tachten_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHT;
        private System.Windows.Forms.Button btnHODEM;
        private System.Windows.Forms.Button btnDEM;
        private System.Windows.Forms.Button btnDEMTEN;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblKQ;
    }
}