import * as SQLite from "expo-sqlite";

export class CantripDatabase {
  db;
  constructor(db: SQLite.SQLiteDatabase) {
    this.db = db;
  }
  create = async ({ title }: { title: string }) =>
    new Promise<boolean>((resolve, reject) =>
      this.db.transaction(
        (tx: {
          executeSql: (
            arg0: string,
            arg1: (string | number)[],
            arg2: (_: any, { rowsAffected }: { rowsAffected: any }) => void
          ) => void;
        }) => {
          tx.executeSql(
            "insert into tasks (title, completed) values (?, ?)",
            [title, 0],
            (_, { rowsAffected }) => {
              if (rowsAffected > 0) {
                resolve(true);
              } else {
                reject(false);
              }
            }
          );
        }
      )
    );

  /** if **id** is undefined -> returns all tasks */
  get = ({ id }: { id?: number }): Promise<Task[]> =>
    new Promise((resolve) => {
      if (!id) {
        this.db.transaction((tx) => {
          tx.executeSql("select * from tasks", [], (_, { rows }) => {
            resolve(rows._array);
          });
        });
      } else {
        this.db.transaction((tx) => {
          tx.executeSql(
            "select * from tasks where id = (?)",
            [id],
            (_, { rows }) => {
              resolve(rows._array);
            }
          );
        });
      }
    });

  setCompletedById = ({ id, completed }: { id: number; completed: boolean }) =>
    this.db.transaction((tx) => {
      tx.executeSql(
        `update tasks set completed = ? where id = ?`,
        [completed ? 1 : 0, id],
        (_, { rowsAffected }) => {
          if (rowsAffected > 0) {
          } else {
          }
        }
      );
    });

  setTitleById = ({ id, title }: { id: number; title: string }) =>
    this.db.transaction((tx) => {
      tx.executeSql(
        `update tasks set title = ? where id = ?`,
        [title, id],
        (_, { rowsAffected }) => {
          if (rowsAffected > 0) {
            console.log("update");
          } else {
            console.log("not update");
          }
        }
      );
    });

  delete = ({ id }: { id: number }) =>
    new Promise<boolean>((resolve, reject) =>
      this.db.transaction((tx) => {
        tx.executeSql(
          "delete from tasks where id = (?)",
          [id],
          (_, { rowsAffected }) => {
            if (rowsAffected > 0) {
              resolve(true);
            } else {
              reject(false);
            }
          }
        );
      })
    );
}
