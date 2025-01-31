using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
	public partial class AddAlarmDialog : Form
	{
		
		public Alarm Alarm;
		OpenFileDialog openFile;
		//string wavPath = "C:\\Users\\rls\\source\\repos\\WindowsDevelopment\\WinForms\\Clock\\Sound";
		//string selectedSound;
		//bool isFirstShowAddAlarmDialog = true;

		//SoundPlayer soundPlayer;
		public AddAlarmDialog()
		{
			InitializeComponent();
			dateTimePickerDate.Enabled = false;
			this.StartPosition = FormStartPosition.Manual;
			Alarm = new Alarm();
			SetWeekDays();
			openFile = new OpenFileDialog();
			labelFilename.Height = 32;
		}

		void SetWeekDays()
		{
			bool[] days = Alarm.Week.ToArray();
			for(int i=0;i<checkedListBoxWeekdays.Items.Count;i++)
			{
				checkedListBoxWeekdays.SetItemChecked(i, days[i]);
			}
		}
		private void checkBoxUseDate_CheckedChanged(object sender, EventArgs e)
		{
			 dateTimePickerDate.Enabled = checkBoxUseDate.Checked;
			checkedListBoxWeekdays.Enabled =!checkBoxUseDate.Checked;
			
		}

		private void buttonOk_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
			Alarm.Date = dateTimePickerDate.Enabled ? dateTimePickerDate.Value : DateTime.MinValue;
			Alarm.Time = dateTimePickerTime.Value.TimeOfDay;

			Alarm.Week = new Week
				(
				checkedListBoxWeekdays.Items.Cast<object>().Select((item, index) => checkedListBoxWeekdays.GetItemChecked(index)).ToArray()
				);
			if (labelFilename.Text != "Filename" && labelFilename.Text != "")
			{
				Alarm.Filename = openFile.FileName;

			}
			else
			{
				MessageBox.Show(this, "Выберите звуковой файл", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.DialogResult = DialogResult.None;
			}
			Alarm.Message = richTextBoxMessage.Text;
		}

		private void AddAlarmDialog_Load(object sender, EventArgs e)
		{
			
		}

		private void buttonChooseFile_Click(object sender, EventArgs e)
		{
			if(openFile.ShowDialog()==DialogResult.OK)
			{
				labelFilename.Text = $"Filename:\n{openFile.FileName}";
			}
		}
	}
}
