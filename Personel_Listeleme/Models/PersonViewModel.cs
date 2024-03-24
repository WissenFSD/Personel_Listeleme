using System.Reflection.PortableExecutable;

namespace Personel_Listeleme.Models
{
	public class ViewList
	{
        public int Id { get; set; }
        public string JobTitle { get; set; }
        public string Gender { get; set; }
    }
	public class PersonViewModel
	{
		public List<ViewPerson> Persons { get; set; }
	}
	public class ViewPerson
	{
        public string JobTitle { get; set; }
		public string Name { get; set; }

        public string FirstName { get; set; }

		public string MiddleName { get; set; }

        public string LastName { get; set;
		}
        public string Gender { get; set; }
    }
}
