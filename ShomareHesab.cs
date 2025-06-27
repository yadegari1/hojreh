using System;
using System.Diagnostics;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x0200001F RID: 31
	public class ShomareHesab
	{
		// Token: 0x060001FA RID: 506 RVA: 0x000020C1 File Offset: 0x000002C1
		[DebuggerNonUserCode]
		public ShomareHesab()
		{
		}

		// Token: 0x060001FB RID: 507 RVA: 0x00015350 File Offset: 0x00013550
		public void Update(string ShomareHesab, string BankID, string ShobeID, string ShobeName, string sahebcheck)
		{
			string text = "declare @shobeid int ;declare @id int;select @id=id from shomarehesab where shomarehesab='" + ShomareHesab + "';";
			text = text + "if @id is null BEGIN " + Environment.NewLine;
			bool flag = Operators.CompareString(ShobeID, string.Empty, false) != 0;
			if (flag)
			{
				text = text + "set @shobeid=" + ShobeID + Environment.NewLine;
			}
			else
			{
				flag = (Operators.CompareString(ShobeName, string.Empty, false) != 0);
				if (flag)
				{
					text = text + " select @shobeid=id from shobe where name=" + Public_Function.GetValue(ShobeName) + ";";
					text += " if @@rowcount=0 begin";
					text = text + " insert into shobe(name) values(" + Public_Function.GetValue(ShobeName) + ");select @shobeid=scope_identity();";
					text += "END";
				}
				else
				{
					text += "set @shobeid=NULL;";
				}
			}
			text = string.Concat(new string[]
			{
				text,
				" insert into shomarehesab(shomarehesab,bank_id,shobe_id,sahebcheck) values(",
				Public_Function.GetValue(ShomareHesab),
				",",
				Public_Function.GetValueInt(BankID),
				",@shobeid,",
				Public_Function.GetValue(sahebcheck),
				")"
			});
			text += " END";
			text = text + " ELSE update shomarehesab set sahebcheck=" + Public_Function.GetValue(sahebcheck) + " where id=@id;";
			Public_Function.ExecuteNonQuery(text);
		}

		// Token: 0x060001FC RID: 508 RVA: 0x000154A0 File Offset: 0x000136A0
		public void UpdateID(string ShomareHesab, string BankID, string ShobeID, string ShobeName, string ID)
		{
			string text = "declare @shobeid int ;declare @id int;";
			bool flag = Operators.CompareString(ShobeID, string.Empty, false) != 0;
			if (flag)
			{
				text = text + "set @shobeid=" + ShobeID + Environment.NewLine;
			}
			else
			{
				flag = (Operators.CompareString(ShobeName, string.Empty, false) != 0);
				if (flag)
				{
					text = text + " select @shobeid=id from shobe where name=" + Public_Function.GetValue(ShobeName) + ";";
					text += " if @@rowcount=0 begin";
					text = text + " insert into shobe(name) values(" + Public_Function.GetValue(ShobeName) + ");select @shobeid=scope_identity();";
					text += "END";
				}
				else
				{
					text += "set @shobe_id=NULL;";
				}
			}
			text = string.Concat(new string[]
			{
				text,
				"update shomarehesab set shomarehesab=",
				Public_Function.GetValue(ShomareHesab),
				",bank_id=",
				Public_Function.GetValueInt(BankID),
				",shobe_id=@shobeid  where id=",
				ID,
				";"
			});
			Public_Function.ExecuteNonQuery(text);
		}
	}
}
