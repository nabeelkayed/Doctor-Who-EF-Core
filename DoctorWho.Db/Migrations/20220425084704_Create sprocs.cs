using Microsoft.EntityFrameworkCore.Migrations;

namespace DoctorWho.Db.Migrations
{
    public partial class Createsprocs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"CREATE PROCEDURE spSummariseEpisodes
                                   AS BEGIN

                                   SELECT TOP (3) CompanionId
                                     FROM EpisodeCompanions
                                     group by CompanionId
                                     order by COUNT(CompanionId) DESC;

                                    SELECT TOP (3) EnemyId
                                      FROM EpisodeEnemys
                                      group by EnemyId
                                      order by COUNT(EnemyId) DESC;

                                    END;");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP PROCEDURE dbo.spSummariseEpisodes");
        }
    }
}
