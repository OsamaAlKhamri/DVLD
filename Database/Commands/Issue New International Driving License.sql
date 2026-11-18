USE DVLD;


SELECT * FROM PEOPLE
WHERE PersonID = 1029

SELECT l.LicenseID, l.ApplicationID, lc.ClassName, l.IssueDate, l.ExpirationDate, l.IsActive, l.PaidFees FROM Licenses as l
INNER JOIN LicenseClasses as lc
ON lc.LicenseClassID = l.LicenseClass
INNER JOIN Drivers as d
ON l.DriverID = d.DriverID
INNER JOIN People as p
ON p.PersonID = d.PersonID
WHERE d.PersonID = 1029

SELECT * FROM Drivers WHERE PersonID = 1029

SELECT * FROM LocalDrivingLicenseApplications where ApplicationID = 129

SELECT l.LicenseID, l.ApplicationID, lc.ClassName, l.IssueDate, l.ExpirationDate, l.IsActive FROM Licenses as l
                INNER JOIN LicenseClasses as lc
                ON lc.LicenseClassID = l.LicenseClass
                WHERE l.DriverID = @DriverID
				ORDER BY l.IssueDate, l.IsActive DESC

SELECT     
    Licenses.LicenseID,
    ApplicationID,
	LicenseClasses.ClassName, Licenses.IssueDate, 
	Licenses.ExpirationDate, Licenses.IsActive
    FROM Licenses INNER JOIN
        LicenseClasses ON Licenses.LicenseClass = LicenseClasses.LicenseClassID
    where DriverID=15
    Order By IsActive Desc, ExpirationDate Desc


SELECT * FROM Applications
WHERE ApplicationID = 129

SELECT * FROM Drivers WHERE DriverID = 16
SELECT * FROM Licenses

SELECT InternationalLicenseID, ApplicationID, IssuedUsingLocalLicenseID, IssueDate, 
                ExpirationDate, IsActive FROM InternationalLicenses
                WHERE DriverID = 15
				ORDER BY IssueDate, IsActive DESC



				SELECT * FROM Applications WHERE ApplicationID = 129
				SELECT * FROM LocalDrivingLicenseApplications WHERE ApplicationID = 129


SELECT * FROM Licenses 
SELECT * FROM Applications
SELECT * FROM InternationalLicenses 
WHERE IssuedUsingLocalLicenseID = 24
SELECT * , IssuedUsingLocalLicenseID FROM InternationalLicenses
SELECT * FROM Drivers
WHERE PersonID = 1032
SELECT * FROM Applications