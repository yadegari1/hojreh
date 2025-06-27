using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using FruitBox.My.Resources;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.GridEX.EditControls;
using Janus.Windows.UI;
using Janus.Windows.UI.Dock;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x020000DE RID: 222
	[DesignerGenerated]
	public partial class Frm_Bargasht_Checkd : Form
	{
		// Token: 0x0600140C RID: 5132 RVA: 0x000D3E74 File Offset: 0x000D2074
		public Frm_Bargasht_Checkd()
		{
			base.KeyDown += new KeyEventHandler(this.Frm_Vusul_Check_KeyDown);
			base.Load += new EventHandler(this.Frm_Vusul_Check_Load);
			Frm_Bargasht_Checkd.__ENCAddToList(this);
			this.dp = new DaryaftPardakht();
			this.InitializeComponent();
		}

		// Token: 0x0600140D RID: 5133 RVA: 0x000D3ECC File Offset: 0x000D20CC
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_Bargasht_Checkd.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_Bargasht_Checkd.__ENCList.Count == Frm_Bargasht_Checkd.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_Bargasht_Checkd.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_Bargasht_Checkd.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_Bargasht_Checkd.__ENCList[num] = Frm_Bargasht_Checkd.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_Bargasht_Checkd.__ENCList.RemoveRange(num, Frm_Bargasht_Checkd.__ENCList.Count - num);
						Frm_Bargasht_Checkd.__ENCList.Capacity = Frm_Bargasht_Checkd.__ENCList.Count;
					}
					Frm_Bargasht_Checkd.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000640 RID: 1600
		// (get) Token: 0x06001410 RID: 5136 RVA: 0x000D4490 File Offset: 0x000D2690
		// (set) Token: 0x06001411 RID: 5137 RVA: 0x000067EA File Offset: 0x000049EA
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

		// Token: 0x17000641 RID: 1601
		// (get) Token: 0x06001412 RID: 5138 RVA: 0x000D44A8 File Offset: 0x000D26A8
		// (set) Token: 0x06001413 RID: 5139 RVA: 0x000067F4 File Offset: 0x000049F4
		internal virtual DateBox2 txt_tarikh
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_tarikh;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_tarikh = value;
			}
		}

		// Token: 0x17000642 RID: 1602
		// (get) Token: 0x06001414 RID: 5140 RVA: 0x000D44C0 File Offset: 0x000D26C0
		// (set) Token: 0x06001415 RID: 5141 RVA: 0x000067FE File Offset: 0x000049FE
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

		// Token: 0x17000643 RID: 1603
		// (get) Token: 0x06001416 RID: 5142 RVA: 0x000D44D8 File Offset: 0x000D26D8
		// (set) Token: 0x06001417 RID: 5143 RVA: 0x000D44F0 File Offset: 0x000D26F0
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

		// Token: 0x17000644 RID: 1604
		// (get) Token: 0x06001418 RID: 5144 RVA: 0x000D4550 File Offset: 0x000D2750
		// (set) Token: 0x06001419 RID: 5145 RVA: 0x00006808 File Offset: 0x00004A08
		public DataRowView Row
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Row;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Row = value;
			}
		}

		// Token: 0x17000645 RID: 1605
		// (get) Token: 0x0600141A RID: 5146 RVA: 0x000D4568 File Offset: 0x000D2768
		// (set) Token: 0x0600141B RID: 5147 RVA: 0x00006812 File Offset: 0x00004A12
		public long Id
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Id;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Id = value;
			}
		}

		// Token: 0x0600141C RID: 5148 RVA: 0x000D4580 File Offset: 0x000D2780
		private long AddBargasht()
		{
			Sanad sanad = new Sanad();
			string text = "declare @parent_id bigint,@moshtari_hesabid bigint,@althesab_id bigint,@sanadbed_id bigint,@sanadbes_id bigint;";
			string tozih = string.Empty;
			text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Insert Into dbo.DaryaftPardakht(dpType_ID,Tarikh,sanadbed_id,sanadbes_id,BankHesab_ID,Mablagh,Tozih,Tarikh_Fa) VALUES(21," + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text)) + ",NULL,NULL,NULL,", this.Row["Mablagh"]), ","), Public_Function.GetValue(this.Row["Tozih"].ToString())), ","), Public_Function.GetValue(this.txt_tarikh.Text)), ");select @parent_id=scope_identity();")));
			DataRow dataRow = Public_Function.FillDataRow(Conversions.ToString(Operators.ConcatenateObject("select * from daryaftpardakht where dptype_id=18 and pardakhtcheck_id=", this.Row["ID"])));
			bool flag = true;
			text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("select @moshtari_hesabid=Codehesab_id from moshtari where id=", this.Row["Moshtari_ID"]), ";")));
			bool flag2 = dataRow == null;
			if (flag2)
			{
				flag = false;
				text += "select @althesab_id=1";
			}
			else
			{
				text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("select @althesab_id=Codehesab_Vusul from bank_hesab where id=", dataRow["BankHesab_ID"]), ";")));
			}
			tozih = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("برگشت چک شماره  ", dataRow["Sh_Check"]), " "), this.Row["bank_name"]), " "), dataRow["Check_Shobe"]), " به سررسید  "), this.Row["Check_Sarresid_Fa"]));
			text += sanad.InsertStr("@moshtari_hesabid", Conversions.ToString(dataRow["Mablagh"]), Conversions.ToString(0), this.txt_tarikh.Text, tozih, Sanad.SanadType.@null);
			text += "select @sanadbed_id=scope_identity();";
			flag2 = flag;
			if (flag2)
			{
				text += sanad.InsertStr("@althesab_id", Conversions.ToString(0), Conversions.ToString(dataRow["Mablagh"]), this.txt_tarikh.Text, tozih, Sanad.SanadType.@null);
				text += "select @sanadbes_id=scope_identity();";
			}
			else
			{
				text += "select @sanadbes_id=null;";
			}
			text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" Insert Into dbo.DaryaftPardakht(dpType_ID,Tarikh,SanadBed_ID,SanadBes_ID,Moshtari_ID,BankHesab_ID,Mablagh,Tozih,Tarikh_Fa,Sh_Check,CheckBank_ID,Check_Shobe,Check_Sarresid,Check_Sarresid_Fa,Check_ShomareHesab,Check_Status,PardakhtCheck_ID,checkbarg_id,Parent_ID) VALUES(22," + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text)) + ",@sanadbed_id,@sanadbes_id ," + Public_Function.GetValueInt(Conversions.ToString(this.Row["Moshtari_ID"])) + "," + Public_Function.GetValueInt(dataRow["BankHesab_ID"].ToString()) + ",", dataRow["Mablagh"]), ","), Public_Function.GetValue(this.Row["Tozih"].ToString())), ","), Public_Function.GetValue(this.txt_tarikh.Text)), ","), Public_Function.GetValue(dataRow["Sh_Check"].ToString())), ","), Public_Function.GetValueInt(dataRow["CheckBank_ID"].ToString())), ","), Public_Function.GetValue(dataRow["Check_Shobe"].ToString())), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Conversions.ToString(dataRow["Check_Sarresid_Fa"])))), ","), Public_Function.GetValue(Conversions.ToString(dataRow["Check_Sarresid_Fa"]))), ","), Public_Function.GetValue(dataRow["Check_ShomareHesab"].ToString())), ",4,"), dataRow["PardakhtCheck_ID"]), ","), Public_Function.GetValueInt(dataRow["checkbarg_id"].ToString())), ",@parent_id);")));
			text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(" update dbo.DaryaftPardakht set check_status=4 where id=", dataRow["PardakhtCheck_ID"]), ";")));
			text += " select @parent_id;";
			return Conversions.ToLong(Public_Function.ExecuteScalar(text));
		}

		// Token: 0x0600141D RID: 5149 RVA: 0x000D4A50 File Offset: 0x000D2C50
		private long AddVusulSandugh()
		{
			Sanad sanad = new Sanad();
			string text = "declare @parent_id bigint,@moshtari_hesabid bigint,@althesab_id bigint,@sanadbed_id bigint,@sanadbes_id bigint;";
			string empty = string.Empty;
			text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Insert Into dbo.DaryaftPardakht(dpType_ID,Tarikh,sanadbed_id,sanadbes_id,Sandug_ID,Mablagh,Tozih,Tarikh_Fa) VALUES(25," + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text)) + ",NULL,NULL,1,", this.Row["Mablagh"]), ","), Public_Function.GetValue(this.Row["Tozih"].ToString())), ","), Public_Function.GetValue(this.txt_tarikh.Text)), ");select @parent_id=scope_identity();")));
			text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" Insert Into dbo.DaryaftPardakht(dpType_ID,Tarikh,SanadBed_ID,SanadBes_ID,Sandug_ID,Mablagh,Tozih,Tarikh_Fa,Sh_Check,CheckBank_ID,Check_Shobe,Check_Sarresid,Check_Sarresid_Fa,Check_ShomareHesab,Check_Status,PardakhtCheck_ID,Parent_ID) VALUES(26," + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text)) + ",NULL,NULL ,1,", this.Row["Mablagh"]), ","), Public_Function.GetValue(this.Row["Tozih"].ToString())), ","), Public_Function.GetValue(this.txt_tarikh.Text)), ","), Public_Function.GetValue(this.Row["Sh_Check"].ToString())), ","), Public_Function.GetValueInt(this.Row["CheckBank_ID"].ToString())), ","), Public_Function.GetValue(this.Row["Check_Shobe"].ToString())), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Conversions.ToString(this.Row["Check_Sarresid_Fa"])))), ","), Public_Function.GetValue(Conversions.ToString(this.Row["Check_Sarresid_Fa"]))), ","), Public_Function.GetValue(this.Row["Check_ShomareHesab"].ToString())), ",3,"), Public_Function.GetValueInt(Conversions.ToString(this.Row["ID"]))), ",@parent_id);")));
			text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(" update dbo.DaryaftPardakht set check_status=3 where id=", this.Row["ID"]), ";select @parent_id;")));
			return Conversions.ToLong(Public_Function.ExecuteScalar(text));
		}

		// Token: 0x0600141E RID: 5150 RVA: 0x000D4D10 File Offset: 0x000D2F10
		private void UiButton1_Click(object sender, EventArgs e)
		{
			bool flag = Operators.ConditionalCompareObjectGreater(this.Row["check_sarresid_fa"], this.txt_tarikh.Text, false);
			if (flag)
			{
				Public_Function.ShowMessage("امکان برگشت چک قبل از تاریخ سررسید وجود ندارد", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, null);
			}
			else
			{
				DataRow dataRow = Public_Function.FillDataRow(Conversions.ToString(Operators.ConcatenateObject("select * from daryaftpardakht where dptype_id=18 and pardakhtcheck_id=", this.Row["ID"])));
				flag = (dataRow == null);
				if (!flag)
				{
					flag = Operators.ConditionalCompareObjectGreater(dataRow["tarikh"], Public_Function.ShamsiToMiladi(this.txt_tarikh.Text), false);
					if (flag)
					{
						Public_Function.ShowMessage("امکان وصول چک قبل از تاریخ سررسید وجود ندارد", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, null);
						return;
					}
				}
				this.Id = this.AddBargasht();
				flag = (this.Id == -1L);
				if (!flag)
				{
					DataTable dataTable = this.dp.RefreshVusul(Conversions.ToString(this.Id));
					object[] array = new object[]
					{
						dataTable
					};
					this.DialogResult = DialogResult.OK;
					this.Close();
				}
			}
		}

		// Token: 0x0600141F RID: 5151 RVA: 0x0007B16C File Offset: 0x0007936C
		private void Frm_Vusul_Check_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Escape;
			if (flag)
			{
				this.DialogResult = DialogResult.Cancel;
				this.Close();
			}
		}

		// Token: 0x06001420 RID: 5152 RVA: 0x0000681C File Offset: 0x00004A1C
		private void Frm_Vusul_Check_Load(object sender, EventArgs e)
		{
			this.txt_tarikh.SetNew();
		}

		// Token: 0x040007C8 RID: 1992
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x040007CA RID: 1994
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x040007CB RID: 1995
		[AccessedThroughProperty("txt_tarikh")]
		private DateBox2 _txt_tarikh;

		// Token: 0x040007CC RID: 1996
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x040007CD RID: 1997
		[AccessedThroughProperty("UiButton1")]
		private UIButton _UiButton1;

		// Token: 0x040007CE RID: 1998
		[CompilerGenerated]
		private DataRowView _Row;

		// Token: 0x040007CF RID: 1999
		[CompilerGenerated]
		private long _Id;

		// Token: 0x040007D0 RID: 2000
		private DaryaftPardakht dp;
	}
}
