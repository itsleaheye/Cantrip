import 'react-native-gesture-handler';

import { FontAwesome } from '@expo/vector-icons';
import { createBottomTabNavigator } from '@react-navigation/bottom-tabs';
import { createNativeStackNavigator } from '@react-navigation/native-stack';
import * as React from 'react';
import { Alert, Pressable } from 'react-native';
import Colors from '../constants/Colors';
import useColorScheme from '../hooks/useColorScheme';
import HomeView from '../screens/homeView';
import { DrawerAppStackParams, RootStackScreenProps, RootTabParamList, RootTabScreenProps } from '../types';
import { createDrawerNavigator, DrawerNavigationProp } from '@react-navigation/drawer';
import CharacterView from '../screens/CharacterView';
import { DefaultTheme, NavigationContainer } from '@react-navigation/native';
import LinkingConfiguration from './LinkingConfiguration';

export default function Navigation() {
  return (
    <NavigationContainer theme={DefaultTheme} linking={LinkingConfiguration}>
      <RootNavigator />
    </NavigationContainer>
  );
}

const Drawer = createDrawerNavigator<DrawerAppStackParams>();

function RootNavigator() {
  return (
    <Drawer.Navigator
        initialRouteName="HomeView"
        screenOptions={{
            headerShown: true,
            // title: "My Characters",
            headerTitleAlign: "center",
            drawerStyle: {
              backgroundColor: "#202328",
            },
        }}
        >
        <Drawer.Screen name="HomeView" component={HomeView}/>
        <Drawer.Screen name="CharacterView" component={CharacterView}/>
      </Drawer.Navigator>
  );
}

/**
 * A bottom tab navigator displays tab buttons on the bottom of the display to switch screens.
 * https://reactnavigation.org/docs/bottom-tab-navigator
 */
// const BottomTab = createBottomTabNavigator<RootTabParamList>();

// function BottomTabNavigator() {
//   const colorScheme = useColorScheme();

//   return (
//     <BottomTab.Navigator
//       initialRouteName="HomeView"
//       screenOptions={{
//         tabBarActiveTintColor: Colors[colorScheme].tint,
//       }}>
//       <BottomTab.Screen
//         name="HomeView"
//         component={HomeView}
//         options={({ navigation }: RootTabScreenProps<'HomeView'>) => ({
//           title: 'My Characters',
//           headerShown: false,
//           tabBarIcon: ({ color }) => <TabBarIcon name="code" color="#fff" />,
//           headerRight: () => (
//             // This is the info button
//             <Pressable
//               onPress={() => navigation.navigate('Modal')}
//               style={({ pressed }) => ({
//                 opacity: pressed ? 0.5 : 1,
//               })}>
//               <FontAwesome
//                 name="info-circle"
//                 size={25}
//                 color={Colors[colorScheme].text}
//                 style={{ marginRight: 15 }}
//               />
//             </Pressable>
//           ),
//         })}
//       />
//     </BottomTab.Navigator>
//   );
// }

/**
 * You can explore the built-in icon families and icons on the web at https://icons.expo.fyi/
 */
function TabBarIcon(props: {
  name: React.ComponentProps<typeof FontAwesome>['name'];
  color: string;
}) {
  return <FontAwesome size={30} style={{ marginBottom: -3 }} {...props} />;
}
