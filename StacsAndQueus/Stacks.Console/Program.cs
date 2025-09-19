using Stack.UsingList;
using StacUseArry;

//<tipo> ()capacidad
var stack = new Stack<string>();
// apilar
/*stack.Push("Uruguay");
stack.Push("Brasil");
stack.Push("Argentina");
stack.Push("Ecuador");*/
//desapilar
//Console.WriteLine(stack.Pop());
var opt = String.Empty;
try {
    //menu
    do {

        opt = Menu();
        
        switch (opt)
        {
            case "1":
                Console.Write("Enter item?");
                
                stack.Push(Console.ReadLine()!);
                break;
            case "2":

                Console.WriteLine(stack.Peek());
                break;

            case "3":
                Console.WriteLine(stack.Pop());
                break;
            default:
                break;
        
        }
    } while (opt!="0");
   
} catch (Exception ex) {
    Console.WriteLine(ex.Message);
}

String Menu()
{
    Console.WriteLine("1. Push");
    Console.WriteLine("2. Peek"); // ver el tope de la pila
    Console.WriteLine("3. Pop");
    Console.WriteLine("0. exit");
    Console.WriteLine("Select your option: ");
    return Console.ReadLine()!;
}