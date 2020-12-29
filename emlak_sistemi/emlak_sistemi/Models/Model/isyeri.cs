using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace emlak_sistemi.Models.Model
{
	[Table("isyeri")]
	public class isyeri
	{
		[Key]
		public int IsyeriId { get; set; }

		[Required, StringLength(150, ErrorMessage = "150 karakter olmalıdır")]
		[DisplayName("İşletme Adı")]
		public string IsletmeAdi { get; set; }

		[Required, StringLength(50, ErrorMessage = "50 karakter olmalıdır")]
		public string Yetkili { get; set; }

		[Required, StringLength(200, ErrorMessage = "200 karakter olmalıdır")]
		
		public string Adres { get; set; }

		[Required]
		public Int64 Telefon { get; set; }
		[Required]
		public Int64 Fax { get; set; }
	}
}