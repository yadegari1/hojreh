using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x020000A9 RID: 169
	[DesignerGenerated]
	public class BaseUserControl : UserControl
	{
		// Token: 0x06000E46 RID: 3654 RVA: 0x000A7334 File Offset: 0x000A5534
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = BaseUserControl.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = BaseUserControl.__ENCList.Count == BaseUserControl.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = BaseUserControl.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = BaseUserControl.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									BaseUserControl.__ENCList[num] = BaseUserControl.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						BaseUserControl.__ENCList.RemoveRange(num, BaseUserControl.__ENCList.Count - num);
						BaseUserControl.__ENCList.Capacity = BaseUserControl.__ENCList.Count;
					}
					BaseUserControl.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x06000E47 RID: 3655 RVA: 0x000A7438 File Offset: 0x000A5638
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

		// Token: 0x06000E48 RID: 3656 RVA: 0x000A7488 File Offset: 0x000A5688
		public BaseUserControl()
		{
			BaseUserControl.__ENCAddToList(this);
			base.SetStyle(ControlStyles.UserMouse, true);
			base.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
			base.SetStyle(ControlStyles.DoubleBuffer, true);
			base.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
			base.UpdateStyles();
			this.DoubleBuffered = true;
		}

		// Token: 0x06000E49 RID: 3657 RVA: 0x0000514E File Offset: 0x0000334E
		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new Container();
			this.AutoScaleMode = AutoScaleMode.Font;
		}

		// Token: 0x06000E4B RID: 3659 RVA: 0x000A74E8 File Offset: 0x000A56E8
		public static List<Control> GetAllChildControls(Control c)
		{
			List<Control> list = new List<Control>();
			BaseUserControl.GetAllChildControlsHelper(c, list);
			return list;
		}

		// Token: 0x06000E4C RID: 3660 RVA: 0x000A750C File Offset: 0x000A570C
		protected static void GetAllChildControlsHelper(Control c, List<Control> l)
		{
			l.Add(c);
			try
			{
				IEnumerator enumerator = c.Controls.GetEnumerator();
				while (enumerator.MoveNext())
				{
					Control c2 = (Control)enumerator.Current;
					BaseUserControl.GetAllChildControlsHelper(c2, l);
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

		// Token: 0x0400056F RID: 1391
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000570 RID: 1392
		private IContainer components;

		// Token: 0x04000571 RID: 1393
		public static int RichTextBoxIndentPixel = 10;

		// Token: 0x04000572 RID: 1394
		public const int WM_CHAR = 258;

		// Token: 0x04000573 RID: 1395
		public const int WM_ERASEBKGND = 20;

		// Token: 0x04000574 RID: 1396
		public const int WM_LBUTTONCLICK = 513;

		// Token: 0x04000575 RID: 1397
		public const int WM_NCCALCSIZE = 131;

		// Token: 0x04000576 RID: 1398
		public const int WM_NCPAINT = 133;

		// Token: 0x04000577 RID: 1399
		public const int WM_PAINT = 15;

		// Token: 0x04000578 RID: 1400
		public const int WM_PARENTNOTIFY = 528;

		// Token: 0x020000AA RID: 170
		// (Invoke) Token: 0x06000E50 RID: 3664
		public delegate void BoolDelegate(bool param);

		// Token: 0x020000AB RID: 171
		// (Invoke) Token: 0x06000E54 RID: 3668
		public delegate void EmptyDelegate();

		// Token: 0x020000AC RID: 172
		// (Invoke) Token: 0x06000E58 RID: 3672
		public delegate bool PreSaveOperation(object parameter);

		// Token: 0x020000AD RID: 173
		public class SaveMessages
		{
			// Token: 0x06000E59 RID: 3673 RVA: 0x00005179 File Offset: 0x00003379
			public SaveMessages(string initialMessage, string noNeed, string saveSucceed, string saveFailed)
			{
				this.InitialMessage = initialMessage;
				this.NoNeed = noNeed;
				this.SaveSucceed = saveSucceed;
				this.SaveFailed = saveFailed;
			}

			// Token: 0x1700042F RID: 1071
			// (get) Token: 0x06000E5A RID: 3674 RVA: 0x000A7584 File Offset: 0x000A5784
			// (set) Token: 0x06000E5B RID: 3675 RVA: 0x000051A5 File Offset: 0x000033A5
			public string InitialMessage
			{
				get
				{
					return this._InitialMessage;
				}
				set
				{
					this._InitialMessage = value;
				}
			}

			// Token: 0x17000430 RID: 1072
			// (get) Token: 0x06000E5C RID: 3676 RVA: 0x000A759C File Offset: 0x000A579C
			// (set) Token: 0x06000E5D RID: 3677 RVA: 0x000051B0 File Offset: 0x000033B0
			public string NoNeed
			{
				get
				{
					return this._NoNeed;
				}
				set
				{
					this._NoNeed = value;
				}
			}

			// Token: 0x17000431 RID: 1073
			// (get) Token: 0x06000E5E RID: 3678 RVA: 0x000A75B4 File Offset: 0x000A57B4
			// (set) Token: 0x06000E5F RID: 3679 RVA: 0x000051BB File Offset: 0x000033BB
			public string SaveFailed
			{
				get
				{
					return this._SaveFailed;
				}
				set
				{
					this._SaveFailed = value;
				}
			}

			// Token: 0x17000432 RID: 1074
			// (get) Token: 0x06000E60 RID: 3680 RVA: 0x000A75CC File Offset: 0x000A57CC
			// (set) Token: 0x06000E61 RID: 3681 RVA: 0x000051C6 File Offset: 0x000033C6
			public string SaveSucceed
			{
				get
				{
					return this._SaveSucceed;
				}
				set
				{
					this._SaveSucceed = value;
				}
			}

			// Token: 0x04000579 RID: 1401
			private string _InitialMessage;

			// Token: 0x0400057A RID: 1402
			private string _NoNeed;

			// Token: 0x0400057B RID: 1403
			private string _SaveFailed;

			// Token: 0x0400057C RID: 1404
			private string _SaveSucceed;
		}

		// Token: 0x020000AE RID: 174
		// (Invoke) Token: 0x06000E65 RID: 3685
		public delegate BaseUserControl.SaveStatus SaveRecordDelegate(BaseUserControl.PreSaveOperation op, object opParameter);

		// Token: 0x020000AF RID: 175
		public enum SaveStatus
		{
			// Token: 0x0400057E RID: 1406
			NoNeed,
			// Token: 0x0400057F RID: 1407
			SaveFailed = 2,
			// Token: 0x04000580 RID: 1408
			SaveSucceeded = 1,
			// Token: 0x04000581 RID: 1409
			WillRetry = 3
		}
	}
}
