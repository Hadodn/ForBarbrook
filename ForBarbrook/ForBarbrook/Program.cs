using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForBarbrook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a dumby applicationg to show barbrook a code example");
            Console.WriteLine("Making Random Data");

            //List of raw data This is all the data you would have already processed
            List<int> dataX = new List<int>();
            List<int> dataY = new List<int>();
            List<int> dataZ = new List<int>();


            Random rand = new Random();

            //Loop to populate the list with data
            for(int i =0; i < 1000; i++)
            {
                //Put random number in
                dataX.Add(rand.Next(0, 501));
                dataY.Add(rand.Next(0, 501));
                dataZ.Add(rand.Next(0, 501));
            }

            //Write data to Csv file
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"D:\filename.csv", true)) //Change to the location you want your file and the name of your file
            {
                string tempString = "";
                for(int i = 0; i < 1000; i++)
                {
                    tempString = (dataX[i].ToString() + "," + dataY[i].ToString() + "," + dataZ[i].ToString());
                    file.WriteLine(tempString);
                }
            }

            Console.WriteLine("Ended Program");
            Console.ReadLine();
        }
    }
}
