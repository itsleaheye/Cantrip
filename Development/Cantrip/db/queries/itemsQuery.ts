// Update this so that items can only be type: weapon, armor, tool, or other
// enum ItemType {
//   Weapon = "weapon",
//   Armor = "armor",
//   Tool = "tool",
//   Other = "other",
// }

export const itemTypesCreateQuery = `
  CREATE TABLE IF NOT EXISTS ItemTypes (
    id INTEGER DEFAULT 1 PRIMARY KEY,
    type TEXT CHECK(type IN ('weapon', 'armor', 'tool', 'other')),
  )
`;

export const itemsCreateQuery = `
  CREATE TABLE IF NOT EXISTS Items (
    id INTEGER DEFAULT 1 PRIMARY KEY,
    name TEXT,
    description TEXT,
    FOREIGN KEY(itemTypeId) REFERENCES ITEM_TYPES(id),
    weight INTEGER,
    cost TEXT,
    quantity INTEGER,
  )
`;
