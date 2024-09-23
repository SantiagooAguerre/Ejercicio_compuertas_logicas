namespace DefaultNamespace;

public class AndGate : IGate
{
    public List<IInput> entradas = new List<IInput>();
    public void AddInput(IInput pepe)
    {
        entradas.Add(pepe);
    }
    
    public bool Valor_epico()
    {
        bool value = true;
        foreach (var valores_completos in entradas)
        {
            value = value && valores_completos.Valor_epico();
        }
        
        return value;
    }
}