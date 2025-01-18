namespace Clock
{
	partial class TimeSelectDialog
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimeSelectDialog));
			this.numericUpDownMinuts = new System.Windows.Forms.NumericUpDown();
			this.labelHours = new System.Windows.Forms.Label();
			this.labelMinutes = new System.Windows.Forms.Label();
			this.buttonSet = new System.Windows.Forms.Button();
			this.numericUpDownHours = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinuts)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownHours)).BeginInit();
			this.SuspendLayout();
			// 
			// numericUpDownMinuts
			// 
			this.numericUpDownMinuts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.numericUpDownMinuts.Location = new System.Drawing.Point(132, 82);
			this.numericUpDownMinuts.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
			this.numericUpDownMinuts.Name = "numericUpDownMinuts";
			this.numericUpDownMinuts.Size = new System.Drawing.Size(54, 29);
			this.numericUpDownMinuts.TabIndex = 1;
			this.numericUpDownMinuts.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// labelHours
			// 
			this.labelHours.AutoSize = true;
			this.labelHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelHours.Location = new System.Drawing.Point(37, 45);
			this.labelHours.Name = "labelHours";
			this.labelHours.Size = new System.Drawing.Size(61, 24);
			this.labelHours.TabIndex = 2;
			this.labelHours.Text = "Hours";
			// 
			// labelMinutes
			// 
			this.labelMinutes.AutoSize = true;
			this.labelMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelMinutes.Location = new System.Drawing.Point(128, 45);
			this.labelMinutes.Name = "labelMinutes";
			this.labelMinutes.Size = new System.Drawing.Size(76, 24);
			this.labelMinutes.TabIndex = 3;
			this.labelMinutes.Text = "Minutеs";
			// 
			// buttonSet
			// 
			this.buttonSet.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonSet.Location = new System.Drawing.Point(80, 145);
			this.buttonSet.Name = "buttonSet";
			this.buttonSet.Size = new System.Drawing.Size(70, 36);
			this.buttonSet.TabIndex = 4;
			this.buttonSet.Text = "Set";
			this.buttonSet.UseVisualStyleBackColor = true;
			this.buttonSet.Click += new System.EventHandler(this.buttonSet_Click);
			// 
			// numericUpDownHours
			// 
			this.numericUpDownHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.numericUpDownHours.Location = new System.Drawing.Point(41, 82);
			this.numericUpDownHours.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
			this.numericUpDownHours.Name = "numericUpDownHours";
			this.numericUpDownHours.Size = new System.Drawing.Size(54, 29);
			this.numericUpDownHours.TabIndex = 5;
			this.numericUpDownHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// TimeSelectDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(233, 215);
			this.Controls.Add(this.numericUpDownHours);
			this.Controls.Add(this.buttonSet);
			this.Controls.Add(this.labelMinutes);
			this.Controls.Add(this.labelHours);
			this.Controls.Add(this.numericUpDownMinuts);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "TimeSelectDialog";
			this.Text = "Choose alarm time";
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinuts)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownHours)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.NumericUpDown numericUpDownMinuts;
		private System.Windows.Forms.Label labelHours;
		private System.Windows.Forms.Label labelMinutes;
		private System.Windows.Forms.Button buttonSet;
		private System.Windows.Forms.NumericUpDown numericUpDownHours;
	}
}