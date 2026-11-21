public class Comment
{
    public string _name;
    public string _text;

    public string GetDisplayText()
    {
        return $"{_name}: {_text}";
    }
}