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
	// Token: 0x02000153 RID: 339
	[DesignerGenerated]
	public partial class Frm_SuratHesab_Takhlie : Form
	{
		// Token: 0x0600331B RID: 13083 RVA: 0x0000CD87 File Offset: 0x0000AF87
		[DebuggerNonUserCode]
		public Frm_SuratHesab_Takhlie()
		{
			base.KeyDown += new KeyEventHandler(this.Frm_SuratHesab_Hazine_KeyDown);
			base.Load += new EventHandler(this.Frm_SuratHesab_Moshtari_Load);
			Frm_SuratHesab_Takhlie.__ENCAddToList(this);
			this.InitializeComponent();
		}

		// Token: 0x0600331C RID: 13084 RVA: 0x00251150 File Offset: 0x0024F350
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_SuratHesab_Takhlie.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_SuratHesab_Takhlie.__ENCList.Count == Frm_SuratHesab_Takhlie.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_SuratHesab_Takhlie.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_SuratHesab_Takhlie.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_SuratHesab_Takhlie.__ENCList[num] = Frm_SuratHesab_Takhlie.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_SuratHesab_Takhlie.__ENCList.RemoveRange(num, Frm_SuratHesab_Takhlie.__ENCList.Count - num);
						Frm_SuratHesab_Takhlie.__ENCList.Capacity = Frm_SuratHesab_Takhlie.__ENCList.Count;
					}
					Frm_SuratHesab_Takhlie.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000FAC RID: 4012
		// (get) Token: 0x0600331F RID: 13087 RVA: 0x00252184 File Offset: 0x00250384
		// (set) Token: 0x06003320 RID: 13088 RVA: 0x0000CDC7 File Offset: 0x0000AFC7
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

		// Token: 0x17000FAD RID: 4013
		// (get) Token: 0x06003321 RID: 13089 RVA: 0x0025219C File Offset: 0x0025039C
		// (set) Token: 0x06003322 RID: 13090 RVA: 0x0000CDD1 File Offset: 0x0000AFD1
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

		// Token: 0x17000FAE RID: 4014
		// (get) Token: 0x06003323 RID: 13091 RVA: 0x002521B4 File Offset: 0x002503B4
		// (set) Token: 0x06003324 RID: 13092 RVA: 0x0000CDDB File Offset: 0x0000AFDB
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

		// Token: 0x17000FAF RID: 4015
		// (get) Token: 0x06003325 RID: 13093 RVA: 0x002521CC File Offset: 0x002503CC
		// (set) Token: 0x06003326 RID: 13094 RVA: 0x002521E4 File Offset: 0x002503E4
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

		// Token: 0x17000FB0 RID: 4016
		// (get) Token: 0x06003327 RID: 13095 RVA: 0x00252244 File Offset: 0x00250444
		// (set) Token: 0x06003328 RID: 13096 RVA: 0x0025225C File Offset: 0x0025045C
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

		// Token: 0x17000FB1 RID: 4017
		// (get) Token: 0x06003329 RID: 13097 RVA: 0x002522BC File Offset: 0x002504BC
		// (set) Token: 0x0600332A RID: 13098 RVA: 0x0000CDE5 File Offset: 0x0000AFE5
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

		// Token: 0x17000FB2 RID: 4018
		// (get) Token: 0x0600332B RID: 13099 RVA: 0x002522D4 File Offset: 0x002504D4
		// (set) Token: 0x0600332C RID: 13100 RVA: 0x002522EC File Offset: 0x002504EC
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

		// Token: 0x17000FB3 RID: 4019
		// (get) Token: 0x0600332D RID: 13101 RVA: 0x0025234C File Offset: 0x0025054C
		// (set) Token: 0x0600332E RID: 13102 RVA: 0x0000CDEF File Offset: 0x0000AFEF
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

		// Token: 0x17000FB4 RID: 4020
		// (get) Token: 0x0600332F RID: 13103 RVA: 0x00252364 File Offset: 0x00250564
		// (set) Token: 0x06003330 RID: 13104 RVA: 0x0025237C File Offset: 0x0025057C
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

		// Token: 0x17000FB5 RID: 4021
		// (get) Token: 0x06003331 RID: 13105 RVA: 0x002523DC File Offset: 0x002505DC
		// (set) Token: 0x06003332 RID: 13106 RVA: 0x002523F4 File Offset: 0x002505F4
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

		// Token: 0x17000FB6 RID: 4022
		// (get) Token: 0x06003333 RID: 13107 RVA: 0x00252454 File Offset: 0x00250654
		// (set) Token: 0x06003334 RID: 13108 RVA: 0x0000CDF9 File Offset: 0x0000AFF9
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

		// Token: 0x17000FB7 RID: 4023
		// (get) Token: 0x06003335 RID: 13109 RVA: 0x0025246C File Offset: 0x0025066C
		// (set) Token: 0x06003336 RID: 13110 RVA: 0x00252484 File Offset: 0x00250684
		internal virtual SelectItem SelectItem1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._SelectItem1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				SelectItem.ValueDeletedEventHandler obj = new SelectItem.ValueDeletedEventHandler(this.SelectItem1_ValueDeleted);
				SelectItem.SelectedValueChangedEventHandler obj2 = new SelectItem.SelectedValueChangedEventHandler(this.SelectItem1_SelectedValueChanged);
				bool flag = this._SelectItem1 != null;
				if (flag)
				{
					this._SelectItem1.ValueDeleted -= obj;
					this._SelectItem1.SelectedValueChanged -= obj2;
				}
				this._SelectItem1 = value;
				flag = (this._SelectItem1 != null);
				if (flag)
				{
					this._SelectItem1.ValueDeleted += obj;
					this._SelectItem1.SelectedValueChanged += obj2;
				}
			}
		}

		// Token: 0x17000FB8 RID: 4024
		// (get) Token: 0x06003337 RID: 13111 RVA: 0x0025250C File Offset: 0x0025070C
		// (set) Token: 0x06003338 RID: 13112 RVA: 0x0000CE03 File Offset: 0x0000B003
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

		// Token: 0x17000FB9 RID: 4025
		// (get) Token: 0x06003339 RID: 13113 RVA: 0x00252524 File Offset: 0x00250724
		// (set) Token: 0x0600333A RID: 13114 RVA: 0x0025253C File Offset: 0x0025073C
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

		// Token: 0x17000FBA RID: 4026
		// (get) Token: 0x0600333B RID: 13115 RVA: 0x0025259C File Offset: 0x0025079C
		// (set) Token: 0x0600333C RID: 13116 RVA: 0x0000CE0D File Offset: 0x0000B00D
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

		// Token: 0x17000FBB RID: 4027
		// (get) Token: 0x0600333D RID: 13117 RVA: 0x002525B4 File Offset: 0x002507B4
		// (set) Token: 0x0600333E RID: 13118 RVA: 0x0000CE17 File Offset: 0x0000B017
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

		// Token: 0x0600333F RID: 13119 RVA: 0x002525CC File Offset: 0x002507CC
		private void LoadData()
		{
			long num = 0L;
			List<string> list = new List<string>();
			List<string> list2 = new List<string>();
			List<string> list3 = new List<string>();
			bool flag = this.SelectItem1.Value != null;
			if (flag)
			{
				list.Add(Conversions.ToString(Operators.ConcatenateObject(" Furush_Keraye.HazineKharid_ID= ", this.SelectItem1.Value)));
				list2.Add(Conversions.ToString(Operators.ConcatenateObject(" Kharid_Keraye.HazineKharid_ID=", this.SelectItem1.Value)));
				list3.Add(Conversions.ToString(Operators.ConcatenateObject(" ersalbar_keraye.HazineKharid_ID= ", this.SelectItem1.Value)));
			}
			flag = this.UiCheckBox2.Checked;
			checked
			{
				if (flag)
				{
					num = Conversions.ToLong(Public_Function.ExecuteScalar("SELECT    isnull(sum( Keraye),0)  FROM Furush_Keraye   where Furush_Keraye.tarikh < " + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_az_tarikh.Text)) + Public_Function.BuildWhere(list, Public_Function.OperandType.AND_)));
					long num2 = Conversions.ToLong(Public_Function.ExecuteScalar("SELECT   isnull( sum( Keraye),0)   FROM kharid_Keraye  where kharid_Keraye.tarikh <" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_az_tarikh.Text)) + Public_Function.BuildWhere(list2, Public_Function.OperandType.AND_)));
					long num3 = Conversions.ToLong(Public_Function.ExecuteScalar("SELECT   isnull( sum( Keraye),0)   FROM Ersalbar_Keraye  where Ersalbar_Keraye.tarikh <" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_az_tarikh.Text)) + Public_Function.BuildWhere(list3, Public_Function.OperandType.AND_)));
					num += num2 + num3;
				}
				flag = this.UiCheckBox2.Checked;
				if (flag)
				{
					list.Add("Furush_Keraye.tarikh >= " + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_az_tarikh.Text)) + " AND Furush_Keraye.tarikh<=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_ta_tarikh.Text)));
					list2.Add("Kharid_Keraye.tarikh >= " + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_az_tarikh.Text)) + " AND Kharid_Keraye.tarikh<=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_ta_tarikh.Text)));
					list3.Add("Ersalbar_keraye.tarikh >= " + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_az_tarikh.Text)) + " AND Ersalbar_keraye.tarikh<=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_ta_tarikh.Text)));
				}
				DataTable dataTable = Public_Function.FillData(string.Concat(new string[]
				{
					"select * from (SELECT     Furush_Keraye.ID, Furush_Keraye.Keraye AS mablagh, Furush_Keraye.Tarikh, Furush_Keraye.Tarikh_Fa,'فروش / '+cast (Furush_Hag.Num as nvarchar(10)) as num,   Moshtari.Name + ' ' + Moshtari.Family AS Moshtari_Name, Hazine_Kharid.Name AS Hazine_Name, Furush_Keraye.HazineKharid_ID  FROM         Furush_Keraye INNER JOIN  Furush_Hag ON Furush_Keraye.Furush_ID = Furush_Hag.ID INNER JOIN  Moshtari ON Furush_Hag.Moshtari_ID = Moshtari.ID INNER JOIN  Hazine_Kharid ON Furush_Keraye.HazineKharid_ID = Hazine_Kharid.ID ",
					Public_Function.BuildWhere(list, Public_Function.OperandType.where),
					" union all  SELECT     Kharid_Keraye.ID, Kharid_Keraye.Keraye AS Mablagh, Kharid_Keraye.Tarikh, Kharid_Keraye.Tarikh_Fa,'خرید / ' + cast( Kharid.Num as nvarchar(10)) as num,   Moshtari.Name + ' ' + Moshtari.Family AS Moshtari_Name, Hazine_Kharid.Name AS Hazine_Name, Kharid_Keraye.HazineKharid_ID   FROM         Kharid_Keraye INNER JOIN  Hazine_Kharid ON Kharid_Keraye.HazineKharid_ID = Hazine_Kharid.ID INNER JOIN  Kharid ON Kharid_Keraye.Kharid_ID = Kharid.ID INNER JOIN  Moshtari ON Kharid.Moshtari_ID = Moshtari.ID ",
					Public_Function.BuildWhere(list2, Public_Function.OperandType.where),
					"union all   SELECT     ErsalBar_Keraye.ID, ErsalBar_Keraye.Keraye AS Mablagh, ErsalBar_Keraye.Tarikh, ErsalBar_Keraye.Tarikh_Fa,'ارسال بار / ' + cast( Ersalbar.Num as nvarchar(10)) as num ,  Moshtari.Name + ' ' + Moshtari.Family AS Moshtari_Name, Hazine_Kharid.Name AS Hazine_Name, ErsalBar_Keraye.HazineKharid_ID  FROM         ErsalBar INNER JOIN  Moshtari ON ErsalBar.Moshtari_ID = Moshtari.ID INNER JOIN  ErsalBar_Keraye ON ErsalBar.ID = ErsalBar_Keraye.ErsalBar_ID INNER JOIN  Hazine_Kharid ON ErsalBar_Keraye.HazineKharid_ID = Hazine_Kharid.ID",
					Public_Function.BuildWhere(list3, Public_Function.OperandType.where),
					" )t  ORDER BY  Tarikh,num"
				}));
				flag = (dataTable.Rows.Count > 0);
				bool flag2;
				if (flag)
				{
					flag2 = Operators.ConditionalCompareObjectEqual(dataTable.Rows[0]["Tarikh_Fa"], "مانده از قبل", false);
					if (flag2)
					{
						dataTable.Rows[0].Delete();
					}
				}
				flag2 = (num != 0L);
				if (flag2)
				{
					DataRow dataRow = dataTable.NewRow();
					dataRow["mablagh"] = num;
					dataRow["Tarikh_Fa"] = "مانده از قبل";
					dataRow["tarikh"] = Public_Function.ShamsiToMiladi(this.txt_az_tarikh.Text);
					flag2 = Conversions.ToBoolean(this.SelectItem1.Value);
					if (flag2)
					{
						dataRow["hazineKharid_id"] = RuntimeHelpers.GetObjectValue(this.SelectItem1.Value);
					}
					dataTable.Rows.InsertAt(dataRow, 0);
				}
				this.GridEX1.DataSource = dataTable;
				Public_Function.AddFilterColumn(this.GridEX1);
				this.EditBox1.Focus();
			}
		}

		// Token: 0x06003340 RID: 13120 RVA: 0x0025296C File Offset: 0x00250B6C
		private void txt_az_tarikh_KeyDown_1(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				this.LoadData();
			}
		}

		// Token: 0x06003341 RID: 13121 RVA: 0x00252994 File Offset: 0x00250B94
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
						this.LoadData();
					}
				}
			}
		}

		// Token: 0x06003342 RID: 13122 RVA: 0x00252A40 File Offset: 0x00250C40
		private void Frm_SuratHesab_Hazine_KeyDown(object sender, KeyEventArgs e)
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

		// Token: 0x06003343 RID: 13123 RVA: 0x0000CE21 File Offset: 0x0000B021
		private void Frm_SuratHesab_Moshtari_Load(object sender, EventArgs e)
		{
			this.txt_az_tarikh.SetNew();
			this.txt_ta_tarikh.SetNew();
			this.LoadData();
		}

		// Token: 0x06003344 RID: 13124 RVA: 0x0023C91C File Offset: 0x0023AB1C
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
				stiText.Text = Public_Function.ToFarsi(Public_Function.MiladiToShamsi(DateAndTime.Now)).ToString();
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

		// Token: 0x06003345 RID: 13125 RVA: 0x00252A80 File Offset: 0x00250C80
		private void ButtonItem1_Click(object sender, EventArgs e)
		{
			StiReport stiReport = new StiReport();
			stiReport.Load(Application.StartupPath + "\\reports\\surathesabkeraye.mrt");
			DataTable dataTable = (DataTable)this.GridEX1.DataSource;
			DataTable dataTable2 = dataTable.Copy();
			dataTable2.TableName = "data";
			dataTable2.DefaultView.RowFilter = dataTable.DefaultView.RowFilter;
			stiReport.RegData(dataTable2.DefaultView);
			this.SetHeader(stiReport);
			StiText stiText = new StiText();
			stiText = (StiText)stiReport.GetComponentByName("Text2");
			string text = "صورتحساب ";
			bool flag = Operators.CompareString(this.SelectItem1.Text, string.Empty, false) != 0;
			if (flag)
			{
				text = text + this.SelectItem1.Text + " ";
			}
			else
			{
				text += "کرایه و مخارج ";
			}
			flag = this.UiCheckBox2.Checked;
			if (flag)
			{
				text = string.Concat(new string[]
				{
					text,
					"از تاریخ ",
					this.txt_az_tarikh.Text,
					" تا تاریخ ",
					this.txt_ta_tarikh.Text
				});
			}
			stiText.Text.Value = Public_Function.ToFarsi(text);
			Public_Function.AddTazminText(stiReport, true, false);
			Public_Function.setReportFont(stiReport, "Text10,Text11,Text13,Text14,Text8");
			Public_Function.SetReport_MarginTop(stiReport);
			stiReport.Print(false);
		}

		// Token: 0x06003346 RID: 13126 RVA: 0x0000CE44 File Offset: 0x0000B044
		private void EditBox1_TextChanged(object sender, EventArgs e)
		{
			Public_Function.FilterGrid(this.GridEX1, this.EditBox1.Text);
		}

		// Token: 0x06003347 RID: 13127 RVA: 0x0000CE5F File Offset: 0x0000B05F
		private void SelectItem1_SelectedValueChanged(object sender, EventArgs e)
		{
			this.LoadData();
		}

		// Token: 0x06003348 RID: 13128 RVA: 0x0000CE5F File Offset: 0x0000B05F
		private void SelectItem1_ValueDeleted(object sender, EventArgs e)
		{
			this.LoadData();
		}

		// Token: 0x06003349 RID: 13129 RVA: 0x0000CE6A File Offset: 0x0000B06A
		private void Timer1_Tick(object sender, EventArgs e)
		{
			this.Timer1.Enabled = false;
			this.GridEX1.MoveLast();
		}

		// Token: 0x040013D5 RID: 5077
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x040013D7 RID: 5079
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x040013D8 RID: 5080
		[AccessedThroughProperty("UiGroupBox2")]
		private UIGroupBox _UiGroupBox2;

		// Token: 0x040013D9 RID: 5081
		[AccessedThroughProperty("GridEX1")]
		private DataEntryGrid _GridEX1;

		// Token: 0x040013DA RID: 5082
		[AccessedThroughProperty("txt_ta_tarikh")]
		private DateBox2 _txt_ta_tarikh;

		// Token: 0x040013DB RID: 5083
		[AccessedThroughProperty("txt_az_tarikh")]
		private DateBox2 _txt_az_tarikh;

		// Token: 0x040013DC RID: 5084
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x040013DD RID: 5085
		[AccessedThroughProperty("UiCheckBox2")]
		private UICheckBox _UiCheckBox2;

		// Token: 0x040013DE RID: 5086
		[AccessedThroughProperty("Bar1")]
		private Bar _Bar1;

		// Token: 0x040013DF RID: 5087
		[AccessedThroughProperty("ButtonItem1")]
		private ButtonItem _ButtonItem1;

		// Token: 0x040013E0 RID: 5088
		[AccessedThroughProperty("EditBox1")]
		private EditBox _EditBox1;

		// Token: 0x040013E1 RID: 5089
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x040013E2 RID: 5090
		[AccessedThroughProperty("SelectItem1")]
		private SelectItem _SelectItem1;

		// Token: 0x040013E3 RID: 5091
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x040013E4 RID: 5092
		[AccessedThroughProperty("Timer1")]
		private Timer _Timer1;

		// Token: 0x040013E5 RID: 5093
		[CompilerGenerated]
		private int? _BankHesab_ID;

		// Token: 0x040013E6 RID: 5094
		[CompilerGenerated]
		private string _BankHesab_Name;
	}
}
