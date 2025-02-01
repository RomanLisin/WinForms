using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
	public class Week
	{
		static readonly string[] DAY_NAMES = new string[] { "Пn", "Вт", "Ср", "Чт", "Пт", "Сб", "Вс" };

		[JsonProperty]  // позволяет сериализовать приватное поле
		private byte days;

		public byte Days
		{
			get => days;
			set => days = value;
		}
		public Week()
		{
			days = 0;
		}
		public Week(byte days =127)
		{
			this.days = days;
		}
		public Week(bool[] days)
		{
			for(byte i =0;i < days.Length;i++)
			{
				if (days[i])
				{
					this.days |= (byte)(1 << i);
				}
			}
		}
		public Week(Week other)
		{
			this.days = other.days;
		}
		public bool[] ToArray()
		{
			bool[] selectedDays = new bool[7];
			for(byte i=0; i<selectedDays.Length;i++)
			{
				selectedDays[i] = (days & (byte)(1 << i)) != 0;
			}
			return selectedDays;
		}
		public override string ToString()
		{
			if (days == 127) return "Каждый день";
			if (days == 0) return "Ни одного дня";
			if (days == 31) return "Только в рабочие дни";
			if (days == 96) return "Только в выходные";
			string dayNames = "";
			for(byte i=0;i<DAY_NAMES.Length;i++)
			{
				if ((days & (byte)(1 << i)) != 0) dayNames += $"{ DAY_NAMES[i]}, ";
			}
			return dayNames.TrimEnd(',',' ');
		}

	}
}
