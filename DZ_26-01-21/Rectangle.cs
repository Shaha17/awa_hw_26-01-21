namespace DZ_26_01_21
{
	class Rectangle
	{
		double side1, side2;
        /// <summary>
		/// Свойство возвращает вычисленную площать прямоугольника
		/// </summary>
		public double Area
		{
			get { return this.side1 * this.side2; }
		}
        /// <summary>
		/// Свойство возвращает вычисленный периметр прямоугольника
		/// </summary>
		public double Perimeter
		{
			get { return (this.side1 + this.side2) * 2; }
		}
        /// <summary>
		/// Конструктор для создания прямоугольника с двумя сторонами
		/// </summary>
		/// <param name="side1">Длинна первой стороны прямоугольника</param>
		/// <param name="side2">Длинна второй стороны прямоугольника</param>
		public Rectangle(double side1, double side2)
		{
			this.side1 = side1;
			this.side2 = side2;
		}
        /// <summary>
		/// Метод вычисляющий площадь прямоугольника
		/// </summary>
		/// <returns>Площадь прямоугольника</returns>
		public double AreaCalculator()
		{
			return this.side1 * this.side2;
		}
        /// <summary>
		/// Метод вычисляющий периметр прямоугольника
		/// </summary>
		/// <returns>Периметр прямоугольника</returns>
		public double PerimeterCalculator()
		{
			return (this.side1 + this.side2) * 2;
		}
	}
}
