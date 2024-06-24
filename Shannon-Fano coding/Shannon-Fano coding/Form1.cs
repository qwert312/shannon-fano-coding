using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace ShannonFanoProgram
{
    partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MouseClickCurrentActivityOnNull(object sender, MouseEventArgs e)
        { 
            this.ActiveControl = null;
        }

        private void buttonEncode_Click(object sender, EventArgs e)
        {
            if (textBoxFromFile.Text == "")
            {
                MessageBox.Show("Сначала выберите текстовый файл для кодирования", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                List<ShannonFanoNode> nodes = ShannonFano.Encode(textBoxFromFile.Text);
                string codes = Newtonsoft.Json.JsonConvert.SerializeObject(nodes);

                textBoxResult.Text = ShannonFano.FullyEncodeText(textBoxFromFile.Text, nodes);


                using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog()) 
                {
                    folderBrowserDialog.Description = "Выберите директорию для закодированного файла и его кодов";

                    if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                    {
                        string encodedFilePath = Path.Combine(folderBrowserDialog.SelectedPath, "EncodedFile.txt");
                        string codesFilePath = Path.Combine(folderBrowserDialog.SelectedPath, "Codes.json");

                        File.WriteAllText(encodedFilePath, textBoxResult.Text);
                        File.WriteAllText(codesFilePath, codes);

                        MessageBox.Show("Закодированный файл и его ключи сохранены", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"Ошибка при кодировании: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void buttonDecode_Click(object sender, EventArgs e)
        {
            if (textBoxFromFile.Text == "")
            {
                MessageBox.Show("Сначала выберите текстовый файл для декодирования", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Title = "Выберите файл с кодами для декодирования";

                    openFileDialog.Filter = "JSON files (*.json)|*.json";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                        {
                            List<ShannonFanoNode> codes = Newtonsoft.Json.JsonConvert.DeserializeObject<List<ShannonFanoNode>>(File.ReadAllText(openFileDialog.FileName));
                            textBoxResult.Text = ShannonFano.Decode(textBoxFromFile.Text, codes);

                            saveFileDialog.Filter = "Text files (*.txt)|*.txt";
                            saveFileDialog.Title = "Выберите, куда будем сохранять декодированный текстовый файл";

                            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                            {
                                string decodedFilePath = saveFileDialog.FileName;
                                    File.WriteAllText(decodedFilePath, textBoxResult.Text);

                                MessageBox.Show("Раскодированный файл сохранён", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при кодировании: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text files (*.txt)|*.txt";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    textBoxBrowse.Text = filePath;

                    textBoxFromFile.Text = File.ReadAllText(filePath);

                    textBoxResult.Text = null;
                }
            }
        }
    }
}
