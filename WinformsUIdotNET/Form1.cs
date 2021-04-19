using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformsUIdotNET
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			CustomizeDesign();
		}
		private void CustomizeDesign()
		{
			panelMediaSubMenu.Visible = false;
			panelPlayListSubMenu.Visible = false;
		}
		private void hideSubMenu()
		{
			if(panelMediaSubMenu.Visible == true)
			{
				panelMediaSubMenu.Visible = false;
			}
			if (panelPlayListSubMenu.Visible == true)
			{
				panelPlayListSubMenu.Visible = false;
			}
			
		}

		private void showSubMenu(Panel SubMenu)
		{
			if(SubMenu.Visible == false)
			{
				hideSubMenu();
				SubMenu.Visible = true;
			}
			else
			{
				SubMenu.Visible = false;
			}
		}

		private void btnMedia_Click(object sender, EventArgs e)
		{
			showSubMenu(panelMediaSubMenu);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			openChildForm(new Form2());
			//your code...
			hideSubMenu();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			//your code...
			hideSubMenu();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			//your code...
			hideSubMenu();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			//your code...
			hideSubMenu();
		}

		private void button8_Click(object sender, EventArgs e)
		{
			//your code...
			hideSubMenu();
		}

		private void button7_Click(object sender, EventArgs e)
		{
			//your code...
			hideSubMenu();
		}

		private void button6_Click(object sender, EventArgs e)
		{
			//your code...
			hideSubMenu();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			//your code...
			hideSubMenu();
		}

		private void btnPlayList_Click(object sender, EventArgs e)
		{
			showSubMenu(panelPlayListSubMenu);

		}

		#region Equalizer
		private void btnEqualizer_Click(object sender, EventArgs e)
		{
			//your code...
			hideSubMenu();
		}
		#endregion

		#region Help
		private void btnHelp_Click(object sender, EventArgs e)
		{
			//your code...
			hideSubMenu();
		}
		#endregion

		private Form activeForm = null;
		private void openChildForm(Form childForm)
		{
			if(activeForm != null)
			{
				activeForm.Close();
			}
			activeForm = childForm;
			childForm.TopLevel = false;
			childForm.FormBorderStyle = FormBorderStyle.None;
			childForm.Dock = DockStyle.Fill;
			panelChildForm.Controls.Add(childForm);
			panelChildForm.Tag = childForm;
			childForm.BringToFront();
			childForm.Show();
		}
	}
}
