using System;

class Program
{
    static void Main()
    {
        // 提示使用者輸入體重
        Console.Write("請輸入體重（公斤）：");
        string weightInput = Console.ReadLine();

        // 提示使用者輸入身高
        Console.Write("請輸入身高（公分）：");
        string heightInput = Console.ReadLine();

        // 轉換輸入為數值
        double weight, height;
        bool isWeightValid = double.TryParse(weightInput, out weight);
        bool isHeightValid = double.TryParse(heightInput, out height);

        if (isWeightValid && isHeightValid)
        {
            // 顯示使用者輸入的資料
            Console.WriteLine($"\n您輸入的體重是：{weight} 公斤");
            Console.WriteLine($"您輸入的身高是：{height} 公分");

            // 尚未計算 BMI 值
            Console.WriteLine("\n尚未計算 BMI 值。");
        }
        else
        {
            Console.WriteLine("輸入格式錯誤，請輸入正確的數字。");
        }

        // 暫停畫面
        Console.WriteLine("\n按任意鍵結束...");
        Console.ReadKey();
    }
}
