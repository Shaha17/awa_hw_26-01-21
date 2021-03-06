using System;

namespace DZ_26_01_21
{
	class Employee
	{
		const double taxFee = 0.13 + 0.01;
		public string Name { get; set; }
		public string Surname { get; set; }
		public string Position { get; set; }
		public int WorkExperience { get; set; }
		public Employee(string name, string surname)
		{
			this.Name = name;
			this.Surname = surname;
		}
		public void Show()
		{
			double tax = this.CalcTax();
			double salary = this.CalcSalaryWithoutTax();
			Console.WriteLine($"Сотрудник {this.Surname} {this.Name}\nНа должности {this.Position}\nСтаж {this.WorkExperience} лет\nЗарплата {this.CalcSalaryWithoutTax()}\nНалоговый сбор {this.CalcTax()}");
		}

		public double CalcTax()
		{
			return Math.Round(taxFee * this.CalcSalaryWithoutTax(), 2);
		}
		double CalcSalaryWithoutTax()
		{
			double expBonus = 1 + Math.Min( this.WorkExperience * 0.5, 2.5);
			double salary = this.Position.ToLower() switch
			{
				"junior" => 1000,
				"middle" => 2000,
				"senior" => 3000,
				"team leader" => 4000,
				"head of project" => 4000,
				_ => 0
			};
			return Math.Round(expBonus * salary, 2);
		}
	}
}

