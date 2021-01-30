using System;

namespace DZ_26_01_21
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Задание 1.2");
			{
				// Задание 1.2
				// Требуется: создать класс с именем Rectangle.
				// В теле класса создать два поля, описывающие длины сторон:
				// • double side1, side2.
				// • Создать пользовательский конструктор Rectangle(double side1, double
				// side2), в теле которого поля side1 и side2 инициализируются
				// значениями аргументов.
				// • Создать два метода:
				// o double AreaCalculator() - вычисляющие площадь прямоугольника:
				// o double PerimeterCalculator() - периметр прямоугольника.
				// • Создать два свойства double Area и double Perimeter с одним методом доступа get.
				// • Написать программу, которая принимает от пользователя длины двух
				// сторон прямоугольника и выводит на экран периметр и площадь.
				double side1, side2;
				Console.WriteLine("Введите первую сторону прямоугольника: ");
				double.TryParse(Console.ReadLine(), out side1);
				Console.WriteLine("Введите вторую сторону прямоугольника: ");
				double.TryParse(Console.ReadLine(), out side2);

				var rect = new Rectangle(side1, side2);
				Console.WriteLine($"Периметр прямоугольника равен {rect.Perimeter}");
				Console.WriteLine($"Площадь прямоугольника равна {rect.AreaCalculator()}");
			}

			Console.WriteLine("Задание 1.3");
			{
				// Задание 1.3
				// Требуется: создать класс Book. Создать классы Title, Author и Content, каждый из
				// которых должен содержать одно строковое поле и метод void Show().
				// 1. Реализуйте возможность добавления в книгу названия книги, имени автора и
				// содержания.
				// 2. Выведите на экран разными цветами при помощи метода Show() название
				// книги, имя автора и содержание.
				var book = new Book("Название", "Автор", "Содержание");
				book.Show();
				book.Author = "Джабборов Шахзод";
				book.Title = "Хроники C#";
				book.Content = "C#C#C#C#C#C#C#C#C#C#";
				book.Show();
			}
			Console.WriteLine("Задание 1.4");
			{
				// Задание 1.4
				// Требуется: создать класс которое описывает состояние и поведение некой сущности.
				// Сущность возьмите из обыденности.
				var myPhone = new SmartPhone()
				{
					Brand = "Samsung",
					Name = "Galaxy S8",
					Os = "Android",
					OsVersion = "8.0",
					Color = "Black",
					Memory = 64,
					Battery = 3000,
					Diagonal = 5.8
				};
				var anotherPhone = new SmartPhone()
				{
					Brand = "Apple",
					Name = "Iphone X",
					Os = "iOS",
					OsVersion = "14.1",
					Color = "Black",
					Memory = 128,
					Battery = 2700,
					Diagonal = 5.8
				};
				myPhone.Show();
				Console.WriteLine();
				Console.WriteLine(anotherPhone.GetFullInfo());
			}

			Console.WriteLine("Задание 2.2");
			{
				// Задание 2.2
				// Cоздать класс Converter.
				// В теле класса создать пользовательский конструктор, который принимает три
				// вещественных аргумента, и инициализирует поля соответствующие курсу 3-х
				// основных валют, по отношению к сомони – public Converter(double
				// usd(доллар), double eur(евро), double rub(рубль)).
				// Написать программу, которая будет выполнять конвертацию из сомони в
				// одну из указанных валют, также программа должна производить
				// конвертацию из указанных валют в сомони
				var converter = new Converter(0.088, 0.073, 6.62);
				Console.WriteLine($"1000 долларов в сомони - {Math.Round(converter.FromUSD(1000), 4)}");
				Console.WriteLine($"1000 сомони в долларов - {Math.Round(converter.ToUSD(1000), 4)}");
				Console.WriteLine($"1000 рублей в сомони - {Math.Round(converter.FromRUB(1000), 4)}");
				Console.WriteLine($"1000 сомони в рублях - {Math.Round(converter.ToRUB(1000), 4)}");
				Console.WriteLine($"1000 евро в сомони - {Math.Round(converter.FromEUR(1000), 4)}");
				Console.WriteLine($"1000 сомони в евро - {Math.Round(converter.ToEUR(1000), 4)}");
			}
			Console.WriteLine();

			Console.WriteLine("Задание 2.3");
			{
				// Задание 2.3
				// Создать класс Employee.
				// В теле класса создать пользовательский конструктор, который принимает два
				// строковых аргумента, и инициализирует поля, соответствующие фамилии и
				// имени сотрудника. Создать метод рассчитывающий оклад сотрудника (в
				// зависимости от должности и стажа) и налоговый сбор.
				// Написать программу, которая выводит на экран информацию о
				// сотруднике (фамилия, имя, должность), оклад (заработная плата) и
				// налоговый сбор (13 % налог + 1% пенсионный фонд) от заработной платы.
				var emp = new Employee("Шахзод", "Джабборов");
				emp.Position = "Middle";
				emp.WorkExperience = 4;
				emp.Show();
			}
		}
	}
}

