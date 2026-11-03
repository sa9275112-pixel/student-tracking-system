# Admin Dashboard – Student Complaint Tracking System

CS312 – Modern Development Tools · Project #10 (تسجيل الشكاوى ومتابعة حالتها)

This repository contains the **Admin Dashboard** screen of the Student Complaint Tracking System, built with C# and Windows Forms (.NET 8).

## What's on the screen

- **Sidebar:** Dashboard, Submit Complaints, My Complaints, Admin Dashboard (current page), Manage Complaints, and Logout at the bottom
- **Summary cards:** Total complaints, Open / New, In progress, Resolved
- **Chart areas:** Complaints by Status, Complaints by Category
- **Recent Complaints:** a table with ID, Title, Student, Category, Status, Priority and Submitted

This stage is the GUI only: the numbers show 0, the chart areas are empty, the table has no rows and the sidebar buttons are not connected yet.

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
