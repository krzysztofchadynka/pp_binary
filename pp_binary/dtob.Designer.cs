namespace Binary___pp
{
    partial class dtob
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
            this.dtob_convertPanel = new System.Windows.Forms.Panel();
            this.dtob_convert_valuesButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtob_binaryText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtob_decimalText = new System.Windows.Forms.TextBox();
            this.dtob_convertPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtob_convertPanel
            // 
            this.dtob_convertPanel.Controls.Add(this.dtob_convert_valuesButton);
            this.dtob_convertPanel.Controls.Add(this.label2);
            this.dtob_convertPanel.Controls.Add(this.dtob_binaryText);
            this.dtob_convertPanel.Controls.Add(this.label1);
            this.dtob_convertPanel.Controls.Add(this.dtob_decimalText);
            this.dtob_convertPanel.Location = new System.Drawing.Point(12, 5);
            this.dtob_convertPanel.Name = "dtob_convertPanel";
            this.dtob_convertPanel.Size = new System.Drawing.Size(342, 170);
            this.dtob_convertPanel.TabIndex = 5;
            this.dtob_convertPanel.Visible = false;
            // 
            // dtob_convert_valuesButton
            // 
            this.dtob_convert_valuesButton.Font = new System.Drawing.Font("Baskerville Old Face", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtob_convert_valuesButton.Location = new System.Drawing.Point(6, 107);
            this.dtob_convert_valuesButton.Name = "dtob_convert_valuesButton";
            this.dtob_convert_valuesButton.Size = new System.Drawing.Size(250, 48);
            this.dtob_convert_valuesButton.TabIndex = 4;
            this.dtob_convert_valuesButton.Text = "convert";
            this.dtob_convert_valuesButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Baskerville Old Face", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.Location = new System.Drawing.Point(3, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Binary";
            // 
            // dtob_binaryText
            // 
            this.dtob_binaryText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtob_binaryText.Location = new System.Drawing.Point(78, 64);
            this.dtob_binaryText.Name = "dtob_binaryText";
            this.dtob_binaryText.Size = new System.Drawing.Size(261, 26);
            this.dtob_binaryText.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Baskerville Old Face", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Decimal";
            // 
            // dtob_decimalText
            // 
            this.dtob_decimalText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtob_decimalText.Location = new System.Drawing.Point(78, 10);
            this.dtob_decimalText.Name = "dtob_decimalText";
            this.dtob_decimalText.Size = new System.Drawing.Size(261, 26);
            this.dtob_decimalText.TabIndex = 0;
            // 
            // dtob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 181);
            this.Controls.Add(this.dtob_convertPanel);
            this.Name = "dtob";
            this.Text = "dtob";
            this.dtob_convertPanel.ResumeLayout(false);
            this.dtob_convertPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel dtob_convertPanel;
        private System.Windows.Forms.Button dtob_convert_valuesButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox dtob_binaryText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dtob_decimalText;

    }
}