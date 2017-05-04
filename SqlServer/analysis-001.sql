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

/*
    Get the server info.
*/
EXEC sp_server_info

/*
	List of databases with size.
*/
EXEC sp_databases

/*
    Details about a table
*/
EXEC sp_statistics Audit

/*
    List of tables in database.
*/
EXEC sp_tables

/*
    Not sure about this.
*/
EXEC sp_autostats Audit

/*
    Last time tables were modified.
	Structure was changed.
*/
SELECT name, [modify_date] FROM sys.tables