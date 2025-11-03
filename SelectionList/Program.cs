List<int> list = [];

while(true)
{
    Console.WriteLine("\n====Welcome to our application====");
    Console.WriteLine("P - Print list");
    Console.WriteLine("A - Add new num");
    Console.WriteLine("M - Calc mean / avg");
    Console.WriteLine("S - Calc Smallest");
    Console.WriteLine("L - Calc Largest");
    Console.WriteLine("F - Find a num");
    Console.WriteLine("C - Clear list");
    Console.WriteLine("Q - Quit");

    Console.WriteLine("Enter Your Input: ");
    char selection = Convert.ToChar(Console.ReadLine().ToUpper());

    switch(selection)
    {
        case 'P':
            {
                if(list.Count == 0)
                    Console.WriteLine("the list is empty");
                else
                {
                    Console.Write("[ ");
                    foreach (var item in list)
                        Console.Write($"{item} "); //[ 10 20 30 ]
                    Console.WriteLine("]");
                }
            }
            break;
        case 'A':
            {
                Console.WriteLine("Enter Your Number");
                list.Add(Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine($"{list[^1]} is added");
            }
            break;
        case 'M':
            {
                int sum = 0;
                foreach (var item in list)
                    sum += item;

                Console.WriteLine($"The Avg = {sum / list.Count}");
            }
            break;
    }
}