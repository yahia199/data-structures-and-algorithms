# Hashtables

A Hash Table is essentially an array with a set length filled with key value pairs.

## Challenge

Implement a Hashtable with:

- Add(key, value) - void return
- Find(string key) - returns the value from key/value pair
- Contains(string key) - returns bool
- GetHash(key) - returns array index

## Approach & Efficiency

Big (O) for Add function is O(n)

Big (O) for Get function is O(n)

Big (O) for Contain function is O(n)

Big (O) for Hash function is O(n)

## API

- Add
```C#
public void Add(string key, string value)
{
    int index = Hash(key);
    Node newNode = new Node(key, value);

    if (Table[index] == null)
    {
        Table[index] = newNode;
    }
    else
    {
        Node current = Table[index];
        while (current.Next != null)
        {
            current = current.Next;
        }
        current.Next = new Node(key, value);
    }
}
```
- Get
```C#
public Node Get(string key)
{
    int index = Hash(key);
    Node current = Table[index];

    while (current != null)
    {
        if (current.Key == key)
        {
            return current;
        }
        current = current.Next;
    }

    return null;
}```

- Contain
```C#
public bool Contains(string key)
{
    int index = Hash(key);
    Node current = Table[index];

    while (current != null)
    {
        if (current.Key == key)
        {
            return true;
        }
        current = current.Next;
    }

    return false;
}```
- Hash
```C#
public int Hash(string key)
{
    int hash = 0;

    foreach (int character in key)
    {
        hash += character;
    }

    return hash * 599 % 1014;
}```