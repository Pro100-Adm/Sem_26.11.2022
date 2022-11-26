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

int AskUser2()
{
Console.Write("Введите число: ");
string? Ask = Console.ReadLine();
if (Ask != null){
try
{
    int op = int.Parse(Ask);
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

int [] array = new int [AskUser()];

void prodPairs(int [] array){
    for(int i = 0; i< array.Length; i++){
        array[i] = AskUser2();
    }
    int [] new_array = new int [array.Length/2];
    for (int i = 0; i < array.Length/2; i++){
        int prod = array[i]*array[array.Length-i-1];
        new_array[i] = prod;
        Console.WriteLine(new_array[i]);
    }
}

prodPairs(array);