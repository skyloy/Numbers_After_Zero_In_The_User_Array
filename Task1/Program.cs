// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

int [] CreateUsersArray(int size){
    Console.WriteLine();
    int[] array = new int[size];
    int number = 1;
    for(int i = 0; i < array.Length; i++){
    Console.Write($"Enter a {number} number of array: ");
    number++;
    array[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine();
    return array;
}

void ShowArray(int[] array){
    Console.Write("[");
    
    for (int i = 0; i < array.Length; i++){
        if(i == array.Length-1)
            Console.Write($"{array[i]}");
        else
            Console.Write($"{array[i]} ");
    }
    Console.Write("]");
    Console.WriteLine();
}

void AboveZero (int[] array){
    int count = 0;
    for(int i = 0; i < array.Length; i++){
        if(array[i] < 0)
            count++;
    }
    Console.WriteLine($"Quantity of numbers below zero is {count}");
}


Console.Write("Enter size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] newArray = CreateUsersArray(size);
ShowArray(newArray);
AboveZero(newArray);