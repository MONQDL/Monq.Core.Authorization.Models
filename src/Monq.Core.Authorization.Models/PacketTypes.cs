﻿namespace Monq.Core.Authorization.Models
{
    /// <summary>
    /// Тип пакета.
    /// </summary>
    public enum PacketTypes
    {
        /// <summary>
        /// Неизвестный тип роли.
        /// </summary>
        Unknown = 0,
        /// <summary>
        /// Системная роль "Менеджер".
        /// </summary>
        Manager = 1,
        /// <summary>
        /// Системная роль "Пользователь".
        /// </summary>
        User = 2,
        /// <summary>
        /// Системная роль "Администратор пространства для чтения",
        /// обладание которой предоставляет доступ на чтение всех сущностей рабочих групп пространства.
        /// </summary>
        UserspaceAdminReader = 3,
        /// <summary>
        /// Пользовательская роль.
        /// </summary>
        Custom = 4,
        /// <summary>
        /// Системная роль "Администратор пространства для записи",
        /// обладание которой предоставляет доступ на запись всех сущностей рабочих групп пространства.
        /// </summary>
        UserspaceAdminWriter = 5,
        /// <summary>
        /// Специальная системная роль, которая содержит набор прав управления системой,
        /// без доступа к объектам рабочих групп.
        /// </summary>
        UserspaceAdmin = 6,
    }
}
