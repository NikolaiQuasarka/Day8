using System.Runtime.CompilerServices;

namespace Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            list = new List<Tanker>();
            bindingSource1.DataSource = list;
            dataGridView1.DataSource = bindingSource1;
        }
        List<Tanker> list;
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBox_model.Text != "" & DateTime.TryParse(textBox_date.Text, out DateTime date) & double.TryParse(textBox_density.Text, out double density) &
                uint.TryParse(textBox_max.Text, out uint max) & textBox_type.Text != "")
            {
                bindingSource1.Add(new Tanker(max)
                {
                    Date_of_issue = date,
                    Density = density,
                    Liquid_type = textBox_type.Text,
                    Model = textBox_model.Text,
                });
            }
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            if (uint.TryParse(textBox_load.Text, out uint mas) & dataGridView1.CurrentRow != null)
            {
                list[dataGridView1.CurrentRow.Index].Load(mas); 
            }
        }

        private void buttonUnload_Click(object sender, EventArgs e)
        {
            if (uint.TryParse(textBox_load.Text, out uint mas) & dataGridView1.CurrentRow != null)
            {
                list[dataGridView1.CurrentRow.Index].Unload(mas);
            }
        }
    }
}
