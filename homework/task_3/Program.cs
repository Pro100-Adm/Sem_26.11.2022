// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

int AskUser()
{
Console.Write("Введите число: ");
string? Ask = Console.ReadLine();
if (Ask != null){
try
{
    int op = int.Parse(Ask);
    if (op>0) return op;
    else {
        Console.WriteLine("Введите число > 0!");
        return AskUser();
    };
}
catch (Exception)
{
    Console.WriteLine("Введите верное число!");
    return AskUser();
}
}
else{
    Console.WriteLine("Введите верное число!");
    return AskUser();
}
}

double AskUser2()
{
Console.Write("Введите число: ");
string? Ask = Console.ReadLine();
if (Ask != null){
try
{
    double op = double.Parse(Ask);
    return op;
}
catch (Exception)
{
    Console.WriteLine("Введите верное число!");
    return AskUser2();
}
}
else{
    Console.WriteLine("Введите верное число!");
    return AskUser2();
}
}

double [] array = new double [AskUser()];

double diff(double [] array){
    double temp = 0;
    for(int i = 0; i< array.Length; i++){
        array[i] = AskUser2();
    }
    for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }                   
                }            
            }
    return array[array.Length-1]-array[0];
    }

Console.WriteLine($"Разница между максимальным и минимальным элементами массива: { diff(array)}");

