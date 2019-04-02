using Practice.Common;
using Practice.Organization;

namespace Practice.HR
{
    /// <summary>
    ///     Класс-фабрика, позволяющий получать экземпляры типов,
    ///     инкапсулированных на уровне библиотеки.
    /// </summary>
    public static class Builders
    {
        /// <summary>
        ///     Возвращает экземпляр "Строителя" клиентов.
        /// </summary>
        /// <returns>
        ///     Экземпляр типа IClientBuilder.
        /// </returns>
        public static IClientBuilder ClientBuilder()
        {
            /*
             * TODO #6: Реализовать фабричный метод ClientBuilder класса Builders
             */

            return new IntClientBuilder();
        }

        internal class IntClientBuilder : IClientBuilder
        {
            private readonly IClient _client = new Client();

            public IClient Build()
            {
                return _client;
            }

            public IClientBuilder Name(IName name)
            {
                _client.Name = new Name(name);
                return this;
            }

            public IClientBuilder Name(string surname, string firstname, string patronymic)
            {
                _client.Name = new Name(surname, firstname, patronymic);
                return this;
            }

            public IClientBuilder Discount(float discount)
            {
                _client.Discount = discount;
                return this;
            }
        }

        /// <summary>
        ///     Возвращает экземпляр "Строителя" сотудников.
        /// </summary>
        /// <returns>
        ///     Возвращает экземпляр типа IEmployeeBuilder.
        /// </returns>
        public static IEmployeeBuilder EmployeeBuilder()
        {
            /*
             * TODO #7: Реализовать фабричный метод EmployeeBuilder класса Builders
             */

            return new IntEmployeeBuilder();
        }

        internal class IntEmployeeBuilder : IEmployeeBuilder
        {
            private readonly Employee _employee = new Employee();

            public IEmployee Build()
            {
                return _employee;
            }

            public IEmployeeBuilder Name(IName name)
            {
                _employee.Name = new Name(name);
                return this;
            }

            public IEmployeeBuilder Name(string surname, string firstname, string patronymic)
            {
                _employee.Name = new Name(surname, firstname, patronymic);
                return this;
            }

            public IEmployeeBuilder Department(IDepartment department)
            {
                _employee.Department = department;
                return this;
            }

            public IEmployeeBuilder Department(string department)
            {
                _employee.Department = new Department(department);
                return this;
            }
        }
    }
}
