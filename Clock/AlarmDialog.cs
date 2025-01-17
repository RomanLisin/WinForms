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
		private int currentYOffset = 100;

		public AlarmDialog()
		{
			InitializeComponent();
		}

		private void buttonAddAlarm_Click(object sender, EventArgs e)
		{
			index++;
			Font textFont = new Font("Microsoft Sans Serif", 18, FontStyle.Regular);

			Label label = new Label
			{
				Text = $"Alarm_{index}",
				Location = new Point(30, currentYOffset),
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
			this.Controls.Add(label);
			this.Controls.Add(checkBox);

			currentYOffset += 30;
		}
	}
}
