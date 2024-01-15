import * as React from "react";
import { View, Text } from "react-native";
import { styles } from "../assets/styles";

export function CharacterView({
  navigation,
  route,
}: {
  navigation: any;
  route: any;
}) {
  const { character } = route.params; //Type cast
  return (
    <View style={{ flex: 1, alignItems: "center", justifyContent: "center" }}>
      <Text style={styles.cardTitle}>{character.name || "Character Name"}</Text>
    </View>
  );
}
