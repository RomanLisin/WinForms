using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
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
							BorderStyle = BorderStyle.None,
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
			Font textFont = new Font("Microsoft Sans Serif", 14, FontStyle.Regular);

			Button addButton = new Button
			{
				Text = $"{(int)timeselectDialog.hours:D2}:{(int)timeselectDialog.minutes:D2}", //$"Alarm_{index}",
				Location = new Point(30, currentYOffset),
				FlatStyle = FlatStyle.Flat,
				BackColor = Color.Transparent,
				Size = new Size(120, 30),
				Font = textFont // new Font("Microsoft Sans Serif", 12, FontStyle.Regular)
			};
			addButton.FlatAppearance.BorderSize = 0; // убирает границу кнопки
			//Label label = new Label
			//{
			//	Text = $"Alarm_{index}",
			//	Location = new Point(30, currentYOffset == 30? 0:currentYOffset),
			//	AutoSize = true,
			//	Font = textFont
			//};
			CheckBox checkBox = new CheckBox
			{
				Text = "On",
				Location = new Point(160, currentYOffset),
				AutoSize = true,
				Font = textFont
			};
			checkBox.CheckedChanged += (s, args) =>
			{
				if (checkBox.Checked)
					MessageBox.Show($"{addButton.Text} include", "Information");
				else
					MessageBox.Show($"{addButton.Text} include", "Information");
			};
			Button removeButton = new Button
			{
				Text = "-",
				Location = new Point(0, currentYOffset),
				Size = new Size(30, 30),
				Font = textFont, //new Font("Microsoft Sans Serif", 12, FontStyle.Regular)
				Tag = index
			};

			removeButton.Click += (s, args) =>
			{
				containerPanel.Controls.Remove(addButton);
				containerPanel.Controls.Remove(checkBox);
				containerPanel.Controls.Remove(removeButton);

				RecalculatePositions();
			};


			containerPanel.Controls.Add(addButton);
			containerPanel.Controls.Add(checkBox);
			containerPanel.Controls.Add(removeButton);

			if (currentYOffset > containerPanel.Height)
			{
				currentYOffset = 0;
				containerPanel.AutoScrollPosition = new Point(0, containerPanel.VerticalScroll.Maximum);
			}
			else  currentYOffset += 30;
		


		}
		
		// метод для пересчета позиций элементов после удаления
		void RecalculatePositions()
		{
			currentYOffset = 0;

			foreach (Control control in containerPanel.Controls) //.OfType<Button>().ToList())
			{
				// обновляем позиции элементов по порядку
				control.Location = new Point(control.Location.X, currentYOffset);
				if (control is Button && control.Text == "-")
				{
					currentYOffset += 30; // увеличиваем отступ только после группы
				}

			}
		}

		public void CheckAlarmMatchesCurrentTime(string labelText)
		{
			//string currentTime = DateTime.Now.ToString("HH:mm");

			foreach (Control control in containerPanel.Controls)
			{
				if (control is Button button && button.Text == labelText) // currentTime)
				{
					MessageBox.Show($"Будильник {button.Text} сработал!", "Уведомление");

					// Дополнительно: можете воспроизвести звук или выполнить другое действие
					//PlayAlarmSound();
				}
			}
		}
		//private void PlayAlarmSound()
		//{
		//	try
		//	{
		//		string filePath = "Sound\\file_example_WAV_1MG.wav"; // Укажите путь к вашему звуковому файлу
		//		using (SoundPlayer player = new SoundPlayer(filePath))
		//		{
		//			player.Play();
		//		}
		//	}
		//	catch (Exception ex)
		//	{
		//		MessageBox.Show($"Ошибка воспроизведения звука: {ex.Message}", "Ошибка");
		//	}
		//}
	}
}
