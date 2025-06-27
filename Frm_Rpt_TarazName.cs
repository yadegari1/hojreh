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
using Janus.Windows.UI.Dock;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x02000139 RID: 313
	[DesignerGenerated]
	public partial class Frm_Rpt_TarazName : Form
	{
		// Token: 0x06002D8A RID: 11658 RVA: 0x0021C530 File Offset: 0x0021A730
		public Frm_Rpt_TarazName()
		{
			base.KeyDown += new KeyEventHandler(this.Frm_Rpt_TarazName_KeyDown);
			base.Load += new EventHandler(this.Frm_Rpt_TarazName_Load);
			base.Resize += new EventHandler(this.Frm_Rpt_TarazName_Resize);
			Frm_Rpt_TarazName.__ENCAddToList(this);
			this.dt_right = new DataTable();
			this.dt_left = new DataTable();
			this.lst2 = new DataTable();
			this.InitializeComponent();
		}

		// Token: 0x06002D8B RID: 11659 RVA: 0x0021C5B0 File Offset: 0x0021A7B0
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_Rpt_TarazName.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_Rpt_TarazName.__ENCList.Count == Frm_Rpt_TarazName.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_Rpt_TarazName.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_Rpt_TarazName.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_Rpt_TarazName.__ENCList[num] = Frm_Rpt_TarazName.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_Rpt_TarazName.__ENCList.RemoveRange(num, Frm_Rpt_TarazName.__ENCList.Count - num);
						Frm_Rpt_TarazName.__ENCList.Capacity = Frm_Rpt_TarazName.__ENCList.Count;
					}
					Frm_Rpt_TarazName.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000DE0 RID: 3552
		// (get) Token: 0x06002D8E RID: 11662 RVA: 0x0021CD9C File Offset: 0x0021AF9C
		// (set) Token: 0x06002D8F RID: 11663 RVA: 0x0000B945 File Offset: 0x00009B45
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

		// Token: 0x17000DE1 RID: 3553
		// (get) Token: 0x06002D90 RID: 11664 RVA: 0x0021CDB4 File Offset: 0x0021AFB4
		// (set) Token: 0x06002D91 RID: 11665 RVA: 0x0021CDCC File Offset: 0x0021AFCC
		internal virtual GridEX GridEX2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GridEX2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				RowLoadEventHandler value2 = new RowLoadEventHandler(this.GridEX2_LoadingRow);
				bool flag = this._GridEX2 != null;
				if (flag)
				{
					this._GridEX2.LoadingRow -= value2;
				}
				this._GridEX2 = value;
				flag = (this._GridEX2 != null);
				if (flag)
				{
					this._GridEX2.LoadingRow += value2;
				}
			}
		}

		// Token: 0x17000DE2 RID: 3554
		// (get) Token: 0x06002D92 RID: 11666 RVA: 0x0021CE2C File Offset: 0x0021B02C
		// (set) Token: 0x06002D93 RID: 11667 RVA: 0x0021CE44 File Offset: 0x0021B044
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
				ColumnActionEventHandler value2 = new ColumnActionEventHandler(this.GridEX1_ColumnButtonClick);
				bool flag = this._GridEX1 != null;
				if (flag)
				{
					this._GridEX1.ColumnButtonClick -= value2;
				}
				this._GridEX1 = value;
				flag = (this._GridEX1 != null);
				if (flag)
				{
					this._GridEX1.ColumnButtonClick += value2;
				}
			}
		}

		// Token: 0x17000DE3 RID: 3555
		// (get) Token: 0x06002D94 RID: 11668 RVA: 0x0021CEA4 File Offset: 0x0021B0A4
		// (set) Token: 0x06002D95 RID: 11669 RVA: 0x0021CEBC File Offset: 0x0021B0BC
		internal virtual BackgroundWorker BackgroundWorker1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._BackgroundWorker1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DoWorkEventHandler value2 = new DoWorkEventHandler(this.BackgroundWorker1_DoWork);
				bool flag = this._BackgroundWorker1 != null;
				if (flag)
				{
					this._BackgroundWorker1.DoWork -= value2;
				}
				this._BackgroundWorker1 = value;
				flag = (this._BackgroundWorker1 != null);
				if (flag)
				{
					this._BackgroundWorker1.DoWork += value2;
				}
			}
		}

		// Token: 0x17000DE4 RID: 3556
		// (get) Token: 0x06002D96 RID: 11670 RVA: 0x0021CF1C File Offset: 0x0021B11C
		// (set) Token: 0x06002D97 RID: 11671 RVA: 0x0000B94F File Offset: 0x00009B4F
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

		// Token: 0x17000DE5 RID: 3557
		// (get) Token: 0x06002D98 RID: 11672 RVA: 0x0021CF34 File Offset: 0x0021B134
		// (set) Token: 0x06002D99 RID: 11673 RVA: 0x0021CF4C File Offset: 0x0021B14C
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

		// Token: 0x17000DE6 RID: 3558
		// (get) Token: 0x06002D9A RID: 11674 RVA: 0x0021CFAC File Offset: 0x0021B1AC
		// (set) Token: 0x06002D9B RID: 11675 RVA: 0x0021CFC4 File Offset: 0x0021B1C4
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

		// Token: 0x06002D9C RID: 11676 RVA: 0x0021D024 File Offset: 0x0021B224
		private void AddToTaraz(string name, long mablagh, Frm_Rpt_TarazName.NoeTaraz t, bool b, int Code)
		{
			bool flag = mablagh == 0L;
			if (!flag)
			{
				flag = (t == Frm_Rpt_TarazName.NoeTaraz.Right);
				if (flag)
				{
					this.dt_right.Rows.Add(new object[]
					{
						name,
						mablagh,
						b,
						Code
					});
				}
				else
				{
					this.dt_left.Rows.Add(new object[]
					{
						name,
						mablagh,
						b,
						Code
					});
				}
			}
		}

		// Token: 0x06002D9D RID: 11677 RVA: 0x0021D0CC File Offset: 0x0021B2CC
		private void GetTakhlie()
		{
			long mablagh = Conversions.ToLong(Public_Function.ExecuteScalar("select isnull(SUM(Sanad.bes) - SUM(Sanad.bed),0) from sanad where codehesab_id=18"));
			this.AddToTaraz("تخلیه", mablagh, Frm_Rpt_TarazName.NoeTaraz.left, true, 10);
		}

		// Token: 0x06002D9E RID: 11678 RVA: 0x0021D0FC File Offset: 0x0021B2FC
		private void GetBarRoyeZamin()
		{
			long num = Conversions.ToLong(Public_Function.ExecuteScalar("select isnull(sum(jam_kol),0) from furush_hag_detail where moshtari_id=-2"));
			long num2 = Conversions.ToLong(Public_Function.ExecuteScalar("select isnull(sum(mablagh),0) from daryaftpardakht where dptype_id=28"));
			long num3 = checked(num2 - num);
			bool flag = num3 < 0L;
			if (flag)
			{
				this.AddToTaraz("بار روی زمین", Math.Abs(num3), Frm_Rpt_TarazName.NoeTaraz.Right, true, 12);
			}
			else
			{
				flag = (num3 > 0L);
				if (flag)
				{
					this.AddToTaraz("بار روی زمین", num3, Frm_Rpt_TarazName.NoeTaraz.left, true, 12);
				}
			}
		}

		// Token: 0x06002D9F RID: 11679 RVA: 0x0021D16C File Offset: 0x0021B36C
		private string GetDaramad()
		{
			long num = Conversions.ToLong(Public_Function.ExecuteScalar("SELECT   isnull( sum(Sanad.Bes),0)- isnull(sum( Sanad.Bed),0) as mablagh  FROM         Sanad INNER JOIN  Code_Hesab ON Sanad.CodeHesab_ID = Code_Hesab.ID  WHERE     (Code_Hesab.Grouh_ID = 7)"));
			long num2 = Conversions.ToLong(Public_Function.ExecuteScalar("SELECT    isnull( sum (Furush_Hag_Detail.kargari),0) as kargari   FROM         Safi_Furush INNER JOIN   Furush_Hag ON Safi_Furush.Furush_Hag_ID = Furush_Hag.ID INNER JOIN   Furush_Hag_Detail ON Furush_Hag.ID = Furush_Hag_Detail.Furush_Hug_ID "));
			return Conversions.ToString(checked(num + num2));
		}

		// Token: 0x06002DA0 RID: 11680 RVA: 0x0021D1A8 File Offset: 0x0021B3A8
		private string GetHazine()
		{
			long num = Conversions.ToLong(Public_Function.ExecuteScalar("SELECT     isnull(sum(Bed),0)-isnull(sum(Bes),0)  FROM Sanad where CodeHesab_ID in (select id from code_hesab where grouh_ID=5) "));
			long num2 = Conversions.ToLong(Public_Function.ExecuteScalar("select isnull(sum(rond),0) from (SELECT   abs(max( Safi_Furush.JamFurush) - (max(Safi_Furush.Mande) +max( Safi_Furush.Karmozd) + isnull(sum (Furush_Keraye.Keraye),0))) as rond   FROM         Safi_Furush INNER JOIN   Furush_Hag ON Safi_Furush.Furush_Hag_ID = Furush_Hag.ID  LEFT OUTER JOIN   Furush_Keraye ON Furush_Hag.ID = Furush_Keraye.Furush_ID    group by    Furush_Hag.Num ) t"));
			return Conversions.ToString(checked(num + num2));
		}

		// Token: 0x06002DA1 RID: 11681 RVA: 0x0021D1E4 File Offset: 0x0021B3E4
		private void GetBedehkaran()
		{
			long num = Conversions.ToLong(Public_Function.ExecuteScalar("select isnull(sum(jam_bed),0) from (  SELECT      SUM(Sanad.Bed - Sanad.Bes) AS jam_bed   FROM         Sanad INNER JOIN  Code_Hesab ON Sanad.CodeHesab_ID = Code_Hesab.ID INNER JOIN  Moshtari ON Code_Hesab.ID = Moshtari.CodeHesab_ID  WHERE     (Code_Hesab.Grouh_ID = 2)  AND (Moshtari.ID NOT IN            (SELECT     Moshtari_ID               FROM         Moshtari_ListSiah))          GROUP BY Sanad.CodeHesab_ID  HAVING(SUM(Sanad.Bed - Sanad.Bes) > 0) ) t"));
			bool flag = num == 0L;
			if (flag)
			{
				num = Conversions.ToLong(Public_Function.ExecuteScalar("SELECT     isnull(SUM(Moshtari.AvalDore),0) FROM         Moshtari INNER JOIN Sanad ON Moshtari.Sanad_ID = Sanad.ID  where bed>0 AND (Moshtari.ID NOT IN            (SELECT     Moshtari_ID               FROM         Moshtari_ListSiah))"));
			}
			flag = (num != 0L);
			if (flag)
			{
				this.AddToTaraz("بدهکاران", num, Frm_Rpt_TarazName.NoeTaraz.Right, true, 2);
			}
		}

		// Token: 0x06002DA2 RID: 11682 RVA: 0x0021D23C File Offset: 0x0021B43C
		private void getbank()
		{
			long mablagh = Conversions.ToLong(Public_Function.ExecuteScalar("SELECT     isnull(SUM(Sanad.Bed) - SUM(Sanad.Bes),0)  FROM         Sanad INNER JOIN Code_Hesab ON Sanad.CodeHesab_ID = Code_Hesab.ID where grouh_id=3 "));
			this.AddToTaraz("موجودی بانک ها", mablagh, Frm_Rpt_TarazName.NoeTaraz.Right, true, 3);
		}

		// Token: 0x06002DA3 RID: 11683 RVA: 0x0021D26C File Offset: 0x0021B46C
		private void GetCheckSandugh()
		{
			long mablagh = Conversions.ToLong(Public_Function.ExecuteScalar("SELECT isnull( sum (DaryaftPardakht.Mablagh),0)  FROM         DaryaftPardakht INNER JOIN  Moshtari ON DaryaftPardakht.Moshtari_ID = Moshtari.ID INNER JOIN  Bank ON DaryaftPardakht.CheckBank_ID = Bank.ID  WHERE     (DaryaftPardakht.dpType_ID IN (2, - 99)) AND (DaryaftPardakht.Check_Status IN (1) )"));
			this.AddToTaraz("چک های نزد صندوق", mablagh, Frm_Rpt_TarazName.NoeTaraz.Right, true, 4);
		}

		// Token: 0x06002DA4 RID: 11684 RVA: 0x0021D29C File Offset: 0x0021B49C
		private void GetcheckdarJaryan()
		{
			long mablagh = Conversions.ToLong(Public_Function.ExecuteScalar("SELECT   isnull( sum (DaryaftPardakht.Mablagh),0)   FROM         DaryaftPardakht INNER JOIN   Moshtari ON DaryaftPardakht.Moshtari_ID = Moshtari.ID INNER JOIN  Bank ON DaryaftPardakht.CheckBank_ID = Bank.ID  WHERE     (DaryaftPardakht.dpType_ID IN (2, - 99)) AND (DaryaftPardakht.Check_Status = 2) "));
			this.AddToTaraz("چک های در جریان وصول", mablagh, Frm_Rpt_TarazName.NoeTaraz.Right, true, 5);
		}

		// Token: 0x06002DA5 RID: 11685 RVA: 0x0021D2CC File Offset: 0x0021B4CC
		private void GetKasrEzafe()
		{
			string text = Conversions.ToString(Public_Function.ExecuteScalar("select top 1 isnull(tarikh_kasrezafe,'') from sud order by id desc"));
			string str = string.Empty;
			bool flag = Operators.CompareString(text, string.Empty, false) == 0;
			if (flag)
			{
				str = " AND Tarikh<=" + Public_Function.GetValue(Conversions.ToString(DateAndTime.Now));
			}
			else
			{
				str = " AND tarikh>" + Public_Function.GetValue(text) + " AND Tarikh<=" + Public_Function.GetValue(Conversions.ToString(DateAndTime.Now));
			}
			long num = Conversions.ToLong(Public_Function.ExecuteScalar("SELECT   isnull(sum(mablagh),0)    FROM         DaryaftPardakht  WHERE     DaryaftPardakht.dpType_ID IN (5)" + str));
			long num2 = Conversions.ToLong(Public_Function.ExecuteScalar("SELECT   isnull(sum(mablagh),0)   FROM         DaryaftPardakht  WHERE     DaryaftPardakht.dpType_ID IN (16)" + str));
			flag = (num2 > num);
			checked
			{
				if (flag)
				{
					this.AddToTaraz("کاهش صندوق", num2 - num, Frm_Rpt_TarazName.NoeTaraz.left, false, 9);
				}
				else
				{
					this.AddToTaraz("افزایش صندوق", num - num2, Frm_Rpt_TarazName.NoeTaraz.left, true, 9);
				}
			}
		}

		// Token: 0x06002DA6 RID: 11686 RVA: 0x0021D3AC File Offset: 0x0021B5AC
		private void GetVam()
		{
			DataTable dataTable = Public_Function.FillData("select id,mablagh from daryaftpardakht where dptype_id=33");
			DataTable dataTable2 = Public_Function.FillData("select sh_fish as id ,isnull(sum(mablagh),0) as mablagh from daryaftpardakht where dptype_id=37 group by sh_fish");
			bool flag2;
			long num;
			try
			{
				IEnumerator enumerator = dataTable.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					DataRow[] array = dataTable2.Select(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("id='", dataRow["ID"]), "'")));
					bool flag = array.Length > 0;
					if (flag)
					{
						flag2 = Operators.ConditionalCompareObjectGreater(array[0]["mablagh"], dataRow["mablagh"], false);
						if (!flag2)
						{
							flag2 = Operators.ConditionalCompareObjectLess(array[0]["mablagh"], dataRow["mablagh"], false);
							if (flag2)
							{
								num = Conversions.ToLong(Operators.AddObject(num, Operators.SubtractObject(dataRow["mablagh"], array[0]["mablagh"])));
							}
						}
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
			flag2 = (num > 0L);
			if (flag2)
			{
				this.AddToTaraz("تسهیلات پرداختنی", num, Frm_Rpt_TarazName.NoeTaraz.left, true, 8);
			}
		}

		// Token: 0x06002DA7 RID: 11687 RVA: 0x0021D50C File Offset: 0x0021B70C
		private void GetMandeSandugh()
		{
			Sandugh sandugh = new Sandugh();
			string left = string.Empty;
			object expr_17 = Public_Function.ExecuteScalar("select top 1 mande from mande_sandugh order by tarikh desc");
			long? num;
			long? value = (expr_17 != null) ? ((long?)expr_17) : num;
			object objectValue = RuntimeHelpers.GetObjectValue(Public_Function.ExecuteScalar("select top 1 tarikh from mande_sandugh order by tarikh desc"));
			bool flag = objectValue == null;
			if (flag)
			{
				Public_Function.ShowMessage("لطفا با بستن صندوق امروز از موجودی صندوق امروز اطمینان حاصل فرمایید", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, null);
			}
			else
			{
				left = Public_Function.MiladiToShamsi(Conversions.ToDate(objectValue));
				flag = (Operators.CompareString(left, Public_Function.MiladiToShamsi(DateAndTime.Now), false) != 0);
				if (flag)
				{
					Public_Function.ShowMessage("لطفا با بستن صندوق امروز از موجودی صندوق امروز اطمینان حاصل فرمایید", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, null);
				}
			}
			flag = !value.HasValue;
			if (flag)
			{
				object expr_BF = Public_Function.ExecuteScalar("select isnull(bed,0) from sanad where codehesab_id=1 and tarikh=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi("1392/01/01")));
				value = ((expr_BF != null) ? ((long?)expr_BF) : num);
			}
			long num2 = 0L;
			bool? arg_105_0;
			if (!value.HasValue)
			{
				arg_105_0 = null;
			}
			else
			{
				bool? flag2 = new bool?(value.GetValueOrDefault() != num2);
				arg_105_0 = flag2;
			}
			bool? flag3 = arg_105_0;
			flag = flag3.GetValueOrDefault();
			if (flag)
			{
				this.AddToTaraz("موجودی نقد صندوق", (T)value, Frm_Rpt_TarazName.NoeTaraz.Right, true, 6);
			}
		}

		// Token: 0x06002DA8 RID: 11688 RVA: 0x0021D644 File Offset: 0x0021B844
		private void GetTaraz_EftetahieLeft()
		{
			long num = Conversions.ToLong(Public_Function.ExecuteScalar("select isnull(sum(bed),0) from sanad where tarikh=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi("1392/01/01"))));
			long num2 = Conversions.ToLong(Public_Function.ExecuteScalar("SELECT     isnull(SUM(Moshtari.AvalDore),0) FROM         Moshtari INNER JOIN Sanad ON Moshtari.Sanad_ID = Sanad.ID  where bed>0 AND (Moshtari.ID NOT IN            (SELECT     Moshtari_ID               FROM         Moshtari_ListSiah))"));
			long num3 = Conversions.ToLong(Public_Function.ExecuteScalar("select isnull(sum(bed),0) from sanad where id in (select sanad_id from bank_hesab )"));
			long num4 = Conversions.ToLong(Public_Function.ExecuteScalar("SELECT isnull( sum (DaryaftPardakht.Mablagh),0)  FROM         DaryaftPardakht INNER JOIN  Moshtari ON DaryaftPardakht.Moshtari_ID = Moshtari.ID INNER JOIN  Bank ON DaryaftPardakht.CheckBank_ID = Bank.ID  WHERE     DaryaftPardakht.dpType_ID IN (- 99)  "));
			this.AddToTaraz("تراز افتتاحیه", checked(num + num2 + num3 + num4), Frm_Rpt_TarazName.NoeTaraz.left, true, 1);
		}

		// Token: 0x06002DA9 RID: 11689 RVA: 0x0021D6C0 File Offset: 0x0021B8C0
		private void GetTaraz_EftetahieRight()
		{
			long num = Conversions.ToLong(Public_Function.ExecuteScalar("select isnull(sum(bes),0) from sanad where tarikh=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi("1392/01/01"))));
			long num2 = Conversions.ToLong(Public_Function.ExecuteScalar("select isnull(sum(bes),0) from sanad where id in (select sanad_id from moshtari where id>0)"));
			long num3 = Conversions.ToLong(Public_Function.ExecuteScalar("select isnull(sum(mablagh),0) from (SELECT    DaryaftPardakht.Mablagh  FROM         DasteCheck INNER JOIN   DasteCheckBarg ON DasteCheck.ID = DasteCheckBarg.DasteCheck_ID INNER JOIN   Bank_Hesab ON DasteCheck.BankHesab_ID = Bank_Hesab.ID INNER JOIN   Bank ON Bank_Hesab.Bank_ID = Bank.ID RIGHT OUTER JOIN   DaryaftPardakht LEFT OUTER JOIN   Hazine ON DaryaftPardakht.Hazine_ID = Hazine.ID ON DasteCheckBarg.ID = DaryaftPardakht.CheckBarg_ID LEFT OUTER JOIN   Bank AS Bank_1 ON DaryaftPardakht.CheckBank_ID = Bank_1.ID LEFT OUTER JOIN   Moshtari ON DaryaftPardakht.Moshtari_ID = Moshtari.ID  WHERE     DaryaftPardakht.dpType_ID IN ( - 98))t"));
			this.AddToTaraz("تراز افتتاحیه", checked(num + num2 + num3), Frm_Rpt_TarazName.NoeTaraz.Right, true, 1);
		}

		// Token: 0x06002DAA RID: 11690 RVA: 0x0021D728 File Offset: 0x0021B928
		private void GetBestankaran()
		{
			long num = Conversions.ToLong(Public_Function.ExecuteScalar("select isnull(sum(jam_bes),0) from (  SELECT      SUM(Sanad.Bes - Sanad.Bed) AS jam_bes   FROM         Sanad INNER JOIN  Code_Hesab ON Sanad.CodeHesab_ID = Code_Hesab.ID INNER JOIN  Moshtari ON Code_Hesab.ID = Moshtari.CodeHesab_ID  WHERE     (Code_Hesab.Grouh_ID = 2)  AND (Moshtari.ID NOT IN            (SELECT     Moshtari_ID               FROM         Moshtari_ListSiah))          GROUP BY Sanad.CodeHesab_ID  HAVING(SUM(Sanad.Bes - Sanad.Bed) > 0) ) t"));
			bool flag = num == 0L;
			if (flag)
			{
				num = Conversions.ToLong(Public_Function.ExecuteScalar("SELECT     isnull(SUM(Moshtari.AvalDore),0) FROM         Moshtari INNER JOIN Sanad ON Moshtari.Sanad_ID = Sanad.ID  where bes>0"));
			}
			this.AddToTaraz("بستانکاران", num, Frm_Rpt_TarazName.NoeTaraz.left, true, 2);
		}

		// Token: 0x06002DAB RID: 11691 RVA: 0x0021D774 File Offset: 0x0021B974
		private void GetCheckPardakhti()
		{
			long mablagh = Conversions.ToLong(Public_Function.ExecuteScalar("select isnull(sum(mablagh),0) from (SELECT    DaryaftPardakht.Mablagh  FROM         DasteCheck INNER JOIN   DasteCheckBarg ON DasteCheck.ID = DasteCheckBarg.DasteCheck_ID INNER JOIN   Bank_Hesab ON DasteCheck.BankHesab_ID = Bank_Hesab.ID INNER JOIN   Bank ON Bank_Hesab.Bank_ID = Bank.ID RIGHT OUTER JOIN   DaryaftPardakht LEFT OUTER JOIN   Hazine ON DaryaftPardakht.Hazine_ID = Hazine.ID ON DasteCheckBarg.ID = DaryaftPardakht.CheckBarg_ID LEFT OUTER JOIN   Bank AS Bank_1 ON DaryaftPardakht.CheckBank_ID = Bank_1.ID LEFT OUTER JOIN   Moshtari ON DaryaftPardakht.Moshtari_ID = Moshtari.ID  WHERE     (DaryaftPardakht.dpType_ID IN (15, 11, - 98))  AND (DaryaftPardakht.Check_Status IN (5)))t"));
			this.AddToTaraz("چک های پرداخت شده از دسته چک", mablagh, Frm_Rpt_TarazName.NoeTaraz.left, true, 3);
		}

		// Token: 0x06002DAC RID: 11692 RVA: 0x0021D7A4 File Offset: 0x0021B9A4
		private void GetKharid(string tarikh)
		{
			long num = Conversions.ToLong(Public_Function.ExecuteScalar("   select isnull(sum(jam_kol),0) from (  SELECT   isnull( sum( Jam_Kol),0) as jam_kol    FROM Kharid_Detail   where kharid_id in (select id from kharid where daramad_sanad_id is null)   union all   SELECT   isnull( sum( Jam_Kol),0) as jam_kol   FROM Kharid_Sardkhane_detail   where kharid_sardkhane_id in (select id from kharid_sardkhane where daramad_sanad_id is null))t "));
			bool flag = num > 0L;
			if (flag)
			{
				this.AddToTaraz("خرید", num, Frm_Rpt_TarazName.NoeTaraz.Right, true, 7);
			}
		}

		// Token: 0x06002DAD RID: 11693 RVA: 0x0021D7E0 File Offset: 0x0021B9E0
		private void GetHazineKharid()
		{
			long num = Conversions.ToLong(Public_Function.ExecuteScalar("select sum(jam) from (select isnull(sum(keraye),0) as jam from kharid_keraye  where kharid_id in (select id from kharid where daramad_sanad_id is null)  union all  select isnull(sum(keraye),0) as jam from furush_keraye   where furush_id in (select id from furush_hag where id not in (select furush_hag_id from safi_furush))  union all select isnull(sum(keraye),0) as jam from kharid_sardkhane_keraye  where kharid_sardkhane_id in (select id from kharid_sardkhane where daramad_sanad_id is null))t"));
			bool flag = num > 0L;
			if (flag)
			{
				this.AddToTaraz(" کسر میشود هزینه های خرید و فروش", num, Frm_Rpt_TarazName.NoeTaraz.left, false, 6);
			}
		}

		// Token: 0x06002DAE RID: 11694 RVA: 0x0021D81C File Offset: 0x0021BA1C
		private void GetSukhte()
		{
			long num = Conversions.ToLong(Public_Function.ExecuteScalar("SELECT    isnull(sum( t.jam_bed),0) as jam_bed  FROM         (SELECT     SUM(Sanad.Bed - Sanad.Bes) AS jam_bed, Sanad.CodeHesab_ID     FROM         Sanad INNER JOIN      Code_Hesab ON Sanad.CodeHesab_ID = Code_Hesab.ID INNER JOIN      Moshtari ON Code_Hesab.ID = Moshtari.CodeHesab_ID     WHERE     (Code_Hesab.Grouh_ID = 2) AND (Moshtari.ID NOT IN     (SELECT     Moshtari_ID        FROM         Sharik)) AND (Moshtari.ID IN     (SELECT     Moshtari_ID        FROM         Moshtari_ListSiah where checked is null))     GROUP BY Sanad.CodeHesab_ID     HAVING      (SUM(Sanad.Bed - Sanad.Bes) > 0)) AS t INNER JOIN   Moshtari AS Moshtari_1 ON t.CodeHesab_ID = Moshtari_1.CodeHesab_ID"));
			long num2 = Conversions.ToLong(Public_Function.ExecuteScalar("SELECT     isnull(sum(bed),0)    FROM         Moshtari INNER JOIN    Sanad ON Moshtari.Sanad_ID = Sanad.ID    where Moshtari.id in (select moshtari_id from moshtari_listsiah)  "));
			checked
			{
				bool flag = num - num2 > 0L;
				if (flag)
				{
					this.AddToTaraz("سوخته بدهکاران", num - num2, Frm_Rpt_TarazName.NoeTaraz.Right, true, 20);
				}
			}
		}

		// Token: 0x06002DAF RID: 11695 RVA: 0x0021D86C File Offset: 0x0021BA6C
		private void GetFurushNaghd()
		{
			string str = "jam_kol";
			bool flag = Conversions.ToBoolean(Public_Function.dict["kargari"]);
			if (flag)
			{
				str = "jamkol_ba_kargari";
			}
			long num = Conversions.ToLong(Public_Function.ExecuteScalar("select isnull(sum(" + str + "),0) from furush_hag_detail   where  furush_hug_id in (select id from furush_hag where id not in (select furush_hag_id from safi_furush))"));
			long num2 = Conversions.ToLong(Public_Function.ExecuteScalar("SELECT     isnull(sum(Kharid_Furush.Jam_Kol),0) FROM Kharid_Furush INNER JOIN Kharid ON Kharid_Furush.Kharid_ID = Kharid.ID where daramad_sanad_id is null"));
			long num3 = Conversions.ToLong(Public_Function.ExecuteScalar("SELECT     isnull(sum(Furush_Sardkhane_Detail.Jam_Kol),0)   FROM         Furush_Sardkhane_Detail INNER JOIN   Furush_Sardkhane ON Furush_Sardkhane_Detail.Furush_Sardkhane_ID = Furush_Sardkhane.ID INNER JOIN   Kharid_Sardkhane ON Furush_Sardkhane.Kharid_Sardkhane_ID = Kharid_Sardkhane.ID   where daramad_sanad_id is null"));
			checked
			{
				num += num2 + num3;
				flag = (num > 0L);
				if (flag)
				{
					this.AddToTaraz("جمع فروش", num, Frm_Rpt_TarazName.NoeTaraz.left, true, 5);
				}
			}
		}

		// Token: 0x06002DB0 RID: 11696 RVA: 0x0006620C File Offset: 0x0006440C
		private void Frm_Rpt_TarazName_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Escape;
			if (flag)
			{
				this.Close();
			}
		}

		// Token: 0x06002DB1 RID: 11697 RVA: 0x0021D900 File Offset: 0x0021BB00
		private void Frm_Rpt_TarazName_Load(object sender, EventArgs e)
		{
			this.lst2.Columns.Add("tarikh", typeof(string));
			this.dt_right.Columns.Add("Name", typeof(string));
			this.dt_right.Columns.Add("Mablagh", typeof(long));
			this.dt_right.Columns.Add("tp", typeof(bool));
			this.dt_right.Columns.Add("code", typeof(int));
			this.dt_left = this.dt_right.Clone();
			string tarikh = "1397/02/01";
			this.GetTaraz_EftetahieLeft();
			this.GetTaraz_EftetahieRight();
			this.GetBedehkaran();
			this.getbank();
			this.GetCheckSandugh();
			this.GetcheckdarJaryan();
			this.GetMandeSandugh();
			this.GetBestankaran();
			this.GetCheckPardakhti();
			string daramad = this.GetDaramad();
			string hazine = this.GetHazine();
			this.GetTakhlie();
			this.AddToTaraz("سود", checked((long)Math.Round(unchecked(Conversions.ToDouble(daramad) - Conversions.ToDouble(hazine)))), Frm_Rpt_TarazName.NoeTaraz.left, true, 4);
			this.GetKharid(tarikh);
			this.GetFurushNaghd();
			this.GetHazineKharid();
			this.GetSukhte();
			this.GetVam();
			this.GetKasrEzafe();
			this.GetBarRoyeZamin();
			this.GridEX1.DataSource = this.dt_right;
			this.GridEX2.DataSource = this.dt_left;
			this.BackgroundWorker1.RunWorkerAsync();
		}

		// Token: 0x06002DB2 RID: 11698 RVA: 0x0021DAA0 File Offset: 0x0021BCA0
		private void Frm_Rpt_TarazName_Resize(object sender, EventArgs e)
		{
			checked
			{
				this.GridEX1.Width = (int)Math.Round(unchecked((double)this.Width / 2.0 - 10.0));
				this.GridEX1.Left = (int)Math.Round(unchecked((double)this.Width / 2.0 + 10.0));
				this.GridEX2.Left = 0;
				this.GridEX2.Width = (int)Math.Round((double)this.Width / 2.0);
			}
		}

		// Token: 0x06002DB3 RID: 11699 RVA: 0x0021DB3C File Offset: 0x0021BD3C
		private void GridEX2_LoadingRow(object sender, RowLoadEventArgs e)
		{
			bool flag = e.Row.RowType == RowType.TotalRow;
			if (flag)
			{
				long num = 0L;
				try
				{
					IEnumerator enumerator = ((DataTable)this.GridEX2.DataSource).Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						flag = Operators.ConditionalCompareObjectEqual(dataRow["tp"], true, false);
						if (flag)
						{
							num = Conversions.ToLong(Operators.AddObject(num, dataRow["mablagh"]));
						}
						else
						{
							num = Conversions.ToLong(Operators.SubtractObject(num, dataRow["mablagh"]));
						}
						e.Row.Cells["mablagh"].Text = Public_Function.FormatPrice(Conversions.ToString(num));
					}
				}
				finally
				{
					IEnumerator enumerator;
					flag = (enumerator is IDisposable);
					if (flag)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
			}
		}

		// Token: 0x06002DB4 RID: 11700 RVA: 0x0021DC50 File Offset: 0x0021BE50
		private void GridEX1_ColumnButtonClick(object sender, ColumnActionEventArgs e)
		{
			Frm_ShowTarazData frm_ShowTarazData = new Frm_ShowTarazData();
			object value = this.GridEX1.CurrentRow.Cells["code"].Value;
			bool flag = Operators.ConditionalCompareObjectEqual(value, 2, false);
			DataTable dt;
			if (flag)
			{
				dt = Public_Function.FillData("SELECT    Sanad.CodeHesab_ID as id, SUM(Sanad.Bed - Sanad.Bes)  as mablagh,max( Moshtari.Name)+' '+max( Moshtari.Family) as name   FROM         Sanad INNER JOIN  Code_Hesab ON Sanad.CodeHesab_ID = Code_Hesab.ID INNER JOIN  Moshtari ON Code_Hesab.ID = Moshtari.CodeHesab_ID  WHERE     (Code_Hesab.Grouh_ID = 2)  AND (Moshtari.ID NOT IN            (SELECT     Moshtari_ID               FROM         Moshtari_ListSiah))          GROUP BY Sanad.CodeHesab_ID  HAVING (SUM(Sanad.Bed - Sanad.Bes) > 0)");
				frm_ShowTarazData.Text = "بدهکاران";
			}
			else
			{
				flag = Operators.ConditionalCompareObjectEqual(value, 3, false);
				if (flag)
				{
					dt = Public_Function.FillData("SELECT    Sanad.CodeHesab_ID, ISNULL(SUM(Sanad.Bed) - SUM(Sanad.Bes), 0) AS mablagh,max( Code_Hesab.Name) as name  FROM         Sanad INNER JOIN  Code_Hesab ON Sanad.CodeHesab_ID = Code_Hesab.ID  WHERE Code_Hesab.Grouh_ID = 3  GROUP BY Sanad.CodeHesab_ID");
					frm_ShowTarazData.Text = "موجودی بانک ها";
				}
			}
			frm_ShowTarazData.dt = dt;
			MyProject.Forms.Form_Main.Dialog_ShowForm(frm_ShowTarazData);
		}

		// Token: 0x06002DB5 RID: 11701 RVA: 0x0021DD00 File Offset: 0x0021BF00
		public long DaryaftNaghd(AsyncSQL async, string tarikh)
		{
			long num = Conversions.ToLong(async.ExecuteScalar("select isnull(sum(mablagh),0) from daryaftpardakht where tarikh=" + Public_Function.GetValue(tarikh) + " and dptype_id in(-1,1,26,6,40)"));
			long num2 = Conversions.ToLong(async.ExecuteScalar("select isnull(sum(mablagh),0) from daryaftpardakht where tarikh=" + Public_Function.GetValue(tarikh) + " and dptype_id in(28) and moshtari_id=-1"));
			long num3 = Conversions.ToLong(async.ExecuteScalar("select isnull(sum(mablagh),0) from daryaftpardakht where tarikh=" + Public_Function.GetValue(tarikh) + " and dptype_id in(27,32,42)"));
			long num4 = Conversions.ToLong(async.ExecuteScalar("SELECT isnull(sum(Sanad_Dasti_Detail.bed),0) FROM Sanad_Dasti INNER JOIN Sanad_Dasti_Detail ON Sanad_Dasti.ID = Sanad_Dasti_Detail.Sanad_Dasti_id where tarikh=" + Public_Function.GetValue(tarikh) + " and hesab_type=1"));
			checked
			{
				num += num2 + num4;
				return num - num3;
			}
		}

		// Token: 0x06002DB6 RID: 11702 RVA: 0x0021DDA4 File Offset: 0x0021BFA4
		public long PardakhtNaghd(AsyncSQL async, string tarikh)
		{
			long num = Conversions.ToLong(async.ExecuteScalar("select isnull(sum(mablagh),0) from daryaftpardakht where tarikh=" + Public_Function.GetValue(tarikh) + " and dptype_id in(10,14,-2,-3,-5)"));
			num = Conversions.ToLong(Operators.AddObject(num, async.ExecuteScalar("select isnull(sum(mablagh),0) from daryaftpardakht where tarikh=" + Public_Function.GetValue(tarikh) + " and dptype_id in(15) and sh_check is null and bankhesab_id is null ")));
			num = Conversions.ToLong(Operators.AddObject(num, async.ExecuteScalar("select isnull(sum(mablagh),0) from daryaftpardakht where tarikh=" + Public_Function.GetValue(tarikh) + " and dptype_id in(37,38) and sandug_id is not null ")));
			return Conversions.ToLong(Operators.AddObject(num, async.ExecuteScalar("SELECT isnull(sum(Sanad_Dasti_Detail.bes),0) FROM Sanad_Dasti INNER JOIN Sanad_Dasti_Detail ON Sanad_Dasti.ID = Sanad_Dasti_Detail.Sanad_Dasti_id where tarikh=" + Public_Function.GetValue(tarikh) + " and hesab_type=1")));
		}

		// Token: 0x06002DB7 RID: 11703 RVA: 0x0021DE60 File Offset: 0x0021C060
		private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
		{
			AsyncSQL asyncSQL = new AsyncSQL();
			DataTable dataTable = asyncSQL.FillData("select * from mande_sandugh order by tarikh");
			List<string> list = new List<string>();
			bool flag = dataTable.Rows.Count == 0;
			checked
			{
				if (!flag)
				{
					int arg_45_0 = 0;
					int num = dataTable.Rows.Count - 1;
					int num2 = arg_45_0;
					bool flag2;
					while (true)
					{
						int arg_DD_0 = num2;
						int num3 = num;
						if (arg_DD_0 > num3)
						{
							break;
						}
						DateTime dateTime = Conversions.ToDate(dataTable.Rows[num2]["tarikh"]).AddDays(1.0);
						flag = (num2 + 1 < dataTable.Rows.Count - 1);
						if (flag)
						{
							flag2 = Operators.ConditionalCompareObjectNotEqual(dataTable.Rows[num2 + 1]["tarikh"], dateTime, false);
							if (flag2)
							{
								list.Add(Conversions.ToString(dateTime));
							}
						}
						num2++;
					}
					flag2 = (list.Count == 0);
					if (!flag2)
					{
						DataTable dataTable2 = asyncSQL.FillData("select tarikh,count(id) from daryaftpardakht where tarikh in (" + Public_Function.GetID(list) + ") group by tarikh having count(id)>0 order by tarikh");
						try
						{
							IEnumerator enumerator = dataTable2.Rows.GetEnumerator();
							while (enumerator.MoveNext())
							{
								DataRow dataRow = (DataRow)enumerator.Current;
								flag2 = (this.DaryaftNaghd(asyncSQL, Conversions.ToString(dataRow["tarikh"])) > 0L);
								if (flag2)
								{
									this.lst2.Rows.Add(new object[]
									{
										Public_Function.MiladiToShamsi(Conversions.ToDate(dataRow["tarikh"]))
									});
								}
								else
								{
									flag2 = (this.PardakhtNaghd(asyncSQL, Conversions.ToString(dataRow["tarikh"])) > 0L);
									if (flag2)
									{
										this.lst2.Rows.Add(new object[]
										{
											Public_Function.MiladiToShamsi(Conversions.ToDate(dataRow["tarikh"]))
										});
									}
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
					}
				}
			}
		}

		// Token: 0x06002DB8 RID: 11704 RVA: 0x0021E0A4 File Offset: 0x0021C2A4
		private void ButtonItem2_Click(object sender, EventArgs e)
		{
			Frm_ShowTarazData frm_ShowTarazData = new Frm_ShowTarazData();
			frm_ShowTarazData.dt = this.lst2;
			frm_ShowTarazData.Text = "تاریخ های زیر در صندوق بسته نشده است";
			frm_ShowTarazData.GridEX1.RootTable.Columns["mablagh"].Visible = false;
			frm_ShowTarazData.GridEX1.RootTable.Columns["name"].Visible = false;
			MyProject.Forms.Form_Main.Dialog_ShowForm(frm_ShowTarazData);
		}

		// Token: 0x06002DB9 RID: 11705 RVA: 0x0021E128 File Offset: 0x0021C328
		private void ButtonItem1_Click(object sender, EventArgs e)
		{
			int num = 0;
			Kharid kharid = new Kharid();
			DataTable dataTable = Public_Function.FillData("SELECT     Kharid_Detail.Kharid_ID, SUM(Kharid_Detail.Jam_Kol) AS mablagh  FROM         Kharid_Detail INNER JOIN   Kharid ON Kharid_Detail.Kharid_ID = Kharid.ID  where daramad_sanad_id Is Not null  GROUP BY Kharid_Detail.Kharid_ID");
			string str = string.Empty;
			bool flag = !Conversions.ToBoolean(Public_Function.dict["kargari"]);
			if (flag)
			{
				str = "Jam_Kol";
			}
			else
			{
				str = "JamKol_ba_kargari";
			}
			DataTable dataTable2 = Public_Function.FillData("SELECT     Kharid_Furush.Kharid_ID,max(num) as num, SUM(Kharid_Furush." + str + ") AS mablagh, MAX(Kharid.Daramad_Sanad_ID) AS daramad_sanad_id,MAX( Sanad.Bes) as sanad_bes  FROM         Kharid INNER JOIN  Kharid_Furush ON Kharid.ID = Kharid_Furush.Kharid_ID INNER JOIN   Sanad ON Kharid.Daramad_Sanad_ID = Sanad.ID  WHERE Kharid.Daramad_Sanad_ID Is Not NULL  GROUP BY Kharid_Furush.Kharid_ID");
			DataTable dataTable3 = Public_Function.FillData("SELECT     Kharid_Keraye.Kharid_ID,SUM( Kharid_Keraye.Keraye) as mablagh   FROM         Kharid INNER JOIN  Kharid_Keraye ON Kharid.ID = Kharid_Keraye.Kharid_ID  WHERE Kharid.Daramad_Sanad_ID Is Not NULL  GROUP BY Kharid_Keraye.Kharid_ID");
			checked
			{
				try
				{
					IEnumerator enumerator = dataTable2.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						long num2 = Conversions.ToLong(dataRow["mablagh"]);
						DataRow[] array = dataTable.Select(Conversions.ToString(Operators.ConcatenateObject("kharid_id=", dataRow["kharid_id"])));
						flag = (array.Length > 0);
						if (flag)
						{
							num2 = Conversions.ToLong(Operators.SubtractObject(num2, array[0]["mablagh"]));
						}
						array = dataTable3.Select(Conversions.ToString(Operators.ConcatenateObject("kharid_id=", dataRow["kharid_id"])));
						flag = (array.Length > 0);
						if (flag)
						{
							num2 = Conversions.ToLong(Operators.SubtractObject(num2, array[0]["mablagh"]));
						}
						flag = Operators.ConditionalCompareObjectNotEqual(num2, dataRow["sanad_bes"], false);
						if (flag)
						{
							kharid.UpdateDaramad(Conversions.ToString(dataRow["num"]));
							num++;
						}
					}
				}
				finally
				{
					IEnumerator enumerator;
					flag = (enumerator is IDisposable);
					if (flag)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				flag = (num == 0);
				if (flag)
				{
					Public_Function.ShowMessage("خطایی یافت نشد", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, null);
				}
				else
				{
					Public_Function.ShowMessage("تعداد " + Conversions.ToString(num) + " خطا اصلاح گردید ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, null);
				}
			}
		}

		// Token: 0x040011B3 RID: 4531
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x040011B5 RID: 4533
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x040011B6 RID: 4534
		[AccessedThroughProperty("GridEX2")]
		private GridEX _GridEX2;

		// Token: 0x040011B7 RID: 4535
		[AccessedThroughProperty("GridEX1")]
		private GridEX _GridEX1;

		// Token: 0x040011B8 RID: 4536
		[AccessedThroughProperty("BackgroundWorker1")]
		private BackgroundWorker _BackgroundWorker1;

		// Token: 0x040011B9 RID: 4537
		[AccessedThroughProperty("Bar1")]
		private Bar _Bar1;

		// Token: 0x040011BA RID: 4538
		[AccessedThroughProperty("ButtonItem2")]
		private ButtonItem _ButtonItem2;

		// Token: 0x040011BB RID: 4539
		[AccessedThroughProperty("ButtonItem1")]
		private ButtonItem _ButtonItem1;

		// Token: 0x040011BC RID: 4540
		private DataTable dt_right;

		// Token: 0x040011BD RID: 4541
		private DataTable dt_left;

		// Token: 0x040011BE RID: 4542
		private DataTable lst2;

		// Token: 0x0200013A RID: 314
		private enum NoeTaraz
		{
			// Token: 0x040011C0 RID: 4544
			left = 1,
			// Token: 0x040011C1 RID: 4545
			Right
		}
	}
}
