public class Gabarito
{
    public char[] gabaritoCorreto = {'A', 'B', 'C', 'D', 'E', 'B', 'C', 'A', 'D', 'A', 'A', 'C', 'D', 'D', 'A' } ;
    

    public char RespostaQuestao(int nQuestoes)//vou receber por parametro o int da questao
    {
        return this.gabaritoCorreto[nQuestoes];
    }


}