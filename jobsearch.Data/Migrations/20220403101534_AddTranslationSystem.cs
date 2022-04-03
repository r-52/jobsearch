using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace jobsearch.Data.Migrations
{
    public partial class AddTranslationSystem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LanguageId",
                table: "Instaces",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "CompanyAgents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FirstName = table.Column<string>(type: "text", nullable: true),
                    LastName = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: false),
                    AvatarUrl = table.Column<string>(type: "text", nullable: true),
                    Position = table.Column<string>(type: "text", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: false),
                    PublicEmail = table.Column<string>(type: "text", nullable: true),
                    PublicPhone = table.Column<string>(type: "text", nullable: true),
                    CompanyId = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Revision = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyAgents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CompanyAgents_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Translations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Key = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: false),
                    LanguageId = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Translations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Translations_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "JobTypeEntity",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 3, 10, 15, 33, 656, DateTimeKind.Utc).AddTicks(6416));

            migrationBuilder.UpdateData(
                table: "JobTypeEntity",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 3, 10, 15, 33, 656, DateTimeKind.Utc).AddTicks(6420));

            migrationBuilder.UpdateData(
                table: "JobTypeEntity",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 3, 10, 15, 33, 656, DateTimeKind.Utc).AddTicks(6421));

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 4, 3, 10, 15, 33, 656, DateTimeKind.Utc).AddTicks(8252), null, "english", null },
                    { 2, new DateTime(2022, 4, 3, 10, 15, 33, 656, DateTimeKind.Utc).AddTicks(8258), null, "german", null }
                });

            migrationBuilder.UpdateData(
                table: "Instaces",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LanguageId" },
                values: new object[] { new DateTime(2022, 4, 3, 10, 15, 33, 656, DateTimeKind.Utc).AddTicks(9329), 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Instaces_LanguageId",
                table: "Instaces",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyAgents_CompanyId",
                table: "CompanyAgents",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Translations_LanguageId",
                table: "Translations",
                column: "LanguageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Instaces_Languages_LanguageId",
                table: "Instaces",
                column: "LanguageId",
                principalTable: "Languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Instaces_Languages_LanguageId",
                table: "Instaces");

            migrationBuilder.DropTable(
                name: "CompanyAgents");

            migrationBuilder.DropTable(
                name: "Translations");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropIndex(
                name: "IX_Instaces_LanguageId",
                table: "Instaces");

            migrationBuilder.DropColumn(
                name: "LanguageId",
                table: "Instaces");

            migrationBuilder.UpdateData(
                table: "Instaces",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 2, 21, 23, 14, 634, DateTimeKind.Utc).AddTicks(8997));

            migrationBuilder.UpdateData(
                table: "JobTypeEntity",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 2, 21, 23, 14, 634, DateTimeKind.Utc).AddTicks(7843));

            migrationBuilder.UpdateData(
                table: "JobTypeEntity",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 2, 21, 23, 14, 634, DateTimeKind.Utc).AddTicks(7846));

            migrationBuilder.UpdateData(
                table: "JobTypeEntity",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 2, 21, 23, 14, 634, DateTimeKind.Utc).AddTicks(7848));
        }
    }
}
