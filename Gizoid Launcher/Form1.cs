using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace Gizoid_Launcher
{
    public partial class Gizoid_Launcher : Form
    {
        public Gizoid_Launcher()
        {
            InitializeComponent();
        }

        private void Gizoid_Launcher_Load(object sender, EventArgs e)
        {
            String dir = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, @"LauncherVersion.txt");
            Console.WriteLine(dir);
            if (File.Exists(dir))
            {
                StreamReader sr = new StreamReader(dir);
                Console.WriteLine("File Exists");
                String version = sr.ReadLine();
                Text = "Gizoid Launcher " + version;
            }
            else 
            {
                Console.WriteLine("File Does not Exist");
            }
            
        }
    }
}
