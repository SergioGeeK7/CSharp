using System;
using System.IO;

using System.Windows.Forms;

namespace EscribirEnArchivo_Append
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtappend_Click(object sender, EventArgs e)
        {
            //using (StreamWriter w = File.AppendText("log.txt"))
            StreamWriter w = File.AppendText("log.txt");

             // w.Dispose(); elimina el objeto por garbage


            {
                //Log(textBox1.Text, w);
                w.Write(textBox1.Text);
            }

            using (StreamReader r = File.OpenText("log.txt"))
            {
                DumpLog(r);
            }
        }

        public static void Log(string logMessage, TextWriter w)
        {
            w.Write(logMessage);
        }

        public static void DumpLog(StreamReader r)
        {
            string line;
            while ((line = r.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }


    }
}
