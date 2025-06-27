using System;
using System.Collections;
using System.Diagnostics;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x02000099 RID: 153
	public class GridColumnCollection : CollectionBase
	{
		// Token: 0x06000DAA RID: 3498 RVA: 0x00004D6A File Offset: 0x00002F6A
		[DebuggerNonUserCode]
		public GridColumnCollection()
		{
		}

		// Token: 0x06000DAB RID: 3499 RVA: 0x000A55F8 File Offset: 0x000A37F8
		public void AddRange(GridColumn[] Columns)
		{
			checked
			{
				for (int i = 0; i < Columns.Length; i++)
				{
					GridColumn item = Columns[i];
					this.Add(item);
				}
			}
		}

		// Token: 0x06000DAC RID: 3500 RVA: 0x000A5628 File Offset: 0x000A3828
		public int Add(GridColumn Item)
		{
			int result;
			try
			{
				IEnumerator enumerator = this.List.GetEnumerator();
				while (enumerator.MoveNext())
				{
					GridColumn gridColumn = (GridColumn)enumerator.Current;
					bool flag = Operators.CompareString(gridColumn.Name, Item.Name, false) == 0;
					if (flag)
					{
						result = 0;
						return result;
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
			result = this.List.Add(Item);
			return result;
		}

		// Token: 0x06000DAD RID: 3501 RVA: 0x00004D74 File Offset: 0x00002F74
		public void Remove(GridColumn Item)
		{
			this.List.Remove(Item);
		}

		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x06000DAE RID: 3502 RVA: 0x000A56BC File Offset: 0x000A38BC
		// (set) Token: 0x06000DAF RID: 3503 RVA: 0x00004D85 File Offset: 0x00002F85
		public GridColumn Item
		{
			get
			{
				return (GridColumn)this.List[Index];
			}
			set
			{
				this.List[Index] = value;
			}
		}
	}
}
