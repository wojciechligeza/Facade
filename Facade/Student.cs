namespace Facade
{
    class Student
    {
        private string _name;

        public Student(string name)
        {
            _name = name;
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }
    }
}
