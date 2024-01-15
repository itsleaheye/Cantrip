import { useState } from "react";
import * as SQLite from "expo-sqlite";
import { Character } from "../components/types";

const newCharacter1: Character = {
  id: "0",
  name: "Test Character Name",
  armor: 0,
  armorClass: "Light",
  background: {
    id: "backgroundName",
    details: "Background details",
    languageExtraSlots: 0,
  },
  class: [],
  equippedWeapons: [],
  hitDice: 0,
  hitPoints: 0,
  initiative: 0,
  inventory: undefined,
  languages: {
    known: ["Common"],
    slots: 1,
  },
  totalLevel: 1,
  proficiencyBonus: 0,
  proficiencies: {
    armor: [],
    weapons: [],
    tools: [],
  },
  race: {
    id: "raceName",
    details: "Race details",
    languages: ["Common", "other languages"],
  },
  speed: 0,
  spellAttack: 0,
  spellDC: 0,
  spells: [],
  stats: {
    strength: 0,
    constitution: 0,
    dexterity: 0,
    intelligence: 0,
    wisdom: 0,
    charisma: 0,
  },
};

//medium.com/@julien-ctx/integrating-sqlite-with-react-native-a-beginners-tutorial-a74bbe34ac6a
const [characterList, setCharacterList] = useState([newCharacter1]);
const db = SQLite.openDatabase("cantrip.db");

export function getCharacterList() {
  // db.transaction((tx) => {
  //   tx.executeSql("select * from Characters", [], (_, { rows }) =>
  //     console.log("the number of Character row are", JSON.stringify(rows))
  //   );
  // });
  return characterList;
}

export function addCharacter(character: Character) {
  // db.transaction((tx) => {
  //   tx.executeSql(createCharacterQuery, []);
  // });
  characterList.push(character);
  setCharacterList((previousList) => [...previousList, character]);

  console.log("[!] Character added ", character.name);
}

export function removeCharacter(character: Character) {
  const index = characterList.indexOf(character);
  characterList.splice(index, 1);

  console.log("[!] Character removed ", character.name);
}

export function updateCharacter(character: Character) {
  const index = characterList.indexOf(character);
  characterList[index] = character;

  console.log("[!] Character updated ", character.name);
}

// [!] Reference | https://github.com/expo/examples/blob/master/with-sqlite/App.js
