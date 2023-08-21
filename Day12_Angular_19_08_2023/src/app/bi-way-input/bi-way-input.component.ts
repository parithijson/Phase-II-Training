import { Component } from '@angular/core';

@Component({
  selector: 'app-bi-way-input',
  templateUrl: './bi-way-input.component.html',
  styleUrls: ['./bi-way-input.component.css']
})
export class BiWayInputComponent {
  username = '';
  reset(){
    this.username='';
  }
}
