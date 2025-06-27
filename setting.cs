using System;
using System.Diagnostics;

namespace FruitBox
{
	// Token: 0x0200007D RID: 125
	internal class setting
	{
		// Token: 0x06000AEC RID: 2796 RVA: 0x000020C1 File Offset: 0x000002C1
		[DebuggerNonUserCode]
		public setting()
		{
		}

		// Token: 0x06000AED RID: 2797 RVA: 0x0008B270 File Offset: 0x00089470
		public void Update(string Key, string Value)
		{
			Public_Function.ExecuteNonQuery(string.Concat(new string[]
			{
				"if not exists(select [key] from setting where [key]=",
				Public_Function.GetValue(Key),
				") insert into setting([key],value) values(",
				Public_Function.GetValue(Key),
				",",
				Public_Function.GetValue(Value),
				") else update setting set value=",
				Public_Function.GetValue(Value),
				" where lower([key])=",
				Public_Function.GetValue(Key)
			}));
		}

		// Token: 0x06000AEE RID: 2798 RVA: 0x00004276 File Offset: 0x00002476
		public void Delete(string Key)
		{
			Public_Function.ExecuteNonQuery("delete from setting where [key]=" + Public_Function.GetValue(Key));
		}
	}
}
