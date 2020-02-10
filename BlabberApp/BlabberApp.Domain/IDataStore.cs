namespace BlabberApp.Domain
{
    public interface IDataStore
    {
        bool Create(IDatum datum);
        IDatum Read(int idx);

        bool Update(IDatum datum);
        
        bool Delete(int idx);        
    }
}