namespace MCT_Helper
{
    partial class fPrintPCD
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
            this.tPrintData = new System.Windows.Forms.TextBox();
            this.bClose = new System.Windows.Forms.Button();
            this.lPCD = new System.Windows.Forms.Label();
            this.lStartAngle = new System.Windows.Forms.Label();
            this.lAngle = new System.Windows.Forms.Label();
            this.tNo = new System.Windows.Forms.TextBox();
            this.lHoleQty = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tPrintData
            // 
            this.tPrintData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tPrintData.Location = new System.Drawing.Point(30, 30);
            this.tPrintData.Multiline = true;
            this.tPrintData.Name = "tPrintData";
            this.tPrintData.ReadOnly = true;
            this.tPrintData.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tPrintData.Size = new System.Drawing.Size(256, 200);
            this.tPrintData.TabIndex = 0;
            // 
            // bClose
            // 
            this.bClose.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bClose.Font = new System.Drawing.Font("Gulim", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bClose.Location = new System.Drawing.Point(0, 236);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(284, 25);
            this.bClose.TabIndex = 1;
            this.bClose.Text = "닫기";
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // lPCD
            // 
            this.lPCD.AutoSize = true;
            this.lPCD.Location = new System.Drawing.Point(0, 0);
            this.lPCD.Name = "lPCD";
            this.lPCD.Size = new System.Drawing.Size(30, 12);
            this.lPCD.TabIndex = 2;
            this.lPCD.Text = "PCD";
            // 
            // lStartAngle
            // 
            this.lStartAngle.AutoSize = true;
            this.lStartAngle.Location = new System.Drawing.Point(0, 15);
            this.lStartAngle.Name = "lStartAngle";
            this.lStartAngle.Size = new System.Drawing.Size(57, 12);
            this.lStartAngle.TabIndex = 2;
            this.lStartAngle.Text = "시작 각도";
            // 
            // lAngle
            // 
            this.lAngle.AutoSize = true;
            this.lAngle.Location = new System.Drawing.Point(100, 15);
            this.lAngle.Name = "lAngle";
            this.lAngle.Size = new System.Drawing.Size(57, 12);
            this.lAngle.TabIndex = 2;
            this.lAngle.Text = "홀간 각도";
            // 
            // tNo
            // 
            this.tNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tNo.Location = new System.Drawing.Point(0, 30);
            this.tNo.Multiline = true;
            this.tNo.Name = "tNo";
            this.tNo.ReadOnly = true;
            this.tNo.Size = new System.Drawing.Size(30, 200);
            this.tNo.TabIndex = 3;
            this.tNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lHoleQty
            // 
            this.lHoleQty.AutoSize = true;
            this.lHoleQty.Location = new System.Drawing.Point(100, 0);
            this.lHoleQty.Name = "lHoleQty";
            this.lHoleQty.Size = new System.Drawing.Size(45, 12);
            this.lHoleQty.TabIndex = 2;
            this.lHoleQty.Text = "홀 수량";
            // 
            // fPrintPCD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.ControlBox = false;
            this.Controls.Add(this.tNo);
            this.Controls.Add(this.lHoleQty);
            this.Controls.Add(this.lAngle);
            this.Controls.Add(this.lStartAngle);
            this.Controls.Add(this.lPCD);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.tPrintData);
            this.Name = "fPrintPCD";
            this.Text = "PCD 좌표";
            this.Load += new System.EventHandler(this.PrintPCD_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tPrintData;
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.Label lPCD;
        private System.Windows.Forms.Label lStartAngle;
        private System.Windows.Forms.Label lAngle;
        private System.Windows.Forms.TextBox tNo;
        private System.Windows.Forms.Label lHoleQty;
    }
}