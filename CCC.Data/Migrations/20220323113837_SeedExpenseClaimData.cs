using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CCC.Data.Migrations
{
    public partial class SeedExpenseClaimData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Total",
                table: "ExpenseClaims",
                type: "numeric",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<decimal>(
                name: "Total",
                table: "ExpenseClaimDetails",
                type: "numeric",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.InsertData(
                table: "ExpenseClaims",
                columns: new[] { "ExpenseClaimId", "Date", "Description", "EmployeeId", "Status", "Total" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 3, 23, 11, 38, 36, 963, DateTimeKind.Utc).AddTicks(2709), "Test", 1, 2, 2000m },
                    { 2, new DateTime(2022, 3, 23, 11, 38, 36, 963, DateTimeKind.Utc).AddTicks(2715), "Test2", 1, 2, 2000m }
                });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 1,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2022, 3, 22, 11, 38, 36, 963, DateTimeKind.Utc).AddTicks(2608), new DateTime(2022, 3, 28, 11, 38, 36, 963, DateTimeKind.Utc).AddTicks(2615) });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 2,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2022, 3, 13, 11, 38, 36, 963, DateTimeKind.Utc).AddTicks(2621), new DateTime(2022, 3, 21, 11, 38, 36, 963, DateTimeKind.Utc).AddTicks(2621) });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 3,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2022, 3, 3, 11, 38, 36, 963, DateTimeKind.Utc).AddTicks(2622), new DateTime(2022, 3, 18, 11, 38, 36, 963, DateTimeKind.Utc).AddTicks(2623) });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 4,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2022, 3, 19, 11, 38, 36, 963, DateTimeKind.Utc).AddTicks(2624), new DateTime(2022, 3, 15, 11, 38, 36, 963, DateTimeKind.Utc).AddTicks(2624) });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 5,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2022, 3, 22, 11, 38, 36, 963, DateTimeKind.Utc).AddTicks(2625), new DateTime(2022, 3, 21, 11, 38, 36, 963, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 6,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2022, 3, 31, 11, 38, 36, 963, DateTimeKind.Utc).AddTicks(2628), new DateTime(2022, 4, 8, 11, 38, 36, 963, DateTimeKind.Utc).AddTicks(2628) });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 7,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2022, 3, 28, 11, 38, 36, 963, DateTimeKind.Utc).AddTicks(2629), new DateTime(2022, 4, 7, 11, 38, 36, 963, DateTimeKind.Utc).AddTicks(2630) });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 8,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2022, 3, 22, 11, 38, 36, 963, DateTimeKind.Utc).AddTicks(2631), new DateTime(2022, 3, 17, 11, 38, 36, 963, DateTimeKind.Utc).AddTicks(2631) });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 9,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2022, 3, 20, 11, 38, 36, 963, DateTimeKind.Utc).AddTicks(2632), new DateTime(2022, 3, 17, 11, 38, 36, 963, DateTimeKind.Utc).AddTicks(2633) });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 10,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2021, 12, 13, 11, 38, 36, 963, DateTimeKind.Utc).AddTicks(2635), new DateTime(2022, 1, 3, 11, 38, 36, 963, DateTimeKind.Utc).AddTicks(2635) });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 11,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2022, 1, 2, 11, 38, 36, 963, DateTimeKind.Utc).AddTicks(2636), new DateTime(2022, 1, 28, 11, 38, 36, 963, DateTimeKind.Utc).AddTicks(2636) });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 12,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2021, 12, 23, 11, 38, 36, 963, DateTimeKind.Utc).AddTicks(2637), new DateTime(2022, 1, 30, 11, 38, 36, 963, DateTimeKind.Utc).AddTicks(2638) });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 13,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2021, 12, 27, 11, 38, 36, 963, DateTimeKind.Utc).AddTicks(2639), new DateTime(2022, 1, 30, 11, 38, 36, 963, DateTimeKind.Utc).AddTicks(2639) });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 14,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2022, 3, 9, 11, 38, 36, 963, DateTimeKind.Utc).AddTicks(2640), new DateTime(2022, 3, 17, 11, 38, 36, 963, DateTimeKind.Utc).AddTicks(2640) });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 15,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2021, 12, 25, 11, 38, 36, 963, DateTimeKind.Utc).AddTicks(2641), new DateTime(2022, 2, 7, 11, 38, 36, 963, DateTimeKind.Utc).AddTicks(2642) });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 16,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2022, 2, 7, 11, 38, 36, 963, DateTimeKind.Utc).AddTicks(2643), new DateTime(2022, 3, 1, 11, 38, 36, 963, DateTimeKind.Utc).AddTicks(2643) });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 17,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2022, 1, 30, 11, 38, 36, 963, DateTimeKind.Utc).AddTicks(2644), new DateTime(2022, 2, 22, 11, 38, 36, 963, DateTimeKind.Utc).AddTicks(2644) });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 18,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2021, 10, 24, 11, 38, 36, 963, DateTimeKind.Utc).AddTicks(2646), new DateTime(2022, 1, 2, 11, 38, 36, 963, DateTimeKind.Utc).AddTicks(2647) });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 19,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2021, 10, 14, 11, 38, 36, 963, DateTimeKind.Utc).AddTicks(2648), new DateTime(2021, 12, 13, 11, 38, 36, 963, DateTimeKind.Utc).AddTicks(2648) });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 20,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2021, 10, 14, 11, 38, 36, 963, DateTimeKind.Utc).AddTicks(2649), new DateTime(2022, 1, 28, 11, 38, 36, 963, DateTimeKind.Utc).AddTicks(2650) });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 21,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2021, 10, 14, 11, 38, 36, 963, DateTimeKind.Utc).AddTicks(2651), new DateTime(2022, 1, 18, 11, 38, 36, 963, DateTimeKind.Utc).AddTicks(2651) });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 22,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2021, 10, 14, 11, 38, 36, 963, DateTimeKind.Utc).AddTicks(2652), new DateTime(2021, 12, 28, 11, 38, 36, 963, DateTimeKind.Utc).AddTicks(2652) });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 23,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2021, 10, 14, 11, 38, 36, 963, DateTimeKind.Utc).AddTicks(2653), new DateTime(2022, 1, 29, 11, 38, 36, 963, DateTimeKind.Utc).AddTicks(2654) });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 24,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2021, 10, 14, 11, 38, 36, 963, DateTimeKind.Utc).AddTicks(2654), new DateTime(2022, 3, 8, 11, 38, 36, 963, DateTimeKind.Utc).AddTicks(2655) });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 25,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2021, 10, 14, 11, 38, 36, 963, DateTimeKind.Utc).AddTicks(2656), new DateTime(2022, 3, 22, 11, 38, 36, 963, DateTimeKind.Utc).AddTicks(2656) });

            migrationBuilder.InsertData(
                table: "ExpenseClaimDetails",
                columns: new[] { "ExpenseClaimDetailId", "Date", "Description", "ExpenseClaimId", "Total" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 3, 23, 11, 38, 36, 963, DateTimeKind.Utc).AddTicks(2804), "Meals", 1, 1200m },
                    { 2, new DateTime(2022, 3, 23, 11, 38, 36, 963, DateTimeKind.Utc).AddTicks(2808), "Taxi", 1, 500m },
                    { 3, new DateTime(2022, 3, 23, 11, 38, 36, 963, DateTimeKind.Utc).AddTicks(2809), "Tools Rental", 1, 300m },
                    { 4, new DateTime(2022, 3, 23, 11, 38, 36, 963, DateTimeKind.Utc).AddTicks(2810), "Meals", 2, 1200m },
                    { 5, new DateTime(2022, 3, 23, 11, 38, 36, 963, DateTimeKind.Utc).AddTicks(2811), "Taxi", 2, 500m },
                    { 6, new DateTime(2022, 3, 23, 11, 38, 36, 963, DateTimeKind.Utc).AddTicks(2813), "Tools Rental", 2, 300m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ExpenseClaimDetails",
                keyColumn: "ExpenseClaimDetailId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ExpenseClaimDetails",
                keyColumn: "ExpenseClaimDetailId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ExpenseClaimDetails",
                keyColumn: "ExpenseClaimDetailId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ExpenseClaimDetails",
                keyColumn: "ExpenseClaimDetailId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ExpenseClaimDetails",
                keyColumn: "ExpenseClaimDetailId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ExpenseClaimDetails",
                keyColumn: "ExpenseClaimDetailId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ExpenseClaims",
                keyColumn: "ExpenseClaimId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ExpenseClaims",
                keyColumn: "ExpenseClaimId",
                keyValue: 2);

            migrationBuilder.AlterColumn<int>(
                name: "Total",
                table: "ExpenseClaims",
                type: "integer",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.AlterColumn<int>(
                name: "Total",
                table: "ExpenseClaimDetails",
                type: "integer",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 1,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2022, 3, 22, 11, 3, 56, 164, DateTimeKind.Utc).AddTicks(8180), new DateTime(2022, 3, 28, 11, 3, 56, 164, DateTimeKind.Utc).AddTicks(8186) });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 2,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2022, 3, 13, 11, 3, 56, 164, DateTimeKind.Utc).AddTicks(8189), new DateTime(2022, 3, 21, 11, 3, 56, 164, DateTimeKind.Utc).AddTicks(8190) });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 3,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2022, 3, 3, 11, 3, 56, 164, DateTimeKind.Utc).AddTicks(8191), new DateTime(2022, 3, 18, 11, 3, 56, 164, DateTimeKind.Utc).AddTicks(8192) });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 4,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2022, 3, 19, 11, 3, 56, 164, DateTimeKind.Utc).AddTicks(8192), new DateTime(2022, 3, 15, 11, 3, 56, 164, DateTimeKind.Utc).AddTicks(8193) });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 5,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2022, 3, 22, 11, 3, 56, 164, DateTimeKind.Utc).AddTicks(8194), new DateTime(2022, 3, 21, 11, 3, 56, 164, DateTimeKind.Utc).AddTicks(8194) });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 6,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2022, 3, 31, 11, 3, 56, 164, DateTimeKind.Utc).AddTicks(8196), new DateTime(2022, 4, 8, 11, 3, 56, 164, DateTimeKind.Utc).AddTicks(8197) });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 7,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2022, 3, 28, 11, 3, 56, 164, DateTimeKind.Utc).AddTicks(8198), new DateTime(2022, 4, 7, 11, 3, 56, 164, DateTimeKind.Utc).AddTicks(8198) });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 8,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2022, 3, 22, 11, 3, 56, 164, DateTimeKind.Utc).AddTicks(8199), new DateTime(2022, 3, 17, 11, 3, 56, 164, DateTimeKind.Utc).AddTicks(8200) });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 9,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2022, 3, 20, 11, 3, 56, 164, DateTimeKind.Utc).AddTicks(8200), new DateTime(2022, 3, 17, 11, 3, 56, 164, DateTimeKind.Utc).AddTicks(8201) });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 10,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2021, 12, 13, 11, 3, 56, 164, DateTimeKind.Utc).AddTicks(8202), new DateTime(2022, 1, 3, 11, 3, 56, 164, DateTimeKind.Utc).AddTicks(8203) });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 11,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2022, 1, 2, 11, 3, 56, 164, DateTimeKind.Utc).AddTicks(8203), new DateTime(2022, 1, 28, 11, 3, 56, 164, DateTimeKind.Utc).AddTicks(8204) });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 12,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2021, 12, 23, 11, 3, 56, 164, DateTimeKind.Utc).AddTicks(8205), new DateTime(2022, 1, 30, 11, 3, 56, 164, DateTimeKind.Utc).AddTicks(8205) });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 13,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2021, 12, 27, 11, 3, 56, 164, DateTimeKind.Utc).AddTicks(8206), new DateTime(2022, 1, 30, 11, 3, 56, 164, DateTimeKind.Utc).AddTicks(8206) });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 14,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2022, 3, 9, 11, 3, 56, 164, DateTimeKind.Utc).AddTicks(8207), new DateTime(2022, 3, 17, 11, 3, 56, 164, DateTimeKind.Utc).AddTicks(8207) });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 15,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2021, 12, 25, 11, 3, 56, 164, DateTimeKind.Utc).AddTicks(8208), new DateTime(2022, 2, 7, 11, 3, 56, 164, DateTimeKind.Utc).AddTicks(8208) });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 16,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2022, 2, 7, 11, 3, 56, 164, DateTimeKind.Utc).AddTicks(8209), new DateTime(2022, 3, 1, 11, 3, 56, 164, DateTimeKind.Utc).AddTicks(8209) });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 17,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2022, 1, 30, 11, 3, 56, 164, DateTimeKind.Utc).AddTicks(8210), new DateTime(2022, 2, 22, 11, 3, 56, 164, DateTimeKind.Utc).AddTicks(8211) });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 18,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2021, 10, 24, 11, 3, 56, 164, DateTimeKind.Utc).AddTicks(8212), new DateTime(2022, 1, 2, 11, 3, 56, 164, DateTimeKind.Utc).AddTicks(8212) });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 19,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2021, 10, 14, 11, 3, 56, 164, DateTimeKind.Utc).AddTicks(8213), new DateTime(2021, 12, 13, 11, 3, 56, 164, DateTimeKind.Utc).AddTicks(8214) });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 20,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2021, 10, 14, 11, 3, 56, 164, DateTimeKind.Utc).AddTicks(8214), new DateTime(2022, 1, 28, 11, 3, 56, 164, DateTimeKind.Utc).AddTicks(8215) });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 21,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2021, 10, 14, 11, 3, 56, 164, DateTimeKind.Utc).AddTicks(8216), new DateTime(2022, 1, 18, 11, 3, 56, 164, DateTimeKind.Utc).AddTicks(8216) });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 22,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2021, 10, 14, 11, 3, 56, 164, DateTimeKind.Utc).AddTicks(8217), new DateTime(2021, 12, 28, 11, 3, 56, 164, DateTimeKind.Utc).AddTicks(8217) });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 23,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2021, 10, 14, 11, 3, 56, 164, DateTimeKind.Utc).AddTicks(8218), new DateTime(2022, 1, 29, 11, 3, 56, 164, DateTimeKind.Utc).AddTicks(8218) });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 24,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2021, 10, 14, 11, 3, 56, 164, DateTimeKind.Utc).AddTicks(8220), new DateTime(2022, 3, 8, 11, 3, 56, 164, DateTimeKind.Utc).AddTicks(8220) });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 25,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2021, 10, 14, 11, 3, 56, 164, DateTimeKind.Utc).AddTicks(8221), new DateTime(2022, 3, 22, 11, 3, 56, 164, DateTimeKind.Utc).AddTicks(8221) });
        }
    }
}
