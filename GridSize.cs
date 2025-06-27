using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Janus.Windows.GridEX;

namespace FruitBox
{
	// Token: 0x02000098 RID: 152
	public class GridSize : Component
	{
		// Token: 0x06000DA0 RID: 3488 RVA: 0x000A5274 File Offset: 0x000A3474
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = GridSize.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = GridSize.__ENCList.Count == GridSize.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = GridSize.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = GridSize.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									GridSize.__ENCList[num] = GridSize.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						GridSize.__ENCList.RemoveRange(num, GridSize.__ENCList.Count - num);
						GridSize.__ENCList.Capacity = GridSize.__ENCList.Count;
					}
					GridSize.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x06000DA1 RID: 3489 RVA: 0x000A5378 File Offset: 0x000A3578
		[DebuggerNonUserCode]
		public GridSize(IContainer container) : this()
		{
			bool flag = container != null;
			if (flag)
			{
				container.Add(this);
			}
		}

		// Token: 0x06000DA2 RID: 3490 RVA: 0x000A53A4 File Offset: 0x000A35A4
		[DebuggerNonUserCode]
		public GridSize()
		{
			GridSize.__ENCAddToList(this);
			GridColumnCollection gridColumns = new GridColumnCollection();
			this.GridColumns = gridColumns;
			this.InitializeComponent();
		}

		// Token: 0x06000DA3 RID: 3491 RVA: 0x000A53D8 File Offset: 0x000A35D8
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

		// Token: 0x06000DA4 RID: 3492 RVA: 0x00004D51 File Offset: 0x00002F51
		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new Container();
		}

		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x06000DA5 RID: 3493 RVA: 0x000A5428 File Offset: 0x000A3628
		// (set) Token: 0x06000DA6 RID: 3494 RVA: 0x000A5440 File Offset: 0x000A3640
		[Category("ExtendProperty"), Browsable(true)]
		public GridEX Grid
		{
			get
			{
				return this._Grid;
			}
			set
			{
				this._Grid = value;
				bool flag = value == null;
				if (flag)
				{
					this.GridColumns.Clear();
				}
				else
				{
					value.Resize += new EventHandler(this.Grid_Resize);
				}
			}
		}

		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x06000DA7 RID: 3495 RVA: 0x000A5484 File Offset: 0x000A3684
		// (set) Token: 0x06000DA8 RID: 3496 RVA: 0x00004D60 File Offset: 0x00002F60
		[Category("ExtendProperty"), Browsable(true), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public GridColumnCollection GridColumns
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GridColumns;
			}
			[DebuggerNonUserCode]
			set
			{
				this._GridColumns = value;
			}
		}

		// Token: 0x06000DA9 RID: 3497 RVA: 0x000A549C File Offset: 0x000A369C
		public void Grid_Resize(object sender, EventArgs e)
		{
			bool flag = this.Grid == null;
			checked
			{
				if (!flag)
				{
					int num = 0;
					int num2 = this.Grid.Width - this.Grid.ScrollBarWidth - this.Grid.RootTable.RowHeaderWidth;
					try
					{
						IEnumerator enumerator = this.GridColumns.GetEnumerator();
						while (enumerator.MoveNext())
						{
							GridColumn gridColumn = (GridColumn)enumerator.Current;
							this.Grid.RootTable.Columns[gridColumn.Name].Width = (int)Math.Round(unchecked((double)num2 / 100.0 * (double)gridColumn.Size));
							num += this.Grid.RootTable.Columns[gridColumn.Name].Width;
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
					flag = (num > num2);
					if (flag)
					{
						GridEXColumn gridEXColumn = this.Grid.RootTable.Columns[this.GridColumns.get_Item(this.GridColumns.Count - 1).Name];
						gridEXColumn.Width -= num - num2 + 2;
					}
				}
			}
		}

		// Token: 0x04000543 RID: 1347
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000544 RID: 1348
		private IContainer components;

		// Token: 0x04000545 RID: 1349
		private GridEX _Grid;

		// Token: 0x04000546 RID: 1350
		[CompilerGenerated]
		private GridColumnCollection _GridColumns;
	}
}
