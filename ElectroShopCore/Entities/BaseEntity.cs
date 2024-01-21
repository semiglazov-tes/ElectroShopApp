
namespace ElectroShopCore.Entities
{
    /// <summary>
    /// Базовый абсрактный класс для сущностей
    /// </summary>
    public abstract class BaseEntity
    {
        public virtual int Id { get; protected set; }
    }
}
