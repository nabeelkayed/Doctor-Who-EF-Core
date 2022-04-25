using Microsoft.EntityFrameworkCore.Migrations;

namespace DoctorWho.Db.Migrations
{
    public partial class Createfunc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"CREATE FUNCTION fnCompanions(@EpisodeId INT)
                                   RETURNS TABLE AS
                                   RETURN SELECT STRING_AGG(c.CompanionName, ', ') as CompanionName FROM Companions c
                                          INNER JOIN EpisodeCompanions ec
                                          ON c.CompanionId = ec.CompanionId
                                          where ec.EpisodeId = @EpisodeId; ");
            migrationBuilder.Sql(@"CREATE FUNCTION fnEnemies(@EpisodeId INT)
                                   RETURNS TABLE AS
                                   RETURN SELECT STRING_AGG(e.EnemyName, ', ') as EnemyName FROM Enemys e
	                                      INNER JOIN EpisodeEnemys ee 
	                                      ON e.EnemyId = ee.EnemyId 
                                          where ee.EpisodeId = @EpisodeId;");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP FUNCTION dbo.fnCompanions");
            migrationBuilder.Sql("DROP FUNCTION dbo.fnEnemies");
        }
    }
}
