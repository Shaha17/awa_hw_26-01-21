using System;

namespace DZ_26_01_21
{
	/// <summary>
	/// Класс хранящий в себе данные о телефоне
	/// </summary>
	class SmartPhone
	{
		/// <summary>
		/// Свойство хранящее в себе бренд телефона. Не может быть изменено после инициализации
		/// </summary>
		public string Brand { get; init; }
		/// <summary>
		/// Свойство хранящее в себе название телефона. Не может быть изменено после инициализации
		/// </summary>
		public string Name { get; init; }
		/// <summary>
		/// Свойство хранящее в себе название операционной системы телефона. Не может быть изменено после инициализации
		/// </summary>
		public string Os { get; init; }
		/// <summary>
		/// Свойство хранящее в себе версию операционной системы телефона.
		/// </summary>
		public string OsVersion { get; set; }
		/// <summary>
		/// Свойство хранящее в себе цвет телефона.
		/// </summary>
		public string Color { get; set; }
		/// <summary>
		/// Свойство хранящее в себе ёмкость памяти телефона в Гб.
		/// </summary>
		public double Memory { get; init; }
		/// <summary>
		/// Свойство хранящее в себе ёмкость батареи телефона в mAh.
		/// </summary>
		public double Battery { get; init; }
		/// <summary>
		/// Свойство хранящее в себе диагональ экрана телефона в дюймах.
		/// </summary>
		public double Diagonal { get; init; }
		/// <summary>
		/// Конструктор по умолчанию
		/// </summary>
		public SmartPhone() { }
		/// <summary>
		/// Конструктор для создания экземпляра с заданными параметрами
		/// </summary>
		/// <param name="brand">Название бренда</param>
		/// <param name="name">Модель телефона</param>
		/// <param name="os">Операционная система</param>
		/// <param name="OsVersion">Версия операционной системы</param>
		/// <param name="color">Цвет телефона</param>
		/// <param name="memory">Ëмкость памяти в Гб</param>
		/// <param name="battery">Ëмкость батареи в mAh</param>
		/// <param name="diagonal">Диагональ экрана в дюймах</param>
		public SmartPhone(string brand, string name, string os, string OsVersion, string color, double memory, double battery, double diagonal)
		{
			this.Brand = brand;
			this.Name = name;
			this.Os = os;
			this.OsVersion = OsVersion;
			this.Color = color;
			this.Memory = memory;
			this.Battery = battery;
			this.Diagonal = diagonal;
		}
		/// <summary>
		/// Метод выводящий полную информацию о телефоне
		/// </summary>
		public void Show()
		{
			Console.WriteLine(this.GetFullInfo());
		}
		/// <summary>
		/// Метод возвращающий строку с полной информацией о телефоне
		/// </summary>
		/// <returns>Информация о телефоне</returns>
		public string GetFullInfo()
		{
			return $"Название: {this.Brand} {this.Name}\n" +
					$"Операционная система: {this.Os} {this.OsVersion}\n" +
					$"Цвет: {this.Color}\n" +
					$"Память: {this.Memory} Гб\n" +
					$"Ëмкость патареи: {this.Battery} mAh\n" +
					$"Диагональ: {this.Diagonal}\"";
		}
	}
}

