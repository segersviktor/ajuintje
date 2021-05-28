using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace MyKafka.DataAccess.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AssociationTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssociationTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CertificateReceivers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CertificateReceivers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Associations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Slug = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MemberFee = table.Column<double>(type: "float", nullable: false),
                    AssociationTypeId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Number = table.Column<int>(type: "int", nullable: false),
                    ZipCode = table.Column<int>(type: "int", nullable: false),
                    Bus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Associations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Associations_AssociationTypes_AssociationTypeId",
                        column: x => x.AssociationTypeId,
                        principalTable: "AssociationTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AssociationUnits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GroupIndex = table.Column<int>(type: "int", nullable: false),
                    CampFee = table.Column<double>(type: "float", nullable: false),
                    CampStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CampEndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AssociationId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Number = table.Column<int>(type: "int", nullable: false),
                    ZipCode = table.Column<int>(type: "int", nullable: false),
                    Bus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssociationUnits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AssociationUnits_Associations_AssociationId",
                        column: x => x.AssociationId,
                        principalTable: "Associations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Members",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MemberFeePaid = table.Column<bool>(type: "bit", nullable: false),
                    CampAttendance = table.Column<bool>(type: "bit", nullable: false),
                    SocialFee = table.Column<bool>(type: "bit", nullable: false),
                    AssociationUnitId = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Number = table.Column<int>(type: "int", nullable: false),
                    ZipCode = table.Column<int>(type: "int", nullable: false),
                    Bus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Members", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Members_AssociationUnits_AssociationUnitId",
                        column: x => x.AssociationUnitId,
                        principalTable: "AssociationUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CertificateLogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MemberId = table.Column<int>(type: "int", nullable: true),
                    CertificateReceiverId = table.Column<int>(type: "int", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Success = table.Column<bool>(type: "bit", nullable: false),
                    Exception = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CertificateLogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CertificateLogs_CertificateReceivers_CertificateReceiverId",
                        column: x => x.CertificateReceiverId,
                        principalTable: "CertificateReceivers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CertificateLogs_Members_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Members",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AssociationTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Scouts en Gidsen Vlaanderen" },
                    { 2, "Chirojeugd Vlaanderen" }
                });

            migrationBuilder.InsertData(
                table: "CertificateReceivers",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "LastModifiedBy", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Christelijke Mutualiteit" },
                    { 2, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Nationale Verbond van Socialistische Mutualiteiten" }
                });

            migrationBuilder.InsertData(
                table: "Associations",
                columns: new[] { "Id", "AssociationTypeId", "Bus", "City", "Country", "CreatedBy", "CreatedDate", "LastModifiedBy", "LastModifiedDate", "MemberFee", "Name", "Number", "Slug", "Street", "ZipCode" },
                values: new object[] { 1, 1, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 45.0, "Scouts 92ste", 0, "scouts-92ste", null, 0 });

            migrationBuilder.InsertData(
                table: "AssociationUnits",
                columns: new[] { "Id", "AssociationId", "Bus", "CampEndDate", "CampFee", "CampStartDate", "City", "Country", "CreatedBy", "CreatedDate", "GroupIndex", "LastModifiedBy", "LastModifiedDate", "Name", "Number", "Street", "ZipCode" },
                values: new object[,]
                {
                    { 1, 1, null, new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, new DateTime(2021, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, null, "Paloebies", 0, null, 0 },
                    { 2, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, null, "Wolven", 0, null, 0 },
                    { 3, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, null, null, "Poema's", 0, null, 0 },
                    { 4, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, null, null, "JV/PV", 0, null, 0 },
                    { 5, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, null, null, "Kevins", 0, null, 0 },
                    { 6, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, null, null, "Jins", 0, null, 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Associations_AssociationTypeId",
                table: "Associations",
                column: "AssociationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_AssociationUnits_AssociationId",
                table: "AssociationUnits",
                column: "AssociationId");

            migrationBuilder.CreateIndex(
                name: "IX_CertificateLogs_CertificateReceiverId",
                table: "CertificateLogs",
                column: "CertificateReceiverId");

            migrationBuilder.CreateIndex(
                name: "IX_CertificateLogs_MemberId",
                table: "CertificateLogs",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_Members_AssociationUnitId",
                table: "Members",
                column: "AssociationUnitId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CertificateLogs");

            migrationBuilder.DropTable(
                name: "CertificateReceivers");

            migrationBuilder.DropTable(
                name: "Members");

            migrationBuilder.DropTable(
                name: "AssociationUnits");

            migrationBuilder.DropTable(
                name: "Associations");

            migrationBuilder.DropTable(
                name: "AssociationTypes");
        }
    }
}
