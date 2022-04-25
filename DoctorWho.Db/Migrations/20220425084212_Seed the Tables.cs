using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DoctorWho.Db.Migrations
{
    public partial class SeedtheTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorId", "AuthorName" },
                values: new object[,]
                {
                    { 1, "Nabeel" },
                    { 2, "Kayed" },
                    { 3, "Ahmad" },
                    { 4, "samer" },
                    { 5, "sameer" }
                });

            migrationBuilder.InsertData(
                table: "Companions",
                columns: new[] { "CompanionId", "CompanionName", "WhoPlayed" },
                values: new object[,]
                {
                    { 4, "Samer", "Ahmad" },
                    { 3, "Ahmad", "Samer" },
                    { 5, "Sameer", "Samer" },
                    { 1, "Nabeel", "kayed" },
                    { 2, "Kayed", "nabeel" }
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "DoctorId", "BirthDate", "DoctorName", "DoctorNumber", "FirstEpisodeDate", "LastEpisodeDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2010, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nabeel", 1, new DateTime(2010, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2010, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2010, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kayed", 12, new DateTime(2010, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2010, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(2010, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ahmad", 123, new DateTime(2010, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2010, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(2010, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samer", 1234, new DateTime(2010, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2010, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, new DateTime(2010, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sameer", 12345, new DateTime(2010, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2010, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Enemys",
                columns: new[] { "EnemyId", "EnemyDescription", "EnemyName" },
                values: new object[,]
                {
                    { 4, "Ahmad", "Samer" },
                    { 1, "kayed", "Nabeel" },
                    { 2, "nabeel", "Kayed" },
                    { 3, "Samer", "Ahmad" },
                    { 5, "Samer", "Sameer" }
                });

            migrationBuilder.InsertData(
                table: "Episodes",
                columns: new[] { "EpisodeId", "AuthorId", "DoctorId", "EpisodeDate", "EpisodeNumber", "EpisodeType", "Nots", "SeriesNumber", "Title" },
                values: new object[,]
                {
                    { 5, 3, null, new DateTime(2010, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 43215, "E", "n5", 12345, "EP5" },
                    { 3, 2, 4, new DateTime(2010, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 321, "C", "n5", 123, "EP3" },
                    { 4, 2, 4, new DateTime(2010, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 4321, "D", "n5", 1234, "EP4" },
                    { 1, 1, 5, new DateTime(2010, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "A", "n5", 1, "EP1" },
                    { 2, 1, 5, new DateTime(2010, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, "B", "n5", 12, "EP2" }
                });

            migrationBuilder.InsertData(
                table: "EpisodeCompanions",
                columns: new[] { "EpisodeCompanionId", "CompanionId", "EpisodeId" },
                values: new object[,]
                {
                    { 5, 5, 5 },
                    { 3, 3, 3 },
                    { 4, 3, 4 },
                    { 1, 1, 1 },
                    { 6, 1, 1 },
                    { 2, 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "EpisodeEnemys",
                columns: new[] { "EpisodeEnemyId", "EnemyId", "EpisodeId" },
                values: new object[,]
                {
                    { 5, 5, 5 },
                    { 3, 3, 3 },
                    { 4, 4, 4 },
                    { 1, 1, 1 },
                    { 6, 1, 1 },
                    { 2, 2, 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemys",
                keyColumn: "EpisodeEnemyId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemys",
                keyColumn: "EpisodeEnemyId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemys",
                keyColumn: "EpisodeEnemyId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemys",
                keyColumn: "EpisodeEnemyId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemys",
                keyColumn: "EpisodeEnemyId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemys",
                keyColumn: "EpisodeEnemyId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Enemys",
                keyColumn: "EnemyId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Enemys",
                keyColumn: "EnemyId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Enemys",
                keyColumn: "EnemyId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Enemys",
                keyColumn: "EnemyId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Enemys",
                keyColumn: "EnemyId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 5);
        }
    }
}
