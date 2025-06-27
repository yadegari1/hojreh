using System;
using System.Collections;

namespace FruitBox
{
	// Token: 0x020000A7 RID: 167
	public class ItemCollection : CollectionBase
	{
		// Token: 0x06000E39 RID: 3641 RVA: 0x000A7278 File Offset: 0x000A5478
		public void AddRange(Column[] Columns)
		{
			checked
			{
				for (int i = 0; i < Columns.Length; i++)
				{
					Column item = Columns[i];
					this.Add(item);
				}
			}
		}

		// Token: 0x1700042B RID: 1067
		public Column this[int index]
		{
			get
			{
				return (Column)this.List[index];
			}
			set
			{
				this.List[index] = value;
			}
		}

		// Token: 0x06000E3C RID: 3644 RVA: 0x000A72CC File Offset: 0x000A54CC
		public int Add(Column item)
		{
			return this.List.Add(item);
		}

		// Token: 0x06000E3D RID: 3645 RVA: 0x00004D74 File Offset: 0x00002F74
		public void Remove(Column item)
		{
			this.List.Remove(item);
		}
	}
}
