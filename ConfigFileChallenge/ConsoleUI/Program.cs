using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // Basic Challenge
            string serverIP = ConfigurationManager.AppSettings["ServerIPAddress"];
            string defaultConnection = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;

            Console.WriteLine(serverIP);
            Console.WriteLine(defaultConnection);
            Console.WriteLine();

            // Advanced Challenge
            // Load all of the app settings
            var appSettings = ConfigurationManager.AppSettings;

            foreach (var key in appSettings.AllKeys)
            {
                Console.WriteLine($"Key: { key } Value: { appSettings[key] }");
            }
            Console.WriteLine();

            // Load all of the connection strings
            var connectionStrings = ConfigurationManager.ConnectionStrings;

            foreach (ConnectionStringSettings cnn in connectionStrings)
            {
                Console.WriteLine($"Name: { cnn.Name } Value: { cnn.ConnectionString }");
            }
            Console.WriteLine();

            // Write to the app settings a new key (if it doesn't already exist)
            var appConfig = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var appSettingsSection = appConfig.AppSettings.Settings;

            string newKey = "Professor";
            string newValue = "Ben Thornhill";

            if (appSettingsSection[newKey] == null)
            {
                appSettingsSection.Add(newKey, newValue);
            }
            else
            {
                appSettingsSection[newKey].Value = newValue;
            }

            // Save the modified settings
            appConfig.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection(appConfig.AppSettings.SectionInformation.Name);

            // Read over the values to make sure they got updated
            appSettings = ConfigurationManager.AppSettings;

            foreach (var key in appSettings.AllKeys)
            {
                Console.WriteLine($"Key: { key } Value: { appSettings[key] }");
            }
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
