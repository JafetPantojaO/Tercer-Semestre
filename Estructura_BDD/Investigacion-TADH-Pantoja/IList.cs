namespace InvestigacionListasEnlazadas;

public interface IList<T>
{
    // Propiedades de estado
    int Count { get; }
    bool IsEmpty { get; }

    // Acceso indexado
    T this[int index] { get; set; }

    // Inserción y adición
    void Add(T item);
    void Insert(int index, T item);

    // Acceso y modificación
    T Get(int index);
    void Set(int index, T item);

    // Eliminación
    bool Remove(T item);
    void Clear();

}
