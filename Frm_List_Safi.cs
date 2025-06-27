using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using FruitBox.My.Resources;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.UI.Dock;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x020000D0 RID: 208
	[DesignerGenerated]
	public partial class Frm_List_Safi : Form
	{
		// Token: 0x060011AD RID: 4525 RVA: 0x000BF878 File Offset: 0x000BDA78
		public Frm_List_Safi()
		{
			base.KeyDown += new KeyEventHandler(this.Frm_List_Safi_KeyDown);
			base.Load += new EventHandler(this.Frm_List_Safi_Load);
			Frm_List_Safi.__ENCAddToList(this);
			bool dialogMode = false;
			this.DialogMode = dialogMode;
			this.InitializeComponent();
		}

		// Token: 0x060011AE RID: 4526 RVA: 0x000BF8D0 File Offset: 0x000BDAD0
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_List_Safi.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_List_Safi.__ENCList.Count == Frm_List_Safi.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_List_Safi.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_List_Safi.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_List_Safi.__ENCList[num] = Frm_List_Safi.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_List_Safi.__ENCList.RemoveRange(num, Frm_List_Safi.__ENCList.Count - num);
						Frm_List_Safi.__ENCList.Capacity = Frm_List_Safi.__ENCList.Count;
					}
					Frm_List_Safi.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000570 RID: 1392
		// (get) Token: 0x060011B1 RID: 4529 RVA: 0x000C0074 File Offset: 0x000BE274
		// (set) Token: 0x060011B2 RID: 4530 RVA: 0x000C008C File Offset: 0x000BE28C
		internal virtual GridEX GridEX1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GridEX1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				RowActionEventHandler value2 = new RowActionEventHandler(this.GridEX1_RowDoubleClick);
				KeyEventHandler value3 = new KeyEventHandler(this.GridEX1_KeyDown);
				bool flag = this._GridEX1 != null;
				if (flag)
				{
					this._GridEX1.RowDoubleClick -= value2;
					this._GridEX1.KeyDown -= value3;
				}
				this._GridEX1 = value;
				flag = (this._GridEX1 != null);
				if (flag)
				{
					this._GridEX1.RowDoubleClick += value2;
					this._GridEX1.KeyDown += value3;
				}
			}
		}

		// Token: 0x17000571 RID: 1393
		// (get) Token: 0x060011B3 RID: 4531 RVA: 0x000C0114 File Offset: 0x000BE314
		// (set) Token: 0x060011B4 RID: 4532 RVA: 0x00005D9E File Offset: 0x00003F9E
		internal virtual Bar Bar1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Bar1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Bar1 = value;
			}
		}

		// Token: 0x17000572 RID: 1394
		// (get) Token: 0x060011B5 RID: 4533 RVA: 0x000C012C File Offset: 0x000BE32C
		// (set) Token: 0x060011B6 RID: 4534 RVA: 0x000C0144 File Offset: 0x000BE344
		internal virtual ButtonItem ButtonItem5
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem5;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem5_Click);
				bool flag = this._ButtonItem5 != null;
				if (flag)
				{
					this._ButtonItem5.Click -= value2;
				}
				this._ButtonItem5 = value;
				flag = (this._ButtonItem5 != null);
				if (flag)
				{
					this._ButtonItem5.Click += value2;
				}
			}
		}

		// Token: 0x17000573 RID: 1395
		// (get) Token: 0x060011B7 RID: 4535 RVA: 0x000C01A4 File Offset: 0x000BE3A4
		// (set) Token: 0x060011B8 RID: 4536 RVA: 0x00005DA8 File Offset: 0x00003FA8
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

		// Token: 0x17000574 RID: 1396
		// (get) Token: 0x060011B9 RID: 4537 RVA: 0x000C01BC File Offset: 0x000BE3BC
		// (set) Token: 0x060011BA RID: 4538 RVA: 0x00005DB2 File Offset: 0x00003FB2
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

		// Token: 0x17000575 RID: 1397
		// (get) Token: 0x060011BB RID: 4539 RVA: 0x000C01D4 File Offset: 0x000BE3D4
		// (set) Token: 0x060011BC RID: 4540 RVA: 0x000C01EC File Offset: 0x000BE3EC
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
				EventHandler value2 = new EventHandler(this.EditBox1_TextChanged);
				bool flag = this._EditBox1 != null;
				if (flag)
				{
					this._EditBox1.TextChanged -= value2;
				}
				this._EditBox1 = value;
				flag = (this._EditBox1 != null);
				if (flag)
				{
					this._EditBox1.TextChanged += value2;
				}
			}
		}

		// Token: 0x17000576 RID: 1398
		// (get) Token: 0x060011BD RID: 4541 RVA: 0x000C024C File Offset: 0x000BE44C
		// (set) Token: 0x060011BE RID: 4542 RVA: 0x00005DBC File Offset: 0x00003FBC
		public int SelectedNum
		{
			[DebuggerNonUserCode]
			get
			{
				return this._SelectedNum;
			}
			[DebuggerNonUserCode]
			set
			{
				this._SelectedNum = value;
			}
		}

		// Token: 0x17000577 RID: 1399
		// (get) Token: 0x060011BF RID: 4543 RVA: 0x000C0264 File Offset: 0x000BE464
		// (set) Token: 0x060011C0 RID: 4544 RVA: 0x00005DC6 File Offset: 0x00003FC6
		public bool DialogMode
		{
			[DebuggerNonUserCode]
			get
			{
				return this._DialogMode;
			}
			[DebuggerNonUserCode]
			set
			{
				this._DialogMode = value;
			}
		}

		// Token: 0x060011C1 RID: 4545 RVA: 0x000C027C File Offset: 0x000BE47C
		private void Get_mande_Safi()
		{
			DataTable dataTable = Public_Function.FillData("SELECT     Furush_Hag.ID, MAX(Furush_Hag.Num) AS Num,MAX(Baskul) as Baskul,max(Furush_Hag.Tedad_Kol) AS Tedad_Kol,max(Tarikh_Vurud) AS Tarikh_Vurud, SUM(Furush_Hag_Detail.Tedad) AS Tedad, SUM(Furush_Hag_Detail.Vazn_Ba_Zarf) AS Vazn_Ba_Zarf,  SUM(Furush_Hag_Detail.Vazn_Kol) AS Vazn_Kol, SUM(Furush_Hag_Detail.Jam_Kol) AS Jam_Kol, max(Moshtari.Name)+' '+ max(Moshtari.Family) AS Moshtari_Name,Null as Vazn_Mande  FROM         Furush_Hag LEFT OUTER JOIN  Furush_Hag_Detail ON Furush_Hag.ID = Furush_Hag_Detail.Furush_Hug_ID INNER JOIN  Moshtari ON Furush_Hag.Moshtari_ID = Moshtari.ID  WHERE     (Furush_Hag.ID NOT IN  (SELECT     Furush_Hag_ID  FROM         Safi_Furush))  GROUP BY Furush_Hag.ID");
			dataTable.Columns.Add("Tedad_mande", typeof(decimal));
			try
			{
				IEnumerator enumerator = dataTable.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					bool flag = dataRow["tedad"] != DBNull.Value;
					if (flag)
					{
						dataRow["tedad"] = dataRow["tedad"].ToString().Replace(".0", "");
					}
					flag = (dataRow["Vazn_Ba_Zarf"] != DBNull.Value);
					if (flag)
					{
						dataRow["Vazn_Ba_Zarf"] = dataRow["Vazn_Ba_Zarf"].ToString().Replace(".0", "");
					}
					flag = (dataRow["vazn_kol"] != DBNull.Value);
					if (flag)
					{
						dataRow["Vazn_Kol"] = dataRow["Vazn_Kol"].ToString().Replace(".0", "");
					}
					flag = (dataRow["baskul"] != DBNull.Value);
					if (flag)
					{
						dataRow["baskul"] = dataRow["baskul"].ToString().Replace(".0", "");
						flag = (dataRow["Vazn_Kol"] != DBNull.Value);
						if (flag)
						{
							dataRow["Vazn_Mande"] = Operators.SubtractObject(dataRow["baskul"], dataRow["vazn_kol"]);
						}
					}
					flag = (dataRow["Jam_Kol"] != DBNull.Value);
					if (flag)
					{
						dataRow["Jam_Kol"] = dataRow["Jam_Kol"].ToString().Replace(".0", "");
					}
					flag = (dataRow["Tedad_Kol"] != DBNull.Value);
					if (flag)
					{
						bool flag2 = dataRow["Tedad"] != DBNull.Value;
						if (flag2)
						{
							dataRow["Tedad_Mande"] = Operators.SubtractObject(dataRow["Tedad_Kol"], dataRow["Tedad"]);
							dataRow["Tedad_Mande"] = dataRow["Tedad_Mande"].ToString().Replace(".0", "");
						}
					}
				}
			}
			finally
			{
				IEnumerator enumerator;
				bool flag2 = enumerator is IDisposable;
				if (flag2)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			this.GridEX1.DataSource = dataTable;
			Public_Function.AddFilterColumn(this.GridEX1);
		}

		// Token: 0x060011C2 RID: 4546 RVA: 0x0006620C File Offset: 0x0006440C
		private void Frm_List_Safi_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Escape;
			if (flag)
			{
				this.Close();
			}
		}

		// Token: 0x060011C3 RID: 4547 RVA: 0x000C055C File Offset: 0x000BE75C
		private void Frm_List_Safi_Load(object sender, EventArgs e)
		{
			bool dialogMode = this.DialogMode;
			if (dialogMode)
			{
				this.Bar1.Visible = false;
			}
			this.Get_mande_Safi();
		}

		// Token: 0x060011C4 RID: 4548 RVA: 0x000C058C File Offset: 0x000BE78C
		private void ButtonItem5_Click(object sender, EventArgs e)
		{
			bool flag = this.GridEX1.CurrentRow != null;
			if (flag)
			{
				Frm_Safi frm_Safi = new Frm_Safi
				{
					Furush_ID = Conversions.ToLong(this.GridEX1.CurrentRow.Cells["furush_hag_id"].Value)
				};
				frm_Safi.ShowDialog();
				Public_Function.InvokeMethod("check_enable");
			}
		}

		// Token: 0x060011C5 RID: 4549 RVA: 0x000C05FC File Offset: 0x000BE7FC
		private void GridEX1_RowDoubleClick(object sender, RowActionEventArgs e)
		{
			bool flag = this.GridEX1.CurrentRow != null;
			if (flag)
			{
				bool flag2 = !this.DialogMode;
				if (flag2)
				{
					Frm_Safi frm_Safi = new Frm_Safi
					{
						Furush_ID = Conversions.ToLong(this.GridEX1.CurrentRow.Cells["furush_hag_id"].Value)
					};
					frm_Safi.ShowDialog();
				}
				else
				{
					this.SelectedNum = Conversions.ToInteger(this.GridEX1.CurrentRow.Cells["num"].Value);
					this.Close();
				}
			}
		}

		// Token: 0x060011C6 RID: 4550 RVA: 0x00005DD0 File Offset: 0x00003FD0
		private void EditBox1_TextChanged(object sender, EventArgs e)
		{
			Public_Function.FilterGrid(this.GridEX1, this.EditBox1.Text);
		}

		// Token: 0x060011C7 RID: 4551 RVA: 0x000C06A8 File Offset: 0x000BE8A8
		private void GridEX1_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				this.GridEX1_RowDoubleClick(null, null);
			}
		}

		// Token: 0x040006C5 RID: 1733
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x040006C7 RID: 1735
		[AccessedThroughProperty("GridEX1")]
		private GridEX _GridEX1;

		// Token: 0x040006C8 RID: 1736
		[AccessedThroughProperty("Bar1")]
		private Bar _Bar1;

		// Token: 0x040006C9 RID: 1737
		[AccessedThroughProperty("ButtonItem5")]
		private ButtonItem _ButtonItem5;

		// Token: 0x040006CA RID: 1738
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x040006CB RID: 1739
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x040006CC RID: 1740
		[AccessedThroughProperty("EditBox1")]
		private EditBox _EditBox1;

		// Token: 0x040006CD RID: 1741
		[CompilerGenerated]
		private int _SelectedNum;

		// Token: 0x040006CE RID: 1742
		[CompilerGenerated]
		private bool _DialogMode;
	}
}
