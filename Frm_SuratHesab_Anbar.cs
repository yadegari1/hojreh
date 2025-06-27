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
using Janus.Windows.UI;
using Janus.Windows.UI.Dock;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Stimulsoft.Report;
using Stimulsoft.Report.Components;

namespace FruitBox
{
	// Token: 0x0200013C RID: 316
	[DesignerGenerated]
	public partial class Frm_SuratHesab_Anbar : Form
	{
		// Token: 0x06002DEC RID: 11756 RVA: 0x0021F88C File Offset: 0x0021DA8C
		[DebuggerNonUserCode]
		public Frm_SuratHesab_Anbar()
		{
			base.KeyDown += new KeyEventHandler(this.Frm_SuratHesab_Anbar_KeyDown);
			base.Load += new EventHandler(this.Frm_SuratHesab_Moshtari_Load);
			base.FormClosing += new FormClosingEventHandler(this.Frm_SuratHesab_Anbar_FormClosing);
			Frm_SuratHesab_Anbar.__ENCAddToList(this);
			this.InitializeComponent();
		}

		// Token: 0x06002DED RID: 11757 RVA: 0x0021F8EC File Offset: 0x0021DAEC
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_SuratHesab_Anbar.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_SuratHesab_Anbar.__ENCList.Count == Frm_SuratHesab_Anbar.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_SuratHesab_Anbar.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_SuratHesab_Anbar.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_SuratHesab_Anbar.__ENCList[num] = Frm_SuratHesab_Anbar.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_SuratHesab_Anbar.__ENCList.RemoveRange(num, Frm_SuratHesab_Anbar.__ENCList.Count - num);
						Frm_SuratHesab_Anbar.__ENCList.Capacity = Frm_SuratHesab_Anbar.__ENCList.Count;
					}
					Frm_SuratHesab_Anbar.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000DF5 RID: 3573
		// (get) Token: 0x06002DF0 RID: 11760 RVA: 0x00220410 File Offset: 0x0021E610
		// (set) Token: 0x06002DF1 RID: 11761 RVA: 0x0000B9F1 File Offset: 0x00009BF1
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

		// Token: 0x17000DF6 RID: 3574
		// (get) Token: 0x06002DF2 RID: 11762 RVA: 0x00220428 File Offset: 0x0021E628
		// (set) Token: 0x06002DF3 RID: 11763 RVA: 0x0000B9FB File Offset: 0x00009BFB
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

		// Token: 0x17000DF7 RID: 3575
		// (get) Token: 0x06002DF4 RID: 11764 RVA: 0x00220440 File Offset: 0x0021E640
		// (set) Token: 0x06002DF5 RID: 11765 RVA: 0x0000BA05 File Offset: 0x00009C05
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

		// Token: 0x17000DF8 RID: 3576
		// (get) Token: 0x06002DF6 RID: 11766 RVA: 0x00220458 File Offset: 0x0021E658
		// (set) Token: 0x06002DF7 RID: 11767 RVA: 0x00220470 File Offset: 0x0021E670
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

		// Token: 0x17000DF9 RID: 3577
		// (get) Token: 0x06002DF8 RID: 11768 RVA: 0x002204D0 File Offset: 0x0021E6D0
		// (set) Token: 0x06002DF9 RID: 11769 RVA: 0x002204E8 File Offset: 0x0021E6E8
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

		// Token: 0x17000DFA RID: 3578
		// (get) Token: 0x06002DFA RID: 11770 RVA: 0x00220548 File Offset: 0x0021E748
		// (set) Token: 0x06002DFB RID: 11771 RVA: 0x0000BA0F File Offset: 0x00009C0F
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

		// Token: 0x17000DFB RID: 3579
		// (get) Token: 0x06002DFC RID: 11772 RVA: 0x00220560 File Offset: 0x0021E760
		// (set) Token: 0x06002DFD RID: 11773 RVA: 0x00220578 File Offset: 0x0021E778
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

		// Token: 0x17000DFC RID: 3580
		// (get) Token: 0x06002DFE RID: 11774 RVA: 0x002205D8 File Offset: 0x0021E7D8
		// (set) Token: 0x06002DFF RID: 11775 RVA: 0x002205F0 File Offset: 0x0021E7F0
		internal virtual UIRadioButton txt_2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txt_2_CheckedChanged);
				bool flag = this._txt_2 != null;
				if (flag)
				{
					this._txt_2.CheckedChanged -= value2;
				}
				this._txt_2 = value;
				flag = (this._txt_2 != null);
				if (flag)
				{
					this._txt_2.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x17000DFD RID: 3581
		// (get) Token: 0x06002E00 RID: 11776 RVA: 0x00220650 File Offset: 0x0021E850
		// (set) Token: 0x06002E01 RID: 11777 RVA: 0x00220668 File Offset: 0x0021E868
		internal virtual UIRadioButton txt_1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txt_1_CheckedChanged);
				bool flag = this._txt_1 != null;
				if (flag)
				{
					this._txt_1.CheckedChanged -= value2;
				}
				this._txt_1 = value;
				flag = (this._txt_1 != null);
				if (flag)
				{
					this._txt_1.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x17000DFE RID: 3582
		// (get) Token: 0x06002E02 RID: 11778 RVA: 0x002206C8 File Offset: 0x0021E8C8
		// (set) Token: 0x06002E03 RID: 11779 RVA: 0x0000BA19 File Offset: 0x00009C19
		internal virtual Label Label20
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label20;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label20 = value;
			}
		}

		// Token: 0x17000DFF RID: 3583
		// (get) Token: 0x06002E04 RID: 11780 RVA: 0x002206E0 File Offset: 0x0021E8E0
		// (set) Token: 0x06002E05 RID: 11781 RVA: 0x0000BA23 File Offset: 0x00009C23
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

		// Token: 0x17000E00 RID: 3584
		// (get) Token: 0x06002E06 RID: 11782 RVA: 0x002206F8 File Offset: 0x0021E8F8
		// (set) Token: 0x06002E07 RID: 11783 RVA: 0x0000BA2D File Offset: 0x00009C2D
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

		// Token: 0x06002E08 RID: 11784 RVA: 0x00220710 File Offset: 0x0021E910
		private void LoadData(int type)
		{
			bool flag = this.GridEX1.RootTable == null;
			if (!flag)
			{
				flag = (type == 1);
				DataTable dataSource;
				if (flag)
				{
					dataSource = Public_Function.FillData("SELECT  Mojodi.Kala_ID,cast(mojodi.avg_kharid as bigint) AS avg_kharid, Mojodi.tedad, Mojodi.vazn_kol, isnull( Furush.tedad_furush,0) as tedad_furush  ,isnull( Furush.vazn_furush,0) as vazn_furush, Kala.Name  ,tedad - isnull(tedad_furush,0) as tedad_mande  ,vazn_kol - isnull(vazn_furush,0) as vazn_mande,isnull(cast(furush.avg_furush as bigint),0) as avg_furush  FROM    (SELECT  Kharid_Detail.Kala_ID, SUM(Kharid_Detail.Tedad) AS tedad, SUM(Kharid_Detail.Vazn_Ba_Zarf) AS vazn_kol,avg(Kharid_Detail.fee) AS avg_kharid  FROM    Kharid INNER JOIN  Kharid_Detail ON Kharid.ID = Kharid_Detail.Kharid_ID  WHERE (Kharid.Daramad_Sanad_ID Is NULL)  GROUP BY Kharid_Detail.Kala_ID) AS Mojodi INNER JOIN  Kala ON Mojodi.Kala_ID = Kala.ID LEFT OUTER JOIN  (SELECT  Kharid_Furush.Kala_ID,isnull( SUM(Kharid_Furush.Tedad),0) AS tedad_furush,isnull( SUM(Kharid_Furush.Vazn_Ba_Zarf),0) AS vazn_furush,avg(Kharid_Furush.fee) as avg_furush  FROM     Kharid AS Kharid_1 INNER JOIN  Kharid_Furush ON Kharid_1.ID = Kharid_Furush.Kharid_ID  WHERE (Kharid_1.Daramad_Sanad_ID Is NULL)  GROUP BY Kharid_Furush.Kala_ID) AS Furush ON Mojodi.Kala_ID = Furush.Kala_ID");
				}
				else
				{
					dataSource = Public_Function.FillData("select Moshtari.Name +' '+ Family as moshtari_name,kala.Name   ,kharid.moshtari_id,kharid.Kala_ID,tedad,vazn_kol,avg_kharid,isnull(tedad_furush,0) as tedad_furush,isnull(vazn_furush,0) as vazn_furush,avg_furush  ,tedad-isnull(tedad_furush,0) as tedad_mande,vazn_kol-isnull( vazn_furush,0) as vazn_mande  from (  select Kharid_Detail. moshtari_id, Kala_ID,SUM(Kharid_Detail.Tedad) AS tedad, SUM(Kharid_Detail.Vazn_Ba_Zarf) AS vazn_kol,round(avg(Kharid_Detail.fee),0) AS avg_kharid   from Kharid_Detail  inner join Kharid  on Kharid.ID=Kharid_Detail.Kharid_ID  WHERE (Kharid.Daramad_Sanad_ID Is NULL)   group by Kharid_Detail.moshtari_id,Kala_ID  ) as kharid  left outer join  (   SELECT  Kharid_Detail.Moshtari_ID, Kharid_Furush.Kala_ID,isnull( SUM(Kharid_Furush.Tedad),0) AS tedad_furush,isnull( SUM(Kharid_Furush.Vazn_Ba_Zarf),0) AS vazn_furush  ,round(avg(Kharid_Furush.fee),0) as avg_furush   FROM     Kharid AS Kharid_1  INNER JOIN  Kharid_Furush ON Kharid_1.ID = Kharid_Furush.Kharid_ID  inner join   Kharid_Detail  on Kharid_Detail.Kharid_ID=Kharid_1.ID   and Kharid_Detail.Kala_ID=Kharid_Furush.Kala_ID  WHERE (Kharid_1.Daramad_Sanad_ID Is NULL)    GROUP BY Kharid_Detail.Moshtari_ID, Kharid_Furush.Kala_ID  ) as furush  on kharid.moshtari_id=furush.moshtari_id  and kharid.Kala_ID=furush.Kala_ID  inner join Moshtari  on kharid.moshtari_id=Moshtari.ID  inner join Kala  on Kala.ID=kharid.Kala_ID");
				}
				this.GridEX1.DataSource = dataSource;
				flag = this.txt_1.Checked;
				if (flag)
				{
					this.GridEX1.RootTable.Columns["moshtari_name"].Visible = false;
				}
				else
				{
					this.GridEX1.RootTable.Columns["moshtari_name"].Visible = true;
				}
				Public_Function.AddFilterColumn(this.GridEX1);
				this.EditBox1.Focus();
			}
		}

		// Token: 0x06002E09 RID: 11785 RVA: 0x002207D4 File Offset: 0x0021E9D4
		private void Frm_SuratHesab_Anbar_FormClosing(object sender, FormClosingEventArgs e)
		{
			setting setting = new setting();
			bool @checked = this.txt_1.Checked;
			if (@checked)
			{
				setting.Update("noe_mojodi_anbar", "1");
				Public_Function.dict["noe_mojodi_anbar"] = "1";
			}
			else
			{
				setting.Update("noe_mojodi_anbar", "2");
				Public_Function.dict["noe_mojodi_anbar"] = "2";
			}
		}

		// Token: 0x06002E0A RID: 11786 RVA: 0x0006620C File Offset: 0x0006440C
		private void Frm_SuratHesab_Anbar_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Escape;
			if (flag)
			{
				this.Close();
			}
		}

		// Token: 0x06002E0B RID: 11787 RVA: 0x00220848 File Offset: 0x0021EA48
		private void Frm_SuratHesab_Moshtari_Load(object sender, EventArgs e)
		{
			bool flag = Conversions.ToDouble(Public_Function.dict["noe_mojodi_anbar"]) == 1.0;
			if (flag)
			{
				this.txt_1.Checked = true;
			}
			else
			{
				this.txt_2.Checked = true;
			}
			this.LoadData(Conversions.ToInteger(Public_Function.dict["noe_mojodi_anbar"]));
		}

		// Token: 0x06002E0C RID: 11788 RVA: 0x00128E48 File Offset: 0x00127048
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

		// Token: 0x06002E0D RID: 11789 RVA: 0x002208B4 File Offset: 0x0021EAB4
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
			Public_Function.AddTazminText(stiReport, true, false);
			Public_Function.setReportFont(stiReport, "Text10,Text12,Text8");
			Public_Function.SetReport_MarginTop(stiReport);
			stiReport.Print(false);
		}

		// Token: 0x06002E0E RID: 11790 RVA: 0x0000BA37 File Offset: 0x00009C37
		private void EditBox1_TextChanged(object sender, EventArgs e)
		{
			Public_Function.FilterGrid(this.GridEX1, this.EditBox1.Text);
		}

		// Token: 0x06002E0F RID: 11791 RVA: 0x0000BA52 File Offset: 0x00009C52
		private void Timer1_Tick(object sender, EventArgs e)
		{
			this.Timer1.Enabled = false;
			this.GridEX1.MoveLast();
		}

		// Token: 0x06002E10 RID: 11792 RVA: 0x00220974 File Offset: 0x0021EB74
		private void txt_2_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.txt_2.Checked;
			if (@checked)
			{
				this.LoadData(2);
			}
		}

		// Token: 0x06002E11 RID: 11793 RVA: 0x0022099C File Offset: 0x0021EB9C
		private void txt_1_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.txt_1.Checked;
			if (@checked)
			{
				this.LoadData(1);
			}
		}

		// Token: 0x040011D2 RID: 4562
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x040011D4 RID: 4564
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x040011D5 RID: 4565
		[AccessedThroughProperty("GridEX1")]
		private DataEntryGrid _GridEX1;

		// Token: 0x040011D6 RID: 4566
		[AccessedThroughProperty("Bar1")]
		private Bar _Bar1;

		// Token: 0x040011D7 RID: 4567
		[AccessedThroughProperty("ButtonItem1")]
		private ButtonItem _ButtonItem1;

		// Token: 0x040011D8 RID: 4568
		[AccessedThroughProperty("EditBox1")]
		private EditBox _EditBox1;

		// Token: 0x040011D9 RID: 4569
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x040011DA RID: 4570
		[AccessedThroughProperty("Timer1")]
		private Timer _Timer1;

		// Token: 0x040011DB RID: 4571
		[AccessedThroughProperty("txt_2")]
		private UIRadioButton _txt_2;

		// Token: 0x040011DC RID: 4572
		[AccessedThroughProperty("txt_1")]
		private UIRadioButton _txt_1;

		// Token: 0x040011DD RID: 4573
		[AccessedThroughProperty("Label20")]
		private Label _Label20;

		// Token: 0x040011DE RID: 4574
		[CompilerGenerated]
		private int? _BankHesab_ID;

		// Token: 0x040011DF RID: 4575
		[CompilerGenerated]
		private string _BankHesab_Name;
	}
}
