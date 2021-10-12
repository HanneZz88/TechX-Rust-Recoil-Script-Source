using System;
using System.Diagnostics;
using System.Speech.Synthesis;
using System.Threading;
using System.Windows.Forms;

namespace TechX_Script
{
	// Token: 0x02000004 RID: 4
	internal class Hotkeys
	{
		// Token: 0x14000001 RID: 1
		// (add) Token: 0x0600000B RID: 11 RVA: 0x00002EE0 File Offset: 0x000010E0
		// (remove) Token: 0x0600000C RID: 12 RVA: 0x00002F14 File Offset: 0x00001114
	
		private static event EventHandler<Hotkeys.HotKeyEventArgs> HotKeyPressed;

		// Token: 0x0600000D RID: 13 RVA: 0x00002F48 File Offset: 0x00001148
		static Hotkeys()
		{
			new Thread(delegate()
			{
				Application.Run(new Hotkeys.MessageWindow());
			})
			{
				Name = "HotKeyMessageThread",
				IsBackground = true
			}.Start();
		}

		// Token: 0x04000001 RID: 1
		private static volatile Hotkeys.MessageWindow _wnd;

		// Token: 0x04000002 RID: 2
		private static volatile IntPtr _hwnd;

		// Token: 0x04000003 RID: 3
		private static ManualResetEvent _windowReadyEvent = new ManualResetEvent(false);

		// Token: 0x02000005 RID: 5
		private class MessageWindow : Form
		{
			// Token: 0x0600000F RID: 15 RVA: 0x00002AE3 File Offset: 0x00000CE3
			public MessageWindow()
			{
				Hotkeys._wnd = this;
				Hotkeys._hwnd = base.Handle;
				Hotkeys._windowReadyEvent.Set();
			}

			// Token: 0x06000010 RID: 16 RVA: 0x00002F94 File Offset: 0x00001194
			protected override void WndProc(ref Message m)
			{
				bool flag = m.Msg == 786;
				if (flag)
				{
					Hotkeys.HotKeyEventArgs e = new Hotkeys.HotKeyEventArgs(m.LParam);
					Hotkeys.Hotkey.OnHotKeyPressed(e);
				}
				base.WndProc(ref m);
			}

			// Token: 0x06000011 RID: 17 RVA: 0x00002B0D File Offset: 0x00000D0D
			protected override void SetVisibleCore(bool value)
			{
				base.SetVisibleCore(false);
			}

			// Token: 0x04000005 RID: 5
			private const int WM_HOTKEY = 786;
		}

		// Token: 0x02000006 RID: 6
		[Flags]
		public enum KeyModifiers
		{
			// Token: 0x04000007 RID: 7
			Control = 2
		}

		// Token: 0x02000007 RID: 7
		public class HotKeyEventArgs : EventArgs
		{
			// Token: 0x06000012 RID: 18 RVA: 0x00002FD0 File Offset: 0x000011D0
			public HotKeyEventArgs(IntPtr hotKeyParam)
			{
				uint num = (uint)hotKeyParam.ToInt64();
				this.Key = (Keys)((num & 4294901760U) >> 16);
				this.Modifiers = (Hotkeys.KeyModifiers)(num & 65535U);
			}

			// Token: 0x04000008 RID: 8
			public readonly Keys Key;

			// Token: 0x04000009 RID: 9
			public readonly Hotkeys.KeyModifiers Modifiers;
		}

		// Token: 0x02000008 RID: 8
		public class Initiate
		{
			// Token: 0x06000013 RID: 19 RVA: 0x0000300C File Offset: 0x0000120C
			public static int RegisterHotKey(Keys key, Hotkeys.KeyModifiers modifiers)
			{
				Hotkeys._windowReadyEvent.WaitOne();
				int num = Interlocked.Increment(ref Hotkeys.Initiate._id);
				Hotkeys._wnd.Invoke(new Hotkeys.Initiate.RegisterHotKeyDelegate(Hotkeys.Initiate.RegisterHotKeyInternal), new object[]
				{
					Hotkeys._hwnd,
					num,
					(uint)modifiers,
					(uint)key
				});
				return num;
			}

			// Token: 0x06000014 RID: 20 RVA: 0x00002B18 File Offset: 0x00000D18
			private static void RegisterHotKeyInternal(IntPtr hwnd, int id, uint modifiers, uint key)
			{
				DLLImports.RegisterHotKey(hwnd, id, modifiers, key);
			}

			// Token: 0x06000015 RID: 21 RVA: 0x00003080 File Offset: 0x00001280
			public static void InitiateHotKeys()
			{
				Hotkeys.Initiate.RegisterHotKey(Keys.Capital, Hotkeys.KeyModifiers.Control);
				Hotkeys.Initiate.RegisterHotKey(Keys.F2, Hotkeys.KeyModifiers.Control);
				Hotkeys.Initiate.RegisterHotKey(Keys.F3, Hotkeys.KeyModifiers.Control);
				Hotkeys.Initiate.RegisterHotKey(Keys.F4, Hotkeys.KeyModifiers.Control);
				Hotkeys.Initiate.RegisterHotKey(Keys.F8, Hotkeys.KeyModifiers.Control);
				Hotkeys.Initiate.RegisterHotKey(Keys.F5, Hotkeys.KeyModifiers.Control);
				Hotkeys.Initiate.RegisterHotKey(Keys.F6, Hotkeys.KeyModifiers.Control);
				Hotkeys.Initiate.RegisterHotKey(Keys.F7, Hotkeys.KeyModifiers.Control);
				Hotkeys.Initiate.RegisterHotKey(Keys.Left, Hotkeys.KeyModifiers.Control);
				Hotkeys.Initiate.RegisterHotKey(Keys.Right, Hotkeys.KeyModifiers.Control);
				Hotkeys.Initiate.RegisterHotKey(Keys.Up, Hotkeys.KeyModifiers.Control);
				Hotkeys.Initiate.RegisterHotKey(Keys.Down, Hotkeys.KeyModifiers.Control);
				Hotkeys.Initiate.RegisterHotKey(Keys.F12, Hotkeys.KeyModifiers.Control);
				Hotkeys.Initiate.RegisterHotKey(Keys.Return, Hotkeys.KeyModifiers.Control);
				Hotkeys.HotKeyPressed += Hotkeys.Hotkey.HotKeys_HotKeyPressed;
			}

			// Token: 0x0400000A RID: 10
			private static int _id;

			// Token: 0x02000009 RID: 9
			// (Invoke) Token: 0x06000018 RID: 24
			private delegate void RegisterHotKeyDelegate(IntPtr hwnd, int id, uint modifiers, uint key);
		}

		// Token: 0x0200000A RID: 10
		public class Hotkey
		{
			// Token: 0x0600001B RID: 27 RVA: 0x00002B25 File Offset: 0x00000D25
			public static void OnHotKeyPressed(Hotkeys.HotKeyEventArgs e)
			{
				EventHandler<Hotkeys.HotKeyEventArgs> hotKeyPressed = Hotkeys.HotKeyPressed;
				if (hotKeyPressed != null)
				{
					hotKeyPressed(null, e);
				}
			}

			// Token: 0x0600001C RID: 28 RVA: 0x00003120 File Offset: 0x00001320
			public static void HotKeys_HotKeyPressed(object sender, Hotkeys.HotKeyEventArgs e)
			{
				Keys key = e.Key;
				Keys keys = key;
				if (keys <= Keys.Capital)
				{
					if (keys != Keys.Return)
					{
						if (keys == Keys.Capital)
						{
							Variables.Menu.setEnabled(!Variables.Menu.isEnabled());
							SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();
							speechSynthesizer.Speak("Script Toggled");
						}
					}
					else
					{
						Console.Beep(466, 125);
						Variables.Weapon.barrelIndex++;
						Variables.Weapon.changeBarrel();
					}
				}
				else
				{
					switch (keys)
					{
					case Keys.Left:
						Console.Beep(466, 125);
						Variables.Weapon.setRandomness(-1);
						break;
					case Keys.Up:
						Console.Beep(466, 125);
						Variables.Settings.setSensitivity(1);
						break;
					case Keys.Right:
						Console.Beep(466, 125);
						Variables.Weapon.setRandomness(1);
						break;
					case Keys.Down:
						Console.Beep(466, 125);
						Variables.Settings.setSensitivity(-1);
						break;
					default:
						switch (keys)
						{
						case Keys.F2:
						{
							Weapons.setVariables(1);
							SpeechSynthesizer speechSynthesizer2 = new SpeechSynthesizer();
							speechSynthesizer2.Speak("AK");
							break;
						}
						case Keys.F3:
						{
							Weapons.setVariables(2);
							SpeechSynthesizer speechSynthesizer3 = new SpeechSynthesizer();
							speechSynthesizer3.Speak("LR");
							break;
						}
						case Keys.F4:
						{
							Weapons.setVariables(7);
							SpeechSynthesizer speechSynthesizer4 = new SpeechSynthesizer();
							speechSynthesizer4.Speak("AK Legit");
							break;
						}
						case Keys.F5:
						{
							Weapons.setVariables(4);
							SpeechSynthesizer speechSynthesizer5 = new SpeechSynthesizer();
							speechSynthesizer5.Speak("CUSTOM");
							break;
						}
						case Keys.F6:
						{
							Weapons.setVariables(5);
							SpeechSynthesizer speechSynthesizer6 = new SpeechSynthesizer();
							speechSynthesizer6.Speak("MP5");
							break;
						}
						case Keys.F7:
						{
							Weapons.setVariables(6);
							SpeechSynthesizer speechSynthesizer7 = new SpeechSynthesizer();
							speechSynthesizer7.Speak("TOMMY");
							break;
						}
						case Keys.F8:
						{
							Weapons.setVariables(8);
							SpeechSynthesizer speechSynthesizer8 = new SpeechSynthesizer();
							speechSynthesizer8.Speak("MP5 Legit");
							break;
						}
						case Keys.F12:
							Console.Beep(466, 125);
							Variables.Weapon.scopeIndex++;
							Variables.Weapon.changeScope();
							break;
						}
						break;
					}
				}
				Console.Clear();
				Display.PrintHeader();
			}
		}
	}
}
