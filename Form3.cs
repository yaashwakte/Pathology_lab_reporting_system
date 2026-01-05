CLASS TestProcessingForm

  ON Load:
    Load patient context
    Fetch assigned tests

  EVENT OnTestResultUpdate():
    Validate result values
    Save test results
    Mark test as completed

  FUNCTION CalculateDerivedValues():
    Apply lab-specific formulas
    Normalize values if required

END CLASS
