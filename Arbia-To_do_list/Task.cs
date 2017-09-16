using System;
using System.Drawing;
using System.Windows.Forms;

using System.Collections.Generic;
using System.Threading.Tasks;
using System.IO;
using System.Collections.ObjectModel;

namespace Todolist 
{
	public class Task 
	{
	public Task () 
	{}
		// add task
	public void 
	add() 
	{
		Button addtask = new Button ();
		addtask.Text = " + ";
		addtask.Width = 60;
		addtask.Height = 50; 
		addtask.Left = 15;
		addtask.Top = 10;
		addtask.ImageAlign = ContentAlignment.MiddleRight;    
		addtask.TextAlign = ContentAlignment.MiddleLeft;
		addtask.FlatStyle = FlatStyle.Flat;
		addtask.Font = new Font (addtask.Font.FontFamily, 25);
		this.Controls.Add (addtask);
	}

	public void
	edit() 
		{
		;
		}

	public void
	consult() {}

	public void
	delete() {}
	}	
}

