namespace CRC16
{
    partial class MainForm
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
            this.txtData = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblChecksum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblByte1 = new System.Windows.Forms.Label();
            this.lblByte2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(12, 36);
            this.txtData.Multiline = true;
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(546, 302);
            this.txtData.TabIndex = 0;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(38, 354);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(155, 23);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "Calculate Checksum =>";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblChecksum
            // 
            this.lblChecksum.AutoSize = true;
            this.lblChecksum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblChecksum.Location = new System.Drawing.Point(209, 359);
            this.lblChecksum.Name = "lblChecksum";
            this.lblChecksum.Size = new System.Drawing.Size(132, 15);
            this.lblChecksum.TabIndex = 2;
            this.lblChecksum.Text = "Checksum Not Calculated";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter comma delimited string of HEX values, like so: 0a,4c,3d,00,00,4d,2e,22,aa";
            // 
            // lblByte1
            // 
            this.lblByte1.AutoSize = true;
            this.lblByte1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblByte1.Location = new System.Drawing.Point(366, 359);
            this.lblByte1.Name = "lblByte1";
            this.lblByte1.Size = new System.Drawing.Size(35, 15);
            this.lblByte1.TabIndex = 2;
            this.lblByte1.Text = "byte1";
            // 
            // lblByte2
            // 
            this.lblByte2.AutoSize = true;
            this.lblByte2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblByte2.Location = new System.Drawing.Point(407, 359);
            this.lblByte2.Name = "lblByte2";
            this.lblByte2.Size = new System.Drawing.Size(35, 15);
            this.lblByte2.TabIndex = 2;
            this.lblByte2.Text = "byte2";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 393);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblByte2);
            this.Controls.Add(this.lblByte1);
            this.Controls.Add(this.lblChecksum);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtData);
            this.Name = "MainForm";
            this.Text = "CRC16 Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblChecksum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblByte1;
        private System.Windows.Forms.Label lblByte2;
    }
}

