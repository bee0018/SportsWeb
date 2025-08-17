using FastEndpoints;
using SportsWebAPI.Requests;
using SportsWebAPI.Responses;

namespace SportsWebAPI.EndPoints
{
    public class TodoEndPoint : Endpoint<TodoRequest, TodoResponse>
    {
        public override void Configure()
        {
            Get("/todo");
            AllowAnonymous();
        }

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