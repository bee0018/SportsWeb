namespace SportsWebAPI.Responses
{
    /// <summary>
    /// Class representing the basis for a todo respnose.
    /// </summary>
    public class TodoResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TodoResponse"/> class.
        /// </summary>
        /// <param name="todo">The task to complete.</param>
        /// <param name="isDone">Flag indicating whether the task is done or not.</param>
        public TodoResponse(string todo, bool isDone)
        {
            Todo = todo;
            IsDone = isDone;
        }

        /// <summary>
        /// Gets or sets the task to complete.
        /// </summary>
        public string Todo { get; set; }

        /// <summary>
        /// Gets or sets the flag indicating whether the task is complete or not.
        /// </summary>
        public bool IsDone { get; set; }
    }
}
