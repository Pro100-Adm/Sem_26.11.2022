// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

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

int [] array = new int [AskUser()];

for (int i=0; i<array.Length; i++){
    array[i] = new Random().Next(0, 1000);
}

int col_even(int [] array){
    int col = 0;
    foreach(int element in array){
        //Console.Write(element+" ");
        if (element%2==0) col++;
    }
    return col;
}

Console.WriteLine($"Количество чётных элементов в массиве: {col_even(array)}");
