using System;

public class Array<T>
{
    private T[] m_Items;
    private void Set(int index, T item)
    {
        m_Items[index] = item;
    }

    public T Get(int index)
    {
        return m_Items[index];
    }
}

//複数の型を定義できる
public class Pair<T1, T2>
{
    public T1 m_Key;
    public T2 m_Valie;
}

//whereを使って制約を設けることができる
//IComparableインターフェースを実装するクラスだけがTに指定
public static T Max<T>(T a, T b)where T : IComparable<T>
{
    if (0 < a.CompareTo(b))
        return a;
    else
        return b;
}

