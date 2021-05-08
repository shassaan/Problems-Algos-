namespace Problems_Algos_.Models
{
    public class Node
    {
        public int Freq { get; set; }
        public char Data { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }
    }


    public class SinglyLinkedListNode
    {
        public int Data { get; set; }
        public SinglyLinkedListNode Next { get; set; }
    }
}