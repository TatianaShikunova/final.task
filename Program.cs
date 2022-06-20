Console.Clear();
Console.WriteLine("Введите количество элементов массива строк:");
int size = int.Parse(Console.ReadLine());
Console.WriteLine("Введите элементы массива строк:");
string [] a = new string [size];
FillArray(a);

void FillArray(string [] array)
{
    for (int i = 0; i<array.Length; i++)
    {
        array[i] = Console.ReadLine();
        
    }
}