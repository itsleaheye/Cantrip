import * as SQLite from "expo-sqlite";
import CharacterListItem from "@/components/CharacterListItem/CharacterListItem";
import GradientButton from "@/components/GradientButton";
import React from "react";
import {
  SafeAreaView,
  ScrollView,
  StyleSheet,
  TouchableOpacity,
  View,
} from "react-native";
import { initializeDatabase } from "@/db/CantripDatabase";
import { placeHolderCharacters } from "@/types/placeholderCharacters";

interface characterDetails {
  id: number;
  name: string;
  characterClass: string;
  image?: string;
  level?: string;
}

export default function CharacterList() {
  const db = initializeDatabase();
  // To do: Create a external hook to fetch existing characters from a SQLite database
  const characters = placeHolderCharacters as characterDetails[];

  // This freezes the app
  // const [characters, setCharacters] = useState([] as characterDetails[]);
  // useEffect(() => {
  //   const fetchedCharacters = getCharacters(db) as characterDetails[];
  //   setCharacters(fetchedCharacters);
  // }, [db]);

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
                    key={character.id}
                    onPress={() => {
                      handlePress(character.name, character.id);
                    }}
                    onLongPress={() => {
                      handleLongPress(character.name);
                    }}
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
          onPress={() => {
            handleNewCharacter();
          }}
        />
        {/* To do: Add button click event to navigate to "/newcharacter" */}
      </View>
    </SafeAreaView>
  );
}

function getCharacters(db: SQLite.SQLiteDatabase) {
  return db.getAllSync("SELECT * FROM charactersTest");
}

function insertPlaceholderCharacter(db: SQLite.SQLiteDatabase) {
  db.withTransactionSync(async () => {
    await db.execSync(
      `INSERT INTO charactersTest (name, characterClass, level) VALUES ('Test Character2', 'Warrior', 1)`
    );
  });
}

function handleLongPress(characterName: string) {
  // To do: Add a modal to delete the character
  alert(`Are you sure you want to delete ${characterName}?`);
}

function handlePress(characterName: string, characterId: number) {
  // To do: Add a navigation event to the character details view
  alert(`Loading ${characterName}'s journal...`);
}

function handleNewCharacter() {
  // To do: Add a navigation event to the new character view
  alert("Creating a new character...");
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
    paddingTop: 0,
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
