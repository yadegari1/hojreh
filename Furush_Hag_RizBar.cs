using System;
using System.Collections;
using System.Data;
using System.Diagnostics;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x0200002C RID: 44
	public class Furush_Hag_RizBar
	{
		// Token: 0x060002B4 RID: 692 RVA: 0x000020C1 File Offset: 0x000002C1
		[DebuggerNonUserCode]
		public Furush_Hag_RizBar()
		{
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x00037F04 File Offset: 0x00036104
		public DataTable GetByID(int Furush_Hag_ID)
		{
			return Public_Function.FillData("SELECT     Furush_Hag_RizBar.*, Kala.Name AS Kala_Name   FROM         Furush_Hag_RizBar INNER JOIN   Kala ON Furush_Hag_RizBar.Kala_ID = Kala.ID   where furush_hag_id=" + Conversions.ToString(Furush_Hag_ID));
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x00037F2C File Offset: 0x0003612C
		public void Insert(int furush_Hag_ID, DataTable dt)
		{
			string text = string.Empty;
			bool flag;
			try
			{
				IEnumerator enumerator = dt.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("INSERT INTO [Furush_Hag_RizBar] ([Furush_Hag_ID],[Kala_ID],[Tedad]) VALUES(" + furush_Hag_ID.ToString() + ",", dataRow["Kala_ID"]), ","), dataRow["Tedad"]), ")")));
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

		// Token: 0x060002B7 RID: 695 RVA: 0x00038008 File Offset: 0x00036208
		public void Update(int Furush_Hag_ID, DataTable dt)
		{
			string iD = Public_Function.GetID(dt, "ID", "");
			string text = string.Empty;
			bool flag = iD.Length > 0;
			if (flag)
			{
				text = string.Concat(new string[]
				{
					text,
					"Delete From dbo.Furush_Hag_RizBar Where Furush_Hag_ID=",
					Conversions.ToString(Furush_Hag_ID),
					" AND ID NOT IN(",
					iD,
					");"
				});
			}
			else
			{
				text = text + "Delete From dbo.Furush_Hag_RizBar Where Furush_Hag_ID=" + Conversions.ToString(Furush_Hag_ID) + ";";
			}
			flag = (dt != null);
			bool flag2;
			if (flag)
			{
				try
				{
					IEnumerator enumerator = dt.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						flag2 = (dataRow["ID"] == DBNull.Value);
						if (flag2)
						{
							text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Insert Into dbo.Furush_Hag_RizBar(Furush_Hag_ID,Kala_ID,Tedad,Vazn,auto,mablagh_kargari) VALUES(" + Conversions.ToString(Furush_Hag_ID) + ",", dataRow["Kala_ID"]), ","), Public_Function.GetValueInt(dataRow["Tedad"].ToString())), ","), Public_Function.GetValueInt(dataRow["Vazn"].ToString())), ","), Public_Function.GetValueInt(dataRow["auto"].ToString())), ","), Public_Function.GetValueInt(dataRow["mablagh_kargari"].ToString())), ");")));
						}
						else
						{
							text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Update dbo.Furush_Hag_RizBar SET Kala_ID=", dataRow["Kala_ID"]), " ,Tedad="), Public_Function.GetValueInt(dataRow["Tedad"].ToString())), " ,Vazn="), Public_Function.GetValueInt(dataRow["Vazn"].ToString())), " ,auto="), Public_Function.GetValueInt(dataRow["auto"].ToString())), " ,mablagh_kargari="), Public_Function.GetValueInt(dataRow["mablagh_kargari"].ToString())), " Where ID="), dataRow["ID"]), ";")));
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
			flag2 = (text.Length > 0);
			if (flag2)
			{
				Public_Function.ExecuteNonQuery(text);
			}
		}
	}
}
