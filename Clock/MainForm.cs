using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;  // DllImport
using System.IO;                       // Directory
using Microsoft.Win32;

namespace Clock
{
	public partial class mainForm : Form
	{
		FontDialog fontDialog;
		public AlarmsForm alarmForm;
		
		public mainForm()
		{
			InitializeComponent();
			labelTime.BackColor = Color.AliceBlue;  // чтобы при изменении прозрачности lableTime отображалось лучше
			this.Location = new Point(Screen.PrimaryScreen.Bounds.Width - this.Width, 50);  // чтобы форма запускалась вправом верхнем углу, при этом Properties -> StartPosition -> Manual
			toolStripMenuItemShowControls.Checked = true;  // Work not correctly
			toolStripMenuItemShowConsole.Checked = true;

			//fontDialog = new FontDialog();
            Console.WriteLine(Directory.GetCurrentDirectory());
			LoadSettings();
			if(fontDialog== null) fontDialog = new FontDialog();
			alarmForm = new AlarmsForm();
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

		void LoadSettings()
		{
			StreamReader sr = null;
			try
			{
				sr = new StreamReader($"{Path.GetDirectoryName(Application.ExecutablePath)}\\..\\..\\Settings.ini");
				toolStripMenuItemTopmost.Checked = Boolean.Parse(sr.ReadLine());
				toolStripMenuItemShowControls.Checked = Boolean.Parse(sr.ReadLine());
				toolStripMenuItemShowConsole.Checked = Boolean.Parse(sr.ReadLine());
				toolStripMenuItemShowDate.Checked = Boolean.Parse(sr.ReadLine());
				toolStripMenuItemShowWeekday.Checked = Boolean.Parse(sr.ReadLine());
				string fontname = sr.ReadLine();
				float fontsize = (float)Convert.ToDouble(sr.ReadLine());
				labelTime.BackColor = Color.FromArgb(Convert.ToInt32(sr.ReadLine()));
				labelTime.ForeColor = Color.FromArgb(Convert.ToInt32(sr.ReadLine()));
				sr.Close();
				fontDialog = new FontDialog(fontname, fontsize);
				labelTime.Font = (Font)fontDialog.Font;
			}
			catch (Exception ex)
			{

				MessageBox.Show(this, ex.Message, "In loadSetting()", MessageBoxButtons.OK, MessageBoxIcon.Error);
				MessageBox.Show(this, ex.ToString(), "In loadSetting()", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		void SaveSettings()
		{
			StreamWriter sw = 
				new StreamWriter($"{Path.GetDirectoryName(Application.ExecutablePath)}\\..\\..\\Settings.ini");
			sw.WriteLine($"{toolStripMenuItemTopmost.Checked}");
			sw.WriteLine($"{toolStripMenuItemShowControls.Checked}");
			sw.WriteLine($"{toolStripMenuItemShowConsole.Checked}");
			sw.WriteLine($"{toolStripMenuItemShowDate.Checked}");
			sw.WriteLine($"{toolStripMenuItemShowWeekday.Checked}");
			sw.WriteLine($"{fontDialog.FontFilename}");
			sw.WriteLine($"{labelTime.Font.Size}");
			sw.WriteLine($"{labelTime.BackColor.ToArgb()}");
			sw.WriteLine($"{labelTime.ForeColor.ToArgb()}");
			sw.Close();
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
			if(fontDialog.ShowDialog(this)==DialogResult.OK)
			{
				labelTime.Font = fontDialog.Font;
			}
		}

		// для отображения часов по двойному клику в трее
		private void notifyIcon_DoubleClick(object sender, EventArgs e)
		{
			if(!this.TopMost)
			{
				this.TopMost = true;
				this.TopMost = false;
			}
		}

		//
		private void toolStripMenuItemShowConsole_CheckedChanged(object sender, EventArgs e)
		{
			bool show = toolStripMenuItemShowConsole.Checked ? AllocConsole() : FreeConsole();
		}
		// ******************************************************************************************************
		// ПЕРЕТАСКИВАНИЕ НАЖАТОЙ НА LABEL ЛЕВОЙ КНОПКОЙ МЫШИ 
		// импорт методов SendMessege и ReleaseCapture из user32.dll
		[DllImport("user32.dll")]
		private static extern int SendMessage(IntPtr hWnd, int Msg, int  wParam, int lParam);

		[DllImport("user32.dll")]
		private static extern bool ReleaseCapture();

		private const int WM_NCLBUTTONDOWN = 0xA1; // message - left button down
		private const int HTCAPTION = 0x2;        // message - window caption
		private void labelTime_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				// освобождаем захват мыши и отправляем сообщение окну
				ReleaseCapture();
				SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
			}
		}
		// ******************************************************************************************************

		[DllImport("kernel32.dll")]
		static extern bool AllocConsole();
		[DllImport("kernel32.dll")]
		static extern bool FreeConsole();

		private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			SaveSettings();
		}

		private void toolStripMenuItemLoadOnWindowsStartup_CheckedChanged(object sender, EventArgs e)
		{
			string key_name = "Clock_VPD_311";
			RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
			if (toolStripMenuItemLoadOnWindowsStartup.Checked) key.SetValue(key_name, Application.ExecutablePath);
			else key.DeleteValue(key_name, false);  // false - обозначает throwOnMissingValue, если нет удаляемого значение  бросает исключение
			key.Dispose();  // высвобождает ресурсы
		}

		private void toolStripMenuItemAlarms_Click(object sender, EventArgs e)
		{
			alarmForm.ShowDialog();
		}

	}

}
