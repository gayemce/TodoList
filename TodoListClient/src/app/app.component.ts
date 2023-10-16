import { CdkDragDrop, moveItemInArray, transferArrayItem } from '@angular/cdk/drag-drop';
import { Component } from '@angular/core';
import { TodoModel } from './models/todo-model';
import { HttpClient } from '@angular/common/http';

import { SweetAlertService } from './sweetalert.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  request: TodoModel = new TodoModel();

  todos: TodoModel[] = [];
  todo: TodoModel[] = [];
  done: TodoModel[] = [];

  todoInput: string = "";
  updateTodoValue: string = "";
  updateTodoId: number = 0;
  addButton = true;
  updateButton: boolean = false;
  errorMessage: string = "";
  deleted: any = [];

  constructor(private http: HttpClient, private sweetAlertService: SweetAlertService) {
    this.getAll();
  }

  CreateToDo() {
    if (!this.todoInput || this.todoInput.trim() === '') {
      this.sweetAlertService.showErrorAlert('Enter a value.');
      return;
    }

    if (this.todos.some(t => t.work.toLowerCase() === this.todoInput.toLowerCase())) {
      this.sweetAlertService.showErrorAlert('This item already exists.');
      this.todoInput = '';
      this.updateButton = false;
      this.addButton = true;
      return;
    }

    this.request.work = this.todoInput;

    this.http.post<TodoModel[]>(`https://localhost:7035/api/Todos/CreateToDo`, this.request)
      .subscribe(res => {
        this.todos = res;
        this.getAll();
        this.todoInput = '';
      });
  }

  UpdateToDo() {
    if (!this.todoInput || this.todoInput.trim() === '') {
      this.sweetAlertService.showErrorAlert('Enter a value.');
      return;
    }

    if (this.todos.some(t => t.work.toLowerCase() === this.todoInput.toLowerCase())) {
      this.sweetAlertService.showErrorAlert('This item already exists.');
      this.todoInput = '';
      this.updateButton = false;
      this.addButton = true;
      return;
    }

    this.request.work = this.todoInput;
    this.request.id = this.updateTodoId;

    this.http.post<TodoModel[]>(`https://localhost:7035/api/Todos/UpdateToDo`, this.request)
      .subscribe(res => {
        this.todos = res;
        this.getAll();
        this.todoInput = '';
        this.updateButton = false;
        this.addButton = true;
      });
  }

  get(item: TodoModel) {
    this.updateTodoValue = item.work;
    this.updateTodoId = item.id;
    this.todoInput = this.updateTodoValue;
    this.updateButton = true;
    this.addButton = false;
  }


  RemoveToDo(id: number) {
    this.http.get<TodoModel[]>(`https://localhost:7035/api/Todos/RemoveToDo/${id}`)
      .subscribe(res => {
        this.deleted = res;
        this.getAll();
      });
  }

  remove(id: number) {
    this.RemoveToDo(id);
  }

  getAll() {
    this.http.get<TodoModel[]>("https://localhost:7035/api/Todos/GetAll")
      .subscribe(res => {
        this.todos = res;
        this.splitTodosToTodoAndDone();
      });
  }

  splitTodosToTodoAndDone() {
    this.todo = [];
    this.done = [];
    for (let t of this.todos)
      if (t.isCompleted === true) {
        this.done.push(t);
      }
      else {
        this.todo.push(t);
      }
  }

  changeCompleted(id: number) {
    this.http.get<TodoModel[]>(`https://localhost:7035/api/Todos/ChangeCompleted/${id}`)
      .subscribe(res => {
        this.todos = res;
        this.splitTodosToTodoAndDone();
      });
  }

  check(id: number) {
    this.changeCompleted(id)
  }

  dropOne(event: CdkDragDrop<TodoModel[]>) {
    if (event.previousContainer === event.container) {
      moveItemInArray(event.container.data, event.previousIndex, event.currentIndex);
    } else {
      const id = this.done[event.previousIndex].id;
      this.changeCompleted(id);
    }
  }

  dropTwo(event: CdkDragDrop<TodoModel[]>) {
    if (event.previousContainer === event.container) {
      moveItemInArray(event.container.data, event.previousIndex, event.currentIndex);
    } else {
      const id = this.todo[event.previousIndex].id;
      this.changeCompleted(id);
    }
  }
}
