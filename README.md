# Admin Dashboard – Student Complaint Tracking System

CS312 – Modern Development Tools · Project #10 (تسجيل الشكاوى ومتابعة حالتها)

This repository contains the **Admin Dashboard** screen of the Student Complaint Tracking System, built with C# and Windows Forms (.NET 8).

## What's on the screen

- **Sidebar:** "Student Complaints" title, Dashboard, New Complaint and My Complaints buttons, and Logout at the bottom
- **Header:** "Welcome Back, Admin!" with a short subtitle
- **Stats box:** Resolved, Pending and Total Complaints, each with an icon and a number
- **Recent Complaints:** a table with ComplaintID, Title, Category, Date and Status

This stage is the GUI only. The numbers and table rows are sample data (see `LoadSampleRows()` in `AdminDashboardForm.cs`), and the buttons are not connected yet.

## How to run

1. Install **Visual Studio 2022** with the **.NET desktop development** workload (includes .NET 8).
2. Open `StudentComplaintTracking.sln`.
3. Press **F5**. The Admin Dashboard window opens.

The form opens in the Visual Studio **Designer**, so it can be edited visually.

## Project structure

```
StudentComplaintTracking.sln
src/StudentComplaintTracking/
├── Program.cs                          entry point (opens AdminDashboardForm)
└── Forms/
    ├── AdminDashboardForm.cs           code
    └── AdminDashboardForm.Designer.cs  layout (edit in the Designer)
```
