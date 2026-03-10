namespace SistemaConfigurazione
{
    class DispositivoFactory
    {
        public static IDispositivo CreaDispositivo(string tipo)
        {
            if (tipo.ToLower() == "computer")
                return new Computer();

            if (tipo.ToLower() == "stampante")
                return new Stampante();

            return null;
        }
    }
}