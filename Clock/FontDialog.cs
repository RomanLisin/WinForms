﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Text;
using System.Linq.Expressions;  // for PrivateFontCollection

namespace Clock
{
	public partial class FontDialog : Form
	{
		string execution_path = ""; 
			string fonts_path = "";
		public FontDialog()
		{
			InitializeComponent();
			execution_path = Path.GetDirectoryName(Application.ExecutablePath);
			fonts_path = $"{execution_path}\\..\\..\\Fonts";
			LoadFonts();
		}
		void LoadFonts()
		{
            Console.WriteLine(execution_path);
			//Directory.SetCurrentDirectory(fonts_path);
   //         Console.WriteLine(Directory.GetCurrentDirectory());

			comboBoxFonts.Items.AddRange(GetFontsFromDirectory(fonts_path,"*.ttf"));
			comboBoxFonts.Items.AddRange(GetFontsFromDirectory(fonts_path,"*.otf"));
			comboBoxFonts.SelectedIndex = 0; // для выбора первого шрифта
        }
		string[] GetFontsFromDirectory(string directory, string format)
		{
			string[] fonts = Directory.GetFiles(directory, format);
			for (int i = 0; i<fonts.Length;i++)
			{
				fonts[i] = fonts[i].Split('\\').Last();
			}
			return fonts;

		}

		private void comboBoxFonts_SelectedIndexChanged(object sender, EventArgs e)
		{
			PrivateFontCollection pfc = new PrivateFontCollection();
			pfc.AddFontFile($"{fonts_path}\\{comboBoxFonts.SelectedItem}");
			labelExample.Font = new Font(pfc.Families[0], Convert.ToInt32(numericUpDownFontSize.Value));
		}
	}
}
