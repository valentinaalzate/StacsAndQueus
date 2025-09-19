namespace StacUseArry
{
    public class StackUsingArray<T>
    {
        private T[] _elements = null!;
        private int _top;

        public StackUsingArray(int capacity)//capacidad de la pila el nuemro maximo que se va a a almacenar
        {
            _elements = new T[capacity]; // se le esta pasando la capacidad
            _top = -1;
        
        }

        public void Push(T item) // T es cualquier cosa y ese T radica lo que voy a pilar
        {
            if (_top == _elements.Length - 1) {
                //.length -1 significa que ya se lleno, no seria bueno poner en consola

                throw new Exception("Stack is full");
            }
            // elements es 10 10-1= 9 -1 es =9 como no es asi entonces a elementos  increment primeto el top entonce a elementos en la posicion top le agrege el item.

            //si la pila esta llena _top =9 top= elements.length elements=10 10-1 = 9 
            // top=  elements.length ?, si entonces saca la excepcion de que esta lleno.

            // a pilar el elemento
            _elements[++_top]= item; // elementos en la incrementacion del top llevele el item
        }

        public T Pop() {

            if (_top== -1) {

                throw new Exception("Stack is empty");
            }

            //desapilar
            // op1 = _top--;
            // mejor este
            return _elements[_top--];
        }

        public T Peek()
        {

            if (_top == -1)
            {

                throw new Exception("Stack is empty");
            }

            
            return _elements[_top]; // retorna el elementoen la posicion top
        }
    }
}
