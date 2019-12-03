using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void 打开子窗体ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.CloseFrom();
			Form2 form2 = new Form2();
			this.OpenFrom(form2);
		}

		private void OpenFrom(Form objFrm)
		{
			//将当前子窗体设置成非顶级控件
			objFrm.TopLevel = false;
			//指定当前子窗体显示的容器
			objFrm.Parent = this.panel1;
			//显示窗体
			objFrm.Show();

		}

		//关闭已经打开的窗体方法
		private void CloseFrom()
		{
			foreach (Control item in this.panel1.Controls)
			{
				if (item is Form objControl)
				{
					objControl.Close();
					this.panel1.Controls.Remove(item);
				}

			}
		}

		private void 打开子窗体2ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.CloseFrom();

			Form2 form3 = new Form2();
			Label label = new Label();
			label.Text = "wawawa";
			form3.Controls.Add(label);
			this.OpenFrom(form3);
		}
	}
}
