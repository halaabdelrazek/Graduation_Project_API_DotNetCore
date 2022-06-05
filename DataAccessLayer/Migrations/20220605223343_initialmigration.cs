using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class initialmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Carriers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Carrier_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Carrier_Phone = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carriers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    First_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Last_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Company_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Avarage_Rateing = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ShippingPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Tax = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OrderStatus = table.Column<int>(type: "int", nullable: false),
                    DeliverDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CarrierId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Carriers_CarrierId",
                        column: x => x.CarrierId,
                        principalTable: "Carriers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "SubCategories",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategories", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SubCategories_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCart",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCart", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShoppingCart_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "UsersClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UsersClaims_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Wishlists",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wishlists", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Wishlists_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "ContactDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Street1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Street2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContactDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ContactDetails_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Accessories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Rating = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Discount_Percent = table.Column<double>(type: "float", nullable: false),
                    Avaiable_Units = table.Column<int>(type: "int", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    In_Stock = table.Column<bool>(type: "bit", nullable: false),
                    Weight = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubCategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accessories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Accessories_SubCategories_SubCategoryId",
                        column: x => x.SubCategoryId,
                        principalTable: "SubCategories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Accessories_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "CardioEquipments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Rating = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Discount_Percent = table.Column<double>(type: "float", nullable: false),
                    Avaiable_Units = table.Column<int>(type: "int", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    In_Stock = table.Column<bool>(type: "bit", nullable: false),
                    Weight = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubCategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Material = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dimensions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardioEquipments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CardioEquipments_SubCategories_SubCategoryId",
                        column: x => x.SubCategoryId,
                        principalTable: "SubCategories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_CardioEquipments_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Laptops",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Rating = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Discount_Percent = table.Column<double>(type: "float", nullable: false),
                    Avaiable_Units = table.Column<int>(type: "int", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    In_Stock = table.Column<bool>(type: "bit", nullable: false),
                    Weight = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubCategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ScreenSize = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MemorySpeed = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CPUModel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CPUSpeed = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SSDSize = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HDDSize = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalUSBPorts = table.Column<int>(type: "int", nullable: true),
                    ProcessorCount = table.Column<int>(type: "int", nullable: false),
                    CPU = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GraphicsCard = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Laptops", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Laptops_SubCategories_SubCategoryId",
                        column: x => x.SubCategoryId,
                        principalTable: "SubCategories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Laptops_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "MakeUps",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Rating = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Discount_Percent = table.Column<double>(type: "float", nullable: false),
                    Avaiable_Units = table.Column<int>(type: "int", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    In_Stock = table.Column<bool>(type: "bit", nullable: false),
                    Weight = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubCategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SkinTone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkinType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dimensions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MakeUps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MakeUps_SubCategories_SubCategoryId",
                        column: x => x.SubCategoryId,
                        principalTable: "SubCategories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_MakeUps_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "MobilePhones",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Rating = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Discount_Percent = table.Column<double>(type: "float", nullable: false),
                    Avaiable_Units = table.Column<int>(type: "int", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    In_Stock = table.Column<bool>(type: "bit", nullable: false),
                    Weight = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubCategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OpreatingSystem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MemoryRAM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StorageCapacity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DisplayType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ScreenSize = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CellularTechnology = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModelYear = table.Column<int>(type: "int", nullable: false),
                    SIMCardSlotCount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MobilePhones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MobilePhones_SubCategories_SubCategoryId",
                        column: x => x.SubCategoryId,
                        principalTable: "SubCategories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_MobilePhones_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Monitors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Rating = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Discount_Percent = table.Column<double>(type: "float", nullable: false),
                    Avaiable_Units = table.Column<int>(type: "int", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    In_Stock = table.Column<bool>(type: "bit", nullable: false),
                    Weight = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubCategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ScreenSize = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RefreshRate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Monitors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Monitors_SubCategories_SubCategoryId",
                        column: x => x.SubCategoryId,
                        principalTable: "SubCategories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Monitors_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "PCGamings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Rating = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Discount_Percent = table.Column<double>(type: "float", nullable: false),
                    Avaiable_Units = table.Column<int>(type: "int", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    In_Stock = table.Column<bool>(type: "bit", nullable: false),
                    Weight = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubCategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MemorySpeed = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CPUSpeed = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GraphicsCard = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PCGamings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PCGamings_SubCategories_SubCategoryId",
                        column: x => x.SubCategoryId,
                        principalTable: "SubCategories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_PCGamings_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Perfumes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Rating = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Discount_Percent = table.Column<double>(type: "float", nullable: false),
                    Avaiable_Units = table.Column<int>(type: "int", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    In_Stock = table.Column<bool>(type: "bit", nullable: false),
                    Weight = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubCategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Volume = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Scent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Perfumes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Perfumes_SubCategories_SubCategoryId",
                        column: x => x.SubCategoryId,
                        principalTable: "SubCategories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Perfumes_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "ShoesSports",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Rating = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Discount_Percent = table.Column<double>(type: "float", nullable: false),
                    Avaiable_Units = table.Column<int>(type: "int", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    In_Stock = table.Column<bool>(type: "bit", nullable: false),
                    Weight = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubCategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Size = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoesSports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShoesSports_SubCategories_SubCategoryId",
                        column: x => x.SubCategoryId,
                        principalTable: "SubCategories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ShoesSports_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "SportsSupplements",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Rating = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Discount_Percent = table.Column<double>(type: "float", nullable: false),
                    Avaiable_Units = table.Column<int>(type: "int", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    In_Stock = table.Column<bool>(type: "bit", nullable: false),
                    Weight = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubCategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Flavour = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Format = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dimensions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SportsSupplements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SportsSupplements_SubCategories_SubCategoryId",
                        column: x => x.SubCategoryId,
                        principalTable: "SubCategories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_SportsSupplements_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Tablets",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Rating = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Discount_Percent = table.Column<double>(type: "float", nullable: false),
                    Avaiable_Units = table.Column<int>(type: "int", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    In_Stock = table.Column<bool>(type: "bit", nullable: false),
                    Weight = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubCategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OpreatingSystem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MemoryRAM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StorageCapacity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DisplayType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ScreenSize = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CellularTechnology = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModelYear = table.Column<int>(type: "int", nullable: false),
                    SIMCardSlotCount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dimensions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tablets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tablets_SubCategories_SubCategoryId",
                        column: x => x.SubCategoryId,
                        principalTable: "SubCategories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Tablets_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "ProductCart",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ShoppingCartId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AccessoriesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CardioEquipmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LaptopId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MakeUpId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MobilePhoneId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MonitorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PCGamingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PerfumeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ShoesSportId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SportsSupplementsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TabletId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCart", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductCart_Accessories_AccessoriesId",
                        column: x => x.AccessoriesId,
                        principalTable: "Accessories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ProductCart_CardioEquipments_CardioEquipmentId",
                        column: x => x.CardioEquipmentId,
                        principalTable: "CardioEquipments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ProductCart_Laptops_LaptopId",
                        column: x => x.LaptopId,
                        principalTable: "Laptops",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ProductCart_MakeUps_MakeUpId",
                        column: x => x.MakeUpId,
                        principalTable: "MakeUps",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ProductCart_MobilePhones_MobilePhoneId",
                        column: x => x.MobilePhoneId,
                        principalTable: "MobilePhones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ProductCart_Monitors_MonitorId",
                        column: x => x.MonitorId,
                        principalTable: "Monitors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ProductCart_PCGamings_PCGamingId",
                        column: x => x.PCGamingId,
                        principalTable: "PCGamings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ProductCart_Perfumes_PerfumeId",
                        column: x => x.PerfumeId,
                        principalTable: "Perfumes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ProductCart_ShoesSports_ShoesSportId",
                        column: x => x.ShoesSportId,
                        principalTable: "ShoesSports",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ProductCart_ShoppingCart_ShoppingCartId",
                        column: x => x.ShoppingCartId,
                        principalTable: "ShoppingCart",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ProductCart_SportsSupplements_SportsSupplementsId",
                        column: x => x.SportsSupplementsId,
                        principalTable: "SportsSupplements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ProductCart_Tablets_TabletId",
                        column: x => x.TabletId,
                        principalTable: "Tablets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "ProductImage",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccessoriesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CardioEquipmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LaptopId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MakeUpId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MobilePhoneId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MonitorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PCGamingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PerfumeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ShoesSportId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SportsSupplementsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TabletId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImage_Accessories_AccessoriesId",
                        column: x => x.AccessoriesId,
                        principalTable: "Accessories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ProductImage_CardioEquipments_CardioEquipmentId",
                        column: x => x.CardioEquipmentId,
                        principalTable: "CardioEquipments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ProductImage_Laptops_LaptopId",
                        column: x => x.LaptopId,
                        principalTable: "Laptops",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ProductImage_MakeUps_MakeUpId",
                        column: x => x.MakeUpId,
                        principalTable: "MakeUps",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ProductImage_MobilePhones_MobilePhoneId",
                        column: x => x.MobilePhoneId,
                        principalTable: "MobilePhones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ProductImage_Monitors_MonitorId",
                        column: x => x.MonitorId,
                        principalTable: "Monitors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ProductImage_PCGamings_PCGamingId",
                        column: x => x.PCGamingId,
                        principalTable: "PCGamings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ProductImage_Perfumes_PerfumeId",
                        column: x => x.PerfumeId,
                        principalTable: "Perfumes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ProductImage_ShoesSports_ShoesSportId",
                        column: x => x.ShoesSportId,
                        principalTable: "ShoesSports",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ProductImage_SportsSupplements_SportsSupplementsId",
                        column: x => x.SportsSupplementsId,
                        principalTable: "SportsSupplements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ProductImage_Tablets_TabletId",
                        column: x => x.TabletId,
                        principalTable: "Tablets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "ProductOrders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AccessoriesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CardioEquipmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LaptopId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MakeUpId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MobilePhoneId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MonitorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PCGamingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PerfumeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ShoesSportId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SportsSupplementsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TabletId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductOrders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductOrders_Accessories_AccessoriesId",
                        column: x => x.AccessoriesId,
                        principalTable: "Accessories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ProductOrders_CardioEquipments_CardioEquipmentId",
                        column: x => x.CardioEquipmentId,
                        principalTable: "CardioEquipments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ProductOrders_Laptops_LaptopId",
                        column: x => x.LaptopId,
                        principalTable: "Laptops",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ProductOrders_MakeUps_MakeUpId",
                        column: x => x.MakeUpId,
                        principalTable: "MakeUps",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ProductOrders_MobilePhones_MobilePhoneId",
                        column: x => x.MobilePhoneId,
                        principalTable: "MobilePhones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ProductOrders_Monitors_MonitorId",
                        column: x => x.MonitorId,
                        principalTable: "Monitors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ProductOrders_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ProductOrders_PCGamings_PCGamingId",
                        column: x => x.PCGamingId,
                        principalTable: "PCGamings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ProductOrders_Perfumes_PerfumeId",
                        column: x => x.PerfumeId,
                        principalTable: "Perfumes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ProductOrders_ShoesSports_ShoesSportId",
                        column: x => x.ShoesSportId,
                        principalTable: "ShoesSports",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ProductOrders_SportsSupplements_SportsSupplementsId",
                        column: x => x.SportsSupplementsId,
                        principalTable: "SportsSupplements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ProductOrders_Tablets_TabletId",
                        column: x => x.TabletId,
                        principalTable: "Tablets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Reviewes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReviewText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReviewDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AccessoriesId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CardioEquipmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LaptopId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MakeUpId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MobilePhoneId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MonitorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PCGamingId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PerfumeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ShoesSportId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SportsSupplementsId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TabletId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviewes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviewes_Accessories_AccessoriesId",
                        column: x => x.AccessoriesId,
                        principalTable: "Accessories",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Reviewes_CardioEquipments_CardioEquipmentId",
                        column: x => x.CardioEquipmentId,
                        principalTable: "CardioEquipments",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Reviewes_Laptops_LaptopId",
                        column: x => x.LaptopId,
                        principalTable: "Laptops",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Reviewes_MakeUps_MakeUpId",
                        column: x => x.MakeUpId,
                        principalTable: "MakeUps",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Reviewes_MobilePhones_MobilePhoneId",
                        column: x => x.MobilePhoneId,
                        principalTable: "MobilePhones",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Reviewes_Monitors_MonitorId",
                        column: x => x.MonitorId,
                        principalTable: "Monitors",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Reviewes_PCGamings_PCGamingId",
                        column: x => x.PCGamingId,
                        principalTable: "PCGamings",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Reviewes_Perfumes_PerfumeId",
                        column: x => x.PerfumeId,
                        principalTable: "Perfumes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Reviewes_ShoesSports_ShoesSportId",
                        column: x => x.ShoesSportId,
                        principalTable: "ShoesSports",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Reviewes_SportsSupplements_SportsSupplementsId",
                        column: x => x.SportsSupplementsId,
                        principalTable: "SportsSupplements",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Reviewes_Tablets_TabletId",
                        column: x => x.TabletId,
                        principalTable: "Tablets",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Reviewes_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "WishlistProducts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WishlistId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AccessoriesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CardioEquipmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LaptopId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MakeUpId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MobilePhoneId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MonitorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PCGamingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PerfumeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ShoesSportId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SportsSupplementsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TabletId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WishlistProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WishlistProducts_Accessories_AccessoriesId",
                        column: x => x.AccessoriesId,
                        principalTable: "Accessories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_WishlistProducts_CardioEquipments_CardioEquipmentId",
                        column: x => x.CardioEquipmentId,
                        principalTable: "CardioEquipments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_WishlistProducts_Laptops_LaptopId",
                        column: x => x.LaptopId,
                        principalTable: "Laptops",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_WishlistProducts_MakeUps_MakeUpId",
                        column: x => x.MakeUpId,
                        principalTable: "MakeUps",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_WishlistProducts_MobilePhones_MobilePhoneId",
                        column: x => x.MobilePhoneId,
                        principalTable: "MobilePhones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_WishlistProducts_Monitors_MonitorId",
                        column: x => x.MonitorId,
                        principalTable: "Monitors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_WishlistProducts_PCGamings_PCGamingId",
                        column: x => x.PCGamingId,
                        principalTable: "PCGamings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_WishlistProducts_Perfumes_PerfumeId",
                        column: x => x.PerfumeId,
                        principalTable: "Perfumes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_WishlistProducts_ShoesSports_ShoesSportId",
                        column: x => x.ShoesSportId,
                        principalTable: "ShoesSports",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_WishlistProducts_SportsSupplements_SportsSupplementsId",
                        column: x => x.SportsSupplementsId,
                        principalTable: "SportsSupplements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_WishlistProducts_Tablets_TabletId",
                        column: x => x.TabletId,
                        principalTable: "Tablets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_WishlistProducts_Wishlists_WishlistId",
                        column: x => x.WishlistId,
                        principalTable: "Wishlists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Accessories_SubCategoryId",
                table: "Accessories",
                column: "SubCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Accessories_UserId",
                table: "Accessories",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_CardioEquipments_SubCategoryId",
                table: "CardioEquipments",
                column: "SubCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CardioEquipments_UserId",
                table: "CardioEquipments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ContactDetails_OrderId",
                table: "ContactDetails",
                column: "OrderId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ContactDetails_UserId",
                table: "ContactDetails",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Laptops_SubCategoryId",
                table: "Laptops",
                column: "SubCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Laptops_UserId",
                table: "Laptops",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_MakeUps_SubCategoryId",
                table: "MakeUps",
                column: "SubCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_MakeUps_UserId",
                table: "MakeUps",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_MobilePhones_SubCategoryId",
                table: "MobilePhones",
                column: "SubCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_MobilePhones_UserId",
                table: "MobilePhones",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Monitors_SubCategoryId",
                table: "Monitors",
                column: "SubCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Monitors_UserId",
                table: "Monitors",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CarrierId",
                table: "Orders",
                column: "CarrierId");

            migrationBuilder.CreateIndex(
                name: "IX_PCGamings_SubCategoryId",
                table: "PCGamings",
                column: "SubCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_PCGamings_UserId",
                table: "PCGamings",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Perfumes_SubCategoryId",
                table: "Perfumes",
                column: "SubCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Perfumes_UserId",
                table: "Perfumes",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCart_AccessoriesId",
                table: "ProductCart",
                column: "AccessoriesId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCart_CardioEquipmentId",
                table: "ProductCart",
                column: "CardioEquipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCart_LaptopId",
                table: "ProductCart",
                column: "LaptopId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCart_MakeUpId",
                table: "ProductCart",
                column: "MakeUpId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCart_MobilePhoneId",
                table: "ProductCart",
                column: "MobilePhoneId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCart_MonitorId",
                table: "ProductCart",
                column: "MonitorId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCart_PCGamingId",
                table: "ProductCart",
                column: "PCGamingId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCart_PerfumeId",
                table: "ProductCart",
                column: "PerfumeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCart_ShoesSportId",
                table: "ProductCart",
                column: "ShoesSportId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCart_ShoppingCartId",
                table: "ProductCart",
                column: "ShoppingCartId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCart_SportsSupplementsId",
                table: "ProductCart",
                column: "SportsSupplementsId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCart_TabletId",
                table: "ProductCart",
                column: "TabletId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImage_AccessoriesId",
                table: "ProductImage",
                column: "AccessoriesId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImage_CardioEquipmentId",
                table: "ProductImage",
                column: "CardioEquipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImage_LaptopId",
                table: "ProductImage",
                column: "LaptopId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImage_MakeUpId",
                table: "ProductImage",
                column: "MakeUpId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImage_MobilePhoneId",
                table: "ProductImage",
                column: "MobilePhoneId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImage_MonitorId",
                table: "ProductImage",
                column: "MonitorId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImage_PCGamingId",
                table: "ProductImage",
                column: "PCGamingId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImage_PerfumeId",
                table: "ProductImage",
                column: "PerfumeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImage_ShoesSportId",
                table: "ProductImage",
                column: "ShoesSportId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImage_SportsSupplementsId",
                table: "ProductImage",
                column: "SportsSupplementsId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImage_TabletId",
                table: "ProductImage",
                column: "TabletId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductOrders_AccessoriesId",
                table: "ProductOrders",
                column: "AccessoriesId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductOrders_CardioEquipmentId",
                table: "ProductOrders",
                column: "CardioEquipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductOrders_LaptopId",
                table: "ProductOrders",
                column: "LaptopId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductOrders_MakeUpId",
                table: "ProductOrders",
                column: "MakeUpId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductOrders_MobilePhoneId",
                table: "ProductOrders",
                column: "MobilePhoneId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductOrders_MonitorId",
                table: "ProductOrders",
                column: "MonitorId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductOrders_OrderId",
                table: "ProductOrders",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductOrders_PCGamingId",
                table: "ProductOrders",
                column: "PCGamingId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductOrders_PerfumeId",
                table: "ProductOrders",
                column: "PerfumeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductOrders_ShoesSportId",
                table: "ProductOrders",
                column: "ShoesSportId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductOrders_SportsSupplementsId",
                table: "ProductOrders",
                column: "SportsSupplementsId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductOrders_TabletId",
                table: "ProductOrders",
                column: "TabletId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviewes_AccessoriesId",
                table: "Reviewes",
                column: "AccessoriesId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviewes_CardioEquipmentId",
                table: "Reviewes",
                column: "CardioEquipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviewes_LaptopId",
                table: "Reviewes",
                column: "LaptopId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviewes_MakeUpId",
                table: "Reviewes",
                column: "MakeUpId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviewes_MobilePhoneId",
                table: "Reviewes",
                column: "MobilePhoneId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviewes_MonitorId",
                table: "Reviewes",
                column: "MonitorId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviewes_PCGamingId",
                table: "Reviewes",
                column: "PCGamingId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviewes_PerfumeId",
                table: "Reviewes",
                column: "PerfumeId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviewes_ShoesSportId",
                table: "Reviewes",
                column: "ShoesSportId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviewes_SportsSupplementsId",
                table: "Reviewes",
                column: "SportsSupplementsId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviewes_TabletId",
                table: "Reviewes",
                column: "TabletId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviewes_UserId",
                table: "Reviewes",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoesSports_SubCategoryId",
                table: "ShoesSports",
                column: "SubCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoesSports_UserId",
                table: "ShoesSports",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCart_UserId",
                table: "ShoppingCart",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SportsSupplements_SubCategoryId",
                table: "SportsSupplements",
                column: "SubCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_SportsSupplements_UserId",
                table: "SportsSupplements",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SubCategories_CategoryID",
                table: "SubCategories",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Tablets_SubCategoryId",
                table: "Tablets",
                column: "SubCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Tablets_UserId",
                table: "Tablets",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "Users",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "Users",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_UsersClaims_UserId",
                table: "UsersClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_WishlistProducts_AccessoriesId",
                table: "WishlistProducts",
                column: "AccessoriesId");

            migrationBuilder.CreateIndex(
                name: "IX_WishlistProducts_CardioEquipmentId",
                table: "WishlistProducts",
                column: "CardioEquipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_WishlistProducts_LaptopId",
                table: "WishlistProducts",
                column: "LaptopId");

            migrationBuilder.CreateIndex(
                name: "IX_WishlistProducts_MakeUpId",
                table: "WishlistProducts",
                column: "MakeUpId");

            migrationBuilder.CreateIndex(
                name: "IX_WishlistProducts_MobilePhoneId",
                table: "WishlistProducts",
                column: "MobilePhoneId");

            migrationBuilder.CreateIndex(
                name: "IX_WishlistProducts_MonitorId",
                table: "WishlistProducts",
                column: "MonitorId");

            migrationBuilder.CreateIndex(
                name: "IX_WishlistProducts_PCGamingId",
                table: "WishlistProducts",
                column: "PCGamingId");

            migrationBuilder.CreateIndex(
                name: "IX_WishlistProducts_PerfumeId",
                table: "WishlistProducts",
                column: "PerfumeId");

            migrationBuilder.CreateIndex(
                name: "IX_WishlistProducts_ShoesSportId",
                table: "WishlistProducts",
                column: "ShoesSportId");

            migrationBuilder.CreateIndex(
                name: "IX_WishlistProducts_SportsSupplementsId",
                table: "WishlistProducts",
                column: "SportsSupplementsId");

            migrationBuilder.CreateIndex(
                name: "IX_WishlistProducts_TabletId",
                table: "WishlistProducts",
                column: "TabletId");

            migrationBuilder.CreateIndex(
                name: "IX_WishlistProducts_WishlistId",
                table: "WishlistProducts",
                column: "WishlistId");

            migrationBuilder.CreateIndex(
                name: "IX_Wishlists_UserId",
                table: "Wishlists",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "ContactDetails");

            migrationBuilder.DropTable(
                name: "ProductCart");

            migrationBuilder.DropTable(
                name: "ProductImage");

            migrationBuilder.DropTable(
                name: "ProductOrders");

            migrationBuilder.DropTable(
                name: "Reviewes");

            migrationBuilder.DropTable(
                name: "UsersClaims");

            migrationBuilder.DropTable(
                name: "WishlistProducts");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "ShoppingCart");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Accessories");

            migrationBuilder.DropTable(
                name: "CardioEquipments");

            migrationBuilder.DropTable(
                name: "Laptops");

            migrationBuilder.DropTable(
                name: "MakeUps");

            migrationBuilder.DropTable(
                name: "MobilePhones");

            migrationBuilder.DropTable(
                name: "Monitors");

            migrationBuilder.DropTable(
                name: "PCGamings");

            migrationBuilder.DropTable(
                name: "Perfumes");

            migrationBuilder.DropTable(
                name: "ShoesSports");

            migrationBuilder.DropTable(
                name: "SportsSupplements");

            migrationBuilder.DropTable(
                name: "Tablets");

            migrationBuilder.DropTable(
                name: "Wishlists");

            migrationBuilder.DropTable(
                name: "Carriers");

            migrationBuilder.DropTable(
                name: "SubCategories");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
