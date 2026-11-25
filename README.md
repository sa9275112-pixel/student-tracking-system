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

## ✅ Windows Forms Controls & Event Handling

Labels, TextBoxes, Buttons, ComboBoxes, CheckBox, LinkLabel, DataGridViews, Panels and TableLayoutPanels, with Click, SelectionChanged, TextChanged, SelectedIndexChanged, Paint, Resize and KeyDown events. These handle navigation between all screens, form validation, the file browser, filters and selecting a complaint to update.

## 🎨 GDI+ / Graphics / Visualization

All custom drawing is in `GdiHelpers.cs` (shared) plus a `SetupGraphics()` method in each screen.

| Screen | GDI+ features |
|---|---|
| Admin Dashboard | Donut chart (complaints by status), bar chart (by category), live summary cards, colored Status/Priority badges, **Ctrl+P** print preview |
| Manage Complaints | Status/Priority badges, status marker on the selected complaint, **Ctrl+P** print preview |
| Student Dashboard | Gradient sidebar, card icons and accents, "% resolved" progress ring, status badges |
| My Complaints | Status tracker on each card (Submitted → Pending → In Progress → Resolved), status-colored card edge |
| Submit Complaint | Card shadow, red outline on missing required fields, colored dots in the Priority list |
| Login / Admin Login | Gradient header and background, card shadow, selected-role underline |

**Techniques used:** `Paint` event and `Graphics`, `Invalidate()` redraws, `SolidBrush`, `LinearGradientBrush`, `Pen` (dash styles, round caps), `FillPie`, `DrawArc`, `FillEllipse`, `DrawLine(s)`, `FillRectangle`, `DrawString`, `GraphicsPath` (rounded shapes), owner-drawn controls (`CellPainting`, `DrawItem`), double buffering, and printing with `PrintDocument` + `PrintPreviewDialog`.

## 📁 Repository structure

```
StudentComplaintTracking_Complete/   ← the final project (open this)
├── StudentComplaintTracking.sln
├── WinFormsApp1.csproj
├── Program.cs                       entry point (opens LoginForm)
├── GdiHelpers.cs                    shared GDI+ drawing (charts, badges, tracker, printing)
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
