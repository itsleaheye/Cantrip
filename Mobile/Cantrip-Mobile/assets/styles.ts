import { StyleSheet } from "react-native";

export const styles = StyleSheet.create({
  backgroundContainer: {
    backgroundColor: "#202328",
    padding: 16,
    flex: 1,
  },
  container: {
    flex: 1,
    justifyContent: "center",
  },
  characterListCard: {
    backgroundColor: "#2A2E37",
    borderRadius: 8,
    marginBottom: 16,
    paddingHorizontal: 16,
    paddingVertical: 10,
    justifyContent: "space-between",
    flexDirection: "row",
  },
  cardTitle: {
    marginTop: 6,
    fontSize: 18,
    color: "#ffffff",
  },
  cardSubtitle: {
    fontSize: 16,
    color: "#53565D",
  },
  iconLeft: {
    marginRight: -70,
    height: 60,
    width: 60,
    backgroundColor: "#42C9C5",
    borderRadius: 100,
  },
  subtitleRight: {
    position: "absolute",
    bottom: 8,
    right: 0,
  },
  primaryButton: {
    backgroundColor: "'linear-gradient(90deg, #22c1c3 0%, #4d9ece 100%)'",
    paddingVertical: 16,
    paddingHorizontal: 16,
    borderRadius: 8,
  },
  primaryButtonText: {
    textAlign: "center",
    fontSize: 18,
    textTransform: "uppercase",
    fontWeight: "bold",
    color: "#fff",
  },
  grayBanner: {
    backgroundColor: "#2A2E37",
    width: "100%",
  },
  abilityRow: {
    marginBottom: 16,
    paddingHorizontal: 16,
    paddingVertical: 10,
    justifyContent: "space-between",
    flexDirection: "row",
  },
  abilityModifier: {
    flexDirection: "row",
    width: "20%",
  },
  stepper: {
    borderRadius: 8,
    backgroundColor: "#53565D",
    color: 202328,
  },
});
