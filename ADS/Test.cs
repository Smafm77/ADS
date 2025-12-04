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