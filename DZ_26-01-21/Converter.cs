namespace DZ_26_01_21
{
	class Converter
	{
		double usd;
		double eur;
		double rub;
		public Converter(double usd, double eur, double rub)
		{
			this.usd = usd;
			this.eur = eur;
			this.rub = rub;
		}
		public double ToUSD(double amount)
		{
			return amount * this.usd;
		}
		public double FromUSD(double amount)
		{
			return amount / this.usd;
		}
		public double ToEUR(double amount)
		{
			return amount * this.eur;
		}
		public double FromEUR(double amount)
		{
			return amount / this.eur;
		}
		public double ToRUB(double amount)
		{
			return amount * this.rub;
		}
		public double FromRUB(double amount)
		{
			return amount / this.rub;
		}
	}
}

