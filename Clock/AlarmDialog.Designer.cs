namespace Clock
{
	partial class AlarmDialog
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlarmDialog));
			this.labelAlarms = new System.Windows.Forms.Label();
			this.buttonAddAlarm = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// labelAlarms
			// 
			this.labelAlarms.AutoSize = true;
			this.labelAlarms.CausesValidation = false;
			this.labelAlarms.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelAlarms.Location = new System.Drawing.Point(30, 31);
			this.labelAlarms.Name = "labelAlarms";
			this.labelAlarms.Size = new System.Drawing.Size(157, 51);
			this.labelAlarms.TabIndex = 0;
			this.labelAlarms.Text = "Alarms";
			// 
			// buttonAddAlarm
			// 
			this.buttonAddAlarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonAddAlarm.Location = new System.Drawing.Point(225, 31);
			this.buttonAddAlarm.Name = "buttonAddAlarm";
			this.buttonAddAlarm.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.buttonAddAlarm.Size = new System.Drawing.Size(59, 51);
			this.buttonAddAlarm.TabIndex = 1;
			this.buttonAddAlarm.Text = "+";
			this.buttonAddAlarm.UseVisualStyleBackColor = true;
			this.buttonAddAlarm.Click += new System.EventHandler(this.buttonAddAlarm_Click);
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.Location = new System.Drawing.Point(310, 31);
			this.button1.Name = "button1";
			this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.button1.Size = new System.Drawing.Size(59, 51);
			this.button1.TabIndex = 2;
			this.button1.Text = "-";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// AlarmDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(392, 385);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.buttonAddAlarm);
			this.Controls.Add(this.labelAlarms);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "AlarmDialog";
			this.Text = "Set alarms";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelAlarms;
		private System.Windows.Forms.Button buttonAddAlarm;
		private System.Windows.Forms.Button button1;
	}
}