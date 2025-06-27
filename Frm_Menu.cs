using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using FruitBox.My.Resources;
using Janus.Windows.EditControls;
using Janus.Windows.UI.Dock;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x0200006F RID: 111
	[DesignerGenerated]
	public partial class Frm_Menu : Form
	{
		// Token: 0x06000892 RID: 2194 RVA: 0x000781AC File Offset: 0x000763AC
		public Frm_Menu()
		{
			base.KeyDown += new KeyEventHandler(this.Frm_Menu_KeyDown);
			base.Load += new EventHandler(this.Frm_Menu_Load);
			base.FormClosing += new FormClosingEventHandler(this.Frm_Menu_FormClosing);
			Frm_Menu.__ENCAddToList(this);
			int group_Index = 0;
			this.Group_Index = group_Index;
			this.InitializeComponent();
		}

		// Token: 0x06000893 RID: 2195 RVA: 0x00078218 File Offset: 0x00076418
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_Menu.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_Menu.__ENCList.Count == Frm_Menu.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_Menu.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_Menu.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_Menu.__ENCList[num] = Frm_Menu.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_Menu.__ENCList.RemoveRange(num, Frm_Menu.__ENCList.Count - num);
						Frm_Menu.__ENCList.Capacity = Frm_Menu.__ENCList.Count;
					}
					Frm_Menu.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x06000896 RID: 2198 RVA: 0x00078824 File Offset: 0x00076A24
		// (set) Token: 0x06000897 RID: 2199 RVA: 0x0000388E File Offset: 0x00001A8E
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

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x06000898 RID: 2200 RVA: 0x0007883C File Offset: 0x00076A3C
		// (set) Token: 0x06000899 RID: 2201 RVA: 0x00003898 File Offset: 0x00001A98
		internal virtual UIGroupBox UiGroupBox3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiGroupBox3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._UiGroupBox3 = value;
			}
		}

		// Token: 0x1700028A RID: 650
		// (get) Token: 0x0600089A RID: 2202 RVA: 0x00078854 File Offset: 0x00076A54
		// (set) Token: 0x0600089B RID: 2203 RVA: 0x000038A2 File Offset: 0x00001AA2
		internal virtual UIGroupBox UiGroupBox2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiGroupBox2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._UiGroupBox2 = value;
			}
		}

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x0600089C RID: 2204 RVA: 0x0007886C File Offset: 0x00076A6C
		// (set) Token: 0x0600089D RID: 2205 RVA: 0x000038AC File Offset: 0x00001AAC
		internal virtual UIGroupBox UiGroupBox4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiGroupBox4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._UiGroupBox4 = value;
			}
		}

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x0600089E RID: 2206 RVA: 0x00078884 File Offset: 0x00076A84
		// (set) Token: 0x0600089F RID: 2207 RVA: 0x000038B6 File Offset: 0x00001AB6
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

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x060008A0 RID: 2208 RVA: 0x0007889C File Offset: 0x00076A9C
		// (set) Token: 0x060008A1 RID: 2209 RVA: 0x000038C0 File Offset: 0x00001AC0
		public int Main_Menu_Index
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Main_Menu_Index;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Main_Menu_Index = value;
			}
		}

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x060008A2 RID: 2210 RVA: 0x000788B4 File Offset: 0x00076AB4
		// (set) Token: 0x060008A3 RID: 2211 RVA: 0x000038CA File Offset: 0x00001ACA
		public int sub_menu_index
		{
			[DebuggerNonUserCode]
			get
			{
				return this._sub_menu_index;
			}
			[DebuggerNonUserCode]
			set
			{
				this._sub_menu_index = value;
			}
		}

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x060008A4 RID: 2212 RVA: 0x000788CC File Offset: 0x00076ACC
		// (set) Token: 0x060008A5 RID: 2213 RVA: 0x000038D4 File Offset: 0x00001AD4
		public int Group_Index
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Group_Index;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Group_Index = value;
			}
		}

		// Token: 0x060008A6 RID: 2214 RVA: 0x000788E4 File Offset: 0x00076AE4
		private void Frm_Menu_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Escape;
			if (flag)
			{
				this.Hide();
			}
		}

		// Token: 0x060008A7 RID: 2215 RVA: 0x0000205D File Offset: 0x0000025D
		private void Frm_Menu_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x060008A8 RID: 2216 RVA: 0x000038DE File Offset: 0x00001ADE
		private void Frm_Menu_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
			this.Hide();
		}

		// Token: 0x04000357 RID: 855
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000359 RID: 857
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x0400035A RID: 858
		[AccessedThroughProperty("UiGroupBox3")]
		private UIGroupBox _UiGroupBox3;

		// Token: 0x0400035B RID: 859
		[AccessedThroughProperty("UiGroupBox2")]
		private UIGroupBox _UiGroupBox2;

		// Token: 0x0400035C RID: 860
		[AccessedThroughProperty("UiGroupBox4")]
		private UIGroupBox _UiGroupBox4;

		// Token: 0x0400035D RID: 861
		[AccessedThroughProperty("PictureBox1")]
		private PictureBox _PictureBox1;

		// Token: 0x0400035E RID: 862
		[CompilerGenerated]
		private int _Main_Menu_Index;

		// Token: 0x0400035F RID: 863
		[CompilerGenerated]
		private int _sub_menu_index;

		// Token: 0x04000360 RID: 864
		[CompilerGenerated]
		private int _Group_Index;
	}
}
