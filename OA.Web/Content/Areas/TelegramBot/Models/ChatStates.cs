namespace ExpertWebApplication.Areas.TelegramBot.Models
{
    public enum State
    {
        Nothing,
        Getexp
    };

    public class ChatStates
    {
        public long Id { get; set; }

        public State State;

        public ChatStates(long id)
        {
            Id = id;
            State = State.Nothing;
        }

        public override string ToString()
        {
            return $"Id - {Id} | State - {State}";
        }
    }
}