import { DrawerNavigationProp } from '@react-navigation/drawer';
import { RouteProp } from '@react-navigation/native';
import { StyleSheet } from 'react-native';
import { styles } from '../assets/styles';
import { Text, View } from '../components/Themed';
import { DrawerAppStackParams } from '../types';

interface CharacterViewProps {
  characterId: string;
}

export default function CharacterView(characterId: string): JSX.Element {
  return (
    <View style={styles.container}>
      <Text>{characterId ? characterId : "This should be my id"}</Text>
    </View>
  );
}
