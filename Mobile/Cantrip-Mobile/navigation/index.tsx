import * as React from "react";
import { View, Text, Button, Alert, FlatList, Pressable } from "react-native";
import { NavigationContainer } from "@react-navigation/native";
import { createNativeStackNavigator } from "@react-navigation/native-stack";
import { Character } from "../components/types";
import { styles } from "../assets/styles";
import { LinearGradient } from "expo-linear-gradient";
import CharacterListCard from "../components/CharacterListCard";
// Reference: https://reactnavigation.org/docs/hello-react-navigation

function SplashView() {
  return (
    <View style={{ flex: 1, alignItems: "center", justifyContent: "center" }}>
      <Text>Home Screen</Text>
    </View>
  );
}

// const Stack = createNativeStackNavigator();

// function App() {
//   return (
//     <NavigationContainer>
//       {/* To Do: Loading Screen overlay of animated logo */}
//       <Stack.Navigator initialRouteName="Home">
//         <Stack.Screen name="Cantrip is Loading" component={SplashView} />
//         <Stack.Screen name="Character Select" component={CharacterSelectView} />
//         <Stack.Screen name="My Character" component={CharacterView} />
//       </Stack.Navigator>
//     </NavigationContainer>
//   );
// }

// export default App;

// import "react-native-gesture-handler";

// import { FontAwesome } from "@expo/vector-icons";
// import { createBottomTabNavigator } from "@react-navigation/bottom-tabs";
// import { createNativeStackNavigator } from "@react-navigation/native-stack";
// import * as React from "react";
// import { Alert, Pressable } from "react-native";
// import Colors from "../constants/Colors";
// import useColorScheme from "../hooks/useColorScheme";
// import HomeView from "../oldScreens/homeView";
// import {
//   DrawerAppStackParams,
//   RootStackScreenProps,
//   RootTabParamList,
//   RootTabScreenProps,
// } from "../types";
// import {
//   createDrawerNavigator,
//   DrawerNavigationProp,
// } from "@react-navigation/drawer";
// import CharacterView from "../oldScreens/CharacterView";
// import { DefaultTheme, NavigationContainer } from "@react-navigation/native";
// import LinkingConfiguration from "./LinkingConfiguration";

// export default function Navigation() {
//   return (
//     <NavigationContainer theme={DefaultTheme} linking={LinkingConfiguration}>
//       <RootNavigator />
//     </NavigationContainer>
//   );
// }

// const Drawer = createDrawerNavigator<DrawerAppStackParams>();

// function RootNavigator() {
//   return (
//     <Drawer.Navigator
//       initialRouteName="HomeView"
//       screenOptions={{
//         headerShown: true,
//         // title: "My Characters",
//         headerTitleAlign: "center",
//         drawerStyle: {
//           backgroundColor: "#202328",
//         },
//       }}
//     >
//       <Drawer.Screen name="HomeView" component={HomeView} />
//       <Drawer.Screen name="CharacterView" component={CharacterView} />
//     </Drawer.Navigator>
//   );
// }

// /**
//  * A bottom tab navigator displays tab buttons on the bottom of the display to switch screens.
//  * https://reactnavigation.org/docs/bottom-tab-navigator
//  */
// // const BottomTab = createBottomTabNavigator<RootTabParamList>();

// // function BottomTabNavigator() {
// //   const colorScheme = useColorScheme();

// //   return (
// //     <BottomTab.Navigator
// //       initialRouteName="HomeView"
// //       screenOptions={{
// //         tabBarActiveTintColor: Colors[colorScheme].tint,
// //       }}>
// //       <BottomTab.Screen
// //         name="HomeView"
// //         component={HomeView}
// //         options={({ navigation }: RootTabScreenProps<'HomeView'>) => ({
// //           title: 'My Characters',
// //           headerShown: false,
// //           tabBarIcon: ({ color }) => <TabBarIcon name="code" color="#fff" />,
// //           headerRight: () => (
// //             // This is the info button
// //             <Pressable
// //               onPress={() => navigation.navigate('Modal')}
// //               style={({ pressed }) => ({
// //                 opacity: pressed ? 0.5 : 1,
// //               })}>
// //               <FontAwesome
// //                 name="info-circle"
// //                 size={25}
// //                 color={Colors[colorScheme].text}
// //                 style={{ marginRight: 15 }}
// //               />
// //             </Pressable>
// //           ),
// //         })}
// //       />
// //     </BottomTab.Navigator>
// //   );
// // }

// /**
//  * You can explore the built-in icon families and icons on the web at https://icons.expo.fyi/
//  */
// function TabBarIcon(props: {
//   name: React.ComponentProps<typeof FontAwesome>["name"];
//   color: string;
// }) {
//   return <FontAwesome size={30} style={{ marginBottom: -3 }} {...props} />;
// }
