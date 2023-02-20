import React from 'react';
import { Alert, Button, FlatList, Pressable, SafeAreaView, StyleSheet } from 'react-native';
import CharacterListCard from '../components/CharacterListCard';
import { styles } from "../assets/styles";
import { Text, View } from '../components/Themed';
import { LinearGradient } from 'expo-linear-gradient';

const DATA = [
  {
    id: '0',
    title: 'First Character',
  },
  {
    id: '1',
    title: 'Second Character',
  },
  {
    id: '2',
    title: 'Third Character',
  },
];

export default function HomeView() {
  return (
    <View style={styles.backgroundContainer}>
      <FlatList
        data={DATA}
        keyExtractor={character => character.id}
        renderItem={({ item }) => (
          <CharacterListCard name={item.title} id={item.id}/>
        )}
      />
      

      <Pressable
        style={styles.primaryButton}
        onPress={() => Alert.alert('New Character pressed')}>
          <LinearGradient colors={['#22c1c3', '#4d9ece']} start={{x: 0, y: 0}} end={{x: 1, y: 0}} style={styles.primaryButton}>
            <Text style={styles.primaryButtonText}>New Character</Text>
          </LinearGradient>
      </Pressable>
    </View>
  );
}

