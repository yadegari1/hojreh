using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using FruitBox.My.Resources;
using Janus.Windows.EditControls;
using Janus.Windows.UI;
using Janus.Windows.UI.Dock;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x02000078 RID: 120
	[DesignerGenerated]
	public partial class Frm_Sal_Mali : Form
	{
		// Token: 0x060009C5 RID: 2501 RVA: 0x00003DE4 File Offset: 0x00001FE4
		[DebuggerNonUserCode]
		public Frm_Sal_Mali()
		{
			base.KeyDown += new KeyEventHandler(this.Frm_Sal_Mali_KeyDown);
			Frm_Sal_Mali.__ENCAddToList(this);
			this.InitializeComponent();
		}

		// Token: 0x060009C6 RID: 2502 RVA: 0x00080698 File Offset: 0x0007E898
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_Sal_Mali.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_Sal_Mali.__ENCList.Count == Frm_Sal_Mali.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_Sal_Mali.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_Sal_Mali.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_Sal_Mali.__ENCList[num] = Frm_Sal_Mali.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_Sal_Mali.__ENCList.RemoveRange(num, Frm_Sal_Mali.__ENCList.Count - num);
						Frm_Sal_Mali.__ENCList.Capacity = Frm_Sal_Mali.__ENCList.Count;
					}
					Frm_Sal_Mali.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x060009C9 RID: 2505 RVA: 0x00080E44 File Offset: 0x0007F044
		// (set) Token: 0x060009CA RID: 2506 RVA: 0x00003E10 File Offset: 0x00002010
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

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x060009CB RID: 2507 RVA: 0x00080E5C File Offset: 0x0007F05C
		// (set) Token: 0x060009CC RID: 2508 RVA: 0x00080E74 File Offset: 0x0007F074
		internal virtual UIButton UiButton1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiButton1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.UiButton1_Click);
				bool flag = this._UiButton1 != null;
				if (flag)
				{
					this._UiButton1.Click -= value2;
				}
				this._UiButton1 = value;
				flag = (this._UiButton1 != null);
				if (flag)
				{
					this._UiButton1.Click += value2;
				}
			}
		}

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x060009CD RID: 2509 RVA: 0x00080ED4 File Offset: 0x0007F0D4
		// (set) Token: 0x060009CE RID: 2510 RVA: 0x00080EEC File Offset: 0x0007F0EC
		internal virtual UIButton UiButton2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiButton2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.UiButton2_Click);
				bool flag = this._UiButton2 != null;
				if (flag)
				{
					this._UiButton2.Click -= value2;
				}
				this._UiButton2 = value;
				flag = (this._UiButton2 != null);
				if (flag)
				{
					this._UiButton2.Click += value2;
				}
			}
		}

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x060009CF RID: 2511 RVA: 0x00080F4C File Offset: 0x0007F14C
		// (set) Token: 0x060009D0 RID: 2512 RVA: 0x00003E1A File Offset: 0x0000201A
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

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x060009D1 RID: 2513 RVA: 0x00080F64 File Offset: 0x0007F164
		// (set) Token: 0x060009D2 RID: 2514 RVA: 0x00003E24 File Offset: 0x00002024
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

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x060009D3 RID: 2515 RVA: 0x00080F7C File Offset: 0x0007F17C
		// (set) Token: 0x060009D4 RID: 2516 RVA: 0x00003E2E File Offset: 0x0000202E
		internal virtual UIRadioButton UiRadioButton2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiRadioButton2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._UiRadioButton2 = value;
			}
		}

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x060009D5 RID: 2517 RVA: 0x00080F94 File Offset: 0x0007F194
		// (set) Token: 0x060009D6 RID: 2518 RVA: 0x00003E38 File Offset: 0x00002038
		internal virtual UIRadioButton UiRadioButton1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiRadioButton1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._UiRadioButton1 = value;
			}
		}

		// Token: 0x060009D7 RID: 2519 RVA: 0x00080FAC File Offset: 0x0007F1AC
		private void transfervagozari(string old, string newd)
		{
			DataTable dataTable = Public_Function.FillData("select id from daryaftpardakht where dptype_id in(-99,2) and check_status=2");
			bool flag = dataTable.Rows.Count == 0;
			if (!flag)
			{
				string iD = Public_Function.GetID(dataTable, "id", "");
				DataTable dataTable2 = Public_Function.FillData("select * from daryaftpardakht where pardakhtcheck_id in (" + iD + ")");
				string iD2 = Public_Function.GetID(dataTable2, "parent_id", "");
				DataTable dataTable3 = Public_Function.FillData("select * from daryaftpardakht where id in (" + iD2 + ")");
				string text = "declare @id bigint;";
				try
				{
					IEnumerator enumerator = dataTable3.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" insert into " + newd + ".dbo.daryaftpardakht (dptype_id,tarikh,sandug_id,bankhesab_id,mablagh,tarikh_fa) select 17," + Public_Function.GetValue(Public_Function.ShamsiToMiladi("1392/01/02")) + ",1,", dataRow["bankhesab_id"]), ","), dataRow["mablagh"]), ",'1392/01/02';select @id=scope_identity();")));
						try
						{
							IEnumerator enumerator2 = dataTable2.Rows.GetEnumerator();
							while (enumerator2.MoveNext())
							{
								DataRow dataRow2 = (DataRow)enumerator2.Current;
								flag = Operators.ConditionalCompareObjectEqual(dataRow2["parent_id"], dataRow["id"], false);
								if (flag)
								{
									text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" insert into " + newd + ".dbo.daryaftpardakht ([dpType_ID],[Tarikh],[Sandug_ID],[BankHesab_ID],[Mablagh],[Tarikh_Fa],[Sh_Check],[CheckBank_ID],[Check_Shobe],[Check_Sarresid]" + " ,[Check_Sarresid_Fa],[Check_Status],[Check_ShomareHesab],[Parent_ID])" + " VALUES (18," + Public_Function.GetValue(Conversions.ToString(dataRow2["Tarikh"])) + ",", dataRow2["Sandug_ID"]), ","), dataRow2["BankHesab_ID"]), ","), dataRow2["Mablagh"]), ","), Public_Function.GetValue(dataRow2["Tarikh_Fa"].ToString())), ","), Public_Function.GetValue(dataRow2["Sh_Check"].ToString())), ","), dataRow2["CheckBank_ID"]), ","), Public_Function.GetValue(dataRow2["Check_Shobe"].ToString())), ","), Public_Function.GetValue(dataRow2["Check_Sarresid"].ToString())), " ,"), Public_Function.GetValue(dataRow2["Check_Sarresid_Fa"].ToString())), ","), dataRow2["Check_Status"]), ","), Public_Function.GetValue(dataRow2["Check_ShomareHesab"].ToString())), ",@id); ")));
								}
							}
						}
						finally
						{
							IEnumerator enumerator2;
							flag = (enumerator2 is IDisposable);
							if (flag)
							{
								(enumerator2 as IDisposable).Dispose();
							}
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
				Public_Function.ExecuteNonQuery(text);
				text = string.Empty;
				string text2 = string.Empty;
				string text3 = string.Empty;
				try
				{
					IEnumerator enumerator3 = dataTable2.Rows.GetEnumerator();
					while (enumerator3.MoveNext())
					{
						DataRow dataRow3 = (DataRow)enumerator3.Current;
						text = string.Concat(new string[]
						{
							text,
							" update ",
							newd,
							".dbo.daryaftpardakht set check_status=2 where sh_check=",
							Public_Function.GetValue(Conversions.ToString(dataRow3["sh_check"])),
							";"
						});
						text2 = Conversions.ToString(Public_Function.ExecuteScalar("select id from " + newd + ".dbo.daryaftpardakht where dptype_id in (-98,-99) and sh_check=" + Public_Function.GetValue(Conversions.ToString(dataRow3["sh_check"]))));
						text3 = Conversions.ToString(Public_Function.ExecuteScalar("select id from " + newd + ".dbo.daryaftpardakht where dptype_id in (18) and sh_check=" + Public_Function.GetValue(Conversions.ToString(dataRow3["sh_check"]))));
						text = string.Concat(new string[]
						{
							text,
							" update ",
							newd,
							".dbo.daryaftpardakht set  pardakhtcheck_id= ",
							text2,
							" where id=",
							text3,
							";"
						});
					}
				}
				finally
				{
					IEnumerator enumerator3;
					flag = (enumerator3 is IDisposable);
					if (flag)
					{
						(enumerator3 as IDisposable).Dispose();
					}
				}
				Public_Function.ExecuteNonQuery(text);
			}
		}

		// Token: 0x060009D8 RID: 2520 RVA: 0x00081524 File Offset: 0x0007F724
		private string getids(DataTable dt, string notin_columns = "")
		{
			string text = string.Empty;
			string[] array = notin_columns.Split(new char[]
			{
				','
			});
			bool flag = true;
			checked
			{
				try
				{
					IEnumerator enumerator = dt.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						string[] array2 = array;
						bool flag2;
						for (int i = 0; i < array2.Length; i++)
						{
							string text2 = array2[i];
							flag2 = (Operators.CompareString(text2.ToLower(), dataRow["column_name"].ToString().ToLower(), false) == 0);
							if (flag2)
							{
								flag = false;
							}
						}
						flag2 = flag;
						if (flag2)
						{
							text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("[", dataRow["column_name"]), "],")));
						}
						else
						{
							flag = true;
						}
					}
				}
				finally
				{
					IEnumerator enumerator;
					bool flag2 = enumerator is IDisposable;
					if (flag2)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				text = Public_Function.RemoveLast(text);
				return text;
			}
		}

		// Token: 0x060009D9 RID: 2521 RVA: 0x00081650 File Offset: 0x0007F850
		private string DbTransfer(string table, bool identity = true, string notin_columns = "")
		{
			DataTable dt = Public_Function.FillData("select column_name from [INFORMATION_SCHEMA].[COLUMNS] where table_name='" + table + "' order by ordinal_position");
			string text = this.getids(dt, notin_columns);
			string text2 = string.Empty;
			if (identity)
			{
				text2 = text2 + "set identity_insert {1}.dbo." + table + " on;";
			}
			text2 = string.Concat(new string[]
			{
				text2,
				" insert into {1}.dbo.",
				table,
				" (",
				text,
				") select ",
				text,
				" from {0}.dbo.",
				table,
				";"
			});
			if (identity)
			{
				text2 = text2 + "set identity_insert {1}.dbo." + table + " off;";
			}
			return text2;
		}

		// Token: 0x060009DA RID: 2522 RVA: 0x00081720 File Offset: 0x0007F920
		private void del(string news)
		{
			string text = "dastecheckbarg,dastecheck,daramad,hazine,dptype,bank_hesab,moshtari_hesab,bank,sharik,moshtari_pic,moshtari_listsiah,moshtari_kala,kala,moshtari,code_hesab,grouh_moshtari,grouh_moshtari2,controls,grid_size,frm_size,user_controls,users,theme,shobe,shomarehesab,setting,pardakhtkonande,note,nahvepardakht_hazine,moshtari_kind,menu_sort,hazine_kharid";
			string text2 = string.Empty;
			string[] array = text.Split(new char[]
			{
				','
			});
			string[] array2 = array;
			checked
			{
				for (int i = 0; i < array2.Length; i++)
				{
					string text3 = array2[i];
					text2 = string.Concat(new string[]
					{
						text2,
						"delete from ",
						news,
						".dbo.",
						text3,
						";"
					});
				}
				Public_Function.ExecuteNonQuery(text2);
			}
		}

		// Token: 0x060009DB RID: 2523 RVA: 0x000817BC File Offset: 0x0007F9BC
		private void Transfer(string old, string newd)
		{
			this.del(newd);
			string text = string.Format(this.DbTransfer("kala", true, ""), old, newd);
			text += string.Format(this.DbTransfer("code_hesab", true, ""), old, newd);
			text += string.Format(this.DbTransfer("bank", true, ""), old, newd);
			text += string.Format(this.DbTransfer("grouh_moshtari", true, ""), old, newd);
			text += string.Format(this.DbTransfer("grouh_moshtari2", true, ""), old, newd);
			text += string.Format(this.DbTransfer("moshtari", true, "avaldoretype,avaldore,sanad_id,avaldore_tarikh"), old, newd);
			text += string.Format(this.DbTransfer("moshtari_pic", true, ""), old, newd);
			text += string.Format(this.DbTransfer("moshtari_listsiah", true, ""), old, newd);
			text += string.Format(this.DbTransfer("moshtari_kala", true, ""), old, newd);
			text += string.Format(this.DbTransfer("moshtari_hesab", true, ""), old, newd);
			text += string.Format(this.DbTransfer("sharik", false, ""), old, newd);
			text += string.Format(this.DbTransfer("dptype", false, ""), old, newd);
			text += string.Format(this.DbTransfer("bank_hesab", true, "avaldore,avaldore_tarikh,sanad_id"), old, newd);
			text += string.Format(this.DbTransfer("controls", true, ""), old, newd);
			text += string.Format(this.DbTransfer("frm_size", true, ""), old, newd);
			text += string.Format(this.DbTransfer("grid_size", true, ""), old, newd);
			text += string.Format(this.DbTransfer("users", true, ""), old, newd);
			text += string.Format(this.DbTransfer("user_controls", true, ""), old, newd);
			text += string.Format(this.DbTransfer("theme", true, ""), old, newd);
			text += string.Format(this.DbTransfer("shobe", true, ""), old, newd);
			text += string.Format(this.DbTransfer("shomarehesab", true, ""), old, newd);
			text += string.Format(this.DbTransfer("setting", false, ""), old, newd);
			text += string.Format(this.DbTransfer("pardakhtkonande", false, ""), old, newd);
			text += string.Format(this.DbTransfer("note", true, ""), old, newd);
			text += string.Format(this.DbTransfer("nahvepardakht_hazine", false, ""), old, newd);
			text += string.Format(this.DbTransfer("moshtari_kind", false, ""), old, newd);
			text += string.Format(this.DbTransfer("menu_sort", true, ""), old, newd);
			text += string.Format(this.DbTransfer("hazine_kharid", true, ""), old, newd);
			text += string.Format(this.DbTransfer("daramad", true, ""), old, newd);
			text += string.Format(this.DbTransfer("hazine", true, ""), old, newd);
			text += string.Format(this.DbTransfer("dastecheck", true, ""), old, newd);
			text += string.Format(this.DbTransfer("dastecheckbarg", true, ""), old, newd);
			Public_Function.ExecuteNonQuery(text);
		}

		// Token: 0x060009DC RID: 2524 RVA: 0x00081BB4 File Offset: 0x0007FDB4
		private void transferMande(string old, string newd)
		{
			DataTable dataTable = Public_Function.FillData(string.Concat(new string[]
			{
				"SELECT     SUM(",
				old,
				".dbo.Sanad.Bed) - SUM(",
				old,
				".dbo.Sanad.Bes)  as bed, ",
				old,
				".dbo.Moshtari.ID , max(",
				old,
				".dbo.moshtari.codehesab_id) AS codehesab_id FROM         ",
				old,
				".dbo.Sanad INNER JOIN ",
				old,
				".dbo.Moshtari ON ",
				old,
				".dbo.Sanad.CodeHesab_ID = ",
				old,
				".dbo.Moshtari.CodeHesab_ID  GROUP BY ",
				old,
				".dbo.Moshtari.ID  order by ",
				old,
				".dbo.moshtari.id"
			}));
			string text = "declare @sanad_id bigint;";
			Sanad sanad = new Sanad();
			string bed = string.Empty;
			string bes = string.Empty;
			string str = string.Empty;
			Moshtari_Info moshtari_Info = new Moshtari_Info();
			try
			{
				IEnumerator enumerator = dataTable.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					bool flag = Operators.ConditionalCompareObjectEqual(dataRow["bed"], 0, false);
					if (!flag)
					{
						flag = Operators.ConditionalCompareObjectGreater(dataRow["bed"], 0, false);
						object[] array;
						DataRow dataRow2;
						string columnName;
						object[] array2;
						bool[] array3;
						if (flag)
						{
							bed = Conversions.ToString(dataRow["bed"]);
							bes = Conversions.ToString(0);
							str = Conversions.ToString(1);
						}
						else
						{
							str = Conversions.ToString(2);
							bed = Conversions.ToString(0);
							object arg_1D8_0 = null;
							Type arg_1D8_1 = typeof(Math);
							string arg_1D8_2 = "Abs";
							array = new object[1];
							object[] arg_1BF_0 = array;
							int arg_1BF_1 = 0;
							dataRow2 = dataRow;
							DataRow arg_1B5_0 = dataRow2;
							columnName = "bed";
							arg_1BF_0[arg_1BF_1] = RuntimeHelpers.GetObjectValue(arg_1B5_0[columnName]);
							array2 = array;
							object[] arg_1D8_3 = array2;
							string[] arg_1D8_4 = null;
							Type[] arg_1D8_5 = null;
							array3 = new bool[]
							{
								true
							};
							object arg_1F6_0 = NewLateBinding.LateGet(arg_1D8_0, arg_1D8_1, arg_1D8_2, arg_1D8_3, arg_1D8_4, arg_1D8_5, array3);
							if (array3[0])
							{
								dataRow2[columnName] = RuntimeHelpers.GetObjectValue(array2[0]);
							}
							bes = Conversions.ToString(arg_1F6_0);
						}
						moshtari_Info.Moshtari_ID = Conversions.ToInteger(dataRow["id"]);
						flag = (Operators.CompareString(moshtari_Info.LastTarikh, string.Empty, false) == 0);
						if (flag)
						{
							moshtari_Info.LastTarikh = Public_Function.MiladiToShamsi(DateAndTime.Now);
						}
						text += sanad.InsertStr(Conversions.ToString(dataRow["codehesab_id"]), bed, bes, moshtari_Info.LastTarikh, moshtari_Info.LastTozih, "@sanad_id", newd, Sanad.SanadType.@null);
						object arg_363_0 = text;
						object arg_30E_0 = " update " + newd + ".dbo.moshtari set avaldoretype=" + str + ",avaldore=";
						object arg_2F0_0 = null;
						Type arg_2F0_1 = typeof(Math);
						string arg_2F0_2 = "Abs";
						array2 = new object[1];
						object[] arg_2D7_0 = array2;
						int arg_2D7_1 = 0;
						dataRow2 = dataRow;
						DataRow arg_2CD_0 = dataRow2;
						columnName = "bed";
						arg_2D7_0[arg_2D7_1] = RuntimeHelpers.GetObjectValue(arg_2CD_0[columnName]);
						array = array2;
						object[] arg_2F0_3 = array;
						string[] arg_2F0_4 = null;
						Type[] arg_2F0_5 = null;
						array3 = new bool[]
						{
							true
						};
						object arg_30E_1 = NewLateBinding.LateGet(arg_2F0_0, arg_2F0_1, arg_2F0_2, arg_2F0_3, arg_2F0_4, arg_2F0_5, array3);
						if (array3[0])
						{
							dataRow2[columnName] = RuntimeHelpers.GetObjectValue(array[0]);
						}
						text = Conversions.ToString(Operators.ConcatenateObject(arg_363_0, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(arg_30E_0, arg_30E_1), ",avaldore_tarikh="), Public_Function.GetValue(moshtari_Info.LastTarikh)), ",sanad_id=@sanad_id where "), newd), ".dbo.moshtari.id="), dataRow["id"]), ";")));
						Public_Function.ExecuteNonQuery(text);
						text = "declare @sanad_id bigint;";
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
		}

		// Token: 0x060009DD RID: 2525 RVA: 0x00081F94 File Offset: 0x00080194
		private long GetBarroyeZamin()
		{
			long num = Conversions.ToLong(Public_Function.ExecuteScalar("select isnull(sum(bed),0) from sanad where codehesab_id=42"));
			long num2 = Conversions.ToLong(Public_Function.ExecuteScalar("SELECT     isnull(sum( Mablagh),0) AS Bed  FROM DaryaftPardakht WHERE     (dpType_ID = 28)"));
			long num3 = Conversions.ToLong(Public_Function.ExecuteScalar("SELECT    isnull(sum( Jam_Kol),0) AS Bes  FROM Furush_Hag_Detail WHERE     (Moshtari_ID = - 2)"));
			long num4 = Conversions.ToLong(Public_Function.ExecuteScalar("select isnull(sum(bes),0) from sanad where codehesab_id=40"));
			return checked(num + num2 - num3 - num4);
		}

		// Token: 0x060009DE RID: 2526 RVA: 0x00081FF4 File Offset: 0x000801F4
		private void TransferCheck(string old, string newd)
		{
			string command = string.Concat(new string[]
			{
				"DELETE FROM ",
				newd,
				".[dbo].[DasteCheckBarg] where id in (select distinct( checkbarg_id) from ",
				old,
				".dbo.daryaftpardakht where checkbarg_id is not null and check_status<>5)"
			});
			Public_Function.ExecuteNonQuery(command);
			string text = "1392/01/01";
			command = string.Concat(new string[]
			{
				" Insert Into ",
				newd,
				".dbo.DaryaftPardakht(dpType_ID,Tarikh,Moshtari_ID,Sandug_ID,Mablagh,Tozih,Tarikh_Fa,Sh_Check,CheckBank_ID,Check_Shobe,Check_Sarresid,Check_Sarresid_Fa,Check_ShomareHesab,Check_Status) select -99,",
				Public_Function.GetValue(Public_Function.ShamsiToMiladi(text)),
				",Moshtari_ID,Sandug_ID,Mablagh,Tozih,",
				Public_Function.GetValue(text),
				",Sh_Check,CheckBank_ID,Check_Shobe,Check_Sarresid,Check_Sarresid_Fa,Check_ShomareHesab,1 from ",
				old,
				".dbo.daryaftpardakht   WHERE     (DaryaftPardakht.dpType_ID in(2,-99)) AND (DaryaftPardakht.Check_Status in (1,2)) order by DaryaftPardakht.Check_Sarresid"
			});
			Public_Function.ExecuteNonQuery(command);
			command = string.Concat(new string[]
			{
				" Insert Into ",
				newd,
				".dbo.DaryaftPardakht(dpType_ID,Tarikh,Moshtari_ID,Sandug_ID,Mablagh,Tozih,Tarikh_Fa,Sh_Check,CheckBank_ID,Check_Shobe,Check_Sarresid,Check_Sarresid_Fa,Check_ShomareHesab,hazine_id,checkbarg_id,bankhesab_id,Check_Status) select -98,",
				Public_Function.GetValue(Public_Function.ShamsiToMiladi(text)),
				",Moshtari_ID,Sandug_ID,Mablagh,Tozih,",
				Public_Function.GetValue(text),
				",Sh_Check,CheckBank_ID,Check_Shobe,Check_Sarresid,Check_Sarresid_Fa,Check_ShomareHesab,hazine_id,checkbarg_id,bankhesab_id,5 from ",
				old,
				".dbo.daryaftpardakht   WHERE     (DaryaftPardakht.dpType_ID IN (15, 11, - 98)) AND (DaryaftPardakht.Check_Status IN (5)) order by DaryaftPardakht.Check_Sarresid"
			});
			Public_Function.ExecuteNonQuery(command);
		}

		// Token: 0x060009DF RID: 2527 RVA: 0x00082118 File Offset: 0x00080318
		private void Transferavaldore(string old, string newd)
		{
			string text = string.Empty;
			long num = Conversions.ToLong(Public_Function.ExecuteScalar("SELECT     isnull(sum(Sanad.Bed),0) FROM " + old + ".dbo.Sanad INNER JOIN Code_Hesab ON Sanad.CodeHesab_ID = Code_Hesab.ID where grouh_id=5"));
			long num2 = Conversions.ToLong(Public_Function.ExecuteScalar("SELECT     isnull(sum(Sanad.Bes),0) FROM " + old + ".dbo.Sanad INNER JOIN Code_Hesab ON Sanad.CodeHesab_ID = Code_Hesab.ID where grouh_id=5"));
			checked
			{
				num -= num2;
				long num3 = Conversions.ToLong(Public_Function.ExecuteScalar(string.Concat(new string[]
				{
					"SELECT    isnull(sum( Sanad.Bed),0) FROM ",
					old,
					".dbo.DaryaftPardakht INNER JOIN ",
					old,
					".dbo.Sanad ON ",
					old,
					".dbo.DaryaftPardakht.SanadBed_ID = ",
					old,
					".dbo.Sanad.ID WHERE (",
					old,
					".dbo.DaryaftPardakht.dpType_ID IN (15, 30)) AND (",
					old,
					".dbo.DaryaftPardakht.Moshtari_ID IS NOT NULL)"
				})));
				text = string.Concat(new string[]
				{
					"insert into ",
					newd,
					".dbo.sanad (codehesab_id,bed,bes,tarikh,tarikh_fa,Tozih) values(28,",
					Conversions.ToString(num + num3),
					",0,",
					Public_Function.GetValue(DateAndTime.Now.ToShortDateString()),
					",",
					Public_Function.GetValue(Public_Function.MiladiToShamsi(DateAndTime.Now)),
					",",
					Public_Function.GetValue("مانده از تاریخ " + Public_Function.MiladiToShamsi(DateAndTime.Now)),
					");"
				});
				Public_Function.ExecuteNonQuery(text);
				long value = Conversions.ToLong(Public_Function.ExecuteScalar(string.Concat(new string[]
				{
					"SELECT     isnull(sum(Sanad.Bes),0)-isnull(sum( Sanad.Bed),0) FROM ",
					old,
					".dbo.Code_Hesab INNER JOIN ",
					old,
					".dbo.Sanad ON Code_Hesab.ID = Sanad.CodeHesab_ID where grouh_id=7"
				})));
				text = string.Concat(new string[]
				{
					"insert into ",
					newd,
					".dbo.sanad (codehesab_id,bed,bes,tarikh,tarikh_fa,Tozih) values(29,0,",
					Conversions.ToString(value),
					",",
					Public_Function.GetValue(DateAndTime.Now.ToShortDateString()),
					",",
					Public_Function.GetValue(Public_Function.MiladiToShamsi(DateAndTime.Now)),
					",",
					Public_Function.GetValue("مانده از تاریخ " + Public_Function.MiladiToShamsi(DateAndTime.Now)),
					");"
				});
				Public_Function.ExecuteNonQuery(text);
				Public_Function.ExecuteNonQuery(string.Concat(new string[]
				{
					"insert into ",
					newd,
					".dbo.mande_sandugh(tarikh,tarikh_fa,mande) select top 1 tarikh,tarikh_fa,mande from ",
					old,
					".dbo.mande_sandugh order by tarikh desc;"
				}));
				text = "declare @id bigint;";
				DataTable dataTable = Public_Function.FillData("select * from bank_hesab");
				Sanad sanad = new Sanad();
				try
				{
					IEnumerator enumerator = dataTable.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						DataTable dataTable2 = Public_Function.FillData(Conversions.ToString(Operators.ConcatenateObject("SELECT     isnull(sum(Bed),0) as bed, isnull(sum(Bes),0) as bes FROM  " + old + ".dbo.Sanad where CodeHesab_ID=", dataRow["codehesab_mojodi"])));
						long num4 = Conversions.ToLong(Operators.SubtractObject(dataTable2.Rows[0]["bed"], dataTable2.Rows[0]["bes"]));
						bool flag = dataTable2.Rows.Count > 0;
						if (flag)
						{
							text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("insert into " + newd + ".dbo.sanad (codehesab_id,bed,bes,tarikh,tarikh_fa,Tozih) values (", dataRow["codehesab_mojodi"]), ","), num4), ", 0,"), Public_Function.GetValue(DateAndTime.Now.ToShortDateString())), ","), Public_Function.GetValue(Public_Function.MiladiToShamsi(DateAndTime.Now))), ","), Public_Function.GetValue("مانده از تاریخ " + Public_Function.MiladiToShamsi(DateAndTime.Now))), ");")));
							text += "select @id=scope_identity();";
							text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(" update " + newd + ".dbo.bank_hesab set avaldore=" + Conversions.ToString(num4) + " ,avaldore_tarikh=" + Public_Function.GetValue(Public_Function.MiladiToShamsi(DateAndTime.Now)) + " ,sanad_id=@id where id=", dataRow["id"])));
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
				Public_Function.ExecuteNonQuery(text);
				long value2 = Conversions.ToLong(Public_Function.ExecuteScalar(" select isnull(sum(mablagh),0) from  (SELECT  -1* Furush_Hag_Detail.Jam_Kol AS mablagh  FROM  Furush_Hag_Detail  WHERE     Furush_Hag_Detail.Moshtari_ID = - 2  UNION ALL  SELECT  DaryaftPardakht.Mablagh AS mablagh FROM         DaryaftPardakht   WHERE     DaryaftPardakht.dpType_ID = 28  UNION ALL  SELECT  -1 * Bes AS mablagh FROM         Sanad  WHERE     (CodeHesab_ID = 40)) t "));
				text = string.Concat(new string[]
				{
					"insert into ",
					newd,
					".dbo.sanad (codehesab_id,bed,bes,tarikh,tarikh_fa,Tozih) values(42,",
					Conversions.ToString(value2),
					",0,",
					Public_Function.GetValue(DateAndTime.Now.ToShortDateString()),
					",",
					Public_Function.GetValue(Public_Function.MiladiToShamsi(DateAndTime.Now)),
					",",
					Public_Function.GetValue("مانده از تاریخ " + Public_Function.MiladiToShamsi(DateAndTime.Now)),
					");"
				});
				Public_Function.ExecuteNonQuery(text);
			}
		}

		// Token: 0x060009E0 RID: 2528 RVA: 0x000826EC File Offset: 0x000808EC
		private void Numbering(string old, string News)
		{
			bool @checked = this.UiRadioButton1.Checked;
			if (@checked)
			{
				string value = Conversions.ToString(Public_Function.ExecuteScalar(" Select isnull(max(Num),0)+1 from " + old + ".dbo.Furush_Hag"));
				setting setting = new setting();
				setting.Update("furush_start_number", value);
			}
		}

		// Token: 0x060009E1 RID: 2529 RVA: 0x0008273C File Offset: 0x0008093C
		private void UiButton1_Click(object sender, EventArgs e)
		{
			bool flag = Public_Function.ShowMessage("آیا مایل به ایجاد سال مالی جدید میباشید؟", MessageBoxButtons.YesNo, MessageBoxIcon.Question, null) == DialogResult.Yes;
			if (flag)
			{
				this.UiButton1.Enabled = false;
				CreateDB createDB = new CreateDB();
				string text = createDB.CreateDB();
				Initdb initdb = new Initdb();
				string database = Public_Function.Connection.Database;
				Public_Function.Connection.ChangeDatabase(text);
				initdb.InitDb1();
				initdb.initdb2();
				initdb.InitDB3();
				this.Numbering(database, text);
				Public_Function.Connection.ChangeDatabase(database);
				this.Transfer(database, text);
				this.transferMande(database, text);
				this.TransferCheck(database, text);
				this.transfervagozari(database, text);
				this.Transferavaldore(database, text);
				Public_Function.ShowMessage("سال مالی با موفقیت ایجاد شد", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, null);
				this.Close();
			}
		}

		// Token: 0x060009E2 RID: 2530 RVA: 0x0006620C File Offset: 0x0006440C
		private void Frm_Sal_Mali_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Escape;
			if (flag)
			{
				this.Close();
			}
		}

		// Token: 0x060009E3 RID: 2531 RVA: 0x0000205D File Offset: 0x0000025D
		private void UiButton2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x040003DF RID: 991
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x040003E1 RID: 993
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x040003E2 RID: 994
		[AccessedThroughProperty("UiButton1")]
		private UIButton _UiButton1;

		// Token: 0x040003E3 RID: 995
		[AccessedThroughProperty("UiButton2")]
		private UIButton _UiButton2;

		// Token: 0x040003E4 RID: 996
		[AccessedThroughProperty("UiGroupBox2")]
		private UIGroupBox _UiGroupBox2;

		// Token: 0x040003E5 RID: 997
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x040003E6 RID: 998
		[AccessedThroughProperty("UiRadioButton2")]
		private UIRadioButton _UiRadioButton2;

		// Token: 0x040003E7 RID: 999
		[AccessedThroughProperty("UiRadioButton1")]
		private UIRadioButton _UiRadioButton1;
	}
}
