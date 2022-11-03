﻿
using System.Numerics;
using WorkWithArrays;
using Vector = WorkWithArrays.Vector;

Vector vector1 = new Vector(20);
vector1.InitRandom(1, 5);

Console.WriteLine(vector1);

Pair[] pairs = vector1.CalcFrequency();

for (int i = 0; i < pairs.Length; i++)
{
    Console.WriteLine(pairs[i] + " ");
}
Console.WriteLine();
Console.WriteLine("Longest frequency is: " + vector1.LongestFrequency(pairs));

Vector vector2 = new Vector(6);
vector2.InitShuffle();

Console.WriteLine(vector2);

Vector vector3 = new Vector(10);
vector3.InitRandom(1, 20);
Console.WriteLine(vector3);
vector3.SplitMergeSort();
Console.WriteLine(vector3);

Vector a = new Vector(3);
a.InitRandom(1, 50);

Vector b = new Vector(5);
b.InitRandom(1, 50);

Vector c = a + b;
Vector d = a + 5;

d += 5;

int ai = a;
Vector e = new Vector(10);
e = 5;

Console.WriteLine("a = " + a);
Console.WriteLine("b = " + b);
Console.WriteLine("c = " + c);
