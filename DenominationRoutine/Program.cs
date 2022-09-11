
var bills = new int[] { 100, 50, 10 };
var payOutMoneys = new int[] { 30, 50, 60, 80, 140, 230, 370, 610, 980 };
void GetPossibility(int amount, int minBill, string? plus)
{
    for (int i = minBill; i < bills.Length; i++)
    {
        var change = plus;
        var sum = amount;

        while (sum > 0)
        {
            if (!string.IsNullOrEmpty(change)) change += " + ";
            //We get the value of the next money in the ATM. We write this money to the change value, if it will continue, we must have data to print this probability result.
            change += bills[i];
            //If this money value is more than the currency we want to withdraw, we do not continue the transaction. But if equal or less we continue
            sum -= bills[i];
            //If the sum value is greater than zero, then we calculate the money that the atm should give.
            if (sum > 0)
            {
                GetPossibility(sum, i + 1, change);
            }
        }
        //If the sum value is reset, there is no other possibility, we print the data.
        if (sum == 0)
        {
            Console.WriteLine(change);
        }
    }
}
foreach (var money in payOutMoneys)
{
    GetPossibility(money, 0, String.Empty);
    Console.WriteLine(" ");
    Console.WriteLine("***********************************");
    Console.WriteLine(" ");

}
