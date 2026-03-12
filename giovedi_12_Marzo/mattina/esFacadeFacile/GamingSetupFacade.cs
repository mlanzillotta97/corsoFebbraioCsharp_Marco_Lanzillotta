using System;

public class GamingSetupFacade
{
    private Monitor monitor;
    private Tastiera tastiera;
    private Mouse mouse;
    private SchedaVideo schedaVideo;

    private SistemaNotifiche notifiche;

    public GamingSetupFacade(SistemaNotifiche notifiche)
    {
        monitor = new Monitor();
        tastiera = new Tastiera();
        mouse = new Mouse();
        schedaVideo = new SchedaVideo();

        this.notifiche = notifiche;
    }

    public void AvviaPostazione()
    {
        Logger.Instance.Log("Avvio postazione gaming");

        schedaVideo.Avvia();
        monitor.Accendi();
        tastiera.Inizializza();
        mouse.Inizializza();

        notifiche.Notifica("La postazione gaming è stata avviata");
    }

    public void SpegniPostazione()
    {
        Logger.Instance.Log("Spegnimento postazione gaming");

        monitor.Spegni();
        schedaVideo.Spegni();

        notifiche.Notifica("La postazione gaming è stata spenta");
    }
}