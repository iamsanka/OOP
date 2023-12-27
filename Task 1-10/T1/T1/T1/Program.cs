//Asking user to input value
Console.Write("Please enter your points :");
int point=Convert.ToInt32(Console.ReadLine()); //converting the entered value to int
int grade=0; //initial value of the grade variable

//cheking conditions
if (point <= 19)
{
    grade = 0;    
}else if (point <= 29)
{
    grade = 1;
}else if(point <= 39)
{
    grade = 2;
}else if (point <= 49)
{
    grade = 3;
}else if (point <= 59)
{
    grade = 4;
}else if (point <= 70)
{
    grade = 5;
}else
{
    grade = 6; //when entered amount is exceeded 70
}

if (grade < 6)
{
    Console.WriteLine($"Your Grade is {grade}");
}
else
{
    Console.WriteLine("Error in entered points!!!!");
}
