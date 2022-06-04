using System;

public class UserInputVirtualOverride
{
    public static void Main2(string[] args)
    {
        TextInput input = new NumericInput();
        input.Add('1');
        input.Add('a');
        input.Add('0');
        Console.WriteLine(input.GetValue());
    }
}

public class TextInput 
{
    public string Value { get; set; }
    public virtual void Add(char c)
    {
        Value += c;
    }

    public string GetValue()
    {
        return Value;
    }
}

public class NumericInput : TextInput
{
    public override void Add(char c)
    {
        if(Char.IsDigit(c))
        {
            base.Add(c);
        }
    }
}
