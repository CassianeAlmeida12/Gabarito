public class Prova
{
    public char[] respostaAluno = new char[15];//Utilizado para armazenar as respostas do aluno
    Gabarito gaba;//criar um objeto do tipo gabarito

    public Prova(Gabarito gaba)
    {
        this.gaba = gaba;
    }

    public void RespostaAluno(char respostaQ)
    {
        for(int i = 0; i < respostaAluno.Length; i++) //está percorrendo o array
        {
            if (respostaAluno[i] == 0) //verificando as casas livres do array
            {
                respostaAluno[i] = respostaQ; //está armazenando a reposta do aluno.
                break; //se não colocar da erro
            }
        }
    }

    public int Acertos()
    {
        int qtAcertos = 0;
        for(int i = 0; i < respostaAluno.Length;i++)
        {
            if(respostaAluno[i] == gaba.RespostaQuestao(i)) // vai verificar se a questão que o aluno digitou corresponde a questão correta do gabarito
            {
                qtAcertos += 1;// vai armazenar quantas questões ele acertou
            }
        }
        return qtAcertos;
    }

    public double Nota()
    {
        double nota = 0;
        for(int i = 0; i < respostaAluno.Length; i++)
        {
            if(respostaAluno [i] == gaba.RespostaQuestao(i))
            {
                if(i < 10)
                {
                    nota += 0.5;
                }
                else
                {
                    nota += 1;
                }
            }
        }
        return nota;
    }
}
