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
	// Token: 0x02000083 RID: 131
	[DesignerGenerated]
	public partial class Frm_Splash2 : Form
	{
		// Token: 0x06000B8C RID: 2956 RVA: 0x00004588 File Offset: 0x00002788
		[DebuggerNonUserCode]
		public Frm_Splash2()
		{
			base.Load += new EventHandler(this.Frm_Splash_Load);
			Frm_Splash2.__ENCAddToList(this);
			this.InitializeComponent();
		}

		// Token: 0x06000B8D RID: 2957 RVA: 0x00090C44 File Offset: 0x0008EE44
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_Splash2.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_Splash2.__ENCList.Count == Frm_Splash2.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_Splash2.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_Splash2.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_Splash2.__ENCList[num] = Frm_Splash2.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_Splash2.__ENCList.RemoveRange(num, Frm_Splash2.__ENCList.Count - num);
						Frm_Splash2.__ENCList.Capacity = Frm_Splash2.__ENCList.Count;
					}
					Frm_Splash2.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000393 RID: 915
		// (get) Token: 0x06000B90 RID: 2960 RVA: 0x000911A8 File Offset: 0x0008F3A8
		// (set) Token: 0x06000B91 RID: 2961 RVA: 0x000045B4 File Offset: 0x000027B4
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

		// Token: 0x17000394 RID: 916
		// (get) Token: 0x06000B92 RID: 2962 RVA: 0x000911C0 File Offset: 0x0008F3C0
		// (set) Token: 0x06000B93 RID: 2963 RVA: 0x000045BE File Offset: 0x000027BE
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

		// Token: 0x17000395 RID: 917
		// (get) Token: 0x06000B94 RID: 2964 RVA: 0x000911D8 File Offset: 0x0008F3D8
		// (set) Token: 0x06000B95 RID: 2965 RVA: 0x000045C8 File Offset: 0x000027C8
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

		// Token: 0x17000396 RID: 918
		// (get) Token: 0x06000B96 RID: 2966 RVA: 0x000911F0 File Offset: 0x0008F3F0
		// (set) Token: 0x06000B97 RID: 2967 RVA: 0x000045D2 File Offset: 0x000027D2
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

		// Token: 0x17000397 RID: 919
		// (get) Token: 0x06000B98 RID: 2968 RVA: 0x00091208 File Offset: 0x0008F408
		// (set) Token: 0x06000B99 RID: 2969 RVA: 0x000045DC File Offset: 0x000027DC
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

		// Token: 0x06000B9A RID: 2970 RVA: 0x00091220 File Offset: 0x0008F420
		private void Frm_Splash_Load(object sender, EventArgs e)
		{
			string text = Assembly.GetEntryAssembly().GetName().Version.ToString();
			bool flag = text.EndsWith(".0.0");
			if (flag)
			{
				this.lbl_ver.Text = text.Replace(".0.0", "");
			}
			flag = text.EndsWith(".0");
			if (flag)
			{
				this.lbl_ver.Text = text.Remove(checked(text.Length - 2), 2);
			}
		}

		// Token: 0x0400048E RID: 1166
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000490 RID: 1168
		[AccessedThroughProperty("Timer1")]
		private Timer _Timer1;

		// Token: 0x04000491 RID: 1169
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04000492 RID: 1170
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x04000493 RID: 1171
		[AccessedThroughProperty("lbl_ver")]
		private Label _lbl_ver;

		// Token: 0x04000494 RID: 1172
		[AccessedThroughProperty("lbl_owner")]
		private Label _lbl_owner;
	}
}
