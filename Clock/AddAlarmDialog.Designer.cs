namespace Clock
{
	partial class AddAlarmDialog
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAlarmDialog));
			this.checkBoxUseDate = new System.Windows.Forms.CheckBox();
			this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
			this.dateTimePickerTime = new System.Windows.Forms.DateTimePicker();
			this.labelFilename = new System.Windows.Forms.Label();
			this.buttonOk = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.checkedListBoxWeekdays = new System.Windows.Forms.CheckedListBox();
			this.listBoxSound = new System.Windows.Forms.ListBox();
			this.labelMessage = new System.Windows.Forms.Label();
			this.richTextBoxMessage = new System.Windows.Forms.RichTextBox();
			this.buttonChooseFile = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// checkBoxUseDate
			// 
			this.checkBoxUseDate.AutoSize = true;
			this.checkBoxUseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.checkBoxUseDate.Location = new System.Drawing.Point(13, 13);
			this.checkBoxUseDate.Name = "checkBoxUseDate";
			this.checkBoxUseDate.Size = new System.Drawing.Size(117, 29);
			this.checkBoxUseDate.TabIndex = 0;
			this.checkBoxUseDate.Text = "Use date";
			this.checkBoxUseDate.UseVisualStyleBackColor = true;
			this.checkBoxUseDate.CheckedChanged += new System.EventHandler(this.checkBoxUseDate_CheckedChanged);
			// 
			// dateTimePickerDate
			// 
			this.dateTimePickerDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.dateTimePickerDate.CustomFormat = "yyyy.MM.dd";
			this.dateTimePickerDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.dateTimePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePickerDate.Location = new System.Drawing.Point(13, 54);
			this.dateTimePickerDate.Name = "dateTimePickerDate";
			this.dateTimePickerDate.Size = new System.Drawing.Size(149, 31);
			this.dateTimePickerDate.TabIndex = 1;
			// 
			// dateTimePickerTime
			// 
			this.dateTimePickerTime.CustomFormat = "HH:mm";
			this.dateTimePickerTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.dateTimePickerTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePickerTime.Location = new System.Drawing.Point(204, 54);
			this.dateTimePickerTime.Name = "dateTimePickerTime";
			this.dateTimePickerTime.ShowUpDown = true;
			this.dateTimePickerTime.Size = new System.Drawing.Size(149, 31);
			this.dateTimePickerTime.TabIndex = 2;
			// 
			// labelFilename
			// 
			this.labelFilename.AutoSize = true;
			this.labelFilename.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelFilename.Location = new System.Drawing.Point(12, 228);
			this.labelFilename.MaximumSize = new System.Drawing.Size(360, 0);
			this.labelFilename.Name = "labelFilename";
			this.labelFilename.Size = new System.Drawing.Size(75, 16);
			this.labelFilename.TabIndex = 4;
			this.labelFilename.Text = "Filename:";
			// 
			// buttonOk
			// 
			this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOk.Location = new System.Drawing.Point(195, 331);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new System.Drawing.Size(75, 23);
			this.buttonOk.TabIndex = 5;
			this.buttonOk.Text = "OK";
			this.buttonOk.UseVisualStyleBackColor = true;
			this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(278, 331);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 6;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// checkedListBoxWeekdays
			// 
			this.checkedListBoxWeekdays.CheckOnClick = true;
			this.checkedListBoxWeekdays.ColumnWidth = 46;
			this.checkedListBoxWeekdays.FormattingEnabled = true;
			this.checkedListBoxWeekdays.Items.AddRange(new object[] {
            "Пн",
            "Вт",
            "Ср",
            "Чт",
            "Пт",
            "Сб",
            "Вс"});
			this.checkedListBoxWeekdays.Location = new System.Drawing.Point(13, 110);
			this.checkedListBoxWeekdays.MultiColumn = true;
			this.checkedListBoxWeekdays.Name = "checkedListBoxWeekdays";
			this.checkedListBoxWeekdays.Size = new System.Drawing.Size(340, 19);
			this.checkedListBoxWeekdays.TabIndex = 3;
			// 
			// listBoxSound
			// 
			this.listBoxSound.FormattingEnabled = true;
			this.listBoxSound.Location = new System.Drawing.Point(116, 295);
			this.listBoxSound.Name = "listBoxSound";
			this.listBoxSound.Size = new System.Drawing.Size(237, 30);
			this.listBoxSound.TabIndex = 7;
			// 
			// labelMessage
			// 
			this.labelMessage.AutoSize = true;
			this.labelMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelMessage.Location = new System.Drawing.Point(9, 295);
			this.labelMessage.Name = "labelMessage";
			this.labelMessage.Size = new System.Drawing.Size(86, 20);
			this.labelMessage.TabIndex = 8;
			this.labelMessage.Text = "Message:";
			// 
			// richTextBoxMessage
			// 
			this.richTextBoxMessage.Location = new System.Drawing.Point(13, 149);
			this.richTextBoxMessage.Name = "richTextBoxMessage";
			this.richTextBoxMessage.Size = new System.Drawing.Size(340, 66);
			this.richTextBoxMessage.TabIndex = 9;
			this.richTextBoxMessage.Text = "";
			// 
			// buttonChooseFile
			// 
			this.buttonChooseFile.Location = new System.Drawing.Point(114, 331);
			this.buttonChooseFile.Name = "buttonChooseFile";
			this.buttonChooseFile.Size = new System.Drawing.Size(75, 23);
			this.buttonChooseFile.TabIndex = 11;
			this.buttonChooseFile.Text = "Обзор";
			this.buttonChooseFile.UseVisualStyleBackColor = true;
			this.buttonChooseFile.Click += new System.EventHandler(this.buttonChooseFile_Click);
			// 
			// AddAlarmDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(372, 366);
			this.Controls.Add(this.buttonChooseFile);
			this.Controls.Add(this.richTextBoxMessage);
			this.Controls.Add(this.labelMessage);
			this.Controls.Add(this.listBoxSound);
			this.Controls.Add(this.checkedListBoxWeekdays);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonOk);
			this.Controls.Add(this.labelFilename);
			this.Controls.Add(this.dateTimePickerTime);
			this.Controls.Add(this.dateTimePickerDate);
			this.Controls.Add(this.checkBoxUseDate);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "AddAlarmDialog";
			this.ShowInTaskbar = false;
			this.Text = "AddAlarmDialog";
			this.Load += new System.EventHandler(this.AddAlarmDialog_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckBox checkBoxUseDate;
		private System.Windows.Forms.DateTimePicker dateTimePickerDate;
		private System.Windows.Forms.DateTimePicker dateTimePickerTime;
		private System.Windows.Forms.Label labelFilename;
		private System.Windows.Forms.Button buttonOk;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.CheckedListBox checkedListBoxWeekdays;
		private System.Windows.Forms.ListBox listBoxSound;
		private System.Windows.Forms.Label labelMessage;
		private System.Windows.Forms.RichTextBox richTextBoxMessage;
		private System.Windows.Forms.Button buttonChooseFile;
	}
}