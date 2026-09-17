namespace ClasseAbstrata
{
    internal interface ISalvavel
    {
        void Salvar();
    }
    public class Documento : ISalvavel
    {
        public void Salvar()
        {
            Console.WriteLine("SALVANDO O DOCUMENTO EM FORMATO .DOC");
        }
    }
    public class Foto : ISalvavel
    {
        public void Salvar()
        {
            Console.WriteLine("SALVANDO A FOTO EM FORMATO .JPG");
        }
    }

}