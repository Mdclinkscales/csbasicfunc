using System;
using System.Collections.Generic;

namespace basicfunc
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] arr = {2,6,8,3,-12,2,9};
            Console.WriteLine(NumToString(arr));
        }
        public static void PrintNumbers(){
            for(int i = 1; i<=255; i++){
                Console.WriteLine(i);
            }
        }
        public static void PrintOdds(){
            for(int i = 1; i<=255; i++){
                if(i%2==1){
                    Console.WriteLine(i);
                }
            }
        }
        public static void PrintSum(){
            int sum = 0;
            for(int i = 0; i<=255; i++){
                Console.WriteLine("New Number:" + i);
                sum = sum+i;
                Console.WriteLine("Sum:" + sum);
            }
        }
        public static void LoopArray(int[] numbers){
            foreach(int number in numbers){
                Console.WriteLine(number);
            }
        }
        public static int FindMax(int[] numbers){
            int max = numbers[0];
            foreach(int number in numbers){
                if(number>max){
                    max = number;
                }
            }
            return max;
        }
        public static void GetAverage(int[] numbers){
            int sum = 0;
            int count = 0;
            foreach(int number in numbers){
                sum = sum + number;
                count++;
            }
            int average = sum/count;
            Console.WriteLine(average);
        }
        public static int[] OddArray(){
            int[] odds = {};
            int oddindex = 0;
            for(int i=1; i<=255; i=i+2){
                odds[oddindex] = i;
                oddindex++;
            }
            return odds;
        }
        public static int GreaterThanY(int[] numbers, int y){
            int count = 0;
            foreach(int number in numbers){
                if(number>y){
                    count++;
                }
            }
            return count;
        }
        public static void SquareArrayVAlues(int[] numbers){
            for (int i = 0; i<numbers.Length; i++){
                numbers[i] = (numbers[i] * numbers[i]);
            }
            Console.WriteLine(numbers);
        }
        public static void EliminateNegatives(int[] numbers){
            for(int i=0; i<numbers.Length; i++){
                if(numbers[i]<0){
                    numbers[i]=0;
                }
            }
            Console.WriteLine(numbers);
        }
        public static void MinMaxAverage(int[] numbers){
            int min = numbers[0];
            int max = numbers[0];
            int sum = numbers[0];
            for (int i=1; i<numbers.Length; i++){
                sum = sum+numbers[i];
                if(numbers[i]>max){
                    max = numbers[i];
                }
                else if(numbers[i]<min){
                    min = numbers[i];
                }
            }
            Console.WriteLine(max);
            Console.WriteLine(min);
            int average = (sum/numbers.Length);
            Console.WriteLine(average);
        }
        public static void ShiftValues(int[] numbers){
            for(int i=0; i<numbers.Length-1; i++){
                numbers[i]=numbers[i+1];
            }
            numbers[numbers.Length-1]=0;
            Console.WriteLine(numbers);
        }
        public static object[] NumToString(int[] numbers){
            object[] objarr = new object[] {};
            for(int i=0; i<numbers.Length; i++){
                objarr[i] = numbers[i];
                Console.WriteLine(objarr[i]);
                //if(objarr[i] < 0){
                //    objarr[i] = "dojo";
                //}
            }
            Console.WriteLine(objarr);
            return objarr;
        }
    }
}
