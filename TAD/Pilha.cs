using System;
using System.Collections.Generic;
namespace PilhaCsharpe;

public class Pilha<T> : IPilha<T>
{
    private List<T> elementos = new List<T>();

    public void Push(T item)
    {
        elementos.Add(item);
    }

    public T Pop()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("A pilha está vazia.");
        }

        var item = elementos[elementos.Count - 1];
        elementos.RemoveAt(elementos.Count - 1);
        return item;
    }

    public T Peek()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("A pilha está vazia.");
        }

        return elementos[elementos.Count - 1];
    }

    public bool IsEmpty()
    {
        return elementos.Count == 0;
    }
}