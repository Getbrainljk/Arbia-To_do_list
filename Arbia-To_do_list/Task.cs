using System;
using System.Drawing;
using System.Windows.Forms;

namespace Todolist
{
	public class Task : App
	{
		public Task ()
		{
			add ();	
		}
		// add task
		public void add()
		{
			Button addtask = new Button ();
			addtask.Text = " + ";
			addtask.Width = 60;
			addtask.Height = 50; 
			addtask.Left = 15;
			addtask.Top = 10;
			this.Controls.Add (addtask);
			addtask.ImageAlign = ContentAlignment.MiddleRight;    
			addtask.TextAlign = ContentAlignment.MiddleLeft;
			addtask.FlatStyle = FlatStyle.Flat;
			addtask.Font = new Font (addtask.Font.FontFamily, 25);
		}
		public void edit()
			{}
		public void consult()
			{}
		public void delete()
			{}
	}	
}

