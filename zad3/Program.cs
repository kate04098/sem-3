int coordXPointA;
int coordYPointA;
int coordXPointB;
int coordYPointB;
double lengtAB;

//Считывает координаты точек А и В
void readDataPoint()
{
Console.WriteLine("Введите координату X точки A");
int coordXPointA = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату Y точки A");
int coordYPointA = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату X точки B");
int coordXPointB = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату Y точки B");
int coordYPointB = int.Parse(Console.ReadLine());

}

//Вычисляет растояние между точками А и В
void conculateLengthAB()
{
    lengtAB = Math.Sqrt( Math.Pow((coordXPointA-coordXPointB),2)+ Math.Pow((coordXPointA-coordXPointB),2));

}
readDataOfPoint();
conculateLengAB();

Console.WriteLine(lengtAB);

