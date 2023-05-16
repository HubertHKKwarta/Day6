using Azure;
using Azure.Data.Tables;

var connectionString = "DefaultEndpointsProtocol=https;AccountName=volleyballsa;AccountKey=BtD9aTXIs21vo+uIUdZwNB7BddWBCwSjhsucb6DaxfkWFZ7QT1SLweM+4GfYO52c01ckfw+RX4hS+AStclaibg==;EndpointSuffix=core.windows.net";



string tableName = "Persons";

var  tableClient = new TableClient(connectionString, tableName);

//Azure.Data.Tables

//// Create a table in your storage account
await tableClient.CreateIfNotExistsAsync();
//// Insert an entity into the table
//var entity = new TableEntity("volleyball", "player5")
//    {
//        { "firstname", "john" },
//        { "country", "BRA" },
//        { "phonenumber", "123456" },
//    };
//await tableClient.AddEntityAsync(entity);
//Console.WriteLine("Entity added to the table.");


// Query entities from the table
//var entity = new TableEntity("volleyball", "player6");
//string partitionKeyFilter = $"PartitionKey eq '{entity.PartitionKey}'";
//await foreach (var e in tableClient.QueryAsync<TableEntity>(partitionKeyFilter))
//{
//    Console.WriteLine($"" +
//        $"PartitionKey: {e.PartitionKey}," +
//        $" RowKey: {e.RowKey}," +
//        $" Property1: {e.GetString("country")}, " +
//        $" Property2: {e.GetString("firstname")}, " +
//        $" Property3: {e.GetString("lastname")}, "); 


//}
//updating
//var entity = new TableEntity("volleyball", "player5");
//entity["country"] = "NewValue1";
//await tableClient.UpdateEntityAsync(entity, ETag.All);
//Console.WriteLine("Entity updated in the table.");

