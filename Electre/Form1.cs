using System.Windows.Forms;

namespace Electre
{
    public partial class Form1 : Form
    {
        string whatToolButtonClicked = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            criteriaTitleLB.Enabled = true;
            criteriaTitleTB.Enabled = true;
            criteriaWeightLB.Enabled = true;
            criteriaWeightTB.Enabled = true;
            criteriaLenghtLB.Enabled = true;
            criteriaLenghtTB.Enabled = true;
            applyButton.Enabled = true;
            cancelButton.Enabled = true;
            criteriaTitleTB.Focus();
            whatToolButtonClicked = "add";
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            criteriaTitleLB.Enabled = false;
            criteriaTitleTB.Enabled = false;
            criteriaTitleTB.Clear();
            criteriaWeightLB.Enabled = false;
            criteriaWeightTB.Enabled = false;
            criteriaWeightTB.Clear();
            criteriaLenghtLB.Enabled = false;
            criteriaLenghtTB.Enabled = false;
            criteriaLenghtTB.Clear();
            applyButton.Enabled = false;
            cancelButton.Enabled = false;
        }

        private void criteriaWeightTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void criteriaLenghtTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            string title;
            int weight, lenght;

            if (criteriaTitleTB.Text != "" && criteriaWeightTB.Text != "" && criteriaLenghtTB.Text != "")
            {
                title = criteriaTitleTB.Text.ToString();
                weight = Convert.ToInt32(criteriaWeightTB.Text);
                lenght = Convert.ToInt32(criteriaLenghtTB.Text);

                if (whatToolButtonClicked == "add")
                {
                    dataGVCriteries.Rows.Add(title, weight, lenght);
                    dataGVOptions.Columns.Add("", title);
                }
                else if (whatToolButtonClicked == "edit")
                {
                    dataGVCriteries.Rows[dataGVCriteries.SelectedCells[0].RowIndex].SetValues(title, weight, lenght);
                }

                criteriaTitleLB.Enabled = false;
                criteriaTitleTB.Enabled = false;
                criteriaTitleTB.Clear();
                criteriaWeightLB.Enabled = false;
                criteriaWeightTB.Enabled = false;
                criteriaWeightTB.Clear();
                criteriaLenghtLB.Enabled = false;
                criteriaLenghtTB.Enabled = false;
                criteriaLenghtTB.Clear();
                applyButton.Enabled = false;
                cancelButton.Enabled = false;

                errorProvider1.Clear();
            } else
            {
                errorProvider1.SetError(applyButton, "Пустые поля не разрешены!");
            }
        }

        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            int deleteRow = dataGVCriteries.SelectedCells[0].RowIndex;
            dataGVCriteries.Rows.RemoveAt(deleteRow);
            dataGVOptions.Columns.RemoveAt(deleteRow + 1);
        }

        private void toolStripButtonEdit_Click(object sender, EventArgs e)
        {
            int editRow = dataGVCriteries.SelectedCells[0].RowIndex;
            criteriaTitleTB.Text = dataGVCriteries[0, editRow].Value.ToString();
            criteriaWeightTB.Text = dataGVCriteries[1, editRow].Value.ToString();
            criteriaLenghtTB.Text = dataGVCriteries[2, editRow].Value.ToString();

            criteriaTitleLB.Enabled = true;
            criteriaTitleTB.Enabled = true;
            criteriaWeightLB.Enabled = true;
            criteriaWeightTB.Enabled = true;
            criteriaLenghtLB.Enabled = true;
            criteriaLenghtTB.Enabled = true;
            applyButton.Enabled = true;
            cancelButton.Enabled = true;
            criteriaTitleTB.Focus();
            whatToolButtonClicked = "edit";
        }

        private void solutionButton_Click(object sender, EventArgs e)
        {
            int [,] matrix_values = ReadingOptionsValues(dataGVOptions);
            string[] matrix_labels = ReadingOptionsLabels(dataGVOptions);
            int[] matrix_weights = ReadingCriteriesWeights(dataGVCriteries);
            int[] matrix_lenghts = ReadingCriteriesLenghts(dataGVCriteries);
            int row_count = matrix_values.GetLength(0);
            int column_count = matrix_values.GetLength(1);
            double[,] matrix_concurrence = new double[row_count, row_count];
            double[,] matrix_noconcurrence = new double[row_count, row_count];
            var noconcurrence_sum = new List<double>(column_count);
            var exclude_indexes = new List<int>();
            int weights_sum = 0;
            double maximum, minimun;

            //Сумма весов
            for (int i = 0; i < matrix_weights.Length; i++)
            {
                weights_sum += matrix_weights[i];
            }

            //Таблица индексов согласия
            for (int i = 0; i < row_count; i++)
            {
                for (int j = 0; j < row_count; j++)
                {
                    if (i == j)
                        matrix_concurrence[i, j] = 0;
                    else
                    {
                        for (int k = 0; k < column_count; k++)
                        {
                            if (matrix_values[i, k] < matrix_values[j, k])
                            {
                                matrix_concurrence[i, j] += (double)matrix_weights[k] / (double)weights_sum;
                            } else //Таблица индексов несогласия
                            {
                                noconcurrence_sum.Add((double)(matrix_values[i, k] - matrix_values[j, k]) / (double)matrix_lenghts[k]);
                                matrix_noconcurrence[i, j] = noconcurrence_sum.Max();
                            }
                        }
                        noconcurrence_sum.Clear();
                    }
                }
            }

            //Вывод таблицы индексов согласия
            Write(matrix_concurrence, dataGVConcurrence);

            //Вывод таблицы индексов несогласия
            Write(matrix_noconcurrence, dataGVNoconcurrence);

            maximum = int.MinValue;
            minimun = int.MaxValue;

            var exclude_counts = new List<int>();
            var range_list = new List<string>();
            string range_item = "";
            int core_count = 1;
            int matrix_size = row_count;

            coresLB.Text = "";
            //Раскидываем по ядрам
            while (matrix_size >= 2)
            {
                matrix_size = row_count;

                //Находим минимум и максимум
                for (int i = 0; i < row_count; i++)
                {
                    for (int j = 0; j < row_count; j++)
                    {
                        if (matrix_concurrence[i, j] > maximum)
                            maximum = matrix_concurrence[i, j];

                        if (matrix_noconcurrence[i, j] != 0 && matrix_noconcurrence[i, j] < minimun && matrix_noconcurrence[i, j] != 0.1)
                            minimun = matrix_noconcurrence[i, j];
                    }
                }
                coresLB.Text += core_count.ToString() + " ядро: ";

                //Ищем ядра
                for (int i = 0; i < row_count; i++)
                {
                    for (int j = 0; j < row_count; j++)
                    {
                        if (i == j && matrix_concurrence[i, j] == 0 && matrix_noconcurrence[i, j] == 0)
                        {
                            //Ничего не делаем
                        }
                        else if (matrix_concurrence[i, j] >= maximum && matrix_noconcurrence[i, j] <= minimun)
                        {
                            exclude_counts.Add(j);
                            for (int k = 0; k < row_count; k++)
                            {
                                if (j == k)
                                {
                                    coresLB.Text += matrix_labels[k] + " ";
                                    range_item += matrix_labels[k] + " ";
                                }
                            }
                        }
                    }
                }

                range_list.Add(range_item);
                range_item = "";

                coresLB.Text += "\n";
                minimun = int.MaxValue;
                maximum = int.MinValue;

                //Вычеркиваем найденные ядра и определяем новое максимальное и минимальное значение
                for (int i = 0; i < row_count; i++)
                {
                    for (int j = 0; j < row_count; j++)
                    {
                        if ((exclude_counts.Contains(i) || exclude_counts.Contains(j)) || (matrix_concurrence[i, j] == 0 && matrix_noconcurrence[i, j] == 0))
                        {
                            matrix_concurrence[i, j] = 0;
                            matrix_noconcurrence[i, j] = 0;
                        } else
                        {
                            matrix_concurrence[i, j] = matrix_concurrence[i, j];
                            matrix_noconcurrence[i, j] = matrix_noconcurrence[i, j];
                            if (matrix_concurrence[i, j] > maximum)
                                maximum = matrix_concurrence[i, j];
                            if (matrix_noconcurrence[i, j] < minimun)
                                minimun = matrix_noconcurrence[i, j];
                        }
                    }
                }

                matrix_size = matrix_size - exclude_counts.Count;
                core_count++;
            }

            //Выписываем последнее ядро
            for (int k = 0; k < row_count; k++)
            {
                if (!exclude_counts.Contains(k))
                {
                    coresLB.Text += core_count.ToString() + " ядро: " + matrix_labels[k];
                    range_list.Add(matrix_labels[k]);
                }
            }

            //Выводим ранжирование альтернатив от лучшей к худшей
            range_list.Reverse();
            rangeLB.Text = "Лучшей является альтернатива " + range_list[0];
            for (int item = 1; item < range_list.Count; item++)
            {
                rangeLB.Text += ", затем " + range_list[item];
            }
        }

        //Чтение значений альтернатива - критерий
        private int[,] ReadingOptionsValues(DataGridView dataGridView)
        {
            int[,] values;

            values = new int[dataGridView.RowCount - 1, dataGridView.ColumnCount - 1];
            try
            {
                for (int i = 0; i < dataGridView.RowCount - 1; i++)
                {
                    for (int j = 0; j < dataGridView.ColumnCount - 1; j++)
                    {
                        values[i, j] = Convert.ToInt32(dataGridView.Rows[i].Cells[j + 1].Value);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Использование букв и символов не допустимо!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return values;
        }

        //Чтение весов критериев
        private int[] ReadingCriteriesWeights(DataGridView dataGridView)
        {
            int[] weights;

            weights = new int[dataGridView.RowCount];
            try
            {
                for (int i = 0; i < dataGridView.RowCount; i++)
                {
                    weights[i] = Convert.ToInt32(dataGridView.Rows[i].Cells[1].Value);
                }
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return weights;
        }


        //Чтение длин шкал
        private int[] ReadingCriteriesLenghts(DataGridView dataGridView)
        {
            int[] lenghts;

            lenghts = new int[dataGridView.RowCount];
            try
            {
                for (int i = 0; i < dataGridView.RowCount; i++)
                {
                    lenghts[i] = Convert.ToInt32(dataGridView.Rows[i].Cells[2].Value);
                }
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return lenghts;
        }

        //Чтение названий альтернатив
        private string[] ReadingOptionsLabels(DataGridView dataGridView)
        {
            string[] labels;

            labels = new string[dataGridView.RowCount - 1];
            try
            {
                for (int i = 0; i < dataGridView.RowCount - 1; i++)
                {
                    labels[i] = (string)dataGridView.Rows[i].Cells[0].Value;
                }
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return labels;
        }

        //Запись матрицы в dataGridView
        private static void Write(double[,] matrix, DataGridView dataGridView)
        {
            dataGridView.RowCount = matrix.GetLength(0);
            dataGridView.ColumnCount = matrix.GetLength(1);

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == j)
                        dataGridView.Rows[i].Cells[j].Value = "*";
                    else
                        dataGridView.Rows[i].Cells[j].Value = Math.Round(matrix[i, j], 4).ToString();
                    dataGridView.Columns[j].Width = 70;
                }
            }
        }
    }
}