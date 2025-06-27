using System;
using System.Collections;
using System.Data;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x02000033 RID: 51
	public class Kharid_Detail
	{
		// Token: 0x060002DE RID: 734 RVA: 0x00002613 File Offset: 0x00000813
		public Kharid_Detail()
		{
			this.Isanad = new Sanad();
		}

		// Token: 0x060002DF RID: 735 RVA: 0x00002628 File Offset: 0x00000828
		public void DeleteByID(string ID)
		{
			Public_Function.ExecuteNonQuery("delete from Kharid_Detail where ID=" + ID);
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x0003D41C File Offset: 0x0003B61C
		public DataTable GetByID(int Kharid_ID)
		{
			return Public_Function.FillData("SELECT  Kharid_Detail.*, Kala.Name AS Kala_Name, Moshtari.Name + ' ' + Moshtari.Family AS moshtari_name  FROM    Kharid_Detail INNER JOIN  Kala ON Kharid_Detail.Kala_ID = Kala.ID LEFT OUTER JOIN   Moshtari ON Kharid_Detail.moshtari_id = Moshtari.ID   WHERE  Kharid_ID=" + Conversions.ToString(Kharid_ID));
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x0003D444 File Offset: 0x0003B644
		public void Insert(int Kharid_ID, DataTable dt)
		{
			string text = string.Empty;
			bool flag;
			try
			{
				IEnumerator enumerator = dt.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Insert Into dbo.Kharid_Detail(Kharid_ID,Kala_ID,Tedad,Vazn_Ba_Zarf,Zarf,Vazn_Kol,Fee,Jam_Kol) VALUES(" + Conversions.ToString(Kharid_ID) + ",", dataRow["Kala_ID"]), ","), Public_Function.GetValueInt(dataRow["Tedad"].ToString())), ","), Public_Function.GetValueInt(dataRow["Vazn_Ba_Zarf"].ToString())), ","), Public_Function.GetValueInt(dataRow["Zarf"].ToString())), ","), dataRow["Vazn_Kol"]), ","), dataRow["Fee"]), ","), dataRow["Jam_Kol"]), ");")));
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
			flag = (text.Length > 0);
			if (flag)
			{
				Public_Function.ExecuteNonQuery(text);
			}
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x0003D5D4 File Offset: 0x0003B7D4
		public void Update(int Kharid_ID, DataTable dt, int kind)
		{
			string iD = Public_Function.GetID(dt, "ID", "");
			string text = "declare @id bigint;";
			bool flag;
			try
			{
				IEnumerator enumerator = dt.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					flag = (dataRow["vazn_ba_zarf"] == DBNull.Value || Operators.ConditionalCompareObjectEqual(dataRow["vazn_ba_zarf"], 0, false));
					if (flag)
					{
						dataRow["vazn_ba_zarf"] = RuntimeHelpers.GetObjectValue(dataRow["vazn_kol"]);
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
			flag = (iD.Length > 0);
			if (flag)
			{
				text = string.Concat(new string[]
				{
					text,
					"delete from sanad where id in(select sanad_id from kharid_detail where kharid_id=",
					Conversions.ToString(Kharid_ID),
					" and id not in(",
					iD,
					")) "
				});
				text = string.Concat(new string[]
				{
					text,
					"Delete From dbo.Kharid_Detail Where Kharid_ID=",
					Conversions.ToString(Kharid_ID),
					" AND ID NOT IN(",
					iD,
					");"
				});
			}
			else
			{
				text = text + "delete from sanad where id in(select sanad_id from kharid_detail where kharid_id=" + Conversions.ToString(Kharid_ID) + ");";
				text = text + "Delete From dbo.Kharid_Detail Where Kharid_ID=" + Conversions.ToString(Kharid_ID) + ";";
			}
			flag = (dt != null);
			bool flag2;
			if (flag)
			{
				flag2 = (dt.Rows.Count > 0);
				if (flag2)
				{
					DataRow dataRow2 = Public_Function.FillDataRow("select * from kharid where id= " + Conversions.ToString(Kharid_ID));
					string str = Conversions.ToString(dataRow2["num"]);
					string text2 = Conversions.ToString(dataRow2["tarikh_vurud"]);
					flag2 = (kind == 1);
					long value;
					DataTable dataTable;
					if (flag2)
					{
						value = Conversions.ToLong(NewLateBinding.LateGet(null, typeof(Public_Function), "ExecuteScalar", new object[]
						{
							Operators.ConcatenateObject("select codehesab_id from moshtari where id=", dataRow2["moshtari_ID"])
						}, null, null, null));
						try
						{
							IEnumerator enumerator2 = dt.Rows.GetEnumerator();
							while (enumerator2.MoveNext())
							{
								DataRow dataRow3 = (DataRow)enumerator2.Current;
								dataRow3["moshtari_id"] = RuntimeHelpers.GetObjectValue(dataRow2["moshtari_ID"]);
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
						dataTable = Public_Function.FillData("select id,codehesab_id from moshtari where id in(" + Public_Function.GetID(dt, "moshtari_id", "") + ")");
					}
					try
					{
						IEnumerator enumerator3 = dt.Rows.GetEnumerator();
						while (enumerator3.MoveNext())
						{
							DataRow dataRow4 = (DataRow)enumerator3.Current;
							flag2 = (kind == 2);
							if (flag2)
							{
								value = Conversions.ToLong(dataTable.Select(Conversions.ToString(Operators.ConcatenateObject("id=", dataRow4["moshtari_id"])))[0]["codehesab_id"]);
							}
							flag2 = (dataRow4["ID"] == DBNull.Value);
							if (flag2)
							{
								text += this.Isanad.InsertStr(value.ToString(), "0", dataRow4["jam_kol"].ToString(), Conversions.ToString(dataRow4["tarikh_fa"]), Conversions.ToString(Operators.ConcatenateObject("خرید سند  " + str + " - ", dataRow4["kala_name"])), Sanad.SanadType.خرید_ریزبار_به_صاحب_بار);
								text += "select @id=scope_identity();";
								text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Insert Into dbo.Kharid_Detail(Kharid_ID,Kala_ID,moshtari_id,Tedad,Vazn_Ba_Zarf,Zarf,Vazn_Kol,Fee,Jam_Kol,auto,sanad_id,mablagh_kargari,tarikh,tarikh_fa,vazn_ba_oft,darsad_oft,vazn_oft) VALUES(" + Conversions.ToString(Kharid_ID) + ",", dataRow4["Kala_ID"]), ","), dataRow4["moshtari_id"]), ","), Public_Function.GetValueInt(dataRow4["Tedad"].ToString())), ","), Public_Function.GetValueInt(dataRow4["Vazn_Ba_Zarf"].ToString())), ","), Public_Function.GetValueInt(dataRow4["Zarf"].ToString())), ","), Public_Function.GetValueInt(dataRow4["Vazn_Kol"].ToString())), ","), Public_Function.GetValueInt(dataRow4["Fee"].ToString())), ","), Public_Function.GetValueInt(dataRow4["Jam_Kol"].ToString())), ","), Public_Function.GetValueInt(dataRow4["auto"].ToString())), ",@id,"), Public_Function.GetValueInt(dataRow4["mablagh_kargari"].ToString())), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Conversions.ToString(dataRow4["tarikh_fa"])))), ","), Public_Function.GetValue(Conversions.ToString(dataRow4["tarikh_fa"]))), ","), Public_Function.GetValueInt(dataRow4["vazn_ba_oft"].ToString())), ","), Public_Function.GetValueInt(dataRow4["darsad_oft"].ToString())), ","), Public_Function.GetValueInt(dataRow4["vazn_oft"].ToString())), ");")));
							}
							else
							{
								flag2 = (dataRow4["sanad_id"] == DBNull.Value);
								if (flag2)
								{
									text += this.Isanad.InsertStr(value.ToString(), "0", dataRow4["jam_kol"].ToString(), Conversions.ToString(dataRow4["tarikh_fa"]), Conversions.ToString(Operators.ConcatenateObject("خرید سند  " + str + " - ", dataRow4["kala_name"])), Sanad.SanadType.خرید_ریزبار_به_صاحب_بار);
									text += "select @id=scope_identity();";
									text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("update kharid_detail set sanad_id=@id where id=", dataRow4["id"]), ";")));
								}
								else
								{
									text += this.Isanad.UpdateStr(Conversions.ToString(value), Conversions.ToString(0), Conversions.ToString(dataRow4["jam_kol"]), Conversions.ToString(dataRow4["tarikh_fa"]), Conversions.ToString(Operators.ConcatenateObject("خرید سند  " + str + " - ", dataRow4["kala_name"])), Conversions.ToString(dataRow4["sanad_id"]), Sanad.SanadType.خرید_ریزبار_به_صاحب_بار);
								}
								text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Update dbo.Kharid_Detail SET Kala_ID=", dataRow4["Kala_ID"]), " ,moshtari_id="), Public_Function.GetValueInt(dataRow4["moshtari_id"].ToString())), " ,Tedad="), Public_Function.GetValueInt(dataRow4["Tedad"].ToString())), " ,Vazn_Ba_Zarf="), Public_Function.GetValueInt(dataRow4["Vazn_Ba_Zarf"].ToString())), " ,Zarf="), Public_Function.GetValueInt(dataRow4["Zarf"].ToString())), " ,Vazn_Kol="), Public_Function.GetValueInt(dataRow4["Vazn_Kol"].ToString())), " ,Fee="), Public_Function.GetValueInt(dataRow4["Fee"].ToString())), " ,Jam_Kol="), Public_Function.GetValueInt(dataRow4["Jam_Kol"].ToString())), " , auto="), Public_Function.GetValueInt(dataRow4["auto"].ToString())), " , mablagh_kargari="), Public_Function.GetValueInt(dataRow4["mablagh_kargari"].ToString())), " ,tarikh="), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Conversions.ToString(dataRow4["tarikh_fa"])))), " ,tarikh_fa="), Public_Function.GetValue(Conversions.ToString(dataRow4["tarikh_fa"]))), " ,vazn_ba_oft="), Public_Function.GetValueInt(dataRow4["vazn_ba_oft"].ToString())), " ,darsad_oft="), Public_Function.GetValueInt(dataRow4["darsad_oft"].ToString())), " , vazn_oft="), Public_Function.GetValueInt(dataRow4["vazn_oft"].ToString())), " Where ID="), dataRow4["ID"]), ";")));
							}
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
			flag2 = (text.Length > 0);
			if (flag2)
			{
				Public_Function.ExecuteNonQuery(text);
			}
		}

		// Token: 0x04000123 RID: 291
		private Sanad Isanad;
	}
}
