using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ebshseubhfhisb;

namespace ebshseubhfhisb
{
	// Token: 0x02000002 RID: 2
	public partial class ebshseubhfhisb : Form
	{
		// Token: 0x06000001 RID: 1
		public ebshseubhfhisb()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000002 RID: 2
		private void btnOnOff_Click(object sender, EventArgs e)
		{
			this.trainerOn = !this.trainerOn;
			if (this.trainerOn)
			{
				this.btnOnOff.Text = "RUNNING";
				this.btnOnOff.ForeColor = Color.Green;
				this.ConsoleOut("Trainer Enabled");
				return;
			}
			this.btnOnOff.Text = "STOPPED";
			this.btnOnOff.ForeColor = Color.Red;
			this.ConsoleOut("Trainer Disabled");
		}

		// Token: 0x06000003 RID: 3
		private void numericUpDown1_ValueChanged(object sender, EventArgs e)
		{
			this.playerSpeed = (float)this.numericUpDown1.Value;
			this.trackBar1.Value = Convert.ToInt32(this.numericUpDown1.Value);
			IntPtr intPtr;
			cwapi.WriteProcessMemory(this.hProc, this.PlayerCompPtr + 23600, Convert.ToSingle(this.playerSpeed), 4L, out intPtr);
		}

		// Token: 0x06000004 RID: 4
		private void trackBar1_Scroll(object sender, EventArgs e)
		{
			this.playerSpeed = (float)this.trackBar1.Value;
			this.numericUpDown1.Value = this.trackBar1.Value;
			IntPtr intPtr;
			cwapi.WriteProcessMemory(this.hProc, this.PlayerCompPtr + 23600, Convert.ToSingle(this.playerSpeed), 4L, out intPtr);
		}

		// Token: 0x06000005 RID: 5
		private void RennysThing_Load(object sender, EventArgs e)
		{
			this.ConsoleOut("Source from Official Renny on Unknowncheats.");
			this.ConsoleOut("Updated to latest version - 1.7.5.8408002");
			this.ConsoleOut("Status - UNDETECTED");
			this.ConsoleOut("ONLY START TRAINER IN A GAME.");
			this.ConsoleOut("DO NOT START TRAINER IN A LOBBY.");
			if (!this.backgroundWorker1.IsBusy)
			{
				this.backgroundWorker1.RunWorkerAsync();
			}
		}

		// Token: 0x06000006 RID: 6
		private void trackBar2_Scroll(object sender, EventArgs e)
		{
			this.zmTeleportDistance = this.trackBar2.Value;
			this.numericUpDown2.Value = Convert.ToInt32(this.trackBar2.Value);
		}

		// Token: 0x06000007 RID: 7
		private void numericUpDown2_ValueChanged(object sender, EventArgs e)
		{
			this.zmTeleportDistance = Convert.ToInt32(this.numericUpDown2.Value);
			this.trackBar2.Value = Convert.ToInt32(this.numericUpDown2.Value);
		}

		// Token: 0x06000008 RID: 8
		private void checkBox3_CheckedChanged(object sender, EventArgs e)
		{
			this.ammoFrozen = this.checkBox3.Checked;
		}

		// Token: 0x06000009 RID: 9
		private void trackBar3_Scroll(object sender, EventArgs e)
		{
			this.numericUpDown3.Value = this.trackBar3.Value;
			this.frozenPlayerPos.X = (float)this.numericUpDown3.Value;
			this.UpdatePlayerPosition(this.frozenPlayerPos);
		}

		// Token: 0x0600000A RID: 10
		private void numericUpDown3_ValueChanged(object sender, EventArgs e)
		{
			this.trackBar3.Value = Convert.ToInt32(this.numericUpDown3.Value);
			this.frozenPlayerPos.X = (float)this.numericUpDown3.Value;
			this.UpdatePlayerPosition(this.frozenPlayerPos);
		}

		// Token: 0x0600000B RID: 11
		private void trackBar5_Scroll(object sender, EventArgs e)
		{
			this.numericUpDown5.Value = this.trackBar5.Value;
			this.frozenPlayerPos.Y = (float)this.numericUpDown5.Value;
			this.UpdatePlayerPosition(this.frozenPlayerPos);
		}

		// Token: 0x0600000C RID: 12
		private void numericUpDown5_ValueChanged(object sender, EventArgs e)
		{
			this.trackBar5.Value = Convert.ToInt32(this.numericUpDown5.Value);
			this.frozenPlayerPos.Y = (float)this.numericUpDown3.Value;
			this.UpdatePlayerPosition(this.frozenPlayerPos);
		}

		// Token: 0x0600000D RID: 13
		private void trackBar4_Scroll(object sender, EventArgs e)
		{
			this.numericUpDown4.Value = this.trackBar4.Value;
			this.frozenPlayerPos.Z = (float)this.numericUpDown4.Value;
			this.UpdatePlayerPosition(this.frozenPlayerPos);
		}

		// Token: 0x0600000E RID: 14
		private void numericUpDown4_ValueChanged(object sender, EventArgs e)
		{
			this.trackBar4.Value = Convert.ToInt32(this.numericUpDown4.Value);
			this.frozenPlayerPos.Z = (float)this.numericUpDown4.Value;
			this.UpdatePlayerPosition(this.frozenPlayerPos);
		}

		// Token: 0x0600000F RID: 15
		private void checkBox2_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000010 RID: 16
		private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
		{
			for (;;)
			{
				try
				{
					if (this.trainerOn)
					{
						Process[] processesByName = Process.GetProcessesByName("BlackOpsColdWar");
						if (processesByName.Length < 1)
						{
							this.UpdateLabel(this.lblGameRunning, "Game is not running!", "Red");
						}
						else
						{
							this.gameProc = processesByName[0];
							this.gamePID = this.gameProc.Id;
							if (this.gamePID > 0)
							{
								this.UpdateLabel(this.lblGameRunning, "Game is running! Process ID: " + this.gamePID.ToString(), "Green");
								this.hProc = cwapi.OpenProcess(cwapi.ProcessAccessFlags.All, false, this.gameProc.Id);
								if (this.baseAddress != cwapi.GetModuleBaseAddress(this.gameProc, "BlackOpsColdWar.exe"))
								{
									this.baseAddress = cwapi.GetModuleBaseAddress(this.gameProc, "BlackOpsColdWar.exe");
								}
								if (this.PlayerCompPtr != cwapi.FindDMAAddy(this.hProc, (IntPtr)(this.baseAddress.ToInt64() + this.PlayerBase.ToInt64()), new int[1]))
								{
									this.PlayerCompPtr = cwapi.FindDMAAddy(this.hProc, (IntPtr)(this.baseAddress.ToInt64() + this.PlayerBase.ToInt64()), new int[1]);
								}
								if (this.PlayerPedPtr != cwapi.FindDMAAddy(this.hProc, (IntPtr)(this.baseAddress.ToInt64() + this.PlayerBase.ToInt64() + 8L), new int[1]))
								{
									this.PlayerPedPtr = cwapi.FindDMAAddy(this.hProc, (IntPtr)(this.baseAddress.ToInt64() + this.PlayerBase.ToInt64() + 8L), new int[1]);
								}
								if (this.ZMGlobalBase != cwapi.FindDMAAddy(this.hProc, (IntPtr)(this.baseAddress.ToInt64() + this.PlayerBase.ToInt64() + 96L), new int[1]))
								{
									this.ZMGlobalBase = cwapi.FindDMAAddy(this.hProc, (IntPtr)(this.baseAddress.ToInt64() + this.PlayerBase.ToInt64() + 96L), new int[1]);
								}
								if (this.ZMBotBase != cwapi.FindDMAAddy(this.hProc, (IntPtr)(this.baseAddress.ToInt64() + this.PlayerBase.ToInt64() + 104L), new int[1]))
								{
									this.ZMBotBase = cwapi.FindDMAAddy(this.hProc, (IntPtr)(this.baseAddress.ToInt64() + this.PlayerBase.ToInt64()) + 104, new int[1]);
								}
								if (this.ZMBotBase != (IntPtr)0 && this.ZMBotBase != (IntPtr)104 && this.ZMBotListBase != cwapi.FindDMAAddy(this.hProc, this.ZMBotBase + 8, new int[1]))
								{
									this.ZMBotListBase = cwapi.FindDMAAddy(this.hProc, this.ZMBotBase + 8, new int[1]);
								}
								byte[] array = new byte[12];
								IntPtr intPtr;
								cwapi.ReadProcessMemory(this.hProc, this.PlayerPedPtr + 724, array, 12L, out intPtr);
								float num = BitConverter.ToSingle(array, 0);
								float num2 = BitConverter.ToSingle(array, 4);
								float num3 = BitConverter.ToSingle(array, 8);
								this.updatedPlayerPos = new Vector3((float)Math.Round((double)num, 4), (float)Math.Round((double)num2, 4), (float)Math.Round((double)num3, 4));
								if (this.freezePlayer)
								{
									if (this.frozenPlayerPos == Vector3.Zero)
									{
										this.frozenPlayerPos = ((this.lastKnownPlayerPos == Vector3.Zero) ? this.updatedPlayerPos : this.lastKnownPlayerPos);
									}
									this.UpdatePlayerPosition(this.frozenPlayerPos);
								}
								bool flag12 = false;
								if (this.numericUpDown3.Value != (decimal)this.lastKnownPlayerPos.X)
								{
									this.lastKnownPlayerPos.X = (float)this.numericUpDown3.Value;
									flag12 = true;
								}
								else
								{
									this.numericUpDown3.Value = (decimal)this.updatedPlayerPos.X;
								}
								if (this.numericUpDown5.Value != (decimal)this.lastKnownPlayerPos.Y)
								{
									this.lastKnownPlayerPos.Y = (float)this.numericUpDown5.Value;
									flag12 = true;
								}
								else
								{
									this.numericUpDown5.Value = (decimal)this.updatedPlayerPos.Y;
								}
								if (this.numericUpDown4.Value != (decimal)this.lastKnownPlayerPos.Z)
								{
									this.lastKnownPlayerPos.Z = (float)this.numericUpDown4.Value;
									flag12 = true;
								}
								else
								{
									this.numericUpDown4.Value = (decimal)this.updatedPlayerPos.Z;
								}
								if (flag12)
								{
									this.UpdatePlayerPosition(this.lastKnownPlayerPos);
								}
								if (this.playerSpeed < 0f)
								{
									byte[] array2 = new byte[4];
									cwapi.ReadProcessMemory(this.hProc, this.PlayerCompPtr + 23600, array2, 4L, out intPtr);
									this.trackBar1.Value = Convert.ToInt32(BitConverter.ToSingle(array2, 0));
									this.numericUpDown1.Value = Convert.ToDecimal(BitConverter.ToSingle(array2, 0));
								}
								if (this.ammoFrozen)
								{
									for (int i = 1; i < 6; i++)
									{
										cwapi.WriteProcessMemory(this.hProc, this.PlayerCompPtr + 0 + 5076 + i * 4, 20, 4L, out intPtr);
									}
								}
								if (this.checkBox1.Checked)
								{
									cwapi.WriteProcessMemory(this.hProc, this.PlayerCompPtr + 0 + 3687, 160, 1L, out intPtr);
								}
								else
								{
									cwapi.WriteProcessMemory(this.hProc, this.PlayerCompPtr + 0 + 3687, 32, 1L, out intPtr);
								}
								if (this.checkBox4.Checked || this.checkBox5.Checked)
								{
									byte[] array3 = new byte[12];
									if (this.checkBox5.Checked)
									{
										byte[] array4 = new byte[4];
										byte[] array5 = new byte[4];
										cwapi.ReadProcessMemory(this.hProc, this.PlayerPedPtr + 56, array4, 4L, out intPtr);
										cwapi.ReadProcessMemory(this.hProc, this.PlayerPedPtr + 52, array5, 4L, out intPtr);
										double num4 = -this.ConvertToRadians((double)BitConverter.ToSingle(array5, 0));
										double num6 = this.ConvertToRadians((double)BitConverter.ToSingle(array4, 0));
										float x = Convert.ToSingle(Math.Cos(num6) * Math.Cos(num4));
										float y = Convert.ToSingle(Math.Sin(num6) * Math.Cos(num4));
										float z = Convert.ToSingle(Math.Sin(num4));
										Vector3 vector = this.updatedPlayerPos + new Vector3(x, y, z) * (float)this.zmTeleportDistance;
										Buffer.BlockCopy(BitConverter.GetBytes(vector.X), 0, array3, 0, 4);
										Buffer.BlockCopy(BitConverter.GetBytes(vector.Y), 0, array3, 4, 4);
										Buffer.BlockCopy(BitConverter.GetBytes(vector.Z), 0, array3, 8, 4);
									}
									for (int j = 0; j < 90; j++)
									{
										if (this.checkBox4.Checked)
										{
											cwapi.WriteProcessMemory(this.hProc, this.ZMBotListBase + 1528 * j + 920, 1, 4L, out intPtr);
											cwapi.WriteProcessMemory(this.hProc, this.ZMBotListBase + 1528 * j + 924, 1, 4L, out intPtr);
										}
										if (this.checkBox5.Checked)
										{
											cwapi.WriteProcessMemory(this.hProc, this.ZMBotListBase + 1528 * j + 724, array3, 12L, out intPtr);
										}
									}
								}
								if (this.checkBox6.Checked)
								{
									cwapi.WriteProcessMemory(this.hProc, this.PlayerCompPtr + 3686, new byte[]
									{
										16
									}, 1L, out intPtr);
								}
								else
								{
									cwapi.WriteProcessMemory(this.hProc, this.PlayerCompPtr + 3686, new byte[1], 1L, out intPtr);
								}
								if (this.checkBox7.Checked)
								{
									cwapi.WriteProcessMemory(this.hProc, this.PlayerCompPtr + 0 + 23780, 100000, 8L, out intPtr);
								}
								if (this.checkBox2.Checked)
								{
									cwapi.WriteProcessMemory(this.hProc, this.PlayerCompPtr + 47152 + 23780, 100000, 8L, out intPtr);
									cwapi.WriteProcessMemory(this.hProc, this.PlayerCompPtr + 94304 + 23780, 100000, 8L, out intPtr);
									cwapi.WriteProcessMemory(this.hProc, this.PlayerCompPtr + 141456 + 23780, 100000, 8L, out intPtr);
								}
								if (this.checkBox9.Checked)
								{
									cwapi.WriteProcessMemory(this.hProc, this.PlayerCompPtr + 47152 + 3687, 160, 1L, out intPtr);
									cwapi.WriteProcessMemory(this.hProc, this.PlayerCompPtr + 94304 + 3687, 160, 1L, out intPtr);
									cwapi.WriteProcessMemory(this.hProc, this.PlayerCompPtr + 141456 + 3687, 160, 1L, out intPtr);
								}
								else
								{
									cwapi.WriteProcessMemory(this.hProc, this.PlayerCompPtr + 47152 + 3687, 32, 1L, out intPtr);
									cwapi.WriteProcessMemory(this.hProc, this.PlayerCompPtr + 94304 + 3687, 32, 1L, out intPtr);
									cwapi.WriteProcessMemory(this.hProc, this.PlayerCompPtr + 141456 + 3687, 32, 1L, out intPtr);
								}
								if (this.checkBox116.Checked)
								{
									for (int k = 1; k < 6; k++)
									{
										cwapi.WriteProcessMemory(this.hProc, this.PlayerCompPtr + 47152 + 5076 + k * 4, 20, 4L, out intPtr);
										cwapi.WriteProcessMemory(this.hProc, this.PlayerCompPtr + 94304 + 5076 + k * 4, 20, 4L, out intPtr);
										cwapi.WriteProcessMemory(this.hProc, this.PlayerCompPtr + 141456 + 5076 + k * 4, 20, 4L, out intPtr);
									}
								}
								if (this.checkBox4.Checked || this.checkBox5.Checked)
								{
									byte[] dst = new byte[12];
									if (this.checkBox5.Checked)
									{
										byte[] array6 = new byte[4];
										byte[] array7 = new byte[4];
										cwapi.ReadProcessMemory(this.hProc, this.PlayerPedPtr + 47152 + 56, array6, 4L, out intPtr);
										cwapi.ReadProcessMemory(this.hProc, this.PlayerPedPtr + 47152 + 52, array7, 4L, out intPtr);
										double num5 = -this.ConvertToRadians((double)BitConverter.ToSingle(array7, 0));
										double num7 = this.ConvertToRadians((double)BitConverter.ToSingle(array6, 0));
										float x2 = Convert.ToSingle(Math.Cos(num7) * Math.Cos(num5));
										float y2 = Convert.ToSingle(Math.Sin(num7) * Math.Cos(num5));
										float z2 = Convert.ToSingle(Math.Sin(num5));
										Vector3 vector2 = this.updatedPlayerPos + new Vector3(x2, y2, z2) * (float)this.zmTeleportDistance;
										Buffer.BlockCopy(BitConverter.GetBytes(vector2.X), 0, dst, 0, 4);
										Buffer.BlockCopy(BitConverter.GetBytes(vector2.Y), 0, dst, 4, 4);
										Buffer.BlockCopy(BitConverter.GetBytes(vector2.Z), 0, dst, 8, 4);
									}
									for (int l = 0; l < 90; l++)
									{
										if (this.checkBox4.Checked)
										{
											cwapi.WriteProcessMemory(this.hProc, this.ZMBotListBase + 1528 * l + 920, 1, 4L, out intPtr);
											cwapi.WriteProcessMemory(this.hProc, this.ZMBotListBase + 1528 * l + 924, 1, 4L, out intPtr);
										}
										if (this.checkBox8.Checked)
										{
											if (this.numericUpDown6.Value <= 0m)
											{
												byte[] array8 = new byte[4];
												cwapi.ReadProcessMemory(this.hProc, (IntPtr)(this.baseAddress.ToInt64() + this.ZMXPScaleBase.ToInt64()) + 48, array8, 4L, out intPtr);
												this.numericUpDown6.Value = (decimal)BitConverter.ToSingle(array8, 0);
												this.trackBar6.Value = (int)BitConverter.ToSingle(array8, 0);
											}
											if (this.numericUpDown7.Value <= 0m)
											{
												byte[] array9 = new byte[4];
												cwapi.ReadProcessMemory(this.hProc, (IntPtr)(this.baseAddress.ToInt64() + this.ZMXPScaleBase.ToInt64()) + 40, array9, 4L, out intPtr);
												this.numericUpDown7.Value = (decimal)BitConverter.ToSingle(array9, 0);
												this.trackBar7.Value = (int)BitConverter.ToSingle(array9, 0);
											}
											bool @checked = this.checkBox8.Checked;
											byte[] array10 = new byte[4];
											Buffer.BlockCopy(BitConverter.GetBytes(this.gunXpModifier), 0, array10, 0, 4);
											byte[] array11 = new byte[4];
											Buffer.BlockCopy(BitConverter.GetBytes(this.xpModifier), 0, array11, 0, 4);
											cwapi.WriteProcessMemory(this.hProc, (IntPtr)(this.baseAddress.ToInt64() + this.ZMXPScaleBase.ToInt64()) + 48, array10, 4L, out intPtr);
											cwapi.WriteProcessMemory(this.hProc, (IntPtr)(this.baseAddress.ToInt64() + this.ZMXPScaleBase.ToInt64()) + 40, array11, 4L, out intPtr);
										}
										byte[] array12 = new byte[4];
										cwapi.ReadProcessMemory(this.hProc, this.ZMGlobalBase + 60, array12, 4L, out intPtr);
										this.lblZombiesLeft.Text = "Zombies Left: " + BitConverter.ToInt32(array12, 0).ToString();
										this.lastKnownPlayerPos = this.updatedPlayerPos;
										if (Marshal.GetLastWin32Error() != 0)
										{
											this.ConsoleOut(Marshal.GetLastWin32Error().ToString());
										}
									}
								}
							}
							else
							{
								this.UpdateLabel(this.lblGameRunning, "Game is not running!", "Red");
							}
						}
					}
				}
				catch (Exception ex)
				{
					this.ConsoleOut(ex.Message);
				}
			}
		}

		// Token: 0x06000011 RID: 17
		private void button1_Click(object sender, EventArgs e)
		{
			this.frozenPlayerPos.X = (float)this.numericUpDown3.Value;
			this.frozenPlayerPos.Y = (float)this.numericUpDown5.Value;
			this.frozenPlayerPos.Z = (float)this.numericUpDown4.Value;
			this.UpdatePlayerPosition(this.frozenPlayerPos);
		}

		// Token: 0x06000012 RID: 18
		private void trackBar6_Scroll(object sender, EventArgs e)
		{
			this.gunXpModifier = (float)this.trackBar6.Value;
			this.numericUpDown6.Value = this.trackBar6.Value;
		}

		// Token: 0x06000013 RID: 19
		private void numericUpDown6_ValueChanged(object sender, EventArgs e)
		{
			this.gunXpModifier = (float)this.numericUpDown6.Value;
			this.trackBar6.Value = (int)this.numericUpDown6.Value;
		}

		// Token: 0x06000014 RID: 20
		private void trackBar7_Scroll(object sender, EventArgs e)
		{
			this.xpModifier = (float)this.trackBar7.Value;
			this.numericUpDown7.Value = this.trackBar7.Value;
		}

		// Token: 0x06000015 RID: 21
		private void numericUpDown7_ValueChanged(object sender, EventArgs e)
		{
			this.xpModifier = (float)this.numericUpDown7.Value;
			this.trackBar7.Value = (int)this.numericUpDown7.Value;
		}

		// Token: 0x06000016 RID: 22
		private void label3_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000017 RID: 23
		private void txtConsole_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000018 RID: 24
		private void lblGameRunning_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000019 RID: 25
		private void checkBox8_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600001A RID: 26
		public void UpdatePlayerPosition(Vector3 pos)
		{
			byte[] array = new byte[12];
			Buffer.BlockCopy(BitConverter.GetBytes(pos.X), 0, array, 0, 4);
			Buffer.BlockCopy(BitConverter.GetBytes(pos.Y), 0, array, 4, 4);
			Buffer.BlockCopy(BitConverter.GetBytes(pos.Z), 0, array, 8, 4);
			IntPtr intPtr;
			cwapi.WriteProcessMemory(this.hProc, this.PlayerPedPtr + 724, array, 12L, out intPtr);
		}

		// Token: 0x0600001B RID: 27
		private void lblZombiesLeft_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600001C RID: 28
		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600001D RID: 29
		private void checkBox9_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600001E RID: 30
		private void checkBox7_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600001F RID: 31
		private void checkBox4_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000020 RID: 32
		private void button3_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000021 RID: 33
		private void checkBox9_CheckedChanged_1(object sender, EventArgs e)
		{
		}

		// Token: 0x06000022 RID: 34
		private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
		{
		}

		// Token: 0x06000023 RID: 35
		private void checkBox2_CheckedChanged_2(object sender, EventArgs e)
		{
		}

		// Token: 0x06000024 RID: 36
		private void checkBox2_CheckedChanged_3(object sender, EventArgs e)
		{
		}

		// Token: 0x06000025 RID: 37
		private void checkBox9_CheckedChanged_2(object sender, EventArgs e)
		{
		}

		// Token: 0x06000026 RID: 38
		private void checkBox10_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000027 RID: 39
		private void checkBox5_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000028 RID: 40
		private void checkBox10_CheckedChanged_1(object sender, EventArgs e)
		{
		}

		// Token: 0x06000029 RID: 41
		private void checkBox10_CheckedChanged_2(object sender, EventArgs e)
		{
		}

		// Token: 0x0600002A RID: 42
		private void checkBox10_CheckedChanged_3(object sender, EventArgs e)
		{
		}

		// Token: 0x0600002B RID: 43
		public void ConsoleOut(string str)
		{
			if (base.InvokeRequired)
			{
				base.Invoke(new Action<string>(this.ConsoleOut), new object[]
				{
					str
				});
				return;
			}
			DateTime now = DateTime.Now;
			this.txtConsole.AppendText(now.ToString("d-MMM-yyyy HH:mm:ss - ") + str + Environment.NewLine);
		}

		// Token: 0x0600002C RID: 44
		public void UpdateLabel(Label label, string text, string color = "Black")
		{
			if (base.InvokeRequired)
			{
				label.Invoke(new MethodInvoker(delegate()
				{
					label.Text = text;
					label.ForeColor = Color.FromName(color);
				}));
				return;
			}
			label.Text = text;
			label.ForeColor = Color.FromName(color);
		}

		// Token: 0x0600002D RID: 45
		public string ToHex(object num)
		{
			return string.Format("0x{0:X}", num);
		}

		// Token: 0x0600002E RID: 46
		public double ConvertToRadians(double angle)
		{
			return 0.017453292519943295 * angle;
		}

		// Token: 0x04000001 RID: 1
		public int gamePID;

		// Token: 0x04000002 RID: 2
		public IntPtr hProc;

		// Token: 0x04000003 RID: 3
		public IntPtr baseAddress = IntPtr.Zero;

		// Token: 0x04000004 RID: 4
		public Color defaultColor = Color.Black;

		// Token: 0x04000005 RID: 5
		public bool trainerOn;

		// Token: 0x04000006 RID: 6
		public Process gameProc;

		// Token: 0x04000007 RID: 7
		public float playerSpeed = -1f;

		// Token: 0x04000008 RID: 8
		public int zmTeleportDistance = 150;

		// Token: 0x04000009 RID: 9
		public bool ammoFrozen;

		// Token: 0x0400000A RID: 10
		public int[] ammoVals = new int[6];

		// Token: 0x0400000B RID: 11
		public int[] maxAmmoVals = new int[6];

		// Token: 0x0400000C RID: 12
		public bool freezePlayer;

		// Token: 0x0400000D RID: 13
		public Vector3 frozenPlayerPos = Vector3.Zero;

		// Token: 0x0400000E RID: 14
		public Vector3 lastKnownPlayerPos = Vector3.Zero;

		// Token: 0x0400000F RID: 15
		public Vector3 updatedPlayerPos = Vector3.Zero;

		// Token: 0x04000010 RID: 16
		public float xpModifier = 1f;

		// Token: 0x04000011 RID: 17
		public float gunXpModifier = 1f;

		// Token: 0x04000012 RID: 18
		public IntPtr PlayerBase = (IntPtr)0xF41F4C8;

		// Token: 0x04000013 RID: 19
		public IntPtr ZMXPScaleBase = (IntPtr)0;

		// Token: 0x04000014 RID: 20
		public IntPtr TimeScaleBase = (IntPtr)0xE4ED974;

		// Token: 0x04000015 RID: 21
		public IntPtr CMDBufferBase = (IntPtr)0x10DD4A80;

		// Token: 0x04000016 RID: 22
		public IntPtr XPScaleZM = (IntPtr)265479520;

		// Token: 0x04000017 RID: 23
		public IntPtr GunXPScaleZM = (IntPtr)265479536;

		// Token: 0x04000018 RID: 24
		public IntPtr PlayerCompPtr;

		// Token: 0x04000019 RID: 25
		public IntPtr PlayerPedPtr;

		// Token: 0x0400001A RID: 26
		public IntPtr ZMGlobalBase;

		// Token: 0x0400001B RID: 27
		public IntPtr ZMBotBase;

		// Token: 0x0400001C RID: 28
		public IntPtr ZMBotListBase;

		// Token: 0x0400001D RID: 29
		public const int PC_ArraySize_Offset = 47152;

		// Token: 0x0400001E RID: 30
		public const int PC_CurrentUsedWeaponID = 40;

		// Token: 0x0400001F RID: 31
		public const int PC_SetWeaponID = 176;

		// Token: 0x04000020 RID: 32
		public const int PC_InfraredVision = 3686;

		// Token: 0x04000021 RID: 33
		public const int PC_GodMode = 3687;

		// Token: 0x04000022 RID: 34
		public const int PC_RapidFire1 = 3692;

		// Token: 0x04000023 RID: 35
		public const int PC_RapidFire2 = 3712;

		// Token: 0x04000024 RID: 36
		public const int PC_MaxAmmo = 4960;

		// Token: 0x04000025 RID: 37
		public const int PC_Ammo = 5076;

		// Token: 0x04000026 RID: 38
		public const int PC_Points = 23780;

		// Token: 0x04000027 RID: 39
		public const int PC_Name = 23514;

		// Token: 0x04000028 RID: 40
		public const int PC_RunSpeed = 23600;

		// Token: 0x04000029 RID: 41
		public const int PC_ClanTags = 24668;

		// Token: 0x0400002A RID: 42
		public const int PP_ArraySize_Offset = 1528;

		// Token: 0x0400002B RID: 43
		public const int PP_Health = 920;

		// Token: 0x0400002C RID: 44
		public const int PP_MaxHealth = 924;

		// Token: 0x0400002D RID: 45
		public const int PP_Coords = 724;

		// Token: 0x0400002E RID: 46
		public const int PP_Heading_Z = 52;

		// Token: 0x0400002F RID: 47
		public const int PP_Heading_XY = 56;

		// Token: 0x04000030 RID: 48
		public const int ZM_Global_ZombiesIgnoreAll = 20;

		// Token: 0x04000031 RID: 49
		public const int ZM_Global_ZMLeftCount = 60;

		// Token: 0x04000032 RID: 50
		public const int ZM_Bot_List_Offset = 8;

		// Token: 0x04000033 RID: 51
		public const int ZM_Bot_ArraySize_Offset = 1528;

		// Token: 0x04000034 RID: 52
		public const int ZM_Bot_Health = 920;

		// Token: 0x04000035 RID: 53
		public const int ZM_Bot_MaxHealth = 924;

		// Token: 0x04000036 RID: 54
		public const int ZM_Bot_Coords = 724;

		// Token: 0x04000037 RID: 55
		public const int XPEP_Offset = 32;

		// Token: 0x04000038 RID: 56
		public const int XPUNK01_Offset = 36;

		// Token: 0x04000039 RID: 57
		public const int XPUNK02_Offset = 40;

		// Token: 0x0400003A RID: 58
		public const int XPUNK03_Offset = 44;

		// Token: 0x0400003B RID: 59
		public const int XPGun_Offset = 48;

		// Token: 0x0400003C RID: 60
		public const int XPUNK04_Offset = 52;

		// Token: 0x0400003D RID: 61
		public const int XPUNK05_Offset = 56;

		// Token: 0x0400003E RID: 62
		public const int XPUNK06_Offset = 60;

		// Token: 0x0400003F RID: 63
		public const int XPUNK07_Offset = 64;

		// Token: 0x04000040 RID: 64
		public const int XPUNK08_Offset = 68;

		// Token: 0x04000041 RID: 65
		public const int XPUNK09_Offset = 72;

		// Token: 0x04000042 RID: 66
		public const int XPUNK10_Offset = 76;

		// Token: 0x04000043 RID: 67
		public const int CMDBB_Exec = -27;
	}
}
