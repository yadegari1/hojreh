using System;
using System.Collections;
using System.Data;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x0200003E RID: 62
	public class Moshtari_Info
	{
		// Token: 0x0600031E RID: 798 RVA: 0x000437B4 File Offset: 0x000419B4
		public Moshtari_Info()
		{
			bool flag = false;
			this.ShowSharik = flag;
			flag = true;
			this.CalcLastTozih = flag;
			flag = true;
			this.CalcMandeMoshtari = flag;
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x0600031F RID: 799 RVA: 0x000437E8 File Offset: 0x000419E8
		// (set) Token: 0x06000320 RID: 800 RVA: 0x00002732 File Offset: 0x00000932
		public bool ShowSharik
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ShowSharik;
			}
			[DebuggerNonUserCode]
			set
			{
				this._ShowSharik = value;
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x06000321 RID: 801 RVA: 0x00043800 File Offset: 0x00041A00
		// (set) Token: 0x06000322 RID: 802 RVA: 0x00043818 File Offset: 0x00041A18
		public int Moshtari_ID
		{
			get
			{
				return this._Moshtari_ID;
			}
			set
			{
				this._Moshtari_ID = value;
				bool flag = Operators.ConditionalCompareObjectEqual(Public_Function.ExecuteScalar("select count(moshtari_id) from sharik where moshtari_id=" + Conversions.ToString(value)), 1, false);
				bool flag2;
				if (flag)
				{
					flag2 = !this.ShowSharik;
					if (flag2)
					{
						this.LastTozih = "";
						this.Mande_Name = "";
						this.Check_Status = "";
						this.Mande = -1L;
						return;
					}
				}
				this.CodeHesab_ID = Conversions.ToLong(Public_Function.ExecuteScalar("Select CodeHesab_ID from Moshtari where id=" + Conversions.ToString(this._Moshtari_ID)));
				flag2 = this.CalcLastTozih;
				if (flag2)
				{
					this.LastTozih = this.GetLastTozih((long)this._Moshtari_ID);
				}
				flag2 = this.CalcMandeMoshtari;
				if (flag2)
				{
					this.GetMandeMoshtari(this._Moshtari_ID);
				}
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06000323 RID: 803 RVA: 0x000438F0 File Offset: 0x00041AF0
		// (set) Token: 0x06000324 RID: 804 RVA: 0x0000273C File Offset: 0x0000093C
		public string LastTozih
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LastTozih;
			}
			[DebuggerNonUserCode]
			set
			{
				this._LastTozih = value;
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06000325 RID: 805 RVA: 0x00043908 File Offset: 0x00041B08
		// (set) Token: 0x06000326 RID: 806 RVA: 0x00002746 File Offset: 0x00000946
		public long Mande
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Mande;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Mande = value;
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x06000327 RID: 807 RVA: 0x00043920 File Offset: 0x00041B20
		// (set) Token: 0x06000328 RID: 808 RVA: 0x00002750 File Offset: 0x00000950
		public string Mande_Name
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Mande_Name;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Mande_Name = value;
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x06000329 RID: 809 RVA: 0x00043938 File Offset: 0x00041B38
		// (set) Token: 0x0600032A RID: 810 RVA: 0x0000275A File Offset: 0x0000095A
		public string Check_Status
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Check_Status;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Check_Status = value;
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x0600032B RID: 811 RVA: 0x00043950 File Offset: 0x00041B50
		// (set) Token: 0x0600032C RID: 812 RVA: 0x00002764 File Offset: 0x00000964
		public bool CalcLastTozih
		{
			[DebuggerNonUserCode]
			get
			{
				return this._CalcLastTozih;
			}
			[DebuggerNonUserCode]
			set
			{
				this._CalcLastTozih = value;
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x0600032D RID: 813 RVA: 0x00043968 File Offset: 0x00041B68
		// (set) Token: 0x0600032E RID: 814 RVA: 0x0000276E File Offset: 0x0000096E
		public bool CalcMandeMoshtari
		{
			[DebuggerNonUserCode]
			get
			{
				return this._CalcMandeMoshtari;
			}
			[DebuggerNonUserCode]
			set
			{
				this._CalcMandeMoshtari = value;
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x0600032F RID: 815 RVA: 0x00043980 File Offset: 0x00041B80
		// (set) Token: 0x06000330 RID: 816 RVA: 0x00002778 File Offset: 0x00000978
		public string LastTarikh
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LastTarikh;
			}
			[DebuggerNonUserCode]
			set
			{
				this._LastTarikh = value;
			}
		}

		// Token: 0x06000331 RID: 817 RVA: 0x00043998 File Offset: 0x00041B98
		private int GetNextPosBed(int pos, DataTable dt)
		{
			long num = 0L;
			checked
			{
				int arg_16_0 = pos + 1;
				int num2 = dt.Rows.Count - 1;
				int num3 = arg_16_0;
				while (true)
				{
					int arg_1F2_0 = num3;
					int num4 = num2;
					if (arg_1F2_0 > num4)
					{
						goto Block_7;
					}
					bool flag = Operators.ConditionalCompareObjectGreater(dt.Rows[num3]["bed"], 0, false) && Operators.ConditionalCompareObjectEqual(dt.Rows[num3]["calc"], 1, false);
					if (flag)
					{
						break;
					}
					num3++;
				}
				int num5;
				bool flag2 = num5 + 1 > dt.Rows.Count - 1;
				int result;
				if (flag2)
				{
					dt.Rows[num5]["rembed"] = num;
					result = num5;
					return result;
				}
				num5 = num3;
				num = Conversions.ToLong(dt.Rows[num3]["rembed"]);
				DateTime dateTime = Conversions.ToDate(dt.Rows[num3]["tarikh"]);
				int arg_101_0 = num5 + 1;
				int num6 = dt.Rows.Count - 1;
				int num7 = arg_101_0;
				while (true)
				{
					int arg_1BC_0 = num7;
					int num4 = num6;
					if (arg_1BC_0 > num4)
					{
						goto Block_6;
					}
					flag2 = (Operators.ConditionalCompareObjectEqual(dt.Rows[num7]["tarikh"], dateTime, false) && Operators.ConditionalCompareObjectGreater(dt.Rows[num7]["bed"], 0, false));
					if (!flag2)
					{
						break;
					}
					num5 = num7;
					num = Conversions.ToLong(Operators.AddObject(num, dt.Rows[num7]["rembed"]));
					num7++;
				}
				dt.Rows[num5]["rembed"] = num;
				result = num5;
				return result;
				Block_6:
				dt.Rows[num5]["rembed"] = num;
				result = num5;
				return result;
				Block_7:
				result = -1;
				return result;
			}
		}

		// Token: 0x06000332 RID: 818 RVA: 0x00043BA4 File Offset: 0x00041DA4
		private int GetNextPosBes(int pos, DataTable dt)
		{
			checked
			{
				int arg_12_0 = pos + 1;
				int num = dt.Rows.Count - 1;
				int num2 = arg_12_0;
				while (true)
				{
					int arg_76_0 = num2;
					int num3 = num;
					if (arg_76_0 > num3)
					{
						goto Block_3;
					}
					bool flag = Operators.ConditionalCompareObjectGreater(dt.Rows[num2]["bes"], 0, false) && Operators.ConditionalCompareObjectEqual(dt.Rows[num2]["calc"], 1, false);
					if (flag)
					{
						break;
					}
					num2++;
				}
				int result = num2;
				return result;
				Block_3:
				result = -1;
				return result;
			}
		}

		// Token: 0x06000333 RID: 819 RVA: 0x00043C30 File Offset: 0x00041E30
		private void Disablecheckbargasht(DataTable dt)
		{
			DataRow[] array = dt.Select("pardakhtcheck_id is not null");
			bool flag = array.Length > 0;
			checked
			{
				if (flag)
				{
					DataRow[] array2 = array;
					for (int i = 0; i < array2.Length; i++)
					{
						DataRow dataRow = array2[i];
						DataRow[] array3 = dt.Select(Conversions.ToString(Operators.ConcatenateObject("check_id=", dataRow["pardakhtcheck_id"])));
						flag = (array3.Length > 0);
						if (flag)
						{
							dataRow["calc"] = 0;
							array3[0]["calc"] = 0;
						}
					}
				}
			}
		}

		// Token: 0x06000334 RID: 820 RVA: 0x00043CCC File Offset: 0x00041ECC
		public string GetLastTozih2()
		{
			long num = Conversions.ToLong(Public_Function.ExecuteScalar("select isnull(sum(bes),0) from sanad where arztype is null and codehesab_id=" + Conversions.ToString(this.CodeHesab_ID)));
			long num2 = Conversions.ToLong(Public_Function.ExecuteScalar("select isnull(sum(mablagh),0) from daryaftpardakht  where id in (select pardakhtcheck_Id from daryaftpardakht where dptype_id=22 and moshtari_id=2878) and dptype_id <> -99"));
			checked
			{
				num -= num2;
				DataTable dataTable = Public_Function.FillData(string.Concat(new string[]
				{
					"select tarikh_Fa,bed from sanad where codehesab_id=",
					Conversions.ToString(this.CodeHesab_ID),
					" AND bed>0 AND ID NOT IN(select sanadbed_ID from daryaftpardakht where dptype_id=22 and moshtari_id=",
					Conversions.ToString(this.Moshtari_ID),
					") "
				}));
				string result;
				try
				{
					IEnumerator enumerator = dataTable.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						num = Conversions.ToLong(Operators.SubtractObject(num, dataRow["bed"]));
						bool flag = num < 0L;
						if (flag)
						{
							result = dataRow["tarikh_FA"].ToString();
							return result;
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
				result = string.Empty;
				return result;
			}
		}

		// Token: 0x06000335 RID: 821 RVA: 0x00043E08 File Offset: 0x00042008
		public string GetLastTozih(long Moshtari_ID)
		{
			string text = string.Empty;
			long num = Conversions.ToLong(Public_Function.ExecuteScalar("select isnull(sum(bed),0)- isnull(sum(bes),0) from sanad where arztype is null and codehesab_ID= " + Conversions.ToString(this.CodeHesab_ID)));
			int num2 = -1;
			bool flag = num == 0L;
			checked
			{
				string result;
				if (flag)
				{
					result = "تسویه مانده";
				}
				else
				{
					flag = (num < 0L);
					if (flag)
					{
						result = "";
					}
					else
					{
						DataTable dataTable = Public_Function.FillData("select sanad.bed,sanad.bes,Sanad.Tarikh_Fa ,Sanad.Tarikh, Sanad.Tozih, Sanad.Bed AS rembed,Sanad.Bes AS rembes,NULL AS PardakhtCheck_ID, NULL AS Check_ID,1 as calc from sanad where arztype is null and sanad.codehesab_ID=" + Conversions.ToString(this.CodeHesab_ID) + " order by sanad.tarikh,sanadtype");
						dataTable.Columns.Add("stat", typeof(string));
						this.Disablecheckbargasht(dataTable);
						int num3 = 0;
						try
						{
							IEnumerator enumerator = dataTable.Rows.GetEnumerator();
							while (enumerator.MoveNext())
							{
								DataRow dataRow = (DataRow)enumerator.Current;
								flag = Operators.ConditionalCompareObjectNotEqual(dataRow["calc"], 0, false);
								if (flag)
								{
									long num4 = Conversions.ToLong(Operators.AddObject(num4, dataRow["bed"]));
									num4 = Conversions.ToLong(Operators.SubtractObject(num4, dataRow["bes"]));
									flag = (num4 > 0L);
									if (flag)
									{
										dataRow["stat"] = "بد";
									}
									else
									{
										flag = (num4 < 0L);
										if (flag)
										{
											dataRow["stat"] = "بس";
										}
										else
										{
											dataRow["stat"] = "ت";
											num2 = num3;
										}
									}
								}
								else
								{
									flag = (num3 > 0);
									if (flag)
									{
										dataRow["stat"] = RuntimeHelpers.GetObjectValue(dataTable.Rows[num3 - 1]["stat"]);
									}
									else
									{
										dataRow["stat"] = "بد";
									}
								}
								num3++;
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
						int num5 = num2;
						int num6 = num2;
						string left = string.Empty;
						num5 = this.GetNextPosBed(num5, dataTable);
						num6 = this.GetNextPosBes(num6, dataTable);
						bool flag2;
						while (num5 != -1 && num6 != -1)
						{
							flag = Operators.ConditionalCompareObjectLess(dataTable.Rows[num6]["rembes"], dataTable.Rows[num5]["rembed"], false);
							if (flag)
							{
								flag2 = (Operators.CompareString(left, string.Empty, false) != 0);
								if (flag2)
								{
									left = string.Empty;
								}
								DataRow dataRow2 = dataTable.Rows[num5];
								DataRow arg_2CA_0 = dataRow2;
								string columnName = "rembed";
								arg_2CA_0[columnName] = Operators.SubtractObject(dataRow2[columnName], dataTable.Rows[num6]["rembes"]);
								flag2 = Operators.ConditionalCompareObjectNotEqual(dataTable.Rows[num6]["stat"], "ت", false);
								if (flag2)
								{
									this.LastTarikh = Conversions.ToString(dataTable.Rows[num5]["Tarikh_Fa"]);
									text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" مانده از ", dataTable.Rows[num5]["Tarikh_Fa"]), " مبلغ "), Public_Function.FormatPrice(Conversions.ToString(dataTable.Rows[num5]["rembed"]))));
								}
								num6 = this.GetNextPosBes(num6, dataTable);
							}
							else
							{
								long num7 = Conversions.ToLong(Operators.SubtractObject(dataTable.Rows[num6]["rembes"], dataTable.Rows[num5]["rembed"]));
								dataTable.Rows[num5]["rembed"] = 0;
								left = Conversions.ToString(dataTable.Rows[num5]["Tarikh_Fa"]);
								num5 = this.GetNextPosBed(num5, dataTable);
								dataTable.Rows[num6]["rembes"] = num7;
							}
						}
						flag2 = (num5 != -1 && num6 == -1);
						if (flag2)
						{
							this.LastTarikh = Conversions.ToString(dataTable.Rows[num5]["Tarikh_Fa"]);
							text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" مانده از ", dataTable.Rows[num5]["Tarikh_Fa"]), " مبلغ "), Public_Function.FormatPrice(Conversions.ToString(dataTable.Rows[num5]["rembed"]))));
						}
						result = text;
					}
				}
				return result;
			}
		}

		// Token: 0x06000336 RID: 822 RVA: 0x00044308 File Offset: 0x00042508
		private void GetMandeMoshtari(int Moshtari_ID)
		{
			long num = Conversions.ToLong(Public_Function.ExecuteScalar("select isnull(sum(bed),0)- isnull(sum(bes),0) from sanad where arztype is null and codehesab_ID= " + Conversions.ToString(this.CodeHesab_ID)));
			DataRow dataRow = Public_Function.FillDataRow("SELECT    COUNT(id) as Count_Check,isnull(SUM(Mablagh),0) as Mablagh   FROM DaryaftPardakht   WHERE     (dpType_ID = 2) AND (Moshtari_ID=" + Conversions.ToString(this._Moshtari_ID) + ") AND (Check_Status IN (1,2))");
			bool flag = dataRow != null;
			bool flag2;
			if (flag)
			{
				flag2 = Operators.ConditionalCompareObjectGreater(dataRow["count_check"], 0, false);
				if (flag2)
				{
					this.Check_Status = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("جمع ", dataRow["Count_Check"]), " فقره چک وصول نشده "), Public_Function.FormatPrice(Conversions.ToString(dataRow["Mablagh"]))));
				}
				else
				{
					this.Check_Status = string.Empty;
				}
			}
			flag2 = (num > 0L);
			if (flag2)
			{
				this.Mande = num;
				this.Mande_Name = "بدهکار";
			}
			flag2 = (num < 0L);
			if (flag2)
			{
				this.Mande = Conversions.ToLong(Public_Function.FormatPrice(Conversions.ToString(Math.Abs(num))));
				this.Mande_Name = "بستانکار";
			}
			flag2 = (num == 0L);
			if (flag2)
			{
				this.Mande = 0L;
				this.Mande_Name = "بیحساب";
			}
		}

		// Token: 0x0400013D RID: 317
		private int _Moshtari_ID;

		// Token: 0x0400013E RID: 318
		private long CodeHesab_ID;

		// Token: 0x0400013F RID: 319
		[CompilerGenerated]
		private bool _ShowSharik;

		// Token: 0x04000140 RID: 320
		[CompilerGenerated]
		private string _LastTozih;

		// Token: 0x04000141 RID: 321
		[CompilerGenerated]
		private long _Mande;

		// Token: 0x04000142 RID: 322
		[CompilerGenerated]
		private string _Mande_Name;

		// Token: 0x04000143 RID: 323
		[CompilerGenerated]
		private string _Check_Status;

		// Token: 0x04000144 RID: 324
		[CompilerGenerated]
		private bool _CalcLastTozih;

		// Token: 0x04000145 RID: 325
		[CompilerGenerated]
		private bool _CalcMandeMoshtari;

		// Token: 0x04000146 RID: 326
		[CompilerGenerated]
		private string _LastTarikh;

		// Token: 0x0200003F RID: 63
		private enum bedbes
		{
			// Token: 0x04000148 RID: 328
			bed,
			// Token: 0x04000149 RID: 329
			bes
		}
	}
}
