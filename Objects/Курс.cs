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
    /// Курс.
    /// </summary>
    // *** Start programmer edit section *** (Курс CustomAttributes)

    // *** End programmer edit section *** (Курс CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("КурсE", new string[] {
            "Название as \'Название\'",
            "ДатаНачала as \'Дата начала\'",
            "ДатаКонца as \'Дата конца\'",
            "Тип as \'Тип\'",
            "Очный as \'Очный\'",
            "Категория as \'Категория\'",
            "Описание as \'Описание\'",
            "Стоимость as \'Стоимость\'",
            "МестоПроведения as \'Место проведения\'"})]
    [AssociatedDetailViewAttribute("КурсE", "Занятие", "ЗанятиеE", true, "", "Занятие", true, new string[] {
            ""})]
    [View("КурсL", new string[] {
            "Название as \'Название\'",
            "ДатаНачала as \'Дата начала\'",
            "ДатаКонца as \'Дата конца\'",
            "Тип as \'Тип\'",
            "Очный as \'Очный\'",
            "Категория as \'Категория\'",
            "Описание as \'Описание\'",
            "Стоимость as \'Стоимость\'",
            "МестоПроведения as \'Место проведения\'"})]
    [View("CoursesView", new string[] {
            "Название as \'Название\'",
            "ДатаНачала as \'Дата начала\'",
            "ДатаКонца as \'Дата конца\'",
            "Тип as \'Тип\'",
            "Очный as \'Очный\'",
            "Категория as \'Категория\'",
            "Описание as \'Описание\'",
            "Стоимость as \'Стоимость\'",
            "МестоПроведения as \'Место проведения\'"})]
    [View("MyCoursesL", new string[] {
            "Название as \'Название\'",
            "ДатаНачала as \'Дата начала\'",
            "ДатаКонца as \'Дата конца\'",
            "Тип as \'Тип\'",
            "Очный as \'Очный\'",
            "Категория as \'Категория\'",
            "Описание as \'Описание\'",
            "Стоимость as \'Стоимость\'",
            "МестоПроведения as \'Место проведения\'"})]
    [View("MyCoursesE", new string[] {
            "Название as \'Название\'",
            "ДатаНачала as \'Дата начала\'",
            "ДатаКонца as \'Дата конца\'",
            "Тип as \'Тип\'",
            "Очный as \'Очный\'",
            "Категория as \'Категория\'",
            "Описание as \'Описание\'",
            "Стоимость as \'Стоимость\'",
            "МестоПроведения as \'Место проведения\'"})]
    public class Курс : ICSSoft.STORMNET.DataObject
    {
        
        private string fНазвание;
        
        private System.DateTime fДатаНачала;
        
        private System.DateTime fДатаКонца;
        
        private IIS.EmployeeCourses.ТипКурса fТип;
        
        private bool fОчный;
        
        private IIS.EmployeeCourses.Категория fКатегория;
        
        private string fОписание;
        
        private double fСтоимость;
        
        private string fМестоПроведения;
        
        private IIS.EmployeeCourses.DetailArrayOfЗанятие fЗанятие;
        
        // *** Start programmer edit section *** (Курс CustomMembers)

        // *** End programmer edit section *** (Курс CustomMembers)

        
        /// <summary>
        /// Название.
        /// </summary>
        // *** Start programmer edit section *** (Курс.Название CustomAttributes)

        // *** End programmer edit section *** (Курс.Название CustomAttributes)
        [StrLen(255)]
        [NotNull()]
        public virtual string Название
        {
            get
            {
                // *** Start programmer edit section *** (Курс.Название Get start)

                // *** End programmer edit section *** (Курс.Название Get start)
                string result = this.fНазвание;
                // *** Start programmer edit section *** (Курс.Название Get end)

                // *** End programmer edit section *** (Курс.Название Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Курс.Название Set start)

                // *** End programmer edit section *** (Курс.Название Set start)
                this.fНазвание = value;
                // *** Start programmer edit section *** (Курс.Название Set end)

                // *** End programmer edit section *** (Курс.Название Set end)
            }
        }
        
        /// <summary>
        /// ДатаНачала.
        /// </summary>
        // *** Start programmer edit section *** (Курс.ДатаНачала CustomAttributes)

        // *** End programmer edit section *** (Курс.ДатаНачала CustomAttributes)
        [NotNull()]
        public virtual System.DateTime ДатаНачала
        {
            get
            {
                // *** Start programmer edit section *** (Курс.ДатаНачала Get start)

                // *** End programmer edit section *** (Курс.ДатаНачала Get start)
                System.DateTime result = this.fДатаНачала;
                // *** Start programmer edit section *** (Курс.ДатаНачала Get end)

                // *** End programmer edit section *** (Курс.ДатаНачала Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Курс.ДатаНачала Set start)

                // *** End programmer edit section *** (Курс.ДатаНачала Set start)
                this.fДатаНачала = value;
                // *** Start programmer edit section *** (Курс.ДатаНачала Set end)

                // *** End programmer edit section *** (Курс.ДатаНачала Set end)
            }
        }
        
        /// <summary>
        /// ДатаКонца.
        /// </summary>
        // *** Start programmer edit section *** (Курс.ДатаКонца CustomAttributes)

        // *** End programmer edit section *** (Курс.ДатаКонца CustomAttributes)
        [NotNull()]
        public virtual System.DateTime ДатаКонца
        {
            get
            {
                // *** Start programmer edit section *** (Курс.ДатаКонца Get start)

                // *** End programmer edit section *** (Курс.ДатаКонца Get start)
                System.DateTime result = this.fДатаКонца;
                // *** Start programmer edit section *** (Курс.ДатаКонца Get end)

                // *** End programmer edit section *** (Курс.ДатаКонца Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Курс.ДатаКонца Set start)

                // *** End programmer edit section *** (Курс.ДатаКонца Set start)
                this.fДатаКонца = value;
                // *** Start programmer edit section *** (Курс.ДатаКонца Set end)

                // *** End programmer edit section *** (Курс.ДатаКонца Set end)
            }
        }
        
        /// <summary>
        /// Тип.
        /// </summary>
        // *** Start programmer edit section *** (Курс.Тип CustomAttributes)

        // *** End programmer edit section *** (Курс.Тип CustomAttributes)
        [NotNull()]
        public virtual IIS.EmployeeCourses.ТипКурса Тип
        {
            get
            {
                // *** Start programmer edit section *** (Курс.Тип Get start)

                // *** End programmer edit section *** (Курс.Тип Get start)
                IIS.EmployeeCourses.ТипКурса result = this.fТип;
                // *** Start programmer edit section *** (Курс.Тип Get end)

                // *** End programmer edit section *** (Курс.Тип Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Курс.Тип Set start)

                // *** End programmer edit section *** (Курс.Тип Set start)
                this.fТип = value;
                // *** Start programmer edit section *** (Курс.Тип Set end)

                // *** End programmer edit section *** (Курс.Тип Set end)
            }
        }
        
        /// <summary>
        /// Очный.
        /// </summary>
        // *** Start programmer edit section *** (Курс.Очный CustomAttributes)

        // *** End programmer edit section *** (Курс.Очный CustomAttributes)
        public virtual bool Очный
        {
            get
            {
                // *** Start programmer edit section *** (Курс.Очный Get start)

                // *** End programmer edit section *** (Курс.Очный Get start)
                bool result = this.fОчный;
                // *** Start programmer edit section *** (Курс.Очный Get end)

                // *** End programmer edit section *** (Курс.Очный Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Курс.Очный Set start)

                // *** End programmer edit section *** (Курс.Очный Set start)
                this.fОчный = value;
                // *** Start programmer edit section *** (Курс.Очный Set end)

                // *** End programmer edit section *** (Курс.Очный Set end)
            }
        }
        
        /// <summary>
        /// Категория.
        /// </summary>
        // *** Start programmer edit section *** (Курс.Категория CustomAttributes)

        // *** End programmer edit section *** (Курс.Категория CustomAttributes)
        [NotNull()]
        public virtual IIS.EmployeeCourses.Категория Категория
        {
            get
            {
                // *** Start programmer edit section *** (Курс.Категория Get start)

                // *** End programmer edit section *** (Курс.Категория Get start)
                IIS.EmployeeCourses.Категория result = this.fКатегория;
                // *** Start programmer edit section *** (Курс.Категория Get end)

                // *** End programmer edit section *** (Курс.Категория Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Курс.Категория Set start)

                // *** End programmer edit section *** (Курс.Категория Set start)
                this.fКатегория = value;
                // *** Start programmer edit section *** (Курс.Категория Set end)

                // *** End programmer edit section *** (Курс.Категория Set end)
            }
        }
        
        /// <summary>
        /// Описание.
        /// </summary>
        // *** Start programmer edit section *** (Курс.Описание CustomAttributes)

        // *** End programmer edit section *** (Курс.Описание CustomAttributes)
        [StrLen(255)]
        public virtual string Описание
        {
            get
            {
                // *** Start programmer edit section *** (Курс.Описание Get start)

                // *** End programmer edit section *** (Курс.Описание Get start)
                string result = this.fОписание;
                // *** Start programmer edit section *** (Курс.Описание Get end)

                // *** End programmer edit section *** (Курс.Описание Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Курс.Описание Set start)

                // *** End programmer edit section *** (Курс.Описание Set start)
                this.fОписание = value;
                // *** Start programmer edit section *** (Курс.Описание Set end)

                // *** End programmer edit section *** (Курс.Описание Set end)
            }
        }
        
        /// <summary>
        /// Стоимость.
        /// </summary>
        // *** Start programmer edit section *** (Курс.Стоимость CustomAttributes)

        // *** End programmer edit section *** (Курс.Стоимость CustomAttributes)
        [NotNull()]
        public virtual double Стоимость
        {
            get
            {
                // *** Start programmer edit section *** (Курс.Стоимость Get start)

                // *** End programmer edit section *** (Курс.Стоимость Get start)
                double result = this.fСтоимость;
                // *** Start programmer edit section *** (Курс.Стоимость Get end)

                // *** End programmer edit section *** (Курс.Стоимость Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Курс.Стоимость Set start)

                // *** End programmer edit section *** (Курс.Стоимость Set start)
                this.fСтоимость = value;
                // *** Start programmer edit section *** (Курс.Стоимость Set end)

                // *** End programmer edit section *** (Курс.Стоимость Set end)
            }
        }
        
        /// <summary>
        /// МестоПроведения.
        /// </summary>
        // *** Start programmer edit section *** (Курс.МестоПроведения CustomAttributes)

        // *** End programmer edit section *** (Курс.МестоПроведения CustomAttributes)
        [StrLen(255)]
        [NotNull()]
        public virtual string МестоПроведения
        {
            get
            {
                // *** Start programmer edit section *** (Курс.МестоПроведения Get start)

                // *** End programmer edit section *** (Курс.МестоПроведения Get start)
                string result = this.fМестоПроведения;
                // *** Start programmer edit section *** (Курс.МестоПроведения Get end)

                // *** End programmer edit section *** (Курс.МестоПроведения Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Курс.МестоПроведения Set start)

                // *** End programmer edit section *** (Курс.МестоПроведения Set start)
                this.fМестоПроведения = value;
                // *** Start programmer edit section *** (Курс.МестоПроведения Set end)

                // *** End programmer edit section *** (Курс.МестоПроведения Set end)
            }
        }
        
        /// <summary>
        /// Курс.
        /// </summary>
        // *** Start programmer edit section *** (Курс.Занятие CustomAttributes)

        // *** End programmer edit section *** (Курс.Занятие CustomAttributes)
        public virtual IIS.EmployeeCourses.DetailArrayOfЗанятие Занятие
        {
            get
            {
                // *** Start programmer edit section *** (Курс.Занятие Get start)

                // *** End programmer edit section *** (Курс.Занятие Get start)
                if ((this.fЗанятие == null))
                {
                    this.fЗанятие = new IIS.EmployeeCourses.DetailArrayOfЗанятие(this);
                }
                IIS.EmployeeCourses.DetailArrayOfЗанятие result = this.fЗанятие;
                // *** Start programmer edit section *** (Курс.Занятие Get end)

                // *** End programmer edit section *** (Курс.Занятие Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Курс.Занятие Set start)

                // *** End programmer edit section *** (Курс.Занятие Set start)
                this.fЗанятие = value;
                // *** Start programmer edit section *** (Курс.Занятие Set end)

                // *** End programmer edit section *** (Курс.Занятие Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "КурсE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View КурсE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("КурсE", typeof(IIS.EmployeeCourses.Курс));
                }
            }
            
            /// <summary>
            /// "КурсL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View КурсL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("КурсL", typeof(IIS.EmployeeCourses.Курс));
                }
            }

            public static ICSSoft.STORMNET.View CoursesView
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("CoursesView", typeof(IIS.EmployeeCourses.Курс));
                }
            }
            public static ICSSoft.STORMNET.View MyCoursesL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("MyCoursesL", typeof(IIS.EmployeeCourses.Курс));
                }
            }
            public static ICSSoft.STORMNET.View MyCoursesE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("MyCoursesE", typeof(IIS.EmployeeCourses.Курс));
                }
            }
        }
    }
}
