using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
	public partial class AlarmsForm : Form
	{
		AddAlarmDialog dialog;
		
		public ListBox Alarms
		{
			get => listBoxAlarms;
			set => listBoxAlarms = value;
		}

		public AlarmsForm()
		{
			InitializeComponent();
			LoadAlarms();
			dialog = new AddAlarmDialog();
		}

		public AlarmsForm(System.Windows.Forms.Form parent):this()
		{
			this.StartPosition= FormStartPosition.Manual;
			this.Location = new Point(parent.Location.X-this.Width,
				parent.Location.Y
				);
		}
		private void buttonAdd_Click(object sender, EventArgs e)
		{
			dialog.Location = new Point
				(
				this.Location.X + (this.Width - dialog.Width) / 2,
				this.Location.Y + (this.Height - dialog.Height) / 2
				);
			DialogResult result = dialog.ShowDialog();
			if(result==DialogResult.OK)
			{
				listBoxAlarms.Items.Add(new Alarm(dialog.Alarm));
			}
		}
		public void UpdateListBoxAlarm(string text)
		{
			listBoxAlarms.Items.Add(text);
		}

		private void listBoxAlarms_DoubleClick(object sender, EventArgs e)
		{
			if (listBoxAlarms.SelectedItem == null) return;
			dialog.Alarm = listBoxAlarms.SelectedItem as Alarm;
			if(dialog.ShowDialog()==DialogResult.OK)
			{
				listBoxAlarms.Items[listBoxAlarms.SelectedIndex] = dialog.Alarm;
			}
		}

		private void listBoxAlarms_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(listBoxAlarms.SelectedItem != null)
			labelAlarmInfo.Text = listBoxAlarms.SelectedItem.ToString();
		}
		public void SaveAlarms()
		{
			try
			{
				List<Alarm> alarms = listBoxAlarms.Items.Cast<Alarm>().ToList();
				string json = JsonConvert.SerializeObject(alarms, Formatting.Indented);
				string filePathJson = Path.Combine(Application.StartupPath, "Alarms.json");
				
				File.WriteAllText(filePathJson, json);
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error saving alarms: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void LoadAlarms()
		{
			try
			{
				string filePath = Path.Combine(Application.StartupPath, "Alarms.json");

				if (File.Exists(filePath))
				{
					string json = File.ReadAllText(filePath);
					List<Alarm> loadedAlarms = JsonConvert.DeserializeObject<List<Alarm>>(json);


					if (loadedAlarms != null)
					{
						
							listBoxAlarms.Items.Clear();

							foreach (Alarm alarm in loadedAlarms)
							{
								Alarms.Items.Add(alarm);
							}
						
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error loading alarms: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
