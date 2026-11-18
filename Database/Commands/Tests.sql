USE DVLD;
SELECT * FROM LocalDrivingLicenseApplications_View
SELECT * FROM Tests

SELECT * FROM LocalDrivingLicenseApplications
SELECT * FROM Applications WHERE ApplicationID = 111

SELECT * FROM dbo.TestAppointments_View

SELECT * FROM TestAppointments
SELECT COUNT(dbo.TestAppointments.TestTypeID) AS PassedTestCount
    FROM dbo.Tests INNER JOIN
	dbo.TestAppointments ON dbo.Tests.TestAppointmentID = dbo.TestAppointments.TestAppointmentID
                               
							   WHERE        (dbo.TestAppointments.LocalDrivingLicenseApplicationID = dbo.LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID) 
							   AND (dbo.Tests.TestResult = 1)) AS PassedTestCount, 