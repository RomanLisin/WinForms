using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Clock
{
	public partial class mainForm : Form
	{
		FontDialog fontDialog;
		public mainForm()
		{
			InitializeComponent();
			labelTime.BackColor = Color.AliceBlue;  // чтобы при изменении прозрачности lableTime отображалось лучше
			this.Location = new Point(Screen.PrimaryScreen.Bounds.Width - this.Width, 50);  // чтобы форма запускалась вправом верхнем углу, при этом Properties -> StartPosition -> Manual
			toolStripMenuItemShowControls.Checked = true;  // Work not correctly
			fontDialog = new FontDialog();
		}
		
		 void SetVisibility(bool visible)
		{
			checkBoxShowDate.Visible = visible;
			checkBoxShowWeekDay.Visible = visible;
			buttonHideControls.Visible = visible;
			this.FormBorderStyle = visible?	FormBorderStyle.FixedDialog:FormBorderStyle.None;
			this.ShowInTaskbar = visible;
			this.TransparencyKey = visible?Color.Empty:this.BackColor; // второй делает прозрачным
		}
		private void timer_Tick(object sender, EventArgs e)
		{
			// обработчик события - это самая обычная функция, которая неявно вызывается при возникновении определенного события  
			// у элемента интерфейса может быть множество событий и одно из них будет событием по умолчанию
			// для таймера событием по умолчанию является тик
			labelTime.Text = DateTime.Now.ToString("hh:mm:ss tt");  // , System.Globalization.CultureInfo.InvariantCulture); // если не включается
																	// labelTime.Text = DateTime.Now.ToString("HH:mm:ss");  // для 24-часового отображения
			if (checkBoxShowDate.Checked)
			{
				labelTime.Text += $"\n{DateTime.Now.ToString("yyyy.MM.dd")}";  // MM - большие это месяцы, mm - маленькие это минуты, при таком формате сортировка совпадает с сортировкой по имени, очень удобно использовать при резервном копировании

			}
			if (checkBoxShowWeekDay.Checked)
			{
				labelTime.Text += $"\n{DateTime.Now.DayOfWeek}";
			}
			notifyIcon.Text = $"{DateTime.Now.ToString("hh:mm tt")}\n{DateTime.Now.ToString("yyyy.MM.dd")}\n{DateTime.Now.DayOfWeek}";//DateTime.Now.ToString("hh:mm tt"); //labelTime.Text;  // чтобы при наведении курсора  в system tray в подсказке  отображалось время

		}

		private void buttonHideControls_Click(object sender, EventArgs e)
		{
			//SetVisibility(false); 
			toolStripMenuItemShowControls.Checked = false;
		}

		private void labelTime_DoubleClick(object sender, EventArgs e) 
		{
			//SetVisibility(true); 
			toolStripMenuItemShowControls.Checked = true;
		}

		private void toolStripMenuItemTopmost_CheckedChanged(object sender, EventArgs e)=>   // => rocketchip
			this.TopMost = toolStripMenuItemTopmost.Checked;

		private void toolStripMenuItemShowControls_CheckedChanged(object sender, EventArgs e) => SetVisibility(toolStripMenuItemShowControls.Checked);

		private void toolStripMenuItemShowDate_CheckedChanged(object sender, EventArgs e) =>
			checkBoxShowDate.Checked = toolStripMenuItemShowDate.Checked;
		

		private void checkBoxShowDate_CheckedChanged(object sender, EventArgs e) =>
			toolStripMenuItemShowDate.Checked = checkBoxShowDate.Checked;

		private void checkBoxShowWeekDay_CheckedChanged(object sender, EventArgs e)
		{
			toolStripMenuItemShowWeekday.Checked = checkBoxShowWeekDay.Checked;
		}

		private void toolStripMenuItemShowWeekday_CheckedChanged(object sender, EventArgs e)
		{
			checkBoxShowWeekDay.Checked = toolStripMenuItemShowWeekday.Checked;
		}

		private void toolStripMenuItemExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void toolStripMenuItemBackgroundColor_Click(object sender, EventArgs e)
		{
			colorDialog.Color = labelTime.BackColor;
			DialogResult result = colorDialog.ShowDialog(this);  // для того чтобы диалоговое окно было модальным по отношению к родительскому
			if (result == DialogResult.OK) labelTime.BackColor = colorDialog.Color;
		}

		private void toolStripMenuItemForegroundColor_Click(object sender, EventArgs e)
		{
			colorDialog.Color = labelTime.ForeColor;
			if (colorDialog.ShowDialog(this) == DialogResult.OK) labelTime.ForeColor = colorDialog.Color;
		}

		private void toolStripMenuItemChooseFont_Click(object sender, EventArgs e)
		{
			fontDialog.ShowDialog(this);
		}

		private void notifyIcon_DoubleClick(object sender, EventArgs e)
		{
			if(!this.TopMost)
			{
				this.TopMost = true;
				this.TopMost = false;
			}
		}

		private void toolStripMenuItemShowConsole_CheckedChanged(object sender, EventArgs e)
		{
			bool show = toolStripMenuItemShowConsole.Checked ? AllocConsole() : FreeConsole();
		}
		[DllImport("kernel32.dll")]
		static extern bool AllocConsole();
		[DllImport("kernel32.dll")]
		static extern bool FreeConsole();
	}
}
