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
	// Token: 0x02000117 RID: 279
	[DesignerGenerated]
	public partial class Frm_Vusul_Check : Form
	{
		// Token: 0x0600293F RID: 10559 RVA: 0x001F37B4 File Offset: 0x001F19B4
		public Frm_Vusul_Check()
		{
			base.KeyDown += new KeyEventHandler(this.Frm_Vusul_Check_KeyDown);
			base.Load += new EventHandler(this.Frm_Vusul_Check_Load);
			Frm_Vusul_Check.__ENCAddToList(this);
			this.dp = new DaryaftPardakht();
			this.InitializeComponent();
		}

		// Token: 0x06002940 RID: 10560 RVA: 0x001F380C File Offset: 0x001F1A0C
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_Vusul_Check.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_Vusul_Check.__ENCList.Count == Frm_Vusul_Check.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_Vusul_Check.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_Vusul_Check.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_Vusul_Check.__ENCList[num] = Frm_Vusul_Check.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_Vusul_Check.__ENCList.RemoveRange(num, Frm_Vusul_Check.__ENCList.Count - num);
						Frm_Vusul_Check.__ENCList.Capacity = Frm_Vusul_Check.__ENCList.Count;
					}
					Frm_Vusul_Check.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000C97 RID: 3223
		// (get) Token: 0x06002943 RID: 10563 RVA: 0x001F3DD0 File Offset: 0x001F1FD0
		// (set) Token: 0x06002944 RID: 10564 RVA: 0x0000A2C7 File Offset: 0x000084C7
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

		// Token: 0x17000C98 RID: 3224
		// (get) Token: 0x06002945 RID: 10565 RVA: 0x001F3DE8 File Offset: 0x001F1FE8
		// (set) Token: 0x06002946 RID: 10566 RVA: 0x0000A2D1 File Offset: 0x000084D1
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

		// Token: 0x17000C99 RID: 3225
		// (get) Token: 0x06002947 RID: 10567 RVA: 0x001F3E00 File Offset: 0x001F2000
		// (set) Token: 0x06002948 RID: 10568 RVA: 0x0000A2DB File Offset: 0x000084DB
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

		// Token: 0x17000C9A RID: 3226
		// (get) Token: 0x06002949 RID: 10569 RVA: 0x001F3E18 File Offset: 0x001F2018
		// (set) Token: 0x0600294A RID: 10570 RVA: 0x001F3E30 File Offset: 0x001F2030
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

		// Token: 0x17000C9B RID: 3227
		// (get) Token: 0x0600294B RID: 10571 RVA: 0x001F3E90 File Offset: 0x001F2090
		// (set) Token: 0x0600294C RID: 10572 RVA: 0x0000A2E5 File Offset: 0x000084E5
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

		// Token: 0x17000C9C RID: 3228
		// (get) Token: 0x0600294D RID: 10573 RVA: 0x001F3EA8 File Offset: 0x001F20A8
		// (set) Token: 0x0600294E RID: 10574 RVA: 0x0000A2EF File Offset: 0x000084EF
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

		// Token: 0x0600294F RID: 10575 RVA: 0x001F3EC0 File Offset: 0x001F20C0
		private long AddVusul()
		{
			Sanad sanad = new Sanad();
			string text = "declare @parent_id bigint,@althesab_id bigint,@sanadbes_id bigint;";
			string tozih = string.Empty;
			text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Insert Into dbo.DaryaftPardakht(dpType_ID,Tarikh,sanadbed_id,sanadbes_id,Mablagh,Tarikh_Fa) VALUES(19," + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text)) + ",NULL,NULL,", this.Row["Mablagh"]), ","), Public_Function.GetValue(this.txt_tarikh.Text)), ");select @parent_id=scope_identity();")));
			string right = Conversions.ToString(NewLateBinding.LateGet(null, typeof(Public_Function), "ExecuteScalar", new object[]
			{
				Operators.ConcatenateObject("SELECT     Moshtari.Name + ' ' + Moshtari.Family AS Moshtari_Name  FROM         DaryaftPardakht INNER JOIN   Moshtari ON DaryaftPardakht.Moshtari_ID = Moshtari.ID   WHERE     DaryaftPardakht.ID = ", this.Row["id"])
			}, null, null, null));
			tozih = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("وصول چک پرداختی به شماره ", this.Row["Sh_Check"]), "به سررسید  "), this.Row["Check_Sarresid_Fa"]), " به "), right));
			text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("select @althesab_id=Codehesab_Mojodi from bank_hesab where id=", this.Row["CheckBank_ID"]), ";")));
			text += sanad.InsertStr("@althesab_id", Conversions.ToString(0), Conversions.ToString(this.Row["Mablagh"]), this.txt_tarikh.Text, tozih, Sanad.SanadType.@null);
			text += "select @sanadbes_id=scope_identity();";
			text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" Insert Into dbo.DaryaftPardakht(dpType_ID,Tarikh,SanadBed_ID,SanadBes_ID,BankHesab_ID,Mablagh,Tozih,Tarikh_Fa,Sh_Check,Check_Shobe,Check_Sarresid,Check_Sarresid_Fa,Check_ShomareHesab,Check_Status,PardakhtCheck_ID,CheckBarg_ID,Parent_ID) VALUES(20," + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text)) + ",NULL,@sanadbes_id ," + Public_Function.GetValueInt(this.Row["CheckBank_ID"].ToString()) + ",", this.Row["Mablagh"]), ","), Public_Function.GetValue(this.Row["Tozih"].ToString())), ","), Public_Function.GetValue(this.txt_tarikh.Text)), ","), Public_Function.GetValue(this.Row["Sh_Check"].ToString())), ","), Public_Function.GetValue(this.Row["Check_Shobe"].ToString())), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Conversions.ToString(this.Row["Check_Sarresid_Fa"])))), ","), Public_Function.GetValue(Conversions.ToString(this.Row["Check_Sarresid_Fa"]))), ","), Public_Function.GetValue(this.Row["Check_ShomareHesab"].ToString())), ",3,"), this.Row["ID"]), ","), this.Row["checkbarg_ID"]), ",@parent_id);")));
			text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(" update dbo.DaryaftPardakht set check_status=3 where id=", this.Row["ID"]), ";select @parent_id;")));
			return Conversions.ToLong(Public_Function.ExecuteScalar(text));
		}

		// Token: 0x06002950 RID: 10576 RVA: 0x001F427C File Offset: 0x001F247C
		private void UiButton1_Click(object sender, EventArgs e)
		{
			bool flag = Operators.ConditionalCompareObjectLess(this.txt_tarikh.Text, this.Row["check_sarresid_fa"], false);
			if (flag)
			{
				Public_Function.ShowMessage("امکان وصول چک قبل از تاریخ سررسید وجود ندارد", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, null);
			}
			else
			{
				this.Id = this.AddVusul();
				DataTable dataTable = this.dp.RefreshVusul(Conversions.ToString(this.Id));
				object[] parameters = new object[]
				{
					dataTable
				};
				Public_Function.InvokeMethod("frm_daryaftpardakht", "RefreshVusul", parameters);
				this.DialogResult = DialogResult.OK;
				this.Close();
			}
		}

		// Token: 0x06002951 RID: 10577 RVA: 0x0007B16C File Offset: 0x0007936C
		private void Frm_Vusul_Check_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Escape;
			if (flag)
			{
				this.DialogResult = DialogResult.Cancel;
				this.Close();
			}
		}

		// Token: 0x06002952 RID: 10578 RVA: 0x0000A2F9 File Offset: 0x000084F9
		private void Frm_Vusul_Check_Load(object sender, EventArgs e)
		{
			this.txt_tarikh.SetNew();
		}

		// Token: 0x04001018 RID: 4120
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x0400101A RID: 4122
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x0400101B RID: 4123
		[AccessedThroughProperty("txt_tarikh")]
		private DateBox2 _txt_tarikh;

		// Token: 0x0400101C RID: 4124
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x0400101D RID: 4125
		[AccessedThroughProperty("UiButton1")]
		private UIButton _UiButton1;

		// Token: 0x0400101E RID: 4126
		[CompilerGenerated]
		private DataRowView _Row;

		// Token: 0x0400101F RID: 4127
		[CompilerGenerated]
		private long _Id;

		// Token: 0x04001020 RID: 4128
		private DaryaftPardakht dp;
	}
}
