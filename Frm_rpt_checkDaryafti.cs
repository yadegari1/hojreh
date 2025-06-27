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
using FruitBox.My;
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
	// Token: 0x02000129 RID: 297
	[DesignerGenerated]
	public partial class Frm_rpt_checkDaryafti : Form
	{
		// Token: 0x06002B1F RID: 11039 RVA: 0x0000AC40 File Offset: 0x00008E40
		[DebuggerNonUserCode]
		public Frm_rpt_checkDaryafti()
		{
			base.Load += new EventHandler(this.Frm_rpt_checkDaryafti_Load);
			base.KeyDown += new KeyEventHandler(this.Frm_rpt_checkDaryafti_KeyDown);
			Frm_rpt_checkDaryafti.__ENCAddToList(this);
			this.InitializeComponent();
		}

		// Token: 0x06002B20 RID: 11040 RVA: 0x002041A4 File Offset: 0x002023A4
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_rpt_checkDaryafti.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_rpt_checkDaryafti.__ENCList.Count == Frm_rpt_checkDaryafti.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_rpt_checkDaryafti.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_rpt_checkDaryafti.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_rpt_checkDaryafti.__ENCList[num] = Frm_rpt_checkDaryafti.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_rpt_checkDaryafti.__ENCList.RemoveRange(num, Frm_rpt_checkDaryafti.__ENCList.Count - num);
						Frm_rpt_checkDaryafti.__ENCList.Capacity = Frm_rpt_checkDaryafti.__ENCList.Count;
					}
					Frm_rpt_checkDaryafti.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000D1F RID: 3359
		// (get) Token: 0x06002B23 RID: 11043 RVA: 0x00204CD4 File Offset: 0x00202ED4
		// (set) Token: 0x06002B24 RID: 11044 RVA: 0x0000AC80 File Offset: 0x00008E80
		internal virtual GridEX GridEX1
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

		// Token: 0x17000D20 RID: 3360
		// (get) Token: 0x06002B25 RID: 11045 RVA: 0x00204CEC File Offset: 0x00202EEC
		// (set) Token: 0x06002B26 RID: 11046 RVA: 0x0000AC8A File Offset: 0x00008E8A
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

		// Token: 0x17000D21 RID: 3361
		// (get) Token: 0x06002B27 RID: 11047 RVA: 0x00204D04 File Offset: 0x00202F04
		// (set) Token: 0x06002B28 RID: 11048 RVA: 0x0000AC94 File Offset: 0x00008E94
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

		// Token: 0x17000D22 RID: 3362
		// (get) Token: 0x06002B29 RID: 11049 RVA: 0x00204D1C File Offset: 0x00202F1C
		// (set) Token: 0x06002B2A RID: 11050 RVA: 0x00204D34 File Offset: 0x00202F34
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

		// Token: 0x17000D23 RID: 3363
		// (get) Token: 0x06002B2B RID: 11051 RVA: 0x00204D94 File Offset: 0x00202F94
		// (set) Token: 0x06002B2C RID: 11052 RVA: 0x0000AC9E File Offset: 0x00008E9E
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

		// Token: 0x17000D24 RID: 3364
		// (get) Token: 0x06002B2D RID: 11053 RVA: 0x00204DAC File Offset: 0x00202FAC
		// (set) Token: 0x06002B2E RID: 11054 RVA: 0x00204DC4 File Offset: 0x00202FC4
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

		// Token: 0x17000D25 RID: 3365
		// (get) Token: 0x06002B2F RID: 11055 RVA: 0x00204E24 File Offset: 0x00203024
		// (set) Token: 0x06002B30 RID: 11056 RVA: 0x00204E3C File Offset: 0x0020303C
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

		// Token: 0x17000D26 RID: 3366
		// (get) Token: 0x06002B31 RID: 11057 RVA: 0x00204E9C File Offset: 0x0020309C
		// (set) Token: 0x06002B32 RID: 11058 RVA: 0x0000ACA8 File Offset: 0x00008EA8
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

		// Token: 0x17000D27 RID: 3367
		// (get) Token: 0x06002B33 RID: 11059 RVA: 0x00204EB4 File Offset: 0x002030B4
		// (set) Token: 0x06002B34 RID: 11060 RVA: 0x00204ECC File Offset: 0x002030CC
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

		// Token: 0x17000D28 RID: 3368
		// (get) Token: 0x06002B35 RID: 11061 RVA: 0x00204F2C File Offset: 0x0020312C
		// (set) Token: 0x06002B36 RID: 11062 RVA: 0x0000ACB2 File Offset: 0x00008EB2
		public int? Moshtari_ID
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Moshtari_ID;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Moshtari_ID = value;
			}
		}

		// Token: 0x17000D29 RID: 3369
		// (get) Token: 0x06002B37 RID: 11063 RVA: 0x00204F44 File Offset: 0x00203144
		// (set) Token: 0x06002B38 RID: 11064 RVA: 0x0000ACBC File Offset: 0x00008EBC
		public string Moshtari_Name
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Moshtari_Name;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Moshtari_Name = value;
			}
		}

		// Token: 0x06002B39 RID: 11065 RVA: 0x00204F5C File Offset: 0x0020315C
		private void LoadData()
		{
			string str = string.Empty;
			bool flag = this.txt_moshtari.Value != null;
			if (flag)
			{
				str = Conversions.ToString(Operators.ConcatenateObject(" AND Moshtari.ID=", this.txt_moshtari.Value));
			}
			DataTable dataTable = Public_Function.FillData("SELECT     DaryaftPardakht.ID, DaryaftPardakht.dpType_ID, DaryaftPardakht.Tarikh, DaryaftPardakht.SanadBed_ID, DaryaftPardakht.SanadBes_ID, DaryaftPardakht.Moshtari_ID,     DaryaftPardakht.Mablagh, DaryaftPardakht.Tozih, DaryaftPardakht.Tarikh_Fa, DaryaftPardakht.Sh_Check, DaryaftPardakht.CheckBank_ID,     DaryaftPardakht.Check_Shobe, DaryaftPardakht.Check_Sarresid, DaryaftPardakht.Check_Sarresid_Fa, DaryaftPardakht.Check_Status,     DaryaftPardakht.Check_ShomareHesab, Moshtari.Name + ' ' + Moshtari.Family AS Moshtari_Name, Bank.Name AS Bank_Name     FROM         DaryaftPardakht INNER JOIN     Moshtari ON DaryaftPardakht.Moshtari_ID = Moshtari.ID Left Outer JOIN     Bank ON DaryaftPardakht.CheckBank_ID = Bank.ID   WHERE     (DaryaftPardakht.dpType_ID in(2,-99,42)) AND (DaryaftPardakht.Check_Status in (1)) " + str + " order by DaryaftPardakht.Check_Sarresid");
			try
			{
				IEnumerator enumerator = dataTable.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					flag = Operators.ConditionalCompareObjectEqual(dataRow["dpType_ID"], -99, false);
					if (flag)
					{
						dataRow["Tarikh_Fa"] = "اول دوره";
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
			Public_Function.AddFilterColumn(this.GridEX1);
		}

		// Token: 0x06002B3A RID: 11066 RVA: 0x00205060 File Offset: 0x00203260
		private void Frm_rpt_checkDaryafti_KeyDown(object sender, KeyEventArgs e)
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

		// Token: 0x06002B3B RID: 11067 RVA: 0x002050A0 File Offset: 0x002032A0
		private void Frm_rpt_checkDaryafti_Load(object sender, EventArgs e)
		{
			this.txt_moshtari.Edit_Frm = MyProject.Forms.Frm_Moshtari;
			bool hasValue = this.Moshtari_ID.HasValue;
			if (hasValue)
			{
				this.txt_moshtari.SetValue(this.Moshtari_Name, this.Moshtari_ID);
			}
			this.LoadData();
		}

		// Token: 0x06002B3C RID: 11068 RVA: 0x0000ACC6 File Offset: 0x00008EC6
		private void txt_moshtari_SelectedValueChanged(object sender, EventArgs e)
		{
			this.LoadData();
		}

		// Token: 0x06002B3D RID: 11069 RVA: 0x00128E48 File Offset: 0x00127048
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

		// Token: 0x06002B3E RID: 11070 RVA: 0x002050FC File Offset: 0x002032FC
		private void ButtonItem1_Click(object sender, EventArgs e)
		{
			StiReport stiReport = new StiReport();
			stiReport.Load(Application.StartupPath + "\\reports\\checkdaryafti.mrt");
			DataTable tabla = (DataTable)this.GridEX1.DataSource;
			DataTable dataTable = Public_Function.CopyTableView(tabla, "data");
			stiReport.RegData(dataTable);
			this.SetHeader(stiReport);
			Public_Function.AddTazminText(stiReport, true, false);
			Public_Function.setReportFont(stiReport, "Text12,Text13,Text16,Text17,Text18");
			Public_Function.SetReport_MarginTop(stiReport);
			stiReport.Print(false);
		}

		// Token: 0x06002B3F RID: 11071 RVA: 0x00205178 File Offset: 0x00203378
		private void Timer1_Tick(object sender, EventArgs e)
		{
			this.Timer1.Enabled = false;
			try
			{
				this.GridEX1.MoveLast();
			}
			catch (Exception expr_1D)
			{
				ProjectData.SetProjectError(expr_1D);
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06002B40 RID: 11072 RVA: 0x0000ACD1 File Offset: 0x00008ED1
		private void EditBox1_TextChanged(object sender, EventArgs e)
		{
			Public_Function.FilterGrid(this.GridEX1, this.EditBox1.Text);
		}

		// Token: 0x040010CA RID: 4298
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x040010CC RID: 4300
		[AccessedThroughProperty("GridEX1")]
		private GridEX _GridEX1;

		// Token: 0x040010CD RID: 4301
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x040010CE RID: 4302
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x040010CF RID: 4303
		[AccessedThroughProperty("txt_moshtari")]
		private SelectItem _txt_moshtari;

		// Token: 0x040010D0 RID: 4304
		[AccessedThroughProperty("Bar1")]
		private Bar _Bar1;

		// Token: 0x040010D1 RID: 4305
		[AccessedThroughProperty("ButtonItem1")]
		private ButtonItem _ButtonItem1;

		// Token: 0x040010D2 RID: 4306
		[AccessedThroughProperty("EditBox1")]
		private EditBox _EditBox1;

		// Token: 0x040010D3 RID: 4307
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x040010D4 RID: 4308
		[AccessedThroughProperty("Timer1")]
		private Timer _Timer1;

		// Token: 0x040010D5 RID: 4309
		[CompilerGenerated]
		private int? _Moshtari_ID;

		// Token: 0x040010D6 RID: 4310
		[CompilerGenerated]
		private string _Moshtari_Name;
	}
}
