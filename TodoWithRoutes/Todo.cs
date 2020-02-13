namespace Todos
{
    /// <summary>
    /// Todo item
    /// </summary>
    public class Todo
    {
        public long Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Check if task is completed.
        /// </summary>
        public bool IsComplete { get; set; }
    }
}
