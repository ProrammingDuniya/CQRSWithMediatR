namespace Core
{
    /// <summary>
    /// Employee
    /// </summary>
    public class Employee : Entity<int>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Employee"/> class.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        /// <param name="dateOfBirth">The date of birth.</param>
        /// <param name="city">The city.</param>
        /// <param name="postalCode">The postal code.</param>
        /// <param name="street">The street.</param>
        private Employee(string? firstName, string? lastName, DateTime? dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
        }

        /// <summary>
        /// Gets the first name.
        /// </summary>
        /// <value>
        /// The first name.
        /// </value>
        public string? FirstName { get; private set; }

        /// <summary>
        /// Gets the last name.
        /// </summary>
        /// <value>
        /// The last name.
        /// </value>
        public string? LastName { get; private set; }

        /// <summary>
        /// Gets the date of birth.
        /// </summary>
        /// <value>
        /// The date of birth.
        /// </value>
        public DateTime? DateOfBirth { get; private set; } 

        /// <summary>
        /// Creates the specified first name.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        /// <param name="dateOfBirth">The date of birth.</param>
        /// <param name="city">The city.</param>
        /// <param name="postalCode">The postal code.</param>
        /// <param name="street">The street.</param>
        /// <returns></returns>
        public static Employee Create(string? firstName, string? lastName, DateTime? dateOfBirth) =>
           new(firstName, lastName, dateOfBirth);
    }
}
