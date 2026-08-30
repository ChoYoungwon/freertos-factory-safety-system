using MySqlConnector;

namespace safety_management
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
            // 로그인 성공 시에만 Form1을 생성하고 애플리케이션을 실행
            //Application.Run(new Form1());
            using (Form4 loginForm = new Form4())
            {
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    // 로그인 성공 시에만 Form1을 생성하고 애플리케이션을 실행
                    Application.Run(new Form1());
                }
            }

        }
    }
}