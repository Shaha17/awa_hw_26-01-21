using System;

namespace DZ_26_01_21
{
	class Title
	{
		/// <summary>
		/// Поле содежащее текст названия
		/// </summary>
		string text;
		/// <summary>
		/// Конструктор для создания объекта названия с параметром text
		/// </summary>
		/// <param name="text">Текст названия</param>
		public Title(string text) 
		{
			this.text = text;
		}
		/// <summary>
		/// Метод для вывода на экран текст названия
		/// </summary>
		public void Show()
		{
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine(text);
			Console.ForegroundColor = ConsoleColor.White;
		}
		/// <summary>
		/// Свойство позволяющее задать текст названия
		/// </summary>
		public string Text
		{
			set
			{
				text = value;
			}
		}

	}
}

