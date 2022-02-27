namespace DELL.projects.Advanced_csharp_bookRead.algorithms.CustomExceptions
{
    public class LinkedNotFoundException : Exception
    {
        public LinkedNotFoundException()
        {

        }

        public LinkedNotFoundException(string message) : base(message) { }
        public LinkedNotFoundException(string message, Exception inner) : base(message, inner) { }
    }
}