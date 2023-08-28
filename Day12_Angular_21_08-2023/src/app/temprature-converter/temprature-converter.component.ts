import { Component } from '@angular/core';

@Component({
  selector: 'app-temprature-converter',
  templateUrl: './temprature-converter.component.html',
  styleUrls: ['./temprature-converter.component.css']
})
export class TempratureConverterComponent {
  title = 'temp';
  inputTemperature!: number;
  selectedUnit: 'celsius' | 'fahrenheit' = 'celsius';
  convertedTemperature: number | null = null;
  targetUnit: string = 'celsius';

  convertTemperature() {
    if (this.selectedUnit === 'celsius') {
      this.targetUnit = 'fahrenheit';
      this.convertedTemperature = (this.inputTemperature * 9 / 5) + 32;
    } else {
      this.targetUnit = 'celsius';
      this.convertedTemperature = (this.inputTemperature - 32) * 5 / 9;
    }
  }

}
