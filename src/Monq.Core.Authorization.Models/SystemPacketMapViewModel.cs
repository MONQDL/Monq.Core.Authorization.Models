namespace Monq.Core.Authorization.Models
{
    /// <summary>
    /// Представление модели соответствия системных пакетов прав.
    /// </summary>
    public sealed class SystemPacketMapViewModel
    {
        /// <summary>
        /// Идентификатор записи соответствия.
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Идентификатор пространства.
        /// </summary>
        public long UserspaceId { get; set; }

        /// <summary>
        /// Идентификатор системного пакета.
        /// </summary>
        public long PacketId { get; set; }

        /// <summary>
        /// Тип пакета.
        /// </summary>
        public PacketTypes PacketType { get; set; }
    }
}
