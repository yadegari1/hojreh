using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x0200005F RID: 95
	[DesignerGenerated]
	public partial class Frm_Backup : Form
	{
		// Token: 0x06000683 RID: 1667 RVA: 0x00002EF1 File Offset: 0x000010F1
		[DebuggerNonUserCode]
		public Frm_Backup()
		{
			base.Load += new EventHandler(this.Frm_Backup_Load);
			Frm_Backup.__ENCAddToList(this);
			this.InitializeComponent();
		}

		// Token: 0x06000684 RID: 1668 RVA: 0x000665D0 File Offset: 0x000647D0
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_Backup.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_Backup.__ENCList.Count == Frm_Backup.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_Backup.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_Backup.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_Backup.__ENCList[num] = Frm_Backup.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_Backup.__ENCList.RemoveRange(num, Frm_Backup.__ENCList.Count - num);
						Frm_Backup.__ENCList.Capacity = Frm_Backup.__ENCList.Count;
					}
					Frm_Backup.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x06000687 RID: 1671 RVA: 0x00066C94 File Offset: 0x00064E94
		// (set) Token: 0x06000688 RID: 1672 RVA: 0x00002F1D File Offset: 0x0000111D
		internal virtual PanelEx PanelEx2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PanelEx2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PanelEx2 = value;
			}
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x06000689 RID: 1673 RVA: 0x00066CAC File Offset: 0x00064EAC
		// (set) Token: 0x0600068A RID: 1674 RVA: 0x00002F27 File Offset: 0x00001127
		internal virtual Label Label1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label1 = value;
			}
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x0600068B RID: 1675 RVA: 0x00066CC4 File Offset: 0x00064EC4
		// (set) Token: 0x0600068C RID: 1676 RVA: 0x00002F31 File Offset: 0x00001131
		internal virtual Label Label2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label2 = value;
			}
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x0600068D RID: 1677 RVA: 0x00066CDC File Offset: 0x00064EDC
		// (set) Token: 0x0600068E RID: 1678 RVA: 0x00002F3B File Offset: 0x0000113B
		internal virtual CircularProgress CircularProgress1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._CircularProgress1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._CircularProgress1 = value;
			}
		}

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x0600068F RID: 1679 RVA: 0x00066CF4 File Offset: 0x00064EF4
		// (set) Token: 0x06000690 RID: 1680 RVA: 0x00066D0C File Offset: 0x00064F0C
		internal virtual Timer Timer1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Timer1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Timer1_Tick);
				bool flag = this._Timer1 != null;
				if (flag)
				{
					this._Timer1.Tick -= value2;
				}
				this._Timer1 = value;
				flag = (this._Timer1 != null);
				if (flag)
				{
					this._Timer1.Tick += value2;
				}
			}
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x06000691 RID: 1681 RVA: 0x00066D6C File Offset: 0x00064F6C
		// (set) Token: 0x06000692 RID: 1682 RVA: 0x00066D84 File Offset: 0x00064F84
		internal virtual Timer Timer2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Timer2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Timer2_Tick);
				bool flag = this._Timer2 != null;
				if (flag)
				{
					this._Timer2.Tick -= value2;
				}
				this._Timer2 = value;
				flag = (this._Timer2 != null);
				if (flag)
				{
					this._Timer2.Tick += value2;
				}
			}
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x06000693 RID: 1683 RVA: 0x00066DE4 File Offset: 0x00064FE4
		// (set) Token: 0x06000694 RID: 1684 RVA: 0x00002F45 File Offset: 0x00001145
		internal virtual PictureBox PictureBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PictureBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PictureBox1 = value;
			}
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x06000695 RID: 1685 RVA: 0x00066DFC File Offset: 0x00064FFC
		// (set) Token: 0x06000696 RID: 1686 RVA: 0x00002F4F File Offset: 0x0000114F
		public string Path
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Path;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Path = value;
			}
		}

		// Token: 0x06000697 RID: 1687 RVA: 0x00066E14 File Offset: 0x00065014
		private void BackUpDataBase(string filename)
		{
			string command = "BACKUP DATABASE " + Public_Function.dict["dbname"] + " TO DISK=" + Public_Function.GetValue(filename);
			Public_Function.ExecuteScalar(command);
		}

		// Token: 0x06000698 RID: 1688 RVA: 0x0000205D File Offset: 0x0000025D
		private void Frm_Backup_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000699 RID: 1689 RVA: 0x00066E50 File Offset: 0x00065050
		private void Timer1_Tick(object sender, EventArgs e)
		{
			this.Timer1.Enabled = false;
			string str = string.Concat(new string[]
			{
				"tazmin-",
				Public_Function.MiladiToShamsi(DateAndTime.Now).Replace("/", ""),
				"-",
				Conversions.ToString(DateAndTime.Hour(DateAndTime.Now)),
				Conversions.ToString(DateAndTime.Minute(DateAndTime.Now))
			});
			this.BackUpDataBase(this.Path + "\\" + str);
			this.Timer2.Enabled = false;
			Public_Function.ShowMessage("پشتیبان گیری با موفقیت انجام شد", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, null);
			this.Close();
		}

		// Token: 0x0600069A RID: 1690 RVA: 0x00066F0C File Offset: 0x0006510C
		private void Timer2_Tick(object sender, EventArgs e)
		{
			bool flag = this.CircularProgress1.Value == 100;
			if (flag)
			{
				this.CircularProgress1.Value = 0;
			}
			CircularProgress circularProgress = this.CircularProgress1;
			checked
			{
				circularProgress.Value += 10;
			}
		}

		// Token: 0x04000278 RID: 632
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x0400027A RID: 634
		[AccessedThroughProperty("PanelEx2")]
		private PanelEx _PanelEx2;

		// Token: 0x0400027B RID: 635
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x0400027C RID: 636
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x0400027D RID: 637
		[AccessedThroughProperty("CircularProgress1")]
		private CircularProgress _CircularProgress1;

		// Token: 0x0400027E RID: 638
		[AccessedThroughProperty("Timer1")]
		private Timer _Timer1;

		// Token: 0x0400027F RID: 639
		[AccessedThroughProperty("Timer2")]
		private Timer _Timer2;

		// Token: 0x04000280 RID: 640
		[AccessedThroughProperty("PictureBox1")]
		private PictureBox _PictureBox1;

		// Token: 0x04000281 RID: 641
		[CompilerGenerated]
		private string _Path;
	}
}
