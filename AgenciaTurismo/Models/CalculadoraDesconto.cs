namespace AgenciaTurismo.Models
{
    public class CalculadoraDesconto
    {
        public static decimal AplicarDesconto10(decimal precoOriginal)
        {
            return precoOriginal * 0.9m;
        }
    }
}
