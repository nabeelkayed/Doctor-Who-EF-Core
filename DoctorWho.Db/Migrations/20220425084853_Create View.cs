using Microsoft.EntityFrameworkCore.Migrations;

namespace DoctorWho.Db.Migrations
{
    public partial class CreateView : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"CREATE VIEW viewEpisodes
                                   AS
                                   select e.EpisodeId, d.DoctorName, a.AuthorName,
                                          (SELECT * from dbo.fnCompanions(e.EpisodeId)) as Companions , 
	                                      (SELECT * from dbo.fnEnemies(e.EpisodeId)) as Enemies
	                                      from Episodes e
                                   INNER JOIN Doctors d 
                                         ON e.DoctorId  = d.DoctorId
                                   INNER JOIN Authors a 
                                         ON e.AuthorId = a.AuthorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP VIEW dbo.viewEpisodes");
        }
    }
}
