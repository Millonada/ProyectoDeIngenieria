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
            textTime.Text = cadena.ToString();
            textRes2.Text = contarPalabras();
            textTotalTiempo.Text = totalTiempo.ToString();
            textTotalFiles.Text = totalFiles.ToString();


            // parte para insertar datos de las palabras



            palabrasText.Text = contarPalabrasByFile();
            

        }

        private string connection() {
            var builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.Database = "proyectosJava";
            builder.UserID = "root";
            builder.Password= "";
            return builder.ToString();
        }

        private void insert(string palabra,string archivo) {


            var conexion = new MySqlConnection(connection());
            conexion.Open();
            string Query = "INSERT INTO palabras (palabra,archivo) values ('" + palabra + "','" + archivo + "')";
            var comando = new MySqlCommand(Query, conexion);
            comando.ExecuteNonQuery();
          /*  while (datos.Read())
            {

                res += datos.GetString(1);
            }*/


            //return ;

            conexion.Close();
            //MessageBox.Show("Se inserto");

        }
        private void separarPalabras(string texto,string archivo) {
            string[] words = texto.Split(' ');
            //foreach (string word in words) { 
            //insert(word, archivo);
           // }
        }

        private string mostrarPalabras()
        {
            string res = "";
            var conexion = new MySqlConnection(connection());
            conexion.Open();
            string Query = "SELECT * FROM `palabras` ORDER BY palabra ASC;";
            var comando = new MySqlCommand(Query, conexion);
            var datos = comando.ExecuteReader();
            while (datos.Read())
            {

                res += datos.GetString(1)+"\r\n";
            }
            return res;
        }

        private string contarPalabras() {
            string res = "";
            var conexion = new MySqlConnection(connection());
            conexion.Open();
            string Query = "SELECT palabra, COUNT(*) AS repeticiones FROM palabras GROUP BY palabra HAVING COUNT(*) > 1;";
            var comando = new MySqlCommand(Query, conexion);
            var datos = comando.ExecuteReader();
            while (datos.Read())
            {

                res += datos.GetString(0) +" = "+ datos.GetInt16(1)+ "\r\n";
            }
            return res;
        }
        private string contarPalabrasByFile()
        {
            string res = "";
            var conexion = new MySqlConnection(connection());
            conexion.Open();
            string Query = "SELECT archivo, palabra, COUNT(*) AS repeticiones FROM palabras GROUP BY archivo, palabra HAVING COUNT(*) > 1;";
            var comando = new MySqlCommand(Query, conexion);
            var datos = comando.ExecuteReader();
            while (datos.Read())
            {

                res += "c:Files02.html  " + " Palabras = " + datos.GetString(1) + " Conteo = " + datos.GetInt16(2) + "\r\n";
            
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