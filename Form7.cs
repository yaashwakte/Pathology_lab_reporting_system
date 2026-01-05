CLASS ReportViewerForm

  CONSTRUCTOR(patientId):
    Store patientId
    Attach custom print handler

  ON Load:
    Configure report viewer
    Select report template based on system state
    Fetch report dataset
    Inject dynamic parameters
    Render report in viewer

  EVENT OnPrint():
    Update patient status to "Printed"
    Notify dashboard to refresh

  FUNCTION BuildReportData():
    IF special mode enabled:
      Fetch extended dataset
    ELSE:
      Fetch filtered dataset
    RETURN dataset

  FUNCTION ExportReportAsPDF():
    Load PDF report template
    Bind dataset
    Export to predefined folder

END CLASS
