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
	// Token: 0x02000131 RID: 305
	[DesignerGenerated]
	public partial class Frm_rpt_kasrezafesandug : Form
	{
		// Token: 0x06002C10 RID: 11280 RVA: 0x0000B160 File Offset: 0x00009360
		[DebuggerNonUserCode]
		public Frm_rpt_kasrezafesandug()
		{
			base.KeyDown += new KeyEventHandler(this.Frm_rpt_kasrezafesandug_KeyDown);
			base.Load += new EventHandler(this.Frm_rpt_kasrezafesandug_Load);
			Frm_rpt_kasrezafesandug.__ENCAddToList(this);
			this.InitializeComponent();
		}

		// Token: 0x06002C11 RID: 11281 RVA: 0x0020C148 File Offset: 0x0020A348
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_rpt_kasrezafesandug.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_rpt_kasrezafesandug.__ENCList.Count == Frm_rpt_kasrezafesandug.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_rpt_kasrezafesandug.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_rpt_kasrezafesandug.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_rpt_kasrezafesandug.__ENCList[num] = Frm_rpt_kasrezafesandug.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_rpt_kasrezafesandug.__ENCList.RemoveRange(num, Frm_rpt_kasrezafesandug.__ENCList.Count - num);
						Frm_rpt_kasrezafesandug.__ENCList.Capacity = Frm_rpt_kasrezafesandug.__ENCList.Count;
					}
					Frm_rpt_kasrezafesandug.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000D67 RID: 3431
		// (get) Token: 0x06002C14 RID: 11284 RVA: 0x0020CC1C File Offset: 0x0020AE1C
		// (set) Token: 0x06002C15 RID: 11285 RVA: 0x0000B1A0 File Offset: 0x000093A0
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

		// Token: 0x17000D68 RID: 3432
		// (get) Token: 0x06002C16 RID: 11286 RVA: 0x0020CC34 File Offset: 0x0020AE34
		// (set) Token: 0x06002C17 RID: 11287 RVA: 0x0000B1AA File Offset: 0x000093AA
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

		// Token: 0x17000D69 RID: 3433
		// (get) Token: 0x06002C18 RID: 11288 RVA: 0x0020CC4C File Offset: 0x0020AE4C
		// (set) Token: 0x06002C19 RID: 11289 RVA: 0x0020CC64 File Offset: 0x0020AE64
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

		// Token: 0x17000D6A RID: 3434
		// (get) Token: 0x06002C1A RID: 11290 RVA: 0x0020CCC4 File Offset: 0x0020AEC4
		// (set) Token: 0x06002C1B RID: 11291 RVA: 0x0000B1B4 File Offset: 0x000093B4
		internal virtual EditBox txt_search
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_search;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_search = value;
			}
		}

		// Token: 0x17000D6B RID: 3435
		// (get) Token: 0x06002C1C RID: 11292 RVA: 0x0020CCDC File Offset: 0x0020AEDC
		// (set) Token: 0x06002C1D RID: 11293 RVA: 0x0000B1BE File Offset: 0x000093BE
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
				this._SelectItem1 = value;
			}
		}

		// Token: 0x17000D6C RID: 3436
		// (get) Token: 0x06002C1E RID: 11294 RVA: 0x0020CCF4 File Offset: 0x0020AEF4
		// (set) Token: 0x06002C1F RID: 11295 RVA: 0x0000B1C8 File Offset: 0x000093C8
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

		// Token: 0x17000D6D RID: 3437
		// (get) Token: 0x06002C20 RID: 11296 RVA: 0x0020CD0C File Offset: 0x0020AF0C
		// (set) Token: 0x06002C21 RID: 11297 RVA: 0x0000B1D2 File Offset: 0x000093D2
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

		// Token: 0x17000D6E RID: 3438
		// (get) Token: 0x06002C22 RID: 11298 RVA: 0x0020CD24 File Offset: 0x0020AF24
		// (set) Token: 0x06002C23 RID: 11299 RVA: 0x0020CD3C File Offset: 0x0020AF3C
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

		// Token: 0x06002C24 RID: 11300 RVA: 0x0020CD9C File Offset: 0x0020AF9C
		private void LoadData()
		{
			DataTable dataTable = Public_Function.FillData("SELECT     DaryaftPardakht.ID,null as gabl,null as mojod, DaryaftPardakht.dpType_ID, DaryaftPardakht.Tarikh, DaryaftPardakht.Tarikh_Fa,  CASE WHEN dptype_id = 5 THEN mablagh END AS ezafe, CASE WHEN dptype_id = 16 THEN mablagh END AS kasr  FROM         DaryaftPardakht  WHERE     (DaryaftPardakht.dpType_ID IN (5, 16)) order by DaryaftPardakht.Tarikh");
			bool flag = dataTable.Rows.Count == 0;
			if (!flag)
			{
				flag = Operators.ConditionalCompareObjectEqual(dataTable.Rows[0]["tarikh_fa"], "1392/01/01", false);
				if (flag)
				{
					dataTable.Rows[0]["tarikh_fa"] = "اول دوره";
				}
				flag = (dataTable.Rows.Count > 2);
				if (flag)
				{
					bool flag2 = Operators.ConditionalCompareObjectEqual(dataTable.Rows[1]["tarikh_fa"], "1392/01/01", false);
					if (flag2)
					{
						dataTable.Rows[1]["tarikh_fa"] = "اول دوره";
					}
				}
				this.GridEX1.DataSource = dataTable;
				Public_Function.AddFilterColumn(this.GridEX1);
			}
		}

		// Token: 0x06002C25 RID: 11301 RVA: 0x0006620C File Offset: 0x0006440C
		private void Frm_rpt_kasrezafesandug_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Escape;
			if (flag)
			{
				this.Close();
			}
		}

		// Token: 0x06002C26 RID: 11302 RVA: 0x0000B1DC File Offset: 0x000093DC
		private void Frm_rpt_kasrezafesandug_Load(object sender, EventArgs e)
		{
			this.LoadData();
		}

		// Token: 0x06002C27 RID: 11303 RVA: 0x00128E48 File Offset: 0x00127048
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

		// Token: 0x06002C28 RID: 11304 RVA: 0x0020CE80 File Offset: 0x0020B080
		private void ButtonItem1_Click(object sender, EventArgs e)
		{
			StiReport stiReport = new StiReport();
			stiReport.Load(Application.StartupPath + "\\reports\\kasrezafi.mrt");
			DataTable dataTable = (DataTable)this.GridEX1.DataSource;
			dataTable.TableName = "data";
			stiReport.RegData(dataTable);
			this.SetHeader(stiReport);
			Public_Function.AddTazminText(stiReport, true, false);
			Public_Function.SetReport_MarginTop(stiReport);
			stiReport.Print(false);
		}

		// Token: 0x06002C29 RID: 11305 RVA: 0x0000B1E7 File Offset: 0x000093E7
		private void EditBox1_TextChanged(object sender, EventArgs e)
		{
			Public_Function.FilterGrid(this.GridEX1, this.EditBox1.Text);
		}

		// Token: 0x04001125 RID: 4389
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04001127 RID: 4391
		[AccessedThroughProperty("GridEX1")]
		private GridEX _GridEX1;

		// Token: 0x04001128 RID: 4392
		[AccessedThroughProperty("Bar1")]
		private Bar _Bar1;

		// Token: 0x04001129 RID: 4393
		[AccessedThroughProperty("ButtonItem1")]
		private ButtonItem _ButtonItem1;

		// Token: 0x0400112A RID: 4394
		[AccessedThroughProperty("txt_search")]
		private EditBox _txt_search;

		// Token: 0x0400112B RID: 4395
		[AccessedThroughProperty("SelectItem1")]
		private SelectItem _SelectItem1;

		// Token: 0x0400112C RID: 4396
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x0400112D RID: 4397
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x0400112E RID: 4398
		[AccessedThroughProperty("EditBox1")]
		private EditBox _EditBox1;
	}
}
