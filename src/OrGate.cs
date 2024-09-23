namespace DefaultNamespace;

public class OrGate : IGate
{
    public List<IInput> entradas = new List<IInput>();
    public void AddInput(IInput pepe)
    {
        entradas.Add(pepe);
    }

    public bool Valor_epico()
    {
        bool value = false;
        foreach (var valores_completos in entradas)
        {
            value = value || valores_completos.Valor_epico();;
        }
        
        return value;
    }
}