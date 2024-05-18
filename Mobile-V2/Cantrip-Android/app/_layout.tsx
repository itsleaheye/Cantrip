import {
  DarkTheme,
  DefaultTheme,
  ThemeProvider,
} from "@react-navigation/native";
import { useFonts } from "expo-font";
import { Stack } from "expo-router";
import * as SplashScreen from "expo-splash-screen";
import { useCallback, useEffect } from "react";
import "react-native-reanimated";
import { connectToDatabase, createTables } from "./db/db";
import { useColorScheme } from "@/hooks/useColorScheme";
import CharacterList from "./views/CharacterList";

// Prevent the splash screen from auto-hiding before asset loading is complete.
SplashScreen.preventAutoHideAsync();

export default function RootLayout() {
  const colorScheme = useColorScheme();
  const [loaded] = useFonts({
    SpaceMono: require("../assets/fonts/SpaceMono-Regular.ttf"),
  });
  // Fetch data from the database
  // const loadData = useCallback(async () => {
  //   try {
  //     const db = await connectToDatabase();
  //     await createTables(db);
  //   } catch (error) {
  //     console.error(error);
  //   }
  // }, []);

  useEffect(() => {
    if (loaded) {
      SplashScreen.hideAsync();
    }
  }, [loaded]);

  if (!loaded) {
    // To do: Add loading animated logo of burning book and dice
    return null;
  }

  // To do: Persistant layouts across all screens
  // Settings will always be top: 0, left: 0
  // Each 'view' should pass in the current route, and a header label (~bold, #fff, h2)

  return (
    <ThemeProvider value={colorScheme === "dark" ? DarkTheme : DefaultTheme}>
      <CharacterList />
      {/* <Stack>
        <Stack.Screen name="(tabs)" options={{ headerShown: true }} />
        <Stack.Screen name="+not-found" />
      </Stack> */}
    </ThemeProvider>
  );
}
