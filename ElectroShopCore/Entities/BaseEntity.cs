
namespace ElectroShopCore.Entities
{
    /// <summary>
    /// Базовый абсрактный класс для сущностей
    /// </summary>
    internal abstract class BaseEntity
    {
        public virtual int Id { get; protected set; }
    }
}
