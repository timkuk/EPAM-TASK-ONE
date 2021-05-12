using System;
using System.Collections.Generic;

namespace EPAM_TASK_ONE
{
    public abstract class AutoFactory
    {
        /// <summary>
        ///Цвет автомобиля
        /// </summary>
        public string Color { get; set; }
        /// <summary>
        /// Тип двигателя
        /// </summary>
        public string Engine { get; set; }
        /// <summary>
        /// Диаметр колёс
        /// </summary>
        public double Wheels { get; set; }
        /// <summary>
        /// Тип трансмиссии
        /// </summary>
        public string Transmission { get; set; }
        /// <summary>
        /// Вес автомобиля
        /// </summary>
        public double Weight { get; set; }
        /// <summary>
        /// Тип автомобиля
        /// </summary>
        public string TypeAuto { get; set; }

        public AutoFactory(string Color, string Engine, double Wheels, string Transmission,double Weight,string TypeAuto)
        {
            this.Color = Color;
            this.Engine = Engine;
            this.Wheels = Wheels;
            this.Transmission = Transmission;
            this.Weight = Weight;
            this.TypeAuto = TypeAuto;
        }
        /// <summary>
        /// Абстрактный метод создания нового автомобиля  
        /// </summary>
        /// <returns></returns>
        public abstract bool CreateNewAuto(AutoFactory autoFactory);
    }
}
