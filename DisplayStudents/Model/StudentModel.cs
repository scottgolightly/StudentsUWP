namespace DisplayStudents.Model
{
    public class StudentModel
    {
        /// <summary>
        /// Gets or sets an identifier for the student.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the student's full name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the year in school. For high school students this will be 10-12 
        /// but we are not validating this to keep the demo simple.
        /// </summary>
        public int YearInSchool { get; set; }

        /// <summary>
        /// Gets or sets the grade point average.
        /// </summary>
        public decimal Gpa { get; set; }

        /// <summary>
        /// Get a string representation of the class.
        /// </summary>
        /// <returns>A string with the properties from this class.</returns>
        public override string ToString()
        {
            return $"{Id}|{Name}|{YearInSchool}|{Gpa}";
        }
    }
}
