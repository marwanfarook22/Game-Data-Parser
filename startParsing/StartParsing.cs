

using Game_Data_Parser.ExistingErrorsRead;

using Game_Data_Parser.UserInterActions;
using System.Text.Json;

namespace Game_Data_Parser.startParsing
{
    public class StartParsing
    {
        private readonly IUserinteraction _userinteraction;
        private readonly IExsistingErrorFile _exsistingErrorFile;


        public StartParsing(IUserinteraction userinteraction, IExsistingErrorFile exsistingErrorFile)
        {
            _userinteraction = userinteraction;

            _exsistingErrorFile = exsistingErrorFile;
        }



        public void mainAppliction(string filePath)
        {
            string UserInputFileName = _userinteraction.Run();
            try
            {
                _exsistingErrorFile.ReadExistingFile(UserInputFileName);
            }
            catch (JsonException ex)
            {
                _userinteraction.Message(ex.Message);
                throw;

            }
            _userinteraction.Exit();



        }
    }
}
