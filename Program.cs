using System;

namespace PersonalGardenLog
{
    class Program
    {
        // 文字列定数を直接定義するアプローチ
        private const string WelcomeMessage = "Welcome to the Personal Garden Log!";
        private const string PromptMessage = "Please enter the plant name you want to record:";
        private const string SuccessMessage = "Successfully saved: ";

        static void Main(string[] args)
        {
            // 1. 歓迎メッセージの表示
            Console.WriteLine(WelcomeMessage);

            // 2. ユーザーからの入力を受け取る
            Console.WriteLine(PromptMessage);
            string plantName = Console.ReadLine();

            // 3. 入力されたデータの処理（例: 保存処理）
            if (!string.IsNullOrWhiteSpace(plantName))
            {
                SavePlantLog(plantName);
                Console.WriteLine($"{SuccessMessage}{plantName}");
            }
            else
            {
                Console.WriteLine("Error: Plant name cannot be empty.");
            }

            // 終了待ち
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        static void SavePlantLog(string plantName)
        {
            // ここに実際のファイル保存処理やデータベース処理などを記述します
            // 現在はコンソール出力のみ
            Console.WriteLine($"[DEBUG] Saving '{plantName}' to the log file...");
        }
    }
}