// Семинар 8 ДЗ

int SetNumber(string str)
{
    System.Console.WriteLine(str);
    int num = int.Parse(Console.ReadLine());
    return num;
}

void PrintArrayDouble(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i] + " ");
    }
        System.Console.WriteLine();
}

int[,] GetRandomMatrix(int rows, int column, int minVal = -100, int maxVal = 100)
{
    int[,] matrix = new int[rows, column];
    var random = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < column; j++)
        {
            matrix[i,j] = random.Next(minVal, maxVal+1);
        }
    }
return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i,j] + " ");
        }
    System.Console.WriteLine();
    }
}

void PrintMatrixDouble(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i,j] + " ");
        }
    System.Console.WriteLine();
    }
}


double[,] GetRandomMatrixDouble(int rows, int column,  int minVal = -100, int maxVal = 100)
{
    double[,] matrix = new double[rows, column];
    var random = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < column; j++)
        {
            matrix[i,j] = Math.Round(random.Next(minVal*10, maxVal*10) * 0.1, 2);
        }
    }
return matrix;
}

void FindNumber(int[,] matrix, int numAsk)
{
    int k = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(matrix[i,j] == numAsk)
            {
                System.Console.WriteLine($"({i}, {j})");
                k++;
                break;
            }
        }

    if (k >0) break;
    } 
if (k == 0) System.Console.WriteLine("Число не найдено");
}

int[,] SortRowsDown(int[,] matr)   //упорядочит по убыванию элементы каждой строки двумерного массива.
{
    int rows = matr.GetLength(0);
    int columns = matr.GetLength(1);
    for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                for (int k = j + 1; k < columns; k++)
                {
                    if (matr[i,j] < matr[i,k])
                    {
                        int temp = matr[i,j];
                        matr[i,j] = matr[i,k];
                        matr[i,k] = temp;
                    }
                }
            }
        }
    return matr;
}

void FindMinRow(int [,] matrix)  //будет находить строку с наименьшей суммой элементов
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    int[] itog = new int[rows];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            itog[i] = itog[i] + matrix[i,j];
        }
    }
    int k = 0;
    for (int i = 0; i < rows; i++)
    {
        if(itog[i] < itog[k]) k = i;
    }
    System.Console.WriteLine("Строка с наименьшей суммой элементов - № " + $"{k+1}");
}

int[,] CompositionMatrix(int[,] matrix1, int[,] matrix2) //будет находить произведение двух матриц.
{
    int rows1 = matrix1.GetLength(0);
    int columns1 = matrix1.GetLength(1);
    int rows2 = matrix2.GetLength(0);
    int columns2 = matrix2.GetLength(1);

    int[,] itog = new int[rows1, columns2];
    for (int i = 0; i < rows1; i++)
    {
        for (int j = 0; j < columns2; j++)
        {
        for (int k = 0; k < rows2; k++)
        {
            itog[i,j] = itog[i,j] + matrix1[i,k] * matrix2[k,j];
        }
        }
    }
return itog;
}

void Random3dMatrix(int x, int y, int z, int minValue=0, int maxValue=99) //трёхмерный массив из одномерного из неповторяющихся двузначных чисел.
{
    int[,,] arr3d= new int[x, y, z];
    int size1d = x*y*z;
    int[] arr1d = GetRandomArrayNotRepeat(size1d, minValue, maxValue);
    int indexAr1 = 0;
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
                arr3d[i,j,k] = arr1d[indexAr1];
                indexAr1++;
                System.Console.Write($"({i}, {j}, {k}) = {arr3d[i,j,k]}  ");
            }
            System.Console.WriteLine();
        }
    }
}

int[] GetRandomArrayNotRepeat(int size, int begin, int last) //одномерный массив из неповторяющихся двузначных чисел.
{
    int[] arr = new int[size];
    Random random = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = random.Next(begin, last+1);
        for (int j = 0; j < i; j++)
        {
            while(arr[i] == arr [j])
            {
                arr[i] = random.Next(begin, last+1);
                j = 0;
            }
        }
    }
return arr;
}

void CircleArray4x4() //заполнит спирально массив 4 на 4
{
    int[,] matr = new int[4,4];
    int k = 1;
    int i =0;
    int j = 0;
    for (j = 0; j < 4; j++)
    {
        matr[0,j]=k;
        k++;
    }
    j--;
    for (i = 1; i < 4; i++)
    {
        matr[i,j]=k;
        k++;
    }
    i--;
    for (j = 2; j >= 0; j--)
    {
        matr[i,j]=k;
        k++;
    }
    j++;
    for (i = 2; i >= 1; i--)
    {
        matr[i,j]=k;
        k++;
    }
    i++;
    for (j = 1; j < 3; j++)
    {
        matr[i,j]=k;
        k++;
    }
    j--;
    i=2;
    for (j = 2; j >= 1; j--)
    {
        matr[i,j]=k;
        k++;
    }
    PrintMatrix(matr);
}

Start();


void Start()
{
    while(true)
    {
        System.Console.WriteLine("Нажмите Enter");
        Console.ReadLine();
        Console.Clear();

        System.Console.WriteLine("Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.");
        System.Console.WriteLine("Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.");
        System.Console.WriteLine("Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.");
        System.Console.WriteLine("Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.");
        System.Console.WriteLine("Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.");
        System.Console.WriteLine("0 - Выход из программы");

        int numberTask = SetNumber("Введите номер задачи и нажмите Enter");

        switch(numberTask)
        {
            case 0: 
            {
                return; 
                break;
            }
            case 54: 
            {
                int rows = SetNumber("Введите количество строк");
                int columns = SetNumber("Введите количество столбцов");
                int[,] matrix = GetRandomMatrix(rows, columns, 0, 9);
                System.Console.WriteLine();
                PrintMatrix(matrix);
                System.Console.WriteLine();
                PrintMatrix(SortRowsDown(matrix));
                break;
            }
            case 56:
            {
                int rows = SetNumber("Введите количество строк");
                int columns = SetNumber("Введите количество столбцов");
                int[,] matrix = GetRandomMatrix(rows, columns, 0, 9);
                System.Console.WriteLine();
                PrintMatrix(matrix);
                System.Console.WriteLine();
                FindMinRow(matrix);
                break;
            }
            case 58:
            {
                int rows1 = SetNumber("Введите количество строк");
                int columns1 = SetNumber("Введите количество столбцов");
                int[,] matrix1 = GetRandomMatrix(rows1, columns1, 0, 5);
                int rows2 = SetNumber("Введите количество строк");
                int columns2 = SetNumber("Введите количество столбцов");
                int[,] matrix2 = GetRandomMatrix(rows2, columns2, 0, 5);
                System.Console.WriteLine();
                PrintMatrix(matrix1);
                System.Console.WriteLine();
                PrintMatrix(matrix2);
                System.Console.WriteLine();
                PrintMatrix(CompositionMatrix(matrix1, matrix2));
                break;
            }
            case 60:
            {
                int x = SetNumber("Введите количество строк по оси x");
                int y = SetNumber("Введите количество строк по оси y");
                int z = SetNumber("Введите количество строк по оси z");
                Random3dMatrix(x, y, z);
                break;
            }
            case 62:
            {
                CircleArray4x4();
                break;
            }
            default:
            {
                System.Console.WriteLine("Неверный номер");
                break;
            }
                
        }
    }

}