import { StyleSheet, Text, View } from "react-native";

export interface CharacterListItemProps {
  name: string;
  characterClass: string;
  image?: string;
  level?: string;
}

export default function CharacterListItem({
  name,
  characterClass,
  image,
  level,
}: CharacterListItemProps): JSX.Element {
  return (
    // To do: Add a click event to navigate to the character sheet
    // To do: Add a long press event to delete the character. Confirm with a modal
    <View style={styles.container}>
      <View style={styles.avatarContainer}>
        {/* To do: V1 will be static and have avatars displaying the characters initial class. Custom avatar uploading will be considered later */}
      </View>
      <View style={styles.details}>
        <Text style={styles.header}>{name}</Text>
        {/* To do: If multiple classes chose phrase it as i.e. "Wizard Cleric" with truncation if too many classes provided */}
        <View style={styles.row}>
          <Text style={styles.subtle}>{characterClass}</Text>
          {/* To do: This is a sum of all class levels */}
          <Text style={styles.subtle}>Lvl {level || 1}</Text>
        </View>
      </View>
    </View>
  );
}

const styles = StyleSheet.create({
  container: {
    display: "flex",
    alignItems: "center",
    flexDirection: "row",
    padding: 10,
    backgroundColor: "#2A2E37",
    borderRadius: 8,
    marginTop: 16,
    width: "100%",
    overflow: "hidden",
  },
  avatarContainer: {
    borderRadius: 100,
    backgroundColor: "#202328",
    height: 60,
    width: 60,
    overflow: "hidden",
    marginRight: 16,
  },
  details: {
    left: 0,
  },
  header: {
    fontSize: 16,
    fontWeight: "bold",
    color: "#fff",
    marginBottom: 4,
  },
  subtle: {
    fontSize: 16,
    color: "#82868E",
  },
  row: {
    paddingRight: 16,
    width: "88%",
    flexDirection: "row",
    justifyContent: "space-between",
  },
});
