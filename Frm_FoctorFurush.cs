using System;
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
	// Token: 0x0200011E RID: 286
	[DesignerGenerated]
	public partial class Frm_FoctorFurush : Form
	{
		// Token: 0x060029C7 RID: 10695 RVA: 0x0000A5B8 File Offset: 0x000087B8
		[DebuggerNonUserCode]
		public Frm_FoctorFurush()
		{
			base.KeyDown += new KeyEventHandler(this.Frm_FoctorFurush_KeyDown);
			base.Load += new EventHandler(this.Frm_FoctorFurush_Load);
			Frm_FoctorFurush.__ENCAddToList(this);
			this.InitializeComponent();
		}

		// Token: 0x060029C8 RID: 10696 RVA: 0x001F7F84 File Offset: 0x001F6184
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_FoctorFurush.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_FoctorFurush.__ENCList.Count == Frm_FoctorFurush.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_FoctorFurush.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_FoctorFurush.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_FoctorFurush.__ENCList[num] = Frm_FoctorFurush.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_FoctorFurush.__ENCList.RemoveRange(num, Frm_FoctorFurush.__ENCList.Count - num);
						Frm_FoctorFurush.__ENCList.Capacity = Frm_FoctorFurush.__ENCList.Count;
					}
					Frm_FoctorFurush.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000CBD RID: 3261
		// (get) Token: 0x060029CB RID: 10699 RVA: 0x001F8CFC File Offset: 0x001F6EFC
		// (set) Token: 0x060029CC RID: 10700 RVA: 0x0000A5F8 File Offset: 0x000087F8
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

		// Token: 0x17000CBE RID: 3262
		// (get) Token: 0x060029CD RID: 10701 RVA: 0x001F8D14 File Offset: 0x001F6F14
		// (set) Token: 0x060029CE RID: 10702 RVA: 0x001F8D2C File Offset: 0x001F6F2C
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
				KeyEventHandler value2 = new KeyEventHandler(this.txt_tarikh_KeyDown);
				bool flag = this._txt_tarikh != null;
				if (flag)
				{
					this._txt_tarikh.KeyDown -= value2;
				}
				this._txt_tarikh = value;
				flag = (this._txt_tarikh != null);
				if (flag)
				{
					this._txt_tarikh.KeyDown += value2;
				}
			}
		}

		// Token: 0x17000CBF RID: 3263
		// (get) Token: 0x060029CF RID: 10703 RVA: 0x001F8D8C File Offset: 0x001F6F8C
		// (set) Token: 0x060029D0 RID: 10704 RVA: 0x001F8DA4 File Offset: 0x001F6FA4
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
				KeyEventHandler value2 = new KeyEventHandler(this.GridEX1_KeyDown);
				bool flag = this._GridEX1 != null;
				if (flag)
				{
					this._GridEX1.KeyDown -= value2;
				}
				this._GridEX1 = value;
				flag = (this._GridEX1 != null);
				if (flag)
				{
					this._GridEX1.KeyDown += value2;
				}
			}
		}

		// Token: 0x17000CC0 RID: 3264
		// (get) Token: 0x060029D1 RID: 10705 RVA: 0x001F8E04 File Offset: 0x001F7004
		// (set) Token: 0x060029D2 RID: 10706 RVA: 0x0000A602 File Offset: 0x00008802
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

		// Token: 0x17000CC1 RID: 3265
		// (get) Token: 0x060029D3 RID: 10707 RVA: 0x001F8E1C File Offset: 0x001F701C
		// (set) Token: 0x060029D4 RID: 10708 RVA: 0x0000A60C File Offset: 0x0000880C
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

		// Token: 0x17000CC2 RID: 3266
		// (get) Token: 0x060029D5 RID: 10709 RVA: 0x001F8E34 File Offset: 0x001F7034
		// (set) Token: 0x060029D6 RID: 10710 RVA: 0x001F8E4C File Offset: 0x001F704C
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
				EventHandler value2 = new EventHandler(this.txt_moshtari_TextChanged);
				SelectItem.SelectedValueChangedEventHandler obj = new SelectItem.SelectedValueChangedEventHandler(this.txt_moshtari_SelectedValueChanged);
				bool flag = this._txt_moshtari != null;
				if (flag)
				{
					this._txt_moshtari.TextChanged -= value2;
					this._txt_moshtari.SelectedValueChanged -= obj;
				}
				this._txt_moshtari = value;
				flag = (this._txt_moshtari != null);
				if (flag)
				{
					this._txt_moshtari.TextChanged += value2;
					this._txt_moshtari.SelectedValueChanged += obj;
				}
			}
		}

		// Token: 0x17000CC3 RID: 3267
		// (get) Token: 0x060029D7 RID: 10711 RVA: 0x001F8ED4 File Offset: 0x001F70D4
		// (set) Token: 0x060029D8 RID: 10712 RVA: 0x0000A616 File Offset: 0x00008816
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

		// Token: 0x17000CC4 RID: 3268
		// (get) Token: 0x060029D9 RID: 10713 RVA: 0x001F8EEC File Offset: 0x001F70EC
		// (set) Token: 0x060029DA RID: 10714 RVA: 0x001F8F04 File Offset: 0x001F7104
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

		// Token: 0x17000CC5 RID: 3269
		// (get) Token: 0x060029DB RID: 10715 RVA: 0x001F8F64 File Offset: 0x001F7164
		// (set) Token: 0x060029DC RID: 10716 RVA: 0x001F8F7C File Offset: 0x001F717C
		internal virtual ButtonItem ButtonItem2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem2_Click);
				bool flag = this._ButtonItem2 != null;
				if (flag)
				{
					this._ButtonItem2.Click -= value2;
				}
				this._ButtonItem2 = value;
				flag = (this._ButtonItem2 != null);
				if (flag)
				{
					this._ButtonItem2.Click += value2;
				}
			}
		}

		// Token: 0x17000CC6 RID: 3270
		// (get) Token: 0x060029DD RID: 10717 RVA: 0x001F8FDC File Offset: 0x001F71DC
		// (set) Token: 0x060029DE RID: 10718 RVA: 0x0000A620 File Offset: 0x00008820
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

		// Token: 0x17000CC7 RID: 3271
		// (get) Token: 0x060029DF RID: 10719 RVA: 0x001F8FF4 File Offset: 0x001F71F4
		// (set) Token: 0x060029E0 RID: 10720 RVA: 0x0000A62A File Offset: 0x0000882A
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
				this._EditBox1 = value;
			}
		}

		// Token: 0x060029E1 RID: 10721 RVA: 0x001F900C File Offset: 0x001F720C
		private void Frm_FoctorFurush_KeyDown(object sender, KeyEventArgs e)
		{
			Keys keyCode = e.KeyCode;
			bool flag = keyCode == Keys.Escape;
			if (flag)
			{
				this.Close();
			}
			else
			{
				flag = (keyCode == Keys.F4);
				if (flag)
				{
					this.ButtonItem1_Click(null, null);
				}
				else
				{
					flag = (keyCode == Keys.F5);
					if (flag)
					{
						this.ButtonItem2_Click(null, null);
					}
				}
			}
		}

		// Token: 0x060029E2 RID: 10722 RVA: 0x001F9060 File Offset: 0x001F7260
		private void Frm_FoctorFurush_Load(object sender, EventArgs e)
		{
			this.txt_tarikh.SetNew();
			this.txt_moshtari.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
			this.txt_moshtari.Edit_Frm = MyProject.Forms.Frm_Moshtari;
			this.txt_moshtari.AddNewForm = MyProject.Forms.Frm_Moshtari;
			this.txt_moshtari.SelectCommand = string.Concat(new string[]
			{
				"SELECT DISTINCT t.Moshtari_ID as ID, Moshtari.Name + ' ' + Moshtari.Family AS Moshtari_Name,case when GrouhMoshtari_ID is null then isnull(Grouh_Moshtari2.Name,'') else isnull(Grouh_Moshtari.Name,'') end AS Shahr  FROM         (SELECT DISTINCT Moshtari_ID FROM Furush_Hag_Detail WHERE     (Tarikh_Fa = ",
				Public_Function.GetValue(this.txt_tarikh.Text),
				") AND (Moshtari_ID > 0) UNION ALL SELECT DISTINCT Moshtari_ID FROM Kharid_Furush WHERE     (Tarikh_Fa = ",
				Public_Function.GetValue(this.txt_tarikh.Text),
				") AND (Moshtari_ID > 0) UNION ALL SELECT DISTINCT Moshtari_ID FROM Furush_Sardkhane_Detail WHERE     (Tarikh_Fa = ",
				Public_Function.GetValue(this.txt_tarikh.Text),
				") AND (Moshtari_ID > 0)) AS t INNER JOIN Moshtari ON t.Moshtari_ID = Moshtari.ID LEFT OUTER JOIN Grouh_Moshtari2 ON Moshtari.GrouhMoshtari2_ID = Grouh_Moshtari2.ID LEFT OUTER JOIN Grouh_Moshtari ON Moshtari.GrouhMoshtari_ID = Grouh_Moshtari.ID"
			});
		}

		// Token: 0x060029E3 RID: 10723 RVA: 0x001F9130 File Offset: 0x001F7330
		private void LoadData()
		{
			this.txt_moshtari.SelectCommand = string.Concat(new string[]
			{
				"SELECT DISTINCT t.Moshtari_ID as id, Moshtari.Name + ' ' + Moshtari.Family AS Moshtari_Name,case when GrouhMoshtari_ID is null then isnull(Grouh_Moshtari2.Name,'') else isnull(Grouh_Moshtari.Name,'') end AS Shahr  FROM         (SELECT DISTINCT Moshtari_ID FROM Furush_Hag_Detail WHERE     (Tarikh_Fa = ",
				Public_Function.GetValue(this.txt_tarikh.Text),
				") AND (Moshtari_ID > 0) UNION ALL SELECT DISTINCT Moshtari_ID FROM Kharid_Furush WHERE     (Tarikh_Fa = ",
				Public_Function.GetValue(this.txt_tarikh.Text),
				") AND (Moshtari_ID > 0) UNION ALL SELECT DISTINCT Moshtari_ID FROM Furush_Sardkhane_Detail WHERE     (Tarikh_Fa = ",
				Public_Function.GetValue(this.txt_tarikh.Text),
				") AND (Moshtari_ID > 0)) AS t INNER JOIN Moshtari ON t.Moshtari_ID = Moshtari.ID LEFT OUTER JOIN Grouh_Moshtari2 ON Moshtari.GrouhMoshtari2_ID = Grouh_Moshtari2.ID LEFT OUTER JOIN Grouh_Moshtari ON Moshtari.GrouhMoshtari_ID = Grouh_Moshtari.ID"
			});
			bool flag = this.txt_moshtari.Value == null;
			if (!flag)
			{
				DataTable dataSource = Public_Function.FillData(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("SELECT      Furush_Hag.Num, Furush_Hag_Detail.Moshtari_ID, Kala.Name AS Kala_Name, Furush_Hag_Detail.Tedad, Furush_Hag_Detail.Vazn_Ba_Zarf,   Furush_Hag_Detail.Zarf, Furush_Hag_Detail.Vazn_Kol, Furush_Hag_Detail.Fee, Furush_Hag_Detail.Jam_Kol  FROM         Furush_Hag_Detail INNER JOIN                Kala ON Furush_Hag_Detail.Kala_ID = Kala.ID INNER JOIN                Furush_Hag ON Furush_Hag_Detail.Furush_Hug_ID = Furush_Hag.ID where Furush_Hag_Detail.Moshtari_ID=", this.txt_moshtari.Value), " and Furush_Hag_Detail.Tarikh="), Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text))), " union all "), " SELECT     Kharid.Num,  Kharid_Furush.Moshtari_ID,Kala.Name AS Kala_Name, Kharid_Furush.Tedad, Kharid_Furush.Vazn_Ba_Zarf, Kharid_Furush.Zarf, Kharid_Furush.Vazn_Kol,  "), " Kharid_Furush.Fee, Kharid_Furush.Jam_Kol "), " FROM         Kharid_Furush INNER JOIN "), "               Kharid ON Kharid_Furush.Kharid_ID = Kharid.ID INNER JOIN "), "               Kala ON Kharid_Furush.Kala_ID = Kala.ID   where Kharid_Furush.Moshtari_ID="), this.txt_moshtari.Value), " AND Kharid_Furush.Tarikh="), Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text)))));
				this.GridEX1.DataSource = dataSource;
				this.GridEX1.CheckAllRecords();
			}
		}

		// Token: 0x060029E4 RID: 10724 RVA: 0x001F92A0 File Offset: 0x001F74A0
		private void txt_moshtari_SelectedValueChanged(object sender, EventArgs e)
		{
			bool flag = Operators.ConditionalCompareObjectEqual(this.txt_moshtari.Value, -1, false);
			if (flag)
			{
				this.Label3.Visible = true;
				this.EditBox1.Visible = true;
				this.EditBox1.Focus();
			}
			else
			{
				this.Label3.Visible = false;
				this.EditBox1.Visible = false;
			}
			this.LoadData();
		}

		// Token: 0x060029E5 RID: 10725 RVA: 0x00128E48 File Offset: 0x00127048
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

		// Token: 0x060029E6 RID: 10726 RVA: 0x001F9318 File Offset: 0x001F7518
		private void ButtonItem1_Click(object sender, EventArgs e)
		{
			bool flag = this.GridEX1.GetCheckedRows().GetLength(0) == 0;
			checked
			{
				if (!flag)
				{
					StiReport stiReport = new StiReport();
					stiReport.Load(Application.StartupPath + "\\reports\\factor.mrt");
					long num = 0L;
					DataTable dataTable = (DataTable)this.GridEX1.DataSource;
					DataTable dataTable2 = dataTable.Clone();
					GridEXRow[] rows = this.GridEX1.GetRows();
					for (int i = 0; i < rows.Length; i++)
					{
						GridEXRow gridEXRow = rows[i];
						flag = gridEXRow.IsChecked;
						if (flag)
						{
							dataTable2.ImportRow(((DataRowView)gridEXRow.DataRow).Row);
							num = Conversions.ToLong(Operators.AddObject(num, gridEXRow.Cells["jam_kol"].Value));
						}
					}
					dataTable2.TableName = "data";
					stiReport.RegData(dataTable2);
					StiText stiText = (StiText)stiReport.GetComponentByName("Text27");
					stiText.Text = this.txt_tarikh.Text;
					stiText = (StiText)stiReport.GetComponentByName("Text25");
					flag = Operators.ConditionalCompareObjectNotEqual(this.txt_moshtari.Value, -1, false);
					if (flag)
					{
						stiText.Text = this.txt_moshtari.Text;
					}
					else
					{
						stiText.Text = this.EditBox1.Text;
					}
					stiText = (StiText)stiReport.GetComponentByName("Text30");
					stiText.Text = huruf.ConvertToHuruf(Conversions.ToString(num), huruf.ConvertType.ریال);
					int value = Conversions.ToInteger(Public_Function.ExecuteScalar("select isnull(max(id),0)+1 from factorfurush"));
					stiText = (StiText)stiReport.GetComponentByName("Text26");
					stiText.Text = Conversions.ToString(value);
					NewLateBinding.LateCall(null, typeof(Public_Function), "ExecuteNonQuery", new object[]
					{
						Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("insert into factorfurush(Num,Moshtari_ID,moshtari_Name) values(" + Conversions.ToString(value) + ",", this.txt_moshtari.Value), ","), Public_Function.GetValue(this.txt_moshtari.Text)), ")")
					}, null, null, null, true);
					this.SetHeader(stiReport);
					Public_Function.AddTazminText(stiReport, true, false);
					stiReport.Print(false);
				}
			}
		}

		// Token: 0x060029E7 RID: 10727 RVA: 0x0000A634 File Offset: 0x00008834
		private void txt_tarikh_KeyDown(object sender, KeyEventArgs e)
		{
			this.LoadData();
		}

		// Token: 0x060029E8 RID: 10728 RVA: 0x001F9594 File Offset: 0x001F7794
		private void GridEX1_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				bool flag2 = this.GridEX1.CurrentRow != null;
				if (flag2)
				{
					this.GridEX1.CurrentRow.IsChecked = !this.GridEX1.CurrentRow.IsChecked;
				}
			}
		}

		// Token: 0x060029E9 RID: 10729 RVA: 0x0000A63F File Offset: 0x0000883F
		private void ButtonItem2_Click(object sender, EventArgs e)
		{
			this.GridEX1.CheckAllRecords();
		}

		// Token: 0x060029EA RID: 10730 RVA: 0x0000205D File Offset: 0x0000025D
		private void txt_moshtari_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x04001050 RID: 4176
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04001052 RID: 4178
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x04001053 RID: 4179
		[AccessedThroughProperty("txt_tarikh")]
		private DateBox2 _txt_tarikh;

		// Token: 0x04001054 RID: 4180
		[AccessedThroughProperty("GridEX1")]
		private GridEX _GridEX1;

		// Token: 0x04001055 RID: 4181
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x04001056 RID: 4182
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04001057 RID: 4183
		[AccessedThroughProperty("txt_moshtari")]
		private SelectItem _txt_moshtari;

		// Token: 0x04001058 RID: 4184
		[AccessedThroughProperty("Bar1")]
		private Bar _Bar1;

		// Token: 0x04001059 RID: 4185
		[AccessedThroughProperty("ButtonItem1")]
		private ButtonItem _ButtonItem1;

		// Token: 0x0400105A RID: 4186
		[AccessedThroughProperty("ButtonItem2")]
		private ButtonItem _ButtonItem2;

		// Token: 0x0400105B RID: 4187
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x0400105C RID: 4188
		[AccessedThroughProperty("EditBox1")]
		private EditBox _EditBox1;
	}
}
