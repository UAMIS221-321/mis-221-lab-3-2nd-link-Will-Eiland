Read me test
//-----------------------------------------------------------------TA 
//initialize variables
int numOfSandwiches = 0;
int numOfToppings = 0;
double tip = 0;
double totalSandwichCost;
double totalTippingCost;
double baseCost;

//initalize constants
const double COST_OF_SANDWICHES = 4.75;
const double COST_OF_TOPPINGS = 0.55;
const double DISCOUNT_AMOUNT  = 0.10;

//promt the user for # sandwiches
System.Console.Writeline("How many Sandwiches?");
numOfSandwiches = int.Parse(Console.Readline());
System.Console.Writeline("Sandwiches" + numOfSandwiches);
//--------------------------------------------------------------
