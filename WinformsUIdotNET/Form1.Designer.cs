
namespace WinformsUIdotNET
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.panelSlideMenu = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnHelp = new System.Windows.Forms.Button();
			this.btnEqualizer = new System.Windows.Forms.Button();
			this.panelPlayListSubMenu = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.btnPlayList = new System.Windows.Forms.Button();
			this.panelMediaSubMenu = new System.Windows.Forms.Panel();
			this.button5 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.btnMedia = new System.Windows.Forms.Button();
			this.panelLogo = new System.Windows.Forms.Panel();
			this.panelChildForm = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panelSlideMenu.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panelPlayListSubMenu.SuspendLayout();
			this.panelMediaSubMenu.SuspendLayout();
			this.panelChildForm.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panelSlideMenu
			// 
			this.panelSlideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(17)))), ((int)(((byte)(7)))));
			this.panelSlideMenu.Controls.Add(this.panel1);
			this.panelSlideMenu.Controls.Add(this.panelMediaSubMenu);
			this.panelSlideMenu.Controls.Add(this.btnMedia);
			this.panelSlideMenu.Controls.Add(this.panelLogo);
			this.panelSlideMenu.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelSlideMenu.Location = new System.Drawing.Point(0, 0);
			this.panelSlideMenu.Name = "panelSlideMenu";
			this.panelSlideMenu.Size = new System.Drawing.Size(250, 553);
			this.panelSlideMenu.TabIndex = 0;
			// 
			// panel1
			// 
			this.panel1.AutoScroll = true;
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
			this.panel1.Controls.Add(this.btnHelp);
			this.panel1.Controls.Add(this.btnEqualizer);
			this.panel1.Controls.Add(this.panelPlayListSubMenu);
			this.panel1.Controls.Add(this.btnPlayList);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 254);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(250, 299);
			this.panel1.TabIndex = 2;
			// 
			// btnHelp
			// 
			this.btnHelp.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnHelp.FlatAppearance.BorderSize = 0;
			this.btnHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(98)))));
			this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnHelp.ForeColor = System.Drawing.SystemColors.Control;
			this.btnHelp.Location = new System.Drawing.Point(0, 210);
			this.btnHelp.Name = "btnHelp";
			this.btnHelp.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.btnHelp.Size = new System.Drawing.Size(250, 45);
			this.btnHelp.TabIndex = 3;
			this.btnHelp.Text = "Help";
			this.btnHelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnHelp.UseVisualStyleBackColor = true;
			this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
			// 
			// btnEqualizer
			// 
			this.btnEqualizer.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnEqualizer.FlatAppearance.BorderSize = 0;
			this.btnEqualizer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(98)))));
			this.btnEqualizer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEqualizer.ForeColor = System.Drawing.SystemColors.Control;
			this.btnEqualizer.Location = new System.Drawing.Point(0, 165);
			this.btnEqualizer.Name = "btnEqualizer";
			this.btnEqualizer.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.btnEqualizer.Size = new System.Drawing.Size(250, 45);
			this.btnEqualizer.TabIndex = 2;
			this.btnEqualizer.Text = "Equalizer";
			this.btnEqualizer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnEqualizer.UseVisualStyleBackColor = true;
			this.btnEqualizer.Click += new System.EventHandler(this.btnEqualizer_Click);
			// 
			// panelPlayListSubMenu
			// 
			this.panelPlayListSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
			this.panelPlayListSubMenu.Controls.Add(this.button1);
			this.panelPlayListSubMenu.Controls.Add(this.button6);
			this.panelPlayListSubMenu.Controls.Add(this.button7);
			this.panelPlayListSubMenu.Controls.Add(this.button8);
			this.panelPlayListSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelPlayListSubMenu.Location = new System.Drawing.Point(0, 45);
			this.panelPlayListSubMenu.Name = "panelPlayListSubMenu";
			this.panelPlayListSubMenu.Size = new System.Drawing.Size(250, 120);
			this.panelPlayListSubMenu.TabIndex = 1;
			// 
			// button1
			// 
			this.button1.Dock = System.Windows.Forms.DockStyle.Top;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.ForeColor = System.Drawing.SystemColors.Control;
			this.button1.Location = new System.Drawing.Point(0, 87);
			this.button1.Name = "button1";
			this.button1.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
			this.button1.Size = new System.Drawing.Size(250, 29);
			this.button1.TabIndex = 4;
			this.button1.Text = "button1";
			this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button6
			// 
			this.button6.Dock = System.Windows.Forms.DockStyle.Top;
			this.button6.FlatAppearance.BorderSize = 0;
			this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button6.ForeColor = System.Drawing.SystemColors.Control;
			this.button6.Location = new System.Drawing.Point(0, 58);
			this.button6.Name = "button6";
			this.button6.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
			this.button6.Size = new System.Drawing.Size(250, 29);
			this.button6.TabIndex = 3;
			this.button6.Text = "button6";
			this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// button7
			// 
			this.button7.Dock = System.Windows.Forms.DockStyle.Top;
			this.button7.FlatAppearance.BorderSize = 0;
			this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button7.ForeColor = System.Drawing.SystemColors.Control;
			this.button7.Location = new System.Drawing.Point(0, 29);
			this.button7.Name = "button7";
			this.button7.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
			this.button7.Size = new System.Drawing.Size(250, 29);
			this.button7.TabIndex = 2;
			this.button7.Text = "button7";
			this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// button8
			// 
			this.button8.Dock = System.Windows.Forms.DockStyle.Top;
			this.button8.FlatAppearance.BorderSize = 0;
			this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button8.ForeColor = System.Drawing.SystemColors.Control;
			this.button8.Location = new System.Drawing.Point(0, 0);
			this.button8.Name = "button8";
			this.button8.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
			this.button8.Size = new System.Drawing.Size(250, 29);
			this.button8.TabIndex = 1;
			this.button8.Text = "button8";
			this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button8.UseVisualStyleBackColor = true;
			this.button8.Click += new System.EventHandler(this.button8_Click);
			// 
			// btnPlayList
			// 
			this.btnPlayList.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnPlayList.FlatAppearance.BorderSize = 0;
			this.btnPlayList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(98)))));
			this.btnPlayList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPlayList.ForeColor = System.Drawing.SystemColors.Control;
			this.btnPlayList.Location = new System.Drawing.Point(0, 0);
			this.btnPlayList.Name = "btnPlayList";
			this.btnPlayList.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.btnPlayList.Size = new System.Drawing.Size(250, 45);
			this.btnPlayList.TabIndex = 1;
			this.btnPlayList.Text = "Play Lists";
			this.btnPlayList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnPlayList.UseVisualStyleBackColor = true;
			this.btnPlayList.Click += new System.EventHandler(this.btnPlayList_Click);
			// 
			// panelMediaSubMenu
			// 
			this.panelMediaSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
			this.panelMediaSubMenu.Controls.Add(this.button5);
			this.panelMediaSubMenu.Controls.Add(this.button4);
			this.panelMediaSubMenu.Controls.Add(this.button3);
			this.panelMediaSubMenu.Controls.Add(this.button2);
			this.panelMediaSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelMediaSubMenu.Location = new System.Drawing.Point(0, 134);
			this.panelMediaSubMenu.Name = "panelMediaSubMenu";
			this.panelMediaSubMenu.Size = new System.Drawing.Size(250, 120);
			this.panelMediaSubMenu.TabIndex = 1;
			// 
			// button5
			// 
			this.button5.Dock = System.Windows.Forms.DockStyle.Top;
			this.button5.FlatAppearance.BorderSize = 0;
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button5.ForeColor = System.Drawing.SystemColors.Control;
			this.button5.Location = new System.Drawing.Point(0, 87);
			this.button5.Name = "button5";
			this.button5.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
			this.button5.Size = new System.Drawing.Size(250, 29);
			this.button5.TabIndex = 4;
			this.button5.Text = "button5";
			this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button4
			// 
			this.button4.Dock = System.Windows.Forms.DockStyle.Top;
			this.button4.FlatAppearance.BorderSize = 0;
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.ForeColor = System.Drawing.SystemColors.Control;
			this.button4.Location = new System.Drawing.Point(0, 58);
			this.button4.Name = "button4";
			this.button4.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
			this.button4.Size = new System.Drawing.Size(250, 29);
			this.button4.TabIndex = 3;
			this.button4.Text = "button4";
			this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button3
			// 
			this.button3.Dock = System.Windows.Forms.DockStyle.Top;
			this.button3.FlatAppearance.BorderSize = 0;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.ForeColor = System.Drawing.SystemColors.Control;
			this.button3.Location = new System.Drawing.Point(0, 29);
			this.button3.Name = "button3";
			this.button3.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
			this.button3.Size = new System.Drawing.Size(250, 29);
			this.button3.TabIndex = 2;
			this.button3.Text = "button3";
			this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button2
			// 
			this.button2.Dock = System.Windows.Forms.DockStyle.Top;
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.ForeColor = System.Drawing.SystemColors.Control;
			this.button2.Location = new System.Drawing.Point(0, 0);
			this.button2.Name = "button2";
			this.button2.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
			this.button2.Size = new System.Drawing.Size(250, 29);
			this.button2.TabIndex = 1;
			this.button2.Text = "button2";
			this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// btnMedia
			// 
			this.btnMedia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
			this.btnMedia.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnMedia.FlatAppearance.BorderSize = 0;
			this.btnMedia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(98)))));
			this.btnMedia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMedia.ForeColor = System.Drawing.SystemColors.Control;
			this.btnMedia.Location = new System.Drawing.Point(0, 89);
			this.btnMedia.Name = "btnMedia";
			this.btnMedia.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.btnMedia.Size = new System.Drawing.Size(250, 45);
			this.btnMedia.TabIndex = 1;
			this.btnMedia.Text = "Media";
			this.btnMedia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnMedia.UseVisualStyleBackColor = false;
			this.btnMedia.Click += new System.EventHandler(this.btnMedia_Click);
			// 
			// panelLogo
			// 
			this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
			this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelLogo.Location = new System.Drawing.Point(0, 0);
			this.panelLogo.Name = "panelLogo";
			this.panelLogo.Size = new System.Drawing.Size(250, 89);
			this.panelLogo.TabIndex = 1;
			// 
			// panelChildForm
			// 
			this.panelChildForm.BackColor = System.Drawing.SystemColors.Desktop;
			this.panelChildForm.Controls.Add(this.pictureBox1);
			this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelChildForm.Location = new System.Drawing.Point(250, 0);
			this.panelChildForm.Name = "panelChildForm";
			this.panelChildForm.Size = new System.Drawing.Size(682, 553);
			this.panelChildForm.TabIndex = 1;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(290, 221);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(178, 107);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(932, 553);
			this.Controls.Add(this.panelChildForm);
			this.Controls.Add(this.panelSlideMenu);
			this.Name = "Form1";
			this.Text = "Form1";
			this.panelSlideMenu.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panelPlayListSubMenu.ResumeLayout(false);
			this.panelMediaSubMenu.ResumeLayout(false);
			this.panelChildForm.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelSlideMenu;
		private System.Windows.Forms.Panel panelMediaSubMenu;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button btnMedia;
		private System.Windows.Forms.Panel panelLogo;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panelPlayListSubMenu;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button btnPlayList;
		private System.Windows.Forms.Button btnHelp;
		private System.Windows.Forms.Button btnEqualizer;
		private System.Windows.Forms.Panel panelChildForm;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}

