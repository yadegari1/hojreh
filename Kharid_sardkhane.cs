using System;
using System.Collections;
using System.Data;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x02000036 RID: 54
	public class Kharid_sardkhane
	{
		// Token: 0x060002ED RID: 749 RVA: 0x0000267D File Offset: 0x0000087D
		public Kharid_sardkhane()
		{
			this.iSanad = new Sanad();
			this.Daryaft = new DaryaftPardakht();
		}

		// Token: 0x060002EE RID: 750 RVA: 0x0003F140 File Offset: 0x0003D340
		public DataRow GetByID(long Num)
		{
			return Public_Function.FillDataRow("SELECT     Kharid_Sardkhane.*  FROM Kharid_sardkhane  where type is null and num=" + Conversions.ToString(Num));
		}

		// Token: 0x060002EF RID: 751 RVA: 0x0003F168 File Offset: 0x0003D368
		public DataTable GetDetailByID(long ID)
		{
			DataTable dataTable = Public_Function.FillData("SELECT     Furush_Sardkhane.Num, SUM(Furush_Sardkhane_Detail.Tedad) AS Tedad, SUM(Furush_Sardkhane_Detail.Vazn_Kol) AS Vazn_Kol,   sum (Furush_Sardkhane_Detail.Jam_Kol) AS Mande, Furush_Sardkhane_Detail.Kala_ID, MAX(Kala.Name) AS Kala_Name, MAX(Furush_Sardkhane_Safi.Mande)   AS Jam_Kol, CAST(sum (Furush_Sardkhane_Detail.Jam_Kol) / SUM(Furush_Sardkhane_Detail.Vazn_Kol) AS bigint) AS Fee     FROM         Furush_Sardkhane_Safi INNER JOIN   Furush_Sardkhane ON Furush_Sardkhane_Safi.Furush_Sardkhane_ID = Furush_Sardkhane.ID INNER JOIN   Furush_Sardkhane_Detail ON Furush_Sardkhane.ID = Furush_Sardkhane_Detail.Furush_Sardkhane_ID INNER JOIN   Kala ON Furush_Sardkhane_Detail.Kala_ID = Kala.ID  WHERE (Furush_Sardkhane.Kharid_Sardkhane_ID = " + Conversions.ToString(ID) + ")   GROUP BY Furush_Sardkhane.Num, Furush_Sardkhane_Detail.Kala_ID");
			dataTable.Columns.Add(new DataColumn("row_index", typeof(int)));
			return dataTable;
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x0003F1B8 File Offset: 0x0003D3B8
		public long GetNewID()
		{
			return Conversions.ToLong(Public_Function.ExecuteScalar("select isnull(max(Num),0)+1 from dbo.Kharid_sardkhane where type is null"));
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x0003F1DC File Offset: 0x0003D3DC
		public long GetNavigateID(Kharid_sardkhane.NavTo nav, long num)
		{
			string empty = string.Empty;
			long result;
			switch (nav)
			{
			case Kharid_sardkhane.NavTo.forward:
				result = Conversions.ToLong(Public_Function.ExecuteScalar("SELECT TOP 1 Num FROM dbo.Kharid_sardkhane   WHERE  type is null and Num > " + Conversions.ToString(num) + " ORDER BY Num ASC"));
				break;
			case Kharid_sardkhane.NavTo.backward:
				result = Conversions.ToLong(Public_Function.ExecuteScalar("SELECT TOP 1 Num FROM dbo.Kharid_sardkhane   WHERE  type is null and Num < " + Conversions.ToString(num) + " ORDER BY Num DESC"));
				break;
			case Kharid_sardkhane.NavTo.first:
				result = Conversions.ToLong(Public_Function.ExecuteScalar(" SELECT MIN(Num) FROM dbo.Kharid_sardkhane where type is null"));
				break;
			case Kharid_sardkhane.NavTo.last:
				result = Conversions.ToLong(Public_Function.ExecuteScalar("SELECT MAX(Num) FROM dbo.Kharid_sardkhane where type is null"));
				break;
			}
			return result;
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x00033520 File Offset: 0x00031720
		public DataTable GetAll()
		{
			return Public_Function.FillData("Select dbo.Furush_Hag.ID,dbo.Furush_Hag.Num,dbo.Furush_Hag.Moshtari_ID,dbo.Furush_Hag.Sh_Mashin,dbo.Furush_Hag.Sh_Barname,dbo.Furush_Hag.Tarikh_Vurud,dbo.Furush_Hag.[Desc],dbo.Furush_Hag.Baskul,Baskul_Mabda,dbo.Furush_Hag.Tedad_Kol,dbo.Furush_Hag.Keraye,dbo.Furush_Hag.Hazine,dbo.Furush_Hag.Tarikh_Keraye,dbo.Furush_Hag.Tarikh_Hazine,dbo.Furush_Hag.Tarikh_Keraye_Fa,dbo.Furush_Hag.Tarikh_Hazine_Fa From dbo.Furush_Hag");
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x0003F280 File Offset: 0x0003D480
		public void UpdateSanadFurushNaghdByID(long id)
		{
			long value = Conversions.ToLong(Public_Function.ExecuteScalar("select num from Kharid where id=" + Conversions.ToString(id)));
			this.UpdateSanadFurushNaghd(Conversions.ToString(value));
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x0002C50C File Offset: 0x0002A70C
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

		// Token: 0x060002F5 RID: 757 RVA: 0x0003F2B8 File Offset: 0x0003D4B8
		public void UpdateSanadFurushNaghd(string num)
		{
			DataTable dataTable = Public_Function.FillData("SELECT     SUM(Kharid_Furush.Jam_Kol) AS Jam_Kol, Kharid_Furush.Tarikh,max(Daryaft_ID) AS Daryaft_ID  FROM         Kharid_Furush INNER JOIN  Kharid ON Kharid_Furush.Kharid_ID = Kharid.ID  where Kharid.Num=" + num + " and Kharid_Furush.Moshtari_id=-1 GROUP BY  Kharid_Furush.Tarikh");
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
							text += this.Daryaft.AddRowStrToDaryaft(Public_Function.MiladiToShamsi(Conversions.ToDate(dataRow["Tarikh"])), Conversions.ToString(dataRow["Jam_Kol"]), "فروش نقد سند شماره " + num, DaryaftPardakht.CodeHesab.فروش_نقد_خرید);
							text += "select @daryaft_id = scope_identity();";
							text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("update Kharid_Furush set daryaft_id=@daryaft_id where [Kharid_ID]=@id and Kharid_Furush.Moshtari_id=-1 and tarikh='", dataRow["tarikh"]), "';")));
						}
						else
						{
							text += this.Daryaft.UpdateRowStrToDaryaft(Public_Function.MiladiToShamsi(Conversions.ToDate(dataRow["Tarikh"])), Conversions.ToString(dataRow["Jam_Kol"]), "فروش نقد سند شماره " + num, Conversions.ToString(dataRow["daryaft_id"]), DaryaftPardakht.CodeHesab.فروش_نقد_خرید);
							text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("update Kharid_Furush set daryaft_id=", dataRow["daryaft_id"]), " where [Kharid_ID]=@id and Kharid_Furush.Moshtari_id=-1 and tarikh='"), dataRow["tarikh"]), "';")));
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

		// Token: 0x060002F6 RID: 758 RVA: 0x0003F4CC File Offset: 0x0003D6CC
		public void UpdateDaramad(string num)
		{
			long value = Conversions.ToLong(Public_Function.ExecuteScalar("select id from kharid_Sardkhane where type is null and num=" + num));
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

		// Token: 0x060002F7 RID: 759 RVA: 0x0003FA24 File Offset: 0x0003DC24
		public long Insert(string Num, string Tarikh_Vurud, string Desc)
		{
			string empty = string.Empty;
			string text = "declare @id bigint;declare @sanad_id int;declare @codehesab_id int;declare @sanadbed_id int;declare @sanadbes_id int;declare @daryaft_id int;declare @keraye_pardakht_id int;declare @hazine_pardakht_id int;";
			text = string.Concat(new string[]
			{
				text,
				" Insert Into dbo.Kharid_sardkhane(Num,Tarikh_Vurud,[Desc]) VALUES(",
				Num,
				",",
				Public_Function.GetValue(Tarikh_Vurud),
				",",
				Public_Function.GetValue(Desc),
				");Select @id=Scope_Identity();"
			});
			text += "select @id;";
			return Conversions.ToLong(Public_Function.ExecuteScalar(text));
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x0003FAB8 File Offset: 0x0003DCB8
		public void Update(string ID, string Num, string Tarikh_Vurud, string Desc)
		{
			string empty = string.Empty;
			string text = "declare @sanad_id int;declare @codehesab_id int;declare @sanadbed_id int;declare @sanadbes_id int;declare @daryaft_id int;declare @keraye_pardakht_id int;declare @hazine_pardakht_id int;";
			text = string.Concat(new string[]
			{
				text,
				" Update dbo.Kharid_sardkhane SET Num=",
				Num,
				" ,[Desc]=",
				Public_Function.GetValue(Desc),
				" Where ID=",
				ID
			});
			Public_Function.ExecuteNonQuery(text);
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x0003FB20 File Offset: 0x0003DD20
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

		// Token: 0x060002FA RID: 762 RVA: 0x0003FEC0 File Offset: 0x0003E0C0
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

		// Token: 0x04000128 RID: 296
		private Sanad iSanad;

		// Token: 0x04000129 RID: 297
		private DaryaftPardakht Daryaft;

		// Token: 0x02000037 RID: 55
		public enum NavTo
		{
			// Token: 0x0400012B RID: 299
			forward = 1,
			// Token: 0x0400012C RID: 300
			backward,
			// Token: 0x0400012D RID: 301
			first,
			// Token: 0x0400012E RID: 302
			last
		}
	}
}
