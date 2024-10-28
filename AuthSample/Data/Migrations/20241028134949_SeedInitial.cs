using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AuthSample.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedInitial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "10b90e0f-7e86-44d8-b682-f887f61950d5", "1f01c43e-b2ff-4f34-b1a9-73600f41f512" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d823bbdd-46ea-46da-8e6b-4c582d4e5dc4", "5de73eda-f05b-41ff-9db6-38eed8872207" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8e2a2d97-377a-4ccc-8689-6e8fd205cc91", "736dafd5-cfc0-4c69-8ff7-7b91d73b1160" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "70bfda4c-1045-42ce-ae31-d3108f2b4b49", "da7d2111-a89f-4c01-90b4-f112ac1b6641" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "10b90e0f-7e86-44d8-b682-f887f61950d5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "70bfda4c-1045-42ce-ae31-d3108f2b4b49");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8e2a2d97-377a-4ccc-8689-6e8fd205cc91");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d823bbdd-46ea-46da-8e6b-4c582d4e5dc4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1f01c43e-b2ff-4f34-b1a9-73600f41f512");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5de73eda-f05b-41ff-9db6-38eed8872207");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "736dafd5-cfc0-4c69-8ff7-7b91d73b1160");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "da7d2111-a89f-4c01-90b4-f112ac1b6641");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5c528ec5-18fc-4aa3-a9d7-9eae13164903", null, "Financeiro", "FINANCEIRO" },
                    { "74a1ec51-6205-4008-a216-81127cd4675c", null, "Admin", "ADMIN" },
                    { "b4063abd-8f4b-4c8b-b16e-ec631aa2e72d", null, "TI", "TI" },
                    { "e995af3d-d1cf-47a0-901c-341739ce9a99", null, "RH", "RH" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "20a7904e-d2f1-4687-baea-f0d05f46ce2f", 0, "1e48a583-cb13-456b-abf4-6cb18bd842c2", "rh@example.com", true, false, null, "RH@EXAMPLE.COM", "RH@EXAMPLE.COM", "AQAAAAIAAYagAAAAEIiudnMmPCys+0eaXJvJYT69p3BQfW8kNRd7ntF9l9NDjjZqJ8hHanb9JT8pjyv/yQ==", null, false, "c41f062c-083d-409e-bdac-d0680091265b", false, "rh@example.com" },
                    { "215aceec-c0bf-47ee-ab49-2f1b611a2f1e", 0, "9c45fcfd-524b-4bcc-9914-ba3337d386dc", "financeiro@example.com", true, false, null, "FINANCEIRO@EXAMPLE.COM", "FINANCEIRO@EXAMPLE.COM", "AQAAAAIAAYagAAAAEC3/WBRvgvnM7R2hJcxbam6pEysJxBBxEJBNOXhLSEsOD3LeYnB3kO0XKMN4HsCuwg==", null, false, "6af4a568-3c8b-43bf-88b8-30a73a148c11", false, "financeiro@example.com" },
                    { "2d5bc841-6ea1-4ae1-bb1e-eabe95be9c07", 0, "8fb50471-2ee7-433d-adb0-ec182e81f629", "ti@example.com", true, false, null, "TI@EXAMPLE.COM", "TI@EXAMPLE.COM", "AQAAAAIAAYagAAAAENUNZpoQzmR4kor4mPwOgnA60mu+oelwyOct86gEde2yyhZiIRQ0ZBCFE1CYheAo7g==", null, false, "3c48346a-3d16-47c8-a914-5700cf29615b", false, "ti@example.com" },
                    { "51de14a9-26cc-443d-8691-c14ec21a9d6a", 0, "15e1bf69-563f-4d22-9c1c-ccf03220808f", "admin@example.com", true, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEKidl7cjhU7NORAgZIQN41oyeWj5pCeKPPXo+pbibl2lQsCnParPRccMiTr3jtvTOg==", null, false, "56f6d2f2-c46f-4c05-b328-82f0c1785bdf", false, "admin@example.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "e995af3d-d1cf-47a0-901c-341739ce9a99", "20a7904e-d2f1-4687-baea-f0d05f46ce2f" },
                    { "5c528ec5-18fc-4aa3-a9d7-9eae13164903", "215aceec-c0bf-47ee-ab49-2f1b611a2f1e" },
                    { "b4063abd-8f4b-4c8b-b16e-ec631aa2e72d", "2d5bc841-6ea1-4ae1-bb1e-eabe95be9c07" },
                    { "74a1ec51-6205-4008-a216-81127cd4675c", "51de14a9-26cc-443d-8691-c14ec21a9d6a" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e995af3d-d1cf-47a0-901c-341739ce9a99", "20a7904e-d2f1-4687-baea-f0d05f46ce2f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5c528ec5-18fc-4aa3-a9d7-9eae13164903", "215aceec-c0bf-47ee-ab49-2f1b611a2f1e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b4063abd-8f4b-4c8b-b16e-ec631aa2e72d", "2d5bc841-6ea1-4ae1-bb1e-eabe95be9c07" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "74a1ec51-6205-4008-a216-81127cd4675c", "51de14a9-26cc-443d-8691-c14ec21a9d6a" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5c528ec5-18fc-4aa3-a9d7-9eae13164903");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "74a1ec51-6205-4008-a216-81127cd4675c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4063abd-8f4b-4c8b-b16e-ec631aa2e72d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e995af3d-d1cf-47a0-901c-341739ce9a99");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20a7904e-d2f1-4687-baea-f0d05f46ce2f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "215aceec-c0bf-47ee-ab49-2f1b611a2f1e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2d5bc841-6ea1-4ae1-bb1e-eabe95be9c07");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "51de14a9-26cc-443d-8691-c14ec21a9d6a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "10b90e0f-7e86-44d8-b682-f887f61950d5", null, "TI", "TI" },
                    { "70bfda4c-1045-42ce-ae31-d3108f2b4b49", null, "Financeiro", "FINANCEIRO" },
                    { "8e2a2d97-377a-4ccc-8689-6e8fd205cc91", null, "RH", "RH" },
                    { "d823bbdd-46ea-46da-8e6b-4c582d4e5dc4", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1f01c43e-b2ff-4f34-b1a9-73600f41f512", 0, "e350eba2-09fa-47a0-9578-16dd38d7f159", "ti@example.com", true, false, null, "TI@EXAMPLE.COM", "TI@EXAMPLE.COM", "AQAAAAIAAYagAAAAEAn8n29Gz3cHkNfvK8QGZPClSkhdf94aYciw25jZ9+n4+kCGM0LvzsXeFdx4ANtrGA==", null, false, "cdaca1db-0eba-4513-87ce-09bcd2552c9d", false, "ti@example.com" },
                    { "5de73eda-f05b-41ff-9db6-38eed8872207", 0, "992ff062-5dcf-4aab-91f0-28349983926b", "admin@example.com", true, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEHcMCrD+E4JF16GAqkmFpXgnQCPpkvdXyDlBVmH5tOcybX+b/FNbV4WHk/wDRsJ3kQ==", null, false, "e996580d-b4db-49b4-803b-67fae964638b", false, "admin@example.com" },
                    { "736dafd5-cfc0-4c69-8ff7-7b91d73b1160", 0, "54e743e1-2eb4-4c0c-b5fc-fdbb1bad4650", "rh@example.com", true, false, null, "RH@EXAMPLE.COM", "RH@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJjSqR7Mo9ymZv4sDbBA/HfMa29cloai/llBIh4A2wx7bm/VaSzSQiEF3Spye/poHg==", null, false, "954a9007-647a-43f2-b946-dd1c8152dae4", false, "rh@example.com" },
                    { "da7d2111-a89f-4c01-90b4-f112ac1b6641", 0, "5ba07ac5-6627-4fae-9ff1-83dbecc0e6da", "financeiro@example.com", true, false, null, "FINANCEIRO@EXAMPLE.COM", "FINANCEIRO@EXAMPLE.COM", "AQAAAAIAAYagAAAAEB3tqV8I3UQ+8Rv8RgPC7t1zfCts5TFzclesfpoglCpHpNpw8vfX4xfbYRPPs+CDEg==", null, false, "6f010abc-a93b-43ff-8cfd-9adedae89d37", false, "financeiro@example.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "10b90e0f-7e86-44d8-b682-f887f61950d5", "1f01c43e-b2ff-4f34-b1a9-73600f41f512" },
                    { "d823bbdd-46ea-46da-8e6b-4c582d4e5dc4", "5de73eda-f05b-41ff-9db6-38eed8872207" },
                    { "8e2a2d97-377a-4ccc-8689-6e8fd205cc91", "736dafd5-cfc0-4c69-8ff7-7b91d73b1160" },
                    { "70bfda4c-1045-42ce-ae31-d3108f2b4b49", "da7d2111-a89f-4c01-90b4-f112ac1b6641" }
                });
        }
    }
}
