using System;

namespace DZ_26_01_21
{
	class Content
	{
		/// <summary>
		/// Поле содежащее текст содержания
		/// </summary>
		string text;
		/// <summary>
		/// Конструктор для создания объекта содержания с параметром text
		/// </summary>
		/// <param name="text">Текст названия</param>
		public Content(string text)
		{
			this.text = text;
		}
		/// <summary>
		/// Метод для вывода на экран текст содержания
		/// </summary>
		public void Show()
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine(text);
			Console.ForegroundColor = ConsoleColor.White;
		}
		/// <summary>
		/// Свойство позволяющее задать текст содержания
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

