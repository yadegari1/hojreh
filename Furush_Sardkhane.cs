using System;
using System.Collections;
using System.Data;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x0200002D RID: 45
	public class Furush_Sardkhane
	{
		// Token: 0x060002B8 RID: 696 RVA: 0x000025B3 File Offset: 0x000007B3
		public Furush_Sardkhane()
		{
			this.Sanad = new Sanad();
			this.Daryaft = new DaryaftPardakht();
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x000382F8 File Offset: 0x000364F8
		public DataRow GetByID(long Num)
		{
			return Public_Function.FillDataRow("SELECT     Furush_Sardkhane.*, Kharid_Sardkhane.Num AS Kharid_Num  FROM         Furush_Sardkhane INNER JOIN  Kharid_Sardkhane ON Furush_Sardkhane.Kharid_Sardkhane_ID = Kharid_Sardkhane.ID  where Furush_Sardkhane.num =" + Conversions.ToString(Num));
		}

		// Token: 0x060002BA RID: 698 RVA: 0x00038320 File Offset: 0x00036520
		public DataTable GetDetailByID(long ID)
		{
			return Public_Function.FillData("SELECT     Furush_Sardkhane_Detail.ID, Furush_Sardkhane_Detail.Furush_Sardkhane_ID, Furush_Sardkhane_Detail.Moshtari_ID, Furush_Sardkhane_Detail.Kala_ID, Furush_Sardkhane_Detail.Tarikh,   Furush_Sardkhane_Detail.Tarikh_Fa, Furush_Sardkhane_Detail.Tedad, Furush_Sardkhane_Detail.Vazn_Ba_Zarf, Furush_Sardkhane_Detail.Zarf, Furush_Sardkhane_Detail.Vazn_Kol,  Furush_Sardkhane_Detail.Fee, Furush_Sardkhane_Detail.Jam_Kol,Furush_Sardkhane_Detail.Sanad_ID, Moshtari.Name + ' ' + Moshtari.Family AS Moshtari_Name, Kala.Name AS Kala_Name,   Furush_Sardkhane_Detail.Sanad_ID,Furush_Sardkhane_Detail.Daryaft_ID,Furush_Sardkhane_Detail.Tedad as tafazol_tedad,Furush_Sardkhane_Detail.Vazn_Ba_Zarf as tafazol_vazn, Furush_Sardkhane_Detail.Kala_ID AS prekala_id,NULL AS Row_Index   FROM         Furush_Sardkhane_Detail INNER JOIN   Moshtari ON Furush_Sardkhane_Detail.Moshtari_ID = Moshtari.ID INNER JOIN   Kala ON Furush_Sardkhane_Detail.Kala_ID = Kala.ID INNER JOIN   Furush_Sardkhane ON Furush_Sardkhane_Detail.Furush_Sardkhane_ID = Furush_Sardkhane.ID   where Furush_Sardkhane.ID=" + Conversions.ToString(ID) + " order by Furush_Sardkhane_Detail.ID");
		}

		// Token: 0x060002BB RID: 699 RVA: 0x0003834C File Offset: 0x0003654C
		public long GetNewID(string Kharid_id)
		{
			return Conversions.ToLong(Public_Function.ExecuteScalar("select isnull(max(Num),0)+1 from dbo.furush_Sardkhane"));
		}

		// Token: 0x060002BC RID: 700 RVA: 0x00038370 File Offset: 0x00036570
		public long GetNavigateID(Furush_Sardkhane.NavTo nav, long num)
		{
			string empty = string.Empty;
			long result;
			switch (nav)
			{
			case Furush_Sardkhane.NavTo.forward:
				result = Conversions.ToLong(Public_Function.ExecuteScalar("SELECT TOP 1 Num FROM dbo.Furush_Sardkhane   WHERE Num > " + Conversions.ToString(num) + " ORDER BY Num ASC"));
				break;
			case Furush_Sardkhane.NavTo.backward:
				result = Conversions.ToLong(Public_Function.ExecuteScalar("SELECT TOP 1 Num FROM dbo.Furush_Sardkhane   WHERE Num < " + Conversions.ToString(num) + " ORDER BY Num DESC"));
				break;
			case Furush_Sardkhane.NavTo.first:
				result = Conversions.ToLong(Public_Function.ExecuteScalar(" SELECT isnull(MIN(Num),1) FROM dbo.Furush_Sardkhane"));
				break;
			case Furush_Sardkhane.NavTo.last:
				result = Conversions.ToLong(Public_Function.ExecuteScalar("SELECT isnull(MAX(Num),1) FROM dbo.Furush_Sardkhane"));
				break;
			}
			return result;
		}

		// Token: 0x060002BD RID: 701 RVA: 0x00033520 File Offset: 0x00031720
		public DataTable GetAll()
		{
			return Public_Function.FillData("Select dbo.Furush_Hag.ID,dbo.Furush_Hag.Num,dbo.Furush_Hag.Moshtari_ID,dbo.Furush_Hag.Sh_Mashin,dbo.Furush_Hag.Sh_Barname,dbo.Furush_Hag.Tarikh_Vurud,dbo.Furush_Hag.[Desc],dbo.Furush_Hag.Baskul,Baskul_Mabda,dbo.Furush_Hag.Tedad_Kol,dbo.Furush_Hag.Keraye,dbo.Furush_Hag.Hazine,dbo.Furush_Hag.Tarikh_Keraye,dbo.Furush_Hag.Tarikh_Hazine,dbo.Furush_Hag.Tarikh_Keraye_Fa,dbo.Furush_Hag.Tarikh_Hazine_Fa From dbo.Furush_Hag");
		}

		// Token: 0x060002BE RID: 702 RVA: 0x00038414 File Offset: 0x00036614
		public void UpdateSanadFurushNaghdByID(long id)
		{
			long value = Conversions.ToLong(Public_Function.ExecuteScalar("select num from furush_hag where id=" + Conversions.ToString(id)));
			this.UpdateSanadFurushNaghd(Conversions.ToString(value));
		}

		// Token: 0x060002BF RID: 703 RVA: 0x0002C50C File Offset: 0x0002A70C
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

		// Token: 0x060002C0 RID: 704 RVA: 0x0003844C File Offset: 0x0003664C
		public void UpdateSanadFurushNaghd(string num)
		{
			DataTable dataTable = Public_Function.FillData("SELECT     SUM(Furush_Sardkhane_Detail.Jam_Kol) AS Jam_Kol, Furush_Sardkhane_Detail.Tarikh,max(Daryaft_ID) AS Daryaft_ID  FROM         Furush_Sardkhane_Detail INNER JOIN  Furush_Sardkhane ON Furush_Sardkhane_Detail.Furush_Sardkhane_ID = Furush_Sardkhane.ID  where Furush_Sardkhane.Num=" + num + " and Furush_Sardkhane_Detail.Moshtari_id=-1 GROUP BY  Furush_Sardkhane_Detail.Tarikh");
			string text = "declare @daryaft_id bigint;declare @sanadbed_id bigint;declare @sanadbes_id bigint;declare @id bigint;select @id=id from furush_Sardkhane where num=" + num + ";";
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
							text += this.Daryaft.AddRowStrToDaryaft(Public_Function.MiladiToShamsi(Conversions.ToDate(dataRow["Tarikh"])), Conversions.ToString(dataRow["Jam_Kol"]), "سند شماره " + num, DaryaftPardakht.CodeHesab.فروش_نقد_سردخانه);
							text += "select @daryaft_id = scope_identity();";
							text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("update Furush_Sardkhane_Detail set daryaft_id=@daryaft_id where [Furush_Sardkhane_ID]=@id and Furush_Sardkhane_Detail.Moshtari_id=-1 and tarikh='", dataRow["tarikh"]), "';")));
						}
						else
						{
							text += this.Daryaft.UpdateRowStrToDaryaft(Public_Function.MiladiToShamsi(Conversions.ToDate(dataRow["Tarikh"])), Conversions.ToString(dataRow["Jam_Kol"]), "سند شماره " + num, Conversions.ToString(dataRow["daryaft_id"]), DaryaftPardakht.CodeHesab.فروش_نقد_سردخانه);
							text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("update Furush_sardkhane_Detail set daryaft_id=", dataRow["daryaft_id"]), " where [Furush_sardkhane_ID]=@id and Furush_sardkhane_Detail.Moshtari_id=-1 and tarikh='"), dataRow["tarikh"]), "';")));
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

		// Token: 0x060002C1 RID: 705 RVA: 0x00038660 File Offset: 0x00036860
		public long Insert(string Num, string Kharid_id, string Sh_Mashin, string Sh_Barname, string Tarikh_Vurud, string Desc, string Baskul, string Baskul_Mabda, string Tedad_Kol, string nahve_furush, DataTable dt)
		{
			string tozih = string.Empty;
			string text = "declare @id bigint;declare @sanad_id int;declare @codehesab_id int;declare @sanadbed_id int;declare @sanadbes_id int;declare @daryaft_id int;declare @keraye_pardakht_id int;declare @hazine_pardakht_id int;";
			string right = string.Empty;
			text = string.Concat(new string[]
			{
				text,
				" Insert Into dbo.Furush_Sardkhane(Num,Kharid_Sardkhane_ID,Sh_Mashin,Sh_Barname,Tarikh_Vurud,[Desc],Baskul,Baskul_Mabda,Tedad_Kol,nahve_furush) VALUES(",
				Num,
				",",
				Kharid_id,
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
				Public_Function.GetValueInt(nahve_furush),
				");Select @id=Scope_Identity();"
			});
			try
			{
				IEnumerator enumerator = dt.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					tozih = " فروش سردخانه سند " + Num;
					bool flag = Operators.ConditionalCompareObjectNotEqual(dataRow["Moshtari_ID"], -1, false) && Operators.ConditionalCompareObjectNotEqual(dataRow["Moshtari_ID"], -2, false) && Operators.ConditionalCompareObjectNotEqual(dataRow["Moshtari_ID"], -3, false);
					if (flag)
					{
						text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("select @codehesab_id=Codehesab_id from Moshtari where id=", dataRow["Moshtari_ID"]), ";")));
						text += this.Sanad.InsertStr("@codehesab_id", dataRow["Jam_Kol"].ToString(), "0", dataRow["Tarikh_Fa"].ToString(), tozih, Sanad.SanadType.فروش_از_سردخانه_به_مشتری);
						text += "Select @Sanad_id=Scope_Identity();";
					}
					if (Operators.ConditionalCompareObjectEqual(dataRow["moshtari_id"], -1, false) || Operators.ConditionalCompareObjectEqual(dataRow["moshtari_id"], -2, false))
					{
						goto IL_26A;
					}
					if (Operators.ConditionalCompareObjectEqual(dataRow["Moshtari_ID"], -3, false))
					{
						goto IL_26A;
					}
					bool arg_26C_0 = false;
					IL_26B:
					flag = arg_26C_0;
					if (flag)
					{
						right = "NULL";
					}
					else
					{
						right = "@sanad_id";
					}
					text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Insert Into dbo.Furush_Sardkhane_Detail(Furush_Sardkhane_ID,Moshtari_ID,Kala_ID,Tarikh,Tarikh_Fa,Tedad,Vazn_Ba_Zarf,Zarf,Vazn_Kol,Fee,Jam_Kol,Sanad_ID,daryaft_id) VALUES(@id,", dataRow["Moshtari_ID"]), ","), dataRow["Kala_ID"]), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Conversions.ToString(dataRow["Tarikh_Fa"])))), ","), Public_Function.GetValue(Conversions.ToString(dataRow["Tarikh_Fa"]))), ","), Public_Function.GetValueInt(dataRow["Tedad"].ToString())), ","), Public_Function.GetValueInt(dataRow["Vazn_Ba_Zarf"].ToString())), ","), Public_Function.GetValueInt(dataRow["Zarf"].ToString())), ","), dataRow["Vazn_Kol"]), ","), dataRow["Fee"]), ","), dataRow["Jam_Kol"]), ","), right), ","), Interaction.IIf(Operators.ConditionalCompareObjectEqual(dataRow["Moshtari_ID"], -1, false), "@daryaft_id", "NULL")), ");")));
					continue;
					IL_26A:
					arg_26C_0 = true;
					goto IL_26B;
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

		// Token: 0x060002C2 RID: 706 RVA: 0x00038B04 File Offset: 0x00036D04
		public void Update(string ID, string Num, string Kharid_ID, string Sh_Mashin, string Sh_Barname, string Tarikh_Vurud, string Desc, string Baskul, string Baskul_Mabda, string Tedad_Kol, string nahve_furush, DataTable dt)
		{
			string iD = Public_Function.GetID(dt, "ID", "");
			string tozih = string.Empty;
			string text = "declare @sanad_id int;declare @codehesab_id int;declare @sanadbed_id int;declare @sanadbes_id int;declare @daryaft_id int;declare @keraye_pardakht_id int;declare @hazine_pardakht_id int;";
			DataTable dataTable = Public_Function.FillData("select distinct daryaft_id as id from furush_Sardkhane_detail where furush_Sardkhane_id=" + ID + " and daryaft_id is not null");
			string right = string.Empty;
			text = string.Concat(new string[]
			{
				text,
				" Update dbo.Furush_Sardkhane SET Num=",
				Num,
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
								goto IL_672;
							}
							if (Operators.ConditionalCompareObjectEqual(dataRow["moshtari_id"], -3, false))
							{
								goto IL_672;
							}
							bool arg_674_0 = false;
							IL_673:
							flag2 = arg_674_0;
							if (flag2)
							{
								flag = (Operators.ConditionalCompareObjectEqual(dataRow["moshtari_id"], -2, false) || Operators.ConditionalCompareObjectEqual(dataRow["moshtari_id"], -3, false));
								if (flag)
								{
									flag3 = (dataRow["Daryaft_ID"] != DBNull.Value);
									if (flag3)
									{
										text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("update Furush_Sardkhane_Detail set daryaft_id=null where id=", dataRow["ID"]), ";")));
									}
								}
								flag3 = (dataRow["sanad_id"] != DBNull.Value);
								if (flag3)
								{
									string text2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("update Furush_Sardkhane_Detail set sanad_id=null where id=", dataRow["ID"]), ";"));
									text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(" delete from sanad where id=", dataRow["sanad_id"]), ";")));
									Public_Function.ExecuteNonQuery(text2);
								}
								goto IL_782;
							}
							goto IL_782;
							IL_672:
							arg_674_0 = true;
							goto IL_673;
						}
						flag = (dataRow["Daryaft_ID"] != DBNull.Value);
						if (flag)
						{
							text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("update Furush_Sardkhane_Detail set daryaft_id=null where id=", dataRow["ID"]), ";")));
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
						IL_782:
						if (Operators.ConditionalCompareObjectEqual(dataRow["moshtari_ID"], -1, false) || Operators.ConditionalCompareObjectEqual(dataRow["moshtari_ID"], -2, false))
						{
							goto IL_7D8;
						}
						if (Operators.ConditionalCompareObjectEqual(dataRow["moshtari_ID"], -3, false))
						{
							goto IL_7D8;
						}
						bool arg_7DA_0 = false;
						IL_7D9:
						flag3 = arg_7DA_0;
						if (flag3)
						{
							right = "NULL";
						}
						else
						{
							right = "@sanad_ID";
						}
						text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Update dbo.Furush_Sardkhane_Detail SET Moshtari_ID=", dataRow["Moshtari_ID"]), " ,Kala_ID="), dataRow["Kala_ID"]), " ,Tarikh="), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Conversions.ToString(dataRow["Tarikh_Fa"])))), " ,Tarikh_Fa="), Public_Function.GetValue(Conversions.ToString(dataRow["Tarikh_Fa"]))), " ,Tedad="), Public_Function.GetValueInt(dataRow["Tedad"].ToString())), " ,Vazn_Ba_Zarf="), Public_Function.GetValueInt(dataRow["Vazn_Ba_Zarf"].ToString())), " ,Zarf="), Public_Function.GetValueInt(dataRow["Zarf"].ToString())), " ,Vazn_Kol="), dataRow["Vazn_Kol"]), " ,Fee="), dataRow["Fee"]), " ,Jam_Kol="), dataRow["Jam_Kol"]), " , Sanad_ID="), right), " Where ID="), dataRow["ID"]), ";")));
						continue;
						IL_7D8:
						arg_7DA_0 = true;
						goto IL_7D9;
					}
					flag2 = (Operators.ConditionalCompareObjectNotEqual(dataRow["Moshtari_ID"], -1, false) && Operators.ConditionalCompareObjectNotEqual(dataRow["moshtari_id"], -2, false) && Operators.ConditionalCompareObjectNotEqual(dataRow["moshtari_ID"], -3, false));
					if (flag2)
					{
						tozih = " فروش سردخانه سند " + Num;
						text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("select @codehesab_id=Codehesab_id from Moshtari where id=", dataRow["Moshtari_ID"]), ";")));
						text += this.Sanad.InsertStr("@codehesab_id", dataRow["Jam_Kol"].ToString(), "0", dataRow["Tarikh_Fa"].ToString(), tozih, Sanad.SanadType.فروش_از_سردخانه_به_مشتری);
						text += "Select @Sanad_id=Scope_Identity();";
						right = "@sanad_id";
					}
					else
					{
						right = "NULL";
					}
					text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Insert Into dbo.Furush_Sardkhane_Detail(Furush_Sardkhane_ID,Moshtari_ID,Kala_ID,Tarikh,Tarikh_Fa,Tedad,Vazn_Ba_Zarf,Zarf,Vazn_Kol,Fee,Jam_Kol,Sanad_ID,daryaft_id) VALUES(" + ID + ",", dataRow["Moshtari_ID"]), ","), dataRow["Kala_ID"]), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Conversions.ToString(dataRow["Tarikh_Fa"])))), ","), Public_Function.GetValue(Conversions.ToString(dataRow["Tarikh_Fa"]))), ","), Public_Function.GetValueInt(dataRow["Tedad"].ToString())), ","), Public_Function.GetValueInt(dataRow["Vazn_Ba_Zarf"].ToString())), ","), Public_Function.GetValueInt(dataRow["Zarf"].ToString())), ","), Public_Function.GetValueInt(Conversions.ToString(dataRow["Vazn_Kol"]))), ","), dataRow["Fee"]), ","), dataRow["Jam_Kol"]), ","), right), ",@daryaft_id"), ");")));
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
				DataTable dataTable2 = Public_Function.FillData("select distinct daryaft_id as id from furush_Sardkhane_detail where furush_Sardkhane_id=" + ID + " and daryaft_id is Not null");
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

		// Token: 0x060002C3 RID: 707 RVA: 0x000397DC File Offset: 0x000379DC
		public void Delete(string ID)
		{
			string text = string.Empty;
			string text2 = string.Empty;
			string text3 = string.Empty;
			DataTable dataTable = Public_Function.FillData("select * from furush_sardkhane_keraye where furush_Sardkhane_id=" + ID);
			bool flag = dataTable.Rows.Count > 0;
			if (flag)
			{
				text3 = Public_Function.GetID(dataTable, "keraye_pardakht_id", "");
				DataTable dt = Public_Function.FillData("select sanadbed_id,sanadbes_id from daryaftpardakht where id in(" + text3 + ");");
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
				text = text + "delete from daryaftpardakht where id in(" + text3 + ");";
				text = text + "delete from furush_sardkhane_keraye where furush_Sardkhane_id=" + ID + ";";
				Public_Function.ExecuteNonQuery(text);
				text = string.Empty;
			}
			text = text + " delete from [Furush_Sardkhane_RizBar] where furush_Sardkhane_id=" + ID + ";";
			DataRow dataRow = Public_Function.FillDataRow("select * from furush_Sardkhane_safi where furush_Sardkhane_id=" + ID);
			flag = (dataRow != null);
			if (flag)
			{
				text = text + "update furush_Sardkhane_Safi set sanad_id=null,karmozd_sanad_id=null where furush_Sardkhane_id=" + ID + ";";
				flag = (dataRow["sanad_id"] != DBNull.Value);
				if (flag)
				{
					text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject("delete from sanad where id in(", dataRow["sanad_id"])));
				}
				flag = (dataRow["karmozd_sanad_id"] != DBNull.Value);
				if (flag)
				{
					text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("delete from sanad where id in(", dataRow["karmozd_sanad_id"]), ");")));
				}
				text = text + "delete from furush_Sardkhane_Safi where furush_Sardkhane_id=" + ID + ";";
				Public_Function.ExecuteNonQuery(text);
				text = string.Empty;
			}
			DataTable dataTable2 = Public_Function.FillData("select * from furush_Sardkhane_detail where furush_Sardkhane_id=" + ID);
			flag = (dataTable2.Rows.Count > 0);
			if (flag)
			{
				text2 = Public_Function.GetID(dataTable2, "sanad_id", "");
				text = text + " update furush_sardkhane_detail set sanad_id=null where furush_sardkhane_id= " + ID + ";";
				flag = (text2.Length > 0);
				if (flag)
				{
					text = text + "delete from sanad where id in(" + text2 + ");";
				}
				Public_Function.ExecuteNonQuery(text);
				text = string.Empty;
				string iD = Public_Function.GetID(dataTable2, "ID", "");
				text3 = Public_Function.GetID(dataTable2, "daryaft_id", "");
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
					bool flag2;
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
					text = text + "update furush_Sardkhane_detail set daryaft_id=null where id in(" + iD + ");";
					text = text + "delete from daryaftpardakht where id in(" + text3 + ");";
				}
			}
			text = text + "Delete From dbo.Furush_Sardkhane Where Id= " + ID + ";";
			Public_Function.ExecuteNonQuery(text);
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x00039BE8 File Offset: 0x00037DE8
		public void DeleteDetailByID(string id)
		{
			long value = Conversions.ToLong(Public_Function.ExecuteScalar("select isnull(daryaft_id,0) from Furush_Sardkhane_Detail where id=" + id));
			long num = Conversions.ToLong(Public_Function.ExecuteScalar("select Furush_Sardkhane_ID from Furush_Sardkhane_Detail where id=" + id));
			string text = "declare @sanad_id int;declare @daryaft_id int;declare @sanadbes_id int;declare @sanadbed_id int;";
			text = text + "select @sanad_id=sanad_id , @daryaft_id=daryaft_id from Furush_Sardkhane_Detail where id=" + id + ";";
			text = text + "update Furush_Sardkhane_Detail set sanad_id=null,daryaft_id=null where id=" + id + ";";
			text += "delete from sanad where id=@sanad_id;";
			text = text + "delete from Furush_Sardkhane_Detail where id=" + id + ";";
			Public_Function.ExecuteNonQuery(text);
			int num2 = Conversions.ToInteger(Public_Function.ExecuteScalar("select isnull(count(id),0) from Furush_Sardkhane_Detail where Furush_Sardkhane_ID=" + Conversions.ToString(num) + " and daryaft_id=" + Conversions.ToString(value)));
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

		// Token: 0x04000113 RID: 275
		private Sanad Sanad;

		// Token: 0x04000114 RID: 276
		private DaryaftPardakht Daryaft;

		// Token: 0x0200002E RID: 46
		public enum NavTo
		{
			// Token: 0x04000116 RID: 278
			forward = 1,
			// Token: 0x04000117 RID: 279
			backward,
			// Token: 0x04000118 RID: 280
			first,
			// Token: 0x04000119 RID: 281
			last
		}
	}
}
