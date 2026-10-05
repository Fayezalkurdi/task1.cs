int allTotal = 0;
int option = 1;

while (option == 1)
{
    Console.Write("Enter price: ");
    int price = Convert.ToInt32(Console.ReadLine()!);   

    Console.Write("Enter quantity: ");
    int quantity = Convert.ToInt32(Console.ReadLine()!);

    int total = price * quantity;
    allTotal += total;

    Console.WriteLine($"Total = {total}");

    Console.Write("Add another product? 1 = Yes, 0 = No: ");
    option = Convert.ToInt32(Console.ReadLine()!);

    if (option != 1 && option != 0)
    {
        Console.WriteLine("Invalid input! Please enter 1 or 0 only.");
        option = 1;
    }
}Console.WriteLine($"All Total = {allTotal}");



