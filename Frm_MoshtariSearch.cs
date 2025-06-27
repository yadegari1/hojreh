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
	// Token: 0x02000121 RID: 289
	[DesignerGenerated]
	public partial class Frm_MoshtariSearch : Form
	{
		// Token: 0x06002A20 RID: 10784 RVA: 0x0000A799 File Offset: 0x00008999
		[DebuggerNonUserCode]
		public Frm_MoshtariSearch()
		{
			base.KeyDown += new KeyEventHandler(this.Frm_MoshtariSearch_KeyDown);
			base.Load += new EventHandler(this.Frm_MoshtariSearch_Load);
			Frm_MoshtariSearch.__ENCAddToList(this);
			this.InitializeComponent();
		}

		// Token: 0x06002A21 RID: 10785 RVA: 0x001FB240 File Offset: 0x001F9440
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_MoshtariSearch.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_MoshtariSearch.__ENCList.Count == Frm_MoshtariSearch.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_MoshtariSearch.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_MoshtariSearch.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_MoshtariSearch.__ENCList[num] = Frm_MoshtariSearch.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_MoshtariSearch.__ENCList.RemoveRange(num, Frm_MoshtariSearch.__ENCList.Count - num);
						Frm_MoshtariSearch.__ENCList.Capacity = Frm_MoshtariSearch.__ENCList.Count;
					}
					Frm_MoshtariSearch.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000CD7 RID: 3287
		// (get) Token: 0x06002A24 RID: 10788 RVA: 0x001FBA44 File Offset: 0x001F9C44
		// (set) Token: 0x06002A25 RID: 10789 RVA: 0x0000A7D9 File Offset: 0x000089D9
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

		// Token: 0x17000CD8 RID: 3288
		// (get) Token: 0x06002A26 RID: 10790 RVA: 0x001FBA5C File Offset: 0x001F9C5C
		// (set) Token: 0x06002A27 RID: 10791 RVA: 0x0000A7E3 File Offset: 0x000089E3
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

		// Token: 0x17000CD9 RID: 3289
		// (get) Token: 0x06002A28 RID: 10792 RVA: 0x001FBA74 File Offset: 0x001F9C74
		// (set) Token: 0x06002A29 RID: 10793 RVA: 0x001FBA8C File Offset: 0x001F9C8C
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

		// Token: 0x17000CDA RID: 3290
		// (get) Token: 0x06002A2A RID: 10794 RVA: 0x001FBAEC File Offset: 0x001F9CEC
		// (set) Token: 0x06002A2B RID: 10795 RVA: 0x001FBB04 File Offset: 0x001F9D04
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
				RowLoadEventHandler value2 = new RowLoadEventHandler(this.GridEX1_LoadingRow);
				bool flag = this._GridEX1 != null;
				if (flag)
				{
					this._GridEX1.LoadingRow -= value2;
				}
				this._GridEX1 = value;
				flag = (this._GridEX1 != null);
				if (flag)
				{
					this._GridEX1.LoadingRow += value2;
				}
			}
		}

		// Token: 0x17000CDB RID: 3291
		// (get) Token: 0x06002A2C RID: 10796 RVA: 0x001FBB64 File Offset: 0x001F9D64
		// (set) Token: 0x06002A2D RID: 10797 RVA: 0x0000A7ED File Offset: 0x000089ED
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

		// Token: 0x17000CDC RID: 3292
		// (get) Token: 0x06002A2E RID: 10798 RVA: 0x001FBB7C File Offset: 0x001F9D7C
		// (set) Token: 0x06002A2F RID: 10799 RVA: 0x001FBB94 File Offset: 0x001F9D94
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

		// Token: 0x06002A30 RID: 10800 RVA: 0x001FBBF4 File Offset: 0x001F9DF4
		private void Frm_MoshtariSearch_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Escape;
			if (flag)
			{
				this.Close();
			}
			flag = (e.KeyCode == Keys.F6);
			if (flag)
			{
				Frm_Moshtari frm_Moshtari = new Frm_Moshtari();
				Frm_Moshtari arg_5D_0 = frm_Moshtari;
				object expr_4B = this.GridEX1.CurrentRow.Cells["ID"].Value;
				int? num;
				arg_5D_0.ID = ((expr_4B != null) ? ((int?)expr_4B) : num);
				frm_Moshtari.ShowDialog();
			}
		}

		// Token: 0x06002A31 RID: 10801 RVA: 0x001FBC70 File Offset: 0x001F9E70
		private void Frm_MoshtariSearch_Load(object sender, EventArgs e)
		{
			DataTable dataSource = Public_Function.FillData("SELECT     Moshtari.ID, Moshtari.Name+' '+ Moshtari.Family AS Moshtari_Name, Moshtari.shsh, Moshtari.CodeMelli, Moshtari.CodePosti, Moshtari.Tel1, Moshtari.Tel2, Moshtari.Tel3, Moshtari.Tel4,  Moshtari.Address, Moshtari.Address2, Moshtari.Fax, Moshtari.CodeEgtesadi, Moshtari.Moaref, Moshtari.kind, Moshtari.moaref_kind, Moshtari.karmozd,   Grouh_Moshtari.Name AS Grouh_Name, Grouh_Moshtari2.Name AS Grouh2_Name  FROM         Moshtari LEFT OUTER JOIN  Grouh_Moshtari ON Moshtari.GrouhMoshtari_ID = Grouh_Moshtari.ID LEFT OUTER JOIN  Grouh_Moshtari2 ON Moshtari.GrouhMoshtari2_ID = Grouh_Moshtari2.ID  where Moshtari.id> 0 and moshtari.id not in(select moshtari_id from sharik)");
			this.GridEX1.DataSource = dataSource;
			Public_Function.AddFilterColumn(this.GridEX1);
		}

		// Token: 0x06002A32 RID: 10802 RVA: 0x0000A7F7 File Offset: 0x000089F7
		private void EditBox1_TextChanged(object sender, EventArgs e)
		{
			Public_Function.FilterGrid(this.GridEX1, this.EditBox1.Text);
		}

		// Token: 0x06002A33 RID: 10803 RVA: 0x001FBCA4 File Offset: 0x001F9EA4
		private void GridEX1_LoadingRow(object sender, RowLoadEventArgs e)
		{
			bool flag = Operators.CompareString(this.EditBox1.Text, string.Empty, false) != 0;
			if (flag)
			{
				try
				{
					IEnumerator enumerator = ((IEnumerable)e.Row.Cells).GetEnumerator();
					while (enumerator.MoveNext())
					{
						GridEXCell gridEXCell = (GridEXCell)enumerator.Current;
						bool flag2 = gridEXCell.Value.ToString().Contains(this.EditBox1.Text);
						if (flag2)
						{
							gridEXCell.FormatStyle = new GridEXFormatStyle();
							gridEXCell.FormatStyle.BackColor = Color.Khaki;
						}
						flag2 = gridEXCell.Text.Contains(this.EditBox1.Text);
						if (flag2)
						{
							gridEXCell.FormatStyle = new GridEXFormatStyle();
							gridEXCell.FormatStyle.BackColor = Color.Khaki;
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

		// Token: 0x06002A34 RID: 10804 RVA: 0x001FBDB8 File Offset: 0x001F9FB8
		private void ButtonItem2_Click(object sender, EventArgs e)
		{
			Frm_Moshtari frm_Moshtari = new Frm_Moshtari();
			Frm_Moshtari arg_39_0 = frm_Moshtari;
			object expr_27 = this.GridEX1.CurrentRow.Cells["ID"].Value;
			int? num;
			arg_39_0.ID = ((expr_27 != null) ? ((int?)expr_27) : num);
			frm_Moshtari.ShowDialog();
		}

		// Token: 0x04001070 RID: 4208
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04001072 RID: 4210
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x04001073 RID: 4211
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04001074 RID: 4212
		[AccessedThroughProperty("EditBox1")]
		private EditBox _EditBox1;

		// Token: 0x04001075 RID: 4213
		[AccessedThroughProperty("GridEX1")]
		private DataEntryGrid _GridEX1;

		// Token: 0x04001076 RID: 4214
		[AccessedThroughProperty("Bar1")]
		private Bar _Bar1;

		// Token: 0x04001077 RID: 4215
		[AccessedThroughProperty("ButtonItem2")]
		private ButtonItem _ButtonItem2;
	}
}
