using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x02000064 RID: 100
	[DesignerGenerated]
	public partial class Frm_cmd : Form
	{
		// Token: 0x06000709 RID: 1801 RVA: 0x0006BD74 File Offset: 0x00069F74
		[DebuggerNonUserCode]
		public Frm_cmd()
		{
			base.Load += new EventHandler(this.Frm_cmd_Load);
			base.FormClosing += new FormClosingEventHandler(this.Frm_cmd_FormClosing);
			base.KeyDown += new KeyEventHandler(this.Frm_cmd_KeyDown);
			Frm_cmd.__ENCAddToList(this);
			this.InitializeComponent();
		}

		// Token: 0x0600070A RID: 1802 RVA: 0x0006BDD4 File Offset: 0x00069FD4
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_cmd.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_cmd.__ENCList.Count == Frm_cmd.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_cmd.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_cmd.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_cmd.__ENCList[num] = Frm_cmd.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_cmd.__ENCList.RemoveRange(num, Frm_cmd.__ENCList.Count - num);
						Frm_cmd.__ENCList.Capacity = Frm_cmd.__ENCList.Count;
					}
					Frm_cmd.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x0600070D RID: 1805 RVA: 0x0006C10C File Offset: 0x0006A30C
		// (set) Token: 0x0600070E RID: 1806 RVA: 0x000030E7 File Offset: 0x000012E7
		internal virtual TextBox TextBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TextBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TextBox1 = value;
			}
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x0600070F RID: 1807 RVA: 0x0006C124 File Offset: 0x0006A324
		// (set) Token: 0x06000710 RID: 1808 RVA: 0x0006C13C File Offset: 0x0006A33C
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

		// Token: 0x06000711 RID: 1809 RVA: 0x0006C19C File Offset: 0x0006A39C
		private void Button1_Click(object sender, EventArgs e)
		{
			bool flag = Public_Function.ExecuteNonQuery(this.TextBox1.Text);
			if (flag)
			{
				MessageBox.Show("OK");
				Public_Function.SetFarsi();
				this.Close();
			}
			else
			{
				MessageBox.Show("Error");
			}
		}

		// Token: 0x06000712 RID: 1810 RVA: 0x000030F1 File Offset: 0x000012F1
		private void Frm_cmd_FormClosing(object sender, FormClosingEventArgs e)
		{
			Public_Function.SetFarsi();
		}

		// Token: 0x06000713 RID: 1811 RVA: 0x0006620C File Offset: 0x0006440C
		private void Frm_cmd_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Escape;
			if (flag)
			{
				this.Close();
			}
		}

		// Token: 0x06000714 RID: 1812 RVA: 0x000030FB File Offset: 0x000012FB
		private void Frm_cmd_Load(object sender, EventArgs e)
		{
			Public_Function.SetEnglish();
		}

		// Token: 0x040002AD RID: 685
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x040002AF RID: 687
		[AccessedThroughProperty("TextBox1")]
		private TextBox _TextBox1;

		// Token: 0x040002B0 RID: 688
		[AccessedThroughProperty("Button1")]
		private Button _Button1;
	}
}
