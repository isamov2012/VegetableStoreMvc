
namespace VegetableStoreMvc.Models
{
	public class FakeDataBase
	{
		ApplicationContext context;

		public FakeDataBase(ApplicationContext context)
		{
			this.context = context;
		}
		public Vegetable[] GetAll()
		{
			return context.Vegetables.OrderBy(v => v.Price)
				.ToArray();

		}
		public void Add(Vegetable vm)
		{

			context.Vegetables.Add(vm);
			context.SaveChanges();

		}

		public Vegetable Find(int id)
		{
			return context.Vegetables.SingleOrDefault(x => x.Id == id);
		}

		public void Remove(int id)
		{
			var veg = Find(id);
			context.Vegetables.Remove(veg);
			context.SaveChanges();

		}

		public void Update(int id, Vegetable newVm)
		{
			var vm = Find(id);
			vm.Name = newVm.Name;
			vm.Price = newVm.Price;
			context.SaveChanges();

		}
	}
}
