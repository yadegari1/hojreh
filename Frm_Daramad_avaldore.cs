using System;
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
using Janus.Windows.GridEX.EditControls;
using Janus.Windows.UI;
using Janus.Windows.UI.Dock;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x020000C7 RID: 199
	[DesignerGenerated]
	public partial class Frm_Daramad_avaldore : Form
	{
		// Token: 0x06001063 RID: 4195 RVA: 0x000B494C File Offset: 0x000B2B4C
		public Frm_Daramad_avaldore()
		{
			base.Load += new EventHandler(this.Frm_Anbar_Load);
			base.KeyDown += new KeyEventHandler(this.Frm_Anbar_KeyDown);
			Frm_Daramad_avaldore.__ENCAddToList(this);
			this.Bank = new Bank();
			this.isnew_daramad = false;
			this.isnew_hazine = false;
			this.isnew_sandugh = false;
			this.isnew_takhlie = false;
			this.isnew_kasri = false;
			this.isnew_ezafi = false;
			this.InitializeComponent();
		}

		// Token: 0x06001064 RID: 4196 RVA: 0x000B49CC File Offset: 0x000B2BCC
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_Daramad_avaldore.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_Daramad_avaldore.__ENCList.Count == Frm_Daramad_avaldore.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_Daramad_avaldore.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_Daramad_avaldore.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_Daramad_avaldore.__ENCList[num] = Frm_Daramad_avaldore.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_Daramad_avaldore.__ENCList.RemoveRange(num, Frm_Daramad_avaldore.__ENCList.Count - num);
						Frm_Daramad_avaldore.__ENCList.Capacity = Frm_Daramad_avaldore.__ENCList.Count;
					}
					Frm_Daramad_avaldore.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000515 RID: 1301
		// (get) Token: 0x06001067 RID: 4199 RVA: 0x000B5C2C File Offset: 0x000B3E2C
		// (set) Token: 0x06001068 RID: 4200 RVA: 0x000058B4 File Offset: 0x00003AB4
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

		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x06001069 RID: 4201 RVA: 0x000B5C44 File Offset: 0x000B3E44
		// (set) Token: 0x0600106A RID: 4202 RVA: 0x000058BE File Offset: 0x00003ABE
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

		// Token: 0x17000517 RID: 1303
		// (get) Token: 0x0600106B RID: 4203 RVA: 0x000B5C5C File Offset: 0x000B3E5C
		// (set) Token: 0x0600106C RID: 4204 RVA: 0x000058C8 File Offset: 0x00003AC8
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

		// Token: 0x17000518 RID: 1304
		// (get) Token: 0x0600106D RID: 4205 RVA: 0x000B5C74 File Offset: 0x000B3E74
		// (set) Token: 0x0600106E RID: 4206 RVA: 0x000B5C8C File Offset: 0x000B3E8C
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

		// Token: 0x17000519 RID: 1305
		// (get) Token: 0x0600106F RID: 4207 RVA: 0x000B5CEC File Offset: 0x000B3EEC
		// (set) Token: 0x06001070 RID: 4208 RVA: 0x000B5D04 File Offset: 0x000B3F04
		internal virtual CurrencyBox txt_hazine
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_hazine;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txt_hazine_ButtonClick);
				bool flag = this._txt_hazine != null;
				if (flag)
				{
					this._txt_hazine.ButtonClick -= value2;
				}
				this._txt_hazine = value;
				flag = (this._txt_hazine != null);
				if (flag)
				{
					this._txt_hazine.ButtonClick += value2;
				}
			}
		}

		// Token: 0x1700051A RID: 1306
		// (get) Token: 0x06001071 RID: 4209 RVA: 0x000B5D64 File Offset: 0x000B3F64
		// (set) Token: 0x06001072 RID: 4210 RVA: 0x000B5D7C File Offset: 0x000B3F7C
		internal virtual CurrencyBox txt_daramad
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_daramad;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txt_daramad_ButtonClick);
				bool flag = this._txt_daramad != null;
				if (flag)
				{
					this._txt_daramad.ButtonClick -= value2;
				}
				this._txt_daramad = value;
				flag = (this._txt_daramad != null);
				if (flag)
				{
					this._txt_daramad.ButtonClick += value2;
				}
			}
		}

		// Token: 0x1700051B RID: 1307
		// (get) Token: 0x06001073 RID: 4211 RVA: 0x000B5DDC File Offset: 0x000B3FDC
		// (set) Token: 0x06001074 RID: 4212 RVA: 0x000058D2 File Offset: 0x00003AD2
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

		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x06001075 RID: 4213 RVA: 0x000B5DF4 File Offset: 0x000B3FF4
		// (set) Token: 0x06001076 RID: 4214 RVA: 0x000B5E0C File Offset: 0x000B400C
		internal virtual CurrencyBox txt_sandugh
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_sandugh;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txt_sandugh_ButtonClick);
				bool flag = this._txt_sandugh != null;
				if (flag)
				{
					this._txt_sandugh.ButtonClick -= value2;
				}
				this._txt_sandugh = value;
				flag = (this._txt_sandugh != null);
				if (flag)
				{
					this._txt_sandugh.ButtonClick += value2;
				}
			}
		}

		// Token: 0x1700051D RID: 1309
		// (get) Token: 0x06001077 RID: 4215 RVA: 0x000B5E6C File Offset: 0x000B406C
		// (set) Token: 0x06001078 RID: 4216 RVA: 0x000058DC File Offset: 0x00003ADC
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

		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x06001079 RID: 4217 RVA: 0x000B5E84 File Offset: 0x000B4084
		// (set) Token: 0x0600107A RID: 4218 RVA: 0x000B5E9C File Offset: 0x000B409C
		internal virtual CurrencyBox txt_takhlie
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_takhlie;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txt_takhlie_ButtonClick);
				bool flag = this._txt_takhlie != null;
				if (flag)
				{
					this._txt_takhlie.ButtonClick -= value2;
				}
				this._txt_takhlie = value;
				flag = (this._txt_takhlie != null);
				if (flag)
				{
					this._txt_takhlie.ButtonClick += value2;
				}
			}
		}

		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x0600107B RID: 4219 RVA: 0x000B5EFC File Offset: 0x000B40FC
		// (set) Token: 0x0600107C RID: 4220 RVA: 0x000058E6 File Offset: 0x00003AE6
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

		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x0600107D RID: 4221 RVA: 0x000B5F14 File Offset: 0x000B4114
		// (set) Token: 0x0600107E RID: 4222 RVA: 0x000B5F2C File Offset: 0x000B412C
		internal virtual CurrencyBox txt_ezafi
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_ezafi;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txt_ezafi_ButtonClick);
				bool flag = this._txt_ezafi != null;
				if (flag)
				{
					this._txt_ezafi.ButtonClick -= value2;
				}
				this._txt_ezafi = value;
				flag = (this._txt_ezafi != null);
				if (flag)
				{
					this._txt_ezafi.ButtonClick += value2;
				}
			}
		}

		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x0600107F RID: 4223 RVA: 0x000B5F8C File Offset: 0x000B418C
		// (set) Token: 0x06001080 RID: 4224 RVA: 0x000B5FA4 File Offset: 0x000B41A4
		internal virtual CurrencyBox txt_kasri
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_kasri;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txt_kasri_ButtonClick);
				bool flag = this._txt_kasri != null;
				if (flag)
				{
					this._txt_kasri.ButtonClick -= value2;
				}
				this._txt_kasri = value;
				flag = (this._txt_kasri != null);
				if (flag)
				{
					this._txt_kasri.ButtonClick += value2;
				}
			}
		}

		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x06001081 RID: 4225 RVA: 0x000B6004 File Offset: 0x000B4204
		// (set) Token: 0x06001082 RID: 4226 RVA: 0x000058F0 File Offset: 0x00003AF0
		internal virtual Label Label6
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label6;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label6 = value;
			}
		}

		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x06001083 RID: 4227 RVA: 0x000B601C File Offset: 0x000B421C
		// (set) Token: 0x06001084 RID: 4228 RVA: 0x000058FA File Offset: 0x00003AFA
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

		// Token: 0x06001085 RID: 4229 RVA: 0x000B6034 File Offset: 0x000B4234
		private void GetData()
		{
			this.dt = Public_Function.FillData("select * from sanad where codehesab_id=15 and tarikh=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi("1392/01/01")));
			this.dt2 = Public_Function.FillData("select * from sanad where codehesab_id=16 and tarikh=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi("1392/01/01")));
			this.dt3 = Public_Function.FillData("select * from sanad where codehesab_id=1 and tarikh=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi("1392/01/01")));
			this.dt4 = Public_Function.FillData("select * from sanad where codehesab_id=18 and tarikh=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi("1392/01/01")));
			DataRow dataRow = Public_Function.FillDataRow("select * from daryaftpardakht where dptype_id=16 and tarikh=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi("1392/01/01")));
			DataRow dataRow2 = Public_Function.FillDataRow("select * from daryaftpardakht where dptype_id=5 and tarikh=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi("1392/01/01")));
			bool flag = this.dt.Rows.Count == 0;
			if (flag)
			{
				this.isnew_daramad = true;
				this.txt_daramad.ButtonStyle = EditButtonStyle.NoButton;
			}
			else
			{
				this.isnew_daramad = false;
				this.txt_daramad.Text = Conversions.ToString(this.dt.Rows[0]["bes"]);
				this.txt_daramad.ButtonStyle = EditButtonStyle.Image;
			}
			flag = (this.dt2.Rows.Count == 0);
			if (flag)
			{
				this.isnew_hazine = true;
				this.txt_hazine.ButtonStyle = EditButtonStyle.NoButton;
			}
			else
			{
				this.isnew_hazine = false;
				this.txt_hazine.Text = Conversions.ToString(this.dt2.Rows[0]["bed"]);
				this.txt_hazine.ButtonStyle = EditButtonStyle.Image;
			}
			flag = (this.dt3.Rows.Count == 0);
			if (flag)
			{
				this.isnew_sandugh = true;
				this.txt_sandugh.ButtonStyle = EditButtonStyle.NoButton;
			}
			else
			{
				this.isnew_sandugh = false;
				this.txt_sandugh.Text = Conversions.ToString(this.dt3.Rows[0]["bed"]);
				this.txt_sandugh.ButtonStyle = EditButtonStyle.Image;
			}
			flag = (this.dt4.Rows.Count == 0);
			if (flag)
			{
				this.isnew_takhlie = true;
				this.txt_takhlie.ButtonStyle = EditButtonStyle.NoButton;
			}
			else
			{
				this.isnew_takhlie = false;
				this.txt_takhlie.Text = Conversions.ToString(this.dt4.Rows[0]["bes"]);
				this.txt_takhlie.ButtonStyle = EditButtonStyle.Image;
			}
			flag = (dataRow != null);
			if (flag)
			{
				this.isnew_kasri = false;
				this.txt_kasri.ButtonStyle = EditButtonStyle.Image;
				this.txt_kasri.Text = Conversions.ToString(dataRow["mablagh"]);
			}
			else
			{
				this.isnew_kasri = true;
				this.txt_kasri.ButtonStyle = EditButtonStyle.NoButton;
			}
			flag = (dataRow2 != null);
			if (flag)
			{
				this.isnew_ezafi = false;
				this.txt_ezafi.ButtonStyle = EditButtonStyle.Image;
				this.txt_ezafi.Text = Conversions.ToString(dataRow2["mablagh"]);
			}
			else
			{
				this.isnew_ezafi = true;
				this.txt_ezafi.ButtonStyle = EditButtonStyle.NoButton;
			}
		}

		// Token: 0x06001086 RID: 4230 RVA: 0x000B6374 File Offset: 0x000B4574
		private void ButtonItem2_Click(object sender, EventArgs e)
		{
			Sanad sanad = new Sanad();
			bool hasValue = this.txt_daramad.Value.HasValue;
			bool hasValue2;
			if (hasValue)
			{
				hasValue2 = this.isnew_daramad;
				if (hasValue2)
				{
					sanad.Insert(Conversions.ToString(15), Conversions.ToString(0), Conversions.ToString((T)this.txt_daramad.Value), "1392/01/01", "درآمد اول دوره", Sanad.SanadType.@null);
					this.isnew_daramad = false;
				}
				else
				{
					sanad.Update(Conversions.ToString(15), Conversions.ToString(0), Conversions.ToString((T)this.txt_daramad.Value), "1392/01/01", "درآمد اول دوره", Conversions.ToString(this.dt.Rows[0]["ID"]), Sanad.SanadType.@null);
				}
			}
			hasValue2 = this.txt_hazine.Value.HasValue;
			if (hasValue2)
			{
				hasValue = this.isnew_hazine;
				if (hasValue)
				{
					sanad.Insert(Conversions.ToString(16), Conversions.ToString((T)this.txt_hazine.Value), Conversions.ToString(0), "1392/01/01", "هزینه اول دوره", Sanad.SanadType.@null);
					this.isnew_hazine = false;
				}
				else
				{
					sanad.Update(Conversions.ToString(16), Conversions.ToString((T)this.txt_hazine.Value), Conversions.ToString(0), "1392/01/01", "هزینه اول دوره", Conversions.ToString(this.dt2.Rows[0]["ID"]), Sanad.SanadType.@null);
				}
			}
			hasValue2 = this.txt_sandugh.Value.HasValue;
			if (hasValue2)
			{
				hasValue = this.isnew_sandugh;
				if (hasValue)
				{
					sanad.Insert(Conversions.ToString(1), Conversions.ToString((T)this.txt_sandugh.Value), Conversions.ToString(0), "1392/01/01", "صندوق اول دوره", Sanad.SanadType.@null);
					this.isnew_sandugh = false;
				}
				else
				{
					sanad.Update(Conversions.ToString(1), Conversions.ToString((T)this.txt_sandugh.Value), Conversions.ToString(0), "1392/01/01", "صندوق اول دوره", Conversions.ToString(this.dt3.Rows[0]["ID"]), Sanad.SanadType.@null);
				}
			}
			hasValue2 = this.txt_takhlie.Value.HasValue;
			if (hasValue2)
			{
				hasValue = this.isnew_takhlie;
				if (hasValue)
				{
					sanad.Insert(Conversions.ToString(18), Conversions.ToString(0), Conversions.ToString((T)this.txt_takhlie.Value), "1392/01/01", "اول دوره تخلیه", Sanad.SanadType.@null);
					this.isnew_sandugh = false;
				}
				else
				{
					sanad.Update(Conversions.ToString(18), Conversions.ToString(0), Conversions.ToString((T)this.txt_takhlie.Value), "1392/01/01", "اول دوره تخلیه", Conversions.ToString(this.dt4.Rows[0]["ID"]), Sanad.SanadType.@null);
				}
			}
			hasValue2 = this.txt_kasri.Value.HasValue;
			if (hasValue2)
			{
				hasValue = this.isnew_kasri;
				if (hasValue)
				{
					string[] array = new string[9];
					array[0] = "insert into daryaftpardakht(dptype_id,tarikh,tarikh_fa,mablagh,tozih) values(16,";
					array[1] = Public_Function.GetValue(Public_Function.ShamsiToMiladi("1392/01/01"));
					array[2] = ",";
					array[3] = Public_Function.GetValue("1392/01/01");
					array[4] = ",";
					string[] arg_38A_0 = array;
					int arg_38A_1 = 5;
					long? value = this.txt_kasri.Value;
					arg_38A_0[arg_38A_1] = (value.HasValue ? Conversions.ToString(value.GetValueOrDefault()) : null);
					array[6] = ",";
					array[7] = Public_Function.GetValue("اول دوره کسری صندوق");
					array[8] = ")";
					Public_Function.ExecuteNonQuery(string.Concat(array));
				}
				else
				{
					string arg_3F8_0 = "update daryaftpardakht set mablagh=";
					long? value = this.txt_kasri.Value;
					Public_Function.ExecuteNonQuery(arg_3F8_0 + (value.HasValue ? Conversions.ToString(value.GetValueOrDefault()) : null) + " where dptype_id=16 and tarikh=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi("1392/01/01")));
				}
			}
			hasValue2 = this.txt_ezafi.Value.HasValue;
			if (hasValue2)
			{
				hasValue = this.isnew_ezafi;
				if (hasValue)
				{
					string[] array = new string[9];
					array[0] = "insert into daryaftpardakht(dptype_id,tarikh,tarikh_fa,mablagh,tozih) values(5,";
					array[1] = Public_Function.GetValue(Public_Function.ShamsiToMiladi("1392/01/01"));
					array[2] = ",";
					array[3] = Public_Function.GetValue("1392/01/01");
					array[4] = ",";
					string[] arg_49A_0 = array;
					int arg_49A_1 = 5;
					long? value2 = this.txt_ezafi.Value;
					arg_49A_0[arg_49A_1] = (value2.HasValue ? Conversions.ToString(value2.GetValueOrDefault()) : null);
					array[6] = ",";
					array[7] = Public_Function.GetValue("اول دوره اضافی صندوق");
					array[8] = ")";
					Public_Function.ExecuteNonQuery(string.Concat(array));
				}
				else
				{
					string arg_508_0 = "update daryaftpardakht set mablagh=";
					long? value = this.txt_ezafi.Value;
					Public_Function.ExecuteNonQuery(arg_508_0 + (value.HasValue ? Conversions.ToString(value.GetValueOrDefault()) : null) + " where dptype_id=5 and tarikh=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi("1392/01/01")));
				}
			}
			Public_Function.ShowMessage("اطلاعات مورد نظر ثبت گردید", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, null);
			this.GetData();
		}

		// Token: 0x06001087 RID: 4231 RVA: 0x000B68B0 File Offset: 0x000B4AB0
		private void Frm_Anbar_KeyDown(object sender, KeyEventArgs e)
		{
			Keys keyCode = e.KeyCode;
			bool flag = keyCode == Keys.F2;
			if (flag)
			{
				bool flag2 = this.ButtonItem2.Visible;
				if (flag2)
				{
					this.ButtonItem2_Click(null, null);
				}
			}
			else
			{
				bool flag2 = keyCode == Keys.Escape;
				if (flag2)
				{
					this.Close();
				}
			}
		}

		// Token: 0x06001088 RID: 4232 RVA: 0x000B6900 File Offset: 0x000B4B00
		private void Frm_Anbar_Load(object sender, EventArgs e)
		{
			this.GetData();
			bool flag = Conversions.ToBoolean(Public_Function.dict["autotakhlie"]);
			if (flag)
			{
				this.txt_takhlie.Visible = true;
				this.Label4.Visible = true;
			}
			else
			{
				this.txt_takhlie.Visible = false;
				this.Label4.Visible = false;
			}
		}

		// Token: 0x06001089 RID: 4233 RVA: 0x000B6968 File Offset: 0x000B4B68
		private void txt_daramad_ButtonClick(object sender, EventArgs e)
		{
			bool flag = Public_Function.ShowMessage("آیا مایل به حذف درآمد اول دوره میباشید؟", MessageBoxButtons.YesNo, MessageBoxIcon.Question, null) == DialogResult.Yes;
			if (flag)
			{
				Sanad sanad = new Sanad();
				sanad.Delete(Conversions.ToString(this.dt.Rows[0]["ID"]));
				this.txt_daramad.ButtonStyle = EditButtonStyle.NoButton;
				this.txt_daramad.SetNew();
				this.isnew_daramad = true;
				this.dt = null;
				Public_Function.ShowMessage("اطلاعات مورد نظر ثبت گردید", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, null);
			}
		}

		// Token: 0x0600108A RID: 4234 RVA: 0x000B69F0 File Offset: 0x000B4BF0
		private void txt_hazine_ButtonClick(object sender, EventArgs e)
		{
			bool flag = Public_Function.ShowMessage("آیا مایل به حذف هزینه اول دوره میباشید؟", MessageBoxButtons.YesNo, MessageBoxIcon.Question, null) == DialogResult.Yes;
			if (flag)
			{
				Sanad sanad = new Sanad();
				sanad.Delete(Conversions.ToString(this.dt2.Rows[0]["ID"]));
				this.txt_hazine.ButtonStyle = EditButtonStyle.NoButton;
				this.txt_hazine.SetNew();
				this.isnew_hazine = true;
				this.dt2 = null;
				Public_Function.ShowMessage("اطلاعات مورد نظر ثبت گردید", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, null);
			}
		}

		// Token: 0x0600108B RID: 4235 RVA: 0x000B6A78 File Offset: 0x000B4C78
		private void txt_sandugh_ButtonClick(object sender, EventArgs e)
		{
			bool flag = Public_Function.ShowMessage("آیا مایل به حذف صندوق اول دوره میباشید؟", MessageBoxButtons.YesNo, MessageBoxIcon.Question, null) == DialogResult.Yes;
			if (flag)
			{
				Sanad sanad = new Sanad();
				sanad.Delete(Conversions.ToString(this.dt3.Rows[0]["ID"]));
				this.txt_sandugh.ButtonStyle = EditButtonStyle.NoButton;
				this.txt_sandugh.SetNew();
				this.isnew_sandugh = true;
				this.dt3 = null;
				Public_Function.ShowMessage("اطلاعات مورد نظر ثبت گردید", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, null);
			}
		}

		// Token: 0x0600108C RID: 4236 RVA: 0x000B6B00 File Offset: 0x000B4D00
		private void txt_kasri_ButtonClick(object sender, EventArgs e)
		{
			bool flag = Public_Function.ShowMessage("آیا مایل به حذف اطلاعات میباشید؟", MessageBoxButtons.YesNo, MessageBoxIcon.Question, null) == DialogResult.Yes;
			if (flag)
			{
				Public_Function.ExecuteNonQuery("delete from daryaftpardakht where dptype_id=16 and tarikh=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi("1392/01/01")));
				this.txt_kasri.ButtonStyle = EditButtonStyle.NoButton;
				this.txt_kasri.SetNew();
				this.isnew_kasri = true;
			}
		}

		// Token: 0x0600108D RID: 4237 RVA: 0x000B6B64 File Offset: 0x000B4D64
		private void txt_ezafi_ButtonClick(object sender, EventArgs e)
		{
			bool flag = Public_Function.ShowMessage("آیا مایل به حذف اطلاعات میباشید؟", MessageBoxButtons.YesNo, MessageBoxIcon.Question, null) == DialogResult.Yes;
			if (flag)
			{
				Public_Function.ExecuteNonQuery("delete from daryaftpardakht where dptype_id=5 and tarikh=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi("1392/01/01")));
				this.txt_ezafi.ButtonStyle = EditButtonStyle.NoButton;
				this.txt_ezafi.SetNew();
				this.isnew_ezafi = true;
			}
		}

		// Token: 0x0600108E RID: 4238 RVA: 0x000B6BC8 File Offset: 0x000B4DC8
		private void txt_takhlie_ButtonClick(object sender, EventArgs e)
		{
			bool flag = Public_Function.ShowMessage("آیا مایل به حذف اطلاعات میباشید؟", MessageBoxButtons.YesNo, MessageBoxIcon.Question, null) == DialogResult.Yes;
			if (flag)
			{
				Sanad sanad = new Sanad();
				sanad.Delete(Conversions.ToString(this.dt4.Rows[0]["ID"]));
				this.txt_takhlie.ButtonStyle = EditButtonStyle.NoButton;
				this.txt_takhlie.SetNew();
				this.isnew_takhlie = true;
				this.dt4 = null;
			}
		}

		// Token: 0x0400063D RID: 1597
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x0400063F RID: 1599
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x04000640 RID: 1600
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04000641 RID: 1601
		[AccessedThroughProperty("Bar1")]
		private Bar _Bar1;

		// Token: 0x04000642 RID: 1602
		[AccessedThroughProperty("ButtonItem2")]
		private ButtonItem _ButtonItem2;

		// Token: 0x04000643 RID: 1603
		[AccessedThroughProperty("txt_hazine")]
		private CurrencyBox _txt_hazine;

		// Token: 0x04000644 RID: 1604
		[AccessedThroughProperty("txt_daramad")]
		private CurrencyBox _txt_daramad;

		// Token: 0x04000645 RID: 1605
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x04000646 RID: 1606
		[AccessedThroughProperty("txt_sandugh")]
		private CurrencyBox _txt_sandugh;

		// Token: 0x04000647 RID: 1607
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x04000648 RID: 1608
		[AccessedThroughProperty("txt_takhlie")]
		private CurrencyBox _txt_takhlie;

		// Token: 0x04000649 RID: 1609
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		// Token: 0x0400064A RID: 1610
		[AccessedThroughProperty("txt_ezafi")]
		private CurrencyBox _txt_ezafi;

		// Token: 0x0400064B RID: 1611
		[AccessedThroughProperty("txt_kasri")]
		private CurrencyBox _txt_kasri;

		// Token: 0x0400064C RID: 1612
		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		// Token: 0x0400064D RID: 1613
		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		// Token: 0x0400064E RID: 1614
		private Bank Bank;

		// Token: 0x0400064F RID: 1615
		private bool isnew_daramad;

		// Token: 0x04000650 RID: 1616
		private bool isnew_hazine;

		// Token: 0x04000651 RID: 1617
		private bool isnew_sandugh;

		// Token: 0x04000652 RID: 1618
		private bool isnew_takhlie;

		// Token: 0x04000653 RID: 1619
		private bool isnew_kasri;

		// Token: 0x04000654 RID: 1620
		private bool isnew_ezafi;

		// Token: 0x04000655 RID: 1621
		private DataTable dt;

		// Token: 0x04000656 RID: 1622
		private DataTable dt2;

		// Token: 0x04000657 RID: 1623
		private DataTable dt3;

		// Token: 0x04000658 RID: 1624
		private DataTable dt4;
	}
}
