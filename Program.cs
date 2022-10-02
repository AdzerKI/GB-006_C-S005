// создание массивов для всех задач
// создает рандомный массив
int[] RandomArrayCreate(int elements, int min, int max){
    int[] array = new int[elements];
    for(int i = 0; i < elements; i++){
        array[i] = new Random().Next(min, max);
    }
    
    return array;
}
// метод возвращает строку из массива
string ArrayToString(int[] arr){
    string result = string.Empty;

    for(int i = 0; i < arr.Length; i++){
        if (i < arr.Length - 1){
            result = result + $"{arr[i]}, ";
        } else {
            result = result + $"{arr[i]}";
        }
    }

    return result;
}

/* Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных 
элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20. */

/* int[] array = RandomArrayCreate(12, -9, 10);
int pos = 0;
int neg = 0;

for(int i = 0; i < array.Length; i++){
    if (array[i] < 0){
        neg = neg + array[i];
    } else {
        pos = pos + array[i];
    }
}

string result = ArrayToString(array);
System.Console.WriteLine($"в массиве [{result}] сумма положительных чисел равна {pos}, сумма отрицательных равна {neg}."); */


/* Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2] */

/* int[] array = RandomArrayCreate(12, -9, 10);
int[] negArray = new int[array.Length];

for(int i = 0; i < array.Length; i++){
    negArray[i] = array[i] * -1;
}

System.Console.WriteLine($"[{ArrayToString(array)}] -> [{ArrayToString(negArray)}]"); */


/* Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да */

/*int[] array = RandomArrayCreate(12, -9, 10);
int number = new Random().Next(-9,10);
bool haveNumber = false;

for(int i = 0; i < array.Length; i++){
    if (array[i] == number) {
        haveNumber = true;
    }
}

string result = "нет";
if (haveNumber == true){
    result = "Да";
} 

System.Console.WriteLine($"{number}; [{ArrayToString(array)}] -> {result}");  */

/* Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5 */

/* int[] array = RandomArrayCreate(123, 0, 1000);
int count = 0;

for(int i = 0; i < array.Length; i++){
    if (array[i] > 9 && array[i] < 100){
        count++;
    }
}

System.Console.WriteLine($"[{ArrayToString(array)}] -> {count}"); */

/* Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний 
элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21 */

/* int[] array = RandomArrayCreate(11, 0, 10);
int[] newArray = new int[array.Length];

for (int i = 0; i < array.Length; i++){
    newArray[i] = array[i] * array[array.Length - i - 1];
}

System.Console.WriteLine($"[{ArrayToString(array)}] -> [{ArrayToString(newArray)}]"); */