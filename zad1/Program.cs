//метод считывает точки и возвращает массив с ними
int[,] readPoint()
{
    string inputLine = Console.ReadLine();

//x=34; y=-30 -> 4

string coordX = inputLine.Substring(0,inputLine.IndexOf(";"));

coordX = coordX.Substring(coordX.IndexOf("=")+1);

string coordY = inputLine.Substring(inputLine.IndexOf(";")+1);
coordY = coordY.Substring(coordY.IndexOf("=")+1);

//Console.WritLine(coordХ+" "+ coordY);

int coordX = int.Parse(coordXLine);
int coordY = int.Parse(coordYLine);

int[,] arrayOut = new int[1,2];
arrayOut[0,0] = coordХ;
arrayOut[0,2] = coordY;

return arrayOut;
}

// Печатает номер четверти
void printQuter(int[,] arreyPoint)
{
if(arreyPoint[0,0]<0&&arreyPoint[0,1]>0)
 Console.WriteLine("1 четверть");

if(arreyPoint[0,0]<0&&arreyPoint[0,1]>0)
 Console.WriteLine("2 четверть");

if(arreyPoint[0,0]<0&&arreyPoint[0,1]<0)
 Console.WriteLine("3 четверть");

if(arreyPoint[0,0]<0&&arreyPoint[0,1]<0)
 Console.WriteLine("4 четверть");
}
int[,] arreyPoint = readPoint();

printQuter(arreyPoint);

//printQuter(readPoint());
