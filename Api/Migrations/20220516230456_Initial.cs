using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Snippets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    FileUrl = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Snippets", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Snippets",
                columns: new[] { "Id", "Description", "FileUrl", "Title" },
                values: new object[] { 1, "I just can't do it. You could see there was text coming out of her eyes, text coming out of her wherever. You have so many different things placeholder text has to be able to do, and I don't believe Lorem Ipsum has the stamina.", "", "Lorem Ipsum" });

            migrationBuilder.InsertData(
                table: "Snippets",
                columns: new[] { "Id", "Description", "FileUrl", "Title" },
                values: new object[] { 2, "I just can't do it. You could see there was text coming out of her eyes, text coming out of her wherever. You have so many different things placeholder text has to be able to do, and I don't believe Lorem Ipsum has the stamina.", "", "Lorem Ipsum" });

            migrationBuilder.InsertData(
                table: "Snippets",
                columns: new[] { "Id", "Description", "FileUrl", "Title" },
                values: new object[] { 3, "I just can't do it. You could see there was text coming out of her eyes, text coming out of her wherever. You have so many different things placeholder text has to be able to do, and I don't believe Lorem Ipsum has the stamina.", "", "Lorem Ipsum" });

            migrationBuilder.InsertData(
                table: "Snippets",
                columns: new[] { "Id", "Description", "FileUrl", "Title" },
                values: new object[] { 4, "I just can't do it. You could see there was text coming out of her eyes, text coming out of her wherever. You have so many different things placeholder text has to be able to do, and I don't believe Lorem Ipsum has the stamina.", "", "Lorem Ipsum" });

            migrationBuilder.InsertData(
                table: "Snippets",
                columns: new[] { "Id", "Description", "FileUrl", "Title" },
                values: new object[] { 5, "I just can't do it. You could see there was text coming out of her eyes, text coming out of her wherever. You have so many different things placeholder text has to be able to do, and I don't believe Lorem Ipsum has the stamina.", "", "Lorem Ipsum" });

            migrationBuilder.InsertData(
                table: "Snippets",
                columns: new[] { "Id", "Description", "FileUrl", "Title" },
                values: new object[] { 6, "I just can't do it. You could see there was text coming out of her eyes, text coming out of her wherever. You have so many different things placeholder text has to be able to do, and I don't believe Lorem Ipsum has the stamina.", "", "Lorem Ipsum" });

            migrationBuilder.InsertData(
                table: "Snippets",
                columns: new[] { "Id", "Description", "FileUrl", "Title" },
                values: new object[] { 7, "I just can't do it. You could see there was text coming out of her eyes, text coming out of her wherever. You have so many different things placeholder text has to be able to do, and I don't believe Lorem Ipsum has the stamina.", "", "Lorem Ipsum" });

            migrationBuilder.InsertData(
                table: "Snippets",
                columns: new[] { "Id", "Description", "FileUrl", "Title" },
                values: new object[] { 8, "I just can't do it. You could see there was text coming out of her eyes, text coming out of her wherever. You have so many different things placeholder text has to be able to do, and I don't believe Lorem Ipsum has the stamina.", "", "Lorem Ipsum" });

            migrationBuilder.InsertData(
                table: "Snippets",
                columns: new[] { "Id", "Description", "FileUrl", "Title" },
                values: new object[] { 9, "I just can't do it. You could see there was text coming out of her eyes, text coming out of her wherever. You have so many different things placeholder text has to be able to do, and I don't believe Lorem Ipsum has the stamina.", "", "Lorem Ipsum" });

            migrationBuilder.InsertData(
                table: "Snippets",
                columns: new[] { "Id", "Description", "FileUrl", "Title" },
                values: new object[] { 10, "I just can't do it. You could see there was text coming out of her eyes, text coming out of her wherever. You have so many different things placeholder text has to be able to do, and I don't believe Lorem Ipsum has the stamina.", "", "Lorem Ipsum" });

            migrationBuilder.InsertData(
                table: "Snippets",
                columns: new[] { "Id", "Description", "FileUrl", "Title" },
                values: new object[] { 11, "I just can't do it. You could see there was text coming out of her eyes, text coming out of her wherever. You have so many different things placeholder text has to be able to do, and I don't believe Lorem Ipsum has the stamina.", "", "Lorem Ipsum" });

            migrationBuilder.InsertData(
                table: "Snippets",
                columns: new[] { "Id", "Description", "FileUrl", "Title" },
                values: new object[] { 12, "I just can't do it. You could see there was text coming out of her eyes, text coming out of her wherever. You have so many different things placeholder text has to be able to do, and I don't believe Lorem Ipsum has the stamina.", "", "Lorem Ipsum" });

            migrationBuilder.InsertData(
                table: "Snippets",
                columns: new[] { "Id", "Description", "FileUrl", "Title" },
                values: new object[] { 13, "I just can't do it. You could see there was text coming out of her eyes, text coming out of her wherever. You have so many different things placeholder text has to be able to do, and I don't believe Lorem Ipsum has the stamina.", "", "Lorem Ipsum" });

            migrationBuilder.InsertData(
                table: "Snippets",
                columns: new[] { "Id", "Description", "FileUrl", "Title" },
                values: new object[] { 14, "I just can't do it. You could see there was text coming out of her eyes, text coming out of her wherever. You have so many different things placeholder text has to be able to do, and I don't believe Lorem Ipsum has the stamina.", "", "Lorem Ipsum" });

            migrationBuilder.InsertData(
                table: "Snippets",
                columns: new[] { "Id", "Description", "FileUrl", "Title" },
                values: new object[] { 15, "I just can't do it. You could see there was text coming out of her eyes, text coming out of her wherever. You have so many different things placeholder text has to be able to do, and I don't believe Lorem Ipsum has the stamina.", "", "Lorem Ipsum" });

            migrationBuilder.InsertData(
                table: "Snippets",
                columns: new[] { "Id", "Description", "FileUrl", "Title" },
                values: new object[] { 16, "I just can't do it. You could see there was text coming out of her eyes, text coming out of her wherever. You have so many different things placeholder text has to be able to do, and I don't believe Lorem Ipsum has the stamina.", "", "Lorem Ipsum" });

            migrationBuilder.InsertData(
                table: "Snippets",
                columns: new[] { "Id", "Description", "FileUrl", "Title" },
                values: new object[] { 17, "I just can't do it. You could see there was text coming out of her eyes, text coming out of her wherever. You have so many different things placeholder text has to be able to do, and I don't believe Lorem Ipsum has the stamina.", "", "Lorem Ipsum" });

            migrationBuilder.InsertData(
                table: "Snippets",
                columns: new[] { "Id", "Description", "FileUrl", "Title" },
                values: new object[] { 18, "I just can't do it. You could see there was text coming out of her eyes, text coming out of her wherever. You have so many different things placeholder text has to be able to do, and I don't believe Lorem Ipsum has the stamina.", "", "Lorem Ipsum" });

            migrationBuilder.InsertData(
                table: "Snippets",
                columns: new[] { "Id", "Description", "FileUrl", "Title" },
                values: new object[] { 19, "I just can't do it. You could see there was text coming out of her eyes, text coming out of her wherever. You have so many different things placeholder text has to be able to do, and I don't believe Lorem Ipsum has the stamina.", "", "Lorem Ipsum" });

            migrationBuilder.InsertData(
                table: "Snippets",
                columns: new[] { "Id", "Description", "FileUrl", "Title" },
                values: new object[] { 20, "I just can't do it. You could see there was text coming out of her eyes, text coming out of her wherever. You have so many different things placeholder text has to be able to do, and I don't believe Lorem Ipsum has the stamina.", "", "Lorem Ipsum" });

            migrationBuilder.InsertData(
                table: "Snippets",
                columns: new[] { "Id", "Description", "FileUrl", "Title" },
                values: new object[] { 21, "I just can't do it. You could see there was text coming out of her eyes, text coming out of her wherever. You have so many different things placeholder text has to be able to do, and I don't believe Lorem Ipsum has the stamina.", "", "Lorem Ipsum" });

            migrationBuilder.InsertData(
                table: "Snippets",
                columns: new[] { "Id", "Description", "FileUrl", "Title" },
                values: new object[] { 22, "I just can't do it. You could see there was text coming out of her eyes, text coming out of her wherever. You have so many different things placeholder text has to be able to do, and I don't believe Lorem Ipsum has the stamina.", "", "Lorem Ipsum" });

            migrationBuilder.InsertData(
                table: "Snippets",
                columns: new[] { "Id", "Description", "FileUrl", "Title" },
                values: new object[] { 23, "I just can't do it. You could see there was text coming out of her eyes, text coming out of her wherever. You have so many different things placeholder text has to be able to do, and I don't believe Lorem Ipsum has the stamina.", "", "Lorem Ipsum" });

            migrationBuilder.InsertData(
                table: "Snippets",
                columns: new[] { "Id", "Description", "FileUrl", "Title" },
                values: new object[] { 24, "I just can't do it. You could see there was text coming out of her eyes, text coming out of her wherever. You have so many different things placeholder text has to be able to do, and I don't believe Lorem Ipsum has the stamina.", "", "Lorem Ipsum" });

            migrationBuilder.InsertData(
                table: "Snippets",
                columns: new[] { "Id", "Description", "FileUrl", "Title" },
                values: new object[] { 25, "I just can't do it. You could see there was text coming out of her eyes, text coming out of her wherever. You have so many different things placeholder text has to be able to do, and I don't believe Lorem Ipsum has the stamina.", "", "Lorem Ipsum" });

            migrationBuilder.InsertData(
                table: "Snippets",
                columns: new[] { "Id", "Description", "FileUrl", "Title" },
                values: new object[] { 26, "I just can't do it. You could see there was text coming out of her eyes, text coming out of her wherever. You have so many different things placeholder text has to be able to do, and I don't believe Lorem Ipsum has the stamina.", "", "Lorem Ipsum" });

            migrationBuilder.InsertData(
                table: "Snippets",
                columns: new[] { "Id", "Description", "FileUrl", "Title" },
                values: new object[] { 27, "I just can't do it. You could see there was text coming out of her eyes, text coming out of her wherever. You have so many different things placeholder text has to be able to do, and I don't believe Lorem Ipsum has the stamina.", "", "Lorem Ipsum" });

            migrationBuilder.InsertData(
                table: "Snippets",
                columns: new[] { "Id", "Description", "FileUrl", "Title" },
                values: new object[] { 28, "I just can't do it. You could see there was text coming out of her eyes, text coming out of her wherever. You have so many different things placeholder text has to be able to do, and I don't believe Lorem Ipsum has the stamina.", "", "Lorem Ipsum" });

            migrationBuilder.InsertData(
                table: "Snippets",
                columns: new[] { "Id", "Description", "FileUrl", "Title" },
                values: new object[] { 29, "I just can't do it. You could see there was text coming out of her eyes, text coming out of her wherever. You have so many different things placeholder text has to be able to do, and I don't believe Lorem Ipsum has the stamina.", "", "Lorem Ipsum" });

            migrationBuilder.InsertData(
                table: "Snippets",
                columns: new[] { "Id", "Description", "FileUrl", "Title" },
                values: new object[] { 30, "I just can't do it. You could see there was text coming out of her eyes, text coming out of her wherever. You have so many different things placeholder text has to be able to do, and I don't believe Lorem Ipsum has the stamina.", "", "Lorem Ipsum" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Snippets");
        }
    }
}
