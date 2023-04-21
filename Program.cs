Console.WriteLine("Введите строки. Разделите их запятыми и пробелами, после ввода нажмите Enter:");
string input = Console.ReadLine();
string[] inputArray = input.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
int shortStringsCount = 0;
    for (int i = 0; i < inputArray.Length; i++){
        if (inputArray[i].Length <= 3){
            shortStringsCount++;
            }
    }
// Создаем новый массив для строк длиной не больше 3
