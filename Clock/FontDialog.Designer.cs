namespace Clock
{
    partial class FontDialog
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
			this.comboBoxFonts = new System.Windows.Forms.ComboBox();
			this.labelChooseFont = new System.Windows.Forms.Label();
			this.labelFontSize = new System.Windows.Forms.Label();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.labelExample = new System.Windows.Forms.Label();
			this.buttonOk = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// comboBoxFonts
			// 
			this.comboBoxFonts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxFonts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.comboBoxFonts.FormattingEnabled = true;
			this.comboBoxFonts.Location = new System.Drawing.Point(25, 52);
			this.comboBoxFonts.Name = "comboBoxFonts";
			this.comboBoxFonts.Size = new System.Drawing.Size(334, 32);
			this.comboBoxFonts.TabIndex = 0;
			// 
			// labelChooseFont
			// 
			this.labelChooseFont.AutoSize = true;
			this.labelChooseFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelChooseFont.Location = new System.Drawing.Point(30, 18);
			this.labelChooseFont.Name = "labelChooseFont";
			this.labelChooseFont.Size = new System.Drawing.Size(144, 20);
			this.labelChooseFont.TabIndex = 1;
			this.labelChooseFont.Text = "Выберите шрифт";
			// 
			// labelFontSize
			// 
			this.labelFontSize.AutoSize = true;
			this.labelFontSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelFontSize.Location = new System.Drawing.Point(388, 18);
			this.labelFontSize.Name = "labelFontSize";
			this.labelFontSize.Size = new System.Drawing.Size(133, 20);
			this.labelFontSize.TabIndex = 2;
			this.labelFontSize.Text = "Размер шрифта";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.numericUpDown1.Location = new System.Drawing.Point(416, 55);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(105, 29);
			this.numericUpDown1.TabIndex = 3;
			this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// labelExample
			// 
			this.labelExample.AutoSize = true;
			this.labelExample.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelExample.Location = new System.Drawing.Point(16, 138);
			this.labelExample.Name = "labelExample";
			this.labelExample.Size = new System.Drawing.Size(191, 51);
			this.labelExample.TabIndex = 4;
			this.labelExample.Text = "Example";
			// 
			// buttonOk
			// 
			this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOk.Location = new System.Drawing.Point(305, 204);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new System.Drawing.Size(89, 32);
			this.buttonOk.TabIndex = 5;
			this.buttonOk.Text = "OK";
			this.buttonOk.UseVisualStyleBackColor = true;
			// 
			// buttonCancel
			// 
			this.buttonCancel.Location = new System.Drawing.Point(418, 204);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(89, 32);
			this.buttonCancel.TabIndex = 6;
			this.buttonCancel.Text = "button2";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// FontDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(537, 259);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonOk);
			this.Controls.Add(this.labelExample);
			this.Controls.Add(this.numericUpDown1);
			this.Controls.Add(this.labelFontSize);
			this.Controls.Add(this.labelChooseFont);
			this.Controls.Add(this.comboBoxFonts);
			this.Name = "FontDialog";
			this.Text = "Choose clock font";
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.ComboBox comboBoxFonts;
		private System.Windows.Forms.Label labelChooseFont;
		private System.Windows.Forms.Label labelFontSize;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.Label labelExample;
		private System.Windows.Forms.Button buttonOk;
		private System.Windows.Forms.Button buttonCancel;
	}
}