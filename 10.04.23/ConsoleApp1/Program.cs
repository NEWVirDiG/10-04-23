﻿/*
 * базовый класс Fourangle
 * 1-й производный класс Parallelogram (Fourangle)
 * 2-й производный класс Rhomb (Parallelogram)
 * 3-й производный класс Rectangle (Fourangle)
 * 4-й производный класс Square (Rectangle)
 * 5-й производный класс Trapezoid (Fourangle)
 */
using FourangleClasses.Classes;

//Console.WriteLine("ЧЕТЫРЕХУГОЛЬНИК");
//ClsFourangle fourangle1 = new ClsFourangle();
//fourangle1.KeyboardInput();
//fourangle1.SidesCalculation();
//fourangle1.DiagonalsCalculation();
//Console.WriteLine($"Периметр = {fourangle1.Perimetr()}");

Console.WriteLine("ЧЕТЫРЕХУГОЛЬНИК 2");
ClsFourangle fourangle2 = new ClsFourangle(-5, 4, 8, 6, 9,-4,-4,-3);

fourangle2.SidesCalculation();
fourangle2.DiagonalsCalculation();
Console.WriteLine($"Периметр ={fourangle2.Perimetr()}");

ClsParallelogram parall = new ClsParallelogram();
parall.KeyboardInput();
parall.SidesCalculation();
parall.DiagonalsCalculation();
Console.WriteLine($"Периметр ={parall.Perimetr()}");

Console.WriteLine($"Площадь ={parall.Ploshad()}");
