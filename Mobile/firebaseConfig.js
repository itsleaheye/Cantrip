// Following Guide: https://docs.expo.dev/guides/using-firebase/
import { initializeApp } from "firebase/app";
import { getFirestore } from "firebase/firestore";
import { getAnalytics } from "firebase/analytics";
import { collection, addDoc, getDocs } from "firebase/firestore";

const firebaseConfig = {
  apiKey: "AIzaSyDR-jly_1Fx0CHM4qcBbleyEGYxupBfJsQ",
  authDomain: "cantrip-mobile.firebaseapp.com",
  projectId: "cantrip-mobile",
  storageBucket: "cantrip-mobile.appspot.com",
  messagingSenderId: "692424177987",
  appId: "1:692424177987:web:bba4659df6b4cc4624d7f6",
  measurementId: "G-HS6Y273VPF", // For Firebase JS SDK v7.20.0 and later, measurementId is optional
};

const app = initializeApp(firebaseConfig);
const analytics = getAnalytics(app);
const db = getFirestore(app);

try {
  const docRef = await addDoc(collection(db, "users"), {
    firstName: "Ada",
    lastName: "Lovelace",
    fullName: "${ firstName } ${lastName}",
  });
  console.log("Document written with ID: ", docRef.id);
} catch (e) {
  console.error("Error adding document: ", e);
}

const querySnapshot = await getDocs(collection(db, "users"));
querySnapshot.forEach((doc) => {
  console.log(`${doc.id} => ${doc.data()}`);
});

// // EXAMPLE Get a list of cities from your database
// async function getCities(db) {
//   const citiesCol = collection(db, "cities");
//   const citySnapshot = await getDocs(citiesCol);
//   const cityList = citySnapshot.docs.map((doc) => doc.data());
//   return cityList;
// }

// EXAMPLE Deployment
// > firebase login > firebase init > firebase deploy --only hosting:cantrip
// {

//   "hosting": {

//     "site": "cantrip",

//     "public": "public",

//     ...

//   }

// }
