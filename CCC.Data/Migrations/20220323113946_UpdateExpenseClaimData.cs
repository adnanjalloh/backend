using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CCC.Data.Migrations
{
    public partial class UpdateExpenseClaimData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ExpenseClaimDetails",
                keyColumn: "ExpenseClaimDetailId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 3, 23, 11, 39, 45, 807, DateTimeKind.Utc).AddTicks(9889));

            migrationBuilder.UpdateData(
                table: "ExpenseClaimDetails",
                keyColumn: "ExpenseClaimDetailId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 3, 23, 11, 39, 45, 807, DateTimeKind.Utc).AddTicks(9891));

            migrationBuilder.UpdateData(
                table: "ExpenseClaimDetails",
                keyColumn: "ExpenseClaimDetailId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 3, 23, 11, 39, 45, 807, DateTimeKind.Utc).AddTicks(9892));

            migrationBuilder.UpdateData(
                table: "ExpenseClaimDetails",
                keyColumn: "ExpenseClaimDetailId",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2022, 3, 23, 11, 39, 45, 807, DateTimeKind.Utc).AddTicks(9893));

            migrationBuilder.UpdateData(
                table: "ExpenseClaimDetails",
                keyColumn: "ExpenseClaimDetailId",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2022, 3, 23, 11, 39, 45, 807, DateTimeKind.Utc).AddTicks(9893));

            migrationBuilder.UpdateData(
                table: "ExpenseClaimDetails",
                keyColumn: "ExpenseClaimDetailId",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2022, 3, 23, 11, 39, 45, 807, DateTimeKind.Utc).AddTicks(9895));

            migrationBuilder.UpdateData(
                table: "ExpenseClaims",
                keyColumn: "ExpenseClaimId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 3, 23, 11, 39, 45, 807, DateTimeKind.Utc).AddTicks(9821));

            migrationBuilder.UpdateData(
                table: "ExpenseClaims",
                keyColumn: "ExpenseClaimId",
                keyValue: 2,
                columns: new[] { "Date", "EmployeeId" },
                values: new object[] { new DateTime(2022, 3, 23, 11, 39, 45, 807, DateTimeKind.Utc).AddTicks(9824), 2 });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 1,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2022, 3, 22, 11, 39, 45, 807, DateTimeKind.Utc).AddTicks(9759), new DateTime(2022, 3, 28, 11, 39, 45, 807, DateTimeKind.Utc).AddTicks(9763) });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 2,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2022, 3, 13, 11, 39, 45, 807, DateTimeKind.Utc).AddTicks(9766), new DateTime(2022, 3, 21, 11, 39, 45, 807, DateTimeKind.Utc).AddTicks(9767) });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 3,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2022, 3, 3, 11, 39, 45, 807, DateTimeKind.Utc).AddTicks(9768), new DateTime(2022, 3, 18, 11, 39, 45, 807, DateTimeKind.Utc).AddTicks(9768) });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 4,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2022, 3, 19, 11, 39, 45, 807, DateTimeKind.Utc).AddTicks(9769), new DateTime(2022, 3, 15, 11, 39, 45, 807, DateTimeKind.Utc).AddTicks(9769) });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 5,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2022, 3, 22, 11, 39, 45, 807, DateTimeKind.Utc).AddTicks(9770), new DateTime(2022, 3, 21, 11, 39, 45, 807, DateTimeKind.Utc).AddTicks(9771) });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 6,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2022, 3, 31, 11, 39, 45, 807, DateTimeKind.Utc).AddTicks(9772), new DateTime(2022, 4, 8, 11, 39, 45, 807, DateTimeKind.Utc).AddTicks(9773) });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 7,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2022, 3, 28, 11, 39, 45, 807, DateTimeKind.Utc).AddTicks(9773), new DateTime(2022, 4, 7, 11, 39, 45, 807, DateTimeKind.Utc).AddTicks(9774) });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 8,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2022, 3, 22, 11, 39, 45, 807, DateTimeKind.Utc).AddTicks(9775), new DateTime(2022, 3, 17, 11, 39, 45, 807, DateTimeKind.Utc).AddTicks(9775) });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 9,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2022, 3, 20, 11, 39, 45, 807, DateTimeKind.Utc).AddTicks(9776), new DateTime(2022, 3, 17, 11, 39, 45, 807, DateTimeKind.Utc).AddTicks(9776) });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 10,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2021, 12, 13, 11, 39, 45, 807, DateTimeKind.Utc).AddTicks(9778), new DateTime(2022, 1, 3, 11, 39, 45, 807, DateTimeKind.Utc).AddTicks(9778) });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 11,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2022, 1, 2, 11, 39, 45, 807, DateTimeKind.Utc).AddTicks(9779), new DateTime(2022, 1, 28, 11, 39, 45, 807, DateTimeKind.Utc).AddTicks(9779) });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 12,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2021, 12, 23, 11, 39, 45, 807, DateTimeKind.Utc).AddTicks(9780), new DateTime(2022, 1, 30, 11, 39, 45, 807, DateTimeKind.Utc).AddTicks(9781) });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 13,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2021, 12, 27, 11, 39, 45, 807, DateTimeKind.Utc).AddTicks(9781), new DateTime(2022, 1, 30, 11, 39, 45, 807, DateTimeKind.Utc).AddTicks(9782) });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 14,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2022, 3, 9, 11, 39, 45, 807, DateTimeKind.Utc).AddTicks(9783), new DateTime(2022, 3, 17, 11, 39, 45, 807, DateTimeKind.Utc).AddTicks(9783) });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 15,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2021, 12, 25, 11, 39, 45, 807, DateTimeKind.Utc).AddTicks(9784), new DateTime(2022, 2, 7, 11, 39, 45, 807, DateTimeKind.Utc).AddTicks(9784) });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 16,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2022, 2, 7, 11, 39, 45, 807, DateTimeKind.Utc).AddTicks(9785), new DateTime(2022, 3, 1, 11, 39, 45, 807, DateTimeKind.Utc).AddTicks(9785) });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 17,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2022, 1, 30, 11, 39, 45, 807, DateTimeKind.Utc).AddTicks(9786), new DateTime(2022, 2, 22, 11, 39, 45, 807, DateTimeKind.Utc).AddTicks(9786) });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 18,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2021, 10, 24, 11, 39, 45, 807, DateTimeKind.Utc).AddTicks(9788), new DateTime(2022, 1, 2, 11, 39, 45, 807, DateTimeKind.Utc).AddTicks(9788) });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 19,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2021, 10, 14, 11, 39, 45, 807, DateTimeKind.Utc).AddTicks(9789), new DateTime(2021, 12, 13, 11, 39, 45, 807, DateTimeKind.Utc).AddTicks(9789) });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 20,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2021, 10, 14, 11, 39, 45, 807, DateTimeKind.Utc).AddTicks(9791), new DateTime(2022, 1, 28, 11, 39, 45, 807, DateTimeKind.Utc).AddTicks(9791) });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 21,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2021, 10, 14, 11, 39, 45, 807, DateTimeKind.Utc).AddTicks(9792), new DateTime(2022, 1, 18, 11, 39, 45, 807, DateTimeKind.Utc).AddTicks(9792) });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 22,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2021, 10, 14, 11, 39, 45, 807, DateTimeKind.Utc).AddTicks(9793), new DateTime(2021, 12, 28, 11, 39, 45, 807, DateTimeKind.Utc).AddTicks(9794) });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 23,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2021, 10, 14, 11, 39, 45, 807, DateTimeKind.Utc).AddTicks(9794), new DateTime(2022, 1, 29, 11, 39, 45, 807, DateTimeKind.Utc).AddTicks(9795) });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 24,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2021, 10, 14, 11, 39, 45, 807, DateTimeKind.Utc).AddTicks(9796), new DateTime(2022, 3, 8, 11, 39, 45, 807, DateTimeKind.Utc).AddTicks(9796) });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 25,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2021, 10, 14, 11, 39, 45, 807, DateTimeKind.Utc).AddTicks(9797), new DateTime(2022, 3, 22, 11, 39, 45, 807, DateTimeKind.Utc).AddTicks(9797) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ExpenseClaimDetails",
                keyColumn: "ExpenseClaimDetailId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 3, 23, 11, 38, 36, 963, DateTimeKind.Utc).AddTicks(2804));

            migrationBuilder.UpdateData(
                table: "ExpenseClaimDetails",
                keyColumn: "ExpenseClaimDetailId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 3, 23, 11, 38, 36, 963, DateTimeKind.Utc).AddTicks(2808));

            migrationBuilder.UpdateData(
                table: "ExpenseClaimDetails",
                keyColumn: "ExpenseClaimDetailId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 3, 23, 11, 38, 36, 963, DateTimeKind.Utc).AddTicks(2809));

            migrationBuilder.UpdateData(
                table: "ExpenseClaimDetails",
                keyColumn: "ExpenseClaimDetailId",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2022, 3, 23, 11, 38, 36, 963, DateTimeKind.Utc).AddTicks(2810));

            migrationBuilder.UpdateData(
                table: "ExpenseClaimDetails",
                keyColumn: "ExpenseClaimDetailId",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2022, 3, 23, 11, 38, 36, 963, DateTimeKind.Utc).AddTicks(2811));

            migrationBuilder.UpdateData(
                table: "ExpenseClaimDetails",
                keyColumn: "ExpenseClaimDetailId",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2022, 3, 23, 11, 38, 36, 963, DateTimeKind.Utc).AddTicks(2813));

            migrationBuilder.UpdateData(
                table: "ExpenseClaims",
                keyColumn: "ExpenseClaimId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 3, 23, 11, 38, 36, 963, DateTimeKind.Utc).AddTicks(2709));

            migrationBuilder.UpdateData(
                table: "ExpenseClaims",
                keyColumn: "ExpenseClaimId",
                keyValue: 2,
                columns: new[] { "Date", "EmployeeId" },
                values: new object[] { new DateTime(2022, 3, 23, 11, 38, 36, 963, DateTimeKind.Utc).AddTicks(2715), 1 });

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
        }
    }
}
