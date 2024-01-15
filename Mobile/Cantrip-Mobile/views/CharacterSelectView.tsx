import * as React from "react";
import { View, Text, Alert, FlatList, Pressable } from "react-native";
import { styles } from "../assets/styles";
import { LinearGradient } from "expo-linear-gradient";
import CharacterListCard from "../components/CharacterListCard";
import { getCharacterList } from "../hooks/characterServices";

export function CharacterSelectView({ navigation }: { navigation: any }) {
  const characterList = getCharacterList();
  const hasCharacters = characterList.length > 0;
  return (
    <View style={{ flex: 1, alignItems: "center", justifyContent: "center" }}>
      {hasCharacters && (
        <FlatList
          data={characterList}
          keyExtractor={(character) => character.id}
          renderItem={({ item }) => (
            <CharacterListCard name={item.name} id={item.id} />
          )}
        />
      )}
      <Pressable
        style={styles.primaryButton}
        onPress={() => {
          Alert.alert("New Character pressed");
          navigation.navigate("CharacterCreateView");
        }}
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
