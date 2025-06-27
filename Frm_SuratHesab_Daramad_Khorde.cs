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
using Janus.Windows.GridEX.EditControls;
using Janus.Windows.UI.Dock;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Stimulsoft.Report;
using Stimulsoft.Report.Components;

namespace FruitBox
{
	// Token: 0x02000143 RID: 323
	[DesignerGenerated]
	public partial class Frm_SuratHesab_Daramad_Khorde : Form
	{
		// Token: 0x06002F4B RID: 12107 RVA: 0x0022D60C File Offset: 0x0022B80C
		public Frm_SuratHesab_Daramad_Khorde()
		{
			base.KeyDown += new KeyEventHandler(this.Frm_SuratHesab_Daramad_KeyDown);
			base.Load += new EventHandler(this.Frm_SuratHesab_Moshtari_Load);
			Frm_SuratHesab_Daramad_Khorde.__ENCAddToList(this);
			this.mande = string.Empty;
			this.InitializeComponent();
		}

		// Token: 0x06002F4C RID: 12108 RVA: 0x0022D664 File Offset: 0x0022B864
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_SuratHesab_Daramad_Khorde.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_SuratHesab_Daramad_Khorde.__ENCList.Count == Frm_SuratHesab_Daramad_Khorde.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_SuratHesab_Daramad_Khorde.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_SuratHesab_Daramad_Khorde.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_SuratHesab_Daramad_Khorde.__ENCList[num] = Frm_SuratHesab_Daramad_Khorde.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_SuratHesab_Daramad_Khorde.__ENCList.RemoveRange(num, Frm_SuratHesab_Daramad_Khorde.__ENCList.Count - num);
						Frm_SuratHesab_Daramad_Khorde.__ENCList.Capacity = Frm_SuratHesab_Daramad_Khorde.__ENCList.Count;
					}
					Frm_SuratHesab_Daramad_Khorde.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000E64 RID: 3684
		// (get) Token: 0x06002F4F RID: 12111 RVA: 0x0022E3B8 File Offset: 0x0022C5B8
		// (set) Token: 0x06002F50 RID: 12112 RVA: 0x0000BE1F File Offset: 0x0000A01F
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

		// Token: 0x17000E65 RID: 3685
		// (get) Token: 0x06002F51 RID: 12113 RVA: 0x0022E3D0 File Offset: 0x0022C5D0
		// (set) Token: 0x06002F52 RID: 12114 RVA: 0x0000BE29 File Offset: 0x0000A029
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

		// Token: 0x17000E66 RID: 3686
		// (get) Token: 0x06002F53 RID: 12115 RVA: 0x0022E3E8 File Offset: 0x0022C5E8
		// (set) Token: 0x06002F54 RID: 12116 RVA: 0x0022E400 File Offset: 0x0022C600
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

		// Token: 0x17000E67 RID: 3687
		// (get) Token: 0x06002F55 RID: 12117 RVA: 0x0022E460 File Offset: 0x0022C660
		// (set) Token: 0x06002F56 RID: 12118 RVA: 0x0000BE33 File Offset: 0x0000A033
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
				this._txt_ta_tarikh = value;
			}
		}

		// Token: 0x17000E68 RID: 3688
		// (get) Token: 0x06002F57 RID: 12119 RVA: 0x0022E478 File Offset: 0x0022C678
		// (set) Token: 0x06002F58 RID: 12120 RVA: 0x0022E490 File Offset: 0x0022C690
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

		// Token: 0x17000E69 RID: 3689
		// (get) Token: 0x06002F59 RID: 12121 RVA: 0x0022E4F0 File Offset: 0x0022C6F0
		// (set) Token: 0x06002F5A RID: 12122 RVA: 0x0000BE3D File Offset: 0x0000A03D
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

		// Token: 0x17000E6A RID: 3690
		// (get) Token: 0x06002F5B RID: 12123 RVA: 0x0022E508 File Offset: 0x0022C708
		// (set) Token: 0x06002F5C RID: 12124 RVA: 0x0022E520 File Offset: 0x0022C720
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

		// Token: 0x17000E6B RID: 3691
		// (get) Token: 0x06002F5D RID: 12125 RVA: 0x0022E580 File Offset: 0x0022C780
		// (set) Token: 0x06002F5E RID: 12126 RVA: 0x0000BE47 File Offset: 0x0000A047
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

		// Token: 0x17000E6C RID: 3692
		// (get) Token: 0x06002F5F RID: 12127 RVA: 0x0022E598 File Offset: 0x0022C798
		// (set) Token: 0x06002F60 RID: 12128 RVA: 0x0022E5B0 File Offset: 0x0022C7B0
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

		// Token: 0x17000E6D RID: 3693
		// (get) Token: 0x06002F61 RID: 12129 RVA: 0x0022E610 File Offset: 0x0022C810
		// (set) Token: 0x06002F62 RID: 12130 RVA: 0x0022E628 File Offset: 0x0022C828
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

		// Token: 0x17000E6E RID: 3694
		// (get) Token: 0x06002F63 RID: 12131 RVA: 0x0022E688 File Offset: 0x0022C888
		// (set) Token: 0x06002F64 RID: 12132 RVA: 0x0000BE51 File Offset: 0x0000A051
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

		// Token: 0x17000E6F RID: 3695
		// (get) Token: 0x06002F65 RID: 12133 RVA: 0x0022E6A0 File Offset: 0x0022C8A0
		// (set) Token: 0x06002F66 RID: 12134 RVA: 0x0022E6B8 File Offset: 0x0022C8B8
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

		// Token: 0x06002F67 RID: 12135 RVA: 0x0022E718 File Offset: 0x0022C918
		private void Timer1_Tick(object sender, EventArgs e)
		{
			this.Timer1.Enabled = false;
			bool flag = this.GridEX1.RowCount > 0;
			if (flag)
			{
				this.GridEX1.MoveLast();
			}
		}

		// Token: 0x06002F68 RID: 12136 RVA: 0x0022E754 File Offset: 0x0022C954
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

		// Token: 0x06002F69 RID: 12137 RVA: 0x0022E844 File Offset: 0x0022CA44
		private void FilterDate()
		{
			bool flag = this.GridEX1.DataSource == null;
			if (!flag)
			{
				flag = !this.UiCheckBox2.Checked;
				if (!flag)
				{
					DataTable dataTable = (DataTable)this.GridEX1.DataSource;
					DataRow dataRow = Public_Function.FillDataRow("    SELECT     NULL AS ID, ISNULL(SUM(Sanad.Bed), 0) AS Bed, ISNULL(SUM(Sanad.Bes), 0) AS Bes, MAX(Sanad.Tarikh) AS Tarikh, NULL AS Tarikh_Fa, '' AS Tozih  FROM         Sanad INNER JOIN Code_Hesab ON Sanad.CodeHesab_ID = Code_Hesab.ID  WHERE Code_Hesab.Grouh_ID=7 and sanad.tarikh<" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_az_tarikh.Text)));
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
					if (flag)
					{
						bool flag2 = dataTable.Rows[0]["ID"] == DBNull.Value;
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
					dataTable.DefaultView.RowFilter = string.Concat(new string[]
					{
						"tarikh >= '",
						Public_Function.ShamsiToMiladi(this.txt_az_tarikh.Text),
						"' AND tarikh<='",
						Public_Function.ShamsiToMiladi(this.txt_ta_tarikh.Text),
						"'"
					});
				}
			}
		}

		// Token: 0x06002F6A RID: 12138 RVA: 0x0022EA94 File Offset: 0x0022CC94
		private void txt_az_tarikh_KeyDown_1(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				this.FilterDate();
			}
		}

		// Token: 0x06002F6B RID: 12139 RVA: 0x0022EABC File Offset: 0x0022CCBC
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

		// Token: 0x06002F6C RID: 12140 RVA: 0x0022EAFC File Offset: 0x0022CCFC
		private void LoadData()
		{
			string text = string.Empty;
			string text2 = string.Empty;
			string text3 = string.Empty;
			bool flag = Operators.CompareString(this.txt_az_tarikh.Text, this.txt_ta_tarikh.Text, false) > 0;
			if (flag)
			{
				this.txt_ta_tarikh.Text = this.txt_az_tarikh.Text;
			}
			text = " tarikh >=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_az_tarikh.Text)) + " AND Tarikh <=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_ta_tarikh.Text));
			text2 = " sanad.tarikh >=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_az_tarikh.Text)) + " AND sanad.Tarikh <=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_ta_tarikh.Text));
			text3 = " khordefurushi.tarikh >=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_az_tarikh.Text)) + " AND khordefurushi.Tarikh <=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_ta_tarikh.Text));
			DataTable dataTable = Public_Function.FillData(string.Concat(new string[]
			{
				"SELECT    tarikh_fa,isnull(sum( KhordeFurushi_Detail.Jam_Kol),0) as kharid,0 as furush,isnull(sum(keraye),0) as hazine,1 as code FROM         KhordeFurushi INNER JOIN KhordeFurushi_Detail ON KhordeFurushi.ID = KhordeFurushi_Detail.Khordefurushi_id  where ",
				text,
				" group by Tarikh_fa   union all   select tarikh_fa,0 as kharid,isnull(sum(mablagh),0) as furush,0 as hazine,2 as code from daryaftpardakht where dptype_id=35 AND ",
				text,
				" group by Tarikh_fa   union all  select tarikh_fa,0 as kharid,0 as furush,sum(hazine) as hazine,3 as code from(  SELECT    tarikh_fa, isnull(sum(Bed),0)-isnull(sum(Bes),0) as hazine  FROM Sanad where CodeHesab_ID in (select id from code_hesab where grouh_ID=5)  AND ",
				text,
				" group by Tarikh_fa  union all   SELECT      sanad.tarikh_fa,isnull(sum(Sanad.Bed),0)-isnull(sum(Sanad.Bes),0) as hazine   FROM         DaryaftPardakht INNER JOIN Sanad ON DaryaftPardakht.SanadBed_ID = Sanad.ID    WHERE     (DaryaftPardakht.dpType_ID IN (15, 30)) AND (DaryaftPardakht.Moshtari_ID IS NOT NULL) AND ",
				text2,
				" group by sanad.Tarikh_fa  union all  SELECT   KhordeFurushi.tarikh_fa,sum(KhordeFurushi_Keraye.Keraye) as hazine FROM KhordeFurushi_Keraye INNER JOIN KhordeFurushi ON KhordeFurushi_Keraye.Khordefurushi_ID = KhordeFurushi.ID  where ",
				text3,
				" group by KhordeFurushi.tarikh_fa)t   group by tarikh_fa   order by tarikh_fa,code"
			}));
			dataTable.Columns.Add("sud", typeof(long));
			string right = string.Empty;
			int arg_1A4_0 = 0;
			checked
			{
				int num = dataTable.Rows.Count - 1;
				int num2 = arg_1A4_0;
				bool flag4;
				while (true)
				{
					int arg_4C8_0 = num2;
					int num3 = num;
					if (arg_4C8_0 > num3)
					{
						break;
					}
					flag = Operators.ConditionalCompareObjectNotEqual(dataTable.Rows[num2]["tarikh_fa"], right, false);
					if (flag)
					{
						right = Conversions.ToString(dataTable.Rows[num2]["tarikh_fa"]);
						object left = dataTable.Rows[num2]["code"];
						flag = Operators.ConditionalCompareObjectEqual(left, 1, false);
						if (flag)
						{
							bool flag2 = num2 + 1 <= dataTable.Rows.Count - 1;
							if (flag2)
							{
								bool flag3 = Operators.ConditionalCompareObjectEqual(dataTable.Rows[num2 + 1]["tarikh_fa"], right, false);
								if (flag3)
								{
									object left2 = dataTable.Rows[num2 + 1]["code"];
									flag4 = Operators.ConditionalCompareObjectEqual(left2, 2, false);
									if (flag4)
									{
										dataTable.Rows[num2]["furush"] = RuntimeHelpers.GetObjectValue(dataTable.Rows[num2 + 1]["furush"]);
									}
									else
									{
										flag4 = Operators.ConditionalCompareObjectEqual(left2, 3, false);
										if (flag4)
										{
											DataRow dataRow = dataTable.Rows[num2];
											DataRow arg_328_0 = dataRow;
											string columnName = "hazine";
											arg_328_0[columnName] = Operators.AddObject(dataRow[columnName], dataTable.Rows[num2 + 1]["hazine"]);
										}
									}
								}
							}
							flag4 = (num2 + 2 <= dataTable.Rows.Count - 1);
							if (flag4)
							{
								bool flag3 = Operators.ConditionalCompareObjectEqual(dataTable.Rows[num2 + 2]["tarikh_fa"], right, false);
								if (flag3)
								{
									DataRow dataRow = dataTable.Rows[num2];
									DataRow arg_3B4_0 = dataRow;
									string columnName = "hazine";
									arg_3B4_0[columnName] = Operators.AddObject(dataRow[columnName], dataTable.Rows[num2 + 2]["hazine"]);
								}
							}
						}
						else
						{
							flag4 = Operators.ConditionalCompareObjectEqual(left, 2, false);
							if (flag4)
							{
								dataTable.Rows[num2]["code"] = 1;
								flag4 = (num2 + 1 <= dataTable.Rows.Count - 1);
								if (flag4)
								{
									bool flag3 = Operators.ConditionalCompareObjectEqual(dataTable.Rows[num2 + 1]["tarikh_fa"], right, false);
									if (flag3)
									{
										DataRow dataRow = dataTable.Rows[num2];
										DataRow arg_47A_0 = dataRow;
										string columnName = "hazine";
										arg_47A_0[columnName] = Operators.AddObject(dataRow[columnName], dataTable.Rows[num2 + 1]["hazine"]);
									}
								}
							}
							else
							{
								flag4 = Operators.ConditionalCompareObjectEqual(left, 3, false);
								if (flag4)
								{
									dataTable.Rows[num2]["code"] = 1;
								}
							}
						}
					}
					num2++;
				}
				try
				{
					IEnumerator enumerator = dataTable.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow2 = (DataRow)enumerator.Current;
						dataRow2["sud"] = Operators.SubtractObject(dataRow2["furush"], Operators.AddObject(dataRow2["kharid"], dataRow2["hazine"]));
					}
				}
				finally
				{
					IEnumerator enumerator;
					flag4 = (enumerator is IDisposable);
					if (flag4)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				flag4 = (dataTable.Rows.Count > 0);
				if (flag4)
				{
					this.txt_az_tarikh.Text = Conversions.ToString(dataTable.Rows[0]["tarikh_fa"]);
					this.txt_ta_tarikh.Text = Conversions.ToString(dataTable.Rows[dataTable.Rows.Count - 1]["tarikh_fa"]);
				}
				else
				{
					this.txt_ta_tarikh.Text = this.txt_az_tarikh.Text;
				}
			}
		}

		// Token: 0x06002F6D RID: 12141 RVA: 0x0022F0FC File Offset: 0x0022D2FC
		private void Frm_SuratHesab_Moshtari_Load(object sender, EventArgs e)
		{
			this.txt_az_tarikh.SetNew();
			this.txt_ta_tarikh.SetNew();
			string text = Conversions.ToString(Public_Function.ExecuteScalar("select top 1 tarikh_Fa from [KhordeFurushi] order by tarikh "));
			bool flag = Operators.CompareString(text, string.Empty, false) != 0 && text != null;
			if (flag)
			{
				this.txt_az_tarikh.Text = text;
			}
			this.txt_ta_tarikh.Text = Public_Function.MiladiToShamsi(DateAndTime.Now);
			this.LoadData();
		}

		// Token: 0x06002F6E RID: 12142 RVA: 0x00128E48 File Offset: 0x00127048
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

		// Token: 0x06002F6F RID: 12143 RVA: 0x0022F17C File Offset: 0x0022D37C
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
			stiReport.Print(false);
		}

		// Token: 0x06002F70 RID: 12144 RVA: 0x0000BE5B File Offset: 0x0000A05B
		private void EditBox1_TextChanged(object sender, EventArgs e)
		{
			Public_Function.FilterGrid(this.GridEX1, this.EditBox1.Text);
		}

		// Token: 0x06002F71 RID: 12145 RVA: 0x0022F298 File Offset: 0x0022D498
		private void GridEX1_LoadingRow(object sender, RowLoadEventArgs e)
		{
			bool flag = e.Row.RowType == RowType.TotalRow;
			if (flag)
			{
				e.Row.Cells["mande"].Text = Public_Function.FormatPrice(this.mande);
			}
		}

		// Token: 0x04001259 RID: 4697
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x0400125B RID: 4699
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x0400125C RID: 4700
		[AccessedThroughProperty("UiGroupBox2")]
		private UIGroupBox _UiGroupBox2;

		// Token: 0x0400125D RID: 4701
		[AccessedThroughProperty("GridEX1")]
		private DataEntryGrid _GridEX1;

		// Token: 0x0400125E RID: 4702
		[AccessedThroughProperty("txt_ta_tarikh")]
		private DateBox2 _txt_ta_tarikh;

		// Token: 0x0400125F RID: 4703
		[AccessedThroughProperty("txt_az_tarikh")]
		private DateBox2 _txt_az_tarikh;

		// Token: 0x04001260 RID: 4704
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x04001261 RID: 4705
		[AccessedThroughProperty("UiCheckBox2")]
		private UICheckBox _UiCheckBox2;

		// Token: 0x04001262 RID: 4706
		[AccessedThroughProperty("Bar1")]
		private Bar _Bar1;

		// Token: 0x04001263 RID: 4707
		[AccessedThroughProperty("ButtonItem1")]
		private ButtonItem _ButtonItem1;

		// Token: 0x04001264 RID: 4708
		[AccessedThroughProperty("EditBox1")]
		private EditBox _EditBox1;

		// Token: 0x04001265 RID: 4709
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x04001266 RID: 4710
		[AccessedThroughProperty("Timer1")]
		private Timer _Timer1;

		// Token: 0x04001267 RID: 4711
		private string mande;
	}
}
