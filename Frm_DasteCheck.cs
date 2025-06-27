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
	// Token: 0x020000C8 RID: 200
	[DesignerGenerated]
	public partial class Frm_DasteCheck : Form
	{
		// Token: 0x06001090 RID: 4240 RVA: 0x000B6C44 File Offset: 0x000B4E44
		public Frm_DasteCheck()
		{
			base.KeyDown += new KeyEventHandler(this.Frm_Anbar_KeyDown);
			base.Load += new EventHandler(this.Frm_Anbar_Load);
			Frm_DasteCheck.__ENCAddToList(this);
			this.DasteCheck = new DasteCheck();
			this.InitializeComponent();
		}

		// Token: 0x06001091 RID: 4241 RVA: 0x000B6C9C File Offset: 0x000B4E9C
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_DasteCheck.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_DasteCheck.__ENCList.Count == Frm_DasteCheck.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_DasteCheck.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_DasteCheck.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_DasteCheck.__ENCList[num] = Frm_DasteCheck.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_DasteCheck.__ENCList.RemoveRange(num, Frm_DasteCheck.__ENCList.Count - num);
						Frm_DasteCheck.__ENCList.Capacity = Frm_DasteCheck.__ENCList.Count;
					}
					Frm_DasteCheck.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x06001094 RID: 4244 RVA: 0x000B7CDC File Offset: 0x000B5EDC
		// (set) Token: 0x06001095 RID: 4245 RVA: 0x00005911 File Offset: 0x00003B11
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

		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x06001096 RID: 4246 RVA: 0x000B7CF4 File Offset: 0x000B5EF4
		// (set) Token: 0x06001097 RID: 4247 RVA: 0x000B7D0C File Offset: 0x000B5F0C
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

		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x06001098 RID: 4248 RVA: 0x000B7D94 File Offset: 0x000B5F94
		// (set) Token: 0x06001099 RID: 4249 RVA: 0x0000591B File Offset: 0x00003B1B
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

		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x0600109A RID: 4250 RVA: 0x000B7DAC File Offset: 0x000B5FAC
		// (set) Token: 0x0600109B RID: 4251 RVA: 0x00005925 File Offset: 0x00003B25
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

		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x0600109C RID: 4252 RVA: 0x000B7DC4 File Offset: 0x000B5FC4
		// (set) Token: 0x0600109D RID: 4253 RVA: 0x000B7DDC File Offset: 0x000B5FDC
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

		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x0600109E RID: 4254 RVA: 0x000B7E3C File Offset: 0x000B603C
		// (set) Token: 0x0600109F RID: 4255 RVA: 0x000B7E54 File Offset: 0x000B6054
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

		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x060010A0 RID: 4256 RVA: 0x000B7EB4 File Offset: 0x000B60B4
		// (set) Token: 0x060010A1 RID: 4257 RVA: 0x000B7ECC File Offset: 0x000B60CC
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

		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x060010A2 RID: 4258 RVA: 0x000B7F2C File Offset: 0x000B612C
		// (set) Token: 0x060010A3 RID: 4259 RVA: 0x0000592F File Offset: 0x00003B2F
		internal virtual SelectItem txt_hesabbank
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_hesabbank;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_hesabbank = value;
			}
		}

		// Token: 0x1700052C RID: 1324
		// (get) Token: 0x060010A4 RID: 4260 RVA: 0x000B7F44 File Offset: 0x000B6144
		// (set) Token: 0x060010A5 RID: 4261 RVA: 0x00005939 File Offset: 0x00003B39
		internal virtual NumericBox txt_tashomare
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_tashomare;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_tashomare = value;
			}
		}

		// Token: 0x1700052D RID: 1325
		// (get) Token: 0x060010A6 RID: 4262 RVA: 0x000B7F5C File Offset: 0x000B615C
		// (set) Token: 0x060010A7 RID: 4263 RVA: 0x000B7F74 File Offset: 0x000B6174
		internal virtual NumericBox txt_tedad
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_tedad;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				CancelEventHandler value2 = new CancelEventHandler(this.txt_tashomare_Validating);
				bool flag = this._txt_tedad != null;
				if (flag)
				{
					this._txt_tedad.Validating -= value2;
				}
				this._txt_tedad = value;
				flag = (this._txt_tedad != null);
				if (flag)
				{
					this._txt_tedad.Validating += value2;
				}
			}
		}

		// Token: 0x1700052E RID: 1326
		// (get) Token: 0x060010A8 RID: 4264 RVA: 0x000B7FD4 File Offset: 0x000B61D4
		// (set) Token: 0x060010A9 RID: 4265 RVA: 0x000B7FEC File Offset: 0x000B61EC
		internal virtual NumericBox txt_azshomare
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_azshomare;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				CancelEventHandler value2 = new CancelEventHandler(this.txt_azshomare_Validating);
				bool flag = this._txt_azshomare != null;
				if (flag)
				{
					this._txt_azshomare.Validating -= value2;
				}
				this._txt_azshomare = value;
				flag = (this._txt_azshomare != null);
				if (flag)
				{
					this._txt_azshomare.Validating += value2;
				}
			}
		}

		// Token: 0x1700052F RID: 1327
		// (get) Token: 0x060010AA RID: 4266 RVA: 0x000B804C File Offset: 0x000B624C
		// (set) Token: 0x060010AB RID: 4267 RVA: 0x00005943 File Offset: 0x00003B43
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

		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x060010AC RID: 4268 RVA: 0x000B8064 File Offset: 0x000B6264
		// (set) Token: 0x060010AD RID: 4269 RVA: 0x0000594D File Offset: 0x00003B4D
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

		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x060010AE RID: 4270 RVA: 0x000B807C File Offset: 0x000B627C
		// (set) Token: 0x060010AF RID: 4271 RVA: 0x00005957 File Offset: 0x00003B57
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

		// Token: 0x060010B0 RID: 4272 RVA: 0x000B8094 File Offset: 0x000B6294
		private void GetData()
		{
			DataTable all = this.DasteCheck.GetAll();
			this.GridEX1.DataSource = all;
		}

		// Token: 0x060010B1 RID: 4273 RVA: 0x000B80BC File Offset: 0x000B62BC
		private void RefreshDatarow(DataRow dr)
		{
			dr.BeginEdit();
			this.txt_hesabbank.SetValue(Conversions.ToString(dr["Name"]), RuntimeHelpers.GetObjectValue(dr["BankHesab_ID"]));
			dr["Name"] = this.txt_hesabbank.Text;
			dr["BankHesab_ID"] = RuntimeHelpers.GetObjectValue(this.txt_hesabbank.Value);
			dr["az_Shomare"] = this.txt_azshomare.Text;
			dr["ta_shomare"] = this.txt_tashomare.Text;
			dr["tedad"] = this.txt_tedad.Text;
			dr.EndEdit();
		}

		// Token: 0x060010B2 RID: 4274 RVA: 0x000B8180 File Offset: 0x000B6380
		private void LoadDatarow(DataRow dr)
		{
			this.txt_hesabbank.SetValue(Conversions.ToString(dr["Name"]), RuntimeHelpers.GetObjectValue(dr["BankHesab_ID"]));
			this.txt_azshomare.Text = dr["az_shomare"].ToString();
			this.txt_tashomare.Text = dr["ta_shomare"].ToString();
			this.txt_tedad.Text = dr["tedad"].ToString();
		}

		// Token: 0x060010B3 RID: 4275 RVA: 0x00005961 File Offset: 0x00003B61
		private void ButtonItem1_Click(object sender, EventArgs e)
		{
			this.isnew = true;
			Public_Function.SetNew(this.UiGroupBox1);
			this.txt_hesabbank.Focus();
		}

		// Token: 0x060010B4 RID: 4276 RVA: 0x000B8210 File Offset: 0x000B6410
		private void ButtonItem2_Click(object sender, EventArgs e)
		{
			bool flag = Public_Function.HasNull(this.UiGroupBox1);
			checked
			{
				if (!flag)
				{
					flag = this.isnew;
					if (flag)
					{
						this.DasteCheck.Insert(Conversions.ToString(this.txt_hesabbank.Value), this.txt_azshomare.Text, this.txt_tedad.Text, this.txt_tashomare.Text);
						this.GetData();
						Public_Function.ConfirmInsert();
						this.Close();
						this.ButtonItem1_Click(null, null);
					}
					else
					{
						flag = (Public_Function.ConfirmUpdate() == DialogResult.Yes);
						if (flag)
						{
							long value = Conversions.ToLong(((DataRowView)this.GridEX1.GetRow().DataRow)["id"]);
							string text = string.Empty;
							int arg_E3_0 = Conversions.ToInteger(this.txt_azshomare.Text);
							int num = Conversions.ToInteger(this.txt_tashomare.Text);
							int num2 = arg_E3_0;
							while (true)
							{
								int arg_104_0 = num2;
								int num3 = num;
								if (arg_104_0 > num3)
								{
									break;
								}
								text = text + Conversions.ToString(num2) + ",";
								num2++;
							}
							text = Public_Function.RemoveLast(text);
							DataTable dataTable = Public_Function.FillData(string.Concat(new string[]
							{
								"select sh_check,checkbarg_id from daryaftpardakht where checkbarg_id in(select id from dastecheckbarg where dastecheck_id=",
								Conversions.ToString(value),
								" and shomarebarg not in(",
								text,
								"))"
							}));
							flag = (dataTable.Rows.Count > 0);
							if (flag)
							{
								string text2 = string.Empty;
								try
								{
									IEnumerator enumerator = dataTable.Rows.GetEnumerator();
									while (enumerator.MoveNext())
									{
										DataRow dataRow = (DataRow)enumerator.Current;
										text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(dataRow["sh_check"], ",")));
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
								text2 = Public_Function.RemoveLast(text2);
								Public_Function.ShowMessage("شماره برگه های زیر دارای عملیات میباشد لطفا پس از حذف عملیات اقدام به اصلاح اطلاعات نمایید" + Environment.NewLine + text2, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, null);
							}
							else
							{
								Public_Function.ExecuteNonQuery(string.Concat(new string[]
								{
									"delete from dastecheckbarg where Dastecheck_id= ",
									Conversions.ToString(value),
									" and shomarebarg not in(",
									text,
									");"
								}));
								this.DasteCheck.Update(Conversions.ToString(this.txt_hesabbank.Value), this.txt_azshomare.Text, this.txt_tedad.Text, this.txt_tashomare.Text, Conversions.ToString(value));
								this.GetData();
								Public_Function.ConfirmInsert();
								this.Close();
							}
						}
					}
				}
			}
		}

		// Token: 0x060010B5 RID: 4277 RVA: 0x000B84DC File Offset: 0x000B66DC
		private void ButtonItem3_Click(object sender, EventArgs e)
		{
			bool flag = this.GridEX1.GetRow() == null;
			checked
			{
				if (!flag)
				{
					flag = (Public_Function.ConfirmDelete() == DialogResult.Yes);
					if (flag)
					{
						string text = string.Empty;
						int arg_54_0 = Conversions.ToInteger(this.txt_azshomare.Text);
						int num = Conversions.ToInteger(this.txt_tashomare.Text);
						int num2 = arg_54_0;
						while (true)
						{
							int arg_75_0 = num2;
							int num3 = num;
							if (arg_75_0 > num3)
							{
								break;
							}
							text = text + Conversions.ToString(num2) + ",";
							num2++;
						}
						text = Public_Function.RemoveLast(text);
						long value = Conversions.ToLong(((DataRowView)this.GridEX1.GetRow().DataRow)["id"]);
						DataTable dataTable = Public_Function.FillData(string.Concat(new string[]
						{
							"select sh_check,checkbarg_id from daryaftpardakht where checkbarg_id in(select id from dastecheckbarg where dastecheck_id=",
							Conversions.ToString(value),
							" and shomarebarg in(",
							text,
							"))"
						}));
						flag = (dataTable.Rows.Count > 0);
						if (flag)
						{
							string text2 = string.Empty;
							try
							{
								IEnumerator enumerator = dataTable.Rows.GetEnumerator();
								while (enumerator.MoveNext())
								{
									DataRow dataRow = (DataRow)enumerator.Current;
									text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(dataRow["sh_check"], ",")));
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
							text2 = Public_Function.RemoveLast(text2);
							Public_Function.ShowMessage("شماره برگه های زیر دارای عملیات میباشد لطفا پس از حذف عملیات اقدام به اصلاح اطلاعات نمایید" + Environment.NewLine + text2, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, null);
						}
						else
						{
							this.DasteCheck.Delete(Conversions.ToString(((DataRowView)this.GridEX1.GetRow().DataRow)["ID"]));
							this.GridEX1.GetRow().Delete();
							flag = (this.GridEX1.RowCount == 0);
							if (flag)
							{
								this.ButtonItem1_Click(null, null);
							}
						}
					}
				}
			}
		}

		// Token: 0x060010B6 RID: 4278 RVA: 0x000B86FC File Offset: 0x000B68FC
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

		// Token: 0x060010B7 RID: 4279 RVA: 0x000B8794 File Offset: 0x000B6994
		private void Frm_Anbar_Load(object sender, EventArgs e)
		{
			this.GridEX1.FocusCellFormatStyle.BackColor = this.GridEX1.SelectedFormatStyle.BackColor;
			this.txt_hesabbank.SelectCommand = " SELECT        Bank_Hesab.ID, Bank.Name + ' - ' + Bank_Hesab.Shobe AS Name  FROM            Bank_Hesab INNER JOIN  Bank ON Bank_Hesab.Bank_ID = Bank.ID";
			this.txt_hesabbank.AddNewForm = MyProject.Forms.Frm_Bank_Hesab;
			this.txt_hesabbank.Edit_Frm = MyProject.Forms.Frm_Bank_Hesab;
			this.GetData();
			this.ButtonItem1_Click(null, null);
		}

		// Token: 0x060010B8 RID: 4280 RVA: 0x00005984 File Offset: 0x00003B84
		private void GridEX1_RowDoubleClick(object sender, RowActionEventArgs e)
		{
			this.GridEX1_SelectionChanged(null, null);
		}

		// Token: 0x060010B9 RID: 4281 RVA: 0x000B8814 File Offset: 0x000B6A14
		private void GridEX1_SelectionChanged(object sender, EventArgs e)
		{
			bool flag = this.GridEX1.GetRow() == null;
			if (!flag)
			{
				DataRow row = ((DataRowView)this.GridEX1.GetRow().DataRow).Row;
				this.isnew = false;
				this.LoadDatarow(row);
			}
		}

		// Token: 0x060010BA RID: 4282 RVA: 0x000B8864 File Offset: 0x000B6A64
		private void txt_azshomare_Validating(object sender, CancelEventArgs e)
		{
			bool flag = Operators.CompareString(this.txt_tedad.Text, string.Empty, false) != 0;
			if (flag)
			{
				this.txt_tashomare.Text = Conversions.ToString(checked(Conversions.ToInteger(this.txt_azshomare.Text) + Conversions.ToInteger(this.txt_tedad.Text) - 1));
			}
			else
			{
				this.txt_tashomare.Text = string.Empty;
			}
		}

		// Token: 0x060010BB RID: 4283 RVA: 0x000B88DC File Offset: 0x000B6ADC
		private void txt_tashomare_Validating(object sender, CancelEventArgs e)
		{
			bool flag = Operators.CompareString(this.txt_azshomare.Text, string.Empty, false) != 0 && Operators.CompareString(this.txt_tedad.Text, string.Empty, false) != 0;
			if (flag)
			{
				this.txt_tashomare.Text = Conversions.ToString(checked(Conversions.ToInteger(this.txt_azshomare.Text) + Conversions.ToInteger(this.txt_tedad.Text) - 1));
			}
			else
			{
				this.txt_tashomare.Text = string.Empty;
			}
		}

		// Token: 0x04000659 RID: 1625
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x0400065B RID: 1627
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x0400065C RID: 1628
		[AccessedThroughProperty("GridEX1")]
		private DataEntryGrid _GridEX1;

		// Token: 0x0400065D RID: 1629
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x0400065E RID: 1630
		[AccessedThroughProperty("Bar1")]
		private Bar _Bar1;

		// Token: 0x0400065F RID: 1631
		[AccessedThroughProperty("ButtonItem1")]
		private ButtonItem _ButtonItem1;

		// Token: 0x04000660 RID: 1632
		[AccessedThroughProperty("ButtonItem2")]
		private ButtonItem _ButtonItem2;

		// Token: 0x04000661 RID: 1633
		[AccessedThroughProperty("ButtonItem3")]
		private ButtonItem _ButtonItem3;

		// Token: 0x04000662 RID: 1634
		[AccessedThroughProperty("txt_hesabbank")]
		private SelectItem _txt_hesabbank;

		// Token: 0x04000663 RID: 1635
		[AccessedThroughProperty("txt_tashomare")]
		private NumericBox _txt_tashomare;

		// Token: 0x04000664 RID: 1636
		[AccessedThroughProperty("txt_tedad")]
		private NumericBox _txt_tedad;

		// Token: 0x04000665 RID: 1637
		[AccessedThroughProperty("txt_azshomare")]
		private NumericBox _txt_azshomare;

		// Token: 0x04000666 RID: 1638
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		// Token: 0x04000667 RID: 1639
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x04000668 RID: 1640
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x04000669 RID: 1641
		private DasteCheck DasteCheck;

		// Token: 0x0400066A RID: 1642
		private bool isnew;
	}
}
