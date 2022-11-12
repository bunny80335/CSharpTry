// See https://aka.ms/new-console-template for more information

// 資料　　：基本上是以一系列位元儲存在電腦記憶體中的值
// 數值資料：若使用的是二進位 (或是基底 2) 數字系統，則可只使用 8 個位元來表示 256 種不同組合
// 文字資料：使用 ASCII 值及其十進位對應項目查閱的 ASCII 資料表
// 資料類型：是一種程式設計語言結構，定義 要為值保留多少記憶體
// 　　　　：基本分類「實值型別」和「參考型別」
// 實值 和 參考 型別間的 基本差異
// 　　　　：與其在您應用程式執行時，於 記憶體 中暫時儲存的 位置 有關。
// 　　　　：值的儲存 位置 會影響 .NET 執行階段管理值 壽命 的方式，包括其宣告(誕生)、指派和擷取(壽命)及完成(死亡)。
// 　　　　：而這也會進而 影響 您在使用實值型別或參考型別時所使用的 語法。
// 實值型別：整數、浮點數
// 　　　　：實值型別變數會將其值 儲存在稱為「堆疊」的儲存體區域。
// 　　　　：堆疊 是配置到目前正在 CPU 上執行程式碼的記憶體(也稱為堆疊框架或啟用框架)。
// 　　　　：當堆疊框架 完成執行後，隨即 移除 堆疊中的值。
// 參考型別：陣列、類別、字串
// 　　　　：參考型別變數會將其值 儲存在稱為「堆積」的記憶體區域。
// 　　　　：堆積 是同時在作業系統上執行的許多應用程式所 共用記憶體區域。
// 　　　　：.NET 執行階段 會與作業系統通訊，判斷哪些記憶體位址可用，並要求可儲存值的位址。
// 　　　　：.NET 執行階段 會儲存值，然後將 記憶體位址 傳回至 變數。
// 　　　　：當程式碼使用變數時，.NET 執行階段便會順暢地查閱儲存在變數中的位址，並擷取儲存在該處的值。

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

/* 數值計算*/
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

    // 整數型別，帶正負號
    // 帶正負號的實值型別會使用最左邊的一位元來儲存，0為正數、1為負數
    Console.WriteLine("\nSigned integral types:");
    Console.WriteLine($"{"sbyte",-8}: {sbyte.MinValue} to {sbyte.MaxValue}");
    Console.WriteLine($"{"short",-8}: {short.MinValue} to {short.MaxValue}");
    Console.WriteLine($"{"int",-8}: {int.MinValue} to {int.MaxValue}");
    Console.WriteLine($"{"long",-8}: {long.MinValue} to {long.MaxValue}");

    // 整數型別，不帶正負號
    Console.WriteLine("\nUnsigned integral types:");
    Console.WriteLine($"{"byte",-8}: {byte.MinValue} to {byte.MaxValue}");
    Console.WriteLine($"{"ushort",-8}: {ushort.MinValue} to {ushort.MaxValue}");
    Console.WriteLine($"{"ushort",-8}: {ushort.MinValue} to {ushort.MaxValue}");
    Console.WriteLine($"{"ulong",-8}: {ulong.MinValue} to {ulong.MaxValue}");

    // 浮動型別，帶正負號
    // 浮點數值在數字成長到相當龐大時，有時候可使用「E 標記法」來表示。
    // 5E+2 這類的值表示 500，因為其相當於 5 * 10^2 或 5 * 10 * 10
    Console.WriteLine("\nFloating point types:");
    Console.WriteLine($"{"float",-8}: {float.MinValue} to {float.MaxValue}");
    Console.WriteLine($"{"double",-8}: {double.MinValue} to {double.MaxValue}");
    Console.WriteLine($"{"decimal",-8}: {decimal.MinValue} to {decimal.MaxValue}");

    // 溢位
    int intMax = int.MaxValue;
    int intOverflow = intMax + 3;
    Console.WriteLine($"\nint Max+3:{intOverflow}\n");

    // 編譯器和執行階段處理 decimal 的方式，與處理 float 或 double 的方式有基本差異，
    // 尤其是在判斷數學運算所需的正確性程度時。
    double d1 = 1;
    double d2 = 3;
    Console.WriteLine($"{"double",-8}: {d1} / {d2} = {d1 / d2}");

    decimal d3 = 1M;
    decimal d4 = 3M;
    Console.WriteLine($"{"decimal",-8}: {d3} / {d4} = {d3 / d4}");

    // 圓面積
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

