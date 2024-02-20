#region LifeHack

// Code for initializing variables, objects, etc.

#endregion
/* КИРИЛИЦЯ В КОНСОЛІ
 
 Console.OutputEncoding = Encoding.UTF8;
 Console.InputEncoding = Encoding.UTF8;
 */
/* конвертация строки класс Convert
          
            string str;

            int a, b;

            Console.WriteLine("введіть перше число");
            str = Console.ReadLine();
            a = Convert.ToInt32(str);
            Console.WriteLine("введіть друге число");
            str = Console.ReadLine();
            b = Convert.ToInt32(str);
            int c = a + b;
            Console.WriteLine("сума чисел дорівнює " + c);
*/
/*       замена символа на запятую (конвертация в дробное число)

string str = "1.7";
NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
{
    NumberDecimalSeparator = ".", //заміна крапки на кому
};
double a = Convert.ToDouble(str, numberFormatInfo);//для вірної конвертації
Console.WriteLine(str);*/
/* # 7 конвертация строки класс Parse, TryParse
 
          Console.WriteLine("wonebud");
          string str = Console.ReadLine();
          int a;

          bool result = int.TryParse(str, out a);
          if (result)
          {
              Console.WriteLine("zbs, znachenie = " + a);//success conversation
          }
          else
          {
              Console.WriteLine("yarik bachok potik!");//conversation failed
          }

        типа лайтовый конвертер

string str = Console.ReadLine();
try
{
    int a = Convert.ToInt32(str);
    Console.WriteLine(" Success convertation");

}
catch (Exception)
{
    Console.WriteLine("Convertation error");
}
          */
/* консоль не закрывайся
*
*  Console.ReadLine();//шоб курва консоль не закривалась
*
*/
/* ХВ 1.1 среднее арифметическое

my solution

          string str;

          int a, b;


          Console.WriteLine("введіть перше число");
          str = Console.ReadLine();
          a = Convert.ToInt32(str);
          Console.WriteLine("введіть друге число");
          str = Console.ReadLine();
          b = Convert.ToInt32(str);
          double result = (double)(a + b)/2;
          Console.WriteLine("seredne aryfmetychne dorivnue " + result);

better solution

          double firstValue, secondValue;
          Console.WriteLine("vvedite chislo 1");
          firstValue = double.Parse(Console.ReadLine());
          Console.WriteLine("vvedite chislo 2");
          secondValue = double.Parse(Console.ReadLine());
          double result = (firstValue + secondValue) / 2;
          Console.WriteLine("srednee arifmeticheskoe chislo ravno " + result);
          */
/* ХВ 1.2 простые матем действия над 3 числами

my solution

    string str;

    int a, b, c;


    Console.WriteLine("введіть перше число");
    str = Console.ReadLine();
    a = Convert.ToInt32(str);
    Console.WriteLine("введіть друге число");
    str = Console.ReadLine();
    b = Convert.ToInt32(str);
    Console.WriteLine("введіть trete число");
    str = Console.ReadLine();
    c = Convert.ToInt32(str);
    double result = (double) (a + b + c);
    Console.WriteLine("suma dorivnue " + result);
    double result2 = (double)(a / b / c);
    Console.WriteLine("dobutok vsih chysel dorivnue " + result2);


better solution

            double firstValue, secondValue, thirdValue;
            Console.WriteLine("vvedite chislo 1");
            firstValue = double.Parse(Console.ReadLine());
            Console.WriteLine("vvedite chislo 2");
            secondValue = double.Parse(Console.ReadLine());
            Console.WriteLine("vvedite chislo 3");
            thirdValue = double.Parse(Console.ReadLine());
            double sumResult = (firstValue + secondValue + thirdValue);
            double multiResult = (firstValue * secondValue * thirdValue);
            Console.WriteLine("suma " + sumResult);
            Console.WriteLine("proizvedenie " + multiResult);
        

*/
/* ХВ 1.3 конвертер валют

my solution

    string str;
    double a, b2, eur2;
    Console.WriteLine("Вас вітає конвертер гривень в долари і євро. Яку суму грн конвертуємо???");
    str = Console.ReadLine();
    a = Convert.ToInt32(str);
    b2 = 26.7648; // prodaja usd
    eur2 = 31.3649; //prodaja eur
    double result2 = (int)(a / b2);
    Console.WriteLine("продаж usd = " + result2 + " usd");
    double result4 = (int)(a / eur2 );
    Console.WriteLine("продаж eur = " + result4 + " eur");

better solution

            double UaHtoUsd = 26.28, UahtoEur = 31.47, UAH;
            Console.WriteLine("vvedite summu v UAH");
            UAH = double.Parse(Console.ReadLine());
            Console.WriteLine(UAH + " v EUR = " + UAH / UahtoEur);
            Console.WriteLine(UAH + " v USD = " + UAH / UaHtoUsd);
*/
/* Инкремент/декремент (прстфиксный и префиксный)
  
    int a = 1;
            a = ++a * a; //сначала префиксный инкремент = (1+1)*2=4
            a = a++ * a; //= 1*1+1=3 (сначала умножение потом постфиксный инкремент                    
            Console.WriteLine(a);
*/
/* операторы отношений и операции сравнений

            int a = 5;
            int b = 4;
            Console.WriteLine(a == b); dorivnue
            Console.WriteLine(a != b); ne dorivnue
            Console.WriteLine(a > b); bil'she
            Console.WriteLine(a < b); menshe
            Console.WriteLine(a >= b); bil'she abo dorivnue
            Console.WriteLine(a <= b); menshe abo dorivnue

*/
/* XB 2 проверка чисел на чётность if else
//old solution
            int a;
            Console.WriteLine("sistema proverki chisel na chetnost");
            a = int.Parse(Console.ReadLine());

            if (a % 2 == 0)
            {
                Console.WriteLine("chetnoe chislo");
            }
            else
            {
                Console.WriteLine("ne chetnoe chislo");
//gigabrain solution

string firstValue = Console.ReadLine();
            double check;
            bool result = double.TryParse(firstValue, out check);
            if (result)
            {
                if (check % 2 == 0)
                {
                    Console.WriteLine($"{firstValue} parne chyslo");
                }
                else
                {
                    Console.WriteLine($"{firstValue} neparne chyslo");
                }

            }
            else
            {
                Console.WriteLine($"{firstValue} nevirna huynia, ce ne chyslo!!!");
            
            }
*/
/* логические операторы "&& ||, & |" (перегрев компа)
 * 
 * && Сокращенное И
 * || Сокращенное ИЛИ
 * &  И
 * |  ИЛИ
 * !  НЕ (унарный)
 * 
 
        public static bool GetTemperature()

        {
            return false;
        } 
        public static bool GetCoolingStatus()
        {
            return true;
        }
        static void Main(string[] args)
        {
            if (GetTemperature() & GetCoolingStatus())
            {
                Console.WriteLine("ugroza povrejdeniya processora!");


    
*/
/* ХВ 3 КАЛЬКУЛЯТОРЫ + omegaBRAIN
first solution

double firstNum, secondNum;
            string calc;
            Console.WriteLine("введіть перше число");
            firstNum = double.Parse(Console.ReadLine());
            Console.WriteLine("яку математичну дію застосуємо?");
            calc = Console.ReadLine();
            Console.WriteLine("введіть друге число");
            secondNum = double.Parse(Console.ReadLine());            
            switch (calc)
            {
                case "+":                    
                    Console.WriteLine("сумма дорівнює " + (firstNum + secondNum));
                    break;
                case "-":                                                                            
                    Console.WriteLine("різниця дорівнює " + (firstNum - secondNum));
                    break;
                case "*":
                    Console.WriteLine("добуток дорівнює " + (firstNum * secondNum));
                    break;
                case "/":                      
                    Console.WriteLine("частка дорівнює " + (firstNum / secondNum));
                    break;
                default:
                    Console.WriteLine(" не вірна математична дія");
                    break;

second solution*
                
                double valueOne, valueTwo;
                Console.WriteLine("vvedit perwe chyslo");
                valueOne = double.Parse(Console.ReadLine());
                Console.WriteLine("yaku matem diyu zastosuemo?");
                string calc = Console.ReadLine();
                Console.WriteLine("vvedit druge chyslo");
                valueTwo = double.Parse(Console.ReadLine());
                if (calc == "+")
                {
                    Console.WriteLine("suma dorivnue: " + (valueOne + valueTwo));
                }
                else if (calc == "-")
                {
                    Console.WriteLine("riznycua dorivnue: " + (valueOne - valueTwo));
                }
                else if (calc == "*")
                {
                    Console.WriteLine("dobutok dorivnue: " + (valueOne * valueTwo));
                }
                else if (calc == "/")
                {
                    if (valueTwo == 0)
                        Console.WriteLine(0);
                    else
                        Console.WriteLine("chastka dorivnue: " + (valueOne / valueTwo));
                }
//omegasolution
 Console.WriteLine("welcome to 12iq calculator\n\nenter first number");

            double check;
            string firstValue = Console.ReadLine();
            bool convert = double.TryParse(firstValue, out check);
            if (convert)
            {
            }
            else
            {
                Console.WriteLine($"ERROR! {firstValue} isn't number, stupid DUMBASS");
            }
            
            Console.WriteLine("what mathematical operation are we going to use");
            string operation = Console.ReadLine();  
            switch (operation)
            {
                case "/":
                    Console.WriteLine($"{firstValue} {operation}");
                    break;
                case "*":
                    Console.WriteLine($"{firstValue} {operation}");
                    break;
                case "-":
                    Console.WriteLine($"{firstValue} {operation}");
                    break;
                case "+":
                    Console.WriteLine($"{firstValue} {operation}");
                    break;
                    
                default:
                    Console.WriteLine("ERROR! wrong operation");
                    break;
            }
            Console.WriteLine("second number");
            string secondValue = Console.ReadLine();
            double check2;
            bool convert2 = double.TryParse(secondValue, out check2);

            if (convert2)
            {
                if (operation == "/")
                {
                    if (check2 == 0)
                    {
                        Console.WriteLine("UNFORTUNATELY YOUR IQ IS LOWER THAN 12, YOU CAN'T DIVIDE BY ZERO");
                    }
                    Console.WriteLine($"so {firstValue} {operation} {secondValue} equals " + (check / check2));
                    

                }
                else if (operation == "*")
                {
                    Console.WriteLine($"so {firstValue} {operation} {secondValue} equals " + (check * check2));
                }
                else if (operation == "-")
                {
                    Console.WriteLine($"so {firstValue} {operation} {secondValue} equals " + (check - check2));
                }
                else if (operation == "+")
                {
                    Console.WriteLine($"so {firstValue} {operation} {secondValue} equals " + (check + check2));
                }
            }  
           
         
            else
            {
                Console.WriteLine($"ERROR! {secondValue} isn't number, stupid DUMBASS ");
            }
            

        }
using diff variations 
{
            Console.WriteLine("welcome to 12iq calculator\n\nenter first number");

            double check;
            string firstValue = Console.ReadLine();
            bool convert = double.TryParse(firstValue, out check);
            Console.WriteLine("second number");
            string secondValue = Console.ReadLine();
            double check2;
            bool convert2 = double.TryParse(secondValue, out check2);
                      
            Console.WriteLine("what mathematical operation are we going to use");
            string operation = Console.ReadLine();
            switch (operation)
            {
                case "/":
                    Console.WriteLine(check / check2);
                    break;
                case "*":
                    Console.WriteLine(check * check2);
                    break;
                case "-":
                    Console.WriteLine(check - check2);
                    break;
                case "+":
                    Console.WriteLine(check + check2);
                    break;

                default:
                    Console.WriteLine("ERROR! wrong operation");
                    break;
            }
            if (operation == "/")
            {
                Console.WriteLine(check / check2);
            }
            else if (operation == "*")
            {
                Console.WriteLine(check * check2);
            }
            else if (operation == "-")
            {
                Console.WriteLine(check * check2);
            }
            else if (operation == "+")
            {
                Console.WriteLine(check * check2);
            }
        }

*/
/* XB 3 GIGA CALC (using switch) while try cath/if else
 solution using switch

                while (true)// цикл повтору
            {
                Console.Clear();
                double firstNum, secondNum;
                string calc;
                try
                {
                    Console.WriteLine("введіть перше число");
                    firstNum = double.Parse(Console.ReadLine());                 
                    Console.WriteLine("введіть друге число");
                    secondNum = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("я умію рахувати лише цифри");
                    Console.ReadLine();
                    continue;                    
                }
                Console.WriteLine("яку математичну дію застосуємо? ('+' '-' '*' '/')");                                
                calc = Console.ReadLine();               
                switch (calc)
                {
                    case "+":
                        Console.WriteLine("сумма дорівнює " + (firstNum + secondNum));
                        break;
                    case "-":
                        Console.WriteLine("різниця дорівнює " + (firstNum - secondNum));
                        break;
                    case "*":
                        Console.WriteLine("добуток дорівнює " + (firstNum * secondNum));
                        break;
                    case "/":
                        if (secondNum == 0)                        
                        Console.WriteLine("частка дорівнює " + (0));                
                        else
                        Console.WriteLine("частка дорівнює " + (firstNum / secondNum));
                        break;
                    default:
                        Console.WriteLine(" не вірна математична дія");
                        break;
                }
                Console.ReadLine();
            }           
*/
/* XB 3 GIGA CALC (using if else) while try cath
            while (true)// цикл повтору
            {
                Console.Clear();
                double firstNum, secondNum;
                string calc;
                try
                {
                    Console.WriteLine("введіть перше число");
                    firstNum = double.Parse(Console.ReadLine());
                    Console.WriteLine("введіть друге число");
                    secondNum = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("я умію рахувати лише цифри");
                    Console.ReadLine();
                    continue;
                }
                Console.WriteLine("яку математичну дію застосуємо? ('+' '-' '*' '/')");
                calc = Console.ReadLine();
                if (calc == "+")
                {
                    Console.WriteLine("suma dorivnue: " + (firstNum + secondNum));
                }
                else if (calc == "-")
                {
                    Console.WriteLine("riznycua dorivnue: " + (firstNum - secondNum));
                }
                else if (calc == "*")
                {
                    Console.WriteLine("dobutok dorivnue: " + (firstNum * secondNum));
                }
                else if (calc == "/")
                {
                    if (secondNum == 0)
                        Console.WriteLine(0);
                    else
                        Console.WriteLine("chastka dorivnue: " + (firstNum / secondNum));
                }
                else
                    Console.WriteLine("не вірна математична дія ");
                Console.ReadLine();
            }
*/
/* ХВ 4 цикл while подсчет чётных и нечётных чисел в диапазоне

bad solution
            
            int count = 0;
            int limit = int.Parse(Console.ReadLine());
            while (count < limit)
            {
                count++;
                if (count % 2 == 0)
                {                    
                    Console.WriteLine(count + " chetnoe chislo");
                }
                else
                {
                    Console.WriteLine(count + " ne chetnoe chislo");
                }
            }
dumbest solution ever!

            int a;
            Console.WriteLine("sistema proverki chisel na chetnost");
            a = int.Parse(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine((a / 2) + " chetnih chisel i " + (a / 2) + " ne chetnih");
            }
            else
            {
                Console.WriteLine((a - 1) / 2 + " chetnih chisel i " + ((a + 1)/2) + " ne chetnih");
            }
Giga brain solution

            uint oddNumbersCount = 0;//счётчик нечётных чисел
            uint evenNumbersCount = 0;//счётчик чётных чисел
            int oddNumbersSum = 0;
            int evenNumbersSum = 0;
            Console.WriteLine("pevoe chislo diapazona");
            int currentValue = int.Parse(Console.ReadLine());
            Console.WriteLine("poslednee chislo diapazona");
            int limit = int.Parse(Console.ReadLine());
            while (currentValue <= limit)
            {
                if (currentValue % 2 == 0)
                {                    
                    evenNumbersCount++;
                    evenNumbersSum += currentValue;
                }
                else
                {
                    oddNumbersCount++;
                    oddNumbersSum = oddNumbersSum + currentValue;                    
                }
                currentValue++;
            }
            Console.WriteLine("Kolichestvo ne chetnih chisel: " + oddNumbersCount);
            Console.WriteLine("Kolichestvo chetnih chisel: " + evenNumbersCount);
            Console.WriteLine("Summa ne chetnih chisel: " + oddNumbersSum);
            Console.WriteLine("Summa chetnih chisel: " + evenNumbersSum);
            Console.ReadLine();
*/
/* # 17 цикл do while
  
            int count = 0;
            do
            {
                count++;//выполняется до
                Console.WriteLine(count);
            }
            while (count < 5);//этого момента
 */
/* # 18 цикл for

            int limit = int.Parse(Console.ReadLine());
            for (int i = 0; i < limit; i++)//  разница между while - область видимости переменной.
            {                              // фор - обьявление переменной в теле цикла, не засоряет, существует в рамках работы цикла
                Console.WriteLine(i);       // вайл - за пределами цикла может путать и мещать, есть возможность изменения
            }
            Console.ReadLine();
*/
/* # 19 цикл for в обратном порядке, несколько переменных, несколько условиий
 *
            int limit = int.Parse(Console.ReadLine());
            for (int i = 0; i < limit; i++)
            { 
                Console.WriteLine(i); 
            }
            for (; ;)
            {
                console.writeline("for is working lul");
                system.threading.thread.sleep(300);
                break;
            }
            console.readline();
*
* переменная i за циклами чтоб оба цикла for ёё видели
            int i = 0;
            for (; i < 3; i++)
            {
                Console.WriteLine("for_1: " + i);
            }
            for (; i < 5; i++)
            {
                Console.WriteLine("for_2: " + i);
            }
            Console.ReadLine();

            for (int i = 0; i < 5;)
            {                           //i++; если написать инкремент до вывода - 4
                Console.WriteLine(i);
                i++;                    //i++; если написать инкремент после вывода - 5
            }
            Console.ReadLine();

            for (int i = 0,j=5; i < 10 && j<12; i++,j++)
            {
                Console.WriteLine("i: " + i);
                Console.WriteLine("j: " + j);
            }

            for (int i = 5; i >= 0; i--)
            {
                Console.WriteLine(i);
            }

            int i = int.Parse(Console.ReadLine());// в обратном порядке
            for (; i >= 0; i--)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();

            for (int i = 0, j = 5; i < 5; i++, j--)
            {
                Console.WriteLine("i: " + i);
                Console.WriteLine("j: " + j);
            }
            Console.ReadLine();
 */
/* # 20 break прерывание цикла (for, while, do while, for each)
                for (int i = 0; i < 100; i++)
            {
                string quit = Console.ReadLine();
                if (quit == "exit")
                {
                    break;
                }
                Console.WriteLine(i);
            }
            Console.ReadLine();
 */
/* # 21 continue прерывание текущей итерации цикла но не прирывание всего цикла - переход к следущей итерации
            for (int i = 0; i < 5; i++)
            {
                if (i == 2)// 2 в консоль не выводится
                {
                    continue;//когда = 2 - начинается выполнение следущей итерации
                }
                Console.WriteLine(i);
            }
            Console.ReadLine();
 */
/* # 22 вложенные циклы (вложенные конструкции)
 * 
    цикл внутри цикла внутри цикла
 
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("цикл 1 итерация №: " + i);
                for (int j = 1; j <= 4; j++)
                {
                    Console.WriteLine("\tцикл 2 итерация №: " + j);// \t = tab
                    for (int q = 1; q <= 2; q++)
                    {
                        Console.WriteLine("\t\tцикл 3 итерация №: " + q);
                    }
                }
            }
            Console.ReadLine();

    прямоугольник

            Console.Write("введите высоту прямоугольника: ");
            int height = int.Parse(Console.ReadLine());
            Console.Write("введите ширину прямоугольника: ");
            int width = int.Parse(Console.ReadLine());
            for (int j = 0; j < height; j++)
            {
                for (int i = 0; i < width; i++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }            
            Console.ReadLine();
advanced things
    static int [,] GetRandomArray(int rows, int columns)
        {
            Random random = new Random();
            var result = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    result[i, j] = random.Next(100);
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            int rows = 10;
            int columns = 5;
            var myArray = GetRandomArray(rows, columns);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{myArray[i,j]}\t");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
 */
/* ХВ № 5 треуугольники
 
 * scamed solution
 * 
 *          int count1 = 1; int count2 = 10;
            int count3 = 1; int count4 = 10;
            int mn = 10;

//Первый треугольник
            for (int i = 0; i < 10; i++)
            {

                for (int j = 0; j < count1; j++)
                {
                    Console.Write("#");

                }

                count1 += 1;
                Console.WriteLine();
            }

            Console.WriteLine();

//Второй треугольник
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < count2; j++)
                {
                    Console.Write("#");
                }

                count2 -= 1;
                Console.WriteLine();
            }

            Console.WriteLine();

//Третий треугольник
            for (int i = 0, k = 1; i < 10; i++)
            {
                string s = new string(' ', mn - k);
                k += 1;
                Console.Write(s);

                for (int j = 0; j < count3; j++)
                {

                    Console.Write("#");
                }

                count3 += 1;
                Console.WriteLine();
            }

            Console.WriteLine();

//Четвёртый треугольник
            for (int i = 0, k = 10; i < 10; i++)
            {
                string s = new string(' ', mn - k);
                k -= 1;
                Console.Write(s);

                for (int j = 0; j < count4; j++)
                {

                    Console.Write("#");
                }

                count4 -= 1;
                Console.WriteLine();
            }*/
/* ХВ № 5 BEST SOLUTION (my)
           Console.Write("vysota trykutnyka: ");
            int height = int.Parse(Console.ReadLine());
            //first triangle
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("x");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            //second triangle
            for (int i = 1; i <= height; i++)
            {
                for (int j = height; j >= i; j--)
                {
                    Console.Write("x");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            //third triangle
            for (int i = 0; i <= height; i++)
            {
                for (int j = height; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write("x");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            //fourth triangle
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = height; j > i; j--)
                {
                    Console.Write("x");
                }
                Console.WriteLine();
            }
            Console.WriteLine();                
 */
/* 31.01.2023
  Console.WriteLine("we gonna draw triangle using:");
            string bullShit = Console.ReadLine();
            Console.WriteLine("enter length of your triangle");
            int length = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int i = 0; i < length; i++)
            {
                for (int j = i; j >= 0; j--)
                {
                    Console.Write(bullShit);
                }

                Console.WriteLine();
            }
            Console.WriteLine();
      //2nd
            for (int i = 0; i < length; i++)
            {
                for (int j = i; j < length; j++)
                {
                    Console.Write(bullShit);
                }

                Console.WriteLine();
            }
            Console.WriteLine();

      //3d     
            for (int i = 0; i <= length; i++)
            {
                for (int j = i; j < length; j++)
                {
                    Console.Write(" ");
                   

                }
                for (int j = i; j > 0; j--)
                {
                    Console.Write(bullShit);
                }
                Console.WriteLine();      
            }
            Console.WriteLine();
      //4th
            for(int i = 0; i < length; i++)
            {
                Console.WriteLine(" ");
                for (int j = i; j > 0; j--)
                {
                    Console.Write(" ");
                }
                for (int j = i; j < length; j++)
                {
                    Console.Write(bullShit);
                }           

                

            }
            Console.WriteLine();
 */
/* +bonus перевод курсора
            Console.Write("введите высоту треугольника: ");
            int height = int.Parse(Console.ReadLine());
//first triangle v.2
            for (int i = 0; i < height; i++)
            {
                Console.SetCursorPosition(height - i, i + 1);
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("x");
                }
                
            }
            Console.ReadLine();
 */
/* # 23 тернарный оператор
 [первый операнд - условие] ? [второй операнд if_true] : [третий операнд if_false]

            bool accessAllowed;
            Console.WriteLine("enter password");
            string storedPassword = "qwerty";
            string enterPassword = Console.ReadLine();
            //if (enterPassword == storedPassword)
            //{
            //    accessAllowed = true;               
            //}
            //else
            //{
            //    accessAllowed = false;                
            //}

            accessAllowed = enterPassword == storedPassword ? true : false; // тот же иф елс что закоммент
            Console.WriteLine(accessAllowed);

            int inputData = int.Parse(Console.ReadLine());
            int outputData = (inputData < 0) ? 0 : inputData;
            Console.WriteLine(outputData);
            Console.Read();
 */
/* # 24 Массивы
        Одномерные массивы
        Тип_элементов_массива [] имя_массива;
null - дефолтное значение для ссылочных типов, отсутствие ссылки ссылочного типа на какие-либо данные

            int[] myArray;          //обьявление массива
            myArray = new int[5];   //размер массива
            myArray[1] = 3;         //обьявление переменных
            myArray[0] = 10;
            int a = myArray[0];     //извлечение переменной
            Console.WriteLine(a);
            //Console.WriteLine(myArray[0]);
            Console.ReadLine();

            int[] myArray;
            myArray = new int[123123];            
            Console.WriteLine(myArray.Length);  //выводит в консоль длину массива          
            Console.ReadLine();

 
 */
/* # 25 инициализация массива
            int[] myArray = new int[] {5,6,9,7,};

            int[] myArray = {5,6,};

            int[] myArray = Enumerable.Repeat(5,10).ToArray(); // создаст массив где 10 переменных со значением 5

            int[] myArray = Enumerable.Range(4,5).ToArray(); // создаст 5 переменных со значениями 4, 5, 6, 7, 8
 */
/* # 26 Массивы и циклы
 * 
            int[] myArray = { 10, 3, 2, 55, 8 };
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }

            Console.ReadLine();
 */
/* XB № 6 Массивы
                1 заполнить массив с клавиатуры
                2 вывести массив в обратном порядке
                3 найти сумму четных чисел в массиве
                4 найти наименьшее число в массиве
My first solution
            Console.WriteLine("enter lenght of array");
            int sizeOfArray = int.Parse(Console.ReadLine());      
            int[] myArray = new int [sizeOfArray].ToArray();
            int varPosition = 0;
            int varcount = 1;
            uint evenNumbersCount = 0;
            int evenNumbersSum = 0;
            
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine("enter var of array № " + varcount++);
                int variable = int.Parse(Console.ReadLine());
                myArray[varPosition] = variable;
                varPosition++;
                
            }
            Console.WriteLine();            
            Console.WriteLine("new array:");

            for (int i = 0; i < myArray.Length; i++)
            {               
                Console.WriteLine(myArray[i]);
                
            }
BEST SOLUTION
 1 заполнить массив с клавиатуры

            Console.Write("enter lenght of array ");
            int elementCount = int.Parse(Console.ReadLine());
            int[] myArray = new int [elementCount];
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write($"\nenter element of array {i}:\t");
                myArray[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\nYour array");
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }
2 вывести массив в обратном порядке  

            Console.Write("enter lenght of array ");
            int elementCount = int.Parse(Console.ReadLine());
            int[] myArray = new int[elementCount];
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write($"\nenter element of array with index {i}:\t");
                myArray[i] = int.Parse(Console.ReadLine());
            }
            
            Console.WriteLine("\nYour array");
            //when the magic starts (myArray.Lenght - 1!!!)
            for (int i = myArray.Length -1 ; i >= 0; i--)
            {
                Console.WriteLine(myArray[i]);
            }
3 найти сумму четных чисел в массиве
            int[] myArray = { 2, 3, 99, 49, 64, 77, 4, 42, 5 };
            int result = 0;

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] % 2 ==0)
                {
                    result += myArray[i];
                }
                
            }
            Console.WriteLine(result);

            Console.ReadLine();     
4 найти наименьшее число в массиве
             int[] myArray = {111, 5152, 4, 99, 49, 64, 77, 4, 42, 5 };
            int minValue = myArray[0];

            for (int i = 1; i < myArray.Length; i++)
            {
                if (myArray[i] < minValue)
                {
                    minValue = myArray[i];
                }
            }
            Console.WriteLine(minValue);
            Console.ReadLine();

MY GIGA BRAIN SOLUTION
            Console.WriteLine("vvedite razmer massiva");
            int[] myArray = new int[int.Parse(Console.ReadLine())];
            Console.WriteLine("razmer massiva " + myArray.Length);
            int arrayElementCount = 1;
            int evenElementCount = 0;
            int evenElementSum = 0;
            
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine("vvedite element massiva nomer " + arrayElementCount++);
                myArray[i] = int.Parse(Console.ReadLine());
                if ((myArray[i]) % 2 == 0)
                {
                    evenElementCount++;
                    evenElementSum +=  myArray[i];
                }
            }
            Console.WriteLine("vash massiv v obratnom poriadke:");
            for (int i = (myArray.Length-1); i >= 0; i--)
            {
                Console.WriteLine(myArray[i]);
            }
            Console.WriteLine("kolichestvo nechetnih chisel ravno " + evenElementCount);
            Console.WriteLine("summa nechetnih chisel ravno " + evenElementSum);
            Console.WriteLine("naimenwee chislo massiva "+myArray.Min());

            Console.ReadLine();

 */ 
/* 03.02.2023
 
  int[] myArray;
            Console.WriteLine("set length of an array");
            int sizeOfArray = int.Parse(Console.ReadLine());
            myArray = new int[sizeOfArray];
            int slotNumber = 0;
            int evenNumberSum = 0;
            

            for (int i = 0; i < myArray.Length; i++)
            {
                slotNumber++;
                Console.WriteLine($"enter number in slot " + (slotNumber));
                myArray[i] = int.Parse(Console.ReadLine());
            }
           

           
            Console.WriteLine("your array backwards is:");
            for (int i = (sizeOfArray-1); i >= 0; i--)
            {
                Console.WriteLine(myArray[i]);
                if (myArray[i] % 2 ==0)
                {
                    evenNumberSum += myArray[i];
                   
                }
                
            }
            int minimalNumberOfArray = myArray.Min();

            Console.WriteLine($"even number sum equals {evenNumberSum}");
            Console.WriteLine($"minimal number of an array is {minimalNumberOfArray}");
            Console.ReadLine();
*/
/* # 27 как работать с массивами на самом деле
            int[] myArray = { 111, 10, 4, 99, 49, 64, 77, 4, 42, 5 };

            Console.WriteLine("min " + myArray.Min());
            Console.WriteLine("max " + myArray.Max());
            Console.WriteLine("sum " + myArray.Sum());
            Console.WriteLine("even number sum " + myArray.Where(i=> i % 2 == 0).Sum());
            Console.WriteLine("odd number min " + myArray.Where(i => i % 2 != 0).Min());
            Console.WriteLine("odd number max " + myArray.Where(i => i % 2 != 0).Max());

            int[] result = myArray.Distinct().ToArray(); //ubrat' povtory

            int[] result = myArray.OrderBy(i => i).ToArray();//sortirovka

            int[] result = myArray.OrderByDescending(i => i).ToArray();//obratnaya sortirovka
            
            Array.Sort(myArray);
            int result = Array.Find(myArray, i  => i < 70);
            int result = Array.FindLast(myArray, i  => i < 70);
 */
/* # 28 индексы и диапазоны в С#8 .NetCore
 
 */
/* # 29 многомерные массивы; двумерный прямоугольный массив .NetCore
 //dot net core


             int[] myArray = { 2, 8, 22, 53, 13, 55, 77, 123 };
            //извлечение второго элемента с конца
            Console.WriteLine(myArray[^2]);
            Console.WriteLine();
            //примеры извлечений диапазонов элементов из массива с выводом на консоль
            foreach (var item in myArray[..4])
                Console.WriteLine($"{item}");
            Console.WriteLine("\n");
            foreach (var item in myArray[4..])
                Console.WriteLine($"{item}");
            Console.WriteLine("\n");
            foreach (var item in myArray[5..7])
                Console.WriteLine($"{item}");
            Console.WriteLine("\n");
 */
/* # 30 двумерный массив
 //тип_данных [,] имя_массива;

            // int[,] myArray;
            //myArray = new int[3, 5];
            int [,] myArray = // new int[3, 5] можно сократить "new int[3, 5]"
            {
                {2,45,12,51,51 },
                { 6,7,8,3,1},
                { 1,5,65,78,13}
            };
            


            Console.WriteLine((myArray[0, 2])); 

 */
/* # 31 вывод двумерного массива
               int[,] myArray = new int[,]
            {
                {2,45,12,51,51},
                {6,7,8,3,1},
                {1,5,65,78,13},
                {6,3,151,5,65},
                
            };
            //int height = myArray.GetLength(0); //количество эл в 1-м измерении (высота таблички)
            //int width = myArray.GetLength(1); //количество эл в 2-м измерении (ширина таблички)
            for (int y = 0; y < myArray.GetLength(0); y++) //height
            {
                for (int x = 0; x < myArray.GetLength(1); x++)//width
                {
                    Console.Write(myArray[y,x]+ "\t");
                }
                Console.WriteLine();
            }
 */
/* # 32 заполнение двумерного маасива случайными числами
            int[,] myArray = new int[10, 6];
            Random random = new Random();
            for (int i = 0; i < myArray.GetLength(0); i++) //height
            {
                for (int j = 0; j < myArray.GetLength(1); j++)//width
                {
                    myArray[i, j] = random.Next(100);
                }
                
            }

            for (int y = 0; y < myArray.GetLength(0); y++) //height
            {
                for (int x = 0; x < myArray.GetLength(1); x++)//width
                {
                    Console.Write(myArray[y, x] + "\t");
                }
                Console.WriteLine();

        заполнение двумерного маасива с клавиатуры
// int numerical 
            int[,] myArray = new int[2, 3];
            
            for (int i = 0; i < myArray.GetLength(0); i++) //height
            {
                for (int j = 0; j < myArray.GetLength(1); j++)//width
                {
                    Console.WriteLine("Y: " +i+" X: "+j);
                    myArray[i, j] = int.Parse(Console.ReadLine());
                }
                
            }
            Console.WriteLine();

            for (int y = 0; y < myArray.GetLength(0); y++) //height
            {
                for (int x = 0; x < myArray.GetLength(1); x++)//width
                {
                    Console.Write(myArray[y, x] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
//strings
            string[,] myArray = new string[2, 3];
            
            for (int i = 0; i < myArray.GetLength(0); i++) //height
            {
                for (int j = 0; j < myArray.GetLength(1); j++)//width
                {
                    Console.WriteLine("Y: " +i+" X: "+j);
                    myArray[i, j] = (Console.ReadLine());
                }
                
            }
            Console.WriteLine();

            for (int y = 0; y < myArray.GetLength(0); y++) //height
            {
                for (int x = 0; x < myArray.GetLength(1); x++)//width
                {
                    Console.Write(myArray[y, x] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadLine();

 */
/* # 33 Ступенчастые массивы (зубчатые)
            int[][] myArray = new int[5][];
            myArray[0] = new int[5];
            myArray[1] = new int[2];
            myArray[2] = new int[7];
            myArray[3] = new int[4];
            myArray[4] = new int[6];
            Random random = new Random();
            for (int i = 0; i < myArray.Length; i++)
            {
                for (int j = 0; j < myArray[i].Length; j++)
                {
                    myArray[i][j] = random.Next(1000);
                }
            }
            for (int i = 0; i < myArray.Length; i++)
            {
                for (int j = 0; j < myArray[i].Length; j++)
                {
                    Console.Write(myArray[i][j] + "\t");
                }
                Console.WriteLine();
            }

            Console.ReadLine();


 */
/* # 34 Трёхмерные массивы | массивы любой мерности
 //прямоугольный массив
            Random random = new Random();
            int[,,] myArray = new int[4, 3, 5];
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    for (int k = 0; k < myArray.GetLength(2); k++)
                    {
                        myArray[i, j, k] = random.Next(100);
                    }
                }
            }
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                Console.WriteLine("\t"+"Page № "+ (i +1));
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    for (int k = 0; k < myArray.GetLength(2); k++)
                    {
                        Console.Write(myArray[i, j, k] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                
            }
            Console.ReadLine();

//зубчатый массив
            Random random = new Random();
            int[][][] myArray = new int[random.Next(3,6)][][];
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = new int[random.Next(2, 6)][];
                for (int j = 0; j < myArray[i].Length; j++)
                {
                    myArray[i][j] = new int[random.Next(2, 6)];
                    for (int k = 0; k < myArray[i][j].Length; k++)
                    {
                        myArray[i][j][k] = random.Next(100);
                    }
                }
            }
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine("\t"+"Page № "+ (i +1));
                for (int j = 0; j < myArray[i].Length; j++)
                {
                    for (int k = 0; k < myArray[i][j].Length; k++)
                    {
                        Console.Write(myArray[i][j][k] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                
            }
            Console.ReadLine();



 */
/* # 35 Функции и методы
       //metod

            static int Sum(int first_value, int second_value)
        {
            

            return first_value + second_value;
        }
        static void Main(string[] args)
        {
            int a, b, c;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            c = Sum(a, b);

            Console.WriteLine(c);

            Console.WriteLine("============");

//non return
            static void Printline()
        {
            Console.WriteLine("pnh");
        }
        static void Main(string[] args) 
        {
            Printline();
            Random random = new Random();
            Console.WriteLine(random.Next());
        }
    
            
            


        }    
 */
/* # ХВ № 7 
 * 1. Написать метод который выводит на экран строку.
 * Символы из которых состоит строка и их количество вводится пользователем.
 * 
 * 2. Написать метод поиска индекса элемента массива (тип элементов в массиве -int),
 * метод должен вернуть индекс первого найденного элемента (если он будет найден).
 * 
 * 
 * my bad solution
 *      //static void PrintLine(string value)
        //{

        //    Console.Write(value);
        //}

        //static void Main(string[] args)
        //{
        //    Console.WriteLine("vvedit' symvol");
        //    string symvol = Console.ReadLine();
        //    Console.WriteLine("kiko raz vyvesty symvol?");
        //    int limit = int.Parse(Console.ReadLine());
        //    for (int i = 0; i < limit; i++)
        //    {
        //        PrintLine(symvol);
        //    }
        //    Console.ReadLine();
        //}
 * good solution
 *      static void PrintLine(string symbol, uint symbolsCount)
        {
            for (int i = 0; i < symbolsCount; i++)
            {
                Console.Write(symbol);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("vvedite simvol");
            string symbol = Console.ReadLine();
            Console.WriteLine("vvedite kolichestvo");
            uint symbolsCount = uint.Parse(Console.ReadLine());
            PrintLine(symbol, symbolsCount);
            Console.ReadLine();
        }
2 good solution
        static int IndexOf(int [] array, int value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value)
                {
                    return i;
                }
            }
            return -1;
        }

        static int[] GetRandomArray(uint length, int minValue, int maxValue)
        {
            int[] myArray = new int[length];
            Random random = new Random();
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = random.Next(minValue, maxValue);
            }
            return myArray;
        }
        static void Main(string[] args)
        {
            int[] myArray = GetRandomArray(10, -20, 10);
            int result = IndexOf(myArray, 9);
            Console.WriteLine(result);
        }
    }   
 * 
 * 
 */
/*27.02.2023
 class Program

    {
        /* # ХВ № 7 13.02.2023
         * 1. Написать метод который выводит на экран строку.
         * Символы из которых состоит строка и их количество вводится пользователем.
         * 
         * 2. Написать метод поиска индекса элемента массива (тип элементов в массиве -int),
         * метод должен вернуть индекс первого найденного элемента (если он будет найден).

// 1.
using System.Text;
using System;

static void Stroka(string symbol, uint symbolCount)
{
    for (int i = 0; i < symbolCount; i++)
    {
        Console.Write(symbol);
    }
}

static void Main(string[] args)
{
    Console.WriteLine("vvedit' symvol iz yakyh bude vash riadok");
    string vvod = Console.ReadLine();
    Console.WriteLine("vvedit' kil'kist' symvoliv u vashomu riadku");
    uint symbolSize = uint.Parse(Console.ReadLine());
    Stroka(vvod, symbolSize);
    Console.WriteLine();
}
//  2.
public static int FindIndex(int[] arr, int value)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == value)
        {
            return i;
        }
    }
    // Якщо елемент не знайдено, повертаємо -1
    return -1;
}
static int[] GetRandomArray(uint length, int minValue, int maxValue)
{
    int[] myArray = new int[length];
    Random random = new Random();
    for (int i = 0; i < length; i++)
    {
        myArray[i] = random.Next(minValue, maxValue);
    }
    return myArray;
}
//v2 first
public static void Main2(string[] args)
{
    Console.OutputEncoding = Encoding.UTF8;
    Console.InputEncoding = Encoding.UTF8;

    int[] myArray = GetRandomArray(10, -20, 10);
    Console.WriteLine("що ж ми шукатимемо? наступний код знайде індекс запитуваного значення в масиві");
    int value = int.Parse(Console.ReadLine());
    int index = FindIndex(myArray, value);
    Console.WriteLine("ваш масив:");
    for (int i = 0; i < myArray.Length; i++)
    {
        Console.WriteLine(myArray[i]);
    }
    if (index == -1)
    {
        Console.WriteLine("Стас сидить в калюжі і куре айкос");
    }
    else
    {
        Console.WriteLine("Індекс першого знайденого елемента {0}: {1}", value, index);
    }
    Console.ReadLine();

}


    }*/
/* # 36 перегрузка методов
        /// <summary>
        /// повертає суму двох чисел
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static int Sum(int a, int b) 
        { 
            return a + b;
        }
        static int Sum(int a, int b, int c) 
        {
            return a + b + c;
        
        
        }


        static void Main(string[] args)
        {
            int result = Sum(2, 3, 4);
            Console.WriteLine(result);
        
        
        }
 */
/* # 37 область видимости (контекст переменной) * конфликты одластей видимости
    class MyClass
    {
        
    }

    class Program
    {
        static int b = 11;

        static void Foo()
        {
            int b = 9;
            Console.WriteLine(b); //використовується та яка була створена в тій же області видимості
        }


        static void Main(string[] args)
        {
            Console.WriteLine();
        }
    }    
   
 */
/* # 38 ссылочные (reference types) и значимые типы (value types) // "stack" and "heap" (управляемая куча
        

        static void Foo(int value)
        {
            value = 5; //contains in stack
        }
        static void Bar(int []array) 
        {
            array[0] = 5; //contains in heap
        }
        static void Main(string[] args)
        {
           int [] a = new int [1];
            a [0]= 1;
            
           Bar(a);

            Console.WriteLine(a[0]);
        }
 * 
 */
/* # 39 null
 * 
 *       static void Foo()
        {
           
            int[] a = new int[10];
        }

        static void Main(string[] args)
        {
            Foo();
        }
 
 */
/* # 40 оператор null обьеденения
 * 
 * //if (str == null) //here is the null test
            //{
            //    Console.WriteLine("error NA");
            //}
            //else
            //{
            //    Console.WriteLine(str);
            //}

            Console.WriteLine(str ?? "error NA"); //gere is the shorter version

//interesting thing (is null exception)
            string str = "takoy zabey";//me can put null; so relust would be 0!
            string result = str ?? string.Empty;
            Console.WriteLine("amount of symbols is " + result.Length);
 */
/* # 41 оператор присваивания обьеденения со значением NULL ??=
 * //1st block
             public static void Main(string[] args)
        {
            //1st block
            string str = "test";
            str ??= string.Empty;
            Console.WriteLine("amount of symbols in string is: " + str.Length);
            Console.ReadLine();

        }


  static int[] GetArray()
        {
            //2nd block

            //int[] myArray = new int[10];// first case
            int[] myArray = new int[10];// second case
            return myArray;
        }


        public static void Main(string[] args)
        {
            int[] myArray= GetArray();
            myArray ??= new int[0];
            Console.WriteLine("amount of symbols in array is: "+myArray.Length);

        }
 */
/* # 42 оператор условного null ?.
 * //first hard case (hard to understand !!! must understand !!! very important

        static int[] GetArray()
        {
            int[] myArray = null; //or {1,2,3};
            return myArray;
        }
        public static void Main(string[] args)
        {
            int [] myArray = GetArray ();

           
            Console.WriteLine("summ of items in array is: "+ (myArray?.Sum() ?? 0 ));

        }

//second very hard case (not figured how its working tbh :( 
  class Program
    {
        static Person GetPerson()
        {
            Person person = new Person() { Contacts = new Contacts() { PhoneNumber = "0977507413" } }; //public class 

            //Person person = new Person() { Contacts = new Contacts() };

            //Person person = null;

            return person;
        }
        static void Main(string[] args)
        {
            Person person = GetPerson();

            Console.WriteLine(person?.Contacts?.PhoneNumber ?? "#NA");

        }
    }

 *
 * */
/* # 43 ключевое слово ref, передача аргументов по ссьілке
 * 
 * ссьілочньіе локальньіе переменньіе
 * 
 * возвращаемьіе ссьілочньіе значения
 * 
 * 
 *  class MyClass
    {
        public int a;
        public double b;
        public float c;
    }
    class Program
    {
        static void Foo(ref MyClass myClass)
        {
            myClass.a = -5;
        }
        static void Bar(int[] myArray)
        {
            //myArray[0] = 5;
            myArray = null;
        }

        static void Main(string[] args)
        {
            //MyClass myClass = new MyClass();

            //Foo(ref myClass);

            //int[] myArray = { 1, 4, 6 };
            //Bar(myArray);

            int[] arr = { 2, 6, 1 };
            int b = arr[0];
            b = -5;


            
        }
    }
 * 
 * */
/* # HW
1. Написать метод Resize изменяющий количество элементов массива (метод должен иметь возможность увеличить или уменьшить количество элементов массива).
2. Написать методы для добавления элемента в начало массива, в конец массива и по указанному индексу.
3. Написать методы для удаления первого элемента массива, последнего элемента массива и элемента по указанному индексу.

 
 */

using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.ExceptionServices;
using ConsoleApp11;


namespace ConsoleApp11
{
   
    class Program
    {
        //static void Foo(ref int a)
        //{
        //   a = -5;
        //}static void Bar(int[] myArray)
        //{

        //}

        static void Main(string[] args)
        {
            //int a = 2;
            //Foo(ref a);
            //Console.WriteLine(a);
            for (int i = 0; i < 12; i++)
            {
                for(int j = 0; j < 12; j++)
                {
                    Console.WriteLine("idi nahuy");
                }
                Console.WriteLine();
            }
        }
        
    }
}



