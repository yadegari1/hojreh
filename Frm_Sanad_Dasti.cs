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
	// Token: 0x0200010D RID: 269
	[DesignerGenerated]
	public partial class Frm_Sanad_Dasti : Form
	{
		// Token: 0x06002694 RID: 9876 RVA: 0x001D288C File Offset: 0x001D0A8C
		public Frm_Sanad_Dasti()
		{
			base.FormClosing += new FormClosingEventHandler(this.Frm_Sanad_Dasti_FormClosing);
			base.KeyDown += new KeyEventHandler(this.Frm_Sanad_Dasti_KeyDown);
			base.Load += new EventHandler(this.Frm_Sanad_Dasti_Load);
			Frm_Sanad_Dasti.__ENCAddToList(this);
			this.frm = new Frm_SelectItem();
			this.InitializeComponent();
		}

		// Token: 0x06002695 RID: 9877 RVA: 0x001D28F8 File Offset: 0x001D0AF8
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_Sanad_Dasti.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_Sanad_Dasti.__ENCList.Count == Frm_Sanad_Dasti.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_Sanad_Dasti.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_Sanad_Dasti.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_Sanad_Dasti.__ENCList[num] = Frm_Sanad_Dasti.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_Sanad_Dasti.__ENCList.RemoveRange(num, Frm_Sanad_Dasti.__ENCList.Count - num);
						Frm_Sanad_Dasti.__ENCList.Capacity = Frm_Sanad_Dasti.__ENCList.Count;
					}
					Frm_Sanad_Dasti.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000BCE RID: 3022
		// (get) Token: 0x06002698 RID: 9880 RVA: 0x001D35CC File Offset: 0x001D17CC
		// (set) Token: 0x06002699 RID: 9881 RVA: 0x00009A11 File Offset: 0x00007C11
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

		// Token: 0x17000BCF RID: 3023
		// (get) Token: 0x0600269A RID: 9882 RVA: 0x001D35E4 File Offset: 0x001D17E4
		// (set) Token: 0x0600269B RID: 9883 RVA: 0x001D35FC File Offset: 0x001D17FC
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
				InitCustomEditEventHandler value2 = new InitCustomEditEventHandler(this.GridEX1_InitCustomEdit);
				KeyEventHandler value3 = new KeyEventHandler(this.GridEX1_KeyDown);
				EndCustomEditEventHandler value4 = new EndCustomEditEventHandler(this.GridEX1_EndCustomEdit);
				ColumnActionEventHandler value5 = new ColumnActionEventHandler(this.GridEX1_ColumnButtonClick);
				bool flag = this._GridEX1 != null;
				if (flag)
				{
					this._GridEX1.InitCustomEdit -= value2;
					this._GridEX1.KeyDown -= value3;
					this._GridEX1.EndCustomEdit -= value4;
					this._GridEX1.ColumnButtonClick -= value5;
				}
				this._GridEX1 = value;
				flag = (this._GridEX1 != null);
				if (flag)
				{
					this._GridEX1.InitCustomEdit += value2;
					this._GridEX1.KeyDown += value3;
					this._GridEX1.EndCustomEdit += value4;
					this._GridEX1.ColumnButtonClick += value5;
				}
			}
		}

		// Token: 0x17000BD0 RID: 3024
		// (get) Token: 0x0600269C RID: 9884 RVA: 0x001D36D8 File Offset: 0x001D18D8
		// (set) Token: 0x0600269D RID: 9885 RVA: 0x00009A1B File Offset: 0x00007C1B
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

		// Token: 0x17000BD1 RID: 3025
		// (get) Token: 0x0600269E RID: 9886 RVA: 0x001D36F0 File Offset: 0x001D18F0
		// (set) Token: 0x0600269F RID: 9887 RVA: 0x001D3708 File Offset: 0x001D1908
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

		// Token: 0x17000BD2 RID: 3026
		// (get) Token: 0x060026A0 RID: 9888 RVA: 0x001D3768 File Offset: 0x001D1968
		// (set) Token: 0x060026A1 RID: 9889 RVA: 0x001D3780 File Offset: 0x001D1980
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

		// Token: 0x17000BD3 RID: 3027
		// (get) Token: 0x060026A2 RID: 9890 RVA: 0x001D37E0 File Offset: 0x001D19E0
		// (set) Token: 0x060026A3 RID: 9891 RVA: 0x00009A25 File Offset: 0x00007C25
		internal virtual CurrencyBox txt_bes
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_bes;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_bes = value;
			}
		}

		// Token: 0x17000BD4 RID: 3028
		// (get) Token: 0x060026A4 RID: 9892 RVA: 0x001D37F8 File Offset: 0x001D19F8
		// (set) Token: 0x060026A5 RID: 9893 RVA: 0x00009A2F File Offset: 0x00007C2F
		internal virtual CurrencyBox txt_bed
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_bed;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_bed = value;
			}
		}

		// Token: 0x17000BD5 RID: 3029
		// (get) Token: 0x060026A6 RID: 9894 RVA: 0x001D3810 File Offset: 0x001D1A10
		// (set) Token: 0x060026A7 RID: 9895 RVA: 0x00009A39 File Offset: 0x00007C39
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
				this._UiComboBox1 = value;
			}
		}

		// Token: 0x17000BD6 RID: 3030
		// (get) Token: 0x060026A8 RID: 9896 RVA: 0x001D3828 File Offset: 0x001D1A28
		// (set) Token: 0x060026A9 RID: 9897 RVA: 0x00009A43 File Offset: 0x00007C43
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

		// Token: 0x17000BD7 RID: 3031
		// (get) Token: 0x060026AA RID: 9898 RVA: 0x001D3840 File Offset: 0x001D1A40
		// (set) Token: 0x060026AB RID: 9899 RVA: 0x00009A4D File Offset: 0x00007C4D
		internal virtual EditBox txt_desc
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_desc;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_desc = value;
			}
		}

		// Token: 0x17000BD8 RID: 3032
		// (get) Token: 0x060026AC RID: 9900 RVA: 0x001D3858 File Offset: 0x001D1A58
		// (set) Token: 0x060026AD RID: 9901 RVA: 0x00009A57 File Offset: 0x00007C57
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

		// Token: 0x17000BD9 RID: 3033
		// (get) Token: 0x060026AE RID: 9902 RVA: 0x001D3870 File Offset: 0x001D1A70
		// (set) Token: 0x060026AF RID: 9903 RVA: 0x00009A61 File Offset: 0x00007C61
		public string Tarikh
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Tarikh;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Tarikh = value;
			}
		}

		// Token: 0x17000BDA RID: 3034
		// (get) Token: 0x060026B0 RID: 9904 RVA: 0x001D3888 File Offset: 0x001D1A88
		// (set) Token: 0x060026B1 RID: 9905 RVA: 0x00009A6B File Offset: 0x00007C6B
		public string Daryaftpardakht_ID
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Daryaftpardakht_ID;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Daryaftpardakht_ID = value;
			}
		}

		// Token: 0x17000BDB RID: 3035
		// (get) Token: 0x060026B2 RID: 9906 RVA: 0x001D38A0 File Offset: 0x001D1AA0
		// (set) Token: 0x060026B3 RID: 9907 RVA: 0x00009A75 File Offset: 0x00007C75
		public bool dorp
		{
			[DebuggerNonUserCode]
			get
			{
				return this._dorp;
			}
			[DebuggerNonUserCode]
			set
			{
				this._dorp = value;
			}
		}

		// Token: 0x17000BDC RID: 3036
		// (get) Token: 0x060026B4 RID: 9908 RVA: 0x001D38B8 File Offset: 0x001D1AB8
		// (set) Token: 0x060026B5 RID: 9909 RVA: 0x00009A7F File Offset: 0x00007C7F
		public long Mablagh
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Mablagh;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Mablagh = value;
			}
		}

		// Token: 0x17000BDD RID: 3037
		// (get) Token: 0x060026B6 RID: 9910 RVA: 0x001D38D0 File Offset: 0x001D1AD0
		// (set) Token: 0x060026B7 RID: 9911 RVA: 0x00009A89 File Offset: 0x00007C89
		public string Tozih
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Tozih;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Tozih = value;
			}
		}

		// Token: 0x060026B8 RID: 9912 RVA: 0x001D38E8 File Offset: 0x001D1AE8
		private void LoadData()
		{
			DataTable dataTable = Public_Function.FillData("SELECT     Sanad_Dasti_Detail.ID, Sanad_Dasti_Detail.Hesab_Type, Sanad_Dasti_Detail.Sandugh_id, Sanad_Dasti_Detail.Moshtari_id, Sanad_Dasti_Detail.BankHesab_ID,   Sanad_Dasti_Detail.Hazine_ID, Sanad_Dasti_Detail.Daramad_ID, Sanad_Dasti_Detail.bed, Sanad_Dasti_Detail.bes, Sanad_Dasti_Detail.Sanad_ID,   Sanad_Dasti_Detail.[Desc], Bank.Name + ' ' + Bank_Hesab.Shobe + ' - ' + Bank_Hesab.SahebHesab AS BankHesab_Name,   Moshtari.Name + ' ' + Moshtari.Family AS Moshtari_name, Hazine.Name AS Hazine_Name, Daramad.Name AS Daramad_Name,   Hesab_Type.Name AS Hesab_Name,case sanad_dasti_detail.hesab_type when 1 then 1 when 2 then moshtari.codehesab_id when 3 then bank_hesab.codehesab_mojodi when 4 then hazine.codehesab_id when 5 then daramad.codehesab_id end as codehesab_id   FROM         Sanad_Dasti INNER JOIN     Sanad_Dasti_Detail ON Sanad_Dasti.ID = Sanad_Dasti_Detail.Sanad_Dasti_id LEFT OUTER JOIN     Hesab_Type ON Sanad_Dasti_Detail.Hesab_Type = Hesab_Type.ID LEFT OUTER JOIN     Daramad ON Sanad_Dasti_Detail.Daramad_ID = Daramad.ID LEFT OUTER JOIN     Hazine ON Sanad_Dasti_Detail.Hazine_ID = Hazine.ID LEFT OUTER JOIN     Moshtari ON Sanad_Dasti_Detail.Moshtari_id = Moshtari.ID LEFT OUTER JOIN     Bank LEFT OUTER JOIN     Bank_Hesab ON Bank.ID = Bank_Hesab.Bank_ID ON Sanad_Dasti_Detail.BankHesab_ID = Bank_Hesab.ID where tarikh=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.Tarikh)));
			dataTable.Columns.Add(new DataColumn("hesab", typeof(string)));
			bool flag = dataTable.Rows.Count > 0;
			if (flag)
			{
				this.Daryaftpardakht_ID = Conversions.ToString(Public_Function.ExecuteScalar("select dp_id from sanad_dasti where tarikh=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.Tarikh))));
			}
			try
			{
				IEnumerator enumerator = dataTable.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					object left = dataRow["hesab_type"];
					flag = Operators.ConditionalCompareObjectEqual(left, 1, false);
					if (flag)
					{
						dataRow["hesab"] = "صندوق";
					}
					else
					{
						flag = Operators.ConditionalCompareObjectEqual(left, 2, false);
						if (flag)
						{
							dataRow["hesab"] = RuntimeHelpers.GetObjectValue(dataRow["moshtari_name"]);
						}
						else
						{
							flag = Operators.ConditionalCompareObjectEqual(left, 3, false);
							if (flag)
							{
								dataRow["hesab"] = RuntimeHelpers.GetObjectValue(dataRow["bankhesab_name"]);
							}
							else
							{
								flag = Operators.ConditionalCompareObjectEqual(left, 4, false);
								if (flag)
								{
									dataRow["hesab"] = RuntimeHelpers.GetObjectValue(dataRow["hazine_name"]);
								}
								else
								{
									flag = Operators.ConditionalCompareObjectEqual(left, 5, false);
									if (flag)
									{
										dataRow["hesab"] = RuntimeHelpers.GetObjectValue(dataRow["daramad_name"]);
									}
								}
							}
						}
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
			DataRow dataRow2 = Public_Function.FillDataRow("select * from sanad_dasti where tarikh=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.Tarikh)));
			flag = (dataRow2 != null);
			if (flag)
			{
				bool flag2 = Operators.ConditionalCompareObjectEqual(dataRow2["dorp"], 1, false);
				if (flag2)
				{
					this.UiComboBox1.SelectedIndex = 0;
				}
				else
				{
					this.UiComboBox1.SelectedIndex = 1;
				}
				this.txt_desc.Text = dataRow2["desc"].ToString();
			}
			this.GridEX1.DataSource = dataTable;
			this.GridEX1.MoveToNewRecord();
			this.GridEX1.Col = 0;
			this.GridEX1.EditMode = EditMode.EditOn;
		}

		// Token: 0x060026B9 RID: 9913 RVA: 0x001D3BA4 File Offset: 0x001D1DA4
		private void Frm_Sanad_Dasti_FormClosing(object sender, FormClosingEventArgs e)
		{
			DataTable dataTable = (DataTable)this.GridEX1.DataSource;
			dataTable.AcceptChanges();
			bool flag = this.UiComboBox1.SelectedIndex == 0;
			bool dorp = flag;
			this.dorp = dorp;
			this.Mablagh = Conversions.ToLong(Public_Function.GetSum(dataTable, "bed"));
			this.Tozih = this.txt_desc.Text;
		}

		// Token: 0x060026BA RID: 9914 RVA: 0x001D3C18 File Offset: 0x001D1E18
		private void Frm_Sanad_Dasti_KeyDown(object sender, KeyEventArgs e)
		{
			Keys keyCode = e.KeyCode;
			bool flag = keyCode == Keys.Escape;
			if (flag)
			{
				this.Close();
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

		// Token: 0x060026BB RID: 9915 RVA: 0x001D3C6C File Offset: 0x001D1E6C
		private void Frm_Sanad_Dasti_Load(object sender, EventArgs e)
		{
			ItemCollection itemCollection = new ItemCollection();
			itemCollection.Add(new Column("ID", "کد", 15));
			itemCollection.Add(new Column("Name", "عنوان", 65));
			this.frm.items = itemCollection;
			this.LoadData();
			bool flag = this.UiComboBox1.SelectedIndex == -1;
			if (flag)
			{
				this.UiComboBox1.SelectedIndex = 0;
			}
		}

		// Token: 0x060026BC RID: 9916 RVA: 0x001D3CE8 File Offset: 0x001D1EE8
		private void HesabName_Select()
		{
			DataTable dt = Public_Function.FillData("select id,Name  from [Hesab_Type] ");
			bool flag = this.frm.ShowDialog(dt, null, "انتخاب نوع حساب") == DialogResult.OK;
			checked
			{
				if (flag)
				{
					bool flag2 = this.GridEX1.Col == this.GridEX1.RootTable.Columns["hesab_name"].Position;
					if (flag2)
					{
						this.GridEX1.EditMode = EditMode.EditOn;
						this.GridEX1.EditTextBox.Text = Conversions.ToString(this.frm.SelectedRow["Name"]);
						this.GridEX1.GetRow().Cells["hesab_type"].Value = RuntimeHelpers.GetObjectValue(this.frm.SelectedRow["ID"]);
					}
					flag2 = Operators.ConditionalCompareObjectEqual(this.frm.SelectedRow["ID"], 1, false);
					if (flag2)
					{
						this.GridEX1.GetRow().Cells["hesab"].Value = "صندوق";
						this.GridEX1.GetRow().Cells["hesab_id"].Value = 1;
						this.GridEX1.GetRow().Cells["codehesab_id"].Value = 1;
						((DataRowView)this.GridEX1.GetRow().DataRow)["sandugh_id"] = 1;
						DataEntryGrid gridEX = this.GridEX1;
						gridEX.Col += 2;
					}
					else
					{
						DataEntryGrid gridEX = this.GridEX1;
						gridEX.Col++;
					}
					this.GridEX1.EditMode = EditMode.EditOn;
					this.GridEX1.GetRow().BeginEdit();
				}
			}
		}

		// Token: 0x060026BD RID: 9917 RVA: 0x001D3ED0 File Offset: 0x001D20D0
		private void Hesab_select()
		{
			bool flag = this.GridEX1.CurrentRow.Cells["hesab_type"].Value == DBNull.Value;
			checked
			{
				if (!flag)
				{
					object value = this.GridEX1.CurrentRow.Cells["hesab_type"].Value;
					flag = Operators.ConditionalCompareObjectEqual(value, 2, false);
					if (flag)
					{
						this.frm.CanEdit = true;
						this.frm.Edit_Frm = MyProject.Forms.Frm_Moshtari;
						((ItemCollection)this.frm.items)[0].Name = "code";
						flag = (this.frm.ShowDialog("SELECT     Moshtari.ID,Moshtari.Code,codehesab_id, Moshtari.Name + ' ' + Moshtari.Family AS name, case when GrouhMoshtari_ID is null then isnull(Grouh_Moshtari2.Name,'') else isnull(Grouh_Moshtari.Name,'') end AS Shahr FROM         Moshtari LEFT OUTER JOIN  Grouh_Moshtari2 ON Moshtari.GrouhMoshtari2_ID = Grouh_Moshtari2.ID LEFT OUTER JOIN  Grouh_Moshtari ON Moshtari.GrouhMoshtari_ID = Grouh_Moshtari.ID WHERE     (Moshtari.ID > 0) order by moshtari.code", MyProject.Forms.Frm_Moshtari, 650) == DialogResult.OK);
						if (flag)
						{
							bool flag2 = this.GridEX1.Col == this.GridEX1.RootTable.Columns["hesab"].Position && this.GridEX1.EditTextBox != null;
							if (flag2)
							{
								this.GridEX1.EditTextBox.Text = Conversions.ToString(this.frm.SelectedRow["Name"]);
								this.GridEX1.GetRow().Cells["hesab_id"].Value = RuntimeHelpers.GetObjectValue(this.frm.SelectedRow["ID"]);
								this.GridEX1.GetRow().Cells["codehesab_id"].Value = RuntimeHelpers.GetObjectValue(this.frm.SelectedRow["codehesab_id"]);
								((DataRowView)this.GridEX1.GetRow().DataRow)["moshtari_id"] = RuntimeHelpers.GetObjectValue(this.frm.SelectedRow["id"]);
								DataEntryGrid gridEX = this.GridEX1;
								gridEX.Col++;
								this.GridEX1.EditMode = EditMode.EditOn;
							}
						}
						((ItemCollection)this.frm.items)[0].Name = "ID";
						this.frm.CanEdit = false;
						this.frm.Edit_Frm = null;
					}
					else
					{
						bool flag2 = Operators.ConditionalCompareObjectEqual(value, 3, false);
						if (flag2)
						{
							this.frm.CanEdit = true;
							this.frm.Edit_Frm = MyProject.Forms.Frm_Bank_Hesab;
							flag2 = (this.frm.ShowDialog("SELECT    Bank_Hesab.ID,codehesab_mojodi, Bank.Name+' '+ Bank_Hesab.Shobe +' - '+ Bank_Hesab.SahebHesab as name FROM Bank_Hesab INNER JOIN Bank ON Bank_Hesab.Bank_ID = Bank.ID ", MyProject.Forms.Frm_Bank_Hesab, 0) == DialogResult.OK);
							if (flag2)
							{
								flag = (this.GridEX1.Col == this.GridEX1.RootTable.Columns["hesab"].Position && this.GridEX1.EditTextBox != null);
								if (flag)
								{
									this.GridEX1.EditTextBox.Text = Conversions.ToString(this.frm.SelectedRow["Name"]);
									this.GridEX1.GetRow().Cells["hesab_id"].Value = RuntimeHelpers.GetObjectValue(this.frm.SelectedRow["ID"]);
									this.GridEX1.GetRow().Cells["codehesab_id"].Value = RuntimeHelpers.GetObjectValue(this.frm.SelectedRow["codehesab_mojodi"]);
									((DataRowView)this.GridEX1.GetRow().DataRow)["bankhesab_id"] = RuntimeHelpers.GetObjectValue(this.frm.SelectedRow["id"]);
									DataEntryGrid gridEX = this.GridEX1;
									gridEX.Col++;
									this.GridEX1.EditMode = EditMode.EditOn;
								}
							}
							this.frm.CanEdit = false;
							this.frm.Edit_Frm = null;
						}
						else
						{
							flag2 = Operators.ConditionalCompareObjectEqual(value, 4, false);
							if (flag2)
							{
								this.frm.CanEdit = true;
								this.frm.Edit_Frm = MyProject.Forms.Frm_Hazine;
								flag2 = (this.frm.ShowDialog("select id,Name,codehesab_id from Hazine ", MyProject.Forms.Frm_Hazine, 0) == DialogResult.OK);
								if (flag2)
								{
									flag = (this.GridEX1.Col == this.GridEX1.RootTable.Columns["hesab"].Position && this.GridEX1.EditTextBox != null);
									if (flag)
									{
										this.GridEX1.EditTextBox.Text = Conversions.ToString(this.frm.SelectedRow["Name"]);
										this.GridEX1.GetRow().Cells["hesab_id"].Value = RuntimeHelpers.GetObjectValue(this.frm.SelectedRow["ID"]);
										this.GridEX1.GetRow().Cells["codehesab_id"].Value = RuntimeHelpers.GetObjectValue(this.frm.SelectedRow["codehesab_id"]);
										((DataRowView)this.GridEX1.GetRow().DataRow)["hazine_id"] = RuntimeHelpers.GetObjectValue(this.frm.SelectedRow["id"]);
										DataEntryGrid gridEX = this.GridEX1;
										gridEX.Col++;
										this.GridEX1.EditMode = EditMode.EditOn;
									}
								}
								this.frm.CanEdit = false;
								this.frm.Edit_Frm = null;
							}
							else
							{
								flag2 = Operators.ConditionalCompareObjectEqual(value, 5, false);
								if (flag2)
								{
									this.frm.CanEdit = true;
									this.frm.Edit_Frm = MyProject.Forms.Frm_Daramad;
									flag2 = (this.frm.ShowDialog("select id,Name,codehesab_id  from daramad ", MyProject.Forms.Frm_Daramad, 0) == DialogResult.OK);
									if (flag2)
									{
										flag = (this.GridEX1.Col == this.GridEX1.RootTable.Columns["hesab"].Position && this.GridEX1.EditTextBox != null);
										if (flag)
										{
											this.GridEX1.EditTextBox.Text = Conversions.ToString(this.frm.SelectedRow["Name"]);
											this.GridEX1.GetRow().Cells["hesab_id"].Value = RuntimeHelpers.GetObjectValue(this.frm.SelectedRow["ID"]);
											this.GridEX1.GetRow().Cells["codehesab_id"].Value = RuntimeHelpers.GetObjectValue(this.frm.SelectedRow["codehesab_id"]);
											((DataRowView)this.GridEX1.GetRow().DataRow)["daramad_id"] = RuntimeHelpers.GetObjectValue(this.frm.SelectedRow["id"]);
											DataEntryGrid gridEX = this.GridEX1;
											gridEX.Col++;
											this.GridEX1.EditMode = EditMode.EditOn;
										}
									}
									this.frm.CanEdit = false;
									this.frm.Edit_Frm = null;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060026BE RID: 9918 RVA: 0x001D4680 File Offset: 0x001D2880
		private void GridEX1_ColumnButtonClick(object sender, ColumnActionEventArgs e)
		{
			int position = e.Column.Position;
			bool flag = position == this.GridEX1.RootTable.Columns["hesab_name"].Position;
			if (flag)
			{
				this.HesabName_Select();
			}
			else
			{
				flag = (position == this.GridEX1.RootTable.Columns["hesab"].Position);
				if (flag)
				{
					this.Hesab_select();
				}
			}
		}

		// Token: 0x060026BF RID: 9919 RVA: 0x001D46FC File Offset: 0x001D28FC
		private void GridEX1_EndCustomEdit(object sender, EndCustomEditEventArgs e)
		{
			bool flag = Operators.CompareString(e.Column.Key.ToLower(), "bed", false) == 0;
			bool flag2;
			long? value;
			if (flag)
			{
				flag2 = (e.EditControl == null);
				if (flag2)
				{
					return;
				}
				flag2 = ((CurrencyBox)e.EditControl).Value.HasValue;
				if (flag2)
				{
					flag = (e.Row.DataRow == null);
					if (flag)
					{
						return;
					}
					e.Row.Cells["bed"].Value = ((CurrencyBox)e.EditControl).Value;
					((CurrencyBox)e.EditControl).Value = value;
				}
			}
			flag2 = (Operators.CompareString(e.Column.Key.ToLower(), "bes", false) == 0);
			if (flag2)
			{
				flag = (e.EditControl == null);
				if (!flag)
				{
					flag2 = ((CurrencyBox)e.EditControl).Value.HasValue;
					if (flag2)
					{
						flag = (e.Row.DataRow == null);
						if (!flag)
						{
							e.Row.Cells["bes"].Value = ((CurrencyBox)e.EditControl).Value;
							((CurrencyBox)e.EditControl).Value = value;
						}
					}
				}
			}
		}

		// Token: 0x060026C0 RID: 9920 RVA: 0x001D4868 File Offset: 0x001D2A68
		private void GridEX1_InitCustomEdit(object sender, InitCustomEditEventArgs e)
		{
			bool flag = Operators.CompareString(e.Column.Key.ToLower(), "bed", false) == 0;
			if (flag)
			{
				e.EditControl = this.txt_bed;
				this.txt_bed.Text = e.Value.ToString();
				this.txt_bed.SelectAll();
			}
			flag = (Operators.CompareString(e.Column.Key.ToLower(), "bes", false) == 0);
			if (flag)
			{
				e.EditControl = this.txt_bes;
				this.txt_bes.Text = e.Value.ToString();
				this.txt_bes.SelectAll();
			}
		}

		// Token: 0x060026C1 RID: 9921 RVA: 0x001D4920 File Offset: 0x001D2B20
		private void GridEX1_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Delete;
			if (flag)
			{
				bool flag2 = this.GridEX1.Row == -1;
				if (flag2)
				{
					bool flag3 = this.GridEX1.EditTextBox != null;
					if (flag3)
					{
						this.GridEX1.EditTextBox.Text = string.Empty;
					}
				}
				else
				{
					bool flag3 = this.GridEX1.Col == 0;
					if (flag3)
					{
						e.SuppressKeyPress = true;
					}
					else
					{
						flag3 = (this.GridEX1.EditTextBox != null);
						if (flag3)
						{
							this.GridEX1.EditTextBox.Text = string.Empty;
						}
					}
				}
			}
			checked
			{
				bool flag3;
				switch (e.KeyData)
				{
				case Keys.Left:
				{
					DataEntryGrid gridEX = this.GridEX1;
					gridEX.Col++;
					this.GridEX1.EditMode = EditMode.EditOn;
					e.SuppressKeyPress = true;
					return;
				}
				case Keys.Up:
					flag3 = (this.GridEX1.Row > 0);
					if (flag3)
					{
						DataEntryGrid gridEX = this.GridEX1;
						gridEX.Row--;
						this.GridEX1.EditMode = EditMode.EditOn;
						e.SuppressKeyPress = true;
						return;
					}
					this.GridEX1.MoveToNewRecord();
					this.GridEX1.Col = 0;
					this.GridEX1.EditMode = EditMode.EditOn;
					e.SuppressKeyPress = true;
					break;
				case Keys.Right:
					flag3 = (this.GridEX1.Col > 0);
					if (flag3)
					{
						DataEntryGrid gridEX = this.GridEX1;
						gridEX.Col--;
						this.GridEX1.EditMode = EditMode.EditOn;
						e.SuppressKeyPress = true;
						return;
					}
					break;
				case Keys.Down:
					flag3 = (this.GridEX1.Row < this.GridEX1.RowCount - 1);
					if (flag3)
					{
						DataEntryGrid gridEX = this.GridEX1;
						gridEX.Row++;
						this.GridEX1.EditMode = EditMode.EditOn;
						e.SuppressKeyPress = true;
						return;
					}
					break;
				}
				flag3 = (e.KeyCode == Keys.Return);
				if (flag3)
				{
					int col = this.GridEX1.Col;
					bool flag2 = col == this.GridEX1.RootTable.Columns["hesab_name"].Position;
					if (flag2)
					{
						flag = (this.GridEX1.EditTextBox == null);
						if (flag)
						{
							return;
						}
						flag3 = (Operators.CompareString(this.GridEX1.EditTextBox.Text, string.Empty, false) == 0);
						if (flag3)
						{
							this.HesabName_Select();
						}
						else
						{
							DataEntryGrid gridEX = this.GridEX1;
							gridEX.Col++;
							this.GridEX1.EditMode = EditMode.EditOn;
						}
					}
					else
					{
						flag3 = (col == this.GridEX1.RootTable.Columns["hesab"].Position);
						if (flag3)
						{
							flag2 = (this.GridEX1.EditTextBox == null);
							if (flag2)
							{
								return;
							}
							flag3 = (Operators.CompareString(this.GridEX1.EditTextBox.Text, string.Empty, false) == 0);
							if (flag3)
							{
								this.Hesab_select();
							}
							else
							{
								DataEntryGrid gridEX = this.GridEX1;
								gridEX.Col++;
								this.GridEX1.EditMode = EditMode.EditOn;
							}
						}
						else
						{
							flag3 = (col == this.GridEX1.RootTable.Columns["desc"].Position);
							if (flag3)
							{
								this.GridEX1.UpdateData();
								this.GridEX1.MoveToNewRecord();
								this.GridEX1.Col = 0;
								this.GridEX1.EditMode = EditMode.EditOn;
							}
							else
							{
								DataEntryGrid gridEX = this.GridEX1;
								gridEX.Col++;
								this.GridEX1.EditMode = EditMode.EditOn;
							}
						}
					}
				}
				flag3 = (this.GridEX1.Col == this.GridEX1.RootTable.Columns["hesab_name"].Position || this.GridEX1.Col == this.GridEX1.RootTable.Columns["hesab"].Position);
				if (flag3)
				{
					e.SuppressKeyPress = true;
				}
			}
		}

		// Token: 0x060026C2 RID: 9922 RVA: 0x001D4D8C File Offset: 0x001D2F8C
		private bool ValidateGrid()
		{
			DataTable dataTable = (DataTable)this.GridEX1.DataSource;
			try
			{
				IEnumerator enumerator = dataTable.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					bool flag = dataRow["bed"] == DBNull.Value;
					if (flag)
					{
						dataRow["bed"] = 0;
					}
					flag = (dataRow["bes"] == DBNull.Value);
					if (flag)
					{
						dataRow["bes"] = 0;
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
			GridEXRow[] rows = this.GridEX1.GetRows();
			checked
			{
				bool flag;
				bool result;
				for (int i = 0; i < rows.Length; i++)
				{
					GridEXRow gridEXRow = rows[i];
					flag = (Operators.ConditionalCompareObjectEqual(gridEXRow.Cells["bed"].Value, 0, false) && Operators.ConditionalCompareObjectEqual(gridEXRow.Cells["bes"].Value, 0, false));
					if (flag)
					{
						Public_Function.GridRaiseSoftError(this.GridEX1, gridEXRow, "bed", "مبلغ بدهکار یا بستانکار را وارد نمایید");
						result = false;
						return result;
					}
				}
				flag = (Operators.CompareString(Public_Function.GetSum(dataTable, "bed"), Public_Function.GetSum(dataTable, "bes"), false) != 0);
				if (flag)
				{
					Public_Function.ShowMessage("سند تراز نمی باشد", MessageBoxButtons.OK, MessageBoxIcon.Hand, null);
					result = false;
					return result;
				}
				result = true;
				return result;
			}
		}

		// Token: 0x060026C3 RID: 9923 RVA: 0x001D4F40 File Offset: 0x001D3140
		private void ButtonItem2_Click(object sender, EventArgs e)
		{
			DataTable dataTable = (DataTable)this.GridEX1.DataSource;
			dataTable.AcceptChanges();
			bool flag = !this.ValidateGrid();
			if (!flag)
			{
				Sanad_Dasti sanad_Dasti = new Sanad_Dasti();
				flag = (this.UiComboBox1.SelectedIndex == 0);
				bool dorp = flag;
				this.Daryaftpardakht_ID = sanad_Dasti.Update(this.Tarikh, dorp, this.txt_desc.Text, dataTable);
				this.dorp = dorp;
				this.Mablagh = Conversions.ToLong(Public_Function.GetSum(dataTable, "bed"));
				this.Tozih = this.txt_desc.Text;
				Public_Function.ShowMessage("اطلاعات مورد نظر ثبت گردید", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, null);
			}
		}

		// Token: 0x060026C4 RID: 9924 RVA: 0x001D4FFC File Offset: 0x001D31FC
		private void ButtonItem3_Click(object sender, EventArgs e)
		{
			bool flag = this.GridEX1.CurrentRow != null;
			if (flag)
			{
				bool flag2 = this.GridEX1.CurrentRow.RowType == RowType.Record;
				if (flag2)
				{
					this.GridEX1.CurrentRow.Delete();
				}
			}
		}

		// Token: 0x04000F17 RID: 3863
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000F19 RID: 3865
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x04000F1A RID: 3866
		[AccessedThroughProperty("GridEX1")]
		private DataEntryGrid _GridEX1;

		// Token: 0x04000F1B RID: 3867
		[AccessedThroughProperty("Bar1")]
		private Bar _Bar1;

		// Token: 0x04000F1C RID: 3868
		[AccessedThroughProperty("ButtonItem2")]
		private ButtonItem _ButtonItem2;

		// Token: 0x04000F1D RID: 3869
		[AccessedThroughProperty("ButtonItem3")]
		private ButtonItem _ButtonItem3;

		// Token: 0x04000F1E RID: 3870
		[AccessedThroughProperty("txt_bes")]
		private CurrencyBox _txt_bes;

		// Token: 0x04000F1F RID: 3871
		[AccessedThroughProperty("txt_bed")]
		private CurrencyBox _txt_bed;

		// Token: 0x04000F20 RID: 3872
		[AccessedThroughProperty("UiComboBox1")]
		private UIComboBox _UiComboBox1;

		// Token: 0x04000F21 RID: 3873
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04000F22 RID: 3874
		[AccessedThroughProperty("txt_desc")]
		private EditBox _txt_desc;

		// Token: 0x04000F23 RID: 3875
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x04000F24 RID: 3876
		[CompilerGenerated]
		private string _Tarikh;

		// Token: 0x04000F25 RID: 3877
		[CompilerGenerated]
		private string _Daryaftpardakht_ID;

		// Token: 0x04000F26 RID: 3878
		[CompilerGenerated]
		private bool _dorp;

		// Token: 0x04000F27 RID: 3879
		[CompilerGenerated]
		private long _Mablagh;

		// Token: 0x04000F28 RID: 3880
		[CompilerGenerated]
		private string _Tozih;

		// Token: 0x04000F29 RID: 3881
		private Frm_SelectItem frm;
	}
}
