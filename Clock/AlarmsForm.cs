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
	public partial class AlarmsForm : Form
	{
		AddAlarmDialog dialog;
		public int selectedIndex { get; set; }
		public AlarmsForm()
		{
			InitializeComponent();
			dialog = new AddAlarmDialog(this);
		}
		private void buttonAdd_Click(object sender, EventArgs e)
		{
			dialog.LoadSource = "AddClick";
			dialog.ShowDialog();
		}
		public void UpdateListBoxAlarm(string text)
		{
			listBoxAlarms.Items.Add(text);
			this.Update();
		}

		private void listBoxAlarms_DoubleClick(object sender, EventArgs e)
		{
			selectedIndex = listBoxAlarms.SelectedIndex;
		}
	}
}
