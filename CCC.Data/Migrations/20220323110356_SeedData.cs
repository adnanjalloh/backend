using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CCC.Data.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumberOfDays",
                table: "Leaves");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "LeaveTypes",
                type: "character varying(32)",
                maxLength: 32,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(16)",
                oldMaxLength: 16,
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentId", "Title" },
                values: new object[,]
                {
                    { 1, "Develpment" },
                    { 2, "Hr" },
                    { 3, "Sales" },
                    { 4, "Support" }
                });

            migrationBuilder.InsertData(
                table: "LeaveTypes",
                columns: new[] { "LeaveTypeId", "Title" },
                values: new object[,]
                {
                    { 1, "Privilege Leave" },
                    { 2, "Earned Leave" },
                    { 3, "Annual Leave" },
                    { 4, "Casual Leave" },
                    { 5, "Sick Leave" },
                    { 6, "Maternity Leave" },
                    { 7, "Marriage Leave" },
                    { 8, "Paternity Leave" },
                    { 9, "Leave Without Pay" },
                    { 10, "Loss of Pay" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Address", "DepartmentId", "Email", "Name" },
                values: new object[,]
                {
                    { 1, "Test", 1, "Ahmed@ccc.com", "Ahmed" },
                    { 2, "Test", 2, "Mohmmed@ccc.com", "Mohmmed" },
                    { 3, "Test", 3, "Ali@ccc.com", "Ali" },
                    { 4, "Test", 4, "Sanaa@ccc.com", "Sanaa" },
                    { 5, "Test", 1, "Raghd@ccc.com", "Raghd" },
                    { 6, "Test", 2, "Saja@ccc.com", "Saja" },
                    { 7, "Test", 3, "Tamer@ccc.com", "Tamer" },
                    { 8, "Test", 4, "Nasim@ccc.com", "Nasim" },
                    { 9, "Test", 1, "Basil@ccc.com", "Basil" },
                    { 10, "Test", 2, "Marwa@ccc.com", "Marwa" },
                    { 11, "Test", 1, "Marwan@ccc.com", "Marwan" }
                });

            migrationBuilder.InsertData(
                table: "Leaves",
                columns: new[] { "LeaveId", "EmployeeId", "From", "LeaveTypeId", "Note", "To" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 3, 22, 11, 3, 56, 164, DateTimeKind.Utc).AddTicks(8180), 1, "Test note", new DateTime(2022, 3, 28, 11, 3, 56, 164, DateTimeKind.Utc).AddTicks(8186) },
                    { 2, 2, new DateTime(2022, 3, 13, 11, 3, 56, 164, DateTimeKind.Utc).AddTicks(8189), 2, "Test note", new DateTime(2022, 3, 21, 11, 3, 56, 164, DateTimeKind.Utc).AddTicks(8190) },
                    { 3, 3, new DateTime(2022, 3, 3, 11, 3, 56, 164, DateTimeKind.Utc).AddTicks(8191), 3, "Test note", new DateTime(2022, 3, 18, 11, 3, 56, 164, DateTimeKind.Utc).AddTicks(8192) },
                    { 4, 4, new DateTime(2022, 3, 19, 11, 3, 56, 164, DateTimeKind.Utc).AddTicks(8192), 4, "Test note", new DateTime(2022, 3, 15, 11, 3, 56, 164, DateTimeKind.Utc).AddTicks(8193) },
                    { 5, 5, new DateTime(2022, 3, 22, 11, 3, 56, 164, DateTimeKind.Utc).AddTicks(8194), 5, "Test note", new DateTime(2022, 3, 21, 11, 3, 56, 164, DateTimeKind.Utc).AddTicks(8194) },
                    { 6, 6, new DateTime(2022, 3, 31, 11, 3, 56, 164, DateTimeKind.Utc).AddTicks(8196), 6, "Test note", new DateTime(2022, 4, 8, 11, 3, 56, 164, DateTimeKind.Utc).AddTicks(8197) },
                    { 7, 7, new DateTime(2022, 3, 28, 11, 3, 56, 164, DateTimeKind.Utc).AddTicks(8198), 7, "Test note", new DateTime(2022, 4, 7, 11, 3, 56, 164, DateTimeKind.Utc).AddTicks(8198) },
                    { 8, 8, new DateTime(2022, 3, 22, 11, 3, 56, 164, DateTimeKind.Utc).AddTicks(8199), 8, "Test note", new DateTime(2022, 3, 17, 11, 3, 56, 164, DateTimeKind.Utc).AddTicks(8200) },
                    { 9, 1, new DateTime(2022, 3, 20, 11, 3, 56, 164, DateTimeKind.Utc).AddTicks(8200), 9, "Test note", new DateTime(2022, 3, 17, 11, 3, 56, 164, DateTimeKind.Utc).AddTicks(8201) },
                    { 10, 2, new DateTime(2021, 12, 13, 11, 3, 56, 164, DateTimeKind.Utc).AddTicks(8202), 10, "Test note", new DateTime(2022, 1, 3, 11, 3, 56, 164, DateTimeKind.Utc).AddTicks(8203) },
                    { 11, 3, new DateTime(2022, 1, 2, 11, 3, 56, 164, DateTimeKind.Utc).AddTicks(8203), 1, "Test note", new DateTime(2022, 1, 28, 11, 3, 56, 164, DateTimeKind.Utc).AddTicks(8204) },
                    { 12, 4, new DateTime(2021, 12, 23, 11, 3, 56, 164, DateTimeKind.Utc).AddTicks(8205), 2, "Test note", new DateTime(2022, 1, 30, 11, 3, 56, 164, DateTimeKind.Utc).AddTicks(8205) },
                    { 13, 5, new DateTime(2021, 12, 27, 11, 3, 56, 164, DateTimeKind.Utc).AddTicks(8206), 3, "Test note", new DateTime(2022, 1, 30, 11, 3, 56, 164, DateTimeKind.Utc).AddTicks(8206) },
                    { 14, 6, new DateTime(2022, 3, 9, 11, 3, 56, 164, DateTimeKind.Utc).AddTicks(8207), 4, "Test note", new DateTime(2022, 3, 17, 11, 3, 56, 164, DateTimeKind.Utc).AddTicks(8207) },
                    { 15, 11, new DateTime(2021, 12, 25, 11, 3, 56, 164, DateTimeKind.Utc).AddTicks(8208), 5, "Test note", new DateTime(2022, 2, 7, 11, 3, 56, 164, DateTimeKind.Utc).AddTicks(8208) },
                    { 16, 8, new DateTime(2022, 2, 7, 11, 3, 56, 164, DateTimeKind.Utc).AddTicks(8209), 6, "Test note", new DateTime(2022, 3, 1, 11, 3, 56, 164, DateTimeKind.Utc).AddTicks(8209) },
                    { 17, 9, new DateTime(2022, 1, 30, 11, 3, 56, 164, DateTimeKind.Utc).AddTicks(8210), 7, "Test note", new DateTime(2022, 2, 22, 11, 3, 56, 164, DateTimeKind.Utc).AddTicks(8211) },
                    { 18, 5, new DateTime(2021, 10, 24, 11, 3, 56, 164, DateTimeKind.Utc).AddTicks(8212), 8, "Test note", new DateTime(2022, 1, 2, 11, 3, 56, 164, DateTimeKind.Utc).AddTicks(8212) },
                    { 19, 4, new DateTime(2021, 10, 14, 11, 3, 56, 164, DateTimeKind.Utc).AddTicks(8213), 9, "Test note", new DateTime(2021, 12, 13, 11, 3, 56, 164, DateTimeKind.Utc).AddTicks(8214) },
                    { 20, 3, new DateTime(2021, 10, 14, 11, 3, 56, 164, DateTimeKind.Utc).AddTicks(8214), 10, "Test note", new DateTime(2022, 1, 28, 11, 3, 56, 164, DateTimeKind.Utc).AddTicks(8215) },
                    { 21, 2, new DateTime(2021, 10, 14, 11, 3, 56, 164, DateTimeKind.Utc).AddTicks(8216), 1, "Test note", new DateTime(2022, 1, 18, 11, 3, 56, 164, DateTimeKind.Utc).AddTicks(8216) },
                    { 22, 1, new DateTime(2021, 10, 14, 11, 3, 56, 164, DateTimeKind.Utc).AddTicks(8217), 2, "Test note", new DateTime(2021, 12, 28, 11, 3, 56, 164, DateTimeKind.Utc).AddTicks(8217) },
                    { 23, 7, new DateTime(2021, 10, 14, 11, 3, 56, 164, DateTimeKind.Utc).AddTicks(8218), 3, "Test note", new DateTime(2022, 1, 29, 11, 3, 56, 164, DateTimeKind.Utc).AddTicks(8218) },
                    { 24, 8, new DateTime(2021, 10, 14, 11, 3, 56, 164, DateTimeKind.Utc).AddTicks(8220), 4, "Test note", new DateTime(2022, 3, 8, 11, 3, 56, 164, DateTimeKind.Utc).AddTicks(8220) },
                    { 25, 10, new DateTime(2021, 10, 14, 11, 3, 56, 164, DateTimeKind.Utc).AddTicks(8221), 5, "Test note", new DateTime(2022, 3, 22, 11, 3, 56, 164, DateTimeKind.Utc).AddTicks(8221) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "LeaveTypes",
                keyColumn: "LeaveTypeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "LeaveTypes",
                keyColumn: "LeaveTypeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "LeaveTypes",
                keyColumn: "LeaveTypeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "LeaveTypes",
                keyColumn: "LeaveTypeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "LeaveTypes",
                keyColumn: "LeaveTypeId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "LeaveTypes",
                keyColumn: "LeaveTypeId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "LeaveTypes",
                keyColumn: "LeaveTypeId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "LeaveTypes",
                keyColumn: "LeaveTypeId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "LeaveTypes",
                keyColumn: "LeaveTypeId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "LeaveTypes",
                keyColumn: "LeaveTypeId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 4);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "LeaveTypes",
                type: "character varying(16)",
                maxLength: 16,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(32)",
                oldMaxLength: 32,
                oldNullable: true);

            migrationBuilder.AddColumn<double>(
                name: "NumberOfDays",
                table: "Leaves",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
