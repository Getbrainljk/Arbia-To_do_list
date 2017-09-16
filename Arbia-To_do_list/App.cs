using System;
using System.Drawing;
using System.Windows.Forms;
	
namespace Todolist
{
	public class 
	App : Form
	{
		public App ()
		{
			Text = "To Do List - arbia nadir";
			Size = new Size (800, 500);
			CenterToScreen ();
			Task task = new Task ();
			task.add();
		}
		protected override bool 
		ProcessCmdKey(ref Message msg, Keys keyData) {
			if (keyData == Keys.Escape) {
				this.Close();
				return true;
			}
			return base.ProcessCmdKey(ref msg, keyData);
		}

		static void
		Main()
		{
			Application.Run(new App());
			
			
		}
	}

}


