namespace SportsWebAPI.Responses
{
    public class TodoResponse
    {
        public TodoResponse(string todo, bool isDone)
        {
            Todo = todo;
            IsDone = isDone;
        }

        public string Todo { get; set; }
        public bool IsDone { get; set; }
    }
}
