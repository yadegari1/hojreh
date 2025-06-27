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
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x02000065 RID: 101
	[DesignerGenerated]
	public partial class Frm_Coloring : Form
	{
		// Token: 0x06000716 RID: 1814 RVA: 0x0006C1E8 File Offset: 0x0006A3E8
		public Frm_Coloring()
		{
			base.KeyDown += new KeyEventHandler(this.Frm_Coloring_KeyDown);
			base.Load += new EventHandler(this.Frm_Coloring_Load);
			Frm_Coloring.__ENCAddToList(this);
			bool isnew = true;
			this.Isnew = isnew;
			this.InitializeComponent();
		}

		// Token: 0x06000717 RID: 1815 RVA: 0x0006C240 File Offset: 0x0006A440
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_Coloring.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_Coloring.__ENCList.Count == Frm_Coloring.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_Coloring.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_Coloring.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_Coloring.__ENCList[num] = Frm_Coloring.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_Coloring.__ENCList.RemoveRange(num, Frm_Coloring.__ENCList.Count - num);
						Frm_Coloring.__ENCList.Capacity = Frm_Coloring.__ENCList.Count;
					}
					Frm_Coloring.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x0600071A RID: 1818 RVA: 0x0006D758 File Offset: 0x0006B958
		// (set) Token: 0x0600071B RID: 1819 RVA: 0x0006D770 File Offset: 0x0006B970
		internal virtual ColorPickerButton ColorPickerButton1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ColorPickerButton1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ColorPickerButton1_SelectedColorChanged);
				bool flag = this._ColorPickerButton1 != null;
				if (flag)
				{
					this._ColorPickerButton1.SelectedColorChanged -= value2;
				}
				this._ColorPickerButton1 = value;
				flag = (this._ColorPickerButton1 != null);
				if (flag)
				{
					this._ColorPickerButton1.SelectedColorChanged += value2;
				}
			}
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x0600071C RID: 1820 RVA: 0x0006D7D0 File Offset: 0x0006B9D0
		// (set) Token: 0x0600071D RID: 1821 RVA: 0x00003112 File Offset: 0x00001312
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

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x0600071E RID: 1822 RVA: 0x0006D7E8 File Offset: 0x0006B9E8
		// (set) Token: 0x0600071F RID: 1823 RVA: 0x0000311C File Offset: 0x0000131C
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

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x06000720 RID: 1824 RVA: 0x0006D800 File Offset: 0x0006BA00
		// (set) Token: 0x06000721 RID: 1825 RVA: 0x00003126 File Offset: 0x00001326
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

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x06000722 RID: 1826 RVA: 0x0006D818 File Offset: 0x0006BA18
		// (set) Token: 0x06000723 RID: 1827 RVA: 0x00003130 File Offset: 0x00001330
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

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x06000724 RID: 1828 RVA: 0x0006D830 File Offset: 0x0006BA30
		// (set) Token: 0x06000725 RID: 1829 RVA: 0x0000313A File Offset: 0x0000133A
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
				this._ButtonItem2 = value;
			}
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x06000726 RID: 1830 RVA: 0x0006D848 File Offset: 0x0006BA48
		// (set) Token: 0x06000727 RID: 1831 RVA: 0x00003144 File Offset: 0x00001344
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

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x06000728 RID: 1832 RVA: 0x0006D860 File Offset: 0x0006BA60
		// (set) Token: 0x06000729 RID: 1833 RVA: 0x0000314E File Offset: 0x0000134E
		internal virtual UIButton UiButton2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiButton2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._UiButton2 = value;
			}
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x0600072A RID: 1834 RVA: 0x0006D878 File Offset: 0x0006BA78
		// (set) Token: 0x0600072B RID: 1835 RVA: 0x00003158 File Offset: 0x00001358
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
				this._UiButton1 = value;
			}
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x0600072C RID: 1836 RVA: 0x0006D890 File Offset: 0x0006BA90
		// (set) Token: 0x0600072D RID: 1837 RVA: 0x0006D8A8 File Offset: 0x0006BAA8
		internal virtual ColorPickerButton ColorPickerButton2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ColorPickerButton2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ColorPickerButton2_SelectedColorChanged);
				bool flag = this._ColorPickerButton2 != null;
				if (flag)
				{
					this._ColorPickerButton2.SelectedColorChanged -= value2;
				}
				this._ColorPickerButton2 = value;
				flag = (this._ColorPickerButton2 != null);
				if (flag)
				{
					this._ColorPickerButton2.SelectedColorChanged += value2;
				}
			}
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x0600072E RID: 1838 RVA: 0x0006D908 File Offset: 0x0006BB08
		// (set) Token: 0x0600072F RID: 1839 RVA: 0x00003162 File Offset: 0x00001362
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

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x06000730 RID: 1840 RVA: 0x0006D920 File Offset: 0x0006BB20
		// (set) Token: 0x06000731 RID: 1841 RVA: 0x0006D938 File Offset: 0x0006BB38
		internal virtual ColorPickerButton ColorPickerButton3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ColorPickerButton3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ColorPickerButton3_SelectedColorChanged);
				bool flag = this._ColorPickerButton3 != null;
				if (flag)
				{
					this._ColorPickerButton3.SelectedColorChanged -= value2;
				}
				this._ColorPickerButton3 = value;
				flag = (this._ColorPickerButton3 != null);
				if (flag)
				{
					this._ColorPickerButton3.SelectedColorChanged += value2;
				}
			}
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x06000732 RID: 1842 RVA: 0x0006D998 File Offset: 0x0006BB98
		// (set) Token: 0x06000733 RID: 1843 RVA: 0x0000316C File Offset: 0x0000136C
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

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x06000734 RID: 1844 RVA: 0x0006D9B0 File Offset: 0x0006BBB0
		// (set) Token: 0x06000735 RID: 1845 RVA: 0x0006D9C8 File Offset: 0x0006BBC8
		internal virtual UIButton UiButton3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiButton3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.UiButton3_Click);
				bool flag = this._UiButton3 != null;
				if (flag)
				{
					this._UiButton3.Click -= value2;
				}
				this._UiButton3 = value;
				flag = (this._UiButton3 != null);
				if (flag)
				{
					this._UiButton3.Click += value2;
				}
			}
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x06000736 RID: 1846 RVA: 0x0006DA28 File Offset: 0x0006BC28
		// (set) Token: 0x06000737 RID: 1847 RVA: 0x00003176 File Offset: 0x00001376
		internal virtual Label Label10
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label10;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label10 = value;
			}
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x06000738 RID: 1848 RVA: 0x0006DA40 File Offset: 0x0006BC40
		// (set) Token: 0x06000739 RID: 1849 RVA: 0x00003180 File Offset: 0x00001380
		internal virtual EditBox EditBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._EditBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._EditBox1 = value;
			}
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x0600073A RID: 1850 RVA: 0x0006DA58 File Offset: 0x0006BC58
		// (set) Token: 0x0600073B RID: 1851 RVA: 0x0000318A File Offset: 0x0000138A
		internal virtual NavBox NavBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._NavBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._NavBox1 = value;
			}
		}

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x0600073C RID: 1852 RVA: 0x0006DA70 File Offset: 0x0006BC70
		// (set) Token: 0x0600073D RID: 1853 RVA: 0x00003194 File Offset: 0x00001394
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

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x0600073E RID: 1854 RVA: 0x0006DA88 File Offset: 0x0006BC88
		// (set) Token: 0x0600073F RID: 1855 RVA: 0x0000319E File Offset: 0x0000139E
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
				this._GridEX1 = value;
			}
		}

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x06000740 RID: 1856 RVA: 0x0006DAA0 File Offset: 0x0006BCA0
		// (set) Token: 0x06000741 RID: 1857 RVA: 0x0006DAB8 File Offset: 0x0006BCB8
		internal virtual ColorPickerButton ColorPickerButton4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ColorPickerButton4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ColorPickerButton4_SelectedColorChanged);
				bool flag = this._ColorPickerButton4 != null;
				if (flag)
				{
					this._ColorPickerButton4.SelectedColorChanged -= value2;
				}
				this._ColorPickerButton4 = value;
				flag = (this._ColorPickerButton4 != null);
				if (flag)
				{
					this._ColorPickerButton4.SelectedColorChanged += value2;
				}
			}
		}

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x06000742 RID: 1858 RVA: 0x0006DB18 File Offset: 0x0006BD18
		// (set) Token: 0x06000743 RID: 1859 RVA: 0x000031A8 File Offset: 0x000013A8
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

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x06000744 RID: 1860 RVA: 0x0006DB30 File Offset: 0x0006BD30
		// (set) Token: 0x06000745 RID: 1861 RVA: 0x000031B2 File Offset: 0x000013B2
		public bool Isnew
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Isnew;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Isnew = value;
			}
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x06000746 RID: 1862 RVA: 0x0006DB48 File Offset: 0x0006BD48
		// (set) Token: 0x06000747 RID: 1863 RVA: 0x000031BC File Offset: 0x000013BC
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

		// Token: 0x06000748 RID: 1864 RVA: 0x0006620C File Offset: 0x0006440C
		private void Frm_Coloring_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Escape;
			if (flag)
			{
				this.Close();
			}
		}

		// Token: 0x06000749 RID: 1865 RVA: 0x0006DB60 File Offset: 0x0006BD60
		private void Frm_Coloring_Load(object sender, EventArgs e)
		{
			DataTable dataSource = Public_Function.FillData("select name+' '+ family as name from moshtari where id>0");
			this.GridEX1.DataSource = dataSource;
			bool flag = this.ID > 0L;
			if (flag)
			{
				this.Isnew = false;
				DataRow dataRow = Public_Function.FillDataRow("select * from theme where id=" + Conversions.ToString(this.ID));
				flag = (dataRow != null);
				if (flag)
				{
					this.EditBox1.Text = Conversions.ToString(dataRow["name"]);
					flag = (dataRow["ToolbarBackground"] != DBNull.Value);
					if (flag)
					{
						this.ColorPickerButton1.SelectedColor = Color.FromArgb(Conversions.ToInteger(dataRow["ToolbarBackground"]));
						this.ColorPickerButton1_SelectedColorChanged(null, null);
					}
					flag = (dataRow["Background"] != DBNull.Value);
					if (flag)
					{
						this.ColorPickerButton2.SelectedColor = Color.FromArgb(Conversions.ToInteger(dataRow["Background"]));
						this.ColorPickerButton2_SelectedColorChanged(null, null);
					}
					flag = (dataRow["ButtonBackground"] != DBNull.Value);
					if (flag)
					{
						this.ColorPickerButton3.SelectedColor = Color.FromArgb(Conversions.ToInteger(dataRow["ButtonBackground"]));
						this.ColorPickerButton3_SelectedColorChanged(null, null);
					}
					flag = (dataRow["GridColor"] != DBNull.Value);
					if (flag)
					{
						this.ColorPickerButton4.SelectedColor = Color.FromArgb(Conversions.ToInteger(dataRow["GridColor"]));
						this.ColorPickerButton4_SelectedColorChanged(null, null);
					}
				}
			}
		}

		// Token: 0x0600074A RID: 1866 RVA: 0x0006DCF8 File Offset: 0x0006BEF8
		private void ColorPickerButton1_SelectedColorChanged(object sender, EventArgs e)
		{
			this.Bar1.BackColor = this.ColorPickerButton1.SelectedColor;
		}

		// Token: 0x0600074B RID: 1867 RVA: 0x0006DD20 File Offset: 0x0006BF20
		private void ColorPickerButton2_SelectedColorChanged(object sender, EventArgs e)
		{
			this.UiGroupBox1.BackgroundStyle = BackgroundStyle.Default;
			this.UiGroupBox1.BackColor = this.ColorPickerButton2.SelectedColor;
		}

		// Token: 0x0600074C RID: 1868 RVA: 0x0006DD54 File Offset: 0x0006BF54
		private void ColorPickerButton3_SelectedColorChanged(object sender, EventArgs e)
		{
			this.UiButton1.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Custom;
			this.UiButton1.OfficeCustomColor = this.ColorPickerButton3.SelectedColor;
			this.UiButton1.BackColor = this.ColorPickerButton3.SelectedColor;
			this.UiButton2.BackColor = this.ColorPickerButton3.SelectedColor;
			this.NavBox1.UiButton1.BackColor = this.ColorPickerButton3.SelectedColor;
			this.NavBox1.UiButton2.BackColor = this.ColorPickerButton3.SelectedColor;
			this.NavBox1.UiButton3.BackColor = this.ColorPickerButton3.SelectedColor;
			this.NavBox1.UiButton4.BackColor = this.ColorPickerButton3.SelectedColor;
		}

		// Token: 0x0600074D RID: 1869 RVA: 0x0006DE28 File Offset: 0x0006C028
		private string GetColorValue(ColorPickerButton cl)
		{
			Color right;
			bool flag = cl.SelectedColor == right;
			string result;
			if (flag)
			{
				result = "NULL";
			}
			else
			{
				result = Public_Function.GetValue(Conversions.ToString(cl.SelectedColor.ToArgb()));
			}
			return result;
		}

		// Token: 0x0600074E RID: 1870 RVA: 0x0006DE70 File Offset: 0x0006C070
		private void UiButton3_Click(object sender, EventArgs e)
		{
			bool flag = Operators.CompareString(this.EditBox1.Text, string.Empty, false) == 0;
			if (flag)
			{
				this.EditBox1.ShowTip("عنوان رنگ بندی را وارد نمائید");
			}
			else
			{
				flag = this.Isnew;
				if (flag)
				{
					int num = Conversions.ToInteger(Public_Function.ExecuteScalar(string.Concat(new string[]
					{
						"INSERT INTO [Theme]  ([Name],[GridColor],[ToolbarBackground],[Background]  ,[ButtonBackground])  VALUES (",
						Public_Function.GetValue(this.EditBox1.Text),
						",",
						this.GetColorValue(this.ColorPickerButton4),
						",",
						this.GetColorValue(this.ColorPickerButton1),
						",",
						this.GetColorValue(this.ColorPickerButton2),
						",",
						this.GetColorValue(this.ColorPickerButton3),
						");select scope_identity();"
					})));
					ButtonItem buttonItem = new ButtonItem();
					buttonItem.Text = this.EditBox1.Text;
					buttonItem.Tag = num;
					MyProject.Forms.Form_Main.ButtonItem98.SubItems.Add(buttonItem, checked(MyProject.Forms.Form_Main.ButtonItem98.SubItems.Count - 1));
					buttonItem.Click += new EventHandler(MyProject.Forms.Form_Main.ColorMenuClick);
					Public_Function.ConfirmInsert();
				}
				else
				{
					Public_Function.ExecuteNonQuery(string.Concat(new string[]
					{
						"update theme set name=",
						Public_Function.GetValue(this.EditBox1.Text),
						",Gridcolor=",
						this.GetColorValue(this.ColorPickerButton4),
						",ToolbarBackground=",
						this.GetColorValue(this.ColorPickerButton1),
						",Background=",
						this.GetColorValue(this.ColorPickerButton2),
						",ButtonBackground=",
						this.GetColorValue(this.ColorPickerButton3),
						" where id=",
						Conversions.ToString(this.ID)
					}));
					Public_Function.ConfirmInsert();
				}
			}
		}

		// Token: 0x0600074F RID: 1871 RVA: 0x0006E0A4 File Offset: 0x0006C2A4
		private void ColorPickerButton4_SelectedColorChanged(object sender, EventArgs e)
		{
			this.GridEX1.OfficeColorScheme = Janus.Windows.GridEX.OfficeColorScheme.Custom;
			this.GridEX1.OfficeCustomColor = this.ColorPickerButton4.SelectedColor;
		}

		// Token: 0x040002B1 RID: 689
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x040002B3 RID: 691
		[AccessedThroughProperty("ColorPickerButton1")]
		private ColorPickerButton _ColorPickerButton1;

		// Token: 0x040002B4 RID: 692
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x040002B5 RID: 693
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x040002B6 RID: 694
		[AccessedThroughProperty("Bar1")]
		private Bar _Bar1;

		// Token: 0x040002B7 RID: 695
		[AccessedThroughProperty("ButtonItem1")]
		private ButtonItem _ButtonItem1;

		// Token: 0x040002B8 RID: 696
		[AccessedThroughProperty("ButtonItem2")]
		private ButtonItem _ButtonItem2;

		// Token: 0x040002B9 RID: 697
		[AccessedThroughProperty("ButtonItem3")]
		private ButtonItem _ButtonItem3;

		// Token: 0x040002BA RID: 698
		[AccessedThroughProperty("UiButton2")]
		private UIButton _UiButton2;

		// Token: 0x040002BB RID: 699
		[AccessedThroughProperty("UiButton1")]
		private UIButton _UiButton1;

		// Token: 0x040002BC RID: 700
		[AccessedThroughProperty("ColorPickerButton2")]
		private ColorPickerButton _ColorPickerButton2;

		// Token: 0x040002BD RID: 701
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x040002BE RID: 702
		[AccessedThroughProperty("ColorPickerButton3")]
		private ColorPickerButton _ColorPickerButton3;

		// Token: 0x040002BF RID: 703
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x040002C0 RID: 704
		[AccessedThroughProperty("UiButton3")]
		private UIButton _UiButton3;

		// Token: 0x040002C1 RID: 705
		[AccessedThroughProperty("Label10")]
		private Label _Label10;

		// Token: 0x040002C2 RID: 706
		[AccessedThroughProperty("EditBox1")]
		private EditBox _EditBox1;

		// Token: 0x040002C3 RID: 707
		[AccessedThroughProperty("NavBox1")]
		private NavBox _NavBox1;

		// Token: 0x040002C4 RID: 708
		[AccessedThroughProperty("SelectItem1")]
		private SelectItem _SelectItem1;

		// Token: 0x040002C5 RID: 709
		[AccessedThroughProperty("GridEX1")]
		private DataEntryGrid _GridEX1;

		// Token: 0x040002C6 RID: 710
		[AccessedThroughProperty("ColorPickerButton4")]
		private ColorPickerButton _ColorPickerButton4;

		// Token: 0x040002C7 RID: 711
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		// Token: 0x040002C8 RID: 712
		[CompilerGenerated]
		private bool _Isnew;

		// Token: 0x040002C9 RID: 713
		[CompilerGenerated]
		private long _ID;
	}
}
