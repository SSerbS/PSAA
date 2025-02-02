class Program{
    static void Main(){
        Console.WriteLine("Digite o nome do paciente! Ele tem menos de 18? (true/false)");
        Paciente paciente = new Paciente(Console.ReadLine(), Console.ReadLine());
        paciente.preencheRespostas();
        paciente.converteParaAreas();
        paciente.resultadoGeral();
        paciente.exibeGabaritoPreenchido();
        paciente.exibePorAreas();
        Console.WriteLine("Deseja salvar os resultados? Digite 's' minúsculo se sim");
        if(Console.ReadLine() == "s"){
            paciente.SalvarResultados();
        }
    }
}