import useCachedResources from "./hooks/useCachedResources";
import { Platform } from "react-native";
import * as SQLite from "expo-sqlite";
// import Navigation from "./navigation";
import { CharacterSelectView } from "./views/CharacterSelectView";

const Stack = createNativeStackNavigator(); // https://reactnavigation.org/docs/stack-navigator/

export default function App() {
  const isLoadingComplete = useCachedResources();

  if (!isLoadingComplete) {
    /* To Do: Loading Screen overlay of animated logo */
    return null;
  } else {
    return (
      <NavigationContainer>
        <Stack.Navigator initialRouteName="Home">
          {/* <Navigation/> */}
          <Stack.Screen name="Cantrip is Loading" component={SplashView} />
          <Stack.Screen
            name="Character Select"
            component={CharacterSelectView}
          />
          <Stack.Screen name="My Character" component={CharacterView} />
        </Stack.Navigator>
      </NavigationContainer>
    );
  }
}

export function openDatabase() {
  return SQLite.openDatabase("cantrip.db");
}
