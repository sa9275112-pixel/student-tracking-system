# Student Complaint Tracking System – Admin Screens

CS312 – Modern Development Tools · Project #10 (تسجيل الشكاوى ومتابعة حالتها)

This repository contains the admin screens of the Student Complaint Tracking System, built with C# and Windows Forms (.NET 8): **Admin Dashboard** and **Manage Complaints**.

## Screens

Both screens share the same sidebar: Dashboard, Submit Complaints, My Complaints, Admin Dashboard, Manage Complaints, and Logout at the bottom. **Manage Complaints** and **Admin Dashboard** in the sidebar switch between the two screens.

### Admin Dashboard (`Forms/AdminDashboardForm`)
- Summary cards: Total complaints, Open / New, In progress, Resolved
- Chart areas: Complaints by Status, Complaints by Category
- Recent Complaints table: ID, Title, Student, Category, Status, Priority, Submitted

### Manage Complaints (`Forms/ManageComplaintsForm`)
- Filters: search box, Status, Category, Priority, with Search and Clear
- All Complaints table: ID, Title, Student, Category, Status, Priority, Assigned To, Submitted
- Update Complaint panel: shows the selected complaint, then Status, Assign to, Priority, Response to student, Notify the student, Save Changes and Delete Complaint

This stage is the GUI only. The tables show sample rows, the cards show 0, the chart areas are empty, and Search, Save Changes and Delete Complaint are not connected yet.

## How to run

1. Install **Visual Studio 2022** with the **.NET desktop development** workload (includes .NET 8).
2. Open `StudentComplaintTracking.sln`.
3. Press **F5**. The Admin Dashboard window opens. Click **Manage Complaints** in the sidebar to open the second screen.

Each form opens in the Visual Studio **Designer**, so it can be edited visually.

## Project structure

```
StudentComplaintTracking.sln
src/StudentComplaintTracking/
├── Program.cs                          entry point (opens AdminDashboardForm)
└── Forms/
    ├── AdminDashboardForm.cs / .Designer.cs     Admin Dashboard
    ├── ManageComplaintsForm.cs / .Designer.cs   Manage Complaints
    └── SidebarStyle.cs                          shared sidebar gradient
```
