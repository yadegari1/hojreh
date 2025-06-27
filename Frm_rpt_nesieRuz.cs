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
	// Token: 0x02000134 RID: 308
	[DesignerGenerated]
	public partial class Frm_rpt_nesieRuz : Form
	{
		// Token: 0x06002C60 RID: 11360 RVA: 0x0000B2DF File Offset: 0x000094DF
		[DebuggerNonUserCode]
		public Frm_rpt_nesieRuz()
		{
			base.Load += new EventHandler(this.Frm_rpt_checkDaryafti_Load);
			base.KeyDown += new KeyEventHandler(this.Frm_rpt_checkvusul_KeyDown);
			Frm_rpt_nesieRuz.__ENCAddToList(this);
			this.InitializeComponent();
		}

		// Token: 0x06002C61 RID: 11361 RVA: 0x0020F068 File Offset: 0x0020D268
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_rpt_nesieRuz.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_rpt_nesieRuz.__ENCList.Count == Frm_rpt_nesieRuz.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_rpt_nesieRuz.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_rpt_nesieRuz.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_rpt_nesieRuz.__ENCList[num] = Frm_rpt_nesieRuz.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_rpt_nesieRuz.__ENCList.RemoveRange(num, Frm_rpt_nesieRuz.__ENCList.Count - num);
						Frm_rpt_nesieRuz.__ENCList.Capacity = Frm_rpt_nesieRuz.__ENCList.Count;
					}
					Frm_rpt_nesieRuz.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000D7E RID: 3454
		// (get) Token: 0x06002C64 RID: 11364 RVA: 0x0020FAA4 File Offset: 0x0020DCA4
		// (set) Token: 0x06002C65 RID: 11365 RVA: 0x0000B31F File Offset: 0x0000951F
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

		// Token: 0x17000D7F RID: 3455
		// (get) Token: 0x06002C66 RID: 11366 RVA: 0x0020FABC File Offset: 0x0020DCBC
		// (set) Token: 0x06002C67 RID: 11367 RVA: 0x0000B329 File Offset: 0x00009529
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

		// Token: 0x17000D80 RID: 3456
		// (get) Token: 0x06002C68 RID: 11368 RVA: 0x0020FAD4 File Offset: 0x0020DCD4
		// (set) Token: 0x06002C69 RID: 11369 RVA: 0x0000B333 File Offset: 0x00009533
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

		// Token: 0x17000D81 RID: 3457
		// (get) Token: 0x06002C6A RID: 11370 RVA: 0x0020FAEC File Offset: 0x0020DCEC
		// (set) Token: 0x06002C6B RID: 11371 RVA: 0x0020FB04 File Offset: 0x0020DD04
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

		// Token: 0x17000D82 RID: 3458
		// (get) Token: 0x06002C6C RID: 11372 RVA: 0x0020FB64 File Offset: 0x0020DD64
		// (set) Token: 0x06002C6D RID: 11373 RVA: 0x0020FB7C File Offset: 0x0020DD7C
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

		// Token: 0x17000D83 RID: 3459
		// (get) Token: 0x06002C6E RID: 11374 RVA: 0x0020FBDC File Offset: 0x0020DDDC
		// (set) Token: 0x06002C6F RID: 11375 RVA: 0x0000B33D File Offset: 0x0000953D
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

		// Token: 0x17000D84 RID: 3460
		// (get) Token: 0x06002C70 RID: 11376 RVA: 0x0020FBF4 File Offset: 0x0020DDF4
		// (set) Token: 0x06002C71 RID: 11377 RVA: 0x0020FC0C File Offset: 0x0020DE0C
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

		// Token: 0x17000D85 RID: 3461
		// (get) Token: 0x06002C72 RID: 11378 RVA: 0x0020FC6C File Offset: 0x0020DE6C
		// (set) Token: 0x06002C73 RID: 11379 RVA: 0x0000B347 File Offset: 0x00009547
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

		// Token: 0x17000D86 RID: 3462
		// (get) Token: 0x06002C74 RID: 11380 RVA: 0x0020FC84 File Offset: 0x0020DE84
		// (set) Token: 0x06002C75 RID: 11381 RVA: 0x0020FC9C File Offset: 0x0020DE9C
		internal virtual DateBox2 txt_tarikh
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_tarikh;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txt_tarikh_Validated);
				KeyEventHandler value3 = new KeyEventHandler(this.txt_tarikh_KeyDown);
				bool flag = this._txt_tarikh != null;
				if (flag)
				{
					this._txt_tarikh.Validated -= value2;
					this._txt_tarikh.KeyDown -= value3;
				}
				this._txt_tarikh = value;
				flag = (this._txt_tarikh != null);
				if (flag)
				{
					this._txt_tarikh.Validated += value2;
					this._txt_tarikh.KeyDown += value3;
				}
			}
		}

		// Token: 0x06002C76 RID: 11382 RVA: 0x0020FD24 File Offset: 0x0020DF24
		private void LoadData()
		{
			DataTable dataTable = Public_Function.FillData(string.Concat(new string[]
			{
				"SELECT     Furush_Hag_Detail.Moshtari_ID, Moshtari.Name+' '+ Moshtari.Family as moshtari_name, Kala.Name AS Kala_Name, Furush_Hag_Detail.Tedad, Furush_Hag_Detail.Vazn_Kol,  Furush_Hag_Detail.Fee, Furush_Hag_Detail.Jam_Kol,cast(0 as bigint) as daryafti,cast(0 as bigint) as mande  FROM         Furush_Hag_Detail INNER JOIN  Moshtari ON Furush_Hag_Detail.Moshtari_ID = Moshtari.ID INNER JOIN  Kala ON Furush_Hag_Detail.Kala_ID = Kala.ID  where moshtari_id>0 and tarikh=",
				Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text)),
				" union all SELECT     Kharid_Furush.Moshtari_ID, Moshtari.Name+' '+ Moshtari.Family as moshtari_name, Kala.Name AS kala_Name, Kharid_Furush.Tedad, Kharid_Furush.Vazn_Kol, Kharid_Furush.Fee,  Kharid_Furush.Jam_Kol,cast(0 as bigint) as daryafti,cast(0 as bigint) as mande   FROM         Kharid_Furush INNER JOIN  Moshtari ON Kharid_Furush.Moshtari_ID = Moshtari.ID INNER JOIN  Kala ON Kharid_Furush.Kala_ID = Kala.ID  where moshtari_id>0 and tarikh=",
				Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text)),
				" order by moshtari_id"
			}));
			this.GridEX1.DataSource = dataTable;
			DataTable dataTable2 = Public_Function.FillData("select sum(mablagh) as mablagh,moshtari_id from daryaftpardakht where dptype_id in (1,2) and tarikh=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text)) + " group by moshtari_id ");
			try
			{
				IEnumerator enumerator = dataTable2.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					DataRow[] array = dataTable.Select(Conversions.ToString(Operators.ConcatenateObject("moshtari_id=", dataRow["moshtari_id"])));
					bool flag = array.Length > 0;
					if (flag)
					{
						array[0]["daryafti"] = RuntimeHelpers.GetObjectValue(dataRow["mablagh"]);
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
			DataTable dt = Public_Function.FillData(" SELECT DISTINCT Moshtari_1.CodeHesab_ID   FROM         Moshtari AS Moshtari_1 INNER JOIN      Furush_Hag_Detail ON Moshtari_1.ID = Furush_Hag_Detail.Moshtari_ID   WHERE  tarikh=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text)) + " AND   Furush_Hag_Detail.Moshtari_ID > 0");
			DataTable dataTable3 = Public_Function.FillData("SELECT     ISNULL(SUM(Sanad.Bed), 0) - ISNULL(SUM(Sanad.Bes), 0) AS mande, Moshtari.ID   FROM         Sanad INNER JOIN   Moshtari ON Sanad.CodeHesab_ID = Moshtari.CodeHesab_ID  WHERE     (Sanad.CodeHesab_ID IN   (" + Public_Function.GetID(dt, "codehesab_id", "-1") + "))   GROUP BY Sanad.CodeHesab_ID, Moshtari.ID");
			try
			{
				IEnumerator enumerator2 = dataTable3.Rows.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					DataRow dataRow2 = (DataRow)enumerator2.Current;
					DataRow[] array = dataTable.Select(Conversions.ToString(Operators.ConcatenateObject("moshtari_id=", dataRow2["id"])));
					bool flag = array.Length > 0;
					if (flag)
					{
						array[0]["mande"] = RuntimeHelpers.GetObjectValue(dataRow2["mande"]);
					}
				}
			}
			finally
			{
				IEnumerator enumerator2;
				bool flag = enumerator2 is IDisposable;
				if (flag)
				{
					(enumerator2 as IDisposable).Dispose();
				}
			}
			dt = Public_Function.FillData("SELECT DISTINCT Moshtari_1.CodeHesab_ID   FROM         Moshtari AS Moshtari_1 INNER JOIN      Kharid_Furush ON Moshtari_1.ID = Kharid_Furush.Moshtari_ID   WHERE  tarikh=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text)) + " AND   Kharid_Furush.Moshtari_ID > 0");
			dataTable3 = Public_Function.FillData("SELECT     ISNULL(SUM(Sanad.Bed), 0) - ISNULL(SUM(Sanad.Bes), 0) AS mande, Moshtari.ID   FROM         Sanad INNER JOIN   Moshtari ON Sanad.CodeHesab_ID = Moshtari.CodeHesab_ID  WHERE     (Sanad.CodeHesab_ID IN   (" + Public_Function.GetID(dt, "codehesab_id", "-1") + "))   GROUP BY Sanad.CodeHesab_ID, Moshtari.ID");
			try
			{
				IEnumerator enumerator3 = dataTable3.Rows.GetEnumerator();
				while (enumerator3.MoveNext())
				{
					DataRow dataRow3 = (DataRow)enumerator3.Current;
					DataRow[] array = dataTable.Select(Conversions.ToString(Operators.ConcatenateObject("moshtari_id=", dataRow3["id"])));
					bool flag = array.Length > 0;
					if (flag)
					{
						array[0]["mande"] = RuntimeHelpers.GetObjectValue(dataRow3["mande"]);
					}
				}
			}
			finally
			{
				IEnumerator enumerator3;
				bool flag = enumerator3 is IDisposable;
				if (flag)
				{
					(enumerator3 as IDisposable).Dispose();
				}
			}
		}

		// Token: 0x06002C77 RID: 11383 RVA: 0x00210080 File Offset: 0x0020E280
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

		// Token: 0x06002C78 RID: 11384 RVA: 0x0000B351 File Offset: 0x00009551
		private void Frm_rpt_checkDaryafti_Load(object sender, EventArgs e)
		{
			this.txt_tarikh.SetNew();
			this.LoadData();
		}

		// Token: 0x06002C79 RID: 11385 RVA: 0x002100C0 File Offset: 0x0020E2C0
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

		// Token: 0x06002C7A RID: 11386 RVA: 0x00128E48 File Offset: 0x00127048
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

		// Token: 0x06002C7B RID: 11387 RVA: 0x0021010C File Offset: 0x0020E30C
		private void ButtonItem1_Click(object sender, EventArgs e)
		{
			StiReport stiReport = new StiReport();
			stiReport.Load(Application.StartupPath + "\\reports\\nesieruz.mrt");
			DataTable tabla = (DataTable)this.GridEX1.DataSource;
			DataTable dataTable = Public_Function.CopyTableView(tabla, "data");
			stiReport.RegData(dataTable);
			this.SetHeader(stiReport);
			Public_Function.AddTazminText(stiReport, true, false);
			Public_Function.SetReport_MarginTop(stiReport);
			Public_Function.setReportFont(stiReport, "Text13,Text14,Text16,Text17,Text18,Text15");
			stiReport.Print(false);
		}

		// Token: 0x06002C7C RID: 11388 RVA: 0x0000B368 File Offset: 0x00009568
		private void EditBox1_TextChanged(object sender, EventArgs e)
		{
			Public_Function.FilterGrid(this.GridEX1, this.EditBox1.Text);
		}

		// Token: 0x06002C7D RID: 11389 RVA: 0x00210188 File Offset: 0x0020E388
		private void txt_tarikh_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				this.LoadData();
			}
		}

		// Token: 0x06002C7E RID: 11390 RVA: 0x0000B383 File Offset: 0x00009583
		private void txt_tarikh_Validated(object sender, EventArgs e)
		{
			this.LoadData();
		}

		// Token: 0x04001144 RID: 4420
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04001146 RID: 4422
		[AccessedThroughProperty("GridEX1")]
		private GridEX _GridEX1;

		// Token: 0x04001147 RID: 4423
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x04001148 RID: 4424
		[AccessedThroughProperty("Bar1")]
		private Bar _Bar1;

		// Token: 0x04001149 RID: 4425
		[AccessedThroughProperty("ButtonItem1")]
		private ButtonItem _ButtonItem1;

		// Token: 0x0400114A RID: 4426
		[AccessedThroughProperty("EditBox1")]
		private EditBox _EditBox1;

		// Token: 0x0400114B RID: 4427
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x0400114C RID: 4428
		[AccessedThroughProperty("Timer1")]
		private Timer _Timer1;

		// Token: 0x0400114D RID: 4429
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x0400114E RID: 4430
		[AccessedThroughProperty("txt_tarikh")]
		private DateBox2 _txt_tarikh;
	}
}
