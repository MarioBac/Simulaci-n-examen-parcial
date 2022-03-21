namespace Simulación_examen_parcial
{
    public partial class Form1 : Form
    {
        List<Departamento> departamentos = new List<Departamento>();
        List <Temperatura> temperaturas = new List<Temperatura>();

        private void CargarTemperaturas (string file)
        {
            FileStream fs = new FileStream (file, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader (fs);
            while (sr.Peek() !=-1)
            {
                Temperatura temperatura = new Temperatura()
                {
                    numDep = Convert.ToInt32(sr.ReadLine()),
                    temperatura = Convert.ToInt32(sr.ReadLine()),
                    fecha = Convert.ToDateTime(sr.ReadLine())
                };
                temperaturas.Add(temperatura);
            }
            sr.Close ();
            fs.Close ();    
        }
        private void CargarDepartamentos (string file)
        {
            FileStream fs = new FileStream(file, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            while (sr.Peek() != -1)
            {
                Departamento departamento = new Departamento()
                {
                    numDep = Convert.ToInt32(sr.ReadLine()),
                    nombre = sr.ReadLine(),
                };
                departamentos.Add(departamento);
            }
            sr.Close();
            fs.Close();
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarDepartamentos("Departamentos.txt");
            CargarDepartamentos("Temperaturas.txt");
            foreach (Departamento departamento in departamentos)
            {
                comboBox1.Items.Add(departamento.nombre);
            }
        }
    }
}