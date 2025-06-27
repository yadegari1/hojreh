using System;

namespace FruitBox
{
	// Token: 0x020000BB RID: 187
	public interface IStickyControl
	{
		// Token: 0x06000EDF RID: 3807
		void DeleteSticky(CtrlStickyNote toDelete);

		// Token: 0x06000EE0 RID: 3808
		void HideAllStickies();

		// Token: 0x06000EE1 RID: 3809
		void RefreshStickyDisplay();
	}
}
