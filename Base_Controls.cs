using System;
using System.Data;
using System.Diagnostics;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x02000050 RID: 80
	public class Base_Controls
	{
		// Token: 0x06000394 RID: 916 RVA: 0x000020C1 File Offset: 0x000002C1
		[DebuggerNonUserCode]
		public Base_Controls()
		{
		}

		// Token: 0x06000395 RID: 917 RVA: 0x0004D334 File Offset: 0x0004B534
		public DataTable GetAll()
		{
			return Public_Function.FillData("Select * from Controls");
		}

		// Token: 0x06000396 RID: 918 RVA: 0x0004D350 File Offset: 0x0004B550
		public int Insert(string name, string parent_ID, string id = "")
		{
			string text = string.Empty;
			bool flag = Operators.CompareString(id, "", false) != 0;
			if (flag)
			{
				text = " set identity_insert controls on;";
				text = string.Concat(new string[]
				{
					text,
					"INSERT INTO controls (id,Name,Parent_ID) VALUES(",
					id,
					",N'",
					name,
					"',",
					Public_Function.GetValueInt(parent_ID),
					") ;"
				});
				text += " set identity_insert controls off;";
			}
			else
			{
				text = string.Concat(new string[]
				{
					text,
					"INSERT INTO controls (Name,Parent_ID) VALUES(N'",
					name,
					"',",
					Public_Function.GetValueInt(parent_ID),
					") ;"
				});
				text += "SELECT Scope_Identity();";
			}
			return Conversions.ToInteger(Public_Function.ExecuteScalar(text));
		}

		// Token: 0x06000397 RID: 919 RVA: 0x0004D434 File Offset: 0x0004B634
		public DataRow GetID(string Name, string Parent_ID)
		{
			string text = " AND Parent_ID ";
			bool flag = Operators.CompareString(Parent_ID, string.Empty, false) == 0;
			if (flag)
			{
				text += " is null";
			}
			else
			{
				flag = (Operators.CompareString(Parent_ID, "is not null", false) == 0);
				if (flag)
				{
					text += Parent_ID;
				}
				else
				{
					text = text + "=" + Parent_ID;
				}
			}
			return Public_Function.FillDataRow("select * from Controls where Name=N'" + Name + "'" + text);
		}
	}
}
