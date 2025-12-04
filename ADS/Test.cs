/* 
Schreiben Sie eine Klasse Test, die das Interface IElementWithKey implementiert und erzeugen Sie 10 Objekte
mit ChangeableKey von 1 bis 10. Testen Sie damit die Methoden ExtractFirst, Insert und verändern Sie die
ChangeableKeys um IncreaseKey zu testen.
*/
public class Test : IElementWithKey
{
    private int _changeableKey;
    private Action? _changingAction;

    public int Key { get; }

    public int ChangeableKey
    {
        get => _changeableKey;
        set
        {
            _changeableKey = value;
            _changingAction?.Invoke();
        }
    }

    public Action ChangingAction
    {
        set => _changingAction = value;
    }

    public Test(int key, int changeableKey)
    {
        Key = key;
        _changeableKey = changeableKey;
    }
}
