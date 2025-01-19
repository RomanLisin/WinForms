using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
	public partial class AlarmDialog : Form
	{
		private int index = 0;
		private int currentYOffset = 0;
		protected TimeSelectDialog timeselectDialog;
		private Panel containerPanel;

		public AlarmDialog()
		{
			InitializeComponent();
		}

		private void buttonAddAlarm_Click(object sender, EventArgs e)
		{
			if (index != 9)
				{index++;
			timeselectDialog = new TimeSelectDialog();

				if (timeselectDialog.ShowDialog(this) == DialogResult.OK)
				{

					if (containerPanel == null)
					{
						containerPanel = new Panel
						{
							Location = new Point(30, 100),
							Size = new Size(250, 230),
							BorderStyle = BorderStyle.FixedSingle,
							AutoScroll = true
						};
						this.Controls.Add(containerPanel);
					}
					alarmAdd();
				}
			}

		}
		void alarmAdd()
		{
			Font textFont = new Font("Microsoft Sans Serif", 18, FontStyle.Regular);
			Label label = new Label
			{
				Text = $"Alarm_{index}",
				Location = new Point(30, currentYOffset == 30? 0:currentYOffset),
				AutoSize = true,
				Font = textFont
			};
			CheckBox checkBox = new CheckBox
			{
				Text = "On",
				Location = new Point(150, currentYOffset),
				AutoSize = true,
				Font = textFont
			};
			checkBox.CheckedChanged += (s, args) =>
			{
				if (checkBox.Checked)
					MessageBox.Show($"{label.Text} include", "Information");
				else
					MessageBox.Show($"{label.Text} include", "Information");
			};

			containerPanel.Controls.Add(label);
			containerPanel.Controls.Add(checkBox);

			
			if (currentYOffset > containerPanel.Height)
			{
				currentYOffset = 0;
				containerPanel.AutoScrollPosition = new Point(0, containerPanel.VerticalScroll.Maximum);
			}
			else  currentYOffset += 30;
		


		}
	}
}
