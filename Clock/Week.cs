using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
	internal class Week
	{
		public byte days { get; set; }

		public Week(CheckedListBox checkedListBox)
		{
			this.days = 0;
			for (int i =0;i < checkedListBox.Items.Count;i++)
			{
				this.days |= (byte)(1<<i); // устанавливаем соответствующий бит
			}
		}
	}
}
