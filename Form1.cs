using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Lipatov_Matvey_24VP2_KR
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Массив
        /// </summary>
        private int[] array1;

        /// <summary>
        /// Количество повторений для измерения времени выполнения
        /// </summary>
        int count = 30;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Метод генерирует массив
        /// </summary>
        /// <param name="len">Длина массива</param>
        /// <exception cref="Exception">Исключение при некорректных параметрах</exception>
        private void GenerateArray(int len)
        {
            if (len > 0) 
            {
                array1 = new int[len];
                Random random = new Random();
                if (radioButton1.Checked) // Неупорядоченный массив
                {
                    for (int i = 0; i < len; i++)
                    {
                        array1[i] = random.Next(0, len);
                    }
                }
                else if (radioButton2.Checked) // Упорядоченный массив
                {
                    int temp = 0;
                    for (int i = 0; i < len; i++)
                    {
                        array1[i] = random.Next(temp, i + 5);
                        temp = array1[i];
                    }
                }
                else if (radioButton3.Checked) // Упорядоченный в обратном порядке массив
                {
                    int temp = 0;
                    for (int i = len - 1; i >= 0; i--)
                    {
                        array1[i] = random.Next(temp, temp + 5);
                        temp = array1[i];
                    }
                }
                else if (radioButton4.Checked) // Частично упорядоченный массив
                {
                    int percentSequence = (int)numericUpDown2.Value;
                    if (percentSequence <= 0)
                    {
                        throw new Exception("Ошибка!\nПроцент упорядоченности должен быть больше 0!");
                    }
                    else
                    {
                        int N2 = len * percentSequence / 100;
                        int i = 0;
                        int temp = 0;
                        for (; i < N2; i++)
                        {
                            array1[i] = random.Next(temp, temp + 5);
                            temp = array1[i];
                        }
                        for (; i < len; i++)
                        {
                            array1[i] = random.Next(0, len);
                        }
                    }    
                }
                else // Пользователь не выбрал тип упорядоченности
                {
                    throw new Exception("Ошибка!\nВы не выбрали тип упорядоченности!");
                }
            }
            else
            {
                throw new Exception("Ошибка!\nРазмер массива должен быть больше 0!");
            }
        }
        
        /// <summary>
        /// Метод сортирует массив пирамидальной сортировкой
        /// </summary>
        /// <param name="array">Сортируемый массив</param>
        /// <param name="len">Длина массива</param>
        private void HeapSort(int[] array, int len)
        {
            // Построение кучи (перегруппируем массив)
            for (int i = len / 2 - 1; i >= 0; i--)
            {
                Heapify(array, len, i);
            }
            // Один за другим извлекаем элементы из кучи
            for (int i = len - 1; i >= 0; i--)
            {
                // Перемещаем текущий корень в конец
                int temp = array[0];
                array[0] = array[i];
                array[i] = temp;
                // вызываем процедуру Heapify на уменьшенной куче
                Heapify(array, i, 0);
            }
        }

        /// <summary>
        /// Метод преобразует поддерево в двоичную кучу с наибольшим элементом в корне
        /// </summary>
        /// <param name="array">Массив, представляющий кучу</param>
        /// <param name="len">Размер кучи</param>
        /// <param name="i">Индекс корневого узла поддерева для преобразования в кучу</param>
        private void Heapify(int[] array, int len, int i)
        {
            int largest = i;
            // Инициализируем наибольший элемент как корень
            int left = 2 * i + 1; 
            int right = 2 * i + 2;
            // Если левый дочерний элемент больше корня
            if (left < len && array[left] > array[largest])
            {
                largest = left;
            }
            // Если правый дочерний элемент больше, чем самый большой элемент на данный момент
            if (right < len && array[right] > array[largest])
            {
                largest = right;
            }
            // Если самый большой элемент не корень
            if (largest != i)
            {
                int swap = array[i];
                array[i] = array[largest];
                array[largest] = swap;
                // Рекурсивно преобразуем в двоичную кучу затронутое поддерево
                Heapify(array, len, largest);
            }
        }

        /// <summary>
        /// Генерирует последовательность Седжвика для сортировки Шелла
        /// </summary>
        /// <param name="len">Длина массива</param>
        /// <returns>Массив промежутков в убывающем порядке</returns>
        private int[] GenerateSedgewickSequence(int len)
        {
            // Сначала подсчитаем количество подходящих промежутков
            int count = 0;
            int k = 0;
            int gap;
            // Подсчитываем сколько gaps нам нужно
            do
            {
                gap = CalculateSedgewickGap(k);
                if (gap < len)
                {
                    count++;
                }
                k++;
            } while (gap < len);
            // Создаем массив нужного размера
            int[] gaps = new int[count];
            k = 0;
            int index = 0;
            // Заполняем массив gaps
            do
            {
                gap = CalculateSedgewickGap(k);
                if (gap < len)
                {
                    gaps[index] = gap;
                    index++;
                }
                k++;
            } while (gap < len);
            // Переворачиваем массив для убывающего порядка
            Array.Reverse(gaps);
            return gaps;
        }

        /// <summary>
        /// Вычисляет значение промежутка для последовательности Седжвика
        /// </summary>
        /// <param name="k">Индекс промежутка</param>
        /// <returns>Значение промежутка</returns>
        private int CalculateSedgewickGap(int k)
        {
            if (k % 2 == 0)
            {
                return (int)(9 * (Math.Pow(2, k) - Math.Pow(2, k / 2)) + 1);
            }
            else
            {
                return (int)(8 * Math.Pow(2, k) - 6 * Math.Pow(2, (k + 1) / 2) + 1);
            }
        }

        /// <summary>
        /// Сортирует массив методом Шелла с последовательностью Седжвика
        /// </summary>
        /// <param name="array">Сортируемый массив</param>
        /// <param name="len">Длина массива</param>
        private void SortSedgewick(int[] array, int len)
        {
            int[] gaps = GenerateSedgewickSequence(len);
            foreach (int gap in gaps)
            {
                for (int i = gap; i < len; i++)
                {
                    int temp = array[i];
                    int j;
                    for (j = i; j >= gap && array[j - gap] > temp; j -= gap)
                    {
                        array[j] = array[j - gap];
                    }
                    array[j] = temp;
                }
            }
        }

        /// <summary>
        /// Метод сортирует массив сортировкой подсчётом
        /// </summary>
        /// <param name="array">Сортируемый массив</param>
        /// <param name="len">Длина массива</param>
        private void CountingSort(int[] array, int len)
        {
            int maxEl = array[0];
            for (int i = 0; i < len; i++)
            {
                if (array[i] > maxEl)
                {
                    maxEl = array[i];
                }
            }
            int[] count = new int[maxEl + 1];
            for (int i = 0; i < len; i++)
            {
                count[array[i]]++;
            }
            int index = 0;
            for (int i = 0; i < count.Length; i++)
            {
                while (count[i] > 0)
                {
                    array[index++] = i;
                    count[i]--;
                }
            }
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Сортировать" - выполняет сравнение алгоритмов сортировки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Cleaner();
                int N = (int)numericUpDown1.Value;
                GenerateArray(N);
                int[] array2 = new int[N];
                Array.Copy(array1, 0, array2, 0, N);
                int[] array3 = new int[N];
                Array.Copy(array1, 0, array3, 0, N);
                int[] ArrayHelp = new int[N];
                Array.Copy(array1, 0, ArrayHelp, 0, N);
                const int N2 = 10;
                int[] DataMass1 = new int[N2];
                int[] DataMass2 = new int[N2];
                int[] DataMass3 = new int[N2];
                int index = 0;
                for(int i = 10; i <= 100; i += 10)
                {
                    int NewLen = N * i / 100;
                    Array.Copy(ArrayHelp, array1, NewLen);
                    Array.Copy(ArrayHelp, array2, NewLen);
                    Array.Copy(ArrayHelp, array3, NewLen);
                    // Пирамидальная сортировка
                    int StartTime1 = Environment.TickCount;
                    {
                        for (int j = 0; j < count; j++)
                        {
                            HeapSort(array1, NewLen);
                        }
                    }
                    int ResultTime1 = Environment.TickCount - StartTime1;
                    DataMass1[index] = ResultTime1;
                    //Сортировка Шелла (шаг - Седжвика)
                    int StartTime2 = Environment.TickCount;
                    {
                        for(int j = 0; j < count; j++)
                        {
                            SortSedgewick(array2, NewLen);
                        }    
                    }
                    int ResultTime2 = Environment.TickCount - StartTime2;
                    DataMass2[index] = ResultTime2;
                    //Сортировка подсчётов
                    int StartTime3 = Environment.TickCount;
                    {
                        for(int j = 0; j < count; j++)
                        {
                            CountingSort(array3, NewLen);
                        }
                    }
                    int ResultTime3 = Environment.TickCount - StartTime3;
                    DataMass3[index] = ResultTime3;
                    index++;
                }
                FillingOutTheTable(DataMass1, DataMass2, DataMass3);
                FillingOutTheSchedule(DataMass1, DataMass2, DataMass3);
            }
            catch (Exception ex) 
            {
                label6.Text = ex.Message;
                label6.ForeColor = Color.Red;
            }
        }

        /// <summary>
        /// Заполняет таблицу данными о времени выполнения алгоритмов
        /// </summary>
        /// <param name="mass1">Данные для пирамидальной сортировки</param>
        /// <param name="mass2">Данные для сортировки Шелла</param>
        /// <param name="mass3">Данные для сортировки подсчетом</param>
        private void FillingOutTheTable(int[] mass1, int[] mass2, int[] mass3)
        {
            int NumLine = 1;
            for (int i = 0; i < mass1.Length; i++)
            {
                dataGridView1[NumLine, 0].Value = mass1[i];
                dataGridView1[NumLine, 1].Value = mass2[i];
                dataGridView1[NumLine, 2].Value = mass3[i];
                NumLine++;
            }
        }

        /// <summary>
        /// Заполняет график данными о времени выполнения алгоритмов
        /// </summary>
        /// <param name="mass1">Данные для пирамидальной сортировки</param>
        /// <param name="mass2">Данные для сортировки Шелла</param>
        /// <param name="mass3">Данные для сортировки подсчетом</param>
        private void FillingOutTheSchedule(int[] mass1, int[] mass2, int[] mass3)
        {
            for (int i = 0; i < mass1.Length; i++)
            {
                int percentage = (i + 1) * 10; // 10%, 20%, ..., 100%
                chart1.Series[0].Points.AddXY(percentage, mass1[i]);
                chart1.Series[1].Points.AddXY(percentage, mass2[i]);
                chart1.Series[2].Points.AddXY(percentage, mass3[i]);
            }
        }

        /// <summary>
        /// Очищает таблицу, график и сообщения об ошибках
        /// </summary>
        private void Cleaner()
        {
            label6.Text = string.Empty;
            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add("Пирамидальная сортировка");
            dataGridView1.Rows.Add("Сортировка Шелла (шаг - Седжвика)");
            dataGridView1.Rows.Add("Сортировка подсчетом");
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            chart1.Series[2].Points.Clear();
        }

        /// <summary>
        /// Обработчик события загрузки формы - создание строк таблицы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            Cleaner();
        }

        /// <summary>
        /// Обработчик события на кнопку "Выход" - закрывает приложение
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
