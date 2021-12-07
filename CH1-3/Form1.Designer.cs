namespace CH1_3
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.llblPaint = new System.Windows.Forms.LinkLabel();
            this.llblColor = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.hsbR = new System.Windows.Forms.HScrollBar();
            this.hsbG = new System.Windows.Forms.HScrollBar();
            this.hsbB = new System.Windows.Forms.HScrollBar();
            this.lblRGB = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblShow = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(1, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(798, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "調色盤";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // llblPaint
            // 
            this.llblPaint.AutoSize = true;
            this.llblPaint.Location = new System.Drawing.Point(197, 90);
            this.llblPaint.Name = "llblPaint";
            this.llblPaint.Size = new System.Drawing.Size(89, 12);
            this.llblPaint.TabIndex = 1;
            this.llblPaint.TabStop = true;
            this.llblPaint.Text = "開啟小畫家程式";
            this.llblPaint.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblPaint_LinkClicked);
            // 
            // llblColor
            // 
            this.llblColor.AutoSize = true;
            this.llblColor.Location = new System.Drawing.Point(494, 90);
            this.llblColor.Name = "llblColor";
            this.llblColor.Size = new System.Drawing.Size(89, 12);
            this.llblColor.TabIndex = 2;
            this.llblColor.TabStop = true;
            this.llblColor.Text = "色彩編碼超連結";
            this.llblColor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblColor_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(94, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "紅(R)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(94, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "綠(G)";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(94, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "藍(B)";
            // 
            // hsbR
            // 
            this.hsbR.LargeChange = 1;
            this.hsbR.Location = new System.Drawing.Point(189, 143);
            this.hsbR.Maximum = 255;
            this.hsbR.Name = "hsbR";
            this.hsbR.Size = new System.Drawing.Size(423, 19);
            this.hsbR.TabIndex = 6;
            this.hsbR.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsbR_Scroll);
            // 
            // hsbG
            // 
            this.hsbG.LargeChange = 1;
            this.hsbG.Location = new System.Drawing.Point(189, 183);
            this.hsbG.Maximum = 255;
            this.hsbG.Name = "hsbG";
            this.hsbG.Size = new System.Drawing.Size(423, 19);
            this.hsbG.TabIndex = 7;
            this.hsbG.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsbR_Scroll);
            // 
            // hsbB
            // 
            this.hsbB.LargeChange = 1;
            this.hsbB.Location = new System.Drawing.Point(189, 223);
            this.hsbB.Maximum = 255;
            this.hsbB.Name = "hsbB";
            this.hsbB.Size = new System.Drawing.Size(423, 19);
            this.hsbB.TabIndex = 8;
            this.hsbB.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsbR_Scroll);
            // 
            // lblRGB
            // 
            this.lblRGB.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRGB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRGB.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblRGB.Location = new System.Drawing.Point(169, 262);
            this.lblRGB.Name = "lblRGB";
            this.lblRGB.Size = new System.Drawing.Size(443, 41);
            this.lblRGB.TabIndex = 9;
            this.lblRGB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(367, 354);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 12);
            this.label5.TabIndex = 10;
            // 
            // lblShow
            // 
            this.lblShow.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblShow.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblShow.Location = new System.Drawing.Point(132, 314);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(515, 127);
            this.lblShow.TabIndex = 11;
            this.lblShow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblShow);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblRGB);
            this.Controls.Add(this.hsbB);
            this.Controls.Add(this.hsbG);
            this.Controls.Add(this.hsbR);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.llblColor);
            this.Controls.Add(this.llblPaint);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel llblPaint;
        private System.Windows.Forms.LinkLabel llblColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.HScrollBar hsbR;
        private System.Windows.Forms.HScrollBar hsbG;
        private System.Windows.Forms.HScrollBar hsbB;
        private System.Windows.Forms.Label lblRGB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblShow;
    }
}

