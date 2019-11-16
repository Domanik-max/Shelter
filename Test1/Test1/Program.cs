using System;
namespace Test1
{
    public class Person
    {
        /// <summary>
		/// set ID can't be null
		/// </summary>
		private int Id { get; set; }

		/// <summary>
		/// set name can't be null
		/// </summary>
		private string Name { get; set; }

		/// <summary>
		/// set age can't be null
		/// </summary>
		private int Age { get; set; }

		/// <summary>
		/// set gender can't be null
		/// </summary>
		private char Gender { get; set; }

        /// <summary>
		/// This function will 
		/// </summary>
		/// <returns>
		/// Will return name of Person 
		/// </returns>
		public static string getName()
		{
			return Name;
		}

		/// <summary>
		/// This function will get person age
		/// </summary>
		/// <returns>
		/// Will return name of Person 
		/// </returns>
		public static string getAge()
		{
			return Age;
		}

	
		/// <summary>
		/// This function will grab all info on person 
		/// </summary>
		/// <returns>
		/// Will return name of Person 
		/// </returns>
		public static Person getInfo(Person currPerson)
		{
			return currPerson;
		}


	}
}
