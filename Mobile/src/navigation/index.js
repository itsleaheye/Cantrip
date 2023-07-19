// import * as React from "react";
// import { View, Text } from "react-native";
// import { NavigationContainer } from "@react-navigation/native";
// import { createNativeStackNavigator } from "@react-navigation/native-stack";

// // Reference: https://reactnavigation.org/docs/hello-react-navigation

// function SplashView() {
//   return (
//     <View style={{ flex: 1, alignItems: "center", justifyContent: "center" }}>
//       <Text>Home Screen</Text>
//     </View>
//   );
// }

// function CharacterSelectView() {
//   return (
//     <View style={{ flex: 1, alignItems: "center", justifyContent: "center" }}>
//       <Text>Details Screen</Text>
//     </View>
//   );
// }

// const Stack = createNativeStackNavigator();

// function App() {
//   return (
//     <NavigationContainer>
//       {/* To Do: Loading Screen overlay of animated logo */}
//       <Stack.Navigator initialRouteName="Home">
//         <Stack.Screen name="Cantrip is Loading" component={SplashView} />
//         <Stack.Screen name="Character Select" component={CharacterSelectView} />
//       </Stack.Navigator>
//     </NavigationContainer>
//   );
// }

// export default App;
