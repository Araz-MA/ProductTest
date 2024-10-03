using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CleanArchitecture.Persistence.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Rangarang_IdentityRole",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rangarang_IdentityRole", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rangarang_IdentityUser",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Age = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rangarang_IdentityUser", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rangarang_Product",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductGroupId = table.Column<int>(type: "int", nullable: false),
                    WorkTypeId = table.Column<int>(type: "int", nullable: false),
                    ProductType = table.Column<byte>(type: "tinyint", nullable: false),
                    Circulation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CopyCount = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PageCount = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrintSide = table.Column<byte>(type: "tinyint", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    IsCalculatePrice = table.Column<bool>(type: "bit", nullable: false),
                    IsCustomCirculation = table.Column<bool>(type: "bit", nullable: false),
                    IsCustomSize = table.Column<bool>(type: "bit", nullable: false),
                    IsCustomPage = table.Column<bool>(type: "bit", nullable: false),
                    MinCirculation = table.Column<int>(type: "int", nullable: false),
                    MaxCirculation = table.Column<int>(type: "int", nullable: false),
                    MinPage = table.Column<int>(type: "int", nullable: false),
                    MaxPage = table.Column<int>(type: "int", nullable: false),
                    MinWidth = table.Column<float>(type: "real", nullable: false),
                    MaxWidth = table.Column<float>(type: "real", nullable: false),
                    MinLength = table.Column<float>(type: "real", nullable: false),
                    MaxLength = table.Column<float>(type: "real", nullable: false),
                    SheetDimensionId = table.Column<int>(type: "int", nullable: false),
                    FileExtension = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsCmyk = table.Column<bool>(type: "bit", nullable: false),
                    cutMargin = table.Column<float>(type: "real", nullable: false),
                    printMargin = table.Column<float>(type: "real", nullable: false),
                    IsCheckFile = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rangarang_Product", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rangarang_IdentityRoleClaim",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rangarang_IdentityRoleClaim", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rangarang_IdentityRoleClaim_Rangarang_IdentityRole_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Rangarang_IdentityRole",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rangarang_IdentityUserClaim",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rangarang_IdentityUserClaim", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rangarang_IdentityUserClaim_Rangarang_IdentityUser_UserId",
                        column: x => x.UserId,
                        principalTable: "Rangarang_IdentityUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rangarang_IdentityUserLogin",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rangarang_IdentityUserLogin", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_Rangarang_IdentityUserLogin_Rangarang_IdentityUser_UserId",
                        column: x => x.UserId,
                        principalTable: "Rangarang_IdentityUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rangarang_IdentityUserRole",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rangarang_IdentityUserRole", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_Rangarang_IdentityUserRole_Rangarang_IdentityRole_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Rangarang_IdentityRole",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rangarang_IdentityUserRole_Rangarang_IdentityUser_UserId",
                        column: x => x.UserId,
                        principalTable: "Rangarang_IdentityUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rangarang_IdentityUserToken",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rangarang_IdentityUserToken", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_Rangarang_IdentityUserToken_Rangarang_IdentityUser_UserId",
                        column: x => x.UserId,
                        principalTable: "Rangarang_IdentityUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rangarang_ProductAdt",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdtId = table.Column<int>(type: "int", nullable: false),
                    Required = table.Column<bool>(type: "bit", nullable: false),
                    Side = table.Column<byte>(type: "tinyint", nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false),
                    IsJeld = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rangarang_ProductAdt", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rangarang_ProductAdt_Rangarang_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Rangarang_Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rangarang_ProductDeliver",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsIncreased = table.Column<bool>(type: "bit", nullable: false),
                    StartCirculation = table.Column<int>(type: "int", nullable: false),
                    EndCirculation = table.Column<int>(type: "int", nullable: false),
                    PrintSide = table.Column<byte>(type: "tinyint", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false),
                    CalcType = table.Column<byte>(type: "tinyint", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rangarang_ProductDeliver", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rangarang_ProductDeliver_Rangarang_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Rangarang_Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rangarang_ProductMaterial",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaterialId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsJeld = table.Column<bool>(type: "bit", nullable: false),
                    Required = table.Column<bool>(type: "bit", nullable: false),
                    IsCustomCirculation = table.Column<bool>(type: "bit", nullable: false),
                    IsCombinedMaterial = table.Column<bool>(type: "bit", nullable: false),
                    Weight = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rangarang_ProductMaterial", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rangarang_ProductMaterial_Rangarang_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Rangarang_Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rangarang_ProductPrintKind",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrintKind = table.Column<int>(type: "int", nullable: false),
                    IsJeld = table.Column<bool>(type: "bit", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rangarang_ProductPrintKind", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rangarang_ProductPrintKind_Rangarang_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Rangarang_Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rangarang_ProductSize",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    length = table.Column<bool>(type: "bit", nullable: false),
                    width = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SheetCount = table.Column<int>(type: "int", nullable: false),
                    sheetDimensionId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rangarang_ProductSize", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rangarang_ProductSize_Rangarang_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Rangarang_Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rangarang_ProductAdtType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdtTypeId = table.Column<int>(type: "int", nullable: false),
                    ProductAdtId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rangarang_ProductAdtType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rangarang_ProductAdtType_Rangarang_ProductAdt_ProductAdtId",
                        column: x => x.ProductAdtId,
                        principalTable: "Rangarang_ProductAdt",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Rangarang_ProductMaterialAttribute",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    productMaterialId = table.Column<int>(type: "int", nullable: false),
                    MaterialAttributeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rangarang_ProductMaterialAttribute", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rangarang_ProductMaterialAttribute_Rangarang_ProductMaterial_MaterialAttributeId",
                        column: x => x.MaterialAttributeId,
                        principalTable: "Rangarang_ProductMaterial",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProductDeliverSize",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductDeliverId = table.Column<int>(type: "int", nullable: false),
                    ProductSizeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductDeliverSize", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductDeliverSize_Rangarang_ProductDeliver_ProductDeliverId",
                        column: x => x.ProductDeliverId,
                        principalTable: "Rangarang_ProductDeliver",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductDeliverSize_Rangarang_ProductSize_ProductSizeId",
                        column: x => x.ProductSizeId,
                        principalTable: "Rangarang_ProductSize",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Rangarang_ProductPrice",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<float>(type: "real", nullable: false),
                    Circulation = table.Column<int>(type: "int", nullable: false),
                    IsDoubleSided = table.Column<bool>(type: "bit", nullable: false),
                    PageCount = table.Column<int>(type: "int", nullable: false),
                    CopyCount = table.Column<int>(type: "int", nullable: false),
                    IsJeld = table.Column<bool>(type: "bit", nullable: false),
                    ProductPrintKindId = table.Column<int>(type: "int", nullable: false),
                    ProductMaterialId = table.Column<int>(type: "int", nullable: false),
                    ProductSizeId = table.Column<int>(type: "int", nullable: false),
                    ProductMaterialAttributeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rangarang_ProductPrice", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rangarang_ProductPrice_Rangarang_ProductMaterial_ProductMaterialId",
                        column: x => x.ProductMaterialId,
                        principalTable: "Rangarang_ProductMaterial",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Rangarang_ProductPrice_Rangarang_ProductMaterialAttribute_ProductMaterialAttributeId",
                        column: x => x.ProductMaterialAttributeId,
                        principalTable: "Rangarang_ProductMaterialAttribute",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Rangarang_ProductPrice_Rangarang_ProductPrintKind_ProductPrintKindId",
                        column: x => x.ProductPrintKindId,
                        principalTable: "Rangarang_ProductPrintKind",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Rangarang_ProductPrice_Rangarang_ProductSize_ProductSizeId",
                        column: x => x.ProductSizeId,
                        principalTable: "Rangarang_ProductSize",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProductAdtPrice",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<int>(type: "int", nullable: false),
                    ProductPriceId = table.Column<int>(type: "int", nullable: false),
                    ProductAdtId = table.Column<int>(type: "int", nullable: false),
                    ProductAdtTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductAdtPrice", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductAdtPrice_Rangarang_ProductAdt_ProductAdtId",
                        column: x => x.ProductAdtId,
                        principalTable: "Rangarang_ProductAdt",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductAdtPrice_Rangarang_ProductAdtType_ProductAdtTypeId",
                        column: x => x.ProductAdtTypeId,
                        principalTable: "Rangarang_ProductAdtType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductAdtPrice_Rangarang_ProductPrice_ProductPriceId",
                        column: x => x.ProductPriceId,
                        principalTable: "Rangarang_ProductPrice",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductAdtPrice_ProductAdtId",
                table: "ProductAdtPrice",
                column: "ProductAdtId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductAdtPrice_ProductAdtTypeId",
                table: "ProductAdtPrice",
                column: "ProductAdtTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductAdtPrice_ProductPriceId",
                table: "ProductAdtPrice",
                column: "ProductPriceId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDeliverSize_ProductDeliverId",
                table: "ProductDeliverSize",
                column: "ProductDeliverId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDeliverSize_ProductSizeId",
                table: "ProductDeliverSize",
                column: "ProductSizeId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "Rangarang_IdentityRole",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Rangarang_IdentityRoleClaim_RoleId",
                table: "Rangarang_IdentityRoleClaim",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "Rangarang_IdentityUser",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "Rangarang_IdentityUser",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Rangarang_IdentityUserClaim_UserId",
                table: "Rangarang_IdentityUserClaim",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Rangarang_IdentityUserLogin_UserId",
                table: "Rangarang_IdentityUserLogin",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Rangarang_IdentityUserRole_RoleId",
                table: "Rangarang_IdentityUserRole",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Rangarang_ProductAdt_ProductId",
                table: "Rangarang_ProductAdt",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Rangarang_ProductAdtType_ProductAdtId",
                table: "Rangarang_ProductAdtType",
                column: "ProductAdtId");

            migrationBuilder.CreateIndex(
                name: "IX_Rangarang_ProductDeliver_ProductId",
                table: "Rangarang_ProductDeliver",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Rangarang_ProductMaterial_ProductId",
                table: "Rangarang_ProductMaterial",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Rangarang_ProductMaterialAttribute_MaterialAttributeId",
                table: "Rangarang_ProductMaterialAttribute",
                column: "MaterialAttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_Rangarang_ProductPrice_ProductMaterialAttributeId",
                table: "Rangarang_ProductPrice",
                column: "ProductMaterialAttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_Rangarang_ProductPrice_ProductMaterialId",
                table: "Rangarang_ProductPrice",
                column: "ProductMaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_Rangarang_ProductPrice_ProductPrintKindId",
                table: "Rangarang_ProductPrice",
                column: "ProductPrintKindId");

            migrationBuilder.CreateIndex(
                name: "IX_Rangarang_ProductPrice_ProductSizeId",
                table: "Rangarang_ProductPrice",
                column: "ProductSizeId");

            migrationBuilder.CreateIndex(
                name: "IX_Rangarang_ProductPrintKind_ProductId",
                table: "Rangarang_ProductPrintKind",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Rangarang_ProductSize_ProductId",
                table: "Rangarang_ProductSize",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductAdtPrice");

            migrationBuilder.DropTable(
                name: "ProductDeliverSize");

            migrationBuilder.DropTable(
                name: "Rangarang_IdentityRoleClaim");

            migrationBuilder.DropTable(
                name: "Rangarang_IdentityUserClaim");

            migrationBuilder.DropTable(
                name: "Rangarang_IdentityUserLogin");

            migrationBuilder.DropTable(
                name: "Rangarang_IdentityUserRole");

            migrationBuilder.DropTable(
                name: "Rangarang_IdentityUserToken");

            migrationBuilder.DropTable(
                name: "Rangarang_ProductAdtType");

            migrationBuilder.DropTable(
                name: "Rangarang_ProductPrice");

            migrationBuilder.DropTable(
                name: "Rangarang_ProductDeliver");

            migrationBuilder.DropTable(
                name: "Rangarang_IdentityRole");

            migrationBuilder.DropTable(
                name: "Rangarang_IdentityUser");

            migrationBuilder.DropTable(
                name: "Rangarang_ProductAdt");

            migrationBuilder.DropTable(
                name: "Rangarang_ProductMaterialAttribute");

            migrationBuilder.DropTable(
                name: "Rangarang_ProductPrintKind");

            migrationBuilder.DropTable(
                name: "Rangarang_ProductSize");

            migrationBuilder.DropTable(
                name: "Rangarang_ProductMaterial");

            migrationBuilder.DropTable(
                name: "Rangarang_Product");
        }
    }
}
