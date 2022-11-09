
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
    var result = songLyrics.Contains("goodbye");
    Console.WriteLine(result);
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
    bool judge1 = (a + b > 10);
    bool judge2 = (a == b);
    bool judge3 = (judge1 && judge2);
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
    Console.WriteLine("----------------\n");
}
branch();
*/

/* 迴圈
static void loop()
{
    byte counter = 0;
    while (counter < 10)
    {
        Console.WriteLine($"while loop. The counter is {counter}");
        counter++;
    }

    counter = 0;
    do 
    {
        Console.WriteLine($"do while loop. The counter is {counter}");
        counter++;
    } while (counter < 10);

    for (int index = 0; index < 10; index++)
    {
        Console.WriteLine($"for loop. The counter is {index}");
    }
}
loop();
*/

/* 結合分支和迴圈
static void combineBL()
{
    byte sum = 0;
    for (byte i = 1; i < 21; i++)
    {
        if (i % 3 == 0)
        {
            sum += i;
        }
    }
    Console.WriteLine($"The sum is {sum}.");
}
combineBL();
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

/* LINQ */
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