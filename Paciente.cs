class Paciente{
    string nome;
    string menorDeIdade;
    public Paciente(string nome, string menorDeIdade){
        this.nome = nome;
        this.menorDeIdade = menorDeIdade;
    }
    int[] respostas= new int[60];
    
    int q1br = 0; //Baixo Registro
    int q2ps = 0; //Procura Sensação
    int q3ss = 0; //Sensitividade Sensorial
    int q4es = 0; //Evita Sensação
    int resQ1br = 0;
    int resQ2ps = 0;
    int resQ3ss = 0;
    int resQ4es = 0;
    int[] arQ1br = [3,6,12,15,21,23,36,37,39,41,44,45,52,55,59];
    int[] arQ2pq = [2,4,8,10,14,17,19,28,30,32,40,42,47,50,58];
    int[] arQ3ss = [7,9,13,16,20,22,25,27,31,33,34,48,51,54,60];
    int[] arQ4es = [1,5,11,18,24,26,29,35,38,43,46,49,53,56,57];
    public void preencheRespostas(){
        Console.WriteLine($"Preenchendo os dados de {nome}!");
        for(int i = 0; i < respostas.Length; i++){ //lembrar que i sempre estará um abaixo do item de fato
            if(i == 0){
                Console.WriteLine($"Preenchendo a questão {i+1}");
            }
            else{
                Console.WriteLine($"Preenchendo a questão {i+1}! Se quiser corrigir a anterior, digite 'b' em minúsculas!");
            }
            var respAtualString = Console.ReadLine();
            if(respAtualString != "b" || i == 0){ //segue na iteração atual caso digite b ou esteja na primeira iteração
                if(int.TryParse(respAtualString, out int respAtualOK)){ //se for um número, segue
                    if(respAtualOK > 0 && respAtualOK < 6){ //verifica se é 1, 2, 3, 4 ou 5
                        respostas[i] = respAtualOK - 1; //deixa no padrão (0123) para ser lido pela função das áreas
                    }
                    else{
                        //Console.Clear();
                        Console.WriteLine("Digite um número válido (1,2,3,4)! Tente novamente!");
                        i--;
                        continue;
                    }
                }
                else{ //caso alguma letra tenha sido digitada
                    //Console.Clear();
                    Console.WriteLine("Digite apenas números! Tente novamente");
                    i--; //repete a tentativa de preencher o valor atual
                    continue;
                }
            }
            else{// caso tenha digitado "b"
            //Console.Clear();
            i = i-2;
            continue;
            }
        }
        Console.WriteLine("Respostas computadas!");
    }

    public void exibeGabaritoPreenchido(){
        for(int i = 0; i < respostas.Length; i++){
            Console.WriteLine($"Questão {i+1} marcou gabarito {respostas[i]+1}");
        }
    }

    public void resultadoGeral(){
        if(menorDeIdade == "true"){
                if (q1br >= 15 && q1br <= 18){ resQ1br = 1;}
                if (q1br >= 19 && q1br <= 26){ resQ1br = 2;}
                if (q1br >= 27 && q1br <= 40){ resQ1br = 3;}
                if (q1br >= 41 && q1br <= 51){ resQ1br = 4;}
                if (q1br >= 52 && q1br <= 75){ resQ1br = 5;}

                if (q2ps >= 15 && q2ps <= 27){ resQ2ps = 1;}
                if (q2ps >= 28 && q2ps <= 41){ resQ2ps = 2;}
                if (q2ps >= 42 && q2ps <= 58){ resQ2ps = 3;}
                if (q2ps >= 59 && q2ps <= 65){ resQ2ps = 4;}
                if (q2ps >= 66 && q2ps <= 75){ resQ2ps = 5;}

                if (q3ss >= 15 && q3ss <= 19){ resQ3ss = 1;}
                if (q3ss >= 20 && q3ss <= 25){ resQ3ss = 2;}
                if (q3ss >= 26 && q3ss <= 40){ resQ3ss = 3;}
                if (q3ss >= 41 && q3ss <= 48){ resQ3ss = 4;}
                if (q3ss >= 49 && q3ss <= 75){ resQ3ss = 5;}

                if (q4es >= 15 && q4es <= 18){ resQ4es = 1;}
                if (q4es >= 19 && q4es <= 26){ resQ4es = 2;}
                if (q4es >= 27 && q4es <= 40){ resQ4es = 3;}
                if (q4es >= 41 && q4es <= 51){ resQ4es = 4;}
                if (q4es >= 52 && q4es <= 75){ resQ4es = 5;}
            }
            else{
                if (q1br >= 15 && q1br <= 18){ resQ1br = 1;}
                if (q1br >= 19 && q1br <= 23){ resQ1br = 2;}
                if (q1br >= 24 && q1br <= 35){ resQ1br = 3;}
                if (q1br >= 36 && q1br <= 44){ resQ1br = 4;}
                if (q1br >= 45 && q1br <= 75){ resQ1br = 5;}

                if (q2ps >= 15 && q2ps <= 35){ resQ2ps = 1;}
                if (q2ps >= 36 && q2ps <= 42){ resQ2ps = 2;}
                if (q2ps >= 43 && q2ps <= 56){ resQ2ps = 3;}
                if (q2ps >= 57 && q2ps <= 62){ resQ2ps = 4;}
                if (q2ps >= 63 && q2ps <= 75){ resQ2ps = 5;}

                if (q3ss >= 15 && q3ss <= 18){ resQ3ss = 1;}
                if (q3ss >= 19 && q3ss <= 23){ resQ3ss = 2;}
                if (q3ss >= 24 && q3ss <= 35){ resQ3ss = 3;}
                if (q3ss >= 36 && q3ss <= 44){ resQ3ss = 4;}
                if (q3ss >= 45 && q3ss <= 75){ resQ3ss = 5;}

                if (q4es >= 15 && q4es <= 19){ resQ4es = 1;}
                if (q4es >= 20 && q4es <= 26){ resQ4es = 2;}
                if (q4es >= 27 && q4es <= 41){ resQ4es = 3;}
                if (q4es >= 42 && q4es <= 49){ resQ4es = 4;}
                if (q4es >= 50 && q4es <= 75){ resQ4es = 5;}
            }
        }

    public void exibePorAreas(){
                Console.WriteLine($"Baixo Registro: {q1br} // {resQ1br}");
                Console.WriteLine($"Procura Sensação: {q2ps} // {resQ2ps}");
                Console.WriteLine($"Sensitividade Sensorial: {q3ss} // {resQ3ss}");
                Console.WriteLine($"Evita Sensação: {q4es} // {resQ4es}");
    }
    public void converteParaAreas(){
        for(int i = 0; i < respostas.Length; i++){
                if(arQ1br.Contains(i+1)){ //verifica se o item atual é de Baixo Registro
                    q1br += respostas[i]+1;
                }
                else if(arQ2pq.Contains(i+1)){
                    q2ps += respostas[i]+1;
                }
                else if(arQ3ss.Contains(i+1)){
                    q3ss += respostas[i]+1;
                }
                else if(arQ4es.Contains(i+1)){
                    q4es += respostas[i]+1;
                }
            }
        }
    public void SalvarResultados(){
        string local = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        string filename = @$"PSAA_{nome}.txt";
        string path = Path.Combine(local, filename);
        int contador = 1;

        while(File.Exists(path)){
            filename = @$"SRS2_{nome}{contador}.txt";
            path = Path.Combine(local, filename);
            contador++;
        }
        if(!File.Exists(path)){
            using(StreamWriter sw = File.CreateText(path)){
                for(int i = 0; i < respostas.Length; i++){
                sw.WriteLine($"Questão {i+1} marcou gabarito {respostas[i]+1}");
                }
                sw.WriteLine();
                sw.WriteLine($"Baixo Registro: {q1br} // {resQ1br}");
                sw.WriteLine($"Procura Sensação: {q2ps} // {resQ2ps}");
                sw.WriteLine($"Sensitividade Sensorial: {q3ss} // {resQ3ss}");
                sw.WriteLine($"Evita Sensação: {q4es} // {resQ4es}");
                sw.WriteLine();
                Console.WriteLine("Arquivo salvo!");
            }
        }
    }
}