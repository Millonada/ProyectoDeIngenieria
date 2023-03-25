using System.Data;
using System.Diagnostics;
using System.Windows.Forms.VisualStyles;
using System.Xml;
using HtmlAgilityPack;
using MySqlConnector;


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
                 resultado += dom.DocumentNode.InnerText; // en la variable resultado se guardan 
                Console.WriteLine("Hola mundo");
                watch.Stop();
                totalTiempo += watch.ElapsedMilliseconds; // se va guardando cuanto tiempo tarda cada archivo
                cadena += file +"              Tiempo          :"+ watch.ElapsedMilliseconds + "\r\n"; // se concatena el nombre del archivo con el tiempo

                //separarPalabras(dom.DocumentNode.InnerText, file);

            }
            tiempoText.Text = cadena.ToString();
         
            textTotalTiempo.Text = totalTiempo.ToString();
            textTotalFiles.Text = totalFiles.ToString();

            textRes2.Text = DiccionarioGet().ToString();
            posting.Text = PostinGet().ToString();


            
            

        }

        private string connection() {
            var builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.Database = "proyectosJava";
            builder.UserID = "root";
            builder.Password= "";
            return builder.ToString();
        }


        private string DiccionarioGet() {
            string res = "";
            var conexion = new MySqlConnection(connection());
            conexion.Open();
            string Query = "SELECT palabra, COUNT(DISTINCT archivo) AS num_archivos_repetidos FROM palabras GROUP BY palabra HAVING COUNT(*) > 1;";
            var comando = new MySqlCommand(Query, conexion);
            var datos = comando.ExecuteReader();
            while (datos.Read())
            {

                res += datos.GetString(0) + " = " + datos.GetInt16(1) +","+ datos.GetInt16(1)+1+ "\r\n";
            }
            return res;
        }

        private string PostinGet()
        {
            var dictionary = new Dictionary<string, Dictionary<string, int>>();
            string res = "";
            var conexion = new MySqlConnection(connection());
            conexion.Open();
            string Query = "SELECT archivo, palabra, COUNT(*) AS num_repeticiones FROM palabras GROUP BY archivo, palabra ORDER BY archivo, palabra;";
            var comando = new MySqlCommand(Query, conexion);
            var reader = comando.ExecuteReader();

            while (reader.Read())
            {
                string archivo = reader.GetString("archivo");
                string palabra = reader.GetString("palabra");
                int num_repeticiones = reader.GetInt32("num_repeticiones");

                // Si la palabra no existe en el diccionario, se crea una entrada vacía
                if (!dictionary.ContainsKey(palabra))
                {
                    dictionary.Add(palabra, new Dictionary<string, int>());
                }

                // Agregar la entrada del archivo y el número de repeticiones
                dictionary[palabra][palabra] = num_repeticiones;
            }

            // Imprimir la hash table
            foreach (var kvp in dictionary)
            {
                
                foreach (var innerKvp in kvp.Value)
                {
                    res += innerKvp.Key +" , "+ innerKvp.Value +"\n";
                    
                }
            }

        
            return res;
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

        private void textTime_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}