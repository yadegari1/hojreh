using System;
using System.Collections;
using System.Data;
using System.Diagnostics;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x02000049 RID: 73
	public class Sanad_Dasti
	{
		// Token: 0x06000366 RID: 870 RVA: 0x000020C1 File Offset: 0x000002C1
		[DebuggerNonUserCode]
		public Sanad_Dasti()
		{
		}

		// Token: 0x06000367 RID: 871 RVA: 0x00048420 File Offset: 0x00046620
		private string AddRowStrToDaryaftExtend(string Tarikh, string Mablagh, bool daryaftorPardakht, string Tozih, string ID)
		{
			string text = string.Empty;
			string text2 = string.Empty;
			if (daryaftorPardakht)
			{
				text2 = Conversions.ToString(-6);
			}
			else
			{
				text2 = Conversions.ToString(-7);
			}
			bool flag = Operators.CompareString(ID, string.Empty, false) == 0;
			if (flag)
			{
				text = string.Concat(new string[]
				{
					text,
					"Insert Into dbo.DaryaftPardakht(dpType_ID,Tarikh,Mablagh,Tozih,Tarikh_Fa) VALUES(",
					text2,
					",",
					Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh)),
					",",
					Mablagh,
					",",
					Public_Function.GetValue(Tozih),
					",",
					Public_Function.GetValue(Tarikh),
					");select @dp_id=scope_identity();"
				});
			}
			else
			{
				text = string.Concat(new string[]
				{
					text,
					"update daryaftpardakht set  dptype_id=",
					text2,
					" ,mablagh=",
					Mablagh,
					" ,Tozih=",
					Public_Function.GetValue(Tozih),
					" where id =",
					ID,
					";"
				});
			}
			return text;
		}

		// Token: 0x06000368 RID: 872 RVA: 0x0004854C File Offset: 0x0004674C
		public string Update(string Tarikh, bool dorp, string Tozih, DataTable dt)
		{
			string text = "declare @sanad_dasti_id bigint;declare @dp_id bigint;declare @sanad_id bigint;";
			DataRow dataRow = Public_Function.FillDataRow("select * from sanad_dasti where tarikh=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh)));
			string iD = Public_Function.GetID(dt, "id", "");
			Sanad sanad = new Sanad();
			DaryaftPardakht daryaftPardakht = new DaryaftPardakht();
			bool flag = iD.Length > 0;
			if (flag)
			{
				text = string.Concat(new string[]
				{
					text,
					" delete from sanad where id in (select sanad_id from sanad_dasti_detail where id in (select id from sanad_dasti_detail where tarikh=",
					Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh)),
					" and id not in (",
					iD,
					")));"
				});
				text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" delete from sanad_dasti_detail where sanad_dasti_id=", dataRow["id"]), " and ID not in ("), iD), ");")));
			}
			else
			{
				flag = (dataRow != null);
				if (flag)
				{
					text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(" delete from sanad where id in (select sanad_id from sanad_dasti_detail where sanad_dasti_id=", dataRow["ID"]), ");")));
					text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(" delete from sanad_dasti_detail where sanad_dasti_id=", dataRow["id"]), ";")));
				}
			}
			flag = (dataRow == null);
			if (flag)
			{
				bool flag2 = dt.Rows.Count > 0;
				if (flag2)
				{
					text += this.AddRowStrToDaryaftExtend(Tarikh, Public_Function.GetSum(dt, "bed"), dorp, Tozih, "");
					text = string.Concat(new string[]
					{
						text,
						" insert into sanad_dasti (dp_id,dorp,Tarikh,tarikh_fa,[desc]) values(@dp_id,",
						Public_Function.GetValueInt(Conversions.ToString(dorp)),
						",",
						Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh)),
						",",
						Public_Function.GetValue(Tarikh),
						",",
						Public_Function.GetValue(Tozih),
						");select @sanad_dasti_id=scope_identity();"
					});
				}
			}
			else
			{
				bool flag2 = dt.Rows.Count > 0;
				if (flag2)
				{
					text += this.AddRowStrToDaryaftExtend(Tarikh, Public_Function.GetSum(dt, "bed"), dorp, Tozih, Conversions.ToString(dataRow["dp_id"]));
					text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(" update sanad_dasti set  dorp=" + Public_Function.GetValueInt(Conversions.ToString(dorp)) + " ,tarikh= " + Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh)) + " ,tarikh_fa= " + Public_Function.GetValue(Tarikh) + " ,[desc]= " + Public_Function.GetValue(Tozih) + " where id =", dataRow["id"]), ";")));
					text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("select @sanad_dasti_id=", dataRow["ID"]), ";")));
					text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("select @dp_id=", dataRow["dp_id"]), ";")));
				}
				else
				{
					text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(" delete from daryaftpardakht where id=", dataRow["dp_id"]), ";")));
					text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(" delete from sanad_dasti where id=", dataRow["id"]), ";")));
				}
			}
			try
			{
				IEnumerator enumerator = dt.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow2 = (DataRow)enumerator.Current;
					bool flag2 = dataRow2["ID"] == DBNull.Value;
					if (flag2)
					{
						text += sanad.InsertStr(dataRow2["codehesab_id"].ToString(), dataRow2["bed"].ToString(), dataRow2["bes"].ToString(), Tarikh.ToString(), dataRow2["desc"].ToString(), "@sanad_id", Sanad.SanadType.@null);
						text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" insert into sanad_dasti_detail ([sanad_dasti_id],[Hesab_Type],[Sandugh_id],[Moshtari_id],[BankHesab_ID],[Hazine_ID],[Daramad_ID],[bed],[bes],[Sanad_ID],[Desc]) values(@sanad_dasti_id,", dataRow2["hesab_type"]), ","), Public_Function.GetValueInt(dataRow2["sandugh_id"].ToString())), ","), Public_Function.GetValueInt(dataRow2["moshtari_id"].ToString())), ","), Public_Function.GetValueInt(dataRow2["bankhesab_id"].ToString())), ","), Public_Function.GetValueInt(dataRow2["hazine_id"].ToString())), ","), Public_Function.GetValueInt(dataRow2["daramad_id"].ToString())), ","), Public_Function.GetValueInt(dataRow2["bed"].ToString())), ","), Public_Function.GetValueInt(dataRow2["bes"].ToString())), ",@sanad_id,"), Public_Function.GetValue(dataRow2["desc"].ToString())), ");")));
					}
					else
					{
						flag2 = (NewLateBinding.LateGet(null, typeof(Public_Function), "ExecuteScalar", new object[]
						{
							Operators.ConcatenateObject("select id from sanad where id=", dataRow2["sanad_ID"])
						}, null, null, null) != null);
						if (flag2)
						{
							text += sanad.UpdateStr(Conversions.ToString(dataRow2["codehesab_id"]), Conversions.ToString(dataRow2["bed"]), Conversions.ToString(dataRow2["bes"]), Tarikh, Public_Function.ShamsiToMiladi(Tarikh), Conversions.ToString(dataRow2["sanad_id"]), Sanad.SanadType.@null);
							text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("set @sanad_id = ", dataRow2["sanad_id"]), ";")));
						}
						else
						{
							text += sanad.InsertStr(dataRow2["codehesab_id"].ToString(), dataRow2["bed"].ToString(), dataRow2["bes"].ToString(), Tarikh.ToString(), dataRow2["desc"].ToString(), "@sanad_id", Sanad.SanadType.@null);
						}
						text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" update sanad_dasti_detail set   [Hesab_Type] = ", dataRow2["hesab_type"]), "  ,[Sandugh_id] = "), Public_Function.GetValueInt(dataRow2["sandugh_id"].ToString())), "  ,[Moshtari_id] ="), Public_Function.GetValueInt(dataRow2["moshtari_id"].ToString())), "  ,[BankHesab_ID] ="), Public_Function.GetValueInt(dataRow2["bankhesab_id"].ToString())), "  ,[Hazine_ID] = "), Public_Function.GetValueInt(dataRow2["hazine_id"].ToString())), "  ,[Daramad_ID] = "), Public_Function.GetValueInt(dataRow2["daramad_id"].ToString())), "  ,[sanad_id] = @sanad_id"), "  ,[bed] = "), Public_Function.GetValue(dataRow2["bed"].ToString())), "  ,[bes] = "), Public_Function.GetValueInt(dataRow2["bes"].ToString())), "  ,[Desc] = "), Public_Function.GetValue(dataRow2["desc"].ToString())), " where id ="), dataRow2["ID"]), ";")));
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
			text += "select @dp_id;";
			return Public_Function.ExecuteScalar(text).ToString();
		}
	}
}
