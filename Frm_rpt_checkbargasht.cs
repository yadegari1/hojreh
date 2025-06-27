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
	// Token: 0x02000127 RID: 295
	[DesignerGenerated]
	public partial class Frm_rpt_checkbargasht : Form
	{
		// Token: 0x06002AEB RID: 10987 RVA: 0x0000AAE1 File Offset: 0x00008CE1
		[DebuggerNonUserCode]
		public Frm_rpt_checkbargasht()
		{
			base.Load += new EventHandler(this.Frm_rpt_checkDaryafti_Load);
			base.KeyDown += new KeyEventHandler(this.Frm_rpt_checkbargasht_KeyDown);
			Frm_rpt_checkbargasht.__ENCAddToList(this);
			this.InitializeComponent();
		}

		// Token: 0x06002AEC RID: 10988 RVA: 0x00202B04 File Offset: 0x00200D04
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_rpt_checkbargasht.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_rpt_checkbargasht.__ENCList.Count == Frm_rpt_checkbargasht.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_rpt_checkbargasht.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_rpt_checkbargasht.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_rpt_checkbargasht.__ENCList[num] = Frm_rpt_checkbargasht.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_rpt_checkbargasht.__ENCList.RemoveRange(num, Frm_rpt_checkbargasht.__ENCList.Count - num);
						Frm_rpt_checkbargasht.__ENCList.Capacity = Frm_rpt_checkbargasht.__ENCList.Count;
					}
					Frm_rpt_checkbargasht.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000D11 RID: 3345
		// (get) Token: 0x06002AEF RID: 10991 RVA: 0x00203334 File Offset: 0x00201534
		// (set) Token: 0x06002AF0 RID: 10992 RVA: 0x0000AB21 File Offset: 0x00008D21
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

		// Token: 0x17000D12 RID: 3346
		// (get) Token: 0x06002AF1 RID: 10993 RVA: 0x0020334C File Offset: 0x0020154C
		// (set) Token: 0x06002AF2 RID: 10994 RVA: 0x0000AB2B File Offset: 0x00008D2B
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

		// Token: 0x17000D13 RID: 3347
		// (get) Token: 0x06002AF3 RID: 10995 RVA: 0x00203364 File Offset: 0x00201564
		// (set) Token: 0x06002AF4 RID: 10996 RVA: 0x0000AB35 File Offset: 0x00008D35
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

		// Token: 0x17000D14 RID: 3348
		// (get) Token: 0x06002AF5 RID: 10997 RVA: 0x0020337C File Offset: 0x0020157C
		// (set) Token: 0x06002AF6 RID: 10998 RVA: 0x00203394 File Offset: 0x00201594
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

		// Token: 0x17000D15 RID: 3349
		// (get) Token: 0x06002AF7 RID: 10999 RVA: 0x002033F4 File Offset: 0x002015F4
		// (set) Token: 0x06002AF8 RID: 11000 RVA: 0x0020340C File Offset: 0x0020160C
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

		// Token: 0x17000D16 RID: 3350
		// (get) Token: 0x06002AF9 RID: 11001 RVA: 0x0020346C File Offset: 0x0020166C
		// (set) Token: 0x06002AFA RID: 11002 RVA: 0x0000AB3F File Offset: 0x00008D3F
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

		// Token: 0x17000D17 RID: 3351
		// (get) Token: 0x06002AFB RID: 11003 RVA: 0x00203484 File Offset: 0x00201684
		// (set) Token: 0x06002AFC RID: 11004 RVA: 0x0020349C File Offset: 0x0020169C
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

		// Token: 0x06002AFD RID: 11005 RVA: 0x002034FC File Offset: 0x002016FC
		private void LoadData()
		{
			DataTable dataSource = Public_Function.FillData("SELECT     DaryaftPardakht.ID, DaryaftPardakht.dpType_ID, DaryaftPardakht.Tarikh, DaryaftPardakht.SanadBed_ID, DaryaftPardakht.SanadBes_ID, DaryaftPardakht.Moshtari_ID,     DaryaftPardakht.Mablagh, DaryaftPardakht.Tozih, DaryaftPardakht.Tarikh_Fa, DaryaftPardakht.Sh_Check, DaryaftPardakht.CheckBank_ID,     DaryaftPardakht.Check_Shobe, DaryaftPardakht.Check_Sarresid, DaryaftPardakht.Check_Sarresid_Fa, DaryaftPardakht.Check_Status,     DaryaftPardakht.Check_ShomareHesab, Moshtari.Name + ' ' + Moshtari.Family AS Moshtari_Name, Bank.Name AS Bank_Name     FROM         DaryaftPardakht INNER JOIN     Moshtari ON DaryaftPardakht.Moshtari_ID = Moshtari.ID INNER JOIN     Bank ON DaryaftPardakht.CheckBank_ID = Bank.ID   WHERE     (DaryaftPardakht.dpType_ID = 22) AND (DaryaftPardakht.Check_Status = 4) order by DaryaftPardakht.Check_Sarresid");
			this.GridEX1.DataSource = dataSource;
			Public_Function.AddFilterColumn(this.GridEX1);
		}

		// Token: 0x06002AFE RID: 11006 RVA: 0x00203530 File Offset: 0x00201730
		private void Frm_rpt_checkbargasht_KeyDown(object sender, KeyEventArgs e)
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

		// Token: 0x06002AFF RID: 11007 RVA: 0x0000AB49 File Offset: 0x00008D49
		private void Frm_rpt_checkDaryafti_Load(object sender, EventArgs e)
		{
			this.LoadData();
		}

		// Token: 0x06002B00 RID: 11008 RVA: 0x0000AB54 File Offset: 0x00008D54
		private void Timer1_Tick(object sender, EventArgs e)
		{
			this.Timer1.Enabled = false;
			this.GridEX1.MoveLast();
			this.EditBox1.Focus();
		}

		// Token: 0x06002B01 RID: 11009 RVA: 0x00128E48 File Offset: 0x00127048
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

		// Token: 0x06002B02 RID: 11010 RVA: 0x00203570 File Offset: 0x00201770
		private void ButtonItem1_Click(object sender, EventArgs e)
		{
			StiReport stiReport = new StiReport();
			stiReport.Load(Application.StartupPath + "\\reports\\checkbargasht.mrt");
			DataTable tabla = (DataTable)this.GridEX1.DataSource;
			DataTable dataTable = Public_Function.CopyTableView(tabla, "data");
			stiReport.RegData(dataTable);
			this.SetHeader(stiReport);
			Public_Function.AddTazminText(stiReport, true, false);
			Public_Function.setReportFont(stiReport, "Text13,Text16,Text17,Text18,Text12");
			Public_Function.SetReport_MarginTop(stiReport);
			stiReport.Print(false);
		}

		// Token: 0x06002B03 RID: 11011 RVA: 0x0000AB7D File Offset: 0x00008D7D
		private void EditBox1_TextChanged(object sender, EventArgs e)
		{
			Public_Function.FilterGrid(this.GridEX1, this.EditBox1.Text);
		}

		// Token: 0x040010B8 RID: 4280
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x040010BA RID: 4282
		[AccessedThroughProperty("GridEX1")]
		private GridEX _GridEX1;

		// Token: 0x040010BB RID: 4283
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x040010BC RID: 4284
		[AccessedThroughProperty("Bar1")]
		private Bar _Bar1;

		// Token: 0x040010BD RID: 4285
		[AccessedThroughProperty("ButtonItem1")]
		private ButtonItem _ButtonItem1;

		// Token: 0x040010BE RID: 4286
		[AccessedThroughProperty("EditBox1")]
		private EditBox _EditBox1;

		// Token: 0x040010BF RID: 4287
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x040010C0 RID: 4288
		[AccessedThroughProperty("Timer1")]
		private Timer _Timer1;
	}
}
