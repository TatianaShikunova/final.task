Console.Clear();
Console.WriteLine("Введите количество элементов массива строк:");
int size = int.Parse(Console.ReadLine());
Console.WriteLine("Введите элементы массива строк:");
string [] a = new string [size];
FillArray(a);
Console.WriteLine("Массив из строк, длина которых меньше либо равна 3 символам: ");
SelectArray(a);

void FillArray(string [] array)
{
    for (int i = 0; i<array.Length; i++)
    {
        array[i] = Console.ReadLine();
        
    }
}
void SelectArray(string [] arr)

{
    
    for (int j = 0; j<arr.Length; j++)
    {
        char [] array = arr[j].ToCharArray();
        if (array.Length<=3)
        {
            Console.WriteLine(String.Join("", array));
            
        }
          
    }
    
}