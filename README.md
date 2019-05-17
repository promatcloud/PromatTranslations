# PromatTranslations
Simple library in .net standard 2.0 to translate text using the Azure cognitive services translator (free up to 2M characters per month)

# QuickStart

## Step 1: Configuration

 ```csharp
    // Initialize the PromatTranslator with your Azure API Key
    PromatTranslator.ConfigureKey("YOUR_AZURE_TRANSLATOR_API_KEY"); 
 ```
OR
 ```csharp
    // Initialize with an IConfiguration (The configuration must define a key "AzureApiKey")
    var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("config.json")
            .Build();
    PromatTranslator.Configure(configuration);
 ```
 
 ## Step 2: Set "language from"
 
 ```csharp
    // Choose the original language (Spanish by default)
    PromatTranslator.ConfigureLanguageFrom(Languages.Español);
 ```
 
 ## Step 3: Translate!!!
 
 ```csharp
    // Get the translated text
    var translated = await PromatTranslator.TranslateAsync("Hola Mundo", Languages.Ingles);
 ```
 
 ## .NET Core console application example:
  
 ```csharpusing System;
using System.Threading.Tasks;
using PromatTranslations;
using PromatTranslations.Constants;

namespace ConsoleApp1
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // Initialize the PromatTranslator with your Azure API Key
            PromatTranslator.ConfigureKey("YOUR_AZURE_TRANSLATOR_API_KEY");

            // Get the translated text
            Console.WriteLine(await PromatTranslator.TranslateAsync("Hola Mundo", Languages.Ingles));
            Console.Read();
        }
    }
}
 ```
 
