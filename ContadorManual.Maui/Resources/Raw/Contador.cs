namespace ContadorManual.Maui.Resources.Raw
{
    public class Contador
    {
        public int _conteo;
        public int Conteo => _conteo;

        public Contador()
        {
            _conteo = 0;

        }
        public void contar()
        {
            _conteo++;
        }
        public void reiniciar()
        {
            _conteo = 0;
        }
    }
}
