using System;
using System.Collections;
using System.Data;
using System.Diagnostics;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x02000016 RID: 22
	public class Kala_To_Kala_Kharid
	{
		// Token: 0x060001CF RID: 463 RVA: 0x000020C1 File Offset: 0x000002C1
		[DebuggerNonUserCode]
		public Kala_To_Kala_Kharid()
		{
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x0001420C File Offset: 0x0001240C
		public void Insert(long Kharid_ID, long Parent_Kala_ID, long Child_Kala_ID)
		{
			Public_Function.ExecuteNonQuery(string.Concat(new string[]
			{
				"insert into kala_to_kala_kharid (Kharid_ID,Parent_kala_ID,Child_Kala_ID) values(",
				Conversions.ToString(Kharid_ID),
				",",
				Conversions.ToString(Parent_Kala_ID),
				",",
				Conversions.ToString(Child_Kala_ID),
				")"
			}));
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x00014270 File Offset: 0x00012470
		public void Update(long Kharid_ID, DataTable dt)
		{
			string iD = Public_Function.GetID(dt, "ID", "");
			string text = string.Empty;
			bool flag = iD.Length > 0;
			if (flag)
			{
				text = string.Concat(new string[]
				{
					text,
					"Delete From dbo.kala_to_kala_kharid Where Kharid_ID=",
					Conversions.ToString(Kharid_ID),
					" AND ID NOT IN(",
					iD,
					");"
				});
			}
			else
			{
				text = text + "Delete From dbo.kala_to_kala_kharid Where Kharid_ID=" + Conversions.ToString(Kharid_ID) + ";";
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
							text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("insert into kala_to_kala_kharid (Kharid_ID,Parent_kala_ID,Child_Kala_ID) values(" + Conversions.ToString(Kharid_ID) + ",", dataRow["Parent_Kala_ID"]), ","), dataRow["Child_Kala_ID"]), ")")));
						}
						else
						{
							text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Update dbo.kala_to_kala_kharid SET Parent_kala_ID=", dataRow["Parent_Kala_ID"]), " ,Child_Kala_ID="), dataRow["Child_Kala_ID"].ToString()), " Where ID="), dataRow["ID"]), ";")));
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

		// Token: 0x060001D2 RID: 466 RVA: 0x00014464 File Offset: 0x00012664
		public DataTable GetByKharid_ID(long ID)
		{
			return Public_Function.FillData("select * from kala_to_kala_kharid where kharid_id=" + Conversions.ToString(ID));
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x0001448C File Offset: 0x0001268C
		public DataTable GetParent_Kala_ID(long Child_Kala_ID)
		{
			return Public_Function.FillData("select Parent_Kala_ID from kala_to_kala where child_kala_id=" + Conversions.ToString(Child_Kala_ID));
		}
	}
}
