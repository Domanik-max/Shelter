using System;
namespace Person
{
    public class Person
    {
		private int Id { get; set; }
		private string Name { get; set; }
		private int Age { get; set; }
		private char Gender { get; set; }

		public Person()
		{
		}

        /// <summary>
		/// This function will grab the name of the person 
		/// </summary>
		/// <returns>
		/// Returns name of Person
		/// </returns>
		public static string getName()
		{
			return Name;
		}

		/// <summary>
		/// This function will grab the age of the person 
		/// </summary>
		/// <returns>
		/// Returns name of Person
		/// </returns>
		public static int getAge()
		{
			return Age;
		}

		/// <summary>
		/// This function will grab the gender of the person 
		/// </summary>
		/// <returns>
		/// Returns gender of Person
		/// </returns>
		public static string getName()
		{
			return Name;
		}





		/// <summary>
		/// This function will grab the name of the person 
		/// </summary>
		/// <returns>
		/// Returns name of Person
		/// </returns>
		public static Person getInfo()
		{
			return Person;
		}







	}
}
