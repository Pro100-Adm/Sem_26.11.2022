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
    array[i] = new Random().Next(-100000,100000);
}

int summ_not_even_pos(int [] array){
    int summ = 0;
    for(int i = 0; i<array.Length; i++){
        if (i%2!=0) summ+=array[i];
        //Console.Write(array[i]+" ");
    }
    return summ;
}

Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях в массиве: {summ_not_even_pos(array)}");