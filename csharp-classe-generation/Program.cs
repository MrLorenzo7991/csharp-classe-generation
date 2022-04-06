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
        Console.Write(arrayDiInteri[i] + ", ");
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

StampaArrayDiStringhe(nomi);
StampaArrayDiStringhe (cognomi);
StampaEtaAlunni(eta);

AggiungiAlunno();

StampaArrayDiStringhe(nomi);
StampaArrayDiStringhe(cognomi);
StampaEtaAlunni(eta);

AggiungiAlunno();

StampaArrayDiStringhe(nomi);
StampaArrayDiStringhe(cognomi);
StampaEtaAlunni(eta);

