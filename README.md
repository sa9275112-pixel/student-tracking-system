# Student Complaint Tracking System

CS312 – Modern Development Tools · Project #10 (تسجيل الشكاوى ومتابعة حالتها)

A Windows Forms desktop app (C#, .NET 8) where students submit complaints and track their status, and admins review and manage them.

## ▶️ How to open and run

1. Install **Visual Studio 2022** with the **.NET desktop development** workload.
2. Open the folder **`StudentComplaintTracking_Complete`**.
3. Double-click **`StudentComplaintTracking.sln`** inside it.
4. Press **F5**. The app starts on the **Login** screen.

> ⚠️ Open the `.sln` inside `StudentComplaintTracking_Complete`. The `archive/` folder holds older versions and is not the final project.

## 🧭 Screens and navigation

```
Login
├── Student ──► Student Dashboard
│                ├── Submit Complaint
│                └── My Complaints
└── Admin ────► Admin Login ──► Admin Dashboard
                                  └── Manage Complaints
```

**Note:** there is no database yet. Both login screens only check that the fields are filled in; they do not verify the ID or password.

## 📁 Repository structure

```
StudentComplaintTracking_Complete/   ← the final project (open this)
├── StudentComplaintTracking.sln
├── WinFormsApp1.csproj
├── Program.cs                       entry point (opens LoginForm)
├── studentcomplaint.*               Login screen
├── AdminLoginForm.*                 Admin login
├── StudentDashboard.*               Student dashboard
├── SubmitComplaintForm.*            Submit a complaint
├── MyComplaints.*                   Student's complaints
├── ManageComplaintsForm.*           Admin: manage complaints
├── forms1/AdminDashboardForm.*      Admin dashboard
├── Properties/, Resources/          resources and images
└── README.txt                       project notes

archive/                             older versions, kept for reference
```
