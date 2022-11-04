
#region ededi orta

console.writeline("araligi daxil edin:");
int num = convert.toınt32(console.readline());


int sum = 0;
int arithmeticMean = 0;



for (int i = 2; i <= num; i += 2)

{
    sum += i;
}
console.writeline("sum:");
console.writeline(sum);
edediorta = sum / (num / 2);
console.writeline("arithmetic mean:");
console.writeline(arithmeticMean);
console.readline();

#endregion

#region floor
Console.WriteLine("enter num:");
int num = Convert.ToInt32(Console.ReadLine());
int remain = 0;
int sum = 0;

while(num!= 0)
{

    remain = num % 10;
    num = (num - remain) / 10;

    Console.WriteLine("remain:");
    Console.WriteLine(remain);
    sum = sum + remain;
    


  



}
Console.WriteLine("sum:");
Console.WriteLine(sum);
Console.ReadLine();

#endregion