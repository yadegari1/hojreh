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
	// Token: 0x0200011F RID: 287
	[DesignerGenerated]
	public partial class Frm_Karmozd : Form
	{
		// Token: 0x060029EC RID: 10732 RVA: 0x0000A65C File Offset: 0x0000885C
		[DebuggerNonUserCode]
		public Frm_Karmozd()
		{
			base.KeyDown += new KeyEventHandler(this.Frm_SuratHesab_Daramad_KeyDown);
			base.Load += new EventHandler(this.Frm_SuratHesab_Moshtari_Load);
			Frm_Karmozd.__ENCAddToList(this);
			this.InitializeComponent();
		}

		// Token: 0x060029ED RID: 10733 RVA: 0x001F95EC File Offset: 0x001F77EC
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_Karmozd.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_Karmozd.__ENCList.Count == Frm_Karmozd.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_Karmozd.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_Karmozd.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_Karmozd.__ENCList[num] = Frm_Karmozd.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_Karmozd.__ENCList.RemoveRange(num, Frm_Karmozd.__ENCList.Count - num);
						Frm_Karmozd.__ENCList.Capacity = Frm_Karmozd.__ENCList.Count;
					}
					Frm_Karmozd.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000CC8 RID: 3272
		// (get) Token: 0x060029F0 RID: 10736 RVA: 0x001FA314 File Offset: 0x001F8514
		// (set) Token: 0x060029F1 RID: 10737 RVA: 0x0000A69C File Offset: 0x0000889C
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

		// Token: 0x17000CC9 RID: 3273
		// (get) Token: 0x060029F2 RID: 10738 RVA: 0x001FA32C File Offset: 0x001F852C
		// (set) Token: 0x060029F3 RID: 10739 RVA: 0x0000A6A6 File Offset: 0x000088A6
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

		// Token: 0x17000CCA RID: 3274
		// (get) Token: 0x060029F4 RID: 10740 RVA: 0x001FA344 File Offset: 0x001F8544
		// (set) Token: 0x060029F5 RID: 10741 RVA: 0x0000A6B0 File Offset: 0x000088B0
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

		// Token: 0x17000CCB RID: 3275
		// (get) Token: 0x060029F6 RID: 10742 RVA: 0x001FA35C File Offset: 0x001F855C
		// (set) Token: 0x060029F7 RID: 10743 RVA: 0x001FA374 File Offset: 0x001F8574
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

		// Token: 0x17000CCC RID: 3276
		// (get) Token: 0x060029F8 RID: 10744 RVA: 0x001FA3D4 File Offset: 0x001F85D4
		// (set) Token: 0x060029F9 RID: 10745 RVA: 0x001FA3EC File Offset: 0x001F85EC
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

		// Token: 0x17000CCD RID: 3277
		// (get) Token: 0x060029FA RID: 10746 RVA: 0x001FA44C File Offset: 0x001F864C
		// (set) Token: 0x060029FB RID: 10747 RVA: 0x0000A6BA File Offset: 0x000088BA
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

		// Token: 0x17000CCE RID: 3278
		// (get) Token: 0x060029FC RID: 10748 RVA: 0x001FA464 File Offset: 0x001F8664
		// (set) Token: 0x060029FD RID: 10749 RVA: 0x001FA47C File Offset: 0x001F867C
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

		// Token: 0x17000CCF RID: 3279
		// (get) Token: 0x060029FE RID: 10750 RVA: 0x001FA4DC File Offset: 0x001F86DC
		// (set) Token: 0x060029FF RID: 10751 RVA: 0x0000A6C4 File Offset: 0x000088C4
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

		// Token: 0x17000CD0 RID: 3280
		// (get) Token: 0x06002A00 RID: 10752 RVA: 0x001FA4F4 File Offset: 0x001F86F4
		// (set) Token: 0x06002A01 RID: 10753 RVA: 0x001FA50C File Offset: 0x001F870C
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

		// Token: 0x17000CD1 RID: 3281
		// (get) Token: 0x06002A02 RID: 10754 RVA: 0x001FA56C File Offset: 0x001F876C
		// (set) Token: 0x06002A03 RID: 10755 RVA: 0x001FA584 File Offset: 0x001F8784
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

		// Token: 0x17000CD2 RID: 3282
		// (get) Token: 0x06002A04 RID: 10756 RVA: 0x001FA5E4 File Offset: 0x001F87E4
		// (set) Token: 0x06002A05 RID: 10757 RVA: 0x0000A6CE File Offset: 0x000088CE
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

		// Token: 0x06002A06 RID: 10758 RVA: 0x001FA5FC File Offset: 0x001F87FC
		private void LoadData()
		{
			string text = string.Empty;
			string empty = string.Empty;
			bool @checked = this.UiCheckBox2.Checked;
			if (@checked)
			{
				text = " where Sanad.tarikh between " + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_az_tarikh.Text)) + " AND " + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_ta_tarikh.Text));
			}
			DataTable dataSource = Public_Function.FillData(string.Concat(new string[]
			{
				"SELECT    sum (bed) as bed,sum( bes) as bes,sum( Mablagh) as Mablagh,max( Moshtari_Name) as moshtari_name  FROM         (SELECT     SUM(Sanad.Bed) AS bed, SUM(Sanad.Bes) AS bes, SUM(Sanad.Bes) - SUM(Sanad.Bed) AS Mablagh, MAX(Moshtari.Name + ' ' + Moshtari.Family)                AS Moshtari_Name     FROM         Sanad INNER JOIN                Code_Hesab ON Sanad.CodeHesab_ID = Code_Hesab.ID INNER JOIN                Safi_Furush ON Sanad.ID = Safi_Furush.Karmozd_Sanad_ID INNER JOIN                Furush_Hag ON Safi_Furush.Furush_Hag_ID = Furush_Hag.ID INNER JOIN                Moshtari ON Furush_Hag.Moshtari_ID = Moshtari.ID  ",
				text,
				"  GROUP BY Furush_Hag.Moshtari_ID  UNION ALL  SELECT     SUM(Sanad.Bed) AS Bed, SUM(Sanad.Bes) AS bes, SUM(Sanad.Bes) - SUM(Sanad.Bed) AS Mablagh, MAX(Moshtari.Name + ' ' + Moshtari.Family)                AS moshtari_name  FROM         Kharid INNER JOIN                Moshtari ON Kharid.Moshtari_ID = Moshtari.ID INNER JOIN                Sanad ON Kharid.Daramad_Sanad_ID = Sanad.ID  ",
				text,
				"  GROUP BY Kharid.Moshtari_ID) AS t  group by moshtari_name  order by mablagh desc"
			}));
			this.GridEX1.DataSource = dataSource;
			Public_Function.AddFilterColumn(this.GridEX1);
			this.GridEX1.MoveFirst();
			this.EditBox1.Focus();
		}

		// Token: 0x06002A07 RID: 10759 RVA: 0x001FA6CC File Offset: 0x001F88CC
		private void UiCheckBox2_CheckedChanged(object sender, EventArgs e)
		{
			this.txt_az_tarikh.Enabled = this.UiCheckBox2.Checked;
			this.txt_ta_tarikh.Enabled = this.UiCheckBox2.Checked;
			bool @checked = this.UiCheckBox2.Checked;
			if (@checked)
			{
				this.txt_az_tarikh.FocusDatePart = 1;
				this.txt_az_tarikh.Focus();
				this.txt_az_tarikh.Focus();
			}
			else
			{
				this.LoadData();
			}
		}

		// Token: 0x06002A08 RID: 10760 RVA: 0x001FA748 File Offset: 0x001F8948
		private void txt_az_tarikh_KeyDown_1(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				this.LoadData();
			}
		}

		// Token: 0x06002A09 RID: 10761 RVA: 0x001FA770 File Offset: 0x001F8970
		private void Frm_SuratHesab_Daramad_KeyDown(object sender, KeyEventArgs e)
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

		// Token: 0x06002A0A RID: 10762 RVA: 0x0000A6D8 File Offset: 0x000088D8
		private void Frm_SuratHesab_Moshtari_Load(object sender, EventArgs e)
		{
			this.LoadData();
			this.txt_az_tarikh.SetNew();
			this.txt_ta_tarikh.SetNew();
		}

		// Token: 0x06002A0B RID: 10763 RVA: 0x001FA7B0 File Offset: 0x001F89B0
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
			stiText = (StiText)rpt.GetComponentByName("txt_tarikh");
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

		// Token: 0x06002A0C RID: 10764 RVA: 0x001FA8E0 File Offset: 0x001F8AE0
		private void ButtonItem1_Click(object sender, EventArgs e)
		{
			StiReport stiReport = new StiReport();
			stiReport.Load(Application.StartupPath + "\\reports\\karmozd.mrt");
			DataTable dataTable = (DataTable)this.GridEX1.DataSource;
			DataTable dataTable2 = dataTable.Copy();
			dataTable2.TableName = "data";
			dataTable2.DefaultView.RowFilter = dataTable.DefaultView.RowFilter;
			stiReport.RegData(dataTable2.DefaultView);
			this.SetHeader(stiReport);
			StiText stiText = new StiText();
			stiText = (StiText)stiReport.GetComponentByName("Text2");
			string text = "گزارش کارمزد صاحب باران ";
			bool @checked = this.UiCheckBox2.Checked;
			if (@checked)
			{
				text = string.Concat(new string[]
				{
					text,
					" از تاریخ ",
					this.txt_az_tarikh.Text,
					" تا تاریخ ",
					this.txt_ta_tarikh.Text
				});
			}
			stiText.Text.Value = text;
			Public_Function.AddTazminText(stiReport, false, false);
			stiReport.Print(false);
		}

		// Token: 0x06002A0D RID: 10765 RVA: 0x0000A6FB File Offset: 0x000088FB
		private void EditBox1_TextChanged(object sender, EventArgs e)
		{
			Public_Function.FilterGrid(this.GridEX1, this.EditBox1.Text);
		}

		// Token: 0x0400105D RID: 4189
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x0400105F RID: 4191
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x04001060 RID: 4192
		[AccessedThroughProperty("UiGroupBox2")]
		private UIGroupBox _UiGroupBox2;

		// Token: 0x04001061 RID: 4193
		[AccessedThroughProperty("GridEX1")]
		private DataEntryGrid _GridEX1;

		// Token: 0x04001062 RID: 4194
		[AccessedThroughProperty("txt_ta_tarikh")]
		private DateBox2 _txt_ta_tarikh;

		// Token: 0x04001063 RID: 4195
		[AccessedThroughProperty("txt_az_tarikh")]
		private DateBox2 _txt_az_tarikh;

		// Token: 0x04001064 RID: 4196
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x04001065 RID: 4197
		[AccessedThroughProperty("UiCheckBox2")]
		private UICheckBox _UiCheckBox2;

		// Token: 0x04001066 RID: 4198
		[AccessedThroughProperty("Bar1")]
		private Bar _Bar1;

		// Token: 0x04001067 RID: 4199
		[AccessedThroughProperty("ButtonItem1")]
		private ButtonItem _ButtonItem1;

		// Token: 0x04001068 RID: 4200
		[AccessedThroughProperty("EditBox1")]
		private EditBox _EditBox1;

		// Token: 0x04001069 RID: 4201
		[AccessedThroughProperty("Label2")]
		private Label _Label2;
	}
}
