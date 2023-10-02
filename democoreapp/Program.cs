using Azure.Storage.Blobs;

string connection = "DefaultEndpointsProtocol=https;AccountName=demoappcore;AccountKey=NRxUzd2doH+FDsQYiVNK+25vBugCgdL3LriRNkS+jpAqLXAMVOXVh4DG7aVn0O7hQ+TBo7kFKh7W+ASt8CySmg==;EndpointSuffix=core.windows.net";
Console.WriteLine("Ingrese el nombre del BLOB: ");
string name = Console.ReadLine();
Console.WriteLine(name);
BlobServiceClient blobServiceClient = new BlobServiceClient(connection);

await blobServiceClient.CreateBlobContainerAsync(name);

Console.WriteLine($"Se creo el blob con el nombre de {name}");