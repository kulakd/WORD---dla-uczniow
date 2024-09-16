namespace WORD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            //Klikniêcie guzika Nowy czyœci nam g³ówny ekran
            RTB.Clear();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            // okno otwierania plików
            OpenFileDialog ofd = new OpenFileDialog();

            // filtrujemy, aby program móg³ otwieraæ tylko pliki Richtextfile lub txt
            ofd.Filter = "Rich Text File (.rtf)|*.rtf|Text Files (.txt)|*.txt";
            ofd.Multiselect = false;
            ofd.Title = "Otwórz plik tekstowy";

            // tryb wczytania pliku tekstowego
            RichTextBoxStreamType streamType = RichTextBoxStreamType.RichText;

            // sprawdzenie rezultatu
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (ofd.FilterIndex == 2) streamType = RichTextBoxStreamType.PlainText;

                // wype³nienie pola tekstowego zawartoœci¹ otwieranego pliku
                RTB.LoadFile(ofd.FileName, streamType);
            }
        }

        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            // okno zapisu do pliku
            SaveFileDialog sfd = new SaveFileDialog();

            // filtr plików mo¿liwych do zapisu
            sfd.Filter = "Rich Text File (.rtf) | *.rtf | Text Files (.txt) | *.txt";

            // tytu³ okna dialogowego
            sfd.Title = "Zapisz plik";

            // tryb wczytania pliku tekstowego
            RichTextBoxStreamType streamType = RichTextBoxStreamType.RichText;

            // sprawdzenie rezultatu
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if (sfd.FilterIndex == 2) streamType = RichTextBoxStreamType.PlainText;

                RTB.SaveFile(sfd.FileName, streamType);
            }
        }

        // wybranie pogrubienia tekstu
        private void btnBold_Click(object sender, EventArgs e)
        {
            // zmienna odpowiadajaca za pogrubiony font
            Font selectedTextFont = RTB.SelectionFont;
            if (selectedTextFont != null)
            {
                if (!selectedTextFont.Bold) RTB.SelectionFont = new Font(selectedTextFont, FontStyle.Bold);
                else RTB.SelectionFont = new Font(selectedTextFont, FontStyle.Regular);

            }
        }

        // wybranie kursywy
        private void btnItalic_Click(object sender, EventArgs e)
        {
            // zmienna odpowiadajaca za kursywe
            Font selectedTextFont = RTB.SelectionFont;
            if (selectedTextFont != null)
            {
                if (!selectedTextFont.Italic) RTB.SelectionFont = new Font(selectedTextFont, FontStyle.Italic);
                else RTB.SelectionFont = new Font(selectedTextFont, FontStyle.Regular);
            }
        }

        // wybranie podkreslenia
        private void btnUnderline_Click(object sender, EventArgs e)
        {
            // zmienna odpowiadajaca za podkreslenie
            Font selectedTextFont = RTB.SelectionFont;
            if (selectedTextFont != null)
            {
                if (!selectedTextFont.Underline) RTB.SelectionFont = new Font(selectedTextFont, FontStyle.Underline);
                else RTB.SelectionFont = new Font(selectedTextFont, FontStyle.Regular);
            }
        }

        // wczytywanie formy 
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int fontSize = 7; fontSize < 70; fontSize++)
            {
                cmbFontSize.Items.Add(fontSize);
            }
            foreach (FontFamily fontFamily in FontFamily.Families)
            {
                cmbFont.Items.Add(fontFamily.Name);
            }
            // ustawienie indexu w cmbFontSize musi odbyæ siê jako pierwsze
            cmbFontSize.SelectedIndex = 0;
            cmbFont.SelectedIndex = 0;
        }

        // ustawianie nowego fontu
        private void SetNewFont()
        {
            RTB.SelectionFont = new Font(cmbFont.Text, float.Parse(cmbFontSize.Text), RTB.SelectionFont.Style);
        }
        private void cmbFontSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetNewFont();
        }
        private void cmbFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetNewFont();
        }

        // zmiana koloru
        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                RTB.SelectionColor = colorDialog.Color;
                pbColor.BackColor = colorDialog.Color;
            }
        }
    }
}