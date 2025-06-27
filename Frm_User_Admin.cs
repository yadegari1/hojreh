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
using DevComponents.DotNetBar;
using FruitBox.My;
using FruitBox.My.Resources;
using Janus.Windows.ButtonBar;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.UI.Dock;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x02000085 RID: 133
	[DesignerGenerated]
	public partial class Frm_User_Admin : Form
	{
		// Token: 0x06000BA5 RID: 2981 RVA: 0x000915D8 File Offset: 0x0008F7D8
		public Frm_User_Admin()
		{
			base.Activated += new EventHandler(this.Frm_User_Admin_Activated);
			base.KeyDown += new KeyEventHandler(this.Frm_User_Admin_KeyDown);
			base.Load += new EventHandler(this.Frm_User_Admin_Load);
			Frm_User_Admin.__ENCAddToList(this);
			this.users = new base_user();
			this._controls = new Base_Controls();
			this.user_control = new Base_User_Control();
			this.InitializeComponent();
		}

		// Token: 0x06000BA6 RID: 2982 RVA: 0x00091658 File Offset: 0x0008F858
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_User_Admin.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_User_Admin.__ENCList.Count == Frm_User_Admin.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_User_Admin.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_User_Admin.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_User_Admin.__ENCList[num] = Frm_User_Admin.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_User_Admin.__ENCList.RemoveRange(num, Frm_User_Admin.__ENCList.Count - num);
						Frm_User_Admin.__ENCList.Capacity = Frm_User_Admin.__ENCList.Count;
					}
					Frm_User_Admin.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x1700039A RID: 922
		// (get) Token: 0x06000BA9 RID: 2985 RVA: 0x00092360 File Offset: 0x00090560
		// (set) Token: 0x06000BAA RID: 2986 RVA: 0x0000462C File Offset: 0x0000282C
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

		// Token: 0x1700039B RID: 923
		// (get) Token: 0x06000BAB RID: 2987 RVA: 0x00092378 File Offset: 0x00090578
		// (set) Token: 0x06000BAC RID: 2988 RVA: 0x00004636 File Offset: 0x00002836
		public virtual Bar Bar1
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

		// Token: 0x1700039C RID: 924
		// (get) Token: 0x06000BAD RID: 2989 RVA: 0x00092390 File Offset: 0x00090590
		// (set) Token: 0x06000BAE RID: 2990 RVA: 0x000923A8 File Offset: 0x000905A8
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
				EventHandler value2 = new EventHandler(this.ButtonItem1_Click);
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

		// Token: 0x1700039D RID: 925
		// (get) Token: 0x06000BAF RID: 2991 RVA: 0x00092408 File Offset: 0x00090608
		// (set) Token: 0x06000BB0 RID: 2992 RVA: 0x00092420 File Offset: 0x00090620
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

		// Token: 0x1700039E RID: 926
		// (get) Token: 0x06000BB1 RID: 2993 RVA: 0x00092480 File Offset: 0x00090680
		// (set) Token: 0x06000BB2 RID: 2994 RVA: 0x00092498 File Offset: 0x00090698
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

		// Token: 0x1700039F RID: 927
		// (get) Token: 0x06000BB3 RID: 2995 RVA: 0x000924F8 File Offset: 0x000906F8
		// (set) Token: 0x06000BB4 RID: 2996 RVA: 0x00092510 File Offset: 0x00090710
		internal virtual ButtonBar ButtonBar1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonBar1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				ItemEventHandler value2 = new ItemEventHandler(this.ButtonBar1_ItemClick);
				bool flag = this._ButtonBar1 != null;
				if (flag)
				{
					this._ButtonBar1.ItemClick -= value2;
				}
				this._ButtonBar1 = value;
				flag = (this._ButtonBar1 != null);
				if (flag)
				{
					this._ButtonBar1.ItemClick += value2;
				}
			}
		}

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x06000BB5 RID: 2997 RVA: 0x00092570 File Offset: 0x00090770
		// (set) Token: 0x06000BB6 RID: 2998 RVA: 0x00092588 File Offset: 0x00090788
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
				RowCheckStateChangeEventHandler value2 = new RowCheckStateChangeEventHandler(this.GridEX1_RowCheckStateChanged);
				RowLoadEventHandler value3 = new RowLoadEventHandler(this.GridEX1_FormattingRow);
				bool flag = this._GridEX1 != null;
				if (flag)
				{
					this._GridEX1.RowCheckStateChanged -= value2;
					this._GridEX1.FormattingRow -= value3;
				}
				this._GridEX1 = value;
				flag = (this._GridEX1 != null);
				if (flag)
				{
					this._GridEX1.RowCheckStateChanged += value2;
					this._GridEX1.FormattingRow += value3;
				}
			}
		}

		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x06000BB7 RID: 2999 RVA: 0x00092610 File Offset: 0x00090810
		// (set) Token: 0x06000BB8 RID: 3000 RVA: 0x00004640 File Offset: 0x00002840
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

		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x06000BB9 RID: 3001 RVA: 0x00092628 File Offset: 0x00090828
		// (set) Token: 0x06000BBA RID: 3002 RVA: 0x0000464A File Offset: 0x0000284A
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

		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x06000BBB RID: 3003 RVA: 0x00092640 File Offset: 0x00090840
		// (set) Token: 0x06000BBC RID: 3004 RVA: 0x00004654 File Offset: 0x00002854
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

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x06000BBD RID: 3005 RVA: 0x00092658 File Offset: 0x00090858
		// (set) Token: 0x06000BBE RID: 3006 RVA: 0x0000465E File Offset: 0x0000285E
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

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x06000BBF RID: 3007 RVA: 0x00092670 File Offset: 0x00090870
		// (set) Token: 0x06000BC0 RID: 3008 RVA: 0x00004668 File Offset: 0x00002868
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

		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x06000BC1 RID: 3009 RVA: 0x00092688 File Offset: 0x00090888
		// (set) Token: 0x06000BC2 RID: 3010 RVA: 0x000926A0 File Offset: 0x000908A0
		internal virtual ButtonItem ButtonItem4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem4_Click);
				bool flag = this._ButtonItem4 != null;
				if (flag)
				{
					this._ButtonItem4.Click -= value2;
				}
				this._ButtonItem4 = value;
				flag = (this._ButtonItem4 != null);
				if (flag)
				{
					this._ButtonItem4.Click += value2;
				}
			}
		}

		// Token: 0x06000BC3 RID: 3011 RVA: 0x00092700 File Offset: 0x00090900
		private void GetChillds(Control ctl, long ID)
		{
			try
			{
				IEnumerator enumerator = ctl.Controls.GetEnumerator();
				while (enumerator.MoveNext())
				{
					Control control = (Control)enumerator.Current;
					bool flag = control is Bar;
					if (flag)
					{
						try
						{
							IEnumerator enumerator2 = ((Bar)control).Items.GetEnumerator();
							while (enumerator2.MoveNext())
							{
								ButtonItem buttonItem = (ButtonItem)enumerator2.Current;
								this.dr = this._controls.GetID(buttonItem.Text, Conversions.ToString(ID));
								flag = (this.dr == null);
								if (flag)
								{
									this._controls.Insert(buttonItem.Text, Conversions.ToString(ID), "");
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
					}
					this.GetChillds(control, ID);
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

		// Token: 0x06000BC4 RID: 3012 RVA: 0x00092834 File Offset: 0x00090A34
		private long InsertUpdateItem(string name, long? Parent_ID, string ids = "")
		{
			DataRow iD = this._controls.GetID(name, Parent_ID.ToString());
			bool flag = iD == null;
			long result;
			if (flag)
			{
				result = (long)this._controls.Insert(name, Parent_ID.ToString(), ids);
			}
			else
			{
				result = Conversions.ToLong(iD["ID"]);
			}
			return result;
		}

		// Token: 0x06000BC5 RID: 3013 RVA: 0x0009289C File Offset: 0x00090A9C
		private void GetMenuChilds(ButtonItem ctl, long Parent_ID)
		{
			bool flag = ctl.SubItems.Count > 0;
			if (flag)
			{
				try
				{
					IEnumerator enumerator = ctl.SubItems.GetEnumerator();
					while (enumerator.MoveNext())
					{
						BaseItem baseItem = (BaseItem)enumerator.Current;
						bool flag2 = baseItem is ButtonItem;
						if (flag2)
						{
							long num = this.InsertUpdateItem(baseItem.Text, Parent_ID, "");
							this.GetMenuChilds((ButtonItem)baseItem, Parent_ID);
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

		// Token: 0x06000BC6 RID: 3014 RVA: 0x00092954 File Offset: 0x00090B54
		private void Sync2()
		{
			long? parent_ID2;
			try
			{
				IEnumerator enumerator = MyProject.Forms.Form_Main.Bar1.Items.GetEnumerator();
				while (enumerator.MoveNext())
				{
					BaseItem baseItem = (BaseItem)enumerator.Current;
					bool flag = baseItem is LabelItem;
					if (!flag)
					{
						long parent_ID = this.InsertUpdateItem(baseItem.Text, parent_ID2, "");
						this.GetMenuChilds((ButtonItem)baseItem, parent_ID);
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
			PropertyInfo[] properties = MyProject.Forms.GetType().GetProperties();
			int i = 0;
			checked
			{
				while (i < properties.Length)
				{
					PropertyInfo propertyInfo = properties[i];
					bool flag = propertyInfo.PropertyType.IsSubclassOf(typeof(Form));
					if (flag)
					{
						Form form = (Form)Activator.CreateInstance(propertyInfo.PropertyType);
						this.dr = this._controls.GetID(form.Text, "is not null");
						flag = (this.dr == null);
						if (flag)
						{
							form.Dispose();
						}
						else
						{
							this.GetChillds(form, Conversions.ToLong(this.dr["ID"]));
							form.Dispose();
						}
					}
					IL_138:
					i++;
					continue;
					goto IL_138;
				}
				long parent_ID = this.InsertUpdateItem("سربرگ ها", parent_ID2, "-1");
				try
				{
					IEnumerator enumerator2 = ((IEnumerable)MyProject.Forms.Form_Main.UiPanelManager1.Panels).GetEnumerator();
					while (enumerator2.MoveNext())
					{
						UIPanel uIPanel = (UIPanel)enumerator2.Current;
						this.InsertUpdateItem(uIPanel.Text, -1L, "");
					}
				}
				finally
				{
					IEnumerator enumerator2;
					bool flag = enumerator2 is IDisposable;
					if (flag)
					{
						(enumerator2 as IDisposable).Dispose();
					}
				}
			}
		}

		// Token: 0x06000BC7 RID: 3015 RVA: 0x00092B5C File Offset: 0x00090D5C
		private void Sync()
		{
			try
			{
				IEnumerator enumerator = MyProject.Forms.Form_Main.ButtonBar1.Groups.GetEnumerator();
				while (enumerator.MoveNext())
				{
					ButtonBarGroup buttonBarGroup = (ButtonBarGroup)enumerator.Current;
					DataRow iD = this._controls.GetID(buttonBarGroup.Text, "");
					bool flag = iD == null;
					int value;
					if (flag)
					{
						value = this._controls.Insert(buttonBarGroup.Text, "", "");
					}
					else
					{
						value = Conversions.ToInteger(iD["ID"]);
					}
					try
					{
						IEnumerator enumerator2 = MyProject.Forms.Form_Main.ButtonBar1.Groups[buttonBarGroup.Key].Items.GetEnumerator();
						while (enumerator2.MoveNext())
						{
							ButtonBarItem buttonBarItem = (ButtonBarItem)enumerator2.Current;
							iD = this._controls.GetID(buttonBarItem.Text, Conversions.ToString(value));
							flag = (iD == null);
							if (flag)
							{
								this._controls.Insert(buttonBarItem.Text, Conversions.ToString(value), "");
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
			PropertyInfo[] properties = MyProject.Forms.GetType().GetProperties();
			int i = 0;
			checked
			{
				while (i < properties.Length)
				{
					PropertyInfo propertyInfo = properties[i];
					bool flag = propertyInfo.PropertyType.IsSubclassOf(typeof(Form));
					if (flag)
					{
						Form form = (Form)Activator.CreateInstance(propertyInfo.PropertyType);
						DataRow iD = this._controls.GetID(form.Text, "is not null");
						flag = (iD == null);
						if (flag)
						{
							form.Dispose();
						}
						else
						{
							this.GetChillds(form, Conversions.ToLong(iD["ID"]));
						}
					}
					IL_1FB:
					i++;
					continue;
					goto IL_1FB;
				}
			}
		}

		// Token: 0x06000BC8 RID: 3016 RVA: 0x00004672 File Offset: 0x00002872
		private void Frm_User_Admin_Activated(object sender, EventArgs e)
		{
			this.GridEX1.RootTable.Columns["name"].Width = 500;
		}

		// Token: 0x06000BC9 RID: 3017 RVA: 0x00092DB4 File Offset: 0x00090FB4
		private void Frm_User_Admin_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.F1 && true;
			if (flag)
			{
				this.Sync2();
				Public_Function.ShowMessage("اطلاعات مدیریت کاربران بروز رسانی گردید", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, null);
			}
			flag = (e.KeyCode == Keys.Escape);
			if (flag)
			{
				this.Close();
			}
			Keys keyCode = e.KeyCode;
			flag = (keyCode == Keys.Insert);
			if (flag)
			{
				this.ButtonItem1_Click(null, null);
			}
			else
			{
				flag = (keyCode == Keys.F2);
				if (flag)
				{
					this.ButtonItem2_Click(null, null);
				}
				else
				{
					flag = (keyCode == Keys.F5);
					if (flag)
					{
						this.ButtonItem3_Click(null, null);
					}
				}
			}
		}

		// Token: 0x06000BCA RID: 3018 RVA: 0x00092E4C File Offset: 0x0009104C
		private void Frm_User_Admin_Load(object sender, EventArgs e)
		{
			this.is_new = true;
			this.dt = this.users.GetAll();
			try
			{
				IEnumerator enumerator = this.dt.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					ButtonBarItem buttonBarItem = new ButtonBarItem(Conversions.ToString(dataRow["UserName"]));
					buttonBarItem.Image = Resources.user;
					buttonBarItem.ImageAlignment = Alignment.Far;
					buttonBarItem.TextAlignment = Alignment.Center;
					this.ButtonBar1.Groups[0].Items.Add(buttonBarItem);
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
			DataTable all = this._controls.GetAll();
			this.GridEX1.DataSource = all;
			this.GridEX1.CheckAllRecords();
		}

		// Token: 0x06000BCB RID: 3019 RVA: 0x00092F48 File Offset: 0x00091148
		private void GridEX1_FormattingRow(object sender, RowLoadEventArgs e)
		{
			GridEXRow[] rows = this.GridEX1.GetRows();
			checked
			{
				for (int i = 0; i < rows.Length; i++)
				{
					GridEXRow gridEXRow = rows[i];
					bool flag = ((DataRowView)gridEXRow.DataRow)["Parent_ID"] == DBNull.Value;
					if (flag)
					{
						bool flag2 = gridEXRow.Cells["Name"].Image == null;
						if (flag2)
						{
							gridEXRow.Cells["Name"].Image = Resources.folder;
						}
						GridEXRow[] childRows = gridEXRow.GetChildRows();
						for (int j = 0; j < childRows.Length; j++)
						{
							GridEXRow gridEXRow2 = childRows[j];
							flag2 = (gridEXRow2.Cells["Name"].Image == null);
							if (flag2)
							{
								gridEXRow2.Cells["Name"].Image = Resources.application;
							}
							GridEXRow[] childRows2 = gridEXRow2.GetChildRows();
							for (int k = 0; k < childRows2.Length; k++)
							{
								GridEXRow gridEXRow3 = childRows2[k];
								flag2 = (gridEXRow3.Cells["Name"].Image == null);
								if (flag2)
								{
									gridEXRow3.Cells["Name"].Image = Resources.shape_move_forwards;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000BCC RID: 3020 RVA: 0x000930B0 File Offset: 0x000912B0
		private void GridEX1_RowCheckStateChanged(object sender, RowCheckStateChangeEventArgs e)
		{
			GridEXRow[] childRows = e.Row.GetChildRows();
			checked
			{
				for (int i = 0; i < childRows.Length; i++)
				{
					GridEXRow gridEXRow = childRows[i];
					gridEXRow.CheckState = e.Row.CheckState;
					GridEXRow[] childRows2 = gridEXRow.GetChildRows();
					for (int j = 0; j < childRows2.Length; j++)
					{
						GridEXRow gridEXRow2 = childRows2[j];
						gridEXRow2.CheckState = gridEXRow.CheckState;
					}
				}
			}
		}

		// Token: 0x06000BCD RID: 3021 RVA: 0x0009312C File Offset: 0x0009132C
		private void ButtonItem1_Click(object sender, EventArgs e)
		{
			Public_Function.SetNew(this.UiGroupBox2);
			this.GridEX1.CheckAllRecords();
			this.EditBox1.Enabled = true;
			this.EditBox1.Focus();
			this.is_new = true;
			this.userdr = null;
		}

		// Token: 0x06000BCE RID: 3022 RVA: 0x0009317C File Offset: 0x0009137C
		private void ButtonItem2_Click(object sender, EventArgs e)
		{
			bool flag = Public_Function.HasNull(this.UiGroupBox2);
			checked
			{
				if (!flag)
				{
					flag = this.is_new;
					if (flag)
					{
						bool flag2 = Public_Function.ExistValue("Users", "UserName", this.EditBox1.Text);
						if (flag2)
						{
							this.EditBox1.ShowTip("نام کاربری انتخاب شده تکراری میباشد");
							return;
						}
						int value = this.users.Insert(this.EditBox1.Text, this.EditBox2.Text);
						GridEXRow[] uncheckedRows = this.GridEX1.GetUncheckedRows();
						for (int i = 0; i < uncheckedRows.Length; i++)
						{
							GridEXRow gridEXRow = uncheckedRows[i];
							this.user_control.Insert(Conversions.ToString(value), Conversions.ToString(((DataRowView)gridEXRow.DataRow)["ID"]));
						}
						this.AddButtonBarItem(this.EditBox1.Text);
						this.is_new = false;
						this.EditBox1.Enabled = false;
					}
					else
					{
						int value = Conversions.ToInteger(this.userdr["ID"]);
						this.users.UpdateUser(this.EditBox2.Text, Conversions.ToString(value));
						this.user_control.DeleteUserPermission(Conversions.ToString(value));
						GridEXRow[] uncheckedRows2 = this.GridEX1.GetUncheckedRows();
						for (int j = 0; j < uncheckedRows2.Length; j++)
						{
							GridEXRow gridEXRow2 = uncheckedRows2[j];
							this.user_control.Insert(Conversions.ToString(value), Conversions.ToString(((DataRowView)gridEXRow2.DataRow)["ID"]));
						}
					}
					Public_Function.ConfirmInsert();
				}
			}
		}

		// Token: 0x06000BCF RID: 3023 RVA: 0x00093334 File Offset: 0x00091534
		private void UncheckRow(GridEXRow Row, int id)
		{
			GridEXRow[] childRows = Row.GetChildRows();
			checked
			{
				for (int i = 0; i < childRows.Length; i++)
				{
					GridEXRow gridEXRow = childRows[i];
					bool flag = Operators.ConditionalCompareObjectEqual(((DataRowView)gridEXRow.DataRow)["ID"], id, false);
					if (flag)
					{
						gridEXRow.CheckState = RowCheckState.Unchecked;
					}
					else
					{
						this.UncheckRow(gridEXRow, id);
					}
				}
			}
		}

		// Token: 0x06000BD0 RID: 3024 RVA: 0x0009339C File Offset: 0x0009159C
		private void UncheckRow(int id)
		{
			GridEXRow[] rows = this.GridEX1.GetRows();
			checked
			{
				for (int i = 0; i < rows.Length; i++)
				{
					GridEXRow gridEXRow = rows[i];
					bool flag = Operators.ConditionalCompareObjectEqual(((DataRowView)gridEXRow.DataRow)["ID"], id, false);
					if (flag)
					{
						gridEXRow.CheckState = RowCheckState.Unchecked;
						break;
					}
					this.UncheckRow(gridEXRow, id);
				}
			}
		}

		// Token: 0x06000BD1 RID: 3025 RVA: 0x0009340C File Offset: 0x0009160C
		private void ButtonBar1_ItemClick(object sender, ItemEventArgs e)
		{
			this.is_new = false;
			this.EditBox1.Enabled = false;
			this.GridEX1.CheckAllRecords();
			this.userdr = this.users.GetByName(e.Item.Text);
			this.EditBox1.Text = e.Item.Text;
			this.EditBox2.Text = Conversions.ToString(this.userdr["Password"]);
			DataTable userPermission = this.user_control.GetUserPermission(e.Item.Text);
			try
			{
				IEnumerator enumerator = userPermission.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					this.UncheckRow(Conversions.ToInteger(dataRow["Control_ID"]));
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

		// Token: 0x06000BD2 RID: 3026 RVA: 0x0009351C File Offset: 0x0009171C
		private void AddButtonBarItem(string Name)
		{
			ButtonBarItem buttonBarItem = new ButtonBarItem(Name);
			buttonBarItem.Image = Resources.user;
			buttonBarItem.ImageAlignment = Alignment.Far;
			buttonBarItem.TextAlignment = Alignment.Center;
			this.ButtonBar1.Groups[0].Items.Add(buttonBarItem);
			buttonBarItem.InvokeOnClick();
		}

		// Token: 0x06000BD3 RID: 3027 RVA: 0x00093574 File Offset: 0x00091774
		private void DeleteButtonBarItem(string Name)
		{
			try
			{
				IEnumerator enumerator = this.ButtonBar1.Groups[0].Items.GetEnumerator();
				while (enumerator.MoveNext())
				{
					ButtonBarItem buttonBarItem = (ButtonBarItem)enumerator.Current;
					bool flag = Operators.CompareString(buttonBarItem.Text, Name, false) == 0;
					if (flag)
					{
						this.ButtonBar1.Groups[0].Items.Remove(buttonBarItem);
						break;
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

		// Token: 0x06000BD4 RID: 3028 RVA: 0x00093620 File Offset: 0x00091820
		private void ButtonItem3_Click(object sender, EventArgs e)
		{
			bool flag = this.userdr == null;
			if (!flag)
			{
				flag = (Public_Function.ConfirmDelete() == DialogResult.Yes);
				if (flag)
				{
					this.users.DeleteUser(Conversions.ToString(this.userdr["ID"]));
					this.DeleteButtonBarItem(Conversions.ToString(this.userdr["UserName"]));
				}
				Public_Function.ConfirmInsert();
				this.ButtonItem1_Click(null, null);
			}
		}

		// Token: 0x06000BD5 RID: 3029 RVA: 0x0000469B File Offset: 0x0000289B
		private void ButtonItem4_Click(object sender, EventArgs e)
		{
			this.Sync2();
			Public_Function.ShowMessage("اطلاعات مدیریت کاربران بروز رسانی گردید", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, null);
		}

		// Token: 0x04000499 RID: 1177
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x0400049B RID: 1179
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x0400049C RID: 1180
		[AccessedThroughProperty("Bar1")]
		private Bar _Bar1;

		// Token: 0x0400049D RID: 1181
		[AccessedThroughProperty("ButtonItem1")]
		private ButtonItem _ButtonItem1;

		// Token: 0x0400049E RID: 1182
		[AccessedThroughProperty("ButtonItem2")]
		private ButtonItem _ButtonItem2;

		// Token: 0x0400049F RID: 1183
		[AccessedThroughProperty("ButtonItem3")]
		private ButtonItem _ButtonItem3;

		// Token: 0x040004A0 RID: 1184
		[AccessedThroughProperty("ButtonBar1")]
		private ButtonBar _ButtonBar1;

		// Token: 0x040004A1 RID: 1185
		[AccessedThroughProperty("GridEX1")]
		private GridEX _GridEX1;

		// Token: 0x040004A2 RID: 1186
		[AccessedThroughProperty("UiGroupBox2")]
		private UIGroupBox _UiGroupBox2;

		// Token: 0x040004A3 RID: 1187
		[AccessedThroughProperty("EditBox2")]
		private EditBox _EditBox2;

		// Token: 0x040004A4 RID: 1188
		[AccessedThroughProperty("EditBox1")]
		private EditBox _EditBox1;

		// Token: 0x040004A5 RID: 1189
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x040004A6 RID: 1190
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x040004A7 RID: 1191
		[AccessedThroughProperty("ButtonItem4")]
		private ButtonItem _ButtonItem4;

		// Token: 0x040004A8 RID: 1192
		private base_user users;

		// Token: 0x040004A9 RID: 1193
		private Base_Controls _controls;

		// Token: 0x040004AA RID: 1194
		private Base_User_Control user_control;

		// Token: 0x040004AB RID: 1195
		private DataTable dt;

		// Token: 0x040004AC RID: 1196
		private DataRow dr;

		// Token: 0x040004AD RID: 1197
		private bool is_new;

		// Token: 0x040004AE RID: 1198
		private DataRow userdr;
	}
}
