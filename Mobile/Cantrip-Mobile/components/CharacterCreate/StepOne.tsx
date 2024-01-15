import { LinearGradient } from "expo-linear-gradient";
import { TextInput, Pressable, Alert, Text, View } from "react-native";
import { styles } from "../../assets/styles";

export function StepOne() {
  return (
    <View>
      {/* https://blog.logrocket.com/building-react-native-forms-with-ui-components/ | Form reference */}
      <div>
        <Text>Character Name</Text>
        <TextInput placeholder="Character Name" />
      </div>
      <div>
        <Text>Race</Text>
        <TextInput placeholder="Race" />
      </div>
      <div>
        <Text>Background</Text>
        <TextInput placeholder="Background" />
      </div>
      <div>
        <Text>Starting Class</Text>
        <TextInput placeholder="Starting Class" />
      </div>
    </View>
  );
}
