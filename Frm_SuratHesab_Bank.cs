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
	// Token: 0x0200013F RID: 319
	[DesignerGenerated]
	public partial class Frm_SuratHesab_Bank : Form
	{
		// Token: 0x06002EBA RID: 11962 RVA: 0x00227998 File Offset: 0x00225B98
		public Frm_SuratHesab_Bank()
		{
			base.KeyDown += new KeyEventHandler(this.Frm_SuratHesab_Bank_KeyDown);
			base.Load += new EventHandler(this.Frm_SuratHesab_Moshtari_Load);
			Frm_SuratHesab_Bank.__ENCAddToList(this);
			this.mande = string.Empty;
			this.InitializeComponent();
		}

		// Token: 0x06002EBB RID: 11963 RVA: 0x002279F0 File Offset: 0x00225BF0
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_SuratHesab_Bank.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_SuratHesab_Bank.__ENCList.Count == Frm_SuratHesab_Bank.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_SuratHesab_Bank.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_SuratHesab_Bank.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_SuratHesab_Bank.__ENCList[num] = Frm_SuratHesab_Bank.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_SuratHesab_Bank.__ENCList.RemoveRange(num, Frm_SuratHesab_Bank.__ENCList.Count - num);
						Frm_SuratHesab_Bank.__ENCList.Capacity = Frm_SuratHesab_Bank.__ENCList.Count;
					}
					Frm_SuratHesab_Bank.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000E3A RID: 3642
		// (get) Token: 0x06002EBE RID: 11966 RVA: 0x00228AB4 File Offset: 0x00226CB4
		// (set) Token: 0x06002EBF RID: 11967 RVA: 0x0000BC5C File Offset: 0x00009E5C
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

		// Token: 0x17000E3B RID: 3643
		// (get) Token: 0x06002EC0 RID: 11968 RVA: 0x00228ACC File Offset: 0x00226CCC
		// (set) Token: 0x06002EC1 RID: 11969 RVA: 0x0000BC66 File Offset: 0x00009E66
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

		// Token: 0x17000E3C RID: 3644
		// (get) Token: 0x06002EC2 RID: 11970 RVA: 0x00228AE4 File Offset: 0x00226CE4
		// (set) Token: 0x06002EC3 RID: 11971 RVA: 0x00228AFC File Offset: 0x00226CFC
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
				RowCheckStateChangeEventHandler value3 = new RowCheckStateChangeEventHandler(this.GridEX1_RowCheckStateChanged);
				KeyEventHandler value4 = new KeyEventHandler(this.GridEX1_KeyDown);
				bool flag = this._GridEX1 != null;
				if (flag)
				{
					this._GridEX1.LoadingRow -= value2;
					this._GridEX1.RowCheckStateChanged -= value3;
					this._GridEX1.KeyDown -= value4;
				}
				this._GridEX1 = value;
				flag = (this._GridEX1 != null);
				if (flag)
				{
					this._GridEX1.LoadingRow += value2;
					this._GridEX1.RowCheckStateChanged += value3;
					this._GridEX1.KeyDown += value4;
				}
			}
		}

		// Token: 0x17000E3D RID: 3645
		// (get) Token: 0x06002EC4 RID: 11972 RVA: 0x00228BAC File Offset: 0x00226DAC
		// (set) Token: 0x06002EC5 RID: 11973 RVA: 0x0000BC70 File Offset: 0x00009E70
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

		// Token: 0x17000E3E RID: 3646
		// (get) Token: 0x06002EC6 RID: 11974 RVA: 0x00228BC4 File Offset: 0x00226DC4
		// (set) Token: 0x06002EC7 RID: 11975 RVA: 0x00228BDC File Offset: 0x00226DDC
		internal virtual SelectItem txt_bankhesab
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_bankhesab;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				SelectItem.SelectedValueChangedEventHandler obj = new SelectItem.SelectedValueChangedEventHandler(this.SelectItem1_SelectedValueChanged);
				bool flag = this._txt_bankhesab != null;
				if (flag)
				{
					this._txt_bankhesab.SelectedValueChanged -= obj;
				}
				this._txt_bankhesab = value;
				flag = (this._txt_bankhesab != null);
				if (flag)
				{
					this._txt_bankhesab.SelectedValueChanged += obj;
				}
			}
		}

		// Token: 0x17000E3F RID: 3647
		// (get) Token: 0x06002EC8 RID: 11976 RVA: 0x00228C3C File Offset: 0x00226E3C
		// (set) Token: 0x06002EC9 RID: 11977 RVA: 0x00228C54 File Offset: 0x00226E54
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

		// Token: 0x17000E40 RID: 3648
		// (get) Token: 0x06002ECA RID: 11978 RVA: 0x00228CB4 File Offset: 0x00226EB4
		// (set) Token: 0x06002ECB RID: 11979 RVA: 0x00228CCC File Offset: 0x00226ECC
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

		// Token: 0x17000E41 RID: 3649
		// (get) Token: 0x06002ECC RID: 11980 RVA: 0x00228D2C File Offset: 0x00226F2C
		// (set) Token: 0x06002ECD RID: 11981 RVA: 0x0000BC7A File Offset: 0x00009E7A
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

		// Token: 0x17000E42 RID: 3650
		// (get) Token: 0x06002ECE RID: 11982 RVA: 0x00228D44 File Offset: 0x00226F44
		// (set) Token: 0x06002ECF RID: 11983 RVA: 0x00228D5C File Offset: 0x00226F5C
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

		// Token: 0x17000E43 RID: 3651
		// (get) Token: 0x06002ED0 RID: 11984 RVA: 0x00228DBC File Offset: 0x00226FBC
		// (set) Token: 0x06002ED1 RID: 11985 RVA: 0x0000BC84 File Offset: 0x00009E84
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

		// Token: 0x17000E44 RID: 3652
		// (get) Token: 0x06002ED2 RID: 11986 RVA: 0x00228DD4 File Offset: 0x00226FD4
		// (set) Token: 0x06002ED3 RID: 11987 RVA: 0x00228DEC File Offset: 0x00226FEC
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

		// Token: 0x17000E45 RID: 3653
		// (get) Token: 0x06002ED4 RID: 11988 RVA: 0x00228E4C File Offset: 0x0022704C
		// (set) Token: 0x06002ED5 RID: 11989 RVA: 0x00228E64 File Offset: 0x00227064
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

		// Token: 0x17000E46 RID: 3654
		// (get) Token: 0x06002ED6 RID: 11990 RVA: 0x00228EC4 File Offset: 0x002270C4
		// (set) Token: 0x06002ED7 RID: 11991 RVA: 0x0000BC8E File Offset: 0x00009E8E
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

		// Token: 0x17000E47 RID: 3655
		// (get) Token: 0x06002ED8 RID: 11992 RVA: 0x00228EDC File Offset: 0x002270DC
		// (set) Token: 0x06002ED9 RID: 11993 RVA: 0x00228EF4 File Offset: 0x002270F4
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

		// Token: 0x17000E48 RID: 3656
		// (get) Token: 0x06002EDA RID: 11994 RVA: 0x00228F54 File Offset: 0x00227154
		// (set) Token: 0x06002EDB RID: 11995 RVA: 0x00228F6C File Offset: 0x0022716C
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

		// Token: 0x17000E49 RID: 3657
		// (get) Token: 0x06002EDC RID: 11996 RVA: 0x00228FCC File Offset: 0x002271CC
		// (set) Token: 0x06002EDD RID: 11997 RVA: 0x0000BC98 File Offset: 0x00009E98
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

		// Token: 0x17000E4A RID: 3658
		// (get) Token: 0x06002EDE RID: 11998 RVA: 0x00228FE4 File Offset: 0x002271E4
		// (set) Token: 0x06002EDF RID: 11999 RVA: 0x0000BCA2 File Offset: 0x00009EA2
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

		// Token: 0x06002EE0 RID: 12000 RVA: 0x00228FFC File Offset: 0x002271FC
		private void SelectItem1_SelectedValueChanged(object sender, EventArgs e)
		{
			int value = Conversions.ToInteger(NewLateBinding.LateGet(null, typeof(Public_Function), "ExecuteScalar", new object[]
			{
				Operators.ConcatenateObject("Select CodeHesab_Mojodi from Bank_Hesab where id=", this.txt_bankhesab.Value)
			}, null, null, null));
			DataTable dataTable = Public_Function.FillData(" select * from (SELECT  top 100   ID, Bed, Bes,Tarikh, Tarikh_Fa, Tozih,checked  FROM Sanad where CodeHesab_ID=" + Conversions.ToString(value) + " order by Tarikh desc,id desc)t  order by tarikh,id");
			dataTable.Columns.Add("mande", typeof(long));
			dataTable.Columns.Add("stat", typeof(string));
			string str = string.Empty;
			bool flag = dataTable.Rows.Count > 0;
			if (flag)
			{
				str = " AND ID NOT IN (" + Public_Function.GetID(dataTable, "id", "") + ")";
			}
			DataRow dataRow = Public_Function.FillDataRow("  SELECT     null as ID, isnull(sum( Sanad.Bed),0) as Bed,isnull(sum( Sanad.Bes),0) as Bes,max(tarikh) as Tarikh,null as Tarikh_Fa, '' as Tozih    FROM Sanad    WHERE Sanad.CodeHesab_ID = " + Conversions.ToString(value) + str);
			dataRow["Tozih"] = "مانده از قبل";
			DataRow dataRow2 = dataTable.NewRow();
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
			bool flag2;
			if (flag)
			{
				flag2 = (dataTable.Rows[0]["ID"] == DBNull.Value);
				if (flag2)
				{
					dataTable.Rows[0].Delete();
				}
				dataRow2["bed"] = RuntimeHelpers.GetObjectValue(dataRow["bed"]);
				dataRow2["bes"] = RuntimeHelpers.GetObjectValue(dataRow["bes"]);
				dataRow2["tozih"] = "مانده از قبل";
				dataRow2["tarikh"] = Public_Function.ShamsiToMiladi(this.txt_az_tarikh.Text);
				dataTable.Rows.InsertAt(dataRow2, 0);
			}
			try
			{
				IEnumerator enumerator = dataTable.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow3 = (DataRow)enumerator.Current;
					long num = Conversions.ToLong(Operators.AddObject(num, dataRow3["bed"]));
					num = Conversions.ToLong(Operators.SubtractObject(num, dataRow3["bes"]));
					dataRow3["mande"] = num;
					flag2 = (num > 0L);
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

		// Token: 0x06002EE1 RID: 12001 RVA: 0x0022946C File Offset: 0x0022766C
		private void Frm_SuratHesab_Moshtari_Load(object sender, EventArgs e)
		{
			this.txt_bankhesab.Edit_Frm = MyProject.Forms.Frm_Bank_Hesab;
			this.txt_bankhesab.AddNewForm = MyProject.Forms.Frm_Bank_Hesab;
			bool flag = this.BankHesab_ID.HasValue;
			if (flag)
			{
				this.txt_bankhesab.SetValue(this.BankHesab_Name, this.BankHesab_ID);
				this.SelectItem1_SelectedValueChanged(null, null);
			}
			flag = (Conversions.ToDouble(Public_Function.dict["surat_bank_kind"]) == 2.0);
			if (flag)
			{
				this.GridEX1.RootTable.Columns["bed"].Caption = "بدهکار";
				this.GridEX1.RootTable.Columns["bes"].Caption = "بستانکار";
				this.GridEX1.RootTable.Columns["stat"].Visible = true;
			}
			this.UiCheckBox2.Checked = false;
			this.txt_az_tarikh.SetNew();
			this.txt_ta_tarikh.SetNew();
		}

		// Token: 0x06002EE2 RID: 12002 RVA: 0x00128E48 File Offset: 0x00127048
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

		// Token: 0x06002EE3 RID: 12003 RVA: 0x00229594 File Offset: 0x00227794
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
				string text = "صورتحساب " + this.txt_bankhesab.Text;
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
				Public_Function.AddTazminText(stiReport, true, false);
				Public_Function.SetReport_MarginTop(stiReport);
				Public_Function.setReportFont(stiReport, "Text10,Text12,Text13,Text14,Text17,Text19,Text21");
				stiReport.Print(false);
			}
		}

		// Token: 0x06002EE4 RID: 12004 RVA: 0x0000BCAC File Offset: 0x00009EAC
		private void EditBox1_TextChanged(object sender, EventArgs e)
		{
			Public_Function.FilterGrid(this.GridEX1, this.EditBox1.Text);
		}

		// Token: 0x06002EE5 RID: 12005 RVA: 0x002296E8 File Offset: 0x002278E8
		private void FilterDate()
		{
			bool flag = this.GridEX1.DataSource == null;
			checked
			{
				if (!flag)
				{
					flag = !this.UiCheckBox2.Checked;
					if (!flag)
					{
						DataTable dataTable = (DataTable)this.GridEX1.DataSource;
						int value = Conversions.ToInteger(NewLateBinding.LateGet(null, typeof(Public_Function), "ExecuteScalar", new object[]
						{
							Operators.ConcatenateObject("select codehesab_mojodi from bank_hesab where id=", this.txt_bankhesab.Value)
						}, null, null, null));
						DataRow dataRow = Public_Function.FillDataRow("  SELECT     null as ID, isnull(sum( Sanad.Bed),0) as Bed,isnull(sum( Sanad.Bes),0) as Bes,max(tarikh) as Tarikh,null as Tarikh_Fa, '' as Tozih    FROM Sanad    WHERE Sanad.CodeHesab_ID = " + Conversions.ToString(value) + " and sanad.tarikh<" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_az_tarikh.Text)));
						DataTable dataTable2 = Public_Function.FillData(string.Concat(new string[]
						{
							"   SELECT  ID, Bed, Bes,Tarikh, Tarikh_Fa, Tozih,checked  FROM Sanad where CodeHesab_ID=",
							Conversions.ToString(value),
							"  and sanad.tarikh >=",
							Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_az_tarikh.Text)),
							"AND sanad.tarikh<=",
							Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_ta_tarikh.Text)),
							" order by tarikh,id"
						}));
						dataTable2.Columns.Add("mande", typeof(long));
						dataTable2.Columns.Add("stat", typeof(string));
						dataRow["Tozih"] = "مانده از قبل";
						DataRow dataRow2 = dataTable2.NewRow();
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
						bool flag2;
						if (flag)
						{
							flag2 = (dataTable.Rows[0]["ID"] == DBNull.Value);
							if (flag2)
							{
								dataTable.Rows[0].Delete();
							}
							dataRow2["bed"] = RuntimeHelpers.GetObjectValue(dataRow["bed"]);
							dataRow2["bes"] = RuntimeHelpers.GetObjectValue(dataRow["bes"]);
							dataRow2["tozih"] = "مانده از قبل";
							dataRow2["tarikh"] = Public_Function.ShamsiToMiladi(this.txt_az_tarikh.Text);
							dataTable2.Rows.InsertAt(dataRow2, 0);
						}
						try
						{
							IEnumerator enumerator = dataTable2.Rows.GetEnumerator();
							while (enumerator.MoveNext())
							{
								DataRow dataRow3 = (DataRow)enumerator.Current;
								long num = Conversions.ToLong(Operators.AddObject(num, dataRow3["bed"]));
								num = Conversions.ToLong(Operators.SubtractObject(num, dataRow3["bes"]));
								dataRow3["mande"] = Math.Abs(num);
								flag2 = (num > 0L);
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
						flag2 = (dataTable.Rows.Count > 0);
						if (flag2)
						{
							this.mande = Conversions.ToString(dataTable.Rows[dataTable.Rows.Count - 1]["mande"]);
						}
						else
						{
							this.mande = Conversions.ToString(0);
						}
						this.GridEX1.DataSource = dataTable2;
						Public_Function.AddFilterColumn(this.GridEX1);
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
						this.GridEX1.MoveLast();
					}
				}
			}
		}

		// Token: 0x06002EE6 RID: 12006 RVA: 0x00229BDC File Offset: 0x00227DDC
		private void txt_az_tarikh_KeyDown_1(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				this.FilterDate();
			}
		}

		// Token: 0x06002EE7 RID: 12007 RVA: 0x00229C04 File Offset: 0x00227E04
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
				this.SelectItem1_SelectedValueChanged(null, null);
			}
		}

		// Token: 0x06002EE8 RID: 12008 RVA: 0x00229C84 File Offset: 0x00227E84
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

		// Token: 0x06002EE9 RID: 12009 RVA: 0x00229CDC File Offset: 0x00227EDC
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

		// Token: 0x06002EEA RID: 12010 RVA: 0x00229D6C File Offset: 0x00227F6C
		private void GridEX1_LoadingRow(object sender, RowLoadEventArgs e)
		{
			bool flag = e.Row.RowType == RowType.TotalRow;
			if (flag)
			{
				e.Row.Cells["mande"].Text = Public_Function.FormatPrice(this.mande);
			}
		}

		// Token: 0x06002EEB RID: 12011 RVA: 0x00229DB4 File Offset: 0x00227FB4
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

		// Token: 0x06002EEC RID: 12012 RVA: 0x0000BCC7 File Offset: 0x00009EC7
		private void Timer1_Tick(object sender, EventArgs e)
		{
			this.Timer1.Enabled = false;
			this.GridEX1.MoveLast();
		}

		// Token: 0x06002EED RID: 12013 RVA: 0x0000BCE4 File Offset: 0x00009EE4
		private void ButtonItem2_Click(object sender, EventArgs e)
		{
			this.txt_bankhesab.PerformButtonClick();
		}

		// Token: 0x04001223 RID: 4643
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04001225 RID: 4645
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x04001226 RID: 4646
		[AccessedThroughProperty("UiGroupBox2")]
		private UIGroupBox _UiGroupBox2;

		// Token: 0x04001227 RID: 4647
		[AccessedThroughProperty("GridEX1")]
		private DataEntryGrid _GridEX1;

		// Token: 0x04001228 RID: 4648
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04001229 RID: 4649
		[AccessedThroughProperty("txt_bankhesab")]
		private SelectItem _txt_bankhesab;

		// Token: 0x0400122A RID: 4650
		[AccessedThroughProperty("txt_ta_tarikh")]
		private DateBox2 _txt_ta_tarikh;

		// Token: 0x0400122B RID: 4651
		[AccessedThroughProperty("txt_az_tarikh")]
		private DateBox2 _txt_az_tarikh;

		// Token: 0x0400122C RID: 4652
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x0400122D RID: 4653
		[AccessedThroughProperty("UiCheckBox2")]
		private UICheckBox _UiCheckBox2;

		// Token: 0x0400122E RID: 4654
		[AccessedThroughProperty("Bar1")]
		private Bar _Bar1;

		// Token: 0x0400122F RID: 4655
		[AccessedThroughProperty("ButtonItem1")]
		private ButtonItem _ButtonItem1;

		// Token: 0x04001230 RID: 4656
		[AccessedThroughProperty("EditBox1")]
		private EditBox _EditBox1;

		// Token: 0x04001231 RID: 4657
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x04001232 RID: 4658
		[AccessedThroughProperty("Timer1")]
		private Timer _Timer1;

		// Token: 0x04001233 RID: 4659
		[AccessedThroughProperty("ButtonItem2")]
		private ButtonItem _ButtonItem2;

		// Token: 0x04001234 RID: 4660
		[CompilerGenerated]
		private int? _BankHesab_ID;

		// Token: 0x04001235 RID: 4661
		[CompilerGenerated]
		private string _BankHesab_Name;

		// Token: 0x04001236 RID: 4662
		private string mande;
	}
}
