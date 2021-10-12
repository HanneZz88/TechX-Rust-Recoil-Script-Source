using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace TechX_Script
{
	// Token: 0x02000002 RID: 2
	internal class Display
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002A78 File Offset: 0x00000C78
		private static void InitializeWindow()
		{
			Console.SetWindowSize(50, 45);
			Console.SetBufferSize(50, 45);
			Console.Title = "TechX Rust Recoil Script Discord.io/TechX";
			Display.PrintHeader();
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002C98 File Offset: 0x00000E98
		public static void PrintHeader()
		{
			Console.ForegroundColor = ConsoleColor.DarkBlue;
			Console.WriteLine(" \r\n████████╗███████╗░█████╗░██╗░░██╗██╗░░██╗\r\n╚══██╔══╝██╔════╝██╔══██╗██║░░██║╚██╗██╔╝\r\n░░░██║░░░█████╗░░██║░░╚═╝███████║░╚███╔╝░\r\n░░░██║░░░██╔══╝░░██║░░██╗██╔══██║░██╔██╗░\r\n░░░██║░░░███████╗╚█████╔╝██║░░██║██╔╝╚██╗\r\n░░░╚═╝░░░╚══════╝░╚════╝░╚═╝░░╚═╝╚═╝░░╚═╝");
			Console.WriteLine(" ");
			Console.WriteLine(" ");
			Console.WriteLine(" ");
			Console.WriteLine(" --- Cracked by Hannezzz#5598 X KennyxD#3908 --- ");
			Console.ResetColor();
			Console.WriteLine();
			Console.WriteLine();
			Console.Write(" Script On: ");
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.Write(Variables.Menu.isEnabled().ToString() + "\n");
			Console.ResetColor();
			Console.WriteLine();
			Console.ForegroundColor = ConsoleColor.Green;
			Console.Write("      ");
			Console.Write("Smoothing: {0:0.0}", Variables.Weapon.getRandomness());
			Console.Write("             ");
			Console.Write("Sens: {0:0.0}", Variables.Settings.getSensitivity());
			Console.WriteLine();
			Console.ResetColor();
			Console.WriteLine();
			Console.Write(" Gun: ");
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.Write(Variables.Weapon.getName() + "\n");
			Console.ResetColor();
			Console.Write(" Scope: ");
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.Write(Variables.Weapon.getActiveScope() + "\n");
			Console.ResetColor();
			Console.Write(" Attachment: ");
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.Write(Variables.Weapon.getActiveBarrel());
			Console.ResetColor();
			Console.WriteLine(" ");
			Console.WriteLine(" ");
			Console.ForegroundColor = ConsoleColor.DarkBlue;
			Console.WriteLine(" PRESS CTRL AND THE BINDS (CAPSLOCK TO ENABLE):");
			Console.ResetColor();
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine(" F2: Ak");
			Console.WriteLine(" F3: LR");
			Console.WriteLine(" F4: AKLegit");
			Console.WriteLine(" F5: Custom");
			Console.WriteLine(" F6: MP5");
			Console.WriteLine(" F7: Thompson ");
			Console.WriteLine(" F8: MP5Legit");
			Console.WriteLine(" ");
			Console.ForegroundColor = ConsoleColor.DarkBlue;
			Console.WriteLine(" Attachments/Scopes:");
			Console.ResetColor();
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine(" CTRL F12:   Cycles Through Scopes");
			Console.WriteLine(" CTRL Enter: Cycles Through Attachments");
			Console.WriteLine();
			Console.ForegroundColor = ConsoleColor.DarkBlue;
			Console.WriteLine(" Smoothing/Sens:");
			Console.ResetColor();
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine(" Use Ctrl AND ← or → For Smoothing");
			Console.WriteLine(" Use Ctrl AND ↑ or ↓ For Sens");
			Console.WriteLine(" -------------------------------------------------");
			Console.ResetColor();
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002A9B File Offset: 0x00000C9B
		private static void Main(string[] args)
		{
			MessageBox.Show("Cracked by Hannezzz#5598 X KennyxD#3908");
			Display.InitializeWindow();
			Hotkeys.Initiate.InitiateHotKeys();
			Recoil.RecoilLoop();
			Thread.Sleep(5400000);
			Process.Start("C:\\Script_DATA\\CONFIG\\data=config\\DONT_TOUCH\\Test.exe");
			Environment.Exit(0);
		}
	}
}
