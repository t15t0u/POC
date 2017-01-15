using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure; // Namespace for CloudConfigurationManager
using Microsoft.WindowsAzure.Storage; // Namespace for CloudStorageAccount
using Microsoft.WindowsAzure.Storage.Queue; // Namespace for Queue storage types
using System.Configuration;

namespace POCQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            var storageConnectionString = ConfigurationManager.AppSettings["StorageConnectionString"];
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(storageConnectionString);
            CloudQueueClient queueClient = storageAccount.CreateCloudQueueClient();
            CloudQueue queue = queueClient.GetQueueReference("redxqueue");
            queue.CreateIfNotExists();
            Console.WriteLine("Reading message...");
            CloudQueueMessage RetrievedMessage = queue.GetMessage();
            Console.WriteLine("Message is : {0}", RetrievedMessage.AsString);
            queue.DeleteMessage(RetrievedMessage);
            Console.ReadLine();

        }
    }
}
