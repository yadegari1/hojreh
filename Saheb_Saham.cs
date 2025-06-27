using System;
using System.Data;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x0200001D RID: 29
	public class Saheb_Saham
	{
		// Token: 0x060001F0 RID: 496 RVA: 0x000022F8 File Offset: 0x000004F8
		public Saheb_Saham()
		{
			this.codeHesab = new Code_Hesab();
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x00015244 File Offset: 0x00013444
		public DataTable GetAll()
		{
			return Public_Function.FillData("SELECT     Moshtari.Name+' '+ Moshtari.Family as name, Sharik.Darsad, Sharik.Moshtari_ID  FROM         Moshtari INNER JOIN  Sharik ON Moshtari.ID = Sharik.Moshtari_ID");
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x00015260 File Offset: 0x00013460
		public long Insert(string Moshtari_id, string darsad)
		{
			string command = string.Concat(new string[]
			{
				"insert into sharik(moshtari_id,darsad) values(",
				Moshtari_id,
				",",
				darsad,
				")"
			});
			return Conversions.ToLong(Public_Function.ExecuteScalar(command));
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x000152B0 File Offset: 0x000134B0
		public void Update(string moshtari_id, string darsad, string id)
		{
			string command = string.Concat(new string[]
			{
				"update sharik set moshtari_id= ",
				moshtari_id,
				" ,darsad=",
				darsad,
				" where moshtari_id=",
				id
			});
			Public_Function.ExecuteNonQuery(command);
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x0000230D File Offset: 0x0000050D
		public void Delete(string ID)
		{
			Public_Function.ExecuteNonQuery("Delete From dbo.sharik Where moshtari_Id= " + ID);
		}

		// Token: 0x040000C7 RID: 199
		private Code_Hesab codeHesab;
	}
}
