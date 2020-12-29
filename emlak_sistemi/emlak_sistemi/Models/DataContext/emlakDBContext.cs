using emlak_sistemi.Models.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace emlak_sistemi.Models.DataContext
{
	public class emlakDBContext:DbContext
	{
		public emlakDBContext() : base("emlakDB")
		{

		}
		public DbSet<evbilgi> evbilgi { get; set; }
		public DbSet<isyeri> isyeri { get; set; }
		public DbSet<musteri> musteri { get; set; }
	}
}