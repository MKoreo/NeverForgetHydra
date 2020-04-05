# Feature thinking

"System.FormatException Input string was not in a correct format. at System.Number.StringToNumber(String str, NumberStyles options, NumberBuffer number, NumberFormatInfo info, Boolean parseDecimal) at System.Number.ParseDecimal(String value, NumberStyles options, NumberFormatInfo numfmt) at System.Convert.ToDecimal(String value) at SPIF.FormMain.buttonAdd_Click(Object sender, EventArgs e) in D \\Barco\\OneDrive\\OneDrive Barco N.V\\_Programming\\NeverForgetHydra\\SPIF\\MainWindow.cs line 468 at System.Windows.Forms.Control.OnClick(EventArgs e) at System.Windows.Forms.Button.OnClick(EventArgs e) at System.Windows.Forms.Button.OnMouseUp(MouseEventArgs mevent) at System.Windows.Forms.Control.WmMouseUp(Message m, MouseButtons button, Int32 clicks) at System.Windows.Forms.Control.WndProc(Message m) at System.Windows.Forms.ButtonBase.WndProc(Message m) at System.Windows.Forms.Button.WndProc(Message m) at System.Windows.Forms.Control.ControlNativeWindow.OnMessage(Message m) at System.Windows.Forms.Control.ControlNativeWindow.WndProc(Message m) at System.Windows.Forms.NativeWindow.DebuggableCallback(IntPtr hWnd, Int32 msg, IntPtr wparam, IntPtr lparam) at System.Windows.Forms.UnsafeNativeMethods.DispatchMessageW(MSG msg) at System.Windows.Forms.Application.ComponentManager.System.Windows.Forms.UnsafeNativeMethods.IMsoComponentManager.FPushMessageLoop(IntPtr dwComponentID, Int32 reason, Int32 pvLoopData) at System.Windows.Forms.Application.ThreadContext.RunMessageLoopInner(Int32 reason, ApplicationContext context) at System.Windows.Forms.Application.ThreadContext.RunMessageLoop(Int32 reason, ApplicationContext context) at System.Windows.Forms.Application.Run(Form mainForm) at SPSTRT.StartApplication.Start() in D \\Barco\\OneDrive\\OneDrive Barco N.V\\_Programming\\NeverForgetHydra\\SPSTRT\\StartApplication.cs line 29 at NeverForgetHydra.Start.Main() in D \\Barco\\OneDrive\\OneDrive Barco N.V\\_Programming\\NeverForgetHydra\\NeverForgetHydra\\Start.cs line 27"

* Version xxx
- Fixed init state of quicksettingspanel
- Fixed menucolors (new renderer)
- Fixed feedback form
- 

* Version 2020.04.04.25373
- Added changelog form
- Added code to GIT

* Version 2020.04.02.0
- Fixed Antivirus false positives
- Fixed bugs in update class
- New changelog
- BugFix: Quicksetting filteronCombo now changes state

* Version: 2020.04.01.0
- Added settings menu
- Quicksettings can now be hidden
- Cleaned Code
- BugFix: Delete row now deletes correct row, even if columns have been sorted. For older versions where time didn't get added to a record but created new one instead: Deletes every record with same name.

* Version 2020.03.31.xx:
  - Added settings menu
  - Quicksettings can now be hidden
  - Cleaned Code
  - BugFix: Delete row now deletes correct row, even if columns have been sorted. For older versions where time didn't get added to a record but created new one instead: Deletes every record with same name.

* Version 2020.03.26
  - Adding a record previously done that day, will add minutes intead of creating a new record.
  - Statuslabels are now fading
  - Settings are saved every minute if one has changed, instead of a direct write to disk upon change
  - Added a joke

* Version 2020.03.25
  - Laatste field + enter = Add (Arne's request)

* Version 2020.03.25
  - Titel now displays current file
  - Barco logo removed
  - Table forecolor text white when black theme
  - Checkbox add to startup
  - Bug: when popup by timer, time passed field is 0, when double click it's correct

# Bugs
Short Term to be fixed:
- Als popup, maar geen add, blijft time passed op 30 minuten staan ofzoiets. Moet doortellen en tot je op add klikt gereset worden
- Dark theme status fade, text fade veel minder dan achtergrond

Long term to be fixed:
- Hours: "." is not accepted as "," but just ignored -> Depends on locale, can be the other way around
- Spaces and other non visable signs are taking in the string (Time & projectcode)
- Timer scrolls to much at once
- Timer does not reset when clicking add, it only resets from popups, do you even want this though? Maybe seperate popup + visible on gui how long till next
- When timer popup on desktop with multiple screens, only dropdownlist shows untill clicked, then full window is shown. Perhaps This.invalidate() can fix?

- ~~when column is sorted wrong one is deleted~~
- ~~Project code gets added even though it's already there, when opening file again, there's only one entry per individual project code~~
- ~~Tabbing selects fields in wrong order~~