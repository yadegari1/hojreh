using System;
using System.Collections;
using System.Data;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x0200004B RID: 75
	public class Varedat
	{
		// Token: 0x06000370 RID: 880 RVA: 0x00002816 File Offset: 0x00000A16
		public Varedat()
		{
			this.iSanad = new Sanad();
			this.Daryaft = new DaryaftPardakht();
			this.Sanad = new Sanad();
		}

		// Token: 0x06000371 RID: 881 RVA: 0x00049390 File Offset: 0x00047590
		public DataRow GetByID(long Num)
		{
			return Public_Function.FillDataRow("SELECT     Kharid_Sardkhane.*  FROM Kharid_sardkhane  where type =1 and num=" + Conversions.ToString(Num));
		}

		// Token: 0x06000372 RID: 882 RVA: 0x000493B8 File Offset: 0x000475B8
		public DataTable GetDetailByID(long ID)
		{
			DataTable dataTable = Public_Function.FillData("SELECT     Kharid_Sardkhane_Furush.ID, Kharid_sardkhane_Furush.Kharid_Sardkhane_ID, Kharid_Sardkhane_Furush.Moshtari_ID, Kharid_Sardkhane_Furush.Kala_ID,  Kharid_Sardkhane_Furush.Tarikh, Kharid_Sardkhane_Furush.Tarikh_Fa, Kharid_Sardkhane_Furush.Tedad, Kharid_Sardkhane_Furush.Vazn_Ba_Zarf,  Kharid_Sardkhane_Furush.Zarf, Kharid_Sardkhane_Furush.Vazn_Kol, Kharid_Sardkhane_Furush.Fee, Kharid_Sardkhane_Furush.Jam_Kol,  Kharid_Sardkhane_Furush.Sanad_ID, Moshtari.Name + ' ' + Moshtari.Family AS Moshtari_Name, Kala.Name AS Kala_Name,  Kharid_Sardkhane_Furush.Daryaft_ID, Kharid_Sardkhane_Furush.Tedad AS tafazol_tedad,  Kharid_Sardkhane_Furush.Vazn_Ba_Zarf AS tafazol_vazn, Kharid_Sardkhane_Furush.Kala_ID AS prekala_id, NULL AS Row_Index   FROM         Kharid_Sardkhane_Furush INNER JOIN  Moshtari ON Kharid_Sardkhane_Furush.Moshtari_ID = Moshtari.ID INNER JOIN  Kala ON Kharid_Sardkhane_Furush.Kala_ID = Kala.ID INNER JOIN  Kharid_Sardkhane ON Kharid_sardkhane_Furush.Kharid_Sardkhane_ID = Kharid_Sardkhane.ID where Kharid_sardkhane_Furush.Kharid_Sardkhane_ID=" + Conversions.ToString(ID));
			dataTable.Columns.Add(new DataColumn("row_index", typeof(int)));
			return dataTable;
		}

		// Token: 0x06000373 RID: 883 RVA: 0x00049404 File Offset: 0x00047604
		public long GetNewID()
		{
			return Conversions.ToLong(Public_Function.ExecuteScalar("select isnull(max(Num),0)+1 from dbo.Kharid_sardkhane where type =1"));
		}

		// Token: 0x06000374 RID: 884 RVA: 0x00049428 File Offset: 0x00047628
		public long GetNavigateID(Varedat.NavTo nav, long num)
		{
			string empty = string.Empty;
			long result;
			switch (nav)
			{
			case Varedat.NavTo.forward:
				result = Conversions.ToLong(Public_Function.ExecuteScalar("SELECT TOP 1 Num FROM dbo.Kharid_sardkhane   WHERE  type =1 and Num > " + Conversions.ToString(num) + " ORDER BY Num ASC"));
				break;
			case Varedat.NavTo.backward:
				result = Conversions.ToLong(Public_Function.ExecuteScalar("SELECT TOP 1 Num FROM dbo.Kharid_sardkhane   WHERE  type =1 and Num < " + Conversions.ToString(num) + " ORDER BY Num DESC"));
				break;
			case Varedat.NavTo.first:
				result = Conversions.ToLong(Public_Function.ExecuteScalar(" SELECT MIN(Num) FROM dbo.Kharid_sardkhane where type =1"));
				break;
			case Varedat.NavTo.last:
				result = Conversions.ToLong(Public_Function.ExecuteScalar("SELECT MAX(Num) FROM dbo.Kharid_sardkhane where type =1"));
				break;
			}
			return result;
		}

		// Token: 0x06000375 RID: 885 RVA: 0x000494CC File Offset: 0x000476CC
		public void UpdateSanadFurushNaghdByID(long id)
		{
			long value = Conversions.ToLong(Public_Function.ExecuteScalar("select num from Kharid_Sardkhane where id=" + Conversions.ToString(id)));
			this.UpdateSanadFurushNaghd(Conversions.ToString(value));
		}

		// Token: 0x06000376 RID: 886 RVA: 0x0002C50C File Offset: 0x0002A70C
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

		// Token: 0x06000377 RID: 887 RVA: 0x00049504 File Offset: 0x00047704
		public void UpdateSanadFurushNaghd(string num)
		{
			DataTable dataTable = Public_Function.FillData("SELECT     SUM(Kharid_Sardkhane_Furush.Jam_Kol) AS Jam_Kol, Kharid_Sardkhane_Furush.Tarikh, MAX(Kharid_Sardkhane_Furush.Daryaft_ID) AS Daryaft_ID  FROM         Kharid_Sardkhane_Furush INNER JOIN  Kharid_Sardkhane ON Kharid_Sardkhane_Furush.Kharid_Sardkhane_ID = Kharid_Sardkhane.ID  WHERE   (Kharid_Sardkhane.type=1)  AND (Kharid_Sardkhane.Num = " + num + ") AND (Kharid_Sardkhane_Furush.Moshtari_ID = - 1) GROUP BY Kharid_Sardkhane_Furush.Tarikh");
			string text = "declare @daryaft_id bigint;declare @sanadbed_id bigint;declare @sanadbes_id bigint;declare @id bigint;select @id=id from Kharid_Sardkhane where type=1 and num=" + num + ";";
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
							text += this.Daryaft.AddRowStrToDaryaft(Public_Function.MiladiToShamsi(Conversions.ToDate(dataRow["Tarikh"])), Conversions.ToString(dataRow["Jam_Kol"]), "فروش نقد سند شماره " + num, DaryaftPardakht.CodeHesab.فروش_نقد_سردخانه);
							text += "select @daryaft_id = scope_identity();";
							text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("update Kharid_Sardkhane_Furush set daryaft_id=@daryaft_id where [Kharid_Sardkhane_ID]=@id and Moshtari_id=-1 and tarikh='", dataRow["tarikh"]), "';")));
						}
						else
						{
							text += this.Daryaft.UpdateRowStrToDaryaft(Public_Function.MiladiToShamsi(Conversions.ToDate(dataRow["Tarikh"])), Conversions.ToString(dataRow["Jam_Kol"]), "فروش نقد سند شماره " + num, Conversions.ToString(dataRow["daryaft_id"]), DaryaftPardakht.CodeHesab.فروش_نقد_سردخانه);
							text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("update Kharid_Sardkhane_Furush set daryaft_id=", dataRow["daryaft_id"]), " where [Kharid_Sardkhane_ID]=@id and Moshtari_id=-1 and tarikh='"), dataRow["tarikh"]), "';")));
						}
						num2++;
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
			}
		}

		// Token: 0x06000378 RID: 888 RVA: 0x00049718 File Offset: 0x00047918
		public void UpdateDaramad(string num)
		{
			long value = Conversions.ToLong(Public_Function.ExecuteScalar("select id from kharid_Sardkhane where type=null and num=" + num));
			DataRow dataRow = Public_Function.FillDataRow("select daramad_sanad_id,darsad from kharid_Sardkhane where id=" + Conversions.ToString(value));
			bool flag = dataRow == null;
			if (!flag)
			{
				long num2 = Conversions.ToLong(Public_Function.ExecuteScalar("select isnull(sum(Jam_Kol),0) from kharid_Sardkhane_detail where kharid_Sardkhane_id=" + Conversions.ToString(value)));
				long num3 = Conversions.ToLong(Public_Function.ExecuteScalar("SELECT     isnull(SUM(cast(Furush_Sardkhane_Safi.Mande as bigint)),0)  FROM         Furush_Sardkhane_Safi INNER JOIN Furush_Sardkhane ON Furush_Sardkhane_Safi.Furush_Sardkhane_ID = Furush_Sardkhane.ID where Kharid_Sardkhane_ID = " + Conversions.ToString(value)));
				long num4 = Conversions.ToLong(Public_Function.ExecuteScalar("select isnull(sum(keraye),0) from kharid_Sardkhane_keraye where Kharid_Sardkhane_ID=" + Conversions.ToString(value)));
				DataTable dataTable = Public_Function.FillData("SELECT     Kharid_Sardkhane_Darsad.*, Moshtari.CodeHesab_ID   FROM         Kharid_Sardkhane_Darsad INNER JOIN  Moshtari ON Kharid_Sardkhane_Darsad.Moshtari_ID = Moshtari.ID where Kharid_Sardkhane_ID=" + Conversions.ToString(value));
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
								tozih = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("%", dataRow2["darsad"]), " "), "درآمد فروش سردخانه سند شماره "), num));
							}
							else
							{
								value3 = Convert.ToInt64(Math.Abs(num6));
								value2 = 0L;
								tozih = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("%", dataRow2["darsad"]), " "), "زیان ناشی از فروش سردخانه سند شماره "), num));
							}
							flag = (dataRow2["sanad_id"] == DBNull.Value);
							if (flag)
							{
								text += this.iSanad.InsertStr(Conversions.ToString(dataRow2["codehesab_id"]), Conversions.ToString(value3), Conversions.ToString(value2), Public_Function.dict["today"], tozih, Sanad.SanadType.@null);
								text += "select @id=scope_identity();";
								text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("update Kharid_Sardkhane_Darsad set sanad_id=@id,mablagh=" + Conversions.ToString(num6) + "  where id=", dataRow2["id"]), ";")));
							}
							else
							{
								text += this.iSanad.UpdateStr(Conversions.ToString(dataRow2["codehesab_id"]), Conversions.ToString(value3), Conversions.ToString(value2), Public_Function.dict["today"], tozih, Conversions.ToString(dataRow2["sanad_id"]), Sanad.SanadType.@null);
								text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("update Kharid_Sardkhane_Darsad set mablagh=" + Conversions.ToString(num6) + "  where id=", dataRow2["id"]), ";")));
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
						tozih = "درآمد فروش سردخانه سند شماره " + num;
					}
					else
					{
						tozih = "% " + Conversions.ToString(decimal.Subtract(new decimal(100L), num7)) + "درآمد فروش سردخانه سند شماره " + num;
					}
				}
				else
				{
					value2 = 0L;
					value3 = Convert.ToInt64(Math.Abs(num8));
					flag = (decimal.Compare(num7, decimal.Zero) == 0);
					if (flag)
					{
						tozih = "زیان فروش سردخانه سند شماره " + num;
					}
					else
					{
						tozih = "% " + Conversions.ToString(decimal.Subtract(new decimal(100L), num7)) + "زیان فروش سردخانه سند شماره " + num;
					}
				}
				flag = (dataRow["daramad_sanad_id"] == DBNull.Value);
				if (flag)
				{
					text += this.iSanad.InsertStr(Conversions.ToString(17), Conversions.ToString(value3), Conversions.ToString(value2), Public_Function.dict["today"], tozih, Sanad.SanadType.@null);
					text += "select @id=scope_identity();";
					text = text + "update kharid_Sardkhane set daramad_sanad_id=@id where id=" + Conversions.ToString(value) + ";";
				}
				else
				{
					text += this.iSanad.UpdateStr(Conversions.ToString(17), Conversions.ToString(value3), Conversions.ToString(value2), Public_Function.dict["today"], tozih, Conversions.ToString(dataRow["daramad_sanad_id"]), Sanad.SanadType.@null);
				}
				Public_Function.ExecuteNonQuery(text);
			}
		}

		// Token: 0x06000379 RID: 889 RVA: 0x00049C70 File Offset: 0x00047E70
		public long Insert(string Num, string Tarikh_Vurud, string Desc, string nahve_kharid, string nahve_furush, DataTable dt)
		{
			string tozih = string.Empty;
			string right = string.Empty;
			string text = "declare @id bigint;declare @sanad_id int;declare @codehesab_id int;declare @sanadbed_id int;declare @sanadbes_id int;declare @daryaft_id int;declare @keraye_pardakht_id int;declare @hazine_pardakht_id int;";
			text = string.Concat(new string[]
			{
				text,
				" Insert Into dbo.Kharid_sardkhane(Num,Tarikh_Vurud,[Desc],[type],nahve_kharid,nahve_furush) VALUES(",
				Num,
				",",
				Public_Function.GetValue(Tarikh_Vurud),
				",",
				Public_Function.GetValue(Desc),
				",1,",
				Public_Function.GetValue(nahve_kharid),
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
					tozih = " واردات سند " + Num;
					bool flag = Operators.ConditionalCompareObjectNotEqual(dataRow["Moshtari_ID"], -1, false) && Operators.ConditionalCompareObjectNotEqual(dataRow["Moshtari_ID"], -2, false) && Operators.ConditionalCompareObjectNotEqual(dataRow["Moshtari_ID"], -3, false);
					if (flag)
					{
						text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("select @codehesab_id=Codehesab_id from Moshtari where id=", dataRow["Moshtari_ID"]), ";")));
						text += this.Sanad.InsertStr("@codehesab_id", dataRow["Jam_Kol"].ToString(), "0", dataRow["Tarikh_Fa"].ToString(), tozih, Sanad.SanadType.خرید_به_سردخانه_ریزبار_صاحب_بار);
						text += "Select @Sanad_id=Scope_Identity();";
					}
					if (Operators.ConditionalCompareObjectEqual(dataRow["moshtari_id"], -1, false) || Operators.ConditionalCompareObjectEqual(dataRow["moshtari_id"], -2, false))
					{
						goto IL_1F7;
					}
					if (Operators.ConditionalCompareObjectEqual(dataRow["Moshtari_ID"], -3, false))
					{
						goto IL_1F7;
					}
					bool arg_1F9_0 = false;
					IL_1F8:
					flag = arg_1F9_0;
					if (flag)
					{
						right = "NULL";
					}
					else
					{
						right = "@sanad_id";
					}
					text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Insert Into dbo.Kharid_Sardkhane_Furush(Kharid_Sardkhane_ID,Moshtari_ID,Kala_ID,Tarikh,Tarikh_Fa,Tedad,Vazn_Ba_Zarf,Zarf,Vazn_Kol,Fee,Jam_Kol,Sanad_ID,daryaft_id) VALUES(@id,", dataRow["Moshtari_ID"]), ","), dataRow["Kala_ID"]), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Conversions.ToString(dataRow["Tarikh_Fa"])))), ","), Public_Function.GetValue(Conversions.ToString(dataRow["Tarikh_Fa"]))), ","), Public_Function.GetValueInt(dataRow["Tedad"].ToString())), ","), Public_Function.GetValueInt(dataRow["Vazn_Ba_Zarf"].ToString())), ","), Public_Function.GetValueInt(dataRow["Zarf"].ToString())), ","), dataRow["Vazn_Kol"]), ","), dataRow["Fee"]), ","), dataRow["Jam_Kol"]), ","), right), ","), Interaction.IIf(Operators.ConditionalCompareObjectEqual(dataRow["Moshtari_ID"], -1, false), "@daryaft_id", "NULL")), ");")));
					continue;
					IL_1F7:
					arg_1F9_0 = true;
					goto IL_1F8;
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

		// Token: 0x0600037A RID: 890 RVA: 0x0004A0A0 File Offset: 0x000482A0
		public void Update(string ID, string Num, string Tarikh_Vurud, string Desc, string nahve_kharid, string nahve_furush, DataTable dt)
		{
			string iD = Public_Function.GetID(dt, "ID", "");
			string tozih = string.Empty;
			string text = "declare @sanad_id int;declare @codehesab_id int;declare @sanadbed_id int;declare @sanadbes_id int;declare @daryaft_id int;declare @keraye_pardakht_id int;declare @hazine_pardakht_id int;";
			DataTable dataTable = Public_Function.FillData("select distinct daryaft_id as id from Kharid_Sardkhane_Furush where Kharid_Sardkhane_ID=" + ID + " and daryaft_id is not null");
			string right = string.Empty;
			text = string.Concat(new string[]
			{
				text,
				" Update dbo.Kharid_sardkhane SET Num=",
				Num,
				" ,[Desc]=",
				Public_Function.GetValue(Desc),
				" ,nahve_kharid=",
				nahve_kharid,
				" ,nahve_furush=",
				nahve_furush,
				" Where ID=",
				ID
			});
			Public_Function.ExecuteNonQuery(text);
			bool flag = iD.Length > 0;
			if (flag)
			{
				text = string.Concat(new string[]
				{
					text,
					"Delete From dbo.Furush_Sardkhane_Detail Where Furush_Sardkhane_ID=",
					ID,
					" AND ID NOT IN(",
					iD,
					");"
				});
			}
			else
			{
				text = text + "Delete From dbo.Furush_Sardkhane_Detail Where Furush_Sardkhane_ID=" + ID + ";";
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
								goto IL_5F7;
							}
							if (Operators.ConditionalCompareObjectEqual(dataRow["moshtari_id"], -3, false))
							{
								goto IL_5F7;
							}
							bool arg_5F9_0 = false;
							IL_5F8:
							flag2 = arg_5F9_0;
							if (flag2)
							{
								flag = (Operators.ConditionalCompareObjectEqual(dataRow["moshtari_id"], -2, false) || Operators.ConditionalCompareObjectEqual(dataRow["moshtari_id"], -3, false));
								if (flag)
								{
									flag3 = (dataRow["Daryaft_ID"] != DBNull.Value);
									if (flag3)
									{
										text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("update Kharid_Sardkhane_Furush set daryaft_id=null where id=", dataRow["ID"]), ";")));
									}
								}
								flag3 = (dataRow["sanad_id"] != DBNull.Value);
								if (flag3)
								{
									string text2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("update Kharid_Sardkhane_Furush set sanad_id=null where id=", dataRow["ID"]), ";"));
									text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(" delete from sanad where id=", dataRow["sanad_id"]), ";")));
									Public_Function.ExecuteNonQuery(text2);
								}
								goto IL_707;
							}
							goto IL_707;
							IL_5F7:
							arg_5F9_0 = true;
							goto IL_5F8;
						}
						flag = (dataRow["Daryaft_ID"] != DBNull.Value);
						if (flag)
						{
							text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("update Kharid_Sardkhane_Furush set daryaft_id=null where id=", dataRow["ID"]), ";")));
						}
						tozih = " فروش سردخانه سند " + Num;
						text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("select @codehesab_id=Codehesab_id from Moshtari where id=", dataRow["Moshtari_ID"]), ";")));
						flag2 = (dataRow["Sanad_ID"] != DBNull.Value);
						if (flag2)
						{
							text += this.Sanad.UpdateStr("@codehesab_id", Conversions.ToString(dataRow["Jam_Kol"]), Conversions.ToString(0), Conversions.ToString(dataRow["Tarikh_Fa"]), tozih, Conversions.ToString(dataRow["Sanad_ID"]), Sanad.SanadType.فروش_از_سردخانه_به_مشتری);
							text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject("select @sanad_id=", dataRow["Sanad_ID"])));
						}
						else
						{
							text += this.Sanad.InsertStr("@codehesab_id", dataRow["Jam_Kol"].ToString(), "0", dataRow["Tarikh_Fa"].ToString(), tozih, Sanad.SanadType.فروش_از_سردخانه_به_مشتری);
							text += "Select @Sanad_id=Scope_Identity();";
						}
						IL_707:
						if (Operators.ConditionalCompareObjectEqual(dataRow["moshtari_ID"], -1, false) || Operators.ConditionalCompareObjectEqual(dataRow["moshtari_ID"], -2, false))
						{
							goto IL_75D;
						}
						if (Operators.ConditionalCompareObjectEqual(dataRow["moshtari_ID"], -3, false))
						{
							goto IL_75D;
						}
						bool arg_75F_0 = false;
						IL_75E:
						flag3 = arg_75F_0;
						if (flag3)
						{
							right = "NULL";
						}
						else
						{
							right = "@sanad_ID";
						}
						text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Update dbo.Kharid_Sardkhane_Furush SET Moshtari_ID=", dataRow["Moshtari_ID"]), " ,Kala_ID="), dataRow["Kala_ID"]), " ,Tarikh="), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Conversions.ToString(dataRow["Tarikh_Fa"])))), " ,Tarikh_Fa="), Public_Function.GetValue(Conversions.ToString(dataRow["Tarikh_Fa"]))), " ,Tedad="), Public_Function.GetValueInt(dataRow["Tedad"].ToString())), " ,Vazn_Ba_Zarf="), Public_Function.GetValueInt(dataRow["Vazn_Ba_Zarf"].ToString())), " ,Zarf="), Public_Function.GetValueInt(dataRow["Zarf"].ToString())), " ,Vazn_Kol="), dataRow["Vazn_Kol"]), " ,Fee="), dataRow["Fee"]), " ,Jam_Kol="), dataRow["Jam_Kol"]), " , Sanad_ID="), right), " Where ID="), dataRow["ID"]), ";")));
						continue;
						IL_75D:
						arg_75F_0 = true;
						goto IL_75E;
					}
					flag2 = (Operators.ConditionalCompareObjectNotEqual(dataRow["Moshtari_ID"], -1, false) && Operators.ConditionalCompareObjectNotEqual(dataRow["moshtari_id"], -2, false) && Operators.ConditionalCompareObjectNotEqual(dataRow["moshtari_ID"], -3, false));
					if (flag2)
					{
						tozih = " واردات سند " + Num;
						text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("select @codehesab_id=Codehesab_id from Moshtari where id=", dataRow["Moshtari_ID"]), ";")));
						text += this.Sanad.InsertStr("@codehesab_id", dataRow["Jam_Kol"].ToString(), "0", dataRow["Tarikh_Fa"].ToString(), tozih, Sanad.SanadType.فروش_از_سردخانه_به_مشتری);
						text += "Select @Sanad_id=Scope_Identity();";
						right = "@sanad_id";
					}
					else
					{
						right = "NULL";
					}
					text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Insert Into dbo.Kharid_Sardkhane_Furush(Kharid_Sardkhane_ID,Moshtari_ID,Kala_ID,Tarikh,Tarikh_Fa,Tedad,Vazn_Ba_Zarf,Zarf,Vazn_Kol,Fee,Jam_Kol,Sanad_ID,daryaft_id) VALUES(" + ID + ",", dataRow["Moshtari_ID"]), ","), dataRow["Kala_ID"]), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Conversions.ToString(dataRow["Tarikh_Fa"])))), ","), Public_Function.GetValue(Conversions.ToString(dataRow["Tarikh_Fa"]))), ","), Public_Function.GetValueInt(dataRow["Tedad"].ToString())), ","), Public_Function.GetValueInt(dataRow["Vazn_Ba_Zarf"].ToString())), ","), Public_Function.GetValueInt(dataRow["Zarf"].ToString())), ","), Public_Function.GetValueInt(Conversions.ToString(dataRow["Vazn_Kol"]))), ","), dataRow["Fee"]), ","), dataRow["Jam_Kol"]), ","), right), ",@daryaft_id"), ");")));
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
				DataTable dataTable2 = Public_Function.FillData("select distinct daryaft_id as id from Kharid_Sardkhane_Furush where [Kharid_Sardkhane_ID]=" + ID + " and daryaft_id is Not null");
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

		// Token: 0x0600037B RID: 891 RVA: 0x0003FB20 File Offset: 0x0003DD20
		public void Delete(string ID)
		{
			string text = string.Empty;
			string text2 = string.Empty;
			string text3 = string.Empty;
			string str = string.Empty;
			long num = Conversions.ToLong(Public_Function.ExecuteScalar("select isnull(count(id),0) from furush_sardkhane where kharid_sardkhane_id=" + ID));
			bool flag = num > 0L;
			if (flag)
			{
				Public_Function.ShowMessage("سند مورد نظر دارای فروش میباشد" + Environment.NewLine + "در ابتدا اقدام به حذف اسناد فروش بفرمائید", MessageBoxButtons.OK, MessageBoxIcon.Hand, null);
			}
			else
			{
				DataTable dataTable = Public_Function.FillData("select sanad_id from kharid_sardkhane_keraye where kharid_sardkhane_id=" + ID + " AND Sanad_id is not null;");
				flag = (dataTable.Rows.Count > 0);
				if (flag)
				{
					str = Public_Function.GetID(dataTable, "sanad_id", "");
					text = text + "delete from sanad where id in (" + str + ");";
				}
				DataTable dataTable2 = Public_Function.FillData("select * from kharid_sardkhane_keraye where kharid_sardkhane_id=" + ID);
				flag = (dataTable2.Rows.Count > 0);
				if (flag)
				{
					text3 = Public_Function.GetID(dataTable2, "keraye_pardakht_id", "");
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
					text = string.Empty;
				}
				DataTable dataTable3 = Public_Function.FillData("select sanad_id from kharid_Sardkhane_darsad where kharid_sardkhane_id= " + ID);
				flag = (dataTable3.Rows.Count > 0);
				if (flag)
				{
					text2 = Public_Function.GetID(dataTable3, "sanad_id", "");
					text = "update kharid_Sardkhane_darsad set sanad_id=null where kharid_Sardkhane_id=" + ID + ";";
					flag = (text2.Length > 0);
					if (flag)
					{
						text = text + "delete from sanad where id in(" + text2 + ");";
					}
					text = text + "delete from kharid_sardkhane_darsad where khardi_sardkhane_id=" + ID + ";";
					Public_Function.ExecuteNonQuery(text);
					text = string.Empty;
				}
				DataTable dataTable4 = Public_Function.FillData("select * from kharid_sardkhane_detail where kharid_sardkhane_id=" + ID);
				flag = (dataTable4.Rows.Count > 0);
				if (flag)
				{
					text2 = Public_Function.GetID(dataTable4, "sanad_id", "");
					text = text + " update kharid_sardkhane_detail set sanad_id=null where kharid_sardkhane_id= " + ID + ";";
					flag = (text2.Length > 0);
					if (flag)
					{
						text = text + "delete from sanad where id in(" + text2 + ");";
					}
					text = text + "delete from kharid_sardkhane_detail where kharid_sardkhane_id=" + ID + ";";
					Public_Function.ExecuteNonQuery(text);
					text = string.Empty;
				}
				DataRow dataRow = Public_Function.FillDataRow("Select daramad_sanad_id from kharid_sardkhane where id=" + ID);
				flag = (dataRow["daramad_sanad_id"] != DBNull.Value);
				if (flag)
				{
					text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject("delete from sanad where id=", dataRow["daramad_sanad_id"])));
				}
				text = text + "Delete From kharid_sardkhane Where Id= " + ID + ";";
				Public_Function.ExecuteNonQuery(text);
			}
		}

		// Token: 0x0600037C RID: 892 RVA: 0x0004ACFC File Offset: 0x00048EFC
		public void DeleteDetailByID(string id)
		{
			long value = Conversions.ToLong(Public_Function.ExecuteScalar("select isnull(daryaft_id,0) from [Kharid_Sardkhane_Furush] where id=" + id));
			long num = Conversions.ToLong(Public_Function.ExecuteScalar("select [Kharid_Sardkhane_ID] from [Kharid_Sardkhane_Furush] where id=" + id));
			string text = "declare @sanad_id int;declare @daryaft_id int;declare @sanadbes_id int;declare @sanadbed_id int;";
			text = text + "select @sanad_id=sanad_id , @daryaft_id=daryaft_id from Kharid_Sardkhane_Furush where id=" + id + ";";
			text = text + "update Kharid_Sardkhane_Furush set sanad_id=null,daryaft_id=null where id=" + id + ";";
			text += "delete from sanad where id=@sanad_id;";
			text = text + "delete from Kharid_Sardkhane_Furush where id=" + id + ";";
			Public_Function.ExecuteNonQuery(text);
			int num2 = Conversions.ToInteger(Public_Function.ExecuteScalar("select isnull(count(id),0) from Kharid_Sardkhane_Furush where Kharid_Sardkhane_ID=" + Conversions.ToString(num) + " and daryaft_id=" + Conversions.ToString(value)));
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

		// Token: 0x04000166 RID: 358
		private Sanad iSanad;

		// Token: 0x04000167 RID: 359
		private DaryaftPardakht Daryaft;

		// Token: 0x04000168 RID: 360
		private Sanad Sanad;

		// Token: 0x0200004C RID: 76
		public enum NavTo
		{
			// Token: 0x0400016A RID: 362
			forward = 1,
			// Token: 0x0400016B RID: 363
			backward,
			// Token: 0x0400016C RID: 364
			first,
			// Token: 0x0400016D RID: 365
			last
		}
	}
}
