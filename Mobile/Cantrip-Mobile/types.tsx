import { DrawerScreenProps } from '@react-navigation/drawer';
import { CompositeScreenProps, NavigatorScreenParams } from '@react-navigation/native';
import { NativeStackScreenProps } from '@react-navigation/native-stack';

declare global {
  namespace ReactNavigation {
    interface RootParamList extends DrawerAppStackParams {}
  }
}

export type DrawerAppStackParams = {
  HomeView: undefined;
  CharacterView: {characterId: string};
};

export type RootStackScreenProps<Screen extends keyof DrawerAppStackParams> = NativeStackScreenProps<
  DrawerAppStackParams,
  Screen
>;

export type RootTabParamList = {
  HomeView: undefined;
  CharacterView: undefined;
};

export type RootTabScreenProps<Screen extends keyof RootTabParamList> = CompositeScreenProps<
  DrawerScreenProps<RootTabParamList, Screen>,
  NativeStackScreenProps<DrawerAppStackParams>
>;
