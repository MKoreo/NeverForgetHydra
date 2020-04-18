# Feature thinking
- Algemeen:
  - Logica van UI doorspelen naar andere plaatsen, zodat UI kleiner wordt en meer functie in andere classes komen waar dit hergebruikt kan worden

- Noob proofing:
  - Hours: "." is not accepted as "," but just ignored -> Depends on locale, can be the other way around
  - Spaces and other non visable signs are taking in the string (Time & projectcode)
  - Timer scrolls to much at once, clicking is fine

**Attempted fix in place**
- **Bug:**  When timer popup on desktop with multiple screens, only dropdownlist shows untill clicked, then full window is shown. Perhaps **This.invalidate()** can fix?
  
# Solved
New:
- Bugfixes:
  - Fixed scrolling of statistics
  - Fixed persistent trayicon after application exit
  - Fixed background of chart bars changing
  - Fixed datagrid theming
  - Attempt: Fix only dropdown shows when popup on secondary monitor
  - Fixed memory issues with worklog
  - 
- Features:
  - Selecting multiple minute cells produces status update containing sum 
  - Spread chart view over available width 
  - Changed chart text color
  - Asynchronous loading of statistics
  - Optimized memory usage of statistics
  - Statistics now given in hours and minutes
  - Statistics colors changed


- ~~Timer does not reset when clicking add, it only resets from popups, do you even want this though? Maybe seperate popup + visible on gui how long till next~~
- ~~when column is sorted wrong one is deleted~~
- ~~Project code gets added even though it's already there, when opening file again, there's only one entry per individual project code~~
- ~~Tabbing selects fields in wrong order~~
- ~~Crash: (Bug) Als geen log geladen, statistics date veranderen~~
