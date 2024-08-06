// See https://aka.ms/new-console-template for more information
using BankAccount;

Account BillZica = new Account("Bill Zica", 12.23m);

BillZica.Print();

BillZica.Deposit(5.13m);
BillZica.Print();

BillZica.Withdraw(-25.12m);
BillZica.Print();

//Realized if I withdraw a negative amount,
//it's the same as a deposit, so I need to
//include data validation for this input

BillZica.Withdraw(81.50m);
BillZica.Print();

//Account balance goes into negative
//territory which is good for now.