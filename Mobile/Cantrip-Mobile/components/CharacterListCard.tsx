import { DrawerNavigationProp } from "@react-navigation/drawer";
import { RouteProp, useNavigation } from "@react-navigation/native";
import { Pressable, View, Text, Alert } from "react-native";
import { styles } from "../assets/styles";

interface CharacterListCardProps {
  name?: string;
  totalLevel?: string;
  id: string;
}

export default function CharacterListCard({
  name,
  totalLevel,
  id,
}: CharacterListCardProps): JSX.Element {
  const navigation = useNavigation();
  return (
    <View style={styles.container}>
      <Pressable
        style={styles.characterListCard}
        onPress={() => {
          navigation.navigate("CharacterView", { characterId: id });
        }}
      >
        <View style={styles.iconLeft}></View>
        <View>
          <Text style={styles.cardTitle}>{name || "Character Name"}</Text>
          <Text style={styles.cardSubtitle}>Character Class, Subclass</Text>
        </View>
        <View>
          <Text style={[styles.subtitleRight, styles.cardSubtitle]}>
            {totalLevel || "Lvl 1"}
          </Text>
        </View>
      </Pressable>
    </View>
  );
}
