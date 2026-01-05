CLASS MainDashboardForm

  ON Load:
    Initialize UI
    Load today’s patient records
    Enable / disable features based on user role

  FUNCTION LoadTodayPatients():
    Fetch patient data for current date
    Bind data to grid
    Update counters and stats

  EVENT OnPatientSelected(patientId):
    Store selected patient context
    Enable actions (edit, print, report)

  EVENT OnOpenReport():
    Open ReportForm with selected patientId

  EVENT OnSettingsClick():
    Open AdminSettingsForm

END CLASS
