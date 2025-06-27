using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Janus.Windows.GridEX;
using Microsoft.VisualBasic.CompilerServices;
using RestSharp;

namespace FruitBox
{
	// Token: 0x020000BE RID: 190
	[DesignerGenerated]
	public partial class Form2 : Form
	{
		// Token: 0x06000F00 RID: 3840 RVA: 0x00005453 File Offset: 0x00003653
		[DebuggerNonUserCode]
		public Form2()
		{
			base.Load += new EventHandler(this.Form2_Load);
			Form2.__ENCAddToList(this);
			this.InitializeComponent();
		}

		// Token: 0x06000F01 RID: 3841 RVA: 0x000AAF94 File Offset: 0x000A9194
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Form2.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Form2.__ENCList.Count == Form2.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Form2.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Form2.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Form2.__ENCList[num] = Form2.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Form2.__ENCList.RemoveRange(num, Form2.__ENCList.Count - num);
						Form2.__ENCList.Capacity = Form2.__ENCList.Count;
					}
					Form2.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x1700044F RID: 1103
		// (get) Token: 0x06000F04 RID: 3844 RVA: 0x000AB334 File Offset: 0x000A9534
		// (set) Token: 0x06000F05 RID: 3845 RVA: 0x000AB34C File Offset: 0x000A954C
		internal virtual Button Button1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button1_Click);
				bool flag = this._Button1 != null;
				if (flag)
				{
					this._Button1.Click -= value2;
				}
				this._Button1 = value;
				flag = (this._Button1 != null);
				if (flag)
				{
					this._Button1.Click += value2;
				}
			}
		}

		// Token: 0x17000450 RID: 1104
		// (get) Token: 0x06000F06 RID: 3846 RVA: 0x000AB3AC File Offset: 0x000A95AC
		// (set) Token: 0x06000F07 RID: 3847 RVA: 0x0000547F File Offset: 0x0000367F
		internal virtual DateBox2 txt_tarikh
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_tarikh;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_tarikh = value;
			}
		}

		// Token: 0x06000F08 RID: 3848 RVA: 0x000AB3C4 File Offset: 0x000A95C4
		private void Form2_Load(object sender, EventArgs e)
		{
			this.txt_tarikh.SetNew();
			RestClient arg_72_0 = new RestClient("https://api.ghasedak.io/v2/verification/send/simple");
			RestRequest restRequest = new RestRequest(Method.POST);
			restRequest.AddHeader("apikey", "64324a32575342595242642b716f2f33514264655439476a776e4a687066666a697063556468737a6462593d");
			restRequest.AddParameter("receptor", "09390244096");
			restRequest.AddParameter("type", "1");
			restRequest.AddParameter("template", "surathesab");
			restRequest.AddParameter("param1", "1398/01/01");
			arg_72_0.Execute(restRequest);
		}

		// Token: 0x06000F09 RID: 3849 RVA: 0x0000205D File Offset: 0x0000025D
		private void Button1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x040005CF RID: 1487
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x040005D1 RID: 1489
		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		// Token: 0x040005D2 RID: 1490
		[AccessedThroughProperty("txt_tarikh")]
		private DateBox2 _txt_tarikh;
	}
}
