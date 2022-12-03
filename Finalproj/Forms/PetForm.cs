using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Finalproj
{
    public partial class PetForm : Form
    {
        Animals animals;

        BindingList<Animals> anmialItemList = new BindingList<Animals>();


        BindingSource bindingSource;



        public PetForm()
        {
            InitializeComponent();
        }
          private void PetForm_Load(object sender, EventArgs e)
           {
               try
               {
                   bindingSource = new BindingSource(anmialItemList, null);

                   dataGridView1.DataSource = bindingSource;


                   IWorkbook workBook;

                   using (FileStream fs = new FileStream("Book.xlsx", FileMode.Open, FileAccess.Read))
                   {
                       workBook = new XSSFWorkbook(fs);

                       ISheet sheet = workBook.GetSheetAt(0);


                       for (int row = 1; row <= sheet.LastRowNum; row++)
                       {
                           IRow curRow = sheet.GetRow(row);

                           if (curRow == null)
                               break;

                           if (sheet.GetRow(row) != null)
                           {
                               ICell column = curRow.GetCell(0);

                            double PetNumber = curRow.GetCell(1).NumericCellValue;
                            double PetPrice = curRow.GetCell(2).NumericCellValue;
                            double PetType = curRow.GetCell(2).NumericCellValue;
                            double PetBreed = curRow.GetCell(2).NumericCellValue;

                               animals = new Animals(PetType, PetNumber, PetPrice, PetBreed);
                               anmialItemList.Add(animals);


                           }

                       }

                   }
               }
               catch (Exception ex)
               {
                   MessageBox.Show(ex.Message, "Excel read Error");
               }

           }
        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell.RowIndex >= 0 && dataGridView1.CurrentCell.RowIndex < anmialItemList.Count)
            {
                Animals animals = anmialItemList[dataGridView1.CurrentCell.RowIndex];

                MessageBox.Show(animals.ToString());

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dialogResult == DialogResult.Yes)
            {
                if (dataGridView1.CurrentCell.RowIndex >= 0 && dataGridView1.CurrentCell.RowIndex < anmialItemList.Count)
                {
                    anmialItemList.RemoveAt(dataGridView1.CurrentCell.RowIndex);
                }
            }
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Excel Files|*.xlsx";
            saveFileDialog1.Title = "Save an Excel File";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                IWorkbook workBook = new XSSFWorkbook();

                ISheet sheet = workBook.CreateSheet("Sheet1");

                int rowNum = 0, colNum = 0;


                IRow row = sheet.CreateRow(rowNum++);

                foreach (DataGridViewColumn dataGridViewColumn in dataGridView1.Columns)
                {
                    ICell cell = row.CreateCell(colNum++);
                    cell.SetCellValue(dataGridViewColumn.HeaderText);
                }
                foreach (Animals animals in anmialItemList)
                {
                    row = sheet.CreateRow(rowNum++);

                    colNum = 0;

                    row.CreateCell(colNum++).SetCellValue(animals.PetNumber);
                    row.CreateCell(colNum++).SetCellValue(animals.PetType);
                    row.CreateCell(colNum++).SetCellValue(animals.PetBreed);
                    row.CreateCell(colNum++).SetCellValue(animals.PetPrice);
                }
                using (FileStream sw = File.Create(saveFileDialog1.FileName))
                {
                    workBook.Write(sw);
                    MessageBox.Show($"File, {saveFileDialog1.FileName}, was succesfully saved.");
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PetForm_Load_1(object sender, EventArgs e)
        {
            try
            {
                bindingSource = new BindingSource(anmialItemList, null);

                dataGridView1.DataSource = bindingSource;


                IWorkbook workBook;

                using (FileStream fs = new FileStream("Book.xlsx", FileMode.Open, FileAccess.Read))
                {
                    workBook = new XSSFWorkbook(fs);

                    ISheet sheet = workBook.GetSheetAt(0);


                    for (int row = 1; row <= sheet.LastRowNum; row++)
                    {
                        IRow curRow = sheet.GetRow(row);

                        if (curRow == null)
                            break;

                        if (sheet.GetRow(row) != null)
                        {
                            ICell column = curRow.GetCell(0);

                            double PetNumber = curRow.GetCell(1).NumericCellValue;
                            double PetPrice = curRow.GetCell(2).NumericCellValue;
                            double PetType = curRow.GetCell(2).NumericCellValue;
                            double PetBreed = curRow.GetCell(2).NumericCellValue;

                            animals = new Animals(PetType, PetNumber, PetPrice, PetBreed);
                            anmialItemList.Add(animals);


                        }

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Excel read Error");
            }
        }
    }
}
