using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SalesWebMvc.Migrations
{
    /// <inheritdoc />
    public partial class pop2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData("department", "(Id, Name)", ["(1, 'Computers'),(2, 'Electronics'),(3, 'Fashion'),(4, 'Books');"]);
            migrationBuilder.InsertData("seller","(Id, Name, Email, Birthdate, BaseSalary, BepartmentId)",["(1, 'Bob Brown', 'bob@gmail.com', '1998-04-21', 1000.0, 1),(2, 'Maria Green', 'maria@gmail.com', '1979-12-31', 3500.0, 2),(3, 'Alex Grey', 'alex@gmail.com', '1988-01-15', 2200.0, 1)(4, 'Martha Red', 'martha@gmail.com', '1993-11-30', 3000.0, 4),(5, 'Donald Blue', 'donald@gmail.com', '2000-01-09', 4000.0, 3),(6, 'Alex Pink', 'bob@gmail.com', '1997-03-04', 3000.0, 2);"]);
            migrationBuilder.InsertData("salesRecord", "(Id, SaleDate, Amount, Status, sellerId)", ["(1, '2018-09-25', 11000.0, 'Billed', 1),(2, '2018-09-04', 7000.0, 'Billed', 5),(3, '2018-09-13', 4000.0, 'Canceled', 4),(4, '2018-09-01', 8000.0, 'Billed', 1),(5, '2018-09-21', 3000.0, 'Billed', 3),(6, '2018-09-15', 2000.0, 'Billed', 1),(7, '2018-09-28', 13000.0, 'Billed', 2),(8, '2018-09-11', 4000.0, 'Billed', 4),(9, '2018-09-14', 11000.0, 'Pending', 6),(10, '2018-09-07', 9000.0, 'Billed', 6),(11, '2018-09-13', 6000.0, 'Billed', 2),(12, '2018-09-25', 7000.0, 'Pending', 3),(13, '2018-09-29', 10000.0, 'Billed', 4),(14, '2018-09-04', 3000.0, 'Billed', 5),(15, '2018-09-12', 4000.0, 'Billed', 1),(16, '2018-10-05', 2000.0, 'Billed', 4),(17, '2018-10-01', 12000.0, 'Billed', 1),(18, '2018-10-24', 6000.0, 'Billed', 3),(19, '2018-10-22', 8000.0, 'Billed', 5),(20, '2018-10-15', 8000.0, 'Billed', 6),(21, '2018-10-17', 9000.0, 'Billed', 2),(22, '2018-10-24', 4000.0, 'Billed', 4),(23, '2018-10-19', 11000.0, 'Canceled', 2),(24, '2018-10-12', 8000.0, 'Billed', 5),(25, '2018-10-31', 7000.0, 'Billed', 3),(26, '2018-10-06', 5000.0, 'Billed', 4),(27, '2018-10-13', 9000.0, 'Pending', 1),(28, '2018-10-07', 4000.0, 'Billed', 3),(29, '2018-10-23', 12000.0, 'Billed', 5),(30, '2018-10-12', 5000.0, 'Billed', 2);"]);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            
        }
    }
}
