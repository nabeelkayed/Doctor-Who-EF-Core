using System;
using System.Collections.Generic;
using System.Text;

namespace DoctorWho.Db.Repositories
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly DoctorWhoCoreDbContext _context;

        public AuthorRepository(DoctorWhoCoreDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public void CreateAuthors(string AuthorName)
        {
            var Author = new Author { AuthorName = AuthorName };
            _context.Authors.Add(Author);
            _context.SaveChanges();
        }
        public void UpdateAuthors(int AuthorId)
        {
            var Author = _context.Authors.Find(AuthorId);
            Author.AuthorName += "Kayed";
            _context.SaveChanges();
        }
        public void DeleteAuthors(int AuthorId)
        {
            var Author = _context.Authors.Find(AuthorId);
            _context.Authors.Remove(Author);
            _context.SaveChanges();
        }

    }
}
