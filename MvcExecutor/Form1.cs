using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Windows.Forms;

namespace MvcExecutor
{
	public partial class Form1 : Form
	{
		ServiceHost _host;

		public Form1()
		{
			InitializeComponent();
			var baseAddress = new Uri("http://127.0.0.1:8195/");
			_host = new ServiceHost(typeof(RegistryService),new[]{baseAddress});
		//	_host.AddDefaultEndpoints();
			
			_host.Open();
		}

		private void Form1Load(object sender, EventArgs e)
		{

			label1.Text = _host.BaseAddresses.Select(u => u.ToString()).Aggregate((u1, u2) => u1 + "," + u2);
			using (Process.Start("http://localhost:8194/registry"))
			{
				
			}
			using (Process.Start("http://localhost:8195/"))
			{
				
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Console.WriteLine("wee?");
		}
	}
}
