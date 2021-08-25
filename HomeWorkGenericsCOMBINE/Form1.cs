using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWorkGenericsCOMBINE
{
    public partial class Form1 : Form
    {
        COMBINE<int> AllCombine = new COMBINE<int>();
        ReadOnly<string> AddedNames = new ReadOnly<string>();
        Valuebles<char> letters = new Valuebles<char>();
        AllGeneral<student> AllStudent = new AllGeneral<student>();
        AllGeneral<Course> Courses = new AllGeneral<Course>();
        ClassesName ClassName = new ClassesName();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
           textBox7.Text = AllCombine.Combine(new int[int.Parse(textBox5.Text)], new int[int.Parse(textBox6.Text)]);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddedNames.Add(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddedNames.ReadOnlyBool();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            letters.Additem(char.Parse(textBox3.Text));
        }

        private void button4_Click(object sender, EventArgs e)
        {
           textBox2.Text = AllStudent.Everything();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox2.Text = Courses.Everything();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
          textBox4.Text =  ClassName.printname();
          textBox8.Text = ClassName.ToString();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
