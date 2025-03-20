This project demonstrates how to send emails using the SMTP protocol with C# and .NET. The app reads SMTP configuration from an appsettings.json file and sends emails securely.

## Requirements
- .NET SDK (v9.0 or later)

- An SMTP server (e.g., Gmail)

- An App Password (if using Gmail with 2-step verification)

## Installation
1. Clone the repository:
   
   ```bash
   git clone https://github.com/Cyrille-18/EmailSenderWithCsharp.git

2. Install dependancies:
   
   ```bash
    dotnet restore

## Configurations
Create an appsettings.json file in the project root with the following content:
   ```bash
        {
        "EmailConfig": {
          "SmtpServer": "smtp.gmail.com",
          "SmtpPort": 587,
          "Email": "youremail@gmail.com",
          "AppPassword": "your App password"
        }
    }
