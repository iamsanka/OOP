//initialising an empty array
using System.Threading.Channels;

int[] points = new int[5];


//making for loop to get judges points and store them in array
for (int i=0; i<points.Length; i++)
{
    Console.Write($"Give points of the Judge {i+1} :");
    points[i] = Convert.ToInt32(Console.In.ReadLine());
}

int sum=points.Sum();
Console.WriteLine($"Total points are {sum}");