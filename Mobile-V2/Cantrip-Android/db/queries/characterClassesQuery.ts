export const characterClassesCreateQuery = `
  CREATE TABLE IF NOT EXISTS CharacterClasses (
    id INTEGER DEFAULT 1 PRIMARY KEY,
    name TEXT,
    description TEXT,
    hitDie INTEGER,
    saves TEXT,
    FOREIGN KEY(armorId) REFERENCES ARMORS(id),
    FOREIGN KEY(weaponId) REFERENCES WEAPONS(id),
    FOREIGN KEY(toolId) REFERENCES TOOLS(id),
    FOREIGN KEY(languangeId) REFERENCES LANGUAGES(id),
  )
`;
