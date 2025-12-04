using System.Dynamic;

public class BinaryNodeAufgabeZwei
{

    public object element;
    public BinaryNodeAufgabeZwei left;
    public BinaryNodeAufgabeZwei right;

    public BinaryNodeAufgabeZwei(object element)
    {
        this.element = element;
        this.left = Left;
        this.right = Right;
    }
    
    public object Element
    {
        get { return element; }
        set { element = value; }
    }

    public BinaryNodeAufgabeZwei Left
    {
        get { return left; }
        set { left = value; }
    }
    public BinaryNodeAufgabeZwei Right
    {
        get { return right; }
        set { right = value; }   
    }
}