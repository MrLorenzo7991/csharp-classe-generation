/*--------------------VARIABILI--------------------*/
int numeroPartecipantiMassimi = 10;
int numeroPartecipantiAttuali = 0;
string[] nomi = new string[numeroPartecipantiMassimi];
string[] cognomi = new string[numeroPartecipantiMassimi];
int[] eta = new int[numeroPartecipantiMassimi];

/*--------------------FUNZIONI--------------------*/
void StampaArrayDiStringhe(string[] arrayDiStringhe)
{
    Console.Write("[");
    for (int i = 0; i < arrayDiStringhe.Length - 1 ; i++)
    {
        Console.Write(arrayDiStringhe[i] + ", ");
    }
    Console.WriteLine(arrayDiStringhe[arrayDiStringhe.Length - 1] + "]");
}

void StampaEtaAlunni(int[] arrayDiInteri)
{
    Console.Write("[");
    for (int i = 0; i < arrayDiInteri.Length - 1; i++)
    {
        Console.Write(arrayDiInteri[i] + ",\t ");
    }
    Console.WriteLine(arrayDiInteri[arrayDiInteri.Length - 1] + "]");
}

void AggiungiAlunno()
{
    if (numeroPartecipantiAttuali == numeroPartecipantiMassimi)  //è giusto inserire variabili che non sono presenti in input?
    {
        Console.WriteLine("Hai Raggiunto il numero massimo di partecipanti, non puoi aggiungere nuovi alunni.");
    }
    else
    {
        Console.WriteLine("Inserisci il nome dell'alunno che vuoi aggiungere:");
        nomi [numeroPartecipantiAttuali] = Console.ReadLine();
        Console.WriteLine("Inserisci il cognonome dell'alunno che vuoi aggiungere:");
        cognomi [numeroPartecipantiAttuali] = Console.ReadLine();
        Console.WriteLine("Inserisci l'età dell'alunno che vuoi aggiungere:");
        bool flag = false;
        do
        {
            if (int.TryParse(Console.ReadLine(), out int etaCorretto))
            {
                eta[numeroPartecipantiAttuali] = etaCorretto;
                numeroPartecipantiAttuali++;
                flag = true;
            }
            else
            {
                Console.WriteLine("Il formato dell'età inserito non è corretto, perfavore riprova.");
            }

        }while (!flag);


    }
}

void RimuoviUltimoAlunno()
{
    if (numeroPartecipantiAttuali == 0)
    {
        Console.WriteLine("Non è presente nessun alunno nella classe");
    }
    else
    {
        nomi[numeroPartecipantiAttuali -1] = " ";
        cognomi[numeroPartecipantiAttuali -1] = " ";
        eta[numeroPartecipantiAttuali -1] = 0;
        numeroPartecipantiAttuali--;
    }
}

double CalcolaEtaMediaClasse(int[] eta, int numeroDiPartecipanti)
{
    int somma = 0;
    for(int i = 0; i < eta.Length; i++)
    {
        somma += eta[i];
    }
    double media = (double)somma / numeroDiPartecipanti;
    return media;
}

int EtaPiuGiovane(int[] eta)
{
    int piuGiovane = eta[0];
    for(int i = 0; i < eta.Length; i++)
    {
        if (eta[i] < piuGiovane)
        {
            piuGiovane = eta[i];
        }
    }
    return piuGiovane;
}

int EtaPiuVecchio(int[] eta)
{
    int piuVecchio = eta[0];
    for (int i = 0; i < eta.Length; i++)
    {
        if (eta[i] > piuVecchio)
        {
            piuVecchio = eta[i];
        }
    }
    return piuVecchio;
}

/*---------------------PROGRAMMA------------------------*/
Console.WriteLine("Benvenuto! \n ");
Console.WriteLine("Questa è la tua classe: ");
StampaArrayDiStringhe(nomi);
StampaArrayDiStringhe(cognomi);
StampaEtaAlunni(eta);
while (true)
{
    Console.WriteLine("Vuoi aggiungere o rimuovere un alunno [aggiungere/rimuovere]?");
    string scelta = Console.ReadLine();
    switch (scelta)
    {
        case "aggiungere":
            AggiungiAlunno();
            Console.WriteLine("Un nuovo alunno è stato aggiunto! Questa è la tua nuova classe:");
            StampaArrayDiStringhe(nomi);
            StampaArrayDiStringhe(cognomi);
            StampaEtaAlunni(eta);
            break;
        case "rimuovere":
            RimuoviUltimoAlunno();
            Console.WriteLine("L' ultimo alunno è stato rimosso! Questa è la tua nuova classe:");
            StampaArrayDiStringhe(nomi);
            StampaArrayDiStringhe(cognomi);
            StampaEtaAlunni(eta);
            break;
        default:
            Console.WriteLine("Scelta non valida, scrivi aggiungere o rimuovere");
            break;
    }
}


