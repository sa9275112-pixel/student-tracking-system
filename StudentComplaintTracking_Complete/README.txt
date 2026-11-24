Student Complaint Tracking System - combined project

Open StudentComplaintTracking.sln in Visual Studio.
Required workload: .NET desktop development.
Target framework: .NET 10 (Windows).

Startup form: LoginForm (Program.cs).

Student flow:
1. Select Student.
2. Enter a non-empty Student ID and password.
3. Click Login to open StudentDashboard.

Important: the supplied source did not include a student authentication/database service.
The Login button therefore checks that both fields are filled, then opens the dashboard.
It does not verify whether the ID/password are valid.

Admin Login remains in the project. The Student Dashboard no longer displays
Admin Dashboard or Manage Complaints buttons, and the remaining sidebar buttons
have been repositioned.
