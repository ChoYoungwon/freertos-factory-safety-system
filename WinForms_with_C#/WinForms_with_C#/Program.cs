using MySql.Data.MySqlClient;

namespace WinForms_with_C_
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
            ApplicationConfiguration.Initialize();
            //Application.Run(new Form1());   // customer 관리 폼
            //Application.Run(new Form2());   // 주문 관리 폼    
            //Application.Run(new Form4());   // 로그인 & 회원가입 폼 실행
            Application.Run(new Form5());     // 그래프 폼        
        }
    }
}