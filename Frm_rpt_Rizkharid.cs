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
	// Token: 0x02000135 RID: 309
	[DesignerGenerated]
	public partial class Frm_rpt_Rizkharid : Form
	{
		// Token: 0x06002C80 RID: 11392 RVA: 0x0000B39B File Offset: 0x0000959B
		[DebuggerNonUserCode]
		public Frm_rpt_Rizkharid()
		{
			base.Load += new EventHandler(this.Frm_SuratHesab_Moshtari_Load);
			base.KeyDown += new KeyEventHandler(this.Frm_SuratHesab_Hazine_KeyDown);
			Frm_rpt_Rizkharid.__ENCAddToList(this);
			this.InitializeComponent();
		}

		// Token: 0x06002C81 RID: 11393 RVA: 0x002101B0 File Offset: 0x0020E3B0
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_rpt_Rizkharid.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_rpt_Rizkharid.__ENCList.Count == Frm_rpt_Rizkharid.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_rpt_Rizkharid.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_rpt_Rizkharid.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_rpt_Rizkharid.__ENCList[num] = Frm_rpt_Rizkharid.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_rpt_Rizkharid.__ENCList.RemoveRange(num, Frm_rpt_Rizkharid.__ENCList.Count - num);
						Frm_rpt_Rizkharid.__ENCList.Capacity = Frm_rpt_Rizkharid.__ENCList.Count;
					}
					Frm_rpt_Rizkharid.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000D87 RID: 3463
		// (get) Token: 0x06002C84 RID: 11396 RVA: 0x00211540 File Offset: 0x0020F740
		// (set) Token: 0x06002C85 RID: 11397 RVA: 0x0000B3DB File Offset: 0x000095DB
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

		// Token: 0x17000D88 RID: 3464
		// (get) Token: 0x06002C86 RID: 11398 RVA: 0x00211558 File Offset: 0x0020F758
		// (set) Token: 0x06002C87 RID: 11399 RVA: 0x0000B3E5 File Offset: 0x000095E5
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

		// Token: 0x17000D89 RID: 3465
		// (get) Token: 0x06002C88 RID: 11400 RVA: 0x00211570 File Offset: 0x0020F770
		// (set) Token: 0x06002C89 RID: 11401 RVA: 0x0000B3EF File Offset: 0x000095EF
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

		// Token: 0x17000D8A RID: 3466
		// (get) Token: 0x06002C8A RID: 11402 RVA: 0x00211588 File Offset: 0x0020F788
		// (set) Token: 0x06002C8B RID: 11403 RVA: 0x002115A0 File Offset: 0x0020F7A0
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
				KeyEventHandler value2 = new KeyEventHandler(this.txt_ta_tarikh_KeyDown);
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

		// Token: 0x17000D8B RID: 3467
		// (get) Token: 0x06002C8C RID: 11404 RVA: 0x00211600 File Offset: 0x0020F800
		// (set) Token: 0x06002C8D RID: 11405 RVA: 0x00211618 File Offset: 0x0020F818
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

		// Token: 0x17000D8C RID: 3468
		// (get) Token: 0x06002C8E RID: 11406 RVA: 0x00211678 File Offset: 0x0020F878
		// (set) Token: 0x06002C8F RID: 11407 RVA: 0x0000B3F9 File Offset: 0x000095F9
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

		// Token: 0x17000D8D RID: 3469
		// (get) Token: 0x06002C90 RID: 11408 RVA: 0x00211690 File Offset: 0x0020F890
		// (set) Token: 0x06002C91 RID: 11409 RVA: 0x002116A8 File Offset: 0x0020F8A8
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

		// Token: 0x17000D8E RID: 3470
		// (get) Token: 0x06002C92 RID: 11410 RVA: 0x00211708 File Offset: 0x0020F908
		// (set) Token: 0x06002C93 RID: 11411 RVA: 0x0000B403 File Offset: 0x00009603
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

		// Token: 0x17000D8F RID: 3471
		// (get) Token: 0x06002C94 RID: 11412 RVA: 0x00211720 File Offset: 0x0020F920
		// (set) Token: 0x06002C95 RID: 11413 RVA: 0x00211738 File Offset: 0x0020F938
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

		// Token: 0x17000D90 RID: 3472
		// (get) Token: 0x06002C96 RID: 11414 RVA: 0x00211798 File Offset: 0x0020F998
		// (set) Token: 0x06002C97 RID: 11415 RVA: 0x002117B0 File Offset: 0x0020F9B0
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

		// Token: 0x17000D91 RID: 3473
		// (get) Token: 0x06002C98 RID: 11416 RVA: 0x00211810 File Offset: 0x0020FA10
		// (set) Token: 0x06002C99 RID: 11417 RVA: 0x0000B40D File Offset: 0x0000960D
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

		// Token: 0x17000D92 RID: 3474
		// (get) Token: 0x06002C9A RID: 11418 RVA: 0x00211828 File Offset: 0x0020FA28
		// (set) Token: 0x06002C9B RID: 11419 RVA: 0x00211840 File Offset: 0x0020FA40
		internal virtual SelectItem txt_kala
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_kala;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				SelectItem.ValueDeletedEventHandler obj = new SelectItem.ValueDeletedEventHandler(this.txt_kala_ValueDeleted);
				SelectItem.SelectedValueChangedEventHandler obj2 = new SelectItem.SelectedValueChangedEventHandler(this.SelectItem1_SelectedValueChanged_1);
				bool flag = this._txt_kala != null;
				if (flag)
				{
					this._txt_kala.ValueDeleted -= obj;
					this._txt_kala.SelectedValueChanged -= obj2;
				}
				this._txt_kala = value;
				flag = (this._txt_kala != null);
				if (flag)
				{
					this._txt_kala.ValueDeleted += obj;
					this._txt_kala.SelectedValueChanged += obj2;
				}
			}
		}

		// Token: 0x17000D93 RID: 3475
		// (get) Token: 0x06002C9C RID: 11420 RVA: 0x002118C8 File Offset: 0x0020FAC8
		// (set) Token: 0x06002C9D RID: 11421 RVA: 0x0000B417 File Offset: 0x00009617
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

		// Token: 0x17000D94 RID: 3476
		// (get) Token: 0x06002C9E RID: 11422 RVA: 0x002118E0 File Offset: 0x0020FAE0
		// (set) Token: 0x06002C9F RID: 11423 RVA: 0x002118F8 File Offset: 0x0020FAF8
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

		// Token: 0x17000D95 RID: 3477
		// (get) Token: 0x06002CA0 RID: 11424 RVA: 0x00211958 File Offset: 0x0020FB58
		// (set) Token: 0x06002CA1 RID: 11425 RVA: 0x00211970 File Offset: 0x0020FB70
		internal virtual SelectItem txt_moshtari
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_moshtari;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				SelectItem.ValueDeletedEventHandler obj = new SelectItem.ValueDeletedEventHandler(this.txt_moshtari_ValueDeleted);
				SelectItem.SelectedValueChangedEventHandler obj2 = new SelectItem.SelectedValueChangedEventHandler(this.txt_moshtari_SelectedValueChanged);
				bool flag = this._txt_moshtari != null;
				if (flag)
				{
					this._txt_moshtari.ValueDeleted -= obj;
					this._txt_moshtari.SelectedValueChanged -= obj2;
				}
				this._txt_moshtari = value;
				flag = (this._txt_moshtari != null);
				if (flag)
				{
					this._txt_moshtari.ValueDeleted += obj;
					this._txt_moshtari.SelectedValueChanged += obj2;
				}
			}
		}

		// Token: 0x17000D96 RID: 3478
		// (get) Token: 0x06002CA2 RID: 11426 RVA: 0x002119F8 File Offset: 0x0020FBF8
		// (set) Token: 0x06002CA3 RID: 11427 RVA: 0x0000B421 File Offset: 0x00009621
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

		// Token: 0x17000D97 RID: 3479
		// (get) Token: 0x06002CA4 RID: 11428 RVA: 0x00211A10 File Offset: 0x0020FC10
		// (set) Token: 0x06002CA5 RID: 11429 RVA: 0x0000B42B File Offset: 0x0000962B
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

		// Token: 0x17000D98 RID: 3480
		// (get) Token: 0x06002CA6 RID: 11430 RVA: 0x00211A28 File Offset: 0x0020FC28
		// (set) Token: 0x06002CA7 RID: 11431 RVA: 0x0000B435 File Offset: 0x00009635
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

		// Token: 0x06002CA8 RID: 11432 RVA: 0x00211A40 File Offset: 0x0020FC40
		private void RemoveZero(DataTable dt)
		{
			try
			{
				IEnumerator enumerator = dt.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					bool flag = dataRow["tedad"] != DBNull.Value;
					if (flag)
					{
						dataRow["tedad"] = Public_Function.GetDecimalValue(Conversions.ToDecimal(dataRow["tedad"]));
					}
					flag = (dataRow["vazn_kol"] != DBNull.Value);
					if (flag)
					{
						dataRow["vazn_kol"] = Public_Function.GetDecimalValue(Conversions.ToDecimal(dataRow["vazn_kol"]));
					}
				}
			}
			finally
			{
				IEnumerator enumerator;
				bool flag = enumerator is IDisposable;
				if (flag)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
		}

		// Token: 0x06002CA9 RID: 11433 RVA: 0x00211B2C File Offset: 0x0020FD2C
		private void LoadData()
		{
			string text = string.Empty;
			bool flag = this.UiCheckBox2.Checked;
			bool flag2;
			if (flag)
			{
				flag2 = (Operators.CompareString(text, string.Empty, false) == 0);
				if (flag2)
				{
					text = " Kharid_Sardkhane_Detail.Tarikh>=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_az_tarikh.Text)) + " and Kharid_Sardkhane_Detail.Tarikh<=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_ta_tarikh.Text));
				}
				else
				{
					text = string.Concat(new string[]
					{
						text,
						" AND  Kharid_Sardkhane_Detail.Tarikh>=",
						Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_az_tarikh.Text)),
						" and Kharid_Sardkhane_Detail.Tarikh<=",
						Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_ta_tarikh.Text))
					});
				}
			}
			flag2 = (this.txt_moshtari.Value != null);
			if (flag2)
			{
				flag = (Operators.CompareString(text, string.Empty, false) == 0);
				if (flag)
				{
					text = Conversions.ToString(Operators.ConcatenateObject(" Kharid_Sardkhane_Detail.moshtari_id=", this.txt_moshtari.Value));
				}
				else
				{
					text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(" AND  Kharid_Sardkhane_Detail.moshtari_id=", this.txt_moshtari.Value)));
				}
			}
			flag2 = (this.txt_kala.Value != null);
			if (flag2)
			{
				flag = (Operators.CompareString(text, string.Empty, false) == 0);
				if (flag)
				{
					text = Conversions.ToString(Operators.ConcatenateObject(" Kharid_Sardkhane_Detail.kala_id=", this.txt_kala.Value));
				}
				else
				{
					text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(" AND  Kharid_Sardkhane_Detail.kala_id=", this.txt_kala.Value)));
				}
			}
			flag2 = (Operators.CompareString(text, string.Empty, false) != 0);
			if (flag2)
			{
				text = " where " + text;
			}
			DataTable dataTable = Public_Function.FillData("SELECT     Kharid_Sardkhane.Num, Kharid_Sardkhane_Detail.Tarikh_Fa, Kala.Name as kala_name, Kharid_Sardkhane_Detail.Tedad, Kharid_Sardkhane_Detail.Vazn_Kol,  Kharid_Sardkhane_detail.Fee, Kharid_Sardkhane_detail.Jam_Kol  FROM         Kharid_Sardkhane INNER JOIN   Kharid_Sardkhane_Detail ON Kharid_Sardkhane.ID = Kharid_Sardkhane_Detail.Kharid_Sardkhane_ID INNER JOIN  Kala ON Kharid_Sardkhane_Detail.Kala_ID = Kala.ID" + text + " order by Kharid_Sardkhane_Detail.Tarikh,num");
			this.RemoveZero(dataTable);
			this.GridEX1.DataSource = dataTable;
			Public_Function.AddFilterColumn(this.GridEX1);
		}

		// Token: 0x06002CAA RID: 11434 RVA: 0x00211D30 File Offset: 0x0020FF30
		private void txt_az_tarikh_KeyDown_1(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				this.LoadData();
			}
		}

		// Token: 0x06002CAB RID: 11435 RVA: 0x00211D58 File Offset: 0x0020FF58
		private void UiCheckBox2_CheckedChanged(object sender, EventArgs e)
		{
			this.txt_az_tarikh.Enabled = this.UiCheckBox2.Checked;
			this.txt_ta_tarikh.Enabled = this.UiCheckBox2.Checked;
			bool @checked = this.UiCheckBox2.Checked;
			if (@checked)
			{
				this.txt_az_tarikh.FocusDatePart = 1;
				this.txt_az_tarikh.Focus();
				this.txt_az_tarikh.Focus();
			}
			else
			{
				this.LoadData();
			}
		}

		// Token: 0x06002CAC RID: 11436 RVA: 0x00211DD4 File Offset: 0x0020FFD4
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

		// Token: 0x06002CAD RID: 11437 RVA: 0x0000B43F File Offset: 0x0000963F
		private void Frm_SuratHesab_Moshtari_Load(object sender, EventArgs e)
		{
			this.txt_az_tarikh.SetNew();
			this.txt_ta_tarikh.SetNew();
			this.LoadData();
		}

		// Token: 0x06002CAE RID: 11438 RVA: 0x00128E48 File Offset: 0x00127048
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

		// Token: 0x06002CAF RID: 11439 RVA: 0x00211E14 File Offset: 0x00210014
		private void ButtonItem1_Click(object sender, EventArgs e)
		{
			StiReport stiReport = new StiReport();
			stiReport.Load(Application.StartupPath + "\\reports\\surathesabhazine.mrt");
			DataTable dataTable = (DataTable)this.GridEX1.DataSource;
			DataTable dataTable2 = dataTable.Copy();
			dataTable2.TableName = "data";
			dataTable2.DefaultView.RowFilter = dataTable.DefaultView.RowFilter;
			stiReport.RegData(dataTable2.DefaultView);
			this.SetHeader(stiReport);
			StiText stiText = new StiText();
			stiText = (StiText)stiReport.GetComponentByName("Text2");
			string text = "صورتحساب هزینه ";
			bool @checked = this.UiCheckBox2.Checked;
			if (@checked)
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
			stiText.Text.Value = text;
			Public_Function.AddTazminText(stiReport, true, false);
			Public_Function.SetReport_MarginTop(stiReport);
			Public_Function.setReportFont(stiReport, "Text10,Text12,Text13,Text14,Text17,Text19,Text21");
			stiReport.Print(false);
		}

		// Token: 0x06002CB0 RID: 11440 RVA: 0x0000B462 File Offset: 0x00009662
		private void EditBox1_TextChanged(object sender, EventArgs e)
		{
			Public_Function.FilterGrid(this.GridEX1, this.EditBox1.Text);
		}

		// Token: 0x06002CB1 RID: 11441 RVA: 0x0000B47D File Offset: 0x0000967D
		private void Timer1_Tick(object sender, EventArgs e)
		{
			this.Timer1.Enabled = false;
			this.GridEX1.MoveLast();
		}

		// Token: 0x06002CB2 RID: 11442 RVA: 0x0000B49A File Offset: 0x0000969A
		private void txt_moshtari_SelectedValueChanged(object sender, EventArgs e)
		{
			this.LoadData();
			this.txt_kala.Focus();
		}

		// Token: 0x06002CB3 RID: 11443 RVA: 0x0000B4B1 File Offset: 0x000096B1
		private void SelectItem1_SelectedValueChanged_1(object sender, EventArgs e)
		{
			this.LoadData();
			this.EditBox1.Focus();
		}

		// Token: 0x06002CB4 RID: 11444 RVA: 0x0000B4C8 File Offset: 0x000096C8
		private void txt_moshtari_ValueDeleted(object sender, EventArgs e)
		{
			this.LoadData();
		}

		// Token: 0x06002CB5 RID: 11445 RVA: 0x0000B4C8 File Offset: 0x000096C8
		private void txt_kala_ValueDeleted(object sender, EventArgs e)
		{
			this.LoadData();
		}

		// Token: 0x06002CB6 RID: 11446 RVA: 0x0000B4C8 File Offset: 0x000096C8
		private void txt_ta_tarikh_KeyDown(object sender, KeyEventArgs e)
		{
			this.LoadData();
		}

		// Token: 0x0400114F RID: 4431
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04001151 RID: 4433
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x04001152 RID: 4434
		[AccessedThroughProperty("UiGroupBox2")]
		private UIGroupBox _UiGroupBox2;

		// Token: 0x04001153 RID: 4435
		[AccessedThroughProperty("GridEX1")]
		private DataEntryGrid _GridEX1;

		// Token: 0x04001154 RID: 4436
		[AccessedThroughProperty("txt_ta_tarikh")]
		private DateBox2 _txt_ta_tarikh;

		// Token: 0x04001155 RID: 4437
		[AccessedThroughProperty("txt_az_tarikh")]
		private DateBox2 _txt_az_tarikh;

		// Token: 0x04001156 RID: 4438
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x04001157 RID: 4439
		[AccessedThroughProperty("UiCheckBox2")]
		private UICheckBox _UiCheckBox2;

		// Token: 0x04001158 RID: 4440
		[AccessedThroughProperty("Bar1")]
		private Bar _Bar1;

		// Token: 0x04001159 RID: 4441
		[AccessedThroughProperty("ButtonItem1")]
		private ButtonItem _ButtonItem1;

		// Token: 0x0400115A RID: 4442
		[AccessedThroughProperty("EditBox1")]
		private EditBox _EditBox1;

		// Token: 0x0400115B RID: 4443
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x0400115C RID: 4444
		[AccessedThroughProperty("txt_kala")]
		private SelectItem _txt_kala;

		// Token: 0x0400115D RID: 4445
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x0400115E RID: 4446
		[AccessedThroughProperty("Timer1")]
		private Timer _Timer1;

		// Token: 0x0400115F RID: 4447
		[AccessedThroughProperty("txt_moshtari")]
		private SelectItem _txt_moshtari;

		// Token: 0x04001160 RID: 4448
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		// Token: 0x04001161 RID: 4449
		[CompilerGenerated]
		private int? _BankHesab_ID;

		// Token: 0x04001162 RID: 4450
		[CompilerGenerated]
		private string _BankHesab_Name;

		// Token: 0x04001163 RID: 4451
		private string mande;
	}
}
