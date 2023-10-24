﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness.BL_Model_Logic_.Model
{
    internal class User
    {
        #region Свойства
        public string Name { get; }

        public Gender Gender { get; }

        public DateTime BirthDate { get; }

        public double Weight { get; set; }

        public double Height { get; set; }
        #endregion

        public User(string name, Gender gender, DateTime birthDate, double weight, double height)
        {
            #region Проверка входных условий
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Имя пользователя не может быть пустым!", nameof(name));
            }
            if (gender == null) 
            {
                throw new ArgumentNullException("Пол должен быть выбран", nameof(gender));
            }

            if (birthDate < DateTime.Parse("01.01.1900") || birthDate >= DateTime.Now)
            {
                throw new ArgumentException("Невозможная дата рождения", nameof(birthDate));
            }
            if (weight <= 0)
            {
                throw new ArgumentException("Вес не может быть меньше или равен нулю.", nameof(weight));
            }
            if (height < 0)
            {
                throw new ArgumentException("Рост не может быть меньше или равен нулю.", nameof(height));
            }
            #endregion

            Name = name;
            Gender = gender;
            BirthDate = birthDate;
            Weight = weight;
            Height = height;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
