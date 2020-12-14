namespace POO_Static
{
    public class Conversor
    {
        private static float cotacaoDolar = 5.24f;
        private static float cotacaoEuro = 6.16f;

        public static float RealParaDolar(float valorRS){
            return valorRS / cotacaoDolar;

        }

        public static float DolarParaReal(float valorUS){
            return cotacaoDolar  * valorUS;
        }
        public static float RealParaEuro(float valorRS){
            return cotacaoEuro * valorRS;

        }
    }
}