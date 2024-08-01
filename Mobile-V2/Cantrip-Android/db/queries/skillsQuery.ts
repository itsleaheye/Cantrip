export const skillsCreateQuery = `
  CREATE TABLE IF NOT EXISTS Skills (
    id INTEGER DEFAULT 1 PRIMARY KEY,
    name TEXT,
    proficiency BOOLEAN,
    modifier INTEGER,
    bonus INTEGER,
  )
`;
