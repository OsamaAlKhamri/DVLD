USE DVLD;

SELECT * FROM People

SELECT * FROM Applications

SELECT * FROM Licenses

SELECT * FROM Drivers

SELECT * FROM ApplicationTypes

SELECT * FROM InternationalLicenses

SELECT * FROM LocalDrivingLicenseApplications

SELECT * FROM LicenseClasses
SELECT ActiveApplicationID=Applications.ApplicationID  
                            From
                            Applications INNER JOIN
                            LocalDrivingLicenseApplications ON Applications.ApplicationID = LocalDrivingLicenseApplications.ApplicationID
                            WHERE ApplicantPersonID = 1025
                            and ApplicationTypeID=1
							and LocalDrivingLicenseApplications.LicenseClassID = 3
                            and ApplicationStatus=1

SELECT Licenses.LicenseID
        FROM Licenses INNER JOIN Drivers ON Licenses.DriverID = Drivers.DriverID 
        WHERE  Licenses.LicenseClass = 3
            AND Drivers.PersonID = 1025
            AND IsActive=1;


SELECT * FROM Licenses

SELECT * FROM LocalDrivingLicenseApplications_View

SELECT * FROM Drivers


SELECT * FROM LocalDrivingLicenseFullApplications_View
WHERE ApplicationStatus in (1, 3) and ApplicantPersonID=1025

SELECT * FROM LocalDrivingLicenseFullApplications_View
WHERE ApplicationStatus in (1, 3) and ApplicantPersonID=1032 and LicenseClassID=1

SELECT ActiveApplicationID=Applications.ApplicationID  
                            From
                            Applications INNER JOIN
                            LocalDrivingLicenseApplications ON Applications.ApplicationID = LocalDrivingLicenseApplications.ApplicationID
                            WHERE ApplicantPersonID = 1032
                            and ApplicationTypeID=1
							and LocalDrivingLicenseApplications.LicenseClassID = 1
                            and ApplicationStatus=1


SELECT * FROM ApplicationTypes


SELECT LocalDrivingLicenseApplications.*
FROM     LocalDrivingLicenseApplications INNER JOIN
                  Applications ON LocalDrivingLicenseApplications.ApplicationID = Applications.ApplicationID INNER JOIN
                  ApplicationTypes ON Applications.ApplicationTypeID = ApplicationTypes.ApplicationTypeID
WHERE  Applications.ApplicantPersonID = 1029 and LocalDrivingLicenseApplications.LicenseClassID=1 and (Applications.ApplicationStatus = 1 OR
                  Applications.ApplicationStatus = 3)




 