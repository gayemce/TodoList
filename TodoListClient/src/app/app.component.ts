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
  todos: TodoModel[] = []
  todo: TodoModel[] = [];
  done: TodoModel[] = [];
  todoInput: string = "";
  updateButtonDisplay: boolean = false;
  addButtonDisplay: boolean = true;
  updateId: number = 0;

  constructor(
    private http: HttpClient,
    private sweetAlertService: SweetAlertService) {
    this.getAll();
  }

  create() {
    if (!this.todoInput || this.todoInput.trim() === '') {
      this.sweetAlertService.showErrorAlert('Enter a value.');
      return;
    }
    if (this.todos.some(t => t.work.toLowerCase() === this.todoInput.toLowerCase())) {
      this.sweetAlertService.showErrorAlert('This item already exists.');
      this.todoInput = '';
      return;
    }

    this.request.work = this.todoInput;
    this.http.post<TodoModel[]>(`https://localhost:7035/api/Todos/Create`, this.request)
      .subscribe(res => {
        this.todo = res;
        this.todoInput = '';
        this.getAll();
      })
  }

  update() {
    if (!this.todoInput || this.todoInput.trim() === '') {
      this.sweetAlertService.showErrorAlert('Enter a value.');
      return;
    }
    if (this.todos.some(t => t.work.toLowerCase() === this.todoInput.toLowerCase())) {
      this.sweetAlertService.showErrorAlert('This item already exists.');
      this.todoInput = '';
      this.updateButtonDisplay = false;
      this.addButtonDisplay = true;
      return;
    }

    this.request.id = this.updateId;
    this.request.work = this.todoInput;
    this.http.post<TodoModel[]>(`https://localhost:7035/api/Todos/Update`, this.request)
      .subscribe(res => {
        this.todo = res;
        this.updateButtonDisplay = false;
        this.addButtonDisplay = true;
        this.todoInput = '';
        this.getAll();
      })
  }

  get(item: TodoModel) {
    this.todoInput = item.work;
    this.updateId = item.id;
    this.addButtonDisplay = false;
    this.updateButtonDisplay = true;
  }

  remove(id: number) {
    this.http.post<TodoModel[]>(`https://localhost:7035/api/Todos/Remove/${id}`, this.request)
      .subscribe(res => {
        this.todos = res;
        this.getAll();
      })
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
        this.getAll();
      });
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
