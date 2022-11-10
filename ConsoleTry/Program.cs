
// See https://aka.ms/new-console-template for more information

/* 字串格式化
static void stringFormatting()
{
    Console.WriteLine("---- String Formatting ----");
    var item = (Name: "eggplant", Price: 1.99m, perPackage: 3);
    var date = DateTime.Now;
    Console.WriteLine($"On {date}, the price of {item.Name} was {item.Price} per {item.perPackage} items.");

    // 自訂日期與時間格式字串 https://learn.microsoft.com/zh-tw/dotnet/standard/base-types/custom-date-and-time-format-strings
    Console.WriteLine($"Date: {date}");
    Console.WriteLine($"Date: {date:d}");
    Console.WriteLine($"Date: {date:yyyy-MM-dd}");
    Console.WriteLine($"Time: {date:H:mm:ss}");

    // https://learn.microsoft.com/zh-tw/dotnet/standard/base-types/standard-numeric-format-strings#currency-format-specifier-c
    Console.WriteLine($"Price: {item.Price}");
    Console.WriteLine($"Price: {item.Price:C2}\n");

    var inventories = new Dictionary<string, int>()
    {
        ["hammer, ball pein"] = 18,
        ["hammer, cross pein"] = 5,
        ["screwdriver, Phillips #2"] = 14
    };

    Console.WriteLine($"Inventory on {DateTime.Now:d}");
    Console.WriteLine(" ");

    // 項目名稱會靠左對齊，而其數量會靠右對齊。
    // 在插入運算式後面加上逗號 (",")，並指定「最小」欄位寬度，即可指定對齊方式。
    // 如果指定的值是正數，則欄位會靠右對齊。
    // 如果它是負數，則欄位會靠左對齊。
    Console.WriteLine($"|{"Item",-25}|{"Quantity",10}|");

    foreach (var inventory in inventories)
    {
        Console.WriteLine($"|{inventory.Key,-25}|{inventory.Value,10}|");
    }

    // 您可以將對齊規範與格式字串結合為單一插入運算式。
    // 若要這樣做，請先指定對齊方式，而且後面接著冒號和格式字串。
    // 嘗試下列程式碼，以顯示含有所定義欄位寬度的三個格式化字串：
    Console.WriteLine($"[{DateTime.Now,-20:d}] Hour [{DateTime.Now,-10:HH}] [{1063.342,15:N2}] feet");

    // 搜尋字串
    string songLyrics = "You say goodbye, and I say hello";
    var result1 = songLyrics.Contains("goodbye");
    var result2 = songLyrics.StartsWith("You");
    var result3 = songLyrics.EndsWith("hello");
    Console.WriteLine(result1);
    Console.WriteLine(songLyrics.Contains("greeting"));
    Console.WriteLine("---------------------------\n");
}
stringFormatting();
*/

/* 數值計算
static void digitalComputing()
{
    Console.WriteLine("---- Digital Computing ----");
    // 數字計算
    int a = 7;
    double b = 4.0;
    int c = 2;
    Console.WriteLine($"{a} + {b} = {a + b}");
    Console.WriteLine($"{a} - {b} = {a - b}");
    Console.WriteLine($"{a} * {b} = {a * b}");
    Console.WriteLine($"{a} / {b} = {a / b}");
    Console.WriteLine($"{a} % {b} = {a % b}");
    Console.WriteLine($"{a} ^ {c} = {a ^ c}");

    int intMax = int.MaxValue;
    int intOverflow = intMax + 3;
    Console.WriteLine($"short max: {short.MaxValue}");
    Console.WriteLine($"short min: {short.MinValue}");
    Console.WriteLine($"int max: {int.MaxValue}");
    Console.WriteLine($"int min: {int.MinValue}");
    Console.WriteLine($"int overflow: {intOverflow}");
    Console.WriteLine($"long max: {long.MaxValue}");
    Console.WriteLine($"long min: {long.MinValue}");
    Console.WriteLine($"decimal max: {decimal.MaxValue}");
    Console.WriteLine($"decimal min: {decimal.MinValue}");
    Console.WriteLine($"float max: {float.MinValue}");
    Console.WriteLine($"float min: {float.MinValue}");
    Console.WriteLine($"double max: {double.MaxValue}");
    Console.WriteLine($"double min: {double.MinValue}");

    double d1 = 1;
    double d2 = 3;
    Console.WriteLine($"{d1 / d2}");

    decimal d3 = 1M;
    decimal d4 = 3M;
    Console.WriteLine($"{d3 / d4}");

    double radius = 2.50;
    double area = Math.PI * radius * radius;
    Console.WriteLine($"Circle Area: {area}");

    // 硬幣翻轉正面或反面
    Random coin = new Random();
    int flip = coin.Next(0, 2);
    Console.WriteLine((flip == 0) ? "heads" : "tails");
    Console.WriteLine("---------------------------\n");
}
digitalComputing();
*/

/* 分支
static void branch()
{
    Console.WriteLine("---- branch ----");
    int a = 5;
    int b = 3;

    // branch ?:
    int c = a > b ? 6 : 2;

    bool judge1 = (a + b > c);
    bool judge2 = (a == c);
    bool judge3 = (judge1 && judge2);

    // branch if-elseif-else
    if (judge3)
    {
        Console.WriteLine("The answer is greater than 10.");
        Console.WriteLine("And the first number is equal to the second.");
    }
    else
    {
        Console.WriteLine("The answer is not greater than 10.");
        Console.WriteLine("Or the first number is not equal to the second.");
    }

    // branch switch-case
    int employeeLevel = 200;
    string employeeName = "John Smith";
    string title = "";
    switch (employeeLevel)
    {
        case 100:
            title = "Junior Associate";
            break;
        case 200:
        case 300:
            title = "Manager";
            break;
        case 400:
            title = "Senior Manager";
            break;
        default:
            title = "Associate";
            break;
    }
    Console.WriteLine($"{employeeName}, {title}");
    Console.WriteLine("----------------\n");
}
branch();
*/

/* 迴圈
static void loop()
{
    byte counter = 0;
    // loop while
    while (counter < 10)
    {
        Console.WriteLine($"while loop. The counter is {counter}");
        counter++;
    }

    counter = 0;
    // loop do-while
    do 
    {
        Console.WriteLine($"do while loop. The counter is {counter}");
        counter++;
    } while (counter < 10);

    string[] names = { "Alex", "Eddie", "David", "Michael" };
    // loop for(初始設定式;條件;迭代器)
    for (int index = 0; index < names.Length; index++)
    {
        if (index == 2)
        {
            names[index] = "Bunny";
        }
        Console.WriteLine($"My name is {names[index]}.");
    }

    // loop foreach
    // 您無法重新指派 name 的值，因為其是 foreach 反覆運算內部實作的一部分。
    foreach (var name in names)
    {
        // if (name == "Eddie")
        //     name = "Error";
        Console.WriteLine($"Hi, {name}");
    }
}
loop();
*/

/* 結合分支和迴圈
static void combineBL()
{
    for (int i = 1; i < 101; i++)
    {
        Console.Write($"{i,3}:");
        Console.Write(i % 3 == 0 ? "Fizz" : "");
        Console.WriteLine(i % 5 == 0 ? "Buzz" : "");
    }
}
combineBL();
*/

/* 小遊戲：英雄和怪物
static void heroAndMonster()
{
    int heroHealth = 10;
    int heroAttack;
    int monsterHealth = 10;
    int monsterAttack;
    int injuried;
    Random ran = new Random();
    do
    {
        heroAttack = ran.Next(1, 10);
        monsterAttack = ran.Next(1, 10);
        if (heroAttack == monsterAttack)
            Console.WriteLine("平手");
        else if (heroAttack > monsterAttack)
        {
            injuried = heroAttack - monsterAttack;
            monsterHealth -= injuried;
            Console.WriteLine($"怪物受到傷害並失去 {injuried} 點生命值，現在擁有 {monsterHealth} 點生命值。");
        }
        else if (monsterAttack > heroAttack)
        {
            injuried = monsterAttack - heroAttack;
            heroHealth -= injuried;
            Console.WriteLine($"英雄受到傷害並失去 {injuried} 點生命值，現在擁有 {heroHealth} 點生命值。");
        }
    } while (heroHealth > 0 && monsterHealth > 0);

    Console.WriteLine(heroHealth > monsterHealth ? "英雄獲勝！" : "怪物獲勝！");
}
heroAndMonster();
*/

/* 數組、列表和集合
static void list()
{
    // variable 變量
    var names = new List<string> { "New Friend", "Scott", "Kendra" };
    names.Add("Maria");
    names.Add("Bill");
    names.Remove("Scott");
    names.Sort();
    foreach (var name in names)
    {
        Console.WriteLine($"Hello {name}");
    }

    var index = names.IndexOf("Kendra");
    if (index == -1)
    {
        Console.WriteLine($"When an item is not found, IndexOf returns {index}.");
    }
    else
    {
        Console.WriteLine($"The name {names[index]} is at index {index}.");
    }
}
list();
*/

/* Fibonacci Number 斐波那契 數列
static void fibonacciNumber()
{
    var fibonacciNumbers = new List<int> { 1, 1 };

    while (fibonacciNumbers.Count < 20)
    {
        var previous1 = fibonacciNumbers[fibonacciNumbers.Count - 1];
        var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];
        fibonacciNumbers.Add(previous1 + previous2);
    }

    foreach (var fibonacciNumber in fibonacciNumbers)
        Console.WriteLine(fibonacciNumber);
}
fibonacciNumber();
*/

// 1. 它有一個10位數字，可以唯一識別銀行賬戶。
// 2. 它有一個字符串，用來存儲所有者的名字。
// 3. 餘額 可以 3.
// 4. 它 接受 存款 。
// 5. 它 接受 撤回 。
// 6. 最初 的 餘額 必須 是 正值 。
// 7. 提款 不能 導致 負結餘 。
/* Class 實例
using MySuperBank;
static void TypeInstance()
{
    var account = new BankAccount("Kendra", 10000);
    account.MakeWithdrawal(120, DateTime.Now, "Hammock");
    Console.WriteLine(account.GetAccountHistory());
}
TypeInstance();
*/

/* LINQ
static void Linq()
{
    // int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
    var numbers = new List<int> { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
    var lowNums = from num in numbers
                  where num < 5
                  select num;

    Console.WriteLine("Number < 5:");
    foreach (var x in lowNums)
    {
        Console.WriteLine(x);
    }
}
Linq();
*/

