using System.Collections.ObjectModel;

namespace Common.Library;

public interface IRepository<TEntity>
{
  ObservableCollection<TEntity> Get();

  TEntity? Get(int id);
}
