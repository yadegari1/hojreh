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
using Janus.Windows.GridEX.EditControls;
using Janus.Windows.UI;
using Janus.Windows.UI.Dock;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x020000D6 RID: 214
	[DesignerGenerated]
	public partial class Frm_SahebSaham : Form
	{
		// Token: 0x06001307 RID: 4871 RVA: 0x000CBC80 File Offset: 0x000C9E80
		public Frm_SahebSaham()
		{
			base.KeyDown += new KeyEventHandler(this.Frm_Anbar_KeyDown);
			base.Load += new EventHandler(this.Frm_Anbar_Load);
			Frm_SahebSaham.__ENCAddToList(this);
			this.SahebSaham = new Saheb_Saham();
			this.InitializeComponent();
		}

		// Token: 0x06001308 RID: 4872 RVA: 0x000CBCD8 File Offset: 0x000C9ED8
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_SahebSaham.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_SahebSaham.__ENCList.Count == Frm_SahebSaham.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_SahebSaham.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_SahebSaham.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_SahebSaham.__ENCList[num] = Frm_SahebSaham.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_SahebSaham.__ENCList.RemoveRange(num, Frm_SahebSaham.__ENCList.Count - num);
						Frm_SahebSaham.__ENCList.Capacity = Frm_SahebSaham.__ENCList.Count;
					}
					Frm_SahebSaham.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x170005ED RID: 1517
		// (get) Token: 0x0600130B RID: 4875 RVA: 0x000CC914 File Offset: 0x000CAB14
		// (set) Token: 0x0600130C RID: 4876 RVA: 0x0000633D File Offset: 0x0000453D
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

		// Token: 0x170005EE RID: 1518
		// (get) Token: 0x0600130D RID: 4877 RVA: 0x000CC92C File Offset: 0x000CAB2C
		// (set) Token: 0x0600130E RID: 4878 RVA: 0x000CC944 File Offset: 0x000CAB44
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

		// Token: 0x170005EF RID: 1519
		// (get) Token: 0x0600130F RID: 4879 RVA: 0x000CC9A4 File Offset: 0x000CABA4
		// (set) Token: 0x06001310 RID: 4880 RVA: 0x000CC9BC File Offset: 0x000CABBC
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

		// Token: 0x170005F0 RID: 1520
		// (get) Token: 0x06001311 RID: 4881 RVA: 0x000CCA1C File Offset: 0x000CAC1C
		// (set) Token: 0x06001312 RID: 4882 RVA: 0x000CCA34 File Offset: 0x000CAC34
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

		// Token: 0x170005F1 RID: 1521
		// (get) Token: 0x06001313 RID: 4883 RVA: 0x000CCA94 File Offset: 0x000CAC94
		// (set) Token: 0x06001314 RID: 4884 RVA: 0x00006347 File Offset: 0x00004547
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

		// Token: 0x170005F2 RID: 1522
		// (get) Token: 0x06001315 RID: 4885 RVA: 0x000CCAAC File Offset: 0x000CACAC
		// (set) Token: 0x06001316 RID: 4886 RVA: 0x00006351 File Offset: 0x00004551
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

		// Token: 0x170005F3 RID: 1523
		// (get) Token: 0x06001317 RID: 4887 RVA: 0x000CCAC4 File Offset: 0x000CACC4
		// (set) Token: 0x06001318 RID: 4888 RVA: 0x000CCADC File Offset: 0x000CACDC
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
				RowActionEventHandler value2 = new RowActionEventHandler(this.GridEX1_RowDoubleClick);
				EventHandler value3 = new EventHandler(this.GridEX1_SelectionChanged);
				bool flag = this._GridEX1 != null;
				if (flag)
				{
					this._GridEX1.RowDoubleClick -= value2;
					this._GridEX1.SelectionChanged -= value3;
				}
				this._GridEX1 = value;
				flag = (this._GridEX1 != null);
				if (flag)
				{
					this._GridEX1.RowDoubleClick += value2;
					this._GridEX1.SelectionChanged += value3;
				}
			}
		}

		// Token: 0x170005F4 RID: 1524
		// (get) Token: 0x06001319 RID: 4889 RVA: 0x000CCB64 File Offset: 0x000CAD64
		// (set) Token: 0x0600131A RID: 4890 RVA: 0x0000635B File Offset: 0x0000455B
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

		// Token: 0x170005F5 RID: 1525
		// (get) Token: 0x0600131B RID: 4891 RVA: 0x000CCB7C File Offset: 0x000CAD7C
		// (set) Token: 0x0600131C RID: 4892 RVA: 0x00006365 File Offset: 0x00004565
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

		// Token: 0x170005F6 RID: 1526
		// (get) Token: 0x0600131D RID: 4893 RVA: 0x000CCB94 File Offset: 0x000CAD94
		// (set) Token: 0x0600131E RID: 4894 RVA: 0x0000636F File Offset: 0x0000456F
		internal virtual SelectItem txt_name
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_name;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_name = value;
			}
		}

		// Token: 0x0600131F RID: 4895 RVA: 0x000CCBAC File Offset: 0x000CADAC
		private void GetData()
		{
			DataTable all = this.SahebSaham.GetAll();
			try
			{
				IEnumerator enumerator = all.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					dataRow["darsad"] = Public_Function.GetDecimalValue(Conversions.ToDecimal(dataRow["darsad"]));
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
			this.GridEX1.DataSource = all;
			this.getnotin();
		}

		// Token: 0x06001320 RID: 4896 RVA: 0x000CCC58 File Offset: 0x000CAE58
		private void LoadDataRow(DataRow dt)
		{
			this.txt_name.SetValue(Conversions.ToString(dt["name"]), RuntimeHelpers.GetObjectValue(dt["moshtari_id"]));
			this.txt_darsad.Text = Conversions.ToString(dt["darsad"]);
		}

		// Token: 0x06001321 RID: 4897 RVA: 0x00006379 File Offset: 0x00004579
		private void ButtonItem1_Click(object sender, EventArgs e)
		{
			this.isnew = true;
			Public_Function.SetNew(this.UiGroupBox1);
			this.txt_name.Focus();
		}

		// Token: 0x06001322 RID: 4898 RVA: 0x000CCCB0 File Offset: 0x000CAEB0
		private bool GetSum()
		{
			DataTable dataTable = (DataTable)this.GridEX1.DataSource;
			int num = 0;
			bool flag;
			try
			{
				IEnumerator enumerator = dataTable.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					num = Conversions.ToInteger(Operators.AddObject(num, dataRow["darsad"]));
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
			flag = (this.GridEX1.CurrentRow != null);
			if (flag)
			{
				num = Conversions.ToInteger(Operators.SubtractObject(num, this.GridEX1.CurrentRow.Cells["darsad"].Value));
			}
			flag = (Operators.CompareString(this.txt_darsad.Text, string.Empty, false) != 0);
			bool result;
			if (flag)
			{
				bool flag2 = (double)num + Conversions.ToDouble(this.txt_darsad.Text) > 100.0;
				if (flag2)
				{
					this.txt_darsad.ShowTip("درصد شراکت نمیتواند بیشتر از " + Conversions.ToString(checked(100 - num)) + " باشد");
					result = false;
					return result;
				}
			}
			result = true;
			return result;
		}

		// Token: 0x06001323 RID: 4899 RVA: 0x000CCE0C File Offset: 0x000CB00C
		private void ButtonItem2_Click(object sender, EventArgs e)
		{
			bool flag = Public_Function.HasNull(this.UiGroupBox1);
			if (!flag)
			{
				flag = (Operators.CompareString(this.txt_darsad.Text, string.Empty, false) != 0);
				bool flag2;
				if (flag)
				{
					flag2 = (Conversions.ToDouble(this.txt_darsad.Text) > 100.0);
					if (flag2)
					{
						this.txt_darsad.ShowTip("درصد شراکت بیشتر ار از 100 نمیتواند باشد");
						return;
					}
				}
				flag2 = !this.GetSum();
				if (!flag2)
				{
					flag2 = (Operators.CompareString(this.txt_darsad.Text, string.Empty, false) == 0);
					if (flag2)
					{
						this.txt_darsad.Text = "0";
					}
					flag2 = this.isnew;
					if (flag2)
					{
						long value = this.SahebSaham.Insert(Conversions.ToString(this.txt_name.Value), this.txt_darsad.Text);
						Public_Function.ConfirmInsert();
						this.GetData();
						this.ButtonItem1_Click(null, null);
					}
					else
					{
						flag2 = (Public_Function.ConfirmUpdate() == DialogResult.Yes);
						if (flag2)
						{
							long value = Conversions.ToLong(((DataRowView)this.GridEX1.GetRow().DataRow)["moshtari_id"]);
							this.SahebSaham.Update(Conversions.ToString(this.txt_name.Value), this.txt_darsad.Text, Conversions.ToString(value));
							Public_Function.ConfirmInsert();
							this.GetData();
						}
					}
				}
			}
		}

		// Token: 0x06001324 RID: 4900 RVA: 0x000CCF84 File Offset: 0x000CB184
		private void ButtonItem3_Click(object sender, EventArgs e)
		{
			bool flag = this.GridEX1.GetRow() == null;
			if (!flag)
			{
				flag = (Public_Function.ConfirmDelete() == DialogResult.Yes);
				if (flag)
				{
					this.SahebSaham.Delete(Conversions.ToString(((DataRowView)this.GridEX1.GetRow().DataRow)["moshtari_id"]));
					this.GetData();
					flag = (this.GridEX1.RowCount == 0);
					if (flag)
					{
						this.ButtonItem1_Click(null, null);
					}
				}
			}
		}

		// Token: 0x06001325 RID: 4901 RVA: 0x000CD008 File Offset: 0x000CB208
		private void Frm_Anbar_KeyDown(object sender, KeyEventArgs e)
		{
			Keys keyCode = e.KeyCode;
			bool flag = keyCode == Keys.Insert;
			if (flag)
			{
				bool flag2 = this.ButtonItem1.Visible;
				if (flag2)
				{
					this.ButtonItem1_Click(null, null);
				}
			}
			else
			{
				bool flag2 = keyCode == Keys.F2;
				if (flag2)
				{
					flag = this.ButtonItem2.Visible;
					if (flag)
					{
						this.ButtonItem2_Click(null, null);
					}
				}
				else
				{
					flag2 = (keyCode == Keys.F5);
					if (flag2)
					{
						flag = this.ButtonItem3.Visible;
						if (flag)
						{
							this.ButtonItem3_Click(null, null);
						}
					}
					else
					{
						flag2 = (keyCode == Keys.Escape);
						if (flag2)
						{
							this.Close();
						}
					}
				}
			}
		}

		// Token: 0x06001326 RID: 4902 RVA: 0x000CD0A0 File Offset: 0x000CB2A0
		private void getnotin()
		{
			string text = string.Empty;
			bool flag = this.GridEX1.DataSource != null;
			if (flag)
			{
				text = Public_Function.GetID((DataTable)this.GridEX1.DataSource, "moshtari_id", "");
			}
			flag = (Operators.CompareString(text, string.Empty, false) != 0);
			if (flag)
			{
				text = " and id not in(" + text + ")";
			}
			this.txt_name.SelectCommand = "Select Id,name + ' ' + Family as Name From Moshtari where id > -1" + text;
		}

		// Token: 0x06001327 RID: 4903 RVA: 0x000CD12C File Offset: 0x000CB32C
		private void Frm_Anbar_Load(object sender, EventArgs e)
		{
			this.txt_name.AddNewForm = MyProject.Forms.Frm_Moshtari;
			this.txt_name.Edit_Frm = MyProject.Forms.Frm_Moshtari;
			this.GridEX1.FocusCellFormatStyle.BackColor = this.GridEX1.SelectedFormatStyle.BackColor;
			this.GetData();
			this.ButtonItem1_Click(null, null);
		}

		// Token: 0x06001328 RID: 4904 RVA: 0x0000639C File Offset: 0x0000459C
		private void GridEX1_RowDoubleClick(object sender, RowActionEventArgs e)
		{
			this.GridEX1_SelectionChanged(null, null);
		}

		// Token: 0x06001329 RID: 4905 RVA: 0x000CD198 File Offset: 0x000CB398
		private void GridEX1_SelectionChanged(object sender, EventArgs e)
		{
			bool flag = this.GridEX1.GetRow() == null;
			if (!flag)
			{
				DataRow row = ((DataRowView)this.GridEX1.GetRow().DataRow).Row;
				this.isnew = false;
				this.LoadDataRow(row);
			}
		}

		// Token: 0x0400075D RID: 1885
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x0400075F RID: 1887
		[AccessedThroughProperty("Bar1")]
		private Bar _Bar1;

		// Token: 0x04000760 RID: 1888
		[AccessedThroughProperty("ButtonItem1")]
		private ButtonItem _ButtonItem1;

		// Token: 0x04000761 RID: 1889
		[AccessedThroughProperty("ButtonItem2")]
		private ButtonItem _ButtonItem2;

		// Token: 0x04000762 RID: 1890
		[AccessedThroughProperty("ButtonItem3")]
		private ButtonItem _ButtonItem3;

		// Token: 0x04000763 RID: 1891
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04000764 RID: 1892
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x04000765 RID: 1893
		[AccessedThroughProperty("GridEX1")]
		private DataEntryGrid _GridEX1;

		// Token: 0x04000766 RID: 1894
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x04000767 RID: 1895
		[AccessedThroughProperty("txt_darsad")]
		private NumericBox _txt_darsad;

		// Token: 0x04000768 RID: 1896
		[AccessedThroughProperty("txt_name")]
		private SelectItem _txt_name;

		// Token: 0x04000769 RID: 1897
		private Saheb_Saham SahebSaham;

		// Token: 0x0400076A RID: 1898
		private bool isnew;
	}
}
