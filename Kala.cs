using System;
using System.Data;
using System.Diagnostics;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x02000015 RID: 21
	public class Kala
	{
		// Token: 0x060001CA RID: 458 RVA: 0x000020C1 File Offset: 0x000002C1
		[DebuggerNonUserCode]
		public Kala()
		{
		}

		// Token: 0x060001CB RID: 459 RVA: 0x000141BC File Offset: 0x000123BC
		public DataTable GetAll()
		{
			return Public_Function.FillData("Select dbo.Kala.ID,dbo.Kala.Name From dbo.Kala");
		}

		// Token: 0x060001CC RID: 460 RVA: 0x000141D8 File Offset: 0x000123D8
		public long Insert(string Name)
		{
			return Conversions.ToLong(Public_Function.ExecuteScalar("Insert Into dbo.Kala(Name) VALUES(" + Public_Function.GetValue(Name) + " );Select Scope_Identity();"));
		}

		// Token: 0x060001CD RID: 461 RVA: 0x00002264 File Offset: 0x00000464
		public void Update(string Name, string ID)
		{
			Public_Function.ExecuteNonQuery("Update dbo.Kala SET  Name=" + Public_Function.GetValue(Name) + " Where ID=" + ID);
		}

		// Token: 0x060001CE RID: 462 RVA: 0x00002284 File Offset: 0x00000484
		public void Delete(string ID)
		{
			Public_Function.ExecuteNonQuery("Delete From dbo.Kala Where Id= " + ID);
		}
	}
}
