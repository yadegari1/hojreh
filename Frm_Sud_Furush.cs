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
using Janus.Windows.Common.Layouts;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.UI.Dock;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x02000111 RID: 273
	[DesignerGenerated]
	public partial class Frm_Sud_Furush : Form
	{
		// Token: 0x0600273B RID: 10043 RVA: 0x001DB1F0 File Offset: 0x001D93F0
		public Frm_Sud_Furush()
		{
			base.FormClosing += new FormClosingEventHandler(this.Frm_RizKharid_FormClosing);
			base.KeyDown += new KeyEventHandler(this.Frm_RizKharid_KeyDown);
			base.Load += new EventHandler(this.Frm_RizKharid_Load);
			Frm_Sud_Furush.__ENCAddToList(this);
			this.frm = new Frm_SelectItem();
			this.Kharid_Darsad = new Kharid_Darsad();
			this.prevent = false;
			bool has_Delete = false;
			this.has_Delete = has_Delete;
			this.InitializeComponent();
		}

		// Token: 0x0600273C RID: 10044 RVA: 0x001DB278 File Offset: 0x001D9478
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_Sud_Furush.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_Sud_Furush.__ENCList.Count == Frm_Sud_Furush.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_Sud_Furush.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_Sud_Furush.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_Sud_Furush.__ENCList[num] = Frm_Sud_Furush.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_Sud_Furush.__ENCList.RemoveRange(num, Frm_Sud_Furush.__ENCList.Count - num);
						Frm_Sud_Furush.__ENCList.Capacity = Frm_Sud_Furush.__ENCList.Count;
					}
					Frm_Sud_Furush.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000BFA RID: 3066
		// (get) Token: 0x0600273F RID: 10047 RVA: 0x001DC568 File Offset: 0x001DA768
		// (set) Token: 0x06002740 RID: 10048 RVA: 0x00009C39 File Offset: 0x00007E39
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

		// Token: 0x17000BFB RID: 3067
		// (get) Token: 0x06002741 RID: 10049 RVA: 0x001DC580 File Offset: 0x001DA780
		// (set) Token: 0x06002742 RID: 10050 RVA: 0x00009C43 File Offset: 0x00007E43
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

		// Token: 0x17000BFC RID: 3068
		// (get) Token: 0x06002743 RID: 10051 RVA: 0x001DC598 File Offset: 0x001DA798
		// (set) Token: 0x06002744 RID: 10052 RVA: 0x001DC5B0 File Offset: 0x001DA7B0
		internal virtual NumericBox txt_darsad2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_darsad2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txt_darsad2_TextChanged);
				bool flag = this._txt_darsad2 != null;
				if (flag)
				{
					this._txt_darsad2.TextChanged -= value2;
				}
				this._txt_darsad2 = value;
				flag = (this._txt_darsad2 != null);
				if (flag)
				{
					this._txt_darsad2.TextChanged += value2;
				}
			}
		}

		// Token: 0x17000BFD RID: 3069
		// (get) Token: 0x06002745 RID: 10053 RVA: 0x001DC610 File Offset: 0x001DA810
		// (set) Token: 0x06002746 RID: 10054 RVA: 0x001DC628 File Offset: 0x001DA828
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
				ColumnActionEventHandler value4 = new ColumnActionEventHandler(this.GridEX1_CellEdited);
				EventHandler value5 = new EventHandler(this.GridEX1_RecordAdded);
				EndCustomEditEventHandler value6 = new EndCustomEditEventHandler(this.GridEX1_EndCustomEdit);
				ColumnActionEventHandler value7 = new ColumnActionEventHandler(this.GridEX1_ColumnButtonClick);
				KeyPressEventHandler value8 = new KeyPressEventHandler(this.GridEX1_KeyPress);
				bool flag = this._GridEX1 != null;
				if (flag)
				{
					this._GridEX1.KeyDown -= value2;
					this._GridEX1.InitCustomEdit -= value3;
					this._GridEX1.CellEdited -= value4;
					this._GridEX1.RecordAdded -= value5;
					this._GridEX1.EndCustomEdit -= value6;
					this._GridEX1.ColumnButtonClick -= value7;
					this._GridEX1.KeyPress -= value8;
				}
				this._GridEX1 = value;
				flag = (this._GridEX1 != null);
				if (flag)
				{
					this._GridEX1.KeyDown += value2;
					this._GridEX1.InitCustomEdit += value3;
					this._GridEX1.CellEdited += value4;
					this._GridEX1.RecordAdded += value5;
					this._GridEX1.EndCustomEdit += value6;
					this._GridEX1.ColumnButtonClick += value7;
					this._GridEX1.KeyPress += value8;
				}
			}
		}

		// Token: 0x17000BFE RID: 3070
		// (get) Token: 0x06002747 RID: 10055 RVA: 0x001DC784 File Offset: 0x001DA984
		// (set) Token: 0x06002748 RID: 10056 RVA: 0x00009C4D File Offset: 0x00007E4D
		internal virtual NumericBox txt_darsad
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_darsad;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_darsad = value;
			}
		}

		// Token: 0x17000BFF RID: 3071
		// (get) Token: 0x06002749 RID: 10057 RVA: 0x001DC79C File Offset: 0x001DA99C
		// (set) Token: 0x0600274A RID: 10058 RVA: 0x00009C57 File Offset: 0x00007E57
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

		// Token: 0x17000C00 RID: 3072
		// (get) Token: 0x0600274B RID: 10059 RVA: 0x001DC7B4 File Offset: 0x001DA9B4
		// (set) Token: 0x0600274C RID: 10060 RVA: 0x00009C61 File Offset: 0x00007E61
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

		// Token: 0x17000C01 RID: 3073
		// (get) Token: 0x0600274D RID: 10061 RVA: 0x001DC7CC File Offset: 0x001DA9CC
		// (set) Token: 0x0600274E RID: 10062 RVA: 0x001DC7E4 File Offset: 0x001DA9E4
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

		// Token: 0x17000C02 RID: 3074
		// (get) Token: 0x0600274F RID: 10063 RVA: 0x001DC844 File Offset: 0x001DAA44
		// (set) Token: 0x06002750 RID: 10064 RVA: 0x001DC85C File Offset: 0x001DAA5C
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

		// Token: 0x17000C03 RID: 3075
		// (get) Token: 0x06002751 RID: 10065 RVA: 0x001DC8BC File Offset: 0x001DAABC
		// (set) Token: 0x06002752 RID: 10066 RVA: 0x00009C6B File Offset: 0x00007E6B
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

		// Token: 0x17000C04 RID: 3076
		// (get) Token: 0x06002753 RID: 10067 RVA: 0x001DC8D4 File Offset: 0x001DAAD4
		// (set) Token: 0x06002754 RID: 10068 RVA: 0x00009C75 File Offset: 0x00007E75
		internal virtual NumericBox txt_sanad
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_sanad;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_sanad = value;
			}
		}

		// Token: 0x17000C05 RID: 3077
		// (get) Token: 0x06002755 RID: 10069 RVA: 0x001DC8EC File Offset: 0x001DAAEC
		// (set) Token: 0x06002756 RID: 10070 RVA: 0x00009C7F File Offset: 0x00007E7F
		internal virtual Label Label3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label3 = value;
			}
		}

		// Token: 0x17000C06 RID: 3078
		// (get) Token: 0x06002757 RID: 10071 RVA: 0x001DC904 File Offset: 0x001DAB04
		// (set) Token: 0x06002758 RID: 10072 RVA: 0x00009C89 File Offset: 0x00007E89
		internal virtual CurrencyBox txt_karmozd
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_karmozd;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_karmozd = value;
			}
		}

		// Token: 0x17000C07 RID: 3079
		// (get) Token: 0x06002759 RID: 10073 RVA: 0x001DC91C File Offset: 0x001DAB1C
		// (set) Token: 0x0600275A RID: 10074 RVA: 0x00009C93 File Offset: 0x00007E93
		internal virtual Label Label4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label4 = value;
			}
		}

		// Token: 0x17000C08 RID: 3080
		// (get) Token: 0x0600275B RID: 10075 RVA: 0x001DC934 File Offset: 0x001DAB34
		// (set) Token: 0x0600275C RID: 10076 RVA: 0x00009C9D File Offset: 0x00007E9D
		internal virtual Label Label5
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label5;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label5 = value;
			}
		}

		// Token: 0x17000C09 RID: 3081
		// (get) Token: 0x0600275D RID: 10077 RVA: 0x001DC94C File Offset: 0x001DAB4C
		// (set) Token: 0x0600275E RID: 10078 RVA: 0x001DC964 File Offset: 0x001DAB64
		internal virtual UIRadioButton UiRadioButton2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiRadioButton2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.UiRadioButton1_CheckedChanged);
				bool flag = this._UiRadioButton2 != null;
				if (flag)
				{
					this._UiRadioButton2.CheckedChanged -= value2;
				}
				this._UiRadioButton2 = value;
				flag = (this._UiRadioButton2 != null);
				if (flag)
				{
					this._UiRadioButton2.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x17000C0A RID: 3082
		// (get) Token: 0x0600275F RID: 10079 RVA: 0x001DC9C4 File Offset: 0x001DABC4
		// (set) Token: 0x06002760 RID: 10080 RVA: 0x001DC9DC File Offset: 0x001DABDC
		internal virtual UIRadioButton UiRadioButton1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiRadioButton1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.UiRadioButton1_CheckedChanged);
				bool flag = this._UiRadioButton1 != null;
				if (flag)
				{
					this._UiRadioButton1.CheckedChanged -= value2;
				}
				this._UiRadioButton1 = value;
				flag = (this._UiRadioButton1 != null);
				if (flag)
				{
					this._UiRadioButton1.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x17000C0B RID: 3083
		// (get) Token: 0x06002761 RID: 10081 RVA: 0x001DCA3C File Offset: 0x001DAC3C
		// (set) Token: 0x06002762 RID: 10082 RVA: 0x00009CA7 File Offset: 0x00007EA7
		public string furush_num
		{
			[DebuggerNonUserCode]
			get
			{
				return this._furush_num;
			}
			[DebuggerNonUserCode]
			set
			{
				this._furush_num = value;
			}
		}

		// Token: 0x17000C0C RID: 3084
		// (get) Token: 0x06002763 RID: 10083 RVA: 0x001DCA54 File Offset: 0x001DAC54
		// (set) Token: 0x06002764 RID: 10084 RVA: 0x00009CB1 File Offset: 0x00007EB1
		public string Furush_ID
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Furush_ID;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Furush_ID = value;
			}
		}

		// Token: 0x17000C0D RID: 3085
		// (get) Token: 0x06002765 RID: 10085 RVA: 0x001DCA6C File Offset: 0x001DAC6C
		// (set) Token: 0x06002766 RID: 10086 RVA: 0x00009CBB File Offset: 0x00007EBB
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

		// Token: 0x17000C0E RID: 3086
		// (get) Token: 0x06002767 RID: 10087 RVA: 0x001DCA84 File Offset: 0x001DAC84
		// (set) Token: 0x06002768 RID: 10088 RVA: 0x00009CC5 File Offset: 0x00007EC5
		public string Darsad
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Darsad;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Darsad = value;
			}
		}

		// Token: 0x17000C0F RID: 3087
		// (get) Token: 0x06002769 RID: 10089 RVA: 0x001DCA9C File Offset: 0x001DAC9C
		// (set) Token: 0x0600276A RID: 10090 RVA: 0x00009CCF File Offset: 0x00007ECF
		private long Karmozd
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Karmozd;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Karmozd = value;
			}
		}

		// Token: 0x17000C10 RID: 3088
		// (get) Token: 0x0600276B RID: 10091 RVA: 0x001DCAB4 File Offset: 0x001DACB4
		// (set) Token: 0x0600276C RID: 10092 RVA: 0x00009CD9 File Offset: 0x00007ED9
		public bool has_Delete
		{
			[DebuggerNonUserCode]
			get
			{
				return this._has_Delete;
			}
			[DebuggerNonUserCode]
			set
			{
				this._has_Delete = value;
			}
		}

		// Token: 0x0600276D RID: 10093 RVA: 0x001DCACC File Offset: 0x001DACCC
		private void RemoveZero(DataTable dt)
		{
			try
			{
				IEnumerator enumerator = dt.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					bool flag = dataRow["darsad"] != DBNull.Value;
					if (flag)
					{
						dataRow["darsad"] = Public_Function.GetDecimalValue(Conversions.ToDecimal(dataRow["darsad"]));
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

		// Token: 0x0600276E RID: 10094 RVA: 0x001DCB74 File Offset: 0x001DAD74
		private void LoadData()
		{
			DataTable dataTable = Public_Function.FillData("SELECT     Furush_Darsad.ID, Furush_Darsad.Furush_ID, Furush_Darsad.Moshtari_ID, Furush_Darsad.Darsad, Furush_Darsad.Mablagh, Furush_Darsad.SanadBed_ID,  Furush_Darsad.SanadBes_ID, Moshtari.Name+' '+ Moshtari.Family as moshtari_Name,Moshtari.Codehesab_ID   FROM         Furush_Darsad INNER JOIN Moshtari ON Furush_Darsad.Moshtari_ID = Moshtari.ID where furush_id=" + this.Furush_ID);
			object objectValue = RuntimeHelpers.GetObjectValue(Public_Function.ExecuteScalar("select noe_darsad from furush_hag where id=" + this.Furush_ID));
			bool flag = objectValue == DBNull.Value;
			if (flag)
			{
				this.UiRadioButton1.Checked = true;
			}
			else
			{
				flag = Operators.ConditionalCompareObjectEqual(objectValue, 1, false);
				if (flag)
				{
					this.UiRadioButton1.Checked = true;
				}
				else
				{
					this.UiRadioButton2.Checked = true;
				}
			}
			this.Karmozd = checked((long)Math.Round(unchecked((double)this.Mablagh / 100.0 * Conversions.ToDouble(this.Darsad))));
			this.RemoveZero(dataTable);
			flag = (dataTable.Rows.Count > 0);
			if (flag)
			{
				this.GridEX1.Enabled = false;
				this.ButtonItem2.Enabled = false;
				this.UiRadioButton1.Enabled = false;
				this.UiRadioButton2.Enabled = false;
			}
			else
			{
				this.ButtonItem2.Enabled = true;
				this.GridEX1.Enabled = true;
				this.UiRadioButton1.Enabled = true;
				this.UiRadioButton2.Enabled = true;
			}
			this.GridEX1.DataSource = dataTable;
		}

		// Token: 0x0600276F RID: 10095 RVA: 0x001DCCBC File Offset: 0x001DAEBC
		private void Moshtari_Select()
		{
			this.frm.CanEdit = true;
			this.frm.Edit_Frm = MyProject.Forms.Frm_Moshtari;
			this.frm.CanDelete = false;
			string text = Public_Function.GetID((DataTable)this.GridEX1.DataSource, "Moshtari_ID", "");
			bool flag = Operators.CompareString(text, string.Empty, false) != 0;
			if (flag)
			{
				text += ",-1,-2,-3,-4,-5,-6";
			}
			else
			{
				text = "-1,-2,-3,-4,-5,-6";
			}
			flag = (this.frm.ShowDialog("select Id,name + ' ' + Family as Name,codehesab_id From Moshtari where id not in(" + text + ")", MyProject.Forms.Frm_Moshtari, 0) == DialogResult.OK);
			checked
			{
				if (flag)
				{
					bool flag2 = this.GridEX1.Col == this.GridEX1.RootTable.Columns["moshtari_Name"].Position && this.GridEX1.EditTextBox != null;
					if (flag2)
					{
						this.GridEX1.EditTextBox.Text = Conversions.ToString(this.frm.SelectedRow["Name"]);
						this.GridEX1.GetRow().Cells["Moshtari_Id"].Value = RuntimeHelpers.GetObjectValue(this.frm.SelectedRow["ID"]);
						this.GridEX1.GetRow().Cells["codehesab_id"].Value = RuntimeHelpers.GetObjectValue(this.frm.SelectedRow["codehesab_id"]);
						DataEntryGrid gridEX = this.GridEX1;
						gridEX.Col++;
					}
				}
			}
		}

		// Token: 0x06002770 RID: 10096 RVA: 0x001DCE74 File Offset: 0x001DB074
		private void Del()
		{
			bool flag = this.GridEX1.CurrentRow.RowType == RowType.Record;
			if (flag)
			{
				this.GridEX1.CurrentRow.Delete();
				this.getdarsad();
			}
		}

		// Token: 0x06002771 RID: 10097 RVA: 0x001DCEB4 File Offset: 0x001DB0B4
		private void getdarsad()
		{
			decimal num = 0m;
			bool flag = this.GridEX1.DataSource != null;
			if (flag)
			{
				num = Conversions.ToDecimal(this.GridEX1.GetTotal(this.GridEX1.RootTable.Columns["darsad"], AggregateFunction.Sum));
			}
			else
			{
				num = 0m;
			}
			flag = this.UiRadioButton1.Checked;
			if (flag)
			{
				this.txt_darsad2.Text = Conversions.ToString(Conversions.ToDouble(this.Darsad) - Convert.ToDouble(num));
			}
			else
			{
				this.txt_darsad2.Text = decimal.Subtract(new decimal(100L), num).ToString();
			}
			this.txt_darsad2.Text = Conversions.ToString(Public_Function.GetDecimalValue(Conversions.ToDecimal(this.txt_darsad2.Text)));
		}

		// Token: 0x06002772 RID: 10098 RVA: 0x001DCF98 File Offset: 0x001DB198
		private void GridEX1_CellEdited(object sender, ColumnActionEventArgs e)
		{
			bool flag = Operators.CompareString(e.Column.Key.ToLower(), "darsad", false) == 0;
			if (flag)
			{
				this.GridEX1.UpdateData();
				this.getdarsad();
				this.GridEX1.Focus();
				flag = (this.GridEX1.CurrentRow.Cells["darsad"].Value != DBNull.Value);
				if (flag)
				{
					this.GridEX1.CurrentRow.BeginEdit();
					flag = this.UiRadioButton1.Checked;
					if (flag)
					{
						this.GridEX1.CurrentRow.Cells["mablagh"].Value = Operators.MultiplyObject((double)this.Mablagh / 100.0, this.GridEX1.CurrentRow.Cells["darsad"].Value);
					}
					else
					{
						this.GridEX1.CurrentRow.Cells["mablagh"].Value = Operators.MultiplyObject((double)this.Karmozd / 100.0, this.GridEX1.CurrentRow.Cells["darsad"].Value);
					}
					this.GridEX1.CurrentRow.EndEdit();
				}
			}
		}

		// Token: 0x06002773 RID: 10099 RVA: 0x001DD108 File Offset: 0x001DB308
		private void GridEX1_ColumnButtonClick(object sender, ColumnActionEventArgs e)
		{
			int position = e.Column.Position;
			bool flag = position == this.GridEX1.RootTable.Columns["Moshtari_Name"].Position;
			if (flag)
			{
				this.Moshtari_Select();
			}
			else
			{
				flag = (position == this.GridEX1.RootTable.Columns["del"].Position);
				if (flag)
				{
					this.Del();
					flag = (this.GridEX1.RowCount == 0);
					if (flag)
					{
						this.UiRadioButton1.Enabled = true;
						this.UiRadioButton2.Enabled = true;
					}
					else
					{
						this.UiRadioButton1.Enabled = false;
						this.UiRadioButton2.Enabled = false;
					}
				}
			}
		}

		// Token: 0x06002774 RID: 10100 RVA: 0x001DD1D0 File Offset: 0x001DB3D0
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
						flag2 = (this.GridEX1.Col == this.GridEX1.RootTable.Columns["Moshtari_Name"].Position);
						if (flag2)
						{
							this.GridEX1.CurrentRow.Cells["Moshtari_ID"].Value = DBNull.Value;
						}
					}
					switch (e.KeyData)
					{
					case Keys.Left:
					{
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
						flag = (col == this.GridEX1.RootTable.Columns["Moshtari_Name"].Position);
						if (flag)
						{
							this.GridEX1.EditMode = EditMode.EditOn;
							flag2 = this.prevent;
							if (flag2)
							{
								e.SuppressKeyPress = true;
								this.prevent = false;
							}
							else
							{
								flag2 = (Operators.CompareString(this.GridEX1.EditTextBox.Text, string.Empty, false) == 0);
								if (flag2)
								{
									this.Moshtari_Select();
								}
								else
								{
									DataEntryGrid gridEX = this.GridEX1;
									gridEX.Col++;
								}
							}
						}
						else
						{
							flag2 = (col == this.GridEX1.RootTable.Columns["Darsad"].Position);
							if (flag2)
							{
								flag = (this.GridEX1.CurrentRow.RowType == RowType.NewRecord);
								if (flag)
								{
									this.GridEX1.UpdateData();
									this.GridEX1.Col = 0;
									this.GridEX1.Row = -1;
								}
								else
								{
									this.GridEX1.Col = 0;
									this.GridEX1.Row = -1;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06002775 RID: 10101 RVA: 0x001DD558 File Offset: 0x001DB758
		private void GridEX1_KeyPress(object sender, KeyPressEventArgs e)
		{
			bool flag = this.GridEX1.Col == this.GridEX1.RootTable.Columns["moshtari_Name"].Position;
			if (flag)
			{
				e.Handled = true;
			}
		}

		// Token: 0x06002776 RID: 10102 RVA: 0x001DD5A0 File Offset: 0x001DB7A0
		private bool ValidateGridData()
		{
			this.GridEX1.UpdateData();
			DataTable dataTable = (DataTable)this.GridEX1.DataSource;
			int i = 0;
			checked
			{
				bool flag;
				while (i <= dataTable.Rows.Count - 1)
				{
					flag = (dataTable.Rows[i].RowState == DataRowState.Deleted);
					if (flag)
					{
						i++;
					}
					else
					{
						flag = (dataTable.Rows[i]["Moshtari_ID"] == DBNull.Value && dataTable.Rows[i]["Darsad"] == DBNull.Value);
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
						flag = (dataRow["Moshtari_ID"] == DBNull.Value);
						if (flag)
						{
							Public_Function.GridRaiseSoftError(this.GridEX1, this.GridEX1.GetRows()[num], "Moshtari_Name", "مشتری را انتخاب نمایید");
							result = false;
							return result;
						}
						flag = (dataRow["Darsad"] == DBNull.Value);
						if (flag)
						{
							Public_Function.GridRaiseSoftError(this.GridEX1, this.GridEX1.GetRows()[num], "Darsad", "درصد را وارد نمایید");
							result = false;
							return result;
						}
						flag = Operators.ConditionalCompareObjectEqual(dataRow["darsad"], 0, false);
						if (flag)
						{
							Public_Function.GridRaiseSoftError(this.GridEX1, this.GridEX1.GetRows()[num], "Darsad", "درصد را وارد نمایید");
							result = false;
							return result;
						}
						num++;
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
				decimal num2 = Conversions.ToDecimal(this.GridEX1.GetTotal(this.GridEX1.RootTable.Columns["darsad"], AggregateFunction.Sum));
				flag = this.UiRadioButton1.Checked;
				if (flag)
				{
					bool flag2 = Convert.ToDouble(num2) > Conversions.ToDouble(this.Darsad);
					if (flag2)
					{
						Public_Function.ShowMessage("جمع درصدها بیشتر از " + this.Darsad + " است ", MessageBoxButtons.OK, MessageBoxIcon.Hand, null);
						result = false;
						return result;
					}
				}
				else
				{
					bool flag2 = decimal.Compare(num2, new decimal(100L)) > 0;
					if (flag2)
					{
						Public_Function.ShowMessage("جمع درصدها بیشتر از  100  است ", MessageBoxButtons.OK, MessageBoxIcon.Hand, null);
						result = false;
						return result;
					}
				}
				result = true;
				return result;
			}
		}

		// Token: 0x06002777 RID: 10103 RVA: 0x0000205D File Offset: 0x0000025D
		private void Frm_RizKharid_FormClosing(object sender, FormClosingEventArgs e)
		{
		}

		// Token: 0x06002778 RID: 10104 RVA: 0x001DD87C File Offset: 0x001DBA7C
		private void Frm_RizKharid_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Escape;
			if (flag)
			{
				this.Close();
			}
			switch (e.KeyCode)
			{
			case Keys.F2:
				this.ButtonItem2_Click(null, null);
				break;
			case Keys.F5:
				this.ButtonItem3_Click(null, null);
				break;
			}
		}

		// Token: 0x06002779 RID: 10105 RVA: 0x001DD8DC File Offset: 0x001DBADC
		private void Frm_RizKharid_Load(object sender, EventArgs e)
		{
			this.txt_sanad.Text = this.furush_num;
			this.txt_mablagh.Text = Conversions.ToString(this.Mablagh);
			this.txt_darsad2.Text = this.Darsad;
			this.txt_karmozd.Text = Conversions.ToString((double)this.Mablagh / 100.0 * Conversions.ToDouble(this.Darsad));
			ItemCollection itemCollection = new ItemCollection();
			itemCollection.Add(new Column("Name", "عنوان", 100));
			this.frm.items = itemCollection;
			this.LoadData();
			this.GridEX1.MoveToNewRecord();
			this.GridEX1.Col = 0;
			this.GridEX1.EditMode = EditMode.EditOn;
			this.getdarsad();
		}

		// Token: 0x0600277A RID: 10106 RVA: 0x001DD9B4 File Offset: 0x001DBBB4
		private void GridEX1_InitCustomEdit(object sender, InitCustomEditEventArgs e)
		{
			string left = e.Column.Key.ToLower();
			bool flag = Operators.CompareString(left, "darsad", false) == 0;
			if (flag)
			{
				e.EditControl = this.txt_darsad;
				this.txt_darsad.Text = e.Value.ToString();
				this.txt_darsad.SelectAll();
			}
		}

		// Token: 0x0600277B RID: 10107 RVA: 0x001DDA1C File Offset: 0x001DBC1C
		private void GridEX1_EndCustomEdit(object sender, EndCustomEditEventArgs e)
		{
			string left = e.Column.Key.ToLower();
			bool flag = Operators.CompareString(left, "darsad", false) == 0;
			if (flag)
			{
				e.Value = ((NumericBox)e.EditControl).Text;
			}
		}

		// Token: 0x0600277C RID: 10108 RVA: 0x001DDA6C File Offset: 0x001DBC6C
		private void GridEX1_RecordAdded(object sender, EventArgs e)
		{
			GridEXRow[] rows = this.GridEX1.GetRows();
			checked
			{
				bool flag;
				for (int i = 0; i < rows.Length; i++)
				{
					GridEXRow gridEXRow = rows[i];
					flag = (gridEXRow.Cells["moshtari_id"].Value == DBNull.Value);
					if (flag)
					{
						gridEXRow.Delete();
						break;
					}
				}
				flag = (this.GridEX1.RowCount == 0);
				if (flag)
				{
					this.UiRadioButton1.Enabled = true;
					this.UiRadioButton2.Enabled = true;
				}
				else
				{
					this.UiRadioButton1.Enabled = false;
					this.UiRadioButton2.Enabled = false;
				}
			}
		}

		// Token: 0x0600277D RID: 10109 RVA: 0x001DDB14 File Offset: 0x001DBD14
		private void InsertData()
		{
			DataTable dataTable = (DataTable)this.GridEX1.DataSource;
			bool flag = dataTable.Rows.Count == 0;
			if (!flag)
			{
				string text = "declare @bed_id bigint,@bes_id bigint;declare @karmozd_sanad_id bigint;";
				Sanad sanad = new Sanad();
				try
				{
					IEnumerator enumerator = dataTable.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						text = text + sanad.InsertStr(Conversions.ToString(dataRow["Codehesab_ID"]), "0", dataRow["mablagh"].ToString(), Public_Function.MiladiToShamsi(DateAndTime.Now), Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(dataRow["darsad"], "%"), " از فروش شماره"), this.furush_num)), Sanad.SanadType.@null) + "; select @bes_id=scope_identity();";
						text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("INSERT INTO Furush_Darsad ([Furush_ID],[Moshtari_ID],[Darsad],[Mablagh],[SanadBed_ID],[SanadBes_ID]) VALUES (" + this.Furush_ID + ",", dataRow["moshtari_ID"]), ","), dataRow["darsad"]), ","), dataRow["mablagh"]), ","), "NULL,@bes_id);")));
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
				decimal d = Conversions.ToDecimal(Public_Function.GetSum(dataTable, "darsad"));
				decimal num = Conversions.ToDecimal(this.txt_karmozd.Text);
				string tozih = string.Empty;
				flag = (decimal.Compare(num, decimal.Zero) > 0);
				long value;
				long value2;
				if (flag)
				{
					value = Convert.ToInt64(num);
					value2 = 0L;
					flag = (decimal.Compare(d, decimal.Zero) == 0);
					if (flag)
					{
						tozih = "درآمد فروش سند شماره " + this.furush_num;
					}
					else
					{
						tozih = " %" + this.txt_darsad2.Text + "درآمد فروش سند شماره " + this.furush_num;
					}
				}
				else
				{
					value = 0L;
					value2 = Convert.ToInt64(Math.Abs(num));
					flag = (decimal.Compare(d, decimal.Zero) == 0);
					if (flag)
					{
						tozih = "زیان فروش سند شماره " + this.furush_num;
					}
					else
					{
						tozih = "% " + this.txt_darsad2.Text + "زیان فروش سند شماره " + this.furush_num;
					}
				}
				text = text + "select @karmozd_sanad_id=karmozd_sanad_id from safi_furush where furush_hag_id=" + this.Furush_ID + ";";
				text += sanad.UpdateStr(Conversions.ToString(12), Conversions.ToString(value2), Conversions.ToString(value), Public_Function.dict["today"], tozih, "@karmozd_sanad_id", Sanad.SanadType.@null);
				Public_Function.ExecuteNonQuery(text);
				flag = this.UiRadioButton1.Checked;
				if (flag)
				{
					Public_Function.ExecuteNonQuery("update furush_hag set noe_darsad=1 where id=" + this.Furush_ID);
				}
				else
				{
					Public_Function.ExecuteNonQuery("update furush_hag set noe_darsad=2 where id=" + this.Furush_ID);
				}
				Public_Function.ShowMessage("اطلاعات مورد نظر ثبت گردید", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, null);
				this.GridEX1.Enabled = false;
				this.ButtonItem2.Enabled = false;
			}
		}

		// Token: 0x0600277E RID: 10110 RVA: 0x001DDE88 File Offset: 0x001DC088
		private void ButtonItem2_Click(object sender, EventArgs e)
		{
			this.GridEX1.UpdateData();
			this.getdarsad();
			bool flag = this.ValidateGridData();
			if (flag)
			{
				this.InsertData();
				this.has_Delete = false;
				this.LoadData();
			}
		}

		// Token: 0x0600277F RID: 10111 RVA: 0x001DDECC File Offset: 0x001DC0CC
		private void ButtonItem3_Click(object sender, EventArgs e)
		{
			DataTable dataTable = (DataTable)this.GridEX1.DataSource;
			Sanad sanad = new Sanad();
			string text = string.Empty;
			bool flag = dataTable.Rows.Count == 0;
			if (!flag)
			{
				try
				{
					IEnumerator enumerator = dataTable.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						flag = (dataRow["sanadbed_id"] != DBNull.Value);
						if (flag)
						{
							text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("delete from sanad where id=", dataRow["sanadbed_id"]), ";")));
						}
						flag = (dataRow["sanadbes_id"] != DBNull.Value);
						if (flag)
						{
							text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("delete from sanad where id=", dataRow["sanadbes_id"]), ";")));
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
				text = text + "delete from furush_darsad where furush_id=" + this.Furush_ID;
				Public_Function.ExecuteNonQuery(text);
				Public_Function.ShowMessage("اطلاعات مورد نظر حذف گردید", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, null);
				this.txt_darsad2.Text = this.Darsad;
				this.LoadData();
				this.has_Delete = true;
			}
		}

		// Token: 0x06002780 RID: 10112 RVA: 0x001DE050 File Offset: 0x001DC250
		private void txt_darsad2_TextChanged(object sender, EventArgs e)
		{
			this.txt_karmozd.Text = Conversions.ToString((double)this.Mablagh / 100.0 * Conversions.ToDouble(this.txt_darsad2.Text));
			bool @checked = this.UiRadioButton1.Checked;
			if (@checked)
			{
				this.txt_karmozd.Text = Conversions.ToString((double)this.Mablagh / 100.0 * Conversions.ToDouble(this.txt_darsad2.Text));
			}
			else
			{
				this.txt_karmozd.Text = Conversions.ToString((double)this.Karmozd / 100.0 * Conversions.ToDouble(this.txt_darsad2.Text));
			}
		}

		// Token: 0x06002781 RID: 10113 RVA: 0x00009CE3 File Offset: 0x00007EE3
		private void UiRadioButton1_CheckedChanged(object sender, EventArgs e)
		{
			this.getdarsad();
		}

		// Token: 0x04000F50 RID: 3920
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000F52 RID: 3922
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x04000F53 RID: 3923
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x04000F54 RID: 3924
		[AccessedThroughProperty("txt_darsad2")]
		private NumericBox _txt_darsad2;

		// Token: 0x04000F55 RID: 3925
		[AccessedThroughProperty("GridEX1")]
		private DataEntryGrid _GridEX1;

		// Token: 0x04000F56 RID: 3926
		[AccessedThroughProperty("txt_darsad")]
		private NumericBox _txt_darsad;

		// Token: 0x04000F57 RID: 3927
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04000F58 RID: 3928
		[AccessedThroughProperty("Bar1")]
		private Bar _Bar1;

		// Token: 0x04000F59 RID: 3929
		[AccessedThroughProperty("ButtonItem2")]
		private ButtonItem _ButtonItem2;

		// Token: 0x04000F5A RID: 3930
		[AccessedThroughProperty("ButtonItem3")]
		private ButtonItem _ButtonItem3;

		// Token: 0x04000F5B RID: 3931
		[AccessedThroughProperty("txt_mablagh")]
		private CurrencyBox _txt_mablagh;

		// Token: 0x04000F5C RID: 3932
		[AccessedThroughProperty("txt_sanad")]
		private NumericBox _txt_sanad;

		// Token: 0x04000F5D RID: 3933
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x04000F5E RID: 3934
		[AccessedThroughProperty("txt_karmozd")]
		private CurrencyBox _txt_karmozd;

		// Token: 0x04000F5F RID: 3935
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		// Token: 0x04000F60 RID: 3936
		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		// Token: 0x04000F61 RID: 3937
		[AccessedThroughProperty("UiRadioButton2")]
		private UIRadioButton _UiRadioButton2;

		// Token: 0x04000F62 RID: 3938
		[AccessedThroughProperty("UiRadioButton1")]
		private UIRadioButton _UiRadioButton1;

		// Token: 0x04000F63 RID: 3939
		private Frm_SelectItem frm;

		// Token: 0x04000F64 RID: 3940
		private Kharid_Darsad Kharid_Darsad;

		// Token: 0x04000F65 RID: 3941
		private bool prevent;

		// Token: 0x04000F66 RID: 3942
		[CompilerGenerated]
		private string _furush_num;

		// Token: 0x04000F67 RID: 3943
		[CompilerGenerated]
		private string _Furush_ID;

		// Token: 0x04000F68 RID: 3944
		[CompilerGenerated]
		private long _Mablagh;

		// Token: 0x04000F69 RID: 3945
		[CompilerGenerated]
		private string _Darsad;

		// Token: 0x04000F6A RID: 3946
		[CompilerGenerated]
		private long _Karmozd;

		// Token: 0x04000F6B RID: 3947
		[CompilerGenerated]
		private bool _has_Delete;
	}
}
