export const languagesCreateQuery = `
  CREATE TABLE IF NOT EXISTS Languages (
    id INTEGER DEFAULT 1 PRIMARY KEY,
    name TEXT,
  )
`;
