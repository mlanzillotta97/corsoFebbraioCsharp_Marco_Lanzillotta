public class Servizio
{
    public void EseguiOperazione()
    {
        Logger logger = Logger.GetIstanza();
        logger.ScriviMessaggio("Operazione eseguita dalla classe Servizio");
    }
}