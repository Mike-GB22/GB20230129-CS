// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
    +"ежели бы вас послали вместо нашего милого Винценгероде,"
    +"вы бы взяли приступом согласие прусского короля."
    +"Вы так красноречивы. Вы дадите мне чаю?";

string Repalace(string textIn, char oldValue, char newValue){
    string result = String.Empty;
    int length = textIn.Length;
    for(int i=0; i<length; i++){
        if(text[i] == oldValue) result += $"{newValue}";
        else result += $"{textIn[i]}";
    }
    
    return result;
}

string newText = Repalace(text, ' ', '|');
Console.WriteLine(newText+"\n");

newText = Repalace(newText, 'к', 'К');
Console.WriteLine(newText);
