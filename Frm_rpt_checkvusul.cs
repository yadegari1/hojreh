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
using Janus.Windows.UI.Dock;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Stimulsoft.Report;
using Stimulsoft.Report.Components;

namespace FruitBox
{
	// Token: 0x0200012D RID: 301
	[DesignerGenerated]
	public partial class Frm_rpt_checkvusul : Form
	{
		// Token: 0x06002BA0 RID: 11168 RVA: 0x0000AEFB File Offset: 0x000090FB
		[DebuggerNonUserCode]
		public Frm_rpt_checkvusul()
		{
			base.Load += new EventHandler(this.Frm_rpt_checkDaryafti_Load);
			base.KeyDown += new KeyEventHandler(this.Frm_rpt_checkvusul_KeyDown);
			Frm_rpt_checkvusul.__ENCAddToList(this);
			this.InitializeComponent();
		}

		// Token: 0x06002BA1 RID: 11169 RVA: 0x00208534 File Offset: 0x00206734
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_rpt_checkvusul.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_rpt_checkvusul.__ENCList.Count == Frm_rpt_checkvusul.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_rpt_checkvusul.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_rpt_checkvusul.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_rpt_checkvusul.__ENCList[num] = Frm_rpt_checkvusul.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_rpt_checkvusul.__ENCList.RemoveRange(num, Frm_rpt_checkvusul.__ENCList.Count - num);
						Frm_rpt_checkvusul.__ENCList.Capacity = Frm_rpt_checkvusul.__ENCList.Count;
					}
					Frm_rpt_checkvusul.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000D45 RID: 3397
		// (get) Token: 0x06002BA4 RID: 11172 RVA: 0x00208D64 File Offset: 0x00206F64
		// (set) Token: 0x06002BA5 RID: 11173 RVA: 0x0000AF3B File Offset: 0x0000913B
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

		// Token: 0x17000D46 RID: 3398
		// (get) Token: 0x06002BA6 RID: 11174 RVA: 0x00208D7C File Offset: 0x00206F7C
		// (set) Token: 0x06002BA7 RID: 11175 RVA: 0x0000AF45 File Offset: 0x00009145
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

		// Token: 0x17000D47 RID: 3399
		// (get) Token: 0x06002BA8 RID: 11176 RVA: 0x00208D94 File Offset: 0x00206F94
		// (set) Token: 0x06002BA9 RID: 11177 RVA: 0x0000AF4F File Offset: 0x0000914F
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

		// Token: 0x17000D48 RID: 3400
		// (get) Token: 0x06002BAA RID: 11178 RVA: 0x00208DAC File Offset: 0x00206FAC
		// (set) Token: 0x06002BAB RID: 11179 RVA: 0x00208DC4 File Offset: 0x00206FC4
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

		// Token: 0x17000D49 RID: 3401
		// (get) Token: 0x06002BAC RID: 11180 RVA: 0x00208E24 File Offset: 0x00207024
		// (set) Token: 0x06002BAD RID: 11181 RVA: 0x00208E3C File Offset: 0x0020703C
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

		// Token: 0x17000D4A RID: 3402
		// (get) Token: 0x06002BAE RID: 11182 RVA: 0x00208E9C File Offset: 0x0020709C
		// (set) Token: 0x06002BAF RID: 11183 RVA: 0x0000AF59 File Offset: 0x00009159
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

		// Token: 0x17000D4B RID: 3403
		// (get) Token: 0x06002BB0 RID: 11184 RVA: 0x00208EB4 File Offset: 0x002070B4
		// (set) Token: 0x06002BB1 RID: 11185 RVA: 0x00208ECC File Offset: 0x002070CC
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

		// Token: 0x06002BB2 RID: 11186 RVA: 0x00208F2C File Offset: 0x0020712C
		private void LoadData()
		{
			DataTable dataSource = Public_Function.FillData("SELECT     DaryaftPardakht.ID, DaryaftPardakht.dpType_ID, DaryaftPardakht.Tarikh, DaryaftPardakht.SanadBed_ID, DaryaftPardakht.SanadBes_ID, DaryaftPardakht.Moshtari_ID,     DaryaftPardakht.Mablagh, DaryaftPardakht.Tozih, DaryaftPardakht.Tarikh_Fa, DaryaftPardakht.Sh_Check, DaryaftPardakht.CheckBank_ID,     DaryaftPardakht.Check_Shobe, DaryaftPardakht.Check_Sarresid, DaryaftPardakht.Check_Sarresid_Fa, DaryaftPardakht.Check_Status,     DaryaftPardakht.Check_ShomareHesab, Moshtari.Name + ' ' + Moshtari.Family AS Moshtari_Name, Bank.Name AS Bank_Name     FROM         DaryaftPardakht INNER JOIN     Moshtari ON DaryaftPardakht.Moshtari_ID = Moshtari.ID Left Outer JOIN     Bank ON DaryaftPardakht.CheckBank_ID = Bank.ID   WHERE     (DaryaftPardakht.dpType_ID IN(2,-99,42) AND (DaryaftPardakht.Check_Status = 3)) order by DaryaftPardakht.Check_Sarresid");
			this.GridEX1.DataSource = dataSource;
			Public_Function.AddFilterColumn(this.GridEX1);
		}

		// Token: 0x06002BB3 RID: 11187 RVA: 0x00208F60 File Offset: 0x00207160
		private void Frm_rpt_checkvusul_KeyDown(object sender, KeyEventArgs e)
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

		// Token: 0x06002BB4 RID: 11188 RVA: 0x0000AF63 File Offset: 0x00009163
		private void Frm_rpt_checkDaryafti_Load(object sender, EventArgs e)
		{
			this.LoadData();
		}

		// Token: 0x06002BB5 RID: 11189 RVA: 0x00208FA0 File Offset: 0x002071A0
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

		// Token: 0x06002BB6 RID: 11190 RVA: 0x00128E48 File Offset: 0x00127048
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

		// Token: 0x06002BB7 RID: 11191 RVA: 0x00208FEC File Offset: 0x002071EC
		private void ButtonItem1_Click(object sender, EventArgs e)
		{
			StiReport stiReport = new StiReport();
			stiReport.Load(Application.StartupPath + "\\reports\\checkvusul.mrt");
			DataTable tabla = (DataTable)this.GridEX1.DataSource;
			DataTable dataTable = Public_Function.CopyTableView(tabla, "data");
			stiReport.RegData(dataTable);
			this.SetHeader(stiReport);
			Public_Function.AddTazminText(stiReport, true, false);
			Public_Function.setReportFont(stiReport, "Text12,Text13,Text16,Text17,Text18");
			Public_Function.SetReport_MarginTop(stiReport);
			stiReport.Print(false);
		}

		// Token: 0x06002BB8 RID: 11192 RVA: 0x0000AF6E File Offset: 0x0000916E
		private void EditBox1_TextChanged(object sender, EventArgs e)
		{
			Public_Function.FilterGrid(this.GridEX1, this.EditBox1.Text);
		}

		// Token: 0x040010F8 RID: 4344
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x040010FA RID: 4346
		[AccessedThroughProperty("GridEX1")]
		private GridEX _GridEX1;

		// Token: 0x040010FB RID: 4347
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x040010FC RID: 4348
		[AccessedThroughProperty("Bar1")]
		private Bar _Bar1;

		// Token: 0x040010FD RID: 4349
		[AccessedThroughProperty("ButtonItem1")]
		private ButtonItem _ButtonItem1;

		// Token: 0x040010FE RID: 4350
		[AccessedThroughProperty("EditBox1")]
		private EditBox _EditBox1;

		// Token: 0x040010FF RID: 4351
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x04001100 RID: 4352
		[AccessedThroughProperty("Timer1")]
		private Timer _Timer1;
	}
}
