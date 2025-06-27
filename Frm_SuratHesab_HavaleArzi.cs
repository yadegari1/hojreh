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
	// Token: 0x02000147 RID: 327
	[DesignerGenerated]
	public partial class Frm_SuratHesab_HavaleArzi : Form
	{
		// Token: 0x0600305A RID: 12378 RVA: 0x0000C1C8 File Offset: 0x0000A3C8
		[DebuggerNonUserCode]
		public Frm_SuratHesab_HavaleArzi()
		{
			base.KeyDown += new KeyEventHandler(this.Frm_SuratHesab_Hazine_KeyDown);
			base.Load += new EventHandler(this.Frm_SuratHesab_Moshtari_Load);
			Frm_SuratHesab_HavaleArzi.__ENCAddToList(this);
			this.InitializeComponent();
		}

		// Token: 0x0600305B RID: 12379 RVA: 0x00237B4C File Offset: 0x00235D4C
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_SuratHesab_HavaleArzi.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_SuratHesab_HavaleArzi.__ENCList.Count == Frm_SuratHesab_HavaleArzi.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_SuratHesab_HavaleArzi.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_SuratHesab_HavaleArzi.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_SuratHesab_HavaleArzi.__ENCList[num] = Frm_SuratHesab_HavaleArzi.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_SuratHesab_HavaleArzi.__ENCList.RemoveRange(num, Frm_SuratHesab_HavaleArzi.__ENCList.Count - num);
						Frm_SuratHesab_HavaleArzi.__ENCList.Capacity = Frm_SuratHesab_HavaleArzi.__ENCList.Count;
					}
					Frm_SuratHesab_HavaleArzi.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000EBE RID: 3774
		// (get) Token: 0x0600305E RID: 12382 RVA: 0x00238B34 File Offset: 0x00236D34
		// (set) Token: 0x0600305F RID: 12383 RVA: 0x0000C208 File Offset: 0x0000A408
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

		// Token: 0x17000EBF RID: 3775
		// (get) Token: 0x06003060 RID: 12384 RVA: 0x00238B4C File Offset: 0x00236D4C
		// (set) Token: 0x06003061 RID: 12385 RVA: 0x0000C212 File Offset: 0x0000A412
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

		// Token: 0x17000EC0 RID: 3776
		// (get) Token: 0x06003062 RID: 12386 RVA: 0x00238B64 File Offset: 0x00236D64
		// (set) Token: 0x06003063 RID: 12387 RVA: 0x00238B7C File Offset: 0x00236D7C
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

		// Token: 0x17000EC1 RID: 3777
		// (get) Token: 0x06003064 RID: 12388 RVA: 0x00238BDC File Offset: 0x00236DDC
		// (set) Token: 0x06003065 RID: 12389 RVA: 0x00238BF4 File Offset: 0x00236DF4
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

		// Token: 0x17000EC2 RID: 3778
		// (get) Token: 0x06003066 RID: 12390 RVA: 0x00238C54 File Offset: 0x00236E54
		// (set) Token: 0x06003067 RID: 12391 RVA: 0x0000C21C File Offset: 0x0000A41C
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

		// Token: 0x17000EC3 RID: 3779
		// (get) Token: 0x06003068 RID: 12392 RVA: 0x00238C6C File Offset: 0x00236E6C
		// (set) Token: 0x06003069 RID: 12393 RVA: 0x00238C84 File Offset: 0x00236E84
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

		// Token: 0x17000EC4 RID: 3780
		// (get) Token: 0x0600306A RID: 12394 RVA: 0x00238CE4 File Offset: 0x00236EE4
		// (set) Token: 0x0600306B RID: 12395 RVA: 0x0000C226 File Offset: 0x0000A426
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

		// Token: 0x17000EC5 RID: 3781
		// (get) Token: 0x0600306C RID: 12396 RVA: 0x00238CFC File Offset: 0x00236EFC
		// (set) Token: 0x0600306D RID: 12397 RVA: 0x00238D14 File Offset: 0x00236F14
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

		// Token: 0x17000EC6 RID: 3782
		// (get) Token: 0x0600306E RID: 12398 RVA: 0x00238D74 File Offset: 0x00236F74
		// (set) Token: 0x0600306F RID: 12399 RVA: 0x00238D8C File Offset: 0x00236F8C
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

		// Token: 0x17000EC7 RID: 3783
		// (get) Token: 0x06003070 RID: 12400 RVA: 0x00238DEC File Offset: 0x00236FEC
		// (set) Token: 0x06003071 RID: 12401 RVA: 0x0000C230 File Offset: 0x0000A430
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

		// Token: 0x17000EC8 RID: 3784
		// (get) Token: 0x06003072 RID: 12402 RVA: 0x00238E04 File Offset: 0x00237004
		// (set) Token: 0x06003073 RID: 12403 RVA: 0x0000C23A File Offset: 0x0000A43A
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

		// Token: 0x17000EC9 RID: 3785
		// (get) Token: 0x06003074 RID: 12404 RVA: 0x00238E1C File Offset: 0x0023701C
		// (set) Token: 0x06003075 RID: 12405 RVA: 0x0000C244 File Offset: 0x0000A444
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

		// Token: 0x17000ECA RID: 3786
		// (get) Token: 0x06003076 RID: 12406 RVA: 0x00238E34 File Offset: 0x00237034
		// (set) Token: 0x06003077 RID: 12407 RVA: 0x00238E4C File Offset: 0x0023704C
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
				SelectItem.SelectedValueChangedEventHandler obj = new SelectItem.SelectedValueChangedEventHandler(this.txt_moshtari_SelectedValueChanged);
				bool flag = this._txt_moshtari != null;
				if (flag)
				{
					this._txt_moshtari.SelectedValueChanged -= obj;
				}
				this._txt_moshtari = value;
				flag = (this._txt_moshtari != null);
				if (flag)
				{
					this._txt_moshtari.SelectedValueChanged += obj;
				}
			}
		}

		// Token: 0x17000ECB RID: 3787
		// (get) Token: 0x06003078 RID: 12408 RVA: 0x00238EAC File Offset: 0x002370AC
		// (set) Token: 0x06003079 RID: 12409 RVA: 0x0000C24E File Offset: 0x0000A44E
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

		// Token: 0x17000ECC RID: 3788
		// (get) Token: 0x0600307A RID: 12410 RVA: 0x00238EC4 File Offset: 0x002370C4
		// (set) Token: 0x0600307B RID: 12411 RVA: 0x0000C258 File Offset: 0x0000A458
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

		// Token: 0x0600307C RID: 12412 RVA: 0x00238EDC File Offset: 0x002370DC
		private void LoadData()
		{
			DataTable dataTable = Public_Function.FillData(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("SELECT     DaryaftPardakht.ID, DaryaftPardakht.dpType_ID, DaryaftPardakht.Tarikh, DaryaftPardakht.Moshtari_ID, DaryaftPardakht.Mablagh, DaryaftPardakht.Tozih,cast(DaryaftPardakht.fishvariz_fa as bigint) as nerkh,  DaryaftPardakht.Tarikh_Fa, Moshtari.Name + ' ' + Moshtari.Family AS Moshtari_Name  FROM         DaryaftPardakht INNER JOIN  Moshtari ON DaryaftPardakht.Moshtari_ID = Moshtari.ID  WHERE DaryaftPardakht.dptype_ID = 43 and  DaryaftPardakht.Moshtari_ID=", this.txt_moshtari.Value), " order by tarikh,id")));
			dataTable.Columns.Add("jam_kol", typeof(long));
			try
			{
				IEnumerator enumerator = dataTable.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					dataRow["jam_kol"] = Operators.MultiplyObject(dataRow["mablagh"], dataRow["nerkh"]);
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
			this.GridEX1.DataSource = dataTable;
			Public_Function.AddFilterColumn(this.GridEX1);
			this.GridEX1.MoveLast();
			this.EditBox1.Focus();
		}

		// Token: 0x0600307D RID: 12413 RVA: 0x00238FE0 File Offset: 0x002371E0
		private void FilterDate()
		{
			bool flag = this.GridEX1.DataSource == null;
			if (!flag)
			{
				flag = !this.UiCheckBox2.Checked;
				if (!flag)
				{
					DataTable dataTable = (DataTable)this.GridEX1.DataSource;
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

		// Token: 0x0600307E RID: 12414 RVA: 0x0023908C File Offset: 0x0023728C
		private void txt_az_tarikh_KeyDown_1(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				this.FilterDate();
			}
		}

		// Token: 0x0600307F RID: 12415 RVA: 0x002390B4 File Offset: 0x002372B4
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

		// Token: 0x06003080 RID: 12416 RVA: 0x002391A4 File Offset: 0x002373A4
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

		// Token: 0x06003081 RID: 12417 RVA: 0x0000C262 File Offset: 0x0000A462
		private void Frm_SuratHesab_Moshtari_Load(object sender, EventArgs e)
		{
			this.txt_az_tarikh.SetNew();
			this.txt_ta_tarikh.SetNew();
		}

		// Token: 0x06003082 RID: 12418 RVA: 0x00128E48 File Offset: 0x00127048
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

		// Token: 0x06003083 RID: 12419 RVA: 0x002391E4 File Offset: 0x002373E4
		private void ButtonItem1_Click(object sender, EventArgs e)
		{
			StiReport stiReport = new StiReport();
			stiReport.Load(Application.StartupPath + "\\reports\\surathesabtafavot.mrt");
			DataTable dataTable = (DataTable)this.GridEX1.DataSource;
			DataTable dataTable2 = dataTable.Copy();
			dataTable2.TableName = "data";
			dataTable2.DefaultView.RowFilter = dataTable.DefaultView.RowFilter;
			stiReport.RegData(dataTable2.DefaultView);
			this.SetHeader(stiReport);
			StiText stiText = new StiText();
			stiText = (StiText)stiReport.GetComponentByName("Text2");
			string text = "صورتحساب تفاوت ";
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
			Public_Function.AddTazminText(stiReport, true, false);
			Public_Function.SetReport_MarginTop(stiReport);
			Public_Function.setReportFont(stiReport, "Text10,Text12,Text8");
			stiReport.Print(false);
		}

		// Token: 0x06003084 RID: 12420 RVA: 0x0000C27E File Offset: 0x0000A47E
		private void EditBox1_TextChanged(object sender, EventArgs e)
		{
			Public_Function.FilterGrid(this.GridEX1, this.EditBox1.Text);
		}

		// Token: 0x06003085 RID: 12421 RVA: 0x0000C299 File Offset: 0x0000A499
		private void txt_moshtari_SelectedValueChanged(object sender, EventArgs e)
		{
			this.LoadData();
		}

		// Token: 0x040012C2 RID: 4802
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x040012C4 RID: 4804
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x040012C5 RID: 4805
		[AccessedThroughProperty("GridEX1")]
		private DataEntryGrid _GridEX1;

		// Token: 0x040012C6 RID: 4806
		[AccessedThroughProperty("txt_ta_tarikh")]
		private DateBox2 _txt_ta_tarikh;

		// Token: 0x040012C7 RID: 4807
		[AccessedThroughProperty("txt_az_tarikh")]
		private DateBox2 _txt_az_tarikh;

		// Token: 0x040012C8 RID: 4808
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x040012C9 RID: 4809
		[AccessedThroughProperty("UiCheckBox2")]
		private UICheckBox _UiCheckBox2;

		// Token: 0x040012CA RID: 4810
		[AccessedThroughProperty("Bar1")]
		private Bar _Bar1;

		// Token: 0x040012CB RID: 4811
		[AccessedThroughProperty("ButtonItem1")]
		private ButtonItem _ButtonItem1;

		// Token: 0x040012CC RID: 4812
		[AccessedThroughProperty("EditBox1")]
		private EditBox _EditBox1;

		// Token: 0x040012CD RID: 4813
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x040012CE RID: 4814
		[AccessedThroughProperty("Timer1")]
		private Timer _Timer1;

		// Token: 0x040012CF RID: 4815
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x040012D0 RID: 4816
		[AccessedThroughProperty("txt_moshtari")]
		private SelectItem _txt_moshtari;

		// Token: 0x040012D1 RID: 4817
		[CompilerGenerated]
		private int? _BankHesab_ID;

		// Token: 0x040012D2 RID: 4818
		[CompilerGenerated]
		private string _BankHesab_Name;
	}
}
