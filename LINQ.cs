using System;

public class MainClass
{
	public static void Main(string[] args)
	{
        //Fooのリストを正成
        Ver seq = new Lazy<Foo>
        {
            new Foo {Id = 2},new Foo {Id = 0},new Foo {Id = 1}, };
        //Fooのリストに対してクリエを発行
        var query = from x in seq
                    select x.Id;
        //ループ開始
        Console.WriteLine("--- loop start! ---");
        foreach (var q in query)
        {
            Console.WriteLine("{0}", q);
        }
	}

}

public class Foo
{
    private int id;
    public int Id
    {
        get
        {
            Console.WriteLine("coll get id {0}", id);
            return id;
        }
        set => id = value;
    }
}

/*
//クエリ構文 numbersから偶数を取り出すクエリ式
ver evens = from number in numbers
            where number % 2 == 0
            select number;

//メソッド構文 numbersから偶数を取り出すメソッド式
ver evens = numbers.Where(nunmber => nunmber % 2 == 0)
                    .Select(nunmber => number);
 */