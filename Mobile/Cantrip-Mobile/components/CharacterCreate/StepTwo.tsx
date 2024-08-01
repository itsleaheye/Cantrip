import { LinearGradient } from "expo-linear-gradient";
import { TextInput, Pressable, Alert, Text, View } from "react-native";
import { styles } from "../../assets/styles";
import { useState } from "react";

export function StepTwo() {
  const [abilityPoints, setAbilityPoints] = useState(18);
  const [charisma, setCharisma] = useState(8);
  const [constitution, setConstitution] = useState(8);
  const [dexterity, setDexterity] = useState(8);
  const [intelligence, setIntelligence] = useState(8);
  const [strength, setStrength] = useState(8);
  const [wisdom, setWisdom] = useState(8);

  return (
    <View>
      <div style={styles.grayBanner}>
        <Text>{abilityPoints}</Text>
        <Text>Points Remaining</Text>
      </div>
      <div>
        <Pressable
          style={styles.primaryButton}
          onPress={() => {
            Alert.alert("[!] Roll Points pressed");
          }}
          disabled={true} // [!] Disabled in Alpha
        >
          <Text>Roll Points</Text>
        </Pressable>
        <Pressable
          style={styles.primaryButton}
          onPress={() => {
            Alert.alert("[!] Buy Points pressed");
          }} // [!] Disabled in Alpha
        >
          <Text>Roll Points</Text>
        </Pressable>
      </div>
      <div style={styles.abilityRow}>
        <Text>Charisma</Text>
        <div style={styles.abilityModifier}>
          <Pressable
            style={styles.stepper}
            onPress={() => {
              setAbilityPoints(abilityPoints - 1);
              setCharisma(charisma + 1); //[!] Look into 13, 14 costing 2 points instead of 1
            }}
            disabled={abilityPoints === 0 || charisma === 15}
          >
            <Text>+</Text>
          </Pressable>
          <Text>{charisma}</Text>
          <Pressable
            style={styles.stepper}
            onPress={() => {
              setAbilityPoints(abilityPoints + 1);
              setCharisma(charisma - 1);
            }}
            disabled={charisma === 8}
          >
            <Text>-</Text>
          </Pressable>
        </div>
      </div>
      <div style={styles.abilityRow}>
        <Text>Constitution</Text>
        <div style={styles.abilityModifier}>
          <Pressable
            style={styles.stepper}
            onPress={() => {
              setAbilityPoints(abilityPoints - 1);
              setConstitution(constitution + 1);
            }}
            disabled={abilityPoints === 0 || constitution === 15}
          >
            <Text>+</Text>
          </Pressable>
          <Text>{charisma}</Text>
          <Pressable
            style={styles.stepper}
            onPress={() => {
              setAbilityPoints(abilityPoints + 1);
              setConstitution(constitution - 1);
            }}
            disabled={constitution === 8}
          >
            <Text>-</Text>
          </Pressable>
        </div>
      </div>
      <div style={styles.abilityRow}>
        <Text>Dexterity</Text>
        <div style={styles.abilityModifier}>
          <Pressable
            style={styles.stepper}
            onPress={() => {
              setAbilityPoints(abilityPoints - 1);
              setConstitution(dexterity + 1);
            }}
            disabled={abilityPoints === 0 || dexterity === 15}
          >
            <Text>+</Text>
          </Pressable>
          <Text>{dexterity}</Text>
          <Pressable
            style={styles.stepper}
            onPress={() => {
              setAbilityPoints(abilityPoints + 1);
              setConstitution(dexterity - 1);
            }}
            disabled={dexterity === 8}
          >
            <Text>-</Text>
          </Pressable>
        </div>
      </div>
      <div style={styles.abilityRow}>
        <Text>Intelligence</Text>
        <div style={styles.abilityModifier}>
          <Pressable
            style={styles.stepper}
            onPress={() => {
              setAbilityPoints(abilityPoints - 1);
              setIntelligence(intelligence + 1);
            }}
            disabled={abilityPoints === 0 || intelligence === 15}
          >
            <Text>+</Text>
          </Pressable>
          <Text>{intelligence}</Text>
          <Pressable
            style={styles.stepper}
            onPress={() => {
              setAbilityPoints(abilityPoints + 1);
              setIntelligence(intelligence - 1);
            }}
            disabled={intelligence === 8}
          >
            <Text>-</Text>
          </Pressable>
        </div>
      </div>
      <div style={styles.abilityRow}>
        <Text>Strength</Text>
        <div style={styles.abilityModifier}>
          <Pressable
            style={styles.stepper}
            onPress={() => {
              setAbilityPoints(abilityPoints - 1);
              setStrength(strength + 1);
            }}
            disabled={abilityPoints === 0 || strength === 15}
          >
            <Text>+</Text>
          </Pressable>
          <Text>{strength}</Text>
          <Pressable
            style={styles.stepper}
            onPress={() => {
              setAbilityPoints(abilityPoints + 1);
              setStrength(strength - 1);
            }}
            disabled={strength === 8}
          >
            <Text>-</Text>
          </Pressable>
        </div>
      </div>
      <div style={styles.abilityRow}>
        <Text>Wisdom</Text>
        <div style={styles.abilityModifier}>
          <Pressable
            style={styles.stepper}
            onPress={() => {
              setAbilityPoints(abilityPoints - 1);
              setWisdom(wisdom + 1);
            }}
            disabled={abilityPoints === 0 || wisdom === 15}
          >
            <Text>+</Text>
          </Pressable>
          <Text>{wisdom}</Text>
          <Pressable
            style={styles.stepper}
            onPress={() => {
              setAbilityPoints(abilityPoints + 1);
              setWisdom(wisdom - 1);
            }}
            disabled={wisdom === 8}
          >
            <Text>-</Text>
          </Pressable>
        </div>
      </div>
    </View>
  );
}
