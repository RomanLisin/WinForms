using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Clock
{
	public partial class FontDialog : Form
	{
		public FontDialog()
		{
			InitializeComponent();
			LoadFonts();
		}
		void LoadFonts()
		{
			string execution_path = Path.GetDirectoryName(Application.ExecutablePath);
            Console.WriteLine(execution_path);
			string fonts_path = $"{execution_path}\\..\\..\\Fonts";
			Directory.SetCurrentDirectory(fonts_path);
            Console.WriteLine(Directory.GetCurrentDirectory());
        }
	}
}
