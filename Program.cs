/* Заполнить двумерный массив следующим образом.
Вводится число n.
1 1 1 1 1 1 ... 1
1 2 2 2 2 2 ... 2
1 2 3 3 3 3 ... 3
1 2 3 4 4 4 ... 4
1 2 3 4 5 5 ... 5
1 2 3 4 5 6 ... 6
1 2 3 4 5 6 ... n
*/

int[,] Rd(int n)
{
    int[,] Num = new int[n, n];
    for (int i = 0; i < Num.GetLength(0); i++)
    {
        Num[i,0] = 1;
        for (int j = 1; j < Num.GetLength(1); j++)
        {
            if (j <= i) Num [i,j] = Num [i,j-1] + 1;
            else Num [i,j] = Num [i,j-1];
        }
    
    }

return Num;
}

void Print(int [,] aaa)
{
for (int i = 0; i < aaa.GetLength(0); i++)
    {
        for (int j = 0; j < aaa.GetLength(1); j++)
            System.Console.Write(aaa[i,j] + " ");
        System.Console.WriteLine("");
    }
System.Console.WriteLine("");
System.Console.WriteLine("");

}

Console.WriteLine();
Console.Write("Введите размер массива: ");
int n = int.Parse(Console.ReadLine());

int[,] bbb = Rd(n);
Print(bbb);