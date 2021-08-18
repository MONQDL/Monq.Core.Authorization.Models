using System;
using System.Collections.Generic;

namespace Monq.Core.Authorization.Models
{
    /// <summary>
    /// Модель представления владельцев пакета пользовательских прав.
    /// </summary>
    public sealed class PacketOwnerViewModel
    {
        /// <summary>
        /// Идентификатор пакета прав.
        /// </summary>
        public long PacketId { get; set; }

        /// <summary>
        /// Идентификатор рабочей группы-владельца пакета.
        /// </summary>
        public long WorkGroupId { get; set; }

        /// <summary>
        /// Идентификатор пользовательского пространства.
        /// </summary>
        public long UserspaceId { get; set; }

        /// <summary>
        /// Коллекция идентификаторов пользователей пакета.
        /// </summary>
        public IEnumerable<long> Users { get; set; } = Array.Empty<long>();
    }
}
