namespace DB_REPORT_01_CAL
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
            // see https://aimage.pngka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }

        /// <summary>
        /// 버튼 ID 들을 명시해둔것입니다.
        /// </summary>
        public enum Buttons
        {
            Btn_0,
            Btn_1,
            Btn_2,
            Btn_3, 
            Btn_4,
            Btn_5,
            Btn_6,
            Btn_7,
            Btn_8,
            Btn_9,
            Btn_plus,
            Btn_minus,
            Btn_multiply,
            Btn_divide,
            Btn_equal
        }
    }
}
