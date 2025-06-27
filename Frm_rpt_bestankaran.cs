using System;
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
using Janus.Windows.GridEX.EditControls;
using Janus.Windows.UI;
using Janus.Windows.UI.Dock;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Stimulsoft.Report;
using Stimulsoft.Report.Components;
using Stimulsoft.Report.Export;

namespace FruitBox
{
	// Token: 0x02000126 RID: 294
	[DesignerGenerated]
	public partial class Frm_rpt_bestankaran : Form
	{
		// Token: 0x06002AB1 RID: 10929 RVA: 0x0000A9DD File Offset: 0x00008BDD
		[DebuggerNonUserCode]
		public Frm_rpt_bestankaran()
		{
			base.Load += new EventHandler(this.Frm_rpt_checkDaryafti_Load);
			base.KeyDown += new KeyEventHandler(this.Frm_rpt_bestankaran_KeyDown);
			Frm_rpt_bestankaran.__ENCAddToList(this);
			this.InitializeComponent();
		}

		// Token: 0x06002AB2 RID: 10930 RVA: 0x00200E2C File Offset: 0x001FF02C
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_rpt_bestankaran.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_rpt_bestankaran.__ENCList.Count == Frm_rpt_bestankaran.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_rpt_bestankaran.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_rpt_bestankaran.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_rpt_bestankaran.__ENCList[num] = Frm_rpt_bestankaran.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_rpt_bestankaran.__ENCList.RemoveRange(num, Frm_rpt_bestankaran.__ENCList.Count - num);
						Frm_rpt_bestankaran.__ENCList.Capacity = Frm_rpt_bestankaran.__ENCList.Count;
					}
					Frm_rpt_bestankaran.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000D00 RID: 3328
		// (get) Token: 0x06002AB5 RID: 10933 RVA: 0x00201FE4 File Offset: 0x002001E4
		// (set) Token: 0x06002AB6 RID: 10934 RVA: 0x0000AA1D File Offset: 0x00008C1D
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
				this._GridEX1 = value;
			}
		}

		// Token: 0x17000D01 RID: 3329
		// (get) Token: 0x06002AB7 RID: 10935 RVA: 0x00201FFC File Offset: 0x002001FC
		// (set) Token: 0x06002AB8 RID: 10936 RVA: 0x0000AA27 File Offset: 0x00008C27
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

		// Token: 0x17000D02 RID: 3330
		// (get) Token: 0x06002AB9 RID: 10937 RVA: 0x00202014 File Offset: 0x00200214
		// (set) Token: 0x06002ABA RID: 10938 RVA: 0x0000AA31 File Offset: 0x00008C31
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

		// Token: 0x17000D03 RID: 3331
		// (get) Token: 0x06002ABB RID: 10939 RVA: 0x0020202C File Offset: 0x0020022C
		// (set) Token: 0x06002ABC RID: 10940 RVA: 0x00202044 File Offset: 0x00200244
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

		// Token: 0x17000D04 RID: 3332
		// (get) Token: 0x06002ABD RID: 10941 RVA: 0x002020A4 File Offset: 0x002002A4
		// (set) Token: 0x06002ABE RID: 10942 RVA: 0x002020BC File Offset: 0x002002BC
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
				EventHandler value2 = new EventHandler(this.ButtonItem1_Click_1);
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

		// Token: 0x17000D05 RID: 3333
		// (get) Token: 0x06002ABF RID: 10943 RVA: 0x0020211C File Offset: 0x0020031C
		// (set) Token: 0x06002AC0 RID: 10944 RVA: 0x00202134 File Offset: 0x00200334
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

		// Token: 0x17000D06 RID: 3334
		// (get) Token: 0x06002AC1 RID: 10945 RVA: 0x00202194 File Offset: 0x00200394
		// (set) Token: 0x06002AC2 RID: 10946 RVA: 0x002021AC File Offset: 0x002003AC
		internal virtual EditBox txt_search
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_search;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txt_search_TextChanged);
				bool flag = this._txt_search != null;
				if (flag)
				{
					this._txt_search.TextChanged -= value2;
				}
				this._txt_search = value;
				flag = (this._txt_search != null);
				if (flag)
				{
					this._txt_search.TextChanged += value2;
				}
			}
		}

		// Token: 0x17000D07 RID: 3335
		// (get) Token: 0x06002AC3 RID: 10947 RVA: 0x0020220C File Offset: 0x0020040C
		// (set) Token: 0x06002AC4 RID: 10948 RVA: 0x0000AA3B File Offset: 0x00008C3B
		internal virtual SelectItem SelectItem1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._SelectItem1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._SelectItem1 = value;
			}
		}

		// Token: 0x17000D08 RID: 3336
		// (get) Token: 0x06002AC5 RID: 10949 RVA: 0x00202224 File Offset: 0x00200424
		// (set) Token: 0x06002AC6 RID: 10950 RVA: 0x0020223C File Offset: 0x0020043C
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

		// Token: 0x17000D09 RID: 3337
		// (get) Token: 0x06002AC7 RID: 10951 RVA: 0x0020229C File Offset: 0x0020049C
		// (set) Token: 0x06002AC8 RID: 10952 RVA: 0x0000AA45 File Offset: 0x00008C45
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

		// Token: 0x17000D0A RID: 3338
		// (get) Token: 0x06002AC9 RID: 10953 RVA: 0x002022B4 File Offset: 0x002004B4
		// (set) Token: 0x06002ACA RID: 10954 RVA: 0x0000AA4F File Offset: 0x00008C4F
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

		// Token: 0x17000D0B RID: 3339
		// (get) Token: 0x06002ACB RID: 10955 RVA: 0x002022CC File Offset: 0x002004CC
		// (set) Token: 0x06002ACC RID: 10956 RVA: 0x0000AA59 File Offset: 0x00008C59
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

		// Token: 0x17000D0C RID: 3340
		// (get) Token: 0x06002ACD RID: 10957 RVA: 0x002022E4 File Offset: 0x002004E4
		// (set) Token: 0x06002ACE RID: 10958 RVA: 0x0000AA63 File Offset: 0x00008C63
		internal virtual UICheckBox UiCheckBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiCheckBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._UiCheckBox1 = value;
			}
		}

		// Token: 0x17000D0D RID: 3341
		// (get) Token: 0x06002ACF RID: 10959 RVA: 0x002022FC File Offset: 0x002004FC
		// (set) Token: 0x06002AD0 RID: 10960 RVA: 0x00202314 File Offset: 0x00200514
		internal virtual SelectItem txt_noe_moshtari
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_noe_moshtari;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				SelectItem.SelectedValueChangedEventHandler obj = new SelectItem.SelectedValueChangedEventHandler(this.txt_noe_moshtari_SelectedValueChanged);
				EventHandler value2 = new EventHandler(this.txt_noe_moshtari_TextChanged);
				SelectItem.ValueDeletedEventHandler obj2 = new SelectItem.ValueDeletedEventHandler(this.txt_noe_moshtari_ValueDeleted);
				EventHandler value3 = new EventHandler(this.moaref_kind_ButtonClick);
				KeyEventHandler value4 = new KeyEventHandler(this.txt_noe_moshtari_KeyDown);
				bool flag = this._txt_noe_moshtari != null;
				if (flag)
				{
					this._txt_noe_moshtari.SelectedValueChanged -= obj;
					this._txt_noe_moshtari.TextChanged -= value2;
					this._txt_noe_moshtari.ValueDeleted -= obj2;
					this._txt_noe_moshtari.ButtonClick -= value3;
					this._txt_noe_moshtari.KeyDown -= value4;
				}
				this._txt_noe_moshtari = value;
				flag = (this._txt_noe_moshtari != null);
				if (flag)
				{
					this._txt_noe_moshtari.SelectedValueChanged += obj;
					this._txt_noe_moshtari.TextChanged += value2;
					this._txt_noe_moshtari.ValueDeleted += obj2;
					this._txt_noe_moshtari.ButtonClick += value3;
					this._txt_noe_moshtari.KeyDown += value4;
				}
			}
		}

		// Token: 0x17000D0E RID: 3342
		// (get) Token: 0x06002AD1 RID: 10961 RVA: 0x0020241C File Offset: 0x0020061C
		// (set) Token: 0x06002AD2 RID: 10962 RVA: 0x0000AA6D File Offset: 0x00008C6D
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

		// Token: 0x17000D0F RID: 3343
		// (get) Token: 0x06002AD3 RID: 10963 RVA: 0x00202434 File Offset: 0x00200634
		// (set) Token: 0x06002AD4 RID: 10964 RVA: 0x0020244C File Offset: 0x0020064C
		internal virtual ButtonItem ButtonItem8
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem8;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem8_Click);
				bool flag = this._ButtonItem8 != null;
				if (flag)
				{
					this._ButtonItem8.Click -= value2;
				}
				this._ButtonItem8 = value;
				flag = (this._ButtonItem8 != null);
				if (flag)
				{
					this._ButtonItem8.Click += value2;
				}
			}
		}

		// Token: 0x17000D10 RID: 3344
		// (get) Token: 0x06002AD5 RID: 10965 RVA: 0x002024AC File Offset: 0x002006AC
		// (set) Token: 0x06002AD6 RID: 10966 RVA: 0x0000AA77 File Offset: 0x00008C77
		internal virtual FolderBrowserDialog FolderBrowserDialog1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._FolderBrowserDialog1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._FolderBrowserDialog1 = value;
			}
		}

		// Token: 0x06002AD7 RID: 10967 RVA: 0x0000AA81 File Offset: 0x00008C81
		private void Delete_Ersalbar_Sanad()
		{
			Public_Function.ExecuteNonQuery("delete from sanad where sanadtype=8 and id not in (select sanad_id from [ErsalBar_Detail] )");
		}

		// Token: 0x06002AD8 RID: 10968 RVA: 0x002024C4 File Offset: 0x002006C4
		private void LoadData()
		{
			this.Delete_Ersalbar_Sanad();
			string str = string.Empty;
			bool flag = this.txt_noe_moshtari.Value != null && Operators.CompareString(this.txt_noe_moshtari.Value.ToString(), string.Empty, false) != 0;
			if (flag)
			{
				bool flag2 = Operators.ConditionalCompareObjectEqual(this.txt_noe_moshtari.Value, "1", false);
				if (flag2)
				{
					str = " AND (Moshtari.kind in (1,3,5)) ";
				}
				else
				{
					str = " AND (Moshtari.kind in (2,4,6)) ";
				}
			}
			DataTable dataSource = Public_Function.FillData("SELECT     t.bes, t.bed, t.jam_bes, t.CodeHesab_ID, t.Moshtari_Name,Moshtari_1.ID, Moshtari_1.Name, Moshtari_1.Family,Moshtari_1.avaldore_tarikh  FROM         (SELECT     SUM(Sanad.Bes) AS bes, SUM(Sanad.Bed) AS bed, SUM(Sanad.Bes - Sanad.Bed) AS jam_bes, Sanad.CodeHesab_ID, MIN(Code_Hesab.Name)  AS Moshtari_Name  FROM         Sanad INNER JOIN  Code_Hesab ON Sanad.CodeHesab_ID = Code_Hesab.ID INNER JOIN   Moshtari ON Code_Hesab.ID = Moshtari.CodeHesab_ID  WHERE   (Sanad.arztype is null) AND  (Code_Hesab.Grouh_ID = 2) " + str + " AND (Moshtari.ID NOT IN  (SELECT     Moshtari_ID  FROM         Sharik)) AND (Moshtari.ID NOT IN (SELECT Moshtari_ID from Not_IN_Bestankaran))   GROUP BY Sanad.CodeHesab_ID  HAVING      (SUM(Sanad.Bes- Sanad.Bed) > 0)) AS t INNER JOIN  Moshtari AS Moshtari_1 ON t.CodeHesab_ID = Moshtari_1.CodeHesab_ID ");
			this.GridEX1.DataSource = dataSource;
		}

		// Token: 0x06002AD9 RID: 10969 RVA: 0x00202564 File Offset: 0x00200764
		private void txt_noe_moshtari_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				this.moaref_kind_ButtonClick(null, null);
			}
		}

		// Token: 0x06002ADA RID: 10970 RVA: 0x0000AA90 File Offset: 0x00008C90
		private void txt_noe_moshtari_ValueDeleted(object sender, EventArgs e)
		{
			this.LoadData();
		}

		// Token: 0x06002ADB RID: 10971 RVA: 0x0020258C File Offset: 0x0020078C
		private void txt_noe_moshtari_TextChanged(object sender, EventArgs e)
		{
			bool flag = Operators.CompareString(this.txt_noe_moshtari.Text, string.Empty, false) == 0;
			if (flag)
			{
				this.txt_noe_moshtari_ValueDeleted(null, null);
			}
		}

		// Token: 0x06002ADC RID: 10972 RVA: 0x0000AA90 File Offset: 0x00008C90
		private void txt_noe_moshtari_SelectedValueChanged(object sender, EventArgs e)
		{
			this.LoadData();
		}

		// Token: 0x06002ADD RID: 10973 RVA: 0x002025C4 File Offset: 0x002007C4
		private void moaref_kind_ButtonClick(object sender, EventArgs e)
		{
			DataTable dataTable = new DataTable();
			dataTable.Columns.Add("id", typeof(int));
			dataTable.Columns.Add("name", typeof(string));
			dataTable.Rows.Add(new object[]
			{
				1,
				"خریدار"
			});
			dataTable.Rows.Add(new object[]
			{
				2,
				"صاحب بار"
			});
			Frm_SelectItem frm_SelectItem = new Frm_SelectItem();
			frm_SelectItem.items = new ItemCollection
			{
				new Column("Name", "عنوان", 100)
			};
			bool flag = frm_SelectItem.ShowDialog(dataTable, null, "انتخاب نوع مشتری") == DialogResult.OK;
			if (flag)
			{
				this.txt_noe_moshtari.SetValue(Conversions.ToString(frm_SelectItem.SelectedRow["Name"]), RuntimeHelpers.GetObjectValue(frm_SelectItem.SelectedRow["ID"]));
				this.txt_noe_moshtari_SelectedValueChanged(null, null);
			}
		}

		// Token: 0x06002ADE RID: 10974 RVA: 0x002026E0 File Offset: 0x002008E0
		private void Frm_rpt_bestankaran_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Escape;
			if (flag)
			{
				this.Close();
			}
			flag = (e.KeyCode == Keys.F3);
			if (flag)
			{
				this.ButtonItem3_Click(null, null);
			}
			flag = (e.KeyCode == Keys.F4);
			if (flag)
			{
				this.ButtonItem1_Click(null, null);
			}
			flag = (e.KeyCode == Keys.F5);
			if (flag)
			{
				this.ButtonItem2_Click(null, null);
			}
		}

		// Token: 0x06002ADF RID: 10975 RVA: 0x0000AA9B File Offset: 0x00008C9B
		private void Frm_rpt_checkDaryafti_Load(object sender, EventArgs e)
		{
			this.LoadData();
			this.UiComboBox1.SelectedValue = 3;
		}

		// Token: 0x06002AE0 RID: 10976 RVA: 0x00202750 File Offset: 0x00200950
		private void ButtonItem1_Click(object sender, EventArgs e)
		{
			StiReport stiReport = new StiReport();
			stiReport.Load(Application.StartupPath + "\\reports\\bestankaran.mrt");
			DataTable dataTable = (DataTable)this.GridEX1.DataSource;
			DataTable dataTable2 = dataTable.Copy();
			dataTable2.TableName = "data";
			stiReport.RegData(dataTable2);
			Public_Function.SetHeader(stiReport, false);
			Public_Function.AddTazminText(stiReport, false, false);
			stiReport.Show();
		}

		// Token: 0x06002AE1 RID: 10977 RVA: 0x002027C0 File Offset: 0x002009C0
		private void UiComboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = this.GridEX1.DataSource == null;
			if (!flag)
			{
				DataTable dataTable = (DataTable)this.GridEX1.DataSource;
				object selectedValue = this.UiComboBox1.SelectedValue;
				flag = Operators.ConditionalCompareObjectEqual(selectedValue, 1, false);
				if (flag)
				{
					dataTable.DefaultView.Sort = "jam_bes desc";
				}
				else
				{
					flag = Operators.ConditionalCompareObjectEqual(selectedValue, 3, false);
					if (flag)
					{
						dataTable.DefaultView.Sort = "name asc,family asc";
					}
				}
				this.GridEX1.Row = 0;
				this.GridEX1.Focus();
			}
		}

		// Token: 0x06002AE2 RID: 10978 RVA: 0x00202868 File Offset: 0x00200A68
		private void ButtonItem3_Click(object sender, EventArgs e)
		{
			Frm_SuratHesab_Moshtari frm_SuratHesab_Moshtari = new Frm_SuratHesab_Moshtari();
			bool flag = this.GridEX1.CurrentRow.Cells["id"].Value != DBNull.Value;
			if (flag)
			{
				bool flag2 = Operators.ConditionalCompareObjectNotEqual(this.GridEX1.CurrentRow.Cells["id"].Value, -1, false);
				if (flag2)
				{
					Frm_SuratHesab_Moshtari arg_98_0 = frm_SuratHesab_Moshtari;
					object expr_86 = this.GridEX1.CurrentRow.Cells["id"].Value;
					int? num;
					arg_98_0.Moshtari_id = ((expr_86 != null) ? ((int?)expr_86) : num);
					frm_SuratHesab_Moshtari.Moshtari_Name = Conversions.ToString(this.GridEX1.CurrentRow.Cells["Moshtari_Name"].Value);
				}
			}
			MyProject.Forms.Form_Main.Dialog_ShowForm(frm_SuratHesab_Moshtari);
		}

		// Token: 0x06002AE3 RID: 10979 RVA: 0x00202954 File Offset: 0x00200B54
		private void ButtonItem2_Click(object sender, EventArgs e)
		{
			this.txt_search.Text = string.Empty;
			bool flag = this.SelectItem1.Value != null;
			if (flag)
			{
				this.LoadData();
				this.SelectItem1.SetNew();
			}
			this.txt_search.Focus();
		}

		// Token: 0x06002AE4 RID: 10980 RVA: 0x00200550 File Offset: 0x001FE750
		private void FilterGrid(GridEX Grid, string Text)
		{
			DataView defaultView = ((DataTable)Grid.DataSource).DefaultView;
			bool flag = Operators.CompareString(Text, string.Empty, false) == 0;
			if (flag)
			{
				defaultView.RowFilter = "";
			}
			else
			{
				defaultView.RowFilter = "moshtari_name LIKE '%" + Text + "%'";
				Public_Function.HighlightCell(Grid, Text);
			}
		}

		// Token: 0x06002AE5 RID: 10981 RVA: 0x0000AAB8 File Offset: 0x00008CB8
		private void txt_search_TextChanged(object sender, EventArgs e)
		{
			this.FilterGrid(this.GridEX1, this.txt_search.Text);
		}

		// Token: 0x06002AE6 RID: 10982 RVA: 0x002029AC File Offset: 0x00200BAC
		private StiReport RenderReport(bool pdf)
		{
			StiReport stiReport = new StiReport();
			stiReport.Load(Application.StartupPath + "\\reports\\bestankaran.mrt");
			DataTable dataTable = (DataTable)this.GridEX1.DataSource;
			dataTable.TableName = "data";
			stiReport.RegData(dataTable.DefaultView);
			Public_Function.SetHeader(stiReport, pdf);
			Public_Function.AddTazminText(stiReport, true, pdf);
			Public_Function.setReportFont(stiReport, "Text5,Text10,Text6");
			Public_Function.SetReport_MarginTop(stiReport);
			return stiReport;
		}

		// Token: 0x06002AE7 RID: 10983 RVA: 0x00202A2C File Offset: 0x00200C2C
		private void ButtonItem1_Click_1(object sender, EventArgs e)
		{
			StiReport stiReport = this.RenderReport(false);
			bool flag = stiReport != null;
			if (flag)
			{
				stiReport.Print(false);
			}
		}

		// Token: 0x06002AE8 RID: 10984 RVA: 0x001C94E4 File Offset: 0x001C76E4
		private void Remove_(StiReport report, string stitext)
		{
			string[] array = stitext.Split(new char[]
			{
				','
			});
			string[] array2 = array;
			checked
			{
				for (int i = 0; i < array2.Length; i++)
				{
					string componentName = array2[i];
					StiText stiText = (StiText)report.GetComponentByName(componentName);
					bool flag = stiText == null;
					if (!flag)
					{
						stiText.Text = stiText.Text.ToString().Replace("ـ", "");
					}
				}
			}
		}

		// Token: 0x06002AE9 RID: 10985 RVA: 0x00202A58 File Offset: 0x00200C58
		private void ButtonItem8_Click(object sender, EventArgs e)
		{
			StiReport stiReport = this.RenderReport(true);
			bool flag = stiReport == null;
			if (!flag)
			{
				flag = (this.FolderBrowserDialog1.ShowDialog() == DialogResult.OK);
				if (flag)
				{
					StiPdfExportService stiPdfExportService = new StiPdfExportService();
					StiJpegExportSettings stiJpegExportSettings = new StiJpegExportSettings();
					stiPdfExportService.MultipleFiles = true;
					this.Remove_(stiReport, "txt_tarikh,Text10,Text1,Text13,Text7,Text5,Text2");
					stiReport.Render(true);
					string text = Public_Function.MiladiToShamsi(DateAndTime.Now).Replace("/", "-");
					stiPdfExportService.ExportPdf(stiReport, this.FolderBrowserDialog1.SelectedPath + "بستانکاران.pdf");
					Public_Function.ShowMessage("گزارش تهیه گردید", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, null);
				}
			}
		}

		// Token: 0x040010A5 RID: 4261
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x040010A7 RID: 4263
		[AccessedThroughProperty("GridEX1")]
		private GridEX _GridEX1;

		// Token: 0x040010A8 RID: 4264
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x040010A9 RID: 4265
		[AccessedThroughProperty("Bar1")]
		private Bar _Bar1;

		// Token: 0x040010AA RID: 4266
		[AccessedThroughProperty("ButtonItem3")]
		private ButtonItem _ButtonItem3;

		// Token: 0x040010AB RID: 4267
		[AccessedThroughProperty("ButtonItem1")]
		private ButtonItem _ButtonItem1;

		// Token: 0x040010AC RID: 4268
		[AccessedThroughProperty("ButtonItem2")]
		private ButtonItem _ButtonItem2;

		// Token: 0x040010AD RID: 4269
		[AccessedThroughProperty("txt_search")]
		private EditBox _txt_search;

		// Token: 0x040010AE RID: 4270
		[AccessedThroughProperty("SelectItem1")]
		private SelectItem _SelectItem1;

		// Token: 0x040010AF RID: 4271
		[AccessedThroughProperty("UiComboBox1")]
		private UIComboBox _UiComboBox1;

		// Token: 0x040010B0 RID: 4272
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x040010B1 RID: 4273
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x040010B2 RID: 4274
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x040010B3 RID: 4275
		[AccessedThroughProperty("UiCheckBox1")]
		private UICheckBox _UiCheckBox1;

		// Token: 0x040010B4 RID: 4276
		[AccessedThroughProperty("txt_noe_moshtari")]
		private SelectItem _txt_noe_moshtari;

		// Token: 0x040010B5 RID: 4277
		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		// Token: 0x040010B6 RID: 4278
		[AccessedThroughProperty("ButtonItem8")]
		private ButtonItem _ButtonItem8;

		// Token: 0x040010B7 RID: 4279
		[AccessedThroughProperty("FolderBrowserDialog1")]
		private FolderBrowserDialog _FolderBrowserDialog1;
	}
}
