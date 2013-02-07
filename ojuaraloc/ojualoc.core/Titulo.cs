namespace ojualoc.core
{
    public class Titulo : Entidade
    {
        public virtual string Nome { get; set; }

        public override string ToString()
        {
            return Nome;
        }
    }
}