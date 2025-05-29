/*
Design a HashSet without using any built-in hash table libraries.

Implement MyHashSet class:

void add(key) Inserts the value key into the HashSet.

bool contains(key) Returns whether the value key exists in the
HashSet or not.

void remove(key) Removes the value key in the HashSet. If key does
not exist in the HashSet, do nothing.

NOTE:
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.Add(key);
 * obj.Remove(key);
 * bool param_3 = obj.Contains(key);

*/


/* Using a boolean array */

public class MyHashSet
{

    private readonly bool[] set;

    public MyHashSet()
    {
        set = new bool[1_000_001];
    }

    public void Add(int key)
    {
        set[key] = true;
    }

    public void Remove(int key)
    {
        set[key] = false;
    }

    public bool Contains(int key)
    {
        return set[key];
    }
}

// Time complexity: O(1), all operations
// Space complexity: O(1_000_001) = ~1MB of memory


/* Using buckets and hashing (chaining)  */

public class MyHashSet
{
    private const int BucketSize = 769;
    private List<int>[] buckets;

    public MyHashSet()
    {
        buckets = new List<int>[BucketSize];
        for (int i = 0; i < BucketSize; i++)
        {
            buckets[i] = new List<int>();
        }
    }

    private int GetBucketIndex(int key)
    {
        return key % BucketSize;
    }

    public void Add(int key)
    {
        int index = GetBucketIndex(key);
        if (!buckets[index].Contains(key))
        {
            buckets[index].Add(key);
        }
    }

    public void Remove(int key)
    {
        int index = GetBucketIndex(key);
        buckets[index].Remove(key);
    }

    public bool Contains(int key)
    {
        int index = GetBucketIndex(key);
        return buckets[index].Contains(key);
    }
}

// Time complexity: O(n / m) * but average time is O(1)
// Space complexity: O(n + m)