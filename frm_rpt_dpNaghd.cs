using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.UI.Dock;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x0200012F RID: 303
	[DesignerGenerated]
	public partial class frm_rpt_dpNaghd : Form
	{
		// Token: 0x06002BD4 RID: 11220 RVA: 0x00209CE0 File Offset: 0x00207EE0
		public frm_rpt_dpNaghd()
		{
			base.Load += new EventHandler(this.frm_rpt_dpNaghd_Load);
			frm_rpt_dpNaghd.__ENCAddToList(this);
			this.dp = new DaryaftPardakht();
			this.dbl_grid = true;
			this.sandug = new Sandugh();
			this.InitializeComponent();
		}

		// Token: 0x06002BD5 RID: 11221 RVA: 0x00209D34 File Offset: 0x00207F34
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = frm_rpt_dpNaghd.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = frm_rpt_dpNaghd.__ENCList.Count == frm_rpt_dpNaghd.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = frm_rpt_dpNaghd.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = frm_rpt_dpNaghd.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									frm_rpt_dpNaghd.__ENCList[num] = frm_rpt_dpNaghd.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						frm_rpt_dpNaghd.__ENCList.RemoveRange(num, frm_rpt_dpNaghd.__ENCList.Count - num);
						frm_rpt_dpNaghd.__ENCList.Capacity = frm_rpt_dpNaghd.__ENCList.Count;
					}
					frm_rpt_dpNaghd.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000D53 RID: 3411
		// (get) Token: 0x06002BD8 RID: 11224 RVA: 0x0020AC88 File Offset: 0x00208E88
		// (set) Token: 0x06002BD9 RID: 11225 RVA: 0x0000B031 File Offset: 0x00009231
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

		// Token: 0x17000D54 RID: 3412
		// (get) Token: 0x06002BDA RID: 11226 RVA: 0x0020ACA0 File Offset: 0x00208EA0
		// (set) Token: 0x06002BDB RID: 11227 RVA: 0x0000B03B File Offset: 0x0000923B
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

		// Token: 0x17000D55 RID: 3413
		// (get) Token: 0x06002BDC RID: 11228 RVA: 0x0020ACB8 File Offset: 0x00208EB8
		// (set) Token: 0x06002BDD RID: 11229 RVA: 0x0000B045 File Offset: 0x00009245
		internal virtual CurrencyBox txt_ruzegabl
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_ruzegabl;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_ruzegabl = value;
			}
		}

		// Token: 0x17000D56 RID: 3414
		// (get) Token: 0x06002BDE RID: 11230 RVA: 0x0020ACD0 File Offset: 0x00208ED0
		// (set) Token: 0x06002BDF RID: 11231 RVA: 0x0000B04F File Offset: 0x0000924F
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

		// Token: 0x17000D57 RID: 3415
		// (get) Token: 0x06002BE0 RID: 11232 RVA: 0x0020ACE8 File Offset: 0x00208EE8
		// (set) Token: 0x06002BE1 RID: 11233 RVA: 0x0000B059 File Offset: 0x00009259
		internal virtual DataEntryGrid GridEx2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GridEx2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GridEx2 = value;
			}
		}

		// Token: 0x17000D58 RID: 3416
		// (get) Token: 0x06002BE2 RID: 11234 RVA: 0x0020AD00 File Offset: 0x00208F00
		// (set) Token: 0x06002BE3 RID: 11235 RVA: 0x0000B063 File Offset: 0x00009263
		internal virtual CurrencyBox txt_mande
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
				this._txt_mande = value;
			}
		}

		// Token: 0x17000D59 RID: 3417
		// (get) Token: 0x06002BE4 RID: 11236 RVA: 0x0020AD18 File Offset: 0x00208F18
		// (set) Token: 0x06002BE5 RID: 11237 RVA: 0x0000B06D File Offset: 0x0000926D
		internal virtual CurrencyBox txt_pardakhti
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_pardakhti;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_pardakhti = value;
			}
		}

		// Token: 0x17000D5A RID: 3418
		// (get) Token: 0x06002BE6 RID: 11238 RVA: 0x0020AD30 File Offset: 0x00208F30
		// (set) Token: 0x06002BE7 RID: 11239 RVA: 0x0000B077 File Offset: 0x00009277
		internal virtual Label Label4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label4 = value;
			}
		}

		// Token: 0x17000D5B RID: 3419
		// (get) Token: 0x06002BE8 RID: 11240 RVA: 0x0020AD48 File Offset: 0x00208F48
		// (set) Token: 0x06002BE9 RID: 11241 RVA: 0x0000B081 File Offset: 0x00009281
		internal virtual CurrencyBox txt_daryafti
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_daryafti;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_daryafti = value;
			}
		}

		// Token: 0x17000D5C RID: 3420
		// (get) Token: 0x06002BEA RID: 11242 RVA: 0x0020AD60 File Offset: 0x00208F60
		// (set) Token: 0x06002BEB RID: 11243 RVA: 0x0000B08B File Offset: 0x0000928B
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

		// Token: 0x17000D5D RID: 3421
		// (get) Token: 0x06002BEC RID: 11244 RVA: 0x0020AD78 File Offset: 0x00208F78
		// (set) Token: 0x06002BED RID: 11245 RVA: 0x0000B095 File Offset: 0x00009295
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

		// Token: 0x17000D5E RID: 3422
		// (get) Token: 0x06002BEE RID: 11246 RVA: 0x0020AD90 File Offset: 0x00208F90
		// (set) Token: 0x06002BEF RID: 11247 RVA: 0x0000B09F File Offset: 0x0000929F
		public string Tarikh
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Tarikh;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Tarikh = value;
			}
		}

		// Token: 0x06002BF0 RID: 11248 RVA: 0x0020ADA8 File Offset: 0x00208FA8
		private void LoadDaryaft()
		{
			string str = string.Concat(new string[]
			{
				"SELECT DaryaftPardakht.id, DaryaftPardakht.dptype_id,  DaryaftPardakht.Moshtari_ID,   DaryaftPardakht.Mablagh, DaryaftPardakht.Tozih,         DaryaftPardakht.Tarikh_Fa,    dpType.Name AS dp_Name,                                 Moshtari.Name + ' ' + Moshtari.Family AS Moshtari_Name, Bank_1.Name AS CheckBank_Name, Bank.Name + ' ' + Bank_Hesab.Shobe +' - '+ Bank_Hesab.SahebHesab AS BankHesab_Name,          DaryaftPardakht.Check_Status, DaryaftPardakht.Sh_Fish, DaryaftPardakht.FishVariz, DaryaftPardakht.FishVariz_Fa, DaryaftPardakht.Hazine_ID,DaryaftPardakht.checkbarg_id,            Hazine.Name AS Hazine_Name, DaryaftPardakht.PardakhtCheck_ID, DaryaftPardakht.Daramad_ID, Daramad.Name AS Daramad_Name                                FROM         Moshtari RIGHT OUTER JOIN                                                                                                                 dpType INNER JOIN                                                                                                                                      DaryaftPardakht ON dpType.ID = DaryaftPardakht.dpType_ID LEFT OUTER JOIN                                                                               Daramad ON DaryaftPardakht.Daramad_ID = Daramad.ID ON Moshtari.ID = DaryaftPardakht.Moshtari_ID LEFT OUTER JOIN                                        Hazine ON DaryaftPardakht.Hazine_ID = Hazine.ID LEFT OUTER JOIN                                                                                        Bank_Hesab LEFT OUTER JOIN                                                                                                                             Bank ON Bank_Hesab.Bank_ID = Bank.ID ON DaryaftPardakht.BankHesab_ID = Bank_Hesab.ID LEFT OUTER JOIN                                                   Bank AS Bank_1 ON DaryaftPardakht.CheckBank_ID = Bank_1.ID                                                                                             where Tarikh=",
				Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.Tarikh)),
				" AND dpType.type=1 and dptype_id in(-1,1,26,6,40)   union all   SELECT DaryaftPardakht.id,DaryaftPardakht.dptype_id,  DaryaftPardakht.Moshtari_ID,   DaryaftPardakht.Mablagh, DaryaftPardakht.Tozih,         DaryaftPardakht.Tarikh_Fa,    dpType.Name AS dp_Name,                                 Moshtari.Name + ' ' + Moshtari.Family AS Moshtari_Name, Bank_1.Name AS CheckBank_Name, Bank.Name + ' ' + Bank_Hesab.Shobe +' - '+ Bank_Hesab.SahebHesab AS BankHesab_Name,          DaryaftPardakht.Check_Status, DaryaftPardakht.Sh_Fish, DaryaftPardakht.FishVariz, DaryaftPardakht.FishVariz_Fa, DaryaftPardakht.Hazine_ID,DaryaftPardakht.checkbarg_id,            Hazine.Name AS Hazine_Name, DaryaftPardakht.PardakhtCheck_ID, DaryaftPardakht.Daramad_ID, Daramad.Name AS Daramad_Name                                FROM         Moshtari RIGHT OUTER JOIN                                                                                                                 dpType INNER JOIN                                                                                                                                      DaryaftPardakht ON dpType.ID = DaryaftPardakht.dpType_ID LEFT OUTER JOIN                                                                               Daramad ON DaryaftPardakht.Daramad_ID = Daramad.ID ON Moshtari.ID = DaryaftPardakht.Moshtari_ID LEFT OUTER JOIN                                        Hazine ON DaryaftPardakht.Hazine_ID = Hazine.ID LEFT OUTER JOIN                                                                                        Bank_Hesab LEFT OUTER JOIN                                                                                                                             Bank ON Bank_Hesab.Bank_ID = Bank.ID ON DaryaftPardakht.BankHesab_ID = Bank_Hesab.ID LEFT OUTER JOIN                                                   Bank AS Bank_1 ON DaryaftPardakht.CheckBank_ID = Bank_1.ID                                                                                             where Tarikh=",
				Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.Tarikh)),
				" AND dpType.type=1 and dptype_id in(28) and DaryaftPardakht.Moshtari_ID=-1  union all   SELECT DaryaftPardakht.id,DaryaftPardakht.dptype_id,  DaryaftPardakht.Moshtari_ID,  -1* DaryaftPardakht.Mablagh, DaryaftPardakht.Tozih,         DaryaftPardakht.Tarikh_Fa,    dpType.Name AS dp_Name,                                 Moshtari.Name + ' ' + Moshtari.Family AS Moshtari_Name, Bank_1.Name AS CheckBank_Name, Bank.Name + ' ' + Bank_Hesab.Shobe +' - '+ Bank_Hesab.SahebHesab AS BankHesab_Name,          DaryaftPardakht.Check_Status, DaryaftPardakht.Sh_Fish, DaryaftPardakht.FishVariz, DaryaftPardakht.FishVariz_Fa, DaryaftPardakht.Hazine_ID,DaryaftPardakht.checkbarg_id,            Hazine.Name AS Hazine_Name, DaryaftPardakht.PardakhtCheck_ID, DaryaftPardakht.Daramad_ID, Daramad.Name AS Daramad_Name                                FROM         Moshtari RIGHT OUTER JOIN                                                                                                                 dpType INNER JOIN                                                                                                                                      DaryaftPardakht ON dpType.ID = DaryaftPardakht.dpType_ID LEFT OUTER JOIN                                                                               Daramad ON DaryaftPardakht.Daramad_ID = Daramad.ID ON Moshtari.ID = DaryaftPardakht.Moshtari_ID LEFT OUTER JOIN                                        Hazine ON DaryaftPardakht.Hazine_ID = Hazine.ID LEFT OUTER JOIN                                                                                        Bank_Hesab LEFT OUTER JOIN                                                                                                                             Bank ON Bank_Hesab.Bank_ID = Bank.ID ON DaryaftPardakht.BankHesab_ID = Bank_Hesab.ID LEFT OUTER JOIN                                                   Bank AS Bank_1 ON DaryaftPardakht.CheckBank_ID = Bank_1.ID                                                                                             where Tarikh=",
				Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.Tarikh)),
				" AND dpType.type=1 and dptype_id in(27,32,42) "
			});
			string command = "select * from (" + str + ") t order by ID ";
			DataTable dataTable = Public_Function.FillData(command);
			try
			{
				IEnumerator enumerator = dataTable.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					bool flag = Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], -1, false);
					if (flag)
					{
						dataRow["moshtari_name"] = RuntimeHelpers.GetObjectValue(dataRow["tozih"]);
					}
					flag = Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 27, false);
					if (flag)
					{
						dataRow["moshtari_name"] = RuntimeHelpers.GetObjectValue(dataRow["bankhesab_name"]);
					}
				}
			}
			finally
			{
				IEnumerator enumerator;
				bool flag = enumerator is IDisposable;
				if (flag)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			this.GridEX1.DataSource = dataTable;
		}

		// Token: 0x06002BF1 RID: 11249 RVA: 0x0020AF30 File Offset: 0x00209130
		private void LoadPardakht()
		{
			string str = string.Concat(new string[]
			{
				"SELECT DaryaftPardakht.id, DaryaftPardakht.dptype_id,  DaryaftPardakht.Moshtari_ID,   DaryaftPardakht.Mablagh, DaryaftPardakht.Tozih,         DaryaftPardakht.Tarikh_Fa,    dpType.Name AS dp_Name,                                 Moshtari.Name + ' ' + Moshtari.Family AS Moshtari_Name, Bank_1.Name AS CheckBank_Name, Bank.Name + ' ' + Bank_Hesab.Shobe +' - '+ Bank_Hesab.SahebHesab AS BankHesab_Name,          DaryaftPardakht.Check_Status, DaryaftPardakht.Sh_Fish, DaryaftPardakht.FishVariz, DaryaftPardakht.FishVariz_Fa, DaryaftPardakht.Hazine_ID,DaryaftPardakht.checkbarg_id,            Hazine.Name AS Hazine_Name, DaryaftPardakht.PardakhtCheck_ID, DaryaftPardakht.Daramad_ID, Daramad.Name AS Daramad_Name                                FROM         Moshtari RIGHT OUTER JOIN                                                                                                                 dpType INNER JOIN                                                                                                                                      DaryaftPardakht ON dpType.ID = DaryaftPardakht.dpType_ID LEFT OUTER JOIN                                                                               Daramad ON DaryaftPardakht.Daramad_ID = Daramad.ID ON Moshtari.ID = DaryaftPardakht.Moshtari_ID LEFT OUTER JOIN                                        Hazine ON DaryaftPardakht.Hazine_ID = Hazine.ID LEFT OUTER JOIN                                                                                        Bank_Hesab LEFT OUTER JOIN                                                                                                                             Bank ON Bank_Hesab.Bank_ID = Bank.ID ON DaryaftPardakht.BankHesab_ID = Bank_Hesab.ID LEFT OUTER JOIN                                                   Bank AS Bank_1 ON DaryaftPardakht.CheckBank_ID = Bank_1.ID                                                                                             where Tarikh=",
				Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.Tarikh)),
				" AND dpType.type=2 and dptype_id in(10,14,-2,-3,-5)   union all   SELECT DaryaftPardakht.id,DaryaftPardakht.dptype_id,  DaryaftPardakht.Moshtari_ID,   DaryaftPardakht.Mablagh, DaryaftPardakht.Tozih,         DaryaftPardakht.Tarikh_Fa,    dpType.Name AS dp_Name,                                 Moshtari.Name + ' ' + Moshtari.Family AS Moshtari_Name, Bank_1.Name AS CheckBank_Name, Bank.Name + ' ' + Bank_Hesab.Shobe +' - '+ Bank_Hesab.SahebHesab AS BankHesab_Name,          DaryaftPardakht.Check_Status, DaryaftPardakht.Sh_Fish, DaryaftPardakht.FishVariz, DaryaftPardakht.FishVariz_Fa, DaryaftPardakht.Hazine_ID,DaryaftPardakht.checkbarg_id,            Hazine.Name AS Hazine_Name, DaryaftPardakht.PardakhtCheck_ID, DaryaftPardakht.Daramad_ID, Daramad.Name AS Daramad_Name                                FROM         Moshtari RIGHT OUTER JOIN                                                                                                                 dpType INNER JOIN                                                                                                                                      DaryaftPardakht ON dpType.ID = DaryaftPardakht.dpType_ID LEFT OUTER JOIN                                                                               Daramad ON DaryaftPardakht.Daramad_ID = Daramad.ID ON Moshtari.ID = DaryaftPardakht.Moshtari_ID LEFT OUTER JOIN                                        Hazine ON DaryaftPardakht.Hazine_ID = Hazine.ID LEFT OUTER JOIN                                                                                        Bank_Hesab LEFT OUTER JOIN                                                                                                                             Bank ON Bank_Hesab.Bank_ID = Bank.ID ON DaryaftPardakht.BankHesab_ID = Bank_Hesab.ID LEFT OUTER JOIN                                                   Bank AS Bank_1 ON DaryaftPardakht.CheckBank_ID = Bank_1.ID                                                                                             where Tarikh=",
				Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.Tarikh)),
				" AND dpType.type=2 and dptype_id in(15) and sh_check is null and bankhesab_id is null  union all   SELECT DaryaftPardakht.id,DaryaftPardakht.dptype_id,  DaryaftPardakht.Moshtari_ID,  -1* DaryaftPardakht.Mablagh, DaryaftPardakht.Tozih,         DaryaftPardakht.Tarikh_Fa,    dpType.Name AS dp_Name,                                 Moshtari.Name + ' ' + Moshtari.Family AS Moshtari_Name, Bank_1.Name AS CheckBank_Name, Bank.Name + ' ' + Bank_Hesab.Shobe +' - '+ Bank_Hesab.SahebHesab AS BankHesab_Name,          DaryaftPardakht.Check_Status, DaryaftPardakht.Sh_Fish, DaryaftPardakht.FishVariz, DaryaftPardakht.FishVariz_Fa, DaryaftPardakht.Hazine_ID,DaryaftPardakht.checkbarg_id,            Hazine.Name AS Hazine_Name, DaryaftPardakht.PardakhtCheck_ID, DaryaftPardakht.Daramad_ID, Daramad.Name AS Daramad_Name                                FROM         Moshtari RIGHT OUTER JOIN                                                                                                                 dpType INNER JOIN                                                                                                                                      DaryaftPardakht ON dpType.ID = DaryaftPardakht.dpType_ID LEFT OUTER JOIN                                                                               Daramad ON DaryaftPardakht.Daramad_ID = Daramad.ID ON Moshtari.ID = DaryaftPardakht.Moshtari_ID LEFT OUTER JOIN                                        Hazine ON DaryaftPardakht.Hazine_ID = Hazine.ID LEFT OUTER JOIN                                                                                        Bank_Hesab LEFT OUTER JOIN                                                                                                                             Bank ON Bank_Hesab.Bank_ID = Bank.ID ON DaryaftPardakht.BankHesab_ID = Bank_Hesab.ID LEFT OUTER JOIN                                                   Bank AS Bank_1 ON DaryaftPardakht.CheckBank_ID = Bank_1.ID                                                                                             where Tarikh=",
				Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.Tarikh)),
				" AND dpType.type=2 and dptype_id in(37,38) and sandug_id is not null  "
			});
			string command = "select * from (" + str + ") t order by ID ";
			DataTable dataTable = Public_Function.FillData(command);
			try
			{
				IEnumerator enumerator = dataTable.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					bool flag = Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 15, false);
					if (flag)
					{
						dataRow["moshtari_name"] = RuntimeHelpers.GetObjectValue(dataRow["tozih"]);
					}
				}
			}
			finally
			{
				IEnumerator enumerator;
				bool flag = enumerator is IDisposable;
				if (flag)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			this.GridEx2.DataSource = dataTable;
		}

		// Token: 0x06002BF2 RID: 11250 RVA: 0x0020B078 File Offset: 0x00209278
		private void loadTextBox()
		{
			long num = this.sandug.DaryaftNaghd(this.Tarikh);
			long num2 = this.sandug.PardakhtNaghd(this.Tarikh);
			long num3 = Conversions.ToLong(Public_Function.ExecuteScalar("select top 1 mande from mande_sandugh where tarikh< " + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.Tarikh)) + " order by tarikh desc "));
			object objectValue = RuntimeHelpers.GetObjectValue(Public_Function.ExecuteScalar("select count(tarikh) from mande_sandugh where tarikh<" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.Tarikh))));
			bool flag = Operators.ConditionalCompareObjectEqual(objectValue, 0, false);
			if (flag)
			{
				num3 = Conversions.ToLong(Public_Function.ExecuteScalar("select top 1 bed from sanad where codehesab_id=1 and tarikh=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi("1392/01/01"))));
			}
			this.txt_ruzegabl.Text = Conversions.ToString(num3);
			this.txt_daryafti.Text = Conversions.ToString(num);
			this.txt_pardakhti.Text = Conversions.ToString(num2);
			this.txt_mande.Text = Conversions.ToString(checked(num3 + num - num2));
		}

		// Token: 0x06002BF3 RID: 11251 RVA: 0x0000B0A9 File Offset: 0x000092A9
		private void frm_rpt_dpNaghd_Load(object sender, EventArgs e)
		{
			this.LoadDaryaft();
			this.LoadPardakht();
			this.loadTextBox();
		}

		// Token: 0x0400110A RID: 4362
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x0400110C RID: 4364
		[AccessedThroughProperty("GridEX1")]
		private DataEntryGrid _GridEX1;

		// Token: 0x0400110D RID: 4365
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x0400110E RID: 4366
		[AccessedThroughProperty("txt_ruzegabl")]
		private CurrencyBox _txt_ruzegabl;

		// Token: 0x0400110F RID: 4367
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04001110 RID: 4368
		[AccessedThroughProperty("GridEx2")]
		private DataEntryGrid _GridEx2;

		// Token: 0x04001111 RID: 4369
		[AccessedThroughProperty("txt_mande")]
		private CurrencyBox _txt_mande;

		// Token: 0x04001112 RID: 4370
		[AccessedThroughProperty("txt_pardakhti")]
		private CurrencyBox _txt_pardakhti;

		// Token: 0x04001113 RID: 4371
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		// Token: 0x04001114 RID: 4372
		[AccessedThroughProperty("txt_daryafti")]
		private CurrencyBox _txt_daryafti;

		// Token: 0x04001115 RID: 4373
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x04001116 RID: 4374
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x04001117 RID: 4375
		[CompilerGenerated]
		private string _Tarikh;

		// Token: 0x04001118 RID: 4376
		private DaryaftPardakht dp;

		// Token: 0x04001119 RID: 4377
		private bool dbl_grid;

		// Token: 0x0400111A RID: 4378
		private Sandugh sandug;
	}
}
