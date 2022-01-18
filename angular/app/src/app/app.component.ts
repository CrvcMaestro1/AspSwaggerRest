import { Component } from '@angular/core';
import { Beer } from './api/models';
import { BeerService } from './api/services';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  public beer!: Beer;

  public constructor(private api: BeerService) {
    this.api.apiBeerGet$Json({ Id: 2 }).subscribe(res => {
      this.beer = res;
    });
  }
}
