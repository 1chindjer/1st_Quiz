Console.WriteLine("Введите строки. Разделите их запятыми и пробелами, после ввода нажмите Enter:");
string input = Console.ReadLine();
string[] inputArray = input.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
int shortStringsCount = 0;
    for (int i = 0; i < inputArray.Length; i++){
        if (inputArray[i].Length <= 3){
            shortStringsCount++;
            }
    }
// Создаем массив для строк длиной не больше 3
string[] shortStringsArray = new string[shortStringsCount];
// Заполняем новый массив
    int index = 0;
    for (int i = 0; i < inputArray.Length; i++){
        if (inputArray[i].Length <= 3){
            shortStringsArray[index] = inputArray[i];
            index++;
        }
    }
Console.WriteLine("\nМассив строк, длина которых меньше или равна 3 символам:");
    for (int i = 0; i < shortStringsArray.Length; i++){
        if (i < shortStringsArray.Length - 1){
            Console.Write($"{shortStringsArray[i]}, ");
        }
        else{
            Console.Write(shortStringsArray[i]);
        }
    }