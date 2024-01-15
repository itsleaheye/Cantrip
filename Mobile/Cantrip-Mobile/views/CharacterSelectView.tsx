import * as React from "react";
import { View, Text, Alert, FlatList, Pressable } from "react-native";
import { styles } from "../assets/styles";
import { Character } from "../components/types";
import { LinearGradient } from "expo-linear-gradient";
import CharacterListCard from "../components/CharacterListCard";

export function CharacterSelectView({ navigation }: { navigation: any }) {
  //https://docs.expo.dev/versions/latest/sdk/sqlite/ | Android Expo SQLite

  // Placeholder for localStorage character list
  const newCharacter: Character = {
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

  return (
    <View style={{ flex: 1, alignItems: "center", justifyContent: "center" }}>
      newCharacter && (
      <FlatList
        data={[newCharacter]}
        keyExtractor={(character) => character.id}
        renderItem={({ item }) => (
          <CharacterListCard name={item.name} id={item.id} />
        )}
      />
      )
      <Pressable
        style={styles.primaryButton}
        onPress={() => Alert.alert("New Character pressed")}
      >
        <LinearGradient
          colors={["#22c1c3", "#4d9ece"]}
          start={{ x: 0, y: 0 }}
          end={{ x: 1, y: 0 }}
          style={styles.primaryButton}
        >
          <Text style={styles.primaryButtonText}>New Character</Text>
        </LinearGradient>
      </Pressable>
    </View>
  );
}
