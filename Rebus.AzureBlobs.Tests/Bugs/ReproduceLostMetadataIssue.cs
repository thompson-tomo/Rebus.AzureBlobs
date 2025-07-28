using System.Threading.Tasks;
using Azure.Storage.Blobs;
using NUnit.Framework;
using Rebus.AzureBlobs.DataBus;
using Rebus.AzureBlobs.Tests.DataBus;
using Rebus.Config;
using Rebus.Logging;
using Rebus.Tests.Contracts;

namespace Rebus.AzureBlobs.Tests.Bugs;

[TestFixture]
public class ReproduceLostMetadataIssue : FixtureBase
{
    [Test]
    public async Task CustomMetadataLost()
    {
        var loggerFactory = new ConsoleLoggerFactory(colored: false);
        var fakeRebusTime = new FakeRebusTime();
        var options = new AzureBlobsDataBusStorageOptions();
        var client = new BlobContainerClient(AzureConfig.ConnectionString, "test");

        var storage = new AzureBlobsDataBusStorage(loggerFactory, fakeRebusTime, options, client);


    }
}