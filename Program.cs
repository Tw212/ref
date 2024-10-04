// See https://aka.ms/new-console-template for more information
/*int a=10, b=20;
BytPlats(ref a, ref b);
Console.WriteLine(a+" "+b);


static void BytPlats(ref int a, ref int b){
   int temp = a;
   a=b;// a:10   b:20
   b=temp;// a:20   b:20
}*/


/*float a=7.5F;
int b=2;
BytPlats(ref a, ref b);
Console.WriteLine(Math.Pow(a,b));


static void BytPlats(ref float a, ref int b){
  
}*/

using System.Runtime.Intrinsics.X86;

Console.WriteLine("Skriv din längd och vikt så räknar vi ut din BMI");
Console.ReadLine();
float b = 0, input;
float c = 0;
float BMI = (b*b)/c;
Console.WriteLine("din bmi är " + (BMI));