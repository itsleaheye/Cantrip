export const spellsCreateQuery = `
  CREATE TABLE IF NOT EXISTS Spells (
    id INTEGER DEFAULT 1 PRIMARY KEY,
    name TEXT,
    duration TEXT,
    range TEXT,
    level INTEGER,
    hitFor INTEGER,
    effect TEXT,
    notes TEXT,
  )
`;
