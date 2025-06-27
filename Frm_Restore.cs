using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x02000077 RID: 119
	[DesignerGenerated]
	public partial class Frm_Restore : Form
	{
		// Token: 0x060009AD RID: 2477 RVA: 0x00003D83 File Offset: 0x00001F83
		[DebuggerNonUserCode]
		public Frm_Restore()
		{
			Frm_Restore.__ENCAddToList(this);
			this.InitializeComponent();
		}

		// Token: 0x060009AE RID: 2478 RVA: 0x0007FCCC File Offset: 0x0007DECC
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_Restore.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_Restore.__ENCList.Count == Frm_Restore.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_Restore.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_Restore.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_Restore.__ENCList[num] = Frm_Restore.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_Restore.__ENCList.RemoveRange(num, Frm_Restore.__ENCList.Count - num);
						Frm_Restore.__ENCList.Capacity = Frm_Restore.__ENCList.Count;
					}
					Frm_Restore.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x060009B1 RID: 2481 RVA: 0x00080390 File Offset: 0x0007E590
		// (set) Token: 0x060009B2 RID: 2482 RVA: 0x00003D9B File Offset: 0x00001F9B
		internal virtual PanelEx PanelEx2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PanelEx2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PanelEx2 = value;
			}
		}

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x060009B3 RID: 2483 RVA: 0x000803A8 File Offset: 0x0007E5A8
		// (set) Token: 0x060009B4 RID: 2484 RVA: 0x00003DA5 File Offset: 0x00001FA5
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

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x060009B5 RID: 2485 RVA: 0x000803C0 File Offset: 0x0007E5C0
		// (set) Token: 0x060009B6 RID: 2486 RVA: 0x00003DAF File Offset: 0x00001FAF
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

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x060009B7 RID: 2487 RVA: 0x000803D8 File Offset: 0x0007E5D8
		// (set) Token: 0x060009B8 RID: 2488 RVA: 0x00003DB9 File Offset: 0x00001FB9
		internal virtual CircularProgress CircularProgress1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._CircularProgress1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._CircularProgress1 = value;
			}
		}

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x060009B9 RID: 2489 RVA: 0x000803F0 File Offset: 0x0007E5F0
		// (set) Token: 0x060009BA RID: 2490 RVA: 0x00080408 File Offset: 0x0007E608
		internal virtual Timer Timer1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Timer1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Timer1_Tick);
				bool flag = this._Timer1 != null;
				if (flag)
				{
					this._Timer1.Tick -= value2;
				}
				this._Timer1 = value;
				flag = (this._Timer1 != null);
				if (flag)
				{
					this._Timer1.Tick += value2;
				}
			}
		}

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x060009BB RID: 2491 RVA: 0x00080468 File Offset: 0x0007E668
		// (set) Token: 0x060009BC RID: 2492 RVA: 0x00080480 File Offset: 0x0007E680
		internal virtual Timer Timer2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Timer2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Timer2_Tick);
				bool flag = this._Timer2 != null;
				if (flag)
				{
					this._Timer2.Tick -= value2;
				}
				this._Timer2 = value;
				flag = (this._Timer2 != null);
				if (flag)
				{
					this._Timer2.Tick += value2;
				}
			}
		}

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x060009BD RID: 2493 RVA: 0x000804E0 File Offset: 0x0007E6E0
		// (set) Token: 0x060009BE RID: 2494 RVA: 0x00003DC3 File Offset: 0x00001FC3
		internal virtual PictureBox PictureBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PictureBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PictureBox1 = value;
			}
		}

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x060009BF RID: 2495 RVA: 0x000804F8 File Offset: 0x0007E6F8
		// (set) Token: 0x060009C0 RID: 2496 RVA: 0x00003DCD File Offset: 0x00001FCD
		public string Path
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Path;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Path = value;
			}
		}

		// Token: 0x060009C1 RID: 2497 RVA: 0x00080510 File Offset: 0x0007E710
		private void RestoreBackup(string OldDBName, string fileName)
		{
			string mConnection = string.Format("Provider=SQLOLEDB.1;Data Source=" + Public_Function.Server + Public_Function.SQLInstance + ";Initial Catalog=master;Persist Security Info=True;User ID=sa;password=1;Connect Timeout=10000", new object[0]);
			Public_Function.ExecuteNonQuery(string.Concat(new string[]
			{
				"declare @cmd varchar(20);declare @spid varchar(4);declare cur cursor for select cast(spid as varchar(4)) from master.dbo.sysprocesses  where dbid=db_id(" + Public_Function.GetValue(OldDBName) + ") open cur  fetch next from cur into @spid while @@fetch_status=0 begin  set @cmd='kill ' + @spid exec (@cmd)  fetch next from cur into @spid  end  close cur deallocate cur USE Master RESTORE DATABASE ",
				OldDBName,
				" FROM  DISK = N'",
				fileName,
				"' WITH  FILE = 1,   NOUNLOAD,  REPLACE,  STATS = 10"
			}), mConnection);
			Public_Function.Connection = new SqlConnection(string.Concat(new string[]
			{
				"Data Source=",
				Public_Function.Server,
				Public_Function.SQLInstance,
				";Initial Catalog=",
				OldDBName,
				";Persist Security Info=True;User ID=sa;Password=1"
			}));
			Public_Function.Connection.Open();
			Public_Function.dict.Clear();
			Public_Function.LoadApplicationSetting();
		}

		// Token: 0x060009C2 RID: 2498 RVA: 0x000805F4 File Offset: 0x0007E7F4
		private void Timer1_Tick(object sender, EventArgs e)
		{
			this.Timer1.Enabled = false;
			this.RestoreBackup(Public_Function.dict["dbname"], this.Path);
			this.Timer2.Enabled = false;
			Public_Function.ShowMessage("بازیابی اطلاعات با موفقیت انجام شد", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, null);
			this.Close();
		}

		// Token: 0x060009C3 RID: 2499 RVA: 0x00080650 File Offset: 0x0007E850
		private void Timer2_Tick(object sender, EventArgs e)
		{
			bool flag = this.CircularProgress1.Value == 100;
			if (flag)
			{
				this.CircularProgress1.Value = 0;
			}
			CircularProgress circularProgress = this.CircularProgress1;
			checked
			{
				circularProgress.Value += 10;
			}
		}

		// Token: 0x040003D5 RID: 981
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x040003D7 RID: 983
		[AccessedThroughProperty("PanelEx2")]
		private PanelEx _PanelEx2;

		// Token: 0x040003D8 RID: 984
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x040003D9 RID: 985
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x040003DA RID: 986
		[AccessedThroughProperty("CircularProgress1")]
		private CircularProgress _CircularProgress1;

		// Token: 0x040003DB RID: 987
		[AccessedThroughProperty("Timer1")]
		private Timer _Timer1;

		// Token: 0x040003DC RID: 988
		[AccessedThroughProperty("Timer2")]
		private Timer _Timer2;

		// Token: 0x040003DD RID: 989
		[AccessedThroughProperty("PictureBox1")]
		private PictureBox _PictureBox1;

		// Token: 0x040003DE RID: 990
		[CompilerGenerated]
		private string _Path;
	}
}
