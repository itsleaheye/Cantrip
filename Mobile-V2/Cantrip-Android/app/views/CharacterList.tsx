import CharacterListItem from "@/components/CharacterListItem/CharacterListItem";
import React from "react";
import { Button, StyleSheet } from "react-native";

const placeHolderCharacters = [
  {
    name: "Lyra Quakestrider",
    characterClass: "Warrior",
    level: "1",
  },
  {
    name: "Kael Leif",
    characterClass: "Mage",
    level: "2",
  },
  {
    name: "Raine Barrel",
    characterClass: "Rogue",
    level: "1",
  },
];

interface characterDetails {
  name: string;
  characterClass: string;
  image?: string;
  level?: string;
}

export default function CharacterList() {
  // To do: Create a hook to fetch existing characters from a SQLite database
  const characters = placeHolderCharacters;
  return (
    <div style={styles.container}>
      <div style={styles.list}>
        {characters.length >= 0 ? (
          // To do: Add these cards inside a lazy load scroll view
          characters.map((character: characterDetails) => {
            return (
              <CharacterListItem
                name={character.name}
                characterClass={character.characterClass}
                level={character.level}
              />
            );
          })
        ) : (
          <p>
            No characters found! Start a new adventure by creating a new
            character below
          </p>
        )}
      </div>
      <div style={styles.footer}>
        <Button title="New Character" onPress={() => {}} />
        {/* To do: Add button click event to navigate to "/newcharacter" */}
        {/* To Do: Add button LinearGradient styling */}
      </div>
    </div>
  );
}

// Make a global style sheet asset file and import it there
const styles = StyleSheet.create({
  container: {
    height: "100%",
    width: "100%",
    display: "flex",
    flexDirection: "column",
    padding: 16,
    backgroundColor: "#2A2E37",
  },
  list: {
    height: "90%",
  },
  footer: {
    bottom: 0,
    height: "10%",
    justifyContent: "center",
    alignItems: "center",
  },
});
