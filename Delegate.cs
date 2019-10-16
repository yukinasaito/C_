
//デリゲート


//string型を引数にとってintを返す、メソッド
public delegate int Intoint(int value);
//引数をとらずintを返すメソッド
public delegate int ReturnInt();


//インスタンスを作るデリゲート型
public delegate int IntToInt(int value);

public class Calculator
{
    public static int AddOne(int value)
    {
        return value + 1;
    }
}
//デリゲートのインスタンスを作るには
IntToInt addOne = Calculator.AddOne;


public  class Multiplier
{
    readonly int number;

    public Multiplier(int number)
    {
        this.number = number;
    }
    public int Calc (int v)
    {
        return number * v;
    }

}

//Calcメソッドを参照するIntToIntデリゲート型のインスタンスを作る

Multiplier doubler = new Multiplier(2);// Calcメソッドは引数で渡した数の2倍の数を返す
IntToInt doublerIntToInt = doubler.Calc;// doublerのCalcを参照するデリゲートを生成


Multiplier trippler = new Multiplier(3);// Calcメソッドは引数で渡した数の3倍の数を返す
IntToInt tripplerIntToInt = trippler.Calc;// tripplerのCalcを参照するデリゲートを生成




