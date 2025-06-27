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
	// Token: 0x02000118 RID: 280
	[DesignerGenerated]
	public partial class Frm_Vusul_Checkd : Form
	{
		// Token: 0x06002954 RID: 10580 RVA: 0x001F4318 File Offset: 0x001F2518
		public Frm_Vusul_Checkd()
		{
			base.KeyDown += new KeyEventHandler(this.Frm_Vusul_Check_KeyDown);
			base.Load += new EventHandler(this.Frm_Vusul_Check_Load);
			Frm_Vusul_Checkd.__ENCAddToList(this);
			this.dp = new DaryaftPardakht();
			this.InitializeComponent();
		}

		// Token: 0x06002955 RID: 10581 RVA: 0x001F4370 File Offset: 0x001F2570
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_Vusul_Checkd.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_Vusul_Checkd.__ENCList.Count == Frm_Vusul_Checkd.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_Vusul_Checkd.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_Vusul_Checkd.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_Vusul_Checkd.__ENCList[num] = Frm_Vusul_Checkd.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_Vusul_Checkd.__ENCList.RemoveRange(num, Frm_Vusul_Checkd.__ENCList.Count - num);
						Frm_Vusul_Checkd.__ENCList.Capacity = Frm_Vusul_Checkd.__ENCList.Count;
					}
					Frm_Vusul_Checkd.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000C9D RID: 3229
		// (get) Token: 0x06002958 RID: 10584 RVA: 0x001F4934 File Offset: 0x001F2B34
		// (set) Token: 0x06002959 RID: 10585 RVA: 0x0000A316 File Offset: 0x00008516
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

		// Token: 0x17000C9E RID: 3230
		// (get) Token: 0x0600295A RID: 10586 RVA: 0x001F494C File Offset: 0x001F2B4C
		// (set) Token: 0x0600295B RID: 10587 RVA: 0x0000A320 File Offset: 0x00008520
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

		// Token: 0x17000C9F RID: 3231
		// (get) Token: 0x0600295C RID: 10588 RVA: 0x001F4964 File Offset: 0x001F2B64
		// (set) Token: 0x0600295D RID: 10589 RVA: 0x0000A32A File Offset: 0x0000852A
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

		// Token: 0x17000CA0 RID: 3232
		// (get) Token: 0x0600295E RID: 10590 RVA: 0x001F497C File Offset: 0x001F2B7C
		// (set) Token: 0x0600295F RID: 10591 RVA: 0x001F4994 File Offset: 0x001F2B94
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

		// Token: 0x17000CA1 RID: 3233
		// (get) Token: 0x06002960 RID: 10592 RVA: 0x001F49F4 File Offset: 0x001F2BF4
		// (set) Token: 0x06002961 RID: 10593 RVA: 0x0000A334 File Offset: 0x00008534
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

		// Token: 0x17000CA2 RID: 3234
		// (get) Token: 0x06002962 RID: 10594 RVA: 0x001F4A0C File Offset: 0x001F2C0C
		// (set) Token: 0x06002963 RID: 10595 RVA: 0x0000A33E File Offset: 0x0000853E
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

		// Token: 0x06002964 RID: 10596 RVA: 0x001F4A24 File Offset: 0x001F2C24
		private long AddVusul()
		{
			Sanad sanad = new Sanad();
			string text = "declare @parent_id bigint,@moshtari_hesabid bigint,@althesab_id bigint,@sanadbed_id bigint,@sanadbes_id bigint;";
			string tozih = string.Empty;
			text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Insert Into dbo.DaryaftPardakht(dpType_ID,Tarikh,sanadbed_id,sanadbes_id,Mablagh,Tarikh_Fa) VALUES(19," + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text)) + ",NULL,NULL,", this.Row["Mablagh"]), ","), Public_Function.GetValue(this.txt_tarikh.Text)), ");select @parent_id=scope_identity();")));
			DataRow dataRow = Public_Function.FillDataRow(Conversions.ToString(Operators.ConcatenateObject("select * from daryaftpardakht where dptype_id=18 and pardakhtcheck_id=", this.Row["ID"])));
			string right = Conversions.ToString(NewLateBinding.LateGet(null, typeof(Public_Function), "ExecuteScalar", new object[]
			{
				Operators.ConcatenateObject("SELECT     Moshtari.Name + ' ' + Moshtari.Family AS Moshtari_Name  FROM         DaryaftPardakht INNER JOIN   Moshtari ON DaryaftPardakht.Moshtari_ID = Moshtari.ID   WHERE     DaryaftPardakht.ID = ", this.Row["id"])
			}, null, null, null));
			tozih = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("وصول چک دریافتی از  ", this.Row["Bank_Name"]), " به شماره "), this.Row["Sh_Check"]), " از "), right));
			text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("select @althesab_id=Codehesab_Vusul from bank_hesab where id=", dataRow["bankhesab_id"]), ";")));
			text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("select @moshtari_hesabid=codehesab_mojodi from bank_hesab where id=", dataRow["bankhesab_id"]), ";")));
			text += sanad.InsertStr("@moshtari_hesabid", Conversions.ToString(this.Row["Mablagh"]), Conversions.ToString(0), this.txt_tarikh.Text, tozih, Sanad.SanadType.@null);
			text += "select @sanadbed_id=scope_identity();";
			text += sanad.InsertStr("@althesab_id", Conversions.ToString(0), Conversions.ToString(this.Row["Mablagh"]), this.txt_tarikh.Text, tozih, Sanad.SanadType.@null);
			text += "select @sanadbes_id=scope_identity();";
			text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" Insert Into dbo.DaryaftPardakht(dpType_ID,Tarikh,SanadBed_ID,SanadBes_ID,BankHesab_ID,Mablagh,Tozih,Tarikh_Fa,Sh_Check,CheckBank_ID,Check_Shobe,Check_Sarresid,Check_Sarresid_Fa,Check_ShomareHesab,Check_Status,PardakhtCheck_ID,Parent_ID) VALUES(20," + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text)) + ",@sanadbed_id,@sanadbes_id ," + Public_Function.GetValueInt(Conversions.ToString(dataRow["bankhesab_id"])) + ",", this.Row["Mablagh"]), ","), Public_Function.GetValue(this.Row["Tozih"].ToString())), ","), Public_Function.GetValue(this.txt_tarikh.Text)), ","), Public_Function.GetValue(this.Row["Sh_Check"].ToString())), ","), Public_Function.GetValueInt(this.Row["CheckBank_ID"].ToString())), ","), Public_Function.GetValue(this.Row["Check_Shobe"].ToString())), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Conversions.ToString(this.Row["Check_Sarresid_Fa"])))), ","), Public_Function.GetValue(Conversions.ToString(this.Row["Check_Sarresid_Fa"]))), ","), Public_Function.GetValue(this.Row["Check_ShomareHesab"].ToString())), ",3,"), dataRow["PardakhtCheck_ID"]), ",@parent_id);")));
			text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(" update dbo.DaryaftPardakht set check_status=3 where id=", dataRow["PardakhtCheck_ID"]), ";select @parent_id;")));
			return Conversions.ToLong(Public_Function.ExecuteScalar(text));
		}

		// Token: 0x06002965 RID: 10597 RVA: 0x001F4E80 File Offset: 0x001F3080
		private long AddVusulSandugh()
		{
			Sanad sanad = new Sanad();
			string text = "declare @parent_id bigint,@moshtari_hesabid bigint,@althesab_id bigint,@sanadbed_id bigint,@sanadbes_id bigint;";
			string empty = string.Empty;
			text += sanad.InsertStr("1", Conversions.ToString(this.Row["Mablagh"]), Conversions.ToString(0), this.txt_tarikh.Text, empty, Sanad.SanadType.@null);
			text += "select @sanadbed_id=scope_identity();";
			text += sanad.InsertStr("33", Conversions.ToString(0), Conversions.ToString(this.Row["Mablagh"]), this.txt_tarikh.Text, empty, Sanad.SanadType.@null);
			text += "select @sanadbes_id=scope_identity();";
			text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Insert Into dbo.DaryaftPardakht(dpType_ID,Tarikh,sanadbed_id,sanadbes_id,Sandug_ID,Mablagh,Tozih,Tarikh_Fa) VALUES(25," + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text)) + ",NULL,NULL,1,", this.Row["Mablagh"]), ","), Public_Function.GetValue(this.Row["Tozih"].ToString())), ","), Public_Function.GetValue(this.txt_tarikh.Text)), ");select @parent_id=scope_identity();")));
			text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" Insert Into dbo.DaryaftPardakht(dpType_ID,Tarikh,sanadbed_id,SanadBes_ID,Sandug_ID,Mablagh,Tozih,Tarikh_Fa,Sh_Check,CheckBank_ID,Check_Shobe,Check_Sarresid,Check_Sarresid_Fa,Check_ShomareHesab,Check_Status,PardakhtCheck_ID,Parent_ID) VALUES(26," + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text)) + ",@sanadbed_id,@sanadbes_id ,1,", this.Row["Mablagh"]), ","), Public_Function.GetValue(this.Row["Tozih"].ToString())), ","), Public_Function.GetValue(this.txt_tarikh.Text)), ","), Public_Function.GetValue(this.Row["Sh_Check"].ToString())), ","), Public_Function.GetValueInt(this.Row["CheckBank_ID"].ToString())), ","), Public_Function.GetValue(this.Row["Check_Shobe"].ToString())), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Conversions.ToString(this.Row["Check_Sarresid_Fa"])))), ","), Public_Function.GetValue(Conversions.ToString(this.Row["Check_Sarresid_Fa"]))), ","), Public_Function.GetValue(this.Row["Check_ShomareHesab"].ToString())), ",3,"), Public_Function.GetValueInt(Conversions.ToString(this.Row["ID"]))), ",@parent_id);")));
			text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(" update dbo.DaryaftPardakht set check_status=3 where id=", this.Row["ID"]), ";select @parent_id;")));
			return Conversions.ToLong(Public_Function.ExecuteScalar(text));
		}

		// Token: 0x06002966 RID: 10598 RVA: 0x001F51CC File Offset: 0x001F33CC
		private void UiButton1_Click(object sender, EventArgs e)
		{
			bool flag = Operators.ConditionalCompareObjectGreater(this.Row["check_sarresid_fa"], this.txt_tarikh.Text, false);
			if (flag)
			{
				Public_Function.ShowMessage("امکان وصول چک قبل از تاریخ سررسید وجود ندارد", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, null);
			}
			else
			{
				DataRow dataRow = Public_Function.FillDataRow(Conversions.ToString(Operators.ConcatenateObject("select * from daryaftpardakht where dptype_id=18 and pardakhtcheck_id=", this.Row["ID"])));
				flag = (dataRow == null);
				if (flag)
				{
					bool flag2 = Operators.ConditionalCompareObjectEqual(this.Row["check_status"], 1, false);
					if (flag2)
					{
						this.Id = this.AddVusulSandugh();
						DataTable dataTable = this.dp.RefreshVusul(Conversions.ToString(this.Id));
						object[] parameters = new object[]
						{
							dataTable
						};
						Public_Function.InvokeMethod("frm_daryaftpardakht", "RefreshVusulDaryaft", parameters);
						this.DialogResult = DialogResult.OK;
						this.Close();
					}
				}
				else
				{
					bool flag2 = Operators.ConditionalCompareObjectGreater(dataRow["tarikh"], Public_Function.ShamsiToMiladi(this.txt_tarikh.Text), false);
					if (flag2)
					{
						Public_Function.ShowMessage("امکان وصول چک قبل از تاریخ سررسید وجود ندارد", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, null);
					}
					else
					{
						this.Id = this.AddVusul();
						flag2 = (this.Id == -1L);
						if (!flag2)
						{
							DataTable dataTable2 = this.dp.RefreshVusul(Conversions.ToString(this.Id));
							object[] parameters2 = new object[]
							{
								dataTable2
							};
							Public_Function.InvokeMethod("frm_daryaftpardakht", "RefreshVusul", parameters2);
							this.DialogResult = DialogResult.OK;
							this.Close();
						}
					}
				}
			}
		}

		// Token: 0x06002967 RID: 10599 RVA: 0x0007B16C File Offset: 0x0007936C
		private void Frm_Vusul_Check_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Escape;
			if (flag)
			{
				this.DialogResult = DialogResult.Cancel;
				this.Close();
			}
		}

		// Token: 0x06002968 RID: 10600 RVA: 0x0000A348 File Offset: 0x00008548
		private void Frm_Vusul_Check_Load(object sender, EventArgs e)
		{
			this.txt_tarikh.Text = Conversions.ToString(this.Row["check_sarresid_fa"]);
		}

		// Token: 0x04001021 RID: 4129
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04001023 RID: 4131
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x04001024 RID: 4132
		[AccessedThroughProperty("txt_tarikh")]
		private DateBox2 _txt_tarikh;

		// Token: 0x04001025 RID: 4133
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04001026 RID: 4134
		[AccessedThroughProperty("UiButton1")]
		private UIButton _UiButton1;

		// Token: 0x04001027 RID: 4135
		[CompilerGenerated]
		private DataRowView _Row;

		// Token: 0x04001028 RID: 4136
		[CompilerGenerated]
		private long _Id;

		// Token: 0x04001029 RID: 4137
		private DaryaftPardakht dp;
	}
}
