using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace FruitBox
{
	// Token: 0x0200001A RID: 26
	public class Moshtari_Pic
	{
		// Token: 0x060001E3 RID: 483 RVA: 0x000020C1 File Offset: 0x000002C1
		[DebuggerNonUserCode]
		public Moshtari_Pic()
		{
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x00014E14 File Offset: 0x00013014
		public DataRow GetByID(string ID)
		{
			return Public_Function.FillDataRow("Select dbo.Moshtari_Pic.Moshtari_ID,dbo.Moshtari_Pic.Picdata,dbo.Moshtari_Pic.SignData From dbo.Moshtari_Pic where Moshtari_ID=" + ID);
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x00014E38 File Offset: 0x00013038
		public void Insert(string Moshtari_ID, byte[] Picdata, byte[] SignData)
		{
			SqlCommand sqlCommand = Public_Function.CreateSqlCommand("Insert Into dbo.Moshtari_Pic(Moshtari_ID,Picdata,SignData) Values(" + Moshtari_ID + ",@PicData,@SignData)");
			sqlCommand.CommandType = CommandType.Text;
			sqlCommand.Parameters.Add("@PicData", SqlDbType.Image);
			sqlCommand.Parameters.Add("@SignData", SqlDbType.Image);
			sqlCommand.Parameters[0].IsNullable = true;
			bool flag = Picdata != null;
			if (flag)
			{
				sqlCommand.Parameters[0].Value = Picdata;
			}
			else
			{
				sqlCommand.Parameters[0].Value = DBNull.Value;
			}
			sqlCommand.Parameters[1].IsNullable = true;
			flag = (SignData != null);
			if (flag)
			{
				sqlCommand.Parameters[1].Value = SignData;
			}
			else
			{
				sqlCommand.Parameters[1].Value = DBNull.Value;
			}
			sqlCommand.ExecuteNonQuery();
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x00014F28 File Offset: 0x00013128
		public void UpdatePicData(byte[] Picdata, string ID)
		{
			SqlCommand sqlCommand = Public_Function.CreateSqlCommand("Update dbo.Moshtari_Pic SET  Picdata = @PicData  Where Moshtari_ID=" + ID);
			sqlCommand.CommandType = CommandType.Text;
			sqlCommand.Parameters.Add("@PicData", SqlDbType.Image);
			sqlCommand.Parameters[0].IsNullable = true;
			bool flag = Picdata != null;
			if (flag)
			{
				sqlCommand.Parameters[0].Value = Picdata;
			}
			else
			{
				sqlCommand.Parameters[0].Value = DBNull.Value;
			}
			sqlCommand.ExecuteNonQuery();
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x00014FB8 File Offset: 0x000131B8
		public void UpdateSignData(byte[] SignData, string ID)
		{
			SqlCommand sqlCommand = Public_Function.CreateSqlCommand("Update dbo.Moshtari_Pic SET SignData= @SignData  Where Moshtari_ID=" + ID);
			sqlCommand.CommandType = CommandType.Text;
			sqlCommand.Parameters.Add("@SignData", SqlDbType.Image);
			sqlCommand.Parameters[0].IsNullable = true;
			bool flag = SignData != null;
			if (flag)
			{
				sqlCommand.Parameters[0].Value = SignData;
			}
			else
			{
				sqlCommand.Parameters[0].Value = DBNull.Value;
			}
			sqlCommand.ExecuteNonQuery();
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x000022AE File Offset: 0x000004AE
		public void Delete(string ID)
		{
			Public_Function.ExecuteNonQuery("Delete From dbo.Moshtari_Pic Where Moshtari_ID= " + ID);
		}
	}
}
