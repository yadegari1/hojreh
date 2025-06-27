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
using Janus.Windows.UI;
using Janus.Windows.UI.Dock;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x0200013B RID: 315
	[DesignerGenerated]
	public partial class Frm_ShowItem : Form
	{
		// Token: 0x06002DBB RID: 11707 RVA: 0x0021E348 File Offset: 0x0021C548
		public Frm_ShowItem()
		{
			base.Activated += new EventHandler(this.Frm_SelectItem_Activated);
			base.FormClosing += new FormClosingEventHandler(this.Frm_SelectItem_FormClosing);
			base.KeyDown += new KeyEventHandler(this.Frm_SelectItem_KeyDown);
			base.Load += new EventHandler(this.Frm_SelectItem_Load);
			Frm_ShowItem.__ENCAddToList(this);
			bool flag = false;
			this.CanEdit = flag;
			flag = false;
			this.AllowEnterToClose = flag;
			flag = false;
			this.CanDelete = flag;
			this.InitializeComponent();
		}

		// Token: 0x06002DBC RID: 11708 RVA: 0x0021E3DC File Offset: 0x0021C5DC
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_ShowItem.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_ShowItem.__ENCList.Count == Frm_ShowItem.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_ShowItem.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_ShowItem.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_ShowItem.__ENCList[num] = Frm_ShowItem.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_ShowItem.__ENCList.RemoveRange(num, Frm_ShowItem.__ENCList.Count - num);
						Frm_ShowItem.__ENCList.Capacity = Frm_ShowItem.__ENCList.Count;
					}
					Frm_ShowItem.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000DE7 RID: 3559
		// (get) Token: 0x06002DBF RID: 11711 RVA: 0x0021EA78 File Offset: 0x0021CC78
		// (set) Token: 0x06002DC0 RID: 11712 RVA: 0x0021EA90 File Offset: 0x0021CC90
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

		// Token: 0x17000DE8 RID: 3560
		// (get) Token: 0x06002DC1 RID: 11713 RVA: 0x0021EB6C File Offset: 0x0021CD6C
		// (set) Token: 0x06002DC2 RID: 11714 RVA: 0x0000B966 File Offset: 0x00009B66
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

		// Token: 0x17000DE9 RID: 3561
		// (get) Token: 0x06002DC3 RID: 11715 RVA: 0x0021EB84 File Offset: 0x0021CD84
		// (set) Token: 0x06002DC4 RID: 11716 RVA: 0x0000B970 File Offset: 0x00009B70
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

		// Token: 0x17000DEA RID: 3562
		// (get) Token: 0x06002DC5 RID: 11717 RVA: 0x0021EB9C File Offset: 0x0021CD9C
		// (set) Token: 0x06002DC6 RID: 11718 RVA: 0x0021EBB4 File Offset: 0x0021CDB4
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

		// Token: 0x17000DEB RID: 3563
		// (get) Token: 0x06002DC7 RID: 11719 RVA: 0x0021EC14 File Offset: 0x0021CE14
		// (set) Token: 0x06002DC8 RID: 11720 RVA: 0x0021EC2C File Offset: 0x0021CE2C
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
				KeyEventHandler value2 = new KeyEventHandler(this.EditBox1_KeyDown);
				EventHandler value3 = new EventHandler(this.EditBox1_TextChanged);
				bool flag = this._EditBox1 != null;
				if (flag)
				{
					this._EditBox1.KeyDown -= value2;
					this._EditBox1.TextChanged -= value3;
				}
				this._EditBox1 = value;
				flag = (this._EditBox1 != null);
				if (flag)
				{
					this._EditBox1.KeyDown += value2;
					this._EditBox1.TextChanged += value3;
				}
			}
		}

		// Token: 0x17000DEC RID: 3564
		// (get) Token: 0x06002DC9 RID: 11721 RVA: 0x0021ECB4 File Offset: 0x0021CEB4
		// (set) Token: 0x06002DCA RID: 11722 RVA: 0x0000B97A File Offset: 0x00009B7A
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

		// Token: 0x17000DED RID: 3565
		// (get) Token: 0x06002DCB RID: 11723 RVA: 0x0021ECCC File Offset: 0x0021CECC
		// (set) Token: 0x06002DCC RID: 11724 RVA: 0x0000B984 File Offset: 0x00009B84
		public DataRowView SelectedRow
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

		// Token: 0x17000DEE RID: 3566
		// (get) Token: 0x06002DCD RID: 11725 RVA: 0x0021ECE4 File Offset: 0x0021CEE4
		// (set) Token: 0x06002DCE RID: 11726 RVA: 0x0000B98E File Offset: 0x00009B8E
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

		// Token: 0x17000DEF RID: 3567
		// (get) Token: 0x06002DCF RID: 11727 RVA: 0x0021ECFC File Offset: 0x0021CEFC
		// (set) Token: 0x06002DD0 RID: 11728 RVA: 0x0000B998 File Offset: 0x00009B98
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

		// Token: 0x17000DF0 RID: 3568
		// (get) Token: 0x06002DD1 RID: 11729 RVA: 0x0021ED14 File Offset: 0x0021CF14
		// (set) Token: 0x06002DD2 RID: 11730 RVA: 0x0000B9A2 File Offset: 0x00009BA2
		public bool AllowEnterToClose
		{
			[DebuggerNonUserCode]
			get
			{
				return this._AllowEnterToClose;
			}
			[DebuggerNonUserCode]
			set
			{
				this._AllowEnterToClose = value;
			}
		}

		// Token: 0x17000DF1 RID: 3569
		// (get) Token: 0x06002DD3 RID: 11731 RVA: 0x0021ED2C File Offset: 0x0021CF2C
		// (set) Token: 0x06002DD4 RID: 11732 RVA: 0x0000B9AC File Offset: 0x00009BAC
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

		// Token: 0x17000DF2 RID: 3570
		// (get) Token: 0x06002DD5 RID: 11733 RVA: 0x0021ED44 File Offset: 0x0021CF44
		// (set) Token: 0x06002DD6 RID: 11734 RVA: 0x0000B9B6 File Offset: 0x00009BB6
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

		// Token: 0x17000DF3 RID: 3571
		// (get) Token: 0x06002DD7 RID: 11735 RVA: 0x0021ED5C File Offset: 0x0021CF5C
		// (set) Token: 0x06002DD8 RID: 11736 RVA: 0x0000B9C0 File Offset: 0x00009BC0
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

		// Token: 0x17000DF4 RID: 3572
		// (get) Token: 0x06002DD9 RID: 11737 RVA: 0x0021ED74 File Offset: 0x0021CF74
		// (set) Token: 0x06002DDA RID: 11738 RVA: 0x0000B9CA File Offset: 0x00009BCA
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

		// Token: 0x06002DDB RID: 11739 RVA: 0x0021ED8C File Offset: 0x0021CF8C
		private void InitGrid(DataTable dt)
		{
			string text = string.Empty;
			DataColumn dataColumn = new DataColumn("filter", typeof(string));
			bool flag = !dt.Columns.Contains("filter");
			if (flag)
			{
				dt.Columns.Add(dataColumn);
			}
			this.GridEX1.DataSource = dt.DefaultView;
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
				flag = (enumerator is IDisposable);
				if (flag)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			int num = 0;
			checked
			{
				int num2 = this.GridEX1.Width - this.GridEX1.ScrollBarWidth - this.GridEX1.RootTable.RowHeaderWidth - 2;
				flag = this.CanEdit;
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
						flag = !this.GridEX1.RootTable.Columns.Contains(column.Name);
						if (!flag)
						{
							this.GridEX1.RootTable.Columns[column.Name].Visible = true;
							this.GridEX1.RootTable.Columns[column.Name].Caption = column.Caption;
							this.GridEX1.RootTable.Columns[column.Name].Width = (int)Math.Round(unchecked((double)num2 / 100.0 * (double)column.Size));
							this.GridEX1.RootTable.Columns[column.Name].Position = num;
							this.GridEX1.RootTable.Columns[column.Name].FormatString = "N0";
							flag = (Operators.CompareString(column.Name.ToLower(), "mablagh", false) == 0);
							if (flag)
							{
								this.GridEX1.RootTable.Columns[column.Name].AggregateFunction = AggregateFunction.Sum;
								this.GridEX1.RootTable.Columns[column.Name].TotalFormatString = "N0";
							}
							num++;
							text = text + column.Name + "+";
						}
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
				text = Public_Function.RemoveLast(text);
				dataColumn.Expression = text;
				flag = this.CanEdit;
				if (flag)
				{
					this.Text = "ویرایش اطلاعات = (F6)";
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
				this.EditBox1.Focus();
			}
		}

		// Token: 0x06002DDC RID: 11740 RVA: 0x0021F1B8 File Offset: 0x0021D3B8
		public DialogResult ShowDialog(string Command, Form frm = null, int width = 0)
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
			DataTable dt = Public_Function.FillData(Command);
			flag = (width != 0);
			if (flag)
			{
				this.Width = width;
			}
			this.InitGrid(dt);
			return base.ShowDialog();
		}

		// Token: 0x06002DDD RID: 11741 RVA: 0x0021F27C File Offset: 0x0021D47C
		public DialogResult ShowDialog(DataTable dt, Form frm = null, int width = 0)
		{
			this.EditBox1.Text = string.Empty;
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
			flag = (width != 0);
			if (flag)
			{
				this.Width = width;
			}
			this.InitGrid(dt);
			return base.ShowDialog();
		}

		// Token: 0x06002DDE RID: 11742 RVA: 0x0000B9D4 File Offset: 0x00009BD4
		private void Frm_SelectItem_Activated(object sender, EventArgs e)
		{
			this.EditBox1.Focus();
		}

		// Token: 0x06002DDF RID: 11743 RVA: 0x0000205D File Offset: 0x0000025D
		private void Frm_SelectItem_FormClosing(object sender, FormClosingEventArgs e)
		{
		}

		// Token: 0x06002DE0 RID: 11744 RVA: 0x0021F330 File Offset: 0x0021D530
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

		// Token: 0x06002DE1 RID: 11745 RVA: 0x0021F3AC File Offset: 0x0021D5AC
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
					flag2 = this.AllowEnterToClose;
					if (flag2)
					{
						this.DialogResult = DialogResult.OK;
						this.Close();
					}
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

		// Token: 0x06002DE2 RID: 11746 RVA: 0x0021F454 File Offset: 0x0021D654
		private void EditBox1_TextChanged(object sender, EventArgs e)
		{
			DataView dataView = (DataView)this.GridEX1.DataSource;
			bool flag = Operators.CompareString(this.EditBox1.Text, string.Empty, false) == 0;
			if (flag)
			{
				dataView.RowFilter = "";
			}
			else
			{
				dataView.RowFilter = "filter LIKE '%" + this.EditBox1.Text + "%'";
				this.GridEX1.Refetch();
				Public_Function.HighlightCell(this.GridEX1, this.EditBox1.Text);
			}
		}

		// Token: 0x06002DE3 RID: 11747 RVA: 0x0021F4E8 File Offset: 0x0021D6E8
		private void Frm_SelectItem_Load(object sender, EventArgs e)
		{
			MyProject.Forms.Form_Main.ApplyTheme(this);
			MyProject.Forms.Form_Main.ApplyFont(this);
			this.GridEX1.FocusCellFormatStyle.BackColor = this.GridEX1.SelectedFormatStyle.BackColor;
			this.EditBox1.Focus();
		}

		// Token: 0x06002DE4 RID: 11748 RVA: 0x0021F548 File Offset: 0x0021D748
		private void Edit()
		{
			bool flag = this.GridEX1.CurrentRow == null;
			if (!flag)
			{
				flag = Operators.ConditionalCompareObjectLess(this.GridEX1.CurrentRow.Cells["id"].Value, 0, false);
				if (!flag)
				{
					PropertyInfo property = this.Edit_Frm.GetType().GetProperty("ID", BindingFlags.Instance | BindingFlags.Public);
					flag = (property != null && property.CanWrite);
					if (flag)
					{
						property.SetValue(this.Edit_Frm, RuntimeHelpers.GetObjectValue(this.GridEX1.CurrentRow.Cells["id"].Value), null);
					}
					MyProject.Forms.Form_Main.Dialog_ShowForm(this.Edit_Frm);
					flag = (this.GridEX1.DataSource != null);
					if (flag)
					{
						DataTable dt = Public_Function.FillData(this.Command);
						this.InitGrid(dt);
					}
					this.EditBox1.Focus();
				}
			}
		}

		// Token: 0x06002DE5 RID: 11749 RVA: 0x0021F654 File Offset: 0x0021D854
		private void GridEX1_ColumnButtonClick(object sender, ColumnActionEventArgs e)
		{
			bool flag = Operators.CompareString(e.Column.Key, "edit", false) == 0;
			if (flag)
			{
				this.Edit();
			}
		}

		// Token: 0x06002DE6 RID: 11750 RVA: 0x0021F688 File Offset: 0x0021D888
		private void GridEX1_GotFocus(object sender, EventArgs e)
		{
			bool flag = this.GridEX1.GetRow() != null;
			if (flag)
			{
				this.GridEX1.GetRow().BeginEdit();
			}
		}

		// Token: 0x06002DE7 RID: 11751 RVA: 0x0021F6C0 File Offset: 0x0021D8C0
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

		// Token: 0x06002DE8 RID: 11752 RVA: 0x0021F758 File Offset: 0x0021D958
		private void GridEX1_RowDoubleClick(object sender, RowActionEventArgs e)
		{
			this.DialogResult = DialogResult.OK;
			this.EditBox1.Focus();
			this.SelectedRow = ((DataView)this.GridEX1.DataSource)[this.GridEX1.Row];
			this.Close();
		}

		// Token: 0x06002DE9 RID: 11753 RVA: 0x0021F7AC File Offset: 0x0021D9AC
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

		// Token: 0x06002DEA RID: 11754 RVA: 0x0021F828 File Offset: 0x0021DA28
		private void UiButton1_Click(object sender, EventArgs e)
		{
			this.Invoke_New();
			MyProject.Forms.Form_Main.Dialog_ShowForm(this.Frm);
			bool flag = this.GridEX1.DataSource != null;
			if (flag)
			{
				DataTable dt = Public_Function.FillData(this.Command);
				this.InitGrid(dt);
			}
			this.EditBox1.Focus();
		}

		// Token: 0x040011C2 RID: 4546
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x040011C4 RID: 4548
		[AccessedThroughProperty("GridEX1")]
		private GridEX _GridEX1;

		// Token: 0x040011C5 RID: 4549
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x040011C6 RID: 4550
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x040011C7 RID: 4551
		[AccessedThroughProperty("UiButton1")]
		private UIButton _UiButton1;

		// Token: 0x040011C8 RID: 4552
		[AccessedThroughProperty("EditBox1")]
		private EditBox _EditBox1;

		// Token: 0x040011C9 RID: 4553
		[CompilerGenerated]
		private CollectionBase _items;

		// Token: 0x040011CA RID: 4554
		[CompilerGenerated]
		private DataRowView _SelectedRow;

		// Token: 0x040011CB RID: 4555
		[CompilerGenerated]
		private long _ExtraData;

		// Token: 0x040011CC RID: 4556
		[CompilerGenerated]
		private bool _CanEdit;

		// Token: 0x040011CD RID: 4557
		[CompilerGenerated]
		private bool _AllowEnterToClose;

		// Token: 0x040011CE RID: 4558
		[CompilerGenerated]
		private bool _CanDelete;

		// Token: 0x040011CF RID: 4559
		[CompilerGenerated]
		private Form _Edit_Frm;

		// Token: 0x040011D0 RID: 4560
		[CompilerGenerated]
		private string _Command;

		// Token: 0x040011D1 RID: 4561
		[CompilerGenerated]
		private Form _Frm;
	}
}
