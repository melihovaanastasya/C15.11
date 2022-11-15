// 22. Программа проверяет пятизначное число на палиндромом.

int a=Convert.ToInt32(Console.ReadLine());
int a1,a2,a4,a5;
a1=a/10000;
a2=(a%10000)/1000;
a4=(a%100)/10;
a5=a%10;
if ((a1==a5) && (a2==a4)) System.Console.WriteLine("палиндром");
else System.Console.WriteLine("no");