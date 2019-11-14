namespace roundDecimalKaelanK
{
    partial class frmRoundDecimal
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
            this.lblEnter = new System.Windows.Forms.Label();
            this.nudPlaces = new System.Windows.Forms.NumericUpDown();
            this.txtDecimal = new System.Windows.Forms.TextBox();
            this.btnRound = new System.Windows.Forms.Button();
            this.lblDecimal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlaces)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEnter
            // 
            this.lblEnter.AutoSize = true;
            this.lblEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnter.Location = new System.Drawing.Point(12, 15);
            this.lblEnter.Name = "lblEnter";
            this.lblEnter.Size = new System.Drawing.Size(181, 20);
            this.lblEnter.TabIndex = 0;
            this.lblEnter.Text = "Enter a decimal number:";
            // 
            // nudPlaces
            // 
            this.nudPlaces.Location = new System.Drawing.Point(383, 63);
            this.nudPlaces.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudPlaces.Name = "nudPlaces";
            this.nudPlaces.Size = new System.Drawing.Size(38, 20);
            this.nudPlaces.TabIndex = 1;
            // 
            // txtDecimal
            // 
            this.txtDecimal.Location = new System.Drawing.Point(199, 17);
            this.txtDecimal.Name = "txtDecimal";
            this.txtDecimal.Size = new System.Drawing.Size(178, 20);
            this.txtDecimal.TabIndex = 2;
            // 
            // btnRound
            // 
            this.btnRound.Location = new System.Drawing.Point(16, 106);
            this.btnRound.Name = "btnRound";
            this.btnRound.Size = new System.Drawing.Size(89, 36);
            this.btnRound.TabIndex = 3;
            this.btnRound.Text = "Round";
            this.btnRound.UseVisualStyleBackColor = true;
            this.btnRound.Click += new System.EventHandler(this.BtnRound_Click);
            // 
            // lblDecimal
            // 
            this.lblDecimal.AutoSize = true;
            this.lblDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecimal.Location = new System.Drawing.Point(12, 63);
            this.lblDecimal.Name = "lblDecimal";
            this.lblDecimal.Size = new System.Drawing.Size(365, 40);
            this.lblDecimal.TabIndex = 4;
            this.lblDecimal.Text = "How many decimal places do you want to round to:\r\n\r\n";
            // 
            // frmRoundDecimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 168);
            this.Controls.Add(this.lblDecimal);
            this.Controls.Add(this.btnRound);
            this.Controls.Add(this.txtDecimal);
            this.Controls.Add(this.nudPlaces);
            this.Controls.Add(this.lblEnter);
            this.Name = "frmRoundDecimal";
            this.Text = "Rounded Decimal";
            ((System.ComponentModel.ISupportInitialize)(this.nudPlaces)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnter;
        private System.Windows.Forms.NumericUpDown nudPlaces;
        private System.Windows.Forms.TextBox txtDecimal;
        private System.Windows.Forms.Button btnRound;
        private System.Windows.Forms.Label lblDecimal;
    }
}

