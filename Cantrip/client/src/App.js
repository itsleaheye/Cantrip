import logo from './media/CantripLogoTransparent.png'
import './App.css';
import "./styles/globalTheme.css";
import "./styles/reset.css";

function App() {
  return (
    <div className="App">
      <img src={logo} class="home-logo" alt="Cantrip Magical Logo" />

      <div className="newCharacterForm">
        <div class="screenOne">
          <h1>New Character</h1>

          <label>Name: </label>
          <input placeholder="Character Name"></input>

          <label>Race: </label>
          <select id="raceList" onchange="raceListSelect()" >
            <option>Dragonborn</option>
            <option>Dwarf</option>
            <option>Elf</option>
            <option>Gnome</option>
            <option>Half-Elf</option>
            <option>Halfing</option>
            <option>Half-Orc</option>
            <option>Human</option>
            <option>Tiefling</option>
          </select>

          <label>Background: </label>
          <select id="backgroundList" onchange="backgroundListSelect()" >
            <option>Acolyte</option>
            <option>Charlatan</option>
            <option>Criminal or Spy</option>
            <option>Entertainer</option>
            <option>Folk Hero</option>
            <option>Gladiator</option>
            <option>Guild Artisan</option>
            <option>Hermit</option>
            <option>Knight</option>
            <option>Noble</option>
            <option>Outlander</option>
            <option>Pirate</option>
            <option>Sage</option>
            <option>Sailor</option>
            <option>Soldier</option>
            <option>Urchin</option>
          </select>

          <label>Class: </label>
          <input placeholder="Character Name"></input>

          <button type="submit" onClick="nextPage"><p>Next</p></button> 
          {/* With each button press, increase a int i.e. 1-3. This represents the character pages. When int = 1, hide other pages, otherwise etc. */}
        </div>

        <div class="screenOne">
          <h1>Abilities</h1>
          <div class="hr-bar">
            <h2>18</h2>
            <p>Points Remaining</p>
          </div>
          <div class="row">
            <button class="increase"></button>
            <label id="charismaVal" value="">1</label>
            <button class="decrease"></button>
          </div>

          <label>Name: </label>
          <input placeholder="Character Name"></input>

          <label>Race: </label>
          <select id="raceList" onchange="raceListSelect()" >
            <option>Dragonborn</option>
            <option>Dwarf</option>
            <option>Elf</option>
            <option>Gnome</option>
            <option>Half-Elf</option>
            <option>Halfing</option>
            <option>Half-Orc</option>
            <option>Human</option>
            <option>Tiefling</option>
          </select>

          <label>Background: </label>
          <select id="backgroundList" onchange="backgroundListSelect()" >
            <option>Acolyte</option>
            <option>Charlatan</option>
            <option>Criminal or Spy</option>
            <option>Entertainer</option>
            <option>Folk Hero</option>
            <option>Gladiator</option>
            <option>Guild Artisan</option>
            <option>Hermit</option>
            <option>Knight</option>
            <option>Noble</option>
            <option>Outlander</option>
            <option>Pirate</option>
            <option>Sage</option>
            <option>Sailor</option>
            <option>Soldier</option>
            <option>Urchin</option>
          </select>

          <label>Class: </label>
          <input placeholder="Character Name"></input>

          <button type="submit" onClick="nextPage"><p>Next</p></button> 
          {/* With each button press, increase a int i.e. 1-3. This represents the character pages. When int = 1, hide other pages, otherwise etc. */}
        </div>
      </div>

    </div>
  );
}

export default App;
