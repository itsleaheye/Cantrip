export const abilitiesCreateQuery = `
  CREATE TABLE IF NOT EXISTS Abilities (
    id INTEGER DEFAULT 1 PRIMARY KEY,
    name TEXT,
    description TEXT,
  )
`;
