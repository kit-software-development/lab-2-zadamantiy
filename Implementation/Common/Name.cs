namespace Practice.Common
{
    /// <summary>
    ///     Скрытая реализация представления об имени человека.
    /// </summary>
    internal struct Name : IName
    {
        /*
         * TODO #1: Реализуйте интерфейс IName для структуры Name
         */

        public Name(string surname, string firstname, string patronymic) : this()
        {
            Surname = surname;
            FirstName = firstname;
            Patronymic = patronymic;

            FullName  = surname 
                      + " " 
                      + firstname 
                      + " " 
                      + patronymic;

            ShortName = surname 
                      + " " 
                      + firstname.Substring(0, 1) 
                      + "." 
                      + patronymic.Substring(0, 1) 
                      + ".";
        }

        public Name(IName name) : this()
        {
            FullName = name.FullName;
            ShortName = name.ShortName;
            var tmp = name.FullName.Split(' ');
            Surname = tmp[0];
            FirstName = tmp[1];
            Patronymic = tmp[2];
        }

        /// <summary>
        ///     Имя.
        /// </summary>
        public string FirstName { get; private set; }
        
        /// <summary>
        ///     Фамилия.
        /// </summary>
        public string Surname { get; private set; }
        
        /// <summary>
        ///     Отчество.
        /// </summary>
        public string Patronymic { get; private set; }

        /// <summary>
        ///     Полное имя.
        /// </summary>
        public string FullName { get; private set; }

        /// <summary>
        ///     Краткое имя.
        /// </summary>
        public string ShortName { get; private set; }
    }
}
