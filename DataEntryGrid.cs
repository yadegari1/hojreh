using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Janus.Windows.GridEX;

namespace FruitBox
{
	// Token: 0x02000090 RID: 144
	public class DataEntryGrid : GridEX
	{
		// Token: 0x06000CC6 RID: 3270 RVA: 0x0009F230 File Offset: 0x0009D430
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = DataEntryGrid.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = DataEntryGrid.__ENCList.Count == DataEntryGrid.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = DataEntryGrid.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = DataEntryGrid.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									DataEntryGrid.__ENCList[num] = DataEntryGrid.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						DataEntryGrid.__ENCList.RemoveRange(num, DataEntryGrid.__ENCList.Count - num);
						DataEntryGrid.__ENCList.Capacity = DataEntryGrid.__ENCList.Count;
					}
					DataEntryGrid.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x06000CC7 RID: 3271 RVA: 0x0009F334 File Offset: 0x0009D534
		[DebuggerNonUserCode]
		public DataEntryGrid(IContainer container) : this()
		{
			bool flag = container != null;
			if (flag)
			{
				container.Add(this);
			}
		}

		// Token: 0x06000CC8 RID: 3272 RVA: 0x0009F360 File Offset: 0x0009D560
		[DebuggerNonUserCode]
		public DataEntryGrid()
		{
			DataEntryGrid.__ENCAddToList(this);
			this.InitializeComponent();
			bool designMode = this.DesignMode;
			if (designMode)
			{
				this.AllowAddNew = InheritableBoolean.True;
				this.AlternatingColors = true;
				this.AutoEdit = true;
				this.EnterKeyBehavior = EnterKeyBehavior.None;
				this.FocusStyle = FocusStyle.Solid;
				this.GridLineStyle = GridLineStyle.Solid;
				this.GroupByBoxVisible = false;
				this.NewRowPosition = NewRowPosition.BottomRow;
				this.RowHeaderContent = RowHeaderContent.RowIndex;
				this.RowHeaders = InheritableBoolean.True;
				this.UpdateMode = UpdateMode.CellUpdate;
				this.VisualStyle = VisualStyle.Office2010;
			}
		}

		// Token: 0x06000CC9 RID: 3273 RVA: 0x0009F3F0 File Offset: 0x0009D5F0
		[DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				bool flag = disposing && this.components != null;
				if (flag)
				{
					this.components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x06000CCA RID: 3274 RVA: 0x000048C4 File Offset: 0x00002AC4
		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new Container();
		}

		// Token: 0x040004E4 RID: 1252
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x040004E5 RID: 1253
		private IContainer components;
	}
}
