namespace Task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            garden = new GardenTrees[30];
        }
        GardenTrees[] garden;

        private void buttonGardenFullFill_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            for(int i = 0; i < garden.Length; i++)
            {
                int typeId = rnd.Next(0,2);
                switch(typeId)
                {
                    case 0:
                        garden[i] = new AppleTree(new DateTime(rnd.Next(2000,2024),rnd.Next(1,12), rnd.Next(1, 30)),(uint)rnd.Next(15,170));
                        break;
                        case 1:
                        garden[i] = new Pear(new DateTime(rnd.Next(2000, 2024), rnd.Next(1, 12), rnd.Next(1, 30)), (uint)rnd.Next(30, 180));
                        break;
                        case 2:
                        garden[i] = new CherryTree(new DateTime(rnd.Next(2000, 2024), rnd.Next(1, 12), rnd.Next(1, 30)), (uint)rnd.Next(5, 50));
                        break;
                }
            }
            dataGridView1.Rows.Clear();
            foreach (var item in garden)
            {
                dataGridView1.Rows.Add(item.Id, item.GetType().Name, item.PlantingDate.ToString("dd.MM.yyyy"), item.BearingKG, item.Replant());
            }
        }
    }
}
