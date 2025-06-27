using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.UI.Dock;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x020000D8 RID: 216
	[DesignerGenerated]
	public partial class Frm_Select_Kala_To_Kala : Form
	{
		// Token: 0x0600134C RID: 4940 RVA: 0x00006464 File Offset: 0x00004664
		[DebuggerNonUserCode]
		public Frm_Select_Kala_To_Kala()
		{
			base.KeyDown += new KeyEventHandler(this.Frm_Select_Kala_To_Kala_KeyDown);
			base.Load += new EventHandler(this.Frm_Select_Kala_To_Kala_Load);
			Frm_Select_Kala_To_Kala.__ENCAddToList(this);
			this.InitializeComponent();
		}

		// Token: 0x0600134D RID: 4941 RVA: 0x000CE130 File Offset: 0x000CC330
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_Select_Kala_To_Kala.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_Select_Kala_To_Kala.__ENCList.Count == Frm_Select_Kala_To_Kala.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_Select_Kala_To_Kala.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_Select_Kala_To_Kala.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_Select_Kala_To_Kala.__ENCList[num] = Frm_Select_Kala_To_Kala.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_Select_Kala_To_Kala.__ENCList.RemoveRange(num, Frm_Select_Kala_To_Kala.__ENCList.Count - num);
						Frm_Select_Kala_To_Kala.__ENCList.Capacity = Frm_Select_Kala_To_Kala.__ENCList.Count;
					}
					Frm_Select_Kala_To_Kala.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x170005FF RID: 1535
		// (get) Token: 0x06001350 RID: 4944 RVA: 0x000CE794 File Offset: 0x000CC994
		// (set) Token: 0x06001351 RID: 4945 RVA: 0x000064A4 File Offset: 0x000046A4
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

		// Token: 0x17000600 RID: 1536
		// (get) Token: 0x06001352 RID: 4946 RVA: 0x000CE7AC File Offset: 0x000CC9AC
		// (set) Token: 0x06001353 RID: 4947 RVA: 0x000064AE File Offset: 0x000046AE
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

		// Token: 0x17000601 RID: 1537
		// (get) Token: 0x06001354 RID: 4948 RVA: 0x000CE7C4 File Offset: 0x000CC9C4
		// (set) Token: 0x06001355 RID: 4949 RVA: 0x000064B8 File Offset: 0x000046B8
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

		// Token: 0x17000602 RID: 1538
		// (get) Token: 0x06001356 RID: 4950 RVA: 0x000CE7DC File Offset: 0x000CC9DC
		// (set) Token: 0x06001357 RID: 4951 RVA: 0x000064C2 File Offset: 0x000046C2
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

		// Token: 0x17000603 RID: 1539
		// (get) Token: 0x06001358 RID: 4952 RVA: 0x000CE7F4 File Offset: 0x000CC9F4
		// (set) Token: 0x06001359 RID: 4953 RVA: 0x000CE80C File Offset: 0x000CCA0C
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
				RowActionEventHandler value2 = new RowActionEventHandler(this.GridEX1_RowDoubleClick);
				KeyEventHandler value3 = new KeyEventHandler(this.GridEX1_KeyDown);
				bool flag = this._GridEX1 != null;
				if (flag)
				{
					this._GridEX1.RowDoubleClick -= value2;
					this._GridEX1.KeyDown -= value3;
				}
				this._GridEX1 = value;
				flag = (this._GridEX1 != null);
				if (flag)
				{
					this._GridEX1.RowDoubleClick += value2;
					this._GridEX1.KeyDown += value3;
				}
			}
		}

		// Token: 0x17000604 RID: 1540
		// (get) Token: 0x0600135A RID: 4954 RVA: 0x000CE894 File Offset: 0x000CCA94
		// (set) Token: 0x0600135B RID: 4955 RVA: 0x000064CC File Offset: 0x000046CC
		public DataTable Dt_Kharid
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Dt_Kharid;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Dt_Kharid = value;
			}
		}

		// Token: 0x17000605 RID: 1541
		// (get) Token: 0x0600135C RID: 4956 RVA: 0x000CE8AC File Offset: 0x000CCAAC
		// (set) Token: 0x0600135D RID: 4957 RVA: 0x000064D6 File Offset: 0x000046D6
		public GridEXRow Selected_Row
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Selected_Row;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Selected_Row = value;
			}
		}

		// Token: 0x0600135E RID: 4958 RVA: 0x0007B16C File Offset: 0x0007936C
		private void Frm_Select_Kala_To_Kala_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Escape;
			if (flag)
			{
				this.DialogResult = DialogResult.Cancel;
				this.Close();
			}
		}

		// Token: 0x0600135F RID: 4959 RVA: 0x000CE8C4 File Offset: 0x000CCAC4
		private void Frm_Select_Kala_To_Kala_Load(object sender, EventArgs e)
		{
			try
			{
				IEnumerator enumerator = this.Dt_Kharid.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					bool flag = dataRow["vazn"] != DBNull.Value;
					if (flag)
					{
						dataRow["vazn"] = Public_Function.GetDecimalValue(Conversions.ToDecimal(dataRow["vazn"]));
					}
					flag = (dataRow["tedad"] != DBNull.Value);
					if (flag)
					{
						dataRow["tedad"] = Public_Function.GetDecimalValue(Conversions.ToDecimal(dataRow["tedad"]));
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
			this.GridEX1.DataSource = this.Dt_Kharid;
		}

		// Token: 0x06001360 RID: 4960 RVA: 0x000CE9C8 File Offset: 0x000CCBC8
		private void GridEX1_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				bool flag2 = this.GridEX1.CurrentRow == null;
				if (!flag2)
				{
					this.Selected_Row = this.GridEX1.CurrentRow;
					this.DialogResult = DialogResult.OK;
					this.Close();
				}
			}
		}

		// Token: 0x06001361 RID: 4961 RVA: 0x000064E0 File Offset: 0x000046E0
		private void GridEX1_RowDoubleClick(object sender, RowActionEventArgs e)
		{
			this.Selected_Row = this.GridEX1.CurrentRow;
			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		// Token: 0x04000777 RID: 1911
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000779 RID: 1913
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x0400077A RID: 1914
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x0400077B RID: 1915
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x0400077C RID: 1916
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x0400077D RID: 1917
		[AccessedThroughProperty("GridEX1")]
		private GridEX _GridEX1;

		// Token: 0x0400077E RID: 1918
		[CompilerGenerated]
		private DataTable _Dt_Kharid;

		// Token: 0x0400077F RID: 1919
		[CompilerGenerated]
		private GridEXRow _Selected_Row;
	}
}
