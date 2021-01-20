namespace ebshseubhfhisb
{
	// Token: 0x02000002 RID: 2
	public partial class ebshseubhfhisb : global::System.Windows.Forms.Form
	{
		// Token: 0x0600002F RID: 47
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000030 RID: 48
		private void InitializeComponent()
		{
			this.backgroundWorker1 = new global::System.ComponentModel.BackgroundWorker();
			this.checkBox1 = new global::System.Windows.Forms.CheckBox();
			this.checkBox3 = new global::System.Windows.Forms.CheckBox();
			this.checkBox4 = new global::System.Windows.Forms.CheckBox();
			this.checkBox5 = new global::System.Windows.Forms.CheckBox();
			this.checkBox6 = new global::System.Windows.Forms.CheckBox();
			this.txtConsole = new global::System.Windows.Forms.TextBox();
			this.lblGameRunning = new global::System.Windows.Forms.Label();
			this.lblZombiesLeft = new global::System.Windows.Forms.Label();
			this.btnOnOff = new global::System.Windows.Forms.Button();
			this.checkBox7 = new global::System.Windows.Forms.CheckBox();
			this.checkBox8 = new global::System.Windows.Forms.CheckBox();
			this.trackBar1 = new global::System.Windows.Forms.TrackBar();
			this.label1 = new global::System.Windows.Forms.Label();
			this.numericUpDown1 = new global::System.Windows.Forms.NumericUpDown();
			this.label2 = new global::System.Windows.Forms.Label();
			this.trackBar2 = new global::System.Windows.Forms.TrackBar();
			this.numericUpDown2 = new global::System.Windows.Forms.NumericUpDown();
			this.label3 = new global::System.Windows.Forms.Label();
			this.trackBar3 = new global::System.Windows.Forms.TrackBar();
			this.numericUpDown3 = new global::System.Windows.Forms.NumericUpDown();
			this.numericUpDown4 = new global::System.Windows.Forms.NumericUpDown();
			this.trackBar4 = new global::System.Windows.Forms.TrackBar();
			this.label4 = new global::System.Windows.Forms.Label();
			this.numericUpDown5 = new global::System.Windows.Forms.NumericUpDown();
			this.trackBar5 = new global::System.Windows.Forms.TrackBar();
			this.label5 = new global::System.Windows.Forms.Label();
			this.numericUpDown6 = new global::System.Windows.Forms.NumericUpDown();
			this.trackBar6 = new global::System.Windows.Forms.TrackBar();
			this.numericUpDown7 = new global::System.Windows.Forms.NumericUpDown();
			this.trackBar7 = new global::System.Windows.Forms.TrackBar();
			this.label6 = new global::System.Windows.Forms.Label();
			this.label7 = new global::System.Windows.Forms.Label();
			this.checkBox2 = new global::System.Windows.Forms.CheckBox();
			this.checkBox9 = new global::System.Windows.Forms.CheckBox();
			this.checkBox116 = new global::System.Windows.Forms.CheckBox();
			((global::System.ComponentModel.ISupportInitialize)this.trackBar1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDown1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.trackBar2).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDown2).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.trackBar3).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDown3).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDown4).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.trackBar4).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDown5).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.trackBar5).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDown6).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.trackBar6).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDown7).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.trackBar7).BeginInit();
			base.SuspendLayout();
			this.backgroundWorker1.DoWork += new global::System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new global::System.Drawing.Point(12, 12);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new global::System.Drawing.Size(76, 17);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "God Mode";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.CheckedChanged += new global::System.EventHandler(this.checkBox1_CheckedChanged);
			this.checkBox3.AutoSize = true;
			this.checkBox3.Location = new global::System.Drawing.Point(119, 12);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new global::System.Drawing.Size(124, 17);
			this.checkBox3.TabIndex = 2;
			this.checkBox3.Text = "Infinite Ammo (SELF)";
			this.checkBox3.UseVisualStyleBackColor = true;
			this.checkBox3.CheckedChanged += new global::System.EventHandler(this.checkBox3_CheckedChanged);
			this.checkBox4.AutoSize = true;
			this.checkBox4.Location = new global::System.Drawing.Point(12, 39);
			this.checkBox4.Name = "checkBox4";
			this.checkBox4.Size = new global::System.Drawing.Size(65, 17);
			this.checkBox4.TabIndex = 3;
			this.checkBox4.Text = "Insta Kill";
			this.checkBox4.UseVisualStyleBackColor = true;
			this.checkBox4.CheckedChanged += new global::System.EventHandler(this.checkBox4_CheckedChanged);
			this.checkBox5.AutoSize = true;
			this.checkBox5.Location = new global::System.Drawing.Point(39, 164);
			this.checkBox5.Name = "checkBox5";
			this.checkBox5.Size = new global::System.Drawing.Size(132, 17);
			this.checkBox5.TabIndex = 4;
			this.checkBox5.Text = "TP Zombies To Cursor";
			this.checkBox5.UseVisualStyleBackColor = true;
			this.checkBox5.CheckedChanged += new global::System.EventHandler(this.checkBox5_CheckedChanged);
			this.checkBox6.AutoSize = true;
			this.checkBox6.Location = new global::System.Drawing.Point(441, 89);
			this.checkBox6.Name = "checkBox6";
			this.checkBox6.Size = new global::System.Drawing.Size(93, 17);
			this.checkBox6.TabIndex = 5;
			this.checkBox6.Text = "Infrared Vision";
			this.checkBox6.UseVisualStyleBackColor = true;
			this.checkBox6.Visible = false;
			this.txtConsole.Location = new global::System.Drawing.Point(5, 279);
			this.txtConsole.Multiline = true;
			this.txtConsole.Name = "txtConsole";
			this.txtConsole.ReadOnly = true;
			this.txtConsole.ScrollBars = global::System.Windows.Forms.ScrollBars.Vertical;
			this.txtConsole.Size = new global::System.Drawing.Size(720, 154);
			this.txtConsole.TabIndex = 6;
			this.txtConsole.TextChanged += new global::System.EventHandler(this.txtConsole_TextChanged);
			this.lblGameRunning.AutoSize = true;
			this.lblGameRunning.ForeColor = global::System.Drawing.Color.Red;
			this.lblGameRunning.Location = new global::System.Drawing.Point(9, 263);
			this.lblGameRunning.Name = "lblGameRunning";
			this.lblGameRunning.Size = new global::System.Drawing.Size(104, 13);
			this.lblGameRunning.TabIndex = 7;
			this.lblGameRunning.Text = "Game is not running!";
			this.lblGameRunning.Click += new global::System.EventHandler(this.lblGameRunning_Click);
			this.lblZombiesLeft.AutoSize = true;
			this.lblZombiesLeft.Location = new global::System.Drawing.Point(511, 23);
			this.lblZombiesLeft.Name = "lblZombiesLeft";
			this.lblZombiesLeft.Size = new global::System.Drawing.Size(68, 13);
			this.lblZombiesLeft.TabIndex = 8;
			this.lblZombiesLeft.Text = "Zombies Left";
			this.lblZombiesLeft.Click += new global::System.EventHandler(this.lblZombiesLeft_Click);
			this.btnOnOff.ForeColor = global::System.Drawing.Color.Red;
			this.btnOnOff.Location = new global::System.Drawing.Point(635, 12);
			this.btnOnOff.Name = "btnOnOff";
			this.btnOnOff.Size = new global::System.Drawing.Size(90, 35);
			this.btnOnOff.TabIndex = 9;
			this.btnOnOff.Text = "STOPPED";
			this.btnOnOff.UseVisualStyleBackColor = true;
			this.btnOnOff.Click += new global::System.EventHandler(this.btnOnOff_Click);
			this.checkBox7.AutoSize = true;
			this.checkBox7.Location = new global::System.Drawing.Point(119, 39);
			this.checkBox7.Name = "checkBox7";
			this.checkBox7.Size = new global::System.Drawing.Size(136, 17);
			this.checkBox7.TabIndex = 15;
			this.checkBox7.Text = "Infinite Essence (SELF)";
			this.checkBox7.UseVisualStyleBackColor = true;
			this.checkBox7.CheckedChanged += new global::System.EventHandler(this.checkBox7_CheckedChanged);
			this.checkBox8.AutoSize = true;
			this.checkBox8.Location = new global::System.Drawing.Point(319, 12);
			this.checkBox8.Name = "checkBox8";
			this.checkBox8.Size = new global::System.Drawing.Size(116, 17);
			this.checkBox8.TabIndex = 16;
			this.checkBox8.Text = "Toggle XP Modifier";
			this.checkBox8.UseVisualStyleBackColor = true;
			this.checkBox8.CheckedChanged += new global::System.EventHandler(this.checkBox8_CheckedChanged);
			this.trackBar1.Location = new global::System.Drawing.Point(253, 168);
			this.trackBar1.Maximum = 100;
			this.trackBar1.Name = "trackBar1";
			this.trackBar1.Size = new global::System.Drawing.Size(193, 45);
			this.trackBar1.TabIndex = 17;
			this.trackBar1.Scroll += new global::System.EventHandler(this.trackBar1_Scroll);
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(282, 168);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(134, 13);
			this.label1.TabIndex = 18;
			this.label1.Text = "Player Speed (Default: 1.0)";
			this.numericUpDown1.DecimalPlaces = 2;
			this.numericUpDown1.Increment = new decimal(new int[]
			{
				25,
				0,
				0,
				131072
			});
			this.numericUpDown1.Location = new global::System.Drawing.Point(285, 202);
			global::System.Windows.Forms.NumericUpDown numericUpDown = this.numericUpDown1;
			int[] array = new int[4];
			array[0] = 2000;
			numericUpDown.Maximum = new decimal(array);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new global::System.Drawing.Size(120, 20);
			this.numericUpDown1.TabIndex = 19;
			this.numericUpDown1.ThousandsSeparator = true;
			this.numericUpDown1.ValueChanged += new global::System.EventHandler(this.numericUpDown1_ValueChanged);
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(9, 183);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(196, 13);
			this.label2.TabIndex = 20;
			this.label2.Text = "Zombie Teleport Distance (Default: 150)";
			this.trackBar2.Location = new global::System.Drawing.Point(5, 200);
			this.trackBar2.Maximum = 750;
			this.trackBar2.Minimum = 25;
			this.trackBar2.Name = "trackBar2";
			this.trackBar2.Size = new global::System.Drawing.Size(193, 45);
			this.trackBar2.TabIndex = 21;
			this.trackBar2.Value = 150;
			this.trackBar2.Scroll += new global::System.EventHandler(this.trackBar2_Scroll);
			this.numericUpDown2.Location = new global::System.Drawing.Point(39, 228);
			global::System.Windows.Forms.NumericUpDown numericUpDown2 = this.numericUpDown2;
			int[] array2 = new int[4];
			array2[0] = 750;
			numericUpDown2.Maximum = new decimal(array2);
			global::System.Windows.Forms.NumericUpDown numericUpDown3 = this.numericUpDown2;
			int[] array3 = new int[4];
			array3[0] = 25;
			numericUpDown3.Minimum = new decimal(array3);
			this.numericUpDown2.Name = "numericUpDown2";
			this.numericUpDown2.Size = new global::System.Drawing.Size(120, 20);
			this.numericUpDown2.TabIndex = 22;
			global::System.Windows.Forms.NumericUpDown numericUpDown4 = this.numericUpDown2;
			int[] array4 = new int[4];
			array4[0] = 150;
			numericUpDown4.Value = new decimal(array4);
			this.numericUpDown2.ValueChanged += new global::System.EventHandler(this.numericUpDown2_ValueChanged);
			this.label3.AutoSize = true;
			this.label3.Location = new global::System.Drawing.Point(571, 63);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(86, 13);
			this.label3.TabIndex = 24;
			this.label3.Text = "Player Position X";
			this.label3.Click += new global::System.EventHandler(this.label3_Click);
			this.trackBar3.Location = new global::System.Drawing.Point(497, 79);
			this.trackBar3.Maximum = 15000;
			this.trackBar3.Minimum = -15000;
			this.trackBar3.Name = "trackBar3";
			this.trackBar3.Size = new global::System.Drawing.Size(236, 45);
			this.trackBar3.TabIndex = 25;
			this.trackBar3.Scroll += new global::System.EventHandler(this.trackBar3_Scroll);
			this.numericUpDown3.DecimalPlaces = 6;
			this.numericUpDown3.Increment = new decimal(new int[]
			{
				25,
				0,
				0,
				131072
			});
			this.numericUpDown3.Location = new global::System.Drawing.Point(514, 109);
			global::System.Windows.Forms.NumericUpDown numericUpDown5 = this.numericUpDown3;
			int[] array5 = new int[4];
			array5[0] = 15000;
			numericUpDown5.Maximum = new decimal(array5);
			this.numericUpDown3.Minimum = new decimal(new int[]
			{
				15000,
				0,
				0,
				int.MinValue
			});
			this.numericUpDown3.Name = "numericUpDown3";
			this.numericUpDown3.Size = new global::System.Drawing.Size(200, 20);
			this.numericUpDown3.TabIndex = 26;
			this.numericUpDown3.ThousandsSeparator = true;
			this.numericUpDown3.ValueChanged += new global::System.EventHandler(this.numericUpDown3_ValueChanged);
			this.numericUpDown4.DecimalPlaces = 6;
			this.numericUpDown4.Increment = new decimal(new int[]
			{
				25,
				0,
				0,
				131072
			});
			this.numericUpDown4.Location = new global::System.Drawing.Point(514, 253);
			global::System.Windows.Forms.NumericUpDown numericUpDown6 = this.numericUpDown4;
			int[] array6 = new int[4];
			array6[0] = 15000;
			numericUpDown6.Maximum = new decimal(array6);
			this.numericUpDown4.Minimum = new decimal(new int[]
			{
				15000,
				0,
				0,
				int.MinValue
			});
			this.numericUpDown4.Name = "numericUpDown4";
			this.numericUpDown4.Size = new global::System.Drawing.Size(200, 20);
			this.numericUpDown4.TabIndex = 29;
			this.numericUpDown4.ThousandsSeparator = true;
			this.numericUpDown4.ValueChanged += new global::System.EventHandler(this.numericUpDown4_ValueChanged);
			this.trackBar4.Location = new global::System.Drawing.Point(497, 216);
			this.trackBar4.Maximum = 15000;
			this.trackBar4.Minimum = -15000;
			this.trackBar4.Name = "trackBar4";
			this.trackBar4.Size = new global::System.Drawing.Size(236, 45);
			this.trackBar4.TabIndex = 28;
			this.trackBar4.Scroll += new global::System.EventHandler(this.trackBar4_Scroll);
			this.label4.AutoSize = true;
			this.label4.Location = new global::System.Drawing.Point(571, 200);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(86, 13);
			this.label4.TabIndex = 27;
			this.label4.Text = "Player Position Z";
			this.numericUpDown5.DecimalPlaces = 6;
			this.numericUpDown5.Increment = new decimal(new int[]
			{
				25,
				0,
				0,
				131072
			});
			this.numericUpDown5.Location = new global::System.Drawing.Point(514, 176);
			global::System.Windows.Forms.NumericUpDown numericUpDown7 = this.numericUpDown5;
			int[] array7 = new int[4];
			array7[0] = 15000;
			numericUpDown7.Maximum = new decimal(array7);
			this.numericUpDown5.Minimum = new decimal(new int[]
			{
				15000,
				0,
				0,
				int.MinValue
			});
			this.numericUpDown5.Name = "numericUpDown5";
			this.numericUpDown5.Size = new global::System.Drawing.Size(200, 20);
			this.numericUpDown5.TabIndex = 32;
			this.numericUpDown5.ThousandsSeparator = true;
			this.numericUpDown5.ValueChanged += new global::System.EventHandler(this.numericUpDown5_ValueChanged);
			this.trackBar5.Location = new global::System.Drawing.Point(497, 148);
			this.trackBar5.Maximum = 15000;
			this.trackBar5.Minimum = -15000;
			this.trackBar5.Name = "trackBar5";
			this.trackBar5.Size = new global::System.Drawing.Size(236, 45);
			this.trackBar5.TabIndex = 31;
			this.trackBar5.Scroll += new global::System.EventHandler(this.trackBar5_Scroll);
			this.label5.AutoSize = true;
			this.label5.Location = new global::System.Drawing.Point(571, 132);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(86, 13);
			this.label5.TabIndex = 30;
			this.label5.Text = "Player Position Y";
			this.numericUpDown6.DecimalPlaces = 2;
			this.numericUpDown6.Location = new global::System.Drawing.Point(312, 65);
			global::System.Windows.Forms.NumericUpDown numericUpDown8 = this.numericUpDown6;
			int[] array8 = new int[4];
			array8[0] = 3000;
			numericUpDown8.Maximum = new decimal(array8);
			this.numericUpDown6.Name = "numericUpDown6";
			this.numericUpDown6.Size = new global::System.Drawing.Size(123, 20);
			this.numericUpDown6.TabIndex = 35;
			this.numericUpDown6.ValueChanged += new global::System.EventHandler(this.numericUpDown6_ValueChanged);
			this.trackBar6.Location = new global::System.Drawing.Point(312, 35);
			this.trackBar6.Maximum = 3000;
			this.trackBar6.Name = "trackBar6";
			this.trackBar6.Size = new global::System.Drawing.Size(117, 45);
			this.trackBar6.TabIndex = 34;
			this.trackBar6.Scroll += new global::System.EventHandler(this.trackBar6_Scroll);
			this.numericUpDown7.DecimalPlaces = 2;
			this.numericUpDown7.Location = new global::System.Drawing.Point(312, 128);
			global::System.Windows.Forms.NumericUpDown numericUpDown9 = this.numericUpDown7;
			int[] array9 = new int[4];
			array9[0] = 3000;
			numericUpDown9.Maximum = new decimal(array9);
			this.numericUpDown7.Name = "numericUpDown7";
			this.numericUpDown7.Size = new global::System.Drawing.Size(123, 20);
			this.numericUpDown7.TabIndex = 37;
			this.numericUpDown7.ValueChanged += new global::System.EventHandler(this.numericUpDown7_ValueChanged);
			this.trackBar7.Location = new global::System.Drawing.Point(312, 100);
			this.trackBar7.Maximum = 3000;
			this.trackBar7.Name = "trackBar7";
			this.trackBar7.Size = new global::System.Drawing.Size(117, 45);
			this.trackBar7.TabIndex = 36;
			this.trackBar7.Scroll += new global::System.EventHandler(this.trackBar7_Scroll);
			this.label6.AutoSize = true;
			this.label6.Location = new global::System.Drawing.Point(241, 59);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(65, 26);
			this.label6.TabIndex = 38;
			this.label6.Text = "Weapon XP\r\nModifier";
			this.label7.AutoSize = true;
			this.label7.Location = new global::System.Drawing.Point(250, 119);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(56, 26);
			this.label7.TabIndex = 39;
			this.label7.Text = "Player  XP\r\nModifier";
			this.checkBox2.AutoSize = true;
			this.checkBox2.Location = new global::System.Drawing.Point(12, 68);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new global::System.Drawing.Size(129, 17);
			this.checkBox2.TabIndex = 40;
			this.checkBox2.Text = "Infinite Essence (ALL)";
			this.checkBox2.UseVisualStyleBackColor = true;
			this.checkBox2.CheckedChanged += new global::System.EventHandler(this.checkBox2_CheckedChanged_3);
			this.checkBox9.AutoSize = true;
			this.checkBox9.Location = new global::System.Drawing.Point(12, 91);
			this.checkBox9.Name = "checkBox9";
			this.checkBox9.Size = new global::System.Drawing.Size(104, 17);
			this.checkBox9.TabIndex = 41;
			this.checkBox9.Text = "God Mode (ALL)";
			this.checkBox9.UseVisualStyleBackColor = true;
			this.checkBox9.CheckedChanged += new global::System.EventHandler(this.checkBox9_CheckedChanged_2);
			this.checkBox116.AutoSize = true;
			this.checkBox116.Location = new global::System.Drawing.Point(12, 118);
			this.checkBox116.Name = "checkBox116";
			this.checkBox116.Size = new global::System.Drawing.Size(117, 17);
			this.checkBox116.TabIndex = 42;
			this.checkBox116.Text = "Infinite Ammo (ALL)";
			this.checkBox116.UseVisualStyleBackColor = true;
			this.checkBox116.CheckedChanged += new global::System.EventHandler(this.checkBox10_CheckedChanged);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(730, 437);
			base.Controls.Add(this.checkBox116);
			base.Controls.Add(this.checkBox9);
			base.Controls.Add(this.checkBox2);
			base.Controls.Add(this.label7);
			base.Controls.Add(this.label6);
			base.Controls.Add(this.numericUpDown7);
			base.Controls.Add(this.trackBar7);
			base.Controls.Add(this.numericUpDown6);
			base.Controls.Add(this.trackBar6);
			base.Controls.Add(this.numericUpDown5);
			base.Controls.Add(this.trackBar5);
			base.Controls.Add(this.label5);
			base.Controls.Add(this.numericUpDown4);
			base.Controls.Add(this.trackBar4);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.numericUpDown3);
			base.Controls.Add(this.trackBar3);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.numericUpDown2);
			base.Controls.Add(this.trackBar2);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.numericUpDown1);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.trackBar1);
			base.Controls.Add(this.checkBox8);
			base.Controls.Add(this.checkBox7);
			base.Controls.Add(this.btnOnOff);
			base.Controls.Add(this.lblZombiesLeft);
			base.Controls.Add(this.lblGameRunning);
			base.Controls.Add(this.txtConsole);
			base.Controls.Add(this.checkBox6);
			base.Controls.Add(this.checkBox5);
			base.Controls.Add(this.checkBox4);
			base.Controls.Add(this.checkBox3);
			base.Controls.Add(this.checkBox1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.Name = "ColdWarZombiesTool";
			this.Text = "CW Zombies Tool";
			base.Load += new global::System.EventHandler(this.RennysThing_Load);
			((global::System.ComponentModel.ISupportInitialize)this.trackBar1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDown1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.trackBar2).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDown2).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.trackBar3).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDown3).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDown4).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.trackBar4).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDown5).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.trackBar5).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDown6).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.trackBar6).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDown7).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.trackBar7).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000044 RID: 68
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000045 RID: 69
		private global::System.ComponentModel.BackgroundWorker backgroundWorker1;

		// Token: 0x04000046 RID: 70
		private global::System.Windows.Forms.CheckBox checkBox1;

		// Token: 0x04000047 RID: 71
		private global::System.Windows.Forms.CheckBox checkBox3;

		// Token: 0x04000048 RID: 72
		private global::System.Windows.Forms.CheckBox checkBox4;

		// Token: 0x04000049 RID: 73
		private global::System.Windows.Forms.CheckBox checkBox5;

		// Token: 0x0400004A RID: 74
		private global::System.Windows.Forms.CheckBox checkBox6;

		// Token: 0x0400004B RID: 75
		private global::System.Windows.Forms.TextBox txtConsole;

		// Token: 0x0400004C RID: 76
		private global::System.Windows.Forms.Label lblGameRunning;

		// Token: 0x0400004D RID: 77
		private global::System.Windows.Forms.Label lblZombiesLeft;

		// Token: 0x0400004E RID: 78
		private global::System.Windows.Forms.Button btnOnOff;

		// Token: 0x0400004F RID: 79
		private global::System.Windows.Forms.CheckBox checkBox7;

		// Token: 0x04000050 RID: 80
		private global::System.Windows.Forms.CheckBox checkBox8;

		// Token: 0x04000051 RID: 81
		private global::System.Windows.Forms.TrackBar trackBar1;

		// Token: 0x04000052 RID: 82
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000053 RID: 83
		private global::System.Windows.Forms.NumericUpDown numericUpDown1;

		// Token: 0x04000054 RID: 84
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000055 RID: 85
		private global::System.Windows.Forms.TrackBar trackBar2;

		// Token: 0x04000056 RID: 86
		private global::System.Windows.Forms.NumericUpDown numericUpDown2;

		// Token: 0x04000057 RID: 87
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000058 RID: 88
		private global::System.Windows.Forms.TrackBar trackBar3;

		// Token: 0x04000059 RID: 89
		private global::System.Windows.Forms.NumericUpDown numericUpDown3;

		// Token: 0x0400005A RID: 90
		private global::System.Windows.Forms.NumericUpDown numericUpDown4;

		// Token: 0x0400005B RID: 91
		private global::System.Windows.Forms.TrackBar trackBar4;

		// Token: 0x0400005C RID: 92
		private global::System.Windows.Forms.Label label4;

		// Token: 0x0400005D RID: 93
		private global::System.Windows.Forms.NumericUpDown numericUpDown5;

		// Token: 0x0400005E RID: 94
		private global::System.Windows.Forms.TrackBar trackBar5;

		// Token: 0x0400005F RID: 95
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04000060 RID: 96
		private global::System.Windows.Forms.NumericUpDown numericUpDown6;

		// Token: 0x04000061 RID: 97
		private global::System.Windows.Forms.TrackBar trackBar6;

		// Token: 0x04000062 RID: 98
		private global::System.Windows.Forms.NumericUpDown numericUpDown7;

		// Token: 0x04000063 RID: 99
		private global::System.Windows.Forms.TrackBar trackBar7;

		// Token: 0x04000064 RID: 100
		private global::System.Windows.Forms.Label label6;

		// Token: 0x04000065 RID: 101
		private global::System.Windows.Forms.Label label7;

		// Token: 0x04000066 RID: 102
		private global::System.Windows.Forms.CheckBox checkBox2;

		// Token: 0x04000067 RID: 103
		private global::System.Windows.Forms.CheckBox checkBox9;

		// Token: 0x04000068 RID: 104
		private global::System.Windows.Forms.CheckBox checkBox116;
	}
}
