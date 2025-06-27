using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using FruitBox.My.Resources;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.UI;
using Janus.Windows.UI.Dock;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x02000067 RID: 103
	[DesignerGenerated]
	public partial class Frm_Delete_SalMali : Form
	{
		// Token: 0x0600076E RID: 1902 RVA: 0x0000328D File Offset: 0x0000148D
		[DebuggerNonUserCode]
		public Frm_Delete_SalMali()
		{
			base.KeyDown += new KeyEventHandler(this.Frm_Delete_SalMali_KeyDown);
			base.Load += new EventHandler(this.Frm_Delete_SalMali_Load);
			Frm_Delete_SalMali.__ENCAddToList(this);
			this.InitializeComponent();
		}

		// Token: 0x0600076F RID: 1903 RVA: 0x0006EC84 File Offset: 0x0006CE84
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_Delete_SalMali.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_Delete_SalMali.__ENCList.Count == Frm_Delete_SalMali.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_Delete_SalMali.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_Delete_SalMali.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_Delete_SalMali.__ENCList[num] = Frm_Delete_SalMali.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_Delete_SalMali.__ENCList.RemoveRange(num, Frm_Delete_SalMali.__ENCList.Count - num);
						Frm_Delete_SalMali.__ENCList.Capacity = Frm_Delete_SalMali.__ENCList.Count;
					}
					Frm_Delete_SalMali.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x06000772 RID: 1906 RVA: 0x0006F62C File Offset: 0x0006D82C
		// (set) Token: 0x06000773 RID: 1907 RVA: 0x000032CD File Offset: 0x000014CD
		internal virtual UIGroupBox UiGroupBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiGroupBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._UiGroupBox1 = value;
			}
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x06000774 RID: 1908 RVA: 0x0006F644 File Offset: 0x0006D844
		// (set) Token: 0x06000775 RID: 1909 RVA: 0x000032D7 File Offset: 0x000014D7
		internal virtual UIGroupBox UiGroupBox2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiGroupBox2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._UiGroupBox2 = value;
			}
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x06000776 RID: 1910 RVA: 0x0006F65C File Offset: 0x0006D85C
		// (set) Token: 0x06000777 RID: 1911 RVA: 0x000032E1 File Offset: 0x000014E1
		internal virtual UICheckBox UiCheckBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiCheckBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._UiCheckBox1 = value;
			}
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x06000778 RID: 1912 RVA: 0x0006F674 File Offset: 0x0006D874
		// (set) Token: 0x06000779 RID: 1913 RVA: 0x000032EB File Offset: 0x000014EB
		internal virtual Label Label1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label1 = value;
			}
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x0600077A RID: 1914 RVA: 0x0006F68C File Offset: 0x0006D88C
		// (set) Token: 0x0600077B RID: 1915 RVA: 0x0006F6A4 File Offset: 0x0006D8A4
		internal virtual UIButton UiButton1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiButton1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.UiButton1_Click);
				bool flag = this._UiButton1 != null;
				if (flag)
				{
					this._UiButton1.Click -= value2;
				}
				this._UiButton1 = value;
				flag = (this._UiButton1 != null);
				if (flag)
				{
					this._UiButton1.Click += value2;
				}
			}
		}

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x0600077C RID: 1916 RVA: 0x0006F704 File Offset: 0x0006D904
		// (set) Token: 0x0600077D RID: 1917 RVA: 0x000032F5 File Offset: 0x000014F5
		internal virtual EditBox EditBox2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._EditBox2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._EditBox2 = value;
			}
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x0600077E RID: 1918 RVA: 0x0006F71C File Offset: 0x0006D91C
		// (set) Token: 0x0600077F RID: 1919 RVA: 0x000032FF File Offset: 0x000014FF
		internal virtual EditBox EditBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._EditBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._EditBox1 = value;
			}
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x06000780 RID: 1920 RVA: 0x0006F734 File Offset: 0x0006D934
		// (set) Token: 0x06000781 RID: 1921 RVA: 0x00003309 File Offset: 0x00001509
		internal virtual Label Label3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label3 = value;
			}
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x06000782 RID: 1922 RVA: 0x0006F74C File Offset: 0x0006D94C
		// (set) Token: 0x06000783 RID: 1923 RVA: 0x00003313 File Offset: 0x00001513
		internal virtual Label Label2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label2 = value;
			}
		}

		// Token: 0x06000784 RID: 1924 RVA: 0x0006F764 File Offset: 0x0006D964
		private void UiButton1_Click(object sender, EventArgs e)
		{
			bool @checked = this.UiCheckBox1.Checked;
			if (@checked)
			{
				bool flag = Public_Function.ShowMessage("آیا مایل به حذف سال مالی میباشید؟", MessageBoxButtons.YesNo, MessageBoxIcon.Question, null) == DialogResult.Yes;
				if (flag)
				{
					SqlConnection sqlConnection = new SqlConnection
					{
						ConnectionString = "Data Source=" + Public_Function.Server + Public_Function.SQLInstance + ";Initial Catalog=master;Persist Security Info=True;User ID=sa;Password=1"
					};
					sqlConnection.Open();
					SqlCommand sqlCommand = new SqlCommand
					{
						Connection = sqlConnection,
						CommandText = "declare @cmd varchar(20);declare @spid varchar(4);declare cur cursor for select cast(spid as varchar(4)) from master.dbo.sysprocesses  where dbid=db_id('" + this.EditBox1.Text + "') open cur  fetch next from cur into @spid while @@fetch_status=0 begin  set @cmd='kill ' + @spid exec (@cmd)  fetch next from cur into @spid  end close cur deallocate cur  use master;drop database " + this.EditBox1.Text
					};
					sqlCommand.ExecuteNonQuery();
					sqlConnection.Close();
					Public_Function.ShowMessage("سال مالی حذف گردید", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, null);
					this.Close();
				}
			}
		}

		// Token: 0x06000785 RID: 1925 RVA: 0x0006620C File Offset: 0x0006440C
		private void Frm_Delete_SalMali_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Escape;
			if (flag)
			{
				this.Close();
			}
		}

		// Token: 0x06000786 RID: 1926 RVA: 0x0006F834 File Offset: 0x0006DA34
		private void Frm_Delete_SalMali_Load(object sender, EventArgs e)
		{
			string command = "select top 1 name,create_date from sys.databases where name like 'fruitbox%' order by name desc";
			DataTable dataTable = Public_Function.FillData(command);
			bool flag = dataTable != null;
			if (flag)
			{
				bool flag2 = Operators.CompareString(dataTable.Rows[0]["name"].ToString().ToLower(), "fruitbox", false) == 0;
				if (flag2)
				{
					this.UiButton1.Enabled = false;
				}
				else
				{
					this.EditBox1.Text = Conversions.ToString(dataTable.Rows[0]["name"]);
					this.EditBox2.Text = Public_Function.MiladiToShamsi(Conversions.ToDate(dataTable.Rows[0]["create_date"]));
				}
			}
		}

		// Token: 0x040002D6 RID: 726
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x040002D8 RID: 728
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x040002D9 RID: 729
		[AccessedThroughProperty("UiGroupBox2")]
		private UIGroupBox _UiGroupBox2;

		// Token: 0x040002DA RID: 730
		[AccessedThroughProperty("UiCheckBox1")]
		private UICheckBox _UiCheckBox1;

		// Token: 0x040002DB RID: 731
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x040002DC RID: 732
		[AccessedThroughProperty("UiButton1")]
		private UIButton _UiButton1;

		// Token: 0x040002DD RID: 733
		[AccessedThroughProperty("EditBox2")]
		private EditBox _EditBox2;

		// Token: 0x040002DE RID: 734
		[AccessedThroughProperty("EditBox1")]
		private EditBox _EditBox1;

		// Token: 0x040002DF RID: 735
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x040002E0 RID: 736
		[AccessedThroughProperty("Label2")]
		private Label _Label2;
	}
}
