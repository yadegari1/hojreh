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
	// Token: 0x0200012E RID: 302
	[DesignerGenerated]
	public partial class Frm_rpt_dastecheck : Form
	{
		// Token: 0x06002BBA RID: 11194 RVA: 0x0000AF96 File Offset: 0x00009196
		[DebuggerNonUserCode]
		public Frm_rpt_dastecheck()
		{
			base.Load += new EventHandler(this.Frm_rpt_checkDaryafti_Load);
			base.KeyDown += new KeyEventHandler(this.Frm_rpt_dastecheck_KeyDown);
			Frm_rpt_dastecheck.__ENCAddToList(this);
			this.InitializeComponent();
		}

		// Token: 0x06002BBB RID: 11195 RVA: 0x00209068 File Offset: 0x00207268
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_rpt_dastecheck.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_rpt_dastecheck.__ENCList.Count == Frm_rpt_dastecheck.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_rpt_dastecheck.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_rpt_dastecheck.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_rpt_dastecheck.__ENCList[num] = Frm_rpt_dastecheck.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_rpt_dastecheck.__ENCList.RemoveRange(num, Frm_rpt_dastecheck.__ENCList.Count - num);
						Frm_rpt_dastecheck.__ENCList.Capacity = Frm_rpt_dastecheck.__ENCList.Count;
					}
					Frm_rpt_dastecheck.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000D4C RID: 3404
		// (get) Token: 0x06002BBE RID: 11198 RVA: 0x00209898 File Offset: 0x00207A98
		// (set) Token: 0x06002BBF RID: 11199 RVA: 0x0000AFD6 File Offset: 0x000091D6
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

		// Token: 0x17000D4D RID: 3405
		// (get) Token: 0x06002BC0 RID: 11200 RVA: 0x002098B0 File Offset: 0x00207AB0
		// (set) Token: 0x06002BC1 RID: 11201 RVA: 0x0000AFE0 File Offset: 0x000091E0
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

		// Token: 0x17000D4E RID: 3406
		// (get) Token: 0x06002BC2 RID: 11202 RVA: 0x002098C8 File Offset: 0x00207AC8
		// (set) Token: 0x06002BC3 RID: 11203 RVA: 0x0000AFEA File Offset: 0x000091EA
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

		// Token: 0x17000D4F RID: 3407
		// (get) Token: 0x06002BC4 RID: 11204 RVA: 0x002098E0 File Offset: 0x00207AE0
		// (set) Token: 0x06002BC5 RID: 11205 RVA: 0x002098F8 File Offset: 0x00207AF8
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

		// Token: 0x17000D50 RID: 3408
		// (get) Token: 0x06002BC6 RID: 11206 RVA: 0x00209958 File Offset: 0x00207B58
		// (set) Token: 0x06002BC7 RID: 11207 RVA: 0x00209970 File Offset: 0x00207B70
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

		// Token: 0x17000D51 RID: 3409
		// (get) Token: 0x06002BC8 RID: 11208 RVA: 0x002099D0 File Offset: 0x00207BD0
		// (set) Token: 0x06002BC9 RID: 11209 RVA: 0x0000AFF4 File Offset: 0x000091F4
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

		// Token: 0x17000D52 RID: 3410
		// (get) Token: 0x06002BCA RID: 11210 RVA: 0x002099E8 File Offset: 0x00207BE8
		// (set) Token: 0x06002BCB RID: 11211 RVA: 0x00209A00 File Offset: 0x00207C00
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

		// Token: 0x06002BCC RID: 11212 RVA: 0x00209A60 File Offset: 0x00207C60
		private void LoadData()
		{
			DataTable dataTable = Public_Function.FillData("SELECT     DaryaftPardakht.ID, DaryaftPardakht.dpType_ID, DaryaftPardakht.Tarikh, DaryaftPardakht.SanadBed_ID, DaryaftPardakht.SanadBes_ID, DaryaftPardakht.Moshtari_ID,   DaryaftPardakht.Mablagh, DaryaftPardakht.Tozih, DaryaftPardakht.Tarikh_Fa, DaryaftPardakht.Sh_Check, DaryaftPardakht.CheckBank_ID,   DaryaftPardakht.Check_Shobe, DaryaftPardakht.Check_Sarresid, DaryaftPardakht.Check_Sarresid_Fa, DaryaftPardakht.Check_Status,   DaryaftPardakht.Check_ShomareHesab,   CASE dptype_id WHEN 11 THEN Moshtari.Name + ' ' + Moshtari.Family WHEN - 98 THEN Moshtari.Name + ' ' + Moshtari.Family WHEN 15 THEN hazine.name END AS    Moshtari_Name, Bank_1.Name AS Bank_Name, Bank_Hesab.Shobe, DaryaftPardakht.CheckBarg_ID, Bank.Name,    CASE check_status WHEN 5 THEN 'پرداخت شده' WHEN 3 THEN 'وصول شده' END AS kind, Hazine.Name AS Hazine_Name, DaryaftPardakht.HazineKharid_ID   FROM         Hazine RIGHT OUTER JOIN   DaryaftPardakht LEFT OUTER JOIN   Hazine_Kharid ON DaryaftPardakht.HazineKharid_ID = Hazine_Kharid.ID ON Hazine.ID = DaryaftPardakht.Hazine_ID LEFT OUTER JOIN   DasteCheck INNER JOIN   DasteCheckBarg ON DasteCheck.ID = DasteCheckBarg.DasteCheck_ID INNER JOIN   Bank_Hesab ON DasteCheck.BankHesab_ID = Bank_Hesab.ID INNER JOIN   Bank ON Bank_Hesab.Bank_ID = Bank.ID ON DaryaftPardakht.CheckBarg_ID = DasteCheckBarg.ID LEFT OUTER JOIN   Bank AS Bank_1 ON DaryaftPardakht.CheckBank_ID = Bank_1.ID LEFT OUTER JOIN   Moshtari ON DaryaftPardakht.Moshtari_ID = Moshtari.ID   WHERE     (DaryaftPardakht.dpType_ID IN (15, 11, - 98)) AND (DaryaftPardakht.Check_Status IN (5))   ORDER BY DaryaftPardakht.Check_Sarresid");
			try
			{
				IEnumerator enumerator = dataTable.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					bool flag = Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], -98, false);
					bool flag2;
					if (flag)
					{
						dataRow["Tarikh_Fa"] = "اول دوره";
						flag = (dataRow["moshtari_name"] == DBNull.Value);
						if (flag)
						{
							flag2 = (dataRow["hazine_name"] != DBNull.Value);
							if (flag2)
							{
								dataRow["moshtari_name"] = RuntimeHelpers.GetObjectValue(dataRow["hazine_name"]);
							}
						}
					}
					flag2 = (dataRow["HazineKharid_ID"] != DBNull.Value);
					if (flag2)
					{
						flag = (dataRow["Tozih"] != DBNull.Value);
						if (flag)
						{
							dataRow["moshtari_name"] = RuntimeHelpers.GetObjectValue(dataRow["Tozih"]);
						}
					}
				}
			}
			finally
			{
				IEnumerator enumerator;
				bool flag2 = enumerator is IDisposable;
				if (flag2)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			this.GridEX1.DataSource = dataTable;
			Public_Function.AddFilterColumn(this.GridEX1);
		}

		// Token: 0x06002BCD RID: 11213 RVA: 0x0000AFFE File Offset: 0x000091FE
		private void Frm_rpt_checkDaryafti_Load(object sender, EventArgs e)
		{
			this.LoadData();
		}

		// Token: 0x06002BCE RID: 11214 RVA: 0x00209BC4 File Offset: 0x00207DC4
		private void Frm_rpt_dastecheck_KeyDown(object sender, KeyEventArgs e)
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

		// Token: 0x06002BCF RID: 11215 RVA: 0x00128E48 File Offset: 0x00127048
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

		// Token: 0x06002BD0 RID: 11216 RVA: 0x00209C04 File Offset: 0x00207E04
		private void ButtonItem1_Click(object sender, EventArgs e)
		{
			StiReport stiReport = new StiReport();
			stiReport.Load(Application.StartupPath + "\\reports\\dastecheck.mrt");
			DataTable dataTable = (DataTable)this.GridEX1.DataSource;
			DataTable dataTable2 = dataTable.Copy();
			dataTable2.TableName = "data";
			stiReport.RegData(dataTable2);
			this.SetHeader(stiReport);
			Public_Function.AddTazminText(stiReport, true, false);
			Public_Function.setReportFont(stiReport, "Text12,Text13,Text16,Text17");
			Public_Function.SetReport_MarginTop(stiReport);
			stiReport.Print(false);
		}

		// Token: 0x06002BD1 RID: 11217 RVA: 0x00209C88 File Offset: 0x00207E88
		private void Timer1_Tick(object sender, EventArgs e)
		{
			this.Timer1.Enabled = false;
			try
			{
				this.GridEX1.MoveLast();
				this.EditBox1.Focus();
			}
			catch (Exception expr_29)
			{
				ProjectData.SetProjectError(expr_29);
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06002BD2 RID: 11218 RVA: 0x0000B009 File Offset: 0x00009209
		private void EditBox1_TextChanged(object sender, EventArgs e)
		{
			Public_Function.FilterGrid(this.GridEX1, this.EditBox1.Text);
		}

		// Token: 0x04001101 RID: 4353
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04001103 RID: 4355
		[AccessedThroughProperty("GridEX1")]
		private GridEX _GridEX1;

		// Token: 0x04001104 RID: 4356
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x04001105 RID: 4357
		[AccessedThroughProperty("Bar1")]
		private Bar _Bar1;

		// Token: 0x04001106 RID: 4358
		[AccessedThroughProperty("ButtonItem1")]
		private ButtonItem _ButtonItem1;

		// Token: 0x04001107 RID: 4359
		[AccessedThroughProperty("EditBox1")]
		private EditBox _EditBox1;

		// Token: 0x04001108 RID: 4360
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x04001109 RID: 4361
		[AccessedThroughProperty("Timer1")]
		private Timer _Timer1;
	}
}
