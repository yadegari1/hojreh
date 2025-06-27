using System;
using System.Collections;
using System.Data;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x02000031 RID: 49
	public class Kharid
	{
		// Token: 0x060002CE RID: 718 RVA: 0x000025F3 File Offset: 0x000007F3
		public Kharid()
		{
			this.iSanad = new Sanad();
			this.Daryaft = new DaryaftPardakht();
		}

		// Token: 0x060002CF RID: 719 RVA: 0x0003A7A0 File Offset: 0x000389A0
		public DataRow GetByID(long Num)
		{
			return Public_Function.FillDataRow("SELECT     Kharid.*, Moshtari.Name+' '+ Moshtari.Family AS Moshtari_Name  FROM         Kharid LEFT OUTER JOIN   Moshtari ON Kharid.Moshtari_ID = Moshtari.ID  where num =" + Conversions.ToString(Num));
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x0003A7C8 File Offset: 0x000389C8
		public DataTable GetDetailByID(long ID)
		{
			DataTable dataTable = Public_Function.FillData("SELECT     Kharid_Furush.ID, Kharid_Furush.Kharid_ID, Kharid_Furush.Moshtari_ID, Kharid_Furush.Kala_ID, Kharid_Furush.Tarikh,   Kharid_Furush.Tarikh_Fa, Kharid_Furush.Tedad, Kharid_Furush.Vazn_Ba_Zarf, Kharid_Furush.Zarf, Kharid_Furush.Vazn_Kol,  Kharid_Furush.Fee, Kharid_Furush.Jam_Kol,Kharid_Furush.Sanad_ID,Kharid_Furush.kargari,Kharid_Furush.jamkol_ba_kargari, Moshtari.Name + ' ' + Moshtari.Family AS Moshtari_Name, Kala.Name AS Kala_Name,   Kharid_Furush.Daryaft_ID,Kharid_Furush.Tedad as tafazol_tedad,Kharid_Furush.Vazn_Ba_Zarf as tafazol_vazn, Kharid_Furush.Kala_ID AS prekala_id,daryaftpardakht.mablagh as pardakhti,daryaftpardakht.ID as pardakht_dp_id   FROM         Kharid_Furush INNER JOIN   Moshtari ON Kharid_Furush.Moshtari_ID = Moshtari.ID INNER JOIN   Kala ON Kharid_Furush.Kala_ID = Kala.ID INNER JOIN   Kharid ON Kharid_Furush.Kharid_ID = Kharid.ID   left outer join kharid_furush_dp  ON Kharid_Furush.ID=kharid_furush_dp.kharid_furush_id  left outer join daryaftpardakht  ON kharid_furush_dp.dp_ID=daryaftpardakht.ID   where Kharid.ID=" + Conversions.ToString(ID) + " order by Kharid_Furush.ID");
			dataTable.Columns.Add(new DataColumn("row_index", typeof(int)));
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

		// Token: 0x060002D1 RID: 721 RVA: 0x0003A930 File Offset: 0x00038B30
		public long GetNewID()
		{
			return Conversions.ToLong(Public_Function.ExecuteScalar("select isnull(max(Num),0)+1 from dbo.Kharid"));
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x0003A954 File Offset: 0x00038B54
		public long GetNavigateID(Kharid.NavTo nav, long num)
		{
			string empty = string.Empty;
			long result;
			switch (nav)
			{
			case Kharid.NavTo.forward:
				result = Conversions.ToLong(Public_Function.ExecuteScalar("SELECT TOP 1 Num FROM dbo.Kharid   WHERE Num > " + Conversions.ToString(num) + " ORDER BY Num ASC"));
				break;
			case Kharid.NavTo.backward:
				result = Conversions.ToLong(Public_Function.ExecuteScalar("SELECT TOP 1 Num FROM dbo.Kharid   WHERE Num < " + Conversions.ToString(num) + " ORDER BY Num DESC"));
				break;
			case Kharid.NavTo.first:
				result = Conversions.ToLong(Public_Function.ExecuteScalar(" SELECT MIN(Num) FROM dbo.Kharid"));
				break;
			case Kharid.NavTo.last:
				result = Conversions.ToLong(Public_Function.ExecuteScalar("SELECT MAX(Num) FROM dbo.Kharid"));
				break;
			}
			return result;
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x00033520 File Offset: 0x00031720
		public DataTable GetAll()
		{
			return Public_Function.FillData("Select dbo.Furush_Hag.ID,dbo.Furush_Hag.Num,dbo.Furush_Hag.Moshtari_ID,dbo.Furush_Hag.Sh_Mashin,dbo.Furush_Hag.Sh_Barname,dbo.Furush_Hag.Tarikh_Vurud,dbo.Furush_Hag.[Desc],dbo.Furush_Hag.Baskul,Baskul_Mabda,dbo.Furush_Hag.Tedad_Kol,dbo.Furush_Hag.Keraye,dbo.Furush_Hag.Hazine,dbo.Furush_Hag.Tarikh_Keraye,dbo.Furush_Hag.Tarikh_Hazine,dbo.Furush_Hag.Tarikh_Keraye_Fa,dbo.Furush_Hag.Tarikh_Hazine_Fa From dbo.Furush_Hag");
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x0003A9F8 File Offset: 0x00038BF8
		public void UpdateSanadFurushNaghdByID(long id)
		{
			long value = Conversions.ToLong(Public_Function.ExecuteScalar("select num from Kharid where id=" + Conversions.ToString(id)));
			this.UpdateSanadFurushNaghd(Conversions.ToString(value));
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x0002C50C File Offset: 0x0002A70C
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

		// Token: 0x060002D6 RID: 726 RVA: 0x0003AA30 File Offset: 0x00038C30
		public void UpdateSanadNaghd_FactorFurush(string tarikh)
		{
			DataTable dataTable = Public_Function.FillData("SELECT   max(Kharid.ID) AS kharid_id, Kharid.num, SUM(Kharid_Furush.Jam_Kol) AS Jam_Kol,SUM(Kharid_Furush.JamKol_ba_kargari) AS JamKol_ba_kargari, Kharid_Furush.Tarikh  ,max(Daryaft_ID) AS Daryaft_ID   FROM         Kharid_Furush INNER JOIN  Kharid ON Kharid_Furush.Kharid_ID = Kharid.ID  where  Kharid_Furush.Tarikh=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(tarikh)) + " and Kharid_Furush.Moshtari_id=-1 GROUP BY  Kharid_Furush.Tarikh,Kharid.num");
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
								text += this.Daryaft.AddRowStrToDaryaft(Public_Function.MiladiToShamsi(Conversions.ToDate(dataRow["Tarikh"])), Conversions.ToString(dataRow["Jam_Kol"]), Conversions.ToString(Operators.ConcatenateObject("فروش نقد سند شماره ", dataRow["num"])), DaryaftPardakht.CodeHesab.فروش_نقد_خرید);
							}
							else
							{
								text += this.Daryaft.AddRowStrToDaryaft(Public_Function.MiladiToShamsi(Conversions.ToDate(dataRow["Tarikh"])), Conversions.ToString(dataRow["JamKol_ba_kargari"]), Conversions.ToString(Operators.ConcatenateObject("فروش نقد سند شماره ", dataRow["num"])), DaryaftPardakht.CodeHesab.فروش_نقد_خرید);
							}
							text += "select @daryaft_id = scope_identity();";
							text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("update Kharid_Furush set daryaft_id=@daryaft_id where [Kharid_ID]=", dataRow["kharid_id"]), " and Kharid_Furush.Moshtari_id=-1 and tarikh='"), dataRow["tarikh"]), "';")));
						}
						else
						{
							bool flag2 = !Conversions.ToBoolean(Public_Function.dict["kargari"]);
							if (flag2)
							{
								text += this.Daryaft.UpdateRowStrToDaryaft(Public_Function.MiladiToShamsi(Conversions.ToDate(dataRow["Tarikh"])), Conversions.ToString(dataRow["Jam_Kol"]), Conversions.ToString(Operators.ConcatenateObject("فروش نقد سند شماره ", dataRow["num"])), Conversions.ToString(dataRow["daryaft_id"]), DaryaftPardakht.CodeHesab.فروش_نقد_خرید);
							}
							else
							{
								text += this.Daryaft.UpdateRowStrToDaryaft(Public_Function.MiladiToShamsi(Conversions.ToDate(dataRow["Tarikh"])), Conversions.ToString(dataRow["JamKol_ba_kargari"]), Conversions.ToString(Operators.ConcatenateObject("فروش نقد سند شماره ", dataRow["num"])), Conversions.ToString(dataRow["daryaft_id"]), DaryaftPardakht.CodeHesab.فروش_نقد_خرید);
							}
							text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("update Kharid_Furush set daryaft_id=", dataRow["daryaft_id"]), " where [Kharid_ID]="), dataRow["kharid_id"]), " and Kharid_Furush.Moshtari_id=-1 and tarikh='"), dataRow["tarikh"]), "';")));
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

		// Token: 0x060002D7 RID: 727 RVA: 0x0003AD8C File Offset: 0x00038F8C
		public void UpdateSanadFurushNaghd(string num)
		{
			DataTable dataTable = Public_Function.FillData("SELECT     SUM(Kharid_Furush.Jam_Kol) AS Jam_Kol,SUM(Kharid_Furush.JamKol_ba_kargari) AS JamKol_ba_kargari, Kharid_Furush.Tarikh,max(Daryaft_ID) AS Daryaft_ID  FROM         Kharid_Furush INNER JOIN  Kharid ON Kharid_Furush.Kharid_ID = Kharid.ID  where Kharid.Num=" + num + " and Kharid_Furush.Moshtari_id=-1 GROUP BY  Kharid_Furush.Tarikh");
			string text = "declare @daryaft_id bigint;declare @sanadbed_id bigint;declare @sanadbes_id bigint;declare @id bigint;select @id=id from Kharid where num=" + num + ";";
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
								text += this.Daryaft.AddRowStrToDaryaft(Public_Function.MiladiToShamsi(Conversions.ToDate(dataRow["Tarikh"])), Conversions.ToString(dataRow["Jam_Kol"]), "فروش نقد سند شماره " + num, DaryaftPardakht.CodeHesab.فروش_نقد_خرید);
							}
							else
							{
								text += this.Daryaft.AddRowStrToDaryaft(Public_Function.MiladiToShamsi(Conversions.ToDate(dataRow["Tarikh"])), Conversions.ToString(dataRow["JamKol_ba_kargari"]), "فروش نقد سند شماره " + num, DaryaftPardakht.CodeHesab.فروش_نقد_خرید);
							}
							text += "select @daryaft_id = scope_identity();";
							text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("update Kharid_Furush set daryaft_id=@daryaft_id where [Kharid_ID]=@id and Kharid_Furush.Moshtari_id=-1 and tarikh='", dataRow["tarikh"]), "';")));
						}
						else
						{
							bool flag2 = !Conversions.ToBoolean(Public_Function.dict["kargari"]);
							if (flag2)
							{
								text += this.Daryaft.UpdateRowStrToDaryaft(Public_Function.MiladiToShamsi(Conversions.ToDate(dataRow["Tarikh"])), Conversions.ToString(dataRow["Jam_Kol"]), "فروش نقد سند شماره " + num, Conversions.ToString(dataRow["daryaft_id"]), DaryaftPardakht.CodeHesab.فروش_نقد_خرید);
							}
							else
							{
								text += this.Daryaft.UpdateRowStrToDaryaft(Public_Function.MiladiToShamsi(Conversions.ToDate(dataRow["Tarikh"])), Conversions.ToString(dataRow["JamKol_ba_kargari"]), "فروش نقد سند شماره " + num, Conversions.ToString(dataRow["daryaft_id"]), DaryaftPardakht.CodeHesab.فروش_نقد_خرید);
							}
							text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("update Kharid_Furush set daryaft_id=", dataRow["daryaft_id"]), " where [Kharid_ID]=@id and Kharid_Furush.Moshtari_id=-1 and tarikh='"), dataRow["tarikh"]), "';")));
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

		// Token: 0x060002D8 RID: 728 RVA: 0x0003B078 File Offset: 0x00039278
		public void UpdateDaramad(string num)
		{
			long value = Conversions.ToLong(Public_Function.ExecuteScalar("select id from kharid where num=" + num));
			DataRow dataRow = Public_Function.FillDataRow("SELECT     Kharid.Daramad_Sanad_ID, Kharid.Moshtari_ID, Kharid.Darsad, Moshtari.Name+' '+ Moshtari.Family as Moshtari_name FROM Kharid LEFT OUTER JOIN Moshtari ON Kharid.Moshtari_ID = Moshtari.ID WHERE Kharid.ID = " + Conversions.ToString(value));
			bool flag = dataRow == null;
			if (!flag)
			{
				long num2 = Conversions.ToLong(Public_Function.ExecuteScalar("select isnull(sum(Jam_Kol),0) from kharid_detail where kharid_id=" + Conversions.ToString(value)));
				long num3 = 0L;
				flag = !Conversions.ToBoolean(Public_Function.dict["kargari"]);
				if (flag)
				{
					num3 = Conversions.ToLong(Public_Function.ExecuteScalar("select isnull(sum(Jam_Kol),0) from kharid_furush where kharid_id=" + Conversions.ToString(value)));
				}
				else
				{
					flag = !Conversions.ToBoolean(Public_Function.dict["kargari_sud"]);
					if (flag)
					{
						num3 = Conversions.ToLong(Public_Function.ExecuteScalar("select isnull(sum(JamKol_ba_kargari),0) from kharid_furush where kharid_id=" + Conversions.ToString(value)));
					}
					else
					{
						num3 = Conversions.ToLong(Public_Function.ExecuteScalar("select isnull(sum(Jam_Kol),0) from kharid_furush where kharid_id=" + Conversions.ToString(value)));
					}
				}
				long num4 = Conversions.ToLong(Public_Function.ExecuteScalar("select isnull(sum(keraye),0) from kharid_keraye where kharid_id=" + Conversions.ToString(value)));
				DataTable dataTable = Public_Function.FillData("SELECT     Kharid_Darsad.*, Moshtari.CodeHesab_ID   FROM         Kharid_Darsad INNER JOIN  Moshtari ON Kharid_Darsad.Moshtari_ID = Moshtari.ID where kharid_id=" + Conversions.ToString(value));
				long num5 = 0L;
				string text;
				string tozih;
				long value2;
				long value3;
				decimal num7;
				checked
				{
					num3 -= num2;
					num5 += num4;
					num3 -= num5;
					text = "declare @id bigint;declare @codehesab_id int;";
					decimal num6 = 0m;
					tozih = string.Empty;
					try
					{
						IEnumerator enumerator = dataTable.Rows.GetEnumerator();
						while (enumerator.MoveNext())
						{
							DataRow dataRow2 = (DataRow)enumerator.Current;
							num6 = Conversions.ToDecimal(Operators.MultiplyObject((double)num3 / 100.0, dataRow2["darsad"]));
							flag = (decimal.Compare(num6, decimal.Zero) > 0);
							if (flag)
							{
								value2 = Convert.ToInt64(num6);
								value3 = 0L;
								tozih = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("%", dataRow2["darsad"]), " "), "درآمد خرید مشارکتی سند شماره "), num));
							}
							else
							{
								value3 = Convert.ToInt64(Math.Abs(num6));
								value2 = 0L;
								tozih = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("%", dataRow2["darsad"]), " "), "زیان خرید مشارکتی سند شماره "), num));
							}
							flag = (dataRow2["sanad_id"] == DBNull.Value);
							if (flag)
							{
								text += this.iSanad.InsertStr(Conversions.ToString(dataRow2["codehesab_id"]), Conversions.ToString(value3), Conversions.ToString(value2), Public_Function.dict["today"], tozih, Sanad.SanadType.@null);
								text += "select @id=scope_identity();";
								text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("update kharid_darsad set sanad_id=@id,mablagh=" + Conversions.ToString(num6) + "  where id=", dataRow2["id"]), ";")));
							}
							else
							{
								text += this.iSanad.UpdateStr(Conversions.ToString(dataRow2["codehesab_id"]), Conversions.ToString(value3), Conversions.ToString(value2), Public_Function.dict["today"], tozih, Conversions.ToString(dataRow2["sanad_id"]), Sanad.SanadType.@null);
								text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("update kharid_darsad set mablagh=" + Conversions.ToString(num6) + "  where id=", dataRow2["id"]), ";")));
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
					num7 = Conversions.ToDecimal(Public_Function.GetSum(dataTable, "darsad"));
				}
				decimal num8 = new decimal((double)num3 / 100.0 * Convert.ToDouble(decimal.Subtract(new decimal(100L), num7)));
				flag = (decimal.Compare(num8, decimal.Zero) > 0);
				if (flag)
				{
					value2 = Convert.ToInt64(num8);
					value3 = 0L;
					flag = (decimal.Compare(num7, decimal.Zero) == 0);
					if (flag)
					{
						tozih = Conversions.ToString(Operators.ConcatenateObject("درآمد خرید سند شماره " + num + " - ", dataRow["moshtari_name"]));
					}
					else
					{
						tozih = Conversions.ToString(Operators.ConcatenateObject("% " + Conversions.ToString(decimal.Subtract(new decimal(100L), num7)) + "درآمد خرید سند شماره " + num + " - ", dataRow["moshtari_name"]));
					}
				}
				else
				{
					value2 = 0L;
					value3 = Convert.ToInt64(Math.Abs(num8));
					flag = (decimal.Compare(num7, decimal.Zero) == 0);
					if (flag)
					{
						tozih = Conversions.ToString(Operators.ConcatenateObject("زیان خرید سند شماره " + num + " - ", dataRow["moshtari_name"]));
					}
					else
					{
						tozih = Conversions.ToString(Operators.ConcatenateObject("% " + Conversions.ToString(decimal.Subtract(new decimal(100L), num7)) + "زیان خرید سند شماره " + num + " - ", dataRow["moshtari_name"]));
					}
				}
				flag = (dataRow["daramad_sanad_id"] == DBNull.Value);
				if (flag)
				{
					text += this.iSanad.InsertStr(Conversions.ToString(12), Conversions.ToString(value3), Conversions.ToString(value2), Public_Function.dict["today"], tozih, Sanad.SanadType.@null);
					text += "select @id=scope_identity();";
					text = text + "update kharid set daramad_sanad_id=@id where id=" + Conversions.ToString(value) + ";";
				}
				else
				{
					text += this.iSanad.UpdateStr(Conversions.ToString(12), Conversions.ToString(value3), Conversions.ToString(value2), Public_Function.dict["today"], tozih, Conversions.ToString(dataRow["daramad_sanad_id"]), Sanad.SanadType.@null);
				}
				Public_Function.ExecuteNonQuery(text);
			}
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x0003B6EC File Offset: 0x000398EC
		public long Insert(string Num, string Moshtari_ID, string Sh_Mashin, string Sh_Barname, string Tarikh_Vurud, string Desc, string Darsad, string nahve_furush, DataTable dt)
		{
			string tozih = string.Empty;
			string text = "declare @id bigint;declare @sanad_id int;declare @codehesab_id int;declare @sanadbed_id int;declare @sanadbes_id int;declare @daryaft_id int;declare @keraye_pardakht_id int;declare @hazine_pardakht_id int;";
			text = string.Concat(new string[]
			{
				text,
				" Insert Into dbo.Kharid(Num,Moshtari_ID,Sh_Mashin,Sh_Barname,Tarikh_Vurud,[Desc],darsad,nahve_furush) VALUES(",
				Num,
				",",
				Public_Function.GetValue(Moshtari_ID),
				",",
				Public_Function.GetValue(Sh_Mashin),
				",",
				Public_Function.GetValue(Sh_Barname),
				",",
				Public_Function.GetValue(Tarikh_Vurud),
				",",
				Public_Function.GetValue(Desc),
				",",
				Public_Function.GetValueInt(Darsad),
				",",
				Public_Function.GetValueInt(nahve_furush),
				");Select @id=Scope_Identity();"
			});
			try
			{
				IEnumerator enumerator = dt.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					tozih = " خرید سند " + Num;
					bool flag = Operators.ConditionalCompareObjectNotEqual(dataRow["Moshtari_ID"], -1, false) && Operators.ConditionalCompareObjectNotEqual(dataRow["Moshtari_ID"], -2, false) && Operators.ConditionalCompareObjectNotEqual(dataRow["Moshtari_ID"], -3, false);
					if (flag)
					{
						text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("select @codehesab_id=Codehesab_id from Moshtari where id=", dataRow["Moshtari_ID"]), ";")));
						flag = !Conversions.ToBoolean(Public_Function.dict["kargari"]);
						if (flag)
						{
							text += this.iSanad.InsertStr("@codehesab_id", dataRow["Jam_Kol"].ToString(), "0", dataRow["Tarikh_Fa"].ToString(), tozih, Sanad.SanadType.فروش_خرید);
						}
						else
						{
							text += this.iSanad.InsertStr("@codehesab_id", dataRow["JamKol_ba_kargari"].ToString(), "0", dataRow["Tarikh_Fa"].ToString(), tozih, Sanad.SanadType.فروش_خرید);
						}
						text += "Select @Sanad_id=Scope_Identity();";
					}
					text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Insert Into dbo.Kharid_Furush(Kharid_ID,Moshtari_ID,Kala_ID,Tarikh,Tarikh_Fa,Tedad,Vazn_Ba_Zarf,Zarf,Vazn_Kol,Fee,Jam_Kol,Sanad_ID,daryaft_id,kargari,jamkol_ba_kargari) VALUES(@id,", dataRow["Moshtari_ID"]), ","), dataRow["Kala_ID"]), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Conversions.ToString(dataRow["Tarikh_Fa"])))), ","), Public_Function.GetValue(Conversions.ToString(dataRow["Tarikh_Fa"]))), ","), Public_Function.GetValueInt(dataRow["Tedad"].ToString())), ","), Public_Function.GetValueInt(dataRow["Vazn_Ba_Zarf"].ToString())), ","), Public_Function.GetValueInt(dataRow["Zarf"].ToString())), ","), dataRow["Vazn_Kol"]), ","), dataRow["Fee"]), ","), dataRow["Jam_Kol"]), ","), Interaction.IIf(Operators.ConditionalCompareObjectEqual(dataRow["Moshtari_ID"], -1, false), "NULL", "@sanad_id")), ","), Interaction.IIf(Operators.ConditionalCompareObjectEqual(dataRow["Moshtari_ID"], -1, false), "@daryaft_id", "NULL")), ","), Public_Function.GetValueInt(dataRow["kargari"].ToString())), ","), Public_Function.GetValueInt(dataRow["jamkol_ba_kargari"].ToString())), ");")));
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

		// Token: 0x060002DA RID: 730 RVA: 0x0003BBC4 File Offset: 0x00039DC4
		public string AddRowStrNaghdMoshtari(string kharid_id, string Tarikh, string Moshtari_id, string Mablagh, string Tozih, string Daryaft_id)
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
				text += this.iSanad.InsertStr(Conversions.ToString(1), Mablagh, Conversions.ToString(0), Tarikh, Tozih, Sanad.SanadType.@null);
				text += " select @sanadbed_id2=scope_identity();";
				text += this.iSanad.InsertStr("@codehesab_id", Conversions.ToString(0), Mablagh, Tarikh, Tozih, Sanad.SanadType.@null);
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
				text = text + " insert into Kharid_Furush_DP (kharid_furush_id,dp_id) values ( " + kharid_id + ",@pardakht_dp_id) ";
				result = text;
			}
			else
			{
				text = text + " select @pardakht_dp_id=" + Daryaft_id + ";";
				text = text + "select @sanadbed_id2=sanadbed_id , @sanadbes_id2=sanadbes_id from daryaftPardakht where parent_id= " + Daryaft_id;
				text += this.iSanad.UpdateStr(Conversions.ToString(1), Mablagh, Conversions.ToString(0), Tarikh, Tozih, "@sanadbed_id2", Sanad.SanadType.@null);
				text += this.iSanad.UpdateStr("@codehesab_id", Conversions.ToString(0), Mablagh, Tarikh, Tozih, "@SanadBes_ID2", Sanad.SanadType.@null);
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

		// Token: 0x060002DB RID: 731 RVA: 0x0003BEF8 File Offset: 0x0003A0F8
		public void Update(string ID, string Num, string Moshtari_ID, string Sh_Mashin, string Sh_Barname, string Tarikh_Vurud, string Desc, string Darsad, string nahve_furush, DataTable dt)
		{
			string iD = Public_Function.GetID(dt, "ID", "");
			string tozih = string.Empty;
			string text = "declare @sanad_id int;declare @codehesab_id int;declare @sanadbed_id int;declare @sanadbes_id int;declare @sanadbed_id2 int;declare @sanadbes_id2 int;declare @daryaft_id int;declare @keraye_pardakht_id int;declare @hazine_pardakht_id int;declare @pardakht_dp_id int;declare @kharid_id int;";
			DataTable dataTable = Public_Function.FillData("select distinct daryaft_id as id from Kharid_Furush where Kharid_ID=" + ID + " and daryaft_id is not null");
			text = string.Concat(new string[]
			{
				text,
				" Update dbo.Kharid SET Num=",
				Num,
				" ,Moshtari_ID=",
				Public_Function.GetValue(Moshtari_ID),
				" ,Sh_Mashin=",
				Public_Function.GetValue(Sh_Mashin),
				" ,Sh_Barname=",
				Public_Function.GetValue(Sh_Barname),
				" ,Tarikh_Vurud=",
				Public_Function.GetValue(Tarikh_Vurud),
				" ,[Desc]=",
				Public_Function.GetValue(Desc),
				" ,Darsad=",
				Public_Function.GetValueInt(Darsad),
				" ,nahve_furush =",
				Public_Function.GetValueInt(nahve_furush),
				" Where ID=",
				ID
			});
			bool flag = iD.Length > 0;
			if (flag)
			{
				text = string.Concat(new string[]
				{
					text,
					"Delete From dbo.Kharid_Furush Where Kharid_ID=",
					ID,
					" AND ID NOT IN(",
					iD,
					");"
				});
			}
			else
			{
				text = text + "Delete From dbo.Kharid_Furush Where Kharid_ID=" + ID + ";";
			}
			bool flag2;
			try
			{
				IEnumerator enumerator = dt.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					flag = (dataRow["ID"] == DBNull.Value);
					if (flag)
					{
						flag2 = (Operators.ConditionalCompareObjectNotEqual(dataRow["Moshtari_ID"], -1, false) && Operators.ConditionalCompareObjectNotEqual(dataRow["Moshtari_ID"], -3, false));
						if (flag2)
						{
							tozih = " خرید سند " + Num;
							text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("select @codehesab_id=Codehesab_id from Moshtari where id=", dataRow["Moshtari_ID"]), ";")));
							flag2 = !Conversions.ToBoolean(Public_Function.dict["kargari"]);
							if (flag2)
							{
								text += this.iSanad.InsertStr("@codehesab_id", dataRow["Jam_Kol"].ToString(), "0", dataRow["Tarikh_Fa"].ToString(), tozih, Sanad.SanadType.فروش_خرید);
							}
							else
							{
								text += this.iSanad.InsertStr("@codehesab_id", dataRow["JamKol_ba_kargari"].ToString(), "0", dataRow["Tarikh_Fa"].ToString(), tozih, Sanad.SanadType.فروش_خرید);
							}
							text += "Select @Sanad_id=Scope_Identity();";
						}
						text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Insert Into dbo.Kharid_Furush(Kharid_ID,Moshtari_ID,Kala_ID,Tarikh,Tarikh_Fa,Tedad,Vazn_Ba_Zarf,Zarf,Vazn_Kol,Fee,Jam_Kol,Sanad_ID,daryaft_id,kargari,jamkol_ba_kargari) VALUES(" + ID + ",", dataRow["Moshtari_ID"]), ","), dataRow["Kala_ID"]), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Conversions.ToString(dataRow["Tarikh_Fa"])))), ","), Public_Function.GetValue(Conversions.ToString(dataRow["Tarikh_Fa"]))), ","), Public_Function.GetValueInt(dataRow["Tedad"].ToString())), ","), Public_Function.GetValueInt(dataRow["Vazn_Ba_Zarf"].ToString())), ","), Public_Function.GetValueInt(dataRow["Zarf"].ToString())), ","), Public_Function.GetValueInt(Conversions.ToString(dataRow["Vazn_Kol"]))), ","), dataRow["Fee"]), ","), dataRow["Jam_Kol"]), ","), Interaction.IIf(Operators.ConditionalCompareObjectEqual(dataRow["Moshtari_ID"], -1, false), "NULL", "@sanad_id")), ",@daryaft_id"), ","), Public_Function.GetValueInt(dataRow["kargari"].ToString())), ","), Public_Function.GetValueInt(dataRow["jamkol_ba_kargari"].ToString())), ");select @kharid_id=scope_identity();")));
						flag2 = (Operators.ConditionalCompareObjectNotEqual(dataRow["Moshtari_ID"], -1, false) && Operators.ConditionalCompareObjectNotEqual(dataRow["Moshtari_ID"], -3, false));
						if (flag2)
						{
							flag = (dataRow["pardakhti"] != DBNull.Value && dataRow["pardakhti"] != null);
							if (flag)
							{
								text += this.AddRowStrNaghdMoshtari("@kharid_id", Conversions.ToString(dataRow["Tarikh_Fa"]), Conversions.ToString(dataRow["Moshtari_ID"]), Conversions.ToString(dataRow["pardakhti"]), "دریافت نقد", dataRow["pardakht_dp_id"].ToString());
							}
						}
					}
					else
					{
						flag2 = (Operators.ConditionalCompareObjectNotEqual(dataRow["Moshtari_ID"], -1, false) && Operators.ConditionalCompareObjectNotEqual(dataRow["moshtari_id"], -3, false));
						if (flag2)
						{
							text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(" update Kharid_Furush set daryaft_id=null where id=", dataRow["ID"]), ";")));
							tozih = " خرید سند " + Num;
							text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("select @codehesab_id=Codehesab_id from Moshtari where id=", dataRow["Moshtari_ID"]), ";")));
							flag2 = (dataRow["Sanad_ID"] != DBNull.Value);
							if (flag2)
							{
								flag = !Conversions.ToBoolean(Public_Function.dict["kargari"]);
								if (flag)
								{
									text += this.iSanad.UpdateStr("@codehesab_id", Conversions.ToString(dataRow["Jam_Kol"]), Conversions.ToString(0), Conversions.ToString(dataRow["Tarikh_Fa"]), tozih, Conversions.ToString(dataRow["Sanad_ID"]), Sanad.SanadType.فروش_خرید);
								}
								else
								{
									text += this.iSanad.UpdateStr("@codehesab_id", Conversions.ToString(dataRow["JamKol_ba_kargari"]), Conversions.ToString(0), Conversions.ToString(dataRow["Tarikh_Fa"]), tozih, Conversions.ToString(dataRow["Sanad_ID"]), Sanad.SanadType.فروش_خرید);
								}
								text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject("select @sanad_id=", dataRow["Sanad_ID"])));
							}
							else
							{
								flag2 = !Conversions.ToBoolean(Public_Function.dict["kargari"]);
								if (flag2)
								{
									text += this.iSanad.InsertStr("@codehesab_id", dataRow["Jam_Kol"].ToString(), "0", dataRow["Tarikh_Fa"].ToString(), tozih, Sanad.SanadType.فروش_خرید);
								}
								else
								{
									text += this.iSanad.InsertStr("@codehesab_id", dataRow["JamKol_ba_kargari"].ToString(), "0", dataRow["Tarikh_Fa"].ToString(), tozih, Sanad.SanadType.فروش_خرید);
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
						}
						else
						{
							flag2 = (Operators.ConditionalCompareObjectEqual(dataRow["moshtari_id"], -1, false) || Operators.ConditionalCompareObjectEqual(dataRow["moshtari_id"], -3, false));
							if (flag2)
							{
								flag = (dataRow["sanad_id"] != DBNull.Value);
								if (flag)
								{
									string text2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("update kharid_furush set sanad_id=null where id=", dataRow["ID"]), ";"));
									text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(" delete from sanad where id=", dataRow["sanad_id"]), ";")));
									Public_Function.ExecuteNonQuery(text2);
								}
								flag2 = Operators.ConditionalCompareObjectEqual(dataRow["moshtari_id"], -3, false);
								if (flag2)
								{
									text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(" update Kharid_Furush set daryaft_id=null where id=", dataRow["ID"]), ";")));
								}
							}
						}
						flag2 = (Operators.ConditionalCompareObjectEqual(dataRow["moshtari_id"], -1, false) || Operators.ConditionalCompareObjectEqual(dataRow["moshtari_id"], -3, false));
						string right;
						if (flag2)
						{
							right = "NULL";
						}
						else
						{
							right = "@sanad_id";
						}
						text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Update dbo.Kharid_Furush SET Moshtari_ID=", dataRow["Moshtari_ID"]), " ,Kala_ID="), dataRow["Kala_ID"]), " ,Tarikh="), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Conversions.ToString(dataRow["Tarikh_Fa"])))), " ,Tarikh_Fa="), Public_Function.GetValue(Conversions.ToString(dataRow["Tarikh_Fa"]))), " ,Tedad="), Public_Function.GetValueInt(dataRow["Tedad"].ToString())), " ,Vazn_Ba_Zarf="), Public_Function.GetValueInt(dataRow["Vazn_Ba_Zarf"].ToString())), " ,Zarf="), Public_Function.GetValueInt(dataRow["Zarf"].ToString())), " ,Vazn_Kol="), dataRow["Vazn_Kol"]), " ,Fee="), dataRow["Fee"]), " ,Jam_Kol="), dataRow["Jam_Kol"]), " , Sanad_ID="), right), " , kargari="), Public_Function.GetValueInt(dataRow["kargari"].ToString())), " , jamkol_ba_kargari="), Public_Function.GetValueInt(dataRow["jamkol_ba_kargari"].ToString())), " Where ID="), dataRow["ID"]), ";")));
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
			Public_Function.ExecuteNonQuery(text);
			this.UpdateSanadFurushNaghd(Num);
			flag2 = (dataTable.Rows.Count > 0);
			if (flag2)
			{
				DataTable dataTable2 = Public_Function.FillData("select distinct daryaft_id as id from Kharid_Furush where Kharid_ID=" + ID + " and daryaft_id is Not null");
				flag2 = (dataTable2.Rows.Count > 0);
				if (flag2)
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
						flag2 = (enumerator2 is IDisposable);
						if (flag2)
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
						flag2 = (enumerator3 is IDisposable);
						if (flag2)
						{
							(enumerator3 as IDisposable).Dispose();
						}
					}
				}
			}
		}

		// Token: 0x060002DC RID: 732 RVA: 0x0003CE74 File Offset: 0x0003B074
		public void Delete(string ID)
		{
			string text = string.Empty;
			string text2 = string.Empty;
			string text3 = string.Empty;
			DataTable dt = Public_Function.FillData("select sanad_id from kharid_detail where kharid_id=" + ID);
			text2 = Public_Function.GetID(dt, "sanad_id", "");
			bool flag = text2.Length > 0;
			if (flag)
			{
				text = text + "delete from sanad where id in (" + text2 + ");";
			}
			text = text + "delete from kharid_detail where kharid_id= " + ID;
			text = text + "delete from Kala_To_Kala_kharid where kharid_id=" + ID + ";";
			DataTable dataTable = Public_Function.FillData("select * from kharid_keraye where kharid_id=" + ID);
			flag = (dataTable.Rows.Count > 0);
			if (flag)
			{
				text3 = Public_Function.GetID(dataTable, "keraye_pardakht_id", "");
				flag = (text3.Length > 0);
				if (flag)
				{
					DataTable dt2 = Public_Function.FillData("select sanadbed_id,sanadbes_id from daryaftpardakht where id in(" + text3 + ");");
					text2 = Public_Function.GetID(dt2, "sanadbed_id", "");
					flag = (text2.Length > 0);
					if (flag)
					{
						text = text + "delete from sanad where id in (" + text2 + ");";
					}
					text2 = Public_Function.GetID(dt2, "sanadbes_id", "");
					flag = (text2.Length > 0);
					if (flag)
					{
						text = text + "delete from sanad where id in(" + text2 + ");";
					}
					text = text + "delete from daryaftpardakht where id in(" + text3 + ");";
					Public_Function.ExecuteNonQuery(text);
				}
				text3 = Public_Function.GetID(dataTable, "id", "");
				text = text + "delete from kharid_keraye where id in (" + text3 + ")";
				Public_Function.ExecuteNonQuery(text);
				text = string.Empty;
			}
			DataTable dataTable2 = Public_Function.FillData("select sanad_id from kharid_darsad where kharid_id= " + ID);
			flag = (dataTable2.Rows.Count > 0);
			if (flag)
			{
				text2 = Public_Function.GetID(dataTable2, "sanad_id", "");
				text = "update kharid_darsad set sanad_id=null where kharid_id=" + ID + ";";
				text = text + "delete from sanad where id in(" + text2 + ");";
				Public_Function.ExecuteNonQuery(text);
				text = string.Empty;
			}
			DataTable dataTable3 = Public_Function.FillData("select * from kharid_furush where kharid_id=" + ID);
			flag = (dataTable3.Rows.Count > 0);
			bool flag2;
			if (flag)
			{
				text2 = Public_Function.GetID(dataTable3, "sanad_id", "");
				text = text + " update kharid_furush set sanad_id=null where kharid_id= " + ID + ";";
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
					DataTable dt2 = Public_Function.FillData("select * from daryaftPardakht where id in(" + text3 + ");");
					text2 = Public_Function.GetID(dt2, "sanadbed_id", "");
					flag = (text2.Length > 0);
					if (flag)
					{
						text2 += ",";
					}
					text2 += Public_Function.GetID(dt2, "sanadbes_id", "");
					flag = (text2.Length > 0);
					if (flag)
					{
						flag2 = (Operators.CompareString(text2.Substring(checked(text2.Length - 1), 1), ",", false) == 0);
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
					text = text + "update kharid_furush set daryaft_id=null where id in(" + iD + ");";
					text = text + "delete from daryaftpardakht where id in(" + text3 + ");";
				}
			}
			DataRow dataRow = Public_Function.FillDataRow("Select daramad_sanad_id from kharid where id=" + ID);
			flag2 = (dataRow["daramad_sanad_id"] != DBNull.Value);
			if (flag2)
			{
				text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject("delete from sanad where id=", dataRow["daramad_sanad_id"])));
			}
			text = text + "Delete From dbo.kharid Where Id= " + ID + ";";
			Public_Function.ExecuteNonQuery(text);
		}

		// Token: 0x060002DD RID: 733 RVA: 0x0003D2EC File Offset: 0x0003B4EC
		public void DeleteDetailByID(string id)
		{
			long value = Conversions.ToLong(Public_Function.ExecuteScalar("select isnull(daryaft_id,0) from Kharid_Furush where id=" + id));
			long num = Conversions.ToLong(Public_Function.ExecuteScalar("select Kharid_ID from Kharid_Furush where id=" + id));
			string text = "declare @sanad_id int;declare @daryaft_id int;declare @sanadbes_id int;declare @sanadbed_id int;";
			text = text + "select @sanad_id=sanad_id , @daryaft_id=daryaft_id from Kharid_Furush where id=" + id + ";";
			text = text + "update Kharid_Furush set sanad_id=null,daryaft_id=null where id=" + id + ";";
			text += "delete from sanad where id=@sanad_id;";
			text = text + "delete from Kharid_Furush where id=" + id + ";";
			Public_Function.ExecuteNonQuery(text);
			int num2 = Conversions.ToInteger(Public_Function.ExecuteScalar("select isnull(count(id),0) from Kharid_Furush where Kharid_ID=" + Conversions.ToString(num) + " and daryaft_id=" + Conversions.ToString(value)));
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

		// Token: 0x0400011C RID: 284
		private Sanad iSanad;

		// Token: 0x0400011D RID: 285
		private DaryaftPardakht Daryaft;

		// Token: 0x02000032 RID: 50
		public enum NavTo
		{
			// Token: 0x0400011F RID: 287
			forward = 1,
			// Token: 0x04000120 RID: 288
			backward,
			// Token: 0x04000121 RID: 289
			first,
			// Token: 0x04000122 RID: 290
			last
		}
	}
}
