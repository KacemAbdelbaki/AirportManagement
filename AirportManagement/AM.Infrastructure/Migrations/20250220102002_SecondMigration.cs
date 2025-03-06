using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SecondMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlightPassenger_flights_FlightsFlightId",
                table: "FlightPassenger");

            migrationBuilder.DropForeignKey(
                name: "FK_FlightPassenger_passengers_PassengersPassengerId",
                table: "FlightPassenger");

            migrationBuilder.DropForeignKey(
                name: "FK_flights_planes_PlaneId",
                table: "flights");

            migrationBuilder.DropPrimaryKey(
                name: "PK_planes",
                table: "planes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_passengers",
                table: "passengers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_flights",
                table: "flights");

            migrationBuilder.RenameTable(
                name: "planes",
                newName: "Planes");

            migrationBuilder.RenameTable(
                name: "passengers",
                newName: "Passengers");

            migrationBuilder.RenameTable(
                name: "flights",
                newName: "Flights");

            migrationBuilder.RenameIndex(
                name: "IX_flights_PlaneId",
                table: "Flights",
                newName: "IX_Flights_PlaneId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Planes",
                table: "Planes",
                column: "PlaneId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Passengers",
                table: "Passengers",
                column: "PassengerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Flights",
                table: "Flights",
                column: "FlightId");

            migrationBuilder.AddForeignKey(
                name: "FK_FlightPassenger_Flights_FlightsFlightId",
                table: "FlightPassenger",
                column: "FlightsFlightId",
                principalTable: "Flights",
                principalColumn: "FlightId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FlightPassenger_Passengers_PassengersPassengerId",
                table: "FlightPassenger",
                column: "PassengersPassengerId",
                principalTable: "Passengers",
                principalColumn: "PassengerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Flights_Planes_PlaneId",
                table: "Flights",
                column: "PlaneId",
                principalTable: "Planes",
                principalColumn: "PlaneId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlightPassenger_Flights_FlightsFlightId",
                table: "FlightPassenger");

            migrationBuilder.DropForeignKey(
                name: "FK_FlightPassenger_Passengers_PassengersPassengerId",
                table: "FlightPassenger");

            migrationBuilder.DropForeignKey(
                name: "FK_Flights_Planes_PlaneId",
                table: "Flights");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Planes",
                table: "Planes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Passengers",
                table: "Passengers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Flights",
                table: "Flights");

            migrationBuilder.RenameTable(
                name: "Planes",
                newName: "planes");

            migrationBuilder.RenameTable(
                name: "Passengers",
                newName: "passengers");

            migrationBuilder.RenameTable(
                name: "Flights",
                newName: "flights");

            migrationBuilder.RenameIndex(
                name: "IX_Flights_PlaneId",
                table: "flights",
                newName: "IX_flights_PlaneId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_planes",
                table: "planes",
                column: "PlaneId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_passengers",
                table: "passengers",
                column: "PassengerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_flights",
                table: "flights",
                column: "FlightId");

            migrationBuilder.AddForeignKey(
                name: "FK_FlightPassenger_flights_FlightsFlightId",
                table: "FlightPassenger",
                column: "FlightsFlightId",
                principalTable: "flights",
                principalColumn: "FlightId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FlightPassenger_passengers_PassengersPassengerId",
                table: "FlightPassenger",
                column: "PassengersPassengerId",
                principalTable: "passengers",
                principalColumn: "PassengerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_flights_planes_PlaneId",
                table: "flights",
                column: "PlaneId",
                principalTable: "planes",
                principalColumn: "PlaneId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
