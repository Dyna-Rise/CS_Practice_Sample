//string[] charaName = new string[3];
//charaName[0] = "ヒノタネ";
//charaName[1] = "ミズトカゲ";
//charaName[2] = "タネガメ";

using System.Xml.Linq;

string[] charaName = { "ヒノタネ","ミズトカゲ","タネガメ"};

string[] type = { "ほのお", "みず", "くさ" };

string[] weakPoint = { type[1], type[2], type[0] };

float[] attack = { 10.0f, 15.0f, 20.0f };
int maxHp = 50;

//Console.WriteLine("名前:" + name1);
//Console.WriteLine("タイプ:" + fire);
//Console.WriteLine("弱点:" + fireWeakPoint);
//Console.WriteLine("最大HP:" + maxHp);
//Console.WriteLine("攻撃パワー1:" + attack1);
//Console.WriteLine("攻撃パワー2:" + attack2);
//Console.WriteLine("攻撃パワー3:" + attack3);

Console.WriteLine("名前:" + charaName[0]);
Console.WriteLine("タイプ" + type[0]);
Console.WriteLine("弱点" +  weakPoint[0]);
Console.WriteLine("最大HP:" + maxHp);
Console.WriteLine("攻撃パワー1" + attack[0]);
Console.WriteLine("攻撃パワー2" + attack[1]);
Console.WriteLine("攻撃パワー3" + attack[2]);

//複数箇所同時選択　2つ目以降をAlt(Option)とCtl(Command)押しながらマウス選択
//→　解除は関係ないところをクリックしてカーソルを外す

Console.WriteLine("名前:" + charaName[1]);
Console.WriteLine("タイプ" + type[1]);
Console.WriteLine("弱点" + weakPoint[1]);
Console.WriteLine("最大HP:" + maxHp);
Console.WriteLine("攻撃パワー1" + attack[0]);
Console.WriteLine("攻撃パワー2" + attack[1]);
Console.WriteLine("攻撃パワー3" + attack[2]);

Console.WriteLine("名前:" + charaName[2]);
Console.WriteLine("タイプ" + type[2]);
Console.WriteLine("弱点" + weakPoint[2]);
Console.WriteLine("最大HP:" + maxHp);
Console.WriteLine("攻撃パワー1" + attack[0]);
Console.WriteLine("攻撃パワー2" + attack[1]);
Console.WriteLine("攻撃パワー3" + attack[2]);

