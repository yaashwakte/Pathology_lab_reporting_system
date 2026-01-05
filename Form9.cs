CLASS BillingReceiptForm

  VARIABLE patientId

  CONSTRUCTOR(patientId):
    Store patientId
    Initialize UI

  ON Load:
    Configure report viewer (fullscreen, toolbar enabled)
    Load billing report template
    Bind report data
    Inject lab metadata
    Render report

  FUNCTION BuildBillingDataset():
    Fetch billing details for patientId
    Return tabular dataset

  FUNCTION SaveReceiptAsPDF():
    Load billing report template
    Bind billing dataset
    Export report as PDF
    Close for
