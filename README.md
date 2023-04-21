# **ИТОГОВАЯ РАБОТА №1**
#### *Задача*: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
<br>
В своем решении я решил пользователю разрешить ввод изначального массива с клавиатуры через консоль. <br>

1. Сначала напишем часть кода, отвечающего за ввод строк из консоли пользователем:
```
Console.WriteLine("Введите строки. Разделите их запятыми и пробелами, после ввода нажмите Enter:");
string input = Console.ReadLine();

string[] inputArray = input.Split(new string[] { ", " },StringSplitOptions.RemoveEmptyEntries);

int shortStringsCount = 0; 
```
В данном случае <br>
`string[] inputArray = input.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);` <br>
разделяет введенную пользователем строку на массив строк.

2. Теперь создаем массив строк, длина которых менее или равна 3 символа

``` string[] shortStringsArray = new string[shortStringsCount];
// Заполняем новый массив
    int index = 0;
    for (int i = 0; i < inputArray.Length; i++){
        if (inputArray[i].Length <= 3){
            shortStringsArray[index] = inputArray[i];
            index++;
        }
    }
```
3. Ну а в финальной части мы выводим массив из тех строк, которые были короче или равны 3м символам
```
Console.WriteLine("\nМассив строк, длина которых меньше или равна 3 символам:");
    for (int i = 0; i < shortStringsArray.Length; i++){
        if (i < shortStringsArray.Length - 1){
            Console.Write($"{shortStringsArray[i]}, ");
        }
        else{
            Console.Write(shortStringsArray[i]);
        }
    }
```
Блок схема:

![Текст с описанием картинки](/xml.jpg)