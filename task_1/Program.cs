// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

int [] array = new int [12];

for (int i=0; i<array.Length; i++){
    array[i] = new Random().Next(-9, 10);
}

void summ(int [] array){
    int summ_positive = 0, summ_negative = 0;
    foreach(int element in array){
        if (element<0){
            summ_negative+=element;
        }else{
            summ_positive+=element;
        }
    }
    Console.WriteLine("Positive elements summ " + summ_positive);
    Console.WriteLine("Negative elements summ " + summ_negative);
}

summ(array);