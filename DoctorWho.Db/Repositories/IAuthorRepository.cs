namespace DoctorWho.Db.Repositories
{
    public interface IAuthorRepository
    {
        void CreateAuthors(string AuthorName);
        void DeleteAuthors(int AuthorId);
        void UpdateAuthors(int AuthorId);
    }
}