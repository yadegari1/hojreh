using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x02000029 RID: 41
	public class Furush_Hag
	{
		// Token: 0x0600029C RID: 668 RVA: 0x00002573 File Offset: 0x00000773
		public Furush_Hag()
		{
			this.Sanad = new Sanad();
			this.Daryaft = new DaryaftPardakht();
		}

		// Token: 0x0600029D RID: 669 RVA: 0x000332C0 File Offset: 0x000314C0
		public DataRow GetByID(long Num)
		{
			return Public_Function.FillDataRow("SELECT     Furush_Hag.*, Moshtari.Name+' '+ Moshtari.Family AS Moshtari_Name  FROM         Furush_Hag INNER JOIN   Moshtari ON Furush_Hag.Moshtari_ID = Moshtari.ID  where num =" + Conversions.ToString(Num));
		}

		// Token: 0x0600029E RID: 670 RVA: 0x000332E8 File Offset: 0x000314E8
		public DataTable GetDetailByID(long ID)
		{
			DataTable dataTable = Public_Function.FillData("SELECT     Furush_Hag_Detail.ID, Furush_Hag_Detail.Furush_Hug_ID, Furush_Hag_Detail.Moshtari_ID, Furush_Hag_Detail.Kala_ID, Furush_Hag_Detail.Tarikh,   Furush_Hag_Detail.Tarikh_Fa, Furush_Hag_Detail.Tedad, Furush_Hag_Detail.Vazn_Ba_Zarf, Furush_Hag_Detail.Zarf, Furush_Hag_Detail.Vazn_Kol,  Furush_Hag_Detail.Fee, Furush_Hag_Detail.Jam_Kol,Furush_Hag_Detail.Sanad_ID,Furush_Hag_Detail.kargari,Furush_Hag_Detail.jamkol_ba_kargari, Moshtari.Name + ' ' + Moshtari.Family AS Moshtari_Name, Kala.Name AS Kala_Name,   Furush_Hag_Detail.Sanad_ID,Furush_Hag_Detail.Daryaft_ID,Furush_Hag_Detail.Tedad as tafazol_tedad,Furush_Hag_Detail.Vazn_Ba_Zarf as tafazol_vazn, Furush_Hag_Detail.Kala_ID AS prekala_id,NULL AS Row_Index,daryaftpardakht.mablagh as pardakhti,daryaftpardakht.ID as pardakht_dp_id    FROM         Furush_Hag_Detail INNER JOIN   Moshtari ON Furush_Hag_Detail.Moshtari_ID = Moshtari.ID INNER JOIN   Kala ON Furush_Hag_Detail.Kala_ID = Kala.ID INNER JOIN   Furush_Hag ON Furush_Hag_Detail.Furush_Hug_ID = Furush_Hag.ID   left outer join Furush_Hag_Detail_DP  ON Furush_Hag_Detail.ID=Furush_Hag_Detail_DP.Furush_Hag_Detail_ID  left outer join daryaftpardakht  ON Furush_Hag_Detail_DP.dp_ID=daryaftpardakht.ID   where Furush_Hag.ID=" + Conversions.ToString(ID));
			decimal num = 0m;
			dataTable.Columns.Add("avg", typeof(decimal));
			try
			{
				IEnumerator enumerator = dataTable.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					bool flag = dataRow["vazn_ba_zarf"] == DBNull.Value;
					if (!flag)
					{
						flag = (dataRow["tedad"] == DBNull.Value);
						if (!flag)
						{
							flag = Operators.ConditionalCompareObjectEqual(dataRow["tedad"], 0, false);
							if (!flag)
							{
								num = decimal.Round(Conversions.ToDecimal(Operators.DivideObject(dataRow["vazn_ba_zarf"], dataRow["tedad"])), 2);
								dataRow["avg"] = num;
							}
						}
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
			return dataTable;
		}

		// Token: 0x0600029F RID: 671 RVA: 0x0003342C File Offset: 0x0003162C
		public long GetNewID()
		{
			return Conversions.ToLong(Public_Function.ExecuteScalar("select isnull(max(Num),0)+1 from dbo.Furush_Hag"));
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x00033450 File Offset: 0x00031650
		public long GetNavigateID(Furush_Hag.NavTo nav, long num)
		{
			string empty = string.Empty;
			long result;
			switch (nav)
			{
			case Furush_Hag.NavTo.forward:
				result = Conversions.ToLong(Public_Function.ExecuteScalar("SELECT TOP 1 Num FROM dbo.Furush_Hag   WHERE Num > " + Conversions.ToString(num) + " ORDER BY Num ASC"));
				break;
			case Furush_Hag.NavTo.backward:
				result = Conversions.ToLong(Public_Function.ExecuteScalar("SELECT TOP 1 Num FROM dbo.Furush_Hag   WHERE Num < " + Conversions.ToString(num) + " ORDER BY Num DESC"));
				break;
			case Furush_Hag.NavTo.first:
				result = Conversions.ToLong(Public_Function.ExecuteScalar(" SELECT isnull(MIN(Num),1) FROM dbo.Furush_Hag"));
				break;
			case Furush_Hag.NavTo.last:
				result = Conversions.ToLong(Public_Function.ExecuteScalar("SELECT isnull(MAX(Num),1) FROM dbo.Furush_Hag"));
				break;
			case Furush_Hag.NavTo.nextopen:
				result = Conversions.ToLong(Public_Function.ExecuteScalar(" SELECT  Furush_Hag.Num FROM    Furush_Hag LEFT OUTER JOIN  Safi_Furush ON Furush_Hag.ID = Safi_Furush.Furush_Hag_ID WHERE Num > " + Conversions.ToString(num) + " and safi_furush.id is null ORDER BY Num ASC"));
				break;
			}
			return result;
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x00033520 File Offset: 0x00031720
		public DataTable GetAll()
		{
			return Public_Function.FillData("Select dbo.Furush_Hag.ID,dbo.Furush_Hag.Num,dbo.Furush_Hag.Moshtari_ID,dbo.Furush_Hag.Sh_Mashin,dbo.Furush_Hag.Sh_Barname,dbo.Furush_Hag.Tarikh_Vurud,dbo.Furush_Hag.[Desc],dbo.Furush_Hag.Baskul,Baskul_Mabda,dbo.Furush_Hag.Tedad_Kol,dbo.Furush_Hag.Keraye,dbo.Furush_Hag.Hazine,dbo.Furush_Hag.Tarikh_Keraye,dbo.Furush_Hag.Tarikh_Hazine,dbo.Furush_Hag.Tarikh_Keraye_Fa,dbo.Furush_Hag.Tarikh_Hazine_Fa From dbo.Furush_Hag");
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x0003353C File Offset: 0x0003173C
		public void UpdateSanadFurushNaghdByID(long id)
		{
			long value = Conversions.ToLong(Public_Function.ExecuteScalar("select num from furush_hag where id=" + Conversions.ToString(id)));
			this.UpdateSanadFurushNaghd(Conversions.ToString(value));
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x0002C50C File Offset: 0x0002A70C
		private object IsTekrari(DataTable dt, int pos, long Daryaft_id)
		{
			checked
			{
				object result;
				for (int i = 0; i <= pos; i++)
				{
					bool flag = dt.Rows[i]["daryaft_id"] == DBNull.Value;
					if (!flag)
					{
						flag = Operators.ConditionalCompareObjectEqual(dt.Rows[i]["daryaft_id"], Daryaft_id, false);
						if (flag)
						{
							result = true;
							return result;
						}
					}
				}
				result = false;
				return result;
			}
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x00033574 File Offset: 0x00031774
		public void UpdateSanadNaghd_FactorFurush(string tarikh)
		{
			DataTable dataTable = Public_Function.FillData("SELECT   max(Furush_Hag.ID) AS furush_id, Furush_Hag.num, SUM(Furush_Hag_Detail .Jam_Kol) AS Jam_Kol,SUM(Furush_Hag_Detail.JamKol_ba_kargari) AS JamKol_ba_kargari, Furush_Hag_Detail.Tarikh  ,max(Daryaft_ID) AS Daryaft_ID   FROM         Furush_Hag_Detail INNER JOIN  Furush_Hag ON Furush_Hag_Detail.Furush_Hug_ID  = Furush_Hag.ID  where Furush_Hag_Detail.Tarikh = " + Public_Function.GetValue(Public_Function.ShamsiToMiladi(tarikh)) + " and Furush_Hag_Detail.Moshtari_id=-1   GROUP BY  Furush_Hag_Detail.Tarikh,Furush_Hag.num");
			string text = "declare @daryaft_id bigint;declare @sanadbed_id bigint;declare @sanadbes_id bigint;declare @id bigint;";
			int num = -1;
			checked
			{
				try
				{
					IEnumerator enumerator = dataTable.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						bool flag = dataRow["Daryaft_ID"] == DBNull.Value || Operators.ConditionalCompareObjectEqual(this.IsTekrari(dataTable, num, Conversions.ToLong(dataRow["daryaft_Id"])), true, false);
						if (flag)
						{
							bool flag2 = !Conversions.ToBoolean(Public_Function.dict["kargari"]);
							if (flag2)
							{
								text += this.Daryaft.AddRowStrToDaryaft(Public_Function.MiladiToShamsi(Conversions.ToDate(dataRow["Tarikh"])), Conversions.ToString(dataRow["Jam_Kol"]), Conversions.ToString(Operators.ConcatenateObject("فروش حق العمل شماره ", dataRow["num"])), DaryaftPardakht.CodeHesab.فروش_نقد_حق_العملکاری);
							}
							else
							{
								text += this.Daryaft.AddRowStrToDaryaft(Public_Function.MiladiToShamsi(Conversions.ToDate(dataRow["Tarikh"])), Conversions.ToString(dataRow["JamKol_ba_kargari"]), Conversions.ToString(Operators.ConcatenateObject("فروش حق العمل شماره ", dataRow["num"])), DaryaftPardakht.CodeHesab.فروش_نقد_حق_العملکاری);
							}
							text += "select @daryaft_id = scope_identity();";
							text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("update Furush_Hag_Detail set daryaft_id=@daryaft_id where [Furush_Hug_ID]=", dataRow["furush_id"]), " and Furush_Hag_Detail.Moshtari_id=-1 and tarikh='"), dataRow["tarikh"]), "';")));
						}
						else
						{
							bool flag2 = !Conversions.ToBoolean(Public_Function.dict["kargari"]);
							if (flag2)
							{
								text += this.Daryaft.UpdateRowStrToDaryaft(Public_Function.MiladiToShamsi(Conversions.ToDate(dataRow["Tarikh"])), Conversions.ToString(dataRow["Jam_Kol"]), Conversions.ToString(Operators.ConcatenateObject("فروش حق العمل شماره ", dataRow["num"])), Conversions.ToString(dataRow["daryaft_id"]), DaryaftPardakht.CodeHesab.فروش_نقد_حق_العملکاری);
							}
							else
							{
								text += this.Daryaft.UpdateRowStrToDaryaft(Public_Function.MiladiToShamsi(Conversions.ToDate(dataRow["Tarikh"])), Conversions.ToString(dataRow["JamKol_ba_kargari"]), Conversions.ToString(Operators.ConcatenateObject("فروش حق العمل شماره ", dataRow["num"])), Conversions.ToString(dataRow["daryaft_id"]), DaryaftPardakht.CodeHesab.فروش_نقد_حق_العملکاری);
							}
							text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("update Furush_Hag_Detail set daryaft_id=", dataRow["daryaft_id"]), " where [Furush_Hug_ID]="), dataRow["furush_id"]), " and Furush_Hag_Detail.Moshtari_id=-1 and tarikh='"), dataRow["tarikh"]), "';")));
						}
						num++;
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
				Public_Function.ExecuteNonQuery(text);
			}
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x000338D0 File Offset: 0x00031AD0
		public void UpdateSanadFurushNaghd(string num)
		{
			DataTable dataTable = Public_Function.FillData("SELECT     SUM(Furush_Hag_Detail.Jam_Kol) AS Jam_Kol,isnull(SUM(Furush_Hag_Detail.JamKol_ba_kargari),0) AS JamKol_ba_kargari, Furush_Hag_Detail.Tarikh,max(Daryaft_ID) AS Daryaft_ID  FROM         Furush_Hag_Detail INNER JOIN  Furush_Hag ON Furush_Hag_Detail.Furush_Hug_ID = Furush_Hag.ID  where Furush_Hag.Num=" + num + " and Furush_Hag_Detail.Moshtari_id=-1 GROUP BY  Furush_Hag_Detail.Tarikh");
			string text = "declare @daryaft_id bigint;declare @sanadbed_id bigint;declare @sanadbes_id bigint;declare @id bigint;select top 1 @id=id from furush_hag where num=" + num + "order by id ;";
			int num2 = -1;
			checked
			{
				try
				{
					IEnumerator enumerator = dataTable.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						bool flag = dataRow["Daryaft_ID"] == DBNull.Value || Operators.ConditionalCompareObjectEqual(this.IsTekrari(dataTable, num2, Conversions.ToLong(dataRow["daryaft_Id"])), true, false);
						if (flag)
						{
							bool flag2 = !Conversions.ToBoolean(Public_Function.dict["kargari"]);
							if (flag2)
							{
								text += this.Daryaft.AddRowStrToDaryaft(Public_Function.MiladiToShamsi(Conversions.ToDate(dataRow["Tarikh"])), Conversions.ToString(dataRow["Jam_Kol"]), "سند شماره " + num, DaryaftPardakht.CodeHesab.فروش_نقد_حق_العملکاری);
							}
							else
							{
								text += this.Daryaft.AddRowStrToDaryaft(Public_Function.MiladiToShamsi(Conversions.ToDate(dataRow["Tarikh"])), Conversions.ToString(dataRow["Jamkol_ba_kargari"]), "سند شماره " + num, DaryaftPardakht.CodeHesab.فروش_نقد_حق_العملکاری);
							}
							text += "select @daryaft_id = scope_identity();";
							text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("update Furush_Hag_Detail set daryaft_id=@daryaft_id where [Furush_Hug_ID]=@id and Furush_Hag_Detail.Moshtari_id=-1 and tarikh='", dataRow["tarikh"]), "';")));
						}
						else
						{
							bool flag2 = !Conversions.ToBoolean(Public_Function.dict["kargari"]);
							if (flag2)
							{
								text += this.Daryaft.UpdateRowStrToDaryaft(Public_Function.MiladiToShamsi(Conversions.ToDate(dataRow["Tarikh"])), Conversions.ToString(dataRow["Jam_Kol"]), "سند شماره " + num, Conversions.ToString(dataRow["daryaft_id"]), DaryaftPardakht.CodeHesab.فروش_نقد_حق_العملکاری);
							}
							else
							{
								text += this.Daryaft.UpdateRowStrToDaryaft(Public_Function.MiladiToShamsi(Conversions.ToDate(dataRow["Tarikh"])), Conversions.ToString(dataRow["JamKol_ba_kargari"]), "سند شماره " + num, Conversions.ToString(dataRow["daryaft_id"]), DaryaftPardakht.CodeHesab.فروش_نقد_حق_العملکاری);
							}
							text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("update Furush_Hag_Detail set daryaft_id=", dataRow["daryaft_id"]), " where [Furush_Hug_ID]=@id and Furush_Hag_Detail.Moshtari_id=-1 and tarikh='"), dataRow["tarikh"]), "';")));
						}
						num2++;
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
				Public_Function.ExecuteNonQuery(text);
			}
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x00033BBC File Offset: 0x00031DBC
		public long Insert(string Num, string Moshtari_ID, string Sh_Mashin, string Sh_Barname, string Tarikh_Vurud, string Desc, string Baskul, string Baskul_Mabda, string Tedad_Kol, string nahve_furush, DataTable dt)
		{
			string tozih = string.Empty;
			string text = "declare @id bigint;declare @sanad_id int;declare @codehesab_id int;declare @sanadbed_id int;declare @sanadbes_id int;declare @daryaft_id int;declare @keraye_pardakht_id int;declare @hazine_pardakht_id int;";
			string right = string.Empty;
			text = string.Concat(new string[]
			{
				text,
				" Insert Into dbo.Furush_Hag(Num,Moshtari_ID,Sh_Mashin,Sh_Barname,Tarikh_Vurud,[Desc],Baskul,Baskul_Mabda,Tedad_Kol,nahve_furush) VALUES(",
				Num,
				",",
				Moshtari_ID,
				",",
				Public_Function.GetValue(Sh_Mashin),
				",",
				Public_Function.GetValue(Sh_Barname),
				",",
				Public_Function.GetValue(Tarikh_Vurud),
				",",
				Public_Function.GetValue(Desc),
				",",
				Public_Function.GetValueInt(Baskul),
				",",
				Public_Function.GetValueInt(Baskul_Mabda),
				",",
				Public_Function.GetValueInt(Tedad_Kol),
				",",
				Public_Function.GetValue(nahve_furush),
				");Select @id=Scope_Identity();"
			});
			try
			{
				IEnumerator enumerator = dt.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					tozih = " فروش سند " + Num;
					bool flag = Operators.ConditionalCompareObjectNotEqual(dataRow["Moshtari_ID"], -1, false) && Operators.ConditionalCompareObjectNotEqual(dataRow["Moshtari_ID"], -2, false) && Operators.ConditionalCompareObjectNotEqual(dataRow["Moshtari_ID"], -3, false);
					if (flag)
					{
						text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("select @codehesab_id=Codehesab_id from Moshtari where id=", dataRow["Moshtari_ID"]), ";")));
						flag = !Conversions.ToBoolean(Public_Function.dict["kargari"]);
						if (flag)
						{
							text += this.Sanad.InsertStr("@codehesab_id", dataRow["Jam_Kol"].ToString(), "0", dataRow["Tarikh_Fa"].ToString(), tozih, Sanad.SanadType.فروش_حق_العمل);
						}
						else
						{
							text += this.Sanad.InsertStr("@codehesab_id", dataRow["Jamkol_ba_kargari"].ToString(), "0", dataRow["Tarikh_Fa"].ToString(), tozih, Sanad.SanadType.فروش_حق_العمل);
						}
						text += "Select @Sanad_id=Scope_Identity();";
					}
					if (Operators.ConditionalCompareObjectEqual(dataRow["moshtari_id"], -1, false) || Operators.ConditionalCompareObjectEqual(dataRow["moshtari_id"], -2, false))
					{
						goto IL_2CF;
					}
					if (Operators.ConditionalCompareObjectEqual(dataRow["Moshtari_ID"], -3, false))
					{
						goto IL_2CF;
					}
					bool arg_2D1_0 = false;
					IL_2D0:
					flag = arg_2D1_0;
					if (flag)
					{
						right = "NULL";
					}
					else
					{
						right = "@sanad_id";
					}
					text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Insert Into dbo.Furush_Hag_Detail(Furush_Hug_ID,Moshtari_ID,Kala_ID,Tarikh,Tarikh_Fa,Tedad,Vazn_Ba_Zarf,Zarf,Vazn_Kol,Fee,Jam_Kol,Sanad_ID,daryaft_id,kargari,jamkol_ba_kargari) VALUES(@id,", dataRow["Moshtari_ID"]), ","), dataRow["Kala_ID"]), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Conversions.ToString(dataRow["Tarikh_Fa"])))), ","), Public_Function.GetValue(Conversions.ToString(dataRow["Tarikh_Fa"]))), ","), Public_Function.GetValueInt(dataRow["Tedad"].ToString())), ","), Public_Function.GetValueInt(dataRow["Vazn_Ba_Zarf"].ToString())), ","), Public_Function.GetValueInt(dataRow["Zarf"].ToString())), ","), dataRow["Vazn_Kol"]), ","), dataRow["Fee"]), ","), dataRow["Jam_Kol"]), ","), right), ","), Interaction.IIf(Operators.ConditionalCompareObjectEqual(dataRow["Moshtari_ID"], -1, false), "@daryaft_id", "NULL")), ","), Public_Function.GetValueInt(dataRow["kargari"].ToString())), ","), Public_Function.GetValueInt(dataRow["jamkol_ba_kargari"].ToString())), ");")));
					continue;
					IL_2CF:
					arg_2D1_0 = true;
					goto IL_2D0;
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
			text += "select @id;";
			long result = Conversions.ToLong(Public_Function.ExecuteScalar(text));
			this.UpdateSanadFurushNaghd(Num);
			return result;
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x00034110 File Offset: 0x00032310
		public string AddRowStrNaghdMoshtari(string Furush_Hag_Detail_ID, string Tarikh, string Moshtari_id, string Mablagh, string Tozih, string Daryaft_id)
		{
			string text = string.Empty;
			bool flag = Operators.CompareString(Daryaft_id, string.Empty, false) == 0;
			string result;
			if (flag)
			{
				text = string.Concat(new string[]
				{
					text,
					" Insert Into dbo.DaryaftPardakht(dpType_ID,Tarikh,Moshtari_ID,Sandug_ID,Mablagh,Tozih,Tarikh_Fa) VALUES(4,",
					Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh)),
					",",
					Moshtari_id,
					",1,",
					Mablagh,
					",",
					Public_Function.GetValue(Tozih),
					",",
					Public_Function.GetValue(Tarikh),
					");select @pardakht_dp_id=scope_identity();"
				});
				text += this.Sanad.InsertStr(Conversions.ToString(1), Mablagh, Conversions.ToString(0), Tarikh, Tozih, Sanad.SanadType.@null);
				text += " select @sanadbed_id2=scope_identity();";
				text += this.Sanad.InsertStr("@codehesab_id", Conversions.ToString(0), Mablagh, Tarikh, Tozih, Sanad.SanadType.@null);
				text += " select @sanadbes_id2=scope_identity();";
				text = string.Concat(new string[]
				{
					text,
					" Insert Into dbo.DaryaftPardakht(dpType_ID,Tarikh,sanadbed_id,sanadbes_id,Moshtari_ID,Sandug_ID,Mablagh,Tozih,Tarikh_Fa,parent_id) VALUES(1,",
					Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh)),
					",@sanadbed_id2,@sanadbes_id2,",
					Moshtari_id,
					",1,",
					Mablagh,
					",",
					Public_Function.GetValue(Tozih),
					",",
					Public_Function.GetValue(Tarikh),
					", @pardakht_dp_id);"
				});
				text = text + " insert into Furush_Hag_Detail_DP (Furush_Hag_Detail_ID,dp_id) values ( " + Furush_Hag_Detail_ID + ",@pardakht_dp_id) ";
				result = text;
			}
			else
			{
				text = text + " select @pardakht_dp_id=" + Daryaft_id + ";";
				text = text + "select @sanadbed_id2=sanadbed_id , @sanadbes_id2=sanadbes_id from daryaftPardakht where parent_id= " + Daryaft_id;
				text += this.Sanad.UpdateStr(Conversions.ToString(1), Mablagh, Conversions.ToString(0), Tarikh, Tozih, "@sanadbed_id2", Sanad.SanadType.@null);
				text += this.Sanad.UpdateStr("@codehesab_id", Conversions.ToString(0), Mablagh, Tarikh, Tozih, "@SanadBes_ID2", Sanad.SanadType.@null);
				text = string.Concat(new string[]
				{
					text,
					"Update dbo.DaryaftPardakht SET dptype_id=4 ,Tarikh=",
					Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh)),
					" ,Moshtari_ID= ",
					Moshtari_id,
					" ,Sandug_ID=1 ,Hazine_ID=Null ,Mablagh=",
					Mablagh,
					" ,Tozih=",
					Public_Function.GetValue(Tozih),
					" ,Tarikh_Fa=",
					Public_Function.GetValue(Tarikh),
					" ,[Sh_Check] = null  ,[CheckBank_ID] = null  ,[Check_Shobe] = null  ,[Check_Sarresid] = null  ,[Check_Sarresid_Fa] = null  ,[Check_Status] =null  ,[Sh_Fish] = null  ,[FishVariz] = null  ,[FishVariz_Fa] = null  Where ID=",
					Daryaft_id,
					";"
				});
				text = string.Concat(new string[]
				{
					text,
					"Update dbo.DaryaftPardakht SET dptype_id=1 ,Tarikh=",
					Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh)),
					" ,Moshtari_ID= ",
					Moshtari_id,
					" ,Sandug_ID=1 ,Hazine_ID=Null ,Mablagh=",
					Mablagh,
					" ,Tozih=",
					Public_Function.GetValue(Tozih),
					" ,Tarikh_Fa=",
					Public_Function.GetValue(Tarikh),
					" ,[Sh_Check] = null  ,[CheckBank_ID] = null  ,[Check_Shobe] = null  ,[Check_Sarresid] = null  ,[Check_Sarresid_Fa] = null  ,[Check_Status] =null  ,[Sh_Fish] = null  ,[FishVariz] = null  ,[FishVariz_Fa] = null  Where parent_ID=",
					Daryaft_id,
					";"
				});
				result = text;
			}
			return result;
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x00034444 File Offset: 0x00032644
		public void Update(string ID, string Num, string Moshtari_ID, string Sh_Mashin, string Sh_Barname, string Tarikh_Vurud, string Desc, string Baskul, string Baskul_Mabda, string Tedad_Kol, string nahve_furush, DataTable dt)
		{
			string iD = Public_Function.GetID(dt, "ID", "");
			string tozih = string.Empty;
			string text = "declare @sanad_id int;declare @codehesab_id int;declare @sanadbed_id int;declare @sanadbes_id int;declare @sanadbed_id2 int;declare @sanadbes_id2 int;declare @daryaft_id int;declare @keraye_pardakht_id int;declare @hazine_pardakht_id int;;declare @pardakht_dp_id int;declare @hag_detail_id int;";
			DataTable dataTable = Public_Function.FillData("select distinct daryaft_id as id from furush_hag_detail where furush_hug_id=" + ID + " and daryaft_id is not null");
			string right = string.Empty;
			text = string.Concat(new string[]
			{
				text,
				" Update dbo.Furush_Hag SET Num=",
				Num,
				" ,Moshtari_ID=",
				Moshtari_ID,
				" ,Sh_Mashin=",
				Public_Function.GetValue(Sh_Mashin),
				" ,Sh_Barname=",
				Public_Function.GetValue(Sh_Barname),
				" ,Tarikh_Vurud=",
				Public_Function.GetValue(Tarikh_Vurud),
				" ,[Desc]=",
				Public_Function.GetValue(Desc),
				" ,Baskul=",
				Public_Function.GetValueInt(Baskul),
				" ,Baskul_Mabda=",
				Public_Function.GetValueInt(Baskul_Mabda),
				" ,Tedad_Kol=",
				Public_Function.GetValueInt(Tedad_Kol),
				" ,nahve_furush=",
				Public_Function.GetValue(nahve_furush),
				" Where ID=",
				ID
			});
			bool flag = iD.Length > 0;
			if (flag)
			{
				text = string.Concat(new string[]
				{
					text,
					"Delete From dbo.Furush_Hag_Detail Where Furush_Hug_ID=",
					ID,
					" AND ID NOT IN(",
					iD,
					");"
				});
			}
			else
			{
				text = text + "Delete From dbo.Furush_Hag_Detail Where Furush_Hug_ID=" + ID + ";";
			}
			bool flag3;
			try
			{
				IEnumerator enumerator = dt.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					flag = (dataRow["ID"] == DBNull.Value);
					bool flag2;
					if (!flag)
					{
						flag2 = (Operators.ConditionalCompareObjectNotEqual(dataRow["Moshtari_ID"], -1, false) && Operators.ConditionalCompareObjectNotEqual(dataRow["moshtari_ID"], -2, false) && Operators.ConditionalCompareObjectNotEqual(dataRow["moshtari_ID"], -3, false));
						if (!flag2)
						{
							if (Operators.ConditionalCompareObjectEqual(dataRow["moshtari_id"], -1, false) || Operators.ConditionalCompareObjectEqual(dataRow["moshtari_id"], -2, false))
							{
								goto IL_9B8;
							}
							if (Operators.ConditionalCompareObjectEqual(dataRow["moshtari_id"], -3, false))
							{
								goto IL_9B8;
							}
							bool arg_9BA_0 = false;
							IL_9B9:
							flag2 = arg_9BA_0;
							if (flag2)
							{
								flag = (Operators.ConditionalCompareObjectEqual(dataRow["moshtari_id"], -2, false) || Operators.ConditionalCompareObjectEqual(dataRow["moshtari_id"], -3, false));
								if (flag)
								{
									flag3 = (dataRow["Daryaft_ID"] != DBNull.Value);
									if (flag3)
									{
										text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("update Furush_Hag_Detail set daryaft_id=null where id=", dataRow["ID"]), ";")));
									}
								}
								flag3 = (dataRow["sanad_id"] != DBNull.Value);
								if (flag3)
								{
									string text2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("update Furush_Hag_Detail set sanad_id=null where id=", dataRow["ID"]), ";"));
									text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(" delete from sanad where id=", dataRow["sanad_id"]), ";")));
									Public_Function.ExecuteNonQuery(text2);
								}
								goto IL_AC8;
							}
							goto IL_AC8;
							IL_9B8:
							arg_9BA_0 = true;
							goto IL_9B9;
						}
						flag = (dataRow["Daryaft_ID"] != DBNull.Value);
						if (flag)
						{
							text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("update Furush_Hag_Detail set daryaft_id=null where id=", dataRow["ID"]), ";")));
						}
						tozih = " فروش سند " + Num;
						text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("select @codehesab_id=Codehesab_id from Moshtari where id=", dataRow["Moshtari_ID"]), ";")));
						flag2 = (dataRow["Sanad_ID"] != DBNull.Value);
						if (flag2)
						{
							flag = !Conversions.ToBoolean(Public_Function.dict["kargari"]);
							if (flag)
							{
								text += this.Sanad.UpdateStr("@codehesab_id", Conversions.ToString(dataRow["Jam_Kol"]), Conversions.ToString(0), Conversions.ToString(dataRow["Tarikh_Fa"]), tozih, Conversions.ToString(dataRow["Sanad_ID"]), Sanad.SanadType.فروش_حق_العمل);
							}
							else
							{
								text += this.Sanad.UpdateStr("@codehesab_id", Conversions.ToString(dataRow["JamKol_ba_kargari"]), Conversions.ToString(0), Conversions.ToString(dataRow["Tarikh_Fa"]), tozih, Conversions.ToString(dataRow["Sanad_ID"]), Sanad.SanadType.فروش_حق_العمل);
							}
							text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject("select @sanad_id=", dataRow["Sanad_ID"])));
						}
						else
						{
							flag2 = !Conversions.ToBoolean(Public_Function.dict["kargari"]);
							if (flag2)
							{
								text += this.Sanad.InsertStr("@codehesab_id", dataRow["Jam_Kol"].ToString(), "0", Conversions.ToString(dataRow["Tarikh_Fa"]), tozih, Sanad.SanadType.فروش_حق_العمل);
							}
							else
							{
								text += this.Sanad.InsertStr("@codehesab_id", dataRow["JamKol_ba_kargari"].ToString(), "0", Conversions.ToString(dataRow["Tarikh_Fa"]), tozih, Sanad.SanadType.فروش_حق_العمل);
							}
							text += "Select @Sanad_id=Scope_Identity();";
						}
						flag2 = (dataRow["pardakhti"] != DBNull.Value && dataRow["pardakhti"] != null);
						if (flag2)
						{
							text += this.AddRowStrNaghdMoshtari(Conversions.ToString(dataRow["id"]), Conversions.ToString(dataRow["Tarikh_Fa"]), Conversions.ToString(dataRow["Moshtari_ID"]), Conversions.ToString(dataRow["pardakhti"]), "دریافت نقد", dataRow["pardakht_dp_id"].ToString());
						}
						else
						{
							flag2 = (dataRow["pardakht_dp_id"] != DBNull.Value);
							if (flag2)
							{
								this.Daryaft.DeleteDaryaftPardakhtRadifExtend(Conversions.ToString(dataRow["pardakht_dp_id"]), string.Empty, string.Empty, string.Empty);
							}
						}
						IL_AC8:
						if (Operators.ConditionalCompareObjectEqual(dataRow["moshtari_ID"], -1, false) || Operators.ConditionalCompareObjectEqual(dataRow["moshtari_ID"], -2, false))
						{
							goto IL_B1E;
						}
						if (Operators.ConditionalCompareObjectEqual(dataRow["moshtari_ID"], -3, false))
						{
							goto IL_B1E;
						}
						bool arg_B20_0 = false;
						IL_B1F:
						flag3 = arg_B20_0;
						if (flag3)
						{
							right = "NULL";
						}
						else
						{
							right = "@sanad_ID";
						}
						text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Update dbo.Furush_Hag_Detail SET Moshtari_ID=", dataRow["Moshtari_ID"]), " ,Kala_ID="), dataRow["Kala_ID"]), " ,Tarikh="), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Conversions.ToString(dataRow["Tarikh_Fa"])))), " ,Tarikh_Fa="), Public_Function.GetValue(Conversions.ToString(dataRow["Tarikh_Fa"]))), " ,Tedad="), Public_Function.GetValueInt(dataRow["Tedad"].ToString())), " ,Vazn_Ba_Zarf="), Public_Function.GetValueInt(dataRow["Vazn_Ba_Zarf"].ToString())), " ,Zarf="), Public_Function.GetValueInt(dataRow["Zarf"].ToString())), " ,Vazn_Kol="), dataRow["Vazn_Kol"]), " ,Fee="), dataRow["Fee"]), " ,Jam_Kol="), dataRow["Jam_Kol"]), " , Sanad_ID="), right), " , kargari="), Public_Function.GetValueInt(dataRow["kargari"].ToString())), " , jamkol_ba_kargari="), Public_Function.GetValueInt(dataRow["jamkol_ba_kargari"].ToString())), " Where ID="), dataRow["ID"]), ";")));
						continue;
						IL_B1E:
						arg_B20_0 = true;
						goto IL_B1F;
					}
					flag2 = (Operators.ConditionalCompareObjectNotEqual(dataRow["Moshtari_ID"], -1, false) && Operators.ConditionalCompareObjectNotEqual(dataRow["moshtari_id"], -2, false) && Operators.ConditionalCompareObjectNotEqual(dataRow["moshtari_ID"], -3, false));
					if (flag2)
					{
						tozih = " فروش سند " + Num;
						text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("select @codehesab_id=Codehesab_id from Moshtari where id=", dataRow["Moshtari_ID"]), ";")));
						flag2 = !Conversions.ToBoolean(Public_Function.dict["kargari"]);
						if (flag2)
						{
							text += this.Sanad.InsertStr("@codehesab_id", dataRow["Jam_Kol"].ToString(), "0", dataRow["Tarikh_Fa"].ToString(), tozih, Sanad.SanadType.فروش_حق_العمل);
						}
						else
						{
							text += this.Sanad.InsertStr("@codehesab_id", dataRow["JamKol_ba_kargari"].ToString(), "0", dataRow["Tarikh_Fa"].ToString(), tozih, Sanad.SanadType.فروش_حق_العمل);
						}
						text += "Select @Sanad_id=Scope_Identity();";
						right = "@sanad_id";
					}
					else
					{
						right = "NULL";
					}
					text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Insert Into dbo.Furush_Hag_Detail(Furush_Hug_ID,Moshtari_ID,Kala_ID,Tarikh,Tarikh_Fa,Tedad,Vazn_Ba_Zarf,Zarf,Vazn_Kol,Fee,Jam_Kol,Sanad_ID,daryaft_id,kargari,jamkol_ba_kargari) VALUES(" + ID + ",", dataRow["Moshtari_ID"]), ","), dataRow["Kala_ID"]), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Conversions.ToString(dataRow["Tarikh_Fa"])))), ","), Public_Function.GetValue(Conversions.ToString(dataRow["Tarikh_Fa"]))), ","), Public_Function.GetValueInt(dataRow["Tedad"].ToString())), ","), Public_Function.GetValueInt(dataRow["Vazn_Ba_Zarf"].ToString())), ","), Public_Function.GetValueInt(dataRow["Zarf"].ToString())), ","), Public_Function.GetValueInt(Conversions.ToString(dataRow["Vazn_Kol"]))), ","), dataRow["Fee"]), ","), dataRow["Jam_Kol"]), ","), right), ",@daryaft_id"), ","), Public_Function.GetValueInt(dataRow["kargari"].ToString())), ","), Public_Function.GetValueInt(dataRow["jamkol_ba_kargari"].ToString())), ");select @hag_detail_id=scope_identity();")));
					flag2 = (Operators.ConditionalCompareObjectNotEqual(dataRow["Moshtari_ID"], -1, false) && Operators.ConditionalCompareObjectNotEqual(dataRow["Moshtari_ID"], -3, false));
					if (flag2)
					{
						flag = (dataRow["pardakhti"] != DBNull.Value && dataRow["pardakhti"] != null);
						if (flag)
						{
							text += this.AddRowStrNaghdMoshtari("@hag_detail_id", Conversions.ToString(dataRow["Tarikh_Fa"]), Conversions.ToString(dataRow["Moshtari_ID"]), Conversions.ToString(dataRow["pardakhti"]), "دریافت نقد", dataRow["pardakht_dp_id"].ToString());
						}
					}
				}
			}
			finally
			{
				IEnumerator enumerator;
				flag3 = (enumerator is IDisposable);
				if (flag3)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			Public_Function.ExecuteNonQuery(text);
			this.UpdateSanadFurushNaghd(Num);
			flag3 = (dataTable.Rows.Count > 0);
			if (flag3)
			{
				DataTable dataTable2 = Public_Function.FillData("select distinct daryaft_id as id from furush_hag_detail where furush_hug_id=" + ID + " and daryaft_id is Not null");
				flag3 = (dataTable2.Rows.Count > 0);
				if (flag3)
				{
					DataTable dataTable3 = Public_Function.FillData(string.Concat(new string[]
					{
						"select id from daryaftpardakht where id in(",
						Public_Function.GetID(dataTable, "id", ""),
						") and id not in(",
						Public_Function.GetID(dataTable2, "id", ""),
						")"
					}));
					string text3 = "declare @sanad_id int;declare @daryaft_id int;declare @sanadbes_id int;declare @sanadbed_id int;";
					try
					{
						IEnumerator enumerator2 = dataTable3.Rows.GetEnumerator();
						while (enumerator2.MoveNext())
						{
							DataRow dataRow2 = (DataRow)enumerator2.Current;
							text3 = Conversions.ToString(Operators.ConcatenateObject(text3, Operators.ConcatenateObject(Operators.ConcatenateObject(" select @sanadbed_id=sanadbed_id,@sanadbes_id=sanadbes_id from daryaftpardakht where id=", dataRow2["id"]), ";")));
							text3 = Conversions.ToString(Operators.ConcatenateObject(text3, Operators.ConcatenateObject(Operators.ConcatenateObject("update daryaftpardakht set sanadbes_id=null,sanadbed_id=null where id=", dataRow2["id"]), ";")));
							text3 += "delete from sanad where id =@sanadbed_id;";
							text3 += "delete from sanad where id=@sanadbes_id;";
							text3 = Conversions.ToString(Operators.ConcatenateObject(text3, Operators.ConcatenateObject(Operators.ConcatenateObject("delete from daryaftpardakht where id=", dataRow2["id"]), ";")));
							Public_Function.ExecuteNonQuery(text3);
						}
					}
					finally
					{
						IEnumerator enumerator2;
						flag3 = (enumerator2 is IDisposable);
						if (flag3)
						{
							(enumerator2 as IDisposable).Dispose();
						}
					}
				}
				else
				{
					string text4 = "declare @sanad_id int;declare @daryaft_id int;declare @sanadbes_id int;declare @sanadbed_id int;";
					try
					{
						IEnumerator enumerator3 = dataTable.Rows.GetEnumerator();
						while (enumerator3.MoveNext())
						{
							DataRow dataRow3 = (DataRow)enumerator3.Current;
							text4 = Conversions.ToString(Operators.ConcatenateObject(text4, Operators.ConcatenateObject(Operators.ConcatenateObject(" select @sanadbed_id=sanadbed_id,@sanadbes_id=sanadbes_id from daryaftpardakht where id=", dataRow3["id"]), ";")));
							text4 = Conversions.ToString(Operators.ConcatenateObject(text4, Operators.ConcatenateObject(Operators.ConcatenateObject("update daryaftpardakht set sanadbes_id=null,sanadbed_id=null where id=", dataRow3["id"]), ";")));
							text4 += "delete from sanad where id =@sanadbed_id;";
							text4 += "delete from sanad where id=@sanadbes_id;";
							text4 = Conversions.ToString(Operators.ConcatenateObject(text4, Operators.ConcatenateObject(Operators.ConcatenateObject("delete from daryaftpardakht where id=", dataRow3["id"]), ";")));
							Public_Function.ExecuteNonQuery(text4);
						}
					}
					finally
					{
						IEnumerator enumerator3;
						flag3 = (enumerator3 is IDisposable);
						if (flag3)
						{
							(enumerator3 as IDisposable).Dispose();
						}
					}
				}
			}
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x000354AC File Offset: 0x000336AC
		public void Delete(string ID)
		{
			string text = string.Empty;
			string text2 = string.Empty;
			string text3 = string.Empty;
			string str = string.Empty;
			text = text + "delete from Kala_To_Kala_Furush where furush_id=" + ID + ";";
			DataTable dataTable = Public_Function.FillData("select sanad_id from furush_keraye where furush_id=" + ID + " AND Sanad_id is not null;");
			bool flag = dataTable.Rows.Count > 0;
			if (flag)
			{
				str = Public_Function.GetID(dataTable, "sanad_id", "");
				text = text + "delete from sanad where id in (" + str + ");";
			}
			DataTable dataTable2 = Public_Function.FillData("select * from furush_keraye where furush_id=" + ID);
			flag = (dataTable2.Rows.Count > 0);
			if (flag)
			{
				text3 = Public_Function.GetID(dataTable2, "keraye_pardakht_id", "");
				flag = (text3.Length > 0);
				if (flag)
				{
					DataTable dt = Public_Function.FillData(string.Concat(new string[]
					{
						"select sanadbed_id,sanadbes_id from daryaftpardakht where id in(",
						text3,
						") OR parent_id in (",
						text3,
						");"
					}));
					text2 = Public_Function.GetID(dt, "sanadbed_id", "");
					flag = (text2.Length > 0);
					if (flag)
					{
						text = text + "delete from sanad where id in (" + text2 + ");";
					}
					text2 = Public_Function.GetID(dt, "sanadbes_id", "");
					flag = (text2.Length > 0);
					if (flag)
					{
						text = text + "delete from sanad where id in(" + text2 + ");";
					}
					text = string.Concat(new string[]
					{
						text,
						"delete from daryaftpardakht where id in(",
						text3,
						") OR parent_id in (",
						text3,
						");"
					});
					Public_Function.ExecuteNonQuery(text);
				}
				text3 = Public_Function.GetID(dataTable2, "id", "");
				text = text + "delete from furush_keraye where id in (" + text3 + ")";
				Public_Function.ExecuteNonQuery(text);
				text = string.Empty;
			}
			text = text + " delete from [Furush_Hag_RizBar] where furush_hag_id=" + ID + ";";
			DataRow dataRow = Public_Function.FillDataRow("select * from safi_furush where furush_hag_id=" + ID);
			flag = (dataRow != null);
			if (flag)
			{
				text = text + "update safi_furush set sanad_id=null,karmozd_sanad_id=null where furush_hag_id=" + ID + ";";
				text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("delete from sanad where id in(", dataRow["sanad_id"]), ","), dataRow["karmozd_sanad_id"]), ");")));
				text = text + "delete from safi_furush where furush_hag_id=" + ID + ";";
				Public_Function.ExecuteNonQuery(text);
				text = string.Empty;
			}
			DataRow dataRow2 = Public_Function.FillDataRow("select * from furush_darsad where furush_id=" + ID);
			flag = (dataRow2 != null);
			if (flag)
			{
				text = text + "update furush_darsad set sanadbed_id=null,sanadbes_id=null where furush_id=" + ID + ";";
				text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("delete from sanad where id in(", dataRow2["sanadbed_id"]), ");")));
				text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("delete from sanad where id in(", dataRow2["sanadbes_id"]), ");")));
				text = text + "delete from furush_darsad where furush_id=" + ID + ";";
				Public_Function.ExecuteNonQuery(text);
				text = string.Empty;
			}
			DataTable dataTable3 = Public_Function.FillData("select * from furush_hag_detail where furush_hug_id=" + ID);
			flag = (dataTable3.Rows.Count > 0);
			checked
			{
				bool flag2;
				if (flag)
				{
					text2 = Public_Function.GetID(dataTable3, "sanad_id", "");
					text = text + " update furush_hag_detail set sanad_id=null where furush_hug_id= " + ID + ";";
					flag = (text2.Length > 0);
					if (flag)
					{
						text = text + "delete from sanad where id in(" + text2 + ");";
					}
					Public_Function.ExecuteNonQuery(text);
					text = string.Empty;
					string iD = Public_Function.GetID(dataTable3, "ID", "");
					text3 = Public_Function.GetID(dataTable3, "daryaft_id", "");
					flag = (Operators.CompareString(text3, string.Empty, false) != 0);
					if (flag)
					{
						DataTable dt = Public_Function.FillData("select * from daryaftPardakht where id in(" + text3 + ");");
						text2 = Public_Function.GetID(dt, "sanadbed_id", "");
						flag = (text2.Length > 0);
						if (flag)
						{
							text2 += ",";
						}
						text2 += Public_Function.GetID(dt, "sanadbes_id", "");
						flag = (text2.Length > 0);
						if (flag)
						{
							flag2 = (Operators.CompareString(text2.Substring(text2.Length - 1, 1), ",", false) == 0);
							if (flag2)
							{
								text2 = Public_Function.RemoveLast(text2);
							}
						}
						flag2 = (text2.Length > 0);
						if (flag2)
						{
							text = text + "update daryaftpardakht set sanadbed_id=null,sanadbes_id=null where id in(" + text3 + ");";
						}
						flag2 = (text2.Length > 0);
						if (flag2)
						{
							text = text + "delete from sanad where id in(" + text2 + ");";
						}
						text = text + "update furush_hag_detail set daryaft_id=null where id in(" + iD + ");";
					}
				}
				text = text + "Delete From dbo.Furush_Hag Where Id= " + ID + ";";
				Public_Function.ExecuteNonQuery(text);
				text = string.Empty;
				List<string> list = new List<string>();
				string[] array = text3.Split(new char[]
				{
					','
				});
				string[] array2 = array;
				for (int i = 0; i < array2.Length; i++)
				{
					string text4 = array2[i];
					flag2 = (Operators.CompareString(text4, string.Empty, false) == 0);
					if (!flag2)
					{
						flag2 = !list.Contains(text4);
						if (flag2)
						{
							list.Add(text4);
							long num = Conversions.ToLong(Public_Function.ExecuteScalar("select count(id) from Furush_Hag_Detail where daryaft_id =" + text4));
							flag2 = (num == 0L);
							if (flag2)
							{
								text = text + "delete from daryaftpardakht where id =" + text4 + ";";
							}
						}
					}
				}
				flag2 = (text.Length > 0);
				if (flag2)
				{
					Public_Function.ExecuteNonQuery(text);
				}
				try
				{
					List<string>.Enumerator enumerator = list.GetEnumerator();
					while (enumerator.MoveNext())
					{
						string current = enumerator.Current;
						string s = Conversions.ToString(Public_Function.ExecuteScalar("select isnull(sum(jam_kol),0) from furush_hag_detail where daryaft_id=" + current));
						Public_Function.ExecuteNonQuery("update daryaftpardakht set mablagh=" + Public_Function.GetValueInt(s) + " where id=" + current);
					}
				}
				finally
				{
					List<string>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
			}
		}

		// Token: 0x060002AA RID: 682 RVA: 0x00035B68 File Offset: 0x00033D68
		public void DeleteDetailByID(string id)
		{
			long value = Conversions.ToLong(Public_Function.ExecuteScalar("select isnull(daryaft_id,0) from furush_hag_Detail where id=" + id));
			long num = Conversions.ToLong(Public_Function.ExecuteScalar("select furush_hug_id from furush_hag_detail where id=" + id));
			string text = "declare @sanad_id int;declare @daryaft_id int;declare @sanadbes_id int;declare @sanadbed_id int;";
			text = text + "select @sanad_id=sanad_id , @daryaft_id=daryaft_id from furush_hag_detail where id=" + id + ";";
			text = text + "update furush_hag_detail set sanad_id=null,daryaft_id=null where id=" + id + ";";
			text += "delete from sanad where id=@sanad_id;";
			text = text + "delete from furush_hag_detail where id=" + id + ";";
			Public_Function.ExecuteNonQuery(text);
			int num2 = Conversions.ToInteger(Public_Function.ExecuteScalar("select isnull(count(id),0) from furush_hag_detail where furush_hug_id=" + Conversions.ToString(num) + " and daryaft_id=" + Conversions.ToString(value)));
			bool flag = num2 == 0;
			if (flag)
			{
				text = "declare @sanad_id int;declare @daryaft_id int;declare @sanadbes_id int;declare @sanadbed_id int;";
				text = text + "select @sanadbed_id=sanadbed_id,@sanadbes_id=sanadbes_id from daryaftpardakht where id= " + Conversions.ToString(value) + ";";
				text = text + "update daryaftpardakht set sanadbes_id=null,sanadbed_id=null where id=" + Conversions.ToString(value) + ";";
				text += "delete from sanad where id =@sanadbed_id;";
				text += "delete from sanad where id=@sanadbes_id;";
				text = text + "delete from daryaftpardakht where id=" + Conversions.ToString(value) + ";";
				Public_Function.ExecuteNonQuery(text);
			}
			this.UpdateSanadFurushNaghdByID(num);
		}

		// Token: 0x04000109 RID: 265
		private Sanad Sanad;

		// Token: 0x0400010A RID: 266
		private DaryaftPardakht Daryaft;

		// Token: 0x0200002A RID: 42
		public enum NavTo
		{
			// Token: 0x0400010C RID: 268
			forward = 1,
			// Token: 0x0400010D RID: 269
			backward,
			// Token: 0x0400010E RID: 270
			first,
			// Token: 0x0400010F RID: 271
			last,
			// Token: 0x04000110 RID: 272
			nextopen
		}
	}
}
