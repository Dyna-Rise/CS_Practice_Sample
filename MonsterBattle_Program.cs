string[] charaName = { "ヒノタネ", "ミズトカゲ", "タネガメ", "ヒカッチュウ" };
string[] type = { "ほのお", "みず", "くさ", "かみなり" };
string[] weakPoint = { type[1], type[2], type[0], type[1] };
float[] attack = { 10.0f, 15.0f, 20.0f };

//int monster1 = 0;
//int monster2 = 1;
int monster1 = 0, monster2 = 1;
int attackNum1 = 0, attackNum2 = 0;
float hp1 = 50.0f, hp2 = 50.0f;
float plusPower = 1.0f;

Random rnd = new Random();
monster1 = rnd.Next(0,charaName.Length);
monster2 = rnd.Next(0,charaName.Length);

for (int i = 1; i < 4; i++)
{
    attackNum1 = rnd.Next(0, attack.Length);
    attackNum2 = rnd.Next(0, attack.Length);

    Console.WriteLine(i + "ターン目の表");
    Console.WriteLine(charaName[monster1] + "の攻撃");
    Console.WriteLine(type[monster1] + "属性の攻撃");
    if (type[monster1] == weakPoint[monster2])
    {
        Console.WriteLine("相手の弱点をついた！");
        plusPower = 1.5f;
    }
    else if (type[monster2] == weakPoint[monster1])
    {
        Console.WriteLine("効果がいまいちだ！");
        plusPower = 0.5f;
    }
    Console.WriteLine(charaName[monster2] + "に" + attack[attackNum1] * plusPower + "のダメージ");
    hp2 -= attack[attackNum1] * plusPower;
    Console.WriteLine(charaName[monster2] + "の残り体力:" + hp2);

    Console.WriteLine(i + "ターン目の裏");
    Console.WriteLine(charaName[monster2] + "の攻撃");
    Console.WriteLine(type[monster2] + "属性の攻撃");
    if (type[monster2] == weakPoint[monster1])
    {
        Console.WriteLine("相手の弱点をついた！");
        plusPower = 1.5f;
    }
    else if (type[monster1] == weakPoint[monster2])
    {
        Console.WriteLine("効果がいまいちだ！");
        plusPower = 0.5f;
    }
    Console.WriteLine(charaName[monster1] + "に" + attack[attackNum2] * plusPower + "のダメージ");
    hp1 -= attack[attackNum2] * plusPower;
    Console.WriteLine(charaName[monster1] + "の残り体力:" + hp1);
}


Console.WriteLine("勝負の結果は…");
if (hp1 > hp2)
{
    Console.WriteLine(charaName[monster1] + "の勝利!");
}
else if (hp1 < hp2)
{
    Console.WriteLine(charaName[monster2] + "の勝利!");
}
else
{
    Console.WriteLine("引き分け！");
}