using System;
using System.Data;
using System.Diagnostics;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x0200000D RID: 13
	public class Daramad
	{
		// Token: 0x060001A5 RID: 421 RVA: 0x000020C1 File Offset: 0x000002C1
		[DebuggerNonUserCode]
		public Daramad()
		{
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00013AEC File Offset: 0x00011CEC
		public DataTable GetAll()
		{
			return Public_Function.FillData("Select dbo.Daramad.ID,dbo.Daramad.Name,dbo.Daramad.CodeHesab_ID From dbo.Daramad");
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00013B08 File Offset: 0x00011D08
		public long Insert(string Name, string CodeHesab_ID)
		{
			return Conversions.ToLong(Public_Function.ExecuteScalar(string.Concat(new string[]
			{
				"Insert Into dbo.Daramad(Name,CodeHesab_ID) VALUES(",
				Public_Function.GetValue(Name),
				",",
				CodeHesab_ID,
				" );Select Scope_Identity();"
			})));
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00002175 File Offset: 0x00000375
		public void Update(string Name, string ID)
		{
			Public_Function.ExecuteNonQuery("Update dbo.Daramad SET Name=" + Public_Function.GetValue(Name) + " Where ID=" + ID);
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00002195 File Offset: 0x00000395
		public void Delete(string ID)
		{
			Public_Function.ExecuteNonQuery("Delete From dbo.Daramad Where Id= " + ID);
		}
	}
}
