export const characterCreateQuery = `
  CREATE TABLE IF NOT EXISTS Character (
    id INTEGER DEFAULT 1 PRIMARY KEY,
    name TEXT,
    FOREIGN KEY(raceId) REFERENCES RACES(id),
    FOREIGN KEY(characaterClassId) REFERENCES CHARACTERCLASSES(id),
    FOREIGN KEY(backgroundId) REFERENCES BACKGROUNDS(id),
    alignment TEXT,
    notes TEXT,
    FOREIGN KEY(skillId) REFERENCES SKILLS(id),
    level INTEGER,
    currentHP INTEGER,
    maxHP INTEGER,
    armorClass INTEGER,
    initiative INTEGER,
    speed INTEGER,
    skillStr INTEGER,
    skillDex INTEGER,
    skillCon INTEGER,
    skillInt INTEGER,
    skillWis INTEGER,
    skillCha INTEGER,
    FOREIGN KEY(languageId) REFERENCES LANGUAGES(id),
    FOREIGN KEY(inventoryId) REFERENCES ITEMS(id),
    FOREIGN KEY(proficiencyArmorId) REFERENCES ITEMS(id),
    FOREIGN KEY(proficiencyWeaponId) REFERENCES ITEMS(id),
    FOREIGN KEY(proficiencyToolId) REFERENCES ITEMS(id),
    FOREIGN KEY(spellId) REFERENCES SPELLS(id)
  )
`;
// Update so that the profiecient item tables fetch items with the corresponding itemTypes of weapon, armor, or tool. Inventory will not have a type check
