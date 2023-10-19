namespace Monq.Core.Authorization.Models
{
    /// <summary>
    /// Тип пакета.
    /// </summary>
    public enum PacketTypes
    {
        /// <summary>
        /// Администратор пространства.
        /// </summary>
        UserspaceAdmin,

        /// <summary>
        /// Пользователь пространства.
        /// </summary>
        UserspaceUser,

        /// <summary>
        /// Менеджер РГ.
        /// </summary>
        WorkgroupManager,

        /// <summary>
        /// Пользователь РГ.
        /// </summary>
        WorkgroupUser,

        /// <summary>
        /// Менеджер РГ "Администраторы пространства".
        /// </summary>
        UserspaceManager,

        /// <summary>
        /// Пакет, созданный пользователем в рабочей группе.
        /// </summary>
        WorkgroupCustom,

        /// <summary>
        /// Пакет, созданный пользователем в группе администраторов пространства.
        /// </summary>
        UserspaceCustom,
    }
}
