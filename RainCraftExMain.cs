using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BepInEx;

namespace RainCraftEx
{
    [BepInPlugin(PLUGIN_GUID, PLUGIN_NAME, PLUGIN_VERSION)]
    public class RainCraftExMain : BaseUnityPlugin
    {
        public const string PLUGIN_GUID = "winston_kirk.raincraftex";
        public const string PLUGIN_NAME = "RainCraftEx - Crafting System";
        public const string PLUGIN_VERSION = "0.0.1";

        private void OnEnable()
        {
            Console.WriteLine("RainCraftEx - Hello? RainInventoryEx are you there?");
        }
    }
}
