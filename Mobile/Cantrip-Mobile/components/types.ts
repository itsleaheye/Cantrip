import { Image } from "react-native";

export interface Class {
  id: string; //also class name
  details: string;
  level: number;
  languages: string[];
  proficiencies: {
    tools: string[];
    weapons: string[];
    armor: string[];
  };
}

export interface Race {
  id: string; //also race name
  details: string;
  languages: string[];
  trait?: string;
  abilities?: {
    name: string;
    description: string;
  };
}

export interface Item {
  id: string;
  category: "Apparel" | "Weapon" | "Consumable" | "Other";
  details: string;
  name: string;
  quantity: number;
  weight: number;
  value: number;
}

export interface Weapon extends Item {
  type: "Melee" | "Ranged" | "Bludgeoning" | "Piercing" | "Slashing"; //[!] Reference Books
  damage: number;
  range: number;
}

export interface Spell {
  id: string;
  type: "Melee" | "Ranged"; //[!] Reference Books
  damage: number;
  level: number;
  isCantrip: boolean;
  isFocused: boolean; //[!] Reference Books
  name: string;
  range: number;
}

export interface Inventory {
  id: string; //also class name
  currentWeight: number; //summary of all items.weight
  items: Item[];
  maxWeight: number;
}

export interface Background {
  id: string; //also background name
  details: string;
  languages: string[];
}

export interface Character {
  id: string;
  armor: number;
  avatar?: Image; //If null, default to class Avatar
  armorClass: "Light" | "Medium" | "Heavy" | "Shield";
  background: Background;
  class: Class[];
  equippedWeapons: Weapon[];
  hitDice: number;
  hitPoints: number;
  initiative: number;
  inventory: Inventory[];
  languages: string[]; //Cumulative of Class[].languages & Race[].languages & Background.languages
  totalLevel: number; //Sum of Class[] levels
  name: string;
  proficiencyBonus: number;
  proficiencies: {
    armor: string[];
    weapons: string[];
    tools: string[];
  };
  race: Race;
  speed: number;
  spellAttack: number;
  spellDC: number;
  spells: Spell[];
  stats: {
    strength: number;
    constitution: number;
    dexterity: number;
    intelligence: number;
    wisdom: number;
    charisma: number;
  };
}