double COST_OF_SANDWICH = 4.75;
double COST_OF_TOPPING = 0.55;     // prices for each thing
double DISCOUNT_AMOUNT = .10;

int numberOfSandwiches = GetNumberOfSandwiches();
int numberOfToppings = GetNumberOfToppings();           // getting my inputs
int tip = GetTip();

double totalSandwichCost = COST_OF_SANDWICH * numberOfSandwiches;
double totalToppingCost = COST_OF_TOPPING * numberOfToppings;           // total costs of everything
double baseCost = totalSandwichCost + totalToppingCost;
double orderCost = tip + baseCost * (1 - DISCOUNT_AMOUNT);
GetOrderCost(orderCost);

static int GetNumberOfSandwiches(){
    System.Console.WriteLine("How many sandwiches? ");
    return int.Parse(Console.ReadLine());
}

static int GetNumberOfToppings(){
    System.Console.WriteLine("How many toppings? ");
    return int.Parse(Console.ReadLine());
}

static int GetTip(){
    System.Console.WriteLine("Tip? ");
    return int.Parse(Console.ReadLine());
}

static void GetOrderCost(double orderCost){
    System.Console.WriteLine($"Your total is {orderCost}");

}











