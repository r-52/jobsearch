using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace jobsearch.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "JobTypeEntity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Revision = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobTypeEntity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Jobs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    HeadlinePlain = table.Column<string>(type: "text", nullable: false),
                    HeadlineHtml = table.Column<string>(type: "text", nullable: false),
                    BodyPlain = table.Column<string>(type: "text", nullable: false),
                    BodyHtml = table.Column<string>(type: "text", nullable: false),
                    IntroImageUrl = table.Column<string>(type: "text", nullable: false),
                    FooterImageUrl = table.Column<string>(type: "text", nullable: false),
                    ExternalApplyUrl = table.Column<string>(type: "text", nullable: false),
                    IsOnline = table.Column<bool>(type: "boolean", nullable: false),
                    IsDraft = table.Column<bool>(type: "boolean", nullable: false),
                    IsArchived = table.Column<bool>(type: "boolean", nullable: false),
                    OnlineFrom = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    OnlineTill = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    JobTypeId = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Revision = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jobs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Jobs_JobTypeEntity_JobTypeId",
                        column: x => x.JobTypeId,
                        principalTable: "JobTypeEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "JobTypeEntity",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Name", "Revision", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 4, 1, 13, 54, 24, 424, DateTimeKind.Utc).AddTicks(1448), null, "jobtype.fulltime", 0, null },
                    { 2, new DateTime(2022, 4, 1, 13, 54, 24, 424, DateTimeKind.Utc).AddTicks(1571), null, "jobtype.halfjob", 0, null },
                    { 3, new DateTime(2022, 4, 1, 13, 54, 24, 424, DateTimeKind.Utc).AddTicks(1676), null, "jobtype.minijob", 0, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_JobTypeId",
                table: "Jobs",
                column: "JobTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Jobs");

            migrationBuilder.DropTable(
                name: "JobTypeEntity");
        }
    }
}
