CLASS ReportsAndAnalyticsForm

  FLAGS:
    patientWise
    doctorWise
    labWise
    summaryMode
    rateListMode
    doctorListMode

  VARIABLES:
    startDate
    endDate
    selectedDoctor
    selectedLab

  ON Load:
    Load doctors into dropdown
    Load labs into dropdown
    Enable summary mode by default
    Disable advanced filters

  EVENT OnGenerateClick():

    IF summaryMode:
      Capture date range and filters

      IF no summary option selected:
        Show validation message
        RETURN

      IF doctorWise AND no doctor selected:
        Show validation message
        RETURN

      IF labWise AND no lab selected:
        Show validation message
        RETURN

      Open summary report viewer

    ELSE IF rateListMode:
      Resolve test category
      Open rate list report

    ELSE IF doctorListMode:
      Open doctor directory report

  FUNCTION LoadDropdownValues(source):
    Fetch values from configuration table
    Populate dropdown

  EVENT OnSummaryModeSelected():
    Enable summary filters
    Disable others

  EVENT OnRateListModeSelected():
    Enable rate category filters

  EVENT OnDoctorListModeSelected():
    Disable all filters

END CLASS
