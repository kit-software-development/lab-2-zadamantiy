namespace Practice.Organization
{
    /// <summary>
    ///     Скрытая реализация представления об отделе предприятия.
    /// </summary>
    internal struct Department : IDepartment
    {
        /*
         * TODO #2: Реализуйте интерфейс IDepartment для структуры Department
         */

        public Department(string department) : this()
        {
            Name = department;
        }

        public string Name { get; private set; }
    }
}
