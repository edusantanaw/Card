
namespace Data.Repository {
    public interface IDeleteRepository<T> {
        T? LoadById(Guid id);
        void Delete(Guid id);
    }
}