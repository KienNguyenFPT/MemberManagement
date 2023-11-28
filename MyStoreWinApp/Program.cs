using MyStoreWinApp.Views;
using System.Configuration;

namespace MyStoreWinApp
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
            //string sqlConnectionString = ConfigurationManager.ConnectionStrings["SqlConnection"].ConnectionString;
            //IMemView memView = new MemberManegementsForm();
            //IMemRepository rep = new MemberRepository(sqlConnectionString);
            //new MemberPresenter(memView, rep);
            //Application.Run(new MemberManegementsForm());
            LoginForm loginForm = new LoginForm();
            loginForm.StartPosition = FormStartPosition.CenterScreen;
            Application.Run(loginForm);
        }
    }
}