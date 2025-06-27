using System;
using System.Collections;
using System.Data;
using System.Diagnostics;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x02000017 RID: 23
	public class Kala_To_Kala_Furush
	{
		// Token: 0x060001D4 RID: 468 RVA: 0x000020C1 File Offset: 0x000002C1
		[DebuggerNonUserCode]
		public Kala_To_Kala_Furush()
		{
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x000144B4 File Offset: 0x000126B4
		public void Insert(long Furush_ID, long Parent_Kala_ID, long Child_Kala_ID)
		{
			Public_Function.ExecuteNonQuery(string.Concat(new string[]
			{
				"insert into kala_to_kala_Furush (Furush_ID,Parent_kala_ID,Child_Kala_ID) values(",
				Conversions.ToString(Furush_ID),
				",",
				Conversions.ToString(Parent_Kala_ID),
				",",
				Conversions.ToString(Child_Kala_ID),
				")"
			}));
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x00014518 File Offset: 0x00012718
		public void Update(long Furush_ID, DataTable dt)
		{
			string iD = Public_Function.GetID(dt, "ID", "");
			string text = string.Empty;
			bool flag = iD.Length > 0;
			if (flag)
			{
				text = string.Concat(new string[]
				{
					text,
					"Delete From dbo.kala_to_kala_Furush Where Furush_ID=",
					Conversions.ToString(Furush_ID),
					" AND ID NOT IN(",
					iD,
					");"
				});
			}
			else
			{
				text = text + "Delete From dbo.kala_to_kala_Furush Where Furush_ID=" + Conversions.ToString(Furush_ID) + ";";
			}
			flag = (dt != null);
			if (flag)
			{
				try
				{
					IEnumerator enumerator = dt.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						bool flag2 = dataRow["ID"] == DBNull.Value;
						if (flag2)
						{
							text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("insert into kala_to_kala_Furush (Furush_ID,Parent_kala_ID,Child_Kala_ID) values(" + Conversions.ToString(Furush_ID) + ",", dataRow["Parent_Kala_ID"]), ","), dataRow["Child_Kala_ID"]), ")")));
						}
						else
						{
							text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Update dbo.kala_to_kala_Furush SET Parent_kala_ID=", dataRow["Parent_Kala_ID"]), " ,Child_Kala_ID="), dataRow["Child_Kala_ID"].ToString()), " Where ID="), dataRow["ID"]), ";")));
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
			}
			Public_Function.ExecuteNonQuery(text);
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x0001470C File Offset: 0x0001290C
		public DataTable GetByFurush_ID(long ID)
		{
			return Public_Function.FillData("select * from kala_to_kala_Furush where Furush_ID=" + Conversions.ToString(ID));
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x00014734 File Offset: 0x00012934
		public DataTable GetParent_Kala_ID(long Child_Kala_ID)
		{
			return Public_Function.FillData("select Parent_Kala_ID from kala_to_kala_Furush where child_kala_id=" + Conversions.ToString(Child_Kala_ID));
		}
	}
}
