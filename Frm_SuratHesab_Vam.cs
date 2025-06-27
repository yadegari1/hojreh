using System;
using System.Collections;
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
	// Token: 0x02000156 RID: 342
	[DesignerGenerated]
	public partial class Frm_SuratHesab_Vam : Form
	{
		// Token: 0x060033B6 RID: 13238 RVA: 0x00256B9C File Offset: 0x00254D9C
		public Frm_SuratHesab_Vam()
		{
			base.KeyDown += new KeyEventHandler(this.Frm_SuratHesab_Bank_KeyDown);
			base.Load += new EventHandler(this.Frm_SuratHesab_Moshtari_Load);
			Frm_SuratHesab_Vam.__ENCAddToList(this);
			this.mande = string.Empty;
			this.InitializeComponent();
		}

		// Token: 0x060033B7 RID: 13239 RVA: 0x00256BF4 File Offset: 0x00254DF4
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_SuratHesab_Vam.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_SuratHesab_Vam.__ENCList.Count == Frm_SuratHesab_Vam.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_SuratHesab_Vam.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_SuratHesab_Vam.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_SuratHesab_Vam.__ENCList[num] = Frm_SuratHesab_Vam.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_SuratHesab_Vam.__ENCList.RemoveRange(num, Frm_SuratHesab_Vam.__ENCList.Count - num);
						Frm_SuratHesab_Vam.__ENCList.Capacity = Frm_SuratHesab_Vam.__ENCList.Count;
					}
					Frm_SuratHesab_Vam.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000FDF RID: 4063
		// (get) Token: 0x060033BA RID: 13242 RVA: 0x00257CD8 File Offset: 0x00255ED8
		// (set) Token: 0x060033BB RID: 13243 RVA: 0x0000D0E0 File Offset: 0x0000B2E0
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

		// Token: 0x17000FE0 RID: 4064
		// (get) Token: 0x060033BC RID: 13244 RVA: 0x00257CF0 File Offset: 0x00255EF0
		// (set) Token: 0x060033BD RID: 13245 RVA: 0x0000D0EA File Offset: 0x0000B2EA
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

		// Token: 0x17000FE1 RID: 4065
		// (get) Token: 0x060033BE RID: 13246 RVA: 0x00257D08 File Offset: 0x00255F08
		// (set) Token: 0x060033BF RID: 13247 RVA: 0x00257D20 File Offset: 0x00255F20
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
				RowLoadEventHandler value2 = new RowLoadEventHandler(this.GridEX1_LoadingRow);
				RowCheckStateChangeEventHandler value3 = new RowCheckStateChangeEventHandler(this.GridEX1_RowCheckStateChanged);
				KeyEventHandler value4 = new KeyEventHandler(this.GridEX1_KeyDown);
				bool flag = this._GridEX1 != null;
				if (flag)
				{
					this._GridEX1.LoadingRow -= value2;
					this._GridEX1.RowCheckStateChanged -= value3;
					this._GridEX1.KeyDown -= value4;
				}
				this._GridEX1 = value;
				flag = (this._GridEX1 != null);
				if (flag)
				{
					this._GridEX1.LoadingRow += value2;
					this._GridEX1.RowCheckStateChanged += value3;
					this._GridEX1.KeyDown += value4;
				}
			}
		}

		// Token: 0x17000FE2 RID: 4066
		// (get) Token: 0x060033C0 RID: 13248 RVA: 0x00257DD0 File Offset: 0x00255FD0
		// (set) Token: 0x060033C1 RID: 13249 RVA: 0x0000D0F4 File Offset: 0x0000B2F4
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

		// Token: 0x17000FE3 RID: 4067
		// (get) Token: 0x060033C2 RID: 13250 RVA: 0x00257DE8 File Offset: 0x00255FE8
		// (set) Token: 0x060033C3 RID: 13251 RVA: 0x00257E00 File Offset: 0x00256000
		internal virtual SelectItem txt_bankhesab
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_bankhesab;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				SelectItem.SelectedValueChangedEventHandler obj = new SelectItem.SelectedValueChangedEventHandler(this.SelectItem1_SelectedValueChanged);
				bool flag = this._txt_bankhesab != null;
				if (flag)
				{
					this._txt_bankhesab.SelectedValueChanged -= obj;
				}
				this._txt_bankhesab = value;
				flag = (this._txt_bankhesab != null);
				if (flag)
				{
					this._txt_bankhesab.SelectedValueChanged += obj;
				}
			}
		}

		// Token: 0x17000FE4 RID: 4068
		// (get) Token: 0x060033C4 RID: 13252 RVA: 0x00257E60 File Offset: 0x00256060
		// (set) Token: 0x060033C5 RID: 13253 RVA: 0x00257E78 File Offset: 0x00256078
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

		// Token: 0x17000FE5 RID: 4069
		// (get) Token: 0x060033C6 RID: 13254 RVA: 0x00257ED8 File Offset: 0x002560D8
		// (set) Token: 0x060033C7 RID: 13255 RVA: 0x00257EF0 File Offset: 0x002560F0
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

		// Token: 0x17000FE6 RID: 4070
		// (get) Token: 0x060033C8 RID: 13256 RVA: 0x00257F50 File Offset: 0x00256150
		// (set) Token: 0x060033C9 RID: 13257 RVA: 0x0000D0FE File Offset: 0x0000B2FE
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

		// Token: 0x17000FE7 RID: 4071
		// (get) Token: 0x060033CA RID: 13258 RVA: 0x00257F68 File Offset: 0x00256168
		// (set) Token: 0x060033CB RID: 13259 RVA: 0x00257F80 File Offset: 0x00256180
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

		// Token: 0x17000FE8 RID: 4072
		// (get) Token: 0x060033CC RID: 13260 RVA: 0x00257FE0 File Offset: 0x002561E0
		// (set) Token: 0x060033CD RID: 13261 RVA: 0x0000D108 File Offset: 0x0000B308
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

		// Token: 0x17000FE9 RID: 4073
		// (get) Token: 0x060033CE RID: 13262 RVA: 0x00257FF8 File Offset: 0x002561F8
		// (set) Token: 0x060033CF RID: 13263 RVA: 0x00258010 File Offset: 0x00256210
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

		// Token: 0x17000FEA RID: 4074
		// (get) Token: 0x060033D0 RID: 13264 RVA: 0x00258070 File Offset: 0x00256270
		// (set) Token: 0x060033D1 RID: 13265 RVA: 0x00258088 File Offset: 0x00256288
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

		// Token: 0x17000FEB RID: 4075
		// (get) Token: 0x060033D2 RID: 13266 RVA: 0x002580E8 File Offset: 0x002562E8
		// (set) Token: 0x060033D3 RID: 13267 RVA: 0x0000D112 File Offset: 0x0000B312
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

		// Token: 0x17000FEC RID: 4076
		// (get) Token: 0x060033D4 RID: 13268 RVA: 0x00258100 File Offset: 0x00256300
		// (set) Token: 0x060033D5 RID: 13269 RVA: 0x00258118 File Offset: 0x00256318
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

		// Token: 0x17000FED RID: 4077
		// (get) Token: 0x060033D6 RID: 13270 RVA: 0x00258178 File Offset: 0x00256378
		// (set) Token: 0x060033D7 RID: 13271 RVA: 0x00258190 File Offset: 0x00256390
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

		// Token: 0x17000FEE RID: 4078
		// (get) Token: 0x060033D8 RID: 13272 RVA: 0x002581F0 File Offset: 0x002563F0
		// (set) Token: 0x060033D9 RID: 13273 RVA: 0x0000D11C File Offset: 0x0000B31C
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

		// Token: 0x17000FEF RID: 4079
		// (get) Token: 0x060033DA RID: 13274 RVA: 0x00258208 File Offset: 0x00256408
		// (set) Token: 0x060033DB RID: 13275 RVA: 0x0000D126 File Offset: 0x0000B326
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

		// Token: 0x060033DC RID: 13276 RVA: 0x00258220 File Offset: 0x00256420
		private void SelectItem1_SelectedValueChanged(object sender, EventArgs e)
		{
			int num = Conversions.ToInteger(NewLateBinding.LateGet(null, typeof(Public_Function), "ExecuteScalar", new object[]
			{
				Operators.ConcatenateObject("Select CodeHesab_Mojodi from Bank_Hesab where id=", this.txt_bankhesab.Value)
			}, null, null, null));
			DataTable dataTable = Public_Function.FillData(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" select id,mablagh as bed,0 as bes,tarikh,tarikh_fa,tozih from daryaftpardakht  where id = ", this.txt_bankhesab.Value), " union all "), " select id,0 as bed,mablagh as bes,tarikh,tarikh_fa,tozih from daryaftpardakht "), " where dptype_id=37 and sh_fish="), Public_Function.GetValue(Conversions.ToString(this.txt_bankhesab.Value))), " order by tarikh")));
			dataTable.Columns.Add("mande", typeof(long));
			dataTable.Columns.Add("stat", typeof(string));
			string empty = string.Empty;
			bool flag;
			try
			{
				IEnumerator enumerator = dataTable.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					long num2 = Conversions.ToLong(Operators.AddObject(num2, dataRow["bed"]));
					num2 = Conversions.ToLong(Operators.SubtractObject(num2, dataRow["bes"]));
					dataRow["mande"] = Math.Abs(num2);
					flag = (num2 > 0L);
					if (flag)
					{
						dataRow["stat"] = "بد";
					}
					else
					{
						dataRow["stat"] = "بس";
					}
				}
			}
			finally
			{
				IEnumerator enumerator;
				flag = (enumerator is IDisposable);
				if (flag)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			this.GridEX1.DataSource = dataTable;
			this.Timer1.Enabled = true;
			flag = (dataTable.Rows.Count > 0);
			if (flag)
			{
				this.mande = Conversions.ToString(dataTable.Rows[checked(dataTable.Rows.Count - 1)]["mande"]);
			}
			else
			{
				this.mande = Conversions.ToString(0);
			}
			Public_Function.AddFilterColumn(this.GridEX1);
			this.EditBox1.Focus();
		}

		// Token: 0x060033DD RID: 13277 RVA: 0x00258480 File Offset: 0x00256680
		private void Frm_SuratHesab_Moshtari_Load(object sender, EventArgs e)
		{
			this.txt_bankhesab.AllowEdit = false;
			this.txt_bankhesab.SelectCommand = " SELECT     DaryaftPardakht.Tarikh_Fa+' - '+cast( DaryaftPardakht.Mablagh as nvarchar(20)) as name, DaryaftPardakht.ID, Bank.Name +' '+ Bank_Hesab.Shobe+' '+Bank_Hesab.SahebHesab as bankhesab_name   FROM         DaryaftPardakht INNER JOIN  Bank_Hesab ON DaryaftPardakht.BankHesab_ID = Bank_Hesab.ID INNER JOIN  Bank ON Bank_Hesab.Bank_ID = Bank.ID  WHERE     (DaryaftPardakht.dpType_ID = 33)";
			this.UiCheckBox2.Checked = false;
			this.txt_az_tarikh.SetNew();
			this.txt_ta_tarikh.SetNew();
		}

		// Token: 0x060033DE RID: 13278 RVA: 0x00128E48 File Offset: 0x00127048
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
				stiText.Text = Public_Function.MiladiToShamsi(DateAndTime.Now);
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

		// Token: 0x060033DF RID: 13279 RVA: 0x002584D4 File Offset: 0x002566D4
		private void ButtonItem1_Click(object sender, EventArgs e)
		{
			bool flag = this.GridEX1.DataSource == null;
			if (!flag)
			{
				StiReport stiReport = new StiReport();
				stiReport.Load(Application.StartupPath + "\\reports\\surathesabbank.mrt");
				DataTable dataTable = (DataTable)this.GridEX1.DataSource;
				DataTable dataTable2 = dataTable.Copy();
				dataTable2.TableName = "data";
				dataTable2.DefaultView.RowFilter = dataTable.DefaultView.RowFilter;
				stiReport.RegData(dataTable2.DefaultView);
				StiText stiText = new StiText();
				stiText = (StiText)stiReport.GetComponentByName("Text3");
				string text = "صورتحساب " + this.txt_bankhesab.Text;
				flag = this.UiCheckBox2.Checked;
				if (flag)
				{
					text = string.Concat(new string[]
					{
						text,
						" از تاریخ ",
						this.txt_az_tarikh.Text,
						" تا ",
						this.txt_ta_tarikh.Text
					});
				}
				stiText.Text.Value = text;
				this.SetHeader(stiReport);
				Public_Function.SetReport_MarginTop(stiReport);
				Public_Function.AddTazminText(stiReport, true, false);
				Public_Function.setReportFont(stiReport, "Text10,Text12,Text13,Text14,Text17,Text19,Text21");
				stiReport.Print(false);
			}
		}

		// Token: 0x060033E0 RID: 13280 RVA: 0x0000D130 File Offset: 0x0000B330
		private void EditBox1_TextChanged(object sender, EventArgs e)
		{
			Public_Function.FilterGrid(this.GridEX1, this.EditBox1.Text);
		}

		// Token: 0x060033E1 RID: 13281 RVA: 0x00258628 File Offset: 0x00256828
		private void FilterDate()
		{
			bool flag = this.GridEX1.DataSource == null;
			if (!flag)
			{
				flag = !this.UiCheckBox2.Checked;
				if (!flag)
				{
					DataTable dataTable = (DataTable)this.GridEX1.DataSource;
					int value = Conversions.ToInteger(NewLateBinding.LateGet(null, typeof(Public_Function), "ExecuteScalar", new object[]
					{
						Operators.ConcatenateObject("select codehesab_mojodi from bank_hesab where id=", this.txt_bankhesab.Value)
					}, null, null, null));
					DataRow dataRow = Public_Function.FillDataRow("  SELECT     null as ID, isnull(sum( Sanad.Bed),0) as Bed,isnull(sum( Sanad.Bes),0) as Bes,max(tarikh) as Tarikh,null as Tarikh_Fa, '' as Tozih    FROM Sanad    WHERE Sanad.CodeHesab_ID = " + Conversions.ToString(value) + " and sanad.tarikh<" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_az_tarikh.Text)));
					dataRow["Tozih"] = "مانده از قبل";
					DataRow dataRow2 = dataTable.NewRow();
					flag = Operators.ConditionalCompareObjectGreater(dataRow["bed"], dataRow["bes"], false);
					if (flag)
					{
						dataRow2["mande"] = Operators.SubtractObject(dataRow["bed"], dataRow["bes"]);
						dataRow2["stat"] = "بد";
					}
					else
					{
						dataRow2["mande"] = Operators.SubtractObject(dataRow["bes"], dataRow["bed"]);
						dataRow2["stat"] = "بس";
					}
					flag = Operators.ConditionalCompareObjectNotEqual(dataRow2["mande"], 0, false);
					if (flag)
					{
						bool flag2 = dataTable.Rows[0]["ID"] == DBNull.Value;
						if (flag2)
						{
							dataTable.Rows[0].Delete();
						}
						dataRow2["bed"] = RuntimeHelpers.GetObjectValue(dataRow["bed"]);
						dataRow2["bes"] = RuntimeHelpers.GetObjectValue(dataRow["bes"]);
						dataRow2["tozih"] = "مانده از قبل";
						dataRow2["tarikh"] = Public_Function.ShamsiToMiladi(this.txt_az_tarikh.Text);
						dataTable.Rows.InsertAt(dataRow2, 0);
					}
					dataTable.DefaultView.RowFilter = string.Concat(new string[]
					{
						"tarikh >= '",
						Public_Function.ShamsiToMiladi(this.txt_az_tarikh.Text),
						"' AND tarikh<='",
						Public_Function.ShamsiToMiladi(this.txt_ta_tarikh.Text),
						"'"
					});
				}
			}
		}

		// Token: 0x060033E2 RID: 13282 RVA: 0x002588CC File Offset: 0x00256ACC
		private void txt_az_tarikh_KeyDown_1(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				this.FilterDate();
			}
		}

		// Token: 0x060033E3 RID: 13283 RVA: 0x002588F4 File Offset: 0x00256AF4
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
						dataTable.DefaultView.RowFilter = string.Empty;
						flag = (dataTable.Rows[0]["ID"] == DBNull.Value);
						if (flag)
						{
							dataTable.Rows[0].Delete();
							dataTable.AcceptChanges();
						}
					}
				}
			}
		}

		// Token: 0x060033E4 RID: 13284 RVA: 0x002589E4 File Offset: 0x00256BE4
		private void Frm_SuratHesab_Bank_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Escape;
			if (flag)
			{
				this.Close();
			}
			flag = (e.KeyCode == Keys.F3);
			if (flag)
			{
				this.ButtonItem2_Click(null, null);
			}
			flag = (e.KeyCode == Keys.F4);
			if (flag)
			{
				this.ButtonItem1_Click(null, null);
			}
		}

		// Token: 0x060033E5 RID: 13285 RVA: 0x00258A3C File Offset: 0x00256C3C
		private void GridEX1_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			bool flag3;
			if (flag)
			{
				bool flag2 = this.GridEX1.CurrentRow != null;
				if (flag2)
				{
					flag3 = (this.GridEX1.CurrentRow != null);
					if (flag3)
					{
						this.GridEX1.CurrentRow.IsChecked = !this.GridEX1.CurrentRow.IsChecked;
						this.GridEX1_RowCheckStateChanged(null, null);
					}
				}
			}
			flag3 = (e.KeyCode == Keys.Escape);
			if (flag3)
			{
				this.Close();
			}
		}

		// Token: 0x060033E6 RID: 13286 RVA: 0x00258ACC File Offset: 0x00256CCC
		private void GridEX1_LoadingRow(object sender, RowLoadEventArgs e)
		{
			bool flag = e.Row.RowType == RowType.TotalRow;
			if (flag)
			{
				e.Row.Cells["mande"].Text = Public_Function.FormatPrice(this.mande);
			}
		}

		// Token: 0x060033E7 RID: 13287 RVA: 0x00258B14 File Offset: 0x00256D14
		private void GridEX1_RowCheckStateChanged(object sender, RowCheckStateChangeEventArgs e)
		{
			bool flag = this.GridEX1.CurrentRow.Cells["ID"].Value == DBNull.Value;
			if (!flag)
			{
				flag = this.GridEX1.CurrentRow.IsChecked;
				if (flag)
				{
					NewLateBinding.LateCall(null, typeof(Public_Function), "ExecuteNonQuery", new object[]
					{
						Operators.ConcatenateObject("update sanad set checked=1 where id=", this.GridEX1.CurrentRow.Cells["ID"].Value)
					}, null, null, null, true);
				}
				else
				{
					NewLateBinding.LateCall(null, typeof(Public_Function), "ExecuteNonQuery", new object[]
					{
						Operators.ConcatenateObject("update sanad set checked=0 where id=", this.GridEX1.CurrentRow.Cells["ID"].Value)
					}, null, null, null, true);
				}
			}
		}

		// Token: 0x060033E8 RID: 13288 RVA: 0x0000D14B File Offset: 0x0000B34B
		private void Timer1_Tick(object sender, EventArgs e)
		{
			this.Timer1.Enabled = false;
			this.GridEX1.MoveLast();
		}

		// Token: 0x060033E9 RID: 13289 RVA: 0x0000D168 File Offset: 0x0000B368
		private void ButtonItem2_Click(object sender, EventArgs e)
		{
			this.txt_bankhesab.PerformButtonClick();
		}

		// Token: 0x0400140F RID: 5135
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04001411 RID: 5137
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x04001412 RID: 5138
		[AccessedThroughProperty("UiGroupBox2")]
		private UIGroupBox _UiGroupBox2;

		// Token: 0x04001413 RID: 5139
		[AccessedThroughProperty("GridEX1")]
		private DataEntryGrid _GridEX1;

		// Token: 0x04001414 RID: 5140
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04001415 RID: 5141
		[AccessedThroughProperty("txt_bankhesab")]
		private SelectItem _txt_bankhesab;

		// Token: 0x04001416 RID: 5142
		[AccessedThroughProperty("txt_ta_tarikh")]
		private DateBox2 _txt_ta_tarikh;

		// Token: 0x04001417 RID: 5143
		[AccessedThroughProperty("txt_az_tarikh")]
		private DateBox2 _txt_az_tarikh;

		// Token: 0x04001418 RID: 5144
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x04001419 RID: 5145
		[AccessedThroughProperty("UiCheckBox2")]
		private UICheckBox _UiCheckBox2;

		// Token: 0x0400141A RID: 5146
		[AccessedThroughProperty("Bar1")]
		private Bar _Bar1;

		// Token: 0x0400141B RID: 5147
		[AccessedThroughProperty("ButtonItem1")]
		private ButtonItem _ButtonItem1;

		// Token: 0x0400141C RID: 5148
		[AccessedThroughProperty("EditBox1")]
		private EditBox _EditBox1;

		// Token: 0x0400141D RID: 5149
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x0400141E RID: 5150
		[AccessedThroughProperty("Timer1")]
		private Timer _Timer1;

		// Token: 0x0400141F RID: 5151
		[AccessedThroughProperty("ButtonItem2")]
		private ButtonItem _ButtonItem2;

		// Token: 0x04001420 RID: 5152
		[CompilerGenerated]
		private int? _BankHesab_ID;

		// Token: 0x04001421 RID: 5153
		[CompilerGenerated]
		private string _BankHesab_Name;

		// Token: 0x04001422 RID: 5154
		private string mande;
	}
}
