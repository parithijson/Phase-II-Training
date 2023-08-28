import { Component } from '@angular/core';

@Component({
  selector: 'app-mortgage-calculator',
  templateUrl: './mortgage-calculator.component.html',
  styleUrls: ['./mortgage-calculator.component.css']
})
export class MortgageCalculatorComponent {
 purchasePrice!: number;
  downPayment!: number;
  repaymentTime!: number;
  interestRate!: number;
  loanAmount: number = 0;
  monthlyPayment: number = 0;

  calculateLoan() {
    this.loanAmount = this.purchasePrice - this.downPayment;
    const monthlyInterestRate = (this.interestRate / 100) / 12;
    const numberOfPayments = this.repaymentTime * 12;
    const numerator = monthlyInterestRate * Math.pow(1 + monthlyInterestRate, numberOfPayments);
    const denominator = Math.pow(1 + monthlyInterestRate, numberOfPayments) - 1;
    this.monthlyPayment = this.loanAmount * (numerator / denominator);
  }
}
