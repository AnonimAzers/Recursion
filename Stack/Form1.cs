using System.Xml.Linq;

namespace Stack
{
    public partial class Form1 : Form
    {
        MyStack<int> IntStack;
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int Size;
            bool result = int.TryParse(textBox2.Text, out Size);
            if (result && Size > 0)
            {
                IntStack = new MyStack<int>(Size);
                label5.Text = Size.ToString();
                label6.Text = "True";
            }
            else
            {
                MessageBox.Show("Ошибка с созданием стека");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int element;
            bool result = int.TryParse(textBox1.Text, out element);
            if (result)
            {
                label6.Text = IntStack != null && IntStack.Push(element) ? "True" : "False";
            }
            else
            {
                MessageBox.Show("Ошибка. Ввели элемент с неверным типом данных");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label6.Text = IntStack != null && IntStack.isEmpty() ? "True" : "False";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int result;
            if (IntStack != null && IntStack.Pop(out result))
            {
                label6.Text = result.ToString();
            } else
            {
                MessageBox.Show("Проблема с выводом элемента");
            }
        }
    }
}