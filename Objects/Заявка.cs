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
    /// Заявка.
    /// </summary>
    // *** Start programmer edit section *** (Заявка CustomAttributes)

    // *** End programmer edit section *** (Заявка CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("ЗаявкаE", new string[] {
            "Сотрудник as \'Сотрудник\'",
            "Сотрудник.Фамилия as \'Фамилия\'",
            "Курс as \'Курс\'",
            "Курс.Название as \'Название\'",
            "Примечание as \'Примечание\'"})]
    [View("ЗаявкаL", new string[] {
            "Сотрудник.Фамилия as \'Фамилия\'",
            "Курс.Название as \'Название\'",
            "Примечание as \'Примечание\'"})]
    public class Заявка : ICSSoft.STORMNET.DataObject
    {
        
        private string fПримечание;
        
        private IIS.EmployeeCourses.СтатусЗаявки fСтатус;
        
        private IIS.EmployeeCourses.Сотрудник fСотрудник;
        
        private IIS.EmployeeCourses.Курс fКурс;
        
        // *** Start programmer edit section *** (Заявка CustomMembers)

        // *** End programmer edit section *** (Заявка CustomMembers)

        
        /// <summary>
        /// Примечание.
        /// </summary>
        // *** Start programmer edit section *** (Заявка.Примечание CustomAttributes)

        // *** End programmer edit section *** (Заявка.Примечание CustomAttributes)
        [StrLen(255)]
        public virtual string Примечание
        {
            get
            {
                // *** Start programmer edit section *** (Заявка.Примечание Get start)

                // *** End programmer edit section *** (Заявка.Примечание Get start)
                string result = this.fПримечание;
                // *** Start programmer edit section *** (Заявка.Примечание Get end)

                // *** End programmer edit section *** (Заявка.Примечание Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Заявка.Примечание Set start)

                // *** End programmer edit section *** (Заявка.Примечание Set start)
                this.fПримечание = value;
                // *** Start programmer edit section *** (Заявка.Примечание Set end)

                // *** End programmer edit section *** (Заявка.Примечание Set end)
            }
        }
        
        /// <summary>
        /// Статус.
        /// </summary>
        // *** Start programmer edit section *** (Заявка.Статус CustomAttributes)

        // *** End programmer edit section *** (Заявка.Статус CustomAttributes)
        public virtual IIS.EmployeeCourses.СтатусЗаявки Статус
        {
            get
            {
                // *** Start programmer edit section *** (Заявка.Статус Get start)

                // *** End programmer edit section *** (Заявка.Статус Get start)
                IIS.EmployeeCourses.СтатусЗаявки result = this.fСтатус;
                // *** Start programmer edit section *** (Заявка.Статус Get end)

                // *** End programmer edit section *** (Заявка.Статус Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Заявка.Статус Set start)

                // *** End programmer edit section *** (Заявка.Статус Set start)
                this.fСтатус = value;
                // *** Start programmer edit section *** (Заявка.Статус Set end)

                // *** End programmer edit section *** (Заявка.Статус Set end)
            }
        }
        
        /// <summary>
        /// Заявка.
        /// </summary>
        // *** Start programmer edit section *** (Заявка.Сотрудник CustomAttributes)

        // *** End programmer edit section *** (Заявка.Сотрудник CustomAttributes)
        [PropertyStorage(new string[] {
                "Сотрудник"})]
        [NotNull()]
        public virtual IIS.EmployeeCourses.Сотрудник Сотрудник
        {
            get
            {
                // *** Start programmer edit section *** (Заявка.Сотрудник Get start)

                // *** End programmer edit section *** (Заявка.Сотрудник Get start)
                IIS.EmployeeCourses.Сотрудник result = this.fСотрудник;
                // *** Start programmer edit section *** (Заявка.Сотрудник Get end)

                // *** End programmer edit section *** (Заявка.Сотрудник Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Заявка.Сотрудник Set start)

                // *** End programmer edit section *** (Заявка.Сотрудник Set start)
                this.fСотрудник = value;
                // *** Start programmer edit section *** (Заявка.Сотрудник Set end)

                // *** End programmer edit section *** (Заявка.Сотрудник Set end)
            }
        }
        
        /// <summary>
        /// Заявка.
        /// </summary>
        // *** Start programmer edit section *** (Заявка.Курс CustomAttributes)

        // *** End programmer edit section *** (Заявка.Курс CustomAttributes)
        [PropertyStorage(new string[] {
                "Курс"})]
        [NotNull()]
        public virtual IIS.EmployeeCourses.Курс Курс
        {
            get
            {
                // *** Start programmer edit section *** (Заявка.Курс Get start)

                // *** End programmer edit section *** (Заявка.Курс Get start)
                IIS.EmployeeCourses.Курс result = this.fКурс;
                // *** Start programmer edit section *** (Заявка.Курс Get end)

                // *** End programmer edit section *** (Заявка.Курс Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Заявка.Курс Set start)

                // *** End programmer edit section *** (Заявка.Курс Set start)
                this.fКурс = value;
                // *** Start programmer edit section *** (Заявка.Курс Set end)

                // *** End programmer edit section *** (Заявка.Курс Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "ЗаявкаE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ЗаявкаE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ЗаявкаE", typeof(IIS.EmployeeCourses.Заявка));
                }
            }
            
            /// <summary>
            /// "ЗаявкаL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ЗаявкаL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ЗаявкаL", typeof(IIS.EmployeeCourses.Заявка));
                }
            }
        }
    }
}
