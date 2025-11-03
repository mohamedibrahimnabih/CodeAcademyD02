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
    Console.WriteLine("I - Find a num using index");
    Console.WriteLine("R - First Number");
    Console.WriteLine("Z - Last Number");
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
                if (list.Count == 0)
                    Console.WriteLine("the list is empty");
                else
                {
                    int sum = 0;
                    foreach (var item in list)
                        sum += item;

                    Console.WriteLine($"The Mean = {sum / list.Count}");
                }
            }
            break;
        case 'R':
            {
                if (list.Count == 0)
                    Console.WriteLine("the list is empty");
                else
                    Console.WriteLine($"The First number is  = {list[0]} , {list.First()}");
            }
            break;
        case 'Z':
            {
                if (list.Count == 0)
                    Console.WriteLine("the list is empty");
                else
                    Console.WriteLine($"The Last number is  = {list[list.Count-1]} , {list[^1]}");
            }
            break;
        case 'S':
            {
                if(!list.Any())
                    Console.WriteLine("The list is empty");
                else
                {
                    int smallest = list[0];

                    foreach (var item in list)
                        if (item < smallest)
                            smallest = item;

                    Console.WriteLine($"The min value {smallest}");
                }
            }
            break;
        case 'L':
            {
                if (!list.Any())
                    Console.WriteLine("The list is empty");
                else
                {
                    int largest = list[0];

                    foreach (var item in list)
                        if (item > largest)
                            largest = item;

                    Console.WriteLine($"The max value {largest}");
                }
            }
            break;
        case 'F':
            {
                if (!list.Any())
                    Console.WriteLine("The list is empty");
                else
                {
                    Console.WriteLine("Enter Your Number to search it:");
                    int number = Convert.ToInt32(Console.ReadLine());

                    bool founded = false;

                    for (int i = 0; i < list.Count; i++)
                    {
                        if (number == list[i])
                        {
                            Console.WriteLine($"the index is: {i}");
                            founded = true;
                        }
                    }

                    if(!founded)
                        Console.WriteLine("No Result");
                }
            }
            break;
        case 'I':
            {
                if (!list.Any())
                    Console.WriteLine("The list is empty");
                else
                {
                    Console.WriteLine("Enter Your Index to search it:");
                    int index = Convert.ToInt32(Console.ReadLine());

                    bool founded = false;

                    for (int i = 0; i < list.Count; i++)
                    {
                        if (index == i)
                        {
                            Console.WriteLine($"Number: {list[i]}");
                            founded = true;
                        }
                    }

                    if (!founded)
                        Console.WriteLine("No Result");
                }
            }
            break;
    }
}