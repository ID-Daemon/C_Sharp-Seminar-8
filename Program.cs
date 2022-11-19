// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

// int rows = 5, cols = 4;
// var array = GetDoubleArray(cols,rows,0,10);
// ViewDablArray(array);
// var result = RevertFirsNLastCols(array);
// Console.WriteLine();
// ViewDablArray(result);

// int[,] RevertFirsNLastCols(int[,] collection){
//     int[,] result = new int[collection.GetLength(0),collection.GetLength(1)];
//     for (int i = 0; i < result.GetLength(0); i++)
//     {
//         for (int j = 0; j < result.GetLength(1); j++)
//         {
//             if (i == 0) result[i,j] = collection[collection.GetLength(0)-1,j];
//             else if (i == collection.GetLength(0)-1)  result[i,j] = collection[0,j];
//             else result[i,j] = collection[i,j];
//         }
//     }
//     return result;
// }



// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.

// int rows = 5, cols = 5;
// var array = GetDoubleArray(cols, rows, 0, 10);
// if (rows != cols) Console.WriteLine("Невозможно заменить строки на столбцы с текущими параметрами двумерного массива");
// else
// {
//     ViewDablArray(array);
//     Console.WriteLine();
//     var result = RevertArray(array);
//     Console.WriteLine();
//     ViewDablArray(result);

// }

// int[,] RevertArray(int[,] collection)
// {
//     int[,] result = new int[collection.GetLength(0), collection.GetLength(1)];
//     for (int i = 0; i < result.GetLength(0); i++)
//     {
//         for (int j = 0; j < result.GetLength(1); j++)
//         {
//             result[i, j] = collection[j, i];
//         }
//     }
//     return result;
// }

// Общий метод для создания двумерных массивов
int[,] GetDoubleArray(int rows, int cols, int minValue, int maxValue)
{
    int[,] collection = new int[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                collection[i, j] = new Random().Next(minValue, maxValue + 1);
            }
        }

    return collection;
}

// Общий метод для вывода на экран двумерных массивов
void ViewDablArray(int[,] collection) {
    int lengthNumber = (collection.GetLength(0) * collection.GetLength(1)).ToString().Length;
    for (int i = 0; i < collection.GetLength(0); i++) {
        for (int j = 0; j < collection.GetLength(1); j++) {
            for (int y = 0; y < lengthNumber - collection[i,j].ToString()!.Length; y++) Console.Write(" ");
            Console.Write($"{collection[i, j]} ");
            }
        Console.WriteLine();
        }
}

// -----------------------------------------------------------------------------------------

// Задача 59: Отсортировать нечетные столбцы массива по возрастанию. Вывести массив изначальный и массив с отсортированными нечетными столбцами

int rows = 6, cols = 8;
var array = GetDoubleArray(cols, rows, 0, 9);
ViewDablArray(array);
Console.WriteLine();
ViewDablArray(SortOddRows(array));

int[,] SortOddRows(int[,] collection)
{
    int max = 0;
    cols = collection.GetLength(0);
    rows = collection.GetLength(1);
    int[,] result = collection;
 
for (int j = 1; j < rows; j+=2)
{
    for (int step=0; step<cols-1;step++){  
    for (int i = 0; i < cols; i++)
    {
            if (i > 0) {
                if (max > result[i,j]){
                    result[i-1,j] = collection[i,j];
                    result[i,j] = max;
                }
                else max = result[i,j];
            }
            else {
                max = result[i,j];
            }
        }
    }
}

    Console.WriteLine();
    Console.WriteLine();

    return result;
}

//---------------------------------

// // Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // В итоге получается вот такой массив:
// // 7 4 2 1
// // 9 5 3 2
// // 8 4 4 2


// int rows = 3, cols = 4;
// var array = GetDoubleArray(cols, rows, 0, 9);
// ViewDablArray(array);
// Console.WriteLine();
// ViewDablArray(SortArray(array));

// int[,] SortArray (int[,] collection){
//     int[,] result = collection;
//     int min = result[0,0];
//     int cols = result.GetLength(0);
//     int rows = result.GetLength(1);
//     for (int i = 0; i < cols; i++)
//     {
//         for (int step = 0; step < rows-1; step++)
//         {
//             for (int j = 0; j < rows; j++)
//             {
//                 if (j>0){
//                     if (min<collection[i,j]){
//                         result[i,j-1] = result[i,j];
//                         result[i,j] = min;
//                     }
//                     else min = result[i,j];
//                 }
//                 else min = result[i,j];
//             }
//         }
//     }


//     return result;
// }

//---------------------------------

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// int rows = 4, cols = 4;
// int[,] array =  GetDoubleArray(rows,cols,0,9);
// ViewDablArray(array);
// Console.WriteLine();
// Console.WriteLine($"Номер строки с наименьшей суммой элементов: {FindMinLine(array)}");


// int FindMinLine (int[,] collection){
//     int result = 0, min = 0, temp = 0;
//     for (int i = 0; i < collection.GetLength(0); i++)
//     {
//         for (int j = 0; j < collection.GetLength(1); j++) temp+=collection[i,j];
//         if (i == 0) min = temp;
//         if (temp < min) {
//             result = i;
//             min = temp;
//             }
//         temp = 0;
//     }
//     return result + 1;
// }

//---------------------------------

// // Задача 58: Задайте две квадратные матрицы. Напишите программу, которая будет находить произведение двух матриц.
// // Например, даны 2 матрицы:
// // 2 4 | 3 4
// // 3 2 | 3 3
// // Результирующая матрица будет:
// // 18 20
// // 15 18

// int rows, cols;
// rows = cols = 3;
// int[,] firsArray = GetDoubleArray(cols, rows, 0, 9);
// int[,] secondArray = GetDoubleArray(cols, rows, 0, 9);
// Console.WriteLine("Первая таблица:");
// ViewDablArray(firsArray);
// Console.WriteLine("Вторая таблица:");
// ViewDablArray(secondArray);
// Console.WriteLine();
// Console.WriteLine("Результирующая матрица:");
// ViewDablArray(SummaryMatrix());


// int[,] SummaryMatrix(){
//     int size = firsArray.GetLength(0);
//     int[,] result = new int[size, size];
//     for (int i = 0; i < size; i++)
//     {
//         for (int j = 0; j < size; j++)
//         {
//             for (int step = 0; step < size; step++)
//             {
//                 result[i,j] =  NeNazval(i,j,size);
//             }
//         }
//     }
//     return result;
// }

// int NeNazval (int const_i, int const_j, int size){
//     int result = 0;
//     for (int step = 0; step < size; step++)
//     {
//         result += firsArray[const_i,step]*secondArray[step,const_j];
//     }
//     return result;
// }

//---------------------------------

// /* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1) */
    
//     int length, height;
//     int width = length = height = 2;
//         int[,,] array = GetTripleArray(length,height,width);
//         ViewTripleArray(array); 

// // Метод для создания трехмерного массива (Q60)
// int[,,] GetTripleArray(int length, int height, int width){
//     int[,,] collection = new int[length,height,width];
//     int[] numbers = new int[100];
//     for (int i = 0; i < 100; i++)
//     {
//         numbers[i]=i;
//     }

//     for (int i = 0; i < length; i++)
//     {
//         for (int j = 0; j < height; j++)
//         {
//             for (int y = 0; y < width; y++)
//             {
//                 do
//                 {
//                     int x =new Random().Next(0,100);
//                     collection [i,j,y] = numbers[x];
//                     numbers[x] = 0;
//                 } while (collection[i,j,y] == 0);
//             }
//         }
//     }

//     return collection;
// }

// // Метод для вывода на экран трехмерного массива (Q60)
// void ViewTripleArray(int[,,] collection){
//     for (int i = 0; i < collection.GetLength(0); i++)
//     {
//         for (int j = 0; j < collection.GetLength(1); j++)
//         {
//             for (int y = 0; y < collection.GetLength(2); y++)
//             {
//                 Console.Write($"{collection[i,j,y]}({i},{j},{y}) | ");
//             }
//             Console.WriteLine();
//         }
//     }
// }

//---------------------------------

// // //Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// // Например, на выходе получается вот такой массив:
// // 01 02 03 04
// // 12 13 14 05
// // 11 16 15 06
// // 10 09 08 07
// int rows = 5;
// int cols = 5;
// int maxStep = cols * rows;
// int step = 1, x = 0, y = 0, route = 0;
// int[,] spiral = new int[cols, rows];
// StepsInSpiral(step, maxStep, x, y, route);
// ViewDablArray(spiral);

// void StepsInSpiral(int step, int maxStep, int x, int y, int route) {
//     do {
//         spiral[y, x] = step;
//         switch (route) {
//             case 0:
//                 if (CanStep(step + 1, maxStep, x + 1, y)) {
//                     step++; x++;
//                     spiral[y, x] = step;}
//                 else { spiral[y, x] = 0; route = ChangeRout(route);}
//                 break;
//             case 1:
//                 if (CanStep(step + 1, maxStep, x, y + 1)) {
//                     step++; y++;
//                     spiral[y, x] = step; }
//                 else { spiral[y, x] = 0; route = ChangeRout(route);}
//                 break;
//             case 2:
//                 if (CanStep(step + 1, maxStep, x - 1, y)) {
//                     step++; x--;
//                     spiral[y, x] = step;}
//                 else{ spiral[y, x] = 0; route = ChangeRout(route);}
//                 break;
//             case 3:
//                 if (CanStep(step + 1, maxStep, x, y - 1)) {
//                     step++; y--;
//                     spiral[y, x] = step;}
//                 else{ spiral[y, x] = 0; route = ChangeRout(route);}
//                 break;
//         }
//     } while (step < maxStep);
// }

// // Проверка возможности хода
// bool CanStep(int step, int maxStep, int x, int y)
// {
//     if (step <= maxStep && x < spiral.GetLength(1) && y < spiral.GetLength(0) && x >= 0 && y >= 0) if (spiral[y, x] == 0) return true;
//                                                                                                     else return false;
//     else return false;
// }

// // Смена направление
// int ChangeRout(int route) {
//     route++; route %= 4;
//     return route;
// }