namespace Project1Winform
{
    internal static class Program
    {
     
        [STAThread]
        static void Main()
        {
           
            ApplicationConfiguration.Initialize();
            Application.Run(new pr1());
        }
    }
}