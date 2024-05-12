import { StyleSheet } from "react-native";

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
    <div style={styles.container}>
      <div style={styles.avatarContainer}>
        {/* To do: V1 will be static and have avatars displaying the characters initial class. Custom avatar uploading will be considered later */}
      </div>
      <div style={styles.details}>
        <div style={styles.header}>
          <h4>{name}</h4>
        </div>
        <div style={styles.subtle}>
          {/* To do: If multiple classes chose phrase it as i.e. "Wizard Cleric" with truncation if too many classes provided */}
          <p>{characterClass}</p>
          {/* To do: This is a sum of all class levels */}
          <p>Lvl {level || 1}</p>
        </div>
      </div>
    </div>
  );
}

const styles = StyleSheet.create({
  container: {
    display: "flex",
    alignItems: "flex-start",
    flexDirection: "row",
    justifyContent: "space-between",
    padding: 8,
    backgroundColor: "#2a2e37",
    borderRadius: 8,
  },
  avatarContainer: {
    borderRadius: 100,
    backgroundColor: "#202328",
    height: 50,
    width: 50,
    overflow: "hidden",
  },
  details: {
    flexDirection: "column",
  },
  header: {
    fontWeight: "bold",
    color: "#fff",
  },
  subtle: {
    color: "82868E",
  },
});
