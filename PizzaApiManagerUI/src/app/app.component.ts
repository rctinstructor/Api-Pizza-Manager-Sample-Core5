import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

export interface PizzaSize {
  id: number;
  name: string;
}

export interface Pizza {
  id: number;
  name: string;
  size: PizzaSize;
  personalRating: number;
}

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
})
export class AppComponent implements OnInit {
  public pizzas: Pizza[] = [];

  constructor(private client: HttpClient) {}

  ngOnInit() {
    this.client
      .get<Pizza[]>('https://localhost:5001/api/pizzas')
      .subscribe((result) => (this.pizzas = result));
  }
}
