namespace MCT_Helper
{
    partial class fPCD
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
            this.bCalculating = new System.Windows.Forms.Button();
            this.lPCD = new System.Windows.Forms.Label();
            this.tPCD = new System.Windows.Forms.TextBox();
            this.chHalfAngle = new System.Windows.Forms.CheckBox();
            this.lHole = new System.Windows.Forms.Label();
            this.tHoleQty = new System.Windows.Forms.TextBox();
            this.lAngle = new System.Windows.Forms.Label();
            this.tStartAngle = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bCalculating
            // 
            this.bCalculating.Font = new System.Drawing.Font("Gulim", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bCalculating.Location = new System.Drawing.Point(45, 130);
            this.bCalculating.Name = "bCalculating";
            this.bCalculating.Size = new System.Drawing.Size(100, 23);
            this.bCalculating.TabIndex = 5;
            this.bCalculating.Text = "Calculating";
            this.bCalculating.UseVisualStyleBackColor = true;
            this.bCalculating.Click += new System.EventHandler(this.bCalculating_Click);
            // 
            // lPCD
            // 
            this.lPCD.AutoSize = true;
            this.lPCD.Location = new System.Drawing.Point(10, 15);
            this.lPCD.Name = "lPCD";
            this.lPCD.Size = new System.Drawing.Size(30, 12);
            this.lPCD.TabIndex = 1;
            this.lPCD.Text = "PCD";
            // 
            // tPCD
            // 
            this.tPCD.Location = new System.Drawing.Point(70, 10);
            this.tPCD.Name = "tPCD";
            this.tPCD.Size = new System.Drawing.Size(100, 21);
            this.tPCD.TabIndex = 1;
            this.tPCD.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tPCD_KeyDown);
            this.tPCD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tPCD_KeyPress);
            // 
            // chHalfAngle
            // 
            this.chHalfAngle.AutoSize = true;
            this.chHalfAngle.Location = new System.Drawing.Point(30, 100);
            this.chHalfAngle.Name = "chHalfAngle";
            this.chHalfAngle.Size = new System.Drawing.Size(132, 16);
            this.chHalfAngle.TabIndex = 4;
            this.chHalfAngle.Text = "시작 각도 자동 계산";
            this.chHalfAngle.UseVisualStyleBackColor = true;
            this.chHalfAngle.CheckedChanged += new System.EventHandler(this.chHalfAngle_CheckedChanged);
            this.chHalfAngle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chHalfAngle_KeyDown);
            // 
            // lHole
            // 
            this.lHole.AutoSize = true;
            this.lHole.Location = new System.Drawing.Point(10, 45);
            this.lHole.Name = "lHole";
            this.lHole.Size = new System.Drawing.Size(45, 12);
            this.lHole.TabIndex = 1;
            this.lHole.Text = "홀 수량";
            // 
            // tHoleQty
            // 
            this.tHoleQty.Location = new System.Drawing.Point(70, 40);
            this.tHoleQty.Name = "tHoleQty";
            this.tHoleQty.Size = new System.Drawing.Size(100, 21);
            this.tHoleQty.TabIndex = 2;
            this.tHoleQty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tHoleQty_KeyDown);
            this.tHoleQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tHoleQty_KeyPress);
            // 
            // lAngle
            // 
            this.lAngle.AutoSize = true;
            this.lAngle.Location = new System.Drawing.Point(10, 75);
            this.lAngle.Name = "lAngle";
            this.lAngle.Size = new System.Drawing.Size(57, 12);
            this.lAngle.TabIndex = 1;
            this.lAngle.Text = "시작 각도";
            // 
            // tStartAngle
            // 
            this.tStartAngle.Location = new System.Drawing.Point(70, 70);
            this.tStartAngle.Name = "tStartAngle";
            this.tStartAngle.Size = new System.Drawing.Size(100, 21);
            this.tStartAngle.TabIndex = 3;
            this.tStartAngle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tStartAngle_KeyDown);
            this.tStartAngle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tStartAngle_KeyPress);
            // 
            // fPCD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(184, 161);
            this.Controls.Add(this.chHalfAngle);
            this.Controls.Add(this.tStartAngle);
            this.Controls.Add(this.lAngle);
            this.Controls.Add(this.tHoleQty);
            this.Controls.Add(this.lHole);
            this.Controls.Add(this.tPCD);
            this.Controls.Add(this.lPCD);
            this.Controls.Add(this.bCalculating);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "fPCD";
            this.ShowIcon = false;
            this.Text = "PCD 계산";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bCalculating;
        private System.Windows.Forms.Label lPCD;
        private System.Windows.Forms.TextBox tPCD;
        private System.Windows.Forms.CheckBox chHalfAngle;
        private System.Windows.Forms.Label lHole;
        private System.Windows.Forms.TextBox tHoleQty;
        private System.Windows.Forms.Label lAngle;
        private System.Windows.Forms.TextBox tStartAngle;
    }
}

