using System;
using System.Runtime.InteropServices;

namespace TechX_Script
{
	// Token: 0x02000003 RID: 3
	internal class DLLImports
	{
		// Token: 0x06000005 RID: 5
		[DllImport("user32.dll")]
		public static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

		// Token: 0x06000006 RID: 6
		[DllImport("user32.dll")]
		public static extern short GetAsyncKeyState(int vKey);

		// Token: 0x06000007 RID: 7
		[DllImport("Kernel32.dll")]
		public static extern bool QueryPerformanceCounter(out long lpPerformanceCount);

		// Token: 0x06000008 RID: 8
		[DllImport("Kernel32.dll")]
		public static extern bool QueryPerformanceFrequency(out long lpFrequency);

		// Token: 0x06000009 RID: 9
		[DllImport("user32.dll")]
		public static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);
	}
}
