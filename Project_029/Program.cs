// 31. Задать массив из 8 элементов и вывести их на экран
// пример  1, 2, 3, 9 = [1, 2, 3, 9]

Console.Clear(); 
 
int N = 8; 
int[] array = new int[N]; 
 
int[] SetArray(int x) 
{ 
    int[] arr = new int[x]; 
    for (int i = 0; i < x; i++) 
    { 
        arr[i] = new Random().Next(1, 100); 
    } 
    return arr; 
} 

array = SetArray(N); 
Console.Write($"{String.Join(',', array)}"); 
Console.WriteLine($" = [{String.Join(',', array)}]");
