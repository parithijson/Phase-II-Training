import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppComponent } from './app.component';
import { ServersComponent } from './servers/servers.component';
import { FormsModule } from '@angular/forms';
import { SuccessComponent } from './success/success.component';
import { WarningComponent } from './warning/warning.component';
import { BiWayInputComponent } from './bi-way-input/bi-way-input.component';
import { CalculatorComponent } from './calculator/calculator.component';


@NgModule({
  declarations: [
    AppComponent,
    ServersComponent,
    SuccessComponent,
    WarningComponent,
    BiWayInputComponent,

    CalculatorComponent,


  ],
  imports: [
    BrowserModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
