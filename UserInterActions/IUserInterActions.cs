

namespace Game_Data_Parser.UserInterActions
{
    public interface IUserinteraction
    {
        public string Run();
        public void Message(string message);
        public void EroorMessage(string message);
        public void Exit();

    }
}
