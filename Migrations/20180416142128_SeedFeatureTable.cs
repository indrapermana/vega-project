﻿using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace vega.Migrations
{
    public partial class SeedFeatureTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Features1')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Features2')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Features3')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Features WHERE Name in ('Features1', 'Features2', 'Features3')");

        }
    }
}
