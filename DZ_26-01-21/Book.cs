using System;

namespace DZ_26_01_21
{
	class Book
	{
		/// <summary>
		/// Поле содержащее в себе объект названия книги
		/// </summary>
		Title title;
		/// <summary>
		/// Поле содержащее в себе объект автора книги
		/// </summary>
		Author author;
		/// <summary>
		/// Поле содержащее в себе объект содержания книги
		/// </summary>
		Content content;
        /// <summary>
		/// Свойство позволяющее задавать название книги
		/// </summary>
		public string Title { set { this.title.Text = value; } }
        /// <summary>
		/// Свойство позволяющее задавать автора книги
		/// </summary>
		public string Author { set { this.author.Text = value; } }
        /// <summary>
		/// Свойство позволяющее задавать содержание книги
		/// </summary>
		public string Content { set { this.content.Text = value; } }
        /// <summary>
		/// Конструктор для создания книги с заданными параметрами
		/// </summary>
		/// <param name="title">Название книги</param>
		/// <param name="author">Автор книги</param>
		/// <param name="content">Содержание книги</param>
		public Book(string title, string author, string content)
		{
			this.title = new Title(title);
			this.author = new Author(author);
			this.content = new Content(content);
		}
        /// <summary>
		/// Метод выводящий на экран информацию о книге
		/// </summary>
		public void Show()
		{
			this.title.Show();
			this.author.Show();
			this.content.Show();
			Console.WriteLine();
		}
	}
}

