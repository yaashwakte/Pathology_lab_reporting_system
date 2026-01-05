CLASS WhatsAppDeliveryForm

  VARIABLE patientId
  VARIABLE defaultPhoneNumber
  VARIABLE sendReportMode
  VARIABLE sendReceiptMode

  CONSTRUCTOR(patientId, phoneNumber):
    Store values
    Initialize UI

  ON Load:
    Pre-fill phone number
    Enable report mode by default
    Load saved contact numbers

  EVENT OnSendClick():
    IF phone number is empty:
      Show validation message
      RETURN

    Show loading cursor

    IF sendReportMode:
      Generate report PDF
    ELSE IF sendReceiptMode:
      Generate receipt PDF

    Trigger WhatsApp message with attachment

  FUNCTION GenerateReportPDF():
    Launch report form in background
    Export report to PDF

  FUNCTION GenerateReceiptPDF():
    Launch billing form in background
    Export receipt to PDF

  FUNCTION TriggerWhatsApp(phoneNumber):
    Open WhatsApp message intent

  EVENT OnSavePhoneNumber():
    Validate input
    Persist number
    Refresh contact list

END CLASS
