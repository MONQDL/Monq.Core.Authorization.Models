using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Monq.Core.Authorization.Models
{
    /// <summary>
    /// Модель представления пакета пользовательских прав.
    /// </summary>
    public sealed class PacketViewModel
    {
        /// <summary>
        /// Идентификатор пакета пользовательских прав.
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Имя пакета пользовательских прав.
        /// </summary>
        public string Name { get; set; } = default!;

        /// <summary>
        /// Описание пакета пользовательских прав.
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Является ли пакет доступным только для чтения.
        /// </summary>
        public bool IsReadOnly { get; set; }

        /// <summary>
        /// Коллекция прав доступа пакета.
        /// </summary>
        public IEnumerable<string> Grants { get; set; } = Array.Empty<string>();

        /// <summary>
        /// Коллекция владельцев пакета.
        /// </summary>
        public IEnumerable<PacketOwnerViewModel> Owners { get; set; } = Array.Empty<PacketOwnerViewModel>();

        /// <summary>
        /// Тип пакета - пакет рабочей группы или пакет пространства.
        /// </summary>
        public PacketTypes PacketType { get; set; }
    }
}
