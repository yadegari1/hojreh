using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using FruitBox.My;
using FruitBox.My.Resources;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.GridEX.EditControls;
using Janus.Windows.UI;
using Janus.Windows.UI.Dock;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x0200007B RID: 123
	[DesignerGenerated]
	public partial class Frm_SelectItemSql : Form
	{
		// Token: 0x06000A41 RID: 2625 RVA: 0x00085668 File Offset: 0x00083868
		public Frm_SelectItemSql()
		{
			base.FormClosing += new FormClosingEventHandler(this.Frm_SelectItem_FormClosing);
			base.KeyDown += new KeyEventHandler(this.Frm_SelectItem_KeyDown);
			base.Load += new EventHandler(this.Frm_SelectItem_Load);
			Frm_SelectItemSql.__ENCAddToList(this);
			bool flag = false;
			this.CanEdit = flag;
			flag = false;
			this.CanDelete = flag;
			this.InitializeComponent();
		}

		// Token: 0x06000A42 RID: 2626 RVA: 0x000856DC File Offset: 0x000838DC
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_SelectItemSql.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_SelectItemSql.__ENCList.Count == Frm_SelectItemSql.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_SelectItemSql.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_SelectItemSql.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_SelectItemSql.__ENCList[num] = Frm_SelectItemSql.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_SelectItemSql.__ENCList.RemoveRange(num, Frm_SelectItemSql.__ENCList.Count - num);
						Frm_SelectItemSql.__ENCList.Capacity = Frm_SelectItemSql.__ENCList.Count;
					}
					Frm_SelectItemSql.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x06000A45 RID: 2629 RVA: 0x00085D34 File Offset: 0x00083F34
		// (set) Token: 0x06000A46 RID: 2630 RVA: 0x00085D4C File Offset: 0x00083F4C
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
				EventHandler value4 = new EventHandler(this.GridEX1_GotFocus);
				ColumnActionEventHandler value5 = new ColumnActionEventHandler(this.GridEX1_ColumnButtonClick);
				bool flag = this._GridEX1 != null;
				if (flag)
				{
					this._GridEX1.RowDoubleClick -= value2;
					this._GridEX1.KeyDown -= value3;
					this._GridEX1.GotFocus -= value4;
					this._GridEX1.ColumnButtonClick -= value5;
				}
				this._GridEX1 = value;
				flag = (this._GridEX1 != null);
				if (flag)
				{
					this._GridEX1.RowDoubleClick += value2;
					this._GridEX1.KeyDown += value3;
					this._GridEX1.GotFocus += value4;
					this._GridEX1.ColumnButtonClick += value5;
				}
			}
		}

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x06000A47 RID: 2631 RVA: 0x00085E28 File Offset: 0x00084028
		// (set) Token: 0x06000A48 RID: 2632 RVA: 0x00003FEE File Offset: 0x000021EE
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

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x06000A49 RID: 2633 RVA: 0x00085E40 File Offset: 0x00084040
		// (set) Token: 0x06000A4A RID: 2634 RVA: 0x00085E58 File Offset: 0x00084058
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
				KeyEventHandler value3 = new KeyEventHandler(this.EditBox1_KeyDown);
				bool flag = this._EditBox1 != null;
				if (flag)
				{
					this._EditBox1.TextChanged -= value2;
					this._EditBox1.KeyDown -= value3;
				}
				this._EditBox1 = value;
				flag = (this._EditBox1 != null);
				if (flag)
				{
					this._EditBox1.TextChanged += value2;
					this._EditBox1.KeyDown += value3;
				}
			}
		}

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x06000A4B RID: 2635 RVA: 0x00085EE0 File Offset: 0x000840E0
		// (set) Token: 0x06000A4C RID: 2636 RVA: 0x00003FF8 File Offset: 0x000021F8
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

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x06000A4D RID: 2637 RVA: 0x00085EF8 File Offset: 0x000840F8
		// (set) Token: 0x06000A4E RID: 2638 RVA: 0x00085F10 File Offset: 0x00084110
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

		// Token: 0x17000322 RID: 802
		// (get) Token: 0x06000A4F RID: 2639 RVA: 0x00085F70 File Offset: 0x00084170
		// (set) Token: 0x06000A50 RID: 2640 RVA: 0x00004002 File Offset: 0x00002202
		public CollectionBase items
		{
			[DebuggerNonUserCode]
			get
			{
				return this._items;
			}
			[DebuggerNonUserCode]
			set
			{
				this._items = value;
			}
		}

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x06000A51 RID: 2641 RVA: 0x00085F88 File Offset: 0x00084188
		// (set) Token: 0x06000A52 RID: 2642 RVA: 0x0000400C File Offset: 0x0000220C
		public DataRow SelectedRow
		{
			[DebuggerNonUserCode]
			get
			{
				return this._SelectedRow;
			}
			[DebuggerNonUserCode]
			set
			{
				this._SelectedRow = value;
			}
		}

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x06000A53 RID: 2643 RVA: 0x00085FA0 File Offset: 0x000841A0
		// (set) Token: 0x06000A54 RID: 2644 RVA: 0x00004016 File Offset: 0x00002216
		public long ExtraData
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ExtraData;
			}
			[DebuggerNonUserCode]
			set
			{
				this._ExtraData = value;
			}
		}

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x06000A55 RID: 2645 RVA: 0x00085FB8 File Offset: 0x000841B8
		// (set) Token: 0x06000A56 RID: 2646 RVA: 0x00004020 File Offset: 0x00002220
		public bool CanEdit
		{
			[DebuggerNonUserCode]
			get
			{
				return this._CanEdit;
			}
			[DebuggerNonUserCode]
			set
			{
				this._CanEdit = value;
			}
		}

		// Token: 0x17000326 RID: 806
		// (get) Token: 0x06000A57 RID: 2647 RVA: 0x00085FD0 File Offset: 0x000841D0
		// (set) Token: 0x06000A58 RID: 2648 RVA: 0x0000402A File Offset: 0x0000222A
		public bool CanDelete
		{
			[DebuggerNonUserCode]
			get
			{
				return this._CanDelete;
			}
			[DebuggerNonUserCode]
			set
			{
				this._CanDelete = value;
			}
		}

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x06000A59 RID: 2649 RVA: 0x00085FE8 File Offset: 0x000841E8
		// (set) Token: 0x06000A5A RID: 2650 RVA: 0x00004034 File Offset: 0x00002234
		public Form Edit_Frm
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Edit_Frm;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Edit_Frm = value;
			}
		}

		// Token: 0x17000328 RID: 808
		// (get) Token: 0x06000A5B RID: 2651 RVA: 0x00086000 File Offset: 0x00084200
		// (set) Token: 0x06000A5C RID: 2652 RVA: 0x0000403E File Offset: 0x0000223E
		private string Command
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Command;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Command = value;
			}
		}

		// Token: 0x17000329 RID: 809
		// (get) Token: 0x06000A5D RID: 2653 RVA: 0x00086018 File Offset: 0x00084218
		// (set) Token: 0x06000A5E RID: 2654 RVA: 0x00004048 File Offset: 0x00002248
		private Form Frm
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Frm;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Frm = value;
			}
		}

		// Token: 0x06000A5F RID: 2655 RVA: 0x00086030 File Offset: 0x00084230
		private void InitGrid(DataTable dt)
		{
			this.GridEX1.DataSource = dt;
			this.GridEX1.RetrieveStructure();
			try
			{
				IEnumerator enumerator = this.GridEX1.RootTable.Columns.GetEnumerator();
				while (enumerator.MoveNext())
				{
					GridEXColumn gridEXColumn = (GridEXColumn)enumerator.Current;
					gridEXColumn.Visible = false;
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
			int num = 0;
			checked
			{
				int num2 = this.GridEX1.Width - this.GridEX1.ScrollBarWidth - this.GridEX1.RootTable.RowHeaderWidth - 2;
				bool flag = this.CanEdit;
				if (flag)
				{
					num2 -= 24;
				}
				flag = this.CanDelete;
				if (flag)
				{
					num2 -= 24;
				}
				try
				{
					IEnumerator enumerator2 = this.items.GetEnumerator();
					while (enumerator2.MoveNext())
					{
						Column column = (Column)enumerator2.Current;
						this.GridEX1.RootTable.Columns[column.Name].Visible = true;
						this.GridEX1.RootTable.Columns[column.Name].Caption = column.Caption;
						this.GridEX1.RootTable.Columns[column.Name].Width = (int)Math.Round(unchecked((double)num2 / 100.0 * (double)column.Size));
						this.GridEX1.RootTable.Columns[column.Name].Position = num;
						num++;
					}
				}
				finally
				{
					IEnumerator enumerator2;
					flag = (enumerator2 is IDisposable);
					if (flag)
					{
						(enumerator2 as IDisposable).Dispose();
					}
				}
				flag = this.CanEdit;
				if (flag)
				{
					GridEXColumn gridEXColumn2 = new GridEXColumn();
					gridEXColumn2.Key = "edit";
					gridEXColumn2.BoundMode = ColumnBoundMode.Unbound;
					gridEXColumn2.ButtonDisplayMode = CellButtonDisplayMode.Always;
					gridEXColumn2.ButtonStyle = Janus.Windows.GridEX.ButtonStyle.Image;
					gridEXColumn2.ButtonImage = Resources.pencil;
					gridEXColumn2.Width = 24;
					this.GridEX1.RootTable.Columns.Add(gridEXColumn2);
				}
				flag = this.CanDelete;
				if (flag)
				{
					GridEXColumn gridEXColumn3 = new GridEXColumn();
					gridEXColumn3.Key = "del";
					gridEXColumn3.BoundMode = ColumnBoundMode.Unbound;
					gridEXColumn3.ButtonDisplayMode = CellButtonDisplayMode.Always;
					gridEXColumn3.ButtonStyle = Janus.Windows.GridEX.ButtonStyle.Image;
					gridEXColumn3.ButtonImage = Resources.delete;
					gridEXColumn3.Width = 24;
					this.GridEX1.RootTable.Columns.Add(gridEXColumn3);
				}
			}
		}

		// Token: 0x06000A60 RID: 2656 RVA: 0x00086300 File Offset: 0x00084500
		public DialogResult ShowDialog(string Command, Form frm = null, string text = "")
		{
			this.EditBox1.Text = string.Empty;
			this.Command = Command;
			bool flag = frm != null;
			if (flag)
			{
				this.Frm = frm;
				PropertyInfo property = frm.GetType().GetProperty("ExtraData", BindingFlags.Instance | BindingFlags.Public);
				flag = (property != null && property.CanWrite);
				if (flag)
				{
					property.SetValue(frm, this.ExtraData, null);
				}
				this.UiButton1.Visible = true;
			}
			else
			{
				this.UiButton1.Visible = false;
			}
			this.Text = text;
			return MyProject.Forms.Form_Main.Dialog_ShowForm(this);
		}

		// Token: 0x06000A61 RID: 2657 RVA: 0x000863B0 File Offset: 0x000845B0
		public DialogResult ShowDialog(DataTable dt, Form frm = null)
		{
			bool flag = frm != null;
			if (flag)
			{
				this.Frm = frm;
				PropertyInfo property = frm.GetType().GetProperty("ExtraData", BindingFlags.Instance | BindingFlags.Public);
				flag = (property != null && property.CanWrite);
				if (flag)
				{
					property.SetValue(frm, this.ExtraData, null);
				}
				this.UiButton1.Visible = true;
			}
			else
			{
				this.UiButton1.Visible = false;
			}
			this.InitGrid(dt);
			return MyProject.Forms.Form_Main.Dialog_ShowForm(this);
		}

		// Token: 0x06000A62 RID: 2658 RVA: 0x0000205D File Offset: 0x0000025D
		private void Frm_SelectItem_FormClosing(object sender, FormClosingEventArgs e)
		{
		}

		// Token: 0x06000A63 RID: 2659 RVA: 0x00086448 File Offset: 0x00084648
		private void Frm_SelectItem_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Insert && this.UiButton1.Visible;
			if (flag)
			{
				this.UiButton1_Click(null, null);
			}
			flag = (e.KeyCode == Keys.Escape);
			if (flag)
			{
				this.DialogResult = DialogResult.Cancel;
				this.Close();
			}
			flag = (e.KeyCode == Keys.F6 && this.CanEdit);
			if (flag)
			{
				this.Edit();
			}
		}

		// Token: 0x06000A64 RID: 2660 RVA: 0x000864C4 File Offset: 0x000846C4
		private void Edit()
		{
			bool flag = Operators.ConditionalCompareObjectLess(this.GridEX1.CurrentRow.Cells["id"].Value, 0, false);
			if (!flag)
			{
				PropertyInfo property = this.Edit_Frm.GetType().GetProperty("ID", BindingFlags.Instance | BindingFlags.Public);
				flag = (property != null && property.CanWrite);
				if (flag)
				{
					property.SetValue(this.Edit_Frm, RuntimeHelpers.GetObjectValue(this.GridEX1.CurrentRow.Cells["id"].Value), null);
				}
				this.Edit_Frm.ShowDialog();
				flag = (this.GridEX1.DataSource != null);
				if (flag)
				{
					bool flag2 = Operators.CompareString(this.EditBox1.Text, string.Empty, false) != 0;
					if (flag2)
					{
						DataTable dt = Public_Function.FillData(string.Format(this.Command, this.EditBox1.Text));
						this.InitGrid(dt);
					}
				}
				this.EditBox1.Focus();
			}
		}

		// Token: 0x06000A65 RID: 2661 RVA: 0x000865DC File Offset: 0x000847DC
		private void EditBox1_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			bool flag2;
			if (flag)
			{
				flag2 = (this.GridEX1.GetRows().Length > 0);
				if (flag2)
				{
					this.GridEX1.Focus();
					this.GridEX1.Row = 0;
				}
				else
				{
					this.DialogResult = DialogResult.OK;
					this.Close();
				}
			}
			flag2 = (e.KeyCode == Keys.Down);
			if (flag2)
			{
				this.GridEX1.Focus();
				flag2 = (this.GridEX1.GetRows().Length > 0);
				if (flag2)
				{
					this.GridEX1.Row = 0;
				}
			}
		}

		// Token: 0x06000A66 RID: 2662 RVA: 0x00086678 File Offset: 0x00084878
		private void EditBox1_TextChanged(object sender, EventArgs e)
		{
			bool flag = Operators.CompareString(this.EditBox1.Text, string.Empty, false) == 0;
			if (flag)
			{
				this.GridEX1.DataSource = null;
			}
			else
			{
				DataTable dt = Public_Function.FillData(string.Format(this.Command, this.EditBox1.Text));
				this.InitGrid(dt);
				MyProject.Forms.Form_Main.ApplyFont(this);
			}
		}

		// Token: 0x06000A67 RID: 2663 RVA: 0x000866EC File Offset: 0x000848EC
		private void Frm_SelectItem_Load(object sender, EventArgs e)
		{
			this.GridEX1.FocusCellFormatStyle.BackColor = this.GridEX1.SelectedFormatStyle.BackColor;
			this.EditBox1.Focus();
		}

		// Token: 0x06000A68 RID: 2664 RVA: 0x00086728 File Offset: 0x00084928
		private void GridEX1_ColumnButtonClick(object sender, ColumnActionEventArgs e)
		{
			bool flag = Operators.CompareString(e.Column.Key, "edit", false) == 0;
			if (flag)
			{
				this.Edit();
			}
		}

		// Token: 0x06000A69 RID: 2665 RVA: 0x0008675C File Offset: 0x0008495C
		private void GridEX1_GotFocus(object sender, EventArgs e)
		{
			bool flag = this.GridEX1.GetRow() != null;
			if (flag)
			{
				this.GridEX1.GetRow().BeginEdit();
			}
		}

		// Token: 0x06000A6A RID: 2666 RVA: 0x00086794 File Offset: 0x00084994
		private void GridEX1_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			bool flag2;
			if (flag)
			{
				flag2 = (this.GridEX1.CurrentRow != null);
				if (flag2)
				{
					this.GridEX1_RowDoubleClick(null, null);
				}
			}
			flag2 = (e.KeyCode == Keys.Escape);
			if (flag2)
			{
				this.DialogResult = DialogResult.Cancel;
				this.EditBox1.Focus();
				this.Close();
			}
			flag2 = (e.KeyCode == Keys.Up);
			if (flag2)
			{
				flag = (this.GridEX1.Row == 0);
				if (flag)
				{
					this.EditBox1.Focus();
				}
			}
		}

		// Token: 0x06000A6B RID: 2667 RVA: 0x0008682C File Offset: 0x00084A2C
		private void GridEX1_RowDoubleClick(object sender, RowActionEventArgs e)
		{
			this.DialogResult = DialogResult.OK;
			this.EditBox1.Focus();
			this.SelectedRow = ((DataTable)this.GridEX1.DataSource).Rows[this.GridEX1.Row];
			this.Close();
		}

		// Token: 0x06000A6C RID: 2668 RVA: 0x00086884 File Offset: 0x00084A84
		private void Invoke_New()
		{
			MethodInfo[] methods = this.Frm.GetType().GetMethods();
			MethodInfo[] array = methods;
			checked
			{
				for (int i = 0; i < array.Length; i++)
				{
					MethodInfo methodInfo = array[i];
					bool flag = Operators.CompareString(methodInfo.Name, "newfrm", false) == 0;
					if (flag)
					{
						this.Frm.GetType().InvokeMember("newfrm", BindingFlags.InvokeMethod, null, this.Frm, null);
						break;
					}
				}
			}
		}

		// Token: 0x06000A6D RID: 2669 RVA: 0x00086900 File Offset: 0x00084B00
		private void UiButton1_Click(object sender, EventArgs e)
		{
			this.Invoke_New();
			this.Frm.ShowDialog();
			bool flag = this.GridEX1.DataSource != null;
			if (flag)
			{
				DataTable dt = Public_Function.FillData(this.Command);
				this.InitGrid(dt);
			}
			this.EditBox1.Focus();
		}

		// Token: 0x0400040A RID: 1034
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x0400040C RID: 1036
		[AccessedThroughProperty("GridEX1")]
		private GridEX _GridEX1;

		// Token: 0x0400040D RID: 1037
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x0400040E RID: 1038
		[AccessedThroughProperty("EditBox1")]
		private EditBox _EditBox1;

		// Token: 0x0400040F RID: 1039
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04000410 RID: 1040
		[AccessedThroughProperty("UiButton1")]
		private UIButton _UiButton1;

		// Token: 0x04000411 RID: 1041
		[CompilerGenerated]
		private CollectionBase _items;

		// Token: 0x04000412 RID: 1042
		[CompilerGenerated]
		private DataRow _SelectedRow;

		// Token: 0x04000413 RID: 1043
		[CompilerGenerated]
		private long _ExtraData;

		// Token: 0x04000414 RID: 1044
		[CompilerGenerated]
		private bool _CanEdit;

		// Token: 0x04000415 RID: 1045
		[CompilerGenerated]
		private bool _CanDelete;

		// Token: 0x04000416 RID: 1046
		[CompilerGenerated]
		private Form _Edit_Frm;

		// Token: 0x04000417 RID: 1047
		[CompilerGenerated]
		private string _Command;

		// Token: 0x04000418 RID: 1048
		[CompilerGenerated]
		private Form _Frm;
	}
}
