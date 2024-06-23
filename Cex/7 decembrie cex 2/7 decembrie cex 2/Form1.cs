namespace _7_decembrie_cex_2

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked && checkBox2.Checked && checkedListBox1.SelectedItem != null)
            {
                StreamWriter s = new StreamWriter("Date.txt", true);
                // Valoare booleana true permite scrierea pe urmatoarea linie din fisierul text, iar  daca aceasta este false se va suprascrie linia/ liniile din fișierul text.
                s.WriteLine(" ");
                //vom adauga un rand gol pentru a vizualiza mai bine inregistrarile in fisier
                s.WriteLine("Nume: ");
                s.WriteLine(textBox1.Text);
                //prin intermediul ob s apelam metoda WriteLine care va scrie in fisier
                s.WriteLine("Prenume: ");
                s.WriteLine(textBox2.Text);
                //avem conditia ca un singur radioButon sa fie marcat, iar acesta sa indice genul
                if (radioButton1.Checked)
                    s.WriteLine("Genul: Femeie ");
                else if (radioButton2.Checked)
                    s.WriteLine("Genul: Femeie ");
                s.WriteLine("Data nasterii: ");
                s.WriteLine(dateTimePicker1.Value.ToString());
                //obiectul dateTimePicker. Apeleaza proprietatea value care are get si set, si facem  cenversia explicita in Strings.WriteLine("Adresa: ");
                s.WriteLine(textBox3.Text);

                foreach (string item in checkedListBox1.CheckedItems)//returneaza lista de elemente selectate
                                                                     //in variabila item salvam fiecare element din lista
                    s.WriteLine(item);//afisam primul element...etc
                s.Close();//opreste scrierea in fisier//daca nu scriem in fisier , nu citeste caci asteapta scrierea in fisier
                string m = "Inregistrare cu succes! ";
                MessageBox.Show(m);//afisam mesajul
                // Application.Exit();

            }
            else
            {
                string message = "Nu sunteti de acord cu procesarea datelor sau nu ati completat toate campurile ";
                MessageBox.Show(message);

            }

        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }
    }
}