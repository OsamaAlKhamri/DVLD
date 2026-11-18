USE DVLD;

SELECT * FROM Tests
SELECT * FROM LicenseClasses

SELECT * FROM People

SELECT * FROM DetainedLicenses 

SELECT Top 1 *, Found=1 FROM DetainedLicenses WHERE LicenseID = 27 AND IsReleased = 0 ORDER BY DetainDate DESC
SELECT * FROM LocalDrivingLicenseApplications
SELECT * FROM Licenses
DELETE FROM WHERE Licenses.LicenseID = 31
UPDATE Applications SET ApplicationStatus=1 WHERE Applications.ApplicationID = 149

SELECT Licenses.LicenseID
    FROM Licenses INNER JOIN Drivers ON Licenses.DriverID = Drivers.DriverID 
    WHERE  Licenses.LicenseClass = 6
        AND Drivers.PersonID = 1029
        AND IsActive=1;

SELECT * FROM Licenses
LEFT JOIN LocalDrivingLicenseApplications as ld ON ld.ApplicationID = Licenses.ApplicationID 
LEFT JOIN Applications ON Applications.ApplicationID = ld.ApplicationID 



SELECT * FROM Applications WHERE ApplicationID=149
SELECT * FROM ApplicationTypes
SELECT * FROM Applications
SELECT * FROM Applications
SELECT * FROM Applications

e
SELECT ld.LicenseClassID,l.PaidFees, Applications.PaidFees FROM Licenses as l
INNER JOIN LocalDrivingLicenseApplications as ld ON ld.ApplicationID = l.ApplicationID 
INNER JOIN Applications ON Applications.ApplicationID = ld.ApplicationID 

SELECT * FROM Drivers

SELECT  top 1 Tests.TestID, 
	                Tests.TestAppointmentID, Tests.TestResult, 
	                Tests.Notes, Tests.CreatedByUserID, Applications.ApplicantPersonID
	                FROM            LocalDrivingLicenseApplications INNER JOIN
								                Tests INNER JOIN
								                TestAppointments ON Tests.TestAppointmentID = TestAppointments.TestAppointmentID 
								                ON LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = TestAppointments.LocalDrivingLicenseApplicationID 
								                INNER JOIN
								                Applications ON LocalDrivingLicenseApplications.ApplicationID = Applications.ApplicationID
	                WHERE        (Applications.ApplicantPersonID = 1029) 
			                AND (LocalDrivingLicenseApplications.LicenseClassID = 6)
			                AND ( TestAppointments.TestTypeID=2)
	                ORDER BY Tests.TestAppointmentID DESC

