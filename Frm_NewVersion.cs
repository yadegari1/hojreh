using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using FruitBox.My.Resources;
using Janus.Windows.EditControls;
using Janus.Windows.UI;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x02000071 RID: 113
	[DesignerGenerated]
	public partial class Frm_NewVersion : Form
	{
		// Token: 0x060008D1 RID: 2257 RVA: 0x00079A98 File Offset: 0x00077C98
		[DebuggerNonUserCode]
		public Frm_NewVersion()
		{
			base.FormClosing += new FormClosingEventHandler(this.Frm_NewVersion_FormClosing);
			base.KeyDown += new KeyEventHandler(this.Frm_NewVersion_KeyDown);
			base.Load += new EventHandler(this.Frm_NewVersion_Load);
			Frm_NewVersion.__ENCAddToList(this);
			this.InitializeComponent();
		}

		// Token: 0x060008D2 RID: 2258 RVA: 0x00079AF8 File Offset: 0x00077CF8
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_NewVersion.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_NewVersion.__ENCList.Count == Frm_NewVersion.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_NewVersion.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_NewVersion.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_NewVersion.__ENCList[num] = Frm_NewVersion.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_NewVersion.__ENCList.RemoveRange(num, Frm_NewVersion.__ENCList.Count - num);
						Frm_NewVersion.__ENCList.Capacity = Frm_NewVersion.__ENCList.Count;
					}
					Frm_NewVersion.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x060008D5 RID: 2261 RVA: 0x0007A498 File Offset: 0x00078698
		// (set) Token: 0x060008D6 RID: 2262 RVA: 0x000039CC File Offset: 0x00001BCC
		internal virtual PanelEx PanelEx3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PanelEx3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PanelEx3 = value;
			}
		}

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x060008D7 RID: 2263 RVA: 0x0007A4B0 File Offset: 0x000786B0
		// (set) Token: 0x060008D8 RID: 2264 RVA: 0x0007A4C8 File Offset: 0x000786C8
		internal virtual UIButton UiButton11
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiButton11;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.UiButton11_Click);
				bool flag = this._UiButton11 != null;
				if (flag)
				{
					this._UiButton11.Click -= value2;
				}
				this._UiButton11 = value;
				flag = (this._UiButton11 != null);
				if (flag)
				{
					this._UiButton11.Click += value2;
				}
			}
		}

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x060008D9 RID: 2265 RVA: 0x0007A528 File Offset: 0x00078728
		// (set) Token: 0x060008DA RID: 2266 RVA: 0x0007A540 File Offset: 0x00078740
		internal virtual UIButton UiButton10
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiButton10;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.UiButton10_Click);
				bool flag = this._UiButton10 != null;
				if (flag)
				{
					this._UiButton10.Click -= value2;
				}
				this._UiButton10 = value;
				flag = (this._UiButton10 != null);
				if (flag)
				{
					this._UiButton10.Click += value2;
				}
			}
		}

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x060008DB RID: 2267 RVA: 0x0007A5A0 File Offset: 0x000787A0
		// (set) Token: 0x060008DC RID: 2268 RVA: 0x000039D6 File Offset: 0x00001BD6
		internal virtual PictureBox PictureBox3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PictureBox3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PictureBox3 = value;
			}
		}

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x060008DD RID: 2269 RVA: 0x0007A5B8 File Offset: 0x000787B8
		// (set) Token: 0x060008DE RID: 2270 RVA: 0x000039E0 File Offset: 0x00001BE0
		internal virtual Label Label11
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label11;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label11 = value;
			}
		}

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x060008DF RID: 2271 RVA: 0x0007A5D0 File Offset: 0x000787D0
		// (set) Token: 0x060008E0 RID: 2272 RVA: 0x000039EA File Offset: 0x00001BEA
		internal virtual Label Label10
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label10;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label10 = value;
			}
		}

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x060008E1 RID: 2273 RVA: 0x0007A5E8 File Offset: 0x000787E8
		// (set) Token: 0x060008E2 RID: 2274 RVA: 0x000039F4 File Offset: 0x00001BF4
		internal virtual TextBox txt_help
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_help;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_help = value;
			}
		}

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x060008E3 RID: 2275 RVA: 0x0007A600 File Offset: 0x00078800
		// (set) Token: 0x060008E4 RID: 2276 RVA: 0x000039FE File Offset: 0x00001BFE
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

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x060008E5 RID: 2277 RVA: 0x0007A618 File Offset: 0x00078818
		// (set) Token: 0x060008E6 RID: 2278 RVA: 0x00003A08 File Offset: 0x00001C08
		internal virtual UICheckBox txt_show
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_show;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_show = value;
			}
		}

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x060008E7 RID: 2279 RVA: 0x0007A630 File Offset: 0x00078830
		// (set) Token: 0x060008E8 RID: 2280 RVA: 0x00003A12 File Offset: 0x00001C12
		public string Version
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Version;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Version = value;
			}
		}

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x060008E9 RID: 2281 RVA: 0x0007A648 File Offset: 0x00078848
		// (set) Token: 0x060008EA RID: 2282 RVA: 0x00003A1C File Offset: 0x00001C1C
		public string HelpText
		{
			[DebuggerNonUserCode]
			get
			{
				return this._HelpText;
			}
			[DebuggerNonUserCode]
			set
			{
				this._HelpText = value;
			}
		}

		// Token: 0x060008EB RID: 2283 RVA: 0x00003A26 File Offset: 0x00001C26
		private void UiButton11_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		// Token: 0x060008EC RID: 2284 RVA: 0x0007A660 File Offset: 0x00078860
		private void UiButton10_Click(object sender, EventArgs e)
		{
			string fileName = "https://www.hojreh-app.ir";
			Process.Start(fileName);
			this.Close();
		}

		// Token: 0x060008ED RID: 2285 RVA: 0x0007A684 File Offset: 0x00078884
		private void Frm_NewVersion_FormClosing(object sender, FormClosingEventArgs e)
		{
			setting setting = new setting();
			setting.Update("show_newversion", Conversions.ToString(!this.txt_show.Checked));
			Public_Function.dict["show_newversion"] = Conversions.ToString(!this.txt_show.Checked);
		}

		// Token: 0x060008EE RID: 2286 RVA: 0x0006620C File Offset: 0x0006440C
		private void Frm_NewVersion_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Escape;
			if (flag)
			{
				this.Close();
			}
		}

		// Token: 0x060008EF RID: 2287 RVA: 0x0007A6DC File Offset: 0x000788DC
		private void Frm_NewVersion_Load(object sender, EventArgs e)
		{
			string text = "نسخه " + this.Version + " نرم افزار منتشر شد";
			this.Label10.Text = text;
			string[] array = this.HelpText.Split(new char[]
			{
				Conversions.ToChar(Environment.NewLine)
			});
			this.txt_help.Text = this.HelpText;
		}

		// Token: 0x04000371 RID: 881
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000373 RID: 883
		[AccessedThroughProperty("PanelEx3")]
		private PanelEx _PanelEx3;

		// Token: 0x04000374 RID: 884
		[AccessedThroughProperty("UiButton11")]
		private UIButton _UiButton11;

		// Token: 0x04000375 RID: 885
		[AccessedThroughProperty("UiButton10")]
		private UIButton _UiButton10;

		// Token: 0x04000376 RID: 886
		[AccessedThroughProperty("PictureBox3")]
		private PictureBox _PictureBox3;

		// Token: 0x04000377 RID: 887
		[AccessedThroughProperty("Label11")]
		private Label _Label11;

		// Token: 0x04000378 RID: 888
		[AccessedThroughProperty("Label10")]
		private Label _Label10;

		// Token: 0x04000379 RID: 889
		[AccessedThroughProperty("txt_help")]
		private TextBox _txt_help;

		// Token: 0x0400037A RID: 890
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x0400037B RID: 891
		[AccessedThroughProperty("txt_show")]
		private UICheckBox _txt_show;

		// Token: 0x0400037C RID: 892
		[CompilerGenerated]
		private string _Version;

		// Token: 0x0400037D RID: 893
		[CompilerGenerated]
		private string _HelpText;
	}
}
