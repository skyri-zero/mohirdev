/*
1. Doira yuzi va aylana uzunligini hisoblash
    Console dan raduisni qiymatini oling va erkanga doiraning yuzi (S=pi*radius^2) va aylana uzunligini (L=2*pi*radius) erkanga chiqaring.
    Input: radius=3
    Output: S=28.2743338823081, L=18.8495559215388
        --------------
    Input: radius=4.23
    Output: S=56.2122031914168, L=26.5778738493697
*/

Console.Write("Enter radius: ");
double radius = Convert.ToDouble(Console.ReadLine());

var S = Math.PI * Math.Pow(radius, 2);
var L = 2 * Math.PI * radius;

Console.WriteLine($"Length = {L}, Surface = {S}");

Console.ReadLine();

/*
2. Valyuta konvertri
    Bir valyutadagi summani sumga aylantiruvchi dastur tuzing. Summa va valyuta kursini e’lon qiling va konvertatsiya qilingan summani hisoblang. Natijani ekranga chiqaring.
    Input: qiymat=2, kurs=12400 so’m
    Output: 24800 so’m
        ----------------
    Input: qiymat=7.6, kurs=12400 so’m
    Output: 94240 so’m
*/
Console.WriteLine("-------------------------------------");

Console.Write("\nEnter amount of JPY: ");
double moneyAmount = Convert.ToDouble(Console.ReadLine());
Console.Write("Value of 1 JPY(89.38) in UZS: ");
double currencyValue = Convert.ToDouble(Console.ReadLine());
var inUzbekSum = moneyAmount * currencyValue;

Console.WriteLine($"{moneyAmount} Japanese Yen equals to {inUzbekSum} Uzbek Sum");
Console.Read();

/*
3. Yoshni hisoblash
    Foydalanuvchining tug’ilgan yilini (int x) consoledan oling. Uning yoshini kunlarda ifodalang. Kabisa yilini hisobga olmang
    Input: x=2004
    Output: 6935
        -----------------
    Input: x=1996
    Output: 9855
*/

Console.WriteLine("-------------------------------------\n");

Console.Write("In what year were you born ? ");
int birthYear = Convert.ToInt32(Console.ReadLine());
int age = DateTime.Now.Year - birthYear;

Console.WriteLine($"You are {age} years old or {age * 365} days old :)");
Console.Read();




































