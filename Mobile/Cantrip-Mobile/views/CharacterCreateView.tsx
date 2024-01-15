import * as React from "react";
import { View, Text, Alert, Pressable } from "react-native";
import { styles } from "../assets/styles";
import { LinearGradient } from "expo-linear-gradient";
import { useState } from "react";
import { StepOne } from "../components/CharacterCreate/StepOne";
import { StepTwo } from "../components/CharacterCreate/StepTwo";

export function CharacterCreateView({ navigation }: { navigation: any }) {
  const [character, SetCharacter] = useState();
  const [step, SetStep] = useState(1);
  return (
    <View style={{ flex: 1, alignItems: "center", justifyContent: "center" }}>
      <Text>New Character</Text>
      {/* [!] Progress Bar Here */}
      {step === 1 && <StepOne />}
      {step === 2 && <StepTwo />}
      {step === 3 && <StepOne />}
      {step === 4 && <StepOne />}

      <Pressable
        style={styles.primaryButton}
        onPress={() => {
          Alert.alert("[!] Next pressed");
          if (step !== 4) {
            SetStep(step + 1);
          } else {
            navigation.navigate("CharacterView", { character: character });
          }
        }}
      >
        <LinearGradient
          colors={["#22c1c3", "#4d9ece"]}
          start={{ x: 0, y: 0 }}
          end={{ x: 1, y: 0 }}
          style={styles.primaryButton}
        >
          <Text style={styles.primaryButtonText}>
            {step === 4 ? "Finish" : "Next"}
          </Text>
        </LinearGradient>
      </Pressable>
      {step === 4 && (
        <Pressable
          onPress={() => {
            Alert.alert("[!] Cancel pressed");
            navigation.navigate("CharacterSelectView");
          }}
        >
          <Text>Cancel Character</Text>
        </Pressable>
      )}
    </View>
  );
}
