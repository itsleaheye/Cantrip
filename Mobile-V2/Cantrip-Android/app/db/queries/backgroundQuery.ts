export const backgroundsCreateQuery = `
  CREATE TABLE IF NOT EXISTS Backgrounds (
    id INTEGER DEFAULT 1 PRIMARY KEY,
    name TEXT,
    description TEXT,
    FOREIGN KEY(languageId) REFERENCES LANGUAGES(id)
  )
`;
