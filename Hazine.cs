using System;
using System.Data;
using System.Diagnostics;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x02000013 RID: 19
	public class Hazine
	{
		// Token: 0x060001C0 RID: 448 RVA: 0x000020C1 File Offset: 0x000002C1
		[DebuggerNonUserCode]
		public Hazine()
		{
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x000140FC File Offset: 0x000122FC
		public DataTable GetAll()
		{
			return Public_Function.FillData("Select dbo.Hazine.ID,dbo.Hazine.Name,dbo.Hazine.CodeHesab_ID From dbo.Hazine");
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x00014118 File Offset: 0x00012318
		public long Insert(string Name, string CodeHesab_ID)
		{
			return Conversions.ToLong(Public_Function.ExecuteScalar(string.Concat(new string[]
			{
				"Insert Into dbo.Hazine(Name,CodeHesab_ID) VALUES(",
				Public_Function.GetValue(Name),
				",",
				CodeHesab_ID,
				" );Select Scope_Identity();"
			})));
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x0000222F File Offset: 0x0000042F
		public void Update(string Name, string ID)
		{
			Public_Function.ExecuteNonQuery("Update dbo.Hazine SET Name=" + Public_Function.GetValue(Name) + " Where ID=" + ID);
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x0000224F File Offset: 0x0000044F
		public void Delete(string ID)
		{
			Public_Function.ExecuteNonQuery("Delete From dbo.Hazine Where Id= " + ID);
		}
	}
}
