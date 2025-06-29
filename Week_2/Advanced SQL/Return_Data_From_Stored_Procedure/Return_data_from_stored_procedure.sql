CREATE PROCEDURE sp_CountEmployeesByDepartment
    @DepartmentID INT
AS
BEGIN
    SELECT 
        COUNT(*) AS TotalEmployees
    FROM 
        Employees
    WHERE 
        DepartmentID = @DepartmentID;
END;
GO  
----
Select * from Employees;
----
EXEC sp_CountEmployeesByDepartment @DepartmentID = 2;
