// See https://aka.ms/new-console-template for more information
using GenericQueue;


GenericQueue<ChatMessage> Queue = new GenericQueue<ChatMessage>(5);

bool flag = true;
int id = 0;

while (flag)
{
    Console.WriteLine("Enter your choice:");
    Console.WriteLine("1. Enqueue");
    Console.WriteLine("2. Dequeue");
    Console.WriteLine("3. Check if Full");
    Console.WriteLine("4. Check if Empty");
    Console.WriteLine("5. Quit");

    var input = Console.ReadLine();

    switch (input)
    {
        case "1":
            Console.WriteLine("Enter message");
            string message = Console.ReadLine();

            if (String.IsNullOrEmpty(message))
            {
                Queue.Enqueue(new ChatMessage());
            }

           else
            {
                ChatMessage msg = new ChatMessage
                {
                    MessageId = ++id,
                    Content = message,
                    TimeStamp = DateTime.Now,
                    SourceId = id,
                };

                Queue.Enqueue(msg);
            }
            break;

        case "2":
            ChatMessage m = Queue.Dequeue();
            Console.WriteLine("The deleted message is");
            Console.WriteLine($"Dequeued message: ID {m.MessageId}, Content: {m.Content}, TimeStamp: {m.TimeStamp}, SourceId: {m.SourceId}");
            break;

        case "3":
            Console.WriteLine(Queue.IsFull());
            break;
        case "4":
            Console.WriteLine(Queue.IsEmpty());
            break;
        case "5":
            flag = false;
            break;
    }


}
