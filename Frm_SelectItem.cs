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
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x0200007A RID: 122
	[DesignerGenerated]
	public partial class Frm_SelectItem : Form
	{
		// Token: 0x06000A08 RID: 2568 RVA: 0x000834C8 File Offset: 0x000816C8
		public Frm_SelectItem()
		{
			base.Activated += new EventHandler(this.Frm_SelectItem_Activated);
			base.FormClosing += new FormClosingEventHandler(this.Frm_SelectItem_FormClosing);
			base.KeyDown += new KeyEventHandler(this.Frm_SelectItem_KeyDown);
			base.Load += new EventHandler(this.Frm_SelectItem_Load);
			Frm_SelectItem.__ENCAddToList(this);
			this.frm_size = new Frm_Size();
			this.grid_size = new Grid_Size();
			bool flag = false;
			this.CanEdit = flag;
			flag = false;
			this.AllowEnterToClose = flag;
			flag = false;
			this.CanDelete = flag;
			this.InitializeComponent();
		}

		// Token: 0x06000A09 RID: 2569 RVA: 0x00083570 File Offset: 0x00081770
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_SelectItem.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_SelectItem.__ENCList.Count == Frm_SelectItem.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_SelectItem.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_SelectItem.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_SelectItem.__ENCList[num] = Frm_SelectItem.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_SelectItem.__ENCList.RemoveRange(num, Frm_SelectItem.__ENCList.Count - num);
						Frm_SelectItem.__ENCList.Capacity = Frm_SelectItem.__ENCList.Count;
					}
					Frm_SelectItem.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x06000A0C RID: 2572 RVA: 0x00083C30 File Offset: 0x00081E30
		// (set) Token: 0x06000A0D RID: 2573 RVA: 0x00083C48 File Offset: 0x00081E48
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
				ColumnActionEventHandler value2 = new ColumnActionEventHandler(this.GridEX1_ColumnButtonClick);
				KeyPressEventHandler value3 = new KeyPressEventHandler(this.GridEX1_KeyPress);
				RowActionEventHandler value4 = new RowActionEventHandler(this.GridEX1_RowDoubleClick);
				KeyEventHandler value5 = new KeyEventHandler(this.GridEX1_KeyDown);
				EventHandler value6 = new EventHandler(this.GridEX1_GotFocus);
				bool flag = this._GridEX1 != null;
				if (flag)
				{
					this._GridEX1.ColumnButtonClick -= value2;
					this._GridEX1.KeyPress -= value3;
					this._GridEX1.RowDoubleClick -= value4;
					this._GridEX1.KeyDown -= value5;
					this._GridEX1.GotFocus -= value6;
				}
				this._GridEX1 = value;
				flag = (this._GridEX1 != null);
				if (flag)
				{
					this._GridEX1.ColumnButtonClick += value2;
					this._GridEX1.KeyPress += value3;
					this._GridEX1.RowDoubleClick += value4;
					this._GridEX1.KeyDown += value5;
					this._GridEX1.GotFocus += value6;
				}
			}
		}

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06000A0E RID: 2574 RVA: 0x00083D50 File Offset: 0x00081F50
		// (set) Token: 0x06000A0F RID: 2575 RVA: 0x00003F59 File Offset: 0x00002159
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

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x06000A10 RID: 2576 RVA: 0x00083D68 File Offset: 0x00081F68
		// (set) Token: 0x06000A11 RID: 2577 RVA: 0x00003F63 File Offset: 0x00002163
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

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x06000A12 RID: 2578 RVA: 0x00083D80 File Offset: 0x00081F80
		// (set) Token: 0x06000A13 RID: 2579 RVA: 0x00083D98 File Offset: 0x00081F98
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

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x06000A14 RID: 2580 RVA: 0x00083DF8 File Offset: 0x00081FF8
		// (set) Token: 0x06000A15 RID: 2581 RVA: 0x00083E10 File Offset: 0x00082010
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

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x06000A16 RID: 2582 RVA: 0x00083E98 File Offset: 0x00082098
		// (set) Token: 0x06000A17 RID: 2583 RVA: 0x00003F6D File Offset: 0x0000216D
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

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x06000A18 RID: 2584 RVA: 0x00083EB0 File Offset: 0x000820B0
		// (set) Token: 0x06000A19 RID: 2585 RVA: 0x00003F77 File Offset: 0x00002177
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

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x06000A1A RID: 2586 RVA: 0x00083EC8 File Offset: 0x000820C8
		// (set) Token: 0x06000A1B RID: 2587 RVA: 0x00003F81 File Offset: 0x00002181
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

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x06000A1C RID: 2588 RVA: 0x00083EE0 File Offset: 0x000820E0
		// (set) Token: 0x06000A1D RID: 2589 RVA: 0x00003F8B File Offset: 0x0000218B
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

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x06000A1E RID: 2590 RVA: 0x00083EF8 File Offset: 0x000820F8
		// (set) Token: 0x06000A1F RID: 2591 RVA: 0x00003F95 File Offset: 0x00002195
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

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x06000A20 RID: 2592 RVA: 0x00083F10 File Offset: 0x00082110
		// (set) Token: 0x06000A21 RID: 2593 RVA: 0x00003F9F File Offset: 0x0000219F
		public char chara
		{
			[DebuggerNonUserCode]
			get
			{
				return this._chara;
			}
			[DebuggerNonUserCode]
			set
			{
				this._chara = value;
			}
		}

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x06000A22 RID: 2594 RVA: 0x00083F28 File Offset: 0x00082128
		// (set) Token: 0x06000A23 RID: 2595 RVA: 0x00003FA9 File Offset: 0x000021A9
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

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x06000A24 RID: 2596 RVA: 0x00083F40 File Offset: 0x00082140
		// (set) Token: 0x06000A25 RID: 2597 RVA: 0x00003FB3 File Offset: 0x000021B3
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

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x06000A26 RID: 2598 RVA: 0x00083F58 File Offset: 0x00082158
		// (set) Token: 0x06000A27 RID: 2599 RVA: 0x00003FBD File Offset: 0x000021BD
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

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x06000A28 RID: 2600 RVA: 0x00083F70 File Offset: 0x00082170
		// (set) Token: 0x06000A29 RID: 2601 RVA: 0x00003FC7 File Offset: 0x000021C7
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

		// Token: 0x06000A2A RID: 2602 RVA: 0x00083F88 File Offset: 0x00082188
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
							flag = !dt.Columns[column.Name].DataType.Equals(typeof(decimal));
							if (flag)
							{
								this.GridEX1.RootTable.Columns[column.Name].FormatString = "N0";
							}
							else
							{
								this.GridEX1.RootTable.Columns[column.Name].FormatString = "G29";
							}
							num++;
							text = text + "ISNULL(" + column.Name + ",'' ) +";
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
				bool flag2;
				if (flag)
				{
					flag2 = (Operators.CompareString(this.Text, string.Empty, false) == 0);
					if (flag2)
					{
						this.Text = "ویرایش اطلاعات = (F6)";
					}
					else
					{
						flag2 = !this.Text.Contains("ویرایش اطلاعات = (F6)");
						if (flag2)
						{
							this.Text += " - ویرایش اطلاعات = (F6)";
						}
					}
					GridEXColumn gridEXColumn2 = new GridEXColumn();
					gridEXColumn2.Key = "edit";
					gridEXColumn2.BoundMode = ColumnBoundMode.Unbound;
					gridEXColumn2.ButtonDisplayMode = CellButtonDisplayMode.Always;
					gridEXColumn2.ButtonStyle = Janus.Windows.GridEX.ButtonStyle.Image;
					gridEXColumn2.ButtonImage = Resources.pencil;
					gridEXColumn2.Width = 24;
					this.GridEX1.RootTable.Columns.Add(gridEXColumn2);
				}
				flag2 = this.CanDelete;
				if (flag2)
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

		// Token: 0x06000A2B RID: 2603 RVA: 0x000843FC File Offset: 0x000825FC
		private void UpdateGridSize(Control ParentControl)
		{
			try
			{
				IEnumerator enumerator = ParentControl.Controls.GetEnumerator();
				while (enumerator.MoveNext())
				{
					Control control = (Control)enumerator.Current;
					bool flag = control is GridEX;
					bool flag2;
					if (flag)
					{
						flag2 = (((GridEX)control).ParentForm is Frm_SelectItem);
						if (flag2)
						{
							this.grid_size.Update(((GridEX)control).ParentForm.Text, control.Name, ((GridEX)control).RootTable.Columns);
						}
						else
						{
							this.grid_size.Update(((GridEX)control).ParentForm.Name, control.Name, ((GridEX)control).RootTable.Columns);
						}
					}
					flag2 = (control.Controls.Count > 0);
					if (flag2)
					{
						this.UpdateGridSize(control);
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
		}

		// Token: 0x06000A2C RID: 2604 RVA: 0x00084510 File Offset: 0x00082710
		private void FormDialog_Closing(object sender, FormClosingEventArgs e)
		{
			Form form = (Form)sender;
			bool flag = form is Frm_SelectItem;
			if (flag)
			{
				this.frm_size.Update(form.Text, form.Location, form.Size);
			}
			else
			{
				this.frm_size.Update(form.Name, form.Location, form.Size);
			}
			this.UpdateGridSize(form);
			flag = (form is Frm_SelectItem);
			DataRow[] array;
			if (flag)
			{
				array = Public_Function.Dt_FrmSize.Select("Name='" + form.Text + "'");
			}
			else
			{
				array = Public_Function.Dt_FrmSize.Select("Name='" + form.Name + "'");
			}
			flag = (array.Length == 0);
			if (flag)
			{
				bool flag2 = form is Frm_SelectItem;
				if (flag2)
				{
					Public_Function.Dt_FrmSize.Rows.Add(new object[]
					{
						0,
						form.Text,
						form.Top,
						form.Left,
						form.Width,
						form.Height
					});
				}
				else
				{
					Public_Function.Dt_FrmSize.Rows.Add(new object[]
					{
						0,
						form.Name,
						form.Top,
						form.Left,
						form.Width,
						form.Height
					});
				}
			}
			else
			{
				array[0]["top"] = form.Top;
				array[0]["left"] = form.Left;
				array[0]["width"] = form.Width;
				array[0]["height"] = form.Height;
			}
		}

		// Token: 0x06000A2D RID: 2605 RVA: 0x00084724 File Offset: 0x00082924
		public void ApplyFont(Control frm)
		{
			string left = Public_Function.dict["textfont"].ToString().Split(new char[]
			{
				';'
			})[2];
			bool flag = Operators.CompareString(left, "regular", false) == 0;
			int style;
			if (flag)
			{
				style = 0;
			}
			else
			{
				flag = (Operators.CompareString(left, "bold", false) == 0);
				if (flag)
				{
					style = 1;
				}
				else
				{
					flag = (Operators.CompareString(left, "italic", false) == 0);
					if (flag)
					{
						style = 2;
					}
				}
			}
			try
			{
				IEnumerator enumerator = frm.Controls.GetEnumerator();
				while (enumerator.MoveNext())
				{
					Control control = (Control)enumerator.Current;
					flag = (control is NavBox);
					if (flag)
					{
						((NavBox)control).NumericBox1.Font = new Font(Public_Function.dict["textfont"].ToString().Split(new char[]
						{
							';'
						})[0], Conversions.ToSingle(Public_Function.dict["textfont"].ToString().Split(new char[]
						{
							';'
						})[1]), (FontStyle)style, GraphicsUnit.Point);
					}
					flag = (control is SelectItem);
					if (flag)
					{
						((SelectItem)control).Font = new Font(Public_Function.dict["textfont"].ToString().Split(new char[]
						{
							';'
						})[0], Conversions.ToSingle(Public_Function.dict["textfont"].ToString().Split(new char[]
						{
							';'
						})[1]), (FontStyle)style, GraphicsUnit.Point);
					}
					flag = (control is EditBox);
					if (flag)
					{
						((EditBox)control).Font = new Font(Public_Function.dict["textfont"].ToString().Split(new char[]
						{
							';'
						})[0], Conversions.ToSingle(Public_Function.dict["textfont"].ToString().Split(new char[]
						{
							';'
						})[1]), (FontStyle)style, GraphicsUnit.Point);
					}
					flag = (control is DateBox2);
					if (flag)
					{
						((DateBox2)control).Font = new Font(Public_Function.dict["textfont"].ToString().Split(new char[]
						{
							';'
						})[0], Conversions.ToSingle(Public_Function.dict["textfont"].ToString().Split(new char[]
						{
							';'
						})[1]), (FontStyle)style, GraphicsUnit.Point);
					}
					flag = (control is GridEX);
					if (flag)
					{
						((GridEX)control).Font = new Font(Public_Function.dict["gridfont"].ToString().Split(new char[]
						{
							';'
						})[0], Conversions.ToSingle(Public_Function.dict["gridfont"].ToString().Split(new char[]
						{
							';'
						})[1]), (FontStyle)style, GraphicsUnit.Point);
						int cellAscent = ((GridEX)control).Font.FontFamily.GetCellAscent(FontStyle.Regular);
						decimal d = new decimal(this.Font.Size * (float)cellAscent / (float)((GridEX)control).Font.FontFamily.GetEmHeight(FontStyle.Regular));
						int cellDescent = ((GridEX)control).Font.FontFamily.GetCellDescent(FontStyle.Regular);
						decimal d2 = new decimal(this.Font.Size * (float)cellDescent / (float)((GridEX)control).Font.FontFamily.GetEmHeight(FontStyle.Regular));
						int lineSpacing = ((GridEX)control).Font.FontFamily.GetLineSpacing(FontStyle.Regular);
						decimal d3 = new decimal(this.Font.Size * (float)lineSpacing / (float)((GridEX)control).Font.FontFamily.GetEmHeight(FontStyle.Regular));
						flag = (decimal.Compare(new decimal(((GridEX)control).RootTable.RowHeight), decimal.Add(decimal.Add(decimal.Add(decimal.Add(decimal.Add(d, d2), d2), d2), d3), new decimal(2L))) < 0);
						if (flag)
						{
							((GridEX)control).RootTable.RowHeight = Convert.ToInt32(decimal.Add(decimal.Add(decimal.Add(decimal.Add(decimal.Add(d, d2), d2), d2), d3), new decimal(2L)));
						}
					}
					flag = (frm.Controls.Count > 0);
					if (flag)
					{
						this.ApplyFont(control);
					}
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
		}

		// Token: 0x06000A2E RID: 2606 RVA: 0x00084C24 File Offset: 0x00082E24
		private void UpdateColumnSize(Control Parentcontrol)
		{
			try
			{
				IEnumerator enumerator = Parentcontrol.Controls.GetEnumerator();
				while (enumerator.MoveNext())
				{
					Control control = (Control)enumerator.Current;
					bool flag = control is GridEX;
					bool flag2;
					if (flag)
					{
						flag2 = (((GridEX)control).ParentForm is Frm_SelectItem);
						DataTable byName;
						if (flag2)
						{
							byName = this.grid_size.GetByName(((GridEX)control).ParentForm.Text, ((GridEX)control).Name);
						}
						else
						{
							byName = this.grid_size.GetByName(((GridEX)control).ParentForm.Name, ((GridEX)control).Name);
						}
						try
						{
							IEnumerator enumerator2 = byName.Rows.GetEnumerator();
							while (enumerator2.MoveNext())
							{
								DataRow dataRow = (DataRow)enumerator2.Current;
								flag2 = ((GridEX)control).RootTable.Columns.Contains(dataRow["key"].ToString());
								if (flag2)
								{
									((GridEX)control).RootTable.Columns[dataRow["key"].ToString()].Width = Conversions.ToInteger(dataRow["width"]);
								}
							}
						}
						finally
						{
							IEnumerator enumerator2;
							flag2 = (enumerator2 is IDisposable);
							if (flag2)
							{
								(enumerator2 as IDisposable).Dispose();
							}
						}
					}
					flag2 = (control.Controls.Count > 0);
					if (flag2)
					{
						this.UpdateColumnSize(control);
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
		}

		// Token: 0x06000A2F RID: 2607 RVA: 0x00084E0C File Offset: 0x0008300C
		private void Form_Load(object sender, EventArgs e)
		{
			this.UpdateColumnSize((Control)sender);
			this.ApplyFont((Control)sender);
			bool flag = Conversions.ToDouble(Public_Function.dict["theme"]) != -1.0;
			if (flag)
			{
				MyProject.Forms.Form_Main.ApplyTheme((Control)sender);
			}
			else
			{
				MyProject.Forms.Form_Main.ApplyTheme((Control)sender);
			}
		}

		// Token: 0x06000A30 RID: 2608 RVA: 0x00084E8C File Offset: 0x0008308C
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
			return MyProject.Forms.Form_Main.Dialog_ShowForm(this);
		}

		// Token: 0x06000A31 RID: 2609 RVA: 0x00084F58 File Offset: 0x00083158
		public DialogResult ShowDialog(DataTable dt, Form frm = null, string Text = "")
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
			this.Text = Text;
			this.InitGrid(dt);
			this.Command = string.Empty;
			return MyProject.Forms.Form_Main.Dialog_ShowForm(this);
		}

		// Token: 0x06000A32 RID: 2610 RVA: 0x00003FD1 File Offset: 0x000021D1
		private void Frm_SelectItem_Activated(object sender, EventArgs e)
		{
			this.EditBox1.Focus();
		}

		// Token: 0x06000A33 RID: 2611 RVA: 0x0000205D File Offset: 0x0000025D
		private void Frm_SelectItem_FormClosing(object sender, FormClosingEventArgs e)
		{
		}

		// Token: 0x06000A34 RID: 2612 RVA: 0x00085014 File Offset: 0x00083214
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

		// Token: 0x06000A35 RID: 2613 RVA: 0x00085090 File Offset: 0x00083290
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

		// Token: 0x06000A36 RID: 2614 RVA: 0x00085138 File Offset: 0x00083338
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

		// Token: 0x06000A37 RID: 2615 RVA: 0x000851CC File Offset: 0x000833CC
		private void Frm_SelectItem_Load(object sender, EventArgs e)
		{
			MyProject.Forms.Form_Main.ApplyTheme(this);
			MyProject.Forms.Form_Main.ApplyFont(this);
			this.GridEX1.FocusCellFormatStyle.BackColor = this.GridEX1.SelectedFormatStyle.BackColor;
			this.EditBox1.Focus();
			bool flag = this.chara.ToString().Length > 0 && Strings.Asc(this.chara) != 0;
			if (flag)
			{
				this.EditBox1.Text = Conversions.ToString(this.chara);
				this.EditBox1.SelectionStart = 1;
				this.EditBox1_TextChanged(null, null);
			}
		}

		// Token: 0x06000A38 RID: 2616 RVA: 0x00085288 File Offset: 0x00083488
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
						bool flag2 = Operators.CompareString(this.Command, string.Empty, false) != 0;
						if (flag2)
						{
							DataTable dt = Public_Function.FillData(this.Command);
							this.InitGrid(dt);
						}
					}
					this.EditBox1.Focus();
				}
			}
		}

		// Token: 0x06000A39 RID: 2617 RVA: 0x000853B0 File Offset: 0x000835B0
		private void GridEX1_ColumnButtonClick(object sender, ColumnActionEventArgs e)
		{
			bool flag = Operators.CompareString(e.Column.Key, "edit", false) == 0;
			if (flag)
			{
				this.Edit();
			}
		}

		// Token: 0x06000A3A RID: 2618 RVA: 0x000853E4 File Offset: 0x000835E4
		private void GridEX1_GotFocus(object sender, EventArgs e)
		{
			bool flag = this.GridEX1.GetRow() != null;
			if (flag)
			{
				this.GridEX1.GetRow().BeginEdit();
			}
		}

		// Token: 0x06000A3B RID: 2619 RVA: 0x0008541C File Offset: 0x0008361C
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

		// Token: 0x06000A3C RID: 2620 RVA: 0x000854B4 File Offset: 0x000836B4
		private void GridEX1_KeyPress(object sender, KeyPressEventArgs e)
		{
			bool flag = char.IsLetter(e.KeyChar) || char.IsDigit(e.KeyChar);
			if (flag)
			{
				this.EditBox1.Focus();
				EditBox editBox = this.EditBox1;
				editBox.Text += Conversions.ToString(e.KeyChar);
				this.EditBox1.SelectionStart = this.EditBox1.Text.Length;
			}
		}

		// Token: 0x06000A3D RID: 2621 RVA: 0x00085534 File Offset: 0x00083734
		private void GridEX1_RowDoubleClick(object sender, RowActionEventArgs e)
		{
			this.DialogResult = DialogResult.OK;
			this.EditBox1.Focus();
			this.SelectedRow = ((DataView)this.GridEX1.DataSource)[this.GridEX1.Row];
			this.Close();
		}

		// Token: 0x06000A3E RID: 2622 RVA: 0x00085588 File Offset: 0x00083788
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

		// Token: 0x06000A3F RID: 2623 RVA: 0x00085604 File Offset: 0x00083804
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

		// Token: 0x040003F7 RID: 1015
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x040003F9 RID: 1017
		[AccessedThroughProperty("GridEX1")]
		private GridEX _GridEX1;

		// Token: 0x040003FA RID: 1018
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x040003FB RID: 1019
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x040003FC RID: 1020
		[AccessedThroughProperty("UiButton1")]
		private UIButton _UiButton1;

		// Token: 0x040003FD RID: 1021
		[AccessedThroughProperty("EditBox1")]
		private EditBox _EditBox1;

		// Token: 0x040003FE RID: 1022
		private Frm_Size frm_size;

		// Token: 0x040003FF RID: 1023
		private Grid_Size grid_size;

		// Token: 0x04000400 RID: 1024
		[CompilerGenerated]
		private CollectionBase _items;

		// Token: 0x04000401 RID: 1025
		[CompilerGenerated]
		private DataRowView _SelectedRow;

		// Token: 0x04000402 RID: 1026
		[CompilerGenerated]
		private long _ExtraData;

		// Token: 0x04000403 RID: 1027
		[CompilerGenerated]
		private bool _CanEdit;

		// Token: 0x04000404 RID: 1028
		[CompilerGenerated]
		private bool _AllowEnterToClose;

		// Token: 0x04000405 RID: 1029
		[CompilerGenerated]
		private char _chara;

		// Token: 0x04000406 RID: 1030
		[CompilerGenerated]
		private bool _CanDelete;

		// Token: 0x04000407 RID: 1031
		[CompilerGenerated]
		private Form _Edit_Frm;

		// Token: 0x04000408 RID: 1032
		[CompilerGenerated]
		private string _Command;

		// Token: 0x04000409 RID: 1033
		[CompilerGenerated]
		private Form _Frm;
	}
}
