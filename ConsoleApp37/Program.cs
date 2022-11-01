// Генерация Матрицы
int[,] GenerationMatrix(int n)
{
    Random rnd = new Random();

    int[,] arr = new int[n, n];

    for (int i = 0; i < n; i++)
    {
        int j = 0;
        while (j < n)
        {
            int a = rnd.Next(0, 11);
            if (a % 2 != 0)
            {
                arr[i, j] = a;
                j++;
            }
        }
    }
    return arr;
}

bool method1(int a)
{
    bool key = false;
    for (int i = 2; i < a; i++)
    {
        if(a % i != 0)
        {
            key = true;
        }
        else
        {
            key = false;
            break;
        }
    }
    return key;
}

// Запись матрицы в файл
void WritingToAFile(int[,] arr)
{
    StreamWriter writer = new StreamWriter("Output.txt");

    int n = arr.GetLength(0);

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            writer.Write($"{arr[i, j]} ");
        }
        writer.WriteLine();
    }

    writer.Close();
}
// Чтение Матрицы из файла
int[,] ReadingFromFile(int n = 5, string nameFile = "Output.txt")
{
    StreamReader reader = new StreamReader(nameFile);

    int[,] mat = new int[n, n];
    int j = 0;

    for (int i = 0; i < n; i++)
    {
        foreach (string str in reader.ReadLine().Split(' '))
        {
            mat[i, j] = int.Parse(str);
            j++;
        }
        j = 0;
    }
 

    reader.Close();
    return mat;
    
}

int method3(int[,] arr)
{
    int n = arr.GetLength(0);

    int count = 0;
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (method1(arr[i, j]))
            {
                count += 1;
            }
        }
    }
    return count;
}

void PrintMat(int[,] arr)
{
    int n = arr.GetLength(0);

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

int n = 5;
// 1
Console.WriteLine("№1");

int[,] arr = GenerationMatrix(5);

PrintMat(arr);

Console.WriteLine("-------------------");
// 2
Console.WriteLine("№2");
int[,] matr = GenerationMatrix(5);

PrintMat(matr); 
//Console.WriteLine(method(matr));

WritingToAFile(matr);

int[,] res = new int[n, n];

// Складывание
for (int i = 0; i < n; i++)
{
    for(int j = 0; j < n; j++)
    {
        res[i, j] = arr[i, j] + matr[i, j];
    }
}
Console.WriteLine("-------------------");
PrintMat(res);

int a = method3(arr);
int b = method3(matr);

if (a > b)
{
    for( int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
    }
    Console.WriteLine();
    Console.WriteLine("В первой матрице больше простых чисел");
    Console.WriteLine(a);
}
else
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
    }
    Console.WriteLine();
    Console.WriteLine("Во второй матрице больше простых чисел");
    Console.WriteLine(b);
}




//bool method(int[,] matr)
//{
//    int n = matr.GetLength(0);
//    int sum = 0;
//    int oldSum = 0;
//    bool key = true;
    
//    for (int i = 0; i < n; i++)
//    {
//        for (int j = 0; j < n; j++)
//        {
//            sum = sum + matr[i, j];
//        }
//        if (sum != oldSum)
//        {
//            key = false;
//            break;
//        }

//        sum = 0;

//        oldSum = sum;
//        Console.WriteLine(sum);

        
//    }

//    return key;
//}


//Console.WriteLine(ReadingFromFile());

//int[,] mat = ReadingFromFile();

//PrintMat(mat);





//int[,] matr = new int[n, n];

//int i = 0;
//int j = 0;
//matr
//foreach (string st in subs)
//{
//    for (int k = 0; k < n; k++)
//    {
//        if (st != ' ')
//        {

//        }
//    }

//}

//PrintMat(matr);

