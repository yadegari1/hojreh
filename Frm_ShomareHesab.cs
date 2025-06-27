using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using FruitBox.My;
using FruitBox.My.Resources;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.GridEX.EditControls;
using Janus.Windows.UI.Dock;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x020000DA RID: 218
	[DesignerGenerated]
	public partial class Frm_ShomareHesab : Form
	{
		// Token: 0x0600138C RID: 5004 RVA: 0x000CFE00 File Offset: 0x000CE000
		public Frm_ShomareHesab()
		{
			base.Activated += new EventHandler(this.Frm_ShomareHesab_Activated);
			base.KeyDown += new KeyEventHandler(this.Frm_ShomareHesab_KeyDown);
			base.Load += new EventHandler(this.Frm_ShomareHesab_Load);
			Frm_ShomareHesab.__ENCAddToList(this);
			bool hasChanged = false;
			this.HasChanged = hasChanged;
			this.shomarehesab = new ShomareHesab();
			this.InitializeComponent();
		}

		// Token: 0x0600138D RID: 5005 RVA: 0x000CFE74 File Offset: 0x000CE074
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_ShomareHesab.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_ShomareHesab.__ENCList.Count == Frm_ShomareHesab.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_ShomareHesab.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_ShomareHesab.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_ShomareHesab.__ENCList[num] = Frm_ShomareHesab.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_ShomareHesab.__ENCList.RemoveRange(num, Frm_ShomareHesab.__ENCList.Count - num);
						Frm_ShomareHesab.__ENCList.Capacity = Frm_ShomareHesab.__ENCList.Count;
					}
					Frm_ShomareHesab.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000614 RID: 1556
		// (get) Token: 0x06001390 RID: 5008 RVA: 0x000D0B94 File Offset: 0x000CED94
		// (set) Token: 0x06001391 RID: 5009 RVA: 0x0000658D File Offset: 0x0000478D
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

		// Token: 0x17000615 RID: 1557
		// (get) Token: 0x06001392 RID: 5010 RVA: 0x000D0BAC File Offset: 0x000CEDAC
		// (set) Token: 0x06001393 RID: 5011 RVA: 0x00006597 File Offset: 0x00004797
		internal virtual EditBox txt_shomareHesab
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_shomareHesab;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_shomareHesab = value;
			}
		}

		// Token: 0x17000616 RID: 1558
		// (get) Token: 0x06001394 RID: 5012 RVA: 0x000D0BC4 File Offset: 0x000CEDC4
		// (set) Token: 0x06001395 RID: 5013 RVA: 0x000065A1 File Offset: 0x000047A1
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

		// Token: 0x17000617 RID: 1559
		// (get) Token: 0x06001396 RID: 5014 RVA: 0x000D0BDC File Offset: 0x000CEDDC
		// (set) Token: 0x06001397 RID: 5015 RVA: 0x000065AB File Offset: 0x000047AB
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

		// Token: 0x17000618 RID: 1560
		// (get) Token: 0x06001398 RID: 5016 RVA: 0x000D0BF4 File Offset: 0x000CEDF4
		// (set) Token: 0x06001399 RID: 5017 RVA: 0x000065B5 File Offset: 0x000047B5
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

		// Token: 0x17000619 RID: 1561
		// (get) Token: 0x0600139A RID: 5018 RVA: 0x000D0C0C File Offset: 0x000CEE0C
		// (set) Token: 0x0600139B RID: 5019 RVA: 0x000065BF File Offset: 0x000047BF
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

		// Token: 0x1700061A RID: 1562
		// (get) Token: 0x0600139C RID: 5020 RVA: 0x000D0C24 File Offset: 0x000CEE24
		// (set) Token: 0x0600139D RID: 5021 RVA: 0x000065C9 File Offset: 0x000047C9
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
				this._ButtonItem1 = value;
			}
		}

		// Token: 0x1700061B RID: 1563
		// (get) Token: 0x0600139E RID: 5022 RVA: 0x000D0C3C File Offset: 0x000CEE3C
		// (set) Token: 0x0600139F RID: 5023 RVA: 0x000D0C54 File Offset: 0x000CEE54
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

		// Token: 0x1700061C RID: 1564
		// (get) Token: 0x060013A0 RID: 5024 RVA: 0x000D0CB4 File Offset: 0x000CEEB4
		// (set) Token: 0x060013A1 RID: 5025 RVA: 0x000065D3 File Offset: 0x000047D3
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
				this._ButtonItem3 = value;
			}
		}

		// Token: 0x1700061D RID: 1565
		// (get) Token: 0x060013A2 RID: 5026 RVA: 0x000D0CCC File Offset: 0x000CEECC
		// (set) Token: 0x060013A3 RID: 5027 RVA: 0x000065DD File Offset: 0x000047DD
		internal virtual SelectItem txt_shobe
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_shobe;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_shobe = value;
			}
		}

		// Token: 0x1700061E RID: 1566
		// (get) Token: 0x060013A4 RID: 5028 RVA: 0x000D0CE4 File Offset: 0x000CEEE4
		// (set) Token: 0x060013A5 RID: 5029 RVA: 0x000065E7 File Offset: 0x000047E7
		internal virtual SelectItem txt_bank
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_bank;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_bank = value;
			}
		}

		// Token: 0x1700061F RID: 1567
		// (get) Token: 0x060013A6 RID: 5030 RVA: 0x000D0CFC File Offset: 0x000CEEFC
		// (set) Token: 0x060013A7 RID: 5031 RVA: 0x000065F1 File Offset: 0x000047F1
		public long ID
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ID;
			}
			[DebuggerNonUserCode]
			set
			{
				this._ID = value;
			}
		}

		// Token: 0x17000620 RID: 1568
		// (get) Token: 0x060013A8 RID: 5032 RVA: 0x000D0D14 File Offset: 0x000CEF14
		// (set) Token: 0x060013A9 RID: 5033 RVA: 0x000065FB File Offset: 0x000047FB
		public bool HasChanged
		{
			[DebuggerNonUserCode]
			get
			{
				return this._HasChanged;
			}
			[DebuggerNonUserCode]
			set
			{
				this._HasChanged = value;
			}
		}

		// Token: 0x060013AA RID: 5034 RVA: 0x00006605 File Offset: 0x00004805
		private void Frm_ShomareHesab_Activated(object sender, EventArgs e)
		{
			this.txt_shomareHesab.Focus();
			this.txt_shomareHesab.SelectAll();
		}

		// Token: 0x060013AB RID: 5035 RVA: 0x000D0D2C File Offset: 0x000CEF2C
		private void Frm_ShomareHesab_KeyDown(object sender, KeyEventArgs e)
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
			}
		}

		// Token: 0x060013AC RID: 5036 RVA: 0x000D0D6C File Offset: 0x000CEF6C
		private void Frm_ShomareHesab_Load(object sender, EventArgs e)
		{
			this.txt_bank.AddNewForm = MyProject.Forms.Frm_Bank;
			this.txt_bank.AllowNew = true;
			bool flag = this.ID != 0L;
			if (flag)
			{
				this.dr = Public_Function.FillDataRow("SELECT     ShomareHesab.ID, ShomareHesab.ShomareHesab, ShomareHesab.ShomareHesab as prevshomarehesab, Bank.Name AS Bank_Name, Shobe.Name AS Shobe_Name, Bank.ID AS Bank_ID, Shobe.ID AS Shobe_ID  FROM         ShomareHesab INNER JOIN  Bank ON ShomareHesab.Bank_ID = Bank.ID INNER JOIN  Shobe ON ShomareHesab.Shobe_ID = Shobe.ID where shomarehesab.ID=" + Conversions.ToString(this.ID));
				flag = (this.dr != null);
				if (flag)
				{
					this.txt_shomareHesab.Text = Conversions.ToString(this.dr["shomarehesab"]);
					this.txt_bank.SetValue(Conversions.ToString(this.dr["Bank_NAme"]), RuntimeHelpers.GetObjectValue(this.dr["bank_ID"]));
					this.txt_shobe.SetValue(Conversions.ToString(this.dr["shobe_Name"]), RuntimeHelpers.GetObjectValue(this.dr["shobe_ID"]));
				}
			}
		}

		// Token: 0x060013AD RID: 5037 RVA: 0x000D0E74 File Offset: 0x000CF074
		private void InvokeMethod(string methodName)
		{
			checked
			{
				try
				{
					IEnumerator enumerator = MyProject.Application.OpenForms.GetEnumerator();
					while (enumerator.MoveNext())
					{
						Form form = (Form)enumerator.Current;
						MethodInfo[] methods = form.GetType().GetMethods(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public);
						bool flag = form is Frm_SelectItemSql;
						if (flag)
						{
							form.Close();
						}
						MethodInfo[] array = methods;
						for (int i = 0; i < array.Length; i++)
						{
							MethodInfo methodInfo = array[i];
							flag = (Operators.CompareString(methodInfo.Name.ToLower(), methodName.ToLower(), false) == 0);
							if (flag)
							{
								this.dr["shomarehesab"] = this.txt_shomareHesab.Text;
								this.dr["bank_id"] = RuntimeHelpers.GetObjectValue(this.txt_bank.Value);
								this.dr["bank_name"] = this.txt_bank.Text;
								this.dr["shobe_id"] = RuntimeHelpers.GetObjectValue(this.txt_shobe.Value);
								this.dr["shobe_name"] = this.txt_shobe.Text;
								object[] parameters = new object[]
								{
									this.dr
								};
								methodInfo.Invoke(form, parameters);
							}
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
		}

		// Token: 0x060013AE RID: 5038 RVA: 0x000D1020 File Offset: 0x000CF220
		private void ButtonItem2_Click(object sender, EventArgs e)
		{
			bool flag = Public_Function.HasNull(this.UiGroupBox1);
			if (!flag)
			{
				bool arg_87_0;
				if (!Operators.ConditionalCompareObjectNotEqual(this.txt_shomareHesab.Text, this.dr["shomarehesab"], false) && !Operators.ConditionalCompareObjectNotEqual(this.txt_bank.Text, this.dr["bank_Name"], false))
				{
					if (!Operators.ConditionalCompareObjectNotEqual(this.txt_shobe.Text, this.dr["shobe_Name"], false))
					{
						arg_87_0 = false;
						goto IL_86;
					}
				}
				arg_87_0 = true;
				IL_86:
				flag = arg_87_0;
				if (flag)
				{
					this.shomarehesab.UpdateID(this.txt_shomareHesab.Text, Conversions.ToString(this.txt_bank.Value), Conversions.ToString(this.txt_shobe.Value), this.txt_shobe.Text, Conversions.ToString(this.ID));
					this.InvokeMethod("shomarehesab_chenged");
				}
				this.Close();
			}
		}

		// Token: 0x04000790 RID: 1936
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000792 RID: 1938
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x04000793 RID: 1939
		[AccessedThroughProperty("txt_shomareHesab")]
		private EditBox _txt_shomareHesab;

		// Token: 0x04000794 RID: 1940
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x04000795 RID: 1941
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x04000796 RID: 1942
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04000797 RID: 1943
		[AccessedThroughProperty("Bar1")]
		private Bar _Bar1;

		// Token: 0x04000798 RID: 1944
		[AccessedThroughProperty("ButtonItem1")]
		private ButtonItem _ButtonItem1;

		// Token: 0x04000799 RID: 1945
		[AccessedThroughProperty("ButtonItem2")]
		private ButtonItem _ButtonItem2;

		// Token: 0x0400079A RID: 1946
		[AccessedThroughProperty("ButtonItem3")]
		private ButtonItem _ButtonItem3;

		// Token: 0x0400079B RID: 1947
		[AccessedThroughProperty("txt_shobe")]
		private SelectItem _txt_shobe;

		// Token: 0x0400079C RID: 1948
		[AccessedThroughProperty("txt_bank")]
		private SelectItem _txt_bank;

		// Token: 0x0400079D RID: 1949
		[CompilerGenerated]
		private long _ID;

		// Token: 0x0400079E RID: 1950
		[CompilerGenerated]
		private bool _HasChanged;

		// Token: 0x0400079F RID: 1951
		private DataRow dr;

		// Token: 0x040007A0 RID: 1952
		private ShomareHesab shomarehesab;
	}
}
