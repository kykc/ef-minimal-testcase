using Microsoft.EntityFrameworkCore;
using System;

namespace efc_minimal_testcase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

	public enum Currency
	{
		EUR = 1,
		USD = 2,
	}

	public class MoneyAmount
	{
		public MoneyAmount(decimal amount, Currency currency)
		{
			Amount = amount;
			Currency = currency;
		}

		public Currency Currency { get; private set; }
		public decimal Amount { get; private set; }
	}

	public class BusinessTransaction
	{
		public int Id { get; set; }
		public MoneyAmount AmountCharged { get; set; }
		public MoneyAmount Profit { get; set; }
	}

	public class FinancialDbContext : DbContext
	{
		public DbSet<BusinessTransaction> BusinessTransactions { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			//optionsBuilder.UseInMemoryDatabase("FinancialTest");
			optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=FinancialTestCase;Trusted_Connection=True;");
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<BusinessTransaction>().OwnsOne(p => p.Profit);
			modelBuilder.Entity<BusinessTransaction>().OwnsOne(p => p.AmountCharged);
			//modelBuilder.Entity<BusinessTransaction>().OwnsOne(p => p.ChargeFee);
		}
	}
}
