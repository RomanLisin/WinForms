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
		string wavPath = "C:\\Users\\rls\\source\\repos\\WindowsDevelopment\\WinForms\\Clock\\Sound";
		string selectedSound;
		bool isFirstShowAddAlarmDialog = true;

		SoundPlayer soundPlayer;
		public AddAlarmDialog()
		{
			InitializeComponent();
			dateTimePickerDate.Enabled = false;
		}

		
		private void checkBoxUseDate_CheckedChanged(object sender, EventArgs e)
		{
			 dateTimePickerDate.Enabled = checkBoxUseDate.Checked;
			checkedListBoxWeekdays.Enabled =!checkBoxUseDate.Checked;
		}

		private void buttonOk_Click(object sender, EventArgs e)
		{
			Alarm alarm = new Alarm(dateTimePickerDate, dateTimePickerTime, checkedListBoxWeekdays,
				selectedSound);
			if (sender is AlarmsForm alarmsForm)
			{
			 alarmsForm.UpdateListBoxAlarm(alarm.AlarmToString());
			}

			if (listBoxSound.SelectedItems == null)
			{
				MessageBox.Show("Please select a sound from the list.");
				return;
			}
			selectedSound = listBoxSound.Text;
			string filePath = $"{wavPath}\\{selectedSound}.wav";

			if(!File.Exists(filePath))
			{
				MessageBox.Show("The selected file does not exists");
				return;
			}
			soundPlayer.SoundLocation = filePath;

		}

		private void AddAlarmDialog_Load(object sender, EventArgs e)
		{
			if (isFirstShowAddAlarmDialog) 
			{ 
			UpdateData(); 
			 isFirstShowAddAlarmDialog=false;
			}
		}
		private void UpdateData()
		{
			try
			{
				if (Directory.Exists(wavPath))
				{
					string[] wavFiles = Directory.GetFiles(wavPath, "*.wav");
					foreach (string wavfile in wavFiles)
					{
						string wavName = Path.GetFileNameWithoutExtension(wavfile);
						listBoxSound.Items.Add(wavName);
					}
				}
				else
				{
					MessageBox.Show("The specified directory does not exist.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"An error occurred: {ex.Message}");
			}
		}

	
	}
}
