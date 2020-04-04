# Feature thinking
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

- Version 2020.03.31.xx:
  - Added settings menu
  - Quicksettings can now be hidden
  - Cleaned Code
  - BugFix: Delete row now deletes correct row, even if columns have been sorted. For older versions where time didn't get added to a record but created new one instead: Deletes every record with same name.

- Version 2020.03.26
  - Adding a record previously done that day, will add minutes intead of creating a new record.
  - Statuslabels are now fading
  - Settings are saved every minute if one has changed, instead of a direct write to disk upon change
  - Added a joke

- Version 2020.03.25
  - Laatste field + enter = Add (Arne's request)

- Version 2020.03.25
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