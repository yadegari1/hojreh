using System;
using System.Collections;
using System.Data;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x02000038 RID: 56
	public class Kharid_Sardkhane_detail
	{
		// Token: 0x060002FB RID: 763 RVA: 0x0000269D File Offset: 0x0000089D
		public Kharid_Sardkhane_detail()
		{
			this.Isanad = new Sanad();
		}

		// Token: 0x060002FC RID: 764 RVA: 0x00002628 File Offset: 0x00000828
		public void DeleteByID(string ID)
		{
			Public_Function.ExecuteNonQuery("delete from Kharid_Detail where ID=" + ID);
		}

		// Token: 0x060002FD RID: 765 RVA: 0x0003FFF0 File Offset: 0x0003E1F0
		public DataTable GetByID(int Kharid_Sardkhane_ID)
		{
			return Public_Function.FillData("SELECT     Kharid_Sardkhane_Detail.ID, Kharid_Sardkhane_Detail.Kharid_Sardkhane_ID, Kharid_Sardkhane_Detail.Moshtari_id, Kharid_Sardkhane_Detail.Tarikh,  Kharid_Sardkhane_Detail.Tarikh_Fa, Kharid_Sardkhane_Detail.sh_mashin, Kharid_Sardkhane_Detail.sh_barname, Kharid_Sardkhane_Detail.Kala_ID,  Kharid_Sardkhane_Detail.Tedad, Kharid_Sardkhane_Detail.Vazn_Ba_Zarf, Kharid_Sardkhane_Detail.Zarf, Kharid_Sardkhane_Detail.Vazn_Kol,  Kharid_Sardkhane_Detail.Fee, Kharid_Sardkhane_Detail.Jam_Kol, Kharid_Sardkhane_Detail.auto, Kharid_Sardkhane_Detail.sanad_id,Kharid_Sardkhane_Detail.sh_factor, Moshtari.Name+' '+  Moshtari.Family as Moshtari_Name, Kala.Name AS Kala_Name,Moshtari.Codehesab_ID   FROM         Kharid_Sardkhane_Detail INNER JOIN  Moshtari ON Kharid_Sardkhane_Detail.Moshtari_id = Moshtari.ID INNER JOIN  Kala ON Kharid_Sardkhane_Detail.Kala_ID = Kala.ID where Kharid_Sardkhane_ID=" + Conversions.ToString(Kharid_Sardkhane_ID));
		}

		// Token: 0x060002FE RID: 766 RVA: 0x0003D444 File Offset: 0x0003B644
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

		// Token: 0x060002FF RID: 767 RVA: 0x00040018 File Offset: 0x0003E218
		public void Update(int Kharid_ID, DataTable dt)
		{
			string iD = Public_Function.GetID(dt, "ID", "");
			string text = "declare @id bigint;";
			bool flag = iD.Length > 0;
			if (flag)
			{
				text = string.Concat(new string[]
				{
					text,
					"delete from sanad where id in(select sanad_id from kharid_sardkhane_detail where kharid_sardkhane_id=",
					Conversions.ToString(Kharid_ID),
					" and id not in(",
					iD,
					")) "
				});
				text = string.Concat(new string[]
				{
					text,
					"Delete From dbo.Kharid_Sardkhane_Detail Where Kharid_Sardkhane_ID=",
					Conversions.ToString(Kharid_ID),
					" AND ID NOT IN(",
					iD,
					");"
				});
			}
			else
			{
				text = text + "delete from sanad where id in(select sanad_id from kharid_Sardkhane_detail where kharid_Sardkhane_id=" + Conversions.ToString(Kharid_ID) + ");";
				text = text + "Delete From dbo.Kharid_Sardkhane_Detail Where Kharid_Sardkhane_ID=" + Conversions.ToString(Kharid_ID) + ";";
			}
			flag = (dt != null);
			bool flag2;
			if (flag)
			{
				flag2 = (dt.Rows.Count > 0);
				if (flag2)
				{
					DataRow dataRow = Public_Function.FillDataRow("select * from kharid_Sardkhane where id= " + Conversions.ToString(Kharid_ID));
					string str = Conversions.ToString(dataRow["num"]);
					try
					{
						IEnumerator enumerator = dt.Rows.GetEnumerator();
						while (enumerator.MoveNext())
						{
							DataRow dataRow2 = (DataRow)enumerator.Current;
							flag2 = (dataRow2["ID"] == DBNull.Value);
							if (flag2)
							{
								text += this.Isanad.InsertStr(dataRow2["codehesab_id"].ToString(), "0", dataRow2["jam_kol"].ToString(), Conversions.ToString(dataRow2["Tarikh_Fa"]), "خرید سند  " + str, Sanad.SanadType.خرید_به_سردخانه_ریزبار_صاحب_بار);
								text += "select @id=scope_identity();";
								text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Insert Into dbo.Kharid_Sardkhane_Detail(Kharid_Sardkhane_ID,moshtari_id,Tarikh,Tarikh_Fa,Sh_Mashin,Sh_Barname,Kala_ID,Tedad,Vazn_Ba_Zarf,Zarf,Vazn_Kol,Fee,Jam_Kol,auto,sanad_id,sh_factor) VALUES(" + Conversions.ToString(Kharid_ID) + ",", dataRow2["moshtari_id"]), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Conversions.ToString(dataRow2["Tarikh_Fa"])))), ","), Public_Function.GetValue(Conversions.ToString(dataRow2["Tarikh_Fa"]))), ","), Public_Function.GetValue(dataRow2["sh_mashin"].ToString())), ","), Public_Function.GetValue(dataRow2["sh_barname"].ToString())), ","), dataRow2["Kala_ID"]), ","), Public_Function.GetValueInt(dataRow2["Tedad"].ToString())), ","), Public_Function.GetValueInt(dataRow2["Vazn_Ba_Zarf"].ToString())), ","), Public_Function.GetValueInt(dataRow2["Zarf"].ToString())), ","), Public_Function.GetValueInt(dataRow2["Vazn_Kol"].ToString())), ","), Public_Function.GetValueInt(dataRow2["Fee"].ToString())), ","), Public_Function.GetValueInt(dataRow2["Jam_Kol"].ToString())), ","), Public_Function.GetValueInt(dataRow2["auto"].ToString())), ",@id,"), Public_Function.GetValue(dataRow2["sh_factor"].ToString())), ");")));
							}
							else
							{
								text += this.Isanad.UpdateStr(Conversions.ToString(dataRow2["codehesab_id"]), Conversions.ToString(0), Conversions.ToString(dataRow2["jam_kol"]), Conversions.ToString(dataRow2["Tarikh_Fa"]), "خرید سند  " + str, Conversions.ToString(dataRow2["sanad_id"]), Sanad.SanadType.خرید_به_سردخانه_ریزبار_صاحب_بار);
								text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Update dbo.Kharid_Sardkhane_Detail SET Kala_ID=", dataRow2["Kala_ID"]), " ,moshtari_id="), dataRow2["moshtari_id"]), " ,Tarikh="), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Conversions.ToString(dataRow2["Tarikh_fa"])))), " ,Tarikh_Fa="), Public_Function.GetValue(Conversions.ToString(dataRow2["Tarikh_Fa"]))), " ,Sh_Mashin="), Public_Function.GetValue(dataRow2["sh_mashin"].ToString())), " ,Sh_barname="), Public_Function.GetValue(dataRow2["sh_barname"].ToString())), " ,Tedad="), Public_Function.GetValueInt(dataRow2["Tedad"].ToString())), " ,Vazn_Ba_Zarf="), Public_Function.GetValueInt(dataRow2["Vazn_Ba_Zarf"].ToString())), " ,Zarf="), Public_Function.GetValueInt(dataRow2["Zarf"].ToString())), " ,Vazn_Kol="), Public_Function.GetValueInt(dataRow2["Vazn_Kol"].ToString())), " ,Fee="), Public_Function.GetValueInt(dataRow2["Fee"].ToString())), " ,Jam_Kol="), Public_Function.GetValueInt(dataRow2["Jam_Kol"].ToString())), " , auto="), Public_Function.GetValueInt(dataRow2["auto"].ToString())), " ,sh_factor="), Public_Function.GetValue(dataRow2["sh_factor"].ToString())), " Where ID="), dataRow2["ID"]), ";")));
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
				}
			}
			flag2 = (text.Length > 0);
			if (flag2)
			{
				Public_Function.ExecuteNonQuery(text);
			}
		}

		// Token: 0x0400012F RID: 303
		private Sanad Isanad;
	}
}
