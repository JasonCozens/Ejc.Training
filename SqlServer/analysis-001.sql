USE [MercuryII]

/*
	Get help on one stored procedure.
*/
EXEC sp_helptext ChangeDriverPin

/*
    Similar to sp_helptext but reutrns single text object.
*/
SELECT OBJECT_DEFINITION (OBJECT_ID(N'ChangeDriverPin'))

/*
    Get text for all stored procedures.
*/
SELECT name, OBJECT_DEFINITION (OBJECT_ID(name)) FROM sysobjects
WHERE Type = 'P'

