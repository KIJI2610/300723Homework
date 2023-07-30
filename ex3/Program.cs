int H = 4; 
int W = 6;
int[,] arr = new int[H,W];
for(int i = 0; i < arr.GetLength(0); i++){
    for(int j = 0; j < arr.GetLength(1); j++){
        arr[i,j] = new Random().Next(10,51);
        System.Console.Write("["+arr[i,j]+"]"+" ");
    }
    System.Console.WriteLine();
}

for (int j = 0; j < W; j++)
{
    double summa = 0;
    for (int i = 0; i < H; i++)
    {
        summa = summa + arr[i, j];
    }
    double result = summa / H;
    System.Console.WriteLine("Среднее арифметическое столбца " + j + ": " + result);
}
