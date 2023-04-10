using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TareasMVC.Migrations
{
    /// <inheritdoc />
    public partial class AdminRol : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                IF NOT EXISTS(SELECT Id FROM AspNetRoles WHERE Id ='d5ea4a60-fe11-4a79-ac28-5244f1a457ce')
                BEGIN
	                insert AspNetRoles (Id,[Name],[NormalizedName])
	                values ('d5ea4a60-fe11-4a79-ac28-5244f1a457ce','admin','ADMIN')
                END" );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DELETE AspNetRoles WHERE Id = 'd5ea4a60-fe11-4a79-ac28-5244f1a457ce'");
        }
    }
}
