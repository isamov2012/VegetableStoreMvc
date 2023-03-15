using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace VegetableStoreMvc.Models
{
	public class Vegetable
	{
		public int Id { get; set; }

		[Display(Name = "Product name:")]
		[Required(ErrorMessage = "This field is required")]
		[StringLength(20, MinimumLength = 2, ErrorMessage = "Name should be between 2 - 25 characters.")]
		public string Name { get; set; }
		[Display(Name = "Product price:")]
		[Required(ErrorMessage = "This field is required")]
		[Range(0, 100, ErrorMessage = "Price should be between 0 - 100")]
		public double Price { get; set; }
	}
}
