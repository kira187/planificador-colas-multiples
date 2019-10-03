using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;	
using System.Diagnostics;


namespace SimuladorProcesos
{
    public partial class MainForm : Form
    {
        private Process[] process;
        private LinkedList<Proceso> procesos;
        private Queue<Proceso> Qprocess;
        private Random random;
        private RoundRobin roundRobin;
        int quantum = 0;

        public MainForm()
        {
            InitializeComponent();
            procesos = new LinkedList<Proceso>();
            random = new Random();
            process = Process.GetProcesses();
            cargarProcesos();
        }

        private void cargarProcesos()
        {
            int tiempo;
            int prioridad;

            for (int i = 0; i < 9; i++)
            {
                tiempo = random.Next(1, 15);
                
                if(tiempo > 10)
                {
                    prioridad = 1;
                }else if (tiempo > 5)
                {
                    prioridad = 2;
                }
                else
                {
                    prioridad = 3;
                }
                Proceso proceso = new Proceso(process[i].Id, process[i].ProcessName, tiempo, prioridad);
                procesos.AddLast(proceso);
                agregarProceso(proceso);
            }
        }

        private void agregarProceso(Proceso proceso)
        {
            string id = proceso.Id.ToString();
            string nombre = proceso.Nombre;
            string estado = proceso.Estado;
            string tiempo = proceso.Tiempo.ToString();
            
            string priority;
            if (proceso.Prioridad == 4)
            {
                priority = "HIGH PRIORITY";
            }
            else if (proceso.Prioridad == 3)
            {
                priority = "HIGH PRIORITY";
            }
            else if (proceso.Prioridad == 2)
            {
                priority = "MEDIUM PRIORITY";
            }
            else
            {
                priority = "LOW PRIORITY";
            }
            string[] row = {id, nombre, estado, tiempo,priority};
            dataGridViewProcesos.Rows.Add(row);
        }
       

        private void IniciarRR()
        {
            Proceso[] arrProcesos = procesos.ToArray();
            roundRobin = new RoundRobin(ref dataGridViewProcesos);
            roundRobin.runRoundRobin(ref arrProcesos, quantum);
        }
        private void buttonCorrer_Click(object sender, EventArgs e)
        {
            IniciarRR();
        }

        private void materiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
            "Seminario de Solución de Problemas de Sistemas Operativos\n" +
            "Alumno: Misael Aguas Jimenez", "Materia:");
        }

        private void refernciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Stallings Williams (Pagina: 433)", "Sistemas Operativos");
        }

        private void reseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
            "A cada proceso se le asigna un intervalo de tiempo, llamadado quantum, durante el cual se le permite ejecutarse." +
            " Si el proceso todavia se esta ejecutando al expirar su queantum, el sistema operativo se apropia del la CPU y asigna el uso a un nuevo proceso " +
            "pasando el proceso de ejecucion a espera. /n" +
            "La asignacion de prioridad es para los trabajos por lotes que sean cortos y los trabajos interactivos donde reciben frecuentemente" +
            "una prioridad más alta que trabajos mayores que realizan largas operaciones. ", "Algoritmo RR con prioridad");
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            lblValueQuantum.Text = trackBar1.Value.ToString();
            quantum = trackBar1.Value;
        }
    }
}
