#  NOTE:
#  This file contains architectural pseudocode only.
#  Core business logic and data access layers are
#  intentionally omitted due to commercial licensing.

# Pathology Lab Management System

A comprehensive Windows-based Laboratory Information Management System (LIMS) designed specifically for pathology laboratories to streamline operations, manage patient records, and generate detailed clinical reports efficiently.

## Overview

This system is built with C# and SQL Server, providing an intuitive interface for managing patient samples, conducting tests, recording results, and generating professional laboratory reports. It supports multi-lab operations with role-based access and various reporting capabilities.

## Key Features

### 🏥 Patient Management
- Patient registration with demographic details
- Unique patient ID generation
- Sample tracking with collection information
- Specimen type management
- Multiple referring physician support
- Care lab assignment and routing

### 🧪 Laboratory Operations
- **Test Management**: Define, organize, and manage laboratory tests by category
- **Test Categories**: 
  - Biochemistry
  - Hemogram
  - Hematology
  - Hormones
  - Culture & Microbiology (with organism isolation tracking)
  - PAP Smear (Gynecology)
- **Test Configuration**: 
  - Test parameters and reference ranges
  - Specimen requirements
  - Testing methods and kits
  - Quality control values
- **Sample Management**: Specimen tracking, collection time recording

### 📊 Results & Reporting
- Multi-parameter test result entry
- Automatic reference range validation
- Crystal Reports integration for professional reports
- Multiple report templates: 
  - Patient individual reports
  - Summary reports (patient-wise, doctor-wise, lab-wise)
  - Rate lists by test category
  - Physician directories
- Customizable blank reports
- E-signature support for authorized reports
- Graph visualization in test results
- Print and PDF export capabilities

### 📱 Digital Communication
- WhatsApp integration for report/receipt sharing
- Automated contact management
- Mobile-friendly report distribution

### 🔐 Security & Access Control
- User authentication with password protection
- Role-based access (Admin, Technician, Doctor)
- Dev mode for administrators
- Database integrity checks

### ⚙️ System Administration
- Lab configuration management
- Test pricing and billing
- Physician and care lab maintenance
- Database maintenance tools
- System license and expiry management
- NHAPI and ASTM parsing support
- Authorized deletion with audit trail

### 📈 Advanced Features
- Multi-lab support and management
- Comprehensive logging and audit trails
- Database reseed utilities
- System configuration persistence
- License activation and validation

## Technical Architecture

### Technology Stack
- **Language**: C# (.NET Framework)
- **UI Framework**: Windows Forms with Krypton Toolkit
- **Database**: SQL Server LocalDB
- **Reporting Engine**: Crystal Reports
- **Integration**: WhatsApp API, NHAPI, ASTM

### Project Structure
```
CLIS. sln                          # Main solution file
├── CLIS/                         # Main application project
│   ├── Form1.cs                 # Main dashboard
│   ├── Form2.cs                 # Test selection interface
│   ├── Form3.cs                 # Test master maintenance
│   ├── Form7.cs                 # Patient report viewer
│   ├── Form8.cs                 # System settings
│   ├── Form9.cs                 # Receipt generation
│   ├── Form12.cs                # WhatsApp integration
│   ├── Form13.cs                # Report parameters
│   ├── Form14.cs                # Summary reports
│   ├── Form17.cs                # Rate lists and directories
│   ├── Class1.cs                # Central data container
│   ├── Program.cs               # Application entry point
│   └── splashscreen.cs          # Splash screen
├── Krypton-master/              # Krypton UI toolkit
├── Setup/                       # Installer and setup files
└── packages/                    # NuGet and external dependencies
```

### Database
- **Database**: CLISDatabase.mdf (SQL Server LocalDB)
- **Key Tables**:
  - CLISPatientdb:  Patient records
  - CLISPatientTstTable: Patient-test associations
  - Refdrtable: Referring physicians
  - carelabtable: Care laboratory information
  - Test category tables (Biochemistry, Hematology, etc.)
  - whatsapptable: WhatsApp contact management

## System Requirements

- **OS**: Windows 7 or higher
- **Framework**: .NET Framework 4.5+
- **Database**: SQL Server 2012 or higher (LocalDB)
- **Memory**: Minimum 2GB RAM
- **Screen Resolution**: 1024x768 or higher
- **Report Folder**: C:\Rpt (for Crystal Reports)
- **System Data**: C:\SystemData (for configuration files)

## Configuration

### Initial Setup
1. **Lab Configuration**: Set lab name in `C:\SystemData\config.txt`
2. **Security**: Configure admin password in `C:\SystemData\key.txt`
3. **License**: License file stored in `C:\SystemData\lib. txt`
4. **Reports**: Place Crystal Report files in `C:\Rpt\`

### Feature Toggles
- **Graphs**: Enable/disable graphs in reports
- **E-Signature**: Optional electronic signature support
- **NHAPI**: HL7 NHAPI integration
- **ASTM Parsing**: Instrument interface support
- **Authorized Delete**: Enhanced delete permissions

## Usage Workflow

1. **Patient Registration**:  Add patient details and sample information
2. **Test Selection**: Choose required tests from organized categories
3. **Results Entry**: Enter test parameters and values
4. **Report Generation**: Generate customized reports for referring physicians
5. **Report Delivery**: Print, export as PDF, or share via WhatsApp
6. **Archival**: Store reports and maintain audit trails

## Special Features

### Multi-Lab Management
- Switch between different care labs
- Lab-wise report summaries
- Separate test rate maintenance per lab

### Specialized Test Support
- **PAP Smear Tests**: Case numbers, specimen types, diagnoses, clinical advice
- **Culture Tests**: Organism isolation tracking, colony counts, antibiotics sensitivity
- **Hormonal Tests**:  Specific reference ranges and interpretation

### Reporting Flexibility
- Multiple report formats and templates
- Blank report support for custom configurations
- E-signature integration for authorized reports
- Graph visualization for trending data

## Installation & Deployment

1. Extract the CLIS.sln project
2. Open in Visual Studio
3. Build the solution
4. Run the installer from the Setup folder
5. Configure system paths and database
6. Set up license file for activation
7. Place Crystal Report templates in C:\Rpt\

## Support & Maintenance

- Automatic license expiry validation
- Database integrity check tools
- Development mode for troubleshooting
- Admin tools for database maintenance
- System configuration backup

## Contributing

Contributions are welcome!  Please feel free to submit pull requests or open issues for any bugs or feature requests.

## Installation
Import the project into Visual Studio
Requires SQL Server LocalDB 2016, Crystal Report for VS


**Version**:  1.0.0  
**Last Updated**: 2026-01-05
