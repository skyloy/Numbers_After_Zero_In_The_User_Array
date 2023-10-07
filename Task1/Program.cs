// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

int [] CreateUsersArray(int size){
    Console.WriteLine();
    int[] array = new int[size];
    for(int i = 0; i < array.Length; i++){
    Console.Write("Enter a number of array: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void ShowArray(int[] array){
    for (int i = 0; i < array.Length; i++){
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void AboveZero (int[] array){
    int count = 0;
    for(int i = 0; i < array.Length; i++){
        if(array[i] < 0)
            count++;
    }
    Console.WriteLine($"Quantity of numbers above zero is {count}");
}


Console.WriteLine("Enter size of array:");
int size = Convert.ToInt32(Console.ReadLine());
int[] newArray = CreateUsersArray(size);
ShowArray(newArray);
AboveZero(newArray);