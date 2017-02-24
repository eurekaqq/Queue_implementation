using Exception = System.Exception;
using Object = System.Object;
using GC = System.GC;
using node;


namespace myQueue {
    class myQueue{
        node<Object> front,rear;

        public myQueue() {

        }

        public myQueue(Object data) {
            Enqueue(data);
        }

        //implement Enqueue()
        public void Enqueue(Object data) {
            if (front != null) {
                node<Object> item = new node<Object>(data);
                rear.next = item;
                rear = item;
            }
            else {
                node<Object> item = new node<object>(data);
                front = item;
                rear = front;
            }
        }

        //implement Dequeue()
        public Object Dequeue() {
            try {
                var temp = front;
                front = front.next;
                return temp.data;
            }
            catch(Exception e) {
                return e.Message;
            }
            finally {
                GC.Collect();
            }
        }

        //implement Peek()
        public Object Peek() {
            try {
                return front.data;
            }
            catch(Exception e) {
                return e.Message;
            }
        }
    }
}
