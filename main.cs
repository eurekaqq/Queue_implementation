using Console = System.Console;
using Queue = myQueue.myQueue;//using namespace myQuene.


namespace main {
    class main {
        static void Main(string[] args) {
            Queue tt = new Queue();
            Console.WriteLine(tt.Peek());
            Console.WriteLine(tt.Dequeue());
            tt.Enqueue(null);
            tt.Enqueue(123);
            tt.Enqueue("asdas");
            tt.Enqueue(4.544);
            Console.WriteLine(tt.Peek());
            Console.WriteLine(tt.Dequeue());
            Console.WriteLine(tt.Dequeue());
            Console.WriteLine(tt.Dequeue());
            Console.WriteLine(tt.Dequeue());
            Console.WriteLine(tt.Dequeue());
            Console.WriteLine(tt.Dequeue());
            Console.WriteLine(tt.Dequeue());
            Console.Read();
        }
    }
}
