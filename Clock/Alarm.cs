using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
	internal class Alarm
	{

		public DateTime Date { get; set; }
		public TimeSpan Time { get; set; }
		public Week Week { get; set; }
		public string Filename { get; set; }	
		public string Message { get; set; }
		public Alarm(DateTimePicker date, DateTimePicker time, CheckedListBox checkedDays,
			string filename ) //, string message)
		{
			Date = new DateTime();
			Time= new TimeSpan();
			
			Date = date.Value;
			Time = time.Value.TimeOfDay;
			Week = new Week(checkedDays);
			Filename = filename;
			//Message = message;
		}
		public string AlarmToString(AddAlarmDialog dialog)
		{
			string[] dateOfweek = {"Пн", "Вт", "Ср", "Чт", "Пт", "Сб", "Вс" };
			List<string> selectedDays = new List<string>();

			//List<string> list = dateOfweek.ToList();
			for(int i =0;i<dateOfweek.Length;i++)
			//for (int i =dateOfweek.Length-1; i>=0;i--)
			{
				if((Week.days & (1 <<i)) != 0)
				{
					//list.RemoveAt(i);
					selectedDays.Add(dateOfweek[i]);
				}
			}
			string selectedDateOfWeek = string.Join(", ", selectedDays);
			//dateOfweek  = list.ToArray();
			return $"{Date.ToString("yyyy-MM-dd")} {Time.ToString(@"hh\:mm")}, {selectedDateOfWeek} , {Filename}" ;
		}
	}
}
