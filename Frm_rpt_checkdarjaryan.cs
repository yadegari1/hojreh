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
using Janus.Windows.UI.Dock;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Stimulsoft.Report;
using Stimulsoft.Report.Components;

namespace FruitBox
{
	// Token: 0x02000128 RID: 296
	[DesignerGenerated]
	public partial class Frm_rpt_checkdarjaryan : Form
	{
		// Token: 0x06002B05 RID: 11013 RVA: 0x0000ABA5 File Offset: 0x00008DA5
		[DebuggerNonUserCode]
		public Frm_rpt_checkdarjaryan()
		{
			base.Load += new EventHandler(this.Frm_rpt_checkDaryafti_Load);
			base.KeyDown += new KeyEventHandler(this.Frm_rpt_checkdarjaryan_KeyDown);
			Frm_rpt_checkdarjaryan.__ENCAddToList(this);
			this.InitializeComponent();
		}

		// Token: 0x06002B06 RID: 11014 RVA: 0x002035EC File Offset: 0x002017EC
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_rpt_checkdarjaryan.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_rpt_checkdarjaryan.__ENCList.Count == Frm_rpt_checkdarjaryan.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_rpt_checkdarjaryan.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_rpt_checkdarjaryan.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_rpt_checkdarjaryan.__ENCList[num] = Frm_rpt_checkdarjaryan.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_rpt_checkdarjaryan.__ENCList.RemoveRange(num, Frm_rpt_checkdarjaryan.__ENCList.Count - num);
						Frm_rpt_checkdarjaryan.__ENCList.Capacity = Frm_rpt_checkdarjaryan.__ENCList.Count;
					}
					Frm_rpt_checkdarjaryan.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000D18 RID: 3352
		// (get) Token: 0x06002B09 RID: 11017 RVA: 0x00203E1C File Offset: 0x0020201C
		// (set) Token: 0x06002B0A RID: 11018 RVA: 0x0000ABE5 File Offset: 0x00008DE5
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

		// Token: 0x17000D19 RID: 3353
		// (get) Token: 0x06002B0B RID: 11019 RVA: 0x00203E34 File Offset: 0x00202034
		// (set) Token: 0x06002B0C RID: 11020 RVA: 0x0000ABEF File Offset: 0x00008DEF
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

		// Token: 0x17000D1A RID: 3354
		// (get) Token: 0x06002B0D RID: 11021 RVA: 0x00203E4C File Offset: 0x0020204C
		// (set) Token: 0x06002B0E RID: 11022 RVA: 0x0000ABF9 File Offset: 0x00008DF9
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

		// Token: 0x17000D1B RID: 3355
		// (get) Token: 0x06002B0F RID: 11023 RVA: 0x00203E64 File Offset: 0x00202064
		// (set) Token: 0x06002B10 RID: 11024 RVA: 0x00203E7C File Offset: 0x0020207C
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

		// Token: 0x17000D1C RID: 3356
		// (get) Token: 0x06002B11 RID: 11025 RVA: 0x00203EDC File Offset: 0x002020DC
		// (set) Token: 0x06002B12 RID: 11026 RVA: 0x00203EF4 File Offset: 0x002020F4
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

		// Token: 0x17000D1D RID: 3357
		// (get) Token: 0x06002B13 RID: 11027 RVA: 0x00203F54 File Offset: 0x00202154
		// (set) Token: 0x06002B14 RID: 11028 RVA: 0x0000AC03 File Offset: 0x00008E03
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

		// Token: 0x17000D1E RID: 3358
		// (get) Token: 0x06002B15 RID: 11029 RVA: 0x00203F6C File Offset: 0x0020216C
		// (set) Token: 0x06002B16 RID: 11030 RVA: 0x00203F84 File Offset: 0x00202184
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

		// Token: 0x06002B17 RID: 11031 RVA: 0x00203FE4 File Offset: 0x002021E4
		private void LoadData()
		{
			DataTable dataTable = Public_Function.FillData("SELECT     DaryaftPardakht.ID, DaryaftPardakht.dpType_ID, DaryaftPardakht.Tarikh, DaryaftPardakht.SanadBed_ID, DaryaftPardakht.SanadBes_ID, DaryaftPardakht.Moshtari_ID,     DaryaftPardakht.Mablagh, DaryaftPardakht.Tozih, DaryaftPardakht.Tarikh_Fa, DaryaftPardakht.Sh_Check, DaryaftPardakht.CheckBank_ID,     DaryaftPardakht.Check_Shobe, DaryaftPardakht.Check_Sarresid, DaryaftPardakht.Check_Sarresid_Fa, DaryaftPardakht.Check_Status,     DaryaftPardakht.Check_ShomareHesab, Moshtari.Name + ' ' + Moshtari.Family AS Moshtari_Name, Bank.Name AS Bank_Name     FROM         DaryaftPardakht INNER JOIN     Moshtari ON DaryaftPardakht.Moshtari_ID = Moshtari.ID Left Outer JOIN     Bank ON DaryaftPardakht.CheckBank_ID = Bank.ID   WHERE     (DaryaftPardakht.dpType_ID IN (2,-99,42)) AND (DaryaftPardakht.Check_Status = 2) order by DaryaftPardakht.Check_Sarresid");
			try
			{
				IEnumerator enumerator = dataTable.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					bool flag = Operators.ConditionalCompareObjectEqual(dataRow["dptype_ID"], -99, false);
					if (flag)
					{
						dataRow["tarikh_fa"] = "اول دوره";
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
			this.GridEX1.DataSource = dataTable;
			Public_Function.AddFilterColumn(this.GridEX1);
		}

		// Token: 0x06002B18 RID: 11032 RVA: 0x0020409C File Offset: 0x0020229C
		private void Frm_rpt_checkdarjaryan_KeyDown(object sender, KeyEventArgs e)
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

		// Token: 0x06002B19 RID: 11033 RVA: 0x0000AC0D File Offset: 0x00008E0D
		private void Frm_rpt_checkDaryafti_Load(object sender, EventArgs e)
		{
			this.LoadData();
		}

		// Token: 0x06002B1A RID: 11034 RVA: 0x00128E48 File Offset: 0x00127048
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

		// Token: 0x06002B1B RID: 11035 RVA: 0x002040DC File Offset: 0x002022DC
		private void ButtonItem1_Click(object sender, EventArgs e)
		{
			StiReport stiReport = new StiReport();
			stiReport.Load(Application.StartupPath + "\\reports\\checkdarjarian.mrt");
			DataTable tabla = (DataTable)this.GridEX1.DataSource;
			DataTable dataTable = Public_Function.CopyTableView(tabla, "data");
			stiReport.RegData(dataTable);
			this.SetHeader(stiReport);
			Public_Function.AddTazminText(stiReport, true, false);
			Public_Function.setReportFont(stiReport, "Text12,Text13,Text16,Text17,Text18");
			Public_Function.SetReport_MarginTop(stiReport);
			stiReport.Print(false);
		}

		// Token: 0x06002B1C RID: 11036 RVA: 0x00204158 File Offset: 0x00202358
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

		// Token: 0x06002B1D RID: 11037 RVA: 0x0000AC18 File Offset: 0x00008E18
		private void EditBox1_TextChanged(object sender, EventArgs e)
		{
			Public_Function.FilterGrid(this.GridEX1, this.EditBox1.Text);
		}

		// Token: 0x040010C1 RID: 4289
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x040010C3 RID: 4291
		[AccessedThroughProperty("GridEX1")]
		private GridEX _GridEX1;

		// Token: 0x040010C4 RID: 4292
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x040010C5 RID: 4293
		[AccessedThroughProperty("Bar1")]
		private Bar _Bar1;

		// Token: 0x040010C6 RID: 4294
		[AccessedThroughProperty("ButtonItem1")]
		private ButtonItem _ButtonItem1;

		// Token: 0x040010C7 RID: 4295
		[AccessedThroughProperty("EditBox1")]
		private EditBox _EditBox1;

		// Token: 0x040010C8 RID: 4296
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x040010C9 RID: 4297
		[AccessedThroughProperty("Timer1")]
		private Timer _Timer1;
	}
}
