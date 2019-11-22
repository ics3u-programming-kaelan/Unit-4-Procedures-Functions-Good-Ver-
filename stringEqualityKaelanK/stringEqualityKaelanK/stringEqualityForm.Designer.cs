namespace stringEqualityKaelanK
{
    partial class stringEqualityForm
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
            this.lblString1 = new System.Windows.Forms.Label();
            this.lblString2 = new System.Windows.Forms.Label();
            this.txtString1 = new System.Windows.Forms.TextBox();
            this.txtString2 = new System.Windows.Forms.TextBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblString1
            // 
            this.lblString1.AutoSize = true;
            this.lblString1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblString1.Location = new System.Drawing.Point(33, 28);
            this.lblString1.Name = "lblString1";
            this.lblString1.Size = new System.Drawing.Size(108, 20);
            this.lblString1.TabIndex = 0;
            this.lblString1.Text = "Enter a string:\r\n";
            // 
            // lblString2
            // 
            this.lblString2.AutoSize = true;
            this.lblString2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblString2.Location = new System.Drawing.Point(33, 59);
            this.lblString2.Name = "lblString2";
            this.lblString2.Size = new System.Drawing.Size(108, 20);
            this.lblString2.TabIndex = 1;
            this.lblString2.Text = "Enter a string:";
            // 
            // txtString1
            // 
            this.txtString1.Location = new System.Drawing.Point(147, 28);
            this.txtString1.Name = "txtString1";
            this.txtString1.Size = new System.Drawing.Size(100, 20);
            this.txtString1.TabIndex = 2;
            // 
            // txtString2
            // 
            this.txtString2.Location = new System.Drawing.Point(147, 61);
            this.txtString2.Name = "txtString2";
            this.txtString2.Size = new System.Drawing.Size(100, 20);
            this.txtString2.TabIndex = 3;
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.Location = new System.Drawing.Point(114, 162);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(36, 20);
            this.lblOutput.TabIndex = 4;
            this.lblOutput.Text = "???\r\n";
            // 
            // btnEnter
            // 
            this.btnEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.Location = new System.Drawing.Point(83, 92);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(90, 49);
            this.btnEnter.TabIndex = 5;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.BtnEnter_Click);
            // 
            // stringEqualityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 203);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.txtString2);
            this.Controls.Add(this.txtString1);
            this.Controls.Add(this.lblString2);
            this.Controls.Add(this.lblString1);
            this.Name = "stringEqualityForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblString1;
        private System.Windows.Forms.Label lblString2;
        private System.Windows.Forms.TextBox txtString1;
        private System.Windows.Forms.TextBox txtString2;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btnEnter;
    }
}

