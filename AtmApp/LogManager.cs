namespace AtmApp
{
    internal class LogManager
    {
        private static string _docPath = "C:\\Development\\C#\\PatikaProjects\\AtmApp";
        private static string _date = DateTime.Now.ToString("dd-MM-yyyy");

        public static void Log(string logInfo)
        {
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(_docPath, $"EOD_{_date}.txt")))
            {
                outputFile.Write($"Tarih: {_date} - Detay: {logInfo}");
            }
        }

        public static void GetLogs()
        {
            try
            {
                string filePath = Path.Combine(_docPath, $"EOD_{_date}.txt");

                StreamReader streamReader = new StreamReader(filePath);

                string text = streamReader.ReadToEnd();

                Console.WriteLine(text);

                streamReader.Close();
            }
            catch (IOException exception)
            {
                Console.Write("Dosya okunamıyor: ");
                Console.WriteLine(exception.Message);
            }
        }
    }
}
