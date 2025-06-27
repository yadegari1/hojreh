using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using FruitBox.My.Resources;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x02000082 RID: 130
	[DesignerGenerated]
	public partial class Frm_Splash : Form
	{
		// Token: 0x06000B7C RID: 2940 RVA: 0x0000451D File Offset: 0x0000271D
		[DebuggerNonUserCode]
		public Frm_Splash()
		{
			base.Load += new EventHandler(this.Frm_Splash_Load);
			Frm_Splash.__ENCAddToList(this);
			this.InitializeComponent();
		}

		// Token: 0x06000B7D RID: 2941 RVA: 0x000905D4 File Offset: 0x0008E7D4
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_Splash.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_Splash.__ENCList.Count == Frm_Splash.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_Splash.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_Splash.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_Splash.__ENCList[num] = Frm_Splash.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_Splash.__ENCList.RemoveRange(num, Frm_Splash.__ENCList.Count - num);
						Frm_Splash.__ENCList.Capacity = Frm_Splash.__ENCList.Count;
					}
					Frm_Splash.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x1700038E RID: 910
		// (get) Token: 0x06000B80 RID: 2944 RVA: 0x00090B3C File Offset: 0x0008ED3C
		// (set) Token: 0x06000B81 RID: 2945 RVA: 0x00004549 File Offset: 0x00002749
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
				this._Timer1 = value;
			}
		}

		// Token: 0x1700038F RID: 911
		// (get) Token: 0x06000B82 RID: 2946 RVA: 0x00090B54 File Offset: 0x0008ED54
		// (set) Token: 0x06000B83 RID: 2947 RVA: 0x00004553 File Offset: 0x00002753
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

		// Token: 0x17000390 RID: 912
		// (get) Token: 0x06000B84 RID: 2948 RVA: 0x00090B6C File Offset: 0x0008ED6C
		// (set) Token: 0x06000B85 RID: 2949 RVA: 0x0000455D File Offset: 0x0000275D
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

		// Token: 0x17000391 RID: 913
		// (get) Token: 0x06000B86 RID: 2950 RVA: 0x00090B84 File Offset: 0x0008ED84
		// (set) Token: 0x06000B87 RID: 2951 RVA: 0x00004567 File Offset: 0x00002767
		internal virtual Label lbl_ver
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_ver;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_ver = value;
			}
		}

		// Token: 0x17000392 RID: 914
		// (get) Token: 0x06000B88 RID: 2952 RVA: 0x00090B9C File Offset: 0x0008ED9C
		// (set) Token: 0x06000B89 RID: 2953 RVA: 0x00004571 File Offset: 0x00002771
		internal virtual Label lbl_owner
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_owner;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_owner = value;
			}
		}

		// Token: 0x06000B8A RID: 2954 RVA: 0x00090BB4 File Offset: 0x0008EDB4
		private void Frm_Splash_Load(object sender, EventArgs e)
		{
			string text = Assembly.GetEntryAssembly().GetName().Version.ToString();
			bool flag = text.EndsWith(".0.0");
			if (flag)
			{
				this.lbl_ver.Text = text.Replace(".0.0", "");
			}
			else
			{
				flag = text.EndsWith(".0");
				if (flag)
				{
					this.lbl_ver.Text = text.Remove(checked(text.Length - 2), 2);
				}
				else
				{
					this.lbl_ver.Text = text;
				}
			}
		}

		// Token: 0x04000487 RID: 1159
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000489 RID: 1161
		[AccessedThroughProperty("Timer1")]
		private Timer _Timer1;

		// Token: 0x0400048A RID: 1162
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x0400048B RID: 1163
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x0400048C RID: 1164
		[AccessedThroughProperty("lbl_ver")]
		private Label _lbl_ver;

		// Token: 0x0400048D RID: 1165
		[AccessedThroughProperty("lbl_owner")]
		private Label _lbl_owner;
	}
}
