import { Background, ClassDetails, Race } from "../components/types";

export function getLanguages(
  className: ClassDetails,
  race: Race,
  background: Background
) {
  let available = {
    languages: ["Common"],
    slots: 1,
  };
  const classLanguages = className.languages;
  const raceLanguages = race.languages;

  classLanguages.map((l) => {
    available.languages.push(l);
    available.slots++;
  });
  raceLanguages.map((l) => {
    available.languages.push(l);
    available.slots++;
  });

  if (background.languageExtraSlots) {
    available.slots += background.languageExtraSlots;
  }

  return available;
}
