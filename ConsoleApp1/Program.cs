using ConsoleApp1;
using System;
using System.Threading;

string key;

void Menu()
{

    Console.Clear();

    Console.Write("Key [ basic / pro / expert ] : ");
    
    key = Console.ReadLine();
    
    if(key.ToUpper() == "BASİC")
    {
        DocumentProgram docProgram = new DocumentProgram();
        docProgram.OpenDocument();
    }
    else if(key.ToUpper() == "PRO")
    {
        DocumentProgram docProgram = new ProDocumentProgram();
        ProDocumentProgram proDocument = (ProDocumentProgram)docProgram;
        proDocument.ProDocumentProgramMenu();
    }
    else if(key.ToUpper() == "EXPERT")
    {
        DocumentProgram docProgram = new ExpertDocument();
        ExpertDocument expert = (ExpertDocument)docProgram;
        expert.ExpertDocumentMenu();
    }
    else
    {
        Console.WriteLine("\nWrong Key");
        Thread.Sleep(1000);
        Menu();
    }
    

}

Menu();