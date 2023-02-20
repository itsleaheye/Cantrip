/**
 * Learn more about deep linking with React Navigation
 * https://reactnavigation.org/docs/deep-linking
 * https://reactnavigation.org/docs/configuring-links
 */

import { LinkingOptions } from "@react-navigation/native";
import * as Linking from "expo-linking";

import { RootTabParamList } from "../types";

// const linking: LinkingOptions<RootTabParamList> = {
//   prefixes: [Linking.createURL("/")],
//   config: {
//     screens: {
//       Root: {
//         screens: {
//           HomeView: {
//             screens: {
//               HomeView: "one",
//             },
//           },
//           TabTwo: {
//             screens: {
//               TabTwoScreen: "two",
//             },
//           },
//         },
//       },
//       Modal: "modal",
//       NotFound: "*",
//     },
//   },
// };

// export default linking;
