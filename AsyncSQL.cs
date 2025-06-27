using System;
using System.Data;
using System.Data.SqlClient;

namespace FruitBox
{
	// Token: 0x02000056 RID: 86
	public class AsyncSQL
	{
		// Token: 0x060003B8 RID: 952 RVA: 0x000028EF File Offset: 0x00000AEF
		public AsyncSQL()
		{
			this.cnn = new SqlConnection();
			this.cnn = new SqlConnection(Public_Function.Connection.ConnectionString);
			this.cnn.Open();
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x00002922 File Offset: 0x00000B22
		public object ExecuteScalar(string Command)
		{
			return new SqlCommand
			{
				Connection = this.cnn,
				CommandText = Command
			}.ExecuteScalar();
		}

		// Token: 0x060003BA RID: 954 RVA: 0x0004DF24 File Offset: 0x0004C124
		public bool ExecuteNonQuery(string Command)
		{
			if (string.Compare(Command, string.Empty, StringComparison.Ordinal) == 0)
			{
				return false;
			}
			SqlTransaction sqlTransaction = null;
			bool result;
			try
			{
				sqlTransaction = Public_Function.Connection.BeginTransaction();
				new SqlCommand
				{
					Connection = this.cnn,
					CommandText = Command,
					Transaction = sqlTransaction
				}.ExecuteNonQuery();
				sqlTransaction.Commit();
				result = true;
			}
			catch (SqlException ex)
			{
				if (sqlTransaction != null)
				{
					sqlTransaction.Rollback();
				}
				Console.WriteLine("Error executing command: " + ex.Message);
				result = false;
			}
			return result;
		}

		// Token: 0x060003BB RID: 955 RVA: 0x0004DFB4 File Offset: 0x0004C1B4
		public DataTable FillData(string Command)
		{
			SqlDataAdapter arg_0B_0 = new SqlDataAdapter();
			DataTable dataTable = new DataTable();
			arg_0B_0.SelectCommand = new SqlCommand
			{
				Connection = this.cnn,
				CommandText = Command
			};
			arg_0B_0.Fill(dataTable);
			return dataTable;
		}

		// Token: 0x060003BC RID: 956 RVA: 0x0004DFF4 File Offset: 0x0004C1F4
		public DataTable FillSchema(string Command)
		{
			SqlDataAdapter arg_0B_0 = new SqlDataAdapter();
			DataTable dataTable = new DataTable();
			arg_0B_0.SelectCommand = new SqlCommand
			{
				Connection = this.cnn,
				CommandText = Command
			};
			arg_0B_0.FillSchema(dataTable, SchemaType.Mapped);
			return dataTable;
		}

		// Token: 0x060003BD RID: 957 RVA: 0x0004E034 File Offset: 0x0004C234
		public DataRow FillDataRow(string Command)
		{
			SqlDataAdapter arg_0B_0 = new SqlDataAdapter();
			DataTable dataTable = new DataTable();
			arg_0B_0.SelectCommand = new SqlCommand
			{
				Connection = this.cnn,
				CommandText = Command
			};
			arg_0B_0.Fill(dataTable);
			if (dataTable.Rows.Count <= 0)
			{
				return null;
			}
			return dataTable.Rows[0];
		}

		// Token: 0x04000180 RID: 384
		private SqlConnection cnn;
	}
}
