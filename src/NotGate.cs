namespace DefaultNamespace;

public class NotGate : IGate
{
    private IInput pepe;
    public void AddInput(IInput pepe)
    {
        this.pepe = pepe;
    }
    
    public bool Valor_epico()
    {
        return !pepe.Valor_epico();
    }
}