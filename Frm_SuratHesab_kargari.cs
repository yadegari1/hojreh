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
using Janus.Windows.UI.Dock;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Stimulsoft.Report;
using Stimulsoft.Report.Components;

namespace FruitBox
{
	// Token: 0x02000149 RID: 329
	[DesignerGenerated]
	public partial class Frm_SuratHesab_kargari : Form
	{
		// Token: 0x060030B9 RID: 12473 RVA: 0x0000C3E3 File Offset: 0x0000A5E3
		[DebuggerNonUserCode]
		public Frm_SuratHesab_kargari()
		{
			base.Load += new EventHandler(this.Frm_SuratHesab_Moshtari_Load);
			base.KeyDown += new KeyEventHandler(this.Frm_SuratHesab_Hazine_KeyDown);
			Frm_SuratHesab_kargari.__ENCAddToList(this);
			this.InitializeComponent();
		}

		// Token: 0x060030BA RID: 12474 RVA: 0x0023B004 File Offset: 0x00239204
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_SuratHesab_kargari.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_SuratHesab_kargari.__ENCList.Count == Frm_SuratHesab_kargari.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_SuratHesab_kargari.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_SuratHesab_kargari.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_SuratHesab_kargari.__ENCList[num] = Frm_SuratHesab_kargari.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_SuratHesab_kargari.__ENCList.RemoveRange(num, Frm_SuratHesab_kargari.__ENCList.Count - num);
						Frm_SuratHesab_kargari.__ENCList.Capacity = Frm_SuratHesab_kargari.__ENCList.Count;
					}
					Frm_SuratHesab_kargari.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000EDD RID: 3805
		// (get) Token: 0x060030BD RID: 12477 RVA: 0x0023C0A8 File Offset: 0x0023A2A8
		// (set) Token: 0x060030BE RID: 12478 RVA: 0x0000C423 File Offset: 0x0000A623
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

		// Token: 0x17000EDE RID: 3806
		// (get) Token: 0x060030BF RID: 12479 RVA: 0x0023C0C0 File Offset: 0x0023A2C0
		// (set) Token: 0x060030C0 RID: 12480 RVA: 0x0000C42D File Offset: 0x0000A62D
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

		// Token: 0x17000EDF RID: 3807
		// (get) Token: 0x060030C1 RID: 12481 RVA: 0x0023C0D8 File Offset: 0x0023A2D8
		// (set) Token: 0x060030C2 RID: 12482 RVA: 0x0000C437 File Offset: 0x0000A637
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

		// Token: 0x17000EE0 RID: 3808
		// (get) Token: 0x060030C3 RID: 12483 RVA: 0x0023C0F0 File Offset: 0x0023A2F0
		// (set) Token: 0x060030C4 RID: 12484 RVA: 0x0023C108 File Offset: 0x0023A308
		internal virtual DateBox2 txt_ta_tarikh
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_ta_tarikh;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyEventHandler value2 = new KeyEventHandler(this.txt_az_tarikh_KeyDown_1);
				bool flag = this._txt_ta_tarikh != null;
				if (flag)
				{
					this._txt_ta_tarikh.KeyDown -= value2;
				}
				this._txt_ta_tarikh = value;
				flag = (this._txt_ta_tarikh != null);
				if (flag)
				{
					this._txt_ta_tarikh.KeyDown += value2;
				}
			}
		}

		// Token: 0x17000EE1 RID: 3809
		// (get) Token: 0x060030C5 RID: 12485 RVA: 0x0023C168 File Offset: 0x0023A368
		// (set) Token: 0x060030C6 RID: 12486 RVA: 0x0023C180 File Offset: 0x0023A380
		internal virtual DateBox2 txt_az_tarikh
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_az_tarikh;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyEventHandler value2 = new KeyEventHandler(this.txt_az_tarikh_KeyDown_1);
				bool flag = this._txt_az_tarikh != null;
				if (flag)
				{
					this._txt_az_tarikh.KeyDown -= value2;
				}
				this._txt_az_tarikh = value;
				flag = (this._txt_az_tarikh != null);
				if (flag)
				{
					this._txt_az_tarikh.KeyDown += value2;
				}
			}
		}

		// Token: 0x17000EE2 RID: 3810
		// (get) Token: 0x060030C7 RID: 12487 RVA: 0x0023C1E0 File Offset: 0x0023A3E0
		// (set) Token: 0x060030C8 RID: 12488 RVA: 0x0000C441 File Offset: 0x0000A641
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

		// Token: 0x17000EE3 RID: 3811
		// (get) Token: 0x060030C9 RID: 12489 RVA: 0x0023C1F8 File Offset: 0x0023A3F8
		// (set) Token: 0x060030CA RID: 12490 RVA: 0x0023C210 File Offset: 0x0023A410
		internal virtual UICheckBox UiCheckBox2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiCheckBox2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.UiCheckBox2_CheckedChanged);
				bool flag = this._UiCheckBox2 != null;
				if (flag)
				{
					this._UiCheckBox2.CheckedChanged -= value2;
				}
				this._UiCheckBox2 = value;
				flag = (this._UiCheckBox2 != null);
				if (flag)
				{
					this._UiCheckBox2.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x17000EE4 RID: 3812
		// (get) Token: 0x060030CB RID: 12491 RVA: 0x0023C270 File Offset: 0x0023A470
		// (set) Token: 0x060030CC RID: 12492 RVA: 0x0000C44B File Offset: 0x0000A64B
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

		// Token: 0x17000EE5 RID: 3813
		// (get) Token: 0x060030CD RID: 12493 RVA: 0x0023C288 File Offset: 0x0023A488
		// (set) Token: 0x060030CE RID: 12494 RVA: 0x0023C2A0 File Offset: 0x0023A4A0
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
				EventHandler value2 = new EventHandler(this.ButtonItem1_Click);
				bool flag = this._ButtonItem1 != null;
				if (flag)
				{
					this._ButtonItem1.Click -= value2;
				}
				this._ButtonItem1 = value;
				flag = (this._ButtonItem1 != null);
				if (flag)
				{
					this._ButtonItem1.Click += value2;
				}
			}
		}

		// Token: 0x17000EE6 RID: 3814
		// (get) Token: 0x060030CF RID: 12495 RVA: 0x0023C300 File Offset: 0x0023A500
		// (set) Token: 0x060030D0 RID: 12496 RVA: 0x0023C318 File Offset: 0x0023A518
		internal virtual EditBox EditBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._EditBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.EditBox1_TextChanged);
				bool flag = this._EditBox1 != null;
				if (flag)
				{
					this._EditBox1.TextChanged -= value2;
				}
				this._EditBox1 = value;
				flag = (this._EditBox1 != null);
				if (flag)
				{
					this._EditBox1.TextChanged += value2;
				}
			}
		}

		// Token: 0x17000EE7 RID: 3815
		// (get) Token: 0x060030D1 RID: 12497 RVA: 0x0023C378 File Offset: 0x0023A578
		// (set) Token: 0x060030D2 RID: 12498 RVA: 0x0000C455 File Offset: 0x0000A655
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

		// Token: 0x17000EE8 RID: 3816
		// (get) Token: 0x060030D3 RID: 12499 RVA: 0x0023C390 File Offset: 0x0023A590
		// (set) Token: 0x060030D4 RID: 12500 RVA: 0x0023C3A8 File Offset: 0x0023A5A8
		internal virtual SelectItem SelectItem1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._SelectItem1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				SelectItem.SelectedValueChangedEventHandler obj = new SelectItem.SelectedValueChangedEventHandler(this.SelectItem1_SelectedValueChanged);
				SelectItem.ValueDeletedEventHandler obj2 = new SelectItem.ValueDeletedEventHandler(this.SelectItem1_ValueDeleted);
				bool flag = this._SelectItem1 != null;
				if (flag)
				{
					this._SelectItem1.SelectedValueChanged -= obj;
					this._SelectItem1.ValueDeleted -= obj2;
				}
				this._SelectItem1 = value;
				flag = (this._SelectItem1 != null);
				if (flag)
				{
					this._SelectItem1.SelectedValueChanged += obj;
					this._SelectItem1.ValueDeleted += obj2;
				}
			}
		}

		// Token: 0x17000EE9 RID: 3817
		// (get) Token: 0x060030D5 RID: 12501 RVA: 0x0023C430 File Offset: 0x0023A630
		// (set) Token: 0x060030D6 RID: 12502 RVA: 0x0000C45F File Offset: 0x0000A65F
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

		// Token: 0x17000EEA RID: 3818
		// (get) Token: 0x060030D7 RID: 12503 RVA: 0x0023C448 File Offset: 0x0023A648
		// (set) Token: 0x060030D8 RID: 12504 RVA: 0x0023C460 File Offset: 0x0023A660
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
				EventHandler value2 = new EventHandler(this.Timer1_Tick);
				bool flag = this._Timer1 != null;
				if (flag)
				{
					this._Timer1.Tick -= value2;
				}
				this._Timer1 = value;
				flag = (this._Timer1 != null);
				if (flag)
				{
					this._Timer1.Tick += value2;
				}
			}
		}

		// Token: 0x17000EEB RID: 3819
		// (get) Token: 0x060030D9 RID: 12505 RVA: 0x0023C4C0 File Offset: 0x0023A6C0
		// (set) Token: 0x060030DA RID: 12506 RVA: 0x0023C4D8 File Offset: 0x0023A6D8
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

		// Token: 0x17000EEC RID: 3820
		// (get) Token: 0x060030DB RID: 12507 RVA: 0x0023C538 File Offset: 0x0023A738
		// (set) Token: 0x060030DC RID: 12508 RVA: 0x0000C469 File Offset: 0x0000A669
		public int? BankHesab_ID
		{
			[DebuggerNonUserCode]
			get
			{
				return this._BankHesab_ID;
			}
			[DebuggerNonUserCode]
			set
			{
				this._BankHesab_ID = value;
			}
		}

		// Token: 0x17000EED RID: 3821
		// (get) Token: 0x060030DD RID: 12509 RVA: 0x0023C550 File Offset: 0x0023A750
		// (set) Token: 0x060030DE RID: 12510 RVA: 0x0000C473 File Offset: 0x0000A673
		public string BankHesab_Name
		{
			[DebuggerNonUserCode]
			get
			{
				return this._BankHesab_Name;
			}
			[DebuggerNonUserCode]
			set
			{
				this._BankHesab_Name = value;
			}
		}

		// Token: 0x060030DF RID: 12511 RVA: 0x0023C568 File Offset: 0x0023A768
		private void LoadData()
		{
			long num = 0L;
			List<string> list = new List<string>();
			List<string> list2 = new List<string>();
			List<string> list3 = new List<string>();
			list.Add("Furush_Hag_Detail.kargari is not null");
			list2.Add("Kharid_Furush.kargari is not null");
			bool flag = this.UiCheckBox2.Checked;
			checked
			{
				if (flag)
				{
					num = Conversions.ToLong(Public_Function.ExecuteScalar("SELECT    isnull(sum( kargari),0) as mablagh  FROM Furush_hag_Detail   where Furush_hag_Detail.tarikh < " + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_az_tarikh.Text))));
					long num2 = Conversions.ToLong(Public_Function.ExecuteScalar("SELECT   isnull( sum( kargari),0) as mablagh   FROM kharid_furush  where kharid_furush.tarikh <" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_az_tarikh.Text))));
					num += num2;
					list.Add("Furush_hag_Detail.tarikh >= " + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_az_tarikh.Text)) + " AND Furush_hag_Detail.tarikh<=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_ta_tarikh.Text)));
					list2.Add("kharid_furush.tarikh >= " + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_az_tarikh.Text)) + " AND kharid_furush.tarikh<=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_ta_tarikh.Text)));
				}
				DataTable dataTable = Public_Function.FillData(string.Concat(new string[]
				{
					"select * from (SELECT    'فروش / '+ cast( Furush_Hag.Num as nvarchar(10)) as num, Furush_Hag_Detail.kargari as mablagh, Furush_Hag_Detail.Tarikh_Fa, Furush_Hag_Detail.Tarikh  FROM         Furush_Hag_Detail INNER JOIN  Furush_Hag ON Furush_Hag_Detail.Furush_Hug_ID = Furush_Hag.ID ",
					Public_Function.BuildWhere(list, Public_Function.OperandType.where),
					" union all  SELECT    'خرید / '+ cast( Kharid.Num as nvarchar(10)) as num, Kharid_Furush.kargari as mablagh, Kharid_Furush.Tarikh_Fa, Kharid_Furush.Tarikh  FROM         Kharid INNER JOIN  Kharid_Furush ON Kharid.ID = Kharid_Furush.Kharid_ID ",
					Public_Function.BuildWhere(list2, Public_Function.OperandType.where),
					" )t  order by Tarikh,num"
				}));
				long num3 = Conversions.ToLong(Public_Function.ExecuteScalar("select isnull(SUM(bed),0) from Sanad where codehesab_id=38 and Sanad.Bed>0"));
				flag = (num3 > 0L);
				if (flag)
				{
					DataRow dataRow = dataTable.NewRow();
					dataRow["mablagh"] = -1L * num3;
					dataRow["num"] = "انتقال به درآمد";
					dataTable.Rows.Add(dataRow);
				}
				flag = (num != 0L);
				if (flag)
				{
					DataRow dataRow2 = dataTable.NewRow();
					dataRow2["mablagh"] = num;
					dataRow2["Tarikh_Fa"] = "مانده از قبل";
					dataRow2["tarikh"] = Public_Function.ShamsiToMiladi(this.txt_az_tarikh.Text);
					flag = Conversions.ToBoolean(this.SelectItem1.Value);
					if (flag)
					{
						dataRow2["hazineKharid_id"] = RuntimeHelpers.GetObjectValue(this.SelectItem1.Value);
					}
					dataTable.Rows.InsertAt(dataRow2, 0);
				}
				this.GridEX1.DataSource = dataTable;
				Public_Function.AddFilterColumn(this.GridEX1);
				this.EditBox1.Focus();
			}
		}

		// Token: 0x060030E0 RID: 12512 RVA: 0x0023C808 File Offset: 0x0023AA08
		private void txt_az_tarikh_KeyDown_1(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				this.LoadData();
			}
		}

		// Token: 0x060030E1 RID: 12513 RVA: 0x0023C830 File Offset: 0x0023AA30
		private void UiCheckBox2_CheckedChanged(object sender, EventArgs e)
		{
			this.txt_az_tarikh.Enabled = this.UiCheckBox2.Checked;
			this.txt_ta_tarikh.Enabled = this.UiCheckBox2.Checked;
			bool flag = this.UiCheckBox2.Checked;
			if (flag)
			{
				this.txt_az_tarikh.FocusDatePart = 1;
				this.txt_az_tarikh.Focus();
				this.txt_az_tarikh.Focus();
			}
			else
			{
				DataTable dataTable = (DataTable)this.GridEX1.DataSource;
				flag = (dataTable == null);
				if (!flag)
				{
					flag = (dataTable.Rows == null);
					if (!flag)
					{
						this.LoadData();
					}
				}
			}
		}

		// Token: 0x060030E2 RID: 12514 RVA: 0x0023C8DC File Offset: 0x0023AADC
		private void Frm_SuratHesab_Hazine_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Escape;
			if (flag)
			{
				this.Close();
			}
			flag = (e.KeyCode == Keys.F4);
			if (flag)
			{
				this.ButtonItem1_Click(null, null);
			}
		}

		// Token: 0x060030E3 RID: 12515 RVA: 0x0000C47D File Offset: 0x0000A67D
		private void Frm_SuratHesab_Moshtari_Load(object sender, EventArgs e)
		{
			this.txt_az_tarikh.SetNew();
			this.txt_ta_tarikh.SetNew();
			this.LoadData();
		}

		// Token: 0x060030E4 RID: 12516 RVA: 0x0023C91C File Offset: 0x0023AB1C
		private void SetHeader(StiReport rpt)
		{
			StiText stiText = (StiText)rpt.GetComponentByName("head1");
			bool flag = stiText != null;
			if (flag)
			{
				stiText.Text = Public_Function.dict["head1"];
			}
			stiText = (StiText)rpt.GetComponentByName("head2");
			flag = (stiText != null);
			if (flag)
			{
				stiText.Text = Public_Function.dict["head2"];
			}
			stiText = (StiText)rpt.GetComponentByName("tarikh");
			flag = (stiText != null);
			if (flag)
			{
				stiText.Text = Public_Function.ToFarsi(Public_Function.MiladiToShamsi(DateAndTime.Now)).ToString();
			}
			flag = Public_Function.dict.ContainsKey("eval");
			if (flag)
			{
				bool flag2 = Conversions.ToBoolean(Public_Function.dict["eval"]);
				if (flag2)
				{
					rpt.Pages[0].Watermark.Angle = 45f;
					rpt.Pages[0].Watermark.Text = "آزمایشی";
				}
			}
			else
			{
				rpt.Pages[0].Watermark = null;
			}
		}

		// Token: 0x060030E5 RID: 12517 RVA: 0x0023CA54 File Offset: 0x0023AC54
		private void ButtonItem1_Click(object sender, EventArgs e)
		{
			StiReport stiReport = new StiReport();
			stiReport.Load(Application.StartupPath + "\\reports\\surathesabkeraye.mrt");
			DataTable dataTable = (DataTable)this.GridEX1.DataSource;
			DataTable dataTable2 = dataTable.Copy();
			dataTable2.TableName = "data";
			dataTable2.DefaultView.RowFilter = dataTable.DefaultView.RowFilter;
			stiReport.RegData(dataTable2.DefaultView);
			this.SetHeader(stiReport);
			StiText stiText = new StiText();
			stiText = (StiText)stiReport.GetComponentByName("Text2");
			string text = "صورتحساب ";
			bool flag = Operators.CompareString(this.SelectItem1.Text, string.Empty, false) != 0;
			if (flag)
			{
				text = text + this.SelectItem1.Text + " ";
			}
			else
			{
				text += "کرایه و مخارج ";
			}
			flag = this.UiCheckBox2.Checked;
			if (flag)
			{
				text = string.Concat(new string[]
				{
					text,
					"از تاریخ ",
					this.txt_az_tarikh.Text,
					" تا تاریخ ",
					this.txt_ta_tarikh.Text
				});
			}
			stiText.Text.Value = Public_Function.ToFarsi(text);
			Public_Function.SetReport_MarginTop(stiReport);
			Public_Function.AddTazminText(stiReport, true, false);
			stiReport.Print(false);
		}

		// Token: 0x060030E6 RID: 12518 RVA: 0x0000C4A0 File Offset: 0x0000A6A0
		private void EditBox1_TextChanged(object sender, EventArgs e)
		{
			Public_Function.FilterGrid(this.GridEX1, this.EditBox1.Text);
		}

		// Token: 0x060030E7 RID: 12519 RVA: 0x0000C4BB File Offset: 0x0000A6BB
		private void SelectItem1_SelectedValueChanged(object sender, EventArgs e)
		{
			this.LoadData();
		}

		// Token: 0x060030E8 RID: 12520 RVA: 0x0000C4BB File Offset: 0x0000A6BB
		private void SelectItem1_ValueDeleted(object sender, EventArgs e)
		{
			this.LoadData();
		}

		// Token: 0x060030E9 RID: 12521 RVA: 0x0000C4C6 File Offset: 0x0000A6C6
		private void Timer1_Tick(object sender, EventArgs e)
		{
			this.Timer1.Enabled = false;
			this.GridEX1.MoveLast();
		}

		// Token: 0x060030EA RID: 12522 RVA: 0x0023CBC0 File Offset: 0x0023ADC0
		private void ButtonItem2_Click(object sender, EventArgs e)
		{
			bool flag = this.GridEX1.DataSource == null;
			checked
			{
				if (!flag)
				{
					flag = (Public_Function.ShowMessage("آیا مایل به انتقال جمع کارگری به درآمد میباشید؟", MessageBoxButtons.YesNo, MessageBoxIcon.Question, null) == DialogResult.No);
					if (!flag)
					{
						object arg_91_0 = null;
						Type arg_91_1 = typeof(Public_Function);
						string arg_91_2 = "GetSum";
						object[] array = new object[2];
						object[] arg_69_0 = array;
						int arg_69_1 = 0;
						DataEntryGrid gridEX = this.GridEX1;
						arg_69_0[arg_69_1] = RuntimeHelpers.GetObjectValue(gridEX.DataSource);
						array[1] = "mablagh";
						object[] array2 = array;
						object[] arg_91_3 = array2;
						string[] arg_91_4 = null;
						Type[] arg_91_5 = null;
						bool[] array3 = new bool[]
						{
							true,
							false
						};
						object arg_AD_0 = NewLateBinding.LateGet(arg_91_0, arg_91_1, arg_91_2, arg_91_3, arg_91_4, arg_91_5, array3);
						if (array3[0])
						{
							gridEX.DataSource = RuntimeHelpers.GetObjectValue(array2[0]);
						}
						long num = Conversions.ToLong(arg_AD_0);
						flag = (num > 0L);
						if (flag)
						{
							string text = string.Empty;
							Sanad sanad = new Sanad();
							text += sanad.InsertStr("38", num.ToString(), "0", Public_Function.MiladiToShamsi(DateAndTime.Now), "انتقال به درآمد", "", Sanad.SanadType.@null);
							text += sanad.InsertStr("37", "0", num.ToString(), Public_Function.MiladiToShamsi(DateAndTime.Now), "درآمد کارگری", "", Sanad.SanadType.@null);
							Public_Function.ExecuteNonQuery(text);
							long num2 = Conversions.ToLong(Public_Function.ExecuteScalar("select isnull(SUM(bed),0) from Sanad where codehesab_id=38 and Sanad.Bed>0"));
							flag = (num2 > 0L);
							if (flag)
							{
								DataTable dataTable = (DataTable)this.GridEX1.DataSource;
								flag = Operators.ConditionalCompareObjectEqual(dataTable.Rows[dataTable.Rows.Count - 1]["num"], "انتقال به درآمد", false);
								if (flag)
								{
									dataTable.Rows[dataTable.Rows.Count - 1]["mablagh"] = -1L * num2;
								}
								else
								{
									DataRow dataRow = dataTable.NewRow();
									dataRow["mablagh"] = -1L * num2;
									dataRow["num"] = "انتقال به درآمد";
									dataTable.Rows.Add(dataRow);
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x040012E6 RID: 4838
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x040012E8 RID: 4840
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x040012E9 RID: 4841
		[AccessedThroughProperty("UiGroupBox2")]
		private UIGroupBox _UiGroupBox2;

		// Token: 0x040012EA RID: 4842
		[AccessedThroughProperty("GridEX1")]
		private DataEntryGrid _GridEX1;

		// Token: 0x040012EB RID: 4843
		[AccessedThroughProperty("txt_ta_tarikh")]
		private DateBox2 _txt_ta_tarikh;

		// Token: 0x040012EC RID: 4844
		[AccessedThroughProperty("txt_az_tarikh")]
		private DateBox2 _txt_az_tarikh;

		// Token: 0x040012ED RID: 4845
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x040012EE RID: 4846
		[AccessedThroughProperty("UiCheckBox2")]
		private UICheckBox _UiCheckBox2;

		// Token: 0x040012EF RID: 4847
		[AccessedThroughProperty("Bar1")]
		private Bar _Bar1;

		// Token: 0x040012F0 RID: 4848
		[AccessedThroughProperty("ButtonItem1")]
		private ButtonItem _ButtonItem1;

		// Token: 0x040012F1 RID: 4849
		[AccessedThroughProperty("EditBox1")]
		private EditBox _EditBox1;

		// Token: 0x040012F2 RID: 4850
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x040012F3 RID: 4851
		[AccessedThroughProperty("SelectItem1")]
		private SelectItem _SelectItem1;

		// Token: 0x040012F4 RID: 4852
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x040012F5 RID: 4853
		[AccessedThroughProperty("Timer1")]
		private Timer _Timer1;

		// Token: 0x040012F6 RID: 4854
		[AccessedThroughProperty("ButtonItem2")]
		private ButtonItem _ButtonItem2;

		// Token: 0x040012F7 RID: 4855
		[CompilerGenerated]
		private int? _BankHesab_ID;

		// Token: 0x040012F8 RID: 4856
		[CompilerGenerated]
		private string _BankHesab_Name;
	}
}
