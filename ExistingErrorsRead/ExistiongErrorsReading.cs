

using Game_Data_Parser.UserInterActions;
using System.Text.Json;

namespace Game_Data_Parser.ExistingErrorsRead
{
    public class ExsistingErrorFile : IExsistingErrorFile
    {
        private readonly string FileName;
        private readonly IUserinteraction _userinteraction;

        public ExsistingErrorFile(string fileName, IUserinteraction userinteraction)
        {
            FileName = fileName;
            _userinteraction = userinteraction;
        }
        public void ReadExistingFile(string filePath)
        {
            var FileContent = File.ReadAllText(filePath);
            try
            {
                var DeserializeFile = JsonSerializer.Deserialize<List<GameContent.GameContent>>(FileContent);
                _userinteraction.Message(Environment.NewLine + "Loaded games are:");
                foreach (var Content in DeserializeFile)
                {
                    _userinteraction.Message(Content.ToString());

                }

            }
            catch (JsonException ex)
            {
                _userinteraction.EroorMessage($"“JSON in the {FileName} was not in a valid format. JSON body:”:");
                _userinteraction.EroorMessage(FileContent);
                throw new JsonException($"{ex.Message},The File Is :{FileName}", ex);

            }

        }

    }
}
