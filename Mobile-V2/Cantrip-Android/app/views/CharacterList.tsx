import CharacterListItem from "@/components/CharacterListItem/CharacterListItem";
import GradientButton from "@/components/GradientButton";
import React from "react";
import {
  SafeAreaView,
  ScrollView,
  StyleSheet,
  Touchable,
  TouchableOpacity,
  View,
} from "react-native";

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
    <SafeAreaView style={styles.safeAreaView}>
      <ScrollView style={styles.scrollView}>
        <View style={styles.container}>
          <View style={styles.list}>
            {characters.length >= 0 ? (
              // To do: Add these cards inside a lazy load scroll view
              characters.map((character: characterDetails) => {
                return (
                  <TouchableOpacity
                    // Update to navigate to Character details view
                    onPress={() => alert(`${character.name} Clicked`)}
                  >
                    <CharacterListItem
                      name={character.name}
                      characterClass={character.characterClass}
                      level={character.level}
                    />
                  </TouchableOpacity>
                );
              })
            ) : (
              <p>
                No characters found! Start a new adventure by creating a new
                character below
              </p>
            )}
          </View>
        </View>
      </ScrollView>
      <View style={styles.footer}>
        <GradientButton
          title="New Character"
          onPress={() => alert("New Character Pressed")}
        />
        {/* To do: Add button click event to navigate to "/newcharacter" */}
      </View>
    </SafeAreaView>
  );
}

// Make a global style sheet asset file and import it there
const styles = StyleSheet.create({
  safeAreaView: {
    height: "100%",
  },
  scrollView: {
    backgroundColor: "#202328",
  },
  container: {
    height: "100%",
    width: "100%",
    display: "flex",
    flexDirection: "column",
    padding: 16,
    paddingTop: 75,
  },
  list: {
    height: "90%",
  },
  footer: {
    backgroundColor: "#202328",
    padding: 16,
    bottom: 0,
  },
});
