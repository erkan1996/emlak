using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace emlak_sistemi.Models.Model
{
	[Table("evbilgi")]
	public class evbilgi
	{
		[Key]
		public int EvId { get; set; }

		[Required, StringLength(50, ErrorMessage = "50 karakter olmalıdır")]
		[DisplayName("işlem Türü")]
		public string Tur { get; set; }

		[Required]
		[DisplayName("m²")]
		public int MetreKare { get; set; }

		[Required]
		[DisplayName("Oda Sayısı")]
		public int OdaSayisi { get; set; }
		public string Foto1 { get; set; }
		public string Foto2 { get; set; }
		public string Foto3 { get; set; }

		[Required]
		public int Kat { get; set; }


		[Required]
		[DisplayName("Isınma Şekli")]
		public string IsiTuru { get; set; }
	
		[DisplayName("Açıklama")]
		public string Aciklama { get; set; }

		[Required]
		[DisplayName("Ev Sahibi Adı")]

		public string Ad { get; set; }

		[Required]
		[DisplayName("Ev Sahibi Soyadı")]

		public string Soyad { get; set; }
		[Required]
		[DisplayName("Ev Sahibi Telefon")]
		public Int64 Telefon { get; set; }


	}
}