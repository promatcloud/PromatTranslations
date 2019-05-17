using System.IO;
using Microsoft.Extensions.Configuration;
using NUnit.Framework;

namespace PromatTranslations.Tests.Integration {
    public abstract class BaseIntegrationTest
    {
        protected IConfiguration Configuration { get; set; }

        [SetUp]
        public void Setup()
        {
            Configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("config.json", optional: true, reloadOnChange: true)
                    .AddUserSecrets<BaseIntegrationTest>()
                    .AddEnvironmentVariables()
                    .Build();

            PromatTranslator.Configure(Configuration);
        }
    }
}