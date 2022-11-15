// See https://aka.ms/new-console-template for more information

// 資料　　：基本上是以一系列位元儲存在電腦記憶體中的值
// 整數資料：若使用的是二進位 (或是基底 2) 數字系統，則可只使用 8 個位元來表示 256 種不同組合
// 浮點數資料
// 　　　　：會有精確度的問題，例如：pi的無限小數
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
// 　　　　：參考型別變數 會將其值 儲存在稱為「堆積」的記憶體區域。
// 　　　　：參考型別變數 會保存儲存在堆積中實際值的參考 (記憶體位址)。
// 　　　　：參考型別的新執行個體是使用 new 運算子來建立。
// 　　　　：堆積 是同時在作業系統上執行的許多應用程式所 共用記憶體區域。
// 　　　　：.NET 執行階段 會與作業系統通訊，判斷哪些記憶體位址可用，並要求可儲存值的位址。
// 　　　　：.NET 執行階段 會儲存值，然後將 記憶體位址 傳回至 變數。
// 　　　　：當程式碼使用變數時，.NET 執行階段便會順暢地查閱儲存在變數中的位址，並擷取儲存在該處的值。
// 字串　　：宣告 string 時可以不使用 new 運算子，這純粹是 C# 設計人員提供的便利性，因為 string 資料類型頻繁使用。
// 基本原則：默認引用命名空間 System
// 　　　　：bool       用於 True 或 False 值
// 　　　　：byte       用於 處理來自其他電腦系統或使用不同字元集的編碼資料。
// 　　　　：int        用於 大多數的整數
// 　　　　：decimal    用於 表示貨幣的數字
// 　　　　：double     用於 幾何或科學用途。 double 經常用於建置涉及動作的遊戲。
// 　　　　：DateTime   用於 特定日期和時間值。
// 　　　　：TimeSpan   用於 一段範圍的年/月/日/小時/分鐘/秒/毫秒。
// 　　　　：string     用於 英數值。
// 　　　　：StringBuilder
// 　　　　：           用於 從許多常值或其他變數建置單一字串。
// 　　　　：           需要 using System.Text;
// Null 　：未指向記憶體中任何項目之變數的值。
// 變數　　：會保存值的記憶體位址
// Call By Reference 傳址參考
// 　　　　：ref 用於參考，會直接對該位址的值進行處理，所以該變數需要有變數值。
// 　　　　：out 用於輸出，會將處理的結果儲存在該位址，所以即使變數有值也不會被使用，而會在處理中取代。

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


    // 整數型別，帶正負號
    // 帶正負號的實值型別會使用最左邊的一位元來儲存，0為正數、1為負數
    Console.WriteLine("\nSigned integral types:");
    Console.WriteLine($"{"sbyte",-8}: {sbyte.MinValue} to {sbyte.MaxValue}");
    Console.WriteLine($"{"short",-8}: {short.MinValue} to {short.MaxValue}");
    Console.WriteLine($"{"int",-8}: {int.MinValue} to {int.MaxValue}");
    Console.WriteLine($"{"long",-8}: {long.MinValue} to {long.MaxValue}");
    Console.WriteLine($"{"nint",-8}: {nint.MinValue} to {nint.MaxValue}");

    // 整數型別，不帶正負號
    Console.WriteLine("\nUnsigned integral types:");
    Console.WriteLine($"{"byte",-8}: {byte.MinValue} to {byte.MaxValue}");
    Console.WriteLine($"{"ushort",-8}: {ushort.MinValue} to {ushort.MaxValue}");
    Console.WriteLine($"{"uint",-8}: {uint.MinValue} to {uint.MaxValue}");
    Console.WriteLine($"{"ulong",-8}: {ulong.MinValue} to {ulong.MaxValue}");
    Console.WriteLine($"{"nuint",-8}: {nuint.MinValue} to {nuint.MaxValue}");

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
*/

/* 實值型別 轉換
static void BuiltInValueConversion()
{
    // 數字轉字串
    int firstInt = 5;
    int secondInt = 7;
    string resultString = firstInt.ToString() + secondInt.ToString();
    Console.WriteLine(resultString);

    // 字串轉數字
    string firstString = "5";
    string secondString = "7";
    // Parse：轉換失敗會有例外
    // Parse：只支援 字串 to 其它型別
    int resultInt = int.Parse(firstString) + int.Parse(secondString);
    Console.WriteLine(resultInt);
    // Convert：轉換失敗會有例外
    // Convert：支援多種型別轉換
    resultInt = Convert.ToInt32(firstString) + Convert.ToInt32(secondString);
    Console.WriteLine(resultInt);

    // 放大轉換
    int myInt = 3;
    Console.WriteLine($"int: {myInt}");
    decimal firstDecimal = myInt;
    Console.WriteLine($"decimal: {firstDecimal}");

    // 縮小轉換：使用 強制轉換(Type)，資料可能會有損失。
    decimal secondDecimal = 1.23456789m;
    float myFloat = (float)secondDecimal;
    Console.WriteLine($"Decimal: {secondDecimal}");
    Console.WriteLine($"Float: {myFloat}");

    // 強制轉型：浮點數 無限制捨棄
    // 強制轉型：僅用於數值型別間的轉換
    // Convert：浮點數 四捨五入
    double firstDouble = 1.1;
    double secondDouble = 1.5;
    Console.WriteLine($"{"強制轉型",4}： {firstDouble} > {(int)firstDouble}");
    Console.WriteLine($"{"強制轉型",4}： {secondDouble} > {(int)secondDouble}");
    Console.WriteLine($"{"Convert",8}： {firstDouble} > {Convert.ToInt32(firstDouble)}");
    Console.WriteLine($"{"Convert",8}： {secondDouble} > {Convert.ToInt32(secondDouble)}");

    // TryParse：轉換失敗不會產生例外
    // 將字串轉換成數值資料類型時，請使用 TryParse()。
    // 如果轉換成功，TryParse() 會傳回 true；如果不成功，則傳回 false。
    // out 參數提供傳回值之方法的次要方式。 在此案例中，out 參數會傳回轉換後的值。
    // 將引數傳入已定義 out 參數的方法時，請使用關鍵字 out。
    // 儲存轉換結果的變數 result 可以在 事前宣告 或是在 TryParse 內宣告 int型別，
    string value = "abc";
    int result = 0;
    if (int.TryParse(value, out result))
    {
        Console.WriteLine($"Measurement: {result}");
    }
    else
    {
        Console.WriteLine("Unable to report the measurement.");
        Console.WriteLine($"result value is {result}.");
    }
}
BuiltInValueConversion();
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

/* 陣列 元素排序*/
static void arraySort()
{
    string[] pallets = { "B14", "A11", "B12", "A13" };

    Console.WriteLine("Sorted...");
    // 排序由小到大
    Array.Sort(pallets);
    foreach (var pallet in pallets)
    {
        Console.WriteLine($"-- {pallet}");
    }

    Console.WriteLine("");
    Console.WriteLine("Reversed...");
    // 排序由大到小
    Array.Reverse(pallets);
    foreach (var pallet in pallets)
    {
        Console.WriteLine($"-- {pallet}");
    }

    // 字串反轉
    string value = "abc123";
    char[] valueArray = value.ToCharArray();
    Array.Reverse(valueArray);
    string result = new string(valueArray);
    Console.WriteLine(result);

    // Join：陣列 加入字串 合成 新字串
    result = String.Join(",", valueArray);
    Console.WriteLine(result);

    // Split：字串 分割成 陣列
    string[] items = result.Split(',');
    foreach (string item in items)
    {
        Console.WriteLine(item);
    }

    // 挑戰：單字反轉
    string pangram = "The quick brown fox jumps over the lazy dog";
    char[] charArray = pangram.ToCharArray();
    Array.Reverse(charArray);
    string[] pangramArray = new string(charArray).Split(' ');
    Array.Reverse(pangramArray);
    Console.WriteLine(string.Join(" ", pangramArray));

    // 挑戰：剖析訂單識別碼
    string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
    string[] orderArray = orderStream.Split(',');
    foreach (string o in orderArray)
    {
        if (o[0] == 'B')
            Console.WriteLine(o);
    }
}
arraySort();


/* 陣列 元素調整
static void arrayAdjust()
{
    string[] pallets = { "B14", "A11", "B12", "A13" };
    Console.WriteLine("");

    // 清除：將變數值變更為 Null
    Array.Clear(pallets, 0, 2);
    Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
    foreach (var pallet in pallets)
    {
        Console.WriteLine($"-- {pallet}");
    }
    Console.WriteLine("");

    // 調整大小：使用 ref 關鍵字，藉傳址傳入 pallets 陣列
    Array.Resize(ref pallets, 6);
    Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

    pallets[4] = "C01";
    pallets[5] = "C02";

    foreach (var pallet in pallets)
    {
        Console.WriteLine($"-- {pallet}");
    }

    Console.WriteLine("");
    Array.Resize(ref pallets, 3);
    Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

    foreach (var pallet in pallets)
    {
        Console.WriteLine($"-- {pallet}");
    }
}
arrayAdjust();
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
