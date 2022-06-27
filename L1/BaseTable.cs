using System.Collections.Generic;

namespace L1
{
    /// <summary>
    /// For generic inheritance
    /// </summary>
    public interface IBaseTable { }

    public class BaseTable<T> : IBaseTable where T: L1.BaseRecord, new()
    {
        public TableEngine<T> Engine { get; private set; }
        public BaseTable()
        {
            Engine = new TableEngine<T>();
        }

        public int Insert(T item) {
            return Engine.Insert(item.GetFields());
        }       
        public int Update(T item) {
            return Engine.Update(
                fields: item.GetFields(), 
                where : new List<BaseField> { new EqField("Id", item.Id) }
            );
        }
        public int HardDelete(T item) 
        {
            return Engine.Delete(new List<BaseField> { new EqField("Id", item.Id) }); 
        }
        public List<T> Get() { return Engine.Select(); }
        public T Get(int id)
        {
            var models = Engine.Select(new List<BaseField> { new EqField("Id", id) });
            if (models.Count != 0)
                return models[0];
            else
                return null;
        }
    }
}
