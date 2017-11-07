@ECHO OFF

REM Copy the database files to the site.
ROBOCOPY build/database/ src/Alloy.WebForms.Template/App_Data/ Alloy.mdf DefaultSiteContent.episerverdata /XC /XN /XO

EXIT /B %ERRORLEVEL%
