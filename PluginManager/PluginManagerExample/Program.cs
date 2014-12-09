using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PluginManager;

namespace PluginManagerExample
{
    class Program
    {
        static void PluginCollectionDemo<T>(T value)
        {
            var plugin = new PluginsCollection<T>();

            Console.WriteLine("My {0}: {1}", value.GetType().Name, value);
            Console.WriteLine("Result of the plugin: {0}", plugin.Modify(value));
        }

        public static void Main()
        {
            Console.WriteLine("***** Create Int PluginsCollection ****");
            PluginCollectionDemo(-5);
            Console.WriteLine();

            Console.WriteLine("***** Create DateTime PluginsCollection *****");
            PluginCollectionDemo(DateTime.Now);
            Console.WriteLine();

            Console.WriteLine("***** Create simple PluginClient *****");
            Console.WriteLine("***** Additional function: i => i * 2 *****");
            Console.WriteLine("***** Plugin function: i => i^3 *****");
            var myPlugin = new PluginablePlugin<int>(i => i * 2, new PluginIntPow3(), 5);

            Console.WriteLine("Input Data: 5");
            Console.Write("Result: ");
            myPlugin.WriteResult();


            Console.WriteLine("Input Data: -5");
            myPlugin.Data = -5;
            Console.Write("Result: ");
            myPlugin.WriteResult();

            Console.ReadLine();
        }
    }
}
