using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using FruitBox.My;

namespace FruitBox
{
	// Token: 0x020000BC RID: 188
	public class StickyManager : List<CtrlStickyNote>
	{
		// Token: 0x06000EE2 RID: 3810 RVA: 0x00005403 File Offset: 0x00003603
		[DebuggerNonUserCode]
		public StickyManager()
		{
		}

		// Token: 0x06000EE3 RID: 3811 RVA: 0x000AA320 File Offset: 0x000A8520
		public void DeleteAllStickies(Control parentControl, bool suspendAndResumeLayout)
		{
			CtrlStickyNote[] array = base.ToArray();
			checked
			{
				for (int i = 0; i < array.Length; i++)
				{
					CtrlStickyNote toDelete = array[i];
					this.DeleteSticky(toDelete, parentControl, suspendAndResumeLayout);
				}
			}
		}

		// Token: 0x06000EE4 RID: 3812 RVA: 0x0000540D File Offset: 0x0000360D
		public void DeleteSticky(CtrlStickyNote toDelete, Control parentControl)
		{
			this.DeleteSticky(toDelete, parentControl, true);
		}

		// Token: 0x06000EE5 RID: 3813 RVA: 0x000AA358 File Offset: 0x000A8558
		public void DeleteSticky(CtrlStickyNote toDelete, Control parentControl, bool suspendAndResumeLayout)
		{
			base.Remove(toDelete);
			if (suspendAndResumeLayout)
			{
				parentControl.SuspendLayout();
			}
			this.IsShowingStickies = true;
			parentControl.Controls.Remove(toDelete);
			toDelete.Dispose();
			if (suspendAndResumeLayout)
			{
				parentControl.ResumeLayout(false);
			}
		}

		// Token: 0x06000EE6 RID: 3814 RVA: 0x000AA3A8 File Offset: 0x000A85A8
		public void DisableAllStickies()
		{
			try
			{
				List<CtrlStickyNote>.Enumerator enumerator = this.GetEnumerator();
				while (enumerator.MoveNext())
				{
					CtrlStickyNote current = enumerator.Current;
					current.Enabled = false;
				}
			}
			finally
			{
				List<CtrlStickyNote>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
		}

		// Token: 0x06000EE7 RID: 3815 RVA: 0x000AA400 File Offset: 0x000A8600
		private void HideAllStickies()
		{
			try
			{
				List<CtrlStickyNote>.Enumerator enumerator = this.GetEnumerator();
				while (enumerator.MoveNext())
				{
					CtrlStickyNote current = enumerator.Current;
					current.Visible = false;
				}
			}
			finally
			{
				List<CtrlStickyNote>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			this.IsShowingStickies = false;
		}

		// Token: 0x06000EE8 RID: 3816 RVA: 0x000AA460 File Offset: 0x000A8660
		public CtrlStickyNote InsertSticky(Control parentControl)
		{
			bool arg_43_2 = true;
			Point location = new Point(10, checked(MyProject.Forms.Form_Main.Bar1.Height + MyProject.Forms.Form_Main.SuperTabStrip1.Height + 10));
			return this.InsertSticky(parentControl, arg_43_2, location, 0, 0, CtrlStickyNote.Colour.Yellow, "");
		}

		// Token: 0x06000EE9 RID: 3817 RVA: 0x000AA4BC File Offset: 0x000A86BC
		public CtrlStickyNote InsertSticky(Control parentControl, bool showSticky, Point location, int width, int height, CtrlStickyNote.Colour colour, string text)
		{
			CtrlStickyNote ctrlStickyNote = new CtrlStickyNote
			{
				Location = location,
				RightToLeft = RightToLeft.No
			};
			bool flag = width > 0;
			if (flag)
			{
				ctrlStickyNote.Width = width;
			}
			flag = (height > 0);
			if (flag)
			{
				ctrlStickyNote.Height = height;
			}
			ctrlStickyNote.CurrentColour = colour;
			ctrlStickyNote.Text = text;
			base.Add(ctrlStickyNote);
			if (showSticky)
			{
				parentControl.SuspendLayout();
			}
			parentControl.Controls.Add(ctrlStickyNote);
			parentControl.Controls.SetChildIndex(ctrlStickyNote, 0);
			if (showSticky)
			{
				ctrlStickyNote.Show();
				parentControl.ResumeLayout(false);
			}
			return ctrlStickyNote;
		}

		// Token: 0x06000EEA RID: 3818 RVA: 0x000AA564 File Offset: 0x000A8764
		private void ShowAllStickies()
		{
			try
			{
				List<CtrlStickyNote>.Enumerator enumerator = this.GetEnumerator();
				while (enumerator.MoveNext())
				{
					CtrlStickyNote current = enumerator.Current;
					bool flag = !current.IsDisposed;
					if (flag)
					{
						current.Visible = true;
					}
				}
			}
			finally
			{
				List<CtrlStickyNote>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			this.IsShowingStickies = true;
		}

		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x06000EEB RID: 3819 RVA: 0x000AA5D4 File Offset: 0x000A87D4
		// (set) Token: 0x06000EEC RID: 3820 RVA: 0x000AA5EC File Offset: 0x000A87EC
		public bool IsShowingStickies
		{
			get
			{
				return this._isShowingStickies;
			}
			set
			{
				bool flag = value != this.IsShowingStickies;
				if (flag)
				{
					if (value)
					{
						this.ShowAllStickies();
					}
					else
					{
						this.HideAllStickies();
					}
				}
			}
		}

		// Token: 0x040005C8 RID: 1480
		private bool _isShowingStickies;
	}
}
