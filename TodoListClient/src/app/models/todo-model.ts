export class TodoModel {
    id: number = 0;
    work: string = "";
    isCompleted: boolean = false;
    isDeleted: boolean = false;
    createdAt: Date = new Date();
    completedAt: Date = new Date();
  }
  