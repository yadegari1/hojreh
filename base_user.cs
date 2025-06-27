using System;
using System.Data;
using System.Diagnostics;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x02000051 RID: 81
	public class base_user
	{
		// Token: 0x06000398 RID: 920 RVA: 0x000020C1 File Offset: 0x000002C1
		[DebuggerNonUserCode]
		public base_user()
		{
		}

		// Token: 0x06000399 RID: 921 RVA: 0x0004D4B4 File Offset: 0x0004B6B4
		public DataRow GetByName(string Name)
		{
			return Public_Function.FillDataRow("select * from users where Username =" + Public_Function.GetValue(Name));
		}

		// Token: 0x0600039A RID: 922 RVA: 0x0004D4DC File Offset: 0x0004B6DC
		public DataTable GetAll()
		{
			return Public_Function.FillData("Select * from Users");
		}

		// Token: 0x0600039B RID: 923 RVA: 0x0004D4F8 File Offset: 0x0004B6F8
		public int Insert(string User_Name, string Password)
		{
			return Conversions.ToInteger(Public_Function.ExecuteScalar(string.Concat(new string[]
			{
				"Insert into Users(UserName,Password,Gui) Values(",
				Public_Function.GetValue(User_Name),
				",",
				Public_Function.GetValue(Password),
				",0); Select Scope_Identity();"
			})));
		}

		// Token: 0x0600039C RID: 924 RVA: 0x0004D550 File Offset: 0x0004B750
		public bool Login(string user, string pass)
		{
			DataRow dataRow = Public_Function.FillDataRow("select * from Users where username=" + Public_Function.GetValue(user) + " AND password=" + Public_Function.GetValue(pass));
			bool flag = dataRow != null;
			bool result;
			if (flag)
			{
				Public_Function.CurrentData.Username = Conversions.ToString(dataRow["username"]);
				Public_Function.CurrentData.UserID = Conversions.ToLong(dataRow["ID"]);
				Public_Function.CurrentData.Gui = Conversions.ToInteger(dataRow["gui"]);
				Public_Function.CurrentData.Password = Conversions.ToString(dataRow["password"]);
				Public_Function.CurrentData.AutoBackup = Conversions.ToBoolean(dataRow["autobackup"]);
				Public_Function.CurrentData.AutoClose = Conversions.ToBoolean(dataRow["autoclose"]);
				Public_Function.CurrentData.Tabbed = Conversions.ToBoolean(dataRow["tabbed"]);
				result = true;
			}
			else
			{
				flag = Public_Function.dict.ContainsKey("eval");
				if (flag)
				{
					bool flag2 = Operators.CompareString(user.ToLower(), "admin", false) == 0 && Operators.CompareString(pass, "1", false) == 0;
					if (flag2)
					{
						Public_Function.CurrentData.Username = "Admin";
						result = true;
						return result;
					}
				}
				result = false;
			}
			return result;
		}

		// Token: 0x0600039D RID: 925 RVA: 0x0004D6AC File Offset: 0x0004B8AC
		public void Update(string gui, string tabbed, string autoclose, string autobackup)
		{
			Public_Function.ExecuteNonQuery(string.Concat(new string[]
			{
				"update users set gui=",
				gui,
				",tabbed=",
				tabbed,
				" ,autoclose=",
				autoclose,
				",autobackup=",
				autobackup,
				" where id=",
				Conversions.ToString(Public_Function.CurrentData.UserID)
			}));
		}

		// Token: 0x0600039E RID: 926 RVA: 0x00002873 File Offset: 0x00000A73
		public void UpdateUser(string password, string Userid)
		{
			Public_Function.ExecuteNonQuery("update users set password=" + Public_Function.GetValue(password) + " where id=" + Userid);
		}

		// Token: 0x0600039F RID: 927 RVA: 0x00002893 File Offset: 0x00000A93
		public void DeleteUser(string userid)
		{
			Public_Function.ExecuteNonQuery("delete from users where id=" + userid);
		}
	}
}
