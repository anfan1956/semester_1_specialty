/*
    написать программу, которая из имеющегося массива строк, формирует массив из строк, 
    длина которых меньше, либо равна 3 символа....
    При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно 
    массивами
*/
string[] array = { "grenade", "Peter", "job", "12945", "URL", "sea", "river", "22", "1:N" };

/// Новый массив назовем arrayFiltered.
/// Так как длина массива после его декларирования неизменна, нужно сначала определить 
/// длину нового массива. Для этого создаем переменную len_filtered
int l = 0;
for (var i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3) l++;
}
if (l == 0)
{
    Console.WriteLine("There are no elements in the array satisfying the condition");
}
else
{

    /// Теперь декларируем массив и заполняем его
    string[] arrayFiltered = new string[l];
    int j = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            arrayFiltered[j] = array[i];
            j++;
        }
        if (j == l) break;
    }
    /// представляем решение задачи в требуемом виде
    Console.WriteLine($"[{String.Join(", ", array)}] -> [{String.Join(", ", arrayFiltered)}]");
}
