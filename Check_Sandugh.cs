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
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x020000DD RID: 221
	[DesignerGenerated]
	public partial class Check_Sandugh : Form
	{
		// Token: 0x060013F2 RID: 5106 RVA: 0x00006743 File Offset: 0x00004943
		public Check_Sandugh()
		{
			base.Load += new EventHandler(this.Check_Sandugh_Load);
			Check_Sandugh.__ENCAddToList(this);
			this.Check_Status = new Check_Status();
			this.InitializeComponent();
		}

		// Token: 0x060013F3 RID: 5107 RVA: 0x000D3008 File Offset: 0x000D1208
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Check_Sandugh.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Check_Sandugh.__ENCList.Count == Check_Sandugh.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Check_Sandugh.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Check_Sandugh.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Check_Sandugh.__ENCList[num] = Check_Sandugh.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Check_Sandugh.__ENCList.RemoveRange(num, Check_Sandugh.__ENCList.Count - num);
						Check_Sandugh.__ENCList.Capacity = Check_Sandugh.__ENCList.Count;
					}
					Check_Sandugh.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000637 RID: 1591
		// (get) Token: 0x060013F6 RID: 5110 RVA: 0x000D3BBC File Offset: 0x000D1DBC
		// (set) Token: 0x060013F7 RID: 5111 RVA: 0x0000677A File Offset: 0x0000497A
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

		// Token: 0x17000638 RID: 1592
		// (get) Token: 0x060013F8 RID: 5112 RVA: 0x000D3BD4 File Offset: 0x000D1DD4
		// (set) Token: 0x060013F9 RID: 5113 RVA: 0x000D3BEC File Offset: 0x000D1DEC
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

		// Token: 0x17000639 RID: 1593
		// (get) Token: 0x060013FA RID: 5114 RVA: 0x000D3C4C File Offset: 0x000D1E4C
		// (set) Token: 0x060013FB RID: 5115 RVA: 0x00006784 File Offset: 0x00004984
		internal virtual DataEntryGrid GridEX1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GridEX1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GridEX1 = value;
			}
		}

		// Token: 0x1700063A RID: 1594
		// (get) Token: 0x060013FC RID: 5116 RVA: 0x000D3C64 File Offset: 0x000D1E64
		// (set) Token: 0x060013FD RID: 5117 RVA: 0x0000678E File Offset: 0x0000498E
		internal virtual PanelEx Panel1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Panel1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Panel1 = value;
			}
		}

		// Token: 0x1700063B RID: 1595
		// (get) Token: 0x060013FE RID: 5118 RVA: 0x000D3C7C File Offset: 0x000D1E7C
		// (set) Token: 0x060013FF RID: 5119 RVA: 0x00006798 File Offset: 0x00004998
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

		// Token: 0x1700063C RID: 1596
		// (get) Token: 0x06001400 RID: 5120 RVA: 0x000D3C94 File Offset: 0x000D1E94
		// (set) Token: 0x06001401 RID: 5121 RVA: 0x000067A2 File Offset: 0x000049A2
		internal virtual SelectItem txt_bankHesab
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_bankHesab;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_bankHesab = value;
			}
		}

		// Token: 0x1700063D RID: 1597
		// (get) Token: 0x06001402 RID: 5122 RVA: 0x000D3CAC File Offset: 0x000D1EAC
		// (set) Token: 0x06001403 RID: 5123 RVA: 0x000067AC File Offset: 0x000049AC
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

		// Token: 0x1700063E RID: 1598
		// (get) Token: 0x06001404 RID: 5124 RVA: 0x000D3CC4 File Offset: 0x000D1EC4
		// (set) Token: 0x06001405 RID: 5125 RVA: 0x000067B6 File Offset: 0x000049B6
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

		// Token: 0x1700063F RID: 1599
		// (get) Token: 0x06001406 RID: 5126 RVA: 0x000D3CDC File Offset: 0x000D1EDC
		// (set) Token: 0x06001407 RID: 5127 RVA: 0x000D3CF4 File Offset: 0x000D1EF4
		internal virtual UIButton UiButton1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiButton1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.UiButton1_Click);
				bool flag = this._UiButton1 != null;
				if (flag)
				{
					this._UiButton1.Click -= value2;
				}
				this._UiButton1 = value;
				flag = (this._UiButton1 != null);
				if (flag)
				{
					this._UiButton1.Click += value2;
				}
			}
		}

		// Token: 0x06001408 RID: 5128 RVA: 0x000D3D54 File Offset: 0x000D1F54
		private void Check_Sandugh_Load(object sender, EventArgs e)
		{
			DataTable dataSource = Public_Function.FillData("SELECT     DaryaftPardakht.ID, DaryaftPardakht.Tarikh, DaryaftPardakht.Moshtari_ID, DaryaftPardakht.Mablagh, DaryaftPardakht.Tozih, DaryaftPardakht.Tarikh_Fa,  DaryaftPardakht.Sh_Check, DaryaftPardakht.CheckBank_ID, DaryaftPardakht.Check_Shobe, DaryaftPardakht.Check_Sarresid_Fa, Moshtari.Name+' ' + Moshtari.Family AS Moshtari_Name,  Bank.Name AS Bank_Name  FROM         DaryaftPardakht INNER JOIN  Bank ON DaryaftPardakht.CheckBank_ID = Bank.ID INNER JOIN  Moshtari ON DaryaftPardakht.Moshtari_ID = Moshtari.ID  where DaryaftPardakht.dptype_ID=2 And check_Status=1");
			this.GridEX1.DataSource = dataSource;
		}

		// Token: 0x06001409 RID: 5129 RVA: 0x000067C0 File Offset: 0x000049C0
		private void ButtonItem2_Click(object sender, EventArgs e)
		{
			this.Panel1.Visible = true;
			this.txt_bankHesab.Focus();
		}

		// Token: 0x0600140A RID: 5130 RVA: 0x000D3D7C File Offset: 0x000D1F7C
		private void UiButton1_Click(object sender, EventArgs e)
		{
			string tozih = string.Empty;
			GridEXRow[] checkedRows = this.GridEX1.GetCheckedRows();
			checked
			{
				for (int i = 0; i < checkedRows.Length; i++)
				{
					GridEXRow gridEXRow = checkedRows[i];
					tozih = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("واگذاری چک به شماره ", gridEXRow.Cells["Sh_Check"].Value), " به "), this.txt_bankHesab.Text));
					this.Check_Status.InsertJaryanVusul(Conversions.ToString(this.txt_bankHesab.Value), Conversions.ToString(gridEXRow.Cells["Mablagh"].Value), Conversions.ToString(gridEXRow.Cells["id"].Value), this.txt_tarikh.Text, tozih);
					gridEXRow.Delete();
				}
				Public_Function.ConfirmInsert();
				this.Panel1.Visible = false;
			}
		}

		// Token: 0x040007BC RID: 1980
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x040007BE RID: 1982
		[AccessedThroughProperty("Bar1")]
		private Bar _Bar1;

		// Token: 0x040007BF RID: 1983
		[AccessedThroughProperty("ButtonItem2")]
		private ButtonItem _ButtonItem2;

		// Token: 0x040007C0 RID: 1984
		[AccessedThroughProperty("GridEX1")]
		private DataEntryGrid _GridEX1;

		// Token: 0x040007C1 RID: 1985
		[AccessedThroughProperty("Panel1")]
		private PanelEx _Panel1;

		// Token: 0x040007C2 RID: 1986
		[AccessedThroughProperty("txt_tarikh")]
		private DateBox2 _txt_tarikh;

		// Token: 0x040007C3 RID: 1987
		[AccessedThroughProperty("txt_bankHesab")]
		private SelectItem _txt_bankHesab;

		// Token: 0x040007C4 RID: 1988
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x040007C5 RID: 1989
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x040007C6 RID: 1990
		[AccessedThroughProperty("UiButton1")]
		private UIButton _UiButton1;

		// Token: 0x040007C7 RID: 1991
		private Check_Status Check_Status;
	}
}
