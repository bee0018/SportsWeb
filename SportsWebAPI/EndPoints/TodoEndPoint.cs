using FastEndpoints;
using SportsWebAPI.Requests;
using SportsWebAPI.Responses;

namespace SportsWebAPI.EndPoints
{
    /// <summary>
    /// Class representing the endpoint for the sample/testing API connectivity.
    /// </summary>
    public class TodoEndPoint : Endpoint<TodoRequest, TodoResponse>
    {
        /// <inheritdoc />
        public override void Configure()
        {
            Get("/todo");
            AllowAnonymous();
        }

        /// <inheritdoc />
        public override async Task<TodoResponse> ExecuteAsync(TodoRequest todoRequest, CancellationToken cancellationToken)
        {
            string todo = "work out";
            if (todoRequest.Scream)
            {
                todo = todo.ToUpper();
            }

            return new TodoResponse(todo, false);
        }
    }
}