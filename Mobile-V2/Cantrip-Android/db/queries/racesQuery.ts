export const racesCreateQuery = `
  CREATE TABLE IF NOT EXISTS Races (
    id INTEGER DEFAULT 1 PRIMARY KEY,
    name TEXT,
    description TEXT,
    trait TEXT,
    FOREIGN KEY(abilityId) REFERENCES ABILITIES(id),
    resistance TEXT,
    FOREIGN KEY(languageId) REFERENCES LANGUAGES(id)
  )
`;
