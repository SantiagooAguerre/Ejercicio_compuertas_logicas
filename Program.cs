namespace DefaultNamespace;

public class Program
{
    static void Main(string[] args)
    {
        IInput entradaA = new LogicValue(false);
        IInput entradaB = new LogicValue(false);
        IInput entradaC = new LogicValue(true);

        IGate primer_and = new AndGate();
        primer_and.AddInput(entradaA);
        primer_and.AddInput(entradaB);

        IGate entradaA_negada = new NotGate();
        IGate entradaB_negada = new NotGate();
        entradaA_negada.AddInput(entradaA);
        entradaB_negada.AddInput(entradaB);
        
        IGate segundo_and = new AndGate();
        segundo_and.AddInput(entradaA_negada);
        segundo_and.AddInput(entradaB_negada);
        
        IGate primer_or = new OrGate();
        primer_or.AddInput(segundo_and);
        primer_or.AddInput(primer_and);
        
        IGate ultimo_and = new AndGate();
        ultimo_and.AddInput(primer_or);
        ultimo_and.AddInput(entradaC);

        Console.WriteLine(ultimo_and.Valor_epico());
    }
}