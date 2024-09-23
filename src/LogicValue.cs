namespace DefaultNamespace;

public class LogicValue : IInput
{
    public bool elpepe { get; set; }

    public LogicValue(bool valor)
    {
        elpepe = valor;
    }
    
    public bool Valor_epico()
    {
        return elpepe;
    }
}