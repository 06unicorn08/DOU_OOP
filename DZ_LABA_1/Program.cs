using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DZ_LABA_1
{
    internal class Program
    {
        private static List<Computer> _computer = new List<Computer>();
           

        static void Main()
        {
           
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\"Меню\" Выберите один из пунктов: \n" +
                    "1. Ввести характеристики \n2. Просмотреть список \n3. Удалить запись");
                int action = Convert.ToInt32(Console.ReadLine());
                switch (action)
                {
                    case 1: 
                        AddToComputerList();
                        break;
                    case 2:
                        DataOutput();
                        break;
                    case 3:
                        ClearComputerяRecord();
                        break;
                    default: Console.WriteLine("Число не соответствует командам");
                        Console.ReadKey();
                        break;
                }
            }

        }

        private static void AddToComputerList()
        {
            int action;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Введите данные: ");
                Console.Write("Введите порядковый номер: ");
                string sequenceNumber = Console.ReadLine();
                Console.Write("Введите производителя ЦП : ");
                string processorManufacturer = Console.ReadLine();
                Console.Write("Введите модель ЦП: ");
                string processorModel = Console.ReadLine();
                Console.Write("Введите ЦП: ");
                string processor = Console.ReadLine();
                Console.Write("Введите общий объём ОЗУ (ГБ): ");
                int volumeRam = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите общий объём накопителей данных (ГБ): ");
                int storageCapacity = Convert.ToInt32(Console.ReadLine());

                _computer.Add(new Computer(sequenceNumber, processorManufacturer, processorModel, processor, volumeRam, storageCapacity));

                Console.Write("Данные успешно записаны. Добавить ещё запись? 1 - Да, 2 - Нет: ");
                action = Convert.ToInt32(Console.ReadLine());
                if (action == 1)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("Выход из добавления записей. Нажмите любую клавишу");
                    Console.ReadKey();
                    break;
                }
            }
        }

        private static void DataOutput()
        {
            int i = 1;
            foreach (var comp in _computer)
            {
                Console.WriteLine($"Компьютер №{i}\nПорядковый номер: {comp.SequenceNumber}\nПроизводитель ЦП: {comp.ProcessorManufacturer}\nМодель ЦП: {comp.ProcessorModel}\nЦП: {comp.Processor}\nОбщий объём ОЗУ (ГБ): {comp.VolumeRam}\nОбщий объём накопителей (ГБ): {comp.StorageCapacity}\n");
                i++;
            }
            Console.WriteLine("Нажмите любую клавишу чтобы продолжить");
            Console.ReadKey();
        }

        private static void ClearComputerяRecord()
        {
            Console.Write("Введите порядковый номер ПК, запись о котором желаете удалить:");
            string sequenceNumberToDelete = Console.ReadLine();
            _computer.RemoveAll(c => c.SequenceNumber == sequenceNumberToDelete);
            Console.WriteLine("Данные успешно удалены, нажмите любую клавишу чтобы продолжить");
            Console.ReadKey();
        }
    }
}