using System.Diagnostics;
using System.Windows.Forms.VisualStyles;
using System.Xml;
using HtmlAgilityPack;
namespace actividad1._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] files = Directory.GetFiles("C:\\Files");
            float totalTiempo = 0;
            string cadena="";
            int totalFiles = 0;
            string resultado="";
            foreach (string file in files) 
            {
                totalFiles++;
                Stopwatch watch = Stopwatch.StartNew();
                string content = File.ReadAllText(file);
                
                
                HtmlAgilityPack.HtmlDocument dom = new HtmlAgilityPack.HtmlDocument();
                dom.LoadHtml(content);
                 resultado += dom.DocumentNode.InnerText;

                watch.Stop();
                totalTiempo += watch.ElapsedMilliseconds;
                cadena += file +"              Tiempo          :"+ watch.ElapsedMilliseconds + "\r\n";
                
              
            }
            textTime.Text = cadena.ToString();
            textRes2.Text = resultado.ToString();
            textTotalTiempo.Text = totalTiempo.ToString();
            textTotalFiles.Text = totalFiles.ToString();    
           

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textRes2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}