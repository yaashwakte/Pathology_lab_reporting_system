CLASS ListReportManager

    PROPERTIES:
        - IsRateList (Boolean)
        - IsPhysicianList (Boolean)
        - CategoryName (String)

    PROCEDURE OnLoad():
        INITIALIZE ReportEngine
        
        IF IsRateList:
            DATA = FetchRateData(CategoryName)
            LOAD "ratelist.rpt"
            BIND DATA to Report
            SET HeaderText = CategoryName
        
        ELSE IF IsPhysicianList:
            DATA = FetchPhysicianDirectory()
            LOAD "physicianlist.rpt"
            BIND DATA to Report

    FUNCTION FetchRateData(category):
        EXECUTE SQL: "SELECT Test, Charge FROM Rates WHERE Category = @category"
        RETURN ResultTable

    FUNCTION FetchPhysicianDirectory():
        EXECUTE SQL: "SELECT Name FROM Doctors"
        RETURN ResultTable