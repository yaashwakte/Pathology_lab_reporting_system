CLASS PatientRegistrationForm

  ON Load:
    Prepare input fields
    Load dropdown values (tests, doctors, categories)

  EVENT OnSavePatient():
    Validate input fields
    Generate unique patient ID
    Save patient master record
    Save associated test records
    Show success confirmation

  FUNCTION ValidateInputs():
    Ensure mandatory fields are present
    Ensure data formats are correct

END CLASS
