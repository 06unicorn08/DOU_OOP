using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_LABA_1
{
    internal class Computer
    {
        public string SequenceNumber { get; set; } //Порядковый (инвентарный) номер (строка) 
        public string ProcessorManufacturer { get; set; } //Производитель ЦП 
        public string ProcessorModel { get; set; } //Модель ЦП 
        public string Processor { get; set; } //ЦП 
        public int VolumeRam { get; set; } //Общий объём ОЗУ (ГБ) 
        public int StorageCapacity { get; set; } //Общий объём накопителей данных (ГБ)

        public Computer(string sequenceNumber, string processorManufacturer, string processorModel, string processor, int volumeRam, int storageCapacity)
        {
            SequenceNumber = sequenceNumber;
            ProcessorManufacturer = processorManufacturer;
            ProcessorModel = processorModel;
            Processor = processor;
            VolumeRam = volumeRam;
            StorageCapacity = storageCapacity;
        }

    }
}
