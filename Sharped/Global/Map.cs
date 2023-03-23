using System.Collections;

namespace Sharped.Global;
public class Map<T> : ICollection<KeyValuePair<string, T>>
{
    private Dictionary<string, T> list = new Dictionary<string, T>();

    public T this[string name] => list[name];

    public int Count => list.Count;
    public bool IsReadOnly => false;

    public void Add(string name, T item)
    {
        list.Add(name, item);
    }
    public void Add(KeyValuePair<string, T> obj)
    {
        list.Add(obj.Key, obj.Value);
    }
    public void Clear()
    {
        list.Clear();
    }
    public bool Contains(string name)
    {
        return list.ContainsKey(name);
    }
    public bool Contains(T item)
    {
        return list.ContainsValue(item);
    }
    public bool Contains(KeyValuePair<string, T> obj)
    {
        return list.Contains(obj);
    }
    public bool Remove(string name)
    {
        return list.Remove(name);
    }
    public void Remove(T item)
    {
        string address = null;
        int i = 0;
        foreach (var v in list)
        {
            if (object.Equals(v.Value, item))
            {
                address = v.Key;
                break;
            }
            i++;
        }
        list.Remove(address);
    }
    public void RemoveAt(int index)
    {
        string address = null;
        int i = 0;
        foreach (var v in list)
        {
            if (i == index)
            {
                address = v.Key;
                break;
            }
            i++;
        }
        list.Remove(address);
    }
    public bool Remove(KeyValuePair<string, T> obj)
    {
        return list.Remove(obj.Key);
    }

    public IEnumerator<KeyValuePair<string, T>> GetEnumerator()
    {
        return list.GetEnumerator();
    }
    IEnumerator IEnumerable.GetEnumerator()
    {
        return list.GetEnumerator();
    }

    public void CopyTo(KeyValuePair<string, T>[] array, int arrayIndex)
    {
        throw new NotImplementedException();
    }
}