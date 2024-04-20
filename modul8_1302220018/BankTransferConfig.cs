using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace modul8_1302220018
{
    internal class BankTransferConfig
    {

        public BankTransferConfig readData()
        {
            string data = File.ReadAllText("D:\\Tugas\\Tugas Kuliah\\Semester 4\\KPL\\modul8_1302220018\\modul8_1302220018\\bank_transfer_config.json");
            BankTransferConfig json = JsonConvert.DeserializeObject<BankTransferConfig>(data);
            return json;
        }

        public string lang { get; set; }
        public class Transfer
        {
            public int threshold { get; set; }
            public int low_fee { get; set; }

            public int high_fee { get; set;}



        }
        
        public Transfer transfer { get; set; }

        public string[] methods { get; set; }

        public class Confirmation
        {
            public string en { get; set; }
            public string id { get; set; }

        }

        public Confirmation confirmation { get; set; }
    }
}
