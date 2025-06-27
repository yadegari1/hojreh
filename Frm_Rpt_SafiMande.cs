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
using Janus.Windows.GridEX.EditControls;
using Janus.Windows.UI.Dock;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x02000137 RID: 311
	[DesignerGenerated]
	public partial class Frm_Rpt_SafiMande : Form
	{
		// Token: 0x06002CF1 RID: 11505 RVA: 0x0000B545 File Offset: 0x00009745
		[DebuggerNonUserCode]
		public Frm_Rpt_SafiMande()
		{
			base.KeyDown += new KeyEventHandler(this.Frm_Rpt_SafiMande_KeyDown);
			base.Load += new EventHandler(this.Frm_Rpt_SafiMande_Load);
			Frm_Rpt_SafiMande.__ENCAddToList(this);
			this.InitializeComponent();
		}

		// Token: 0x06002CF2 RID: 11506 RVA: 0x00216830 File Offset: 0x00214A30
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_Rpt_SafiMande.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_Rpt_SafiMande.__ENCList.Count == Frm_Rpt_SafiMande.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_Rpt_SafiMande.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_Rpt_SafiMande.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_Rpt_SafiMande.__ENCList[num] = Frm_Rpt_SafiMande.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_Rpt_SafiMande.__ENCList.RemoveRange(num, Frm_Rpt_SafiMande.__ENCList.Count - num);
						Frm_Rpt_SafiMande.__ENCList.Capacity = Frm_Rpt_SafiMande.__ENCList.Count;
					}
					Frm_Rpt_SafiMande.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000DA6 RID: 3494
		// (get) Token: 0x06002CF5 RID: 11509 RVA: 0x002172DC File Offset: 0x002154DC
		// (set) Token: 0x06002CF6 RID: 11510 RVA: 0x0000B585 File Offset: 0x00009785
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

		// Token: 0x17000DA7 RID: 3495
		// (get) Token: 0x06002CF7 RID: 11511 RVA: 0x002172F4 File Offset: 0x002154F4
		// (set) Token: 0x06002CF8 RID: 11512 RVA: 0x0000B58F File Offset: 0x0000978F
		internal virtual ButtonItem ButtonItem2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ButtonItem2 = value;
			}
		}

		// Token: 0x17000DA8 RID: 3496
		// (get) Token: 0x06002CF9 RID: 11513 RVA: 0x0021730C File Offset: 0x0021550C
		// (set) Token: 0x06002CFA RID: 11514 RVA: 0x00217324 File Offset: 0x00215524
		internal virtual ButtonItem ButtonItem1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem9_Click);
				bool flag = this._ButtonItem1 != null;
				if (flag)
				{
					this._ButtonItem1.Click -= value2;
				}
				this._ButtonItem1 = value;
				flag = (this._ButtonItem1 != null);
				if (flag)
				{
					this._ButtonItem1.Click += value2;
				}
			}
		}

		// Token: 0x17000DA9 RID: 3497
		// (get) Token: 0x06002CFB RID: 11515 RVA: 0x00217384 File Offset: 0x00215584
		// (set) Token: 0x06002CFC RID: 11516 RVA: 0x0000B599 File Offset: 0x00009799
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

		// Token: 0x17000DAA RID: 3498
		// (get) Token: 0x06002CFD RID: 11517 RVA: 0x0021739C File Offset: 0x0021559C
		// (set) Token: 0x06002CFE RID: 11518 RVA: 0x002173B4 File Offset: 0x002155B4
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

		// Token: 0x17000DAB RID: 3499
		// (get) Token: 0x06002CFF RID: 11519 RVA: 0x00217414 File Offset: 0x00215614
		// (set) Token: 0x06002D00 RID: 11520 RVA: 0x0000B5A3 File Offset: 0x000097A3
		internal virtual SelectItem txt_bankhesab
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_bankhesab;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_bankhesab = value;
			}
		}

		// Token: 0x17000DAC RID: 3500
		// (get) Token: 0x06002D01 RID: 11521 RVA: 0x0021742C File Offset: 0x0021562C
		// (set) Token: 0x06002D02 RID: 11522 RVA: 0x0000B5AD File Offset: 0x000097AD
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

		// Token: 0x17000DAD RID: 3501
		// (get) Token: 0x06002D03 RID: 11523 RVA: 0x00217444 File Offset: 0x00215644
		// (set) Token: 0x06002D04 RID: 11524 RVA: 0x0021745C File Offset: 0x0021565C
		internal virtual DataEntryGrid GridEX1
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
				RowCheckStateChangeEventHandler value2 = new RowCheckStateChangeEventHandler(this.GridEX1_RowCheckStateChanged);
				bool flag = this._GridEX1 != null;
				if (flag)
				{
					this._GridEX1.RowCheckStateChanged -= value2;
				}
				this._GridEX1 = value;
				flag = (this._GridEX1 != null);
				if (flag)
				{
					this._GridEX1.RowCheckStateChanged += value2;
				}
			}
		}

		// Token: 0x17000DAE RID: 3502
		// (get) Token: 0x06002D05 RID: 11525 RVA: 0x002174BC File Offset: 0x002156BC
		// (set) Token: 0x06002D06 RID: 11526 RVA: 0x0000B5B7 File Offset: 0x000097B7
		public long Moshtari_id
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Moshtari_id;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Moshtari_id = value;
			}
		}

		// Token: 0x06002D07 RID: 11527 RVA: 0x002174D4 File Offset: 0x002156D4
		private void Frm_Rpt_SafiMande_KeyDown(object sender, KeyEventArgs e)
		{
			Keys keyCode = e.KeyCode;
			bool flag = keyCode == Keys.Escape;
			if (flag)
			{
				this.Close();
			}
			else
			{
				flag = (keyCode == Keys.F4);
				if (flag)
				{
					this.ButtonItem9_Click(null, null);
				}
			}
		}

		// Token: 0x06002D08 RID: 11528 RVA: 0x0000B5C1 File Offset: 0x000097C1
		private void EditBox1_TextChanged(object sender, EventArgs e)
		{
			Public_Function.FilterGrid(this.GridEX1, this.EditBox1.Text);
		}

		// Token: 0x06002D09 RID: 11529 RVA: 0x00217514 File Offset: 0x00215714
		private void Frm_Rpt_SafiMande_Load(object sender, EventArgs e)
		{
			DataTable dataTable = Public_Function.FillData(" SELECT     Safi_Furush_1.ID, Sanad.CodeHesab_ID, Sanad.Bed, Sanad.Bes, Sanad.Tarikh, Sanad.Tarikh_Fa, Sanad.Tozih, NULL AS kala_name, Sanad.Bed AS rembed,  Sanad.Bes AS rembes, t.Tedad, t.vazn_kol, NULL AS Fee, t.ba_zarf, 4 AS SanadType, Safi_Furush_1.printcount, NULL AS PardakhtCheck_ID, NULL AS Check_ID,  1 AS calc, Sanad.checked, Furush_Hag_1.Num,Furush_Hag_1.ID AS furush_id    FROM         Safi_Furush AS Safi_Furush_1 INNER JOIN  Sanad ON Safi_Furush_1.Sanad_ID = Sanad.ID INNER JOIN      (SELECT     Safi_Furush.ID, SUM(Furush_Hag_Detail.Tedad) AS Tedad, SUM(Furush_Hag_Detail.Vazn_Kol) AS vazn_kol, SUM(Furush_Hag_Detail.Vazn_Ba_Zarf)                                AS ba_zarf         FROM         Safi_Furush INNER JOIN                               Furush_Hag ON Safi_Furush.Furush_Hag_ID = Furush_Hag.ID INNER JOIN                               Furush_Hag_Detail ON Furush_Hag.ID = Furush_Hag_Detail.Furush_Hug_ID         WHERE     (Furush_Hag.Moshtari_ID = " + Conversions.ToString(this.Moshtari_id) + ") AND (Safi_Furush.printcount IS NULL)         GROUP BY Safi_Furush.ID) AS t ON Safi_Furush_1.ID = t.ID INNER JOIN        Furush_Hag AS Furush_Hag_1 ON Safi_Furush_1.Furush_Hag_ID = Furush_Hag_1.ID");
			string text = string.Empty;
			string value = string.Empty;
			try
			{
				IEnumerator enumerator = dataTable.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					text = Conversions.ToString(dataRow["Tozih"]);
					int num = text.IndexOf("-");
					bool flag = num > 0;
					if (flag)
					{
						value = checked(text.Substring(num + 1, text.Length - num - 1));
						dataRow["tozih"] = value;
					}
				}
			}
			finally
			{
				IEnumerator enumerator;
				bool flag = enumerator is IDisposable;
				if (flag)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			this.GridEX1.DataSource = dataTable;
			Public_Function.AddFilterColumn(this.GridEX1);
		}

		// Token: 0x06002D0A RID: 11530 RVA: 0x00217614 File Offset: 0x00215814
		private void GridEX1_RowCheckStateChanged(object sender, RowCheckStateChangeEventArgs e)
		{
			bool flag = this.GridEX1.CurrentRow.Cells["ID"].Value == DBNull.Value;
			if (!flag)
			{
				flag = this.GridEX1.CurrentRow.IsChecked;
				if (flag)
				{
					NewLateBinding.LateCall(null, typeof(Public_Function), "ExecuteNonQuery", new object[]
					{
						Operators.ConcatenateObject("update Safi_Furush set printcount=1 where id=", this.GridEX1.CurrentRow.Cells["ID"].Value)
					}, null, null, null, true);
				}
				else
				{
					flag = (this.GridEX1.CurrentRow.Cells["printcount"].Value == DBNull.Value);
					if (flag)
					{
						NewLateBinding.LateCall(null, typeof(Public_Function), "ExecuteNonQuery", new object[]
						{
							Operators.ConcatenateObject("update Safi_Furush set printcount=null where id=", this.GridEX1.CurrentRow.Cells["ID"].Value)
						}, null, null, null, true);
					}
					else
					{
						this.GridEX1.CurrentRow.BeginEdit();
						this.GridEX1.CurrentRow.IsChecked = true;
						this.GridEX1.CurrentRow.EndEdit();
					}
				}
			}
		}

		// Token: 0x06002D0B RID: 11531 RVA: 0x00217770 File Offset: 0x00215970
		private void ButtonItem9_Click(object sender, EventArgs e)
		{
			bool flag = this.GridEX1.CurrentRow == null;
			if (!flag)
			{
				string text = string.Empty;
				Frm_Safi frm_Safi = new Frm_Safi();
				frm_Safi.WindowState = FormWindowState.Minimized;
				frm_Safi.ShowInTaskbar = false;
				frm_Safi.Show();
				frm_Safi.Furush_ID = Conversions.ToLong(this.GridEX1.CurrentRow.Cells["furush_id"].Value);
				frm_Safi.Frm_Safi_Load(null, null);
				frm_Safi.ButtonItem4_Click(null, null);
				text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(" update safi_furush set printcount=1 where id= ", this.GridEX1.CurrentRow.Cells["ID"].Value)));
				this.GridEX1.CurrentRow.BeginEdit();
				this.GridEX1.CurrentRow.IsChecked = true;
				this.GridEX1.CurrentRow.Cells["printcount"].Value = 1;
				this.GridEX1.CurrentRow.EndEdit();
				frm_Safi.Close();
				flag = (text.Length > 0);
				if (flag)
				{
					Public_Function.ExecuteNonQuery(text);
				}
			}
		}

		// Token: 0x04001175 RID: 4469
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04001177 RID: 4471
		[AccessedThroughProperty("Bar1")]
		private Bar _Bar1;

		// Token: 0x04001178 RID: 4472
		[AccessedThroughProperty("ButtonItem2")]
		private ButtonItem _ButtonItem2;

		// Token: 0x04001179 RID: 4473
		[AccessedThroughProperty("ButtonItem1")]
		private ButtonItem _ButtonItem1;

		// Token: 0x0400117A RID: 4474
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x0400117B RID: 4475
		[AccessedThroughProperty("EditBox1")]
		private EditBox _EditBox1;

		// Token: 0x0400117C RID: 4476
		[AccessedThroughProperty("txt_bankhesab")]
		private SelectItem _txt_bankhesab;

		// Token: 0x0400117D RID: 4477
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x0400117E RID: 4478
		[AccessedThroughProperty("GridEX1")]
		private DataEntryGrid _GridEX1;

		// Token: 0x0400117F RID: 4479
		[CompilerGenerated]
		private long _Moshtari_id;
	}
}
