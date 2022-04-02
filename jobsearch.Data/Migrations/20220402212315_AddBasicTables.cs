using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace jobsearch.Data.Migrations
{
    public partial class AddBasicTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "IntroImageUrl",
                table: "Jobs",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "FooterImageUrl",
                table: "Jobs",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "ExternalApplyUrl",
                table: "Jobs",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "BodyPlain",
                table: "Jobs",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "BodyHtml",
                table: "Jobs",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<int>(
                name: "InstanceId",
                table: "Jobs",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Instaces",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Domain = table.Column<string>(type: "text", nullable: false),
                    Tld = table.Column<string>(type: "text", nullable: false),
                    MetaKeywords = table.Column<string>(type: "text", nullable: true),
                    MetaDescription = table.Column<string>(type: "text", nullable: true),
                    ExtraCss = table.Column<string>(type: "text", nullable: true),
                    LogoUrl = table.Column<string>(type: "text", nullable: true),
                    Imprint = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Revision = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instaces", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TagUsages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ForeignTableIdentifier = table.Column<int>(type: "integer", nullable: false),
                    TableIdentifierPlain = table.Column<string>(type: "text", nullable: false),
                    ForeignKey = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Revision = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TagUsages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    ProfileHeadline = table.Column<string>(type: "text", nullable: true),
                    ProfileHtmlBody = table.Column<string>(type: "text", nullable: true),
                    ProfilePlainBody = table.Column<string>(type: "text", nullable: true),
                    Address = table.Column<string>(type: "text", nullable: true),
                    InstanceId = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Revision = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Companies_Instaces_InstanceId",
                        column: x => x.InstanceId,
                        principalTable: "Instaces",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TitleTranslationKey = table.Column<string>(type: "text", nullable: false),
                    DescriptionTranslationKey = table.Column<string>(type: "text", nullable: false),
                    InstanceId = table.Column<int>(type: "integer", nullable: false),
                    UsageCount = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tags_Instaces_InstanceId",
                        column: x => x.InstanceId,
                        principalTable: "Instaces",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Instaces",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Domain", "ExtraCss", "Imprint", "LogoUrl", "MetaDescription", "MetaKeywords", "Name", "Revision", "Tld", "UpdatedAt" },
                values: new object[] { 1, new DateTime(2022, 4, 2, 21, 23, 14, 634, DateTimeKind.Utc).AddTicks(8997), null, "localhost", ".empty-class {}", "Test", "", "MetaDescription", "keywords", "Localhost", 1, "", null });

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

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_InstanceId",
                table: "Jobs",
                column: "InstanceId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_InstanceId",
                table: "Companies",
                column: "InstanceId");

            migrationBuilder.CreateIndex(
                name: "IX_Tags_InstanceId",
                table: "Tags",
                column: "InstanceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Jobs_Instaces_InstanceId",
                table: "Jobs",
                column: "InstanceId",
                principalTable: "Instaces",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jobs_Instaces_InstanceId",
                table: "Jobs");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "TagUsages");

            migrationBuilder.DropTable(
                name: "Instaces");

            migrationBuilder.DropIndex(
                name: "IX_Jobs_InstanceId",
                table: "Jobs");

            migrationBuilder.DropColumn(
                name: "InstanceId",
                table: "Jobs");

            migrationBuilder.AlterColumn<string>(
                name: "IntroImageUrl",
                table: "Jobs",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FooterImageUrl",
                table: "Jobs",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ExternalApplyUrl",
                table: "Jobs",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BodyPlain",
                table: "Jobs",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BodyHtml",
                table: "Jobs",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "JobTypeEntity",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 1, 13, 54, 24, 424, DateTimeKind.Utc).AddTicks(1448));

            migrationBuilder.UpdateData(
                table: "JobTypeEntity",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 1, 13, 54, 24, 424, DateTimeKind.Utc).AddTicks(1571));

            migrationBuilder.UpdateData(
                table: "JobTypeEntity",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 1, 13, 54, 24, 424, DateTimeKind.Utc).AddTicks(1676));
        }
    }
}
