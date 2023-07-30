int[,] arr = new int[4,5];

for(int i = 0; i < arr.GetLength(0); i++){
    for(int j = 0; j < arr.GetLength(1); j++){
        arr[i,j] = new Random().Next(10,50);
        System.Console.Write("["+arr[i,j]+"]"+" ");
    }
    System.Console.WriteLine();
}

int indexI = Convert.ToInt32(Console.ReadLine());
int indexJ = Convert.ToInt32(Console.ReadLine());
for(int i = 0; i < arr.GetLength(0); i++){
    for(int j = 0; j < arr.GetLength(1); j++){
        if(arr[indexI,indexJ] == arr[i,j]){
            System.Console.Write("["+arr[indexI,indexJ]+"]"+" ");
        }
       
    }
}

