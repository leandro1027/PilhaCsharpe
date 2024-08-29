using System; 
using System.Collections.Generic; // Importa o namespace para coleções genéricas, como List<T>.
namespace PilhaCsharpe; 

public class Pilha<T> : IPilha<T> // Define uma classe genérica Pilha que implementa a interface IPilha<T>.
{
    
    private List<T> elementos = new List<T>(); // Cria uma lista genérica para armazenar os elementos da pilha.
                                                
    // Método para empilhar (adicionar) um item no topo da pilha.
    public void Push(T item)
    {
        // Adiciona o item ao final da lista, que representa o topo da pilha.
        elementos.Add(item);
    }

    // Método para desempilhar (remover) o item do topo da pilha.
    public T Pop()
    {
        // Verifica se a pilha está vazia antes de tentar remover um item.
        if (IsEmpty())
        {
            // Se a pilha estiver vazia, lança uma exceção para indicar que a operação não é válida.
            throw new InvalidOperationException("A pilha está vazia.");
        }

        // Armazena o item no topo da pilha (último elemento da lista) em uma variável.
        var item = elementos[elementos.Count - 1];
        // Remove o item do topo da pilha (último elemento da lista).
        elementos.RemoveAt(elementos.Count - 1);
        // Retorna o item removido.
        return item;
    }

    // Método para ver o item no topo da pilha sem removê-lo.
    public T Peek()
    {
        // Verifica se a pilha está vazia antes de tentar acessar um item.
        if (IsEmpty())
        {
            // Se a pilha estiver vazia, lança uma exceção para indicar que a operação não é válida.
            throw new InvalidOperationException("A pilha está vazia.");
        }

        // Retorna o item no topo da pilha (último elemento da lista) sem removê-lo.
        return elementos[elementos.Count - 1];
    }

    // Método para verificar se a pilha está vazia.
    public bool IsEmpty()
    {
        // Retorna true se a lista não contiver elementos, ou seja, se a pilha estiver vazia.
        return elementos.Count == 0;
    }
}
