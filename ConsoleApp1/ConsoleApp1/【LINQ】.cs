using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {
        LinqTest.Test0();
        LinqTest.Test1();
        LinqTest.Test2();
        LinqTest.Test3();
        LinqTest.Test4();
        Console.WriteLine("キーを押すと終了します > ");
        Console.ReadKey();
    }
}

public class Dog
{
    public string name { get; set; }
    public int weight { get; set; }
    public string color { get; set; }

}

public class LinqTest
{

    public static List<Dog> dogList = new List<Dog>(){
        new Dog(){name = "shiba", weight = 40, color = "brown"},
        new Dog(){name = "chihuahua", weight = 6,  color = "white"},
        new Dog(){name = "bull dog", weight = 40, color = "black"},
        new Dog(){name = "poodle", weight = 20, color = "brown"},
        new Dog(){name = "pug", weight = 60, color = "white"},
    };

    // Q0. 犬を出力します。
    public static void Test0()
    {
        // 犬を出力するサンプル
        Dog dog = dogList.FirstOrDefault();
        Console.WriteLine("私は" + dog.name + "です。" + dog.color + "で" + dog.weight.ToString() + "kgです。");

        // Listの中身を1個ずつ出力して確認するサンプル
        for (int i = 0; i < dogList.Count; i++)
        {
            dog = dogList[i];
            Console.WriteLine("私は" + dog.name + "です。" + dog.color + "で" + dog.weight.ToString() + "kgです。" + "Listの" + i.ToString() + "番目にいます");
        }
    }

    // Q1. .Whereを使って、重さが30以上の犬だけのList<Dog> heavyDogList を出力してください。
    public static void Test1()
    {
        Console.WriteLine("Q1");
        List<Dog> heavyDogList = dogList
            .Where(dog => dog.weight >= 30).ToList();
        for (int i = 0; i < heavyDogList.Count; i++)
        {
            Dog dog = heavyDogList[i];
            Console.WriteLine("私は" + dog.name + "です。" + dog.color + "で" + dog.weight.ToString() + "kgです。" + "Listの" + i.ToString() + "番目にいます");
        }
    }
    // Q2. .Selectを使って、体色だけのList<string> dogColorList を出力してください。
    public static void Test2()
    {
        Console.WriteLine("Q2");
        List<string> dogColorList = dogList
            .Select(dog => dog.color).ToList();
        for (int i = 0; i < dogColorList.Count; i++)
        {
            string dogColor = dogColorList[i];
             Console.WriteLine("私は" + dogColor + "です。");
        }
    }

    // Q3. .FirstOrDefalutを使って、名前が"shiba"の犬 Dog shiba を1つ出力してください。
    public static void Test3()
    {
        Console.WriteLine("Q3");
        Dog shiba = dogList
            .FirstOrDefault(dog => dog.name == "shiba");
        for (int i = 0; i < 1; i++)
        {
            Dog dog = shiba;
            Console.WriteLine("私は" + dog.name + "です。" + dog.color + "で" + dog.weight.ToString() + "kgです。");
        }
    }
    // Q4. .Whereと.Selectを組み合わせて、体色が"brown"の犬の名前のList<string> brownDogNameListを出力してください。
    public static void Test4()
    {
        Console.WriteLine("Q4");
        List<string> brownDogNameList =  dogList
            .Where(dog => dog.color == "brown")
            .Select(dog => dog.name).ToList();

        for (int i = 0; i < brownDogNameList.Count ; i++)
        {
            string brownDogName = brownDogNameList[i];
            Console.WriteLine("名前は" + brownDogName + "です。" );
        }
    }
}