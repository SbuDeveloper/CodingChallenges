// See https://aka.ms/new-console-template for more information

using HollardAssessment;

DocumentStore documentStore = new DocumentStore(2);
documentStore.AddDocument("item");
Console.WriteLine(documentStore);