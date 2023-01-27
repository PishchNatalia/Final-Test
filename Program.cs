// Задача.Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
string[]ChooseStringLess3(string[]array)
{
    int count = 0;
    for (int i = 0;i < array.Length;i ++)
    if (array[i].Length <= 3) count++;

    string[] newArray = new string[count];
    count = 0;

    for (int i = 0;i <array.Length; i++)
        if (array[i].Length <= 3)
        {
            newArray[count] = array[i];
            count++;
        }
        return newArray;

}

void ShowStringArray(string[]array)
{
    for (int i = 0;i < array.Length;i++)
    Console.Write(array[i] + " ");

 Console.WriteLine();   

}
string[] Myarray = new string[]{"Hi","Hello","World","Go","Win"};
ShowStringArray(Myarray);
string[] cutArray = ChooseStringLess3(Myarray);
ShowStringArray(cutArray);


