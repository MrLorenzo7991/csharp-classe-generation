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
    Console.WriteLine(arrayDiInteri[arrayDiInteri.Length - 1] + "] \n");
}

void AggiungiAlunno()
{
    if (numeroPartecipantiAttuali == numeroPartecipantiMassimi) 
    {
        Console.WriteLine("Hai Raggiunto il numero massimo di partecipanti, non puoi aggiungere nuovi alunni.\n");
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
                Console.WriteLine("Il formato dell'età inserito non è corretto, perfavore riprova.\n");
            }

        }while (!flag);
        Console.WriteLine("Un nuovo alunno è stato aggiunto! Questa è la tua nuova classe:");
        StampaArrayDiStringhe(nomi);
        StampaArrayDiStringhe(cognomi);
        StampaEtaAlunni(eta);

    }
}

void RimuoviUltimoAlunno()
{
    if (numeroPartecipantiAttuali == 0)
    {
        Console.WriteLine("Non è presente nessun alunno nella classe \n");
    }
    else
    {
        nomi[numeroPartecipantiAttuali -1] = " ";
        cognomi[numeroPartecipantiAttuali -1] = " ";
        eta[numeroPartecipantiAttuali -1] = 0;
        numeroPartecipantiAttuali--;
        Console.WriteLine("L'ultimo alunno è stato eliminato! Questa è la tua nuova classe:");
        StampaArrayDiStringhe(nomi);
        StampaArrayDiStringhe(cognomi);
        StampaEtaAlunni(eta);
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

void StudentePiuGiovane()
{
    int etaPiuGiovane = eta[0];
    int indiceStudentePiuGiovane = 0;
    for (int i = 0; i < eta.Length; i++)
    {
        if (eta[i] < etaPiuGiovane && eta[i] != 0)
        {
            etaPiuGiovane = eta[i];
            indiceStudentePiuGiovane = i;
        }
    }
    Console.WriteLine("Lo studente più giovane è:");
    Console.WriteLine(nomi[indiceStudentePiuGiovane] + "\t" + cognomi[indiceStudentePiuGiovane] + "\t" + etaPiuGiovane + " anni \n");
}

void StudentePiuVecchio()
{
    int etaPiuVecchio = eta[0];
    int indiceStudentePiuVecchio = 0;
    for (int i = 0; i < eta.Length; i++)
    {
        if (eta[i] > etaPiuVecchio)
        {
            etaPiuVecchio = eta[i];
            indiceStudentePiuVecchio = i;
        }
    }
    Console.WriteLine("Lo studente più vecchio è:");
    Console.WriteLine(nomi[indiceStudentePiuVecchio] + "\t" + cognomi[indiceStudentePiuVecchio] + "\t" + etaPiuVecchio + " anni \n");
}
/*---------------------PROGRAMMA------------------------*/
Console.WriteLine("Benvenuto! \n ");
Console.WriteLine("Questa è la tua classe: ");
StampaArrayDiStringhe(nomi);
StampaArrayDiStringhe(cognomi);
StampaEtaAlunni(eta);
Console.WriteLine();

while (true)
{
    Console.WriteLine("Cosa vuoi fare? (scrivi il numero dell'operazione scelta)");
    Console.WriteLine("1) Aggiungere o rimuovere un alunno");
    Console.WriteLine("2) Stampare la classe");
    Console.WriteLine("3) Calcolare l'età media della classe");
    Console.WriteLine("4) Conoscere lo studente più giovane");
    Console.WriteLine("5) Conoscere lo studente più vecchio \n");
    
    bool flag = false;
    int sceltaOperazione = 0;
    do
    {

        int sceltaOperzione = 0;
        if (int.TryParse(Console.ReadLine(), out int scelta))
        {
            sceltaOperazione = scelta;
            flag = true;
        }
        else
        {
            Console.WriteLine("Scegli un numero da 1 a 5 perfavore \n");
        }
    } while (flag == false); 
    
    switch (sceltaOperazione)
    {
        case 1:
            Console.WriteLine("Vuoi aggiungere o rimuovere un alunno [aggiungere/rimuovere]?");
            string scelta = Console.ReadLine();
            switch (scelta)
            {
                case "aggiungere":
                    AggiungiAlunno();
                    break;
                case "rimuovere":
                    RimuoviUltimoAlunno();
                    break;
                default:
                    Console.WriteLine("Scelta non valida, riprova \n");
                    break;
            }
            break;
        case 2:
            StampaArrayDiStringhe(nomi);
            StampaArrayDiStringhe(cognomi);
            StampaEtaAlunni(eta);
            break;
        case 3:
            Console.WriteLine("L' età media della classe è di: " + CalcolaEtaMediaClasse(eta, numeroPartecipantiAttuali) + " anni \n");
            break ;
        case 4:
            StudentePiuGiovane();
            break;
        case 5:
            StudentePiuVecchio();
            break;
        default :
            Console.WriteLine("Scegli un numero da 1 a 5 perfavore \n");
            break;
    }
}







