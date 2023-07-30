System.Console.Write("Введите длину: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите высоту: ");
int b = Convert.ToInt32(Console.ReadLine());

double[,] arr = new double[b,a];
for(int i = 0; i < arr.GetLength(0); i++){
    for(int j = 0; j < arr.GetLength(1); j++){
    arr[i,j] = new Random().NextDouble()*(-100+50)+35;
    System.Console.Write("["+arr[i,j].ToString("F2")+"]"+" ");
}
System.Console.WriteLine();
}
