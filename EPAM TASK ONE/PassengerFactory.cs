using System;
using System.Collections.Generic;

namespace EPAM_TASK_ONE
{
    /// <summary>
    /// Дочерний класс Фабрика Легковых автомобилей
    /// </summary>
    public class PassengerFactory : AutoFactory
    {
        /// <summary>
        /// Создание записи
        /// </summary>
        /// <param name="Color"></param>
        /// <param name="Engine"></param>
        /// <param name="Wheels"></param>
        /// <param name="Transmission"></param>
        /// <param name="Weight"></param>
        public PassengerFactory(string Color, string Engine, double Wheels, string Transmission, double Weight,string TypeAuto) : base(Color, Engine, Wheels, Transmission, Weight, TypeAuto) { }
        /// <summary>
        /// Переопределение метода базового класса ,создание автомобиля
        /// </summary>
        /// <param name="autoFactory"></param>
        /// <returns></returns>
        public override bool CreateNewAuto(AutoFactory autoFactory)
        {
            return true;
        }
    }
}
