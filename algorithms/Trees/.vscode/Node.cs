namespace Trees.vscode
{
    public class NodeBinary<T>
    {
        public NodeBinary left { get; set; }
        public NodeBinary right { get; set; }

        private T data;

        public NodeBinary(T data)
        {
            this.data = data;
        }

    }
}