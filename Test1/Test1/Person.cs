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
		/// 
		/// </summary>
		/// <returns></returns>
		public static string getName()
		{
			return Name;
		}

	}
}
