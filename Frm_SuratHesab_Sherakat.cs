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
using Stimulsoft.Report.Export;

namespace FruitBox
{
	// Token: 0x02000151 RID: 337
	[DesignerGenerated]
	public partial class Frm_SuratHesab_Sherakat : Form
	{
		// Token: 0x060032BB RID: 12987 RVA: 0x0024DC38 File Offset: 0x0024BE38
		public Frm_SuratHesab_Sherakat()
		{
			base.KeyDown += new KeyEventHandler(this.Frm_SuratHesab_Daramad_KeyDown);
			base.Load += new EventHandler(this.Frm_SuratHesab_Moshtari_Load);
			Frm_SuratHesab_Sherakat.__ENCAddToList(this);
			this.mande = string.Empty;
			this.InitializeComponent();
		}

		// Token: 0x060032BC RID: 12988 RVA: 0x0024DC90 File Offset: 0x0024BE90
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_SuratHesab_Sherakat.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_SuratHesab_Sherakat.__ENCList.Count == Frm_SuratHesab_Sherakat.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_SuratHesab_Sherakat.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_SuratHesab_Sherakat.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_SuratHesab_Sherakat.__ENCList[num] = Frm_SuratHesab_Sherakat.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_SuratHesab_Sherakat.__ENCList.RemoveRange(num, Frm_SuratHesab_Sherakat.__ENCList.Count - num);
						Frm_SuratHesab_Sherakat.__ENCList.Capacity = Frm_SuratHesab_Sherakat.__ENCList.Count;
					}
					Frm_SuratHesab_Sherakat.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000F8D RID: 3981
		// (get) Token: 0x060032BF RID: 12991 RVA: 0x0024EE7C File Offset: 0x0024D07C
		// (set) Token: 0x060032C0 RID: 12992 RVA: 0x0000CBEF File Offset: 0x0000ADEF
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

		// Token: 0x17000F8E RID: 3982
		// (get) Token: 0x060032C1 RID: 12993 RVA: 0x0024EE94 File Offset: 0x0024D094
		// (set) Token: 0x060032C2 RID: 12994 RVA: 0x0000CBF9 File Offset: 0x0000ADF9
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

		// Token: 0x17000F8F RID: 3983
		// (get) Token: 0x060032C3 RID: 12995 RVA: 0x0024EEAC File Offset: 0x0024D0AC
		// (set) Token: 0x060032C4 RID: 12996 RVA: 0x0024EEC4 File Offset: 0x0024D0C4
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

		// Token: 0x17000F90 RID: 3984
		// (get) Token: 0x060032C5 RID: 12997 RVA: 0x0024EF24 File Offset: 0x0024D124
		// (set) Token: 0x060032C6 RID: 12998 RVA: 0x0024EF3C File Offset: 0x0024D13C
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

		// Token: 0x17000F91 RID: 3985
		// (get) Token: 0x060032C7 RID: 12999 RVA: 0x0024EF9C File Offset: 0x0024D19C
		// (set) Token: 0x060032C8 RID: 13000 RVA: 0x0024EFB4 File Offset: 0x0024D1B4
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

		// Token: 0x17000F92 RID: 3986
		// (get) Token: 0x060032C9 RID: 13001 RVA: 0x0024F014 File Offset: 0x0024D214
		// (set) Token: 0x060032CA RID: 13002 RVA: 0x0000CC03 File Offset: 0x0000AE03
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

		// Token: 0x17000F93 RID: 3987
		// (get) Token: 0x060032CB RID: 13003 RVA: 0x0024F02C File Offset: 0x0024D22C
		// (set) Token: 0x060032CC RID: 13004 RVA: 0x0024F044 File Offset: 0x0024D244
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

		// Token: 0x17000F94 RID: 3988
		// (get) Token: 0x060032CD RID: 13005 RVA: 0x0024F0A4 File Offset: 0x0024D2A4
		// (set) Token: 0x060032CE RID: 13006 RVA: 0x0000CC0D File Offset: 0x0000AE0D
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

		// Token: 0x17000F95 RID: 3989
		// (get) Token: 0x060032CF RID: 13007 RVA: 0x0024F0BC File Offset: 0x0024D2BC
		// (set) Token: 0x060032D0 RID: 13008 RVA: 0x0024F0D4 File Offset: 0x0024D2D4
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

		// Token: 0x17000F96 RID: 3990
		// (get) Token: 0x060032D1 RID: 13009 RVA: 0x0024F134 File Offset: 0x0024D334
		// (set) Token: 0x060032D2 RID: 13010 RVA: 0x0024F14C File Offset: 0x0024D34C
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

		// Token: 0x17000F97 RID: 3991
		// (get) Token: 0x060032D3 RID: 13011 RVA: 0x0024F1AC File Offset: 0x0024D3AC
		// (set) Token: 0x060032D4 RID: 13012 RVA: 0x0000CC17 File Offset: 0x0000AE17
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

		// Token: 0x17000F98 RID: 3992
		// (get) Token: 0x060032D5 RID: 13013 RVA: 0x0024F1C4 File Offset: 0x0024D3C4
		// (set) Token: 0x060032D6 RID: 13014 RVA: 0x0000CC21 File Offset: 0x0000AE21
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
				this._Timer1 = value;
			}
		}

		// Token: 0x17000F99 RID: 3993
		// (get) Token: 0x060032D7 RID: 13015 RVA: 0x0024F1DC File Offset: 0x0024D3DC
		// (set) Token: 0x060032D8 RID: 13016 RVA: 0x0024F1F4 File Offset: 0x0024D3F4
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

		// Token: 0x17000F9A RID: 3994
		// (get) Token: 0x060032D9 RID: 13017 RVA: 0x0024F254 File Offset: 0x0024D454
		// (set) Token: 0x060032DA RID: 13018 RVA: 0x0024F26C File Offset: 0x0024D46C
		internal virtual ButtonItem ButtonItem8
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem8;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem8_Click);
				bool flag = this._ButtonItem8 != null;
				if (flag)
				{
					this._ButtonItem8.Click -= value2;
				}
				this._ButtonItem8 = value;
				flag = (this._ButtonItem8 != null);
				if (flag)
				{
					this._ButtonItem8.Click += value2;
				}
			}
		}

		// Token: 0x17000F9B RID: 3995
		// (get) Token: 0x060032DB RID: 13019 RVA: 0x0024F2CC File Offset: 0x0024D4CC
		// (set) Token: 0x060032DC RID: 13020 RVA: 0x0000CC2B File Offset: 0x0000AE2B
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

		// Token: 0x17000F9C RID: 3996
		// (get) Token: 0x060032DD RID: 13021 RVA: 0x0024F2E4 File Offset: 0x0024D4E4
		// (set) Token: 0x060032DE RID: 13022 RVA: 0x0024F2FC File Offset: 0x0024D4FC
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
				SelectItem.SelectedValueChangedEventHandler obj = new SelectItem.SelectedValueChangedEventHandler(this.txt_moshtari_SelectedValueChanged);
				bool flag = this._txt_moshtari != null;
				if (flag)
				{
					this._txt_moshtari.SelectedValueChanged -= obj;
				}
				this._txt_moshtari = value;
				flag = (this._txt_moshtari != null);
				if (flag)
				{
					this._txt_moshtari.SelectedValueChanged += obj;
				}
			}
		}

		// Token: 0x17000F9D RID: 3997
		// (get) Token: 0x060032DF RID: 13023 RVA: 0x0024F35C File Offset: 0x0024D55C
		// (set) Token: 0x060032E0 RID: 13024 RVA: 0x0000CC35 File Offset: 0x0000AE35
		internal virtual FolderBrowserDialog FolderBrowserDialog1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._FolderBrowserDialog1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._FolderBrowserDialog1 = value;
			}
		}

		// Token: 0x060032E1 RID: 13025 RVA: 0x0024F374 File Offset: 0x0024D574
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

		// Token: 0x060032E2 RID: 13026 RVA: 0x0024F4AC File Offset: 0x0024D6AC
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

		// Token: 0x060032E3 RID: 13027 RVA: 0x0024F5A8 File Offset: 0x0024D7A8
		private void MandeGabl(DataTable dt)
		{
			bool flag = !this.UiCheckBox2.Checked;
			if (!flag)
			{
				flag = this.txt_mande.Checked;
				if (flag)
				{
					DataRow dataRow = Public_Function.FillDataRow(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" select sum(sanad.bed) as bed ,sum( sanad.bes) as bes,'' as tozih from Kharid_Darsad  inner join sanad  on Kharid_Darsad.Sanad_ID=Sanad.ID  where Moshtari_ID = ", this.txt_moshtari.Value), " AND sanad.tarikh<"), Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_az_tarikh.Text)))));
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

		// Token: 0x060032E4 RID: 13028 RVA: 0x0024F7D8 File Offset: 0x0024D9D8
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

		// Token: 0x060032E5 RID: 13029 RVA: 0x0024F88C File Offset: 0x0024DA8C
		private void txt_az_tarikh_KeyDown_1(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				this.FilterDate();
			}
		}

		// Token: 0x060032E6 RID: 13030 RVA: 0x0024F8B4 File Offset: 0x0024DAB4
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

		// Token: 0x060032E7 RID: 13031 RVA: 0x0000CC3F File Offset: 0x0000AE3F
		private void Frm_SuratHesab_Moshtari_Load(object sender, EventArgs e)
		{
			this.txt_az_tarikh.SetNew();
			this.txt_ta_tarikh.SetNew();
			this.txt_moshtari.Focus();
		}

		// Token: 0x060032E8 RID: 13032 RVA: 0x0024F8F4 File Offset: 0x0024DAF4
		private StiReport RenderReport(bool pdf)
		{
			StiReport stiReport = new StiReport();
			stiReport.Load(Application.StartupPath + "\\reports\\surathesabsherakat.mrt");
			DataTable dataTable = (DataTable)this.GridEX1.DataSource;
			DataTable dataTable2 = dataTable.Copy();
			dataTable2.TableName = "data";
			dataTable2.DefaultView.RowFilter = dataTable.DefaultView.RowFilter;
			stiReport.RegData(dataTable2.DefaultView);
			Public_Function.SetHeader(stiReport, false);
			StiText stiText = new StiText();
			stiText = (StiText)stiReport.GetComponentByName("Text2");
			string text = "صورتحساب شراکت  " + this.txt_moshtari.Text;
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
			Public_Function.SetHeader(stiReport, pdf);
			Public_Function.AddTazminText(stiReport, true, pdf);
			Public_Function.SetReport_MarginTop(stiReport);
			Public_Function.setReportFont(stiReport, "Text10,Text12,Text13,Text14,Text17,Text19,Text21");
			return stiReport;
		}

		// Token: 0x060032E9 RID: 13033 RVA: 0x0024FA34 File Offset: 0x0024DC34
		private void ButtonItem1_Click(object sender, EventArgs e)
		{
			StiReport stiReport = this.RenderReport(false);
			bool flag = stiReport != null;
			if (flag)
			{
				stiReport.Print(false);
			}
		}

		// Token: 0x060032EA RID: 13034 RVA: 0x0000CC67 File Offset: 0x0000AE67
		private void EditBox1_TextChanged(object sender, EventArgs e)
		{
			Public_Function.FilterGrid(this.GridEX1, this.EditBox1.Text);
		}

		// Token: 0x060032EB RID: 13035 RVA: 0x0024FA60 File Offset: 0x0024DC60
		private void GridEX1_LoadingRow(object sender, RowLoadEventArgs e)
		{
			bool flag = e.Row.RowType == RowType.TotalRow;
			if (flag)
			{
				e.Row.Cells["mande"].Text = Public_Function.FormatPrice(this.mande);
			}
		}

		// Token: 0x060032EC RID: 13036 RVA: 0x0024FAA8 File Offset: 0x0024DCA8
		private void txt_mande_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.GridEX1.DataSource == null;
			if (!flag)
			{
				DataTable dt = (DataTable)this.GridEX1.DataSource;
				this.MandeGabl(dt);
			}
		}

		// Token: 0x060032ED RID: 13037 RVA: 0x0024FAE8 File Offset: 0x0024DCE8
		private void txt_moshtari_SelectedValueChanged(object sender, EventArgs e)
		{
			DataTable dataTable = Public_Function.FillData(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select sanad.* from Kharid_Darsad  inner join sanad  on Kharid_Darsad.Sanad_ID=Sanad.ID  where Moshtari_ID = ", this.txt_moshtari.Value), " order by Tarikh")));
			dataTable.Columns.Add("mande", typeof(long));
			dataTable.Columns.Add("stat", typeof(string));
			this.calc_mande(dataTable);
			this.GridEX1.DataSource = dataTable;
			Public_Function.AddFilterColumn(this.GridEX1);
			this.GridEX1.MoveLast();
			this.EditBox1.Focus();
		}

		// Token: 0x060032EE RID: 13038 RVA: 0x0024FB90 File Offset: 0x0024DD90
		private void ButtonItem8_Click(object sender, EventArgs e)
		{
			StiReport stiReport = this.RenderReport(true);
			bool flag = stiReport == null;
			if (!flag)
			{
				flag = (this.FolderBrowserDialog1.ShowDialog() == DialogResult.OK);
				if (flag)
				{
					StiPdfExportService stiPdfExportService = new StiPdfExportService();
					StiJpegExportSettings stiJpegExportSettings = new StiJpegExportSettings();
					stiPdfExportService.MultipleFiles = true;
					stiReport.Render(true);
					string text = Public_Function.MiladiToShamsi(DateAndTime.Now).Replace("/", "");
					stiPdfExportService.ExportPdf(stiReport, this.FolderBrowserDialog1.SelectedPath + "\\شراکت -" + this.txt_moshtari.Text + ".pdf");
					Public_Function.ShowMessage("گزارش تهیه گردید", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, null);
				}
			}
		}

		// Token: 0x040013B1 RID: 5041
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x040013B3 RID: 5043
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x040013B4 RID: 5044
		[AccessedThroughProperty("UiGroupBox2")]
		private UIGroupBox _UiGroupBox2;

		// Token: 0x040013B5 RID: 5045
		[AccessedThroughProperty("GridEX1")]
		private DataEntryGrid _GridEX1;

		// Token: 0x040013B6 RID: 5046
		[AccessedThroughProperty("txt_ta_tarikh")]
		private DateBox2 _txt_ta_tarikh;

		// Token: 0x040013B7 RID: 5047
		[AccessedThroughProperty("txt_az_tarikh")]
		private DateBox2 _txt_az_tarikh;

		// Token: 0x040013B8 RID: 5048
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x040013B9 RID: 5049
		[AccessedThroughProperty("UiCheckBox2")]
		private UICheckBox _UiCheckBox2;

		// Token: 0x040013BA RID: 5050
		[AccessedThroughProperty("Bar1")]
		private Bar _Bar1;

		// Token: 0x040013BB RID: 5051
		[AccessedThroughProperty("ButtonItem1")]
		private ButtonItem _ButtonItem1;

		// Token: 0x040013BC RID: 5052
		[AccessedThroughProperty("EditBox1")]
		private EditBox _EditBox1;

		// Token: 0x040013BD RID: 5053
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x040013BE RID: 5054
		[AccessedThroughProperty("Timer1")]
		private Timer _Timer1;

		// Token: 0x040013BF RID: 5055
		[AccessedThroughProperty("txt_mande")]
		private UICheckBox _txt_mande;

		// Token: 0x040013C0 RID: 5056
		[AccessedThroughProperty("ButtonItem8")]
		private ButtonItem _ButtonItem8;

		// Token: 0x040013C1 RID: 5057
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x040013C2 RID: 5058
		[AccessedThroughProperty("txt_moshtari")]
		private SelectItem _txt_moshtari;

		// Token: 0x040013C3 RID: 5059
		[AccessedThroughProperty("FolderBrowserDialog1")]
		private FolderBrowserDialog _FolderBrowserDialog1;

		// Token: 0x040013C4 RID: 5060
		private string mande;
	}
}
