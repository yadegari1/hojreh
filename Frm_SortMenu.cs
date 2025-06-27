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
using FruitBox.My;
using FruitBox.My.Resources;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.UI;
using Janus.Windows.UI.Dock;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x02000081 RID: 129
	[DesignerGenerated]
	public partial class Frm_SortMenu : Form
	{
		// Token: 0x06000B50 RID: 2896 RVA: 0x00004483 File Offset: 0x00002683
		[DebuggerNonUserCode]
		public Frm_SortMenu()
		{
			base.KeyDown += new KeyEventHandler(this.Frm_SortMenu_KeyDown);
			base.Load += new EventHandler(this.Frm_SortMenu_Load);
			Frm_SortMenu.__ENCAddToList(this);
			this.InitializeComponent();
		}

		// Token: 0x06000B51 RID: 2897 RVA: 0x0008E76C File Offset: 0x0008C96C
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_SortMenu.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_SortMenu.__ENCList.Count == Frm_SortMenu.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_SortMenu.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_SortMenu.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_SortMenu.__ENCList[num] = Frm_SortMenu.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_SortMenu.__ENCList.RemoveRange(num, Frm_SortMenu.__ENCList.Count - num);
						Frm_SortMenu.__ENCList.Capacity = Frm_SortMenu.__ENCList.Count;
					}
					Frm_SortMenu.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x06000B54 RID: 2900 RVA: 0x0008F59C File Offset: 0x0008D79C
		// (set) Token: 0x06000B55 RID: 2901 RVA: 0x0008F5B4 File Offset: 0x0008D7B4
		internal virtual UIComboBox UiComboBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiComboBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.UiComboBox1_SelectedIndexChanged);
				bool flag = this._UiComboBox1 != null;
				if (flag)
				{
					this._UiComboBox1.SelectedIndexChanged -= value2;
				}
				this._UiComboBox1 = value;
				flag = (this._UiComboBox1 != null);
				if (flag)
				{
					this._UiComboBox1.SelectedIndexChanged += value2;
				}
			}
		}

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x06000B56 RID: 2902 RVA: 0x0008F614 File Offset: 0x0008D814
		// (set) Token: 0x06000B57 RID: 2903 RVA: 0x000044C3 File Offset: 0x000026C3
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

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x06000B58 RID: 2904 RVA: 0x0008F62C File Offset: 0x0008D82C
		// (set) Token: 0x06000B59 RID: 2905 RVA: 0x0008F644 File Offset: 0x0008D844
		internal virtual UIButton UiButton2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiButton2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.UiButton2_Click);
				bool flag = this._UiButton2 != null;
				if (flag)
				{
					this._UiButton2.Click -= value2;
				}
				this._UiButton2 = value;
				flag = (this._UiButton2 != null);
				if (flag)
				{
					this._UiButton2.Click += value2;
				}
			}
		}

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x06000B5A RID: 2906 RVA: 0x0008F6A4 File Offset: 0x0008D8A4
		// (set) Token: 0x06000B5B RID: 2907 RVA: 0x0008F6BC File Offset: 0x0008D8BC
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

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x06000B5C RID: 2908 RVA: 0x0008F71C File Offset: 0x0008D91C
		// (set) Token: 0x06000B5D RID: 2909 RVA: 0x000044CD File Offset: 0x000026CD
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

		// Token: 0x17000386 RID: 902
		// (get) Token: 0x06000B5E RID: 2910 RVA: 0x0008F734 File Offset: 0x0008D934
		// (set) Token: 0x06000B5F RID: 2911 RVA: 0x000044D7 File Offset: 0x000026D7
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
				this._ButtonItem1 = value;
			}
		}

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x06000B60 RID: 2912 RVA: 0x0008F74C File Offset: 0x0008D94C
		// (set) Token: 0x06000B61 RID: 2913 RVA: 0x0008F764 File Offset: 0x0008D964
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
				EventHandler value2 = new EventHandler(this.ButtonItem2_Click);
				bool flag = this._ButtonItem2 != null;
				if (flag)
				{
					this._ButtonItem2.Click -= value2;
				}
				this._ButtonItem2 = value;
				flag = (this._ButtonItem2 != null);
				if (flag)
				{
					this._ButtonItem2.Click += value2;
				}
			}
		}

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x06000B62 RID: 2914 RVA: 0x0008F7C4 File Offset: 0x0008D9C4
		// (set) Token: 0x06000B63 RID: 2915 RVA: 0x0008F7DC File Offset: 0x0008D9DC
		internal virtual ButtonItem ButtonItem3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem3_Click);
				bool flag = this._ButtonItem3 != null;
				if (flag)
				{
					this._ButtonItem3.Click -= value2;
				}
				this._ButtonItem3 = value;
				flag = (this._ButtonItem3 != null);
				if (flag)
				{
					this._ButtonItem3.Click += value2;
				}
			}
		}

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x06000B64 RID: 2916 RVA: 0x0008F83C File Offset: 0x0008DA3C
		// (set) Token: 0x06000B65 RID: 2917 RVA: 0x0008F854 File Offset: 0x0008DA54
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
				EventHandler value2 = new EventHandler(this.GridEX1_SelectionChanged);
				bool flag = this._GridEX1 != null;
				if (flag)
				{
					this._GridEX1.SelectionChanged -= value2;
				}
				this._GridEX1 = value;
				flag = (this._GridEX1 != null);
				if (flag)
				{
					this._GridEX1.SelectionChanged += value2;
				}
			}
		}

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x06000B66 RID: 2918 RVA: 0x0008F8B4 File Offset: 0x0008DAB4
		// (set) Token: 0x06000B67 RID: 2919 RVA: 0x000044E1 File Offset: 0x000026E1
		internal virtual DataEntryGrid GridEx2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GridEx2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GridEx2 = value;
			}
		}

		// Token: 0x1700038B RID: 907
		// (get) Token: 0x06000B68 RID: 2920 RVA: 0x0008F8CC File Offset: 0x0008DACC
		// (set) Token: 0x06000B69 RID: 2921 RVA: 0x0008F8E4 File Offset: 0x0008DAE4
		internal virtual UIButton UiButton4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiButton4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.UiButton4_Click);
				bool flag = this._UiButton4 != null;
				if (flag)
				{
					this._UiButton4.Click -= value2;
				}
				this._UiButton4 = value;
				flag = (this._UiButton4 != null);
				if (flag)
				{
					this._UiButton4.Click += value2;
				}
			}
		}

		// Token: 0x1700038C RID: 908
		// (get) Token: 0x06000B6A RID: 2922 RVA: 0x0008F944 File Offset: 0x0008DB44
		// (set) Token: 0x06000B6B RID: 2923 RVA: 0x0008F95C File Offset: 0x0008DB5C
		internal virtual UIButton UiButton3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiButton3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.UiButton3_Click);
				bool flag = this._UiButton3 != null;
				if (flag)
				{
					this._UiButton3.Click -= value2;
				}
				this._UiButton3 = value;
				flag = (this._UiButton3 != null);
				if (flag)
				{
					this._UiButton3.Click += value2;
				}
			}
		}

		// Token: 0x1700038D RID: 909
		// (get) Token: 0x06000B6C RID: 2924 RVA: 0x0008F9BC File Offset: 0x0008DBBC
		// (set) Token: 0x06000B6D RID: 2925 RVA: 0x000044EB File Offset: 0x000026EB
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

		// Token: 0x06000B6E RID: 2926 RVA: 0x0006620C File Offset: 0x0006440C
		private void Frm_SortMenu_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Escape;
			if (flag)
			{
				this.Close();
			}
		}

		// Token: 0x06000B6F RID: 2927 RVA: 0x0008F9D4 File Offset: 0x0008DBD4
		private void Frm_SortMenu_Load(object sender, EventArgs e)
		{
			this.GridEX1.FocusCellFormatStyle.BackColor = this.GridEX1.SelectedFormatStyle.BackColor;
			int num = 0;
			int num2 = 0;
			checked
			{
				try
				{
					IEnumerator enumerator = MyProject.Forms.Form_Main.Bar1.Items.GetEnumerator();
					while (enumerator.MoveNext())
					{
						BaseItem baseItem = (BaseItem)enumerator.Current;
						bool flag = baseItem is LabelItem;
						if (!flag)
						{
							flag = !baseItem.Visible;
							if (!flag)
							{
								string command = string.Concat(new string[]
								{
									"if not exists(select id from Menu_Sort where name=",
									Public_Function.GetValue(baseItem.Text),
									")  INSERT INTO [dbo].[Menu_Sort] ([Parent_ID],[Name],[order]) VALUES (NULL,",
									Public_Function.GetValue(baseItem.Text),
									",",
									Conversions.ToString(num),
									"); "
								});
								Public_Function.ExecuteNonQuery(command);
								this.UiComboBox1.Items.Add(baseItem.Text);
								num++;
								num2 = 0;
								try
								{
									IEnumerator enumerator2 = baseItem.SubItems.GetEnumerator();
									while (enumerator2.MoveNext())
									{
										BaseItem baseItem2 = (BaseItem)enumerator2.Current;
										flag = (baseItem2 is ButtonItem);
										if (!flag)
										{
											goto IL_21C;
										}
										bool flag2 = !baseItem2.Visible;
										if (!flag2)
										{
											int value = Conversions.ToInteger(Public_Function.ExecuteScalar("select id from menu_sort where name=" + Public_Function.GetValue(baseItem.Text)));
											command = string.Concat(new string[]
											{
												"if not exists(select id from Menu_Sort where parent_id=",
												Conversions.ToString(value),
												" AND name=",
												Public_Function.GetValue(baseItem2.Text),
												")  INSERT INTO [dbo].[Menu_Sort] ([Parent_ID],[Name],[order]) VALUES (",
												Conversions.ToString(value),
												",",
												Public_Function.GetValue(baseItem2.Text),
												",",
												Conversions.ToString(num2),
												");"
											});
											Public_Function.ExecuteNonQuery(command);
											num2++;
											goto IL_21C;
										}
										continue;
										IL_21C:
										int num3 = 1;
										try
										{
											IEnumerator enumerator3 = baseItem2.SubItems.GetEnumerator();
											while (enumerator3.MoveNext())
											{
												BaseItem baseItem3 = (BaseItem)enumerator3.Current;
												flag2 = (baseItem3 is ButtonItem);
												if (flag2)
												{
													flag = !baseItem3.Visible;
													if (!flag)
													{
														int value2 = Conversions.ToInteger(Public_Function.ExecuteScalar("select id from menu_sort where name=" + Public_Function.GetValue(baseItem2.Text) + " and parent_id is not null"));
														command = string.Concat(new string[]
														{
															"if not exists(select id from Menu_Sort where parent_id=",
															Conversions.ToString(value2),
															" AND name=",
															Public_Function.GetValue(baseItem3.Text),
															")  INSERT INTO [dbo].[Menu_Sort] ([Parent_ID],[Name],[order]) VALUES (",
															Conversions.ToString(value2),
															",",
															Public_Function.GetValue(baseItem3.Text),
															",",
															Conversions.ToString(num3),
															");"
														});
														Public_Function.ExecuteNonQuery(command);
														num3++;
													}
												}
											}
										}
										finally
										{
											IEnumerator enumerator3;
											flag2 = (enumerator3 is IDisposable);
											if (flag2)
											{
												(enumerator3 as IDisposable).Dispose();
											}
										}
									}
								}
								finally
								{
									IEnumerator enumerator2;
									bool flag2 = enumerator2 is IDisposable;
									if (flag2)
									{
										(enumerator2 as IDisposable).Dispose();
									}
								}
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
			}
		}

		// Token: 0x06000B70 RID: 2928 RVA: 0x0008DE98 File Offset: 0x0008C098
		private void Delmenus(string menu, DataTable dt)
		{
			bool flag = false;
			try
			{
				IEnumerator enumerator = MyProject.Forms.Form_Main.Bar1.Items.GetEnumerator();
				while (enumerator.MoveNext())
				{
					BaseItem baseItem = (BaseItem)enumerator.Current;
					bool flag2 = baseItem is ButtonItem;
					if (flag2)
					{
						bool flag3 = Operators.CompareString(baseItem.Text, menu, false) == 0;
						if (flag3)
						{
							try
							{
								IEnumerator enumerator2 = dt.Rows.GetEnumerator();
								while (enumerator2.MoveNext())
								{
									DataRow dataRow = (DataRow)enumerator2.Current;
									flag = false;
									try
									{
										IEnumerator enumerator3 = baseItem.SubItems.GetEnumerator();
										while (enumerator3.MoveNext())
										{
											BaseItem baseItem2 = (BaseItem)enumerator3.Current;
											flag3 = Operators.ConditionalCompareObjectEqual(baseItem2.Text, dataRow["name"], false);
											if (flag3)
											{
												flag = true;
											}
										}
									}
									finally
									{
										IEnumerator enumerator3;
										flag3 = (enumerator3 is IDisposable);
										if (flag3)
										{
											(enumerator3 as IDisposable).Dispose();
										}
									}
									flag3 = !flag;
									if (flag3)
									{
										NewLateBinding.LateCall(null, typeof(Public_Function), "ExecuteNonQuery", new object[]
										{
											Operators.ConcatenateObject("delete from menu_sort where id=", dataRow["ID"])
										}, null, null, null, true);
									}
								}
							}
							finally
							{
								IEnumerator enumerator2;
								flag3 = (enumerator2 is IDisposable);
								if (flag3)
								{
									(enumerator2 as IDisposable).Dispose();
								}
							}
						}
					}
				}
			}
			finally
			{
				IEnumerator enumerator;
				bool flag3 = enumerator is IDisposable;
				if (flag3)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
		}

		// Token: 0x06000B71 RID: 2929 RVA: 0x0008FE00 File Offset: 0x0008E000
		private void GetItems(string Menu)
		{
			int value = Conversions.ToInteger(Public_Function.ExecuteScalar("select id from menu_sort where name=" + Public_Function.GetValue(Menu)));
			DataTable dataTable = Public_Function.FillData("select * from menu_sort where parent_id=" + Conversions.ToString(value) + " order by [order]");
			this.Delmenus(Menu, dataTable);
			dataTable = Public_Function.FillData("select * from menu_sort where parent_id=" + Conversions.ToString(value) + " order by [order]");
			this.GridEX1.DataSource = dataTable;
		}

		// Token: 0x06000B72 RID: 2930 RVA: 0x0008FE78 File Offset: 0x0008E078
		private void GetSubItems(string id)
		{
			DataTable dataTable = Public_Function.FillData("select * from menu_sort where parent_id=" + id + " order by [order]");
			bool flag = dataTable.Rows.Count > 0;
			if (flag)
			{
				this.GridEx2.DataSource = dataTable;
				this.GridEx2.Visible = true;
				this.UiButton3.Visible = true;
				this.UiButton4.Visible = true;
			}
			else
			{
				this.GridEx2.Visible = false;
				this.UiButton3.Visible = false;
				this.UiButton4.Visible = false;
			}
		}

		// Token: 0x06000B73 RID: 2931 RVA: 0x000044F5 File Offset: 0x000026F5
		private void UiComboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.GetItems(this.UiComboBox1.SelectedItem.Text);
		}

		// Token: 0x06000B74 RID: 2932 RVA: 0x0008FF10 File Offset: 0x0008E110
		private void UiButton2_Click(object sender, EventArgs e)
		{
			bool flag = this.GridEX1.CurrentRow == null;
			checked
			{
				if (!flag)
				{
					int position = this.GridEX1.CurrentRow.Position;
					string value = Conversions.ToString(this.GridEX1.CurrentRow.Cells["Name"].Value);
					int num = Conversions.ToInteger(this.GridEX1.CurrentRow.Cells["ID"].Value);
					flag = (position < this.GridEX1.RowCount - 1);
					if (flag)
					{
						this.GridEX1.CurrentRow.Delete();
						((DataTable)this.GridEX1.DataSource).AcceptChanges();
						DataRow dataRow = ((DataTable)this.GridEX1.DataSource).NewRow();
						dataRow["Name"] = value;
						dataRow["ID"] = num;
						((DataTable)this.GridEX1.DataSource).Rows.InsertAt(dataRow, position + 1);
						this.GridEX1.Row = position + 1;
					}
				}
			}
		}

		// Token: 0x06000B75 RID: 2933 RVA: 0x00090038 File Offset: 0x0008E238
		private void UiButton1_Click(object sender, EventArgs e)
		{
			bool flag = this.GridEX1.CurrentRow == null;
			checked
			{
				if (!flag)
				{
					int position = this.GridEX1.CurrentRow.Position;
					string value = Conversions.ToString(this.GridEX1.CurrentRow.Cells["Name"].Value);
					int num = Conversions.ToInteger(this.GridEX1.CurrentRow.Cells["ID"].Value);
					flag = (position > 0);
					if (flag)
					{
						this.GridEX1.CurrentRow.Delete();
						((DataTable)this.GridEX1.DataSource).AcceptChanges();
						DataRow dataRow = ((DataTable)this.GridEX1.DataSource).NewRow();
						dataRow["Name"] = value;
						dataRow["ID"] = num;
						((DataTable)this.GridEX1.DataSource).Rows.InsertAt(dataRow, position - 1);
						this.GridEX1.Row = position - 1;
					}
				}
			}
		}

		// Token: 0x06000B76 RID: 2934 RVA: 0x00090154 File Offset: 0x0008E354
		private void ButtonItem3_Click(object sender, EventArgs e)
		{
			Frm_MainSortMenu frm_MainSortMenu = new Frm_MainSortMenu();
			frm_MainSortMenu.ShowDialog();
			this.UiComboBox1.Items.Clear();
			try
			{
				IEnumerator enumerator = MyProject.Forms.Form_Main.Bar1.Items.GetEnumerator();
				while (enumerator.MoveNext())
				{
					BaseItem baseItem = (BaseItem)enumerator.Current;
					bool flag = baseItem is ButtonItem;
					if (flag)
					{
						this.UiComboBox1.Items.Add(baseItem.Text);
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
		}

		// Token: 0x06000B77 RID: 2935 RVA: 0x0009020C File Offset: 0x0008E40C
		private void ButtonItem2_Click(object sender, EventArgs e)
		{
			string text = string.Empty;
			int num = 0;
			GridEXRow[] rows = this.GridEX1.GetRows();
			checked
			{
				for (int i = 0; i < rows.Length; i++)
				{
					GridEXRow gridEXRow = rows[i];
					text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("update menu_sort set [order] =" + Conversions.ToString(num) + " where id=", gridEXRow.Cells["ID"].Value), ";")));
					num++;
				}
				GridEXRow[] rows2 = this.GridEx2.GetRows();
				for (int j = 0; j < rows2.Length; j++)
				{
					GridEXRow gridEXRow2 = rows2[j];
					text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("update menu_sort set [order] =" + Conversions.ToString(num) + " where id=", gridEXRow2.Cells["ID"].Value), ";")));
					num++;
				}
				Public_Function.ExecuteNonQuery(text);
				MyProject.Forms.Form_Main.Load_Root_Menu();
				Public_Function.ShowMessage("اطلاعات با موفقیت ثبت گردید", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, null);
			}
		}

		// Token: 0x06000B78 RID: 2936 RVA: 0x00090340 File Offset: 0x0008E540
		private void GridEX1_SelectionChanged(object sender, EventArgs e)
		{
			bool flag = this.GridEX1.CurrentRow == null;
			if (!flag)
			{
				this.GetSubItems(Conversions.ToString(this.GridEX1.CurrentRow.Cells["ID"].Value));
			}
		}

		// Token: 0x06000B79 RID: 2937 RVA: 0x00090390 File Offset: 0x0008E590
		private void UiButton3_Click(object sender, EventArgs e)
		{
			bool flag = this.GridEx2.CurrentRow == null;
			checked
			{
				if (!flag)
				{
					int position = this.GridEx2.CurrentRow.Position;
					string value = Conversions.ToString(this.GridEx2.CurrentRow.Cells["Name"].Value);
					int num = Conversions.ToInteger(this.GridEx2.CurrentRow.Cells["ID"].Value);
					flag = (position > 0);
					if (flag)
					{
						this.GridEx2.CurrentRow.Delete();
						((DataTable)this.GridEx2.DataSource).AcceptChanges();
						DataRow dataRow = ((DataTable)this.GridEx2.DataSource).NewRow();
						dataRow["Name"] = value;
						dataRow["ID"] = num;
						((DataTable)this.GridEx2.DataSource).Rows.InsertAt(dataRow, position - 1);
						this.GridEx2.Row = position - 1;
					}
				}
			}
		}

		// Token: 0x06000B7A RID: 2938 RVA: 0x000904AC File Offset: 0x0008E6AC
		private void UiButton4_Click(object sender, EventArgs e)
		{
			bool flag = this.GridEx2.CurrentRow == null;
			checked
			{
				if (!flag)
				{
					int position = this.GridEx2.CurrentRow.Position;
					string value = Conversions.ToString(this.GridEx2.CurrentRow.Cells["Name"].Value);
					int num = Conversions.ToInteger(this.GridEx2.CurrentRow.Cells["ID"].Value);
					flag = (position < this.GridEx2.RowCount - 1);
					if (flag)
					{
						this.GridEx2.CurrentRow.Delete();
						((DataTable)this.GridEx2.DataSource).AcceptChanges();
						DataRow dataRow = ((DataTable)this.GridEx2.DataSource).NewRow();
						dataRow["Name"] = value;
						dataRow["ID"] = num;
						((DataTable)this.GridEx2.DataSource).Rows.InsertAt(dataRow, position + 1);
						this.GridEx2.Row = position + 1;
					}
				}
			}
		}

		// Token: 0x04000478 RID: 1144
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x0400047A RID: 1146
		[AccessedThroughProperty("UiComboBox1")]
		private UIComboBox _UiComboBox1;

		// Token: 0x0400047B RID: 1147
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x0400047C RID: 1148
		[AccessedThroughProperty("UiButton2")]
		private UIButton _UiButton2;

		// Token: 0x0400047D RID: 1149
		[AccessedThroughProperty("UiButton1")]
		private UIButton _UiButton1;

		// Token: 0x0400047E RID: 1150
		[AccessedThroughProperty("Bar1")]
		private Bar _Bar1;

		// Token: 0x0400047F RID: 1151
		[AccessedThroughProperty("ButtonItem1")]
		private ButtonItem _ButtonItem1;

		// Token: 0x04000480 RID: 1152
		[AccessedThroughProperty("ButtonItem2")]
		private ButtonItem _ButtonItem2;

		// Token: 0x04000481 RID: 1153
		[AccessedThroughProperty("ButtonItem3")]
		private ButtonItem _ButtonItem3;

		// Token: 0x04000482 RID: 1154
		[AccessedThroughProperty("GridEX1")]
		private DataEntryGrid _GridEX1;

		// Token: 0x04000483 RID: 1155
		[AccessedThroughProperty("GridEx2")]
		private DataEntryGrid _GridEx2;

		// Token: 0x04000484 RID: 1156
		[AccessedThroughProperty("UiButton4")]
		private UIButton _UiButton4;

		// Token: 0x04000485 RID: 1157
		[AccessedThroughProperty("UiButton3")]
		private UIButton _UiButton3;

		// Token: 0x04000486 RID: 1158
		[AccessedThroughProperty("Label1")]
		private Label _Label1;
	}
}
