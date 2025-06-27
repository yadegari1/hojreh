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
	// Token: 0x020000DC RID: 220
	[DesignerGenerated]
	public partial class Check_Bank : Form
	{
		// Token: 0x060013DC RID: 5084 RVA: 0x000066BC File Offset: 0x000048BC
		public Check_Bank()
		{
			base.Load += new EventHandler(this.Check_Sandugh_Load);
			Check_Bank.__ENCAddToList(this);
			this.Check_Status = new Check_Status();
			this.InitializeComponent();
		}

		// Token: 0x060013DD RID: 5085 RVA: 0x000D2458 File Offset: 0x000D0658
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Check_Bank.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Check_Bank.__ENCList.Count == Check_Bank.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Check_Bank.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Check_Bank.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Check_Bank.__ENCList[num] = Check_Bank.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Check_Bank.__ENCList.RemoveRange(num, Check_Bank.__ENCList.Count - num);
						Check_Bank.__ENCList.Capacity = Check_Bank.__ENCList.Count;
					}
					Check_Bank.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000630 RID: 1584
		// (get) Token: 0x060013E0 RID: 5088 RVA: 0x000D2D90 File Offset: 0x000D0F90
		// (set) Token: 0x060013E1 RID: 5089 RVA: 0x000066F3 File Offset: 0x000048F3
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

		// Token: 0x17000631 RID: 1585
		// (get) Token: 0x060013E2 RID: 5090 RVA: 0x000D2DA8 File Offset: 0x000D0FA8
		// (set) Token: 0x060013E3 RID: 5091 RVA: 0x000D2DC0 File Offset: 0x000D0FC0
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

		// Token: 0x17000632 RID: 1586
		// (get) Token: 0x060013E4 RID: 5092 RVA: 0x000D2E20 File Offset: 0x000D1020
		// (set) Token: 0x060013E5 RID: 5093 RVA: 0x000066FD File Offset: 0x000048FD
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

		// Token: 0x17000633 RID: 1587
		// (get) Token: 0x060013E6 RID: 5094 RVA: 0x000D2E38 File Offset: 0x000D1038
		// (set) Token: 0x060013E7 RID: 5095 RVA: 0x00006707 File Offset: 0x00004907
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

		// Token: 0x17000634 RID: 1588
		// (get) Token: 0x060013E8 RID: 5096 RVA: 0x000D2E50 File Offset: 0x000D1050
		// (set) Token: 0x060013E9 RID: 5097 RVA: 0x00006711 File Offset: 0x00004911
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

		// Token: 0x17000635 RID: 1589
		// (get) Token: 0x060013EA RID: 5098 RVA: 0x000D2E68 File Offset: 0x000D1068
		// (set) Token: 0x060013EB RID: 5099 RVA: 0x0000671B File Offset: 0x0000491B
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

		// Token: 0x17000636 RID: 1590
		// (get) Token: 0x060013EC RID: 5100 RVA: 0x000D2E80 File Offset: 0x000D1080
		// (set) Token: 0x060013ED RID: 5101 RVA: 0x000D2E98 File Offset: 0x000D1098
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

		// Token: 0x060013EE RID: 5102 RVA: 0x000D2EF8 File Offset: 0x000D10F8
		private void Check_Sandugh_Load(object sender, EventArgs e)
		{
			DataTable dataSource = Public_Function.FillData(" SELECT     DaryaftPardakht.ID, DaryaftPardakht.Tarikh, DaryaftPardakht.Moshtari_ID, DaryaftPardakht.Mablagh, DaryaftPardakht.Tozih, DaryaftPardakht.Tarikh_Fa,     DaryaftPardakht.Sh_Check, DaryaftPardakht.CheckBank_ID, DaryaftPardakht.Check_Shobe, DaryaftPardakht.Check_Sarresid_Fa,     Moshtari.Name + ' ' + Moshtari.Family AS Moshtari_Name, Bank.Name AS Bank_Name, Sanad.VusulBank_ID,     Bank_1.Name + '-' + Bank_Hesab.Shobe AS VusulBank_Name,Check_Status.Tarikh_Fa AS Tarikh_Vagozari     FROM         DaryaftPardakht INNER JOIN     Bank ON DaryaftPardakht.CheckBank_ID = Bank.ID INNER JOIN     Moshtari ON DaryaftPardakht.Moshtari_ID = Moshtari.ID INNER JOIN     Check_Status ON DaryaftPardakht.ID = Check_Status.dp_id INNER JOIN     Sanad ON Check_Status.Sanadbed_ID = Sanad.ID INNER JOIN     Bank_Hesab ON Sanad.VusulBank_ID = Bank_Hesab.ID INNER JOIN     Bank AS Bank_1 ON Bank_Hesab.Bank_ID = Bank_1.ID     WHERE     (DaryaftPardakht.dpType_ID = 2) AND (DaryaftPardakht.Check_Status = 2)");
			this.GridEX1.DataSource = dataSource;
		}

		// Token: 0x060013EF RID: 5103 RVA: 0x00006725 File Offset: 0x00004925
		private void ButtonItem2_Click(object sender, EventArgs e)
		{
			this.Panel1.Visible = true;
		}

		// Token: 0x060013F0 RID: 5104 RVA: 0x000D2F20 File Offset: 0x000D1120
		private void UiButton1_Click(object sender, EventArgs e)
		{
			string tozih = string.Empty;
			GridEXRow[] checkedRows = this.GridEX1.GetCheckedRows();
			checked
			{
				for (int i = 0; i < checkedRows.Length; i++)
				{
					GridEXRow gridEXRow = checkedRows[i];
					tozih = Conversions.ToString(Operators.ConcatenateObject("وصول چک به شماره ", gridEXRow.Cells["Sh_Check"].Value));
					this.Check_Status.InsertVusul(Conversions.ToString(gridEXRow.Cells["VusulBank_ID"].Value), Conversions.ToString(gridEXRow.Cells["Mablagh"].Value), Conversions.ToString(gridEXRow.Cells["id"].Value), this.txt_tarikh.Text, tozih);
					gridEXRow.Delete();
				}
				Public_Function.ConfirmInsert();
				this.Panel1.Visible = false;
			}
		}

		// Token: 0x040007B2 RID: 1970
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x040007B4 RID: 1972
		[AccessedThroughProperty("Bar1")]
		private Bar _Bar1;

		// Token: 0x040007B5 RID: 1973
		[AccessedThroughProperty("ButtonItem2")]
		private ButtonItem _ButtonItem2;

		// Token: 0x040007B6 RID: 1974
		[AccessedThroughProperty("GridEX1")]
		private DataEntryGrid _GridEX1;

		// Token: 0x040007B7 RID: 1975
		[AccessedThroughProperty("Panel1")]
		private PanelEx _Panel1;

		// Token: 0x040007B8 RID: 1976
		[AccessedThroughProperty("txt_tarikh")]
		private DateBox2 _txt_tarikh;

		// Token: 0x040007B9 RID: 1977
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x040007BA RID: 1978
		[AccessedThroughProperty("UiButton1")]
		private UIButton _UiButton1;

		// Token: 0x040007BB RID: 1979
		private Check_Status Check_Status;
	}
}
