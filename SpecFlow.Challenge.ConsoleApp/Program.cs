using System;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Xml.Serialization;

namespace SpecFlow.Challenge.ConsoleApp
{
    class Program
    {
        /// <summary>
        /// Enumerator that indicates the Challenge topics
        /// </summary>
        private enum WexChallenges
        {
            [XmlEnum("Cira-Dinha Logic Printer")]
            CiraDinha = 1,
            [XmlEnum("Reverse Tree Designer")]
            ReverseTree
        }

        /// <summary>
        /// The Main method, to starts the program
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            WexChallenges definedChallenge;
            Console.WriteLine("Please, choice the topic as follow the WEX QA Engineer topics:");
            foreach (WexChallenges item in Enum.GetValues(typeof(WexChallenges)))
            {
                Console.WriteLine(" {0} - {1}", (int)item, item.ToString());
                Console.WriteLine("\t {0}", XmlEnumValue(item));
            }

            Enum.TryParse<WexChallenges>(Console.ReadLine(), out definedChallenge);

            switch (definedChallenge)
            {
                case WexChallenges.CiraDinha:
                    CiraDinhaLogicPrinter();
                    break;
                case WexChallenges.ReverseTree:
                    ReverseTreeDesigner();
                    break;
            }
        }

        /// <summary>
        /// This method refers to topic 01 on Session 01
        /// from WEX QA Engeineer Challenge, Cira-Dinha Logic
        /// </summary>
        private static void CiraDinhaLogicPrinter()
        {
            const string CIRA = "Cira",
                         DINHA = "Dinha",
                         PATTERN = "Número: {0} | Resultado: {1}";
            long counter = 0;
            Console.WriteLine("Cira-Dinha logic printer will start; press <Enter> to get out to the program.");
            do
            {
                StringBuilder sb = new StringBuilder();
                Console.WriteLine("");
                string strCounter = counter.ToString();
                if (counter > 0 && counter % 3 == 0)
                {
                    sb.Append(CIRA);
                }
                if (strCounter.Contains("5"))
                {
                    sb.Append(DINHA);
                }
                Console.Write(PATTERN, (counter < 10) ? "0" + counter.ToString() : counter.ToString(), sb.ToString());
                counter++;
                Thread.Sleep(1000);
            }
            while (!Console.KeyAvailable);
        }

        /// <summary>
        /// This method refers to topic 02 on Session 01
        /// from WEX QA Engeineer Challenge, Reverse Tree Designer
        /// </summary>
        private static void ReverseTreeDesigner()
        {
            Console.WriteLine("Please, define de number that limits the basis-top of Reverse Tree:");
            int basisTop = Convert.ToInt32(Console.ReadLine());
            for (int i = basisTop; i > 0; i--)
            {
                StringBuilder sb = new StringBuilder();
                int basis = basisTop - i;
                if(basis > 0)
                {
                    for (int t = 0; t < basis; t++)
                    {
                        sb.Append(" ");
                    }
                }
                for (int j  = 0; j < i; j++)
                {
                    sb.Append("* ");
                }
                Console.WriteLine(sb.ToString());
            }
            Console.WriteLine("Press <Enter> to get out to the program.");
            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
        }


        /// <summary>
        /// Auxiliar method to get XmlEnum description
        /// </summary>
        /// <param name="value">Enumerator</param>
        /// <returns>System.String</returns>
        private static string XmlEnumValue(Enum value)
        {
            Type type = value.GetType();
            FieldInfo fieldInfo = type.GetField(value.ToString());
            XmlEnumAttribute[] attrbs = fieldInfo.GetCustomAttributes(
                typeof(XmlEnumAttribute), false) as XmlEnumAttribute[];
            return attrbs.Length > 0 ? (!string.IsNullOrWhiteSpace(attrbs[0].Name)) ? attrbs[0].Name : value.ToString() : null;
        }
    }
}
