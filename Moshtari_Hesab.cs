using System;
using System.Collections;
using System.Data;
using System.Diagnostics;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x02000019 RID: 25
	public class Moshtari_Hesab
	{
		// Token: 0x060001DE RID: 478 RVA: 0x000020C1 File Offset: 0x000002C1
		[DebuggerNonUserCode]
		public Moshtari_Hesab()
		{
		}

		// Token: 0x060001DF RID: 479 RVA: 0x00014A04 File Offset: 0x00012C04
		public DataTable GetByID(string Moshtari_ID)
		{
			return Public_Function.FillData("Select dbo.Moshtari_Hesab.ID,dbo.Moshtari_Hesab.Moshtari_ID,Moshtari_Hesab.Saheb_Hesab,dbo.Moshtari_Hesab.Bank_ID,dbo.Moshtari_Hesab.Card_Hesab,dbo.Moshtari_Hesab.Bank_Hesab,Moshtari_Hesab.Shaba_Hesab,Bank.Name AS Bank_Name From dbo.Moshtari_Hesab LEFT OUTER JOIN dbo.Bank ON dbo.Moshtari_Hesab.Bank_ID=dbo.Bank.ID Where Moshtari_ID=" + Moshtari_ID);
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x00014A28 File Offset: 0x00012C28
		public long Insert(string Moshtari_ID, DataTable dt)
		{
			string text = string.Empty;
			try
			{
				IEnumerator enumerator = dt.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Insert Into dbo.Moshtari_Hesab(Moshtari_ID,Bank_ID,Card_Hesab,Bank_Hesab,Saheb_Hesab) VALUES(" + Moshtari_ID + ",", dataRow["Bank_ID"]), ","), Public_Function.GetValue(Conversions.ToString(dataRow["Card_Hesab"]))), ","), Public_Function.GetValue(Conversions.ToString(dataRow["Bank_Hesab"]))), ","), Public_Function.GetValue(Conversions.ToString(dataRow["Saheb_Hesab"]))), ");")));
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
			return Conversions.ToLong(Public_Function.ExecuteScalar(text));
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x00014B54 File Offset: 0x00012D54
		public void Update(string ID, DataTable dt)
		{
			string iD = Public_Function.GetID(dt, "ID", "");
			string text = string.Empty;
			bool flag = iD.Length > 0;
			if (flag)
			{
				text = string.Concat(new string[]
				{
					text,
					"Delete From dbo.Moshtari_Hesab Where Moshtari_ID=",
					ID,
					" AND ID NOT IN(",
					iD,
					");"
				});
			}
			else
			{
				text = text + "Delete From dbo.Moshtari_Hesab Where Moshtari_ID=" + ID + ";";
			}
			try
			{
				IEnumerator enumerator = dt.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					flag = (dataRow["ID"] == DBNull.Value);
					if (flag)
					{
						text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Insert Into dbo.Moshtari_Hesab(Moshtari_ID,Bank_ID,Card_Hesab,Bank_Hesab,Shaba_Hesab,Saheb_Hesab) VALUES(" + ID + ",", dataRow["Bank_ID"]), ","), Public_Function.GetValue(dataRow["Card_Hesab"].ToString())), ","), Public_Function.GetValue(dataRow["Bank_Hesab"].ToString())), ","), Public_Function.GetValue(dataRow["Shaba_Hesab"].ToString())), ","), Public_Function.GetValue(dataRow["Saheb_Hesab"].ToString())), ");")));
					}
					else
					{
						text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Update dbo.Moshtari_Hesab SET Bank_ID=", dataRow["Bank_ID"]), " ,Card_Hesab="), Public_Function.GetValue(dataRow["Card_Hesab"].ToString())), " ,Bank_Hesab="), Public_Function.GetValue(dataRow["Bank_Hesab"].ToString())), " ,Shaba_Hesab="), Public_Function.GetValue(dataRow["Shaba_Hesab"].ToString())), " ,Saheb_Hesab="), Public_Function.GetValue(dataRow["Saheb_Hesab"].ToString())), " Where ID="), dataRow["ID"]), ";")));
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
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x00002299 File Offset: 0x00000499
		public void Delete(string ID)
		{
			Public_Function.ExecuteNonQuery("Delete From dbo.Moshtari Where Id= " + ID);
		}
	}
}
