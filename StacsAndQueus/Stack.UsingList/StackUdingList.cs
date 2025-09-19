namespace Stack.UsingList
{
    public class StackUdingList<T>
    {
        private List<T> _elements = []; //tengo una lista de t que es de elementos y simplemente [] se esta inicializando la lista

        public void Push(T item) => _elements.Add(item); //para adicionar un elemento .add(item) y le pasa el item
       
        

        public T Pop()
        {
            //como saber si una lista esta vacia
            if (_elements.Count == 0) //count me da la cantidad de elementos

            {

                throw new Exception("Stack is empty");
            }


            T item = _elements[_elements.Count - 1]; //va hacer igual a mi coleccion de elementos en la posicion _elements.Count - 1 para tenerlo en la memoria

            _elements.RemoveAt(_elements.Count - 1); //elimineme el elemento que hay en la posicion _elements.Count - 1
            return item;

        }

        public T Peek()
        {
            //como saber si una lista esta vacia
            if (_elements.Count == 0) //count me da la cantidad de elementos

            {

                throw new Exception("Stack is empty");
            }

            return _elements[_elements.Count-1];

        }

    }
}
