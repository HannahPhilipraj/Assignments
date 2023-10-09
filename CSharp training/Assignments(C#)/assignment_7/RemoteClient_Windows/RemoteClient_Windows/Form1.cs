using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RemotingServer;


namespace RemoteClient_Windows
{
    
    public partial class Form1 : Form
    {
        Service service = new Service();
        public Form1()
        {
            InitializeComponent();
            
            service =(Service)Activator.GetObject(typeof(Service),
               "tcp://localhost:8089/FirstRemoteService");
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            textresult1.Text=service.Enter_name(str).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n1 = Int32.Parse(textBox2.Text);
            textresult2.Text=service.Sqrtof_Number(n1).ToString();
                
        }
        public void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
