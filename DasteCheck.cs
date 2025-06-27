using System;
using System.Data;
using System.Diagnostics;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x0200000E RID: 14
	public class DasteCheck
	{
		// Token: 0x060001AA RID: 426 RVA: 0x000020C1 File Offset: 0x000002C1
		[DebuggerNonUserCode]
		public DasteCheck()
		{
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00013B5C File Offset: 0x00011D5C
		public DataTable GetAll()
		{
			return Public_Function.FillData("SELECT  DasteCheck.id,DasteCheck.BankHesab_ID, Bank.Name+' - '+ Bank_Hesab.Shobe AS Name, DasteCheck.Az_Shomare, DasteCheck.Tedad, DasteCheck.Ta_Shomare  FROM         DasteCheck INNER JOIN  Bank_Hesab ON DasteCheck.BankHesab_ID = Bank_Hesab.ID INNER JOIN  Bank ON Bank_Hesab.Bank_ID = Bank.ID");
		}

		// Token: 0x060001AC RID: 428 RVA: 0x00013B78 File Offset: 0x00011D78
		public void Insert(string BankHesab_ID, string Az_Shomare, string Tedad, string Ta_Shomare)
		{
			string text = string.Concat(new string[]
			{
				"declare @id int;INSERT INTO [DasteCheck]  ([BankHesab_ID],[Az_Shomare],[Tedad],[Ta_Shomare])  VALUES(",
				BankHesab_ID,
				",",
				Az_Shomare,
				",",
				Tedad,
				",",
				Ta_Shomare,
				");Select @id=Scope_Identity();"
			});
			int arg_60_0 = Conversions.ToInteger(Az_Shomare);
			int num = Conversions.ToInteger(Ta_Shomare);
			int num2 = arg_60_0;
			checked
			{
				while (true)
				{
					int arg_85_0 = num2;
					int num3 = num;
					if (arg_85_0 > num3)
					{
						break;
					}
					text = text + "insert into dastecheckbarg (Dastecheck_id,ShomareBarg) values(@id," + Conversions.ToString(num2) + ")";
					num2++;
				}
				Public_Function.ExecuteNonQuery(text);
			}
		}

		// Token: 0x060001AD RID: 429 RVA: 0x00013C14 File Offset: 0x00011E14
		public void Update(string BankHesab_ID, string Az_Shomare, string Tedad, string Ta_Shomare, string ID)
		{
			string text = string.Empty;
			text = string.Concat(new string[]
			{
				"UPDATE [DasteCheck]  SET [BankHesab_ID] =  ",
				BankHesab_ID,
				"  ,[Az_Shomare] = ",
				Az_Shomare,
				"  ,[Tedad] = ",
				Tedad,
				"  ,[Ta_Shomare] = ",
				Ta_Shomare,
				"  WHERE ID=",
				ID,
				";"
			});
			int arg_77_0 = Conversions.ToInteger(Az_Shomare);
			int num = Conversions.ToInteger(Ta_Shomare);
			int num2 = arg_77_0;
			checked
			{
				while (true)
				{
					int arg_E7_0 = num2;
					int num3 = num;
					if (arg_E7_0 > num3)
					{
						break;
					}
					text = string.Concat(new string[]
					{
						text,
						"if not exists(select id from dastecheckbarg where Dastecheck_id=",
						ID,
						" and ShomareBarg=",
						Conversions.ToString(num2),
						") insert into dastecheckbarg (Dastecheck_id,ShomareBarg) values(",
						ID,
						",",
						Conversions.ToString(num2),
						");"
					});
					num2++;
				}
				Public_Function.ExecuteNonQuery(text);
			}
		}

		// Token: 0x060001AE RID: 430 RVA: 0x000021AA File Offset: 0x000003AA
		public void Delete(string ID)
		{
			Public_Function.ExecuteNonQuery("delete from [DasteCheckBarg] where Dastecheck_id =" + ID + "; Delete From dbo.DasteCheck Where Id= " + ID);
		}
	}
}
