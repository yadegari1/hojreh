using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using FruitBox.My.Resources;
using Janus.Windows.EditControls;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x0200005D RID: 93
	[DesignerGenerated]
	public partial class Frm_About : Form
	{
		// Token: 0x06000644 RID: 1604 RVA: 0x00002D8F File Offset: 0x00000F8F
		[DebuggerNonUserCode]
		public Frm_About()
		{
			Frm_About.__ENCAddToList(this);
			this.InitializeComponent();
		}

		// Token: 0x06000645 RID: 1605 RVA: 0x00064540 File Offset: 0x00062740
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_About.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_About.__ENCList.Count == Frm_About.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_About.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_About.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_About.__ENCList[num] = Frm_About.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_About.__ENCList.RemoveRange(num, Frm_About.__ENCList.Count - num);
						Frm_About.__ENCList.Capacity = Frm_About.__ENCList.Count;
					}
					Frm_About.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x06000648 RID: 1608 RVA: 0x00064D74 File Offset: 0x00062F74
		// (set) Token: 0x06000649 RID: 1609 RVA: 0x00002DA7 File Offset: 0x00000FA7
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

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x0600064A RID: 1610 RVA: 0x00064D8C File Offset: 0x00062F8C
		// (set) Token: 0x0600064B RID: 1611 RVA: 0x00002DB1 File Offset: 0x00000FB1
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

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x0600064C RID: 1612 RVA: 0x00064DA4 File Offset: 0x00062FA4
		// (set) Token: 0x0600064D RID: 1613 RVA: 0x00002DBB File Offset: 0x00000FBB
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

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x0600064E RID: 1614 RVA: 0x00064DBC File Offset: 0x00062FBC
		// (set) Token: 0x0600064F RID: 1615 RVA: 0x00002DC5 File Offset: 0x00000FC5
		internal virtual Label Label3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label3 = value;
			}
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x06000650 RID: 1616 RVA: 0x00064DD4 File Offset: 0x00062FD4
		// (set) Token: 0x06000651 RID: 1617 RVA: 0x00002DCF File Offset: 0x00000FCF
		internal virtual Label Label4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label4 = value;
			}
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x06000652 RID: 1618 RVA: 0x00064DEC File Offset: 0x00062FEC
		// (set) Token: 0x06000653 RID: 1619 RVA: 0x00002DD9 File Offset: 0x00000FD9
		internal virtual Label Label5
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label5;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label5 = value;
			}
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x06000654 RID: 1620 RVA: 0x00064E04 File Offset: 0x00063004
		// (set) Token: 0x06000655 RID: 1621 RVA: 0x00002DE3 File Offset: 0x00000FE3
		internal virtual Label Label6
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label6;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label6 = value;
			}
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x06000656 RID: 1622 RVA: 0x00064E1C File Offset: 0x0006301C
		// (set) Token: 0x06000657 RID: 1623 RVA: 0x00002DED File Offset: 0x00000FED
		internal virtual Label Label7
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label7;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label7 = value;
			}
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x06000658 RID: 1624 RVA: 0x00064E34 File Offset: 0x00063034
		// (set) Token: 0x06000659 RID: 1625 RVA: 0x00002DF7 File Offset: 0x00000FF7
		internal virtual UIGroupBox UiGroupBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiGroupBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._UiGroupBox1 = value;
			}
		}

		// Token: 0x0400025B RID: 603
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x0400025D RID: 605
		[AccessedThroughProperty("PictureBox1")]
		private PictureBox _PictureBox1;

		// Token: 0x0400025E RID: 606
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x0400025F RID: 607
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x04000260 RID: 608
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x04000261 RID: 609
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		// Token: 0x04000262 RID: 610
		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		// Token: 0x04000263 RID: 611
		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		// Token: 0x04000264 RID: 612
		[AccessedThroughProperty("Label7")]
		private Label _Label7;

		// Token: 0x04000265 RID: 613
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;
	}
}
