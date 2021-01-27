using System;

namespace DZ_26_01_21
{
	class Author
	{
		/// <summary>
		/// Поле содежащее текст автора
		/// </summary>
		string text;
		/// <summary>
		/// Конструктор для создания объекта автора с параметром text
		/// </summary>
		/// <param name="text">Текст названия</param>
		public Author(string text)
		{
			this.text = text;
		}
		/// <summary>
		/// Метод для вывода на экран текст автора
		/// </summary>
		public void Show()
		{
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.WriteLine(text);
			Console.ForegroundColor = ConsoleColor.White;
		}
		/// <summary>
		/// Свойство позволяющее задать текст автора
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

