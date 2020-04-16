# Feature thinking
- FIRST:
  - "Invalid handle bug bij debugging"

- Algemeen:
  - Logs doorgeven met ref, zoals bij theme
  - Logica van UI doorspelen naar andere plaatsen, zodat UI kleiner wordt en meer functie in andere classes komen waar dit hergebruikt kan worden

- Interessante features:
  - Selection datagrid: Minuten optellen en uren/vakjes weergeven voor in te vullen op hydra -> Zou heel gemakkelijk zijn

- Statistics
  - **Bug**: Background moet stoppen bij laatste chart bar
  - Feature: Moet geladen worden met background worker ofzoiets
  - **Bug**: Achtergrond chart bars veranderen als theme aangepast wordt achteraf
  - Bijhouden wat grootste aantal minuten zijn, getoond in chart. Maximum van elke progressbar instellen op iets hoger dan maximum. Zorgt voor een betere visualisatie van de tijd.


- **Bug: Some werkt dit soms niet** Headers datagrid moeten vetgedrukt worden
  - Denk zelfs dat elke cell styling heeft verloren

- **Bug:** When timer popup on desktop with multiple screens, only dropdownlist shows untill clicked, then full window is shown. Perhaps **This.invalidate()** can fix?

- Noob proofing:
  - Hours: "." is not accepted as "," but just ignored -> Depends on locale, can be the other way around
  - Spaces and other non visable signs are taking in the string (Time & projectcode)
  - Timer scrolls to much at once, clicking is fine


# Solved
New:
  - Fixed scrolling of statistics
  - Fixed persistent trayicon after application exit


- ~~Timer does not reset when clicking add, it only resets from popups, do you even want this though? Maybe seperate popup + visible on gui how long till next~~
- ~~when column is sorted wrong one is deleted~~
- ~~Project code gets added even though it's already there, when opening file again, there's only one entry per individual project code~~
- ~~Tabbing selects fields in wrong order~~
- ~~Crash: (Bug) Als geen log geladen, statistics date veranderen~~
