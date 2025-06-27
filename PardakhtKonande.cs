using System;
using System.Diagnostics;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x0200001C RID: 28
	public class PardakhtKonande
	{
		// Token: 0x060001EE RID: 494 RVA: 0x000020C1 File Offset: 0x000002C1
		[DebuggerNonUserCode]
		public PardakhtKonande()
		{
		}

		// Token: 0x060001EF RID: 495 RVA: 0x00015098 File Offset: 0x00013298
		public void Update(string Name, string namePedar, string CodeMelli, string Shsh, string CodePosti, string Tel, string TarikhTavalod, string address)
		{
			int num = Conversions.ToInteger(Public_Function.ExecuteScalar("select count(name) from pardakhtkonande "));
			bool flag = num == 0;
			if (flag)
			{
				Public_Function.ExecuteNonQuery(string.Concat(new string[]
				{
					"INSERT INTO [PardakhtKonande]  ([Name],[namePedar],[CodeMelli],[Shsh],[CodePosti],[Tel],[TarikhTavalod],address)  VALUES( ",
					Public_Function.GetValue(Name),
					",",
					Public_Function.GetValue(namePedar),
					",",
					Public_Function.GetValue(CodeMelli),
					",",
					Public_Function.GetValue(Shsh),
					",",
					Public_Function.GetValue(CodePosti),
					",",
					Public_Function.GetValue(Tel),
					",",
					Public_Function.GetValue(TarikhTavalod),
					",",
					Public_Function.GetValue(address),
					") "
				}));
			}
			else
			{
				Public_Function.ExecuteNonQuery(string.Concat(new string[]
				{
					"UPDATE [PardakhtKonande]  SET [Name] = ",
					Public_Function.GetValue(Name),
					" ,[namePedar] = ",
					Public_Function.GetValue(namePedar),
					",[CodeMelli] = ",
					Public_Function.GetValue(CodeMelli),
					",[Shsh] = ",
					Public_Function.GetValue(Shsh),
					",[CodePosti] = ",
					Public_Function.GetValue(CodePosti),
					",[Tel] =  ",
					Public_Function.GetValue(Tel),
					",[TarikhTavalod] = ",
					Public_Function.GetValue(TarikhTavalod),
					",address=",
					Public_Function.GetValue(address)
				}));
			}
		}
	}
}
