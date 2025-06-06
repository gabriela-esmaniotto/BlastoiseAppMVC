﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlastoiseApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class CriacaoTabelaContact : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contact",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Nome do contato"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "E-mail do contato"),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Mensagem do contato"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.Id);
                },
                comment: "Tabela de registro dos contatos");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contact");
        }
    }
}
