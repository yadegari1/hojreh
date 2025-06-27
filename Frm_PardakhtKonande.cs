using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using FruitBox.My.Resources;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.GridEX.EditControls;
using Janus.Windows.UI;
using Janus.Windows.UI.Dock;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x020000D5 RID: 213
	[DesignerGenerated]
	public partial class Frm_PardakhtKonande : Form
	{
		// Token: 0x060012CD RID: 4813 RVA: 0x000C9E40 File Offset: 0x000C8040
		public Frm_PardakhtKonande()
		{
			base.Load += new EventHandler(this.Frm_PardakhtKonande_Load);
			base.KeyDown += new KeyEventHandler(this.Frm_Anbar_KeyDown);
			Frm_PardakhtKonande.__ENCAddToList(this);
			this.p = new PardakhtKonande();
			this.InitializeComponent();
		}

		// Token: 0x060012CE RID: 4814 RVA: 0x000C9E98 File Offset: 0x000C8098
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_PardakhtKonande.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_PardakhtKonande.__ENCList.Count == Frm_PardakhtKonande.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_PardakhtKonande.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_PardakhtKonande.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_PardakhtKonande.__ENCList[num] = Frm_PardakhtKonande.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_PardakhtKonande.__ENCList.RemoveRange(num, Frm_PardakhtKonande.__ENCList.Count - num);
						Frm_PardakhtKonande.__ENCList.Capacity = Frm_PardakhtKonande.__ENCList.Count;
					}
					Frm_PardakhtKonande.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x170005D4 RID: 1492
		// (get) Token: 0x060012D1 RID: 4817 RVA: 0x000CB7E0 File Offset: 0x000C99E0
		// (set) Token: 0x060012D2 RID: 4818 RVA: 0x00006240 File Offset: 0x00004440
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

		// Token: 0x170005D5 RID: 1493
		// (get) Token: 0x060012D3 RID: 4819 RVA: 0x000CB7F8 File Offset: 0x000C99F8
		// (set) Token: 0x060012D4 RID: 4820 RVA: 0x0000624A File Offset: 0x0000444A
		internal virtual EditBox txt_name
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_name;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_name = value;
			}
		}

		// Token: 0x170005D6 RID: 1494
		// (get) Token: 0x060012D5 RID: 4821 RVA: 0x000CB810 File Offset: 0x000C9A10
		// (set) Token: 0x060012D6 RID: 4822 RVA: 0x00006254 File Offset: 0x00004454
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

		// Token: 0x170005D7 RID: 1495
		// (get) Token: 0x060012D7 RID: 4823 RVA: 0x000CB828 File Offset: 0x000C9A28
		// (set) Token: 0x060012D8 RID: 4824 RVA: 0x0000625E File Offset: 0x0000445E
		internal virtual Bar Bar1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Bar1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Bar1 = value;
			}
		}

		// Token: 0x170005D8 RID: 1496
		// (get) Token: 0x060012D9 RID: 4825 RVA: 0x000CB840 File Offset: 0x000C9A40
		// (set) Token: 0x060012DA RID: 4826 RVA: 0x00006268 File Offset: 0x00004468
		internal virtual ButtonItem ButtonItem1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ButtonItem1 = value;
			}
		}

		// Token: 0x170005D9 RID: 1497
		// (get) Token: 0x060012DB RID: 4827 RVA: 0x000CB858 File Offset: 0x000C9A58
		// (set) Token: 0x060012DC RID: 4828 RVA: 0x000CB870 File Offset: 0x000C9A70
		internal virtual ButtonItem ButtonItem2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem2_Click);
				bool flag = this._ButtonItem2 != null;
				if (flag)
				{
					this._ButtonItem2.Click -= value2;
				}
				this._ButtonItem2 = value;
				flag = (this._ButtonItem2 != null);
				if (flag)
				{
					this._ButtonItem2.Click += value2;
				}
			}
		}

		// Token: 0x170005DA RID: 1498
		// (get) Token: 0x060012DD RID: 4829 RVA: 0x000CB8D0 File Offset: 0x000C9AD0
		// (set) Token: 0x060012DE RID: 4830 RVA: 0x00006272 File Offset: 0x00004472
		internal virtual ButtonItem ButtonItem3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ButtonItem3 = value;
			}
		}

		// Token: 0x170005DB RID: 1499
		// (get) Token: 0x060012DF RID: 4831 RVA: 0x000CB8E8 File Offset: 0x000C9AE8
		// (set) Token: 0x060012E0 RID: 4832 RVA: 0x0000627C File Offset: 0x0000447C
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

		// Token: 0x170005DC RID: 1500
		// (get) Token: 0x060012E1 RID: 4833 RVA: 0x000CB900 File Offset: 0x000C9B00
		// (set) Token: 0x060012E2 RID: 4834 RVA: 0x00006286 File Offset: 0x00004486
		internal virtual EditBox txt_tel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_tel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_tel = value;
			}
		}

		// Token: 0x170005DD RID: 1501
		// (get) Token: 0x060012E3 RID: 4835 RVA: 0x000CB918 File Offset: 0x000C9B18
		// (set) Token: 0x060012E4 RID: 4836 RVA: 0x00006290 File Offset: 0x00004490
		internal virtual EditBox txt_codeposti
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_codeposti;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_codeposti = value;
			}
		}

		// Token: 0x170005DE RID: 1502
		// (get) Token: 0x060012E5 RID: 4837 RVA: 0x000CB930 File Offset: 0x000C9B30
		// (set) Token: 0x060012E6 RID: 4838 RVA: 0x0000629A File Offset: 0x0000449A
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

		// Token: 0x170005DF RID: 1503
		// (get) Token: 0x060012E7 RID: 4839 RVA: 0x000CB948 File Offset: 0x000C9B48
		// (set) Token: 0x060012E8 RID: 4840 RVA: 0x000062A4 File Offset: 0x000044A4
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

		// Token: 0x170005E0 RID: 1504
		// (get) Token: 0x060012E9 RID: 4841 RVA: 0x000CB960 File Offset: 0x000C9B60
		// (set) Token: 0x060012EA RID: 4842 RVA: 0x000062AE File Offset: 0x000044AE
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

		// Token: 0x170005E1 RID: 1505
		// (get) Token: 0x060012EB RID: 4843 RVA: 0x000CB978 File Offset: 0x000C9B78
		// (set) Token: 0x060012EC RID: 4844 RVA: 0x000062B8 File Offset: 0x000044B8
		internal virtual EditBox txt_namepedar
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_namepedar;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_namepedar = value;
			}
		}

		// Token: 0x170005E2 RID: 1506
		// (get) Token: 0x060012ED RID: 4845 RVA: 0x000CB990 File Offset: 0x000C9B90
		// (set) Token: 0x060012EE RID: 4846 RVA: 0x000062C2 File Offset: 0x000044C2
		internal virtual EditBox txt_shsh
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_shsh;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_shsh = value;
			}
		}

		// Token: 0x170005E3 RID: 1507
		// (get) Token: 0x060012EF RID: 4847 RVA: 0x000CB9A8 File Offset: 0x000C9BA8
		// (set) Token: 0x060012F0 RID: 4848 RVA: 0x000062CC File Offset: 0x000044CC
		internal virtual EditBox txt_codemelli
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_codemelli;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_codemelli = value;
			}
		}

		// Token: 0x170005E4 RID: 1508
		// (get) Token: 0x060012F1 RID: 4849 RVA: 0x000CB9C0 File Offset: 0x000C9BC0
		// (set) Token: 0x060012F2 RID: 4850 RVA: 0x000062D6 File Offset: 0x000044D6
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

		// Token: 0x170005E5 RID: 1509
		// (get) Token: 0x060012F3 RID: 4851 RVA: 0x000CB9D8 File Offset: 0x000C9BD8
		// (set) Token: 0x060012F4 RID: 4852 RVA: 0x000062E0 File Offset: 0x000044E0
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

		// Token: 0x170005E6 RID: 1510
		// (get) Token: 0x060012F5 RID: 4853 RVA: 0x000CB9F0 File Offset: 0x000C9BF0
		// (set) Token: 0x060012F6 RID: 4854 RVA: 0x000062EA File Offset: 0x000044EA
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

		// Token: 0x170005E7 RID: 1511
		// (get) Token: 0x060012F7 RID: 4855 RVA: 0x000CBA08 File Offset: 0x000C9C08
		// (set) Token: 0x060012F8 RID: 4856 RVA: 0x000062F4 File Offset: 0x000044F4
		internal virtual EditBox EditBox3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._EditBox3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._EditBox3 = value;
			}
		}

		// Token: 0x170005E8 RID: 1512
		// (get) Token: 0x060012F9 RID: 4857 RVA: 0x000CBA20 File Offset: 0x000C9C20
		// (set) Token: 0x060012FA RID: 4858 RVA: 0x000062FE File Offset: 0x000044FE
		internal virtual EditBox EditBox4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._EditBox4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._EditBox4 = value;
			}
		}

		// Token: 0x170005E9 RID: 1513
		// (get) Token: 0x060012FB RID: 4859 RVA: 0x000CBA38 File Offset: 0x000C9C38
		// (set) Token: 0x060012FC RID: 4860 RVA: 0x00006308 File Offset: 0x00004508
		internal virtual EditBox EditBox5
		{
			[DebuggerNonUserCode]
			get
			{
				return this._EditBox5;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._EditBox5 = value;
			}
		}

		// Token: 0x170005EA RID: 1514
		// (get) Token: 0x060012FD RID: 4861 RVA: 0x000CBA50 File Offset: 0x000C9C50
		// (set) Token: 0x060012FE RID: 4862 RVA: 0x00006312 File Offset: 0x00004512
		internal virtual EditBox EditBox6
		{
			[DebuggerNonUserCode]
			get
			{
				return this._EditBox6;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._EditBox6 = value;
			}
		}

		// Token: 0x170005EB RID: 1515
		// (get) Token: 0x060012FF RID: 4863 RVA: 0x000CBA68 File Offset: 0x000C9C68
		// (set) Token: 0x06001300 RID: 4864 RVA: 0x0000631C File Offset: 0x0000451C
		internal virtual Label Label8
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label8;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label8 = value;
			}
		}

		// Token: 0x170005EC RID: 1516
		// (get) Token: 0x06001301 RID: 4865 RVA: 0x000CBA80 File Offset: 0x000C9C80
		// (set) Token: 0x06001302 RID: 4866 RVA: 0x00006326 File Offset: 0x00004526
		internal virtual EditBox txt_address
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_address;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_address = value;
			}
		}

		// Token: 0x06001303 RID: 4867 RVA: 0x000CBA98 File Offset: 0x000C9C98
		private void ButtonItem2_Click(object sender, EventArgs e)
		{
			bool flag = Public_Function.HasNull(this.UiGroupBox1);
			if (!flag)
			{
				this.p.Update(this.txt_name.Text, this.txt_namepedar.Text, this.txt_codemelli.Text, this.txt_shsh.Text, this.txt_codeposti.Text, this.txt_tel.Text, this.txt_tarikh.Text, this.txt_address.Text);
				Public_Function.ConfirmInsert();
			}
		}

		// Token: 0x06001304 RID: 4868 RVA: 0x000CBB24 File Offset: 0x000C9D24
		private void Frm_Anbar_KeyDown(object sender, KeyEventArgs e)
		{
			Keys keyCode = e.KeyCode;
			bool flag = keyCode == Keys.F2;
			if (flag)
			{
				bool flag2 = this.ButtonItem2.Visible;
				if (flag2)
				{
					this.ButtonItem2_Click(null, null);
				}
			}
			else
			{
				bool flag2 = keyCode == Keys.Escape;
				if (flag2)
				{
					this.Close();
				}
			}
		}

		// Token: 0x06001305 RID: 4869 RVA: 0x000CBB74 File Offset: 0x000C9D74
		private void Frm_PardakhtKonande_Load(object sender, EventArgs e)
		{
			DataRow dataRow = Public_Function.FillDataRow("select top 1 * from pardakhtkonande");
			bool flag = dataRow != null;
			if (flag)
			{
				this.txt_name.Text = dataRow["NAme"].ToString();
				this.txt_namepedar.Text = dataRow["namepedar"].ToString();
				this.txt_codemelli.Text = dataRow["codemelli"].ToString();
				this.txt_codeposti.Text = dataRow["codeposti"].ToString();
				this.txt_shsh.Text = dataRow["shsh"].ToString();
				this.txt_tarikh.Text = dataRow["tarikhtavalod"].ToString();
				this.txt_tel.Text = dataRow["tel"].ToString();
				this.txt_address.Text = dataRow["address"].ToString();
			}
		}

		// Token: 0x04000741 RID: 1857
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000743 RID: 1859
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x04000744 RID: 1860
		[AccessedThroughProperty("txt_name")]
		private EditBox _txt_name;

		// Token: 0x04000745 RID: 1861
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04000746 RID: 1862
		[AccessedThroughProperty("Bar1")]
		private Bar _Bar1;

		// Token: 0x04000747 RID: 1863
		[AccessedThroughProperty("ButtonItem1")]
		private ButtonItem _ButtonItem1;

		// Token: 0x04000748 RID: 1864
		[AccessedThroughProperty("ButtonItem2")]
		private ButtonItem _ButtonItem2;

		// Token: 0x04000749 RID: 1865
		[AccessedThroughProperty("ButtonItem3")]
		private ButtonItem _ButtonItem3;

		// Token: 0x0400074A RID: 1866
		[AccessedThroughProperty("txt_tarikh")]
		private DateBox2 _txt_tarikh;

		// Token: 0x0400074B RID: 1867
		[AccessedThroughProperty("txt_tel")]
		private EditBox _txt_tel;

		// Token: 0x0400074C RID: 1868
		[AccessedThroughProperty("txt_codeposti")]
		private EditBox _txt_codeposti;

		// Token: 0x0400074D RID: 1869
		[AccessedThroughProperty("Label7")]
		private Label _Label7;

		// Token: 0x0400074E RID: 1870
		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		// Token: 0x0400074F RID: 1871
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		// Token: 0x04000750 RID: 1872
		[AccessedThroughProperty("txt_namepedar")]
		private EditBox _txt_namepedar;

		// Token: 0x04000751 RID: 1873
		[AccessedThroughProperty("txt_shsh")]
		private EditBox _txt_shsh;

		// Token: 0x04000752 RID: 1874
		[AccessedThroughProperty("txt_codemelli")]
		private EditBox _txt_codemelli;

		// Token: 0x04000753 RID: 1875
		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		// Token: 0x04000754 RID: 1876
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x04000755 RID: 1877
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x04000756 RID: 1878
		[AccessedThroughProperty("EditBox3")]
		private EditBox _EditBox3;

		// Token: 0x04000757 RID: 1879
		[AccessedThroughProperty("EditBox4")]
		private EditBox _EditBox4;

		// Token: 0x04000758 RID: 1880
		[AccessedThroughProperty("EditBox5")]
		private EditBox _EditBox5;

		// Token: 0x04000759 RID: 1881
		[AccessedThroughProperty("EditBox6")]
		private EditBox _EditBox6;

		// Token: 0x0400075A RID: 1882
		[AccessedThroughProperty("Label8")]
		private Label _Label8;

		// Token: 0x0400075B RID: 1883
		[AccessedThroughProperty("txt_address")]
		private EditBox _txt_address;

		// Token: 0x0400075C RID: 1884
		private PardakhtKonande p;
	}
}
