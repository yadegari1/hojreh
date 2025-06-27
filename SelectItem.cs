using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Janus.Windows.GridEX;
using Janus.Windows.GridEX.EditControls;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x020000A3 RID: 163
	public class SelectItem : EditBox
	{
		// Token: 0x06000E07 RID: 3591 RVA: 0x000A6AD0 File Offset: 0x000A4CD0
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = SelectItem.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = SelectItem.__ENCList.Count == SelectItem.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = SelectItem.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = SelectItem.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									SelectItem.__ENCList[num] = SelectItem.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						SelectItem.__ENCList.RemoveRange(num, SelectItem.__ENCList.Count - num);
						SelectItem.__ENCList.Capacity = SelectItem.__ENCList.Count;
					}
					SelectItem.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x06000E08 RID: 3592 RVA: 0x000A6BD4 File Offset: 0x000A4DD4
		[DebuggerNonUserCode]
		public SelectItem(IContainer container) : this()
		{
			bool flag = container != null;
			if (flag)
			{
				container.Add(this);
			}
		}

		// Token: 0x06000E09 RID: 3593 RVA: 0x000A6C00 File Offset: 0x000A4E00
		[DebuggerNonUserCode]
		public SelectItem()
		{
			SelectItem.__ENCAddToList(this);
			ItemCollection items = new ItemCollection();
			this.Items = items;
			bool canEdit = false;
			this.CanEdit = canEdit;
			this.RightToLeft = RightToLeft.No;
			this.TextAlignment = TextAlignment.Far;
			this.ButtonStyle = EditButtonStyle.TextButton;
			this.ButtonText = "...";
			this.ButtonClick += new EventHandler(this.Select_Click);
			this.InitializeComponent();
		}

		// Token: 0x06000E0A RID: 3594 RVA: 0x000A6C74 File Offset: 0x000A4E74
		[DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				bool flag = disposing && this.components != null;
				if (flag)
				{
					this.components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x06000E0B RID: 3595 RVA: 0x00004FA8 File Offset: 0x000031A8
		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new Container();
		}

		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x06000E0C RID: 3596 RVA: 0x000A6CC4 File Offset: 0x000A4EC4
		// (set) Token: 0x06000E0D RID: 3597 RVA: 0x00004FB7 File Offset: 0x000031B7
		[Category("ExtendProperty")]
		public string SelectCommand
		{
			[DebuggerNonUserCode]
			get
			{
				return this._SelectCommand;
			}
			[DebuggerNonUserCode]
			set
			{
				this._SelectCommand = value;
			}
		}

		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x06000E0E RID: 3598 RVA: 0x000A6CDC File Offset: 0x000A4EDC
		// (set) Token: 0x06000E0F RID: 3599 RVA: 0x00004FC1 File Offset: 0x000031C1
		[Browsable(false)]
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

		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x06000E10 RID: 3600 RVA: 0x000A6CF4 File Offset: 0x000A4EF4
		// (set) Token: 0x06000E11 RID: 3601 RVA: 0x00004FCB File Offset: 0x000031CB
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content), Browsable(true), Category("ExtendProperty")]
		public ItemCollection Items
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Items;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Items = value;
			}
		}

		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x06000E12 RID: 3602 RVA: 0x000A6D0C File Offset: 0x000A4F0C
		// (set) Token: 0x06000E13 RID: 3603 RVA: 0x00004FD5 File Offset: 0x000031D5
		[Category("ExtendProperty")]
		public string DisplayMember
		{
			[DebuggerNonUserCode]
			get
			{
				return this._DisplayMember;
			}
			[DebuggerNonUserCode]
			set
			{
				this._DisplayMember = value;
			}
		}

		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x06000E14 RID: 3604 RVA: 0x000A6D24 File Offset: 0x000A4F24
		// (set) Token: 0x06000E15 RID: 3605 RVA: 0x00004FDF File Offset: 0x000031DF
		[Category("ExtendProperty")]
		public string ValueMember
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ValueMember;
			}
			[DebuggerNonUserCode]
			set
			{
				this._ValueMember = value;
			}
		}

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x06000E16 RID: 3606 RVA: 0x000A6D3C File Offset: 0x000A4F3C
		// (set) Token: 0x06000E17 RID: 3607 RVA: 0x00004FE9 File Offset: 0x000031E9
		[Category("ExtendProperty")]
		public Form AddNewForm
		{
			[DebuggerNonUserCode]
			get
			{
				return this._AddNewForm;
			}
			[DebuggerNonUserCode]
			set
			{
				this._AddNewForm = value;
			}
		}

		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x06000E18 RID: 3608 RVA: 0x000A6D54 File Offset: 0x000A4F54
		// (set) Token: 0x06000E19 RID: 3609 RVA: 0x00004FF3 File Offset: 0x000031F3
		[Browsable(false)]
		public object Value
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Value;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Value = RuntimeHelpers.GetObjectValue(value);
			}
		}

		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x06000E1A RID: 3610 RVA: 0x000A6D6C File Offset: 0x000A4F6C
		// (set) Token: 0x06000E1B RID: 3611 RVA: 0x00005002 File Offset: 0x00003202
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

		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x06000E1C RID: 3612 RVA: 0x000A6D84 File Offset: 0x000A4F84
		// (set) Token: 0x06000E1D RID: 3613 RVA: 0x0000500C File Offset: 0x0000320C
		[Category("ExtendProperty")]
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

		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x06000E1E RID: 3614 RVA: 0x000A6D9C File Offset: 0x000A4F9C
		// (set) Token: 0x06000E1F RID: 3615 RVA: 0x00005016 File Offset: 0x00003216
		[Category("ExtendProperty")]
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

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x06000E20 RID: 3616 RVA: 0x00005020 File Offset: 0x00003220
		// (remove) Token: 0x06000E21 RID: 3617 RVA: 0x0000503A File Offset: 0x0000323A
		public event SelectItem.SelectedValueChangingEventHandler SelectedValueChanging
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.SelectedValueChangingEvent = (SelectItem.SelectedValueChangingEventHandler)Delegate.Combine(this.SelectedValueChangingEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.SelectedValueChangingEvent = (SelectItem.SelectedValueChangingEventHandler)Delegate.Remove(this.SelectedValueChangingEvent, value);
			}
		}

		// Token: 0x1400000A RID: 10
		// (add) Token: 0x06000E22 RID: 3618 RVA: 0x00005054 File Offset: 0x00003254
		// (remove) Token: 0x06000E23 RID: 3619 RVA: 0x0000506E File Offset: 0x0000326E
		public event SelectItem.SelectedValueChangedEventHandler SelectedValueChanged
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.SelectedValueChangedEvent = (SelectItem.SelectedValueChangedEventHandler)Delegate.Combine(this.SelectedValueChangedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.SelectedValueChangedEvent = (SelectItem.SelectedValueChangedEventHandler)Delegate.Remove(this.SelectedValueChangedEvent, value);
			}
		}

		// Token: 0x1400000B RID: 11
		// (add) Token: 0x06000E24 RID: 3620 RVA: 0x00005088 File Offset: 0x00003288
		// (remove) Token: 0x06000E25 RID: 3621 RVA: 0x000050A2 File Offset: 0x000032A2
		public event SelectItem.ValueDeletedEventHandler ValueDeleted
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.ValueDeletedEvent = (SelectItem.ValueDeletedEventHandler)Delegate.Combine(this.ValueDeletedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.ValueDeletedEvent = (SelectItem.ValueDeletedEventHandler)Delegate.Remove(this.ValueDeletedEvent, value);
			}
		}

		// Token: 0x06000E26 RID: 3622 RVA: 0x000050BC File Offset: 0x000032BC
		public void SetValue(string Name, object Value)
		{
			this.Text = Name;
			this.Value = RuntimeHelpers.GetObjectValue(Value);
		}

		// Token: 0x06000E27 RID: 3623 RVA: 0x000050D5 File Offset: 0x000032D5
		public new void SetNew()
		{
			this.SelectedRow = null;
			this.Text = string.Empty;
			this.Value = null;
		}

		// Token: 0x06000E28 RID: 3624 RVA: 0x000A6DB4 File Offset: 0x000A4FB4
		public override void me_keypress(object sender, KeyPressEventArgs e)
		{
			base.me_keypress(RuntimeHelpers.GetObjectValue(sender), e);
			e.Handled = true;
			bool flag = char.IsLetter(e.KeyChar) || char.IsDigit(e.KeyChar);
			if (flag)
			{
				bool flag2 = Operators.CompareString(this.SelectCommand, string.Empty, false) != 0;
				if (flag2)
				{
					Frm_SelectItem frm_SelectItem = new Frm_SelectItem
					{
						items = this.Items,
						CanEdit = this.CanEdit,
						Edit_Frm = this.Edit_Frm,
						chara = e.KeyChar
					};
					frm_SelectItem.ExtraData = this.ExtraData;
					flag2 = (frm_SelectItem.ShowDialog(this.SelectCommand, this.AddNewForm, 0) == DialogResult.OK);
					if (flag2)
					{
						flag = (this.Value == DBNull.Value || Operators.ConditionalCompareObjectNotEqual(this.Value, frm_SelectItem.SelectedRow[this.ValueMember], false));
						if (flag)
						{
							this.SelectedRow = frm_SelectItem.SelectedRow;
							flag2 = (this.DisplayMember != null);
							if (flag2)
							{
								this.Text = Conversions.ToString(frm_SelectItem.SelectedRow[this.DisplayMember]);
							}
							SelectItem.SelectedValueChangingEventHandler selectedValueChangingEvent = this.SelectedValueChangingEvent;
							flag2 = (selectedValueChangingEvent != null);
							if (flag2)
							{
								selectedValueChangingEvent(RuntimeHelpers.GetObjectValue(sender), e);
							}
							this.Value = RuntimeHelpers.GetObjectValue(frm_SelectItem.SelectedRow[this.ValueMember]);
							SelectItem.SelectedValueChangedEventHandler selectedValueChangedEvent = this.SelectedValueChangedEvent;
							flag2 = (selectedValueChangedEvent != null);
							if (flag2)
							{
								selectedValueChangedEvent(RuntimeHelpers.GetObjectValue(sender), e);
							}
							base.me_keydown(RuntimeHelpers.GetObjectValue(sender), new KeyEventArgs(Keys.Return));
						}
					}
				}
			}
		}

		// Token: 0x06000E29 RID: 3625 RVA: 0x000A6F7C File Offset: 0x000A517C
		public override void me_keydown(object sender, KeyEventArgs e)
		{
			Keys keyCode = e.KeyCode;
			bool flag = keyCode == Keys.Return;
			if (flag)
			{
				bool flag2 = Operators.CompareString(this.Text, string.Empty, false) == 0;
				if (flag2)
				{
					this.Select_Click(RuntimeHelpers.GetObjectValue(sender), e);
				}
				else
				{
					base.me_keydown(RuntimeHelpers.GetObjectValue(sender), e);
				}
			}
			else
			{
				bool flag2 = keyCode == Keys.Delete;
				if (flag2)
				{
					e.SuppressKeyPress = true;
					this.SetNew();
					SelectItem.ValueDeletedEventHandler valueDeletedEvent = this.ValueDeletedEvent;
					flag2 = (valueDeletedEvent != null);
					if (flag2)
					{
						valueDeletedEvent(RuntimeHelpers.GetObjectValue(sender), e);
					}
					this.Select_Click(RuntimeHelpers.GetObjectValue(sender), e);
				}
				else
				{
					flag2 = (keyCode == Keys.Up);
					if (flag2)
					{
						flag = (this.Parent == null);
						if (!flag)
						{
							flag2 = (this.Parent.Parent != null);
							if (flag2)
							{
								flag = (this.Parent.Parent is GridEX);
								if (flag)
								{
									return;
								}
							}
							this.ParentForm.SelectNextControl((Control)sender, false, true, true, true);
						}
					}
					else
					{
						flag2 = (keyCode == Keys.Down);
						if (flag2)
						{
							flag = (this.Parent == null);
							if (!flag)
							{
								flag2 = (this.Parent.Parent != null);
								if (flag2)
								{
									flag = (this.Parent.Parent is GridEX);
									if (flag)
									{
										return;
									}
								}
								this.ParentForm.SelectNextControl((Control)sender, true, true, true, true);
							}
						}
					}
				}
			}
		}

		// Token: 0x06000E2A RID: 3626 RVA: 0x000050F5 File Offset: 0x000032F5
		public void ShowDialog()
		{
			this.Select_Click(this, null);
		}

		// Token: 0x06000E2B RID: 3627 RVA: 0x000A70F4 File Offset: 0x000A52F4
		private void Select_Click(object sender, EventArgs e)
		{
			base.OnButtonClick(EditButton.Button);
			bool flag = Operators.CompareString(this.SelectCommand, string.Empty, false) != 0;
			if (flag)
			{
				Frm_SelectItem frm_SelectItem = new Frm_SelectItem
				{
					items = this.Items,
					CanEdit = this.CanEdit,
					Edit_Frm = this.Edit_Frm
				};
				frm_SelectItem.ExtraData = this.ExtraData;
				flag = (frm_SelectItem.ShowDialog(this.SelectCommand, this.AddNewForm, 0) == DialogResult.OK);
				if (flag)
				{
					bool flag2 = this.Value == DBNull.Value || Operators.ConditionalCompareObjectNotEqual(this.Value, frm_SelectItem.SelectedRow[this.ValueMember], false);
					if (flag2)
					{
						this.SelectedRow = frm_SelectItem.SelectedRow;
						flag2 = (this.DisplayMember != null);
						if (flag2)
						{
							this.Text = Conversions.ToString(frm_SelectItem.SelectedRow[this.DisplayMember]);
						}
						SelectItem.SelectedValueChangingEventHandler selectedValueChangingEvent = this.SelectedValueChangingEvent;
						flag2 = (selectedValueChangingEvent != null);
						if (flag2)
						{
							selectedValueChangingEvent(RuntimeHelpers.GetObjectValue(sender), e);
						}
						this.Value = RuntimeHelpers.GetObjectValue(frm_SelectItem.SelectedRow[this.ValueMember]);
						SelectItem.SelectedValueChangedEventHandler selectedValueChangedEvent = this.SelectedValueChangedEvent;
						flag2 = (selectedValueChangedEvent != null);
						if (flag2)
						{
							selectedValueChangedEvent(RuntimeHelpers.GetObjectValue(sender), e);
						}
						base.me_keydown(RuntimeHelpers.GetObjectValue(sender), new KeyEventArgs(Keys.Return));
					}
				}
			}
		}

		// Token: 0x0400055D RID: 1373
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x0400055E RID: 1374
		private IContainer components;

		// Token: 0x0400055F RID: 1375
		[CompilerGenerated]
		private string _SelectCommand;

		// Token: 0x04000560 RID: 1376
		[CompilerGenerated]
		private DataRowView _SelectedRow;

		// Token: 0x04000561 RID: 1377
		[CompilerGenerated]
		private ItemCollection _Items;

		// Token: 0x04000562 RID: 1378
		[CompilerGenerated]
		private string _DisplayMember;

		// Token: 0x04000563 RID: 1379
		[CompilerGenerated]
		private string _ValueMember;

		// Token: 0x04000564 RID: 1380
		[CompilerGenerated]
		private Form _AddNewForm;

		// Token: 0x04000565 RID: 1381
		[CompilerGenerated]
		private object _Value;

		// Token: 0x04000566 RID: 1382
		[CompilerGenerated]
		private long _ExtraData;

		// Token: 0x04000567 RID: 1383
		[CompilerGenerated]
		private bool _CanEdit;

		// Token: 0x04000568 RID: 1384
		[CompilerGenerated]
		private Form _Edit_Frm;

		// Token: 0x04000569 RID: 1385
		private SelectItem.SelectedValueChangingEventHandler SelectedValueChangingEvent;

		// Token: 0x0400056A RID: 1386
		private SelectItem.SelectedValueChangedEventHandler SelectedValueChangedEvent;

		// Token: 0x0400056B RID: 1387
		private SelectItem.ValueDeletedEventHandler ValueDeletedEvent;

		// Token: 0x020000A4 RID: 164
		// (Invoke) Token: 0x06000E2F RID: 3631
		public delegate void SelectedValueChangingEventHandler(object sender, EventArgs e);

		// Token: 0x020000A5 RID: 165
		// (Invoke) Token: 0x06000E33 RID: 3635
		public delegate void SelectedValueChangedEventHandler(object sender, EventArgs e);

		// Token: 0x020000A6 RID: 166
		// (Invoke) Token: 0x06000E37 RID: 3639
		public delegate void ValueDeletedEventHandler(object sender, EventArgs e);
	}
}
