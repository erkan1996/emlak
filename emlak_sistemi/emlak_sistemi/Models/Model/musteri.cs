using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace emlak_sistemi.Models.Model
{

	[Table("musteri")]
	public class musteri
	{
		[Key]
		public int MusteriId { get; set; }

		[Required, StringLength(50, ErrorMessage = "50 karakter olmalıdır")]
		
		public string Ad { get; set; }

		[Required, StringLength(50, ErrorMessage = "50 karakter olmalıdır")]

		public string Soyad { get; set; }

		[DisplayName("Ev Telefonu")]
		public Int64 EvTelefonu { get; set; }

		[Required]
		[DisplayName("Cep Telefonu")]

		public Int64 CepNo { get; set; }

		[ StringLength(100, ErrorMessage = "100 karakter olmalıdır")]
		
		public string Mail { get; set; }


	}
}