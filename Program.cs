﻿// int[] RandomArr(int size){
//     int[] arr=new int[size];
//     for(int i=0; i<size; i++){
//         arr[i]=new Random().Next(100,1000);
//     }
//     return arr;
// }

// void ShowArray(int[]array){
//     for(int i=0; i < array.Length; i++){
//         Console.Write($"{array[i]} ");
//     }
// }

// int Elements(int[] array){
//     int curr=0;
//     for(int i=0; i < array.Length; i++){
//         if(array[i] % 2 == 0) {
//            curr++; 
//         }            
//     }      
//     return curr;      
// }

// Console.Write("Размер массива: ");
// int size=Convert.ToInt32(Console.ReadLine());
// int[] array=RandomArr(size);
// ShowArray(array);
// Console.WriteLine();
// int count=Elements(array);
// Console.WriteLine("Четных чисел: " + count);   



// Задать одномерный массив, заполненный случайными числами.
// Найти сумму эл-в, стоящих на нечетных позициях

// int[] Change(int size){
//     int[] array=new int[size];
//     for(int i=0; i<size; i++){
//         array[i]=new Random().Next(0,10);
//     }
//     return array;
// }

// void ShowArray(int[]array){
//     for(int i=0; i < array.Length; i++){
//         Console.Write($"{array[i]} ");
//     }
// }

// int Elements(int[] array){
//     int sum=0;
//     for(int i=0; i < array.Length; i++){
       
//         if(i % 2 != 0){
//             sum=sum + array[i];  
//         }        
//     }      
//     return sum;      
// }

// Console.Write("Размер массива: ");
// int size=Convert.ToInt32(Console.ReadLine());
// int[] array=Change(size);
// ShowArray(array);
// Console.WriteLine();
// int sum=Elements(array);
// Console.WriteLine("Чисел на нечетных позициях: " + sum);   


// Задать массив вещественных чисел (от -бесконечности до +бесконечности)
// Найти разницу между мах и мин элементами массива.

// int[]  Change(int size){
//     int[] array=new int[size];
//     for(int i=0; i < array.Length; i++){
//         array[i]=Convert.ToInt32(new Random().Next(-100,100));
//     } 
//     return array;
// }

// void ShowArray(int[]array){
//     for(int i=0; i < array.Length; i++){
//         Console.Write($"{array[i]} ");
//     }
// }

// int Elem1(int[] array){
//     int max=0;
//     for(int i=0; i < array.Length; i++){  
//         if(array[i] > max) max = array[i];   
//     }            
//     return max;      
// }

// int Elem2(int[] array){
//     int min=0;
//     for(int i=0; i < array.Length; i++){
//         if(array[i] < min) min=array[i];  
//         }             
//     return min;      
// }

// Console.Write("Размер массива: ");
// int size=Convert.ToInt32(Console.ReadLine());
// int[] array=Change(size);
// ShowArray(array);
// Console.WriteLine();
// int max=Elem1(array);
// Console.WriteLine("max: " + max);   
// int min=Elem2(array);
// Console.WriteLine("min: " + min); 
// Console.WriteLine("Разницу между маx и мин элементом массива: " + (max - min));
#   S e m i n a r 6 _ D Z  
 