namespace TeamBuilder.Models
{
    /* 
    Added a Data Transfer Object (DTO)!     
    "A DTO may be used to:
    Prevent over-posting.
    Hide properties that clients are not supposed to view.
    Omit some properties in order to reduce payload size.
    Flatten object graphs that contain nested objects. Flattened object graphs can be more convenient for clients.".
    Ref: https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-8.0&tabs=visual-studio
     */

    public class TodoItemDTO
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public bool IsComplete { get; set; }
    }

    public class TodoItem : TodoItemDTO
    {
        public string? Secret { get; set; }

        public static TodoItemDTO ItemToDTO(TodoItem todoItem) =>
            new TodoItemDTO
            {
            Id = todoItem.Id,
            Name = todoItem.Name,
            IsComplete = todoItem.IsComplete
            };
    }
}
