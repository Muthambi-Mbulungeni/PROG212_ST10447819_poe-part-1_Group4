# PROG6212 POE Part 1 - CMCS Prototype

This folder holds report content (400–500 words), UML description, and project plan to accompany the UI prototype.

## Design choices (summary)
ASP.NET Core MVC, non-functional UI prototype, pages for Lecturer, Coordinator, Manager. Database model includes User, Claim, ClaimLine, Document, Approval with clear relationships.

## UML (text outline)
- User (Id, FullName, Email, Role)
- Claim (Id, LecturerId, Month, Year, HourlyRate, TotalHours, Amount, Status)
- ClaimLine (Id, ClaimId, ActivityDescription, Hours)
- Document (Id, ClaimId, FileName, FilePath, UploadedAt)
- Approval (Id, ClaimId, ApproverId, Decision, Comment, DecisionAt)

Relations: User 1..* Claim; Claim 1..* ClaimLine; Claim 1..* Document; Claim 1..* Approval; User 1..* Approval as Approver.

## Project plan (weeks)
1) Requirements + UML, 2) Scaffold MVC, 3) Build mockups, 4) Finalize docs & commits.


