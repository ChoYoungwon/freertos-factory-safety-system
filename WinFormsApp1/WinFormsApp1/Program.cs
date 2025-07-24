using System.Diagnostics;

namespace WinFormsApp1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Debug.WriteLine("프로그래밍 시작됩니다");
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
            Debug.WriteLine("프로그래밍 종료됩니다");
        }
    }
}