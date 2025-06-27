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
	// Token: 0x0200014E RID: 334
	[DesignerGenerated]
	public partial class Frm_SuratHesab_Sandugh : Form
	{
		// Token: 0x06003207 RID: 12807 RVA: 0x00247498 File Offset: 0x00245698
		public Frm_SuratHesab_Sandugh()
		{
			base.KeyDown += new KeyEventHandler(this.Frm_SuratHesab_Bank_KeyDown);
			base.Load += new EventHandler(this.Frm_SuratHesab_Moshtari_Load);
			Frm_SuratHesab_Sandugh.__ENCAddToList(this);
			this.mande = string.Empty;
			this.InitializeComponent();
		}

		// Token: 0x06003208 RID: 12808 RVA: 0x002474F0 File Offset: 0x002456F0
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_SuratHesab_Sandugh.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_SuratHesab_Sandugh.__ENCList.Count == Frm_SuratHesab_Sandugh.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_SuratHesab_Sandugh.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_SuratHesab_Sandugh.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_SuratHesab_Sandugh.__ENCList[num] = Frm_SuratHesab_Sandugh.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_SuratHesab_Sandugh.__ENCList.RemoveRange(num, Frm_SuratHesab_Sandugh.__ENCList.Count - num);
						Frm_SuratHesab_Sandugh.__ENCList.Capacity = Frm_SuratHesab_Sandugh.__ENCList.Count;
					}
					Frm_SuratHesab_Sandugh.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000F4D RID: 3917
		// (get) Token: 0x0600320B RID: 12811 RVA: 0x00248280 File Offset: 0x00246480
		// (set) Token: 0x0600320C RID: 12812 RVA: 0x0000C96F File Offset: 0x0000AB6F
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

		// Token: 0x17000F4E RID: 3918
		// (get) Token: 0x0600320D RID: 12813 RVA: 0x00248298 File Offset: 0x00246498
		// (set) Token: 0x0600320E RID: 12814 RVA: 0x0000C979 File Offset: 0x0000AB79
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

		// Token: 0x17000F4F RID: 3919
		// (get) Token: 0x0600320F RID: 12815 RVA: 0x002482B0 File Offset: 0x002464B0
		// (set) Token: 0x06003210 RID: 12816 RVA: 0x002482C8 File Offset: 0x002464C8
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
				RowCheckStateChangeEventHandler value2 = new RowCheckStateChangeEventHandler(this.GridEX1_RowCheckStateChanged);
				RowLoadEventHandler value3 = new RowLoadEventHandler(this.GridEX1_LoadingRow);
				KeyEventHandler value4 = new KeyEventHandler(this.GridEX1_KeyDown);
				bool flag = this._GridEX1 != null;
				if (flag)
				{
					this._GridEX1.RowCheckStateChanged -= value2;
					this._GridEX1.LoadingRow -= value3;
					this._GridEX1.KeyDown -= value4;
				}
				this._GridEX1 = value;
				flag = (this._GridEX1 != null);
				if (flag)
				{
					this._GridEX1.RowCheckStateChanged += value2;
					this._GridEX1.LoadingRow += value3;
					this._GridEX1.KeyDown += value4;
				}
			}
		}

		// Token: 0x17000F50 RID: 3920
		// (get) Token: 0x06003211 RID: 12817 RVA: 0x00248378 File Offset: 0x00246578
		// (set) Token: 0x06003212 RID: 12818 RVA: 0x00248390 File Offset: 0x00246590
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

		// Token: 0x17000F51 RID: 3921
		// (get) Token: 0x06003213 RID: 12819 RVA: 0x002483F0 File Offset: 0x002465F0
		// (set) Token: 0x06003214 RID: 12820 RVA: 0x00248408 File Offset: 0x00246608
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
				EventHandler value2 = new EventHandler(this.txt_az_tarikh_TextChanged);
				KeyEventHandler value3 = new KeyEventHandler(this.txt_az_tarikh_KeyDown_1);
				bool flag = this._txt_az_tarikh != null;
				if (flag)
				{
					this._txt_az_tarikh.TextChanged -= value2;
					this._txt_az_tarikh.KeyDown -= value3;
				}
				this._txt_az_tarikh = value;
				flag = (this._txt_az_tarikh != null);
				if (flag)
				{
					this._txt_az_tarikh.TextChanged += value2;
					this._txt_az_tarikh.KeyDown += value3;
				}
			}
		}

		// Token: 0x17000F52 RID: 3922
		// (get) Token: 0x06003215 RID: 12821 RVA: 0x00248490 File Offset: 0x00246690
		// (set) Token: 0x06003216 RID: 12822 RVA: 0x0000C983 File Offset: 0x0000AB83
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

		// Token: 0x17000F53 RID: 3923
		// (get) Token: 0x06003217 RID: 12823 RVA: 0x002484A8 File Offset: 0x002466A8
		// (set) Token: 0x06003218 RID: 12824 RVA: 0x002484C0 File Offset: 0x002466C0
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

		// Token: 0x17000F54 RID: 3924
		// (get) Token: 0x06003219 RID: 12825 RVA: 0x00248520 File Offset: 0x00246720
		// (set) Token: 0x0600321A RID: 12826 RVA: 0x0000C98D File Offset: 0x0000AB8D
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

		// Token: 0x17000F55 RID: 3925
		// (get) Token: 0x0600321B RID: 12827 RVA: 0x00248538 File Offset: 0x00246738
		// (set) Token: 0x0600321C RID: 12828 RVA: 0x00248550 File Offset: 0x00246750
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

		// Token: 0x17000F56 RID: 3926
		// (get) Token: 0x0600321D RID: 12829 RVA: 0x002485B0 File Offset: 0x002467B0
		// (set) Token: 0x0600321E RID: 12830 RVA: 0x002485C8 File Offset: 0x002467C8
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

		// Token: 0x17000F57 RID: 3927
		// (get) Token: 0x0600321F RID: 12831 RVA: 0x00248628 File Offset: 0x00246828
		// (set) Token: 0x06003220 RID: 12832 RVA: 0x0000C997 File Offset: 0x0000AB97
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

		// Token: 0x17000F58 RID: 3928
		// (get) Token: 0x06003221 RID: 12833 RVA: 0x00248640 File Offset: 0x00246840
		// (set) Token: 0x06003222 RID: 12834 RVA: 0x00248658 File Offset: 0x00246858
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

		// Token: 0x17000F59 RID: 3929
		// (get) Token: 0x06003223 RID: 12835 RVA: 0x002486B8 File Offset: 0x002468B8
		// (set) Token: 0x06003224 RID: 12836 RVA: 0x002486D0 File Offset: 0x002468D0
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

		// Token: 0x06003225 RID: 12837 RVA: 0x00248730 File Offset: 0x00246930
		private void LoadData()
		{
			DataTable dataTable = Public_Function.FillData("SELECT     ID, Bed, Bes,Tarikh, Tarikh_Fa, Tozih,checked  FROM Sanad " + Public_Function.BuildWhere(new List<string>
			{
				"tarikh>=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_az_tarikh.Text)),
				"tarikh<=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_ta_tarikh.Text))
			}, Public_Function.OperandType.where) + " AND CodeHesab_ID in (1)  ");
			dataTable.Columns.Add("mande", typeof(long));
			dataTable.Columns.Add("stat", typeof(string));
			DataRow dataRow = Public_Function.FillDataRow("select top 1 mande,Tarikh_Fa from mande_sandugh where tarikh< " + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_az_tarikh.Text)) + " order by tarikh desc ");
			bool flag = dataRow == null;
			long num;
			if (flag)
			{
				num = Conversions.ToLong(Public_Function.ExecuteScalar("select top 1 bed from sanad where codehesab_id=1 and tarikh=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi("1392/01/01"))));
			}
			else
			{
				num = Conversions.ToLong(dataRow["mande"]);
			}
			flag = (num != 0L);
			if (flag)
			{
				DataRow dataRow2 = dataTable.NewRow();
				flag = (dataRow != null);
				if (flag)
				{
					dataRow2["tozih"] = Operators.ConcatenateObject("مانده از تاریخ ", dataRow["tarikh_Fa"]);
				}
				else
				{
					dataRow2["tozih"] = "مانده اول دوره ";
				}
				flag = (num > 0L);
				if (flag)
				{
					dataRow2["bed"] = num;
					dataRow2["bes"] = 0;
				}
				else
				{
					dataRow2["bed"] = 0;
					dataRow2["bes"] = num;
				}
				dataTable.Rows.InsertAt(dataRow2, 0);
			}
			bool flag2;
			try
			{
				IEnumerator enumerator = dataTable.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow3 = (DataRow)enumerator.Current;
					flag = Operators.ConditionalCompareObjectGreater(dataRow3["bes"], 0, false);
					if (flag)
					{
						flag2 = (dataRow3["tozih"] != DBNull.Value && dataRow3["tozih"].ToString().StartsWith("دریافت از کارتخوان"));
						if (flag2)
						{
							dataRow3["bed"] = Operators.MultiplyObject(dataRow3["bes"], -1);
							dataRow3["bes"] = 0;
						}
					}
					long num2 = Conversions.ToLong(Operators.AddObject(num2, dataRow3["bed"]));
					num2 = Conversions.ToLong(Operators.SubtractObject(num2, dataRow3["bes"]));
					dataRow3["mande"] = Math.Abs(num2);
					flag2 = (num2 > 0L);
					if (flag2)
					{
						dataRow3["stat"] = "بد";
					}
					else
					{
						dataRow3["stat"] = "بس";
					}
				}
			}
			finally
			{
				IEnumerator enumerator;
				flag2 = (enumerator is IDisposable);
				if (flag2)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			this.GridEX1.DataSource = dataTable;
			this.Timer1.Enabled = true;
			flag2 = (dataTable.Rows.Count > 0);
			checked
			{
				if (flag2)
				{
					this.mande = Conversions.ToString(dataTable.Rows[dataTable.Rows.Count - 1]["mande"]);
				}
				else
				{
					this.mande = Conversions.ToString(0);
				}
				GridEXRow[] rows = this.GridEX1.GetRows();
				for (int i = 0; i < rows.Length; i++)
				{
					GridEXRow gridEXRow = rows[i];
					flag2 = (((DataRowView)gridEXRow.DataRow)["checked"] == DBNull.Value);
					if (flag2)
					{
						gridEXRow.IsChecked = false;
					}
					else
					{
						flag2 = Operators.ConditionalCompareObjectEqual(((DataRowView)gridEXRow.DataRow)["checked"], true, false);
						if (flag2)
						{
							gridEXRow.IsChecked = true;
						}
					}
				}
				Public_Function.AddFilterColumn(this.GridEX1);
				this.EditBox1.Focus();
			}
		}

		// Token: 0x06003226 RID: 12838 RVA: 0x0000C9A1 File Offset: 0x0000ABA1
		private void Frm_SuratHesab_Moshtari_Load(object sender, EventArgs e)
		{
			this.UiCheckBox2.Checked = false;
			this.txt_az_tarikh.SetNew();
			this.txt_ta_tarikh.SetNew();
			this.LoadData();
		}

		// Token: 0x06003227 RID: 12839 RVA: 0x00128E48 File Offset: 0x00127048
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

		// Token: 0x06003228 RID: 12840 RVA: 0x00248BBC File Offset: 0x00246DBC
		private void ButtonItem1_Click(object sender, EventArgs e)
		{
			bool flag = this.GridEX1.DataSource == null;
			if (!flag)
			{
				StiReport stiReport = new StiReport();
				stiReport.Load(Application.StartupPath + "\\reports\\surathesabbank.mrt");
				DataTable dataTable = (DataTable)this.GridEX1.DataSource;
				DataTable dataTable2 = dataTable.Copy();
				dataTable2.TableName = "data";
				dataTable2.DefaultView.RowFilter = dataTable.DefaultView.RowFilter;
				stiReport.RegData(dataTable2.DefaultView);
				StiText stiText = new StiText();
				stiText = (StiText)stiReport.GetComponentByName("Text3");
				string text = "صورتحساب صندوق";
				flag = this.UiCheckBox2.Checked;
				if (flag)
				{
					text = string.Concat(new string[]
					{
						text,
						" از تاریخ ",
						this.txt_az_tarikh.Text,
						" تا ",
						this.txt_ta_tarikh.Text
					});
				}
				stiText.Text.Value = text;
				this.SetHeader(stiReport);
				Public_Function.SetReport_MarginTop(stiReport);
				Public_Function.AddTazminText(stiReport, true, false);
				stiReport.Print(false);
			}
		}

		// Token: 0x06003229 RID: 12841 RVA: 0x0000C9D1 File Offset: 0x0000ABD1
		private void EditBox1_TextChanged(object sender, EventArgs e)
		{
			Public_Function.FilterGrid(this.GridEX1, this.EditBox1.Text);
		}

		// Token: 0x0600322A RID: 12842 RVA: 0x00248CF4 File Offset: 0x00246EF4
		private void txt_az_tarikh_KeyDown_1(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				this.LoadData();
			}
		}

		// Token: 0x0600322B RID: 12843 RVA: 0x00248D1C File Offset: 0x00246F1C
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
					}
				}
			}
		}

		// Token: 0x0600322C RID: 12844 RVA: 0x00248E0C File Offset: 0x0024700C
		private void Frm_SuratHesab_Bank_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Escape;
			if (flag)
			{
				this.Close();
			}
			flag = (e.KeyCode == Keys.F3);
			if (flag)
			{
				this.ButtonItem2_Click(null, null);
			}
			flag = (e.KeyCode == Keys.F4);
			if (flag)
			{
				this.ButtonItem1_Click(null, null);
			}
		}

		// Token: 0x0600322D RID: 12845 RVA: 0x00248E64 File Offset: 0x00247064
		private void GridEX1_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			bool flag3;
			if (flag)
			{
				bool flag2 = this.GridEX1.CurrentRow != null;
				if (flag2)
				{
					flag3 = (this.GridEX1.CurrentRow != null);
					if (flag3)
					{
						this.GridEX1.CurrentRow.IsChecked = !this.GridEX1.CurrentRow.IsChecked;
						this.GridEX1_RowCheckStateChanged(null, null);
					}
				}
			}
			flag3 = (e.KeyCode == Keys.Escape);
			if (flag3)
			{
				this.Close();
			}
		}

		// Token: 0x0600322E RID: 12846 RVA: 0x00248EF4 File Offset: 0x002470F4
		private void GridEX1_LoadingRow(object sender, RowLoadEventArgs e)
		{
			bool flag = e.Row.RowType == RowType.TotalRow;
			if (flag)
			{
				e.Row.Cells["mande"].Text = Public_Function.FormatPrice(this.mande);
			}
		}

		// Token: 0x0600322F RID: 12847 RVA: 0x00248F3C File Offset: 0x0024713C
		private void GridEX1_RowCheckStateChanged(object sender, RowCheckStateChangeEventArgs e)
		{
			bool flag = this.GridEX1.CurrentRow.Cells["ID"].Value == DBNull.Value;
			if (!flag)
			{
				flag = this.GridEX1.CurrentRow.IsChecked;
				if (flag)
				{
					NewLateBinding.LateCall(null, typeof(Public_Function), "ExecuteNonQuery", new object[]
					{
						Operators.ConcatenateObject("update sanad set checked=1 where id=", this.GridEX1.CurrentRow.Cells["ID"].Value)
					}, null, null, null, true);
				}
				else
				{
					NewLateBinding.LateCall(null, typeof(Public_Function), "ExecuteNonQuery", new object[]
					{
						Operators.ConcatenateObject("update sanad set checked=0 where id=", this.GridEX1.CurrentRow.Cells["ID"].Value)
					}, null, null, null, true);
				}
			}
		}

		// Token: 0x06003230 RID: 12848 RVA: 0x0000C9EC File Offset: 0x0000ABEC
		private void Timer1_Tick(object sender, EventArgs e)
		{
			this.Timer1.Enabled = false;
			this.GridEX1.MoveLast();
		}

		// Token: 0x06003231 RID: 12849 RVA: 0x0000205D File Offset: 0x0000025D
		private void ButtonItem2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06003232 RID: 12850 RVA: 0x0000CA09 File Offset: 0x0000AC09
		private void txt_az_tarikh_TextChanged(object sender, EventArgs e)
		{
			this.txt_ta_tarikh.SetDate(this.txt_az_tarikh.Text);
		}

		// Token: 0x04001366 RID: 4966
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04001368 RID: 4968
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x04001369 RID: 4969
		[AccessedThroughProperty("UiGroupBox2")]
		private UIGroupBox _UiGroupBox2;

		// Token: 0x0400136A RID: 4970
		[AccessedThroughProperty("GridEX1")]
		private DataEntryGrid _GridEX1;

		// Token: 0x0400136B RID: 4971
		[AccessedThroughProperty("txt_ta_tarikh")]
		private DateBox2 _txt_ta_tarikh;

		// Token: 0x0400136C RID: 4972
		[AccessedThroughProperty("txt_az_tarikh")]
		private DateBox2 _txt_az_tarikh;

		// Token: 0x0400136D RID: 4973
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x0400136E RID: 4974
		[AccessedThroughProperty("UiCheckBox2")]
		private UICheckBox _UiCheckBox2;

		// Token: 0x0400136F RID: 4975
		[AccessedThroughProperty("Bar1")]
		private Bar _Bar1;

		// Token: 0x04001370 RID: 4976
		[AccessedThroughProperty("ButtonItem1")]
		private ButtonItem _ButtonItem1;

		// Token: 0x04001371 RID: 4977
		[AccessedThroughProperty("EditBox1")]
		private EditBox _EditBox1;

		// Token: 0x04001372 RID: 4978
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x04001373 RID: 4979
		[AccessedThroughProperty("Timer1")]
		private Timer _Timer1;

		// Token: 0x04001374 RID: 4980
		[AccessedThroughProperty("ButtonItem2")]
		private ButtonItem _ButtonItem2;

		// Token: 0x04001375 RID: 4981
		private string mande;
	}
}
