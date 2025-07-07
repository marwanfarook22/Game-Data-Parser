

namespace Game_Data_Parser.UserInterActions
{


    public class UserInteraction : IUserinteraction
    {

        private readonly LoggerSystem _loggerSystem;

        public UserInteraction(LoggerSystem loggerSystem)
        {
            _loggerSystem = loggerSystem;
        }

        public void EroorMessage(string message)
        {
            var OrginalColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.WriteLine(message);
            /*Color Console After Red*/
            Console.ForegroundColor = ConsoleColor.White;

        }

        public void Exit()
        {
            Message("Press Any Key To Esc");
            Console.ReadKey();
        }

        public void Message(string message) => Console.WriteLine(message);

        public string Run()
        {
            bool ShallStop = true;
            string FileName;
            do
            {
                Message("Entering the file name by the user");
                FileName = Console.ReadLine();
                try
                {
                    ValidateFileName(FileName);
                    ShallStop = false;
                }
                catch (ArgumentNullException ex)
                {
                    Console.WriteLine(ex.Message);
                    _loggerSystem.CatchError(ex);


                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    _loggerSystem.CatchError(ex);

                }
                catch (FileNotFoundException ex)
                {
                    Console.WriteLine(ex.Message);
                    _loggerSystem.CatchError(ex);

                }

            }
            while (ShallStop);
            return FileName;
        }



        public void ValidateFileName(string userinput)
        {
            if (userinput is null)
            {
                throw new ArgumentNullException("File name cannot be null");

            }
            if (userinput == string.Empty)
            {
                throw new ArgumentException("File name cannot be empty");
            }
            if (!File.Exists(userinput))
            {

                throw new FileNotFoundException("File not found.");
            }
        }
    }
}
