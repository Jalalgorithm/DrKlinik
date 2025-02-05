# Dr Klinik - Heart Disease Detection System

## Overview
Dr Klinik is a **Blazor WebAssembly** application designed for **heart disease detection** using a machine learning model. The system allows users, particularly doctors and medical professionals, to input patient health parameters and receive a predictive diagnosis regarding heart disease. It leverages an AI-powered model integrated with a **Flask API** to provide accurate assessments.

## Features
- **User Authentication**: Secure login and signup functionality.
- **Heart Disease Prediction**: Takes patient parameters and predicts the likelihood of heart disease.
- **Interactive UI**: A modern, responsive Blazor WebAssembly interface.
- **Machine Learning Integration**: Uses a pre-trained RandomForestClassifier model via a Flask API.
- **Data Visualization**: Presents results with graphical insights.
- **Email Notifications**: Sends diagnostic results to users via email.

## System Architecture
1. **Blazor WebAssembly Frontend** - Provides an interactive user interface.
2. **.NET Web API Backend** - Manages authentication, data processing, and API consumption.
3. **Flask API** - Hosts the heart disease prediction model.
4. **Machine Learning Model** - A RandomForestClassifier model trained for heart disease detection.

## Technologies Used
- **Frontend**: Blazor WebAssembly, Bootstrap 5
- **Backend**: ASP.NET Core Web API
- **Machine Learning**: Python, Flask, Scikit-learn
- **Database**: SQL Server
- **Authentication**: JWT (JSON Web Token)
- **Email Service**: MailKit

## Installation Guide
### Prerequisites
Ensure you have the following installed:
- .NET SDK
- Node.js (for npm dependencies if required)
- Python (for running the Flask API)
- SQL Server
- Visual Studio / VS Code

### Steps
1. **Clone the Repository**:
   ```sh
   git clone https://github.com/your-repo/dr-klinik.git
   cd dr-klinik
   ```
2. **Backend Setup (ASP.NET Core API)**:
   - Navigate to the API project folder.
   - Install dependencies:
     ```sh
     dotnet restore
     ```
   - Run the API:
     ```sh
     dotnet run
     ```
3. **Frontend Setup (Blazor WebAssembly)**:
   - Navigate to the Blazor project folder.
   - Run the application:
     ```sh
     dotnet run
     ```
4. **Flask API Setup (Machine Learning Model)**:
   - Navigate to the Flask API folder.
   - Install dependencies:
     ```sh
     pip install -r requirements.txt
     ```
   - Run the Flask API:
     ```sh
     python app.py
     ```

## Usage
1. **Login / Register** to access the system.
2. **Enter Patient Details** such as age, cholesterol level, blood pressure, etc.
3. **Submit for Analysis** to receive heart disease prediction.
4. **View Results & Insights** with a detailed explanation of the diagnosis.
5. **Download or Email Report** for future reference.

## API Endpoints
| Endpoint | Method | Description |
|----------|--------|-------------|
| `/api/auth/login` | POST | User login |
| `/api/auth/register` | POST | User registration |
| `/api/predict` | POST | Submit patient data for prediction |
| `/api/results` | GET | Fetch previous diagnoses |

## Contributing
We welcome contributions! To contribute:
1. Fork the repository.
2. Create a new feature branch.
3. Commit your changes.
4. Submit a pull request.

## License
Dr Klinik is licensed under the **MIT License**.

## Contact
For support or inquiries, reach out via:
- **Email**: temitomzi@gmail.com
- **GitHub Issues**: https://github.com/jalalgorithm/dr-klinik/issues

