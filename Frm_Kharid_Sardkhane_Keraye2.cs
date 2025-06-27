using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using FruitBox.My;
using Janus.Windows.Common.Layouts;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.UI.Dock;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x020000F9 RID: 249
	[DesignerGenerated]
	public partial class Frm_Kharid_Sardkhane_Keraye2 : Form
	{
		// Token: 0x06001D77 RID: 7543 RVA: 0x0015B558 File Offset: 0x00159758
		public Frm_Kharid_Sardkhane_Keraye2()
		{
			base.FormClosing += new FormClosingEventHandler(this.Frm_RizKharid_FormClosing);
			base.KeyDown += new KeyEventHandler(this.Frm_RizKharid_KeyDown);
			base.Load += new EventHandler(this.Frm_RizKharid_Load);
			Frm_Kharid_Sardkhane_Keraye2.__ENCAddToList(this);
			this.frm = new Frm_SelectItem();
			this.Kharid_Keraye = new Kharid_Sardkhane_Keraye();
			this.prevent = false;
			this.InitializeComponent();
		}

		// Token: 0x06001D78 RID: 7544 RVA: 0x0015B5D4 File Offset: 0x001597D4
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_Kharid_Sardkhane_Keraye2.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_Kharid_Sardkhane_Keraye2.__ENCList.Count == Frm_Kharid_Sardkhane_Keraye2.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_Kharid_Sardkhane_Keraye2.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_Kharid_Sardkhane_Keraye2.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_Kharid_Sardkhane_Keraye2.__ENCList[num] = Frm_Kharid_Sardkhane_Keraye2.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_Kharid_Sardkhane_Keraye2.__ENCList.RemoveRange(num, Frm_Kharid_Sardkhane_Keraye2.__ENCList.Count - num);
						Frm_Kharid_Sardkhane_Keraye2.__ENCList.Capacity = Frm_Kharid_Sardkhane_Keraye2.__ENCList.Count;
					}
					Frm_Kharid_Sardkhane_Keraye2.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x1700090B RID: 2315
		// (get) Token: 0x06001D7B RID: 7547 RVA: 0x0015BD8C File Offset: 0x00159F8C
		// (set) Token: 0x06001D7C RID: 7548 RVA: 0x000080C3 File Offset: 0x000062C3
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

		// Token: 0x1700090C RID: 2316
		// (get) Token: 0x06001D7D RID: 7549 RVA: 0x0015BDA4 File Offset: 0x00159FA4
		// (set) Token: 0x06001D7E RID: 7550 RVA: 0x0015BDBC File Offset: 0x00159FBC
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
				KeyEventHandler value2 = new KeyEventHandler(this.GridEX1_KeyDown);
				InitCustomEditEventHandler value3 = new InitCustomEditEventHandler(this.GridEX1_InitCustomEdit);
				KeyPressEventHandler value4 = new KeyPressEventHandler(this.GridEX1_KeyPress);
				EndCustomEditEventHandler value5 = new EndCustomEditEventHandler(this.GridEX1_EndCustomEdit);
				ColumnActionEventHandler value6 = new ColumnActionEventHandler(this.GridEX1_ColumnButtonClick);
				EventHandler value7 = new EventHandler(this.GridEX1_RecordAdded);
				bool flag = this._GridEX1 != null;
				if (flag)
				{
					this._GridEX1.KeyDown -= value2;
					this._GridEX1.InitCustomEdit -= value3;
					this._GridEX1.KeyPress -= value4;
					this._GridEX1.EndCustomEdit -= value5;
					this._GridEX1.ColumnButtonClick -= value6;
					this._GridEX1.RecordAdded -= value7;
				}
				this._GridEX1 = value;
				flag = (this._GridEX1 != null);
				if (flag)
				{
					this._GridEX1.KeyDown += value2;
					this._GridEX1.InitCustomEdit += value3;
					this._GridEX1.KeyPress += value4;
					this._GridEX1.EndCustomEdit += value5;
					this._GridEX1.ColumnButtonClick += value6;
					this._GridEX1.RecordAdded += value7;
				}
			}
		}

		// Token: 0x1700090D RID: 2317
		// (get) Token: 0x06001D7F RID: 7551 RVA: 0x0015BEF0 File Offset: 0x0015A0F0
		// (set) Token: 0x06001D80 RID: 7552 RVA: 0x000080CD File Offset: 0x000062CD
		internal virtual CurrencyBox txt_mablagh
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_mablagh;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_mablagh = value;
			}
		}

		// Token: 0x1700090E RID: 2318
		// (get) Token: 0x06001D81 RID: 7553 RVA: 0x0015BF08 File Offset: 0x0015A108
		// (set) Token: 0x06001D82 RID: 7554 RVA: 0x000080D7 File Offset: 0x000062D7
		internal virtual DateBox2 txt_tarikhGrid
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_tarikhGrid;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_tarikhGrid = value;
			}
		}

		// Token: 0x1700090F RID: 2319
		// (get) Token: 0x06001D83 RID: 7555 RVA: 0x0015BF20 File Offset: 0x0015A120
		// (set) Token: 0x06001D84 RID: 7556 RVA: 0x000080E1 File Offset: 0x000062E1
		public DataTable Furush_Table
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Furush_Table;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Furush_Table = value;
			}
		}

		// Token: 0x17000910 RID: 2320
		// (get) Token: 0x06001D85 RID: 7557 RVA: 0x0015BF38 File Offset: 0x0015A138
		// (set) Token: 0x06001D86 RID: 7558 RVA: 0x000080EB File Offset: 0x000062EB
		public long Moshtari_ID
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Moshtari_ID;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Moshtari_ID = value;
			}
		}

		// Token: 0x17000911 RID: 2321
		// (get) Token: 0x06001D87 RID: 7559 RVA: 0x0015BF50 File Offset: 0x0015A150
		// (set) Token: 0x06001D88 RID: 7560 RVA: 0x000080F5 File Offset: 0x000062F5
		public DataTable dt_keraye
		{
			[DebuggerNonUserCode]
			get
			{
				return this._dt_keraye;
			}
			[DebuggerNonUserCode]
			set
			{
				this._dt_keraye = value;
			}
		}

		// Token: 0x17000912 RID: 2322
		// (get) Token: 0x06001D89 RID: 7561 RVA: 0x0015BF68 File Offset: 0x0015A168
		// (set) Token: 0x06001D8A RID: 7562 RVA: 0x000080FF File Offset: 0x000062FF
		public long Kharid_ID
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Kharid_ID;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Kharid_ID = value;
			}
		}

		// Token: 0x17000913 RID: 2323
		// (get) Token: 0x06001D8B RID: 7563 RVA: 0x0015BF80 File Offset: 0x0015A180
		// (set) Token: 0x06001D8C RID: 7564 RVA: 0x00008109 File Offset: 0x00006309
		public decimal Sum_Vazn
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Sum_Vazn;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Sum_Vazn = value;
			}
		}

		// Token: 0x17000914 RID: 2324
		// (get) Token: 0x06001D8D RID: 7565 RVA: 0x0015BF98 File Offset: 0x0015A198
		// (set) Token: 0x06001D8E RID: 7566 RVA: 0x00008113 File Offset: 0x00006313
		public string Furush_num
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Furush_num;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Furush_num = value;
			}
		}

		// Token: 0x06001D8F RID: 7567 RVA: 0x00147F90 File Offset: 0x00146190
		private void RemoveZero(DataTable dt)
		{
			try
			{
				IEnumerator enumerator = dt.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					bool flag = dataRow["tedad"] != DBNull.Value;
					if (flag)
					{
						dataRow["tedad"] = dataRow["tedad"].ToString().Replace(".0", "");
					}
					flag = (dataRow["vazn"] != DBNull.Value);
					if (flag)
					{
						dataRow["vazn"] = dataRow["vazn"].ToString().Replace(".0", "");
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

		// Token: 0x06001D90 RID: 7568 RVA: 0x00126BD8 File Offset: 0x00124DD8
		private void Adddt(DataTable dt)
		{
			bool flag = dt.Columns.Contains("dt");
			if (!flag)
			{
				dt.Columns.Add("dt", typeof(DataTable));
			}
		}

		// Token: 0x06001D91 RID: 7569 RVA: 0x0015BFB0 File Offset: 0x0015A1B0
		private void LoadData()
		{
			bool flag = this.dt_keraye == null;
			if (flag)
			{
				this.dt_keraye = this.Kharid_Keraye.GetByID(checked((int)this.Kharid_ID));
			}
			this.RemoveZero(this.dt_keraye);
			this.GridEX1.DataSource = this.dt_keraye;
			this.Adddt(this.dt_keraye);
		}

		// Token: 0x06001D92 RID: 7570 RVA: 0x0015C014 File Offset: 0x0015A214
		private void GetSum()
		{
			this.Sum_Vazn = decimal.Zero;
			GridEXRow[] rows = this.GridEX1.GetRows();
			checked
			{
				for (int i = 0; i < rows.Length; i++)
				{
					GridEXRow gridEXRow = rows[i];
					bool flag = gridEXRow.Cells["vazn_ba_zarf"].Value != DBNull.Value;
					if (flag)
					{
						this.Sum_Vazn = Conversions.ToDecimal(Operators.AddObject(this.Sum_Vazn, gridEXRow.Cells["vazn_ba_zarf"].Value));
					}
				}
			}
		}

		// Token: 0x06001D93 RID: 7571 RVA: 0x0015C0A8 File Offset: 0x0015A2A8
		private void Kala_select()
		{
			string command = "SELECT     Kala.ID, Kala.Name  FROM         Moshtari_Kala INNER JOIN  Kala ON Moshtari_Kala.Kala_ID = Kala.ID where Moshtari_ID=" + this.Moshtari_ID.ToString();
			this.frm.ExtraData = this.Moshtari_ID;
			bool flag = this.frm.ShowDialog(command, MyProject.Forms.Frm_Moshtari_kala, 0) == DialogResult.OK;
			checked
			{
				if (flag)
				{
					bool flag2 = this.GridEX1.Col == this.GridEX1.RootTable.Columns["Kala_Name"].Position && this.GridEX1.EditTextBox != null;
					if (flag2)
					{
						this.GridEX1.EditTextBox.Text = Conversions.ToString(this.frm.SelectedRow["Name"]);
						this.GridEX1.GetRow().Cells["Kala_ID"].Value = RuntimeHelpers.GetObjectValue(this.frm.SelectedRow["ID"]);
						DataEntryGrid gridEX = this.GridEX1;
						gridEX.Col++;
					}
				}
			}
		}

		// Token: 0x06001D94 RID: 7572 RVA: 0x0015C1C4 File Offset: 0x0015A3C4
		private void Delete(GridEXRow row)
		{
			bool flag = row.DataRow != null;
			if (flag)
			{
				DataRowView dataRowView = (DataRowView)row.DataRow;
				flag = (dataRowView["ID"] != DBNull.Value);
				if (flag)
				{
					int num = Conversions.ToInteger(NewLateBinding.LateGet(null, typeof(Public_Function), "ExecuteScalar", new object[]
					{
						Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select count(ID)  from daryaftpardakht where id=", dataRowView["Keraye_pardakht_ID"]), " OR parent_id="), dataRowView["Keraye_pardakht_ID"])
					}, null, null, null));
					flag = (num == 1);
					if (flag)
					{
						this.Kharid_Keraye.DeleteByID(Conversions.ToString(dataRowView["ID"]));
						this.GridEX1.CurrentRow.Delete();
					}
					else
					{
						DataTable dataTable = Public_Function.FillData(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select *  from daryaftpardakht where id=", dataRowView["Keraye_pardakht_ID"]), " OR parent_id="), dataRowView["Keraye_pardakht_ID"])));
						bool flag2 = true;
						try
						{
							IEnumerator enumerator = dataTable.Rows.GetEnumerator();
							while (enumerator.MoveNext())
							{
								DataRow dataRow = (DataRow)enumerator.Current;
								flag = (Operators.ConditionalCompareObjectNotEqual(dataRow["dptype_id"], -4, false) && Operators.ConditionalCompareObjectNotEqual(dataRow["dptype_id"], 10, false));
								if (flag)
								{
									flag2 = false;
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
						flag = flag2;
						if (flag)
						{
							this.Kharid_Keraye.DeleteByID(Conversions.ToString(dataRowView["ID"]));
							this.GridEX1.CurrentRow.Delete();
							Public_Function.InvokeMethod("Frm_DaryaftPardakht", "Refresh_Keraye", null);
						}
						else
						{
							Public_Function.ShowMessage("پرداخت مورد نظر دارای پرداخت چک و یا کارت به کارت میباشد" + Environment.NewLine + "لطفا در ابتدا اقدام به حذف موارد ذکر شده نمایید", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, null);
						}
					}
				}
				else
				{
					this.GridEX1.CurrentRow.Delete();
				}
			}
		}

		// Token: 0x06001D95 RID: 7573 RVA: 0x0015C40C File Offset: 0x0015A60C
		private void DelKala()
		{
			bool flag = this.GridEX1.CurrentRow != null;
			if (flag)
			{
				bool flag2 = this.GridEX1.CurrentRow.RowType == RowType.Record;
				if (flag2)
				{
					this.Delete(this.GridEX1.CurrentRow);
					((DataTable)this.GridEX1.DataSource).AcceptChanges();
				}
			}
		}

		// Token: 0x06001D96 RID: 7574 RVA: 0x0015C474 File Offset: 0x0015A674
		private void Hazine_Select()
		{
			string str = string.Empty;
			bool flag = !Conversions.ToBoolean(Public_Function.dict["showavaldore"]);
			if (flag)
			{
				str = " where id not in (-6)";
			}
			string command = "SELECT    ID,Name  From Hazine_Kharid" + str + " order by code";
			flag = (this.frm.ShowDialog(command, MyProject.Forms.Frm_Hazine_Kharid, 0) == DialogResult.OK);
			checked
			{
				if (flag)
				{
					bool flag2 = this.GridEX1.Col == this.GridEX1.RootTable.Columns["Hazine_Kharid_Name"].Position && this.GridEX1.EditTextBox != null;
					if (flag2)
					{
						this.GridEX1.EditTextBox.Text = Conversions.ToString(this.frm.SelectedRow["Name"]);
						this.GridEX1.GetRow().Cells["HazineKharid_ID"].Value = RuntimeHelpers.GetObjectValue(this.frm.SelectedRow["ID"]);
						DataEntryGrid gridEX = this.GridEX1;
						gridEX.Col++;
					}
				}
			}
		}

		// Token: 0x06001D97 RID: 7575 RVA: 0x0015C5A0 File Offset: 0x0015A7A0
		private void GridEX1_ColumnButtonClick(object sender, ColumnActionEventArgs e)
		{
			int position = e.Column.Position;
			bool flag = position == this.GridEX1.RootTable.Columns["hazine_kharid_Name"].Position;
			if (flag)
			{
				this.Hazine_Select();
			}
			else
			{
				flag = (position == this.GridEX1.RootTable.Columns["moshtari_Name"].Position);
				if (flag)
				{
					this.Moshtari_Select('\0');
				}
				else
				{
					flag = (position == this.GridEX1.RootTable.Columns["del"].Position);
					if (flag)
					{
						this.DelKala();
					}
					else
					{
						flag = (position == this.GridEX1.RootTable.Columns["mablagh"].Position);
						if (flag)
						{
							bool flag2 = this.GridEX1.CurrentRow.Cells["Hazine_Kharid_Name"].Value == DBNull.Value;
							if (!flag2)
							{
								Frm_PardakhtMoshtari frm_PardakhtMoshtari = new Frm_PardakhtMoshtari();
								frm_PardakhtMoshtari.Tarikh = this.GridEX1.CurrentRow.Cells["Tarikh_Fa"].Value.ToString();
								frm_PardakhtMoshtari.Tozih = "فروش شماره " + this.Furush_num;
								frm_PardakhtMoshtari.RibbonStatusBar1.Visible = false;
								frm_PardakhtMoshtari.Text = "پرداخت کرایه ";
								frm_PardakhtMoshtari.HazineKharid_Name = Conversions.ToString(this.GridEX1.CurrentRow.Cells["Hazine_Kharid_Name"].Value);
								frm_PardakhtMoshtari.HazineKharid_ID = Conversions.ToInteger(this.GridEX1.CurrentRow.Cells["HazineKharid_ID"].Value);
								frm_PardakhtMoshtari.Moshtari_ID = Conversions.ToString(this.Moshtari_ID);
								flag2 = (this.GridEX1.CurrentRow.Cells["mablagh"].Value != DBNull.Value);
								if (flag2)
								{
									frm_PardakhtMoshtari.Mablagh_Kol = Conversions.ToLong(this.GridEX1.CurrentRow.Cells["mablagh"].Value);
								}
								flag2 = (((DataRowView)this.GridEX1.CurrentRow.DataRow)["keraye_pardakht_id"] != DBNull.Value);
								if (flag2)
								{
									frm_PardakhtMoshtari.Pardakht_ID = Conversions.ToString(((DataRowView)this.GridEX1.CurrentRow.DataRow)["keraye_pardakht_id"]);
								}
								flag2 = (((DataRowView)this.GridEX1.CurrentRow.DataRow)["dt"] != DBNull.Value);
								if (flag2)
								{
									frm_PardakhtMoshtari.dt = (DataTable)((DataRowView)this.GridEX1.CurrentRow.DataRow)["dt"];
								}
								MyProject.Forms.Form_Main.Dialog_ShowForm(frm_PardakhtMoshtari);
								flag2 = (frm_PardakhtMoshtari.dt != null && frm_PardakhtMoshtari.dt.Rows.Count > 0);
								if (flag2)
								{
									((DataRowView)this.GridEX1.CurrentRow.DataRow)["dt"] = frm_PardakhtMoshtari.dt;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06001D98 RID: 7576 RVA: 0x00148A78 File Offset: 0x00146C78
		private void GridEX1_EndCustomEdit(object sender, EndCustomEditEventArgs e)
		{
			string left = e.Column.Key.ToLower();
			bool flag = Operators.CompareString(left, "tarikh_fa", false) == 0;
			if (flag)
			{
				e.Value = ((DateBox2)e.EditControl).Text;
			}
			else
			{
				flag = (Operators.CompareString(left, "mablagh", false) == 0);
				if (flag)
				{
					bool hasValue = ((CurrencyBox)e.EditControl).Value.HasValue;
					if (hasValue)
					{
						e.Value = ((CurrencyBox)e.EditControl).Value;
					}
				}
			}
		}

		// Token: 0x06001D99 RID: 7577 RVA: 0x0015C8E8 File Offset: 0x0015AAE8
		private void GridEX1_InitCustomEdit(object sender, InitCustomEditEventArgs e)
		{
			string left = e.Column.Key.ToLower();
			bool flag = Operators.CompareString(left, "tarikh_fa", false) == 0;
			if (flag)
			{
				e.EditControl = this.txt_tarikhGrid;
				this.txt_tarikhGrid.SetDate(e.Value.ToString());
			}
			else
			{
				flag = (Operators.CompareString(left, "mablagh", false) == 0);
				if (flag)
				{
					e.EditControl = this.txt_mablagh;
					flag = (e.Value != null);
					if (flag)
					{
						this.txt_mablagh.Text = e.Value.ToString();
					}
					else
					{
						this.txt_mablagh.Text = string.Empty;
					}
					this.txt_mablagh.SelectAll();
				}
			}
		}

		// Token: 0x06001D9A RID: 7578 RVA: 0x0015C9B0 File Offset: 0x0015ABB0
		private void Moshtari_Select(char chr = '\0')
		{
			this.frm.CanEdit = true;
			this.frm.CanDelete = false;
			this.frm.Edit_Frm = MyProject.Forms.Frm_Moshtari;
			this.frm.chara = chr;
			string text = string.Empty;
			bool flag = !Conversions.ToBoolean(Public_Function.dict["showavaldore"]);
			if (flag)
			{
				text = " where moshtari.id not in (-3";
			}
			flag = (Operators.CompareString(text, string.Empty, false) == 0);
			if (flag)
			{
				text = " where moshtari.id not in (-4,-5)";
			}
			else
			{
				text += " ,-4,-5)";
			}
			flag = (this.frm.ShowDialog("SELECT     Moshtari.ID,Moshtari.Code, Moshtari.Name + ' ' + Moshtari.Family AS name, case when GrouhMoshtari_ID is null then isnull(Grouh_Moshtari2.Name,'') else isnull(Grouh_Moshtari.Name,'') end AS Shahr FROM         Moshtari LEFT OUTER JOIN  Grouh_Moshtari2 ON Moshtari.GrouhMoshtari2_ID = Grouh_Moshtari2.ID LEFT OUTER JOIN  Grouh_Moshtari ON Moshtari.GrouhMoshtari_ID = Grouh_Moshtari.ID " + text + " order by moshtari.code ", MyProject.Forms.Frm_Moshtari, 0) == DialogResult.OK);
			checked
			{
				if (flag)
				{
					bool flag2 = this.GridEX1.Col == this.GridEX1.RootTable.Columns["moshtari_Name"].Position && this.GridEX1.EditTextBox != null;
					if (flag2)
					{
						this.GridEX1.EditTextBox.Text = Conversions.ToString(this.frm.SelectedRow["Name"]);
						this.GridEX1.GetRow().Cells["Moshtari_Id"].Value = RuntimeHelpers.GetObjectValue(this.frm.SelectedRow["ID"]);
						DataEntryGrid gridEX = this.GridEX1;
						gridEX.Col++;
					}
				}
			}
		}

		// Token: 0x06001D9B RID: 7579 RVA: 0x0015CB3C File Offset: 0x0015AD3C
		private void GridEX1_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = this.GridEX1.AllowEdit == InheritableBoolean.False;
			checked
			{
				if (!flag)
				{
					flag = (this.GridEX1.EditTextBox == null);
					bool flag2;
					if (flag)
					{
						flag2 = (this.GridEX1.GetRow().RowType == RowType.Record);
						if (flag2)
						{
							this.GridEX1.GetRow().BeginEdit();
						}
					}
					flag2 = (e.KeyCode == Keys.Delete);
					if (flag2)
					{
						flag = (this.GridEX1.EditTextBox != null);
						if (flag)
						{
							this.GridEX1.EditTextBox.Text = string.Empty;
						}
						flag2 = (this.GridEX1.Col == this.GridEX1.RootTable.Columns["moshtari_name"].Position);
						if (flag2)
						{
							this.GridEX1.CurrentRow.Cells["moshtari_ID"].Value = DBNull.Value;
						}
					}
					switch (e.KeyData)
					{
					case Keys.Left:
					{
						flag2 = (this.GridEX1.Col == this.GridEX1.RootTable.Columns["tarikh_fa"].Position);
						if (flag2)
						{
							e.SuppressKeyPress = true;
							return;
						}
						DataEntryGrid gridEX = this.GridEX1;
						gridEX.Col++;
						e.SuppressKeyPress = true;
						return;
					}
					case Keys.Up:
						flag2 = (this.GridEX1.Row > 0);
						if (flag2)
						{
							DataEntryGrid gridEX = this.GridEX1;
							gridEX.Row--;
							e.SuppressKeyPress = true;
							return;
						}
						this.GridEX1.MoveToNewRecord();
						this.GridEX1.Col = 0;
						this.GridEX1.EditMode = EditMode.EditOn;
						e.SuppressKeyPress = true;
						break;
					case Keys.Right:
						flag2 = (this.GridEX1.Col == this.GridEX1.RootTable.Columns["tarikh_fa"].Position);
						if (flag2)
						{
							e.SuppressKeyPress = true;
							return;
						}
						flag2 = (this.GridEX1.Col > 0);
						if (flag2)
						{
							DataEntryGrid gridEX = this.GridEX1;
							gridEX.Col--;
							e.SuppressKeyPress = true;
							return;
						}
						break;
					case Keys.Down:
						flag2 = (this.GridEX1.Row < this.GridEX1.RowCount - 1);
						if (flag2)
						{
							DataEntryGrid gridEX = this.GridEX1;
							gridEX.Row++;
							e.SuppressKeyPress = true;
							return;
						}
						break;
					}
					flag2 = (e.KeyCode == Keys.Return);
					if (flag2)
					{
						int col = this.GridEX1.Col;
						flag = (col == this.GridEX1.RootTable.Columns["Tarikh_Fa"].Position);
						if (flag)
						{
							bool flag3 = this.prevent;
							if (flag3)
							{
								e.SuppressKeyPress = true;
								this.prevent = false;
							}
							else
							{
								DataEntryGrid gridEX = this.GridEX1;
								gridEX.Col++;
							}
						}
						else
						{
							bool flag3 = col == this.GridEX1.RootTable.Columns["hazine_kharid_Name"].Position;
							if (flag3)
							{
								flag2 = (Operators.CompareString(this.GridEX1.EditTextBox.Text, string.Empty, false) == 0);
								if (flag2)
								{
									this.Hazine_Select();
								}
								else
								{
									DataEntryGrid gridEX = this.GridEX1;
									gridEX.Col++;
								}
							}
							else
							{
								flag3 = (col == this.GridEX1.RootTable.Columns["moshtari_name"].Position);
								if (flag3)
								{
									flag2 = (Operators.CompareString(this.GridEX1.EditTextBox.Text, string.Empty, false) == 0);
									if (flag2)
									{
										this.Moshtari_Select('\0');
									}
									else
									{
										DataEntryGrid gridEX = this.GridEX1;
										gridEX.Col++;
									}
								}
								else
								{
									flag3 = (col == this.GridEX1.RootTable.Columns["mablagh"].Position);
									if (flag3)
									{
										flag2 = (this.GridEX1.CurrentRow.RowType == RowType.Record);
										if (flag2)
										{
											flag = (this.GridEX1.Row + 1 <= this.GridEX1.RowCount - 1);
											if (flag)
											{
												DataEntryGrid gridEX = this.GridEX1;
												gridEX.Row++;
												this.prevent = true;
												this.GridEX1.Col = this.GridEX1.RootTable.Columns["Tarikh_Fa"].Position;
											}
											else
											{
												this.GridEX1.MoveToNewRecord();
												this.GridEX1.Col = 0;
											}
										}
										flag3 = (this.GridEX1.CurrentRow.RowType == RowType.NewRecord);
										if (flag3)
										{
											this.GridEX1.UpdateData();
											this.GridEX1.MoveToNewRecord();
											this.GridEX1.Col = 0;
											this.GridEX1.EditMode = EditMode.EditOn;
										}
									}
									else
									{
										DataEntryGrid gridEX = this.GridEX1;
										gridEX.Col++;
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06001D9C RID: 7580 RVA: 0x0015D0A8 File Offset: 0x0015B2A8
		private bool ValidateGridData()
		{
			this.GridEX1.UpdateData();
			DataTable dataTable = (DataTable)this.GridEX1.DataSource;
			int i = 0;
			checked
			{
				while (i <= dataTable.Rows.Count - 1)
				{
					bool flag = dataTable.Rows[i].RowState == DataRowState.Deleted;
					if (flag)
					{
						i++;
					}
					else
					{
						flag = (dataTable.Rows[i]["keraye"] == DBNull.Value && dataTable.Rows[i]["hazinekharid_id"] == DBNull.Value);
						if (flag)
						{
							dataTable.Rows[i].Delete();
							i--;
						}
						i++;
					}
				}
				dataTable.AcceptChanges();
				int num = 0;
				bool result;
				try
				{
					IEnumerator enumerator = dataTable.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						bool flag = dataRow["keraye"] == DBNull.Value;
						if (flag)
						{
							Public_Function.GridRaiseSoftError(this.GridEX1, this.GridEX1.GetRows()[num], "mablagh", "کرایه را وارد نمایید");
							result = false;
							return result;
						}
						flag = (dataRow["hazinekharid_id"] == DBNull.Value);
						if (flag)
						{
							Public_Function.GridRaiseSoftError(this.GridEX1, this.GridEX1.GetRows()[num], "hazine_kharid_name", "نوع هزینه را وارد نمایید");
							result = false;
							return result;
						}
						flag = Conversions.ToBoolean(Public_Function.dict["sardkhane_keraye_moshtari"]);
						if (flag)
						{
							bool flag2 = dataRow["moshtari_name"] == DBNull.Value;
							if (flag2)
							{
								Public_Function.GridRaiseSoftError(this.GridEX1, this.GridEX1.GetRows()[num], "moshtari_name", "مشتری را وارد نمایید");
								result = false;
								return result;
							}
						}
						num++;
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
				result = true;
				return result;
			}
		}

		// Token: 0x06001D9D RID: 7581 RVA: 0x0015D2E4 File Offset: 0x0015B4E4
		private void Frm_RizKharid_FormClosing(object sender, FormClosingEventArgs e)
		{
			bool flag = this.ValidateGridData();
			if (flag)
			{
				this.GetSum();
			}
			else
			{
				e.Cancel = true;
			}
		}

		// Token: 0x06001D9E RID: 7582 RVA: 0x0006620C File Offset: 0x0006440C
		private void Frm_RizKharid_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Escape;
			if (flag)
			{
				this.Close();
			}
		}

		// Token: 0x06001D9F RID: 7583 RVA: 0x0015D310 File Offset: 0x0015B510
		private void Frm_RizKharid_Load(object sender, EventArgs e)
		{
			ItemCollection itemCollection = new ItemCollection();
			itemCollection.Add(new Column("Name", "عنوان", 100));
			this.frm.items = itemCollection;
			bool flag = Conversions.ToBoolean(Public_Function.dict["sardkhane_keraye_moshtari"]);
			if (flag)
			{
				this.GridEX1.RootTable.Columns["moshtari_name"].Visible = true;
			}
			else
			{
				this.GridEX1.RootTable.Columns["moshtari_name"].Visible = false;
			}
			flag = Conversions.ToBoolean(Public_Function.dict["sardkhane_keraye_tozih"]);
			if (flag)
			{
				this.GridEX1.RootTable.Columns["tozih"].Visible = true;
			}
			else
			{
				this.GridEX1.RootTable.Columns["tozih"].Visible = false;
			}
			this.LoadData();
			this.GridEX1.MoveToNewRecord();
			this.GridEX1.Col = 0;
			this.GridEX1.EditMode = EditMode.EditOn;
		}

		// Token: 0x06001DA0 RID: 7584 RVA: 0x0015D434 File Offset: 0x0015B634
		private void GridEX1_KeyPress(object sender, KeyPressEventArgs e)
		{
			bool flag = this.GridEX1.Col == this.GridEX1.RootTable.Columns["hazine_Kharid_name"].Position;
			if (flag)
			{
				e.Handled = true;
			}
		}

		// Token: 0x06001DA1 RID: 7585 RVA: 0x0015D47C File Offset: 0x0015B67C
		private void GridEX1_RecordAdded(object sender, EventArgs e)
		{
			GridEXRow[] rows = this.GridEX1.GetRows();
			checked
			{
				for (int i = 0; i < rows.Length; i++)
				{
					GridEXRow gridEXRow = rows[i];
					bool flag = gridEXRow.Cells["Kala_ID"].Value == DBNull.Value && gridEXRow.Cells["hazinekharid_id"].Value == DBNull.Value;
					if (flag)
					{
						gridEXRow.Delete();
						break;
					}
				}
			}
		}

		// Token: 0x04000B77 RID: 2935
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000B79 RID: 2937
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x04000B7A RID: 2938
		[AccessedThroughProperty("GridEX1")]
		private DataEntryGrid _GridEX1;

		// Token: 0x04000B7B RID: 2939
		[AccessedThroughProperty("txt_mablagh")]
		private CurrencyBox _txt_mablagh;

		// Token: 0x04000B7C RID: 2940
		[AccessedThroughProperty("txt_tarikhGrid")]
		private DateBox2 _txt_tarikhGrid;

		// Token: 0x04000B7D RID: 2941
		private Frm_SelectItem frm;

		// Token: 0x04000B7E RID: 2942
		private Kharid_Sardkhane_Keraye Kharid_Keraye;

		// Token: 0x04000B7F RID: 2943
		[CompilerGenerated]
		private DataTable _Furush_Table;

		// Token: 0x04000B80 RID: 2944
		[CompilerGenerated]
		private long _Moshtari_ID;

		// Token: 0x04000B81 RID: 2945
		[CompilerGenerated]
		private DataTable _dt_keraye;

		// Token: 0x04000B82 RID: 2946
		[CompilerGenerated]
		private long _Kharid_ID;

		// Token: 0x04000B83 RID: 2947
		[CompilerGenerated]
		private decimal _Sum_Vazn;

		// Token: 0x04000B84 RID: 2948
		[CompilerGenerated]
		private string _Furush_num;

		// Token: 0x04000B85 RID: 2949
		private bool prevent;
	}
}
