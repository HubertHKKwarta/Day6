﻿
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using System.Reflection.Metadata;
//uploading
//var connectionString = "DefaultEndpointsProtocol=https;AccountName=volleyballsa;AccountKey=BtD9aTXIs21vo+uIUdZwNB7BddWBCwSjhsucb6DaxfkWFZ7QT1SLweM+4GfYO52c01ckfw+RX4hS+AStclaibg==;EndpointSuffix=core.windows.net";
//var containerName = "volleyballpictures";
//var blobServiceClient = new BlobServiceClient(connectionString);
//var containerClient =
//blobServiceClient.GetBlobContainerClient(containerName);
//Console.WriteLine("Enter the file path of the image to upload:");
//var imagePath = Console.ReadLine();
//using var fileStream = File.OpenRead(imagePath);
//var blobName = Path.GetFileName(imagePath);
//var blobClient = containerClient.GetBlobClient(blobName);
//await blobClient.UploadAsync(fileStream, true);

//Console.WriteLine($"Image '{imagePath}' uploaded successfully to Blob storage.");

//downloading
var connectionString = "DefaultEndpointsProtocol=https;AccountName=volleyballsa;AccountKey=BtD9aTXIs21vo+uIUdZwNB7BddWBCwSjhsucb6DaxfkWFZ7QT1SLweM+4GfYO52c01ckfw+RX4hS+AStclaibg==;EndpointSuffix=core.windows.net";
var containerName = "volleyballpictures";
var blobServiceClient = new BlobServiceClient(connectionString);
var containerClient = blobServiceClient.GetBlobContainerClient(containerName);

//Console.WriteLine("Enter the name of the image to download from Blob storage: ");
//var imageNameToDownload = Console.ReadLine();
//var downloadBlobClient = containerClient.GetBlobClient(imageNameToDownload);
//Console.WriteLine("Enter the destination file path to save the downloaded image: ");
//var destinationPath = Console.ReadLine();
//BlobDownloadInfo download = await downloadBlobClient.DownloadAsync();
//using var downloadFileStream = File.OpenWrite(destinationPath);
//await download.Content.CopyToAsync(downloadFileStream);
//downloadFileStream.Close();
//Console.WriteLine($"Image '{imageNameToDownload}' downloaded successfully from Blob storage and saved to '{destinationPath}'.");


