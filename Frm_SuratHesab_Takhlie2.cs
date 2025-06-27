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
	// Token: 0x02000154 RID: 340
	[DesignerGenerated]
	public partial class Frm_SuratHesab_Takhlie2 : Form
	{
		// Token: 0x0600334B RID: 13131 RVA: 0x0000CE94 File Offset: 0x0000B094
		[DebuggerNonUserCode]
		public Frm_SuratHesab_Takhlie2()
		{
			base.Load += new EventHandler(this.Frm_SuratHesab_Moshtari_Load);
			base.KeyDown += new KeyEventHandler(this.Frm_SuratHesab_Hazine_KeyDown);
			Frm_SuratHesab_Takhlie2.__ENCAddToList(this);
			this.InitializeComponent();
		}

		// Token: 0x0600334C RID: 13132 RVA: 0x00252BF8 File Offset: 0x00250DF8
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_SuratHesab_Takhlie2.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_SuratHesab_Takhlie2.__ENCList.Count == Frm_SuratHesab_Takhlie2.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_SuratHesab_Takhlie2.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_SuratHesab_Takhlie2.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_SuratHesab_Takhlie2.__ENCList[num] = Frm_SuratHesab_Takhlie2.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_SuratHesab_Takhlie2.__ENCList.RemoveRange(num, Frm_SuratHesab_Takhlie2.__ENCList.Count - num);
						Frm_SuratHesab_Takhlie2.__ENCList.Capacity = Frm_SuratHesab_Takhlie2.__ENCList.Count;
					}
					Frm_SuratHesab_Takhlie2.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000FBC RID: 4028
		// (get) Token: 0x0600334F RID: 13135 RVA: 0x00253C9C File Offset: 0x00251E9C
		// (set) Token: 0x06003350 RID: 13136 RVA: 0x0000CED4 File Offset: 0x0000B0D4
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

		// Token: 0x17000FBD RID: 4029
		// (get) Token: 0x06003351 RID: 13137 RVA: 0x00253CB4 File Offset: 0x00251EB4
		// (set) Token: 0x06003352 RID: 13138 RVA: 0x0000CEDE File Offset: 0x0000B0DE
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

		// Token: 0x17000FBE RID: 4030
		// (get) Token: 0x06003353 RID: 13139 RVA: 0x00253CCC File Offset: 0x00251ECC
		// (set) Token: 0x06003354 RID: 13140 RVA: 0x0000CEE8 File Offset: 0x0000B0E8
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

		// Token: 0x17000FBF RID: 4031
		// (get) Token: 0x06003355 RID: 13141 RVA: 0x00253CE4 File Offset: 0x00251EE4
		// (set) Token: 0x06003356 RID: 13142 RVA: 0x00253CFC File Offset: 0x00251EFC
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

		// Token: 0x17000FC0 RID: 4032
		// (get) Token: 0x06003357 RID: 13143 RVA: 0x00253D5C File Offset: 0x00251F5C
		// (set) Token: 0x06003358 RID: 13144 RVA: 0x00253D74 File Offset: 0x00251F74
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

		// Token: 0x17000FC1 RID: 4033
		// (get) Token: 0x06003359 RID: 13145 RVA: 0x00253DD4 File Offset: 0x00251FD4
		// (set) Token: 0x0600335A RID: 13146 RVA: 0x0000CEF2 File Offset: 0x0000B0F2
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

		// Token: 0x17000FC2 RID: 4034
		// (get) Token: 0x0600335B RID: 13147 RVA: 0x00253DEC File Offset: 0x00251FEC
		// (set) Token: 0x0600335C RID: 13148 RVA: 0x00253E04 File Offset: 0x00252004
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

		// Token: 0x17000FC3 RID: 4035
		// (get) Token: 0x0600335D RID: 13149 RVA: 0x00253E64 File Offset: 0x00252064
		// (set) Token: 0x0600335E RID: 13150 RVA: 0x0000CEFC File Offset: 0x0000B0FC
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

		// Token: 0x17000FC4 RID: 4036
		// (get) Token: 0x0600335F RID: 13151 RVA: 0x00253E7C File Offset: 0x0025207C
		// (set) Token: 0x06003360 RID: 13152 RVA: 0x00253E94 File Offset: 0x00252094
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

		// Token: 0x17000FC5 RID: 4037
		// (get) Token: 0x06003361 RID: 13153 RVA: 0x00253EF4 File Offset: 0x002520F4
		// (set) Token: 0x06003362 RID: 13154 RVA: 0x00253F0C File Offset: 0x0025210C
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

		// Token: 0x17000FC6 RID: 4038
		// (get) Token: 0x06003363 RID: 13155 RVA: 0x00253F6C File Offset: 0x0025216C
		// (set) Token: 0x06003364 RID: 13156 RVA: 0x0000CF06 File Offset: 0x0000B106
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

		// Token: 0x17000FC7 RID: 4039
		// (get) Token: 0x06003365 RID: 13157 RVA: 0x00253F84 File Offset: 0x00252184
		// (set) Token: 0x06003366 RID: 13158 RVA: 0x00253F9C File Offset: 0x0025219C
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
				SelectItem.SelectedValueChangedEventHandler obj = new SelectItem.SelectedValueChangedEventHandler(this.SelectItem1_SelectedValueChanged);
				SelectItem.ValueDeletedEventHandler obj2 = new SelectItem.ValueDeletedEventHandler(this.SelectItem1_ValueDeleted);
				bool flag = this._SelectItem1 != null;
				if (flag)
				{
					this._SelectItem1.SelectedValueChanged -= obj;
					this._SelectItem1.ValueDeleted -= obj2;
				}
				this._SelectItem1 = value;
				flag = (this._SelectItem1 != null);
				if (flag)
				{
					this._SelectItem1.SelectedValueChanged += obj;
					this._SelectItem1.ValueDeleted += obj2;
				}
			}
		}

		// Token: 0x17000FC8 RID: 4040
		// (get) Token: 0x06003367 RID: 13159 RVA: 0x00254024 File Offset: 0x00252224
		// (set) Token: 0x06003368 RID: 13160 RVA: 0x0000CF10 File Offset: 0x0000B110
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

		// Token: 0x17000FC9 RID: 4041
		// (get) Token: 0x06003369 RID: 13161 RVA: 0x0025403C File Offset: 0x0025223C
		// (set) Token: 0x0600336A RID: 13162 RVA: 0x00254054 File Offset: 0x00252254
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

		// Token: 0x17000FCA RID: 4042
		// (get) Token: 0x0600336B RID: 13163 RVA: 0x002540B4 File Offset: 0x002522B4
		// (set) Token: 0x0600336C RID: 13164 RVA: 0x002540CC File Offset: 0x002522CC
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

		// Token: 0x17000FCB RID: 4043
		// (get) Token: 0x0600336D RID: 13165 RVA: 0x0025412C File Offset: 0x0025232C
		// (set) Token: 0x0600336E RID: 13166 RVA: 0x0000CF1A File Offset: 0x0000B11A
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

		// Token: 0x17000FCC RID: 4044
		// (get) Token: 0x0600336F RID: 13167 RVA: 0x00254144 File Offset: 0x00252344
		// (set) Token: 0x06003370 RID: 13168 RVA: 0x0000CF24 File Offset: 0x0000B124
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

		// Token: 0x06003371 RID: 13169 RVA: 0x0025415C File Offset: 0x0025235C
		private void LoadData()
		{
			long num = 0L;
			List<string> list = new List<string>();
			List<string> list2 = new List<string>();
			List<string> list3 = new List<string>();
			List<string> list4 = new List<string>();
			list.Add(" Furush_Keraye.HazineKharid_ID=-5 ");
			list2.Add(" Kharid_Keraye.HazineKharid_ID=-5");
			list3.Add(" ersalbar_keraye.HazineKharid_ID=-5 ");
			list4.Add("codehesab_id=18 and bed>0");
			bool flag = this.UiCheckBox2.Checked;
			checked
			{
				if (flag)
				{
					num = Conversions.ToLong(Public_Function.ExecuteScalar("SELECT    isnull(sum( Keraye),0)  FROM Furush_Keraye   where Furush_Keraye.tarikh < " + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_az_tarikh.Text)) + Public_Function.BuildWhere(list, Public_Function.OperandType.AND_)));
					long num2 = Conversions.ToLong(Public_Function.ExecuteScalar("SELECT   isnull( sum( Keraye),0)   FROM kharid_Keraye  where kharid_Keraye.tarikh <" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_az_tarikh.Text)) + Public_Function.BuildWhere(list2, Public_Function.OperandType.AND_)));
					long num3 = Conversions.ToLong(Public_Function.ExecuteScalar("SELECT   isnull( sum( Keraye),0)   FROM Ersalbar_Keraye  where Ersalbar_Keraye.tarikh <" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_az_tarikh.Text)) + Public_Function.BuildWhere(list3, Public_Function.OperandType.AND_)));
					long num4 = Conversions.ToLong(Public_Function.ExecuteScalar("select isnull(sum(bed),0) from sanad " + Public_Function.BuildWhere(list4, Public_Function.OperandType.where) + " AND sanad.tarikh<" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_az_tarikh.Text))));
					num += num2 + num3 - num4;
					list.Add("Furush_Keraye.tarikh >= " + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_az_tarikh.Text)) + " AND Furush_Keraye.tarikh<=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_ta_tarikh.Text)));
					list2.Add("Kharid_Keraye.tarikh >= " + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_az_tarikh.Text)) + " AND Kharid_Keraye.tarikh<=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_ta_tarikh.Text)));
					list3.Add("Ersalbar_keraye.tarikh >= " + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_az_tarikh.Text)) + " AND Ersalbar_keraye.tarikh<=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_ta_tarikh.Text)));
					list4.Add("sanad.tarikh>=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_az_tarikh.Text)) + " AND sanad.tarikh<=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_ta_tarikh.Text)));
				}
				long num5 = Conversions.ToLong(Public_Function.ExecuteScalar("select isnull(bes,0) from sanad where codehesab_id=18 and bes>0 and tarikh=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi("1392/01/01"))));
				DataTable dataTable = Public_Function.FillData(string.Concat(new string[]
				{
					"select * from (SELECT     Furush_Keraye.ID, Furush_Keraye.Keraye AS mablagh, Furush_Keraye.Tarikh, Furush_Keraye.Tarikh_Fa,'فروش / '+cast (Furush_Hag.Num as nvarchar(10)) as num,   Moshtari.Name + ' ' + Moshtari.Family AS Moshtari_Name, Hazine_Kharid.Name AS Hazine_Name, Furush_Keraye.HazineKharid_ID  FROM         Furush_Keraye INNER JOIN  Furush_Hag ON Furush_Keraye.Furush_ID = Furush_Hag.ID INNER JOIN  Moshtari ON Furush_Hag.Moshtari_ID = Moshtari.ID INNER JOIN  Hazine_Kharid ON Furush_Keraye.HazineKharid_ID = Hazine_Kharid.ID ",
					Public_Function.BuildWhere(list, Public_Function.OperandType.where),
					" union all  SELECT     Kharid_Keraye.ID, Kharid_Keraye.Keraye AS Mablagh, Kharid_Keraye.Tarikh, Kharid_Keraye.Tarikh_Fa,'خرید / ' + cast( Kharid.Num as nvarchar(10)) as num,   Moshtari.Name + ' ' + Moshtari.Family AS Moshtari_Name, Hazine_Kharid.Name AS Hazine_Name, Kharid_Keraye.HazineKharid_ID   FROM         Kharid_Keraye INNER JOIN  Hazine_Kharid ON Kharid_Keraye.HazineKharid_ID = Hazine_Kharid.ID INNER JOIN  Kharid ON Kharid_Keraye.Kharid_ID = Kharid.ID INNER JOIN  Moshtari ON Kharid.Moshtari_ID = Moshtari.ID ",
					Public_Function.BuildWhere(list2, Public_Function.OperandType.where),
					"union all   SELECT     ErsalBar_Keraye.ID, ErsalBar_Keraye.Keraye AS Mablagh, ErsalBar_Keraye.Tarikh, ErsalBar_Keraye.Tarikh_Fa,'ارسال بار / ' + cast( Ersalbar.Num as nvarchar(10)) as num ,  Moshtari.Name + ' ' + Moshtari.Family AS Moshtari_Name, Hazine_Kharid.Name AS Hazine_Name, ErsalBar_Keraye.HazineKharid_ID  FROM         ErsalBar INNER JOIN  Moshtari ON ErsalBar.Moshtari_ID = Moshtari.ID INNER JOIN  ErsalBar_Keraye ON ErsalBar.ID = ErsalBar_Keraye.ErsalBar_ID INNER JOIN  Hazine_Kharid ON ErsalBar_Keraye.HazineKharid_ID = Hazine_Kharid.ID",
					Public_Function.BuildWhere(list3, Public_Function.OperandType.where),
					" union all select sanad.id,-1 * sanad.bed as mablagh,sanad.tarikh,sanad.tarikh_fa,'' as num,tozih as moshtari_name,'' as hazine_name,18 as hazinekharid_id from sanad",
					Public_Function.BuildWhere(list4, Public_Function.OperandType.where),
					" )t  ORDER BY  Tarikh,num"
				}));
				long num6 = Conversions.ToLong(Public_Function.ExecuteScalar("select isnull(SUM(bed),0) from Sanad where codehesab_id=36 and Sanad.Bes>0"));
				flag = (num6 > 0L);
				if (flag)
				{
					DataRow dataRow = dataTable.NewRow();
					dataRow["mablagh"] = -1L * num6;
					dataRow["num"] = "انتقال به درآمد";
					dataTable.Rows.Add(dataRow);
				}
				flag = (num != 0L);
				if (flag)
				{
					DataRow dataRow2 = dataTable.NewRow();
					dataRow2["mablagh"] = num;
					dataRow2["Tarikh_Fa"] = "مانده از قبل";
					dataRow2["tarikh"] = Public_Function.ShamsiToMiladi(this.txt_az_tarikh.Text);
					flag = Conversions.ToBoolean(this.SelectItem1.Value);
					if (flag)
					{
						dataRow2["hazineKharid_id"] = RuntimeHelpers.GetObjectValue(this.SelectItem1.Value);
					}
					dataTable.Rows.InsertAt(dataRow2, 0);
				}
				flag = (num5 != 0L);
				if (flag)
				{
					DataRow dataRow3 = dataTable.NewRow();
					dataRow3["mablagh"] = num5;
					dataRow3["Tarikh_Fa"] = "اول دوره";
					dataRow3["tarikh"] = "1392/01/01";
					dataTable.Rows.InsertAt(dataRow3, 0);
				}
				this.GridEX1.DataSource = dataTable;
				Public_Function.AddFilterColumn(this.GridEX1);
				this.EditBox1.Focus();
			}
		}

		// Token: 0x06003372 RID: 13170 RVA: 0x002545D0 File Offset: 0x002527D0
		private void txt_az_tarikh_KeyDown_1(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				this.LoadData();
			}
		}

		// Token: 0x06003373 RID: 13171 RVA: 0x002545F8 File Offset: 0x002527F8
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

		// Token: 0x06003374 RID: 13172 RVA: 0x002546A4 File Offset: 0x002528A4
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

		// Token: 0x06003375 RID: 13173 RVA: 0x0000CF2E File Offset: 0x0000B12E
		private void Frm_SuratHesab_Moshtari_Load(object sender, EventArgs e)
		{
			this.txt_az_tarikh.SetNew();
			this.txt_ta_tarikh.SetNew();
			this.LoadData();
		}

		// Token: 0x06003376 RID: 13174 RVA: 0x0023C91C File Offset: 0x0023AB1C
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

		// Token: 0x06003377 RID: 13175 RVA: 0x002546E4 File Offset: 0x002528E4
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
			Public_Function.SetReport_MarginTop(stiReport);
			Public_Function.AddTazminText(stiReport, true, false);
			stiReport.Print(false);
		}

		// Token: 0x06003378 RID: 13176 RVA: 0x0000CF51 File Offset: 0x0000B151
		private void EditBox1_TextChanged(object sender, EventArgs e)
		{
			Public_Function.FilterGrid(this.GridEX1, this.EditBox1.Text);
		}

		// Token: 0x06003379 RID: 13177 RVA: 0x0000CF6C File Offset: 0x0000B16C
		private void SelectItem1_SelectedValueChanged(object sender, EventArgs e)
		{
			this.LoadData();
		}

		// Token: 0x0600337A RID: 13178 RVA: 0x0000CF6C File Offset: 0x0000B16C
		private void SelectItem1_ValueDeleted(object sender, EventArgs e)
		{
			this.LoadData();
		}

		// Token: 0x0600337B RID: 13179 RVA: 0x0000CF77 File Offset: 0x0000B177
		private void Timer1_Tick(object sender, EventArgs e)
		{
			this.Timer1.Enabled = false;
			this.GridEX1.MoveLast();
		}

		// Token: 0x0600337C RID: 13180 RVA: 0x00254850 File Offset: 0x00252A50
		private void ButtonItem2_Click(object sender, EventArgs e)
		{
			bool flag = this.GridEX1.DataSource == null;
			checked
			{
				if (!flag)
				{
					flag = (Public_Function.ShowMessage("آیا مایل به انتقال جمع تخلیه به درآمد میباشید؟", MessageBoxButtons.YesNo, MessageBoxIcon.Question, null) == DialogResult.No);
					if (!flag)
					{
						object arg_91_0 = null;
						Type arg_91_1 = typeof(Public_Function);
						string arg_91_2 = "GetSum";
						object[] array = new object[2];
						object[] arg_69_0 = array;
						int arg_69_1 = 0;
						DataEntryGrid gridEX = this.GridEX1;
						arg_69_0[arg_69_1] = RuntimeHelpers.GetObjectValue(gridEX.DataSource);
						array[1] = "mablagh";
						object[] array2 = array;
						object[] arg_91_3 = array2;
						string[] arg_91_4 = null;
						Type[] arg_91_5 = null;
						bool[] array3 = new bool[]
						{
							true,
							false
						};
						object arg_AD_0 = NewLateBinding.LateGet(arg_91_0, arg_91_1, arg_91_2, arg_91_3, arg_91_4, arg_91_5, array3);
						if (array3[0])
						{
							gridEX.DataSource = RuntimeHelpers.GetObjectValue(array2[0]);
						}
						long num = Conversions.ToLong(arg_AD_0);
						flag = (num > 0L);
						if (flag)
						{
							string text = string.Empty;
							Sanad sanad = new Sanad();
							text += sanad.InsertStr("18", num.ToString(), "0", Public_Function.MiladiToShamsi(DateAndTime.Now), "انتقال به درآمد", "", Sanad.SanadType.@null);
							text += sanad.InsertStr("36", "0", num.ToString(), Public_Function.MiladiToShamsi(DateAndTime.Now), "درآمد تخلیه", "", Sanad.SanadType.@null);
							Public_Function.ExecuteNonQuery(text);
							long num2 = Conversions.ToLong(Public_Function.ExecuteScalar("select isnull(SUM(bed),0) from Sanad where codehesab_id=18 and Sanad.Bed>0"));
							flag = (num2 > 0L);
							if (flag)
							{
								DataTable dataTable = (DataTable)this.GridEX1.DataSource;
								flag = Operators.ConditionalCompareObjectEqual(dataTable.Rows[dataTable.Rows.Count - 1]["num"], "انتقال به درآمد", false);
								if (flag)
								{
									dataTable.Rows[dataTable.Rows.Count - 1]["mablagh"] = -1L * num2;
								}
								else
								{
									DataRow dataRow = dataTable.NewRow();
									dataRow["mablagh"] = -1L * num2;
									dataRow["num"] = "انتقال به درآمد";
									dataTable.Rows.Add(dataRow);
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x040013E7 RID: 5095
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x040013E9 RID: 5097
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x040013EA RID: 5098
		[AccessedThroughProperty("UiGroupBox2")]
		private UIGroupBox _UiGroupBox2;

		// Token: 0x040013EB RID: 5099
		[AccessedThroughProperty("GridEX1")]
		private DataEntryGrid _GridEX1;

		// Token: 0x040013EC RID: 5100
		[AccessedThroughProperty("txt_ta_tarikh")]
		private DateBox2 _txt_ta_tarikh;

		// Token: 0x040013ED RID: 5101
		[AccessedThroughProperty("txt_az_tarikh")]
		private DateBox2 _txt_az_tarikh;

		// Token: 0x040013EE RID: 5102
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x040013EF RID: 5103
		[AccessedThroughProperty("UiCheckBox2")]
		private UICheckBox _UiCheckBox2;

		// Token: 0x040013F0 RID: 5104
		[AccessedThroughProperty("Bar1")]
		private Bar _Bar1;

		// Token: 0x040013F1 RID: 5105
		[AccessedThroughProperty("ButtonItem1")]
		private ButtonItem _ButtonItem1;

		// Token: 0x040013F2 RID: 5106
		[AccessedThroughProperty("EditBox1")]
		private EditBox _EditBox1;

		// Token: 0x040013F3 RID: 5107
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x040013F4 RID: 5108
		[AccessedThroughProperty("SelectItem1")]
		private SelectItem _SelectItem1;

		// Token: 0x040013F5 RID: 5109
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x040013F6 RID: 5110
		[AccessedThroughProperty("Timer1")]
		private Timer _Timer1;

		// Token: 0x040013F7 RID: 5111
		[AccessedThroughProperty("ButtonItem2")]
		private ButtonItem _ButtonItem2;

		// Token: 0x040013F8 RID: 5112
		[CompilerGenerated]
		private int? _BankHesab_ID;

		// Token: 0x040013F9 RID: 5113
		[CompilerGenerated]
		private string _BankHesab_Name;
	}
}
