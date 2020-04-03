namespace H8
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Button1 = new System.Windows.Forms.Button();
            this.LblHeight = new System.Windows.Forms.Label();
            this.textHeight = new System.Windows.Forms.TextBox();
            this.textLength = new System.Windows.Forms.TextBox();
            this.LblLength = new System.Windows.Forms.Label();
            this.LblPer1 = new System.Windows.Forms.Label();
            this.textPer1 = new System.Windows.Forms.TextBox();
            this.LblPer2 = new System.Windows.Forms.Label();
            this.textPer2 = new System.Windows.Forms.TextBox();
            this.textTh1 = new System.Windows.Forms.TextBox();
            this.textTh2 = new System.Windows.Forms.TextBox();
            this.LblTh1 = new System.Windows.Forms.Label();
            this.LblTh2 = new System.Windows.Forms.Label();
            this.LblPen = new System.Windows.Forms.Label();
            this.LblWarning = new System.Windows.Forms.Label();
            this.TreePanel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnColorDialog = new System.Windows.Forms.Button();
            this.TreePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(54, 12);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(75, 23);
            this.Button1.TabIndex = 1;
            this.Button1.Text = "Draw";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // LblHeight
            // 
            this.LblHeight.AutoSize = true;
            this.LblHeight.Location = new System.Drawing.Point(3, 71);
            this.LblHeight.Name = "LblHeight";
            this.LblHeight.Size = new System.Drawing.Size(67, 15);
            this.LblHeight.TabIndex = 4;
            this.LblHeight.Text = "递归深度";
            // 
            // textHeight
            // 
            this.textHeight.Location = new System.Drawing.Point(106, 68);
            this.textHeight.Name = "textHeight";
            this.textHeight.Size = new System.Drawing.Size(75, 25);
            this.textHeight.TabIndex = 5;
            this.textHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textHeight_KeyPress);
            // 
            // textLength
            // 
            this.textLength.Location = new System.Drawing.Point(106, 115);
            this.textLength.Name = "textLength";
            this.textLength.Size = new System.Drawing.Size(73, 25);
            this.textLength.TabIndex = 6;
            this.textLength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textHeight_KeyPress);
            // 
            // LblLength
            // 
            this.LblLength.AutoSize = true;
            this.LblLength.Location = new System.Drawing.Point(3, 115);
            this.LblLength.Name = "LblLength";
            this.LblLength.Size = new System.Drawing.Size(67, 15);
            this.LblLength.TabIndex = 7;
            this.LblLength.Text = "递归步数";
            // 
            // LblPer1
            // 
            this.LblPer1.AutoSize = true;
            this.LblPer1.Location = new System.Drawing.Point(3, 177);
            this.LblPer1.Name = "LblPer1";
            this.LblPer1.Size = new System.Drawing.Size(97, 15);
            this.LblPer1.TabIndex = 8;
            this.LblPer1.Text = "右分支长度比";
            // 
            // textPer1
            // 
            this.textPer1.Location = new System.Drawing.Point(106, 174);
            this.textPer1.Name = "textPer1";
            this.textPer1.Size = new System.Drawing.Size(73, 25);
            this.textPer1.TabIndex = 9;
            this.textPer1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textPer1_KeyPress);
            // 
            // LblPer2
            // 
            this.LblPer2.AutoSize = true;
            this.LblPer2.Location = new System.Drawing.Point(3, 244);
            this.LblPer2.Name = "LblPer2";
            this.LblPer2.Size = new System.Drawing.Size(97, 15);
            this.LblPer2.TabIndex = 10;
            this.LblPer2.Text = "左分支长度比";
            // 
            // textPer2
            // 
            this.textPer2.Location = new System.Drawing.Point(106, 234);
            this.textPer2.Name = "textPer2";
            this.textPer2.Size = new System.Drawing.Size(73, 25);
            this.textPer2.TabIndex = 11;
            this.textPer2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textPer1_KeyPress);
            // 
            // textTh1
            // 
            this.textTh1.Location = new System.Drawing.Point(106, 292);
            this.textTh1.Name = "textTh1";
            this.textTh1.Size = new System.Drawing.Size(73, 25);
            this.textTh1.TabIndex = 12;
            this.textTh1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textPer1_KeyPress);
            // 
            // textTh2
            // 
            this.textTh2.Location = new System.Drawing.Point(106, 349);
            this.textTh2.Name = "textTh2";
            this.textTh2.Size = new System.Drawing.Size(73, 25);
            this.textTh2.TabIndex = 13;
            this.textTh2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textPer1_KeyPress);
            // 
            // LblTh1
            // 
            this.LblTh1.AutoSize = true;
            this.LblTh1.Location = new System.Drawing.Point(3, 292);
            this.LblTh1.Name = "LblTh1";
            this.LblTh1.Size = new System.Drawing.Size(82, 15);
            this.LblTh1.TabIndex = 14;
            this.LblTh1.Text = "右分支角度";
            // 
            // LblTh2
            // 
            this.LblTh2.AutoSize = true;
            this.LblTh2.Location = new System.Drawing.Point(3, 352);
            this.LblTh2.Name = "LblTh2";
            this.LblTh2.Size = new System.Drawing.Size(82, 15);
            this.LblTh2.TabIndex = 15;
            this.LblTh2.Text = "左分支角度";
            // 
            // LblPen
            // 
            this.LblPen.AutoSize = true;
            this.LblPen.Location = new System.Drawing.Point(69, 387);
            this.LblPen.Name = "LblPen";
            this.LblPen.Size = new System.Drawing.Size(31, 15);
            this.LblPen.TabIndex = 16;
            this.LblPen.Text = "Pen";
            // 
            // LblWarning
            // 
            this.LblWarning.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LblWarning.ForeColor = System.Drawing.Color.Red;
            this.LblWarning.Location = new System.Drawing.Point(12, 451);
            this.LblWarning.Name = "LblWarning";
            this.LblWarning.Size = new System.Drawing.Size(152, 62);
            this.LblWarning.TabIndex = 18;
            this.LblWarning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TreePanel
            // 
            this.TreePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TreePanel.AutoScroll = true;
            this.TreePanel.AutoSize = true;
            this.TreePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TreePanel.Controls.Add(this.groupBox1);
            this.TreePanel.Location = new System.Drawing.Point(197, 12);
            this.TreePanel.Name = "TreePanel";
            this.TreePanel.Size = new System.Drawing.Size(695, 488);
            this.TreePanel.TabIndex = 19;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(544, 188);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(8, 8);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // BtnColorDialog
            // 
            this.BtnColorDialog.Location = new System.Drawing.Point(30, 416);
            this.BtnColorDialog.Name = "BtnColorDialog";
            this.BtnColorDialog.Size = new System.Drawing.Size(110, 23);
            this.BtnColorDialog.TabIndex = 20;
            this.BtnColorDialog.Text = "ColorDialog";
            this.BtnColorDialog.UseVisualStyleBackColor = true;
            this.BtnColorDialog.Click += new System.EventHandler(this.BtnColorDialog_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 512);
            this.Controls.Add(this.BtnColorDialog);
            this.Controls.Add(this.LblWarning);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.TreePanel);
            this.Controls.Add(this.textTh2);
            this.Controls.Add(this.LblPen);
            this.Controls.Add(this.LblTh2);
            this.Controls.Add(this.textTh1);
            this.Controls.Add(this.LblLength);
            this.Controls.Add(this.LblTh1);
            this.Controls.Add(this.textHeight);
            this.Controls.Add(this.LblPer1);
            this.Controls.Add(this.textLength);
            this.Controls.Add(this.textPer1);
            this.Controls.Add(this.LblHeight);
            this.Controls.Add(this.LblPer2);
            this.Controls.Add(this.textPer2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TreePanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Label LblHeight;
        private System.Windows.Forms.TextBox textHeight;
        private System.Windows.Forms.TextBox textLength;
        private System.Windows.Forms.Label LblLength;
        private System.Windows.Forms.Label LblPer1;
        private System.Windows.Forms.TextBox textPer1;
        private System.Windows.Forms.Label LblPer2;
        private System.Windows.Forms.TextBox textPer2;
        private System.Windows.Forms.TextBox textTh1;
        private System.Windows.Forms.TextBox textTh2;
        private System.Windows.Forms.Label LblTh1;
        private System.Windows.Forms.Label LblTh2;
        private System.Windows.Forms.Label LblPen;
        private System.Windows.Forms.Label LblWarning;
        private System.Windows.Forms.Panel TreePanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnColorDialog;
    }
}

