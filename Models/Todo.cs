namespace TodoREST.Models
{
    /*
     todo data
     type Todo = { name: string; id: number };
     */

    public class Todo
    {
        public int ID { get; set; } // PK NN
        public string Name { get; set; }
    }
}
