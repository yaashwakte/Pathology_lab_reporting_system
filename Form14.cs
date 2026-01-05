CLASS SummaryAnalyticsManager

    PROPERTIES:
        - DateRange (Start, End)
        - FilterType (PatientWise, DoctorWise, LabWise)
        - SortOrder (Date or SampleID)

    PROCEDURE BuildAndDisplayReport():
        1. Select BaseQuery Template (Joins PatientTable with DoctorTable)
        
        2. APPLY FILTERS:
           IF DoctorWise: Append "WHERE Doctor = @selectedDoctor"
           IF LabWise:    Append "WHERE Lab = @selectedLab"
           
        3. APPLY DATE RANGE:
           Append "AND Date BETWEEN @start AND @end"
           
        4. APPLY SORTING:
           IF SortBySample: Append "ORDER BY SampleID"
           ELSE:            Append "ORDER BY Date"

        5. EXECUTE Query using Parameterized SQL (to prevent injection)
        6. MAP Results to "summaryreport.rpt"
        7. UPDATE Report TextObjects (Show DateRange in Header)