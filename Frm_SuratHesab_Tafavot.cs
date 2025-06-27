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
	// Token: 0x02000152 RID: 338
	[DesignerGenerated]
	public partial class Frm_SuratHesab_Tafavot : Form
	{
		// Token: 0x060032F0 RID: 13040 RVA: 0x0000CC8F File Offset: 0x0000AE8F
		[DebuggerNonUserCode]
		public Frm_SuratHesab_Tafavot()
		{
			base.KeyDown += new KeyEventHandler(this.Frm_SuratHesab_Hazine_KeyDown);
			base.Load += new EventHandler(this.Frm_SuratHesab_Moshtari_Load);
			Frm_SuratHesab_Tafavot.__ENCAddToList(this);
			this.InitializeComponent();
		}

		// Token: 0x060032F1 RID: 13041 RVA: 0x0024FC40 File Offset: 0x0024DE40
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_SuratHesab_Tafavot.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_SuratHesab_Tafavot.__ENCList.Count == Frm_SuratHesab_Tafavot.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_SuratHesab_Tafavot.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_SuratHesab_Tafavot.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_SuratHesab_Tafavot.__ENCList[num] = Frm_SuratHesab_Tafavot.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_SuratHesab_Tafavot.__ENCList.RemoveRange(num, Frm_SuratHesab_Tafavot.__ENCList.Count - num);
						Frm_SuratHesab_Tafavot.__ENCList.Capacity = Frm_SuratHesab_Tafavot.__ENCList.Count;
					}
					Frm_SuratHesab_Tafavot.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000F9E RID: 3998
		// (get) Token: 0x060032F4 RID: 13044 RVA: 0x00250980 File Offset: 0x0024EB80
		// (set) Token: 0x060032F5 RID: 13045 RVA: 0x0000CCCF File Offset: 0x0000AECF
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

		// Token: 0x17000F9F RID: 3999
		// (get) Token: 0x060032F6 RID: 13046 RVA: 0x00250998 File Offset: 0x0024EB98
		// (set) Token: 0x060032F7 RID: 13047 RVA: 0x0000CCD9 File Offset: 0x0000AED9
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

		// Token: 0x17000FA0 RID: 4000
		// (get) Token: 0x060032F8 RID: 13048 RVA: 0x002509B0 File Offset: 0x0024EBB0
		// (set) Token: 0x060032F9 RID: 13049 RVA: 0x0000CCE3 File Offset: 0x0000AEE3
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

		// Token: 0x17000FA1 RID: 4001
		// (get) Token: 0x060032FA RID: 13050 RVA: 0x002509C8 File Offset: 0x0024EBC8
		// (set) Token: 0x060032FB RID: 13051 RVA: 0x002509E0 File Offset: 0x0024EBE0
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

		// Token: 0x17000FA2 RID: 4002
		// (get) Token: 0x060032FC RID: 13052 RVA: 0x00250A40 File Offset: 0x0024EC40
		// (set) Token: 0x060032FD RID: 13053 RVA: 0x00250A58 File Offset: 0x0024EC58
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

		// Token: 0x17000FA3 RID: 4003
		// (get) Token: 0x060032FE RID: 13054 RVA: 0x00250AB8 File Offset: 0x0024ECB8
		// (set) Token: 0x060032FF RID: 13055 RVA: 0x0000CCED File Offset: 0x0000AEED
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

		// Token: 0x17000FA4 RID: 4004
		// (get) Token: 0x06003300 RID: 13056 RVA: 0x00250AD0 File Offset: 0x0024ECD0
		// (set) Token: 0x06003301 RID: 13057 RVA: 0x00250AE8 File Offset: 0x0024ECE8
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

		// Token: 0x17000FA5 RID: 4005
		// (get) Token: 0x06003302 RID: 13058 RVA: 0x00250B48 File Offset: 0x0024ED48
		// (set) Token: 0x06003303 RID: 13059 RVA: 0x0000CCF7 File Offset: 0x0000AEF7
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

		// Token: 0x17000FA6 RID: 4006
		// (get) Token: 0x06003304 RID: 13060 RVA: 0x00250B60 File Offset: 0x0024ED60
		// (set) Token: 0x06003305 RID: 13061 RVA: 0x00250B78 File Offset: 0x0024ED78
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

		// Token: 0x17000FA7 RID: 4007
		// (get) Token: 0x06003306 RID: 13062 RVA: 0x00250BD8 File Offset: 0x0024EDD8
		// (set) Token: 0x06003307 RID: 13063 RVA: 0x00250BF0 File Offset: 0x0024EDF0
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

		// Token: 0x17000FA8 RID: 4008
		// (get) Token: 0x06003308 RID: 13064 RVA: 0x00250C50 File Offset: 0x0024EE50
		// (set) Token: 0x06003309 RID: 13065 RVA: 0x0000CD01 File Offset: 0x0000AF01
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

		// Token: 0x17000FA9 RID: 4009
		// (get) Token: 0x0600330A RID: 13066 RVA: 0x00250C68 File Offset: 0x0024EE68
		// (set) Token: 0x0600330B RID: 13067 RVA: 0x00250C80 File Offset: 0x0024EE80
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

		// Token: 0x17000FAA RID: 4010
		// (get) Token: 0x0600330C RID: 13068 RVA: 0x00250CE0 File Offset: 0x0024EEE0
		// (set) Token: 0x0600330D RID: 13069 RVA: 0x0000CD0B File Offset: 0x0000AF0B
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

		// Token: 0x17000FAB RID: 4011
		// (get) Token: 0x0600330E RID: 13070 RVA: 0x00250CF8 File Offset: 0x0024EEF8
		// (set) Token: 0x0600330F RID: 13071 RVA: 0x0000CD15 File Offset: 0x0000AF15
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

		// Token: 0x06003310 RID: 13072 RVA: 0x00250D10 File Offset: 0x0024EF10
		private void LoadData()
		{
			DataTable dataSource = Public_Function.FillData("SELECT     DaryaftPardakht.ID, DaryaftPardakht.dpType_ID, DaryaftPardakht.Tarikh, DaryaftPardakht.Moshtari_ID, DaryaftPardakht.Mablagh, DaryaftPardakht.Tozih,  DaryaftPardakht.Tarikh_Fa, Moshtari.Name + ' ' + Moshtari.Family AS Moshtari_Name  FROM         DaryaftPardakht INNER JOIN  Moshtari ON DaryaftPardakht.Moshtari_ID = Moshtari.ID  WHERE DaryaftPardakht.dptype_ID = 8  order by tarikh,id");
			this.GridEX1.DataSource = dataSource;
			Public_Function.AddFilterColumn(this.GridEX1);
			this.EditBox1.Focus();
		}

		// Token: 0x06003311 RID: 13073 RVA: 0x00250D50 File Offset: 0x0024EF50
		private void FilterDate()
		{
			bool flag = this.GridEX1.DataSource == null;
			if (!flag)
			{
				flag = !this.UiCheckBox2.Checked;
				if (!flag)
				{
					DataTable dataTable = (DataTable)this.GridEX1.DataSource;
					DataRow dataRow = Public_Function.FillDataRow(" SELECT    isnull(sum(DaryaftPardakht.Mablagh),0) AS Mablagh,'مانده از قبل' AS Tozih FROM         DaryaftPardakht INNER JOIN  Moshtari ON DaryaftPardakht.Moshtari_ID = Moshtari.ID  WHERE DaryaftPardakht.dptype_ID = 8  and Tarikh<" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_az_tarikh.Text)));
					DataRow dataRow2 = dataTable.NewRow();
					flag = Operators.ConditionalCompareObjectNotEqual(dataRow["mablagh"], 0, false);
					if (flag)
					{
						dataRow2["Mablagh"] = RuntimeHelpers.GetObjectValue(dataRow["mablagh"]);
						flag = (dataTable.Rows[0]["ID"] == DBNull.Value);
						if (flag)
						{
							dataTable.Rows[0].Delete();
						}
						dataRow2["tarikh_Fa"] = "مانده از قبل";
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

		// Token: 0x06003312 RID: 13074 RVA: 0x00250EDC File Offset: 0x0024F0DC
		private void txt_az_tarikh_KeyDown_1(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				this.FilterDate();
			}
		}

		// Token: 0x06003313 RID: 13075 RVA: 0x00250F04 File Offset: 0x0024F104
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

		// Token: 0x06003314 RID: 13076 RVA: 0x00250FF4 File Offset: 0x0024F1F4
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

		// Token: 0x06003315 RID: 13077 RVA: 0x0000CD1F File Offset: 0x0000AF1F
		private void Frm_SuratHesab_Moshtari_Load(object sender, EventArgs e)
		{
			this.txt_az_tarikh.SetNew();
			this.txt_ta_tarikh.SetNew();
			this.LoadData();
		}

		// Token: 0x06003316 RID: 13078 RVA: 0x00128E48 File Offset: 0x00127048
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

		// Token: 0x06003317 RID: 13079 RVA: 0x00251034 File Offset: 0x0024F234
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
			Public_Function.setReportFont(stiReport, "Text10,Text12,Text8");
			Public_Function.SetReport_MarginTop(stiReport);
			stiReport.Print(false);
		}

		// Token: 0x06003318 RID: 13080 RVA: 0x0000CD42 File Offset: 0x0000AF42
		private void EditBox1_TextChanged(object sender, EventArgs e)
		{
			Public_Function.FilterGrid(this.GridEX1, this.EditBox1.Text);
		}

		// Token: 0x06003319 RID: 13081 RVA: 0x0000CD5D File Offset: 0x0000AF5D
		private void Timer1_Tick(object sender, EventArgs e)
		{
			this.Timer1.Enabled = false;
			this.GridEX1.MoveLast();
		}

		// Token: 0x040013C5 RID: 5061
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x040013C7 RID: 5063
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x040013C8 RID: 5064
		[AccessedThroughProperty("UiGroupBox2")]
		private UIGroupBox _UiGroupBox2;

		// Token: 0x040013C9 RID: 5065
		[AccessedThroughProperty("GridEX1")]
		private DataEntryGrid _GridEX1;

		// Token: 0x040013CA RID: 5066
		[AccessedThroughProperty("txt_ta_tarikh")]
		private DateBox2 _txt_ta_tarikh;

		// Token: 0x040013CB RID: 5067
		[AccessedThroughProperty("txt_az_tarikh")]
		private DateBox2 _txt_az_tarikh;

		// Token: 0x040013CC RID: 5068
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x040013CD RID: 5069
		[AccessedThroughProperty("UiCheckBox2")]
		private UICheckBox _UiCheckBox2;

		// Token: 0x040013CE RID: 5070
		[AccessedThroughProperty("Bar1")]
		private Bar _Bar1;

		// Token: 0x040013CF RID: 5071
		[AccessedThroughProperty("ButtonItem1")]
		private ButtonItem _ButtonItem1;

		// Token: 0x040013D0 RID: 5072
		[AccessedThroughProperty("EditBox1")]
		private EditBox _EditBox1;

		// Token: 0x040013D1 RID: 5073
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x040013D2 RID: 5074
		[AccessedThroughProperty("Timer1")]
		private Timer _Timer1;

		// Token: 0x040013D3 RID: 5075
		[CompilerGenerated]
		private int? _BankHesab_ID;

		// Token: 0x040013D4 RID: 5076
		[CompilerGenerated]
		private string _BankHesab_Name;
	}
}
