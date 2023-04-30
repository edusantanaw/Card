namespace Data.Repository {
    public interface ICreateRepository<In, Out> {
        Out Create(In data);
    }
}