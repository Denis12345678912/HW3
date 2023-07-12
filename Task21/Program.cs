// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве
//A(3,6,8); B(2,1,-7) ->15.84
//A(7,-5,0); B(1,-1,9) -> 11.53


 void GetCoordinates(int aX, int aY, int aZ,  int bX, int bY, int bZ )
 {
    double distance = Math.Sqrt(Math.Pow(aX-bX, 2) + Math.Pow(aY-bY, 2)  + Math.Pow(aZ-bZ, 2));
    Console.WriteLine($"Расстояние между двух точек: {distance}!");
 }

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}


int aX = GetInput("Введите координату A: по оси X: ");
int aY = GetInput("Введите координату A: по оси Y: ");
int aZ = GetInput("Введите координату A: по оси Z: ");
int bX = GetInput("Введите координату B: по оси X: ");
int bY = GetInput("Введите координату B: по оси Y: ");
int bZ = GetInput("Введите координату B: по оси Z: ");

 GetCoordinates(aX, aY, aZ, bX, bY, bZ);