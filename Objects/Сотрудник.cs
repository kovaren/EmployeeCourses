﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.18408
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.EmployeeCourses
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Сотрудник.
    /// </summary>
    // *** Start programmer edit section *** (Сотрудник CustomAttributes)

    // *** End programmer edit section *** (Сотрудник CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("СотрудникE", new string[] {
            "Фамилия as \'Фамилия\'",
            "Имя as \'Имя\'",
            "Отчество as \'Отчество\'",
            "ДатаРождения as \'Дата рождения\'",
            "Должность as \'Должность\'",
            "Телефон as \'Телефон\'",
            "Email as \'Email\'"})]
    [View("СотрудникL", new string[] {
            "ТабельныйНомер as \'Табельный номер\'",
            "Фамилия as \'Фамилия\'",
            "Имя as \'Имя\'",
            "ДатаРождения as \'Дата рождения\'",
            "Отчество as \'Отчество\'",
            "Должность as \'Должность\'",
            "Телефон as \'Телефон\'",
            "Email as \'Email\'"})]
    public class Сотрудник : ICSSoft.STORMNET.DataObject
    {
        
        private int fТабельныйНомер;
        
        private string fФамилия;
        
        private string fИмя;
        
        private string fОтчество;
        
        private System.DateTime fДатаРождения = System.DateTime.Parse("01.01.1985");
        
        private IIS.EmployeeCourses.Должность fДолжность;
        
        private string fТелефон;
        
        private string fEmail;
        
        // *** Start programmer edit section *** (Сотрудник CustomMembers)

        // *** End programmer edit section *** (Сотрудник CustomMembers)

        
        /// <summary>
        /// ТабельныйНомер.
        /// </summary>
        // *** Start programmer edit section *** (Сотрудник.ТабельныйНомер CustomAttributes)

        // *** End programmer edit section *** (Сотрудник.ТабельныйНомер CustomAttributes)
        [DisableInsertProperty(true)]
        [NotNull()]
        public virtual int ТабельныйНомер
        {
            get
            {
                // *** Start programmer edit section *** (Сотрудник.ТабельныйНомер Get start)

                // *** End programmer edit section *** (Сотрудник.ТабельныйНомер Get start)
                int result = this.fТабельныйНомер;
                // *** Start programmer edit section *** (Сотрудник.ТабельныйНомер Get end)

                // *** End programmer edit section *** (Сотрудник.ТабельныйНомер Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Сотрудник.ТабельныйНомер Set start)

                // *** End programmer edit section *** (Сотрудник.ТабельныйНомер Set start)
                this.fТабельныйНомер = value;
                // *** Start programmer edit section *** (Сотрудник.ТабельныйНомер Set end)

                // *** End programmer edit section *** (Сотрудник.ТабельныйНомер Set end)
            }
        }
        
        /// <summary>
        /// Фамилия.
        /// </summary>
        // *** Start programmer edit section *** (Сотрудник.Фамилия CustomAttributes)

        // *** End programmer edit section *** (Сотрудник.Фамилия CustomAttributes)
        [StrLen(255)]
        [NotNull()]
        public virtual string Фамилия
        {
            get
            {
                // *** Start programmer edit section *** (Сотрудник.Фамилия Get start)

                // *** End programmer edit section *** (Сотрудник.Фамилия Get start)
                string result = this.fФамилия;
                // *** Start programmer edit section *** (Сотрудник.Фамилия Get end)

                // *** End programmer edit section *** (Сотрудник.Фамилия Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Сотрудник.Фамилия Set start)

                // *** End programmer edit section *** (Сотрудник.Фамилия Set start)
                this.fФамилия = value;
                // *** Start programmer edit section *** (Сотрудник.Фамилия Set end)

                // *** End programmer edit section *** (Сотрудник.Фамилия Set end)
            }
        }
        
        /// <summary>
        /// Имя.
        /// </summary>
        // *** Start programmer edit section *** (Сотрудник.Имя CustomAttributes)

        // *** End programmer edit section *** (Сотрудник.Имя CustomAttributes)
        [StrLen(255)]
        [NotNull()]
        public virtual string Имя
        {
            get
            {
                // *** Start programmer edit section *** (Сотрудник.Имя Get start)

                // *** End programmer edit section *** (Сотрудник.Имя Get start)
                string result = this.fИмя;
                // *** Start programmer edit section *** (Сотрудник.Имя Get end)

                // *** End programmer edit section *** (Сотрудник.Имя Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Сотрудник.Имя Set start)

                // *** End programmer edit section *** (Сотрудник.Имя Set start)
                this.fИмя = value;
                // *** Start programmer edit section *** (Сотрудник.Имя Set end)

                // *** End programmer edit section *** (Сотрудник.Имя Set end)
            }
        }
        
        /// <summary>
        /// Отчество.
        /// </summary>
        // *** Start programmer edit section *** (Сотрудник.Отчество CustomAttributes)

        // *** End programmer edit section *** (Сотрудник.Отчество CustomAttributes)
        [StrLen(255)]
        [NotNull()]
        public virtual string Отчество
        {
            get
            {
                // *** Start programmer edit section *** (Сотрудник.Отчество Get start)

                // *** End programmer edit section *** (Сотрудник.Отчество Get start)
                string result = this.fОтчество;
                // *** Start programmer edit section *** (Сотрудник.Отчество Get end)

                // *** End programmer edit section *** (Сотрудник.Отчество Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Сотрудник.Отчество Set start)

                // *** End programmer edit section *** (Сотрудник.Отчество Set start)
                this.fОтчество = value;
                // *** Start programmer edit section *** (Сотрудник.Отчество Set end)

                // *** End programmer edit section *** (Сотрудник.Отчество Set end)
            }
        }
        
        /// <summary>
        /// ДатаРождения.
        /// </summary>
        // *** Start programmer edit section *** (Сотрудник.ДатаРождения CustomAttributes)

        // *** End programmer edit section *** (Сотрудник.ДатаРождения CustomAttributes)
        [NotNull()]
        public virtual System.DateTime ДатаРождения
        {
            get
            {
                // *** Start programmer edit section *** (Сотрудник.ДатаРождения Get start)

                // *** End programmer edit section *** (Сотрудник.ДатаРождения Get start)
                System.DateTime result = this.fДатаРождения;
                // *** Start programmer edit section *** (Сотрудник.ДатаРождения Get end)

                // *** End programmer edit section *** (Сотрудник.ДатаРождения Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Сотрудник.ДатаРождения Set start)

                // *** End programmer edit section *** (Сотрудник.ДатаРождения Set start)
                this.fДатаРождения = value;
                // *** Start programmer edit section *** (Сотрудник.ДатаРождения Set end)

                // *** End programmer edit section *** (Сотрудник.ДатаРождения Set end)
            }
        }
        
        /// <summary>
        /// Должность.
        /// </summary>
        // *** Start programmer edit section *** (Сотрудник.Должность CustomAttributes)

        // *** End programmer edit section *** (Сотрудник.Должность CustomAttributes)
        [NotNull()]
        public virtual IIS.EmployeeCourses.Должность Должность
        {
            get
            {
                // *** Start programmer edit section *** (Сотрудник.Должность Get start)

                // *** End programmer edit section *** (Сотрудник.Должность Get start)
                IIS.EmployeeCourses.Должность result = this.fДолжность;
                // *** Start programmer edit section *** (Сотрудник.Должность Get end)

                // *** End programmer edit section *** (Сотрудник.Должность Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Сотрудник.Должность Set start)

                // *** End programmer edit section *** (Сотрудник.Должность Set start)
                this.fДолжность = value;
                // *** Start programmer edit section *** (Сотрудник.Должность Set end)

                // *** End programmer edit section *** (Сотрудник.Должность Set end)
            }
        }
        
        /// <summary>
        /// Телефон.
        /// </summary>
        // *** Start programmer edit section *** (Сотрудник.Телефон CustomAttributes)

        // *** End programmer edit section *** (Сотрудник.Телефон CustomAttributes)
        [StrLen(255)]
        public virtual string Телефон
        {
            get
            {
                // *** Start programmer edit section *** (Сотрудник.Телефон Get start)

                // *** End programmer edit section *** (Сотрудник.Телефон Get start)
                string result = this.fТелефон;
                // *** Start programmer edit section *** (Сотрудник.Телефон Get end)

                // *** End programmer edit section *** (Сотрудник.Телефон Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Сотрудник.Телефон Set start)

                // *** End programmer edit section *** (Сотрудник.Телефон Set start)
                this.fТелефон = value;
                // *** Start programmer edit section *** (Сотрудник.Телефон Set end)

                // *** End programmer edit section *** (Сотрудник.Телефон Set end)
            }
        }
        
        /// <summary>
        /// Email.
        /// </summary>
        // *** Start programmer edit section *** (Сотрудник.Email CustomAttributes)

        // *** End programmer edit section *** (Сотрудник.Email CustomAttributes)
        [StrLen(255)]
        public virtual string Email
        {
            get
            {
                // *** Start programmer edit section *** (Сотрудник.Email Get start)

                // *** End programmer edit section *** (Сотрудник.Email Get start)
                string result = this.fEmail;
                // *** Start programmer edit section *** (Сотрудник.Email Get end)

                // *** End programmer edit section *** (Сотрудник.Email Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Сотрудник.Email Set start)

                // *** End programmer edit section *** (Сотрудник.Email Set start)
                this.fEmail = value;
                // *** Start programmer edit section *** (Сотрудник.Email Set end)

                // *** End programmer edit section *** (Сотрудник.Email Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "СотрудникE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View СотрудникE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("СотрудникE", typeof(IIS.EmployeeCourses.Сотрудник));
                }
            }
            
            /// <summary>
            /// "СотрудникL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View СотрудникL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("СотрудникL", typeof(IIS.EmployeeCourses.Сотрудник));
                }
            }
        }
    }
}
