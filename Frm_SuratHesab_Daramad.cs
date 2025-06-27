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
	// Token: 0x02000142 RID: 322
	[DesignerGenerated]
	public partial class Frm_SuratHesab_Daramad : Form
	{
		// Token: 0x06002F1E RID: 12062 RVA: 0x0022BBD0 File Offset: 0x00229DD0
		public Frm_SuratHesab_Daramad()
		{
			base.KeyDown += new KeyEventHandler(this.Frm_SuratHesab_Daramad_KeyDown);
			base.Load += new EventHandler(this.Frm_SuratHesab_Moshtari_Load);
			Frm_SuratHesab_Daramad.__ENCAddToList(this);
			this.mande = string.Empty;
			this.InitializeComponent();
		}

		// Token: 0x06002F1F RID: 12063 RVA: 0x0022BC28 File Offset: 0x00229E28
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_SuratHesab_Daramad.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_SuratHesab_Daramad.__ENCList.Count == Frm_SuratHesab_Daramad.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_SuratHesab_Daramad.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_SuratHesab_Daramad.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_SuratHesab_Daramad.__ENCList[num] = Frm_SuratHesab_Daramad.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_SuratHesab_Daramad.__ENCList.RemoveRange(num, Frm_SuratHesab_Daramad.__ENCList.Count - num);
						Frm_SuratHesab_Daramad.__ENCList.Capacity = Frm_SuratHesab_Daramad.__ENCList.Count;
					}
					Frm_SuratHesab_Daramad.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000E57 RID: 3671
		// (get) Token: 0x06002F22 RID: 12066 RVA: 0x0022CA44 File Offset: 0x0022AC44
		// (set) Token: 0x06002F23 RID: 12067 RVA: 0x0000BD83 File Offset: 0x00009F83
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

		// Token: 0x17000E58 RID: 3672
		// (get) Token: 0x06002F24 RID: 12068 RVA: 0x0022CA5C File Offset: 0x0022AC5C
		// (set) Token: 0x06002F25 RID: 12069 RVA: 0x0000BD8D File Offset: 0x00009F8D
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

		// Token: 0x17000E59 RID: 3673
		// (get) Token: 0x06002F26 RID: 12070 RVA: 0x0022CA74 File Offset: 0x0022AC74
		// (set) Token: 0x06002F27 RID: 12071 RVA: 0x0022CA8C File Offset: 0x0022AC8C
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
				RowLoadEventHandler value2 = new RowLoadEventHandler(this.GridEX1_LoadingRow);
				bool flag = this._GridEX1 != null;
				if (flag)
				{
					this._GridEX1.LoadingRow -= value2;
				}
				this._GridEX1 = value;
				flag = (this._GridEX1 != null);
				if (flag)
				{
					this._GridEX1.LoadingRow += value2;
				}
			}
		}

		// Token: 0x17000E5A RID: 3674
		// (get) Token: 0x06002F28 RID: 12072 RVA: 0x0022CAEC File Offset: 0x0022ACEC
		// (set) Token: 0x06002F29 RID: 12073 RVA: 0x0022CB04 File Offset: 0x0022AD04
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

		// Token: 0x17000E5B RID: 3675
		// (get) Token: 0x06002F2A RID: 12074 RVA: 0x0022CB64 File Offset: 0x0022AD64
		// (set) Token: 0x06002F2B RID: 12075 RVA: 0x0022CB7C File Offset: 0x0022AD7C
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

		// Token: 0x17000E5C RID: 3676
		// (get) Token: 0x06002F2C RID: 12076 RVA: 0x0022CBDC File Offset: 0x0022ADDC
		// (set) Token: 0x06002F2D RID: 12077 RVA: 0x0000BD97 File Offset: 0x00009F97
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

		// Token: 0x17000E5D RID: 3677
		// (get) Token: 0x06002F2E RID: 12078 RVA: 0x0022CBF4 File Offset: 0x0022ADF4
		// (set) Token: 0x06002F2F RID: 12079 RVA: 0x0022CC0C File Offset: 0x0022AE0C
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

		// Token: 0x17000E5E RID: 3678
		// (get) Token: 0x06002F30 RID: 12080 RVA: 0x0022CC6C File Offset: 0x0022AE6C
		// (set) Token: 0x06002F31 RID: 12081 RVA: 0x0000BDA1 File Offset: 0x00009FA1
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

		// Token: 0x17000E5F RID: 3679
		// (get) Token: 0x06002F32 RID: 12082 RVA: 0x0022CC84 File Offset: 0x0022AE84
		// (set) Token: 0x06002F33 RID: 12083 RVA: 0x0022CC9C File Offset: 0x0022AE9C
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

		// Token: 0x17000E60 RID: 3680
		// (get) Token: 0x06002F34 RID: 12084 RVA: 0x0022CCFC File Offset: 0x0022AEFC
		// (set) Token: 0x06002F35 RID: 12085 RVA: 0x0022CD14 File Offset: 0x0022AF14
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

		// Token: 0x17000E61 RID: 3681
		// (get) Token: 0x06002F36 RID: 12086 RVA: 0x0022CD74 File Offset: 0x0022AF74
		// (set) Token: 0x06002F37 RID: 12087 RVA: 0x0000BDAB File Offset: 0x00009FAB
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

		// Token: 0x17000E62 RID: 3682
		// (get) Token: 0x06002F38 RID: 12088 RVA: 0x0022CD8C File Offset: 0x0022AF8C
		// (set) Token: 0x06002F39 RID: 12089 RVA: 0x0022CDA4 File Offset: 0x0022AFA4
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

		// Token: 0x17000E63 RID: 3683
		// (get) Token: 0x06002F3A RID: 12090 RVA: 0x0022CE04 File Offset: 0x0022B004
		// (set) Token: 0x06002F3B RID: 12091 RVA: 0x0022CE1C File Offset: 0x0022B01C
		internal virtual UICheckBox txt_mande
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_mande;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txt_mande_CheckedChanged);
				bool flag = this._txt_mande != null;
				if (flag)
				{
					this._txt_mande.CheckedChanged -= value2;
				}
				this._txt_mande = value;
				flag = (this._txt_mande != null);
				if (flag)
				{
					this._txt_mande.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x06002F3C RID: 12092 RVA: 0x0022CE7C File Offset: 0x0022B07C
		private void calc_mande(DataTable dt)
		{
			int arg_10_0 = 0;
			checked
			{
				int num = dt.DefaultView.Count - 1;
				int num2 = arg_10_0;
				bool flag;
				while (true)
				{
					int arg_D6_0 = num2;
					int num3 = num;
					if (arg_D6_0 > num3)
					{
						break;
					}
					long num4 = Conversions.ToLong(Operators.AddObject(num4, dt.DefaultView[num2]["bed"]));
					num4 = Conversions.ToLong(Operators.SubtractObject(num4, dt.DefaultView[num2]["bes"]));
					dt.DefaultView[num2]["mande"] = Math.Abs(num4);
					flag = (num4 > 0L);
					if (flag)
					{
						dt.DefaultView[num2]["stat"] = "بد";
					}
					else
					{
						dt.DefaultView[num2]["stat"] = "بس";
					}
					num2++;
				}
				flag = (dt.DefaultView.Count > 0);
				if (flag)
				{
					this.mande = Conversions.ToString(dt.DefaultView[dt.DefaultView.Count - 1]["mande"]);
				}
				else
				{
					this.mande = Conversions.ToString(0);
				}
			}
		}

		// Token: 0x06002F3D RID: 12093 RVA: 0x0022CFB4 File Offset: 0x0022B1B4
		private void SelectItem1_SelectedValueChanged(object sender, EventArgs e)
		{
			DataTable dataTable = Public_Function.FillData("SELECT     Sanad.ID, Sanad.Bed, Sanad.Bes,Sanad.Tarikh, Sanad.Tarikh_Fa, Sanad.Tozih  FROM         Sanad INNER JOIN  Code_Hesab ON Sanad.CodeHesab_ID = Code_Hesab.ID  WHERE     Code_Hesab.Grouh_ID=7 order by tarikh");
			dataTable.Columns.Add("mande", typeof(long));
			dataTable.Columns.Add("stat", typeof(string));
			this.calc_mande(dataTable);
			this.GridEX1.DataSource = dataTable;
			Public_Function.AddFilterColumn(this.GridEX1);
			this.EditBox1.Focus();
		}

		// Token: 0x06002F3E RID: 12094 RVA: 0x0000BDB5 File Offset: 0x00009FB5
		private void Timer1_Tick(object sender, EventArgs e)
		{
			this.Timer1.Enabled = false;
			this.GridEX1.MoveLast();
		}

		// Token: 0x06002F3F RID: 12095 RVA: 0x0022D034 File Offset: 0x0022B234
		private void UiCheckBox2_CheckedChanged(object sender, EventArgs e)
		{
			this.txt_az_tarikh.Enabled = this.UiCheckBox2.Checked;
			this.txt_ta_tarikh.Enabled = this.UiCheckBox2.Checked;
			bool flag = this.UiCheckBox2.Checked;
			if (flag)
			{
				this.txt_az_tarikh.FocusDatePart = 1;
				this.txt_az_tarikh.Focus();
				this.txt_az_tarikh.Focus();
			}
			else
			{
				DataTable dataTable = (DataTable)this.GridEX1.DataSource;
				flag = (dataTable == null);
				if (!flag)
				{
					flag = (dataTable.Rows == null);
					if (!flag)
					{
						dataTable.DefaultView.RowFilter = string.Empty;
						flag = (dataTable.Rows[0]["ID"] == DBNull.Value);
						if (flag)
						{
							dataTable.Rows[0].Delete();
							dataTable.AcceptChanges();
						}
						this.calc_mande(dataTable);
					}
				}
			}
		}

		// Token: 0x06002F40 RID: 12096 RVA: 0x0022D130 File Offset: 0x0022B330
		private void MandeGabl(DataTable dt)
		{
			bool flag = !this.UiCheckBox2.Checked;
			if (!flag)
			{
				flag = this.txt_mande.Checked;
				if (flag)
				{
					DataRow dataRow = Public_Function.FillDataRow("    SELECT     NULL AS ID, ISNULL(SUM(Sanad.Bed), 0) AS Bed, ISNULL(SUM(Sanad.Bes), 0) AS Bes, MAX(Sanad.Tarikh) AS Tarikh, NULL AS Tarikh_Fa, '' AS Tozih  FROM         Sanad INNER JOIN Code_Hesab ON Sanad.CodeHesab_ID = Code_Hesab.ID  WHERE Code_Hesab.Grouh_ID=7 and sanad.tarikh<" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_az_tarikh.Text)));
					dataRow["Tozih"] = "مانده از قبل";
					DataRow dataRow2 = dt.NewRow();
					flag = Operators.ConditionalCompareObjectGreater(dataRow["bed"], dataRow["bes"], false);
					if (flag)
					{
						dataRow2["mande"] = Operators.SubtractObject(dataRow["bed"], dataRow["bes"]);
						dataRow2["stat"] = "بد";
					}
					else
					{
						dataRow2["mande"] = Operators.SubtractObject(dataRow["bes"], dataRow["bed"]);
						dataRow2["stat"] = "بس";
					}
					flag = Operators.ConditionalCompareObjectNotEqual(dataRow2["mande"], 0, false);
					if (flag)
					{
						bool flag2 = dt.Rows[0]["ID"] == DBNull.Value;
						if (flag2)
						{
							dt.Rows[0].Delete();
						}
						dataRow2["bed"] = RuntimeHelpers.GetObjectValue(dataRow["bed"]);
						dataRow2["bes"] = RuntimeHelpers.GetObjectValue(dataRow["bes"]);
						dataRow2["tozih"] = "مانده از قبل";
						dataRow2["tarikh"] = Public_Function.ShamsiToMiladi(this.txt_az_tarikh.Text);
						dt.Rows.InsertAt(dataRow2, 0);
					}
				}
				else
				{
					bool flag2 = dt.Rows[0]["ID"] == DBNull.Value;
					if (flag2)
					{
						dt.Rows[0].Delete();
					}
				}
				this.calc_mande(dt);
			}
		}

		// Token: 0x06002F41 RID: 12097 RVA: 0x0022D340 File Offset: 0x0022B540
		private void FilterDate()
		{
			bool flag = this.GridEX1.DataSource == null;
			if (!flag)
			{
				flag = !this.UiCheckBox2.Checked;
				if (!flag)
				{
					DataTable dataTable = (DataTable)this.GridEX1.DataSource;
					dataTable.DefaultView.RowFilter = string.Concat(new string[]
					{
						"tarikh >= '",
						Public_Function.ShamsiToMiladi(this.txt_az_tarikh.Text),
						"' AND tarikh<='",
						Public_Function.ShamsiToMiladi(this.txt_ta_tarikh.Text),
						"'"
					});
					this.MandeGabl(dataTable);
				}
			}
		}

		// Token: 0x06002F42 RID: 12098 RVA: 0x0022D3F4 File Offset: 0x0022B5F4
		private void txt_az_tarikh_KeyDown_1(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				this.FilterDate();
			}
		}

		// Token: 0x06002F43 RID: 12099 RVA: 0x0022D41C File Offset: 0x0022B61C
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

		// Token: 0x06002F44 RID: 12100 RVA: 0x0000BDD2 File Offset: 0x00009FD2
		private void Frm_SuratHesab_Moshtari_Load(object sender, EventArgs e)
		{
			this.SelectItem1_SelectedValueChanged(null, null);
			this.txt_az_tarikh.SetNew();
			this.txt_ta_tarikh.SetNew();
		}

		// Token: 0x06002F45 RID: 12101 RVA: 0x00128E48 File Offset: 0x00127048
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

		// Token: 0x06002F46 RID: 12102 RVA: 0x0022D45C File Offset: 0x0022B65C
		private void ButtonItem1_Click(object sender, EventArgs e)
		{
			StiReport stiReport = new StiReport();
			stiReport.Load(Application.StartupPath + "\\reports\\surathesabdaramad.mrt");
			DataTable dataTable = (DataTable)this.GridEX1.DataSource;
			DataTable dataTable2 = dataTable.Copy();
			dataTable2.TableName = "data";
			dataTable2.DefaultView.RowFilter = dataTable.DefaultView.RowFilter;
			stiReport.RegData(dataTable2.DefaultView);
			this.SetHeader(stiReport);
			StiText stiText = new StiText();
			stiText = (StiText)stiReport.GetComponentByName("Text2");
			string text = "صورتحساب درآمد ";
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
			Public_Function.AddTazminText(stiReport, true, false);
			Public_Function.SetReport_MarginTop(stiReport);
			Public_Function.setReportFont(stiReport, "Text10,Text12,Text13,Text14,Text17,Text19,Text21");
			stiReport.Print(false);
		}

		// Token: 0x06002F47 RID: 12103 RVA: 0x0000BDF7 File Offset: 0x00009FF7
		private void EditBox1_TextChanged(object sender, EventArgs e)
		{
			Public_Function.FilterGrid(this.GridEX1, this.EditBox1.Text);
		}

		// Token: 0x06002F48 RID: 12104 RVA: 0x0022D584 File Offset: 0x0022B784
		private void GridEX1_LoadingRow(object sender, RowLoadEventArgs e)
		{
			bool flag = e.Row.RowType == RowType.TotalRow;
			if (flag)
			{
				e.Row.Cells["mande"].Text = Public_Function.FormatPrice(this.mande);
			}
		}

		// Token: 0x06002F49 RID: 12105 RVA: 0x0022D5CC File Offset: 0x0022B7CC
		private void txt_mande_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.GridEX1.DataSource == null;
			if (!flag)
			{
				DataTable dt = (DataTable)this.GridEX1.DataSource;
				this.MandeGabl(dt);
			}
		}

		// Token: 0x04001249 RID: 4681
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x0400124B RID: 4683
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x0400124C RID: 4684
		[AccessedThroughProperty("UiGroupBox2")]
		private UIGroupBox _UiGroupBox2;

		// Token: 0x0400124D RID: 4685
		[AccessedThroughProperty("GridEX1")]
		private DataEntryGrid _GridEX1;

		// Token: 0x0400124E RID: 4686
		[AccessedThroughProperty("txt_ta_tarikh")]
		private DateBox2 _txt_ta_tarikh;

		// Token: 0x0400124F RID: 4687
		[AccessedThroughProperty("txt_az_tarikh")]
		private DateBox2 _txt_az_tarikh;

		// Token: 0x04001250 RID: 4688
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x04001251 RID: 4689
		[AccessedThroughProperty("UiCheckBox2")]
		private UICheckBox _UiCheckBox2;

		// Token: 0x04001252 RID: 4690
		[AccessedThroughProperty("Bar1")]
		private Bar _Bar1;

		// Token: 0x04001253 RID: 4691
		[AccessedThroughProperty("ButtonItem1")]
		private ButtonItem _ButtonItem1;

		// Token: 0x04001254 RID: 4692
		[AccessedThroughProperty("EditBox1")]
		private EditBox _EditBox1;

		// Token: 0x04001255 RID: 4693
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x04001256 RID: 4694
		[AccessedThroughProperty("Timer1")]
		private Timer _Timer1;

		// Token: 0x04001257 RID: 4695
		[AccessedThroughProperty("txt_mande")]
		private UICheckBox _txt_mande;

		// Token: 0x04001258 RID: 4696
		private string mande;
	}
}
