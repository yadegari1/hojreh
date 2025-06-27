using System;
using System.Data;
using System.Diagnostics;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x02000012 RID: 18
	public class Grouh_Moshtari2
	{
		// Token: 0x060001BB RID: 443 RVA: 0x000020C1 File Offset: 0x000002C1
		[DebuggerNonUserCode]
		public Grouh_Moshtari2()
		{
		}

		// Token: 0x060001BC RID: 444 RVA: 0x000140AC File Offset: 0x000122AC
		public DataTable GetAll()
		{
			return Public_Function.FillData("Select dbo.Grouh_Moshtari2.ID,dbo.Grouh_Moshtari2.Name From dbo.Grouh_Moshtari2");
		}

		// Token: 0x060001BD RID: 445 RVA: 0x000140C8 File Offset: 0x000122C8
		public long Insert(string Name)
		{
			return Conversions.ToLong(Public_Function.ExecuteScalar("Insert Into dbo.Grouh_Moshtari2(Name) VALUES(" + Public_Function.GetValue(Name) + " );Select Scope_Identity();"));
		}

		// Token: 0x060001BE RID: 446 RVA: 0x000021FA File Offset: 0x000003FA
		public void Update(string Name, string ID)
		{
			Public_Function.ExecuteNonQuery("Update dbo.Grouh_Moshtari2 SET Name=" + Public_Function.GetValue(Name) + " Where ID=" + ID);
		}

		// Token: 0x060001BF RID: 447 RVA: 0x0000221A File Offset: 0x0000041A
		public void Delete(string ID)
		{
			Public_Function.ExecuteNonQuery("Delete From dbo.Grouh_Moshtari2 Where Id= " + ID);
		}
	}
}
