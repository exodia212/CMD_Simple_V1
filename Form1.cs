
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace CMD_Simple

{
    public partial class Form1 : Form
    {
        program cmd = new program();
        

        public bool verb;
        public bool choice1, choice2, choice3, choice4, choice5 = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void loopBack_Click(object sender, EventArgs e)
        {
            cmd.TCPtest();

            choice1 = true;
            if (verb == false)
            {
                search();
            }
        }

        public void textBox1_TextChanged(object sender, EventArgs e){}
        private void pingGoogle_Click(object sender, EventArgs e)
        {
            cmd.pingGoogle();
            choice2 = true;
            if (verb == false)
            {
                search();
            }
        }

        private void ipConfig_Click(object sender, EventArgs e)
        {
            cmd.IPconfig();
            choice3 = true;
            if (verb == false)
            {
                search();
            }
        }

        private void netStat_Click(object sender, EventArgs e)
        {
            cmd.netStat();
            choice4 = true;
            if (verb == false)
            {
                search();
            }
        }

        private void resetTCP_Click(object sender, EventArgs e)
        {
        
            cmd.ResetTCP();
            choice5 = true;
            if (verb == false)
            {
                search();
            }
        }
        public async Task search()
        {

            if (choice1 == true)
            {
                await cmd.TCPtest();
                if (cmd.output1.Contains("TTL=128")) { textBox1.Text = "PASS"; }
                else {textBox1.Text = "FAIL";}
                choice1 = false;
            }
            else if (choice2 == true)
            {
                await cmd.pingGoogle();
                if (cmd.output1.Contains("bytes=32")) { textBox1.Text = "PASS"; }
                else { textBox1.Text = "FAIL"; }
                choice2 = false;
            }
            else if (choice3 == true)
            {
                await cmd.IPconfig();
                if (cmd.output1.Contains("Host Name")) { textBox1.Text = "PASS"; }
                else { textBox1.Text = "FAIL"; }
                choice3 = false;
            }
            else if (choice4 == true)
            {
                await cmd.netStat();
                if (cmd.output1.Contains("ESTABLISHED")) { textBox1.Text = "PASS"; }
                else { textBox1.Text = "FAIL"; }
                choice4 = false;
            }
            else if (choice5 == true) 
            {
                await cmd.ResetTCP();
                if (cmd.output1.Contains("Sucessfully reset the Winsock Catalog.")) { textBox1.Text = "Please restart the computer"; }
                else { textBox1.Text = "TCP/IP Stack Reset Failed. Please try again"; }
                choice5 = false;
            }
            
        }
    }
    class program : Form
    {
        public string output1;
        



        public async Task TCPtest()
        {
            var processorInfo = new ProcessStartInfo("cmd.exe", "/c ping 127.0.0.1");
            processorInfo.RedirectStandardOutput = true;
            var processor = Process.Start(processorInfo);
            output1 = await processor.StandardOutput.ReadToEndAsync();
            return;
        }
        public async Task pingGoogle()
        {
            var processorInfo = new ProcessStartInfo("cmd.exe", "/c ping 8.8.8.8");
            processorInfo.RedirectStandardOutput = true;
            var processor = Process.Start(processorInfo);
            output1 = await processor.StandardOutput.ReadToEndAsync();
            return;
        }
        public async Task IPconfig()
        {
            var processorInfo = new ProcessStartInfo("cmd.exe", "/c ipconfig /all");
            processorInfo.RedirectStandardOutput = true;
            var processor = Process.Start(processorInfo);
            output1 = await processor.StandardOutput.ReadToEndAsync();
            return;
        }
        public async Task netStat()
        {
            var processorInfo = new ProcessStartInfo("cmd.exe", "/c netstat -a");
            processorInfo.RedirectStandardOutput = true;
            var processor = Process.Start(processorInfo);
            output1 = await processor.StandardOutput.ReadToEndAsync();
            return;
        }
        public async Task ResetTCP()
        {
            var processorInfo = new ProcessStartInfo("cmd.exe", "/c netsh winsock reset");
            processorInfo.RedirectStandardOutput = true;
            var processor = Process.Start(processorInfo);
            output1 = await processor.StandardOutput.ReadToEndAsync();
            return;
        }


    }
}

