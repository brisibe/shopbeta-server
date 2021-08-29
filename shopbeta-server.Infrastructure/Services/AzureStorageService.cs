
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using Microsoft.AspNetCore.Http;
using shopbeta.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace shopbeta_server.Infrastructure.Services
{
    public class AzureStorageService : IStorageService
    {

        private readonly BlobServiceClient _blobServiceClient;
       

        public AzureStorageService(BlobServiceClient blobServiceClient)
        {
            _blobServiceClient = blobServiceClient;
        }

        public async Task<string> Upload(IFormFile file)
        {

            var fileName = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds() + file.FileName;
            
            var blobContainer = _blobServiceClient.GetBlobContainerClient("product");
            
            var blobClient = blobContainer.GetBlobClient(fileName);

            var blobHeader = new BlobHttpHeaders();
            blobHeader.ContentType = "image/png";
            

            await blobClient.UploadAsync(file.OpenReadStream(), blobHeader);

            return blobClient.Uri.AbsoluteUri;
            

        }

       
    }
}
