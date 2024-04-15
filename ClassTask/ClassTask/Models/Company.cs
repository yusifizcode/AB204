namespace ClassTask.Models
{
    internal class Company
    {
        Developer[] _developers = { };
        private Manager[] _managers = { };

        public void AddDeveloper(Developer developer)
        {
            AddEntity(ref _developers, developer);
        }

        public void AddManager(Manager manager)
        {
            Array.Resize(ref _managers, _managers.Length + 1);
            _managers[_managers.Length - 1] = manager;
        }

        public Developer[] GetAllDevelopersBySalary(int minSalary, int maxSalary)
        {
            Developer[] filteredDevelopers = { };
            for (int i = 0; i < _developers.Length; i++)
            {
                if (_developers[i].Salary >= minSalary && _developers[i].Salary <= maxSalary)
                {
                    AddEntity(ref filteredDevelopers, _developers[i]);
                }
            }

            return filteredDevelopers;
        }

        public void AddEntity(ref Developer[] developers, Developer developer)
        {
            Array.Resize(ref developers, developers.Length + 1);
            developers[developers.Length - 1] = developer;
        }
    }
}
