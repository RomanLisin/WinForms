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
	public partial class TimeSelectDialog : Form
	{
		public decimal hours = 0;
		public decimal minutes = 0;
		public TimeSelectDialog()
		{
			InitializeComponent();

		}


		private void buttonSet_Click(object sender, EventArgs e)
		{
			hours = numericUpDownHours.Value;
			minutes = numericUpDownMinuts.Value;
		}
	}
	
}
