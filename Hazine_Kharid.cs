using System;
using System.Data;
using System.Diagnostics;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x02000014 RID: 20
	public class Hazine_Kharid
	{
		// Token: 0x060001C5 RID: 453 RVA: 0x000020C1 File Offset: 0x000002C1
		[DebuggerNonUserCode]
		public Hazine_Kharid()
		{
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x0001416C File Offset: 0x0001236C
		public DataTable GetAll()
		{
			return Public_Function.FillData("Select * From dbo.Hazine_Kharid  where id>-6 order by code ");
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x00014188 File Offset: 0x00012388
		public long Insert(string Name)
		{
			return Conversions.ToLong(Public_Function.ExecuteScalar("Insert Into dbo.Hazine_kharid(Name) VALUES(" + Public_Function.GetValue(Name) + " );Select Scope_Identity();"));
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x0000222F File Offset: 0x0000042F
		public void Update(string Name, string ID)
		{
			Public_Function.ExecuteNonQuery("Update dbo.Hazine SET Name=" + Public_Function.GetValue(Name) + " Where ID=" + ID);
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x0000224F File Offset: 0x0000044F
		public void Delete(string ID)
		{
			Public_Function.ExecuteNonQuery("Delete From dbo.Hazine Where Id= " + ID);
		}
	}
}
